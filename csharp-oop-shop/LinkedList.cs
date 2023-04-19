using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using items;

namespace linkedlist
{
    public class LinkedList
    {
        internal Item head;
        internal void InsertFront(LinkedList myList, string name, string description, float priceNoIva)
        {
            Item new_item = new Item(name, description, priceNoIva);
            new_item.next = myList.head;
            myList.head = new_item;
        }

        internal void InsertLast(LinkedList myList, string name, string description, float priceNoIva)
        {
            Item new_item = new Item(name, description, priceNoIva);
            if (myList.head == null)
            {
                myList.head = new_item;
                return;
            }
            Item lastItem = GetLastNode(myList);
            lastItem.next = new_item;
        }

        internal Item GetLastNode(LinkedList myList)
        {
            Item temp = myList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        internal void printList(LinkedList myList)
        {
            Item temp = myList.head;
            while (temp.next != null)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Full name: " + temp.getFullName());
                Console.WriteLine("Code: " + temp.getCode());
                Console.WriteLine("Name: " + temp.getName());
                Console.WriteLine("Price no Iva: " + temp.getPriceNoIva());
                Console.WriteLine("Price Iva: " + temp.getPriceIva());
                Console.WriteLine("--------------------------------");
                temp = temp.next;
            }
        }
    }
}
