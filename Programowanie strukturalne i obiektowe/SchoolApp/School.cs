using System;
using SchoolApp;
using SchoolApp.Database;
using SchoolApp.Database.Entities;
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
                        AddNewSchoolClasses();
                        break;
                    case 2:
                        DeleteClass();
                        break;

                    case 3:
                        ModifyClass();
                        break;

                    case 4:
                        ShowEm();
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
        #region Metody do pracy na tabeli SchoolClasses
        private void AddNewSchoolClasses()
        {
            Console.WriteLine("Podaj nazwe klasy");
            string className = Console.ReadLine();

            SchoolClass schoolClass = new SchoolClass()
            {
                Name = className
            };

            schooldatabase.SchoolClasses.Add(schoolClass);
            schooldatabase.SaveChanges();
        }
        private void ShowEm()
        {
            Console.WriteLine("Wszystkie klasy: ");

            foreach(SchoolClass schoolClass in schooldatabase.SchoolClasses)
            {
                Console.WriteLine(schoolClass.Id + " " + schoolClass.Name);
            }
            Console.ReadKey();
        }
        private void DeleteClass()
        {
            Console.WriteLine("Podaj Id klasy do usuniecia: ");
            if (int.TryParse(Console.ReadLine(), out int idDelete))
            {
                SchoolClass schoolClassToDelete = schooldatabase.SchoolClasses.FirstOrDefault(sc => sc.Id == idDelete); 

                if(schoolClassToDelete != null)
                {
                    schooldatabase.SchoolClasses.Remove(schoolClassToDelete);
                    schooldatabase.SaveChanges();
                    Console.WriteLine("Kasowanie udane");
                }
                else
                {
                    Console.WriteLine("Brak klasy o takim id");
                }
            }
            else
            {
                Console.WriteLine("Błąd");

            }
        }
        private void ModifyClass()
        {
            Console.WriteLine("Podaj Id klasy do modyfikacji: ");
            if (int.TryParse(Console.ReadLine(), out int idModify))
            {
                SchoolClass schoolClassToModify = schooldatabase.SchoolClasses.FirstOrDefault(sc => sc.Id == idModify);

                if (schoolClassToModify != null)
                {
                    Console.WriteLine("Podaj nowa nazwe klasy");
                    string newName = Console.ReadLine();
                    schooldatabase.SaveChanges();
                    Console.WriteLine("Modyfikacja zakonczona");
                }
                else
                {
                    Console.WriteLine("Brak klasy o takim id");
                }
            }
        }
        #endregion
    }
}
