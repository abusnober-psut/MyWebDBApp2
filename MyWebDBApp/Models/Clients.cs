using System.ComponentModel.DataAnnotations;

namespace MyWebDBApp.Models
{
    public class Clients
    {
        [Required]
        [RegularExpression(@"[0-9]{4}")]
        public int Id { set; get; }
        
        [Required]
        public string name { get; set; }

        [Required]
        public string mobile { get; set; }
        
        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public int points { get; set; }

        public string comments { get; set; }

    }
}
