﻿using DataExtract.Queries;
using DataExtract.Repository.PostgreSQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.PostgreSQL.postgreSQLhelperForTest
{
    public class PostgreSQLDeleteTestHelper
    {
        private int numberOfRecords = 1000;
        string connectionstring;

        public PostgreSQLDeleteTestHelper(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }
        public void DeleteFromTableByRecord1(string tableName)
        {
            PostgreSqlServerRpositoryAdo sqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.DeleteFromTable(SqQueries.DeleteFromTableByREcord1(tableName), i);
        }
        public void DeleteFromTableByRecord2(string tableName)
        {
            PostgreSqlServerRpositoryAdo sqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.DeleteFromTable(SqQueries.DeleteFromTableByREcord2(tableName), i);
        }
        public void DeleteFromTableByRecord3(string tableName)
        {
            PostgreSqlServerRpositoryAdo sqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.DeleteFromTable(SqQueries.DeleteFromTableByREcord3(tableName), i);
        }
        public void DeleteFromTableByRecord4(string tableName)
        {
            PostgreSqlServerRpositoryAdo sqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.DeleteFromTable(SqQueries.DeleteFromTableByREcord4(tableName), i);
        }
        public void DeleteFromTableByRecord5(string tableName)
        {
            PostgreSqlServerRpositoryAdo sqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.DeleteFromTable(SqQueries.DeleteFromTableByREcord5(tableName), i);
        }
        public void DeleteFromTableByRecord6(string tableName)
        {
            PostgreSqlServerRpositoryAdo sqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.DeleteFromTable(SqQueries.DeleteFromTableByREcord6(tableName), i);
        }
        public void DeleteFromTableByRecord7(string tableName)
        {
            PostgreSqlServerRpositoryAdo sqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.DeleteFromTable(SqQueries.DeleteFromTableByREcord7(tableName), i);
        }
        public void DeleteFromTableByRecord8(string tableName)
        {
            PostgreSqlServerRpositoryAdo sqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.DeleteFromTable(SqQueries.DeleteFromTableByREcord8(tableName), i);
        }
        public void DeleteFromTableByRecord9(string tableName)
        {
            PostgreSqlServerRpositoryAdo sqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.DeleteFromTable(SqQueries.DeleteFromTableByREcord9(tableName), i);
        }
        public void DeleteFromTableByRecord10(string tableName)
        {
            PostgreSqlServerRpositoryAdo sqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryAdo.DeleteFromTable(SqQueries.DeleteFromTableByREcord10(tableName), i);
        }
    }
}