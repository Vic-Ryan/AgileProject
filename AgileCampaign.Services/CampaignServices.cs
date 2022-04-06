using AgileCampaign.data;
using AgileCampaign.Model;
using AgileUser.Data;
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
        public bool CreateCamaign(CampaignCreate model)
        {
            var entity = new Campaign()
            {
                OwnerId = _userId,
                GameName = model.GameName,
                GameType = model.GameType,
                Restrictions = model.Restrictions,
                Discription = model.Discription,
                NumPlayers = model.NumPlayers,
                SessionLength = model.SessionLength
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Campaign.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<CampaignListItem> GetCampaign()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx
                               .Campaign
                               .Where(e => e.OwnerId == _userId)
                               .Select(e => new CampaignListItem()
                               {
                                   GameId = e.GameId,
                                   GameName = e.GameName,
                                   GameType = e.GameType,
                                   NumPlayers = e.NumPlayers,
                                   CreatedUtc = e.CreatedUtc
                               });
                return query.ToArray();
            }
        }

    }
}
