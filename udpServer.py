import socket

import threading
import json
import random
Kp = 0
Sp = 0
def random_float():
    return random.random()

import time
class Tmr:
  def __init__(self, seconds):
    self.seconds = seconds
    self.refTime = -1
    self.trigger = False
  
  def tmrStart(self):
    if self.refTime==-1:
      self.refTime = time.time()
    self.trigger = self.refTime + self.seconds < time.time()
    if self.trigger:
      self.refTime = -1
    else:
      pass
      
  def pulse(self):
    return self.trigger
#from Tmr import *


def udp_server_thread(host='0.0.0.0', port=20001):
    """
    The function to be run in a separate thread for the UDP server.
    
    :param host: The IP address to listen on. '0.0.0.0' listens on all available interfaces.
    :param port: The port number to listen on.
    """
    with socket.socket(socket.AF_INET, socket.SOCK_DGRAM) as server_socket:
        server_socket.bind((host, port))
        print(f"UDP server listening on {host}:{port} in a thread.")
        
        try:
            while True:
                data, address = server_socket.recvfrom(4096)  # Buffer size is 4096 bytes
                #print(f"Received message: {data.decode()} from {address}")
                
                json_data = json.loads(data.decode('utf-8'))
                print(f"Received data: {json_data}")
                
                #print(f"Kp: {json_data['Kp']}")
                #print(f"Ti: {json_data['Ti']}")
                #print(f"Td: {json_data['Td']}")
                #print(f"Sp: {json_data['Sp']}")
                Sp = json_data['Sp']
                
                
                # Send a response back to the client
                data = {
                
                'Sp': Sp,
                'Cv': random_float()*5.0,
                'Pv': random_float()*11.5
                }
                message = json.dumps(data).encode('utf-8')
                server_socket.sendto(message, address)
                
        except KeyboardInterrupt:
            print("UDP server thread is shutting down.")
def main():
    # Create and start the UDP server thread only once, outside the while loop
    thread = threading.Thread(target=udp_server_thread)
    thread.daemon = True
    thread.start()

    Tmr1 = Tmr(5)  # Print data to console
    while True:
        Tmr1.tmrStart()
        if Tmr1.pulse():
            print("\...")
        time.sleep(1)  # Prevent the while loop from hogging the CPU

if __name__ == '__main__':
    main()




