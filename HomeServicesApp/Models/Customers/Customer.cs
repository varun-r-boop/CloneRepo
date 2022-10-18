using System.ComponentModel.DataAnnotations;

namespace HomeServicesApp.Models.Customers
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public int mobile_number { get; set; }

    }
}
