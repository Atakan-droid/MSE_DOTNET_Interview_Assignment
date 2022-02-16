using Business.Abstract;
using Business.Utilities.Messages;
using Business.Utilities.ResultType;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AlarmManager : IAlarmService
    {
        Alarm alarm = new Alarm();
        List<string> errors = new List<string>();
        public AlarmManager()
        {
            alarm.MaxPressure = 100;
            alarm.MinPressure = 0;
            alarm.MaxTemperature = 100;
            alarm.MinTemperature = 0;

        }

        public Result<Alarm> CheckValuesOfStation(Station station)
        {
            if (station.Temperature < alarm.MinTemperature)
            {
                errors.Add("Isı: "+station.Temperature+" > "+Messages.TempratureLow);
            }
            else if(station.Temperature>alarm.MaxTemperature)
            {
                errors.Add("Isı: " + station.Temperature +" > "+ Messages.TempratureHigh);
            }
            if (station.Pressure < alarm.MinPressure)
            {
                errors.Add("Basınç: " + station.Pressure +" > "+ Messages.PressureLow);
            }
            else if (station.Pressure > alarm.MaxPressure)
            {
                errors.Add("Basınç: " + station.Pressure +" > "+ Messages.PressureHigh);
            }
            if (errors.Count == 0)
            {
                return new Result<Alarm>(true,"");
            }
            else
            {
                return new Result<Alarm>(errors,false,"");
            }
            
        }
    }
}
