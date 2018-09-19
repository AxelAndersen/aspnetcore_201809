using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hModelBinding.Models
{
    public class Person
    {
        [Required]
        public string Navn { get; set; }
        public int Alder { get; set; }
        public string LandId { get; set; }
    }
}
