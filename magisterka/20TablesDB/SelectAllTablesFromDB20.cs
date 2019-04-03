using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Tests.OracleDbServeTests.AdoTests._20TableDB;
using Tests.Tests.OracleDbServeTests.EntityTests._20TableDB;
using Tests.Tests.OracleDbServeTests.NHibernate._20TableDb;
using Tests.Tests.PostgreSQL.AdoTests._20TableDB;
using Tests.Tests.PostgreSQL.EntityTest._20TableDb;
using Tests.Tests.PostgreSQL.NHibernate._20TableDb;
using Tests.Tests.SqlServerTests.ADOTESTS._20TableDB;
using Tests.Tests.SqlServerTests.EntityTest._20TableDb;
using Tests.Tests.SqlServerTests.NHibernate._20TableDb;

namespace magisterka._20TablesDB
{
    public class SelectAllTablesFromDB20
    {
        Stopwatch sw = new Stopwatch();
        //sqlserver 
        //public static SqlServerGetDataFromTable20TableDbADO GetDataFromTable20TableDbADO = new SqlServerGetDataFromTable20TableDbADO();
        //public static SqlServerGetDataFromTable20TableDBENTI GetDataFromTable20TableDBENTI = new SqlServerGetDataFromTable20TableDBENTI();
        //public static SqlServerGetDataFromTable20TableDBNHIBERNATE GetDataFromTable20TableDBNHIBERNATE = new SqlServerGetDataFromTable20TableDBNHIBERNATE();

        //oracle 
        //public static OracleGetDataFromTable20TableDBENTI GetDataFromTable20TableDBENTI = new OracleGetDataFromTable20TableDBENTI();
        //public static OracleServerGetDataFromTable20TableDbADO GetDataFromTable20TableDbADO = new OracleServerGetDataFromTable20TableDbADO();
        //public static OracleGetDataFromTable20TableDBNHIBERNATE GetDataFromTable20TableDBNHIBERNATE = new OracleGetDataFromTable20TableDBNHIBERNATE();

        //postgres
        public static PostgreSQLServerGetDataFromTable20TableDbADO GetDataFromTable20TableDbADO = new PostgreSQLServerGetDataFromTable20TableDbADO();
        public static PostgreSQLGetDataFromTable20TableDBENTI GetDataFromTable20TableDBENTI = new PostgreSQLGetDataFromTable20TableDBENTI();
        public static PostgreSQLGetDataFromTable20TableDBNHIBERNATE GetDataFromTable20TableDBNHIBERNATE = new PostgreSQLGetDataFromTable20TableDBNHIBERNATE();

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
            var j = GetDataFromTable20TableDbADO.GetDataTableByTable();
        }

        private void ENTITYTest()
        {
            var i = GetDataFromTable20TableDBENTI.GetDataTableByTable();
        }

        private void NHIBERNATETest()
        {
            var k = GetDataFromTable20TableDBNHIBERNATE.GetDataTableByTable();
        }
    }
}
