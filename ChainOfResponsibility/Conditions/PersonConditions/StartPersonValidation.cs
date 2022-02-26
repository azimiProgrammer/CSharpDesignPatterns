using ChainOfResponsibility.Abstractions;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Conditions.PersonConditions
{
    public class StartPersonValidation : AbstractHandler<Person>
    {
        public override Person Handle(Person person)
        {
            return base.Handle(person);
        }
    }
}
