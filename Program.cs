using System;
using SeatingProgram.Model;
using System.Collections.Generic;

namespace SeatingProgram
{
    class Program
    {
        public static void Main (string[] args)
        {

            Console.WriteLine("Setting up guest list");
            List<Guest> familyGuestList = new List<Guest>(){};
            SetupData setup = new SetupData();
            List<FamilyGroup> families = setup.SetupFamilyGroups();
 


            List<Table> results = new List<Table>();
            Seating seating = new Seating();

            foreach (var groupOfFamily in families)
            {
                results = seating.SetFamilyTableArrangements(results, groupOfFamily);
            }


            Console.WriteLine("Here is the break line.");

            familyGuestList = setup.SetupIndividualGuests();

            results = seating.SetTableArrancement(results, familyGuestList);
            
            foreach (var result in results)
            {
                Console.WriteLine("Table number - " + result.TableNumber);
                Console.WriteLine("Guest count - " + result.Guests.Count);
                foreach (var guest in result.Guests)
                {
                    Console.WriteLine("Guest name " + guest.GuestName);
                }
            }


        }
    }
}
