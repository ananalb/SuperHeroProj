using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero.Models
{
    public class Superhero
    {
        [Key]
        public int SuperheroId { get; set; }
        public string Name { get; set; }
        public string AlterEgo { get; set; }
        public string PrimarySuperheroAbility { get; set; }
        public string SecondarySuperheroAbility { get; set; }
        public string Catchphrase { get; set; }
    }
}
