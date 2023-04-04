using System;
using SchoolApp.Database;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    class School
    {
        private SchoolDatabase schooldatabase = new SchoolDatabase();
        public void Run()
        {
            while (true)
            {
                ShowMenu();

                Console.WriteLine("Wybierz: ");
                if (!int.TryParse(Console.ReadLine(), out int option))
                    continue;
                switch(option)
                {
                    case 1:

                        break;
                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                    case 0:
                        return;

                        
                }

            }
    
        }
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine(" Lista dostępnych opcji: "  );
            Console.WriteLine("1. Dodanie nowej klasy ");
            Console.WriteLine("2. Usunięcie klasy ");
            Console.WriteLine("3. Modyfikacja klasy ");
            Console.WriteLine("4. Wyświetlenie wszystkich klas ");

            Console.WriteLine("0. Koniec Programu");
        }
    }
}
