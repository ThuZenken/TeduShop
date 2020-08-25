using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TeduShop.Model.Abstract
{
    public abstract class AudiTable : IAudiTable
    {
        public DateTime? CreateDate { get; set; }

        [MaxLength(256)]
        public string CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        [MaxLength(256)]
        public string UpdateBy { get; set; }

        [MaxLength(256)]
        public string MetaKeyWork { get; set; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }

        public bool status { get; set; }
    }
}
