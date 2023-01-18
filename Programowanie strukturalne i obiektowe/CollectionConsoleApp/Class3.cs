using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsoleApp
{
    class TestListofObject
    {
        public void Test()
        {
            List<Person> listofpeople = new List<Person>();
            Person person = new Person("Jan", "Kowalski", 40, 200);
            listofpeople.Add(person);

            listofpeople.Add(new Person("Ewa", "Nowak", 36, 111));
            listofpeople.Add(new Person("Paweł", "Nieznany", 15, 170 ));
            listofpeople.Add(new Person("Bez", "Bezimienny", 14,169));

            Console.WriteLine("Lista wszystkich osob: ");
            foreach(Person p in listofpeople)
            {
                p.info();
            }
            Console.WriteLine();
            List<Person> listofpeoplePegi18;
            listofpeoplePegi18 = listofpeople.Where(x => x.age >= 18).ToList();
            Console.WriteLine("Lista wszystkich osob pelnoletnich: ");
            foreach(Person p in listofpeoplePegi18)
            {
                p.info();
            }
            Console.WriteLine();
            List<Person> sortedListbyAge = listofpeople.OrderBy(x => x.age).ToList();
            Console.WriteLine("Lista osob wedlug wieku:  ");
            foreach (Person p in sortedListbyAge)
            {
                p.info();
            }
            Console.WriteLine();
            int age = listofpeople.Min(x => x.age);
            Console.WriteLine("najmlodsza osoba ma wiek: " + age);
        }
    }
}
