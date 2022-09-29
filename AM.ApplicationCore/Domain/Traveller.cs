using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveller:Passenger
    {

        public Traveller()
        {
                
        }
        public string HealthInfo { get; set; }
        public string Nationality { get; set; }
        public Traveller(string passportNumber,
            string firstName,
            string lastName,
            string emailAddress,
            DateTime birthDate, 
            string phoneNumber,
            string healthInfo ,
            string nationality) : base(passportNumber, firstName, lastName, emailAddress, birthDate, phoneNumber)
        {
            HealthInfo = healthInfo;
            Nationality = nationality;

        }

        public override string? ToString()
        {
            return $"{FirstName} , {LastName} , {EmailAddress}" +
                $" , {BirthDate},{PhoneNumber},{PassportNumber},{HealthInfo} ,{Nationality}";
        }

        public override string PassengerType()
        {
            return base.PassengerType()+" i'm a traveller";
        }
    }
}
