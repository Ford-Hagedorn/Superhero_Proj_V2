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
        public string HeroMainPowers { get; set; }
        public string HeroSecondaryPowers { get; set; }
        public string HeroAlias { get; set; }
        public string CatchPhrase { get; set; }

    }
}
