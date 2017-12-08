using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IteratorPatternTutorial.Iterator;

namespace IteratorPatternTutorial.Aggregate
{
    public interface ISocialNetworking
    {
        IIterator CreateIterator();
    }
}
