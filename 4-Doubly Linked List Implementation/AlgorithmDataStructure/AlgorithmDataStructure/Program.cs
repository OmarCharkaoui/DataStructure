using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListDouble DoubleLinkedList = new LinkedListDouble();
                DoubleLinkedList.append(5);
                DoubleLinkedList.append(30);
                DoubleLinkedList.append(25);
                DoubleLinkedList.append(71);

            DoubleLinkedList.Remove_at_pos(1);
           
           DoubleLinkedList.DisplayDataForwade();
         

            Console.ReadLine();
        }
    }


    class LinkedListDouble
    {
        public class Node
        {
            public int data { get; set; }
            public Node next { get; set; }
            public Node prev { get; set; }
        }
     
        public Node Head { get; set; }

        public void DisplayDataForwade()
        {
            Node Temp = new Node();
            Temp = Head;

            while (Temp != null)
            {
                Console.WriteLine(Temp.data);
                Temp = Temp.next;
            }
             

        }

        public void DisplayDataBackWard()
        {
            while (Head.next!= null)
            {
                       
                Head = Head.next;
       
            }
        
            while (Head != null)
            {

                Console.WriteLine(Head.data);
                Head = Head.prev;
             
            }




        }

        public void append(int data)
        {
            Node node = new Node();
            node.data = data;
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Node temp = new Node();
                temp = Head;
                while (temp.next != null)
                {

                    temp = temp.next;
                }
                temp.next = node;
                node.prev = temp;
            }

        }

        public void Remove(int data)
        {
            if (Head == null)
            {
                return;
            }
            Node Temp = new Node();
            Temp = Head;
            while(Temp!=null && Temp.data != data)
            {
                Temp = Temp.next;
            }
            if (Temp == null)
            {
                Console.WriteLine("Data Not Found");
               
            }
            if (Temp!=null && Temp.data == data)
            {
                Temp.prev.next = Temp.next;
            }




        }
        public void insert_at_pos(int data, int pos)
        {
            Node NewNode = new Node();
            NewNode.data = data;

            Node temp = new Node();
            temp = Head;
            if (pos == 0)
            {
                NewNode.next = temp;
                temp.prev = NewNode;
                Head = NewNode;
                return;
            }
            
            for (int i = 0; i < pos; i++)
            {
                temp = temp.next;
            }

            if (temp==null)
            {
                append(data);
                
            }
            else {
             
                temp.prev.next = NewNode;
                NewNode.prev = temp.prev.next;
                NewNode.next = temp;
                temp.prev = NewNode;
            }


        }
        
        public void Remove_at_pos(int pos)
        {
            if (pos == 0)
            {
                Head = Head.next;
                Head.prev.next = null;
                Head.prev = null;
                return;
            }
            Node temp = new Node();
            temp = Head;
            for (int i = 0; i <pos ; i++)
            {
                temp = temp.next;

            }
            if(temp == null)
            {
                Console.WriteLine("Position Not Found In the Linked List");
                return;
            }
            else if(temp.next == null)
            {
                temp.prev.next = null;
                temp.prev = null;
                return;
            }
            else
            {
                Node prev = new Node();
                prev = temp.prev;

                Node next = new Node();
                next = temp.next;

                temp.prev = null;
                temp.next = null;

                prev.next = next;
                next.prev = prev;


            }


        }
       
    }
}
