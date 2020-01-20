using System;
using System.Threading;

namespace AbstractClasses
{
    class Program
    {

        // Testing SSH Key
        static void Main(string[] args)
        {
            // Instantiate Dog class to create dog object
            Dog dog = new Dog();

            // Instantiate Cat class to create cat object
            Cat cat = new Cat();

            dog.animalSound();
            cat.animalSound();

            // This allows the console window to stay open for 3 seconds.
            // That way we can view our results for 3 seconds before the window closes.
            // This is using milliseconds.
            Thread.Sleep(3000);
        }
    }
}