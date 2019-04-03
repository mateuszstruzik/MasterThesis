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
    public class OuterJoinFromDB20
    {
        Stopwatch sw = new Stopwatch();
        ////sqlserver 40w
        //public static SqlServerOuterJoin20TableDbADO OuterJoin20TableDbADO = new SqlServerOuterJoin20TableDbADO();
        //public static SqlServerOuterJoin20TableDbENTITY OuterJoin20TableDbENTITY = new SqlServerOuterJoin20TableDbENTITY();
        //public static SqlServerOuterJoin20TableDbNHIBERNATE OuterJoin20TableDbNHIBERNATE = new SqlServerOuterJoin20TableDbNHIBERNATE();

        //oracle 
        public static OracleServerOuterJoin20TableDbADO OuterJoin20TableDbADO = new OracleServerOuterJoin20TableDbADO();
        public static OracleServerOuterJoin20TableDbENTITY OuterJoin20TableDbENTITY = new OracleServerOuterJoin20TableDbENTITY();
        public static OracleServerOuterJoin20TableDbNHIBERNATE OuterJoin20TableDbNHIBERNATE = new OracleServerOuterJoin20TableDbNHIBERNATE();
        //postgres
        //public static PostgreSQLServerOuterJoin20TableDbADO OuterJoin20TableDbADO = new PostgreSQLServerOuterJoin20TableDbADO();
        //public static PostgreSQLServerOuterJoin20TableDbENTITY OuterJoin20TableDbENTITY = new PostgreSQLServerOuterJoin20TableDbENTITY();
        //public static PostgreSQLServerOuterJoin20TableDbNHIBERNATE OuterJoin20TableDbNHIBERNATE = new PostgreSQLServerOuterJoin20TableDbNHIBERNATE();

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
            OuterJoin20TableDbADO.GetOuterJoinResultsMultiUser();
        }

        private void ENTITYTest()
        {
            OuterJoin20TableDbENTITY.GetOuterJoinResultsMultiUser();
        }

        private void NHIBERNATETest()
        {
            OuterJoin20TableDbNHIBERNATE.GetOuterJoinResultsMultiUser();
        }
    }
}
