using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListIntegerLibrary
{
    public class DoublyLinkedList
    {
        public DoublyLinkedNode Head;
        public DoublyLinkedNode Tail;

        // Time: O(n) Space: O(1)
        public bool ContainsNodeWithValue(int value)
        {
            DoublyLinkedNode node = Head;
            while (node != null && node.Value != value) node = node.Next;
            return node != null;
        }

        // Time: O(1) Space: O(1)
        public void RemoveNode(DoublyLinkedNode node)
        {
            if (node == Head) Head = Head.Next;
            if (node == Tail) Tail = Tail.Prev;
            UpdateNodePointers(node);
        }

        public void UpdateNodePointers(DoublyLinkedNode node)
        {
            if (node.Prev != null) node.Prev.Next = node.Next;
            if (node.Next != null) node.Next.Prev = node.Prev;
            node.Prev = null;
            node.Next = null;
        }

        // Time: O(n) Space: O(1)
        public void RemoveNodesWithValue(int value)
        {
            DoublyLinkedNode node = Head;
            while (node != null)
            {
                DoublyLinkedNode nodeToRemove = node;
                node = node.Next;
                if (nodeToRemove.Value == value) RemoveNode(nodeToRemove);
            }
        }

        // Time: O(1) Space: O(1)
        public void InsertNodeBefore(DoublyLinkedNode node, DoublyLinkedNode nodeToInsert)
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
        public void InsertNodeAfter(DoublyLinkedNode node, DoublyLinkedNode nodeToInsert)
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
        public void SetHead(DoublyLinkedNode node)
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
        public void SetTail(DoublyLinkedNode node)
        {
            if (Tail == null)
            {
                SetHead(node);
                return;
            }
            
            InsertNodeAfter(Tail, node);
        }

        // Time: O(p) Space: O(1)
        public void InsertAtPosition(int position, DoublyLinkedNode nodeToInsert)
        {
            if (position == 1)
            {
                SetHead(nodeToInsert);
                return;
            }

            DoublyLinkedNode node = Head;
            int currentPosition = 1;

            while (node != null && currentPosition++ != position)
            {
                node = node.Next;
            }

            if (node != null)
            {
                InsertNodeBefore(node, nodeToInsert);
            }
            else SetTail(nodeToInsert);
        }
    }
}
