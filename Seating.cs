using System;
using SeatingProgram.Model;
using System.Collections.Generic;

namespace SeatingProgram
{
    public class Seating
    {
        public List<Table> SetFamilyTableArrangements(List<Table> tables, FamilyGroup familyGroup)
        {
            if (familyGroup.MustSitAlone)
            {
                if (familyGroup.GuestList.Count > tables[0].MaxGuestCount)
                {
                    throw new Exception("There are too many people in this family for one table");
                }
                Table firstTable = new Table()
                {
                    Guests = familyGroup.GuestList,
                    TableNumber = tables.Count + 1,
                    TableFull = true
                };
                tables.Add(firstTable);
            }
            else
            {
                List<List<Guest>> tempList = new List<List<Guest>>();
                tempList.Add(familyGroup.GuestList);
                SetTableArrancement(tables, tempList);
            }
            return tables;
        }

        public List<Table> SetTableArrancement(List<Table> tableList, List<List<Guest>> guestListlarge)
        {

            foreach (var guestListOfFamily in guestListlarge)
            {
            List<Guest> guestList = guestListOfFamily;
                while (guestList.Count > 0)
                {
                    Guest guest = guestList[0];
                    //refactor to use family lists
                    //            foreach(var guest in guestList)
                    //          {
                    if(tableList != null && tableList.Count < 1)
                    {
                        Console.WriteLine("Setting up first table.");
                        Table firstTable = new Table(){

                            Guests = new List<Guest> (){
                                guest
                            },
                            TableNumber = tableList.Count + 1
                        };
                        tableList.Add(firstTable);
                    }
                    else
                    {
                        foreach (var table in tableList)
                        {
                            if (table.TableFull){continue;}
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
                            else
                            {
                                Console.WriteLine($"Table {table.TableNumber} is full.");
                                Table newTable = new Table();
                                newTable.Guests = new List<Guest>();
                                newTable.Guests.Add(guest);
                                tableList.Add(newTable);
                                break;
                            }

                        }
                    }
                    guestList.Remove(guest);
                }
            }

            return tableList;
        }


    }
}