using System.Collections.Generic;

namespace SeatingProgram.Model
{
    public class FamilyGroup
    {
        public List<Guest> GuestList { get; set; }
        public bool MustSitAlone { get; set; }
        public string FamilyName { get; set; }
        public bool Seated { get; set; }

    }
}