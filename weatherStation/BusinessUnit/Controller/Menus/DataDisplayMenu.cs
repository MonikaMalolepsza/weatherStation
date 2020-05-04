using System;

namespace weatherStation
{

    partial class main
    {
        static void DataDisplayMenu (ref Record[] weatherData)
        {
            bool menuActive = true;
            string headline = "Data display menu";
            string[] menuPoints = { "Sort data", "Search data", "Show data", "Back" };
            string[] sortingAlgorithms = { "Bubble Sort", "Selection Sort", "Back" };
            string[] searchingAlgorithms = { "Linear search", "Binary search", "Back" };
            string[] sortingParams = { "Date", "Air Temperature","Air Pressure", "Humidity", "Back" };

            do
            {
                int choice = ShowMenu(ref menuPoints, headline);

                if (choice == 0)
                {
                    bool sortingProcessActive = true;

                    do
                    {
                        int selectedSortAlgorithm = ShowMenu(ref sortingAlgorithms, "Which sort algorithm should be used?");

                        if (selectedSortAlgorithm == 0)
                        {
                            bool parameterSelectionActive = true;

                            do
                            {
                                int parameterSelection = ShowMenu(ref sortingParams, "Choose sorting parameter:");

                                if (parameterSelection == 4)
                                {
                                    parameterSelectionActive = false;
                                }
                                else
                                {
                                    BubbleSort(ref weatherData, parameterSelection);

                                    parameterSelectionActive = false;
                                    sortingProcessActive = false;
                                }

                            } while (parameterSelectionActive);
                        }
                        else if (selectedSortAlgorithm == 1)
                        {
                            bool parameterSelectionActive = true;

                            do
                            {
                                int parameterSelection = ShowMenu(ref sortingParams, "Choose sorting parameter:");

                                if (parameterSelection == 4)
                                {
                                    //back
                                    parameterSelectionActive = false;
                                }
                                else
                                {
                                    SelectionSort(ref weatherData, parameterSelection);
                                    parameterSelectionActive = false;
                                }

                            } while (parameterSelectionActive);
                        }
                        else if (selectedSortAlgorithm == 2)
                        {
                            sortingProcessActive = false;
                        }
                        else
                        {
                            //empty
                        }

                    } while (sortingProcessActive);
                }
                else if (choice == 1)
                {
                    bool searchingProcess = true;

                    do
                    {
                        int selectedAlgorithm = ShowMenu(ref searchingAlgorithms, "Choose searching algorithm:");

                        if (selectedAlgorithm == 0)
                        {
                            bool parameterSelectionActive = true;

                            do
                            {
                                int parameterSelection = ShowMenu(ref sortingParams, "Choose searching parameter:");

                                if (parameterSelection == 4)
                                {
                                    //back
                                    parameterSelectionActive = false;
                                }
                                else
                                {
                                    bool searchProcess = true;
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Please enter the search value for the parameter " + ParamMapping(parameterSelection));
                                        string userInput = Console.ReadLine();
                                        int positionOfItem = LinearSearch(ref weatherData, parameterSelection, userInput);
                                        Console.Clear();
                                        if (positionOfItem == -1)
                                        {
                                            Console.WriteLine("Error: Record not existing.");
                                            Console.ReadKey(true);
                                            searchProcess = false;

                                        }
                                        else
                                        {
                                            ShowFullData(ref weatherData, positionOfItem);
                                            searchProcess = false;
                                            parameterSelectionActive = false;
                                            searchingProcess = false;
                                        }
                                    } while (searchProcess);
                                }

                            } while (parameterSelectionActive);

                        }
                        else if (selectedAlgorithm == 1)
                        {
                            //Binary search
                        }

                    } while (searchingProcess);
                    //search data

                }
                else if (choice == 2)
                {
                    ShowFullData(ref weatherData);
                }
                else if (choice == 3)
                {
                    menuActive = false;
                }

            } while (menuActive);
        }
    }
}