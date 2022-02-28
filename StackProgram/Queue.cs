using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProgram
{
    public class Queue
    {
        Node head = null;

        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;                
            }
            Console.WriteLine("{0} inserted into Queue", node.data);
        }

        public void Peek()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty!");
                return;
            }
            Console.WriteLine("\n{0} is in the top of the Queue", this.head.data);
        }

        internal void Display()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty, Dequeue is not possible");
                return;
            }
            Console.WriteLine("Dequeued value is : {0}", head.data);
            this.head = head.next;
        }

        public void IsEmpty()
        {
            while (this.head != null)
            {
                Peek();
                Dequeue();
            }
        }
    }
}
