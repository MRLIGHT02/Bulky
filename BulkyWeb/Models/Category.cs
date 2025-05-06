using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
    {
    public class Category
        {
       
        public int CatagoryId { get; set; }
        [Required]
        public string? Name { get; set; }
        public int DisplayOrder { get; set; }
        }

    }
