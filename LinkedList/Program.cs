using System;

namespace LinkedList
{
    class Program
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
        static void Main(string[] args)
        {
            Linked<string> list = new Linked<string>();

            list.AddFirst(new LinkedNode<string>("first entry (added first, as first)"));
            list.AddFirst(new LinkedNode<string>("second entry (added second, as first)"));
            list.AddLast(new LinkedNode<string>("third entry (added third, as last)"));
            list.AddLast(new LinkedNode<string>("fourth entry (added fourth, as first)"));
            list.AddFirst(new LinkedNode<string>("fifth entry (added fifth, as first)"));
            list.AddLast(new LinkedNode<string>("sixth entry (added sixth, as last)"));
            LinkedNode<string> newLastNode = new LinkedNode<string>("seventh entry, as new link node");
            list.AddLast(newLastNode);
            list.insertAfter(newLastNode, new LinkedNode<string>("inserted first after the last"));
            //list.insertAfter(newLastNode, new LinkedNode<string>("inserted second after the last, but will appear right after the last"));

            DisplayAllNodes(list);

            //Console.WriteLine("list2 items are being displayed");
            //Linked<string> list2 = new Linked<string>();

            //list2.AddLast(new LinkedNode<string>("first item"));
            //list2.AddLast(new LinkedNode<string>("second item"));
            //LinkedNode<string> thirdItem = new LinkedNode<string>("third item");
            //list2.AddLast(thirdItem);
            //list2.AddLast(new LinkedNode<string>("fourth item"));
            //list2.AddLast(new LinkedNode<string>("fifth item"));

            //list2.removeLink(thirdItem);

            //DisplayAllNodes(list2);


            Console.ReadLine();
        }

        private static void DisplayAllNodes(Linked<string> list)
        {
            LinkedNode<string> cursor = list.Head;
            while (cursor != null)
            {
                Console.WriteLine(cursor.Data);
                cursor = cursor.next;
            }
        }
    }
}