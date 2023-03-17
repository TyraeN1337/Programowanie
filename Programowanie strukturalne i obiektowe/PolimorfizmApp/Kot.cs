﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmApp
{
    class Cat
    {
        private string name;

        public Cat(string catName)
        {
            name = catName;
        }
        public void Meow()
        { 
           Console.WriteLine($"Kot o imieniu {name} miauczy.");
        }
        public void ShowInfo()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Obiekt klasy Cat.");
            Console.WriteLine($"Pies o imieniu {name} ");
            Console.WriteLine("---------------------------------------------");
        }
        
    }
}
