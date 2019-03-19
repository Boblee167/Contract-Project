namespace ContractManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContractDetails",
                c => new
                    {
                        Contract_ID = c.Int(nullable: false, identity: true),
                        ContractStartDate = c.DateTime(nullable: false),
                        ContractFinishDate = c.DateTime(nullable: false),
                        ContractExtensionsAvailable = c.Int(nullable: false),
                        DurationContactExtension = c.Int(nullable: false),
                        Servicetype = c.Int(nullable: false),
                        PriceDescription = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                        VatRate = c.Double(nullable: false),
                        PriceUpdatedate = c.DateTime(nullable: false),
                        Supplier_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Contract_ID)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_ID, cascadeDelete: true)
                .Index(t => t.Supplier_ID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Supplier_ID = c.Int(nullable: false, identity: true),
                        SupplierNumber = c.String(nullable: false),
                        SupplierName = c.String(nullable: false),
                        SupplierAddress = c.String(nullable: false),
                        SupplierCounty = c.String(nullable: false),
                        SupplierContact = c.String(nullable: false),
                        SupplierEMail = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Supplier_ID);
            
            CreateTable(
                "dbo.ContractHours",
                c => new
                    {
                        Transaction_ID = c.Int(nullable: false, identity: true),
                        Property_ID = c.Int(nullable: false),
                        Contract_ID = c.Int(nullable: false),
                        Weekday = c.Int(nullable: false),
                        DailyHours = c.Double(nullable: false),
                        HoursUpdatedDate = c.DateTime(nullable: false),
                        WeeklyHours = c.Double(nullable: false),
                        AvgMonthlyHours = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Transaction_ID)
                .ForeignKey("dbo.ContractDetails", t => t.Contract_ID, cascadeDelete: true)
                .ForeignKey("dbo.Properties", t => t.Property_ID, cascadeDelete: true)
                .Index(t => t.Property_ID)
                .Index(t => t.Contract_ID);
            
            CreateTable(
                "dbo.Properties",
                c => new
                    {
                        Property_ID = c.Int(nullable: false, identity: true),
                        Prop_Address = c.String(nullable: false),
                        Prop_County = c.String(nullable: false),
                        Type = c.Int(nullable: false),
                        Cost_Centre = c.String(nullable: false),
                        OPW_Building_Code = c.String(nullable: false),
                        Team = c.Int(nullable: false),
                        SquareMetre = c.Int(nullable: false),
                        StaffCapacity = c.Int(nullable: false),
                        CarParkSpots = c.Int(nullable: false),
                        DateOpened = c.DateTime(nullable: false),
                        DateClosed = c.DateTime(nullable: false),
                        Lease_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Property_ID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.ContractHours", "Property_ID", "dbo.Properties");
            DropForeignKey("dbo.ContractHours", "Contract_ID", "dbo.ContractDetails");
            DropForeignKey("dbo.ContractDetails", "Supplier_ID", "dbo.Suppliers");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.ContractHours", new[] { "Contract_ID" });
            DropIndex("dbo.ContractHours", new[] { "Property_ID" });
            DropIndex("dbo.ContractDetails", new[] { "Supplier_ID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Properties");
            DropTable("dbo.ContractHours");
            DropTable("dbo.Suppliers");
            DropTable("dbo.ContractDetails");
        }
    }
}
