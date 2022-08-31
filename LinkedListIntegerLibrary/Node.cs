using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListIntegerLibrary
{
    public class Node
    {
        public int Value;
        public Node? Prev;
        public Node? Next;

        public Node(int value)
        {
            this.Value = value;
        }
    }
}
