'''
Created on Jan 11, 2010

@author: jacob-laptop
'''
from MyMath import MyMath
from MyMath import NegativeNumberException
import unittest


class Test(unittest.TestCase):

    squareOracle = (
                    (2,4),
                    (3,9),
                    (4,16))
    
    squareRootOracle = (
                  (4,2),
                  (16,4))

    def setUp(self):
        self.myMath = MyMath()


    def tearDown(self):
        pass

    def testSquareSuccess(self):
        for number,expected in self.squareOracle:
            self.assertEqual(
                             self.myMath.computeSquare(number)
                             ,expected)
            
    def testSquareRootSuccess(self):
        for number, expected in self.squareRootOracle:
            self.assertEqual(
                             self.myMath.computeSquareRoot(number),
                             expected)
            
    def testSquareRootFailure(self): 
        self.assertRaises(NegativeNumberException,
                          self.myMath.computeSquareRoot,
                          -1)


if __name__ == "__main__":
    #import sys;sys.argv = ['', 'Test.testName']
    try:
        unittest.main()
    except: pass
