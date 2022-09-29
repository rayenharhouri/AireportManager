using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;


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

    foreach (Flight flight in sf.GetFlights("estimated duration", "105")
)
{
    Console.WriteLine(flight);
};