using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Pharmacy.Models
{
    public partial class PharmacyContext : DbContext
    {
        public PharmacyContext()
        {
        }

        public PharmacyContext(DbContextOptions<PharmacyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ACountry> ACountries { get; set; }
        public virtual DbSet<AOrderStatus> AOrderStatuses { get; set; }
        public virtual DbSet<AStaff> AStaffs { get; set; }
        public virtual DbSet<AbasicUnit> AbasicUnits { get; set; }
        public virtual DbSet<Agender> Agenders { get; set; }
        public virtual DbSet<Aproduct> Aproducts { get; set; }
        public virtual DbSet<AproductCategory> AproductCategories { get; set; }
        public virtual DbSet<AproductClassification> AproductClassifications { get; set; }
        public virtual DbSet<AproductSupplier> AproductSuppliers { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<AstaffImage> AstaffImages { get; set; }
        public virtual DbSet<AstaffRole> AstaffRoles { get; set; }
        public virtual DbSet<PosOrdersHeader> PosOrdersHeaders { get; set; }
        public virtual DbSet<PosorderDetail> PosorderDetails { get; set; }
        public virtual DbSet<ProductPhysicalCount> ProductPhysicalCounts { get; set; }
        public virtual DbSet<ProductWastage> ProductWastages { get; set; }
        public virtual DbSet<SupplierOrderBatchDetail> SupplierOrderBatchDetails { get; set; }
        public virtual DbSet<SupplierOrderDetail> SupplierOrderDetails { get; set; }
        public virtual DbSet<SupplierOrderHeader> SupplierOrderHeaders { get; set; }
        public virtual DbSet<TblErrorLog> TblErrorLogs { get; set; }
        public virtual DbSet<ViewAvailableBatch> ViewAvailableBatches { get; set; }
        public virtual DbSet<ViewAvailableBatch2> ViewAvailableBatch2s { get; set; }
        public virtual DbSet<ViewAvailableProduct> ViewAvailableProducts { get; set; }
        public virtual DbSet<ViewBatchNo> ViewBatchNos { get; set; }
        public virtual DbSet<ViewMostCurrentSupply> ViewMostCurrentSupplies { get; set; }
        public virtual DbSet<ViewPhysicalCount> ViewPhysicalCounts { get; set; }
        public virtual DbSet<ViewPhysicalCount2> ViewPhysicalCount2s { get; set; }
        public virtual DbSet<ViewPosOrder> ViewPosOrders { get; set; }
        public virtual DbSet<ViewProduct> ViewProducts { get; set; }
        public virtual DbSet<ViewStockManagement> ViewStockManagements { get; set; }
        public virtual DbSet<ViewSystemRemainingStock> ViewSystemRemainingStocks { get; set; }
        public virtual DbSet<ViewUserManagement> ViewUserManagements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                                               .SetBasePath(Directory.GetCurrentDirectory())
                                               .AddJsonFile("appsettings.json")
                                               .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<ACountry>(entity =>
            {
                entity.HasKey(e => e.CountryCode)
                    .HasName("PK_Country");

                entity.ToTable("A_Country");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CountryName).HasMaxLength(50);
            });

            modelBuilder.Entity<AOrderStatus>(entity =>
            {
                entity.HasKey(e => e.OrderStatus);

                entity.ToTable("A_Order_Status");

                entity.Property(e => e.OrderStatus)
                    .ValueGeneratedNever()
                    .HasColumnName("Order_Status");

                entity.Property(e => e.StatusDescription)
                    .HasMaxLength(4000)
                    .HasColumnName("Status_Description");
            });

            modelBuilder.Entity<AStaff>(entity =>
            {
                entity.HasKey(e => e.StaffId);

                entity.ToTable("A_Staff");

                entity.Property(e => e.StaffId).HasMaxLength(200);

                entity.Property(e => e.City).HasMaxLength(200);

                entity.Property(e => e.Dob).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(2000);

                entity.Property(e => e.NationalityId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.NinNumber).HasMaxLength(1000);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.StaffName).HasMaxLength(4000);

                entity.Property(e => e.StaffRoleId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tele).HasMaxLength(50);

                entity.Property(e => e.Town).HasMaxLength(200);

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.AStaffs)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_A_Staff_AGender");

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.AStaffs)
                    .HasForeignKey(d => d.NationalityId)
                    .HasConstraintName("FK_A_Staff_A_Country");

                entity.HasOne(d => d.StaffRole)
                    .WithMany(p => p.AStaffs)
                    .HasForeignKey(d => d.StaffRoleId)
                    .HasConstraintName("FK_A_Staff_AStaffRole");
            });

            modelBuilder.Entity<AbasicUnit>(entity =>
            {
                entity.HasKey(e => e.BasicUnitId);

                entity.ToTable("ABasicUnit");

                entity.Property(e => e.BasicUnitId).ValueGeneratedNever();

                entity.Property(e => e.BasicUnitDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<Agender>(entity =>
            {
                entity.HasKey(e => e.GenderId);

                entity.ToTable("AGender");

                entity.Property(e => e.GenderId).ValueGeneratedNever();

                entity.Property(e => e.GenderName).HasMaxLength(50);
            });

            modelBuilder.Entity<Aproduct>(entity =>
            {
                entity.HasKey(e => e.ProductCode);

                entity.ToTable("AProduct");

                entity.Property(e => e.ProductDescription).HasMaxLength(2000);

                entity.HasOne(d => d.BasicUnit)
                    .WithMany(p => p.Aproducts)
                    .HasForeignKey(d => d.BasicUnitId)
                    .HasConstraintName("FK_AProduct_ABasicUnit");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Aproducts)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_AProduct_AProductCategory");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Aproducts)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_AProduct_AProductSupplier");
            });

            modelBuilder.Entity<AproductCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("AProductCategory");

                entity.Property(e => e.CategoryId).ValueGeneratedNever();

                entity.Property(e => e.CategoryDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<AproductClassification>(entity =>
            {
                entity.HasKey(e => e.ClassificationId)
                    .HasName("PK_ProductClassification");

                entity.ToTable("AProductClassification");

                entity.Property(e => e.ClassificationId).ValueGeneratedNever();

                entity.Property(e => e.ClassificationDesc).HasMaxLength(1000);

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.AproductClassifications)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .HasConstraintName("FK_AProductClassification_AProductCategory");
            });

            modelBuilder.Entity<AproductSupplier>(entity =>
            {
                entity.HasKey(e => e.SupplierId);

                entity.ToTable("AProductSupplier");

                entity.Property(e => e.SupplierId).ValueGeneratedNever();

                entity.Property(e => e.City).HasMaxLength(1000);

                entity.Property(e => e.Country).HasMaxLength(1000);

                entity.Property(e => e.Email).HasMaxLength(1000);

                entity.Property(e => e.Fax).HasMaxLength(1000);

                entity.Property(e => e.Phone).HasMaxLength(1000);

                entity.Property(e => e.Pobox).HasMaxLength(1000);

                entity.Property(e => e.Street).HasMaxLength(1000);

                entity.Property(e => e.SupplierDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.StaffId).HasMaxLength(200);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK_AspNetUsers_A_Staff");
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AstaffImage>(entity =>
            {
                entity.HasKey(e => e.StaffId);

                entity.ToTable("AStaffImage");

                entity.Property(e => e.StaffId).HasMaxLength(200);

                entity.Property(e => e.ImageName).HasMaxLength(2000);

                entity.Property(e => e.ImageType)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Staff)
                    .WithOne(p => p.AstaffImage)
                    .HasForeignKey<AstaffImage>(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AStaffImage_A_Staff");
            });

            modelBuilder.Entity<AstaffRole>(entity =>
            {
                entity.HasKey(e => e.StaffRoleId);

                entity.ToTable("AStaffRole");

                entity.Property(e => e.StaffRoleId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StaffRole).HasMaxLength(2000);
            });

            modelBuilder.Entity<PosOrdersHeader>(entity =>
            {
                entity.HasKey(e => e.SaleId);

                entity.ToTable("PosOrdersHeader");

                entity.Property(e => e.SaleId).HasMaxLength(200);

                entity.Property(e => e.Buyer).HasMaxLength(300);

                entity.Property(e => e.CancelledBy).HasMaxLength(200);

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.PosOrdersHeaders)
                    .HasForeignKey(d => d.OrderStatusId)
                    .HasConstraintName("FK_PosOrdersHeader_A_Order_Status");
            });

            modelBuilder.Entity<PosorderDetail>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("POSOrderDetails");

                entity.Property(e => e.ItemId).HasMaxLength(200);

                entity.Property(e => e.BatchNo).HasMaxLength(200);

                entity.Property(e => e.SaleId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.BasicUnit)
                    .WithMany(p => p.PosorderDetails)
                    .HasForeignKey(d => d.BasicUnitId)
                    .HasConstraintName("FK_POSOrderDetails_ABasicUnit");

                entity.HasOne(d => d.ProductCodeNavigation)
                    .WithMany(p => p.PosorderDetails)
                    .HasForeignKey(d => d.ProductCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_POSOrderDetails_AProduct");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.PosorderDetails)
                    .HasForeignKey(d => d.SaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_POSOrderDetails_PosOrdersHeader");
            });

            modelBuilder.Entity<ProductPhysicalCount>(entity =>
            {
                entity.HasKey(e => e.PhysicalCountId);

                entity.ToTable("ProductPhysicalCount");

                entity.Property(e => e.PhysicalCountId).HasMaxLength(200);

                entity.Property(e => e.BatchNo).HasMaxLength(1000);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.EditedBy).HasMaxLength(200);

                entity.Property(e => e.PhysicalCountDate).HasColumnType("date");

                entity.HasOne(d => d.ProductCodeNavigation)
                    .WithMany(p => p.ProductPhysicalCounts)
                    .HasForeignKey(d => d.ProductCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductPhysicalCount_AProduct");
            });

            modelBuilder.Entity<ProductWastage>(entity =>
            {
                entity.HasKey(e => e.WastageId);

                entity.ToTable("ProductWastage");

                entity.Property(e => e.WastageId).HasMaxLength(200);

                entity.Property(e => e.BatchNo).HasMaxLength(200);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.WastageDate).HasColumnType("datetime");

                entity.Property(e => e.WastedBy).HasMaxLength(200);

                entity.HasOne(d => d.BasicUnit)
                    .WithMany(p => p.ProductWastages)
                    .HasForeignKey(d => d.BasicUnitId)
                    .HasConstraintName("FK_ProductWastage_ABasicUnit");

                entity.HasOne(d => d.ProductCodeNavigation)
                    .WithMany(p => p.ProductWastages)
                    .HasForeignKey(d => d.ProductCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductWastage_AProduct");

                entity.HasOne(d => d.WastedByNavigation)
                    .WithMany(p => p.ProductWastages)
                    .HasForeignKey(d => d.WastedBy)
                    .HasConstraintName("FK_ProductWastage_A_Staff");
            });

            modelBuilder.Entity<SupplierOrderBatchDetail>(entity =>
            {
                entity.HasKey(e => e.BatchId);

                entity.Property(e => e.BatchId).HasMaxLength(200);

                entity.Property(e => e.BatchNo).HasMaxLength(200);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.SupplierOrderBatchDetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplierOrderBatchDetails_SupplierOrderDetails");
            });

            modelBuilder.Entity<SupplierOrderDetail>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.Property(e => e.ItemId).HasMaxLength(200);

                entity.Property(e => e.OrderNumber)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.OrderNumberNavigation)
                    .WithMany(p => p.SupplierOrderDetails)
                    .HasForeignKey(d => d.OrderNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplierOrderDetails_SupplierOrderHeader");

                entity.HasOne(d => d.ProductCodeNavigation)
                    .WithMany(p => p.SupplierOrderDetails)
                    .HasForeignKey(d => d.ProductCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplierOrderDetails_AProduct");
            });

            modelBuilder.Entity<SupplierOrderHeader>(entity =>
            {
                entity.HasKey(e => e.OrderNumber);

                entity.ToTable("SupplierOrderHeader");

                entity.Property(e => e.OrderNumber).HasMaxLength(200);

                entity.Property(e => e.DateConfirmed).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.OrderConfirmedBy).HasMaxLength(200);

                entity.Property(e => e.OrderCreatedBy).HasMaxLength(200);

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderStatus).HasColumnName("Order_Status");

                entity.Property(e => e.StockComfirmedBy).HasMaxLength(200);

                entity.Property(e => e.StockConfirmationDate).HasColumnType("datetime");

                entity.Property(e => e.StockRecievedBy).HasMaxLength(200);

                entity.HasOne(d => d.OrderStatusNavigation)
                    .WithMany(p => p.SupplierOrderHeaders)
                    .HasForeignKey(d => d.OrderStatus)
                    .HasConstraintName("FK_SupplierOrderHeader_A_Order_Status");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SupplierOrderHeaders)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_SupplierOrderHeader_AProductSupplier");
            });

            modelBuilder.Entity<TblErrorLog>(entity =>
            {
                entity.ToTable("tblErrorLog");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewAvailableBatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewAvailableBatch");

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.BatchNo).HasMaxLength(200);
            });

            modelBuilder.Entity<ViewAvailableBatch2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewAvailableBatch2");

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.BatchNo).HasMaxLength(200);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewAvailableProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewAvailableProduct");

                entity.Property(e => e.BasicUnitDescription).HasMaxLength(2000);

                entity.Property(e => e.CategoryDescription).HasMaxLength(2000);

                entity.Property(e => e.ClassificationDesc).HasMaxLength(1000);

                entity.Property(e => e.ProductDescription).HasMaxLength(2000);

                entity.Property(e => e.SupplierDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<ViewBatchNo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewBatchNo");

                entity.Property(e => e.BatchNo).HasMaxLength(200);

                entity.Property(e => e.ProductDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<ViewMostCurrentSupply>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewMostCurrentSupply");

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.BatchNo).HasMaxLength(200);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderNumber)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.OrderStatus).HasColumnName("Order_Status");
            });

            modelBuilder.Entity<ViewPhysicalCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewPhysicalCount");

                entity.Property(e => e.PhysicalCountDate).HasColumnType("date");
            });

            modelBuilder.Entity<ViewPhysicalCount2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PhysicalCount_2");

                entity.Property(e => e.PhysicalCountDate).HasColumnType("date");

                entity.Property(e => e.ProductDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<ViewPosOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewPosOrders");

                entity.Property(e => e.BatchNo).HasMaxLength(200);

                entity.Property(e => e.Buyer).HasMaxLength(300);

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.SaleId)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ViewProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewProduct");

                entity.Property(e => e.BasicUnitDescription).HasMaxLength(2000);

                entity.Property(e => e.CategoryDescription).HasMaxLength(2000);

                entity.Property(e => e.ClassificationDesc).HasMaxLength(1000);

                entity.Property(e => e.ProductDescription).HasMaxLength(2000);

                entity.Property(e => e.SupplierDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<ViewStockManagement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewStockManagement");

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.BatchNo).HasMaxLength(200);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderNumber)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.OrderStatus).HasColumnName("Order_Status");
            });

            modelBuilder.Entity<ViewSystemRemainingStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewSystemRemainingStock");

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.BatchNo).HasMaxLength(200);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.OrderStatus).HasColumnName("Order_Status");

                entity.Property(e => e.StockDate)
                    .HasColumnType("date")
                    .HasColumnName("STockDate");
            });

            modelBuilder.Entity<ViewUserManagement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewUserManagement");

                entity.Property(e => e.City).HasMaxLength(200);

                entity.Property(e => e.Dob).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(2000);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.NationalityId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.NinNumber).HasMaxLength(1000);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.StaffId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StaffName).HasMaxLength(4000);

                entity.Property(e => e.StaffRoleId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tele).HasMaxLength(50);

                entity.Property(e => e.Town).HasMaxLength(200);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
