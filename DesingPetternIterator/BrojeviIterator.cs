using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPetternIterator
{
    class BrojeviIterator : IIterator
    {

        private int num;
        private int position;

        public BrojeviIterator(int[] num)
        {
            position = 0;
            this.num = num[position];
        }

        public int Next()
        {
            
       
        }

        public bool HasNext()
        {
            

        }

     
    }
}
