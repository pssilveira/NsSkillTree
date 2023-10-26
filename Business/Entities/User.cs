using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public Profile? Profile { get; set; }
    }
}
