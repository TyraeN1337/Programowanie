using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsoleApp
{
    class TestCollection
    {
        public void TestArrayCollection()
        {
            int[] arrayofnumber = new int[10];
            arrayofnumber[5] = 2137;
            var random = new Random();
            for(int i = 0; i < arrayofnumber.Length; i++)
            {
                arrayofnumber[i] = random.Next() % 100;
            }
            Console.WriteLine("Liczby w tablicy: ");
            foreach (int item in arrayofnumber)
            {
                Console.Write(item + " , ");
            }
            Console.WriteLine();
            int max = arrayofnumber[0];
            foreach(int number in arrayofnumber)
            {
                if (number > max)
                    max = number;
            }
            Console.WriteLine("Max w tablicy to: " + max);
        }
    }
}
