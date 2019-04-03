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
    public class OuterJoinFromDB40
    {
        Stopwatch sw = new Stopwatch();

        ////sqlserver 
        //public static SqlServerOuterJoin40TableDbADO OuterJoin40TableDbADO = new SqlServerOuterJoin40TableDbADO();
        //public static SqlServerOuterJoin40TableDbENTITY OuterJoin40TableDbENTITY = new SqlServerOuterJoin40TableDbENTITY();
        //public static SqlServerOuterJoin40TableDbNHIBERNATE OuterJoin40TableDbNHIBERNATE = new SqlServerOuterJoin40TableDbNHIBERNATE();

        //oracle 
        public static OracleServerOuterJoin40TableDbADO OuterJoin40TableDbADO = new OracleServerOuterJoin40TableDbADO();
        public static OracleServerOuterJoin40TableDbENTITY OuterJoin40TableDbENTITY = new OracleServerOuterJoin40TableDbENTITY();
        public static OracleServerOuterJoin40TableDbNHIBERNATE OuterJoin40TableDbNHIBERNATE = new OracleServerOuterJoin40TableDbNHIBERNATE();

        //postgres
        //public static PostgreSQLServerOuterJoin40TableDbADO OuterJoin40TableDbADO = new PostgreSQLServerOuterJoin40TableDbADO();
        //public static PostgreSQLServerOuterJoin40TableDbENTITY OuterJoin40TableDbENTITY = new PostgreSQLServerOuterJoin40TableDbENTITY();
        //public static PostgreSQLServerOuterJoin40TableDbNHIBERNATE OuterJoin40TableDbNHIBERNATE = new PostgreSQLServerOuterJoin40TableDbNHIBERNATE();

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
            OuterJoin40TableDbADO.GetOuterJoinResultsMultiUser();
        }

        private void ENTITYTest()
        {
            OuterJoin40TableDbENTITY.GetOuterJoinResultsMultiUser();
        }

        private void NHIBERNATETest()
        {
            OuterJoin40TableDbNHIBERNATE.GetOuterJoinResultsMultiUser();
        }
    }
}
