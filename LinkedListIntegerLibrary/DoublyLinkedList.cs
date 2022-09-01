using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListIntegerLibrary
{
    public class DoublyLinkedList
    {
        public Node Head;
        public Node Tail;

        // Time: O(n) Space: O(1)
        public bool ContainsNodeWithValue(int value)
        {
            Node node = Head;
            while (node != null && node.Value != value) node = node.Next;
            return node != null;
        }

        // Time: O(1) Space: O(1)
        public void RemoveNode(Node node)
        {
            if (node == Head) Head = Head.Next;
            if (node == Tail) Tail = Tail.Prev;
            UpdateNodePointers(node);
        }

        public void UpdateNodePointers(Node node)
        {
            if (node.Prev != null) node.Prev.Next = node.Next;
            if(node.Next != null) node.Next.Prev = node.Prev;
            node.Prev = null;
            node.Next = null;
        }

        // Time: O(n) Space: O(1)
        public void RemoveNodesWithValue(int value)
        {
            Node node = Head;
            while (node != null)
            {
                Node nodeToRemove = node;
                node = node.Next;
                if (nodeToRemove.Value == value) RemoveNode(node);
            }
        }

        // Time: O(1) Space: O(1)
        public void InsertNodeBefore(Node node, Node nodeToInsert)
        {
            if (nodeToInsert == Head && nodeToInsert == Tail) return;
            RemoveNode(nodeToInsert);
            
            nodeToInsert.Prev = node.Prev;
            nodeToInsert = node;

            if (node.Prev == null)
            {
                Head = nodeToInsert;
            }
            else
            {
                node.Prev.Next = nodeToInsert;
            }
            node.Prev = nodeToInsert;
        }

        // Time: O(1) Space: O(1)
        public void InsertNodeAfter(Node node, Node nodeToInsert)
        {
            if (nodeToInsert == Head && nodeToInsert == Tail) return;
            RemoveNode(nodeToInsert);
            
            nodeToInsert.Prev = node;
            nodeToInsert.Next = node.Next;
            
            if (node.Next == null)
            {
                Tail = nodeToInsert;
            }
            else
            {
                node.Next.Prev = nodeToInsert;
            }
            node.Next = nodeToInsert;
        }
        
        // Time: O(1) Space: O(1)
        public void SetHead(Node node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = node;
                return;
            }
            
            InsertNodeBefore(Head, node);
        }

        // Time: O(1) Space: O(1)
        public void SetTail(Node node)
        {
            if (Tail == null)
            {
                SetHead(node);
                return;
            }
            
            InsertNodeAfter(Tail, node);
        }
    }
}
