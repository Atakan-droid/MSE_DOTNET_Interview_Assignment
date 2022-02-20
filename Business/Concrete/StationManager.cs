using Business.Abstract;
using Business.Utilities.MailKit;
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
        private readonly IUserService _userService;
        private readonly IAlarmService _alarmService;
        private readonly IMailService _mailService;
        public StationManager(IStationDal stationDal, 
            IProductionLineService productionLineService, 
            IUserService userService, 
            IAlarmService alarmService,
            IMailService mailService)
        {
            _stationDal = stationDal;
            _productionLineService = productionLineService;
            _userService = userService;
            _alarmService = alarmService;
            _mailService = mailService;
        }

        public Result<Station> AddStation(Station station)
        {
            bool IsStationExist = _stationDal.Any(u => u.StationName == station.StationName);
            var IsUserExist = _userService.GetUserById(station.MaintenanceStaffId);
            if (!IsUserExist.Success) { return new Result<Station>(false,Messages.UserNotFound); }
            if (IsStationExist) { return new Result<Station>(false, Messages.StationExist); }
            else
            {
                _stationDal.Add(station);
                var checkValues = _alarmService.CheckValuesOfStation(station);
                if (!checkValues.Success) {
                    MailModel mailModel = new MailModel();
                    mailModel.ToEmail = IsUserExist.Data.Mail;
                    mailModel.Subject = station.StationName + " Sorun!!!";
                    var result = String.Join(", ", checkValues.ListData);
                    mailModel.Body = result;
                    bool isMailSuccesfullySent=_mailService.SendEmail(mailModel);
                    if (isMailSuccesfullySent)
                    {
                        return new Result<Station>(false,Messages.MailSent);
                    }
                    else
                    {
                        return new Result<Station>(false,Messages.MailNotSent);
                    }
                }
                return new Result<Station>(true, Messages.StationAdded);
            }
        }

        public Result<Station> ChangeStationStaff(int stationId, int userId)
        {
            var isStationExist = _stationDal.Get(s => s.Id == stationId);
            if (isStationExist == null) { return new Result<Station>(false,Messages.StationNotFound); }
            var isUserExist = _userService.GetUserById(userId);
            if (!isUserExist.Success) { return new Result<Station>(false,Messages.UserNotFound); }
            isStationExist.MaintenanceStaffId = userId;
            isStationExist.ModifiedDate = DateTime.Now;
            _stationDal.Update(isStationExist);
            return new Result<Station>(true, Messages.StationStaffChanged);
        }

        public Result<Station> DeleteStation(int stationId)
        {
            var IsStationExist = _stationDal.Get(u => u.Id == stationId);
            if (IsStationExist != null)
            {
                IsStationExist.IsDeleted = true;
                IsStationExist.ModifiedDate = DateTime.Now;
                _stationDal.Update(IsStationExist);
                return new Result<Station>(true, Messages.StationDeleted);
            }
            else
            {
                return new Result<Station>(false, Messages.StationNotFound);
            }
        }

        public Result<Station> GetStationById(int stationId)
        {
            var result = _stationDal.Get(u => u.Id == stationId, predicate => predicate.MaintenanceStaff, c => c.ProductionLine);
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
            var result = _stationDal.GetAll(u => u.LineId == productionLineId, predicate => predicate.MaintenanceStaff, c => c.ProductionLine);
            if (result != null)
            {
                return new Result<List<Station>>(result, true, Messages.StationGot);
            }
            return new Result<List<Station>>(false, Messages.StationNotFound);
        }
        public Result<List<Station>> GetStationByProductionLineName(string productionLineName)
        {    
            var result = _stationDal.GetAll(u => u.ProductionLine.LineName == productionLineName, predicate => predicate.MaintenanceStaff, c => c.ProductionLine);
            if (result != null)
            {
                return new Result<List<Station>>(result, true, Messages.StationGot);
            }
            return new Result<List<Station>>(false, Messages.StationNotFound);
        }

        public Result<List<Station>> GetStationByUser(int userId)
        {
            var IsUserExist = _userService.GetUserById(userId);
            if (!IsUserExist.Success) { return new Result<List<Station>>(false, IsUserExist.Message); }
            var result = _stationDal.GetAll(u => u.MaintenanceStaffId == userId, predicate => predicate.MaintenanceStaff, c => c.ProductionLine);
            if (result != null)
            {
                return new Result<List<Station>>(result, true, Messages.StationGot);
            }
            return new Result<List<Station>>(false, Messages.UserNotFound);
        }

        public Result<List<Station>> GetStations()
        {
            return new Result<List<Station>>(_stationDal.GetAll(u => u.IsDeleted == false,predicate=>predicate.MaintenanceStaff,c=>c.ProductionLine),true,Messages.StationGot);
        }

        public Result<Station> HardDeleteStation(int stationId)
        {
            var IsStationExist = _stationDal.Get(u => u.Id == stationId);
            if (IsStationExist != null)
            {
                
                _stationDal.Delete(IsStationExist);
                return new Result<Station>(true, Messages.StationDeleted);
            }
            else
            {
                return new Result<Station>(false, Messages.StationNotFound);
            }
        }

        public Result<Station> UpdateStation(int stationId, Station station)
        {
            var IsStationExist = _stationDal.Get(u => u.Id == stationId);
            if (IsStationExist != null)
            {
                var isUserExist = _userService.GetUserById(station.MaintenanceStaffId);
                if (!isUserExist.Success) { return new Result<Station>(false,Messages.UserNotFound); }
                var isLineExist = _productionLineService.GetProductionLineById(station.LineId);
                if (!isLineExist.Success) { return new Result<Station>(false, Messages.ProductionLineNotFound); }
                IsStationExist.Temperature = station.Temperature;
                IsStationExist.Pressure = station.Pressure;
                IsStationExist.StationName = station.StationName;
                IsStationExist.Status = station.Status;
                IsStationExist.LineId = station.LineId;
                IsStationExist.ProductionLine = isLineExist.Data;
                IsStationExist.MaintenanceStaffId = station.MaintenanceStaffId;
                IsStationExist.MaintenanceStaff = isUserExist.Data;
                IsStationExist.ModifiedDate = DateTime.Now;
                _stationDal.Update(IsStationExist);
                var checkValues = _alarmService.CheckValuesOfStation(station);
                if (!checkValues.Success)
                {
                    MailModel mailModel = new MailModel();
                    mailModel.ToEmail = isUserExist.Data.Mail;
                    mailModel.Subject = station.StationName + " Sorun!!!";
                    mailModel.Body = checkValues.ListData.ToString();
                    bool isMailSuccesfullySent = _mailService.SendEmail(mailModel);
                    if (isMailSuccesfullySent)
                    {
                        return new Result<Station>(false, Messages.MailSent);
                    }
                    else
                    {
                        return new Result<Station>(false, Messages.MailNotSent);
                    }
                }
                return new Result<Station>(true, Messages.StationUpdated);
            }
            else
            {
                return new Result<Station>(false, Messages.StationNotFound);
            }
        }
    }
}
