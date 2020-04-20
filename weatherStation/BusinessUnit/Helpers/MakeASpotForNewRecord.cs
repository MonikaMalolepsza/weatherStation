namespace weatherStation
{
    partial class main
    {

        static void MakeASpotForNewRecord (ref Record [] weatherData, int positionToBeFreed)
        {

            for (int i = FindLastRecordPlusOne(ref weatherData); i > positionToBeFreed; i--)
            {
                SwapRecords(ref weatherData, i, i-1);
            }
        }
    }
}