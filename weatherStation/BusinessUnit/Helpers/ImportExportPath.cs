//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        ImportExportPath.cs
//Datum:        20.04.2020
//Beschreibung:
//Aenderungen:  20.04.2020 Erstellung

using System;
using System.IO;

namespace weatherStation
{
    partial class main
    {
        static bool ImportExportPath(bool importExport, ref string path)
        {
            string headline;
            string errorMessage;
            if (importExport)
            {
                headline = "Please enter the relative path to the file,\r\nwhich should be imported.";
                errorMessage = "The file \"" + path + "\" does not exist. Please check your entry!";
            }
            else
            {
                headline = "Please enter the relative path to the Directory,\r\nwhere the file should be saved.";
                errorMessage = "The directory \"" + path + "\" does not exist. Please check your entry!";
            }
            path = "";
            bool pathProcess = true;
            Console.CursorVisible = true;
            string errorShown = "";
            do
            {
                Console.Clear();
                Console.WriteLine(headline);
                Console.WriteLine();
                Console.WriteLine("Confirm the entry with the Enter key.");
                Console.WriteLine("To go back, press the Escape key.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("You are in: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Directory.GetCurrentDirectory());
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("Path and file name: " + path);
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(errorShown);
                Console.ForegroundColor = ConsoleColor.White;
                Console.CursorTop = 10;
                Console.CursorLeft = 6 + path.Length;

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                {
                    pathProcess = false;
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    errorShown = "";
                    path = path.Substring(0, path.Length > 0 ? path.Length - 1 : 0);
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (importExport)
                    {
                        if (File.Exists(Directory.GetCurrentDirectory() + "/" + path))
                        {
                            path = Directory.GetCurrentDirectory() + "/" + path;
                            Console.CursorVisible = false;
                            return true;
                        }
                        else
                        {
                            errorShown = errorMessage;
                        }
                    }
                    else
                    {
                        if (!File.Exists(Directory.GetCurrentDirectory() + "/" + path))
                        {
                            path = Directory.GetCurrentDirectory() + "/" + path;
                            Console.CursorVisible = false;
                            return true;
                        }
                        else
                        {
                            errorShown = errorMessage;
                        }
                    }
                }
                else if (!char.IsControl(key.KeyChar))
                {
                    errorShown = "";
                    path += key.KeyChar;
                }
                else
                {
                    //empty
                }
            } while (pathProcess);
            return false;
        }
    }
}