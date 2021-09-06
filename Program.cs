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
            List<FamilyGroup> families = new List<FamilyGroup>();
            FamilyGroup JelksFamily = new FamilyGroup
            {
                GuestList = new List<Guest>()
                {
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
                    }
                },
                MustSitAlone = false
            };
            families.Add(JelksFamily);


            FamilyGroup DarleneFamily = new FamilyGroup
            {
                GuestList = new List<Guest>()
                {
                    new Guest(){
                        GuestName = "Darlene Kirch",
                        Vaccinated = true,
                        MustSitNextToo = new List<string>(){"Bruce Lynn"}
                    },
                    new Guest(){
                        GuestName = "Bruce Lynn",
                        Vaccinated = true,
                        MustSitNextToo = new List<string>(){"Darlene Kirch"}
                    }
                },
                MustSitAlone = false
            };


            families.Add(DarleneFamily);


            FamilyGroup DanaFamily = new FamilyGroup{
                GuestList = new List<Guest>(){
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
                }},
                MustSitAlone = false
            };
                        families.Add(DanaFamily);


            FamilyGroup WeddingParty = new FamilyGroup()
            {
                GuestList = new List<Guest>(){
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
                },
                MustSitAlone = true
            };

            families.Add(WeddingParty);

            List<Table> results = new List<Table>();
            Seating seating = new Seating();

            foreach (var groupOfFamily in families)
            {
                results = seating.SetFamilyTableArrangements(results, groupOfFamily);
            }


            Console.WriteLine("Here is the break line.");


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
