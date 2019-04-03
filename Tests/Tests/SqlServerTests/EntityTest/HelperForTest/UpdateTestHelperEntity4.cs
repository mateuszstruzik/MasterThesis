using DataExtract.Models.EntityContext._80TableDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.SqlServerTests.EntityTest.HelperForTest
{
    public class UpdateTestHelperEntity4
    {
        public string UpdateValue = "EntityUpdate";
        private int RecordsNumber = 100;

        public void UpdateTableContext401()
        {
            using (var context = new SqlServerContextFor80TableDB())
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

        public void UpdateTableContext402()
        {
            using (var context = new SqlServerContextFor80TableDB())
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

        public void UpdateTableContext403()
        {
            using (var context = new SqlServerContextFor80TableDB())
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

        public void UpdateTableContext404()
        {
            using (var context = new SqlServerContextFor80TableDB())
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

        public void UpdateTableContext405()
        {
            using (var context = new SqlServerContextFor80TableDB())
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

        public void UpdateTableContext406()
        {
            using (var context = new SqlServerContextFor80TableDB())
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

        public void UpdateTableContext407()
        {
            using (var context = new SqlServerContextFor80TableDB())
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

        public void UpdateTableContext408()
        {
            using (var context = new SqlServerContextFor80TableDB())
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

        public void UpdateTableContext409()
        {
            using (var context = new SqlServerContextFor80TableDB())
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

        public void UpdateTableContext4010()
        {
            using (var context = new SqlServerContextFor80TableDB())
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
        public void UpdateTableContext411()
        {
            using (var context = new SqlServerContextFor80TableDB())
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

        public void UpdateTableContext412()
        {
            using (var context = new SqlServerContextFor80TableDB())
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

        public void UpdateTableContext413()
        {
            using (var context = new SqlServerContextFor80TableDB())
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

        public void UpdateTableContext414()
        {
            using (var context = new SqlServerContextFor80TableDB())
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

        public void UpdateTableContext415()
        {
            using (var context = new SqlServerContextFor80TableDB())
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

        public void UpdateTableContext416()
        {
            using (var context = new SqlServerContextFor80TableDB())
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

        public void UpdateTableContext417()
        {
            using (var context = new SqlServerContextFor80TableDB())
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

        public void UpdateTableContext418()
        {
            using (var context = new SqlServerContextFor80TableDB())
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

        public void UpdateTableContext419()
        {
            using (var context = new SqlServerContextFor80TableDB())
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

        public void UpdateTableContext420()
        {
            using (var context = new SqlServerContextFor80TableDB())
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

        public void UpdateTableContext421()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_21.FirstOrDefault(item => item.Column_1_TAB1 == i);
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

        public void UpdateTableContext422()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_22.FirstOrDefault(item => item.Column_1_TAB2 == i);
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

        public void UpdateTableContext423()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_23.FirstOrDefault(item => item.Column_1_TAB3 == i);
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

        public void UpdateTableContext424()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_24.FirstOrDefault(item => item.Column_1_TAB4 == i);
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

        public void UpdateTableContext425()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_25.FirstOrDefault(item => item.Column_1_TAB5 == i);
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

        public void UpdateTableContext426()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_26.FirstOrDefault(item => item.Column_1_TAB6 == i);
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

        public void UpdateTableContext427()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_27.FirstOrDefault(item => item.Column_1_TAB7 == i);
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

        public void UpdateTableContext428()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_28.FirstOrDefault(item => item.Column_1_TAB8 == i);
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

        public void UpdateTableContext429()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_29.FirstOrDefault(item => item.Column_1_TAB9 == i);
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

        public void UpdateTableContext430()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_30.FirstOrDefault(item => item.Column_1_TAB10 == i);
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

        public void UpdateTableContext431()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_31.FirstOrDefault(item => item.Column_1_TAB1 == i);
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

        public void UpdateTableContext432()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_32.FirstOrDefault(item => item.Column_1_TAB2 == i);
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

        public void UpdateTableContext433()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_33.FirstOrDefault(item => item.Column_1_TAB3 == i);
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

        public void UpdateTableContext434()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_34.FirstOrDefault(item => item.Column_1_TAB4 == i);
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

        public void UpdateTableContext435()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_35.FirstOrDefault(item => item.Column_1_TAB5 == i);
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

        public void UpdateTableContext436()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_36.FirstOrDefault(item => item.Column_1_TAB6 == i);
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

        public void UpdateTableContext437()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_37.FirstOrDefault(item => item.Column_1_TAB7 == i);
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

        public void UpdateTableContext438()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_38.FirstOrDefault(item => item.Column_1_TAB8 == i);
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

        public void UpdateTableContext439()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_39.FirstOrDefault(item => item.Column_1_TAB9 == i);
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

        public void UpdateTableContext440()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_40.FirstOrDefault(item => item.Column_1_TAB10 == i);
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

        public void UpdateTableContext441()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_41.FirstOrDefault(item => item.Column_1_TAB1 == i);
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

        public void UpdateTableContext442()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_42.FirstOrDefault(item => item.Column_1_TAB2 == i);
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

        public void UpdateTableContext443()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_43.FirstOrDefault(item => item.Column_1_TAB3 == i);
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

        public void UpdateTableContext444()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_44.FirstOrDefault(item => item.Column_1_TAB4 == i);
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

        public void UpdateTableContext445()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_45.FirstOrDefault(item => item.Column_1_TAB5 == i);
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

        public void UpdateTableContext446()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_46.FirstOrDefault(item => item.Column_1_TAB6 == i);
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

        public void UpdateTableContext447()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_47.FirstOrDefault(item => item.Column_1_TAB7 == i);
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

        public void UpdateTableContext448()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_48.FirstOrDefault(item => item.Column_1_TAB8 == i);
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

        public void UpdateTableContext449()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_49.FirstOrDefault(item => item.Column_1_TAB9 == i);
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

        public void UpdateTableContext450()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_50.FirstOrDefault(item => item.Column_1_TAB10 == i);
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

        public void UpdateTableContext451()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_51.FirstOrDefault(item => item.Column_1_TAB1 == i);
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

        public void UpdateTableContext452()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_52.FirstOrDefault(item => item.Column_1_TAB2 == i);
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

        public void UpdateTableContext453()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_53.FirstOrDefault(item => item.Column_1_TAB3 == i);
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

        public void UpdateTableContext454()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_54.FirstOrDefault(item => item.Column_1_TAB4 == i);
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

        public void UpdateTableContext455()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_55.FirstOrDefault(item => item.Column_1_TAB5 == i);
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

        public void UpdateTableContext456()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_56.FirstOrDefault(item => item.Column_1_TAB6 == i);
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

        public void UpdateTableContext457()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_57.FirstOrDefault(item => item.Column_1_TAB7 == i);
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

        public void UpdateTableContext458()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_58.FirstOrDefault(item => item.Column_1_TAB8 == i);
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

        public void UpdateTableContext459()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_59.FirstOrDefault(item => item.Column_1_TAB9 == i);
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

        public void UpdateTableContext460()
        {
            using (var context = new SqlServerContextFor80TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    var std = context.Table_60.FirstOrDefault(item => item.Column_1_TAB10 == i);
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

