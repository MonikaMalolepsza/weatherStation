//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        MainMenu.cs
//Datum:        23.04.2020
//Beschreibung:
//Aenderungen:  23.04.2020 Erstellung

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
                    DataEvaluationMenu(ref weatherData);
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