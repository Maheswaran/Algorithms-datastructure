using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList lnkList = new SingleLinkedList(new Node(2));
            lnkList.Insert_NewNode_at_end(3);
            lnkList.Insert_NewNode_at_end(12);
            lnkList.Insert_NewNode_at_end(14);
            lnkList.Insert_NewNode_at_end(9);
            lnkList.DisplayAllNodeValue();
            Console.Read();
        }
    }
}
