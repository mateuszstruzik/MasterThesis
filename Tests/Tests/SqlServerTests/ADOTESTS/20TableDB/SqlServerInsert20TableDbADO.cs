using DataExtract.Queries;
using DataExtract.Repository.SQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests.Tests.SqlServerTests.ADOTESTS._20TableDB
{
    public class SqlServerInsert20TableDbADO
    {
        private static int objectNumber = 20;
        public SqlServerRpositoryAdo[] RpositoryArray = new SqlServerRpositoryAdo[objectNumber];
        public SqlServerInsert20TableDbADO()
        {

            for (int i = 0; i < objectNumber; i++)
            {
                RpositoryArray[i] = new SqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings["SqlServer20Table"].ConnectionString);
            }
        }

        public void InsertTableDb()
        {
            var tokenSource = new CancellationToken();
            var Task1 = new Task(() => RpositoryArray[0].InsertToTable(SqQueries.insertQuery("table1")));
            var Task2 = new Task(() => RpositoryArray[1].InsertToTable(SqQueries.insertQuery("table2")));
            var Task3 = new Task(() => RpositoryArray[2].InsertToTable(SqQueries.insertQuery("table3")));
            var Task4 = new Task(() => RpositoryArray[3].InsertToTable(SqQueries.insertQuery("table4")));
            var Task5 = new Task(() => RpositoryArray[4].InsertToTable(SqQueries.insertQuery("table5")));
            var Task6 = new Task(() => RpositoryArray[5].InsertToTable(SqQueries.insertQuery("table6")));
            var Task7 = new Task(() => RpositoryArray[6].InsertToTable(SqQueries.insertQuery("table7")));
            var Task8 = new Task(() => RpositoryArray[7].InsertToTable(SqQueries.insertQuery("table8")));
            var Task9 = new Task(() => RpositoryArray[8].InsertToTable(SqQueries.insertQuery("table9")));
            var Task10 = new Task(() => RpositoryArray[9].InsertToTable(SqQueries.insertQuery("table10")));
            var Task11 = new Task(() => RpositoryArray[10].InsertToTable(SqQueries.insertQuery("table11")));
            var Task12 = new Task(() => RpositoryArray[11].InsertToTable(SqQueries.insertQuery("table12")));
            var Task13 = new Task(() => RpositoryArray[12].InsertToTable(SqQueries.insertQuery("table13")));
            var Task14 = new Task(() => RpositoryArray[13].InsertToTable(SqQueries.insertQuery("table14")));
            var Task15 = new Task(() => RpositoryArray[14].InsertToTable(SqQueries.insertQuery("table15")));
            var Task16 = new Task(() => RpositoryArray[15].InsertToTable(SqQueries.insertQuery("table16")));
            var Task17 = new Task(() => RpositoryArray[16].InsertToTable(SqQueries.insertQuery("table17")));
            var Task18 = new Task(() => RpositoryArray[17].InsertToTable(SqQueries.insertQuery("table18")));
            var Task19 = new Task(() => RpositoryArray[18].InsertToTable(SqQueries.insertQuery("table19")));
            var Task20 = new Task(() => RpositoryArray[19].InsertToTable(SqQueries.insertQuery("table20")));

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
            Task11.Start();
            Task12.Start();
            Task13.Start();
            Task14.Start();
            Task15.Start();
            Task16.Start();
            Task17.Start();
            Task18.Start();
            Task19.Start();
            Task20.Start();


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
            Task11,
            Task12,
            Task13,
            Task14,
            Task15,
            Task16,
            Task17,
            Task18,
            Task19,
            Task20,
            }, tokenSource);
        }
    }
}
