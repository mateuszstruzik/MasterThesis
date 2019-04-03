using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Tests.OracleDbServeTests.AdoTests._80TableDB;
using Tests.Tests.OracleDbServeTests.NHibernate._80TableDb;
using Tests.Tests.PostgreSQL.AdoTests._80TableDB;
using Tests.Tests.PostgreSQL.EntityTest._80TableDb;
using Tests.Tests.PostgreSQL.NHibernate._80TableDb;
using Tests.Tests.SqlServerTests.ADOTESTS._80TableDB;
using Tests.Tests.SqlServerTests.EntityTest._80TableDB;
using Tests.Tests.SqlServerTests.NHibernate._80TableDb;

namespace magisterka._80TablesDB
{
    public class UpdateDB80
    {
        Stopwatch sw = new Stopwatch();
        //sqlserver
        public static SqlServerUpdate80TableDbADO Update80TableDbADO = new SqlServerUpdate80TableDbADO();
        public static SqlServerUpdate80TableDbENTITY Update80TableDbENTITY = new SqlServerUpdate80TableDbENTITY();
        public static SqlServerUpdate80TableDbNHIBERNATE Update80TableDbNHIBERNATE = new SqlServerUpdate80TableDbNHIBERNATE();
        ///
        //public static OracleServerUpdate80TableDbADO Update80TableDbADO = new OracleServerUpdate80TableDbADO();
        //public static OracleServerUpdate80TableDbNHIBERNATE Update80TableDbNHIBERNATE = new OracleServerUpdate80TableDbNHIBERNATE();

        //public static PostgreSQLServerUpdate80TableDbADO Update80TableDbADO = new PostgreSQLServerUpdate80TableDbADO();
        //public static PostgreSQLUpdate80TableDbENTITY Update80TableDbENTITY = new PostgreSQLUpdate80TableDbENTITY();
        //public static PostgreSQLUpdate80TableDbNHIBERNATE Update80TableDbNHIBERNATE = new PostgreSQLUpdate80TableDbNHIBERNATE();
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
            Update80TableDbADO.UpdateTableDb();
        }

        private void ENTITYTest()
        {
            Update80TableDbENTITY.UpdateTableContext80Db();
        }

        private void NHIBERNATETest()
        {
            Update80TableDbNHIBERNATE.UpdateTable();
        }
    }
}
