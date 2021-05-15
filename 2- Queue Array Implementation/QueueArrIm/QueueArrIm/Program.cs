using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueArrIm
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueArr queue = new QueueArr();
           
            queue.Display();

            Console.ReadLine();
        }
    }

    class QueueArr
    {
        private int[] Numbers  { get; set; }
        private int Head { get; set; }
        private int tail { get; set; }

        public QueueArr()
        {
            Numbers = new int[10];
            Head = 0;
            tail = 0;
        }

        public void Enqueue(int val)
        {

            if (tail == Numbers.Length - 1)
            {
                Console.WriteLine("Full Queue");
                return;
            }

            Numbers[tail] = val;
            tail++;


        }


        #region Circelar Queue
        //public void Enqueue(int val)
        //{

        //    if (tail == Numbers.Length - 1)
        //    {
        //        tail = 0;
        //        Head = 0;
        //        Numbers[tail] = val;
        //        tail++;
        //        return;


        //    }

        //    Numbers[tail] = val;
        //    tail++;


        //}
        #endregion
        public void Dequeue()
        {
            Head++;
            if (Head == tail)
            {
                Console.WriteLine("Empty Queue");
                return;
            }
           
           
        }
        public void Display()
        {
           
           
            while (Head < tail)
            {
                Console.WriteLine(Numbers[Head]);
                Head++;
            }
        }

        public void QueueTop()
        {
            if(tail == Head)
            {
                Console.WriteLine("Empty Queue");
                return;
            }
           
            Console.WriteLine(Numbers[Head]);
        }


    }
}
