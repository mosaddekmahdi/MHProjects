using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IteratorPatternTutorial.Aggregate;
using IteratorPatternTutorial.Iterator;

namespace IteratorPatternTutorial
{
    class DriverProgram
    {
        static void Main(string[] args)
        {
            ISocialNetworking fb = new Facebook();
            ISocialNetworking tw = new Twitter();

            IIterator fbIterator = fb.CreateIterator();
            IIterator twIterator = tw.CreateIterator();

            Console.WriteLine("Facebook: ");
            PrintUsers(fbIterator);

            Console.WriteLine("Twitter: ");
            PrintUsers(twIterator);

            Console.ReadKey();
        }

        public static void PrintUsers(IIterator iterate)
        {
            iterate.First();
            while (!iterate.IsDone())
            {
                Console.WriteLine(iterate.Next());
            }
        }
    }
}
