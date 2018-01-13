import socket

client_socket = None
data_array = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0]
send_data = '0,0,0,0,0,0,0,0,0,0'
recv_data = None

def _initialize(ip = '192.168.2.2', port= 1864):
    global client_socket
    
    print ('Connecting: ' + ip + ':' + str(port))
    try:
        client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        client_socket.connect((ip, port))
        print ('Connection established successfully.')
    except:
        print('ERROR: Connection Error !') 
    
def _send_data():
    global client_socket
    global send_data
    
    while True:
        try:        
            client_socket.send(send_data + "\n")
        except:
            pass
            
def _recv_data():
    global client_socket
    global data_array
    global recv_data
    
    while True:
        try:
            recv_data = client_socket.recv(1024)
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