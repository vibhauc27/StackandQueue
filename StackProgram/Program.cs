using System;

namespace StackProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked list Stack and Queue program");

            Queue queue = new Queue();

            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            queue.Dequeue();

            queue.IsEmpty();
            queue.Display();




        }
    }
}