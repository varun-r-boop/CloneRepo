using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeServicesApp.Models.Providers
{
    public class ProviderRating
    {
        [Key] [ForeignKey("Id")]
        public int Id { get; set; }
        
        public int avg_punc_rating { get; set; }
        public int avg_prof_rating { get; set; }
        public int avg_eti_rating { get; set; }
        public int avg_comm_rating { get; set; }
        public int avg_price_rating { get; set; }
        public int avg_overall_rating { get; set; }
        public DateOnly last_updated_on { get; set; }



    }
}
