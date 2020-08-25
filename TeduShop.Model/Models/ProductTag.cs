using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeduShop.Model.Models
{   
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key, Column(Order = 1)]
        public int ProductId { get; set; }

        [Key, Column(Order = 2)]
        public string TagId { get; set; }

        public Product Product { get; set; }

        public Tag Tag { get; set; }
    }
}
