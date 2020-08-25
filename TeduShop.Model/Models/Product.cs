using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml.Linq;
using TeduShop.Model.Abstract;
using TeduShop.Model.Models;

namespace TeduShop.Model
{
    [Table("Products")]
    public class Product : AudiTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(240)]
        public string Name { get; set; }

        [Required]
        [MaxLength(240)]
        public string Alias { get; set; }


        public int CategoryId { get; set; }

        public string Image { get; set; }

        public XElement MoreImage {get; set;}

        public Decimal Price { get; set; }

        public Decimal? PromotionPrice { get; set; }

        public int Warranty { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public bool? HomeFlag { get; set; }

        public bool? HotFlag { get; set; }

        public int? ViewCount { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ProductCategory ProductCategory { get; set; }

        public virtual ICollection<ProductTag> ProductTags { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
