using System;
using ContravariantList.Interfaces;

namespace ContravariantList.Models
{
    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void SayAge()
        {
            Console.WriteLine($"I'm a Dog, my age: {Age}");
        }

        public virtual void SayName()
        {
            Console.WriteLine($"I'm a Dog, my name is: {Name}");
        }
    }
}