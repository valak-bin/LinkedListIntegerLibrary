using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListIntegerLibrary
{
    public class SinglyLinkedList
    {
        public SinglyLinkedNode Head;
        public SinglyLinkedNode Tail;

        // Time: O(n) Space: O(1)
        public bool ContainsNodeWithValue(int value)
        {
            SinglyLinkedNode node = Head;
            while (node != null && node.Value != value) node = node.Next;
            return node != null;
        }        
    }
}
