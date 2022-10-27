using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    static public class PassengerExtention
    {
        public static void UpperFullName(this Passenger p)
        {
            p.FirstName = Char.ToUpper(p.FirstName[0]) + p.FirstName.Substring(1);
            p.LastName = Char.ToUpper(p.LastName[0]) + p.LastName.Substring(1);
        }
    }
}
