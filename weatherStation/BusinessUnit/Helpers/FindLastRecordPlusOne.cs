namespace weatherStation
{
    partial class main
    {

        static int FindLastRecordPlusOne (ref Record [] weatherData)
        {
            Defragment(ref weatherData);

            for (int i = 0; i < weatherData.Length; i++)
            {
                if (weatherData[i].date == "")
                {
                    return i;
                }
            }

            return 366;
        }
    }
}