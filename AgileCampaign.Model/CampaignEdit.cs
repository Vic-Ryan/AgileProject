using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileCampaign.Model
{
    public class CampaignEdit
    {
        public int GameId { get; set; }
        public int SessionLength { get; set; }
        public int NumPlayers { get; set; }
        public string Restrictions { get; set; }
        public string Discription { get; set; }

    }
}
