using DataExtract.Models.TableModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.EntityContext._20TableDB
{
    public class SqlServerContextFor20TableDB : DbContext
    {
        public SqlServerContextFor20TableDB() : base("SqlServer20Table")
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
        public DbSet<Table_11> Table_11 { get; set; }
        public DbSet<Table_12> Table_12 { get; set; }
        public DbSet<Table_13> Table_13 { get; set; }
        public DbSet<Table_14> Table_14 { get; set; }
        public DbSet<Table_15> Table_15 { get; set; }
        public DbSet<Table_16> Table_16 { get; set; }
        public DbSet<Table_17> Table_17 { get; set; }
        public DbSet<Table_18> Table_18 { get; set; }
        public DbSet<Table_19> Table_19 { get; set; }
        public DbSet<Table_20> Table_20 { get; set; }
    }
}
