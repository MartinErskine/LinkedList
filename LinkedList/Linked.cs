namespace LinkedList
{
    public class Linked<T>
    {
        public LinkedNode<T> Head
        {
            get
            {
                return head;
            }
        }
        private LinkedNode<T> head;
        private LinkedNode<T> tail;
        public void AddFirst(LinkedNode<T> node)
        {
            if (head == null)
            {
                head = tail = node;
                head.next = tail;
            }
            else
            {
                node.next = head;
                head = node;
            }
        }

        public void AddLast(LinkedNode<T> node)
        {
            if (tail == null)
            {
                tail = head = node;
                head.next = tail;
            }
            else
            {
                tail.next = node;
                tail = node;
            }
        }

        // inserting after a node is much easier than before a node in a singly Linked list because there is no 
        // pointer to the node pointing at the current, unlike a doubly Linked list.
        public void insertAfter(LinkedNode<T> nodeBefore, LinkedNode<T> node)
        {
            LinkedNode<T> nodeAfter = nodeBefore.next;
            nodeBefore.next = node;
            node.next = nodeAfter;

        }

        public void removeLink(LinkedNode<T> node)
        {
            LinkedNode<T> nodeBefore = FindNodeBefore(node);
            // if node not found, just return
            if (nodeBefore == null)
                return;
            if (object.ReferenceEquals(head, node))
            {
                head = node;
            }
            if (object.ReferenceEquals(tail, node))
            {
                tail = nodeBefore;
            }

            nodeBefore.next = node.next;
        }

        // finding the node before the current requires traversal of a singly Linked list.
        public LinkedNode<T> FindNodeBefore(LinkedNode<T> node)
        {
            // there is no node before the head, so return null
            if (object.ReferenceEquals(node, head))
                return null;
            LinkedNode<T> nodeBefore = head;
            LinkedNode<T> cursor = head;
            while (cursor != null)
            {

                if (object.ReferenceEquals(node, cursor))
                    return nodeBefore;

                nodeBefore = cursor;

                cursor = cursor.next;
            }
            //if nothing found, return null
            return null;
        }
    }
}