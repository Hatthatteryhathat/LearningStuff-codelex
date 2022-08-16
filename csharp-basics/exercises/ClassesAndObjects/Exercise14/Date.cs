using System;
using System.Globalization;


namespace Exercise14
{
    internal class Date
    {
        private DateTime _date;

        public Date(int year, int month, int day) 
        { 
            _date = new DateTime(year, month, day);
        }

        public string WeekdayInDutch() 
        {
            CultureInfo dutchCulture = new System.Globalization.CultureInfo("nl-NL");
            string dayName = dutchCulture.DateTimeFormat.GetDayName(_date.DayOfWeek);

            return dayName;
        }
    }
}
