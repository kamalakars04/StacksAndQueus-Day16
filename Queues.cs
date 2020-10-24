using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    class Queues<T>
    {
        Node<T> head;

        /// <summary>
        /// UC 1 Enqueues the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Enqueue(T item)
        {
            Node<T> new_node = new Node<T>(item);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node<T> temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
            Console.WriteLine("inserted into list " + new_node.data);
        }
    }
}
