using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff:Passenger
    {
        public Staff()
        {

        }
        public DateTime EmploymentDate { get; set; }
        public float Salary { get; set; }
        public string Function { get; set; }

        public Staff(string passportNumber,
            string firstName,
            string lastName,
            string emailAddress,
            DateTime birthDate,
            string phoneNumber, 
            DateTime employmentDate,
            float salary,
            string function) : base(passportNumber, firstName, lastName, emailAddress, birthDate, phoneNumber)
        {
            EmploymentDate = employmentDate;    
            Salary = salary;    
            Function = function;    

        }

        public override string? ToString()
        {
            return $"{FirstName} , {LastName} , {EmailAddress}" +
                $" , {BirthDate},{PhoneNumber},{PassportNumber},{EmploymentDate} ,{Salary},{Function}";
        }

        public override string PassengerType()
        {
            return "I'm a passenger i'm a staff";
        }
    }
}
