using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Project_DataBaseFirst.Models
{
    public partial class DBGR96Context : DbContext
    {
        public DBGR96Context()
        {
        }

        public DBGR96Context(DbContextOptions<DBGR96Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<CarForSale> CarForSales { get; set; } = null!;
        public virtual DbSet<CarsForSale> CarsForSales { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Department1> Department1s { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Kitablar> Kitablars { get; set; } = null!;
        public virtual DbSet<Kitablar1> Kitablar1s { get; set; } = null!;
        public virtual DbSet<Personal> Personals { get; set; } = null!;
        public virtual DbSet<Personal1> Personal1s { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Registration> Registrations { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<staff> staff { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=DBGR96;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("CARS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Brand)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BRAND");

                entity.Property(e => e.Color)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("COLOR");

                entity.Property(e => e.EngineSize).HasColumnName("ENGINE_SIZE");

                entity.Property(e => e.Mileage).HasColumnName("MILEAGE");

                entity.Property(e => e.Model)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MODEL");

                entity.Property(e => e.TypeOfBan)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TYPE_OF_BAN");

                entity.Property(e => e.Year)
                    .HasColumnType("date")
                    .HasColumnName("YEAR");
            });

            modelBuilder.Entity<CarForSale>(entity =>
            {
                entity.ToTable("CAR_FOR_SALES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Brand)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BRAND");

                entity.Property(e => e.Color)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("COLOR");

                entity.Property(e => e.EngineSize).HasColumnName("ENGINE_SIZE");

                entity.Property(e => e.Mileage).HasColumnName("MILEAGE");

                entity.Property(e => e.Model)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MODEL");

                entity.Property(e => e.ProductionDate).HasColumnName("PRODUCTION_DATE");

                entity.Property(e => e.TypeOfBan)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TYPE_OF_BAN");
            });

            modelBuilder.Entity<CarsForSale>(entity =>
            {
                entity.ToTable("CARS_FOR_SALE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Brand)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BRAND");

                entity.Property(e => e.CarType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CAR_TYPE");

                entity.Property(e => e.Color)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("COLOR");

                entity.Property(e => e.EngineSize).HasColumnName("ENGINE_SIZE");

                entity.Property(e => e.Mileage).HasColumnName("MILEAGE");

                entity.Property(e => e.Model)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MODEL");

                entity.Property(e => e.ProductionYear).HasColumnName("PRODUCTION_YEAR");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CONTACTS");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY_CODE")
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.InsertUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INSERT_USER");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Number)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("NUMBER")
                    .IsFixedLength();

                entity.Property(e => e.Prefix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PREFIX")
                    .IsFixedLength();

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("CUSTOMER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Birthplace)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIRTHPLACE");

                entity.Property(e => e.Bithdate)
                    .HasColumnType("date")
                    .HasColumnName("BITHDATE");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Identitynu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDENTITYNU")
                    .IsFixedLength();

                entity.Property(e => e.Identitypincode).HasColumnName("IDENTITYPINCODE");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEPARTMENT");

                entity.Property(e => e.DepartmentManager)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT_MANAGER");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT_NAME");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<Department1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEPARTMENT1");

                entity.Property(e => e.DepartmentManager)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT_MANAGER");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT_NAME");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Kitablar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KITABLAR");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.KitabAd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KITAB_AD");

                entity.Property(e => e.KitabCapev)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KITAB_CAPEV");

                entity.Property(e => e.KitabQiymet)
                    .HasColumnType("money")
                    .HasColumnName("KITAB_QIYMET");

                entity.Property(e => e.KitabSehife).HasColumnName("KITAB_SEHIFE");

                entity.Property(e => e.KitabTarix)
                    .HasColumnType("date")
                    .HasColumnName("KITAB_TARIX");

                entity.Property(e => e.KitabYazar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KITAB_YAZAR");
            });

            modelBuilder.Entity<Kitablar1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KITABLAR1");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.KitabAd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KITAB_AD");

                entity.Property(e => e.KitabCapev)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KITAB_CAPEV");

                entity.Property(e => e.KitabQiymet)
                    .HasColumnType("money")
                    .HasColumnName("KITAB_QIYMET");

                entity.Property(e => e.KitabSehife).HasColumnName("KITAB_SEHIFE");

                entity.Property(e => e.KitabTarix)
                    .HasColumnType("date")
                    .HasColumnName("KITAB_TARIX");

                entity.Property(e => e.KitabYazar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KITAB_YAZAR");
            });

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PERSONAL");

                entity.Property(e => e.BirthPlace)
                    .HasColumnType("date")
                    .HasColumnName("BIRTH_PLACE");

                entity.Property(e => e.DepId).HasColumnName("DEP_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Surname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<Personal1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PERSONAL1");

                entity.Property(e => e.BirthPlace)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIRTH_PLACE");

                entity.Property(e => e.DepId).HasColumnName("DEP_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Surname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("PRODUCT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY");

                entity.Property(e => e.MadedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MADED_BY");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Price)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.ProductDate)
                    .HasColumnType("date")
                    .HasColumnName("PRODUCT_DATE");
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.ToTable("REGISTRATION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENDER")
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("STUDENT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Approved).HasColumnName("APPROVED");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MOBILE");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("USERS");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.ToTable("STAFF");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BirthDate)
                    .HasColumnType("date")
                    .HasColumnName("BIRTH_DATE");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Salary)
                    .HasColumnType("money")
                    .HasColumnName("SALARY");

                entity.Property(e => e.Surname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SURNAME");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
