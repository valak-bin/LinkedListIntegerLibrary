using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListIntegerLibrary
{
    public class SinglyLinkedNode
    {
        public int Value;
        public SinglyLinkedNode? Next;

        public SinglyLinkedNode(int value)
        {
            this.Value = value;
            this.Next = null;
        }
    }
}
