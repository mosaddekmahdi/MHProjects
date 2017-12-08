
#UDPServer Program

from socket import *

serverPort = 10000

serverSocket = socket(AF_INET, SOCK_DGRAM)
serverSocket.bind(('', serverPort))

print "This sever is ready to receive any message: "

while 1:
    msg, clientAddress = serverSocket.recvfrom(2048)
    modifiedmsg = msg.upper()
    serverSocket.sendto(modifiedmsg, clientAddress)
