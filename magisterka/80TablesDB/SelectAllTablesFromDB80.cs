using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Tests.OracleDbServeTests.AdoTests._80TableDB;
using Tests.Tests.OracleDbServeTests.EntityTests._80TableDB;
using Tests.Tests.OracleDbServeTests.NHibernate._80TableDb;
using Tests.Tests.PostgreSQL.AdoTests._80TableDB;
using Tests.Tests.PostgreSQL.EntityTest._80TableDb;
using Tests.Tests.PostgreSQL.NHibernate._80TableDb;
using Tests.Tests.SqlServerTests.ADOTESTS._80TableDB;
using Tests.Tests.SqlServerTests.EntityTest._80TableDB;
using Tests.Tests.SqlServerTests.NHibernate._80TableDb;

namespace magisterka._80TablesDB
{
    public class SelectAllTablesFromDB80
    {
        Stopwatch sw = new Stopwatch();
        //sqlserver 
        //public static SqlServerGetDataFromTable80TableDbADO GetDataFromTable80TableDbADO = new SqlServerGetDataFromTable80TableDbADO();
        //public static SqlServerGetDataFromTable80TableDBENTI GetDataFromTable80TableDBENTI = new SqlServerGetDataFromTable80TableDBENTI();
        //public static SqlServerGetDataFromTable80TableDBNHIBERNATE GetDataFromTable80TableDBNHIBERNATE = new SqlServerGetDataFromTable80TableDBNHIBERNATE();
        //oracle 
        //public static OracleServerGetDataFromTable80TableDbADO GetDataFromTable80TableDbADO = new OracleServerGetDataFromTable80TableDbADO();
        //public static OracleGetDataFromTable80TableDBENTI GetDataFromTable80TableDBENTI = new OracleGetDataFromTable80TableDBENTI();
        //public static OracleGetDataFromTable80TableDBNHIBERNATE GetDataFromTable80TableDBNHIBERNATE = new OracleGetDataFromTable80TableDBNHIBERNATE();
        //postgres
        public static PostgreSQLServerGetDataFromTable80TableDbADO GetDataFromTable80TableDbADO = new PostgreSQLServerGetDataFromTable80TableDbADO();
        public static PostgreSQLGetDataFromTable80TableDBENTI GetDataFromTable80TableDBENTI = new PostgreSQLGetDataFromTable80TableDBENTI();
        public static PostgreSQLGetDataFromTable80TableDBNHIBERNATE GetDataFromTable80TableDBNHIBERNATE = new PostgreSQLGetDataFromTable80TableDBNHIBERNATE();

        public void RunSelectFromAllTablesTest(int chosenTest)
        {
            switch (chosenTest)
            {
                case 1:
                    sw.Start();
                    ADOTest();
                    sw.Stop();
                    Console.WriteLine("Elapsed={0}", sw.Elapsed);
                    sw.Reset();
                    break;
                case 2:
                    sw.Start();
                    ENTITYTest();
                    sw.Stop();
                    Console.WriteLine("Elapsed={0}", sw.Elapsed);
                    sw.Reset();
                    break;
                case 3:
                    sw.Start();
                    NHIBERNATETest();
                    sw.Stop();
                    Console.WriteLine("Elapsed={0}", sw.Elapsed);
                    sw.Reset();
                    break;
                default:
                    Console.WriteLine("Wrong option choosen");
                    break;
            }
        }

        private void ADOTest()
        {
            var j = GetDataFromTable80TableDbADO.GetDataTableByTable();
        }

        private void ENTITYTest()
        {
            var i = GetDataFromTable80TableDBENTI.GetDataTableByTable();
        }

        private void NHIBERNATETest()
        {
            var k = GetDataFromTable80TableDBNHIBERNATE.GetDataTableByTable();
        }
    }
}

