''' unittest_modulo.py

'''


import unittest


class Test(unittest.TestCase):
    def test_basic_modulo(self):

        ''' Note that on function name, you must add word "test_" othrwise the test will not run.

        '''
        
        self.failUnlessEqual(3 %2, 1)

if __name__== '__main__':

    unittest.main()
    
    

