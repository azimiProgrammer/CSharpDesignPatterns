using ChainOfResponsibility.Abstractions;
using ChainOfResponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Conditions.PersonConditions
{
    public class PersonLocationIsTehran : AbstractHandler<Person>
    {
        public override Person Handle(Person person)
        {
            if (person.CityName == "tehran")
            {
                Console.WriteLine("person location is tehran");
                person.BankAccountNumber = "72006545";
                return person;
            }
            else
            {
                return base.Handle(person);
            }
        }
    }
}
