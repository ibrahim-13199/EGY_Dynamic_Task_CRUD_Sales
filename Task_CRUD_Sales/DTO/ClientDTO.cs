using Task_CRUD_Sales.Models;

namespace Task_CRUD_Sales.DTO
{
    public class ClientDTO
    {
        public int Id { get; set; }
        public string? ClientName { get; set; }
        public string? Address { get; set; }
        public int CustomerPhone { get; set; }
        public string? Characterization { get; set; }
        public string? job { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? Client_Source { get; set; }
        public string? Client_Category { get; set; }

        
    }
}
