using APIContactList.Server.Data;
using System.ComponentModel.DataAnnotations;

namespace APIContactList.Server.Models
{
    public class Customer
    {
        
            [Key]
            public int CustomerId { get; set; }
            public string name { get; set; }
            public string phoneNumber { get; set; }
            public string email { get; set; }
            public string address { get; set; }
            public int CompanyId { get; set; }  

    }
}
