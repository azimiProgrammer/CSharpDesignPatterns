using ChainOfResponsibility.Abstractions;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Conditions.PersonConditions
{
    public class PersonAgeLessThan7Years : AbstractHandler<Person>
    {
        public override Person Handle(Person person)
        {
            if (person.Age < 7)
            {
                Console.WriteLine("person age is less than 7 years");
                person.MobileNumber = "09125770457";
                return person;
            }
            else
            {
                return base.Handle(person);
            }
        }
    }
}
