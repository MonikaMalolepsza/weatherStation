//Autor:        Monika Malolepsza
//Klasse:       IA119
//datei:        ShowData.cs
//Datum:        18.04.2020
//Beschreibung: 
//Aenderungen:  18.04.2020 Erstellung
using System;


namespace weatherStation
{
    partial class main
    {
        static void ShowFullData(ref Record[] weatherData)
        {
            bool contentIsShown = true;
            int currPage = 0;
            string currentLine = "";
            Defragment(ref weatherData);
            int numberRecordsFilled = 0;
            for (int i = 0; i < 366; i++)
            {
                if (weatherData[i].Date != "")
                {
                    numberRecordsFilled++;
                }
            }

            if (numberRecordsFilled % 15 == 0)
            {
                numberRecordsFilled /= 15;
            }
            else
            {
                numberRecordsFilled /= 15;
                numberRecordsFilled++;
            }


            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Pos    Date            Temperature          Air pressure                Humidity");
                Console.ForegroundColor = ConsoleColor.White;

                for (int pageContent = currPage * 15;
                    (pageContent < (currPage * 15 + 15)) && (pageContent < 366);
                    pageContent++)
                {
                    if (weatherData[pageContent].Date != "")
                    {
                        currentLine += new string(' ', 3 - (pageContent + 1).ToString().Length) + (pageContent + 1)
                                                                                             + "    " + weatherData[
                                                                                                 pageContent].Date
                                                                                             + new string(' ',
                                                                                                 8 + (3 - weatherData[
                                                                                                              pageContent]
                                                                                                          .AirTemperature
                                                                                                          .ToString(
                                                                                                              "N1")
                                                                                                          .Length)) +
                                                                                             weatherData[pageContent]
                                                                                                 .AirTemperature
                                                                                                 .ToString("N1") + "°C"
                                                                                             + new string(' ',
                                                                                                 15 + (3 - weatherData[
                                                                                                               pageContent]
                                                                                                           .AirPressure
                                                                                                           .ToString()
                                                                                                           .Length)) +
                                                                                             weatherData[pageContent]
                                                                                                 .AirPressure + "HPa"
                                                                                             + new string(' ',
                                                                                                 22 + (2 - weatherData[
                                                                                                               pageContent]
                                                                                                           .Humidity
                                                                                                           .ToString()
                                                                                                           .Length)) +
                                                                                             weatherData[pageContent]
                                                                                                 .Humidity + "%";
                        Console.WriteLine(currentLine);
                    }

                    currentLine = "";
                }

                Console.SetCursorPosition(0, Console.BufferHeight - 6);

                Console.Write("Close [esc]" + new string(' ', Console.BufferWidth - 28) + "Seite ");
                Console.Write("[" + (currPage + 1 > 9 ? "" : "0") + (currPage + 1) + "/" +
                              (numberRecordsFilled > 9 ? "" : "0") + numberRecordsFilled + "]");
                Console.WriteLine();
                Console.WriteLine(new string(' ', 25) + ((currPage == 0) ? new string(' ', 15) : "Vorherige Seite") +
                                  "     " +
                                  ((currPage == numberRecordsFilled - 1) ? new string(' ', 13) : "Nächste Seite"));
                Console.WriteLine(new string(' ', 37) + ((currPage == 0) ? "   " : "<--") + "     " +
                                  ((currPage == numberRecordsFilled - 1) ? "   " : "-->"));


                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key.ToString() == "LeftArrow")
                {
                    if (currPage != 0)
                    {
                        currPage--;
                    }
                }
                else if (key.Key.ToString() == "RightArrow")
                {
                    if (currPage < numberRecordsFilled - 1)
                    {
                        currPage++;
                    }
                }
                else if (key.Key.ToString() == "Escape")
                {
                    contentIsShown = false;
                }
            } while (contentIsShown);
        }

        static void ShowFullData(ref Record[] weatherData, int searchedEntry)
        {
            bool contentIsShown = true;
            int currPage = searchedEntry / 15;
            string currData = "";
            Defragment(ref weatherData);
            int numberPagesFilled = 0;
            for (int i = 0; i < 366; i++)
            {
                if (weatherData[i].Date != "")
                {
                    numberPagesFilled++;
                }
            }

            if (numberPagesFilled % 15 == 0)
            {
                numberPagesFilled /= 15;
            }
            else
            {
                numberPagesFilled /= 15;
                numberPagesFilled++;
            }

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pos    Date            Temperature          Air pressure                Humidity");
                Console.ForegroundColor = ConsoleColor.White;
                for (int pageContent = currPage * 15;
                    (pageContent < (currPage * 15 + 15)) && (pageContent < 366);
                    pageContent++)
                {
                    if (weatherData[pageContent].Date != "")
                    {
                        if (pageContent == searchedEntry)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                        currData += new string(' ', 3 - (pageContent + 1).ToString().Length) + (pageContent + 1)
                                                                                             + "    " + weatherData[
                                                                                                 pageContent].Date
                                                                                             + new string(' ',
                                                                                                 8 + (3 - weatherData[
                                                                                                              pageContent]
                                                                                                          .AirTemperature
                                                                                                          .ToString(
                                                                                                              "N1")
                                                                                                          .Length)) +
                                                                                             weatherData[pageContent]
                                                                                                 .AirTemperature
                                                                                                 .ToString("N1") + "°C"
                                                                                             + new string(' ',
                                                                                                 15 + (3 - weatherData[
                                                                                                               pageContent]
                                                                                                           .AirPressure
                                                                                                           .ToString()
                                                                                                           .Length)) +
                                                                                             weatherData[pageContent]
                                                                                                 .AirPressure + "HPa"
                                                                                             + new string(' ',
                                                                                                 14 + (2 - weatherData[
                                                                                                               pageContent]
                                                                                                           .Humidity
                                                                                                           .ToString()
                                                                                                           .Length)) +
                                                                                             weatherData[pageContent]
                                                                                                 .Humidity + "%";
                        Console.WriteLine(currData);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    currData = "";
                }

                Console.SetCursorPosition(0, Console.BufferHeight - 6);

                Console.Write("Close [esc]" + new string(' ', Console.BufferWidth - 28) + "Page ");
                Console.Write("[" + (currPage + 1 > 9 ? "" : "0") + (currPage + 1) + "/" +
                              (numberPagesFilled > 9 ? "" : "0") + numberPagesFilled + "]");
                Console.WriteLine();
                Console.WriteLine(new string(' ', 25) + ((currPage == 0) ? new string(' ', 15) : "Previous page") +
                                  "     " +
                                  ((currPage == numberPagesFilled - 1) ? new string(' ', 13) : "Next Page"));
                Console.WriteLine(new string(' ', 37) + ((currPage == 0) ? "   " : "<--") + "     " +
                                  ((currPage == numberPagesFilled - 1) ? "   " : "-->"));

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key.ToString() == "LeftArrow")
                {
                    if (currPage != 0)
                    {
                        currPage--;
                    }
                }
                else if (key.Key.ToString() == "RightArrow")
                {
                    if (currPage < numberPagesFilled - 1)
                    {
                        currPage++;
                    }
                }
                else if (key.Key.ToString() == "Escape")
                {
                    contentIsShown = false;
                }
            } while (contentIsShown);
        }
    }
}