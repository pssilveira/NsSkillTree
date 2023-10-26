using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Ability : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Skill? Skill { get; set; }
    }
}
