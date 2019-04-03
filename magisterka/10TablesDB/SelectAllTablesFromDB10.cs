using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Tests.OracleDbServeTests.AdoTests._10TableDB;
using Tests.Tests.OracleDbServeTests.EntityTests._10TableDB;
using Tests.Tests.OracleDbServeTests.NHibernate._10TableDb;
using Tests.Tests.PostgreSQL.AdoTests._10TableDB;
using Tests.Tests.PostgreSQL.EntityTest._10TableDb;
using Tests.Tests.PostgreSQL.NHibernate._10TableDb;
using Tests.Tests.SqlServerTests.ADOTESTS._10TableDB;
using Tests.Tests.SqlServerTests.EntityTest;
using Tests.Tests.SqlServerTests.NHibernate._10TableDb;

namespace magisterka._10TablesDB
{
    public class SelectAllTablesFromDB10
    {
        Stopwatch sw = new Stopwatch();
        //sqlserver 
        //public SqlServerGetDataFromTable10TableDbADO GetDataFromTable10TableDbADO = new SqlServerGetDataFromTable10TableDbADO();
        //public SqlServerGetDataFromTable10TableDBENTI GetDataFromTable10TableDBENTI = new SqlServerGetDataFromTable10TableDBENTI();
        //public SqlServerGetDataFromTable10TableDBNHIBERNATE GetDataFromTable10TableDBNHIBERNATE = new SqlServerGetDataFromTable10TableDBNHIBERNATE();

        //oracle 
        //public OracleServerGetDataFromTable10TableDbADO GetDataFromTable10TableDbADO = new OracleServerGetDataFromTable10TableDbADO();
        //public OracleGetDataFromTable10TableDBNHIBERNATE GetDataFromTable10TableDBENTI = new OracleGetDataFromTable10TableDBNHIBERNATE();
        //public OracleGetDataFromTable10TableDBENTI GetDataFromTable10TableDBNHIBERNATE = new OracleGetDataFromTable10TableDBENTI();

        //postgres
        public PostgreSQLServerGetDataFromTable10TableDbADO GetDataFromTable10TableDbADO = new PostgreSQLServerGetDataFromTable10TableDbADO();
        public PostgreSQLGetDataFromTable10TableDBENTI GetDataFromTable10TableDBENTI = new PostgreSQLGetDataFromTable10TableDBENTI();
        public PostgreSQLGetDataFromTable10TableDBNHIBERNATE GetDataFromTable10TableDBNHIBERNATE = new PostgreSQLGetDataFromTable10TableDBNHIBERNATE();

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
            var j = GetDataFromTable10TableDbADO.GetDataTableByTable();
        }

        private void ENTITYTest()
        {
            var i = GetDataFromTable10TableDBENTI.GetDataTableByTable();
        }

        private void NHIBERNATETest()
        {
            var k = GetDataFromTable10TableDBNHIBERNATE.GetDataTableByTable();
        }
    }
}
