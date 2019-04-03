using DataExtract.Models.TableModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.EntityContext
{
    public class PostgreSQLContextFor10TableDB : DbContext
    {
        public PostgreSQLContextFor10TableDB() : base("PostgreSQLServer10Table")
        {

        }

        public DbSet<Table_1> Table_1 { get; set; }
        public DbSet<Table_2> Table_2 { get; set; }
        public DbSet<Table_3> Table_3 { get; set; }
        public DbSet<Table_4> Table_4 { get; set; }
        public DbSet<Table_5> Table_5 { get; set; }
        public DbSet<Table_6> Table_6 { get; set; }
        public DbSet<Table_7> Table_7 { get; set; }
        public DbSet<Table_8> Table_8 { get; set; }
        public DbSet<Table_9> Table_9 { get; set; }
        public DbSet<Table_10> Table_10 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("");
        }
    }
}
