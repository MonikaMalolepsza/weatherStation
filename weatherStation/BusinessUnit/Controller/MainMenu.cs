
using System;

namespace weatherStation
{

    partial class main
    {
        static void MainMenu(ref Record[] weatherData)
        {
            bool activeMenu = true;
            string headline = "Main Menu";
            string[] mainMenuPoints = { "Data display", "Data manipulation", "Data analyse", "Exit" };

            do
            {
                int menuChoice = ShowMenu(ref mainMenuPoints, headline);

                if (menuChoice == 0)
                {
                    DataDisplayMenu(ref weatherData);
                }
                else if (menuChoice == 1)
                {
                    DataManipulationMenu(ref weatherData);
                }
                else if (menuChoice == 2)
                {
                    DataAnalyseMenu(ref weatherData);
                }
                else if (menuChoice == 3)
                {
                    activeMenu = false;
                }
                else
                {
                    //Nichts
                }

            } while (activeMenu);
        }
    }
}