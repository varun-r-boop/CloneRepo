using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeServicesApp.Models.ServiceDelivery
{
    public class ServiceRequest
    {
        [Key]
       public int Id { get; set; }
        [ForeignKey("customer_id")]

        public int customer_id{ get; set; }
        [ForeignKey("address_id")]


        public int address_id { get; set; }
        [ForeignKey("service_id")]


        public int service_id { get; set; }

        public string requirement_desc { get; set; }

        public DateTime service_require_on  { get; set; }

        public TimeOnly expected_start_time     { get; set; }

        public int tentative_efforts_read_in_hrs { get; set; }
    }
}
