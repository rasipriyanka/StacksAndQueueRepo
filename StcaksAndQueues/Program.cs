﻿using System;

namespace StcaksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stacks linkedListStack = new Stacks();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
        }
    }
}
