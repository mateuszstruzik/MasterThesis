using DataExtract.Queries;
using DataExtract.Repository.OracleDbServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.OracleDbServeTests.AdoTests.OraclehelperForTest
{
    public class OracleUpdateTestHelper
    {
        private int numberOfRecords = 100;
        string connectionstring;

        public OracleUpdateTestHelper(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }
        public void UpdateSchema1(string tableName)
        {
            OracleDbServerRpositoryAdo oracleDbServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                oracleDbServerRpositoryAdo.UpdateTable(SqQueries.Column10TableUpdateOracle(tableName), "UpdateTest3", i);
        }
        public void UpdateSchema2(string tableName)
        {
            OracleDbServerRpositoryAdo oracleDbServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                oracleDbServerRpositoryAdo.UpdateTable(SqQueries.Column15With2TableUpdateOracle(tableName), "UpdateTest3", i);
        }

        public void UpdateSchema10(string tableName)
        {
            OracleDbServerRpositoryAdo oracleDbServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                oracleDbServerRpositoryAdo.UpdateTable(SqQueries.Column15With10TableUpdateOracle(tableName), "UpdateTest3", i);
        }
        public void UpdateSchema3(string tableName)
        {
            OracleDbServerRpositoryAdo oracleDbServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                oracleDbServerRpositoryAdo.UpdateTable(SqQueries.Column20With3TableUpdateOracle(tableName), "UpdateTest3", i);
        }
        public void UpdateSchema9(string tableName)
        {
            OracleDbServerRpositoryAdo oracleDbServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                oracleDbServerRpositoryAdo.UpdateTable(SqQueries.Column20With9TableUpdateOracle(tableName), "UpdateTest3", i);
        }
        public void UpdateSchema4(string tableName)
        {
            OracleDbServerRpositoryAdo oracleDbServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                oracleDbServerRpositoryAdo.UpdateTable(SqQueries.Column25With4TableUpdateOracle(tableName), "UpdateTest3", i);
        }
        public void UpdateSchema8(string tableName)
        {
            OracleDbServerRpositoryAdo oracleDbServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                oracleDbServerRpositoryAdo.UpdateTable(SqQueries.Column25With8TableUpdateOracle(tableName), "UpdateTest3", i);
        }

        public void UpdateSchema5(string tableName)
        {
            OracleDbServerRpositoryAdo oracleDbServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                oracleDbServerRpositoryAdo.UpdateTable(SqQueries.Column30With5TableUpdateOracle(tableName), "UpdateTest3", i);
        }
        public void UpdateSchema7(string tableName)
        {
            OracleDbServerRpositoryAdo oracleDbServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                oracleDbServerRpositoryAdo.UpdateTable(SqQueries.Column30With7TableUpdateOracle(tableName), "UpdateTest3", i);
        }
        public void UpdateSchema6(string tableName)
        {
            OracleDbServerRpositoryAdo oracleDbServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                oracleDbServerRpositoryAdo.UpdateTable(SqQueries.Column35With6TableUpdateOracle(tableName), "UpdateTest3", i);
        }
    }
}
