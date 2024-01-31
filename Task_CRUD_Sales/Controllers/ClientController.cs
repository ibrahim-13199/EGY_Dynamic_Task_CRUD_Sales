using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task_CRUD_Sales.DTO;
using Task_CRUD_Sales.Repositories;

namespace Task_CRUD_Sales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        //to inject client repo inteface to use it's methods
        IClientRepo clientRepoData;
        public ClientController(IClientRepo _clientRepoData)
        {
            this.clientRepoData = _clientRepoData;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetClientById(int id)
        {
            return Ok(clientRepoData.GetClientById(id));
        }

        [HttpGet]
        public IActionResult GetAllClients ()
        {
            return Ok(clientRepoData.GetAllClients());
        }

        [HttpPost]
        public IActionResult NewClient(ClientDTO clientDTO)
        {
            if (ModelState.IsValid == true)
            {
                return Ok(clientRepoData.InsertNewClient(clientDTO));
            }
            return BadRequest("UnAdded");
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateClient(int id, ClientDTO clientDTO)
        {
            if (ModelState.IsValid == true)
            {
                return Ok(clientRepoData.editClient(id, clientDTO));
            }
            return BadRequest("UnUpdated");
        }
        [HttpDelete("{id:int}")]
        public IActionResult deleteClient(int id)
        {
            return Ok(clientRepoData.Delete(id));
        }


    }
}
