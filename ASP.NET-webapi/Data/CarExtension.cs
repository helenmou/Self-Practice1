﻿using ASP.NET_webapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_webapi.Data
{
    public static class CarExtension
    { //Extension class must be static and with " this " keyword
        public static IEnumerable<CarDto> ToCarDto(this IEnumerable<string> source)
        {
            foreach (var line in source)
            {
                var columns = line.Split(',');
                //yield return a virtral value, only get data when use it
                yield return new CarDto 
                {
                    Id = int.Parse(columns[0]),
                    Year = int.Parse(columns[1]),
                    Manufacturer = columns[2],
                    Name = columns[3],
                    Displacement = double.Parse(columns[4]),
                    Cylinders = int.Parse(columns[5]),
                    City = int.Parse(columns[6]),
                    Highway = int.Parse(columns[7]),
                    Combined = int.Parse(columns[8])
                };
            }
        }
    }
}