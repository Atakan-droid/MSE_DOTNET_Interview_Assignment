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
            bool IsLineExist = _productionLineDal.Any(u => u.LineName == productionLine.LineName);
            if (IsLineExist) { return new Result<ProductionLine>(false, Messages.LineAlreadyExist); }
            else
            {
                _productionLineDal.Add(productionLine);
                return new Result<ProductionLine>(true, Messages.LineAdded);
            }
        }

        public Result<ProductionLine> DeleteProductionLine(int productionLineId)
        {
            var IsLineExist = _productionLineDal.Get(u => u.Id == productionLineId);
            if (IsLineExist != null)
            {
                IsLineExist.IsDeleted = true;
                IsLineExist.ModifiedDate = DateTime.Now;
                _productionLineDal.Update(IsLineExist);
                return new Result<ProductionLine>(true, Messages.LineDeleted);
            }
            else
            {
                return new Result<ProductionLine>(false, Messages.ProductionLineNotFound);
            }
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
            var result = _productionLineDal.GetAllLinesRelatedToUser(userId);
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
            var IsLineExist = _productionLineDal.Get(u => u.Id == productionLineId);
            if (IsLineExist != null)
            {
               
                _productionLineDal.Delete(IsLineExist);
                return new Result<ProductionLine>(true, Messages.LineDeleted);
            }
            else
            {
                return new Result<ProductionLine>(false, Messages.ProductionLineNotFound);
            }
        }

        public Result<ProductionLine> UpdateProductionLine(int productionLineId, ProductionLine productionLine)
        {
            var IsLineExist = _productionLineDal.Get(u => u.Id == productionLineId);
            if (IsLineExist != null)
            {
                IsLineExist.LineName = productionLine.LineName;
                IsLineExist.Stations = productionLine.Stations;
                IsLineExist.ModifiedDate = DateTime.Now;
                _productionLineDal.Update(IsLineExist);
                return new Result<ProductionLine>(true, Messages.LineUpdated);
            }
            else
            {
                return new Result<ProductionLine>(false, Messages.ProductionLineNotFound);
            }
        }
    }
}
