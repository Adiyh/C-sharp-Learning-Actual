using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverRiding
{
    public class Animal
    { 
        public virtual void sound()
        {
            Console.WriteLine("Animal makes sound");
        }
        public static void run()
        {
         
            Animal animal = new Dog();
            animal.sound();
            
        }
    }
    public class Dog : Animal
    {
        public override void  sound()
        {
            Console.WriteLine("Dog barks");
        }

    }
    
}


