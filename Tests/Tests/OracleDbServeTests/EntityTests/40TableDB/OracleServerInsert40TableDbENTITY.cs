using DataExtract.Models.EntityContext._40TableDB;
using DataExtract.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tests.Tests.OracleDbServeTests.EntityTests.OracleHelperForTest;

namespace Tests.Tests.OracleDbServeTests.EntityTests._40TableDB
{
    public class OracleServerInsert40TableDbENTITY
    {
        public OracleInsertTestHelperEntity HelperEntity = new OracleInsertTestHelperEntity();

        public void InsertTableDb()
        {
            var tokenSource = new CancellationToken();
            var Task1 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table1")));
            var Task2 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table2")));
            var Task3 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table3")));
            var Task4 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table4")));
            var Task5 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table5")));
            var Task6 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table6")));
            var Task7 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table7")));
            var Task8 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table8")));
            var Task9 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table9")));
            var Task10 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table10")));
            var Task11 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table11")));
            var Task12 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table12")));
            var Task13 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table13")));
            var Task14 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table14")));
            var Task15 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table15")));
            var Task16 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table16")));
            var Task17 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table17")));
            var Task18 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table18")));
            var Task19 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table19")));
            var Task20 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table20")));
            var Task21 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table21")));
            var Task22 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table22")));
            var Task23 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table23")));
            var Task24 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table24")));
            var Task25 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table25")));
            var Task26 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table26")));
            var Task27 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table27")));
            var Task28 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table28")));
            var Task29 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table29")));
            var Task30 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table30")));
            var Task31 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table31")));
            var Task32 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table32")));
            var Task33 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table33")));
            var Task34 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table34")));
            var Task35 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table35")));
            var Task36 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table36")));
            var Task37 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table37")));
            var Task38 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table38")));
            var Task39 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table39")));
            var Task40 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor40TableDB>(SqQueries.insertOracleQuery("table40")));

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
            Task21.Start();
            Task22.Start();
            Task23.Start();
            Task24.Start();
            Task25.Start();
            Task26.Start();
            Task27.Start();
            Task28.Start();
            Task29.Start();
            Task30.Start();
            Task31.Start();
            Task32.Start();
            Task33.Start();
            Task34.Start();
            Task35.Start();
            Task36.Start();
            Task37.Start();
            Task38.Start();
            Task39.Start();
            Task40.Start();

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
            Task21,
            Task22,
            Task23,
            Task24,
            Task25,
            Task26,
            Task27,
            Task28,
            Task29,
            Task30,
            Task31,
            Task32,
            Task33,
            Task34,
            Task35,
            Task36,
            Task37,
            Task38,
            Task39,
            Task40,
            }, tokenSource);

        }
    }
}
