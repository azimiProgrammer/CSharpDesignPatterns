using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthDateYear { get; set; }
        public string CityName { get; set; }
        public int Age => DateTime.Now.Year - BirthDateYear;

        public string DocumentNumber { get; set; }
        public string BankAccountNumber { get; set; }
        public string MobileNumber { get; set; }
    }
}
