namespace Veritas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRICE_HISTORY
    {
        [Key]
        [Column(Order = 0)]
        public decimal SCHEME_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime VALUATION_DATE { get; set; }

        public decimal? BID_PRICE_BF { get; set; }

        public decimal? OFFER_PRICE_BF { get; set; }

        public decimal? TOTAL_UNITS { get; set; }

        public decimal? ASSET_VALUE { get; set; }

        public decimal? STOCKS_VALUE { get; set; }

        public decimal? UNQUOTED_VALUE { get; set; }

        public decimal? UNQUOTED_APPR { get; set; }

        public decimal? UNINVESTED_CASH { get; set; }

        public decimal? UNDISTR_INCOME { get; set; }

        public decimal? MM_VALUE { get; set; }

        public decimal? STAMP_DUTIES { get; set; }

        public decimal? NSE_CSCS { get; set; }

        public decimal? BROKERAGE_FEES { get; set; }

        public decimal? TOTAL_BID_VALUE { get; set; }

        public decimal? TOTAL_OFFER_VALUE { get; set; }

        public decimal? BID_PRICE { get; set; }

        public decimal? OFFER_PRICE { get; set; }

        public decimal? APPR_TO_DATE { get; set; }

        public decimal? ID { get; set; }
    }
}
