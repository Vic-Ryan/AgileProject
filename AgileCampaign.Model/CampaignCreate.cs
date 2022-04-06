using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileCampaign.Model
{
    public class CampaignCreate
    {
        [Required]
        [MinLength(3, ErrorMessage ="Give players a good type: Gritty, Rule of cool, Water World, Module:WaterDeep, ext")]
        [MaxLength(30, ErrorMessage ="Ruel of thumb for type: Keep It Simple Silly")]
        public string GameType { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "Type none if there are no restrictions, other wise Keep It Simple Silly (K.I.S.S)")]
        [MaxLength(150, ErrorMessage = "Ruel of thumb for type: Keep It Simple Silly")]
        public string Restrictions { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "Type none if you havent come up with one")]
        [MaxLength(550, ErrorMessage = "Remember, K.I.S.S. this isnt a book!")]
        public string Discription { get; set; }

        [Required]
        public int NumPlayers { get; set; }
        [Required]
        public int SessionLength { get; set; }
    }
}
