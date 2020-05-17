//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        DateFormatInputValidator.cs
//Datum:        16.05.2020
//Beschreibung:
//Aenderungen:  16.05.2020 Erstellung



namespace weatherStation
{

        partial class main
        {
            static bool DateFormatInputValidator (string date, char inputChar)
            {
                return ((inputChar == '.' && (date.Length == 2 || date.Length == 5))
                        || (char.IsDigit(inputChar) && date.Length != 2 && date.Length != 5)) && date.Length < 10;
            }
        }

}


