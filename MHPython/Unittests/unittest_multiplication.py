''' unittest_multipliction.py

'''


import unittest


class Test(unittest.TestCase):
    def test_basic_multipliction(self):

        ''' Note that on function name, you must add word "test_" othrwise the test will not run.

        '''
        
        self.failUnlessEqual(2*1, 2)

if __name__== '__main__':

    unittest.main()
    
    

