using DataExtract.Models.TableModels;
using DataExtract.Models.TableModels.SingleTablesModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.EntityContext._80TableDB
{
    public class OracleContextFor80TableDB : DbContext
    {
        public OracleContextFor80TableDB() : base("OracleDbServer80Table")
        {
            this.Database.CommandTimeout = 600;
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
        public DbSet<Table_21> Table_21 { get; set; }
        public DbSet<Table_22> Table_22 { get; set; }
        public DbSet<Table_23> Table_23 { get; set; }
        public DbSet<Table_24> Table_24 { get; set; }
        public DbSet<Table_25> Table_25 { get; set; }
        public DbSet<Table_26> Table_26 { get; set; }
        public DbSet<Table_27> Table_27 { get; set; }
        public DbSet<Table_28> Table_28 { get; set; }
        public DbSet<Table_29> Table_29 { get; set; }
        public DbSet<Table_30> Table_30 { get; set; }
        public DbSet<Table_31> Table_31 { get; set; }
        public DbSet<Table_32> Table_32 { get; set; }
        public DbSet<Table_33> Table_33 { get; set; }
        public DbSet<Table_34> Table_34 { get; set; }
        public DbSet<Table_35> Table_35 { get; set; }
        public DbSet<Table_36> Table_36 { get; set; }
        public DbSet<Table_37> Table_37 { get; set; }
        public DbSet<Table_38> Table_38 { get; set; }
        public DbSet<Table_39> Table_39 { get; set; }
        public DbSet<Table_40> Table_40 { get; set; }
        public DbSet<Table_41> Table_41 { get; set; }
        public DbSet<Table_42> Table_42 { get; set; }
        public DbSet<Table_43> Table_43 { get; set; }
        public DbSet<Table_44> Table_44 { get; set; }
        public DbSet<Table_45> Table_45 { get; set; }
        public DbSet<Table_46> Table_46 { get; set; }
        public DbSet<Table_47> Table_47 { get; set; }
        public DbSet<Table_48> Table_48 { get; set; }
        public DbSet<Table_49> Table_49 { get; set; }
        public DbSet<Table_50> Table_50 { get; set; }
        public DbSet<Table_51> Table_51 { get; set; }
        public DbSet<Table_52> Table_52 { get; set; }
        public DbSet<Table_53> Table_53 { get; set; }
        public DbSet<Table_54> Table_54 { get; set; }
        public DbSet<Table_55> Table_55 { get; set; }
        public DbSet<Table_56> Table_56 { get; set; }
        public DbSet<Table_57> Table_57 { get; set; }
        public DbSet<Table_58> Table_58 { get; set; }
        public DbSet<Table_59> Table_59 { get; set; }
        public DbSet<Table_60> Table_60 { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("MATI");
        }
    }
}

