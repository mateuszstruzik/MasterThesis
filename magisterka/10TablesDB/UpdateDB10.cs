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
    public class UpdateDB10
    {
        Stopwatch sw = new Stopwatch();
        //sqlserver
        //public static SqlServerUpdate10TableDbADO Update10TableDbADO = new SqlServerUpdate10TableDbADO();
        //public static SqlServerUpdate10TableDbENTITY Update10TableDbENTITY = new SqlServerUpdate10TableDbENTITY();
        //public static SqlServerUpdate10TableDbNHIBERNATE Update10TableDbNHIBERNATE = new SqlServerUpdate10TableDbNHIBERNATE();

        public static OracleServerUpdate10TableDbADO Update10TableDbADO = new OracleServerUpdate10TableDbADO();
        public static OracleServerUpdate10TableDbENTITY Update10TableDbENTITY = new OracleServerUpdate10TableDbENTITY();
        public static OracleServerUpdate10TableDbNHIBERNATE Update10TableDbNHIBERNATE = new OracleServerUpdate10TableDbNHIBERNATE();

        //public static PostgreSQLServerUpdate10TableDbADO Update10TableDbADO = new PostgreSQLServerUpdate10TableDbADO();
        //public static PostgreSQLUpdate10TableDbENTITY Update10TableDbENTITY = new PostgreSQLUpdate10TableDbENTITY();
        //public static PostgreSQLUpdate10TableDbNHIBERNATE Update10TableDbNHIBERNATE = new PostgreSQLUpdate10TableDbNHIBERNATE();

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
            Update10TableDbADO.UpdateTableDb();
        }

        private void ENTITYTest()
        {
            Update10TableDbENTITY.UpdateTableContext10Db();
        }

        private void NHIBERNATETest()
        {
            Update10TableDbNHIBERNATE.UpdateTable();
        }
    }
}
