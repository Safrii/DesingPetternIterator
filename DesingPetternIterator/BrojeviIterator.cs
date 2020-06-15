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
            position = -1;
            this.num = num;
        }

        public int Next()
        {
            
           return num[position];

        }

        public bool HasNext()
        {
          
            while (num.Length  > position)
            {
             if(num.Length - 1 == position)
                {
                    break;
                }   
                position++;
                if (num[position] > 0)
                {
                    return true;

                }
                else
                    continue;
            }
            return false;
        }

           


        }
    }



