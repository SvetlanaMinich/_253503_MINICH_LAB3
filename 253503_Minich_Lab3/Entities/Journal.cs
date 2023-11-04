using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _253503_Minich_Lab3.Entities
{
    internal class Journal
    {
        private List<string> messages = new();

        public Journal()
        {
            
        }

        public void LogRoom(int room, string log)
        {
            messages.Add($"Room {room} has been ordered by {log}.\n");
        }

        public string GetLogs()
        {
            string res = "";
            foreach (var item in messages)
            {
                res += item;
            }
            return res;
        }
    }
}
