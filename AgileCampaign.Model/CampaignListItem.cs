using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileCampaign.Model
{
    public class CampaignListItem
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string GameType { get; set; }
        public int NumPlayers { get; set; }
        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }

    }
}
