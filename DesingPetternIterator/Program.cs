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

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

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
