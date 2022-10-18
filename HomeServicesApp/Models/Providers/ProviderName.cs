using System.ComponentModel.DataAnnotations;

namespace HomeServicesApp.Models.Providers
{
    public class ProviderName
    {
        [Key]
        public int Id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public int mobile_number { get; set; }

        public string is_individual { get; set; }
        public string is_registered_office { get; set; }
        public string office_address { get; set; }
        public string zip { get; set; }

        public string description { get; set; }
    }
}
