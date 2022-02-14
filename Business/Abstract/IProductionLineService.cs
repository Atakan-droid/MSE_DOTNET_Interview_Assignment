using Business.Utilities.ResultType;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductionLineService
    {
        Result<ProductionLine> AddProductionLine(ProductionLine productionLine);
        Result<ProductionLine> UpdateProductionLine(int productionLineId, ProductionLine productionLine);
        Result<ProductionLine> DeleteProductionLine(int productionLineId);
        Result<ProductionLine> HardDeleteProductionLine(int productionLineId);
        Result<List<ProductionLine>> GetProductionLineByUser(int userId);
        Result<List<ProductionLine>> GetProductionLines();
        Result<ProductionLine> GetProductionLineById(int productionLineId);
    }
}
