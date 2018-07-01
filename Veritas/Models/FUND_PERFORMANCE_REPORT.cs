namespace Veritas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FUND_PERFORMANCE_REPORT
    {
        [Key]
        [Column(Order = 0)]
        public decimal SCHEME_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string DESCRIPTION { get; set; }

        public decimal? MARKET_VALUE { get; set; }

        public decimal? FUND_PERCENTAGE { get; set; }

        public decimal? RETURN_ON_INSTRUMENT { get; set; }

        public decimal? BENCHMARK { get; set; }
    }
}
