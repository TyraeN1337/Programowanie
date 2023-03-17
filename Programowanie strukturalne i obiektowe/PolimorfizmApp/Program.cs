using System;

namespace PolimorfizmApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Burek");
            Dog seconddog = new Dog("Nyga");
            Cat cat = new Cat("Puszek");



            dog.Bark();
            cat.Meow();

            dog.ShowInfo();
            cat.ShowInfo();

            InfoAboutDog(dog);
            InfoAboutDog(seconddog);
        }

        static void InfoAboutDog(Dog d)
        {
            d.ShowInfo();
        }
        static void InfoAbout(animal a)
        {
            a.ShowInfo();
        }
    }
}
