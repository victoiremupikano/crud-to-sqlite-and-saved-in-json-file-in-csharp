using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omen_management.Services
{
    class convertDate
    {
        public string mysqlDatetimeFormat(KryptonDateTimePicker dte)
        {
            string result = string.Empty;
            if (dte.Value.Month <= 9)
            {
                result = dte.Value.Year.ToString() + "-" + "0" + dte.Value.Month.ToString() + "-" + dte.Value.Day.ToString() + " " + dte.Value.Hour.ToString() + ":" + dte.Value.Minute.ToString() + ":" + dte.Value.Second.ToString();
            }
            else
            {
                result = dte.Value.Year.ToString() + "-" + dte.Value.Month.ToString() + "-" + dte.Value.Day.ToString() + " " + dte.Value.Hour.ToString() + ":" + dte.Value.Minute.ToString() + ":" + dte.Value.Second.ToString();
            }
            return result;
        }

        public string mysqlDatetimeFormatByNowValue(DateTime dte)
        {
            string result = string.Empty;
            if (dte.Month <= 9)
            {
                result = dte.Year.ToString() + "-" + "0" + dte.Month.ToString() + "-" + dte.Day.ToString() + " " + dte.Hour.ToString() + ":" + dte.Minute.ToString() + ":" + dte.Second.ToString();
            }
            else
            {
                result = dte.Year.ToString() + "-" + dte.Month.ToString() + "-" + dte.Day.ToString() + " " + dte.Hour.ToString() + ":" + dte.Minute.ToString() + ":" + dte.Second.ToString();
            }
            return result;
        }

        public string mysqlDateFormat(KryptonDateTimePicker dte)
        {
            string result = string.Empty;
            if (dte.Value.Month <= 9)
            {
                result = dte.Value.Year.ToString() + "-" + "0" + dte.Value.Month.ToString() + "-" + dte.Value.Day.ToString();
            }
            else
            {
                result = dte.Value.Year.ToString() + "-" + dte.Value.Month.ToString() + "-" + dte.Value.Day.ToString();
            }
            return result;
        }

        public string mysqlDateFormatByNowValue(DateTime dte)
        {
            string result = string.Empty;
            if (dte.Month <= 9)
            {
                result = dte.Year.ToString() + "-" + "0" + dte.Month.ToString() + "-" + dte.Day.ToString();
            }
            else
            {
                result = dte.Year.ToString() + "-" + dte.Month.ToString() + "-" + dte.Day.ToString();
            }
            return result;
        }

        public string dayOnWeekInLetter(DateTime dte)
        {
            int value = ((int)dte.DayOfWeek);
            //var avec le jour en toute lettre
            string inletter = string.Empty;
            switch (value)
            {
                case 0:
                    inletter = "Dimanche";
                    break;
                case 1:
                    inletter = "Lundi";
                    break;
                case 2:
                    inletter = "Mardi";
                    break;
                case 3:
                    inletter = "Mercredi";
                    break;
                case 4:
                    inletter = "Jeudi";
                    break;
                case 5:
                    inletter = "Vendredi";
                    break;
                case 6:
                    inletter = "Samedi";
                    break;
                default:
                    break;
            }
            return inletter;
        }

        public List<DateTime> GetDatesOfMonth(int year, int month)
        {
            var dates = new List<DateTime>();

            // Loop from the first day of the month until we hit the next month, moving forward a day at a time
            for (var date = new DateTime(year, month, 1); date.Month == month; date = date.AddDays(1))
            {
                dates.Add(date);
            }

            return dates;
        }

        public int NbrDaysOfMonth(int year, int month)
        {
            int result = 0;
            return result = DateTime.DaysInMonth(year, month);
        }

        public string timeByDatetime(DateTime dte)
        {
            string hour, minute, second = string.Empty;
            //l'heure
            if (dte.Hour <= 9)
            {
                hour = "0" + dte.Hour.ToString();
            }
            else
            {
                hour = dte.Hour.ToString();
            }
            //la minute
            if (dte.Minute <= 9)
            {
                minute = "0" + dte.Minute.ToString();
            }
            else
            {
                minute = dte.Minute.ToString();
            }
            //la seconde
            if (dte.Second <= 9)
            {
                second = "0" + dte.Second.ToString();
            }
            else
            {
                second = dte.Second.ToString();
            }

            string time = hour + ":" + minute + ":" + second;
            return time;
        }

        //recup year only
        public string mysqlYearOnlyByNowValue(DateTime dte)
        {
            string result = dte.Year.ToString();

            return result;
        }
        //recup month only
        public string mysqlMonthOnlyByNowValue(DateTime dte)
        {
            string result = dte.Month.ToString();

            return result;
        }
        //recup day only
        public string mysqlDayOnlyByNowValue(DateTime dte)
        {
            string result = dte.Day.ToString();

            return result;
        }
    }
}
