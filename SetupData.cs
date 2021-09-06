using System;
using System.Collections.Generic;
using SeatingProgram;
using SeatingProgram.Model;

namespace SeatingProgram{
    public class SetupData
    {

        public List<FamilyGroup> SetupFamilyGroups()
        {
            List<FamilyGroup> familyGroups = new List<FamilyGroup>();
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
            familyGroups.Add(JelksFamily);


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


            familyGroups.Add(DarleneFamily);


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
                MustSitAlone = true
            };
            familyGroups.Add(DanaFamily);


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
                        familyGroups.Add(WeddingParty);





            FamilyGroup RogerDysartFamily = new FamilyGroup
            {
              GuestList = new List<Guest>()
            {
            new Guest(){
               GuestName = "Roger Dysart",
               Vaccinated = true,
               MustSitNextToo = new List<string>(){"Anika Dysrat"}
            },
            new Guest(){
                GuestName = "Anika Dysart",
              Vaccinated = true,
                MustSitNextToo = new List<string>(){"Roger Dysart"}
            },
            new Guest(){
                GuestName = "Quintin Dysart",
                Vaccinated = true,
                MustSitNextToo = new List<string>(){}
            },
            new Guest(){
                GuestName = "Linea Dysart",
                Vaccinated = true,
                MustSitNextToo = new List<string>(){}
            },
            new Guest(){
                GuestName = "Darius Dysart",
                Vaccinated = true,
                MustSitNextToo = new List<string>(){}}
            },
            MustSitAlone = true
            };
            familyGroups.Add(RogerDysartFamily);
                        return familyGroups;

    }
        public List<Guest> SetupIndividualGuests()
        {
            List<Guest> guestList = new List<Guest>();

            guestList.Add(new Guest(){
                GuestName = "Theresa",
                Vaccinated = true
            });            guestList.Add(new Guest(){
                GuestName = "Kristen",
                Vaccinated = true
            });            guestList.Add(new Guest(){
                GuestName = "Paul",
                Vaccinated = true
            });            guestList.Add(new Guest(){
                GuestName = "Adrien",
                Vaccinated = true
            });

            return guestList;
        }
    }




}