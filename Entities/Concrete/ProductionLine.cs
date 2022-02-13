using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ProductionLine:EntityBase,IEntity
    {
        public string LineName { get; set; }
        public ICollection<Station> Stations { get; set; }
    }
}
