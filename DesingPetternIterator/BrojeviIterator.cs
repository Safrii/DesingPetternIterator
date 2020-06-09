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
            if (position != num.Length)
            {


                while (position != num.Length)
                {
                    position++;
                    if (num[position] % 2 == 0)
                    {
                        return true;
                    }
                    else
                        return false;

                }

            }

            return false;


        }
    }
}


