using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3
{
    class Animal
    {
        public virtual void sound() { Console.WriteLine("동물이 소리를 낸다."); }
    }

    class Dog :Animal
    {
        public override void sound() { Console.WriteLine("BARK!"); }
    }

    class Cat : Animal
    {
        public override void sound() { Console.WriteLine("Meow~"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal d1 = new Dog();
            Animal c1 = new Cat();

            a1.sound();
            d1.sound();
            c1.sound();
        }
    }
}
