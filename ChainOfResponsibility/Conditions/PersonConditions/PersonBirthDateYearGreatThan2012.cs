using ChainOfResponsibility.Abstractions;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Conditions.PersonConditions
{
    public class PersonBirthDateYearGreatThan2012 : AbstractHandler<Person>
    {
        public override Person Handle(Person person)
        {
            if (person.BirthDateYear > 2012)
            {
                Console.WriteLine("person birth date Year grea tthan 2012");
                person.DocumentNumber = "Ab4434543232";
                return person;
            }
            else
            {
                return base.Handle(person);
            }
        }
    }
}
