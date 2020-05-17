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
                                //Nothing
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
                                    //nothing
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
                                    int anotherTry = ShowMenu(ref noYes,
                                        "Record has been edited.\r\nDo you want to edit another record?");
                                    if (anotherTry == 1)
                                    {
                                        processActive = false;
                                    }
                                    else
                                    {
                                        //nothing
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
                                    //nothing
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
                                    //nothing
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
                }
                else if (selection == 4)
                {
                    //Export Data
                }
                else if (selection == 5)
                {
                    menuActive = false;
                }


            } while (menuActive);

        }
    }
}