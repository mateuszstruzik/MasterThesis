using DataExtract.Queries;
using DataExtract.Repository.PostgreSQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.PostgreSQL.NHibernate.HelperForTests
{
    public class PostgreSQLDeleteTestHelperNHIBERNATE
    {
        private int numberOfRecords = 50;
        private string connectionString;
        public PostgreSQLDeleteTestHelperNHIBERNATE(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void DeleteFromTableByRecord1<T>(string tableName) where T : class, new()
        {
            PostgreSQLServerRepositoryNHibernate sqlServerRpositoryNh = new PostgreSQLServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryNh.DeleteFromtable<T>(SqQueries.DeleteFromTableByREcordOrac1(tableName), i);
        }

        public void DeleteFromTableByRecord2<T>(string tableName) where T : class, new()
        {
            PostgreSQLServerRepositoryNHibernate sqlServerRpositoryNh = new PostgreSQLServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryNh.DeleteFromtable<T>(SqQueries.DeleteFromTableByREcordOrac2(tableName), i);
        }
        public void DeleteFromTableByRecord3<T>(string tableName) where T : class, new()
        {
            PostgreSQLServerRepositoryNHibernate sqlServerRpositoryNh = new PostgreSQLServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryNh.DeleteFromtable<T>(SqQueries.DeleteFromTableByREcordOrac3(tableName), i);
        }
        public void DeleteFromTableByRecord4<T>(string tableName) where T : class, new()
        {
            PostgreSQLServerRepositoryNHibernate sqlServerRpositoryNh = new PostgreSQLServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryNh.DeleteFromtable<T>(SqQueries.DeleteFromTableByREcordOrac4(tableName), i);
        }
        public void DeleteFromTableByRecord5<T>(string tableName) where T : class, new()
        {
            PostgreSQLServerRepositoryNHibernate sqlServerRpositoryNh = new PostgreSQLServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryNh.DeleteFromtable<T>(SqQueries.DeleteFromTableByREcordOrac5(tableName), i);
        }
        public void DeleteFromTableByRecord6<T>(string tableName) where T : class, new()
        {
            PostgreSQLServerRepositoryNHibernate sqlServerRpositoryNh = new PostgreSQLServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryNh.DeleteFromtable<T>(SqQueries.DeleteFromTableByREcordOrac6(tableName), i);
        }
        public void DeleteFromTableByRecord7<T>(string tableName) where T : class, new()
        {
            PostgreSQLServerRepositoryNHibernate sqlServerRpositoryNh = new PostgreSQLServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryNh.DeleteFromtable<T>(SqQueries.DeleteFromTableByREcordOrac7(tableName), i);
        }
        public void DeleteFromTableByRecord8<T>(string tableName) where T : class, new()
        {
            PostgreSQLServerRepositoryNHibernate sqlServerRpositoryNh = new PostgreSQLServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryNh.DeleteFromtable<T>(SqQueries.DeleteFromTableByREcordOrac8(tableName), i);
        }
        public void DeleteFromTableByRecord9<T>(string tableName) where T : class, new()
        {
            PostgreSQLServerRepositoryNHibernate sqlServerRpositoryNh = new PostgreSQLServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryNh.DeleteFromtable<T>(SqQueries.DeleteFromTableByREcordOrac9(tableName), i);
        }
        public void DeleteFromTableByRecord10<T>(string tableName) where T : class, new()
        {
            PostgreSQLServerRepositoryNHibernate sqlServerRpositoryNh = new PostgreSQLServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryNh.DeleteFromtable<T>(SqQueries.DeleteFromTableByREcordOrac10(tableName), i);
        }
    }
}
