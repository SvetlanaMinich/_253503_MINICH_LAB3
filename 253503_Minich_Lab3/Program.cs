using _253503_Minich_Lab3.Entities;

namespace _253503_Minich_Lab3
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Journal journal = new();
            Hotel hotel = new();
            hotel.RoomListChangedEvent += journal.LogRoom;
            hotel.OrderRoom(10, "A");
            hotel.OrderRoom(20, "B");
            hotel.OrderRoom(30, "C");
            hotel.OrderRoom(12,"D");
            hotel.OrderRoom(22,"E");
            Console.WriteLine("Logs are");
            Console.WriteLine(journal.GetLogs());
            Console.WriteLine($"Most popular room is: {hotel.MostPopularRoom()}");
            Console.WriteLine("Client that paid more: " + hotel.MaxPriceClient());
            Console.WriteLine($"Number of clients that pay over 500$: {hotel.ClientsPayOverPrice(500)}");
            Console.WriteLine("Sorted rooms by price:");
            List<Room> RoomsSorted = hotel.SortedRoomsByPrice();
            foreach (Room room in RoomsSorted) 
            {
                Console.WriteLine($"Room {room.Number} costs {room.Price}");
            }
            Console.WriteLine($"Whole payment: {hotel.WholePriceOrderedRooms()}");
        }
    }
}
