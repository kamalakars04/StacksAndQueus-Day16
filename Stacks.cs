using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    class Stacks<T>
    {
        public Node<T> top;
        /// <summary>
        /// UC 1 Pushes the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        public void Push(T value)
        {
            Node<T> new_node = new Node<T>(value);
            if (this.top != null)
                new_node.next = this.top;
            this.top = new_node;
            Console.WriteLine("Value inserted into the stack " + value);
        }
    }
}
