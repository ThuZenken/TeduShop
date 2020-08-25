using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeduShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key,Column(Order=1)]
        public int OrderId { get; set; }

        [Key, Column(Order = 2)]
        public int ProductId { get; set; }

        public int Quality { get; set; }

        public Order Order { get; set; }

        public Product Product { get; set; }
    }
}
