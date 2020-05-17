
//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        InputEntryManipulation.cs
//Datum:        10.05.2020
//Aenderungen:  10.05.2020 Erstellung
using System;

namespace weatherStation
{
    partial class main
    {
        static bool InputEntryManipulation(ref Record[] weatherData, ref Record newEntry, ref int position)
        {
            bool editing = true;
            int currentLine = 0;
            string[] userInputs = { "", "", "", "", position.ToString() };
            string[] parameters = { "Data", "Air Temperature", "Air Pressure", "Humidity", "Position" };
            string[] menuPath = { "Data manipulation menu", "Resume input" };

            do
            {
                Console.Clear();
                Console.WriteLine("Please enter the values for a new record:");
                for (int counter = 0; counter < parameters.Length; counter++)
                {
                    if (counter == currentLine)
                    {
                                          Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine(parameters[counter] + ": " + userInputs[counter]);
                    Console.ForegroundColor = ConsoleColor.White;
                }

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                {
                    editing = false;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    if (currentLine < 4)
                    {
                        currentLine++;
                    }
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    if (currentLine > 0)
                    {
                        currentLine--;
                    }
                }
                else if (key.Key == ConsoleKey.Backspace)
                {

                    userInputs[currentLine] = userInputs[currentLine].Substring(0, userInputs[currentLine].Length > 0 ? userInputs[currentLine].Length - 1 : 0);

                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    newEntry.Date = userInputs[0];
                    newEntry.AirTemperature = userInputs[1] == "" ? 0:Convert.ToDouble(userInputs[1]);
                    newEntry.AirPressure = userInputs[2] == "" ? 0:Convert.ToUInt32(userInputs[2]);
                    newEntry.Humidity = userInputs[3] == "" ? 0:Convert.ToUInt32(userInputs[3]);
                    bool validation = ValidateEntry(ref weatherData, ref newEntry);
                    if (userInputs[4] != "" && (Convert.ToInt32(userInputs[4]) > 366 || (Convert.ToInt32(userInputs[4]) < 1)))
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid Position!");
                    }
                    if (!validation)
                    {
                        int option = ShowMenu(ref menuPath, "Invalid Input.");
                        if (option == 0)
                        {
                            return false;
                        }
                        else if (option == 1)
                        {

                        }
                    }
                    else
                    {
                        position = Convert.ToInt32(userInputs[4] == "" ? "-1" : userInputs[4]);
                        return true;
                    }
                }
                else
                {
                    if (currentLine == 0)
                    {
                        if (DateFormatInputValidator(userInputs[currentLine], key.KeyChar))
                        {
                            userInputs[currentLine] += key.KeyChar;
                        }
                    }
                    else if (currentLine == 1)
                    {
                        if (key.KeyChar == ',' || char.IsDigit(key.KeyChar))
                        {
                            userInputs[currentLine] += key.KeyChar;
                        }
                    }
                    else if (currentLine == 2)
                    {
                        if (char.IsDigit(key.KeyChar))
                        {
                            userInputs[currentLine] += key.KeyChar;
                        }
                    }
                    else if (currentLine == 3)
                    {
                        if (char.IsDigit(key.KeyChar))
                        {
                            userInputs[currentLine] += key.KeyChar;
                        }
                    }
                    else if (currentLine == 4)
                    {
                        if (char.IsDigit(key.KeyChar))
                        {
                            userInputs[currentLine] += key.KeyChar;
                        }
                    }
                }
            } while (editing);
            return false;
        }

        static bool InputEntryManipulation(ref Record[] weatherData, ref Record newEntry, string date, string temperature, string pressure, string humidity, string position)
        {
            bool editing = true;
            int currentLine = 0;
            string[] userInputs = { date, temperature, pressure, humidity, position };
            string[] parameters = { "Data", "Air Temperature", "Air Pressure", "Humidity", "Position" };
            string[] menuPath = { "Data manipulation menu", "Resume input" };

            do
            {
                Console.Clear();
                Console.WriteLine("Please enter the values for a new record:");
                for (int counter = 0; counter < parameters.Length; counter++)
                {
                    if (counter == currentLine)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine(parameters[counter] + ": " + userInputs[counter]);
                    Console.ForegroundColor = ConsoleColor.White;
                }

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                {
                    editing = false;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    if (currentLine < 3)
                    {
                        currentLine++;
                    }
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    if (currentLine > 0)
                    {
                        currentLine--;
                    }
                }
                else if (key.Key == ConsoleKey.Backspace)
                {

                    userInputs[currentLine] = userInputs[currentLine].Substring(0, userInputs[currentLine].Length > 0 ? userInputs[currentLine].Length - 1 : 0);

                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    newEntry.Date = userInputs[0];
                    newEntry.AirTemperature = userInputs[1] == "" ? 0:Convert.ToDouble(userInputs[1]);
                    newEntry.AirPressure = userInputs[2] == "" ? 0:Convert.ToUInt32(userInputs[2]);
                    newEntry.Humidity = userInputs[3] == "" ? 0:Convert.ToUInt32(userInputs[3]);
                    bool validation = ValidateEntry(ref weatherData, ref newEntry);

                    if (!validation)
                    {
                        int option = ShowMenu(ref menuPath, "Invalid Input.");
                        if (option == 0)
                        {
                            return false;
                        }
                        else if (option == 1)
                        {

                        }
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    if (currentLine == 0)
                    {
                        if (DateFormatInputValidator(userInputs[currentLine], key.KeyChar))
                        {
                            userInputs[currentLine] += key.KeyChar;
                        }
                    }
                    else if (currentLine == 1)
                    {
                        if (key.KeyChar == ',' || char.IsDigit(key.KeyChar))
                        {
                            userInputs[currentLine] += key.KeyChar;
                        }
                    }
                    else if (currentLine == 2)
                    {
                        if (char.IsDigit(key.KeyChar))
                        {
                            userInputs[currentLine] += key.KeyChar;
                        }
                    }
                    else if (currentLine == 3)
                    {
                        if (char.IsDigit(key.KeyChar))
                        {
                            userInputs[currentLine] += key.KeyChar;
                        }
                    }
                }
            } while (editing);
            return false;
        }
    }
}