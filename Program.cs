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
            List<List<Guest>> familyGuestList = new List<List<Guest>>(){};
            List<Guest> JelksFamily = new List<Guest>(){
                new Guest(){
                    GuestName = "Olivia Jelks",
                    Vaccinated = false,
                    MustSitNextToo = new List<string>(){"Devin Kirch", "Devin Jelks"}
                },
                new Guest(){
                    GuestName = "Devin Jelks",
                    Vaccinated = true,
                    MustSitNextToo = new List<string>(){"Olivia Jelks", "Devin Kirch"}
                },
                new Guest(){
                    GuestName = "Devin Kirch",
                    Vaccinated = true,
                    MustSitNextToo = new List<string>(){"Olivia Jelks", "Devin Jelks"}
                },
            };


            List<Guest> DarleneFamily = new List<Guest>(){
                new Guest(){
                    GuestName = "Darlene Kirch",
                    Vaccinated = true,
                    MustSitNextToo = new List<string>(){"Bruce Lynn"}
                },
                new Guest(){
                    GuestName = "Bruce Lynn",
                    Vaccinated = true,
                    MustSitNextToo = new List<string>(){"Darlene Kirch"}
                },
            };




            List<Guest> DanaFamily = new List<Guest>(){
                new Guest(){
                    GuestName = "Dana Greenberg",
                    Vaccinated = true
                },
                new Guest(){
                    GuestName = "Chad Greenberg",
                    Vaccinated = true
                },
                new Guest(){
                    GuestName = "Tyler Greenberg",
                    Vaccinated = true
                },
                new Guest(){
                    GuestName = "Tanner Greenberg",
                    Vaccinated = true
                },
                new Guest(){
                    GuestName = "Taylor Greenberg",
                    Vaccinated = true
                },
            };

            List<Guest> WeddingParty = new List<Guest>()
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
                }
            };

            familyGuestList.Add(DanaFamily);
            familyGuestList.Add(JelksFamily);
            familyGuestList.Add(DarleneFamily);
            familyGuestList.Add(WeddingParty);


            // List<Guest> guestList = new List<Guest>()
            // {
            //     new Guest(){
            //         GuestName = "David L Kirch",
            //         Vaccinated = true,
            //         MustSitNextToo = new List<string>(){"Kristina Miller"}
            //     },
            //     new Guest(){
            //         GuestName = "Kristina Miller",
            //         Vaccinated = true,
            //         MustSitNextToo = new List<string>(){"David L Kirch"}
            //     },
            //     new Guest(){
            //         GuestName = "Darlene Kirch",
            //         Vaccinated = true,
            //         CanNotSitNextoTo = new List<string>(){"Kristina Miller"}
            //     },

            // };


            Seating seating = new Seating();
            List<Table> results = seating.SetTableArrancement(familyGuestList);
            
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
