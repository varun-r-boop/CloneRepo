using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeServicesApp.Models.ServiceDelivery
{
    public class ServiceDeliveryOffer
    {
        [Key]
    public int id { get; set; }

        [ForeignKey("service_request_id")]
        public int service_request_id { get; set; }
        [ForeignKey("service_provider_map_id")]

        public int service_provider_map_id { get; set; }

        public int discount_in_percentage { get; set; }

        public int estimated_cost { get; set; }
        public DateOnly offer_submit_date { get; set; }
        public string is_offer_accepted { get; set; }
    }
}
