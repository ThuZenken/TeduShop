using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeduShop.Model.Models
{
    [Table("VisitorStatics")]
    public class VisitorStatics
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime VisitedDate { get; set; }

        [MaxLength(50)]
        public string IpAddress { get; set; }
    }
}
