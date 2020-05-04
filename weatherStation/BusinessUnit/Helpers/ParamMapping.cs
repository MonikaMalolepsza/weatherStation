namespace weatherStation
{
    partial class main
    {
        static string ParamMapping(int parameter)
        {
            switch (parameter)
            {
                case 0:
                    return "Date";
                case 1:
                    return "airTemperature";
                case 2:
                    return "airPressure";
                case 3:
                    return "humidity";
                default:
                    return "Error";
            }
        }
    }
}