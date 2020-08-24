using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeduShop.Model
{
    [Table("Footers")]
    class Footer
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Content { get; set; }

    }
}
