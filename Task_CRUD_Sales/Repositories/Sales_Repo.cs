using Task_CRUD_Sales.DTO;
using Task_CRUD_Sales.Models;

namespace Task_CRUD_Sales.Repositories
{
    public class Sales_Repo: ISalesRepo
    {
        DataContext dbContext;

        //do this for ingect db data context to can use database
        public Sales_Repo(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Sales> GetAllSales()
        {
            return dbContext.sales.ToList();
        }

        public Sales GetSalesById(int id)
        {
            Sales sales1 = dbContext.sales.FirstOrDefault(d => d.Id == id);
            //ClientDTO clientDto = new ClientDTO();
            return sales1;
        }


        public int InsertNewSales(SalesDTO newsales)
        {
            Sales sales1 = new Sales();

            //Check for the object already exist 
            if (newsales.Sales_Person != null)
            {
                sales1.Sales_Person = newsales.Sales_Person;
                sales1.Sales_Date = newsales.Sales_Date;
                sales1.Region = newsales.Region;
                sales1.Client_Id = newsales.Client_Id;


                dbContext.sales.Add(sales1);
                dbContext.SaveChanges();
            }
            //here if not found the sales_id 
            else
            {
                return 0; 
            }
         
            return 1;

        }

        public int editSales(int id, SalesDTO currentsales1)
        {
            //GetSalesById(id); 
            Sales sales1 = dbContext.sales.FirstOrDefault(c => c.Id == id);
            if (sales1.Sales_Person != null)
            {
                sales1.Sales_Person = currentsales1.Sales_Person;
                sales1.Sales_Date = currentsales1.Sales_Date;
                sales1.Region = currentsales1.Region;
                sales1.Client_Id=currentsales1.Client_Id;
                 
                dbContext.SaveChanges();
            }
            //here if not found the sales_id 
            else
            {
                return -1;
            }
            
            return 1;
        }

        public int Delete(int id)
        {
            //GetSalesById(id);
            Sales sales1 = dbContext.sales.FirstOrDefault(p => p.Id == id);

            //here if the object null return -1 
            if (sales1 == null)
            {
                return -1;
            }

            dbContext.sales.Remove(sales1);
            //save in db
            int rowRemoved = dbContext.SaveChanges();
            return rowRemoved;

        }
    }
}
