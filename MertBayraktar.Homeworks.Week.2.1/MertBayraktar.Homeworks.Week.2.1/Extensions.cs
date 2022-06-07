using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertBayraktar.Homeworks.Week._2._1
{
    public static class Extensions
    {
        public static string Ago(this DateTime date)

        {
            DateTime date1 = new DateTime(2022, 5, 27);

            TimeSpan span = date1.Subtract(date).Duration();
            var abc = new StringBuilder();
            abc.Append($"{span.Days.ToString()} gün {span.Hours.ToString()} saat " +
                $"{span.Minutes.ToString()} dakika {span.Seconds.ToString()} saniye önce");

            return abc.ToString();
        }
    }
}
