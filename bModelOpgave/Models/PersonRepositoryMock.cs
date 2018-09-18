using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bModelOpgave.Models
{
    public class PersonRepositoryMock
    {
        public Person HentPerson()
        {
            return new Person() { PersonId = 1, Navn = "Axel", Alder = 44, ErAktiv = true, Password = "xxx", Oprettet = DateTime.Now.AddYears(-44) };


        }
    }
}
