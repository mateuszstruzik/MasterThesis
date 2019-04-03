using DataExtract.Queries;
using DataExtract.Repository.OracleDbServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests.Tests.OracleDbServeTests.AdoTests._10TableDB
{
    public class OracleServerInsert10TableDbADO
    {
        private static int objectNumber = 10;
        public OracleDbServerRpositoryAdo[] RpositoryArray = new OracleDbServerRpositoryAdo[objectNumber];
        public OracleServerInsert10TableDbADO()
        {

            for (int i = 0; i < objectNumber; i++)
            {
                RpositoryArray[i] = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings["OracleDbServer10Table"].ConnectionString);
            }
        }

        public void InsertTableDb()
        {
            var tokenSource = new CancellationToken();
            var Task1 = new Task(() => RpositoryArray[0].InsertToTable(SqQueries.insertOracleQuery("table1")));
            var Task2 = new Task(() => RpositoryArray[1].InsertToTable(SqQueries.insertOracleQuery("table2")));
            var Task3 = new Task(() => RpositoryArray[2].InsertToTable(SqQueries.insertOracleQuery("table3")));
            var Task4 = new Task(() => RpositoryArray[3].InsertToTable(SqQueries.insertOracleQuery("table4")));
            var Task5 = new Task(() => RpositoryArray[4].InsertToTable(SqQueries.insertOracleQuery("table5")));
            var Task6 = new Task(() => RpositoryArray[5].InsertToTable(SqQueries.insertOracleQuery("table6")));
            var Task7 = new Task(() => RpositoryArray[6].InsertToTable(SqQueries.insertOracleQuery("table7")));
            var Task8 = new Task(() => RpositoryArray[7].InsertToTable(SqQueries.insertOracleQuery("table8")));
            var Task9 = new Task(() => RpositoryArray[8].InsertToTable(SqQueries.insertOracleQuery("table9")));
            var Task10 = new Task(() => RpositoryArray[9].InsertToTable(SqQueries.insertOracleQuery("table10")));

            Task1.Start();
            Task2.Start();
            Task3.Start();
            Task4.Start();
            Task5.Start();
            Task6.Start();
            Task7.Start();
            Task8.Start();
            Task9.Start();
            Task10.Start();

            new MultitaskingMonitor().WaitAll(new Task[] {
            Task1,
            Task2,
            Task3,
            Task4,
            Task5,
            Task6,
            Task7,
            Task8,
            Task9,
            Task10,
            }, tokenSource);

        }
    }
}
