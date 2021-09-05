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
            List<Guest> guestList = new List<Guest>()
            {
                new Guest(){
                    GuestName = "David L Kirch",
                    Vaccinated = true,
                    MustSitNextToo = new List<string>(){"Kristina Miller"}
                },
                new Guest(){
                    GuestName = "Kristina Miller",
                    Vaccinated = true,
                    MustSitNextToo = new List<string>(){"David L Kirch"}
                },
                new Guest(){
                    GuestName = "Olivia Jelks",
                    Vaccinated = true,
                    MustSitNextToo = new List<string>(){"Devin Kirch", "Devin Jelks"}
                },
                new Guest(){
                    GuestName = "Devin Jelks",
                    Vaccinated = true,
                    MustSitNextToo = new List<string>(){}
                },
                new Guest(){
                    GuestName = "Darlene Kirch",
                    Vaccinated = true,
                    CanNotSitNextoTo = new List<string>(){"Kristina Miller"}
                },

            };


            Seating seating = new Seating();
            List<Table> results = seating.SetTableArrancement(guestList);
            
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
