using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPetternIterator
{

    class Program
    {
        static void Main(string[] args)
        {

            int[] array = {-1,1,-5,9,-8,-6,0,5,5,5,6,-7,0};

            IBrojevi Brojevi = new Brojevi(array);
            IIterator iterator = Brojevi.CreateIterator();

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }

            Console.ReadLine();
        }
    }
}
