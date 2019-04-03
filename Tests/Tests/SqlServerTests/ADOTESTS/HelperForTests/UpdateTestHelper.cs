using DataExtract.Queries;
using DataExtract.Repository.SQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.SqlServerTests.ADOTESTS.HelperForTests
{
    public class UpdateTestHelper
    {
        private int numberOfRecords = 100;
        string connectionstring;

        public UpdateTestHelper(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }
        public void UpdateSchema1(string tableName)
        {
            SqlServerRpositoryAdo sqlServerRpositoryAdo = new SqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.UpdateTable(SqQueries.Column10TableUpdate(tableName), "UpdateTest3", i);
        }
        public void UpdateSchema2(string tableName)
        {
            SqlServerRpositoryAdo sqlServerRpositoryAdo = new SqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.UpdateTable(SqQueries.Column15With2TableUpdate(tableName), "UpdateTest3", i);
        }

        public void UpdateSchema10(string tableName)
        {
            SqlServerRpositoryAdo sqlServerRpositoryAdo = new SqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.UpdateTable(SqQueries.Column15With10TableUpdate(tableName), "UpdateTest3", i);
        }
        public void UpdateSchema3(string tableName)
        {
            SqlServerRpositoryAdo sqlServerRpositoryAdo = new SqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.UpdateTable(SqQueries.Column20With3TableUpdate(tableName), "UpdateTest3", i);
        }
        public void UpdateSchema9(string tableName)
        {
            SqlServerRpositoryAdo sqlServerRpositoryAdo = new SqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.UpdateTable(SqQueries.Column20With9TableUpdate(tableName), "UpdateTest3", i);
        }
        public void UpdateSchema4(string tableName)
        {
            SqlServerRpositoryAdo sqlServerRpositoryAdo = new SqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.UpdateTable(SqQueries.Column25With4TableUpdate(tableName), "UpdateTest3", i);
        }
        public void UpdateSchema8(string tableName)
        {
            SqlServerRpositoryAdo sqlServerRpositoryAdo = new SqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.UpdateTable(SqQueries.Column25With8TableUpdate(tableName), "UpdateTest3", i);
        }

        public void UpdateSchema5(string tableName)
        {
            SqlServerRpositoryAdo sqlServerRpositoryAdo = new SqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.UpdateTable(SqQueries.Column30With5TableUpdate(tableName), "UpdateTest3", i);
        }
        public void UpdateSchema7(string tableName)
        {
            SqlServerRpositoryAdo sqlServerRpositoryAdo = new SqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.UpdateTable(SqQueries.Column30With7TableUpdate(tableName), "UpdateTest3", i);
        }
        public void UpdateSchema6(string tableName)
        {
            SqlServerRpositoryAdo sqlServerRpositoryAdo = new SqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.UpdateTable(SqQueries.Column35With6TableUpdate(tableName), "UpdateTest3", i);
        }
    }
}
