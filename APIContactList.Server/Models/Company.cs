using APIContactList.Server.Data;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.ComponentModel.DataAnnotations;

namespace APIContactList.Server.Models
{
    public class Company
    {

           
            public int CompanyID { get; set; }
            public string CompanyName { get; set; }
            public string CompanyAddress { get; set; }
            public string CompanyEmail { get; set; }
            public ICollection<Customer> Customer { get; set; }


    }
}
