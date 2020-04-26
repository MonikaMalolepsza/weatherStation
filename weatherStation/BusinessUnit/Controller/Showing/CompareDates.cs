
using System;

namespace weatherStation
{
    partial class main
    {
        static bool CompareDates(string firstDate, string secondDate)
        {
            string[] firstDateAsArray = firstDate.Split('.');
            string[] secondDateAsArray = secondDate.Split('.');
            if (Convert.ToInt32(firstDateAsArray[2]) < Convert.ToInt32(secondDateAsArray[2]))
            {
                return true;
            }
            else if (Convert.ToInt32(firstDateAsArray[2]) > Convert.ToInt32(secondDateAsArray[2]))
            {
                return false;
            }
            else
            {
                if (Convert.ToInt32(firstDateAsArray[1]) < Convert.ToInt32(secondDateAsArray[1]))
                {
                    return true;
                }
                else if (Convert.ToInt32(firstDateAsArray[1]) > Convert.ToInt32(secondDateAsArray[1]))
                {
                    return false;
                }
                else
                {
                    if (Convert.ToInt32(firstDateAsArray[0]) < Convert.ToInt32(secondDateAsArray[0]))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}