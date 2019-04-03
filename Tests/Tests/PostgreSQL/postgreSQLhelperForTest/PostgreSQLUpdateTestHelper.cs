using DataExtract.Queries;
using DataExtract.Repository.PostgreSQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.PostgreSQL.postgreSQLhelperForTest
{
    public class PostgreSQLUpdateTestHelper
    {
        private int numberOfRecords = 100;
        string connectionstring;

        public PostgreSQLUpdateTestHelper(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }
        public void UpdateSchema1(string tableName)
        {
            PostgreSqlServerRpositoryAdo sqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.UpdateTable(SqQueries.Column10TableUpdatePostgres(tableName), "UpdateTestpostgres", i);
        }
        public void UpdateSchema2(string tableName)
        {
            PostgreSqlServerRpositoryAdo sqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.UpdateTable(SqQueries.Column15With2TableUpdatePostgres(tableName), "UpdateTestpostgres", i);
        }

        public void UpdateSchema10(string tableName)
        {
            PostgreSqlServerRpositoryAdo sqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.UpdateTable(SqQueries.Column15With10TableUpdatePostgres(tableName), "UpdateTestpostgres", i);
        }
        public void UpdateSchema3(string tableName)
        {
            PostgreSqlServerRpositoryAdo sqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.UpdateTable(SqQueries.Column20With3TableUpdatePostgres(tableName), "UpdateTestpostgres", i);
        }
        public void UpdateSchema9(string tableName)
        {
            PostgreSqlServerRpositoryAdo sqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.UpdateTable(SqQueries.Column20With9TableUpdatePostgres(tableName), "UpdateTestpostgres", i);
        }
        public void UpdateSchema4(string tableName)
        {
            PostgreSqlServerRpositoryAdo sqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.UpdateTable(SqQueries.Column25With4TableUpdatePostgres(tableName), "UpdateTestpostgres", i);
        }
        public void UpdateSchema8(string tableName)
        {
            PostgreSqlServerRpositoryAdo sqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.UpdateTable(SqQueries.Column25With8TableUpdatePostgres(tableName), "UpdateTestpostgres", i);
        }

        public void UpdateSchema5(string tableName)
        {
            PostgreSqlServerRpositoryAdo sqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.UpdateTable(SqQueries.Column30With5TableUpdatePostgres(tableName), "UpdateTestpostgres", i);
        }
        public void UpdateSchema7(string tableName)
        {
            PostgreSqlServerRpositoryAdo sqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.UpdateTable(SqQueries.Column30With7TableUpdatePostgres(tableName), "UpdateTestpostgres", i);
        }
        public void UpdateSchema6(string tableName)
        {
            PostgreSqlServerRpositoryAdo sqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.UpdateTable(SqQueries.Column35With6TableUpdatePostgres(tableName), "UpdateTestpostgres", i);
        }
    }
}
