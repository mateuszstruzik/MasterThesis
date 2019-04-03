using DataExtract.Models.EntityContext._40TableDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.SqlServerTests.EntityTest.HelperForTest
{
    public class UpdateTestHelperEntity3
    {
        public string UpdateValue = "EntityUpdate";
        private int RecordsNumber = 50;
        public void UpdateTableContext301()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext302()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext303()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext304()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext305()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext306()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext307()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext308()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext309()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext3010()
        {
            using (var context = new SqlServerContextFor40TableDB())
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
        public void UpdateTableContext311()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext312()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext313()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext314()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext315()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext316()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext317()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext318()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext319()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext320()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext321()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext322()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext323()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext324()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext325()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext326()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext327()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext328()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext329()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext330()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext331()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext332()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext333()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext334()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext335()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext336()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext337()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext338()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext339()
        {
            using (var context = new SqlServerContextFor40TableDB())
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

        public void UpdateTableContext340()
        {
            using (var context = new SqlServerContextFor40TableDB())
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
    }
}

