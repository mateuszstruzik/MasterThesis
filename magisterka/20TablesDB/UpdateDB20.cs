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
    public class UpdateDB20
    {
        Stopwatch sw = new Stopwatch();
        //sqlserver
        //public static SqlServerUpdate20TableDbADO Update20TableDbADO = new SqlServerUpdate20TableDbADO();
        //public static SqlServerUpdate20TableDbENTITY Update20TableDbENTITY = new SqlServerUpdate20TableDbENTITY();
        //public static SqlServerUpdate20TableDbNHIBERNATE Update20TableDbNHIBERNATE = new SqlServerUpdate20TableDbNHIBERNATE();

        public static OracleServerUpdate20TableDbADO Update20TableDbADO = new OracleServerUpdate20TableDbADO();
        public static OracleServerUpdate20TableDbENTITY Update20TableDbENTITY = new OracleServerUpdate20TableDbENTITY();
        public static OracleServerUpdate20TableDbNHIBERNATE Update20TableDbNHIBERNATE = new OracleServerUpdate20TableDbNHIBERNATE();


        //public static PostgreSQLServerUpdate20TableDbADO Update20TableDbADO = new PostgreSQLServerUpdate20TableDbADO();
        //public static PostgreSQLUpdate20TableDbENTITY Update20TableDbENTITY = new PostgreSQLUpdate20TableDbENTITY();
        //public static PostgreSQLUpdate20TableDbNHIBERNATE Update20TableDbNHIBERNATE = new PostgreSQLUpdate20TableDbNHIBERNATE();

        public void RunUpdateTest(int chosenTest)
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
            Update20TableDbADO.UpdateTableDb();
        }

        private void ENTITYTest()
        {
            Update20TableDbENTITY.UpdateTableContext20Db();
        }

        private void NHIBERNATETest()
        {
            Update20TableDbNHIBERNATE.UpdateTable();
        }
    }
}
