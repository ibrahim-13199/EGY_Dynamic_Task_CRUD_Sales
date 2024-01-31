namespace Task_CRUD_Sales.DTO
{
    public class SalesDTO
    {
        public int Id { get; set; }
        public DateTime Sales_Date { get; set; }
        public string? Sales_Person { get; set; }
        public string Region { get; set; }
        public int Client_Id { get; set; }
    }
}
