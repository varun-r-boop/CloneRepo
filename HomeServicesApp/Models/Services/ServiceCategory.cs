using System.ComponentModel.DataAnnotations;

namespace HomeServicesApp.Models.services
{
    public class ServiceCategory
    {
        [Key]
        public int Id { get; set; }
        public string? category_name { get; set; }

    }
}

