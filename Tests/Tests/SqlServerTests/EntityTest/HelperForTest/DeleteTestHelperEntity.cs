﻿using DataExtract.Models.EntityContext;
using DataExtract.Queries;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.SqlServerTests.EntityTest.HelperForTest
{
    public class DeleteTestHelperEntity
    {
        private int RecordsNumber = 100;

        public void DeleteTableContext1<T>(string tableName) where T : DbContext ,new()
        {
            using (var context = new T())
            {
                for (int i = 1; i < RecordsNumber +1; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.DeleteFromTableByREcord1(tableName), new SqlParameter("@ColumnNumber", i));

                }
                context.SaveChanges();
            }
        }

        public void DeleteTableContext2<T>(string tableName) where T : DbContext, new()
        {
            using (var context = new T())
            {
                for (int i = 1; i < RecordsNumber +1; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.DeleteFromTableByREcord2(tableName), new SqlParameter("@ColumnNumber", i));
                }

                context.SaveChanges();
            }
        }

        public void DeleteTableContext3<T>(string tableName) where T : DbContext, new()
        {
            using (var context = new T())
            {
                for (int i = 1; i < RecordsNumber +1; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.DeleteFromTableByREcord3(tableName), new SqlParameter("@ColumnNumber", i));
                }
                context.SaveChanges();
            }
        }

        public void DeleteTableContext4<T>(string tableName) where T : DbContext, new()
        {
            using (var context = new T())
            {
                for (int i = 1; i < RecordsNumber +1; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.DeleteFromTableByREcord4(tableName), new SqlParameter("@ColumnNumber", i));

                }
                context.SaveChanges();
            }
        }

        public void DeleteTableContext5<T>(string tableName) where T : DbContext, new()
        {
            using (var context = new T())
            {
                for (int i = 1; i < RecordsNumber +1; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.DeleteFromTableByREcord5(tableName), new SqlParameter("@ColumnNumber", i));

                }
                context.SaveChanges();
            }
        }

        public void DeleteTableContext6<T>(string tableName) where T : DbContext, new()
        {
            using (var context = new T())
            {
                for (int i = 1; i < RecordsNumber +1; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.DeleteFromTableByREcord6(tableName), new SqlParameter("@ColumnNumber", i));

                }
                context.SaveChanges();
            }
        }

        public void DeleteTableContext7<T>(string tableName) where T : DbContext, new()
        {
            using (var context = new T())
            {
                for (int i = 1; i < RecordsNumber +1; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.DeleteFromTableByREcord7(tableName), new SqlParameter("@ColumnNumber", i));

                }
                context.SaveChanges();
            }
        }

        public void DeleteTableContext8<T>(string tableName) where T : DbContext, new()
        {
            using (var context = new T())
            {
                for (int i = 1; i < RecordsNumber +1; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.DeleteFromTableByREcord8(tableName), new SqlParameter("@ColumnNumber", i));

                }
                context.SaveChanges();
            }
        }

        public void DeleteTableContext9<T>(string tableName) where T : DbContext, new()
        {
            using (var context = new T())
            {
                for (int i = 1; i < RecordsNumber +1; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.DeleteFromTableByREcord9(tableName), new SqlParameter("@ColumnNumber", i));

                }
                context.SaveChanges();
            }
        }

        public void DeleteTableContext10<T>(string tableName) where T : DbContext, new()
        {
            using (var context = new T())
            {
                for (int i = 1; i < RecordsNumber +1; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.DeleteFromTableByREcord10(tableName), new SqlParameter("@ColumnNumber", i));

                }
                context.SaveChanges();
            }
        }
    }
}