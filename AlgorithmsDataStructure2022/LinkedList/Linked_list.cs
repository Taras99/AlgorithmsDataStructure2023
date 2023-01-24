using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
 
namespace AlgorithmsDataStructure2022.LinkedList
{
    public class Linked_list
    {
        public Node? First { get; set; }

        public void insertFirst( int data) 
        {
            Node newNode = new Node();

            newNode.Data = data;
           // Put old node in next
            newNode.Next= First;
            // Make the first new node
            First = newNode;

        }

        public Node DeleteFirst ()
        {
            Node temp = First;
            First = First.Next;
            return temp;
        }

        public void Display()
        {
            Console.WriteLine("Iterating throw list ...");
            Node cuurent = First;
            while ( cuurent != null )
            {
                cuurent.DisplayNode();
                cuurent = cuurent.Next;
            }
        
        }
        public void Insert_last(int data)
        {


            Node cuurent = First;
            while (cuurent != null)
            {
                cuurent = cuurent.Next;
            }
            //  initialising new node 
            Node newNode = new Node();
            newNode.Data = 465;
            cuurent.Next = newNode;
        }

    }
}
