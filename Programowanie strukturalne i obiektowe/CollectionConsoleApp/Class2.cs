using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsoleApp
{
    class TestListCollection
    {
        public void FirstTest()
        {
            Random random = new Random();

            List<int> listofInts = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                listofInts.Add(random.Next(1, 11));
            }
            Console.WriteLine("List int'ow: ");
            foreach (int element in listofInts)
            {
                Console.Write(element + " , ");
            }
            Console.WriteLine();

            List<double> listofDoubles = new List<double>();
            for (int i = 0; i < 5; i++)
            {
                double number = random.NextDouble() * 10 + 1;
                number = Math.Round(number, 4);

                listofDoubles.Add(number);
            }
            Console.WriteLine("List Doublow: ");
            foreach (int element in listofDoubles)
            {
                Console.Write(element + " , ");
            }
            Console.WriteLine();

            List<int> newListOfInts = GetNewCollection<int>(listofInts, x => { return x > 5; });
            Console.WriteLine("Lista intow wieksza od 5: ");
            foreach(int item in newListOfInts)
            {
                Console.Write(item + " , ");
            }
            Console.WriteLine(); 
           
        }
         
          
        private T MaxFromAllTypes<T>(List<T> list, Func<T, T, bool> check)
        {
            T max = list[0];
            foreach (T item in list)
            {
                if (check (item, max))
                    max = item;
            }
            return max;
        }
        
        private bool CheckInt(int firstnumber, int secondnumber)
        {
            return firstnumber > secondnumber;
        }
        private bool CheckDouble(double firstnumber, double secondnumber)
        {
            return firstnumber > secondnumber;
        }
        
        public List<T> GetNewCollection<T>(List<T> list, Func<T, bool> check)
        {
            List<T> newCollection = new List<T>();
            foreach (T item in list)
            {
                if(check(item))
                    newCollection.Add(item);
            }
            return newCollection;

        }


    }
}
