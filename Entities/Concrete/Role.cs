using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Role:EntityBase,IEntity
    {
        public string RoleName { get; set; }
        public ICollection<User> Users { get; set; }

    }
}
