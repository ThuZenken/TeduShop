using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [MaxLength(10)]
        public string Id { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
