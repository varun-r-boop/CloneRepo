using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeServicesApp.Models.Customers
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("customer_id")]
        public int customer_id { get; set; }
        public string street_address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zip { get; set; }

        
    }
}
