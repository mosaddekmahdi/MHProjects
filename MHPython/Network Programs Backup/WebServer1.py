
# WebServer1.py Program
# Mokter Hossain; CS 538, Fall 2013

#import socket module
# Import everything from socket
from socket import *
# Import time module to use sleep() method
from time   import *

serverPort=12120
serverSocket = socket(AF_INET, SOCK_STREAM)
#Binds the socket to the Server Port
serverSocket.bind(("",serverPort))
#Listens to a single connection at a certain time
serverSocket.listen(1)


#Establish the connection

while True:     #Loop indefinitely
    
    print "Whe web server is ready on port:", serverPort    
    connectionSocket, addr = serverSocket.accept()
   

    # Attempt to do following
    try:

        # Receive message from the client
	message =  connectionSocket.recv(1024)
		
	#Find path of the requested item from the above message
	filename = message.split()[1]
	f = open(filename[1:])
        outputdata = f.read()

	# Stores the data in a buffer
	
	
	# Send one HTTP header line into socket
		
	connectionSocket.send("HTTP/1.1 200 OK\r\n")
              
	
        #Send the content of the requested file to the client

	for i in range(0, len(outputdata)):  
            connectionSocket.send(outputdata[i])
	# Close the client connection socket
	connectionSocket.close()
 
        
    except IOError:
        # Send response messgage if file is not found
        connectionSocket.send("Error #404: File not found!!")
        # Close connection
        connectionSocket.close()

serverSocket.close()
    
