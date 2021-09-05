using System;
using SeatingProgram.Model;
using System.Collections.Generic;

namespace SeatingProgram
{
    public class Seating
    {

        public List<Table> SetTableArrancement(List<Guest> guestList)
        {
            List<Table> tableList = new List<Table>();

            while (guestList.Count > 0)
            {
                Guest guest = guestList[0];
//            foreach(var guest in guestList)
  //          {
                if(tableList != null && tableList.Count < 1)
                {
                    Console.WriteLine("Setting up first table.");
                    Table firstTable = new Table(){
                        Guests = new List<Guest> (){
                            guest
                        },
                        TableNumber = 1
                    };
                    tableList.Add(firstTable);
                }
                else
                {
                    foreach (var table in tableList)
                    {
                        bool invalidTable = false;
                        if(table.Guests.Count < table.MaxGuestCount)
                        {
                            foreach(var tableGuest in table.Guests)
                            {
                                if(guest.CanNotSitNextoTo != null && guest.CanNotSitNextoTo.Contains(tableGuest.GuestName))
                                {
                                    invalidTable = true;
                                }
                            }
                            if (!invalidTable)
                            {
                                //Logic to make sure guest who must sit next to another guest is handled.
                                // if (guest.MustSitNextToo.Contains(tabl)) && guest.MustSitNextToo.Count > 0)
                                // {
                                //     table.Guests.Add(guest);
                                // }
                                table.Guests.Add(guest);
                            }
                        }
                        else{
                            Console.WriteLine($"Table {table.TableNumber} is full.");
                        }

                    }
                }
                guestList.Remove(guest);
            }

            return tableList;
        }


    }
}