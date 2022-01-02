using System;
using Microsoft.VisualBasic;

namespace IteratorPattern
{
    class Program
    {
        private static void Main(string[] args)
        {
            Aggregate<int> listOfInt = new Aggregate<int>();
            
            listOfInt.Push(1);
            listOfInt.Push(2);
            listOfInt.Push(3);

            IIterator<int> iterator = listOfInt.GetIterator();

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}