import socket

server_socket = None
client_address = None
data_array = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0]
send_data = '0,0,0,0,0,0,0,0,0,0'
recv_data = None

def _initialize(ip = '192.168.2.2', port = 1864):
    global server_socket
    global client_address
    
    print ('Starting server: ' + ip + ':' + str(port))
    try:
        server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        server_socket.bind(ip,port)
        client_address = server_socket.accept()
        print ('Connection established successfully.')
    except:
        print('ERROR: Connection Error !')
    
def _send_data():
    global client_address
    global send_data
    
    while True:
        try:        
            client_address.send(send_data + "\n")
        except:
            pass
            
def _recv_data():
    global server_socket
    global recv_data
    global data_array

    while True:
        try:
            recv_data = server_socket.recv(1024)
        except:
            print ('ERROR: Cannot receive data !')
            break
        
        if not recv_data:
            break
        else:
            array = recv_data.split(",")
            try:
                data_array = [int(x) for x in array]
            except:
                pass
    print('Receiving data:\t' + data_array)
    
def kill():
    global client_socket
client_socket.close()