using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    public class Aggregate<T> : IAggregate<T>
    {
        private readonly List<T> _container = new List<T>();
        private class Iterator : IIterator<T>
        {
            private int _currentIndex;
            private Aggregate<T> _aggregate;
            
            public Iterator(Aggregate<T> aggregate)
            {
                _aggregate = aggregate;
                _currentIndex = 0;
            }
            public bool HasNext()
            {
                return _currentIndex < _aggregate._container.Count;
            }

            public T Next()
            {
                return _aggregate._container[_currentIndex++];
            }
        }
        

        public IIterator<T> GetIterator()
        {
            return new Iterator(this);
        }

        public void Push(T element)
        {
            _container.Add(element);
        }

        public void Pop()
        {
            int lastIndex = _container.Count - 1;
            _container.RemoveAt(lastIndex);
        }
    }
}