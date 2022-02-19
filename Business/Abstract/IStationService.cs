using Business.Utilities.ResultType;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStationService
    {
        Result<Station> AddStation(Station station);
        Result<Station> UpdateStation(int stationId, Station station);
        Result<Station> DeleteStation(int stationId);
        Result<Station> HardDeleteStation(int stationId);
        Result<List<Station>> GetStationByProductionLine(int productionLineId);
        Result<List<Station>> GetStationByProductionLineName(string productionLineName);
        Result<List<Station>> GetStationByUser(int userId);
        Result<List<Station>> GetStations();
        Result<Station> GetStationById(int stationId);
    }
}
