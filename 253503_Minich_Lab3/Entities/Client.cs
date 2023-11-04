using _253503_Minich_Lab3.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _253503_Minich_Lab3.Entities
{
    internal class Client : IClient
    {
        public string FullName { get; set; }
        public int OrderedRoom { get; set; }
        public int OrderedRoomPrice { get; set; }
        public Client() 
        { 
            OrderedRoom= 0;
            OrderedRoomPrice= 0;
            FullName = "";
        }
    }
}
