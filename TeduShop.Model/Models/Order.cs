using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(240)]
        public string Name { get; set; }

        [Required]
        [MaxLength(240)]
        public string Address { get; set; }

        [Required]
        [MaxLength(240)]
        public string Email { get; set; }

        [Required]
        [MaxLength(15)]
        public string Mobile { get; set; }

        [Required]
        public string Message { get; set; } 


        public DateTime CreateDate { get; set; }

        public string CreateBy { get; set; }

        public string PaymentMethod { get; set; }

        [Required]
        public string PaymentStatus { get; set; }

        [Required]
        public bool Status { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
