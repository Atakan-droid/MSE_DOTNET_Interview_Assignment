using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Station:EntityBase,IEntity
    {
        public string StationName { get; set; }
        public decimal Heat { get; set; }
        public decimal Pressure { get; set; }
        public string Status { get; set; }
        public int LineId { get; set; }
        public ProductionLine ProductionLine { get; set; }
        public int MaintenanceStaffId { get; set; }
        public User MaintenanceStaff { get; set; }
    }
}
