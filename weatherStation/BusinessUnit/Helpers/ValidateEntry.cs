using System;
using System.Text.RegularExpressions;

namespace weatherStation
{
    partial class main
    {
        static bool ValidateEntry(ref Record[] weatherData, ref Record entry)
        {
            Defragment(ref weatherData);

            Regex dateRegex = new Regex(@"([0][1-9]|[1|2][0-9]|[3][0-1]).([0][1-9]|[1][0-2]).(19|20)\d\d");


            if (weatherData[weatherData.Length - 1].Date == "")
            {
                if (!dateRegex.Match(entry.Date).Success)
                {
                    return false;
                }
                if (!(entry.AirTemperature <= 60 && entry.AirTemperature >= -50))
                {
                    return false;
                }
                if (!(entry.AirPressure <= 1080 && entry.AirPressure >= 700))
                {
                    return false;
                }
                if (!(entry.Humidity <=100 && entry.Humidity >= 0))
                {
                    return false;
                }

                return true;
            }

            return false;
        }
    }
}