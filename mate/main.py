# import
from threading import Thread
import time
from bs4 import BeautifulSoup
import requests
import socket
from datetime import datetime


# definitions
recv_data = ""
angles = ""
data = ""
loop = True

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
        try:
            self.client_socket.connect((self.server_ip,self.port))
            print("Connection established")
            log("Connection established")
        except TimeoutError:
            print("ERROR: Server is not responding")
            log_error("Server is not responding")
        except OSError:
            print("ERROR: No Connection found")
            log_error("No Connection found")

    def send(self,data):
        self.send_data = data
        self.client_socket.send(self.send_data)
        print("Sending Data: ", self.send_data)
        log("Sending Data: " + self.send_data)

    def recv(self):

        self.recv_data = self.client_socket.recv(self.buffer_size)
        print("Receiving Data: ", self.recv_data)
        #log("Receiving Data: " + self.recv_data)
        self.recv_data = str(self.recv_data)
        return self.recv_data

    def kill(self):
        self.client_socket.close()
        print("Socket closed")
        log("Socket closed")
# Client Object Begin

def send(send_data):
    bytes = str.encode(send_data)
    DuzceSocketClient.send(data = bytes)
    log("Transmitted Data: " + send_data)

def liftbagON():
    requests.get("http://192.168.4.1/ac")
    log("Lift bag opened")
def liftbagOFF():
    requests.get("http://192.168.4.1/kapa")
    log("Lift bag closed")

def OBS_read():
    while(loop):
        html = requests.get("http://192.168.4.1")
        soup = BeautifulSoup(html.text,"lxml")
        tempImport = soup.find("h3")
        tempImport2 = str(tempImport)
        Import = tempImport2[4:-5]
        if "DATA" in Import:
            angles = Import [:41]
            data = Import[47:]
            loop = False
        else:
            angles = Import
        send("OBS: " + angles + data)
        log("OBS: " + angles + data)
        time.sleep(0.2)
# setup
logpad = open("/home/pi/mate/log.txt", "w")
DuzceSocketClient = Client(server_ip = '192.168.2.1', port = 1864)
DuzceSocketClient.connect()
#recvThread = Thread(target=recv, args=(0.01))
#recvThread.start()

# main loop
while True:
    recv_data = DuzceSocketClient.recv()
    print(recv_data)
    print(type(recv_data))
    if(recv_data == "b'LiftbagiSalKanka'"):
        print("ahshahshahsahsa")
        liftbagON()
        print('hahahahahahahahahah')
    elif(recv_data == 'LiftbagiKapaKanka'):
        liftbagOFF()
    elif(recv_data == 'OBSeBaglanKanka'):
        OBS_read()

