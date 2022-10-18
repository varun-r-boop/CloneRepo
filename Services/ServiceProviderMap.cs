using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeServicesApp.Models.services
{
    public class ServiceProviderMap
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("service_id")]

        public int service_id { get; set; }
        [ForeignKey("provider_id")]

        public int provider_id { get; set; }
        public int billing_rate_per_hour { get; set; }
        public int experience_in_months { get; set; }
        public string? service_offering_description { get; set; }
    }
}
