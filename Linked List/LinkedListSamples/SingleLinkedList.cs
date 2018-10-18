using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSamples
{
    public class SingleLinkedList
    {
        public Node head;

        public SingleLinkedList(Node node)
        {
            if (node == null)
                throw new Exception("Can't create linked list with empty node");
            else
                head = node;
        }

        public void Insert_NewNode_at_end(int data)
        {
            //Complete this method
            Node tailNode = head;
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                while (tailNode != null)
                {
                    if (tailNode.next == null)
                    {
                        Node newNode = new Node(data);
                        tailNode.next = newNode;
                        break;
                    }
                    tailNode = tailNode.next;
                }
            }           
        }

        //public static Node insert(Node head, int data)
        //{
        //    //Complete this method
        //    Node tailNode = head;
        //    if (head == null)
        //    {
        //        head = new Node(data);
        //    }
        //    else
        //    {
        //        while (tailNode != null)
        //        {
        //            if (tailNode.next == null)
        //            {
        //                Node newNode = new Node(data);
        //                tailNode.next = newNode;
        //                break;
        //            }
        //            tailNode = tailNode.next;
        //        }
        //    }
        //    return head;
        //}

        public void DisplayAllNodeValue()
        {
            Node temp = head;
            displaynodevlaues(temp);
        }

        private static void displaynodevlaues(Node temp)
        {
            if (temp.next == null)
            {
                Console.WriteLine(temp.data);
                return;
            }
            else
            {
                Console.WriteLine(temp.data);
                displaynodevlaues(temp.next);
            }
        }
    }

    public class Node
    {
        public int data;
        public Node next;

        public Node(int value)
        {
            data = value;
            next = null;
        }
    }
}
