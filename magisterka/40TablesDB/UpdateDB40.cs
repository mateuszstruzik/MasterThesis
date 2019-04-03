using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Tests.OracleDbServeTests.AdoTests._40TableDB;
using Tests.Tests.OracleDbServeTests.NHibernate._40TableDb;
using Tests.Tests.PostgreSQL.AdoTests._40TableDB;
using Tests.Tests.PostgreSQL.EntityTest._40TableDb;
using Tests.Tests.PostgreSQL.NHibernate._40TableDb;
using Tests.Tests.SqlServerTests.ADOTESTS._40TableDB;
using Tests.Tests.SqlServerTests.EntityTest._40TableDB;
using Tests.Tests.SqlServerTests.NHibernate._40TableDb;

namespace magisterka._40TablesDB
{
    public class UpdateDB40
    {
        Stopwatch sw = new Stopwatch();
        //sqlserver
        //public static SqlServerUpdate40TableDbADO Update40TableDbADO = new SqlServerUpdate40TableDbADO();
        //public static SqlServerUpdate40TableDbENTITY Update40TableDbENTITY = new SqlServerUpdate40TableDbENTITY();
        //public static SqlServerUpdate40TableDbNHIBERNATE Update40TableDbNHIBERNATE = new SqlServerUpdate40TableDbNHIBERNATE();

        public static OracleServerUpdate40TableDbADO Update40TableDbADO = new OracleServerUpdate40TableDbADO();
        public static OracleServerUpdate40TableDbNHIBERNATE Update40TableDbNHIBERNATE = new OracleServerUpdate40TableDbNHIBERNATE();

        //public static PostgreSQLServerUpdate40TableDbADO Update40TableDbADO = new PostgreSQLServerUpdate40TableDbADO();
        //public static PostgreSQLUpdate40TableDbENTITY Update40TableDbENTITY = new PostgreSQLUpdate40TableDbENTITY();
        //public static PostgreSQLUpdate40TableDbNHIBERNATE Update40TableDbNHIBERNATE = new PostgreSQLUpdate40TableDbNHIBERNATE();

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
            Update40TableDbADO.UpdateTableDb();
        }

        private void ENTITYTest()
        {
            //Update40TableDbENTITY.UpdateTableContext30Db();
        }

        private void NHIBERNATETest()
        {
            Update40TableDbNHIBERNATE.UpdateTable();
        }
    }
}
