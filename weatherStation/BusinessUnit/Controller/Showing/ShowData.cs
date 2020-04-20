//Autor:        Monika Malolepsza
//Klasse:       IA119
//datei:        ShowData.cs
//Datum:        18.04.2020
//Beschreibung: 
//Aenderungen:  18.04.2020 Erstellung
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                if (weatherData[i].date != "")
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
                Console.WriteLine("Pos    Datum           Temperatur           Luftdruck           Luftfeuchtigkeit");
                Console.ForegroundColor = ConsoleColor.White;

                for (int pageContent = currPage * 15;
                    (pageContent < (currPage * 15 + 15)) && (pageContent < 366);
                    pageContent++)
                {
                    if (weatherData[pageContent].date != "")
                    {
                        currentLine += new string(' ', 3 - (pageContent + 1).ToString().Length) + (pageContent + 1)
                                                                                             + "    " + weatherData[
                                                                                                 pageContent].date
                                                                                             + new string(' ',
                                                                                                 8 + (3 - weatherData[
                                                                                                              pageContent]
                                                                                                          .airTemperature
                                                                                                          .ToString(
                                                                                                              "N1")
                                                                                                          .Length)) +
                                                                                             weatherData[pageContent]
                                                                                                 .airTemperature
                                                                                                 .ToString("N1") + "°C"
                                                                                             + new string(' ',
                                                                                                 15 + (3 - weatherData[
                                                                                                               pageContent]
                                                                                                           .airPressure
                                                                                                           .ToString()
                                                                                                           .Length)) +
                                                                                             weatherData[pageContent]
                                                                                                 .airPressure + "HPa"
                                                                                             + new string(' ',
                                                                                                 14 + (2 - weatherData[
                                                                                                               pageContent]
                                                                                                           .humidity
                                                                                                           .ToString()
                                                                                                           .Length)) +
                                                                                             weatherData[pageContent]
                                                                                                 .humidity + "%";
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
                if (weatherData[i].date != "")
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
                Console.WriteLine("Pos    Datum           Temperatur           Luftdruck           Luftfeuchtigkeit");
                Console.ForegroundColor = ConsoleColor.White;
                for (int pageContent = currPage * 15;
                    (pageContent < (currPage * 15 + 15)) && (pageContent < 366);
                    pageContent++)
                {
                    if (weatherData[pageContent].date != "")
                    {
                        if (pageContent == searchedEntry)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                        currData += new string(' ', 3 - (pageContent + 1).ToString().Length) + (pageContent + 1)
                                                                                             + "    " + weatherData[
                                                                                                 pageContent].date
                                                                                             + new string(' ',
                                                                                                 8 + (3 - weatherData[
                                                                                                              pageContent]
                                                                                                          .airTemperature
                                                                                                          .ToString(
                                                                                                              "N1")
                                                                                                          .Length)) +
                                                                                             weatherData[pageContent]
                                                                                                 .airTemperature
                                                                                                 .ToString("N1") + "°C"
                                                                                             + new string(' ',
                                                                                                 15 + (3 - weatherData[
                                                                                                               pageContent]
                                                                                                           .airPressure
                                                                                                           .ToString()
                                                                                                           .Length)) +
                                                                                             weatherData[pageContent]
                                                                                                 .airPressure + "HPa"
                                                                                             + new string(' ',
                                                                                                 14 + (2 - weatherData[
                                                                                                               pageContent]
                                                                                                           .humidity
                                                                                                           .ToString()
                                                                                                           .Length)) +
                                                                                             weatherData[pageContent]
                                                                                                 .humidity + "%";
                        Console.WriteLine(currData);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    currData = "";
                }

                Console.SetCursorPosition(0, Console.BufferHeight - 6);

                Console.Write("Schließen [esc]" + new string(' ', Console.BufferWidth - 28) + "Seite ");
                Console.Write("[" + (currPage + 1 > 9 ? "" : "0") + (currPage + 1) + "/" +
                              (numberPagesFilled > 9 ? "" : "0") + numberPagesFilled + "]");
                Console.WriteLine();
                Console.WriteLine(new string(' ', 25) + ((currPage == 0) ? new string(' ', 15) : "Vorherige Seite") +
                                  "     " +
                                  ((currPage == numberPagesFilled - 1) ? new string(' ', 13) : "Nächste Seite"));
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