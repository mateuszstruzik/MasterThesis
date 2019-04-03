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
using Tests.Tests.SqlServerTests.EntityTest._10TableDB;
using Tests.Tests.SqlServerTests.NHibernate._10TableDb;

namespace magisterka._10TablesDB
{
    public class OuterJoinFromDB10
    {
        Stopwatch sw = new Stopwatch();
        //sqlserver 
        //public static SqlServerOuterJoin10TableDbADO OuterJoin10TableDbADO = new SqlServerOuterJoin10TableDbADO();
        //public static SqlServerOuterJoin10TableDbENTITY OuterJoin10TableDbENTITY = new SqlServerOuterJoin10TableDbENTITY();
        //public static SqlServerOuterJoin10TableDbNHIBERNATE OuterJoin10TableDbNHIBERNATE = new SqlServerOuterJoin10TableDbNHIBERNATE();

        //oracle 
        public static OracleServerOuterJoin10TableDbADO OuterJoin10TableDbADO = new OracleServerOuterJoin10TableDbADO();
        public static OracleServerOuterJoin10TableDbENTITY OuterJoin10TableDbENTITY = new OracleServerOuterJoin10TableDbENTITY();
        public static OracleServerOuterJoin10TableDbNHIBERNATE OuterJoin10TableDbNHIBERNATE = new OracleServerOuterJoin10TableDbNHIBERNATE();

        //postgres
        //public static PostgreSQLServerOuterJoin10TableDbADO OuterJoin10TableDbADO = new PostgreSQLServerOuterJoin10TableDbADO();
        //public static PostgreSQLServerOuterJoin10TableDbENTITY OuterJoin10TableDbENTITY = new PostgreSQLServerOuterJoin10TableDbENTITY();
        //public static PostgreSQLServerOuterJoin10TableDbNHIBERNATE OuterJoin10TableDbNHIBERNATE = new PostgreSQLServerOuterJoin10TableDbNHIBERNATE();

        public void RunOuterJoinTest(int chosenTest)
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
            OuterJoin10TableDbADO.GetOuterJoinResultsMultiUser();
        }

        private void ENTITYTest()
        {
            OuterJoin10TableDbENTITY.GetOuterJoinResultsMultiUser();
        }

        private void NHIBERNATETest()
        {
            OuterJoin10TableDbNHIBERNATE.GetOuterJoinResultsMultiUser();
        }
    }
}
