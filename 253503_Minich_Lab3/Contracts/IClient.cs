using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _253503_Minich_Lab3.Entities;

namespace _253503_Minich_Lab3.Contracts
{
    internal interface IClient
    {
        string FullName { get; set; }
        int OrderedRoom { get; set; }
        int OrderedRoomPrice { get; set; }
    }
}
