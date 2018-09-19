using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRepDemo.Models
{
    public class PersonRepositoryMock : IPersonRepository
    {

        public List<Person> GetPersons()
        {
            return new List<Person>()
            {
                new Person() {  PersonId = 1, Name = "Julie" },
                new Person() { PersonId = 2, Name = "Maria" }
            };
        }
    }


    public class PersonRepositoryDB : IPersonRepository
    {

        public List<Person> GetPersons()
        {
            return new List<Person>()
            {
                new Person() {  PersonId = 1, Name = "Julie fra DB" },
                new Person() { PersonId = 2, Name = "Maria fra DB" }
            };
        }
    }
}
