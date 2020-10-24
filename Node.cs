using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    class Node<T>
    {
        T data;
        public Node<T> next;
        public Node(T data)
        {
            this.data = data;
        }
    }
}
