using Task_CRUD_Sales.DTO;
using Task_CRUD_Sales.Models;

namespace Task_CRUD_Sales.Repositories
{
    public interface ISalesRepo
    {
        List<Sales> GetAllSales();
        int InsertNewSales(SalesDTO newsales);
        Sales GetSalesById(int id);
        int editSales(int id, SalesDTO currentsales1);
        int Delete(int id);

    }
}
