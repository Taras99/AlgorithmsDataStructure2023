using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructure2022.Stack
{
    public class Stack
    {
        public int Maxsize { get; set; }
        public string[] StackArray { get; set; }
        public int Top { get; set; }

        public Stack(int size)
        {
            // this holds constructor value
            this.Maxsize = size;
            // Create array with size
            this.StackArray = new string[Maxsize];
            // we top -1 because  array is zero index ; and we don`t skip first element
            this.Top = -1;
        }

        public void Push(string item ) 
        {
            Top++;
            StackArray[Top] = item;
        }
        public string  Pop()
        {
            int old_top = Top;
            Top--;
            return StackArray[old_top];
        }

        public string Peek() 
        { 
            return StackArray[Top]; 
        }

        public bool isEmpty()
        {
            return Top == 0;
        }

        public bool isFull()
        {
            return (Maxsize - 1  == Top);
        }
        

    }
}
