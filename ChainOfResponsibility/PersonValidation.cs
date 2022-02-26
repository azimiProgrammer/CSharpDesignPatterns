using ChainOfResponsibility.Conditions.PersonConditions;
using ChainOfResponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public interface IPersonValidation
    {
        void Handle(Person person);
    }
    public class PersonValidation : IPersonValidation
    {
        public void Handle(Person person)
        {
            var personValidation = new StartPersonValidation();

            personValidation
                .SetNext(new PersonAgeLessThan7Years())
                .SetNext(new PersonBirthDateYearGreatThan2012())
                .SetNext(new PersonLocationIsTehran());

            personValidation.Handle(person);
        }
    }
}
