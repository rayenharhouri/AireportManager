using AM.ApplicationCore.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight
    {
        public List<Flight> Flights { get; set; } = TestData.Flights;


        public List<DateTime> GetFlightDatesWithFor
           (string destination)
        {
            List<DateTime> dates = new List<DateTime>();

            for (int i = 0; i < Flights.Count; i++)
            {
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

        /*  public List<Flight> GetFlights(string typeOfFilter, string filterValue)
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
                          if (flight.FlightDate == DateTime.Parse(filterValue))
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
          }*/

        // public  Func<String, IList<Flight>,List<Flight> >GetFlightsD {get;set;}


        public List<Flight> find(String filterValue, Func<Flight, String, Boolean> del)
        {
            List<Flight> result = new List<Flight>();
            foreach (Flight flight in Flights)
            {
                if (del(flight, filterValue))
                {
                    result.Add(flight);
                }
            }
            return result;
        }

        public  IEnumerable<DateTime> getFlightDateLinqQuery(DateTime dateFlight)
        {
            IEnumerable<DateTime> dateTimes =
            (from date in Flights
             where date.FlightDate.CompareTo(dateFlight) == 0
             select date.FlightDate);
            return dateTimes;
        }
        public IEnumerable<DateTime> getFlightDateLinqQuery1(String destination)
        {
            //IEnumerable<DateTime> dateTimes =
            var req = Flights.Where(f => f.Destination == destination)
                .Select(f => f.FlightDate);
            return req;
            //from date in Flights
             //where 
             //select date.FlightDate;
            //return dateTimes;
        }

        public void getFlightDateDestinationLinq(AM.ApplicationCore.Domain.Plane plane)
        {
            var rq = 
                from flight in Flights
                where flight.Plane.PlaneId == plane.PlaneId 
                select new {flight.FlightDate ,flight.Destination };
            foreach (var flight in rq)
            {
                Console.WriteLine(flight.FlightDate+flight.Destination);
            }
      
        }

        public void getFlightDateDestinationLinqMethode(AM.ApplicationCore.Domain.Plane plane)
        {
            var rq =
                Flights.Where(f => f.Plane.PlaneId == plane.PlaneId)
                .Select(f => new { f.FlightDate, f.Destination });
            // select new { flight.FlightDate, flight.Destination };
            rq.ToList().ForEach(f => Console.WriteLine(f.FlightDate + f.Destination));
        }
        public int ProgrammedFlightNumber(DateTime startDate)
        {
            var req =
                from f in Flights
                where (f.FlightDate.CompareTo(startDate) >= 0 )  && (f.FlightDate - startDate).TotalDays >= 0 && (f.FlightDate - startDate).TotalDays <= 7
                select f;
                return req.Count();
        }
        public int ProgrammedFlightNumberMethode(DateTime startDate)
        {
            var req =
                Flights.Count(f => (f.FlightDate.CompareTo(startDate) >= 0) && (f.FlightDate - startDate).TotalDays >= 0 && (f.FlightDate - startDate).TotalDays <= 7);
                return req;
        }
        public double DurationAverage(string destination)
        {
            return Flights.Where(f => f.Destination == destination)
                .Average(f => f.EstimatedDuration);
        }
        public IEnumerable<Flight> OrderedDurationFlights()
        {
            return Flights.OrderByDescending(f => f.EstimatedDuration);
        }
        public IEnumerable<Flight> OrderedDurationFlightsReq()
        {
            var req = from Flight in Flights
                      orderby Flight.EstimatedDuration descending
                      select Flight;
            return req;
        }
        public IEnumerable<Traveller> SeniorTravellers(Flight flight)
        {
            var req = from f in Flights
                      where f.FlightId == flight.FlightId
                      select f;
            return req.Single()
                .Passengers
                .OfType<Traveller>()
                .OrderBy(t => t.BirthDate)
                .Take(3);
        }
        public void DestinationGroupedFlights()
        {
            var req = from f in Flights
                      group f by f.Destination;
            foreach (var group in req)
            {
                Console.WriteLine(group.Key);
                foreach( var flight in group)
                {
                    Console.WriteLine(flight.FlightDate);
                }

                group.ToList().ForEach(t => Console.WriteLine(t.FlightDate));
            }
        }
        Action<AM.ApplicationCore.Domain.Plane> FlightDetailsDel { get; set; }
        Func<string,double> DurationAverageDel { get; set; }
        public ServiceFlight()
        {
            FlightDetailsDel = plane =>
            {
                var rq =
                    Flights.Where(f => f.Plane.PlaneId == plane.PlaneId)
                    .Select(f => new { f.FlightDate, f.Destination });
                // select new { flight.FlightDate, flight.Destination };
                rq.ToList().ForEach(f => Console.WriteLine(f.FlightDate + f.Destination));
            };

            DurationAverageDel = destination =>
                 Flights.Where(f => f.Destination == destination)
                    .Average(f => f.EstimatedDuration);
        }
        
                
    }

}
