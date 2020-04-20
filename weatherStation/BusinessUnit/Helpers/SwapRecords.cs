namespace weatherStation
{
    partial class main
    {

        static void SwapRecords (ref Record [] weatherData, int position1, int position2)
        {
            Record tempRecord = new Record
            {
                date = weatherData[position1].date,
                airPressure = weatherData[position1].airPressure,
                airTemperature = weatherData[position1].airTemperature,
                humidity = weatherData[position1].humidity,
            };

            weatherData[position1].date = weatherData[position2].date;
            weatherData[position1].airPressure = weatherData[position2].airPressure;
            weatherData[position1].airTemperature = weatherData[position2].airTemperature;
            weatherData[position1].humidity = weatherData[position2].humidity;

            weatherData[position2].date = tempRecord.date;
            weatherData[position2].airPressure = tempRecord.airPressure;
            weatherData[position2].airTemperature = tempRecord.airTemperature;
            weatherData[position2].humidity = tempRecord.humidity;

        }
    }
}