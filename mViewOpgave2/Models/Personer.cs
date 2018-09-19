using System;
using System.Collections.Generic;
using System.Text;

namespace Cronberg
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Navn { get; set; }
    }
    public class PersonRepository
    {

        public List<Person> HentPersoner()
        {

            return new List<Person>() {
                new Person(){ PersonId = 1, Navn = "a" },
                new Person(){ PersonId = 2, Navn = "b" },
                new Person(){ PersonId = 3, Navn = "c" }
            };
        }

        public Person HentPerson()
        {

            return new Person() { PersonId = 1, Navn = "a" };
        }

    }
}
