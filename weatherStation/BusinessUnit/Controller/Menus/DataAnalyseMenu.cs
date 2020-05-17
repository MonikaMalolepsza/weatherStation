using System;

namespace weatherStation
{

    partial class main
    {
        static void DataAnalyseMenu(ref Record[] weatherData)
        {
            bool menueActive = true;
            bool parameterSelectionActive;

            string[] evaluateValues = {"Arithmetic mean", "Median", "Back"};
            string[] parameters = { "Air temperature", "Air pressure", "Humidity", "Back"};

            do
            {
                parameterSelectionActive = true;
                int selection = ShowMenu(ref evaluateValues, "Please select an evaluation method.");
                if (selection == 0)
                {
                    do
                    {
                        int selectedParameter = ShowMenu(ref parameters, "Which parameter should be evaluated?");
                        if (selectedParameter != 3)
                        {
                            double arithmeticMean = ArithmeticMean(ref weatherData, selectedParameter);
                            Console.Clear();
                            Console.WriteLine("The average value of " + parameters[selectedParameter] + " is " + arithmeticMean);
                            Console.ReadKey(true);
                        }
                        parameterSelectionActive = false;
                    } while (parameterSelectionActive);
                }
                else if (selection == 1)
                {
                    do
                    {
                        int selectedParameter = ShowMenu(ref parameters, "Which parameter should be evaluated?");
                        if (selectedParameter != 3)
                        {
                            double median = Median(ref weatherData, selectedParameter);
                            Console.Clear();
                            Console.WriteLine("The average value of " + parameters[selectedParameter] + " is " + median);
                            Console.ReadKey(true);
                        }
                        parameterSelectionActive = false;
                    } while (parameterSelectionActive);
                }
                else if (selection == 2)
                {
                    menueActive = false;
                }
            } while (menueActive);
        }
    }
}