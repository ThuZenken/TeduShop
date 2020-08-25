using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [MaxLength(10)]
        public string Id { get; set; }

        [Required]
        [MaxLength(240)]
        public string Name { get; set; }

        public string Type { get; set; }

        public virtual ICollection<ProductTag> ProductTags { get; set; }

        public virtual ICollection<PostTag> PostTags { get; set; }
    }
}
