using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeServicesApp.Models.ServiceDelivery
{
    public class ServiceAppointment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("service_delivery_offer_id")]

        public int service_delivery_offer_id { get; set; }

        public DateTime service_deliver_on { get; set; }

        public TimeOnly service_start_time  { get; set; }

        public TimeOnly service_end_time { get; set; }
    }
}
