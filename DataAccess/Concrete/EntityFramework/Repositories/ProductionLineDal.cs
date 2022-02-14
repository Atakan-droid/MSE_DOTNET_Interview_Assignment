using DataAccess.Abstract;
using DataAccess.Abstract.EntityFramework;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Repositories
{
    public class ProductionLineDal : EfBaseRepository<ProductionLine, EfMSE_DOTNET_Context>, IProductionLineDal
    {
        public List<ProductionLine> GetAllLinesRelatedToUser(int userId)
        {
            using (EfMSE_DOTNET_Context context = new EfMSE_DOTNET_Context())
            {
                var result = from c in context.Users
                             join a in context.Stations
                             on
                             c.Id equals a.MaintenanceStaffId
                             join u in context.ProductionLines
                             on
                             a.LineId equals u.Id
                             join r in context.Roles
                             on
                             c.RoleID equals r.Id
                             where c.Id == userId && r.RoleName == "Bakım Personeli"
                             select u;


                return result.ToList();
            }
        }
    }
}
