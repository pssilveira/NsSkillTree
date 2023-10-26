using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Skill : IEntity
    {
        public int Id { get; set; }
        public string? Name  { get; set; }
        public IList<Profile>? Profiles { get; set; }
        public IList<Ability>? Abilities { get; set; }
    }
}
