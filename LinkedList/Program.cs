using System;
using System.Runtime.ExceptionServices;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----strings----");

            var stringList = new LinkedList<string>();

            var nodeOne = new LinkedNode<string>("Node One (I was added as the First Node)");
            stringList.AddNodeFirst(nodeOne);

            var nodeTwo = new LinkedNode<string>("Node Two (I was added as the First Node so, Node One was bumped down");
            stringList.AddNodeFirst(nodeTwo);

            var nodeThree = new LinkedNode<string>("Node Three (I was added as the Last Node so, Node One & Two are above me");
            stringList.AddNodeLast(nodeThree);

            var nodeFour = new LinkedNode<string>("Node Four (I was inserted after Node Two so, I'm below Node two)");
            stringList.InsertNodeAfter(nodeTwo, nodeFour);

            var nodeFive = new LinkedNode<string>("Node Five (I was added as the First Node so, Node two was bumped down");
            stringList.AddNodeFirst(nodeFive);

            stringList.RemoveNode(nodeFour);

            var nodeSix = new LinkedNode<string>("Node Six (Node Four was just removed. I was added as the Last Node so, Node Three is above me)");
            stringList.AddNodeLast(nodeSix);

            DisplayAllStringNodes(stringList);

            Console.WriteLine("----ints----");

            var intList = new LinkedList<int>();

            var nodeSeven = new LinkedNode<int>(7);
            intList.AddNodeFirst(nodeSeven);

            var nodeEight = new LinkedNode<int>(8);
            intList.AddNodeFirst(nodeEight);

            var nodeNine = new LinkedNode<int>(9);
            intList.AddNodeLast(nodeNine);

            var nodeTen = new LinkedNode<int>(10);
            intList.AddNodeLast(nodeTen);

            var nodeEleven = new LinkedNode<int>(11);
            intList.AddNodeFirst(nodeEleven);

            intList.RemoveNode(nodeEight);

            var nodeTwelve = new LinkedNode<int>(12);
            intList.AddNodeLast(nodeTwelve);

            DisplayAllIntNodes(intList);

            Console.ReadLine();
        }

        private static void DisplayAllStringNodes(LinkedList<string> list)
        {
            var cursor = list.Head;

            while (cursor != null)
            {
                Console.WriteLine(cursor.Data);
                cursor = cursor.Next;
            }
        }

        private static void DisplayAllIntNodes(LinkedList<int> list)
        {
            var cursor = list.Head;

            while (cursor != null)
            {
                Console.WriteLine(cursor.Data);
                cursor = cursor.Next;
            }
        }
    }
}