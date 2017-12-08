'''
Created on Jan 11, 2010

@author: jacob-laptop
'''

from math import sqrt

class MyMath(object):
    '''
    classdocs
    '''


    def __init__(self):
        '''
        Constructor
        '''
        
    def computeSquare(self,number):
        return number * number
    
    def computeSquareRoot(self,number):
        if(number < 0):
            raise NegativeNumberException
        
        return sqrt(number)
        
class NegativeNumberException(Exception):
    pass