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
    public class DeleteAndInsertDB10
    {
        Stopwatch sw = new Stopwatch();
        //sqlserver
        //public static SqlServerDelete10TableDbADO Delete10TableDbADO = new SqlServerDelete10TableDbADO();
        //public static SqlServerDelete10TableDbENTITY Delete10TableDbENTITY = new SqlServerDelete10TableDbENTITY();
        //public static SqlServerDelete10TableDbNHIBERNATE Delete10TableDbNHIBERNATE = new SqlServerDelete10TableDbNHIBERNATE();
        //public static SqlServerInsert10TableDbADO Insert10TableDbADO = new SqlServerInsert10TableDbADO();
        //public static SqlServerInsert10TableDbENTITY Insert10TableDbENTITY = new SqlServerInsert10TableDbENTITY();
        //public static SqlServerInsert10TableDbNHIBERNATE Insert10TableDbNHIBERNATE = new SqlServerInsert10TableDbNHIBERNATE();

        //Oracle
        public static OracleServerDelete10TableDbADO Delete10TableDbADO = new OracleServerDelete10TableDbADO();
        public static OracleServerDelete10TableDbENTITY Delete10TableDbENTITY = new OracleServerDelete10TableDbENTITY();
        public static OracleServerDelete10TableDbNHIBERNATE Delete10TableDbNHIBERNATE = new OracleServerDelete10TableDbNHIBERNATE();
        public static OracleServerInsert10TableDbADO Insert10TableDbADO = new OracleServerInsert10TableDbADO();
        public static OracleServerInsert10TableDbENTITY Insert10TableDbENTITY = new OracleServerInsert10TableDbENTITY();
        public static OracleServerInsert10TableDbNHIBERNATE Insert10TableDbNHIBERNATE = new OracleServerInsert10TableDbNHIBERNATE();

        ////postgresql
        //public static PostgreSQLServerDelete10TableDbADO Delete10TableDbADO = new PostgreSQLServerDelete10TableDbADO();
        //public static PostgreSQLServerDelete10TableDbENTITY Delete10TableDbENTITY = new PostgreSQLServerDelete10TableDbENTITY();
        //public static PostgreSQLServerDelete10TableDbNHIBERNATE Delete10TableDbNHIBERNATE = new PostgreSQLServerDelete10TableDbNHIBERNATE();
        //public static PostgreSQLServerInsert10TableDbADO Insert10TableDbADO = new PostgreSQLServerInsert10TableDbADO();
        //public static PostgreSQLServerInsert10TableDbENTITY Insert10TableDbENTITY = new PostgreSQLServerInsert10TableDbENTITY();
        //public static PostgreSQLInsert10TableDbNHIBERNATE Insert10TableDbNHIBERNATE = new PostgreSQLInsert10TableDbNHIBERNATE();

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
            Insert10TableDbNHIBERNATE.InsertTableDb();
        }

        private void ENTITYTestInsert()
        {
            Insert10TableDbENTITY.InsertTableDb();
        }

        private void ADOTestInsert()
        {
            Insert10TableDbADO.InsertTableDb();
        }

        private void ADOTest()
        {
            Delete10TableDbADO.DeleteTableDb();
        }

        private void ENTITYTest()
        {
            Delete10TableDbENTITY.DeleteTableDb();
        }

        private void NHIBERNATETest()
        {
            Delete10TableDbNHIBERNATE.DeleteTableDb();
        }
    }
}
