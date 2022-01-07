namespace LinkedList
{
    public class LinkedNode<T>
    {
        public LinkedNode<T> Next;

        public T Data;

        public LinkedNode(T data)
        {
            Data = data;
        }
    }
}