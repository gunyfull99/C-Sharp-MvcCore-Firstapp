using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace firstapp.Models
{
    public class Category
    {   
        [Key]   
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100 only!!")]
        public int displayOrder { get; set; }
        public DateTime createDateTime { get; set; }= DateTime.Now;
    }
}
                