using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack stack = new LinkedListStack();

            stack.Push(30);
            stack.Push(600);
            stack.Push(90);


            while (stack.Top != null)
            {
                Console.WriteLine(stack.Top.Data);

                stack.Top = stack.Top.Next;
            }

            Console.ReadLine();
        }

    }

    class LinkedListStack
    {
        public class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }
        }
        public Node Top { get; set; }

        public LinkedListStack()
        {
            Top = null;
        }

        public void Push(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;

            if (Top == null)
            {
                Top = newNode;
                return;
            }
            newNode.Next = Top;
            Top = newNode;
        }

        public void Pop()
        {
            if(Top == null)
            {
                return;
            }
            Top = Top.Next;
        }

        public void displayTop()
        {
            if (Top != null) { 
            Console.WriteLine(Top.Data);
                return;
            }
            Console.WriteLine("Empty List");
        }


    }
}
