using Task_CRUD_Sales.DTO;
using Task_CRUD_Sales.Models;

namespace Task_CRUD_Sales.Repositories
{
    public interface IClientRepo
    {
        List<Client> GetAllClients();
        ClientDTO GetClientById(int id);
        int InsertNewClient(ClientDTO newClient);
        int editClient(int id, ClientDTO clientDto);
        int Delete(int id);
    } 
}
