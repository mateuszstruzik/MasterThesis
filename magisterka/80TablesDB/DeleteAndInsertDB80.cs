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
    public class DeleteAndInsertDB80
    {
        Stopwatch sw = new Stopwatch();
        //sqlserver
        public static SqlServerDelete80TableDbADO Delete80TableDbADO = new SqlServerDelete80TableDbADO();
        public static SqlServerDelete80TableDbENTITY Delete80TableDbENTITY = new SqlServerDelete80TableDbENTITY();
        public static SqlServerDelete80TableDbNHIBERNATE Delete80TableDbNHIBERNATE = new SqlServerDelete80TableDbNHIBERNATE();
        public static SqlServerInsert80TableDbADO Insert80TableDbADO = new SqlServerInsert80TableDbADO();
        public static SqlServerInsert80TableDbENTITY Insert80TableDbENTITY = new SqlServerInsert80TableDbENTITY();
        public static SqlServerInsert80TableDbNHIBERNATE Insert80TableDbNHIBERNATE = new SqlServerInsert80TableDbNHIBERNATE();

        //oracle
        //public static OracleServerDelete80TableDbADO Delete80TableDbADO = new OracleServerDelete80TableDbADO();
        //public static OracleServerDelete80TableDbENTITY Delete80TableDbENTITY = new OracleServerDelete80TableDbENTITY();
        //public static OracleServerDelete80TableDbNHIBERNATE Delete80TableDbNHIBERNATE = new OracleServerDelete80TableDbNHIBERNATE();
        //public static OracleServerInsert80TableDbADO Insert80TableDbADO = new OracleServerInsert80TableDbADO();
        //public static OracleServerInsert80TableDbENTITY Insert80TableDbENTITY = new OracleServerInsert80TableDbENTITY();
        //public static OracleServerInsert80TableDbNHIBERNATE Insert80TableDbNHIBERNATE = new OracleServerInsert80TableDbNHIBERNATE();

        //postgresql
        //public static PostgreSQLServerDelete80TableDbADO Delete80TableDbADO = new PostgreSQLServerDelete80TableDbADO();
        //public static PostgreSQLServerDelete80TableDbENTITY Delete80TableDbENTITY = new PostgreSQLServerDelete80TableDbENTITY();
        //public static PostgreSQLServerDelete80TableDbNHIBERNATE Delete80TableDbNHIBERNATE = new PostgreSQLServerDelete80TableDbNHIBERNATE();
        //public static PostgreSQLServerInsert80TableDbADO Insert80TableDbADO = new PostgreSQLServerInsert80TableDbADO();
        //public static PostgreSQLServerInsert80TableDbENTITY Insert80TableDbENTITY = new PostgreSQLServerInsert80TableDbENTITY();
        //public static PostgreSQLInsert80TableDbNHIBERNATE Insert80TableDbNHIBERNATE = new PostgreSQLInsert80TableDbNHIBERNATE();


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
            Insert80TableDbNHIBERNATE.InsertTableDb();
        }

        private void ENTITYTestInsert()
        {
            Insert80TableDbENTITY.InsertTableDb();
        }

        private void ADOTestInsert()
        {
            Insert80TableDbADO.InsertTableDb();
        }

        private void ADOTest()
        {
            Delete80TableDbADO.DeleteTableDb();
        }

        private void ENTITYTest()
        {
            Delete80TableDbENTITY.DeleteTableDb();
        }

        private void NHIBERNATETest()
        {
            Delete80TableDbNHIBERNATE.DeleteTableDb();
        }
    }
}
