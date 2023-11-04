using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _253503_Minich_Lab3.Entities;

namespace _253503_Minich_Lab3.Contracts
{
    internal interface IHotel
    {
        Dictionary<int,Room> Rooms { get; }
        List<Client> Clients { get; }
        bool OrderRoom(int roomId, string name);
        int MostPopularRoom();
        int WholePriceOrderedRooms();
        string MaxPriceClient();
        int ClientsPayOverPrice(int price);
        List<Room> SortedRoomsByPrice();
        Dictionary<int, int> GroupOfSortedRoomsByPrice();
    }
}
