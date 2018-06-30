namespace Veritas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EXIT_PROCESS_PAYMENT
    {
        [StringLength(30)]
        public string PIN { get; set; }

        public decimal? ADMIN_FEE { get; set; }

        public DateTime? PAYMENT_DATE { get; set; }

        [StringLength(1)]
        public string PAYMENT_TYPE { get; set; }

        [StringLength(15)]
        public string BATCH_ID { get; set; }

        public decimal? AMOUNT_TO_PAY { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        public decimal? CHECKED_BY { get; set; }

        public DateTime? CHECKED_DATE { get; set; }

        [StringLength(1)]
        public string CHECKED { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool EXITFEE { get; set; }

        public decimal? VAT { get; set; }

        public decimal? PAY_YEARS { get; set; }

        [StringLength(100)]
        public string DESCRIPTION { get; set; }

        public decimal? PRICE { get; set; }
    }
}
