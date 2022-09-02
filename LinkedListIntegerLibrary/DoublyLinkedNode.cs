using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListIntegerLibrary
{
    public class DoublyLinkedNode
    {
        public int Value;
        public DoublyLinkedNode? Prev;
        public DoublyLinkedNode? Next;

        public DoublyLinkedNode(int value)
        {
            this.Value = value;
            this.Prev = null;
            this.Next = null;
        }
    }
}
