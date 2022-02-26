// See https://aka.ms/new-console-template for more information


using ChainOfResponsibility;
using ChainOfResponsibility.Models;
using Newtonsoft.Json;

var personValidation = new PersonValidation();

var person = new Person
{
    Id = 1,
    FirstName = "mohammadreza",
    LastName = "azimi",
    BirthDateYear = 2013,
    CityName = "tehran"
};

personValidation.Handle(person);

Console.WriteLine(JsonConvert.SerializeObject(person));
Console.ReadKey();