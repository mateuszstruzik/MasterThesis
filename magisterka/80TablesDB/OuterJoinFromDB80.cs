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
    public class OuterJoinFromDB80
    {
        Stopwatch sw = new Stopwatch();

        //sqlserver 
        public static SqlServerOuterJoin80TableDbADO OuterJoin80TableDbADO = new SqlServerOuterJoin80TableDbADO();
        public static SqlServerOuterJoin80TableDbENTITY OuterJoin80TableDbENTITY = new SqlServerOuterJoin80TableDbENTITY();
        public static SqlServerOuterJoin80TableDbNHIBERNATE OuterJoin80TableDbNHIBERNATE = new SqlServerOuterJoin80TableDbNHIBERNATE();
        //oracle 
        //public static OracleServerOuterJoin80TableDbADO OuterJoin80TableDbADO = new OracleServerOuterJoin80TableDbADO();
        //public static OracleServerOuterJoin80TableDbENTITY OuterJoin80TableDbENTITY = new OracleServerOuterJoin80TableDbENTITY();
        //public static OracleServerOuterJoin80TableDbNHIBERNATE OuterJoin80TableDbNHIBERNATE = new OracleServerOuterJoin80TableDbNHIBERNATE();
        //postgres
        //public static PostgreSQLServerOuterJoin80TableDbADO OuterJoin80TableDbADO = new PostgreSQLServerOuterJoin80TableDbADO();
        //public static PostgreSQLServerOuterJoin80TableDbENTITY OuterJoin80TableDbENTITY = new PostgreSQLServerOuterJoin80TableDbENTITY();
        //public static PostgreSQLServerOuterJoin80TableDbNHIBERNATE OuterJoin80TableDbNHIBERNATE = new PostgreSQLServerOuterJoin80TableDbNHIBERNATE();

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
            OuterJoin80TableDbADO.GetOuterJoinResultsMultiUser();
        }

        private void ENTITYTest()
        {
            OuterJoin80TableDbENTITY.GetOuterJoinResultsMultiUser();
        }

        private void NHIBERNATETest()
        {
            OuterJoin80TableDbNHIBERNATE.GetOuterJoinResultsMultiUser();
        }
    }
}
