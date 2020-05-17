using System;
using System.IO;

namespace weatherStation
{

    partial class main
    {
        static void DataManipulationMenu(ref Record[] weatherData)
        {
            bool menuActive = true;
            bool processActive;

            string[] menuSelection = { "Add Data", "Edit Data", "Delete Data", "Import Data", "Export Data", "Back" };
            string[] noYes = { "yes", "no" };
            string path = "";

            int selection;
            int position = FindLastRecordPlusOne(ref weatherData);
            Record newRecord;

            do
            {
                processActive = true;

                selection = ShowMenu(ref menuSelection, "Manipulate Data");

                if (selection == 0)
                {
                    //Add Data

                    do
                    {

                        newRecord = new Record{Date="", AirPressure = 0, AirTemperature = 0.0d, Humidity = 0};
                        if (InputEntryManipulation(ref weatherData, ref newRecord, ref position))
                        {
                            AddEntry(ref weatherData, position, ref newRecord);
                            int again = ShowMenu(ref noYes, "Record added.\r\nAdd another Record?");
                            if (again == 1)
                            {
                                processActive = false;
                            }
                            else
                            {
                                //Empty
                            }
                        }
                        else
                        {
                            processActive = false;
                        }


                    } while (processActive);
                }
                else if (selection == 1)
                {
                    //Edit Data
                    do
                    {
                        if (InputEntryPosition(ref weatherData, ref position,
                            "Enter the position of the record to be edited."))
                        {
                            if (weatherData[position - 1].Date == "")
                            {
                                int anotherTry = ShowMenu(ref noYes,
                                    "Invalid position.\r\nDo you want to enter another position?");
                                if (anotherTry == 1)
                                {
                                    processActive = false;
                                }
                                else
                                {
                                    //Empty
                                }
                            }
                            else
                            {
                                newRecord = weatherData[position - 1];
                                if (InputEntryManipulation(ref weatherData, ref newRecord, newRecord.Date,
                                    newRecord.AirTemperature.ToString(), newRecord.AirPressure.ToString(),
                                    newRecord.Humidity.ToString(), position.ToString()))
                                {
                                    AlterEntry(ref weatherData, position, ref newRecord);
                                    ShowFullData(ref weatherData);
                                    int anotherTry = ShowMenu(ref noYes,
                                        "Record has been edited.\r\nDo you want to edit another record?");
                                    if (anotherTry == 1)
                                    {
                                        processActive = false;
                                    }
                                    else
                                    {
                                        //Empty
                                    }
                                }
                            }
                        }
                        else
                        {
                            processActive = false;
                        }

                    } while (processActive);

                }
                else if (selection == 2)
                {
                    //Delete Data
                    do
                    {
                        if (InputEntryPosition(ref weatherData, ref position,
                            "Enter the position of the record to be deleted."))
                        {
                            if (weatherData[position - 1].Date == "")
                            {
                                int anotherTry = ShowMenu(ref noYes,
                                    "Invalid position.\r\nDo you want to enter another position?");
                                if (anotherTry == 1)
                                {
                                    processActive = false;
                                }
                                else
                                {
                                    //Empty
                                }
                            }
                            else
                            {
                                DeleteEntry(ref weatherData, position);
                                int anotherTry = ShowMenu(ref noYes,
                                    "Record has been deleted.\r\nDo you want to delete another record?");
                                if (anotherTry == 1)
                                {
                                    processActive = false;
                                }
                                else
                                {
                                    //Empty
                                }
                            }
                        }
                        else
                        {
                            processActive = false;
                        }
                    } while (processActive);
                }
                else if (selection == 3)
                {
                    //Import Data
                    if (ImportExportPath(true, ref path))
                    {
                        if (ShowMenu(ref noYes, "Are you sure you want to import this file?\r\nExisting records will be permanently deleted,\r\nif no data backup exists.") == 0)
                        {
                            Console.Clear();
                            string error = ImportData(ref weatherData, path);
                            Console.WriteLine("Import completed!");
                            if (error != "")
                            {
                                Console.WriteLine(error);
                            }
                            else
                            {
                                //Empty
                            }
                            Console.SetCursorPosition(Console.CursorLeft, Console.WindowHeight - 2);
                            Console.WriteLine("Press any button to continue.");
                            Console.ReadKey(true);
                        }
                        else
                        {
                            //Empty
                        }
                    }
                    else
                    {
                        //Empty
                    }

                }
                else if (selection == 4)
                {
                    //Export Data
                    if (ImportExportPath(false, ref path))
                    {
                        ExportData(ref weatherData, path);
                        Console.Clear();
                        Console.WriteLine("Export completed!");
                        Console.WriteLine("The file is located in the following directory:\r\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(path.Substring(0, path.LastIndexOf("/")));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(Console.CursorLeft, Console.WindowHeight - 2);
                        Console.WriteLine("Press any button to continue.");
                        Console.ReadKey(true);
                    }
                    else
                    {
                        //empty
                    }
                }
                else if (selection == 5)
                {
                    menuActive = false;
                }


            } while (menuActive);

        }
    }
}