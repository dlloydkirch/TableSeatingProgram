using System;
using System.Collections.Generic;

namespace SeatingProgram.Model
{
    public class Guest
    {
        public string GuestName { get; set; }
        public bool Vaccinated { get; set; }
        public List<string> CanNotSitNextoTo { get; set; }
        public List<string> MustSitNextToo { get; set; }
    }
}