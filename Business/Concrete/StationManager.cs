using Business.Abstract;
using DataAccess.Abstract;
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
        public StationManager(IStationDal stationDal)
        {
            _stationDal = stationDal;
        }
    }
}
