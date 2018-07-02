namespace Veritas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SupportCategory
    {
        public SupportCategory()
        {
            this.SupportLogs = new HashSet<SupportLog>();
        }
        public virtual ICollection<SupportLog> SupportLogs { get; set; }
        public int  Id { get; set; }

        [StringLength(50)]
        public string Value { get; set; }

        public string Pin { get; set; }

        public int Category { get; set; }

        public string Summary { get; set; }

        public string Explanation { get; set; }
    }

}
