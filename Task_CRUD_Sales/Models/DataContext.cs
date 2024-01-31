using Microsoft.EntityFrameworkCore;

namespace Task_CRUD_Sales.Models
{
    public class DataContext:DbContext
    {
        
        public DataContext()
        {
        }
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        

        public DbSet<Client> clients { get; set; }
        public DbSet<Sales> sales { get; set; }
    }
}
