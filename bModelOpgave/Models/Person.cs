using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bModelOpgave.Models
{
    public class Person
    {
        public int PersonId { get; set; }

        [Required]
        [Display(ResourceType = typeof(side), Name ="navn")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Forkert navn")]
        public string Navn { get; set; }

        [Required]
        public int Alder { get; set; }

        public bool ErAktiv { get; set; }

        [DataType(DataType.Date)]
        public DateTime Oprettet  { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
