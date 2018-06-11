# import
from threading import Thread
import time
from bs4 import BeautifulSoup
import requests
import socket
from datetime import datetime
import RPi.GPIO as GPIO

# definitions
recv_data = ""
angles = ""
data = ""
loop = True
DIR = 20   # Direction GPIO Pin
STEP = 21  # Step GPIO Pin
delay = .0008

# Logging Code Block Begin
def error_decorator(error_func):
    def wrapper(*arg):
        print("ERROR: ", end="", file = logpad)
        return error_func(*arg)
    return wrapper

@error_decorator
def log(log_msg):
    print(str(datetime.now()) + "\t" + log_msg, file = logpad)

@error_decorator
def log_error(error_msg):
    print(str(datetime.now()) + "\t" + error_msg, file = logpad)
# Logging Code Block End

# Client Object Begin
class Client(object):
    def __init__(self,server_ip,port,buffer_size=1024,send_data="",recv_data=""):
        self.client_ip = socket.gethostbyname(socket.gethostname())
        self.server_ip = server_ip
        self.port = port
        self.buffer_size = buffer_size
        self.send_data = send_data
        self.recv_data = recv_data
        self.client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        print("Socket created")
        log("Socket created")

    def connect(self):
        while True:
            try:
                self.client_socket.connect((self.server_ip,self.port))
                print("Connection established")
                log("Connection established")
                break
            except TimeoutError:
                print("ERROR: Server is not responding")
                log_error("Server is not responding")
            except OSError:
                print("ERROR: No Connection found")
                log_error("No Connection found")

    def send(self,data):
        try:
            self.send_data = data
            self.client_socket.send(self.send_data)
            print("Sending Data: ", self.send_data)
            log("Sending Data: " + self.send_data)
        except:
            print("Error occured")

    def recv(self):
        try:
            self.recv_data = self.client_socket.recv(self.buffer_size)
            print("Receiving Data: ", self.recv_data)
            self.recv_data = str(self.recv_data)
            return self.recv_data
        except:
            print("Error")
            return "Error"

    def kill(self):
        self.client_socket.close()
        print("Socket closed")
        log("Socket closed")
# Client Object Begin

def send(send_data):
    try:
        bytes = str.encode(send_data)
        DuzceSocketClient.send(data = bytes)
        log("Transmitted Data: " + send_data)
    except:
        print("Error")

def liftbagON():
    try:
        requests.get("http://192.168.4.1/ac")
        log("Lift bag opened")
    except:
        print("Error")

def liftbagOFF():
    try:
        requests.get("http://192.168.4.1/kapa")
        log("Lift bag closed")
    except:
        print("Error")

def OBS_read():
    while True:
        try:
            html = requests.get("http://192.168.4.1")
            soup = BeautifulSoup(html.text,"lxml")
            tempImport = soup.find("h3")
            tempImport2 = str(tempImport)
            Import = tempImport2[4:-5]
            if "DATA" in Import:
                break
            send("OBS: " + Import)
            log("OBS: " + Import)
            time.sleep(0.2)
        except:
            print("Error")

def turn_valve(n):
    n = int(n * 200)
    for x in range(n):
        GPIO.output(STEP, GPIO.HIGH)
        time.sleep(delay)
        GPIO.output(STEP, GPIO.LOW)
        time.sleep(delay)

# setup
logpad = open("/home/pi/mate/log.txt", "w")
GPIO.setmode(GPIO.BCM)
GPIO.setup(DIR, GPIO.OUT)
GPIO.setup(STEP, GPIO.OUT)
GPIO.output(DIR, 1)
GPIO.setup(4, GPIO.OUT)
GPIO.output(4,GPIO.LOW)
DuzceSocketClient = Client(server_ip = '192.168.2.1', port = 1864)
DuzceSocketClient.connect()

# main loop
while True:
    recv_data = DuzceSocketClient.recv()
    print(recv_data)
    if(recv_data == "b'LiftbagiSalKanka'"):
        liftbagON()
    elif(recv_data == "b'LiftbagiKapaKanka'"):
        liftbagOFF()
    elif(recv_data == "b'OBSeBaglanKanka'"):
        OBS_read()
    elif('Turner' in recv_data): # Example: "b'Turner'Clock'0.5'"
        if('Clock' in recv_data):
            GPIO.output(4,GPIO.HIGH) # Power ON
            GPIO.output(DIR, 1)
            turn_valve(float(recv_data.split("'")[2].split("\"")[0]))
            GPIO.output(4,GPIO.LOW) # Power OFF
        elif('Counter' in recv_data):
            GPIO.output(4,GPIO.HIGH) # Power ON
            GPIO.output(DIR, 0)
            turn_valve(float(recv_data.split("'")[2].split("\"")[0]))
            GPIO.output(4,GPIO.LOW) # Power OFF
    elif(recv_data == "b'Kill'"):
        DuzceSocketClient.kill()
        log("Application Closed")
        logpad.close()
        GPIO.cleanup()
