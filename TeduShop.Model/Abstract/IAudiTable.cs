using System;
using System.Collections.Generic;
using System.Text;

namespace TeduShop.Model.Abstract
{
    public interface IAudiTable
    {
        DateTime? CreateDate { get; set; }
        string CreateBy { get; set; }
        DateTime? UpdateDate { get; set; }
        string UpdateBy { get; set; }
        string MetaKeyWork { get; set; }
        string MetaDescription { get; set; }
        bool status { get; set; }

    }

}
