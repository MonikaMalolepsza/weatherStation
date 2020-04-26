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
                                int parameterSelection = ShowMenu(ref sortingParams, "Choose sorting parameter");

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
                                int parameterSelection = ShowMenu(ref sortingParams, "Choose sorting parameter");

                                if (parameterSelection == 4)
                                {
                                    parameterSelectionActive = false;
                                }
                                else
                                {
                                    SelectionSort(ref weatherData, parameterSelection);
                                }

                            } while (parameterSelectionActive);
                        }
                        else if (selectedSortAlgorithm == 2)
                        {
                            sortingProcessActive = false;
                        }
                        else
                        {

                        }

                    } while (sortingProcessActive);
                }
                else if (choice == 1)
                {
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