namespace StacksAndQueues
{
    using System;
    using System.Collections.Generic;
    using System.Text;
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

        /// <summary>
        /// Dequeues this instance.
        /// </summary>
        public void Dequeue()
        {
            // If queue is empty, return NULL.  
            if (this.head == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            // Store previous head and move head pointer one step ahead to delete the current element 
            Node<T> temp = this.head;
            this.head = this.head.next;

            Console.WriteLine("\nItem deleted is {0}", temp.data);
        }
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("queue is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data);
                    temp = temp.next;
                }
            }
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            if (this.head == null)
                return true;
            return false;
        }
    }
}
