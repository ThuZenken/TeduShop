using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeduShop.Model.Models
{ 
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(240)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string URL { get; set; }

        [Required]
        public string Image { get; set; }

        public int? DisplayOrder { get; set; }

        public bool? Status { get; set; }
    }
}
