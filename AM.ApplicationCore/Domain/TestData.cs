using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {

        public static List<Plane> Planes { get; set; } = new List<Plane>() {
       new Plane() {
        Capacity=150,
        PlaneType=PlaneType.boing,
        ManufactureDate=new DateTime(2015,02,03)
       },
         new Plane() {
        Capacity=250,
        PlaneType=PlaneType.airbus,
        ManufactureDate=new DateTime(2020,11,11)
        }
    };



        public static List<Staff> Staffs { get; set; } = new List<Staff>() { 

  new Staff() {
            FirstName = "captain",
        LastName = "captain",
        EmailAddress = "captain.captain@gmail.com",
        BirthDate = new DateTime(1965, 1, 1),
        EmploymentDate = new DateTime(1999, 1, 1),
        Salary = 99999
        },
        
        new Staff() {
            FirstName = "hostess1",
        LastName = "hostss1",
        EmailAddress = "hostess1.hostess1@gmail.com",
        BirthDate = new DateTime(1995, 1, 1),
        EmploymentDate = new DateTime(2020, 1, 1),
        Salary = 999
        },
         new Staff() {
            FirstName = "hostess2",
        LastName = "hostess2",
        EmailAddress = "hostess2.hostess2@gmail.com",
        BirthDate = new DateTime(1996, 1, 1),
        EmploymentDate = new DateTime(2020, 1, 1),
        Salary = 999
        },
        };


        public static List<Passenger> Travellers { get; set; } = new List<Passenger>()
        {
            new Traveller() {
        FirstName="traveller1",
        LastName= "traveller1",
        EmailAddress= "traveller1.traveller1@gmail.com",
        BirthDate=new DateTime(1980,1,1),
        HealthInfo="No troubles",
        Nationality="American"
        }, new Traveller() {
        FirstName="traveller2",
        LastName= "traveller2",
        EmailAddress= "traveller2.traveller2@gmail.com",
        BirthDate=new DateTime(1981,1,1),
        HealthInfo="Some troubles",
        Nationality="French"
        },new Traveller() {
        FirstName="traveller3",
        LastName= "traveller3",
        EmailAddress= "traveller3.traveller3@gmail.com",
        BirthDate=new DateTime(1982,1,1),
        HealthInfo="No troubles",
        Nationality="Tunisian"
        },new Traveller() {
        FirstName="traveller4",
        LastName= "traveller4",
        EmailAddress= "traveller4.traveller4@gmail.com",
        BirthDate=new DateTime(1983,1,1),
        HealthInfo="Some troubles",
        Nationality="American"
        },new Traveller() {
        FirstName="traveller5",
        LastName= "traveller5",
        EmailAddress= "traveller5.traveller5@gmail.com",
        BirthDate=new DateTime(1984,1,1),
        HealthInfo="Some troubles",
        Nationality="Spanish"
        }
        };


        public static List<Flight> Flights { get; set; } = new List<Flight>()
        {
            new Flight()
            {
                FlightDate=new DateTime(2022,1,1,15,10,10),
                Destination="Paris",
                EffectiveArrival=new DateTime(2022,1,1,17,10,10),
                Plane=Planes[1],
                EstimatedDuration=110,
                Passengers= Travellers
            },
            new Flight()
            {
                FlightDate=new DateTime(2022,2,1,21,10,10),
                Destination="Paris",
                EffectiveArrival=new DateTime(2022,2,1,23,10,10),
                Plane=Planes[0],
                EstimatedDuration=105
            },
            new Flight()
            {
                FlightDate=new DateTime(2022,3,1,5,10,10),
                Destination="Paris",
                EffectiveArrival=new DateTime(2022,3,1,6,40,10),
                Plane=Planes[0],
                EstimatedDuration=100
            },

            new Flight()
            {
                FlightDate=new DateTime(2022,4,1,6,10,10),
                Destination="Madrid",
                EffectiveArrival=new DateTime(2022,4,1,8,10,10),
                Plane=Planes[0],
                EstimatedDuration=130
            },

            new Flight()
            {
                FlightDate=new DateTime(2022,5,1,17,10,10),
                Destination="Madrid",
                EffectiveArrival=new DateTime(2022,5,1,18,50,10),
                Plane=Planes[0],
                EstimatedDuration=105
            },


            new Flight()
            {
                FlightDate=new DateTime(2022,6,1,20,10,10),
                Destination="Lisbonne",
                EffectiveArrival=new DateTime(2022,6,1,22,30,10),
                Plane=Planes[1],
                EstimatedDuration=200
            },

        };

        }
}
