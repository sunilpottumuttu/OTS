using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OTS.Data.OTSModels
{
    public partial class ZZTOPContext : DbContext
    {
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientContact> ClientContact { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<D10client> D10client { get; set; }
        public virtual DbSet<D10customer> D10customer { get; set; }
        public virtual DbSet<D10docType> D10docType { get; set; }
        public virtual DbSet<D10driver> D10driver { get; set; }
        public virtual DbSet<D10loadInfo> D10loadInfo { get; set; }
        public virtual DbSet<D10location> D10location { get; set; }
        public virtual DbSet<D10ppe> D10ppe { get; set; }
        public virtual DbSet<D10prodType> D10prodType { get; set; }
        public virtual DbSet<D10state> D10state { get; set; }
        public virtual DbSet<D10user> D10user { get; set; }
        public virtual DbSet<D10vehType> D10vehType { get; set; }
        public virtual DbSet<D20loadInfoData> D20loadInfoData { get; set; }
        public virtual DbSet<D20ppedata> D20ppedata { get; set; }
        public virtual DbSet<D30docScanTxn> D30docScanTxn { get; set; }
        public virtual DbSet<D30feedBack> D30feedBack { get; set; }
        public virtual DbSet<D30incidenceTxn> D30incidenceTxn { get; set; }
        public virtual DbSet<D30kxtxn> D30kxtxn { get; set; }
        public virtual DbSet<D30loadInfoTxn> D30loadInfoTxn { get; set; }
        public virtual DbSet<D30ppetxn> D30ppetxn { get; set; }
        public virtual DbSet<D30redeemTxn> D30redeemTxn { get; set; }
        public virtual DbSet<Direction> Direction { get; set; }
        public virtual DbSet<DocumentMaster> DocumentMaster { get; set; }
        public virtual DbSet<DocumentSubmission> DocumentSubmission { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<Incident> Incident { get; set; }
        public virtual DbSet<Kxmaster> Kxmaster { get; set; }
        public virtual DbSet<LoadInfoConfiguration> LoadInfoConfiguration { get; set; }
        public virtual DbSet<LoadInfoData> LoadInfoData { get; set; }
        public virtual DbSet<LoadInfoMaster> LoadInfoMaster { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Ppeconfiguration> Ppeconfiguration { get; set; }
        public virtual DbSet<Ppedata> Ppedata { get; set; }
        public virtual DbSet<Ppemaster> Ppemaster { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
        public virtual DbSet<Reward> Reward { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Submission> Submission { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<VehicleTypeMaster> VehicleTypeMaster { get; set; }

        // Unable to generate entity type for table 'dbo.CustomerContact'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LocationContact'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.D10Roll'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=user-pc;Database=ZZTOP;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.ClientKey)
                    .HasName("PK_Client");

                entity.Property(e => e.ClientKey).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.DocumentPath).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.Property(e => e.Zip).HasMaxLength(50);
            });

            modelBuilder.Entity<ClientContact>(entity =>
            {
                entity.HasKey(e => e.ClientContactKey)
                    .HasName("PK_ClientContact");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.ClientContact)
                    .HasForeignKey(d => d.ClientKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientContact_Client");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerKey)
                    .HasName("PK_Customer");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.Property(e => e.Zip).HasMaxLength(50);

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.ClientKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Customer_Client");
            });

            modelBuilder.Entity<D10client>(entity =>
            {
                entity.HasKey(e => e.ClientKey)
                    .HasName("PK_D10Client");

                entity.ToTable("D10Client");

                entity.Property(e => e.ClientKey).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CrBy).HasColumnName("CR_BY");

                entity.Property(e => e.CrDt)
                    .HasColumnName("CR_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocumentPath).HasMaxLength(500);

                entity.Property(e => e.EdBy).HasColumnName("ED_BY");

                entity.Property(e => e.EdDt)
                    .HasColumnName("ED_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Status).HasColumnType("nchar(3)");

                entity.Property(e => e.Zip).HasMaxLength(50);
            });

            modelBuilder.Entity<D10customer>(entity =>
            {
                entity.HasKey(e => e.CustomerKey)
                    .HasName("PK_D10Customer");

                entity.ToTable("D10Customer");

                entity.Property(e => e.CustomerKey).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CrBy).HasColumnName("CR_BY");

                entity.Property(e => e.CrDt)
                    .HasColumnName("CR_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EdBy).HasColumnName("ED_BY");

                entity.Property(e => e.EdDt)
                    .HasColumnName("ED_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Status).HasColumnType("nchar(3)");

                entity.Property(e => e.Zip).HasMaxLength(50);

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.D10customer)
                    .HasForeignKey(d => d.ClientKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_D10Customer_D10Client");
            });

            modelBuilder.Entity<D10docType>(entity =>
            {
                entity.HasKey(e => e.DocTypeKey)
                    .HasName("PK_D10DocType");

                entity.ToTable("D10DocType");

                entity.Property(e => e.DocTypeKey).ValueGeneratedNever();

                entity.Property(e => e.CrBy).HasColumnName("CR_BY");

                entity.Property(e => e.CrDt)
                    .HasColumnName("CR_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocType).HasMaxLength(50);

                entity.Property(e => e.EdBy).HasColumnName("ED_BY");

                entity.Property(e => e.EdDt)
                    .HasColumnName("ED_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShortStr).HasColumnType("nchar(3)");
            });

            modelBuilder.Entity<D10driver>(entity =>
            {
                entity.HasKey(e => e.DriverKey)
                    .HasName("PK_D10Driver");

                entity.ToTable("D10Driver");

                entity.Property(e => e.DriverKey).ValueGeneratedNever();

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CrBy).HasColumnName("CR_BY");

                entity.Property(e => e.CrDt)
                    .HasColumnName("CR_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.EdBy).HasColumnName("ED_BY");

                entity.Property(e => e.EdDt)
                    .HasColumnName("ED_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RegMobileNo).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.Zone).HasMaxLength(50);

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.D10driver)
                    .HasForeignKey(d => d.ClientKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_D10Driver_D10Client");

                entity.HasOne(d => d.DriverKeyNavigation)
                    .WithOne(p => p.InverseDriverKeyNavigation)
                    .HasForeignKey<D10driver>(d => d.DriverKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_D10Driver_D10Driver");
            });

            modelBuilder.Entity<D10loadInfo>(entity =>
            {
                entity.HasKey(e => e.LoadInfoKey)
                    .HasName("PK_D10LoadInfo");

                entity.ToTable("D10LoadInfo");

                entity.Property(e => e.LoadInfoKey).ValueGeneratedNever();

                entity.Property(e => e.CrBy).HasColumnName("CR_BY");

                entity.Property(e => e.CrDt)
                    .HasColumnName("CR_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.EdBy).HasColumnName("ED_BY");

                entity.Property(e => e.EdDt)
                    .HasColumnName("ED_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ValueType).HasColumnType("nchar(3)");

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.D10loadInfo)
                    .HasForeignKey(d => d.ClientKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_D10LoadInfo_D10Client");
            });

            modelBuilder.Entity<D10location>(entity =>
            {
                entity.HasKey(e => e.LocationKey)
                    .HasName("PK_D10Location");

                entity.ToTable("D10Location");

                entity.Property(e => e.LocationKey).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CrBy).HasColumnName("CR_BY");

                entity.Property(e => e.CrDt)
                    .HasColumnName("CR_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.EdBy).HasColumnName("ED_BY");

                entity.Property(e => e.EdDt)
                    .HasColumnName("ED_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.GpsId)
                    .HasColumnName("GpsID")
                    .HasMaxLength(50);

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Zip).HasMaxLength(50);

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.D10location)
                    .HasForeignKey(d => d.ClientKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_D10Location_D10Client");

                entity.HasOne(d => d.CustomerKeyNavigation)
                    .WithMany(p => p.D10location)
                    .HasForeignKey(d => d.CustomerKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_D10Location_D10Customer");
            });

            modelBuilder.Entity<D10ppe>(entity =>
            {
                entity.HasKey(e => e.Ppekey)
                    .HasName("PK_D10PPE");

                entity.ToTable("D10PPE");

                entity.Property(e => e.Ppekey)
                    .HasColumnName("PPEKey")
                    .ValueGeneratedNever();

                entity.Property(e => e.CrBy).HasColumnName("CR_BY");

                entity.Property(e => e.CrDt)
                    .HasColumnName("CR_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.EdBy).HasColumnName("ED_BY");

                entity.Property(e => e.EdDt)
                    .HasColumnName("ED_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ValueType).HasMaxLength(50);

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.D10ppe)
                    .HasForeignKey(d => d.ClientKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_D10PPE_D10Client");
            });

            modelBuilder.Entity<D10prodType>(entity =>
            {
                entity.HasKey(e => e.ProductTypeKey)
                    .HasName("PK_D10ProdType");

                entity.ToTable("D10ProdType");

                entity.Property(e => e.ProductTypeKey).ValueGeneratedNever();

                entity.Property(e => e.CrBy).HasColumnName("CR_BY");

                entity.Property(e => e.CrDt)
                    .HasColumnName("CR_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.EdBy).HasColumnName("ED_BY");

                entity.Property(e => e.EdDt)
                    .HasColumnName("ED_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProductType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<D10state>(entity =>
            {
                entity.HasKey(e => e.StateId)
                    .HasName("PK_D10State");

                entity.ToTable("D10State");

                entity.Property(e => e.StateId).ValueGeneratedNever();

                entity.Property(e => e.State).HasMaxLength(50);
            });

            modelBuilder.Entity<D10user>(entity =>
            {
                entity.HasKey(e => e.UserKey)
                    .HasName("PK_D10User");

                entity.ToTable("D10User");

                entity.Property(e => e.UserKey).ValueGeneratedNever();

                entity.Property(e => e.CrBy).HasColumnName("CR_BY");

                entity.Property(e => e.CrDt)
                    .HasColumnName("CR_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.EdBy).HasColumnName("ED_BY");

                entity.Property(e => e.EdDt)
                    .HasColumnName("ED_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.RegMobileNo).HasMaxLength(50);

                entity.Property(e => e.Roll)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.HasOne(d => d.ManagerKeyNavigation)
                    .WithMany(p => p.InverseManagerKeyNavigation)
                    .HasForeignKey(d => d.ManagerKey)
                    .HasConstraintName("FK_D10User_D10User");
            });

            modelBuilder.Entity<D10vehType>(entity =>
            {
                entity.HasKey(e => e.VehicleTypeKey)
                    .HasName("PK_D10VehType");

                entity.ToTable("D10VehType");

                entity.Property(e => e.VehicleTypeKey).ValueGeneratedNever();

                entity.Property(e => e.CrBy).HasColumnName("CR_BY");

                entity.Property(e => e.CrDt)
                    .HasColumnName("CR_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.EdBy).HasColumnName("ED_BY");

                entity.Property(e => e.EdDt)
                    .HasColumnName("ED_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.VehType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.D10vehType)
                    .HasForeignKey(d => d.ClientKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_D10VehType_D10Client");
            });

            modelBuilder.Entity<D20loadInfoData>(entity =>
            {
                entity.HasKey(e => e.LoadInfoKey)
                    .HasName("PK_D20LoadInfoData");

                entity.ToTable("D20LoadInfoData");

                entity.Property(e => e.LoadInfoKey).ValueGeneratedNever();

                entity.Property(e => e.CrBy).HasColumnName("CR_BY");

                entity.Property(e => e.CrDt)
                    .HasColumnName("CR_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.EdBy).HasColumnName("ED_BY");

                entity.Property(e => e.EdDt)
                    .HasColumnName("ED_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(100);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.D20loadInfoData)
                    .HasForeignKey(d => d.ClientKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_D20LoadInfoData_D10Client");

                entity.HasOne(d => d.CustomerKeyNavigation)
                    .WithMany(p => p.D20loadInfoData)
                    .HasForeignKey(d => d.CustomerKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_D20LoadInfoData_D10Customer");

                entity.HasOne(d => d.LoadInfoKeyNavigation)
                    .WithOne(p => p.D20loadInfoData)
                    .HasForeignKey<D20loadInfoData>(d => d.LoadInfoKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_D20LoadInfoData_D10LoadInfo");

                entity.HasOne(d => d.ProdTypeKeyNavigation)
                    .WithMany(p => p.D20loadInfoData)
                    .HasForeignKey(d => d.ProdTypeKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_D20LoadInfoData_D10ProdType");

                entity.HasOne(d => d.VehTypeKeyNavigation)
                    .WithMany(p => p.D20loadInfoData)
                    .HasForeignKey(d => d.VehTypeKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_D20LoadInfoData_D10VehType");
            });

            modelBuilder.Entity<D20ppedata>(entity =>
            {
                entity.HasKey(e => e.Ppekey)
                    .HasName("PK_D20PPEData");

                entity.ToTable("D20PPEData");

                entity.Property(e => e.Ppekey)
                    .HasColumnName("PPEKey")
                    .ValueGeneratedNever();

                entity.Property(e => e.CrBy).HasColumnName("CR_BY");

                entity.Property(e => e.CrDt)
                    .HasColumnName("CR_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.EdBy).HasColumnName("ED_BY");

                entity.Property(e => e.EdDt)
                    .HasColumnName("ED_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(100);

                entity.Property(e => e.Value).HasMaxLength(500);

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.D20ppedata)
                    .HasForeignKey(d => d.ClientKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_D20PPEData_D10Client");

                entity.HasOne(d => d.CustomerKeyNavigation)
                    .WithMany(p => p.D20ppedata)
                    .HasForeignKey(d => d.CustomerKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_D20PPEData_D10Customer");

                entity.HasOne(d => d.LocationKeyNavigation)
                    .WithMany(p => p.D20ppedata)
                    .HasForeignKey(d => d.LocationKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_D20PPEData_D10Location");

                entity.HasOne(d => d.ProdTypeKeyNavigation)
                    .WithMany(p => p.D20ppedata)
                    .HasForeignKey(d => d.ProdTypeKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_D20PPEData_D10ProdType");

                entity.HasOne(d => d.VehTypeKeyNavigation)
                    .WithMany(p => p.D20ppedata)
                    .HasForeignKey(d => d.VehTypeKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_D20PPEData_D10VehType");
            });

            modelBuilder.Entity<D30docScanTxn>(entity =>
            {
                entity.HasKey(e => e.TxnKey)
                    .HasName("PK_D30DocScanTxn");

                entity.ToTable("D30DocScanTxn");

                entity.Property(e => e.TxnKey).ValueGeneratedNever();

                entity.Property(e => e.CrBy).HasColumnName("CR_BY");

                entity.Property(e => e.CrDt)
                    .HasColumnName("CR_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.DocPath).HasMaxLength(100);

                entity.Property(e => e.EdBy).HasColumnName("ED_BY");

                entity.Property(e => e.EdDt)
                    .HasColumnName("ED_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.D30docScanTxn)
                    .HasForeignKey(d => d.ClientKey)
                    .HasConstraintName("FK_D30DocScanTxn_D10Client");

                entity.HasOne(d => d.DocTypeKeyNavigation)
                    .WithMany(p => p.D30docScanTxn)
                    .HasForeignKey(d => d.DocTypeKey)
                    .HasConstraintName("FK_D30DocScanTxn_D10DocType");

                entity.HasOne(d => d.DriverKeyNavigation)
                    .WithMany(p => p.D30docScanTxn)
                    .HasForeignKey(d => d.DriverKey)
                    .HasConstraintName("FK_D30DocScanTxn_D10User");
            });

            modelBuilder.Entity<D30feedBack>(entity =>
            {
                entity.HasKey(e => e.TxnKey)
                    .HasName("PK_D30FeedBack");

                entity.ToTable("D30FeedBack");

                entity.Property(e => e.TxnKey).ValueGeneratedNever();

                entity.Property(e => e.CrBy).HasColumnName("CR_BY");

                entity.Property(e => e.CrDt)
                    .HasColumnName("CR_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.DocPath).HasMaxLength(100);

                entity.Property(e => e.EdBy).HasColumnName("ED_BY");

                entity.Property(e => e.EdDt)
                    .HasColumnName("ED_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.FeedBackStr).HasMaxLength(500);

                entity.Property(e => e.ScreenName).HasMaxLength(50);

                entity.HasOne(d => d.DriverKeyNavigation)
                    .WithMany(p => p.D30feedBack)
                    .HasForeignKey(d => d.DriverKey)
                    .HasConstraintName("FK_D30FeedBack_D10User");
            });

            modelBuilder.Entity<D30incidenceTxn>(entity =>
            {
                entity.HasKey(e => e.TxnKey)
                    .HasName("PK_D30IncidenceTxn");

                entity.ToTable("D30IncidenceTxn");

                entity.Property(e => e.TxnKey).ValueGeneratedNever();

                entity.Property(e => e.CrBy).HasColumnName("CR_BY");

                entity.Property(e => e.CrDt)
                    .HasColumnName("CR_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.DocPath).HasMaxLength(100);

                entity.Property(e => e.EdBy).HasColumnName("ED_BY");

                entity.Property(e => e.EdDt)
                    .HasColumnName("ED_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gpslocation)
                    .HasColumnName("GPSLocation")
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.D30incidenceTxn)
                    .HasForeignKey(d => d.ClientKey)
                    .HasConstraintName("FK_D30IncidenceTxn_D10Client");
            });

            modelBuilder.Entity<D30kxtxn>(entity =>
            {
                entity.HasKey(e => e.TxnKey)
                    .HasName("PK_D30KXTxn");

                entity.ToTable("D30KXTxn");

                entity.Property(e => e.TxnKey).ValueGeneratedNever();

                entity.Property(e => e.CrBy).HasColumnName("CR_BY");

                entity.Property(e => e.CrDt)
                    .HasColumnName("CR_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.DocPath).HasMaxLength(100);

                entity.Property(e => e.EdBy).HasColumnName("ED_BY");

                entity.Property(e => e.EdDt)
                    .HasColumnName("ED_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Kxtype)
                    .HasColumnName("KXType")
                    .HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.Tag1).HasMaxLength(50);

                entity.Property(e => e.Tag2).HasMaxLength(50);

                entity.Property(e => e.Tag3).HasMaxLength(50);

                entity.Property(e => e.Tag4).HasMaxLength(50);

                entity.Property(e => e.Tag5).HasMaxLength(50);

                entity.Property(e => e.Tag6).HasMaxLength(50);

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.D30kxtxn)
                    .HasForeignKey(d => d.ClientKey)
                    .HasConstraintName("FK_D30KXTxn_D10Client");

                entity.HasOne(d => d.CustomerKeyNavigation)
                    .WithMany(p => p.D30kxtxn)
                    .HasForeignKey(d => d.CustomerKey)
                    .HasConstraintName("FK_D30KXTxn_D10Customer");

                entity.HasOne(d => d.DriverKeyNavigation)
                    .WithMany(p => p.D30kxtxn)
                    .HasForeignKey(d => d.DriverKey)
                    .HasConstraintName("FK_D30KXTxn_D10User");

                entity.HasOne(d => d.LocationKeyNavigation)
                    .WithMany(p => p.D30kxtxn)
                    .HasForeignKey(d => d.LocationKey)
                    .HasConstraintName("FK_D30KXTxn_D10Location");

                entity.HasOne(d => d.ProdTypeKeyNavigation)
                    .WithMany(p => p.D30kxtxn)
                    .HasForeignKey(d => d.ProdTypeKey)
                    .HasConstraintName("FK_D30KXTxn_D10ProdType");

                entity.HasOne(d => d.VehTypeKeyNavigation)
                    .WithMany(p => p.D30kxtxn)
                    .HasForeignKey(d => d.VehTypeKey)
                    .HasConstraintName("FK_D30KXTxn_D10VehType");
            });

            modelBuilder.Entity<D30loadInfoTxn>(entity =>
            {
                entity.HasKey(e => e.TxnKey)
                    .HasName("PK_D30LoadInfoTxn");

                entity.ToTable("D30LoadInfoTxn");

                entity.Property(e => e.TxnKey).ValueGeneratedNever();

                entity.Property(e => e.CrBy).HasColumnName("CR_BY");

                entity.Property(e => e.CrDt)
                    .HasColumnName("CR_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.EdBy).HasColumnName("ED_BY");

                entity.Property(e => e.EdDt)
                    .HasColumnName("ED_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.Value).HasMaxLength(200);

                entity.Property(e => e.YesNo).HasColumnType("nchar(1)");

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.D30loadInfoTxn)
                    .HasForeignKey(d => d.ClientKey)
                    .HasConstraintName("FK_D30LoadInfoTxn_D10Client");

                entity.HasOne(d => d.CustomerKeyNavigation)
                    .WithMany(p => p.D30loadInfoTxn)
                    .HasForeignKey(d => d.CustomerKey)
                    .HasConstraintName("FK_D30LoadInfoTxn_D10Customer");

                entity.HasOne(d => d.DriverKeyNavigation)
                    .WithMany(p => p.D30loadInfoTxn)
                    .HasForeignKey(d => d.DriverKey)
                    .HasConstraintName("FK_D30LoadInfoTxn_D10User");

                entity.HasOne(d => d.LoadInfoKeyNavigation)
                    .WithMany(p => p.D30loadInfoTxn)
                    .HasForeignKey(d => d.LoadInfoKey)
                    .HasConstraintName("FK_D30LoadInfoTxn_D20LoadInfoData");

                entity.HasOne(d => d.LocationKeyNavigation)
                    .WithMany(p => p.D30loadInfoTxn)
                    .HasForeignKey(d => d.LocationKey)
                    .HasConstraintName("FK_D30LoadInfoTxn_D10Location");

                entity.HasOne(d => d.ProdTypeKeyNavigation)
                    .WithMany(p => p.D30loadInfoTxn)
                    .HasForeignKey(d => d.ProdTypeKey)
                    .HasConstraintName("FK_D30LoadInfoTxn_D10ProdType");

                entity.HasOne(d => d.VehTypeKeyNavigation)
                    .WithMany(p => p.D30loadInfoTxn)
                    .HasForeignKey(d => d.VehTypeKey)
                    .HasConstraintName("FK_D30LoadInfoTxn_D10VehType");
            });

            modelBuilder.Entity<D30ppetxn>(entity =>
            {
                entity.HasKey(e => e.TxnKey)
                    .HasName("PK_D30PPETxn");

                entity.ToTable("D30PPETxn");

                entity.Property(e => e.TxnKey).ValueGeneratedNever();

                entity.Property(e => e.CrBy).HasColumnName("CR_BY");

                entity.Property(e => e.CrDt)
                    .HasColumnName("CR_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.EdBy).HasColumnName("ED_BY");

                entity.Property(e => e.EdDt)
                    .HasColumnName("ED_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ppekey).HasColumnName("PPEKey");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.Value).HasMaxLength(200);

                entity.Property(e => e.YesNo).HasColumnType("nchar(1)");

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.D30ppetxn)
                    .HasForeignKey(d => d.ClientKey)
                    .HasConstraintName("FK_D30PPETxn_D10Client");

                entity.HasOne(d => d.CustomerKeyNavigation)
                    .WithMany(p => p.D30ppetxn)
                    .HasForeignKey(d => d.CustomerKey)
                    .HasConstraintName("FK_D30PPETxn_D10Customer");

                entity.HasOne(d => d.DriverKeyNavigation)
                    .WithMany(p => p.D30ppetxn)
                    .HasForeignKey(d => d.DriverKey)
                    .HasConstraintName("FK_D30PPETxn_D10User");

                entity.HasOne(d => d.LocationKeyNavigation)
                    .WithMany(p => p.D30ppetxn)
                    .HasForeignKey(d => d.LocationKey)
                    .HasConstraintName("FK_D30PPETxn_D10Location");

                entity.HasOne(d => d.PpekeyNavigation)
                    .WithMany(p => p.D30ppetxn)
                    .HasForeignKey(d => d.Ppekey)
                    .HasConstraintName("FK_D30PPETxn_D20PPEData");

                entity.HasOne(d => d.ProdTypeKeyNavigation)
                    .WithMany(p => p.D30ppetxn)
                    .HasForeignKey(d => d.ProdTypeKey)
                    .HasConstraintName("FK_D30PPETxn_D10ProdType");

                entity.HasOne(d => d.VehTypeKeyNavigation)
                    .WithMany(p => p.D30ppetxn)
                    .HasForeignKey(d => d.VehTypeKey)
                    .HasConstraintName("FK_D30PPETxn_D10VehType");
            });

            modelBuilder.Entity<D30redeemTxn>(entity =>
            {
                entity.HasKey(e => e.TxnKey)
                    .HasName("PK_D30RedeemTxn");

                entity.ToTable("D30RedeemTxn");

                entity.Property(e => e.TxnKey).ValueGeneratedNever();

                entity.Property(e => e.CrBy).HasColumnName("CR_BY");

                entity.Property(e => e.CrDt)
                    .HasColumnName("CR_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.EdBy).HasColumnName("ED_BY");

                entity.Property(e => e.EdDt)
                    .HasColumnName("ED_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.D30redeemTxn)
                    .HasForeignKey(d => d.ClientKey)
                    .HasConstraintName("FK_D30RedeemTxn_D10Client");

                entity.HasOne(d => d.DriverKeyNavigation)
                    .WithMany(p => p.D30redeemTxnDriverKeyNavigation)
                    .HasForeignKey(d => d.DriverKey)
                    .HasConstraintName("FK_D30RedeemTxn_D10User");

                entity.HasOne(d => d.UserKeyNavigation)
                    .WithMany(p => p.D30redeemTxnUserKeyNavigation)
                    .HasForeignKey(d => d.UserKey)
                    .HasConstraintName("FK_D30RedeemTxn_D10User1");
            });

            modelBuilder.Entity<Direction>(entity =>
            {
                entity.HasKey(e => e.DirectionKey)
                    .HasName("PK_Direction");

                entity.Property(e => e.Direction1).HasMaxLength(50);

                entity.Property(e => e.Direction2).HasMaxLength(50);

                entity.HasOne(d => d.LocationKeyNavigation)
                    .WithMany(p => p.Direction)
                    .HasForeignKey(d => d.LocationKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Direction_Location");
            });

            modelBuilder.Entity<DocumentMaster>(entity =>
            {
                entity.HasKey(e => e.DocumentMasterKey)
                    .HasName("PK_DocumentMaster");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.DocumentMaster)
                    .HasForeignKey(d => d.ClientKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocumentMaster_Client");
            });

            modelBuilder.Entity<DocumentSubmission>(entity =>
            {
                entity.HasKey(e => e.DocumentSubmissionKey)
                    .HasName("PK_DocumentSubmission");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.DocumentPath).HasMaxLength(300);

                entity.Property(e => e.ReviewDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.DocumentSubmission)
                    .HasForeignKey(d => d.ClientKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocumentSubmission_Client");

                entity.HasOne(d => d.DocumentMasterKeyNavigation)
                    .WithMany(p => p.DocumentSubmission)
                    .HasForeignKey(d => d.DocumentMasterKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocumentSubmission_DocumentMaster");

                entity.HasOne(d => d.UserKeyNavigation)
                    .WithMany(p => p.DocumentSubmission)
                    .HasForeignKey(d => d.UserKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocumentSubmission_User");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.HasKey(e => e.FeedbackKey)
                    .HasName("PK_Feedback");

                entity.Property(e => e.Comment).HasMaxLength(1000);

                entity.Property(e => e.DocumentPath).HasMaxLength(300);

                entity.Property(e => e.Response).HasMaxLength(1000);

                entity.Property(e => e.ResponseDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ScreenName).HasMaxLength(50);

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.Feedback)
                    .HasForeignKey(d => d.ClientKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Feedback_Client");

                entity.HasOne(d => d.UserKeyNavigation)
                    .WithMany(p => p.Feedback)
                    .HasForeignKey(d => d.UserKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Feedback_User");
            });

            modelBuilder.Entity<Incident>(entity =>
            {
                entity.HasKey(e => e.IncidentKey)
                    .HasName("PK_Incident");

                entity.Property(e => e.DocumentPath)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Gpslocation)
                    .HasColumnName("GPSLocation")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.Incident)
                    .HasForeignKey(d => d.ClientKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Incident_Client");

                entity.HasOne(d => d.UserKeyNavigation)
                    .WithMany(p => p.Incident)
                    .HasForeignKey(d => d.UserKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Incident_User");
            });

            modelBuilder.Entity<Kxmaster>(entity =>
            {
                entity.HasKey(e => e.Kxkey)
                    .HasName("PK_KX");

                entity.ToTable("KXMaster");

                entity.Property(e => e.Kxkey).HasColumnName("KXKey");

                entity.Property(e => e.DocumentPath).HasMaxLength(300);

                entity.Property(e => e.Kxtype)
                    .IsRequired()
                    .HasColumnName("KXType")
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasColumnType("nchar(3)");

                entity.Property(e => e.Tag1).HasMaxLength(50);

                entity.Property(e => e.Tag2).HasMaxLength(50);

                entity.Property(e => e.Tag3).HasMaxLength(50);

                entity.Property(e => e.Tag4).HasMaxLength(50);

                entity.Property(e => e.Tag5).HasMaxLength(50);

                entity.Property(e => e.Tag6).HasColumnType("nchar(10)");

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.Kxmaster)
                    .HasForeignKey(d => d.ClientKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_KXMaster_Client");

                entity.HasOne(d => d.SubmissionKeyNavigation)
                    .WithMany(p => p.Kxmaster)
                    .HasForeignKey(d => d.SubmissionKey)
                    .HasConstraintName("FK_KXMaster_Submission");
            });

            modelBuilder.Entity<LoadInfoConfiguration>(entity =>
            {
                entity.HasKey(e => e.LoadInfoConfigurationKey)
                    .HasName("PK_LoadInfoConfiguration");

                entity.HasOne(d => d.LoadInfoMasterKeyNavigation)
                    .WithMany(p => p.LoadInfoConfiguration)
                    .HasForeignKey(d => d.LoadInfoMasterKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LoadInfoConfiguration_LoadInfoMaster");

                entity.HasOne(d => d.ProductTypeKeyNavigation)
                    .WithMany(p => p.LoadInfoConfiguration)
                    .HasForeignKey(d => d.ProductTypeKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LoadInfoConfiguration_ProductType");
            });

            modelBuilder.Entity<LoadInfoData>(entity =>
            {
                entity.HasKey(e => e.LoadInfoDataKey)
                    .HasName("PK_LoadInfoData");

                entity.Property(e => e.Value).HasMaxLength(2000);

                entity.HasOne(d => d.LoadInfoConfigurationKeyNavigation)
                    .WithMany(p => p.LoadInfoData)
                    .HasForeignKey(d => d.LoadInfoConfigurationKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LoadInfoData_LoadInfoConfiguration");
            });

            modelBuilder.Entity<LoadInfoMaster>(entity =>
            {
                entity.HasKey(e => e.LoadInfoMasterKey)
                    .HasName("PK_LoadInfoMaster");

                entity.Property(e => e.DefaultValue).HasMaxLength(50);

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.YesOrNo).HasMaxLength(50);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.LocationKey)
                    .HasName("PK_Location");

                entity.Property(e => e.Gpsid)
                    .HasColumnName("GPSId")
                    .HasMaxLength(50);

                entity.Property(e => e.LocationId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.ClientKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Location_Client");

                entity.HasOne(d => d.CustomerKeyNavigation)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.CustomerKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Location_Customer");
            });

            modelBuilder.Entity<Ppeconfiguration>(entity =>
            {
                entity.HasKey(e => e.PpeconfigurationKey)
                    .HasName("PK_PPEConfiguration");

                entity.ToTable("PPEConfiguration");

                entity.Property(e => e.PpeconfigurationKey).HasColumnName("PPEConfigurationKey");

                entity.Property(e => e.PpemasterKey).HasColumnName("PPEMasterKey");

                entity.HasOne(d => d.PpemasterKeyNavigation)
                    .WithMany(p => p.Ppeconfiguration)
                    .HasForeignKey(d => d.PpemasterKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PPEConfiguration_PPEMaster");

                entity.HasOne(d => d.ProductTypeKeyNavigation)
                    .WithMany(p => p.Ppeconfiguration)
                    .HasForeignKey(d => d.ProductTypeKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PPEConfiguration_ProductType");
            });

            modelBuilder.Entity<Ppedata>(entity =>
            {
                entity.HasKey(e => e.PpedataKey)
                    .HasName("PK_PPEData");

                entity.ToTable("PPEData");

                entity.Property(e => e.PpedataKey).HasColumnName("PPEDataKey");

                entity.Property(e => e.PpeconfigurationKey).HasColumnName("PPEConfigurationKey");

                entity.Property(e => e.Value).HasMaxLength(2000);

                entity.HasOne(d => d.PpeconfigurationKeyNavigation)
                    .WithMany(p => p.Ppedata)
                    .HasForeignKey(d => d.PpeconfigurationKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PPEData_PPEConfiguration");
            });

            modelBuilder.Entity<Ppemaster>(entity =>
            {
                entity.HasKey(e => e.PpemasterKey)
                    .HasName("PK_PPEMaster");

                entity.ToTable("PPEMaster");

                entity.Property(e => e.PpemasterKey).HasColumnName("PPEMasterKey");

                entity.Property(e => e.DefaultValue).HasMaxLength(50);

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.YesOrNo).HasMaxLength(50);
            });

            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.HasKey(e => e.ProductTypeKey)
                    .HasName("PK_ProductType");

                entity.Property(e => e.Type).HasMaxLength(150);

                entity.HasOne(d => d.LocationKeyNavigation)
                    .WithMany(p => p.ProductType)
                    .HasForeignKey(d => d.LocationKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProductType_Location");

                entity.HasOne(d => d.VehicleTypeMasterKeyNavigation)
                    .WithMany(p => p.ProductType)
                    .HasForeignKey(d => d.VehicleTypeMasterKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProductType_VehicleTypeMaster");
            });

            modelBuilder.Entity<Reward>(entity =>
            {
                entity.HasKey(e => e.RewardKey)
                    .HasName("PK_Reward");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.RedeemStatus).HasColumnType("nchar(3)");

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.Reward)
                    .HasForeignKey(d => d.ClientKey)
                    .HasConstraintName("FK_Reward_Client");

                entity.HasOne(d => d.SubmissionKeyNavigation)
                    .WithMany(p => p.Reward)
                    .HasForeignKey(d => d.SubmissionKey)
                    .HasConstraintName("FK_Reward_Submission");

                entity.HasOne(d => d.UserKeyNavigation)
                    .WithMany(p => p.Reward)
                    .HasForeignKey(d => d.UserKey)
                    .HasConstraintName("FK_Reward_User");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RoleKey)
                    .HasName("PK_Role");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("nchar(3)");
            });

            modelBuilder.Entity<Submission>(entity =>
            {
                entity.HasKey(e => e.SubmissionKey)
                    .HasName("PK_Submission");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.DocumentPath).HasMaxLength(300);

                entity.Property(e => e.ReviewedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.Property(e => e.SubmittedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("nchar(10)");

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.Submission)
                    .HasForeignKey(d => d.ClientKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Submission_Client");

                entity.HasOne(d => d.UserKeyNavigation)
                    .WithMany(p => p.Submission)
                    .HasForeignKey(d => d.UserKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Submission_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserKey)
                    .HasName("PK_User");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.ClientKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_User_Client");

                entity.HasOne(d => d.ManagerUserKeyNavigation)
                    .WithMany(p => p.InverseManagerUserKeyNavigation)
                    .HasForeignKey(d => d.ManagerUserKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_User_User");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => e.UserRoleKey)
                    .HasName("PK_UserRole");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.HasOne(d => d.ClientKeyNavigation)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.ClientKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UserRole_Client");

                entity.HasOne(d => d.RoleKeyNavigation)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.RoleKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UserRole_Role");

                entity.HasOne(d => d.UserKeyNavigation)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.UserKey)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UserRole_User");
            });

            modelBuilder.Entity<VehicleTypeMaster>(entity =>
            {
                entity.HasKey(e => e.VehicleTypeMasterKey)
                    .HasName("PK_VehicleType");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}