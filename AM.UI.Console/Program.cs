using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using AM.ApplicationCore;


/*Passenger passenger1 = new Passenger();
passenger1.PassportNumber = "Mer07122019";
passenger1.FirstName = "Jack";
passenger1.LastName = "Green";
passenger1.EmailAddress = "jack.green@gmail.com";
passenger1.PhoneNumber = "+3345754657654";
passenger1.BirthDate = new DateTime(1998, 09, 29);


Passenger passenger3 = new Passenger() {
PassportNumber = "Mernas07122019",
PhoneNumber = "+21652221191",
EmailAddress = "merima@gmail.com",
FirstName = "Meriam",
LastName = "Ben Ida",
BirthDate = new DateTime(1999,11,22)
};*/

Passenger passenger2 = new Passenger("Nas07122019", "Anas", "Houissa", "anashouissa@gmail.com", new DateTime(1997, 04, 15), "+2165512454");

Plane plane = new Plane();
plane.Capacity = 500;
plane.ManufactureDate = new DateTime(1992, 12, 1);
plane.PlaneId = 1;
plane.PlaneType = PlaneType.airbus;

Plane plane2 = new Plane()
{
    Capacity = 700,
    ManufactureDate = new DateTime(2001,1,24),
    PlaneType = PlaneType.airbus,
};

Staff staff = new Staff("1", "name", "last", "z@z.c", DateTime.Now, "1212", DateTime.Now, 12, "func");


/*
Console.WriteLine(passenger2.PassengerType());
Console.WriteLine(staff.PassengerType());*/

/***TP2*///

ServiceFlight sf = new ServiceFlight();
/*
foreach(DateTime date in sf.GetFlightDatesWithFor("Paris")){
    Console.WriteLine(date);
};

foreach (DateTime date in sf.GetFlightDatesWithForEach("Paris"))
{
    Console.WriteLine(date);
};
*/

   // foreach (Flight flight in sf.GetFlights("estimated duration", "105")
/*
)
{
    Console.WriteLine(flight);
}*/

 static List<Flight> findDestination(String dest,IList<Flight> flights) {
    List<Flight> result = new List<Flight>();
    foreach( Flight flight in flights)
    {
        if(flight.Destination == dest)
        {
            result.Add(flight);
            
        }
    }
    return result;
}

ServiceFlight sv = new ServiceFlight();
/*sv.GetFlightsD=findDestination;

foreach (Flight flight in sv.GetFlightsD("Paris",sv.Flights))
{
    Console.WriteLine(flight);
};*/



static bool flightsByDate(Flight flight,String date)
{
    return flight.FlightDate==DateTime.Parse(date);
}


static bool flightsByDest(Flight flight, String dest)
{
    return flight.Destination == dest;
}

sv.find("15/10/2022", delegate(Flight flight,String date)
{
    return flight.FlightDate == DateTime.Parse(date);

});
sv.find("Paris", (Flight flight,String destination) =>
{
    return flight.Destination == destination;

});

int x = 3;

x.Add(9);


