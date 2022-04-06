using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileCampaign.data
{
    public class Campaign
    {
        [Key]
        public int GameId { get; set; }

        [Required]
        public int SessionLength { get; set; }
        [Required]
        public int NumPlayers { get; set; }
        [Required]
        public string GameType { get; set; }
        [Required]
        public string Restrictions { get; set; }
        [Required]
        public string Discription { get; set; }
        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
