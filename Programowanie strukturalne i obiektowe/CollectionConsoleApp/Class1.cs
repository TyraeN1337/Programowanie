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
        public void TestObjectArrayCollection()
        {
            Number[] arrayWidthObjectNumbers = new Number[5];
            // arrayWidthObjectNumbers[2].ourNumber = 7;
            Random random = new Random();
            for (int i = 0; i < arrayWidthObjectNumbers.Length; i++)
            {
                arrayWidthObjectNumbers[i] = new Number();
                arrayWidthObjectNumbers[i].ourNumber = random.Next() % 100;
            }
            foreach(Number number in arrayWidthObjectNumbers)
            {
                Console.Write($"{number.ourNumber} ,");
            }
            Console.WriteLine();
            int max = arrayWidthObjectNumbers[0].ourNumber;
            foreach (Number number in arrayWidthObjectNumbers)
            {
                if (number.ourNumber > max)
                    max = number.ourNumber;
            }
            Console.WriteLine("Max w tablicy to: " + max);
        }
        public void TestGeneric()
        {
            Number[] numbers = new Number[5];
            NumberFloat[] floatnumbers = new NumberFloat[5];
            NumberDouble[] ndoubleumbers = new NumberDouble[5];
          
            NumberGeneric<int> intgenericNumber = new NumberGeneric<int>();
            intgenericNumber.ourNumber = 7;

            NumberGeneric<int>[] intgenericNumbers = new NumberGeneric<int>[5];
            NumberGeneric<float>[] floatgenericNumbers = new NumberGeneric<float>[5];
            NumberGeneric<double>[] doublegenericNumbers = new NumberGeneric<double>[5];
            NumberGeneric<byte>[] bytegenericNumbers = new NumberGeneric<byte>[5];
        }
        public void ListCollection()
        {
            int[] tab = new int[10];
            List<int> listofints = new List<int>();
            Console.WriteLine("Kolekcja ma elementów: " + listofints.Count);
            listofints.Add(5);
            Console.WriteLine("Kolekcja ma elementów: " + listofints.Count);
            Console.WriteLine("Zerowy element: " + listofints[0]);
        }
    }
    class Number
    {
        public int ourNumber;
    }
    class NumberDouble
    {
        public double ourNumber;
    }
    class NumberFloat
    {
        public float ourNumber;
    }
    class NumberGeneric<T>
    {
        public T ourNumber;
    }
}
