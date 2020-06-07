using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPetternIterator
{
    class BrojeviIterator : IIterator
    {

        private int[] num;
        private int position;

        public BrojeviIterator(int[] num)
        {
            position = 0;
            this.num = num;
        }

        public int Next()
        {
            return num[position++];

        }

        public bool HasNext()
        {
            if (num.Length != position)
            {
                return true;
            }
            else return false;


        }


    }
}