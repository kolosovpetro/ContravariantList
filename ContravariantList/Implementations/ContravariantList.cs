using System.Collections.Generic;
using ContravariantList.Interfaces;

namespace ContravariantList.Implementations
{
    public class ContravariantList<T> : IContravariantList<T> where T : IAnimal
    {
        private readonly List<T> _animals = new List<T>();

        public int Count => _animals.Count;

        public void Push(T entity)
        {
            _animals.Add(entity);
        }
    }
}