using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotOfTasks
{
    class Exercise
    {

        public void Exercise1()
        {
            float srednia;
            float dzielnik = 2;
            Console.WriteLine("Podaj liczbę:");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            srednia = (number1 + number2) / dzielnik;
            Console.WriteLine("Srednia arytmetyczna : " + srednia);
            Console.WriteLine();
        }
        public void Exercise2()
        {
            Console.WriteLine("Podaj liczbę boku a:");
            int sideA = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę boku B:");
            int sideB = int.Parse(Console.ReadLine());
            float area;
            area = sideA * sideB;

            Console.WriteLine("Pole prostokątu to: " + area);
            Console.WriteLine();
        }
        public void Exercise3()
        {
            double V;
            Console.WriteLine("Podaj promien: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wysokosc: ");
            int h = int.Parse(Console.ReadLine());

            V =   Math.PI/3 * r * r * h;

            Console.WriteLine("Objetość stożka to: " + V);
        }
        public void Exercise4()
        {
            Console.WriteLine("Podaj promien: ");
           float r = float.Parse(Console.ReadLine());
           double area;

            area = Math.PI *( r * r);
           
            Console.WriteLine("Pole koła to: " + area);
            Console.WriteLine();
        }
        public void Exercise5()
        {
            Console.WriteLine("Podaj liczby:");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int suma;
            number1 = number1 * number1;
            number2 = number2 * number2;
            Console.WriteLine("liczba pierwsza do potegi 2 to " + number1);
            Console.WriteLine("liczba druga do potegi 2 to " + number2);
            suma = number1 + number2;
            Console.WriteLine("Suma : " + suma);
        }
        public void Exercise6()
        {
            Console.WriteLine("Podaj liczbę podstawy B:");
            int sideB = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wysokosc: ");
            int h = int.Parse(Console.ReadLine());
            float area;
            area = (sideB * h) / 2;
            Console.WriteLine("Pole trójkąta to: " + area);
            Console.WriteLine();
        }
        public void Exercise7()
        {
            Console.WriteLine("Podaj promien: ");
            float r = float.Parse(Console.ReadLine());
            double V;

            V = 4 / 3 * Math.PI *( r * r * r);

            Console.WriteLine("Objetość tej kuli to: " + V);
            Console.WriteLine();
        }
        public void Exercise8()
        {
            Console.WriteLine("Podaj liczbę podstawy a:");
            int sideA = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę podstawy B:");
            int sideB = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wysokosc: ");
            int h = int.Parse(Console.ReadLine());
            float area;
            area = ((sideA + sideB) * h )/ 2;
            Console.WriteLine("Pole trapezu to: " + area);
            Console.WriteLine();
        }
        public void Exercise9()
        {
            Console.WriteLine("Podaj liczbę wagi1:");
            float w1= int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę  wagi2:");
            float w2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę wagi3:");
            float w3 = int.Parse(Console.ReadLine());

       
            w2 = w2 * w2;
            w3 = w3 * w3 * w3;
        }

    }
}
