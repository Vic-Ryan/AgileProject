using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileUser.Data
{
    public class User
    {
        [Key]
        public int CharacterId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string PreferredClass { get; set; }
        public bool IsBanned { get; set; }
        public List<string> PastGames { get; set; } = new List<string>();

    }
}
