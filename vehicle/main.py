from modules import client
from threading import Thread
import time

send_data = '0000,0000,0000,0000'
recv_data = '0000,0000,0000,0000'
read_data = '0000,0000,0000,0000'
write_data = '0000,0000,0000,0000'

def recv(interval):
    global recv_data
    while True:
        time.sleep(interval)
        recv_data = raspi.recv()
        if not recv_data:
            continue
            print('No Signal')
        else:
            recv_data = recv_data.decode()
            log("Received Data: " + recv_data)
            #Do stuff

def send(interval):
    global send_data
    while True:
        time.sleep(interval)
        bytes = str.encode(send_data)
        raspi.send(data = bytes)
        log("Transmitted Data: " + send_data)

def read_from_sensors():
    global read_data
    #bengü
    return read_data

def write_to_sensors(write_data):
    global write_data
    #bengü
    pass

raspi = Client(server_ip = '192.168.2.2', port = 1864)
raspi.connect()
recvThread = Thread(target=recv, args=(0.01))
sendThread = Thread(target=send, args=(0.01))
recvThread.start()
sendThread.start()

while True:
    #sensor_data = read_from_sensors()
    #send_data = '0000,0000,0000,1111'
    print(recv_data)
    #recv_data.split(",")
    #liftbag = recv_data[0]
    #write_data = '0000,0000,0000' + str(liftbag)
    #write_to_sensors(write_data)
