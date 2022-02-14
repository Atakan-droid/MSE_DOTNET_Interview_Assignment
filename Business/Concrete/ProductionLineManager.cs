using Business.Abstract;
using Business.Utilities.Messages;
using Business.Utilities.ResultType;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductionLineManager:IProductionLineService
    {
        private readonly IProductionLineDal _productionLineDal;
  
        private readonly IUserService _userService;

        public ProductionLineManager(IProductionLineDal productionLineDal, IUserService userService)
        {
            _productionLineDal = productionLineDal;
            _userService = userService;
        }

        public Result<ProductionLine> AddProductionLine(ProductionLine productionLine)
        {
            throw new NotImplementedException();
        }

        public Result<ProductionLine> DeleteProductionLine(int productionLineId)
        {
            throw new NotImplementedException();
        }

        public Result<ProductionLine> GetProductionLineById(int productionLineId)
        {
            var result = _productionLineDal.Get(u => u.Id == productionLineId);
            if (result != null)
            {
                return new Result<ProductionLine>(result, true, Messages.ProductionLinesGot);
            }
            return new Result<ProductionLine>(false, Messages.ProductionLineNotFound);
        }

      

        public Result<List<ProductionLine>> GetProductionLineByUser(int userId)
        {
            var IsUserExist = _userService.GetUserById(userId);
            if (!IsUserExist.Success) { return new Result<List<ProductionLine>>(false, IsUserExist.Message); }
            var result = _productionLineDal.GetAll(u => u.Id == userId);
            if (result != null)
            {
                return new Result<List<ProductionLine>>(result, true, Messages.ProductionLinesGot);
            }
            return new Result<List<ProductionLine>>(false, Messages.ProductionLineNotFound);
        }

        public Result<List<ProductionLine>> GetProductionLines()
        {
            return new Result<List<ProductionLine>>(_productionLineDal.GetAll(),true,Messages.ProductionLinesGot);
        }

        public Result<ProductionLine> HardDeleteProductionLine(int productionLineId)
        {
            throw new NotImplementedException();
        }

        public Result<ProductionLine> UpdateProductionLine(int productionLineId, ProductionLine productionLine)
        {
            throw new NotImplementedException();
        }
    }
}
