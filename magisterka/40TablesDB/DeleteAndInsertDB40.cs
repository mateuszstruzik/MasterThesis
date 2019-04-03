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
    public class DeleteAndInsertDB40
    {
        Stopwatch sw = new Stopwatch();
        //sqlserver
        //public static SqlServerDelete40TableDbADO Delete40TableDbADO = new SqlServerDelete40TableDbADO();
        //public static SqlServerDelete40TableDbENTITY Delete40TableDbENTITY = new SqlServerDelete40TableDbENTITY();
        //public static SqlServerDelete40TableDbNHIBERNATE Delete40TableDbNHIBERNATE = new SqlServerDelete40TableDbNHIBERNATE();
        //public static SqlServerInsert40TableDbADO Insert40TableDbADO = new SqlServerInsert40TableDbADO();
        //public static SqlServerInsert40TableDbENTITY Insert40TableDbENTITY = new SqlServerInsert40TableDbENTITY();
        //public static SqlServerInsert40TableDbNHIBERNATE Insert40TableDbNHIBERNATE = new SqlServerInsert40TableDbNHIBERNATE();

        //oracle
        public static OracleServerDelete40TableDbADO Delete40TableDbADO = new OracleServerDelete40TableDbADO();
        public static OracleServerDelete40TableDbENTITY Delete40TableDbENTITY = new OracleServerDelete40TableDbENTITY();
        public static OracleServerDelete40TableDbNHIBERNATE Delete40TableDbNHIBERNATE = new OracleServerDelete40TableDbNHIBERNATE();
        public static OracleServerInsert40TableDbADO Insert40TableDbADO = new OracleServerInsert40TableDbADO();
        public static OracleServerInsert40TableDbENTITY Insert40TableDbENTITY = new OracleServerInsert40TableDbENTITY();
        public static OracleServerInsert40TableDbNHIBERNATE Insert40TableDbNHIBERNATE = new OracleServerInsert40TableDbNHIBERNATE();

        //postgresql
        //public static PostgreSQLServerDelete40TableDbADO Delete40TableDbADO = new PostgreSQLServerDelete40TableDbADO();
        //public static PostgreSQLServerDelete40TableDbENTITY Delete40TableDbENTITY = new PostgreSQLServerDelete40TableDbENTITY();
        //public static PostgreSQLServerDelete40TableDbNHIBERNATE Delete40TableDbNHIBERNATE = new PostgreSQLServerDelete40TableDbNHIBERNATE();
        //public static PostgreSQLServerInsert40TableDbADO Insert40TableDbADO = new PostgreSQLServerInsert40TableDbADO();
        //public static PostgreSQLServerInsert40TableDbENTITY Insert40TableDbENTITY = new PostgreSQLServerInsert40TableDbENTITY();
        //public static PostgreSQLInsert40TableDbNHIBERNATE Insert40TableDbNHIBERNATE = new PostgreSQLInsert40TableDbNHIBERNATE();

        public void RunUpdateTest(int chosenTest)
        {
            switch (chosenTest)
            {
                case 1:
                    sw.Start();
                    ADOTest();
                    ADOTestInsert();
                    sw.Stop();
                    Console.WriteLine("Elapsed={0}", sw.Elapsed);
                    sw.Reset();
                    break;
                case 2:
                    sw.Start();
                    ENTITYTest();
                    ENTITYTestInsert();
                    sw.Stop();
                    Console.WriteLine("Elapsed={0}", sw.Elapsed);
                    sw.Reset();
                    break;
                case 3:
                    sw.Start();
                    NHIBERNATETest();
                    NHIBERNATETestInsert();
                    sw.Stop();
                    Console.WriteLine("Elapsed={0}", sw.Elapsed);
                    sw.Reset();
                    break;
                default:
                    Console.WriteLine("Wrong option choosen");
                    break;
            }

        }

        private void NHIBERNATETestInsert()
        {
            Insert40TableDbNHIBERNATE.InsertTableDb();
        }

        private void ENTITYTestInsert()
        {
            Insert40TableDbENTITY.InsertTableDb();
        }

        private void ADOTestInsert()
        {
            Insert40TableDbADO.InsertTableDb();
        }

        private void ADOTest()
        {
            Delete40TableDbADO.DeleteTableDb();
        }

        private void ENTITYTest()
        {
            Delete40TableDbENTITY.DeleteTableDb();
        }

        private void NHIBERNATETest()
        {
            Delete40TableDbNHIBERNATE.DeleteTableDb();
        }
    }
}
