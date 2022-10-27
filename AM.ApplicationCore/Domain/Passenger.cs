using System; // same as import in java (des namespace)
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger                      //internal == default in java on peut la supprimer
    {
        public Passenger()
        {
        }
       
        
        public Passenger(string passportNumber, string firstName, string lastName, string emailAddress, DateTime birthDate, string phoneNumber)
        {
            PassportNumber = passportNumber;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
        }

        //declaration
        //explicit (naaraf type) : string nom; ( aandi choix naaml init ou non)
        //implicit ( meanrach type) : var age = 0; on peut pas l'utilise lors de la decalration des atributs


        /*propriete*/
        [Key]
        public string PassportNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress  { get; set; }
        public DateTime BirthDate { get; set; } 
        public string PhoneNumber   { get; set; }
        
       // public int Id {get; set; }

        public IList<Flight> Flights { get; set; }




        public override string ToString()
        {
            return $"{PassportNumber} , {FirstName} , {LastName} , {EmailAddress} , {BirthDate} , {PhoneNumber} ,{Flights}";
        }


      /*  public bool CheckProfile(string nomPassenger,string prenomPassenger)
        {
            return FirstName == nomPassenger && LastName == prenomPassenger;
           
        }
        public bool CheckProfile(string nomPassenger,string prenomPassenger,string emailPassenger)
        {
            return FirstName == nomPassenger && LastName == prenomPassenger && EmailAddress == emailPassenger;
        }*/

        public bool CheckProfile(string nomPassenger, string prenomPassenger, string? emailPassenger=null)
        {
            if (emailPassenger == null)
            {
                return FirstName == nomPassenger && LastName == prenomPassenger;
            }
            else {
                return FirstName == nomPassenger && LastName == prenomPassenger && EmailAddress == emailPassenger;
            }
        }

        public virtual string PassengerType()
        {
            return "I'm a passenger";
        }
        
    }
}
