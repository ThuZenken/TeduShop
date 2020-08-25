using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeduShop.Model.Models
{
    [Table("Pages")]
    public class Page
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(240)]
        public string Name { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        [MaxLength(240)]
        public string MetaKeywork { get; set; }

        [Required]
        [MaxLength(240)]
        public string MetaDescription { get; set; }

        public bool? Status { get; set; }


    }
}
