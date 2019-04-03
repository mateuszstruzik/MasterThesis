using DataExtract.Queries;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.OracleDbServeTests.EntityTests.OracleHelperForTest
{
    public class OracleDeleteHelperEntity
    {
        private int RecordsNumber = 100;

        public void DeleteTableContext1<T>(string tableName) where T : DbContext, new()
        {
            using (var context = new T())
            {
                for (int i = 1; i < RecordsNumber + 1; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.DeleteFromTableByREcordOrac1(tableName), new OracleParameter("ColumnNumber", i));

                }
                context.SaveChanges();
            }
        }

        public void DeleteTableContext2<T>(string tableName) where T : DbContext, new()
        {
            using (var context = new T())
            {
                for (int i = 1; i < RecordsNumber + 1; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.DeleteFromTableByREcordOrac2(tableName), new OracleParameter("ColumnNumber", i));
                }

                context.SaveChanges();
            }
        }

        public void DeleteTableContext3<T>(string tableName) where T : DbContext, new()
        {
            using (var context = new T())
            {
                for (int i = 1; i < RecordsNumber + 1; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.DeleteFromTableByREcordOrac3(tableName), new OracleParameter("ColumnNumber", i));
                }
                context.SaveChanges();
            }
        }

        public void DeleteTableContext4<T>(string tableName) where T : DbContext, new()
        {
            using (var context = new T())
            {
                for (int i = 1; i < RecordsNumber + 1; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.DeleteFromTableByREcordOrac4(tableName), new OracleParameter("ColumnNumber", i));

                }
                context.SaveChanges();
            }
        }

        public void DeleteTableContext5<T>(string tableName) where T : DbContext, new()
        {
            using (var context = new T())
            {
                for (int i = 1; i < RecordsNumber + 1; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.DeleteFromTableByREcordOrac5(tableName), new OracleParameter("ColumnNumber", i));

                }
                context.SaveChanges();
            }
        }

        public void DeleteTableContext6<T>(string tableName) where T : DbContext, new()
        {
            using (var context = new T())
            {
                for (int i = 1; i < RecordsNumber + 1; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.DeleteFromTableByREcordOrac6(tableName), new OracleParameter("ColumnNumber", i));

                }
                context.SaveChanges();
            }
        }

        public void DeleteTableContext7<T>(string tableName) where T : DbContext, new()
        {
            using (var context = new T())
            {
                for (int i = 1; i < RecordsNumber + 1; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.DeleteFromTableByREcordOrac7(tableName), new OracleParameter("ColumnNumber", i));

                }
                context.SaveChanges();
            }
        }

        public void DeleteTableContext8<T>(string tableName) where T : DbContext, new()
        {
            using (var context = new T())
            {
                for (int i = 1; i < RecordsNumber + 1; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.DeleteFromTableByREcordOrac8(tableName), new OracleParameter("ColumnNumber", i));

                }
                context.SaveChanges();
            }
        }

        public void DeleteTableContext9<T>(string tableName) where T : DbContext, new()
        {
            using (var context = new T())
            {
                for (int i = 1; i < RecordsNumber + 1; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.DeleteFromTableByREcordOrac9(tableName), new OracleParameter("ColumnNumber", i));

                }
                context.SaveChanges();
            }
        }

        public void DeleteTableContext10<T>(string tableName) where T : DbContext, new()
        {
            using (var context = new T())
            {
                for (int i = 1; i < RecordsNumber + 1; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.DeleteFromTableByREcordOrac10(tableName), new OracleParameter("ColumnNumber", i));

                }
                context.SaveChanges();
            }
        }
    }
}
