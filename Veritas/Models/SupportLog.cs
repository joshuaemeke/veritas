namespace Veritas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SupportLog
    {
        public int Id { get; set; }

        [StringLength(128)]
        public string Pin { get; set; }

        public int? CategoryId { get; set; }

        [StringLength(128)]
        public string Summary { get; set; }

        public string Explanation { get; set; }

        public DateTime? DateSubmitted { get; set; }
    }
}
