using Task_CRUD_Sales.DTO;
using Task_CRUD_Sales.Models;

namespace Task_CRUD_Sales.Repositories
{
    public class ClientRepo : IClientRepo
    {
        DataContext dbContext;
        
        //do this for ingect db data context to can use database
        public ClientRepo(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Client> GetAllClients()
        {
            return dbContext.clients.ToList();
        }

        public ClientDTO GetClientById(int id)
        {
            Client client1 = dbContext.clients.FirstOrDefault(d => d.Id == id);
            ClientDTO clientDto = new ClientDTO();
            return clientDto;
        }


        public int InsertNewClient(ClientDTO newClient)
        {
            Client client1 = new Client();

            //Check for the object already exist 
            if (newClient.ClientName != null)
            {
                client1.ClientName = newClient.ClientName;
                client1.Client_Source = newClient.Client_Source;
                client1.Client_Category = newClient.Client_Category;
                client1.CreatedDate = newClient.CreatedDate;
                client1.CreatedBy = newClient.CreatedBy;
                client1.Address = newClient.Address;
                client1.CustomerPhone = newClient.CustomerPhone;
                client1.Characterization = newClient.Characterization;
                client1.ModifiedBy = newClient.ModifiedBy;
                client1.ModifiedDate = newClient.ModifiedDate;
                client1.job = newClient.job;
                dbContext.clients.Add(client1);
                dbContext.SaveChanges();
            }
            //here if not found the client_id 
            return 0;

        }

        public int editClient(int id, ClientDTO clientDto)
        {
            //GetClientById(id); 
            Client client1 = dbContext.clients.FirstOrDefault(c => c.Id == id);
            if (client1.ClientName != null)
            {
                client1.ClientName = clientDto.ClientName;
                client1.Client_Source = clientDto.Client_Source;
                client1.Client_Category = clientDto.Client_Category;
                client1.CreatedDate = clientDto.CreatedDate;
                client1.CreatedBy = clientDto.CreatedBy;
                client1.Address = clientDto.Address;
                client1.CustomerPhone = clientDto.CustomerPhone;
                client1.Characterization = clientDto.Characterization;
                client1.ModifiedBy = clientDto.ModifiedBy;
                client1.ModifiedDate = clientDto.ModifiedDate;
                client1.job = clientDto.job;
                dbContext.SaveChanges();
            }
            return 0;
        }

        public int Delete(int id)
        {
            //GetClientById(id);
            Client client1 = dbContext.clients.FirstOrDefault(p => p.Id == id);

            //here if the object null return -1 
            if (client1 == null)
            {
                return -1;
            }

            dbContext.clients.Remove(client1);
            //save in db
            int rowRemoved = dbContext.SaveChanges();
            return rowRemoved;

        }
    }
}

