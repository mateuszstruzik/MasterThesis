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
    public class InnerJoinFromDB10
    {
        Stopwatch sw = new Stopwatch();
        //sqlserver 
        //public static SqlServerInnerJoin10TableDbADO InnerJoin10TableDbADO = new SqlServerInnerJoin10TableDbADO();
        //public static SqlServerInnerJoin10TableDbENTITY InnerJoin10TableDbENTITY = new SqlServerInnerJoin10TableDbENTITY();
        //public static SqlServerInnerJoin10TableDbNHIBERNATE InnerJoin10TableDbNHIBERNATE = new SqlServerInnerJoin10TableDbNHIBERNATE();

        //oracle 
        public static OracleServerInnerJoin10TableDbADO InnerJoin10TableDbADO = new OracleServerInnerJoin10TableDbADO();
        public static OracleServerInnerJoin10TableDbENTITY InnerJoin10TableDbENTITY = new OracleServerInnerJoin10TableDbENTITY();
        public static OracleServerInnerJoin10TableDbNHIBERNATE InnerJoin10TableDbNHIBERNATE = new OracleServerInnerJoin10TableDbNHIBERNATE();

        //postgres 
        //public static PostgreSQLServerInnerJoin10TableDbADO InnerJoin10TableDbADO = new PostgreSQLServerInnerJoin10TableDbADO();
        //public static PostgreSQLServerInnerJoin10TableDbENTITY InnerJoin10TableDbENTITY = new PostgreSQLServerInnerJoin10TableDbENTITY();
        //public static PostgreSQLServerInnerJoin10TableDbNHIBERNATE InnerJoin10TableDbNHIBERNATE = new PostgreSQLServerInnerJoin10TableDbNHIBERNATE();

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
            InnerJoin10TableDbADO.GetInnerJoinResultsMultiUser();
        }

        private void ENTITYTest()
        {
            InnerJoin10TableDbENTITY.GetJoinResultsMultiUser();
        }

        private void NHIBERNATETest()
        {
            InnerJoin10TableDbNHIBERNATE.GetOuterJoinResultsMultiUser();
        }

    }
}
