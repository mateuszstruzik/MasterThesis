using AdoNetSqlServer.ADONET.OracleDb;
using AdoNetSqlServer.SQLServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetSqlServer
{
    public class TestFroAdoNet
    {
        //SqlServerConnection sqltest = new SqlServerConnection("data source=.; database=10TablesDB;integrated security=SSPI");
        OracleServeDbConnections oracletest = new OracleServeDbConnections("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST = localhost)(PORT=1521))(CONNECT_DATA =(SERVER=DEDICATED)(SERVICE_NAME=Tab10Db))); User Id=Mati;Password=Real1203#");

        public void testConnection()
        {
            //sqltest.ExecuteSqlQuery(@"Select * from Table_1");
            var  j = oracletest.ExecuteSqlQuery(@"Select * from Table_1");
        }
    }
}
