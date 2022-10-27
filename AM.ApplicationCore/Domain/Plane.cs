﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        public Plane()
        {

        }
        public Plane(int capacity, DateTime manufactureDate, int planeId, PlaneType planeType)
        {
            Capacity = capacity;
            ManufactureDate = manufactureDate;
            PlaneId = planeId;
            PlaneType = planeType;
        }

        [Range(0,int.MaxValue)]
        public int? Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }

        public IList<Flight> Flights { get; set; }

        public override string? ToString()

        {
            return $"{PlaneId} , {Capacity} , {PlaneType} , {Flights} ,{ManufactureDate}";
        }
    }
}
