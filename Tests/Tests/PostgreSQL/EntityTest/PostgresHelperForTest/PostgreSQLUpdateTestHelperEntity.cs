using DataExtract.Models.EntityContext;
using DataExtract.Queries;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.PostgreSQL.EntityTest.PostgresHelperForTest
{
    public class PostgreSQLUpdateTestHelperEntity
    {
        public string UpdateValue = "EntityUpdatepostgres";
        private int RecordsNumber = 1000;
        public void UpdateTableContext101(string tableName)
        {
            using (var context = new PostgreSQLContextFor10TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.Column10TableUpdatePostgres(tableName), new NpgsqlParameter("@UpdValue", "PostgresEntity"), new NpgsqlParameter("@ColumnNumber", i));
                }

                context.SaveChanges();
            }
        }

        public void UpdateTableContext102(string tableName)
        {
            using (var context = new PostgreSQLContextFor10TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.Column15With2TableUpdatePostgres(tableName), new NpgsqlParameter("@UpdValue", "PostgresEntity"), new NpgsqlParameter("@ColumnNumber", i));
                }

                context.SaveChanges();
            }
        }

        public void UpdateTableContext103(string tableName)
        {
            using (var context = new PostgreSQLContextFor10TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.Column20With3TableUpdatePostgres(tableName), new NpgsqlParameter("@UpdValue", "PostgresEntity"), new NpgsqlParameter("@ColumnNumber", i));
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext104(string tableName)
        {
            using (var context = new PostgreSQLContextFor10TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.Column25With4TableUpdatePostgres(tableName), new NpgsqlParameter("@UpdValue", "PostgresEntity"), new NpgsqlParameter("@ColumnNumber", i));
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext105(string tableName)
        {
            using (var context = new PostgreSQLContextFor10TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.Column30With5TableUpdatePostgres(tableName), new NpgsqlParameter("@UpdValue", "PostgresEntity"), new NpgsqlParameter("@ColumnNumber", i));
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext106(string tableName)
        {
            using (var context = new PostgreSQLContextFor10TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.Column35With6TableUpdatePostgres(tableName), new NpgsqlParameter("@UpdValue", "PostgresEntity"), new NpgsqlParameter("@ColumnNumber", i));
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext107(string tableName)
        {
            using (var context = new PostgreSQLContextFor10TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.Column30With7TableUpdatePostgres(tableName), new NpgsqlParameter("@UpdValue", "PostgresEntity"), new NpgsqlParameter("@ColumnNumber", i));
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext108(string tableName)
        {
            using (var context = new PostgreSQLContextFor10TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.Column25With8TableUpdatePostgres(tableName), new NpgsqlParameter("@UpdValue", "PostgresEntity"), new NpgsqlParameter("@ColumnNumber", i));
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext109(string tableName)
        {
            using (var context = new PostgreSQLContextFor10TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.Column20With9TableUpdatePostgres(tableName), new NpgsqlParameter("@UpdValue", "PostgresEntity"), new NpgsqlParameter("@ColumnNumber", i));
                }
                context.SaveChanges();
            }
        }

        public void UpdateTableContext1010(string tableName)
        {
            using (var context = new PostgreSQLContextFor10TableDB())
            {
                for (int i = 1; i < RecordsNumber; i++)
                {
                    context.Database.ExecuteSqlCommand(SqQueries.Column15With10TableUpdatePostgres(tableName), new NpgsqlParameter("@UpdValue", "PostgresEntity"), new NpgsqlParameter("@ColumnNumber", i));
                }
                context.SaveChanges();
            }
        }
    }
}
