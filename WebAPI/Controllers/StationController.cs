using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : ControllerBase
    {
        private readonly IStationService _stationService;
        public StationController(IStationService stationService)
        {
            _stationService = stationService;
        }
        [HttpGet("getstations")]
        public IActionResult GetStations()
        {
            var result = _stationService.GetStations();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }

        }


        [HttpGet("getstationbyid/{stationId}")]
        public IActionResult GetStationById(int stationId)
        {
            var result = _stationService.GetStationById(stationId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return NotFound(result.Message);
            }
        }
        [HttpGet("getstationsbyproductionline/{Id}")]
        public IActionResult GetStationByProductionId(int Id)
        {
            var result = _stationService.GetStationByProductionLine(Id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return NotFound(result.Message);
            }
        }
        [HttpGet("getstationsbyproductionlinename/{line}")]
        public IActionResult GetStationByProductionLineNamee(string line)
        {
            var result = _stationService.GetStationByProductionLineName(line);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return NotFound(result.Message);
            }
        }
        [HttpGet("getstationsbyuser/{userId}")]
        public IActionResult GetStationByUser(int userId)
        {
            var result = _stationService.GetStationByUser(userId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return NotFound(result.Message);
            }
        }


        [HttpPost("addstation")]
        public IActionResult AddStation(Station station)
        {
            var result = _stationService.AddStation(station);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }


        [HttpPut("updatestation/{id}")]
        public IActionResult UpdateStation(int id, Station station)
        {
            var result = _stationService.UpdateStation(id, station);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }

        }
        [HttpGet("deletestation/{id}")]
        public IActionResult DeleteStation(int id)
        {
            var result = _stationService.DeleteStation(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }

        }

        [HttpDelete("harddeletestation/{id}")]
        public IActionResult HardDeleteStation(int id)
        {
            var result = _stationService.HardDeleteStation(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
    }
}
