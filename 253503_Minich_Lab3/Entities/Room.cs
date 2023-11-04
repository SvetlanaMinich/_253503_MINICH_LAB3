using _253503_Minich_Lab3.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _253503_Minich_Lab3.Entities
{
    internal class Room : IRoom
    {
        public int Number { get; }
        public int Price { get; set; }
        public int Popularity { get; set; }
        public bool IsFree { get; set; }
        public Client CurrentClient { get; set; }
        public Room(int i) 
        {
            Random r = new Random(i);
            Number = i;
            Price = r.Next(0,1000);
            Popularity= r.Next(0,200);
            IsFree = true;
            CurrentClient = new Client();
        }
    }
}
