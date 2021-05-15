using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            QueueLinked queue = new QueueLinked();
            queue.Enqueue(33);
            queue.Enqueue(44);
            //queue.Dequeue();

            queue.Display();




            Console.ReadLine();
        }
    }

   public class QueueLinked
    {
        public class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }
        }
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public QueueLinked()
        {
            Head = null;
            Tail = null;
        }

        public void Enqueue(int val)
        {
            Node newNode = new Node();
            newNode.Data = val;
            if(Head == null && Tail == null)
            {
                Head = Tail = newNode;
               // Tail = newNode;
                return;
            }

           
            Tail.Next = newNode;
            Tail = newNode;
      


        }
        public void Dequeue()
        {
            if (Head!=null && Tail!=null)
            {
                Console.WriteLine("Value is " + Head.Data);
                Head = Head.Next;
                return;
            }
            Console.WriteLine("Cant Dequeue Empty List");

        }

        public void Display()
        {
            while(Head != null)
            {
                Console.WriteLine(Head.Data);
                Head = Head.Next;
            }

        }



    }
}
