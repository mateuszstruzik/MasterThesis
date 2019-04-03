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
    public class OracleDeleteTestHelper
    {
        private int numberOfRecords = 100;
        string connectionstring;

        public OracleDeleteTestHelper(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }
        public void DeleteFromTableByRecord1(string tableName)
        {
            OracleDbServerRpositoryAdo sqlServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.DeleteFromTable(SqQueries.DeleteFromTableByREcordOrac1(tableName), i);
        }
        public void DeleteFromTableByRecord2(string tableName)
        {
            OracleDbServerRpositoryAdo sqlServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.DeleteFromTable(SqQueries.DeleteFromTableByREcordOrac2(tableName), i);
        }
        public void DeleteFromTableByRecord3(string tableName)
        {
            OracleDbServerRpositoryAdo sqlServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.DeleteFromTable(SqQueries.DeleteFromTableByREcordOrac3(tableName), i);
        }
        public void DeleteFromTableByRecord4(string tableName)
        {
            OracleDbServerRpositoryAdo sqlServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.DeleteFromTable(SqQueries.DeleteFromTableByREcordOrac4(tableName), i);
        }
        public void DeleteFromTableByRecord5(string tableName)
        {
            OracleDbServerRpositoryAdo sqlServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.DeleteFromTable(SqQueries.DeleteFromTableByREcordOrac5(tableName), i);
        }
        public void DeleteFromTableByRecord6(string tableName)
        {
            OracleDbServerRpositoryAdo sqlServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.DeleteFromTable(SqQueries.DeleteFromTableByREcordOrac6(tableName), i);
        }
        public void DeleteFromTableByRecord7(string tableName)
        {
            OracleDbServerRpositoryAdo sqlServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.DeleteFromTable(SqQueries.DeleteFromTableByREcordOrac7(tableName), i);
        }
        public void DeleteFromTableByRecord8(string tableName)
        {
            OracleDbServerRpositoryAdo sqlServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.DeleteFromTable(SqQueries.DeleteFromTableByREcordOrac8(tableName), i);
        }
        public void DeleteFromTableByRecord9(string tableName)
        {
            OracleDbServerRpositoryAdo sqlServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.DeleteFromTable(SqQueries.DeleteFromTableByREcordOrac9(tableName), i);
        }
        public void DeleteFromTableByRecord10(string tableName)
        {
            OracleDbServerRpositoryAdo sqlServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.DeleteFromTable(SqQueries.DeleteFromTableByREcordOrac10(tableName), i);
        }
    }
}
