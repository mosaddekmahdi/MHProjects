''' unittest_addition.py

'''

'''
import os
os.system('cls')
'''


import unittest


class Test(unittest.TestCase):
    def test_basic_addition(self):


        self.failUnlessEqual(1+1, 22)

if __name__== '__main__':

    unittest.main()
    
    

