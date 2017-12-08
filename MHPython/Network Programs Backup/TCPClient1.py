
#TCPClient Program

from socket import *
from time import *

serverName = '192.168.1.176'
serverPort = 11000
clientSocket = socket(AF_INET, SOCK_STREAM)
# Below is the additional line compared to UDP
clientSocket.connect((serverName, serverPort))

print "Start time is : %s" % ctime()

msg = raw_input('Input your name in lower case: ')
clientSocket.send(msg)  #This is special
#clientSocket.sendto(msg, (serverName, serverPort))
uppercasemsg = clientSocket.recv(1024)
print "\nModified Message back from server: ", uppercasemsg

print "\n\nThanks, your server is responding! Please wait 10 seconds to quit"
sleep(10)

clientSocket.close()
