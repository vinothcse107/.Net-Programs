using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using x = System.Environment;
namespace ConsoleTest.Data_Structures;

// type parameter T in angle brackets
public class GenericLinkedList<T>
{
      // The nested class is also generic on T.
      private class Node
      {
            public Node(T t) {
                  Next = null;
                  Data = t;
            }
            public Node Next { get;set; }
            public T Data { get; set; }
      }

      private Node head;

      // constructor
      public GenericLinkedList()
      {
            head = null;
      }
      // T as method parameter type:
      public void Add(params T[] t)
      {
            // Gets The Last Node in Linked List
            Node current = head;
            while (current != null && current.Next != null)
                  current = current.Next;
           
            // Adding Multiple Elements to List
            for (int i = 0; i < t.Length; i++)
            {
                  // Node Creation
                  Node n = new Node(t[i]);
                  
                  // if No Elements Were Present
                  // Assigning current as new Node
                  if (head == null) current = head = n;
                  
                  // If Elements Present Adding a pointer to the Next Node
                  // Assigning current as new Node
                  else current.Next = current = n;
            }
      }
      public void Remove(T t)
      {
            Node current = head;
            Node prev = null;

            // If Element is in Head Removes The head and Assign Next Values as Head
            if (head.Data.Equals(t)) {
                  current = head = head.Next;
            }

            // Search of all the Nodes and reassign the Node references
            while (current !=null)
            {
                  // Value Matches Mark the Previous pointer with Next element of the current
                  if(current.Data.Equals(t)) {
                        prev.Next = current.Next;
                  }
                  
                  // Updating Previous and Current Element
                  prev = current;
                  current = current.Next;
            }
      }
      public void InsertAt(T t , int pos)
      {
            Node current = head;
            Node n = new Node(t);
            for (int i = 1; i < pos-1; i++)
            {
                  current = current.Next;
            }
            n.Next = current.Next;
            current.Next = n;
      }

      // Sorts Only The inner Values Not the Nodes Alignment
      public void Sort()
      {
            Node current = head;
            Node index = null;
            int temp;

            if (head == null) {
                  return;
            } else {
                  while (current != null) {
                        // index points to the node Next to current
                        index = current.Next;

                        while (index != null) {
                              if (Convert.ToInt32(current.Data) > Convert.ToInt32(index.Data)) {
                                    temp = Convert.ToInt32(current.Data);
                                    current.Data = index.Data;
                                    index.Data = (T)(object)temp;
                              }
                              index = index.Next;
                        }
                        current = current.Next;
                  }
            }
      }
      
      
      public IEnumerator<T> GetEnumerator()
      {
            Node current = head;

            while (current != null)
            {
                  yield return current.Data;
                  Console.WriteLine($"{current.Data} {current.GetHashCode()}");
                  current = current.Next;
            }
      }
}
