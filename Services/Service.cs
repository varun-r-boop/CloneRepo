using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeServicesApp.Models.services
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("service_category_id")]
        public int service_category_id { get; set; }
        public string? service_name { get; set; }

    }
}
