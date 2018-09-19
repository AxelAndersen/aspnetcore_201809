using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronberg
{
    public class LandeRepository : ILandeRepository
    {
        public List<Land> HentLande() {
            return new List<Land>() {
                new Land() { Id = "DK", Navn = "Danmark" },
                new Land() { Id = "NO", Navn = "Norge" },
                new Land() { Id = "SE", Navn = "Sverige" },
                new Land() { Id = "FI", Navn = "Finland" }
            };
        }
    }

    public class Land {
        public string Id { get; set; }        
        public string Navn { get; set; }
    }
}
