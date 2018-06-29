using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veritas.Models
{
    public class User
    {
        [Key]
        public decimal USERID { get; set; }

        public string USERNAME { get; set; }

        public string PASSWORD { get; set; }

        public string USERPIN { get; set; }

        public string ROLEID { get; set; }

        public string TITLE { get; set; }

        public string FIRSTNAME { get; set; }

        public string LASTNAME { get; set; }

        public string COMPANY { get; set; }

        public string STREET { get; set; }

        public string CITY { get; set; }

        public string STATE { get; set; }

        public string ZIP { get; set; }

        public string COUNTRY { get; set; }

        public string PHONE { get; set; }

        public string FAX { get; set; }

        public string EMAIL { get; set; }

        public string HINTQUESTION { get; set; }

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

        public string opassword { get; set; }
    }
}