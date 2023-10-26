using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Profile : IEntity
    {
        public int Id { get; set; }
        public required User User { get; set; }
        public IList<Skill>? Skills { get; set; }
        public string? Picture { get; set; }
        public string? Bio { get; set; }
        public Team? Team { get; set; }
    }
}
