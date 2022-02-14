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
    public class ProductionLineController : ControllerBase
    {
        private readonly IProductionLineService _productionLineService;

        public ProductionLineController(IProductionLineService productionLineService)
        {
            _productionLineService = productionLineService;
        }

        [HttpGet("getproductionLines")]
        public IActionResult GetProductionLines()
        {
            var result = _productionLineService.GetProductionLines();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }

        }


      
        [HttpGet("getproductionLinesbyuser/{userId}")]
        public IActionResult GetProductionLineByUser(int userId)
        {
            var result = _productionLineService.GetProductionLineByUser(userId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return NotFound(result.Message);
            }
        }


        [HttpPost("addproductionLine")]
        public IActionResult AddProductionLine(ProductionLine productionLine)
        {
            var result = _productionLineService.AddProductionLine(productionLine);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }


        [HttpPut("updateproductionLine/{id}")]
        public IActionResult UpdateProductionLine(int id, ProductionLine productionLine)
        {
            var result = _productionLineService.UpdateProductionLine(id, productionLine);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }

        }
        [HttpPatch("deleteproductionLine/{id}")]
        public IActionResult DeleteProductionLine(int id)
        {
            var result = _productionLineService.DeleteProductionLine(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }

        }

        [HttpDelete("harddeleteproductionLine/{id}")]
        public IActionResult HardDeleteProductionLine(int id)
        {
            var result = _productionLineService.HardDeleteProductionLine(id);
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
