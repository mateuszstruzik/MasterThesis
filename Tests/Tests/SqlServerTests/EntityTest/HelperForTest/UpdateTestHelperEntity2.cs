﻿using DataExtract.Models.EntityContext._20TableDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.SqlServerTests.EntityTest.HelperForTest
{
    public class UpdateTestHelperEntity2
    {
        public string UpdateValue = "EntityUpdate";
        private int RecordsNumber = 1000;
        public void UpdateTableContext201()
        {
            using (var context = new SqlServerContextFor20TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_1.FirstOrDefault(item => item.Column_1_TAB1 == i);
                    std.Column_2_TAB1 = UpdateValue;
                    std.Column_3_TAB1 = UpdateValue;
                    std.Column_4_TAB1 = UpdateValue;
                    std.Column_5_TAB1 = UpdateValue;
                    std.Column_6_TAB1 = UpdateValue;
                    std.Column_7_TAB1 = UpdateValue;
                    std.Column_8_TAB1 = UpdateValue;
                    std.Column_9_TAB1 = UpdateValue;
                    std.Column_10_TAB1 = UpdateValue;

                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext202()
        {
            using (var context = new SqlServerContextFor20TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_2.FirstOrDefault(item => item.Column_1_TAB2 == i);
                    std.Column_2_TAB2 = UpdateValue;
                    std.Column_3_TAB2 = UpdateValue;
                    std.Column_4_TAB2 = UpdateValue;
                    std.Column_5_TAB2 = UpdateValue;
                    std.Column_6_TAB2 = UpdateValue;
                    std.Column_7_TAB2 = UpdateValue;
                    std.Column_8_TAB2 = UpdateValue;
                    std.Column_9_TAB2 = UpdateValue;
                    std.Column_10_TAB2 = UpdateValue;

                }

                context.SaveChanges();
            }
        }

        public void UpdateTableContext203()
        {
            using (var context = new SqlServerContextFor20TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_3.FirstOrDefault(item => item.Column_1_TAB3 == i);
                    std.Column_2_TAB3 = UpdateValue;
                    std.Column_3_TAB3 = UpdateValue;
                    std.Column_4_TAB3 = UpdateValue;
                    std.Column_5_TAB3 = UpdateValue;
                    std.Column_6_TAB3 = UpdateValue;
                    std.Column_7_TAB3 = UpdateValue;
                    std.Column_8_TAB3 = UpdateValue;
                    std.Column_9_TAB3 = UpdateValue;
                    std.Column_10_TAB3 = UpdateValue;


                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext204()
        {
            using (var context = new SqlServerContextFor20TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_4.FirstOrDefault(item => item.Column_1_TAB4 == i);
                    std.Column_2_TAB4 = UpdateValue;
                    std.Column_3_TAB4 = UpdateValue;
                    std.Column_4_TAB4 = UpdateValue;
                    std.Column_5_TAB4 = UpdateValue;
                    std.Column_6_TAB4 = UpdateValue;
                    std.Column_7_TAB4 = UpdateValue;
                    std.Column_8_TAB4 = UpdateValue;
                    std.Column_9_TAB4 = UpdateValue;
                    std.Column_10_TAB4 = UpdateValue;

                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext205()
        {
            using (var context = new SqlServerContextFor20TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_5.FirstOrDefault(item => item.Column_1_TAB5 == i);
                    std.Column_2_TAB5 = UpdateValue;
                    std.Column_3_TAB5 = UpdateValue;
                    std.Column_4_TAB5 = UpdateValue;
                    std.Column_5_TAB5 = UpdateValue;
                    std.Column_6_TAB5 = UpdateValue;
                    std.Column_7_TAB5 = UpdateValue;
                    std.Column_8_TAB5 = UpdateValue;
                    std.Column_9_TAB5 = UpdateValue;
                    std.Column_10_TAB5 = UpdateValue;


                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext206()
        {
            using (var context = new SqlServerContextFor20TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_6.FirstOrDefault(item => item.Column_1_TAB6 == i);
                    std.Column_2_TAB6 = UpdateValue;
                    std.Column_3_TAB6 = UpdateValue;
                    std.Column_4_TAB6 = UpdateValue;
                    std.Column_5_TAB6 = UpdateValue;
                    std.Column_6_TAB6 = UpdateValue;
                    std.Column_7_TAB6 = UpdateValue;
                    std.Column_8_TAB6 = UpdateValue;
                    std.Column_9_TAB6 = UpdateValue;
                    std.Column_10_TAB6 = UpdateValue;
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext207()
        {
            using (var context = new SqlServerContextFor20TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_7.FirstOrDefault(item => item.Column_1_TAB7 == i);
                    std.Column_2_TAB7 = UpdateValue;
                    std.Column_3_TAB7 = UpdateValue;
                    std.Column_4_TAB7 = UpdateValue;
                    std.Column_5_TAB7 = UpdateValue;
                    std.Column_6_TAB7 = UpdateValue;
                    std.Column_7_TAB7 = UpdateValue;
                    std.Column_8_TAB7 = UpdateValue;
                    std.Column_9_TAB7 = UpdateValue;
                    std.Column_10_TAB7 = UpdateValue;
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext208()
        {
            using (var context = new SqlServerContextFor20TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_8.FirstOrDefault(item => item.Column_1_TAB8 == i);
                    std.Column_2_TAB8 = UpdateValue;
                    std.Column_3_TAB8 = UpdateValue;
                    std.Column_4_TAB8 = UpdateValue;
                    std.Column_5_TAB8 = UpdateValue;
                    std.Column_6_TAB8 = UpdateValue;
                    std.Column_7_TAB8 = UpdateValue;
                    std.Column_8_TAB8 = UpdateValue;
                    std.Column_9_TAB8 = UpdateValue;
                    std.Column_10_TAB8 = UpdateValue;
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext209()
        {
            using (var context = new SqlServerContextFor20TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_9.FirstOrDefault(item => item.Column_1_TAB9 == i);
                    std.Column_2_TAB9 = UpdateValue;
                    std.Column_3_TAB9 = UpdateValue;
                    std.Column_4_TAB9 = UpdateValue;
                    std.Column_5_TAB9 = UpdateValue;
                    std.Column_6_TAB9 = UpdateValue;
                    std.Column_7_TAB9 = UpdateValue;
                    std.Column_8_TAB9 = UpdateValue;
                    std.Column_9_TAB9 = UpdateValue;
                    std.Column_10_TAB9 = UpdateValue;
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext2010()
        {
            using (var context = new SqlServerContextFor20TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_10.FirstOrDefault(item => item.Column_1_TAB10 == i);
                    std.Column_2_TAB10 = UpdateValue;
                    std.Column_3_TAB10 = UpdateValue;
                    std.Column_4_TAB10 = UpdateValue;
                    std.Column_5_TAB10 = UpdateValue;
                    std.Column_6_TAB10 = UpdateValue;
                    std.Column_7_TAB10 = UpdateValue;
                    std.Column_8_TAB10 = UpdateValue;
                    std.Column_9_TAB10 = UpdateValue;
                    std.Column_10_TAB10 = UpdateValue;
                }
                context.SaveChanges();
            }
        }
        public void UpdateTableContext211()
        {
            using (var context = new SqlServerContextFor20TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_1.FirstOrDefault(item => item.Column_1_TAB1 == i);
                    std.Column_2_TAB1 = UpdateValue;
                    std.Column_3_TAB1 = UpdateValue;
                    std.Column_4_TAB1 = UpdateValue;
                    std.Column_5_TAB1 = UpdateValue;
                    std.Column_6_TAB1 = UpdateValue;
                    std.Column_7_TAB1 = UpdateValue;
                    std.Column_8_TAB1 = UpdateValue;
                    std.Column_9_TAB1 = UpdateValue;
                    std.Column_10_TAB1 = UpdateValue;

                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext212()
        {
            using (var context = new SqlServerContextFor20TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_12.FirstOrDefault(item => item.Column_1_TAB2 == i);
                    std.Column_2_TAB2 = UpdateValue;
                    std.Column_3_TAB2 = UpdateValue;
                    std.Column_4_TAB2 = UpdateValue;
                    std.Column_5_TAB2 = UpdateValue;
                    std.Column_6_TAB2 = UpdateValue;
                    std.Column_7_TAB2 = UpdateValue;
                    std.Column_8_TAB2 = UpdateValue;
                    std.Column_9_TAB2 = UpdateValue;
                    std.Column_10_TAB2 = UpdateValue;

                }

                context.SaveChanges();
            }
        }

        public void UpdateTableContext213()
        {
            using (var context = new SqlServerContextFor20TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_13.FirstOrDefault(item => item.Column_1_TAB3 == i);
                    std.Column_2_TAB3 = UpdateValue;
                    std.Column_3_TAB3 = UpdateValue;
                    std.Column_4_TAB3 = UpdateValue;
                    std.Column_5_TAB3 = UpdateValue;
                    std.Column_6_TAB3 = UpdateValue;
                    std.Column_7_TAB3 = UpdateValue;
                    std.Column_8_TAB3 = UpdateValue;
                    std.Column_9_TAB3 = UpdateValue;
                    std.Column_10_TAB3 = UpdateValue;


                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext214()
        {
            using (var context = new SqlServerContextFor20TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_14.FirstOrDefault(item => item.Column_1_TAB4 == i);
                    std.Column_2_TAB4 = UpdateValue;
                    std.Column_3_TAB4 = UpdateValue;
                    std.Column_4_TAB4 = UpdateValue;
                    std.Column_5_TAB4 = UpdateValue;
                    std.Column_6_TAB4 = UpdateValue;
                    std.Column_7_TAB4 = UpdateValue;
                    std.Column_8_TAB4 = UpdateValue;
                    std.Column_9_TAB4 = UpdateValue;
                    std.Column_10_TAB4 = UpdateValue;

                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext215()
        {
            using (var context = new SqlServerContextFor20TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_15.FirstOrDefault(item => item.Column_1_TAB5 == i);
                    std.Column_2_TAB5 = UpdateValue;
                    std.Column_3_TAB5 = UpdateValue;
                    std.Column_4_TAB5 = UpdateValue;
                    std.Column_5_TAB5 = UpdateValue;
                    std.Column_6_TAB5 = UpdateValue;
                    std.Column_7_TAB5 = UpdateValue;
                    std.Column_8_TAB5 = UpdateValue;
                    std.Column_9_TAB5 = UpdateValue;
                    std.Column_10_TAB5 = UpdateValue;


                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext216()
        {
            using (var context = new SqlServerContextFor20TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_16.FirstOrDefault(item => item.Column_1_TAB6 == i);
                    std.Column_2_TAB6 = UpdateValue;
                    std.Column_3_TAB6 = UpdateValue;
                    std.Column_4_TAB6 = UpdateValue;
                    std.Column_5_TAB6 = UpdateValue;
                    std.Column_6_TAB6 = UpdateValue;
                    std.Column_7_TAB6 = UpdateValue;
                    std.Column_8_TAB6 = UpdateValue;
                    std.Column_9_TAB6 = UpdateValue;
                    std.Column_10_TAB6 = UpdateValue;
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext217()
        {
            using (var context = new SqlServerContextFor20TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_17.FirstOrDefault(item => item.Column_1_TAB7 == i);
                    std.Column_2_TAB7 = UpdateValue;
                    std.Column_3_TAB7 = UpdateValue;
                    std.Column_4_TAB7 = UpdateValue;
                    std.Column_5_TAB7 = UpdateValue;
                    std.Column_6_TAB7 = UpdateValue;
                    std.Column_7_TAB7 = UpdateValue;
                    std.Column_8_TAB7 = UpdateValue;
                    std.Column_9_TAB7 = UpdateValue;
                    std.Column_10_TAB7 = UpdateValue;
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext218()
        {
            using (var context = new SqlServerContextFor20TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_18.FirstOrDefault(item => item.Column_1_TAB8 == i);
                    std.Column_2_TAB8 = UpdateValue;
                    std.Column_3_TAB8 = UpdateValue;
                    std.Column_4_TAB8 = UpdateValue;
                    std.Column_5_TAB8 = UpdateValue;
                    std.Column_6_TAB8 = UpdateValue;
                    std.Column_7_TAB8 = UpdateValue;
                    std.Column_8_TAB8 = UpdateValue;
                    std.Column_9_TAB8 = UpdateValue;
                    std.Column_10_TAB8 = UpdateValue;
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext219()
        {
            using (var context = new SqlServerContextFor20TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_19.FirstOrDefault(item => item.Column_1_TAB9 == i);
                    std.Column_2_TAB9 = UpdateValue;
                    std.Column_3_TAB9 = UpdateValue;
                    std.Column_4_TAB9 = UpdateValue;
                    std.Column_5_TAB9 = UpdateValue;
                    std.Column_6_TAB9 = UpdateValue;
                    std.Column_7_TAB9 = UpdateValue;
                    std.Column_8_TAB9 = UpdateValue;
                    std.Column_9_TAB9 = UpdateValue;
                    std.Column_10_TAB9 = UpdateValue;
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext220()
        {
            using (var context = new SqlServerContextFor20TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_20.FirstOrDefault(item => item.Column_1_TAB10 == i);
                    std.Column_2_TAB10 = UpdateValue;
                    std.Column_3_TAB10 = UpdateValue;
                    std.Column_4_TAB10 = UpdateValue;
                    std.Column_5_TAB10 = UpdateValue;
                    std.Column_6_TAB10 = UpdateValue;
                    std.Column_7_TAB10 = UpdateValue;
                    std.Column_8_TAB10 = UpdateValue;
                    std.Column_9_TAB10 = UpdateValue;
                    std.Column_10_TAB10 = UpdateValue;
                }
                context.SaveChanges();
            }
        }
    }
}
