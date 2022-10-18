using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HomeServicesApp.Models.Providers
{
    public class ProviderReviewLog
    {
        [Key]
        
        public int Id { get; set; }
        [ForeignKey("service_appointment_id")]
        public int service_appointment_id { get; set; }
        public int punctuality_rating { get; set; }
        public int proficiency_rating { get; set; }
        public int etiquattes_rating { get; set; }
        public int communication_rating { get; set; }
        public int price_rating { get; set; }
        public int overall_rating { get; set; }
        public string review { get; set; }
        public DateOnly review_data { get; set; }
}
