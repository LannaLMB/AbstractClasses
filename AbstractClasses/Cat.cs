using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Cat : Animal  // The Cat Class inherits our Animal(Base) Class
    {
        public override void animalSound()
        {
            Console.WriteLine("Meow!");
           // return ("Meow!");
        }
    }
}