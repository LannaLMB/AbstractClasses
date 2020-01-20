using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Dog : Animal // The Dog Class inherits our Animal(Base) Class
    {
        public override void animalSound()
        {
            //return ("Woof!");
            Console.WriteLine("Woof!");
        }
    }
}