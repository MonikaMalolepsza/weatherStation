using System;

namespace weatherStation
{
    partial class main
    {
        static bool InputEntryPosition(ref Record[] weatherData, ref int position, string headline)
        {
            bool userInputActive = true;
            string userInput = "";

            do
            {
                Console.Clear();
                Console.WriteLine(headline);
                Console.WriteLine(userInput);
                Console.CursorTop = 2;
                Console.CursorLeft = userInput.Length;
                Console.SetCursorPosition(0, Console.WindowHeight - 4);
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Escape)
                {
                    userInputActive = false;
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    userInput = userInput.Substring(0, userInput.Length > 0 ? userInput.Length - 1 : 0);
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    position = Convert.ToInt32(userInput);
                    return true;
                }
                else if (char.IsDigit(key.KeyChar))
                {
                    userInput += key.KeyChar;
                }
                else
                {
                    //Nothing
                }
            } while (userInputActive);

            return false;
        }
    }
}