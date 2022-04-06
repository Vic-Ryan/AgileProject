using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileCampaign.Services
{
    public class CampaignServices
    {
        private readonly Guid _userId;
        public CampaignServices(Guid userId)
        {
            _userId = userId;
        }

    }
}
