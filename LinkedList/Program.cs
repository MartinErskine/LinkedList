using System;

namespace LinkedList
{
    class Program
    {
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