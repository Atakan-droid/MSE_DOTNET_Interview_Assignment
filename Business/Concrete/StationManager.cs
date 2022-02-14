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
    public class StationManager:IStationService
    {
        private readonly IStationDal _stationDal;
        private readonly IProductionLineService _productionLineService;
        public StationManager(IStationDal stationDal, IProductionLineService productionLineService)
        {
            _stationDal = stationDal;
            _productionLineService = productionLineService;
        }

        public Result<Station> AddStation(Station station)
        {
            throw new NotImplementedException();
        }

        public Result<Station> DeleteStation(int stationId)
        {
            throw new NotImplementedException();
        }

        public Result<Station> GetStationById(int stationId)
        {
            var result = _stationDal.Get(u => u.Id == stationId);
            if (result != null)
            {
                return new Result<Station>(result, true, Messages.StationGot);
            }
            return new Result<Station>(false, Messages.StationNotFound);
        }

        public Result<List<Station>> GetStationByProductionLine(int productionLineId)
        {
            var IsLineExist = _productionLineService.GetProductionLineById(productionLineId);
            if (!IsLineExist.Success) { return new Result<List<Station>>(false, IsLineExist.Message); }
            var result = _stationDal.GetAll(u => u.Id == productionLineId);
            if (result != null)
            {
                return new Result<List<Station>>(result, true, Messages.StationGot);
            }
            return new Result<List<Station>>(false, Messages.StationNotFound);
        }

        public Result<List<Station>> GetStationByUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Result<List<Station>> GetStations()
        {
            return new Result<List<Station>>(_stationDal.GetAll(),true,Messages.StationGot);
        }

        public Result<Station> HardDeleteStation(int stationId)
        {
            throw new NotImplementedException();
        }

        public Result<Station> UpdateStation(int stationId, Station station)
        {
            throw new NotImplementedException();
        }
    }
}
