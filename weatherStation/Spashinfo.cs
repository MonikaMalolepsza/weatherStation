//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Splashinfo.cs
//Datum:        19.04.2020
//Beschreibung: Gibt eine Splashinfo über das Projekt auf der Konsole aus
//Aenderungen:  19.04.2020 Erstellung

using System;
using System.Threading;

namespace weatherStation
{
    partial class main
    {
        static void Splashinfo()
        {
            string[] titles = { "Project name:", "Version:", "Data:", "Author:", "Class:" };
            string[] information = { "Weather Station", "1.0", "17.05.2020", "Monika Malolepsza", "IA119" };
            Console.CursorTop = 5;
            for (int i = 0; i < information.Length; i++)
            {
                Console.CursorLeft = (Console.WindowWidth - 32) / 2;
                Console.WriteLine("{0,-12}{1,20}", titles[i], information[i]);
                Thread.Sleep(400);
            }
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, Console.WindowHeight - 2);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

        }
    }
}