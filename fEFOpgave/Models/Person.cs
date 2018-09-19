using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace fEFOpgave.Models
{
    [Table("person")]
    public class Person
    {
        public int PersonId { get; set; }
        public string Navn { get; set; }
        public DateTime Fødselsdato { get; set; }
        public bool Aktiv { get; set; }
    }

    public class PersonContext : DbContext
    {
        public DbSet<Person> Personer { get; set; }

        public PersonContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("Data Source=c:\\temp\\aspnetcore21_sqlite_ef\\aspnetcore21_sqlite_ef\\personer.db");
            optionsBuilder.UseSqlite("Data Source=personer.db");
        }
    }


    public class PersonRepository
    {
        public List<Person> HentAlle()
        {
            using (PersonContext c = new PersonContext())
            {
                return c.Personer.OrderBy(i => i.Navn).ToList();
            }
        }

    }
}
