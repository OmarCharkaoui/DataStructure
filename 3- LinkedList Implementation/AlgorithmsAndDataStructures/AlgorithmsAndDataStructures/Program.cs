using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    public class Program
    {
        static void Main(string[] args)
        {

            LinkedList linkedList = new LinkedList();
            linkedList.append(5);
            linkedList.append(8);
            linkedList.append(7);
            linkedList.append(3);
            Console.ReadLine();
        }
     
    }


   public class LinkedList
    {
        public class Node {
            public  int data;
            public Node Next;

        };
        public Node head = null;

        public void append(int data)
        {
            Node node = new Node();
            node.data = data;
            if (head == null)
            {
                head = node;

            }
            else
            {
                Node temp = new Node();
                temp.Next = head;

                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = node;
            }
        }

        public void remove(int data)
        {
            Node temp = new Node();
            Node before = new Node();
            before = head;
          
            if (before.data == data)
            {
                before = before.Next;
                head = before;
                return;
            }
         

            while (before.Next != null && before.Next.data != data)
            {
                before = before.Next;
            }
             
  
            if (before.Next == null)
            {
                Console.WriteLine("not Found");
                return;
            }
            else
            {
                temp = before.Next;
                before.Next = temp.Next;
            }

           
           
            


        }

        public void insert_at_pos(int val,int pos)
        {

            Node newNode = new Node();
            newNode.data = val;

            if (pos == 0)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }
            Node temp = new Node();
            temp = head;
            for (int i = 0; i < pos-1 && temp.Next != null; i++)
            {
                temp = temp.Next;
            }

            newNode.Next = temp.Next;
            temp.Next = newNode;
    


        }

        public void remove_at_pos(int pos)
        {

            Node temp = new Node();
            temp = head;
            if (pos == 0)
            {
                head = head.Next;
                return;
            }
            for (int i = 0; i < pos-1 && temp!=null; i++)
            {
                temp = temp.Next;
            }

            if (temp != null) { 
            temp.Next = temp.Next.Next;
            }







        }

        public void reverse()
        {
            if (head == null)
            {
                return;
            }
            if (head.Next == null)
            {
                return;
            }
            Node prev = null;
            Node current = head;
            Node next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            head = prev;

        }

        public void PrintUsingRecursion()
        {
            if(head==null)
            {
                return;
            }
            else { 
            Console.WriteLine(head.data);
            head = head.Next;
            PrintUsingRecursion();
            }

        }

      

    }




}
//file:///C:/Users/omar/Desktop/A-Common-Sense-Guide-to-Data-Structures-and-Algorithms-Level-Up-Your-Core-Programming-Skills.pdf
//117

//https://www.youtube.com/watch?v=zcUFui6m-38&list=PLwCMLs3sjOY4UQq4vXgGPwGLVX1Y5faaS&index=17

//https://www.youtube.com/watch?v=K7J3nCeRC80&list=PL2_aWCzGMAwI3W_JlcBbtYTwiQSsOTa6P&index=10