using DataExtract.Models.EntityContext;
using DataExtract.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tests.Tests.OracleDbServeTests.EntityTests.OracleHelperForTest;

namespace Tests.Tests.OracleDbServeTests.EntityTests._10TableDB
{
    public class OracleServerInsert10TableDbENTITY
    {
        public OracleInsertTestHelperEntity HelperEntity = new OracleInsertTestHelperEntity();

        public void InsertTableDb()
        {
            var tokenSource = new CancellationToken();
            var Task1 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor10TableDB>(SqQueries.insertOracleQuery("table1")));
            var Task2 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor10TableDB>(SqQueries.insertOracleQuery("table2")));
            var Task3 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor10TableDB>(SqQueries.insertOracleQuery("table3")));
            var Task4 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor10TableDB>(SqQueries.insertOracleQuery("table4")));
            var Task5 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor10TableDB>(SqQueries.insertOracleQuery("table5")));
            var Task6 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor10TableDB>(SqQueries.insertOracleQuery("table6")));
            var Task7 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor10TableDB>(SqQueries.insertOracleQuery("table7")));
            var Task8 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor10TableDB>(SqQueries.insertOracleQuery("table8")));
            var Task9 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor10TableDB>(SqQueries.insertOracleQuery("table9")));
            var Task10 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor10TableDB>(SqQueries.insertOracleQuery("table10")));

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
