using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeduShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    { 
        [Key, Column(Order =1)]
        public int PostId { get; set; }

        [Key, Column(Order = 1)]
        public string TagId { get; set; }

        public Post Post { get; set; }

        public Tag Tag { get; set; }
    }
}
