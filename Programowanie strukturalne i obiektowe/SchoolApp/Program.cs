using Microsoft.EntityFrameworkCore;
using SchoolApp.database.Entities;
using System;
using System.Collections.Generic;
using SchoolApp.database;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                SchoolDatabase schoolDatabase = new SchoolDatabase();

                SchoolClass schoolClass = new SchoolClass();
                schoolClass.Id = 1;
                schoolClass.Name = "1A";

                schoolDatabase.SchoolClasses.Add(schoolClass);

                schoolClass = new SchoolClass()
                {
                    Id = 2,
                    Name = "1B"
                };
                schoolDatabase.SchoolClasses.Add(schoolClass);

                schoolClass = new SchoolClass()
                {
                    Id = 3,
                    Name = "1C"
                };
                schoolDatabase.SchoolClasses.Add(schoolClass);

                schoolClass = new SchoolClass()
                {
                    Id = 4,
                    Name = "2C"
                };
                schoolDatabase.SchoolClasses.Add(schoolClass);

                Console.WriteLine("Lista klas w szkole:");
                foreach (var item in schoolDatabase.SchoolClasses)
                {
                    Console.WriteLine(item.Id + " " + item.Name);
                }

                
            }
        }
    }
}
