using System;

namespace StackProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked list stack program");

            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
        }
    }
}