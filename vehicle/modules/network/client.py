import socket
from printer import log
from printer import log_error

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
        log("Sending Data: ", self.send_data)
    
    def recv(self):
        self.recv_data = self.client_socket.recv(self.buffer_size)
        print("Receiving Data: ", self.recv_data)
        log("Receiving Data: ", self.recv_data)
        return self.recv_data
        
    def kill(self):
        self.client_socket.close()
        print("Socket closed")
        log("Socket closed")