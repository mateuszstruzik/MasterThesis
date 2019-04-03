using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Tests.OracleDbServeTests.AdoTests._40TableDB;
using Tests.Tests.OracleDbServeTests.EntityTests._40TableDB;
using Tests.Tests.OracleDbServeTests.NHibernate._40TableDb;
using Tests.Tests.PostgreSQL.AdoTests._40TableDB;
using Tests.Tests.PostgreSQL.EntityTest._40TableDb;
using Tests.Tests.PostgreSQL.NHibernate._40TableDb;
using Tests.Tests.SqlServerTests.ADOTESTS._40TableDB;
using Tests.Tests.SqlServerTests.EntityTest._40TableDB;
using Tests.Tests.SqlServerTests.NHibernate._40TableDb;

namespace magisterka._40TablesDB
{
    public class SelectAllTablesFromDB40
    {
        Stopwatch sw = new Stopwatch();
        //sqlserver 
        //public static SqlServerGetDataFromTable40TableDbADO GetDataFromTable40TableDbADO = new SqlServerGetDataFromTable40TableDbADO();
        //public static SqlServerGetDataFromTable40TableDBENTI GetDataFromTable40TableDBENTI = new SqlServerGetDataFromTable40TableDBENTI();
        //public static SqlServerGetDataFromTable40TableDBNHIBERNATE GetDataFromTable40TableDBNHIBERNATE = new SqlServerGetDataFromTable40TableDBNHIBERNATE();
        //oracle 
        //public static OracleServerGetDataFromTable40TableDbADO GetDataFromTable40TableDbADO = new OracleServerGetDataFromTable40TableDbADO();
        //public static OracleGetDataFromTable40TableDBENTI GetDataFromTable40TableDBENTI = new OracleGetDataFromTable40TableDBENTI();
        //public static OracleGetDataFromTable40TableDBNHIBERNATE GetDataFromTable40TableDBNHIBERNATE = new OracleGetDataFromTable40TableDBNHIBERNATE();
        //postgres
        public static PostgreSQLServerGetDataFromTable40TableDbADO GetDataFromTable40TableDbADO = new PostgreSQLServerGetDataFromTable40TableDbADO();
        public static PostgreSQLGetDataFromTable40TableDBENTI GetDataFromTable40TableDBENTI = new PostgreSQLGetDataFromTable40TableDBENTI();
        public static PostgreSQLGetDataFromTable40TableDBNHIBERNATE GetDataFromTable40TableDBNHIBERNATE = new PostgreSQLGetDataFromTable40TableDBNHIBERNATE();

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
            var j = GetDataFromTable40TableDbADO.GetDataTableByTable();
        }

        private void ENTITYTest()
        {
            var i = GetDataFromTable40TableDBENTI.GetDataTableByTable();
        }

        private void NHIBERNATETest()
        {
            var k = GetDataFromTable40TableDBNHIBERNATE.GetDataTableByTable();
        }
    }
}
