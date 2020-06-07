using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPetternIterator
{
    class Brojevi : IBrojevi
    {

        private int[] brojevi;

        public Brojevi(int[] brojevi)
        {
            this.brojevi = brojevi;
        }




        public IIterator CreateIterator()
        {
            return new BrojeviIterator(brojevi);
        }
    }
}
