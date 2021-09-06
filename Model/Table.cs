using System.Collections.Generic;

namespace SeatingProgram.Model
{
    public class Table
    {
        public List<Guest> Guests { get; set; }
        public int TableNumber { get; set; }
        public int MaxGuestCount = 6;//{ get; set; }
        public bool TableFull { get; set; }
    }
}