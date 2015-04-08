namespace DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DataModel;


    public partial class UserManagementContext : DbContext
    {
        public UserManagementContext()
            : base("name=UserManagement")
        {
           this.Database.Initialize(force: false); 

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.LastName)
                .IsUnicode(false);

  
        }
    }
}
