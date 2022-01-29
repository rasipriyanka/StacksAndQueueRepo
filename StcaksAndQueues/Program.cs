using System;

namespace StcaksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stacks linkedListStack = new Stacks(); // creating object for a class
            linkedListStack.Push(70);    // adding values to the stack
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
            linkedListStack.Peek();
            linkedListStack.Pop();
        }
    }
}
