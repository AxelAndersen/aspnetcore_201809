using cModelOpgave;
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
        [Display(ResourceType = typeof(side), Name ="Name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Forkert navn")]
        public string Navn { get; set; }

        [Required]
        [Display(ResourceType = typeof(side), Name = "Age")]
        public int Alder { get; set; }

        [Display(ResourceType = typeof(side), Name = "IsActive")]
        public bool ErAktiv { get; set; }

        [DataType(DataType.Date)]
        public DateTime Oprettet  { get; set; }
        
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string UserLanguage { get; set; }
    }
}
