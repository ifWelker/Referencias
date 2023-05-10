﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RefExtensionMethods.Extensions
{ //Extensão para uma contagem/duração de uma determinada data até a data atual do sistema
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj) 
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);
            
            if (duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F2", CultureInfo.InvariantCulture) + " hours.";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days.";
            }
        }
    }
}
