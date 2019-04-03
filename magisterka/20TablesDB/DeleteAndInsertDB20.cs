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
    public class DeleteAndInsertDB20
    {
        Stopwatch sw = new Stopwatch();
        //sqlserver
        //public static SqlServerDelete20TableDbADO Delete20TableDbADO = new SqlServerDelete20TableDbADO();
        //public static SqlServerDelete20TableDbENTITY Delete20TableDbENTITY = new SqlServerDelete20TableDbENTITY();
        //public static SqlServerDelete20TableDbNHIBERNATE Delete20TableDbNHIBERNATE = new SqlServerDelete20TableDbNHIBERNATE();
        //public static SqlServerInsert20TableDbADO Insert20TableDbADO = new SqlServerInsert20TableDbADO();
        //public static SqlServerInsert20TableDbENTITY Insert20TableDbENTITY = new SqlServerInsert20TableDbENTITY();
        //public static SqlServerInsert20TableDbNHIBERNATE Insert20TableDbNHIBERNATE = new SqlServerInsert20TableDbNHIBERNATE();

        //oracle 
        public static OracleServerDelete20TableDbADO Delete20TableDbADO = new OracleServerDelete20TableDbADO();
        public static OracleServerDelete20TableDbENTITY Delete20TableDbENTITY = new OracleServerDelete20TableDbENTITY();
        public static OracleServerDelete20TableDbNHIBERNATE Delete20TableDbNHIBERNATE = new OracleServerDelete20TableDbNHIBERNATE();
        public static OracleServerInsert20TableDbADO Insert20TableDbADO = new OracleServerInsert20TableDbADO();
        public static OracleServerInsert20TableDbENTITY Insert20TableDbENTITY = new OracleServerInsert20TableDbENTITY();
        public static OracleServerInsert20TableDbNHIBERNATE Insert20TableDbNHIBERNATE = new OracleServerInsert20TableDbNHIBERNATE();

        ////postgresql
        //public static PostgreSQLServerDelete20TableDbADO Delete20TableDbADO = new PostgreSQLServerDelete20TableDbADO();
        //public static PostgreSQLServerDelete20TableDbENTITY Delete20TableDbENTITY = new PostgreSQLServerDelete20TableDbENTITY();
        //public static PostgreSQLServerDelete20TableDbNHIBERNATE Delete20TableDbNHIBERNATE = new PostgreSQLServerDelete20TableDbNHIBERNATE();
        //public static PostgreSQLServerInsert20TableDbADO Insert20TableDbADO = new PostgreSQLServerInsert20TableDbADO();
        //public static PostgreSQLServerInsert20TableDbENTITY Insert20TableDbENTITY = new PostgreSQLServerInsert20TableDbENTITY();
        //public static PostgreSQLInsert20TableDbNHIBERNATE Insert20TableDbNHIBERNATE = new PostgreSQLInsert20TableDbNHIBERNATE();

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
            Insert20TableDbNHIBERNATE.InsertTableDb();
        }

        private void ENTITYTestInsert()
        {
            Insert20TableDbENTITY.InsertTableDb();
        }

        private void ADOTestInsert()
        {
            Insert20TableDbADO.InsertTableDb();
        }

        private void ADOTest()
        {
            Delete20TableDbADO.DeleteTableDb();
        }

        private void ENTITYTest()
        {
            Delete20TableDbENTITY.DeleteTableDb();
        }

        private void NHIBERNATETest()
        {
            Delete20TableDbNHIBERNATE.DeleteTableDb();
        }
    }
}
