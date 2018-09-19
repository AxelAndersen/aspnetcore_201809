using System.Collections.Generic;

namespace eRepDemo.Models
{
    public interface IPersonRepository
    {
        List<Person> GetPersons();
    }
}