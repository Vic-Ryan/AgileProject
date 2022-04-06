using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileUser.Models
{
    public class NoteCreate
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string PrefferedClass { get; set; }
    }
}
