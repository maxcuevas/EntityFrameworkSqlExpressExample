namespace EntityFrameworkSqlExpressExample
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<anotherTable> anotherTables { get; set; }
        public virtual DbSet<datum> data { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<anotherTable>()
                .Property(e => e.anotherage)
                .IsFixedLength();

            modelBuilder.Entity<anotherTable>()
                .Property(e => e.anotherHeight)
                .IsFixedLength();

            modelBuilder.Entity<datum>()
                .Property(e => e.name)
                .IsFixedLength();
        }
    }
}
