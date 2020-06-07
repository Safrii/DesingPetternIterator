using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPetternIterator
{
    interface IIterator
    {
    
        int Next();

        bool HasNext();

    }
}
