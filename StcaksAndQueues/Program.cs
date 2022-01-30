using System;

namespace StcaksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue linkedListStack = new Queue(); // creating object for a class

            linkedListStack.Enqueue(56);    // adding values to the Queue
            linkedListStack.Enqueue(30);
            linkedListStack.Enqueue(70);
            linkedListStack.Display();
            linkedListStack.Dequeue();
        }
    }
}
