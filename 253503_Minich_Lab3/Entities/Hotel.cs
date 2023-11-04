using _253503_Minich_Lab3.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _253503_Minich_Lab3.Entities
{
    internal class Hotel : IHotel
    {
        public delegate void RoomListChangedDelegate(int room, string message);
        public event RoomListChangedDelegate RoomListChangedEvent;
        public Dictionary<int, Room> Rooms { get; } = new Dictionary<int, Room>();
        public List<Client> Clients { get; } = new List<Client>();
        public string MaxPriceClient()
        {
            Client? ClientWithMaxPrice = Clients.OrderByDescending(client => client.OrderedRoomPrice).FirstOrDefault();
            string ClientWithMaxPriceName = "";
            if(ClientWithMaxPrice != null)
            {
                ClientWithMaxPriceName = ClientWithMaxPrice.FullName;
            }
            return ClientWithMaxPriceName;
        }
        public int MostPopularRoom()
        {
            Room? RoomWithMaxPopularity = Rooms.Values.OrderByDescending(room=>room.Popularity).FirstOrDefault();
            int RoomWithMaxPopularityNumber = 0;
            if(RoomWithMaxPopularity!=null)
            {
                RoomWithMaxPopularityNumber = RoomWithMaxPopularity.Number;
            }
            return RoomWithMaxPopularityNumber;
        }
        public bool OrderRoom(int roomId, string name)
        {
            if(Rooms.ContainsKey(roomId))
            {
                Room room = Rooms[roomId];
                if(room.IsFree)
                {
                    Client client = new()
                    {
                        FullName = name,
                        OrderedRoomPrice = room.Price,
                        OrderedRoom = room.Number
                    };
                    Clients.Add(client);
                    room.CurrentClient = client;
                    room.Popularity++;
                    room.IsFree = false;
                    RoomListChangedEvent(roomId,name);
                    return true;
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
            return false;
        }
        public int ClientsPayOverPrice(int price)
        {
            int ClientsPayOverPriceNumber = Clients.Aggregate(0, (count, client) =>
            {
                if(client.OrderedRoomPrice>price)
                {
                    count++;
                }
                return count;
            });
            return ClientsPayOverPriceNumber;
        }
        public List<Room> SortedRoomsByPrice()
        {
            List<Room> SortedRooms = Rooms.Values.OrderByDescending(room => room.Price).ToList();
            return SortedRooms;
        }
        public int WholePriceOrderedRooms()
        {
            int WholePrice = Rooms.Values.Aggregate(0,(price,room)=>
            {
                if(room.IsFree==false)
                {
                    price += room.Price;
                }
                return price;
            });
            return WholePrice;
        }
        public Dictionary<int,int> GroupOfSortedRoomsByPrice()
        {
            Dictionary<int, int> SortedRoomsByPrice = Rooms.Values.GroupBy(room => room.Price)
                .ToDictionary(group => group.Key, group => group.Count());
            return SortedRoomsByPrice;
        }
        public Hotel()
        {
            for(int i = 1;i<=30;i++)
            {
                Rooms.Add(i, new Room(i));
            }
        }
    }
}
