using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileUser.Models
{
    public class UserDetail
    {
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public string PreferredClass { get; set; }
        public bool IsBanned { get; set; }
        public List<string> PastGames { get; set; }
    }
}
