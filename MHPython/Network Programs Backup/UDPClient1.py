#UDPClient Program

from socket import *
from time import *

serverName = '192.168.1.176'
serverPort = 10000
clientSocket = socket(AF_INET, SOCK_DGRAM)
print "Start time is : %s" % ctime()

msg = raw_input('Input your name in lower case: ')

clientSocket.sendto(msg, (serverName, serverPort))
modifiedmsg, serverAddress = clientSocket.recvfrom(2048)
print modifiedmsg

print "Thanks, your server is responding! Please wait 10 seconds to quit"
sleep(10)

clientSocket.close()
