
#JULIUS JOW
#CS 538 COMPUTER NETWORKS  ASSIGNMENT 2
#FALL 2013, 09/18/2013
# Import socket module
from socket import *    

#We  are creating a TCP server socket
#(AF_INET -underlying networks is using  IPv4 )
#(SOCK_STREAM -is a  TCP Socket)

serverSocket = socket(AF_INET, SOCK_STREAM)
#Prepare a sever socket
# assign a server port number
serverPort = 12001

# Bind the socket to  server port
serverSocket.bind(("", serverPort))

# Listen to  1 connection at a time
serverSocket.listen(1)

# Server running
while True:
	print 'Ready to serve...'
	
	# Set up a new connection when a client knocks on the door.
	#This creates a new socket on the server for this specific client
	connectionSocket, addr = serverSocket.accept()
	
	
	try:
		# Receive message from the client
		message =  connectionSocket.recv(1024)
		
		#Get path of the requested item from the message, [1]
		
		filename = message.split()[1]
		f = open(filename[1:])
		# Store this in a buffer
		outputdata = f.read()
		#print outputdata 
		# Send one HTTP header line into socket
		
		connectionSocket.send("HTTP/1.1 200 OK\r\n\r\n")
              
		# Send the content of the requested file to the client
		for i in range(0, len(outputdata)):  
			connectionSocket.send(outputdata[i])
		
		# Close the client connection socket
		connectionSocket.close()

	except IOError:
		#Send response message for file not found
		connectionSocket.send("Error says Julius Jow It is Not Found \r\n")
		# Close the client socket
		connectionSocket.close()

serverSocket.close()  



