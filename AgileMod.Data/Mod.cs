using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileMod.Data
{
    public enum PowerLevel
    {
        Base = 100,
        Master = 1,
        Wizard,
        Rogue,
        BeanCounter
    }
    public class Mod
    {
        [Key]
        public int ModId { get; set; }
        [Required]
        public PowerLevel powerLevel { get; set; }


        public bool HasUsedModPowers { get; set; }

        public DateTimeOffset LastTimeOnline { get; set; }
    }
}
