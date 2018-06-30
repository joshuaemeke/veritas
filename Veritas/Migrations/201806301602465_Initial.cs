namespace Veritas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EXIT_PROCESS_PAYMENT",
                c => new
                    {
                        ID = c.Decimal(nullable: false, precision: 18, scale: 0, identity: true),
                        EXITFEE = c.Boolean(nullable: false),
                        PIN = c.String(maxLength: 30, unicode: false),
                        ADMIN_FEE = c.Decimal(precision: 10, scale: 2),
                        PAYMENT_DATE = c.DateTime(),
                        PAYMENT_TYPE = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        BATCH_ID = c.String(maxLength: 15, unicode: false),
                        AMOUNT_TO_PAY = c.Decimal(precision: 18, scale: 2),
                        CHECKED_BY = c.Decimal(precision: 10, scale: 0),
                        CHECKED_DATE = c.DateTime(),
                        CHECKED = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        VAT = c.Decimal(precision: 18, scale: 2),
                        PAY_YEARS = c.Decimal(precision: 10, scale: 2),
                        DESCRIPTION = c.String(maxLength: 100, unicode: false),
                        PRICE = c.Decimal(precision: 10, scale: 4),
                    })
                .PrimaryKey(t => new { t.ID, t.EXITFEE });
            
            CreateTable(
                "dbo.portal_s_websure",
                c => new
                    {
                        USERID = c.Decimal(nullable: false, precision: 20, scale: 0, identity: true),
                        USERNAME = c.String(maxLength: 40, unicode: false),
                        PASSWORD = c.String(maxLength: 20, unicode: false),
                        USERPIN = c.String(maxLength: 40, unicode: false),
                        ROLEID = c.String(maxLength: 20, unicode: false),
                        TITLE = c.String(maxLength: 10, unicode: false),
                        FIRSTNAME = c.String(maxLength: 25, unicode: false),
                        LASTNAME = c.String(maxLength: 25, unicode: false),
                        COMPANY = c.String(maxLength: 40, unicode: false),
                        STREET = c.String(maxLength: 40, unicode: false),
                        CITY = c.String(maxLength: 25, unicode: false),
                        STATE = c.String(maxLength: 25, unicode: false),
                        ZIP = c.String(maxLength: 10, unicode: false),
                        COUNTRY = c.String(maxLength: 40, unicode: false),
                        PHONE = c.String(maxLength: 30, unicode: false),
                        FAX = c.String(maxLength: 30, unicode: false),
                        EMAIL = c.String(maxLength: 80, unicode: false),
                        HINTQUESTION = c.String(maxLength: 40, unicode: false),
                        HINTANSWER = c.String(maxLength: 40, unicode: false),
                        PASSCHG_LOGON = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        PASSNO_EXPIRE = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        PASSDT_EXPIRE = c.DateTime(),
                        PASSNO_CHANGE = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        USER_DISABLED = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        USER_LOCKED = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        DAY_1 = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        DAY_2 = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        DAY_3 = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        DAY_4 = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        DAY_5 = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        DAY_6 = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        DAY_7 = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        PIN_MISSED = c.Decimal(precision: 1, scale: 0),
                        LAST_USED = c.DateTime(),
                        CREATED = c.DateTime(),
                        MODIFIED = c.DateTime(),
                        FLAGUPLOADED = c.Byte(),
                        opassword = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.USERID);
            
            CreateTable(
                "dbo.PRICE_HISTORY",
                c => new
                    {
                        SCHEME_ID = c.Decimal(nullable: false, precision: 10, scale: 0),
                        VALUATION_DATE = c.DateTime(nullable: false),
                        BID_PRICE_BF = c.Decimal(precision: 14, scale: 4),
                        OFFER_PRICE_BF = c.Decimal(precision: 14, scale: 4),
                        TOTAL_UNITS = c.Decimal(precision: 18, scale: 4),
                        ASSET_VALUE = c.Decimal(precision: 18, scale: 2),
                        STOCKS_VALUE = c.Decimal(precision: 18, scale: 2),
                        UNQUOTED_VALUE = c.Decimal(precision: 18, scale: 2),
                        UNQUOTED_APPR = c.Decimal(precision: 18, scale: 2),
                        UNINVESTED_CASH = c.Decimal(precision: 18, scale: 2),
                        UNDISTR_INCOME = c.Decimal(precision: 18, scale: 2),
                        MM_VALUE = c.Decimal(precision: 18, scale: 2),
                        STAMP_DUTIES = c.Decimal(precision: 18, scale: 2),
                        NSE_CSCS = c.Decimal(precision: 18, scale: 2),
                        BROKERAGE_FEES = c.Decimal(precision: 18, scale: 2),
                        TOTAL_BID_VALUE = c.Decimal(precision: 18, scale: 2),
                        TOTAL_OFFER_VALUE = c.Decimal(precision: 18, scale: 2),
                        BID_PRICE = c.Decimal(precision: 14, scale: 4),
                        OFFER_PRICE = c.Decimal(precision: 14, scale: 4),
                        APPR_TO_DATE = c.Decimal(precision: 18, scale: 2),
                        ID = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => new { t.SCHEME_ID, t.VALUATION_DATE });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PRICE_HISTORY");
            DropTable("dbo.portal_s_websure");
            DropTable("dbo.EXIT_PROCESS_PAYMENT");
        }
    }
}
