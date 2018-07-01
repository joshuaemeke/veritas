namespace Veritas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FUND_PERFORMANCE
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal TRANSID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime START_PERIOD { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime END_PERIOD { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime REPORT_DATE { get; set; }

        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        public decimal? BALANCE_BF { get; set; }

        public decimal? GROSS_CONTRIBUTION { get; set; }

        public decimal? CLAIMS_PAID { get; set; }

        public decimal? OTHER_WITHDRAWALS { get; set; }

        public decimal? OTHER_DEPOSITS { get; set; }

        public decimal? FUND_MANAGER_FEES { get; set; }

        public decimal? OTHER_ADMIN_EXPENSE { get; set; }

        public decimal? GROSS_EARNINGS { get; set; }

        public decimal? ENDING_BALANCE { get; set; }

        public decimal? INTEREST_INCOME { get; set; }

        public decimal? DIVIDEND_INCOME { get; set; }

        public decimal? UNRECOGNIZED_GAINS_EQUITIES { get; set; }

        public decimal? CAPITAL_GAINS_EQUITIES { get; set; }

        public decimal? UNRECOGNIZED_GAINS_PROPS { get; set; }

        public decimal? CAPITAL_GAINS_PROPS { get; set; }

        public decimal? SCHEME_ID { get; set; }
    }
}
