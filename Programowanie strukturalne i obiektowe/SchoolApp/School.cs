using System;
using Microsoft.EntityFrameworkCore;
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
                switch (option)
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
                    case 5:
                        AddNewStudent();
                        break;
                    case 6:
                        DeleteStudent();
                        break;
                    case 7:
                        ModifyStudent();
                        break;
                    case 8:
                        ShowAllStudents();
                        break;
                    case 9:
                        ShowAllStudentWithClass();
                        break;
                    case 10:
                        ShowAllStudentsOrderBySurname();
                        break;

                    case 0:
                        return;


                }

            }

        }
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Lista dostepnych opcji:");
            //CRUD
            Console.WriteLine("1. Dodanie nowej klasy."); //C - create
            Console.WriteLine("2. Usunięcie klasy.");   //D - delete
            Console.WriteLine("3. Modyfikacja klasy."); //U - update
            Console.WriteLine("4. Wyświetlenie wszystkich klas."); //R - read

            Console.WriteLine("5. Dodanie nowego ucznia");
            Console.WriteLine("8. Wyświetlenie wszystkich uczniów");
            Console.WriteLine("9. Wyświetlenie szystkich uczniów z informacją o klasie");
            Console.WriteLine("10. Wyświetlenie wszystkich uczniów posortowanych po nazwiskach");
            Console.WriteLine("11. Wyświetlenie uczniów z warunkami");
            Console.WriteLine("0. Koniec programu.");
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

            foreach (SchoolClass schoolClass in schooldatabase.SchoolClasses)
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

                if (schoolClassToDelete != null)
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

        #region Metody do pracy na tabeli Students

        private void AddNewStudent()
        {
            Console.WriteLine("Podaj imię:");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko:");
            string surname = Console.ReadLine();
            Console.WriteLine("Podaj id klasy:");
            int schoolClassId = int.Parse(Console.ReadLine());

            Student student = new Student()
            {
                Name = name,
                Surname = surname,
                SchoolClassId = schoolClassId
            };
            schooldatabase.Students.Add(student);
            schooldatabase.SaveChanges();
            Console.WriteLine("Dodano studenta");
            Console.ReadKey();

        }

        private void ShowAllStudents()
        {
            /*
             select *
               from Students
             */
            Console.WriteLine("Lista uczniów");

            foreach (Student student in schooldatabase.Students)
            {
                Console.WriteLine("Id: " + student.Id);
                Console.WriteLine("Imię: " + student.Name);
                Console.WriteLine("Nazwisko: " + student.Surname);
            }
            Console.ReadKey();
        }

        private void ShowAllStudentWithClass()
        {

            Console.WriteLine("Lista uczniów");

            foreach (Student student in schooldatabase.Students.Include(s => s.SchoolClass))
            {
                Console.WriteLine("Id: " + student.Id);
                Console.WriteLine("Imię: " + student.Name);
                Console.WriteLine("Nazwisko: " + student.Surname);
                Console.WriteLine("Nazwa klasy: " + student.SchoolClass.Name);
            }
            Console.ReadKey();
        }
        private void DeleteStudent()
        {
            Console.WriteLine("Podaj Id ucznia do usuniecia: ");
            int studentId = int.Parse(Console.ReadLine());

            Student StudentToDelete = schooldatabase.Students.FirstOrDefault(s => s.Id == studentId);

            if (StudentToDelete != null)
            {
                schooldatabase.Students.Remove(StudentToDelete);
                schooldatabase.SaveChanges();
            }
            else
            {
                Console.WriteLine("Brak ucznia w bazie");
            }
            Console.ReadKey();
        }
        private void ModifyStudent()
        {
            Console.WriteLine("Podaj Id ucznia do modyfikacji: ");
            int studentId = int.Parse(Console.ReadLine());

            Student StudentToModify = schooldatabase.Students.FirstOrDefault(s => s.Id == studentId);

            if (StudentToModify != null)
            {
                Console.WriteLine("Podaj nowe imie:");
                StudentToModify.Name = Console.ReadLine();
                Console.WriteLine("Podaj nowe nazwisko: ");
                StudentToModify.Surname = Console.ReadLine();
                schooldatabase.SaveChanges();
            }
            else
            {
                Console.WriteLine("Brak ucznia w bazie");
            }
            Console.ReadKey();
        }
        private void ShowAllStudentsOrderBySurname()
        {
            /*
             select *
               from Students
             */
            Console.WriteLine("Lista uczniów");

            foreach (Student student in schooldatabase.Students.OrderBy(s => s.Surname).ThenByDescending(s => s.Name))
            {
                Console.WriteLine("Id: " + student.Id);
                Console.WriteLine("Imię: " + student.Name);
                Console.WriteLine("Nazwisko: " + student.Surname);
            }
            Console.ReadKey();


        }
        private void shwa()
        {
             
        }
    }
    #endregion
}


