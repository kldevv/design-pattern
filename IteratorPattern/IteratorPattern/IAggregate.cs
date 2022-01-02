namespace IteratorPattern
{
    public interface IAggregate<T>
    {
        public IIterator<T> GetIterator();
        public void Push(T element);
        public void Pop();
    }
}