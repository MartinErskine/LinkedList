namespace LinkedList
{
    public class LinkedNode<T>
    {
        public LinkedNode<T> next;
        public T Data;
        public LinkedNode(T Data)
        {
            this.Data = Data;
        }
    }
}