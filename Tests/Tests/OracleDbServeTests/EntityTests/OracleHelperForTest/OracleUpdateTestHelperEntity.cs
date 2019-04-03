﻿using DataExtract.Models.EntityContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.OracleDbServeTests.EntityTests.OracleHelperForTest
{
    public class OracleUpdateTestHelperEntity
    {
        public string UpdateValue = "EntityUpdate";
        private int RecordsNumber = 1000;
        public void UpdateTableContext101()
        {

            using (var context = new OracleContextFor10TableDB())
            {

                for (int i = 1; i < RecordsNumber; i++)
                {
                    using (var trans = context.Database.BeginTransaction())
                    {
                        var std = context.Table_1.Find(i);
                        std.Column_2_TAB1 = UpdateValue;
                        std.Column_3_TAB1 = UpdateValue;
                        std.Column_4_TAB1 = UpdateValue;
                        std.Column_5_TAB1 = UpdateValue;
                        std.Column_6_TAB1 = UpdateValue;
                        std.Column_7_TAB1 = UpdateValue;
                        std.Column_8_TAB1 = UpdateValue;
                        std.Column_9_TAB1 = UpdateValue;
                        std.Column_10_TAB1 = UpdateValue;

                        trans.Commit();
                        bool a = context.ChangeTracker.HasChanges();

                    }
                }
                context.SaveChanges();

            }
        }

        public void UpdateTableContext102()
        {
            using (var context = new OracleContextFor10TableDB())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    for (int i = 1; i < RecordsNumber; i++)
                    {
                        var std = context.Table_2.Find(i);
                        std.Column_2_TAB2 = UpdateValue;
                        std.Column_3_TAB2 = UpdateValue;
                        std.Column_4_TAB2 = UpdateValue;
                        std.Column_5_TAB2 = UpdateValue;
                        std.Column_6_TAB2 = UpdateValue;
                        std.Column_7_TAB2 = UpdateValue;
                        std.Column_8_TAB2 = UpdateValue;
                        std.Column_9_TAB2 = UpdateValue;
                        std.Column_10_TAB2 = UpdateValue;
                        trans.Commit();
                        bool a = context.ChangeTracker.HasChanges();

                    }
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext103()
        {
            using (var context = new OracleContextFor10TableDB())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    for (int i = 1; i < RecordsNumber; i++)
                    {
                        var std = context.Table_3.Find(i); std.Column_2_TAB3 = UpdateValue;
                        std.Column_3_TAB3 = UpdateValue;
                        std.Column_4_TAB3 = UpdateValue;
                        std.Column_5_TAB3 = UpdateValue;
                        std.Column_6_TAB3 = UpdateValue;
                        std.Column_7_TAB3 = UpdateValue;
                        std.Column_8_TAB3 = UpdateValue;
                        std.Column_9_TAB3 = UpdateValue;
                        std.Column_10_TAB3 = UpdateValue;
                        trans.Commit();
                        bool a = context.ChangeTracker.HasChanges();

                    }
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext104()
        {
            using (var context = new OracleContextFor10TableDB())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    for (int i = 1; i < RecordsNumber; i++)
                    {
                        var std = context.Table_4.Find(i); std.Column_2_TAB4 = UpdateValue;
                        std.Column_3_TAB4 = UpdateValue;
                        std.Column_4_TAB4 = UpdateValue;
                        std.Column_5_TAB4 = UpdateValue;
                        std.Column_6_TAB4 = UpdateValue;
                        std.Column_7_TAB4 = UpdateValue;
                        std.Column_8_TAB4 = UpdateValue;
                        std.Column_9_TAB4 = UpdateValue;
                        std.Column_10_TAB4 = UpdateValue;
                        trans.Commit();
                        bool a = context.ChangeTracker.HasChanges();

                    }
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext105()
        {
            using (var context = new OracleContextFor10TableDB())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    for (int i = 1; i < RecordsNumber; i++)
                    {
                        var std = context.Table_5.Find(i); std.Column_2_TAB5 = UpdateValue;
                        std.Column_3_TAB5 = UpdateValue;
                        std.Column_4_TAB5 = UpdateValue;
                        std.Column_5_TAB5 = UpdateValue;
                        std.Column_6_TAB5 = UpdateValue;
                        std.Column_7_TAB5 = UpdateValue;
                        std.Column_8_TAB5 = UpdateValue;
                        std.Column_9_TAB5 = UpdateValue;
                        std.Column_10_TAB5 = UpdateValue;
                        trans.Commit();
                        bool a = context.ChangeTracker.HasChanges();

                    }
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext106()
        {

            using (var context = new OracleContextFor10TableDB())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    for (int i = 1; i < RecordsNumber; i++)
                    {
                        var std = context.Table_6.Find(i); std.Column_2_TAB6 = UpdateValue;
                        std.Column_3_TAB6 = UpdateValue;
                        std.Column_4_TAB6 = UpdateValue;
                        std.Column_5_TAB6 = UpdateValue;
                        std.Column_6_TAB6 = UpdateValue;
                        std.Column_7_TAB6 = UpdateValue;
                        std.Column_8_TAB6 = UpdateValue;
                        std.Column_9_TAB6 = UpdateValue;
                        std.Column_10_TAB6 = UpdateValue;
                        trans.Commit();
                        bool a = context.ChangeTracker.HasChanges();

                    }
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext107()
        {
            using (var context = new OracleContextFor10TableDB())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    for (int i = 1; i < RecordsNumber; i++)
                    {
                        var std = context.Table_7.Find(i); std.Column_2_TAB7 = UpdateValue;
                        std.Column_3_TAB7 = UpdateValue;
                        std.Column_4_TAB7 = UpdateValue;
                        std.Column_5_TAB7 = UpdateValue;
                        std.Column_6_TAB7 = UpdateValue;
                        std.Column_7_TAB7 = UpdateValue;
                        std.Column_8_TAB7 = UpdateValue;
                        std.Column_9_TAB7 = UpdateValue;
                        std.Column_10_TAB7 = UpdateValue;
                        trans.Commit();
                        bool a = context.ChangeTracker.HasChanges();

                    }
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext108()
        {
            using (var context = new OracleContextFor10TableDB())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    for (int i = 1; i < RecordsNumber; i++)
                    {
                        var std = context.Table_8.Find(i); std.Column_2_TAB8 = UpdateValue;
                        std.Column_3_TAB8 = UpdateValue;
                        std.Column_4_TAB8 = UpdateValue;
                        std.Column_5_TAB8 = UpdateValue;
                        std.Column_6_TAB8 = UpdateValue;
                        std.Column_7_TAB8 = UpdateValue;
                        std.Column_8_TAB8 = UpdateValue;
                        std.Column_9_TAB8 = UpdateValue;
                        std.Column_10_TAB8 = UpdateValue;
                        trans.Commit();
                        bool a = context.ChangeTracker.HasChanges();

                    }
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext109()
        {
            using (var context = new OracleContextFor10TableDB())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    for (int i = 1; i < RecordsNumber; i++)
                    {
                        var std = context.Table_9.Find(i); std.Column_2_TAB9 = UpdateValue;
                        std.Column_3_TAB9 = UpdateValue;
                        std.Column_4_TAB9 = UpdateValue;
                        std.Column_5_TAB9 = UpdateValue;
                        std.Column_6_TAB9 = UpdateValue;
                        std.Column_7_TAB9 = UpdateValue;
                        std.Column_8_TAB9 = UpdateValue;
                        std.Column_9_TAB9 = UpdateValue;
                        std.Column_10_TAB9 = UpdateValue;
                        trans.Commit();
                        bool a = context.ChangeTracker.HasChanges();

                    }
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext1010()
        {
            using (var context = new OracleContextFor10TableDB())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    for (int i = 1; i < RecordsNumber; i++)
                    {
                        var std = context.Table_10.Find(i); std.Column_2_TAB10 = UpdateValue;
                        std.Column_3_TAB10 = UpdateValue;
                        std.Column_4_TAB10 = UpdateValue;
                        std.Column_5_TAB10 = UpdateValue;
                        std.Column_6_TAB10 = UpdateValue;
                        std.Column_7_TAB10 = UpdateValue;
                        std.Column_8_TAB10 = UpdateValue;
                        std.Column_9_TAB10 = UpdateValue;
                        std.Column_10_TAB10 = UpdateValue;
                        trans.Commit();
                        bool a = context.ChangeTracker.HasChanges();

                    }
                }
                context.SaveChanges();
            }
        }
    }
}
