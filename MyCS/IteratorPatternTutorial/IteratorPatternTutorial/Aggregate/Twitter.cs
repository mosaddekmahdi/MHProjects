﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IteratorPatternTutorial.Iterator;

namespace IteratorPatternTutorial.Aggregate
{
    public class Twitter:ISocialNetworking
    {
        private string[] Users;

        public Twitter()
        {
            Users = new[] { "Kathy", "Lori", "Kristen", "Jamie" };
        }

        public IIterator CreateIterator()
        {
            return new TwitterIterator(Users);
        }
    }
}
