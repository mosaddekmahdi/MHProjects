
#TCPServer Program

from socket import *

serverPort = 11000

serverSocket = socket(AF_INET, SOCK_STREAM)
serverSocket.bind(('', serverPort))
serverSocket.listen(1) # This is an additional line compared to UDP

print "This sever is ready to receive any message: "

while 1:    # This section is completely different form UDPServer
    connectionSocket, addr = serverSocket.accept()
    msg = connectionSocket.recv(1024)
    uppercasemsg = msg.upper()
    connectionSocket.send(uppercasemsg)
    connectionSocket.close()
