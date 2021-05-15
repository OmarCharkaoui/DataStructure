using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackArrayIm
{
    class Program
    {
        static void Main(string[] args)
        {
         
            StackArr stack = new StackArr();

     
            Console.ReadLine();
        }
    }

    class StackArr
    {
        private int[] numbers { get; set; }
        private int Top { get; set; }

        public StackArr()
        {
            numbers = new int[10];
            Top = 0;
        }

        public void Push(int val)
        {
            if (Top > numbers.Length-1)
            {
                Console.WriteLine("Stack is Full");
                return;
            }
            
            numbers[Top] = val;
            Top++;
        }
       
        public void Pop()
        {
            if (Top == 0)
            {
                Console.WriteLine("Empty Array");
                return;
            }
            Top--;
        }

        public void Display()
        {

            while (0 < Top)
            {
                Console.WriteLine(numbers[Top-1]);
                Top--;
            }
        }

        public void DisplayTop()
        {
            if (Top == 0) { Console.WriteLine("Empty List"); return; }
            Console.WriteLine(numbers[Top-1]);
        } 
    }
}
