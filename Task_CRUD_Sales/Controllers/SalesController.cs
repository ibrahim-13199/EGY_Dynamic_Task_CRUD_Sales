using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task_CRUD_Sales.DTO;
using Task_CRUD_Sales.Models;
using Task_CRUD_Sales.Repositories;

namespace Task_CRUD_Sales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {

        //to inject sales repo inteface to use it's methods
        ISalesRepo salesRepoData;
        public SalesController(ISalesRepo _salesRepoData)
        {
            this.salesRepoData = _salesRepoData;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetSalesById(int id)
        {
            return Ok(salesRepoData.GetSalesById(id));
        }

        [HttpGet]
        public IActionResult GetAllSales()
        {
            return Ok(salesRepoData.GetAllSales());
        }

        [HttpPost]
        public IActionResult NewSales(SalesDTO sales1)
        {
            if (ModelState.IsValid == true)
            {
                return Ok(salesRepoData.InsertNewSales(sales1));
            }
            return BadRequest("UnAdded");
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateSales(int id, SalesDTO sales1)
        {
            if (ModelState.IsValid == true)
            {
                return Ok(salesRepoData.editSales(id, sales1));
            }
            return BadRequest("UnUpdated");
        }
        [HttpDelete("{id:int}")]
        public IActionResult deleteSales(int id)
        {
            return Ok(salesRepoData.Delete(id));
        }

    }
}
