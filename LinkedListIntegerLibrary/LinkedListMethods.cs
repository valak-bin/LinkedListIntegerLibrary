using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListIntegerLibrary
{
    public static class LinkedListMethods
    {
        // This will be a static class that contains methods that return objects

        public static SinglyLinkedNode SumOfSinglyLinkedLists(SinglyLinkedNode linkedListOne, SinglyLinkedNode linkedListTwo)
        // Time: O(Max(n, m)) where Max(n,m) is the length of the longest linked list
        // Space: O(Max(n, m)) 

        {
            // Define the node that allows us to access the head of the output linked list
            SinglyLinkedNode newLinkedListHeadPointer = new SinglyLinkedNode(0);
            
            // We can set the next node of our current node to head of the output linked list
            // when we add the first node into the output linked list
            SinglyLinkedNode currentNode = newLinkedListHeadPointer;

            int additionCarryover = 0;

            // Allow us to iterate through linkedListOne and linkedListTwo
            SinglyLinkedNode nodeOne = linkedListOne;
            SinglyLinkedNode nodeTwo = linkedListTwo;

            // If we have a carry, nodeOne, or nodeTwo, keep looping
            while (nodeOne != null || nodeTwo != null || additionCarryover != 0)
            {
                // Get the values associated with nodeOne and nodeTwo
                int valueOne = (nodeOne != null) ? nodeOne.Value : 0;
                int valueTwo = (nodeTwo != null) ? nodeTwo.Value: 0;

                // Add the two values and the carry
                int sumOfValues = valueOne + valueTwo + additionCarryover;

                // The value that we want to add to the new output node
                int newValue = sumOfValues % 10;


                SinglyLinkedNode newNode = new SinglyLinkedNode(newValue);
                currentNode.Next = newNode;
                currentNode = newNode;

                additionCarryover = sumOfValues / 10;
                
                // Updated nodeOne and nodeTwo so we keep iterating through the linked list
                nodeOne = (nodeOne != null) ? nodeOne.Next : null;
                nodeTwo = (nodeTwo != null) ? nodeTwo.Next : null;
            }

            // Gets the Next value of our dummy node, which is the head of the linked list
            return newLinkedListHeadPointer.Next;
        }

        public static SinglyLinkedNode ReverseSinglyLinkedList(SinglyLinkedNode head)
        // Time: O(n)
        // Space: O(1)
        {
            // Declare P1 and P2 pointers
            SinglyLinkedNode previousNode = null; // previousNode starts before the head
            SinglyLinkedNode currentNode = head;
            
            while (currentNode != null)
            {
                // Declare P3 inside each iteration of the while loop so we don't
                // have to do null checks for P3 every single iteration
                SinglyLinkedNode nextNode = currentNode.Next;
                currentNode.Next = previousNode;
                previousNode = currentNode;
                currentNode = nextNode;
            }

            return previousNode;
        }
    }
}
