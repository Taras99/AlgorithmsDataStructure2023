using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructure2022.Queue
{
    public class Queue
    {
        public int Maxsize { get; set; }
        public int[] QueueArray { get; set; }
        public int Front { get; set; }
        public int Rear { get; set; }
        public int NItems { get; set; }

        public Queue(int size) 
        {
            this.Maxsize= size;
            this.QueueArray= new int[size];
            Front=0;
            Rear=-1;
        }

        public void Enqueue(int item)
        {
            Rear++;
            // insert where rear is incremented
            QueueArray[Rear]= item;
            // increment
            NItems++;
        }

        public int Dequeue() 
        {
            int temp = QueueArray[Front];
            Front++;

            if (Front == Maxsize)
            {
                Front = 0;
            }
            NItems--;

            return temp;

        }

        public int Peek() 
        { 
            return QueueArray[Front];

        }
    }
}
