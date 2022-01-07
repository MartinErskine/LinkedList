namespace LinkedList
{
    public class LinkedList<T>
    {
        public LinkedNode<T> Head { get; private set; }

        private LinkedNode<T> _tail;

        /// <summary>
        /// Make Node current First in list.
        /// </summary>
        /// <param name="node"></param>
        public void AddNodeFirst(LinkedNode<T> node)
        {
            if (Head == null)
            {
                Head = _tail = node;
                Head.Next = _tail;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
        }

        /// <summary>
        /// Make Node current Last in list
        /// </summary>
        /// <param name="node"></param>
        public void AddNodeLast(LinkedNode<T> node)
        {
            if (_tail == null)
            {
                _tail = Head = node;
                Head.Next = _tail;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }
        }

        /// <summary>
        /// Add Node immediately after a given Node.
        /// </summary>
        /// <param name="nodeBefore"></param>
        /// <param name="node"></param>
        public void InsertNodeAfter(LinkedNode<T> nodeBefore, LinkedNode<T> node)
        {
            var nodeAfter = nodeBefore.Next;

            nodeBefore.Next = node;
            node.Next = nodeAfter;

        }

        /// <summary>
        /// Remove a Node.
        /// </summary>
        /// <param name="node"></param>
        public void RemoveNode(LinkedNode<T> node)
        {
            var nodeBefore = FindNodeBefore(node);

            if (nodeBefore == null)
            {
                return;
            }

            if (ReferenceEquals(Head, node))
            {
                Head = node;
            }

            if (ReferenceEquals(_tail, node))
            {
                _tail = nodeBefore;
            }

            nodeBefore.Next = node.Next;
        }

        /// <summary>
        /// Find the Node before a given Node.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public LinkedNode<T> FindNodeBefore(LinkedNode<T> node)
        {
            if (ReferenceEquals(node, Head))
            {
                return null;
            }

            var nodeBefore = Head;
            var cursor = Head;

            while (cursor != null)
            {
                if (ReferenceEquals(node, cursor))
                    return nodeBefore;

                nodeBefore = cursor;

                cursor = cursor.Next;
            }

            return null;
        }
    }
}