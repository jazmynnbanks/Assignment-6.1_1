using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Assignment_6._1_1;

namespace Assignment_6._1_1
{
    internal class LinkedList
    {
        private Node Head;
        public LinkedList()
        {
            Head = null;
        }



        public void AddHouse(int number, string type, string address)
        {
            Node newHouse = new Node(number, type, address);
            if (Head == null)
            {
                Head = newHouse;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newHouse;
            }
        }
    


    public void SearchHouse(int number)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.HouseNumber == number)
                {
                    Console.WriteLine($"House {number} found! ");
                    Console.WriteLine($"House number: {current.HouseNumber}");
                    Console.WriteLine($"House type: {current.HouseType}");
                    Console.WriteLine($"Address: {current.Address}");
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine($"House {number} not found");
     
        }
    }
}
