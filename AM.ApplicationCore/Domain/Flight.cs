using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {

        public Flight()
        {

        }
        public Flight(string destination, string departure, int flightId, DateTime flightDate, DateTime effectiveArrival, int estimatedDuration)
        {
            Destination = destination;
            Departure = departure;
            FlightId = flightId;
            FlightDate = flightDate;
            EffectiveArrival = effectiveArrival;
            EstimatedDuration = estimatedDuration;
        }

        public string Destination { get; set; }
        public string Departure { get; set; }
        public int FlightId { get; set; }
        public DateTime FlightDate { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        public Plane Plane { get; set; }

        public IList<Passenger> Passengers { get; set; }


        public override string? ToString()
        {
            return $"{FlightId} , {Destination} , {Departure} , {FlightDate},{EffectiveArrival},{EstimatedDuration},{Plane},{Passengers}";
        }
    }
}
