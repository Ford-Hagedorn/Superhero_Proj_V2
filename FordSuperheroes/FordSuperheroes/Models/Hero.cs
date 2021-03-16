using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FordSuperheroes.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string HeroName { get; set; }
        public string HeroPowers { get; set; }
        public string HeroSubPowers { get; set; }
        public string HeroRealName { get; set; }
        public string CatchPhrase { get; set; }

    }
}
