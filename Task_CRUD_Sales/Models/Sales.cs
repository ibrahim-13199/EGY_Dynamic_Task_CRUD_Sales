using System.ComponentModel.DataAnnotations.Schema;

namespace Task_CRUD_Sales.Models
{
    public class Sales
    {
        public int Id { get; set; }
        public DateTime Sales_Date { get; set; }
        public string? Sales_Person { get; set; }
        public string Region { get; set; }

        /*relation between client table and sales table 1-m
         take a forienkey from client table to sales table also take a list from sales table to client table*/
        [ForeignKey("CustomerRelation")]
        public int Client_Id { get; set; }

        public virtual Client CustomerRelation { get; set; }

    }
}
