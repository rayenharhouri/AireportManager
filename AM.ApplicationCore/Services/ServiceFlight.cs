using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight
    {
        public List<Flight> Flights { get; set; } = TestData.Flights;


        public List<DateTime> GetFlightDatesWithFor
           (string destination) { 
            List<DateTime> dates = new List<DateTime>();

            for (int i=0;i< Flights.Count ; i++) {
                if (Flights[i].Destination.ToUpper().Equals(destination.ToUpper()))
                {
                    dates.Add(Flights[i].FlightDate);
                }

            }
            return dates;
        }

        public List<DateTime> GetFlightDatesWithForEach(string destination)
        {
            List<DateTime> dates = new List<DateTime>();

            foreach (Flight flight in Flights)
            {
                if (flight.Destination.ToUpper().Equals(destination.ToUpper()))
                {
                    dates.Add(flight.FlightDate);
                }

            }
            return dates;
        }

        public List<Flight> GetFlights(string typeOfFilter,string filterValue)
        {
            List<Flight> flights = new List<Flight>();

            switch (typeOfFilter.ToUpper())
            {
                case "DESTINATION":
                    foreach (Flight flight in Flights)
                    {
                        if (flight.Destination.ToUpper().Equals(filterValue.ToUpper()))
                        {
                            flights.Add(flight);
                        }
                    }
                    break;

                case "FLIGHT DATE":
                    foreach (Flight flight in Flights)
                    {
                       if (flight.FlightDate==DateTime.Parse(filterValue))
                        {
                            flights.Add(flight);
                        }
                    }
                    break;

                case "EFFECTIVE ARRIVAL":
                    foreach (Flight flight in Flights)
                    {
                        if (flight.EffectiveArrival == DateTime.Parse(filterValue))
                        {
                            flights.Add(flight);
                        }
                    }
                    break;

                case "ESTIMATED DURATION":
                    foreach (Flight flight in Flights)
                    {
                        if (flight.EstimatedDuration == int.Parse(filterValue))
                        {
                            flights.Add(flight);
                        }
                    }
                    break;
            }

          return flights;
        }

    } 
    
}
