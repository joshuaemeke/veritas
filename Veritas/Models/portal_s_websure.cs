namespace Veritas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class portal_s_websure
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal USERID { get; set; }

        [StringLength(40)]
        public string USERNAME { get; set; }

        [StringLength(20)]
        public string PASSWORD { get; set; }

        [StringLength(40)]
        public string USERPIN { get; set; }

        [StringLength(20)]
        public string ROLEID { get; set; }

        [StringLength(10)]
        public string TITLE { get; set; }

        [StringLength(25)]
        public string FIRSTNAME { get; set; }

        [StringLength(25)]
        public string LASTNAME { get; set; }

        [StringLength(40)]
        public string COMPANY { get; set; }

        [StringLength(40)]
        public string STREET { get; set; }

        [StringLength(25)]
        public string CITY { get; set; }

        [StringLength(25)]
        public string STATE { get; set; }

        [StringLength(10)]
        public string ZIP { get; set; }

        [StringLength(40)]
        public string COUNTRY { get; set; }

        [StringLength(30)]
        public string PHONE { get; set; }

        [StringLength(30)]
        public string FAX { get; set; }

        [StringLength(80)]
        public string EMAIL { get; set; }

        [StringLength(40)]
        public string HINTQUESTION { get; set; }

        [StringLength(40)]
        public string HINTANSWER { get; set; }

        [StringLength(1)]
        public string PASSCHG_LOGON { get; set; }

        [StringLength(1)]
        public string PASSNO_EXPIRE { get; set; }

        public DateTime? PASSDT_EXPIRE { get; set; }

        [StringLength(1)]
        public string PASSNO_CHANGE { get; set; }

        [StringLength(1)]
        public string USER_DISABLED { get; set; }

        [StringLength(1)]
        public string USER_LOCKED { get; set; }

        [StringLength(1)]
        public string DAY_1 { get; set; }

        [StringLength(1)]
        public string DAY_2 { get; set; }

        [StringLength(1)]
        public string DAY_3 { get; set; }

        [StringLength(1)]
        public string DAY_4 { get; set; }

        [StringLength(1)]
        public string DAY_5 { get; set; }

        [StringLength(1)]
        public string DAY_6 { get; set; }

        [StringLength(1)]
        public string DAY_7 { get; set; }

        public decimal? PIN_MISSED { get; set; }

        public DateTime? LAST_USED { get; set; }

        public DateTime? CREATED { get; set; }

        public DateTime? MODIFIED { get; set; }

        public byte? FLAGUPLOADED { get; set; }

        [StringLength(20)]
        public string opassword { get; set; }
    }
}
