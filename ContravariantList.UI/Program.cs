using System;
using ContravariantList.Implementations;
using ContravariantList.Interfaces;
using ContravariantList.Models;

namespace ContravariantList.UI
{
    public static class Program
    {
        private static void Main()
        {
            IContravariantList<Wolf> list = new ContravariantList<IAnimal>();
            list.Push(new Wolf());
            list.Push(new Wolf());
            Console.WriteLine(list.Count);
        }
    }
}