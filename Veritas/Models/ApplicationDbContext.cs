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


        public virtual DbSet<EXIT_PROCESS_PAYMENT> EXIT_PROCESS_PAYMENT { get; set; }
        public virtual DbSet<portal_s_websure> portal_s_websure { get; set; }
        public virtual DbSet<PRICE_HISTORY> PRICE_HISTORY { get; set; }



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
        }

   

    }
}