
using System.Data.Entity;
using Demo.Core.Entities.Concrete.Access;
using Demo.Core.Entities.Concrete.Common;
using Demo.Core.Entities.Concrete.Docs;
using Demo.Core.Entities.Concrete.Log;
using Demo.Core.Entities.Concrete.SysProj;

namespace Demo.Data.Context
{
    public class DemoContext : DbContext
    {
        private readonly DemoContext _context;
        private DbContextTransaction _transaction;

        public DemoContext()
        : base("name=DemoEntities")
        {

        }

        /// <summary>
        ///  Schema : Access
        /// </summary>
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RolePermission> RolePermissions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }

        /// <summary>
        /// Schema : Common
        /// </summary>
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        /// <summary>
        /// Schema : Docs
        /// </summary>
        public virtual DbSet<Media> Medias { get; set; }

        /// <summary>
        /// Schema : Log
        /// </summary>
        public virtual DbSet<ExceptionLog> ExceptionLogs { get; set; }
        public virtual DbSet<RequestDetailLog> RequestDetailLogs { get; set; }
        public virtual DbSet<RequestLog> RequestLogs { get; set; }

        /// <summary>
        /// Schema : SysProj
        /// </summary>
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Lookup> Lookups { get; set; }
        public virtual DbSet<LookupList> LookupLists { get; set; }
        public virtual DbSet<Parameter> Parameters { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permission>().ToTable("Permissions", "access");
            modelBuilder.Entity<Role>().ToTable("Roles", "access");
            modelBuilder.Entity<RolePermission>().ToTable("RolePermissions", "access");
            modelBuilder.Entity<User>().ToTable("Users", "access");
            modelBuilder.Entity<UserRole>().ToTable("UserRoles", "access");


            modelBuilder.Entity<Media>().ToTable("Persons", "common");
            modelBuilder.Entity<Unit>().ToTable("Units", "common");


            modelBuilder.Entity<Media>().ToTable("Medias", "access");


            modelBuilder.Entity<ExceptionLog>().ToTable("ExceptionLogs", "log");
            modelBuilder.Entity<RequestDetailLog>().ToTable("RequestDetailLogs", "log");
            modelBuilder.Entity<RequestLog>().ToTable("RequestLogs", "log");


            modelBuilder.Entity<Language>().ToTable("Languages", "sysproj");
            modelBuilder.Entity<Lookup>().ToTable("Lookups", "sysproj");
            modelBuilder.Entity<LookupList>().ToTable("LookupLists", "sysproj");
            modelBuilder.Entity<Parameter>().ToTable("Parameters", "sysproj");
            modelBuilder.Entity<Resource>().ToTable("Resources", "sysproj");

            base.OnModelCreating(modelBuilder);
        }

        public void BeginTransaction()
        {
            _transaction = _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            _transaction.Commit();
        }

        public void RoolBack()
        {
            _transaction.Rollback();
        }
    }

}
