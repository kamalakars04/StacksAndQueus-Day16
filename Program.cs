using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stacks
            Stacks<int> stacks = new Stacks<int>();
            stacks.Push(70);
            stacks.Push(30);
            stacks.Push(56);
            stacks.Display();
            stacks.Peek();
            stacks.Pop();
            stacks.Display();
            stacks.IsEmpty();
            stacks.Display();

            // Queue
            Queues<int> queue = new Queues<int>();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
        }
    }
}
