using _253503_Minich_Lab3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _253503_Minich_Lab3.Contracts
{
    internal interface IRoom
    {
        int Number { get; }
        int Price { get; set; }
        int Popularity { get; set; }
        bool IsFree { get; set; }
        Client CurrentClient { get; set; }
    }
}
