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
    public class InnerJoinFromDB20
    {
        Stopwatch sw = new Stopwatch();
        ////sqlserver 
        //public static SqlServerInnerJoin20TableDbADO InnerJoin20TableDbADO = new SqlServerInnerJoin20TableDbADO();
        //public static SqlServerInnerJoin20TableDbENTITY InnerJoin20TableDbENTITY = new SqlServerInnerJoin20TableDbENTITY();
        //public static SqlServerInnerJoin20TableDbNHIBERNATE InnerJoin20TableDbNHIBERNATE = new SqlServerInnerJoin20TableDbNHIBERNATE();
        ////oracle 
        public static OracleServerInnerJoin20TableDbADO InnerJoin20TableDbADO = new OracleServerInnerJoin20TableDbADO();
        public static OracleServerInnerJoin20TableDbENTITY InnerJoin20TableDbENTITY = new OracleServerInnerJoin20TableDbENTITY();
        public static OracleServerInnerJoin20TableDbNHIBERNATE InnerJoin20TableDbNHIBERNATE = new OracleServerInnerJoin20TableDbNHIBERNATE();

        //postgres
        //public static PostgreSQLServerInnerJoin20TableDbADO InnerJoin20TableDbADO = new PostgreSQLServerInnerJoin20TableDbADO();
        //public static PostgreSQLServerInnerJoin20TableDbENTITY InnerJoin20TableDbENTITY = new PostgreSQLServerInnerJoin20TableDbENTITY();
        //public static PostgreSQLServerInnerJoin20TableDbNHIBERNATE InnerJoin20TableDbNHIBERNATE = new PostgreSQLServerInnerJoin20TableDbNHIBERNATE();

        public void RunInnerJoinTest(int chosenTest)
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
            InnerJoin20TableDbADO.GetInnerJoinResultsMultiUser();
        }

        private void ENTITYTest()
        {
            InnerJoin20TableDbENTITY.GetJoinResultsMultiUser();
        }

        private void NHIBERNATETest()
        {
            InnerJoin20TableDbNHIBERNATE.GetOuterJoinResultsMultiUser();
        }
    }
}
