using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Veritas.Models
{
 

    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=Default")
        {
        }
        public virtual DbSet<FUND_PERFORMANCE> FUND_PERFORMANCE { get; set; }
        public virtual DbSet<FUND_PERFORMANCE_REPORT> FUND_PERFORMANCE_REPORT { get; set; }
        public virtual DbSet<SupportCategory> SupportCategories { get; set; }
        public virtual DbSet<EXIT_PROCESS_PAYMENT> EXIT_PROCESS_PAYMENT { get; set; }
        public virtual DbSet<portal_s_websure> portal_s_websure { get; set; }
        public virtual DbSet<PRICE_HISTORY> PRICE_HISTORY { get; set; }
        public virtual DbSet<SupportLog> SupportLogs { get; set; }
        public virtual DbSet<CONTRIBUTION> CONTRIBUTIONs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EXIT_PROCESS_PAYMENT>()
                .Property(e => e.PIN)
                .IsUnicode(false);

            modelBuilder.Entity<EXIT_PROCESS_PAYMENT>()
                .Property(e => e.ADMIN_FEE)
                .HasPrecision(10, 2);

            modelBuilder.Entity<EXIT_PROCESS_PAYMENT>()
                .Property(e => e.PAYMENT_TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EXIT_PROCESS_PAYMENT>()
                .Property(e => e.BATCH_ID)
                .IsUnicode(false);

            modelBuilder.Entity<EXIT_PROCESS_PAYMENT>()
                .Property(e => e.ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EXIT_PROCESS_PAYMENT>()
                .Property(e => e.CHECKED_BY)
                .HasPrecision(10, 0);

            modelBuilder.Entity<EXIT_PROCESS_PAYMENT>()
                .Property(e => e.CHECKED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EXIT_PROCESS_PAYMENT>()
                .Property(e => e.PAY_YEARS)
                .HasPrecision(10, 2);

            modelBuilder.Entity<EXIT_PROCESS_PAYMENT>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<EXIT_PROCESS_PAYMENT>()
                .Property(e => e.PRICE)
                .HasPrecision(10, 4);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.USERID)
                .HasPrecision(20, 0);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.USERPIN)
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.ROLEID)
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.FIRSTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.LASTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.COMPANY)
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.STREET)
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.STATE)
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.ZIP)
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.COUNTRY)
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.HINTQUESTION)
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.HINTANSWER)
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.PASSCHG_LOGON)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.PASSNO_EXPIRE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.PASSNO_CHANGE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.USER_DISABLED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.USER_LOCKED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.DAY_1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.DAY_2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.DAY_3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.DAY_4)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.DAY_5)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.DAY_6)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.DAY_7)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.PIN_MISSED)
                .HasPrecision(1, 0);

            modelBuilder.Entity<portal_s_websure>()
                .Property(e => e.opassword)
                .IsUnicode(false);

            modelBuilder.Entity<PRICE_HISTORY>()
                .Property(e => e.SCHEME_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<PRICE_HISTORY>()
                .Property(e => e.BID_PRICE_BF)
                .HasPrecision(14, 4);

            modelBuilder.Entity<PRICE_HISTORY>()
                .Property(e => e.OFFER_PRICE_BF)
                .HasPrecision(14, 4);

            modelBuilder.Entity<PRICE_HISTORY>()
                .Property(e => e.TOTAL_UNITS)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRICE_HISTORY>()
                .Property(e => e.BID_PRICE)
                .HasPrecision(14, 4);

            modelBuilder.Entity<PRICE_HISTORY>()
                .Property(e => e.OFFER_PRICE)
                .HasPrecision(14, 4);

            modelBuilder.Entity<PRICE_HISTORY>()
                .Property(e => e.ID)
                .HasPrecision(10, 0);
            modelBuilder.Entity<SupportCategory>()
                .Property(e => e.Id);
            modelBuilder.Entity<SupportCategory>()
                .Property(e => e.Value);
            modelBuilder.Entity<SupportCategory>()
                .Property(e => e.Category);
            modelBuilder.Entity<SupportCategory>()
                .Property(e => e.Pin);
            modelBuilder.Entity<SupportCategory>()
                .Property(e => e.Summary);
            modelBuilder.Entity<SupportCategory>()
                .Property(e => e.Explanation);
            modelBuilder.Entity<FUND_PERFORMANCE>()
                .Property(e => e.TRANSID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<FUND_PERFORMANCE>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<FUND_PERFORMANCE_REPORT>()
                .Property(e => e.SCHEME_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<FUND_PERFORMANCE_REPORT>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<FUND_PERFORMANCE_REPORT>()
                .Property(e => e.FUND_PERCENTAGE)
                .HasPrecision(6, 2);

            modelBuilder.Entity<FUND_PERFORMANCE_REPORT>()
                .Property(e => e.RETURN_ON_INSTRUMENT)
                .HasPrecision(6, 2);

            modelBuilder.Entity<FUND_PERFORMANCE_REPORT>()
                .Property(e => e.BENCHMARK)
                .HasPrecision(6, 2);
            modelBuilder.Entity<CONTRIBUTION>()
               .Property(e => e.BATCH_ID)
               .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.PIN)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.POSTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.EMPLOYEE_VARIANCE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.EMPLOYER_VARIANCE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.OTHER_VARIANCE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.OTHER_FEE)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.TOTAL_UNITS)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.SCHEME_ID)
                .HasPrecision(15, 0);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.PAYMENT_ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.PRICE)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.TRANS_UNITS_R)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.TRANS_UNITS_V)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.TRANS_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.EMPLOYER_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.RETIREE_DEPOSITE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.FUND_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.BRANCH_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.TRANS_ID)
                .HasPrecision(15, 0);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.PFC_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.PFA_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.TRANSID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.OLDPFACODE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.RECORDID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.SENT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.TRANS_UNITS)
                .HasPrecision(10, 4);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.OLD_PFACODE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.CLIENT_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.POSTED_BY)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.USERID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.mnth1)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.yearr1)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.agent_code)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.FEE_ID)
                .HasPrecision(3, 0);
        }

    }
}