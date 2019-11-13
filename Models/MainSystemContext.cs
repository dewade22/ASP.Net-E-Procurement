using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Balimoon_E_Procurement.Models
{
    public partial class MainSystemContext : DbContext
    {
        public MainSystemContext()
        {
        }

        public MainSystemContext(DbContextOptions<MainSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetSystemUsers> AspNetSystemUsers { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspNetVendor> AspNetVendor { get; set; }
        public virtual DbSet<CompanyInformation> CompanyInformation { get; set; }
        public virtual DbSet<ExportImportTable> ExportImportTable { get; set; }
        public virtual DbSet<LookupField> LookupField { get; set; }
        public virtual DbSet<Systemobject> Systemobject { get; set; }
        public virtual DbSet<Systempermission> Systempermission { get; set; }
        public virtual DbSet<Systemroles> Systemroles { get; set; }
        public virtual DbSet<Systemusermenu> Systemusermenu { get; set; }
        public virtual DbSet<Systemuserroles> Systemuserroles { get; set; }
        public virtual DbSet<Systemusers> Systemusers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=MainSystem;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetSystemUsers>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApproverId)
                    .HasColumnName("ApproverID")
                    .HasMaxLength(450);

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Substitute).HasMaxLength(450);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspNetUserRoles)
                    .HasForeignKey<AspNetUserRoles>(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.Picture).HasMaxLength(450);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetVendor>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(450);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Contact).HasMaxLength(450);

                entity.Property(e => e.ContactEmail).HasMaxLength(450);

                entity.Property(e => e.ContactName).HasMaxLength(450);

                entity.Property(e => e.FileLocation).HasMaxLength(450);

                entity.Property(e => e.InvoiceContact).HasMaxLength(450);

                entity.Property(e => e.InvoiceEmail).HasMaxLength(450);

                entity.Property(e => e.InvoiceName).HasMaxLength(450);

                entity.Property(e => e.NpwpNo)
                    .IsRequired()
                    .HasColumnName("NPWP_No")
                    .HasMaxLength(450);

                entity.Property(e => e.SiupNo)
                    .IsRequired()
                    .HasColumnName("SIUP_No")
                    .HasMaxLength(450);

                entity.Property(e => e.SuplierType).HasMaxLength(450);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.swiftcode)
                    .HasMaxLength(250);

                entity.Property(e => e.VendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompanyInformation>(entity =>
            {
                entity.HasKey(e => e.CompanyCode)
                    .HasName("CompanyInformation$0");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AbbreviatedName)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Abn)
                    .HasColumnName("ABN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.AbndivisionPartNo)
                    .HasColumnName("ABNDivisionPartNo")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Appversion)
                    .HasColumnName("APPVersion")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BankAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BankBranchNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCalendarCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CalConvergenceTimeFrame)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CheckAvailPeriodCalc)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddress)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddress2)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyFaxNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyPhoneNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyPhoneNo2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CountryRegionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomSystemIndicatorText)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CustomsPermitDate).HasColumnType("datetime");

                entity.Property(e => e.CustomsPermitNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FileFolder)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.GiroNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HomePage)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Iban)
                    .HasColumnName("IBAN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageFolderName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IndustrialClassification)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Irdno)
                    .HasColumnName("IRDNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LoginImageName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogoFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentCompanyCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentRoutingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rdocode)
                    .HasColumnName("RDOCode")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityCheck)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShiptoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCountryRegionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SignInvoiceDept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SignInvoiceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Swiftcode)
                    .HasColumnName("SWIFTCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VatregistrationDate)
                    .HasColumnName("VATRegistrationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.VatregistrationNo)
                    .HasColumnName("VATRegistrationNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WallFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExportImportTable>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.CompanyCode, e.NewFieldName });

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NewFieldName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldFieldName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LookupField>(entity =>
            {
                entity.HasKey(e => new { e.LookupGroup, e.LookupCode })
                    .HasName("PK_LookupField_1");

                entity.HasIndex(e => e.LookupFieldId)
                    .HasName("IX_LookupField")
                    .IsUnique();

                entity.Property(e => e.LookupGroup)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.LookupCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IndexBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LookupDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LookupFieldId)
                    .HasColumnName("LookupFieldID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Systemobject>(entity =>
            {
                entity.ToTable("systemobject");

                entity.Property(e => e.SystemObjectId)
                    .HasColumnName("SystemObjectID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ObjectDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectSeqNo).HasDefaultValueSql("((1))");

                entity.Property(e => e.ObjectSystemArg)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectSystemImageFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectSystemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UrlObjectName)
                    .HasColumnName("urlObjectName")
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Systempermission>(entity =>
            {
                entity.HasKey(e => new { e.CompanyCode, e.RoleId, e.ObjectId })
                    .HasName("PK_systempermission_1");

                entity.ToTable("systempermission");

                entity.HasIndex(e => e.SystemPermissionId)
                    .HasName("IX_systempermission")
                    .IsUnique();

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExecuteData).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ReadData).HasDefaultValueSql("((1))");

                entity.Property(e => e.SystemPermissionId)
                    .HasColumnName("SystemPermissionID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Systemroles>(entity =>
            {
                entity.HasKey(e => new { e.CompanyCode, e.Role });

                entity.ToTable("systemroles");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Role)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Descriptions)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.SystemRolesId)
                    .HasColumnName("SystemRolesID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Systemusermenu>(entity =>
            {
                entity.HasKey(e => new { e.CompanyCode, e.RoleId, e.ParentId, e.ChildId })
                    .HasName("PK_systemusermenu_1");

                entity.ToTable("systemusermenu");

                entity.HasIndex(e => e.SystemUserMenuId)
                    .HasName("IX_SystemUserMenu")
                    .IsUnique();

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ChildId).HasColumnName("ChildID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.SystemUserMenuId)
                    .HasColumnName("SystemUserMenuID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Systemuserroles>(entity =>
            {
                entity.HasKey(e => new { e.UserCode, e.CompanyCode })
                    .HasName("PK_systemuserroles_1");

                entity.ToTable("systemuserroles");

                entity.HasIndex(e => e.SystemUserRolesId)
                    .HasName("IX_systemuserroles")
                    .IsUnique();

                entity.Property(e => e.UserCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasColumnName("RoleID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SystemUserRolesId)
                    .HasColumnName("SystemUserRolesID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Systemusers>(entity =>
            {
                entity.HasKey(e => e.UserCode)
                    .HasName("PK_systemusers_1");

                entity.ToTable("systemusers");

                entity.HasIndex(e => e.SystemUsersId)
                    .HasName("IX_systemusers")
                    .IsUnique();

                entity.Property(e => e.UserCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AllowFapostingFrom)
                    .HasColumnName("AllowFAPostingFrom")
                    .HasColumnType("datetime");

                entity.Property(e => e.AllowFapostingTo)
                    .HasColumnName("AllowFAPostingTo")
                    .HasColumnType("datetime");

                entity.Property(e => e.AllowPostingFrom).HasColumnType("datetime");

                entity.Property(e => e.AllowPostingTo).HasColumnType("datetime");

                entity.Property(e => e.ApproverId)
                    .HasColumnName("ApproverID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Blocked).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("EMailAddress")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseAmountApprovalLimit).HasDefaultValueSql("((0))");

                entity.Property(e => e.PurchaseRespCtrFilter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.RequestAmountApprovalLimit).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesAmountApprovalLimit).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesRespCtrFilter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalespersPurchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceRespCtrFilter)
                    .HasColumnName("ServiceRespCtr_Filter")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitute)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SystemUsersId)
                    .HasColumnName("SystemUsersID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UnlimitedPurchaseApproval).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnlimitedRequestApproval).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnlimitedSalesApproval).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
