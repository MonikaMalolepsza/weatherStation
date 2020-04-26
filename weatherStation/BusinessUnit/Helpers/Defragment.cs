namespace weatherStation
{
    partial class main
    {

        static void Defragment (ref Record [] weatherData)
        {
            bool countSwapped = true;

            while (countSwapped)
            {
                countSwapped = false;

                for (int i = 1; i < weatherData.Length-1; i++)
                {
                    if (weatherData[i-1].Date == "" && weatherData[i].Date != "")
                    {
                        countSwapped = true;
                        SwapRecords(ref weatherData, i, i-1);
                    }
                }
            }
        }
    }
}