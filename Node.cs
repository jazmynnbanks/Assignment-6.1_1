using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._1_1
{
    public class Node
    {
        public int HouseNumber { get; set; }
        public string HouseType { get; set; }
        public string Address { get; set; }
        public Node Next { get; set; }


        public Node(int number, string houseType, string address)
        {
            HouseNumber = number;
            HouseType = houseType;
            Address = address;
            Next = null;
        }
    }
}
