﻿using DataExtract.Models.EntityContext._20TableDB;
using DataExtract.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tests.Tests.OracleDbServeTests.EntityTests.OracleHelperForTest;

namespace Tests.Tests.OracleDbServeTests.EntityTests._20TableDB
{
    public class OracleServerInsert20TableDbENTITY
    {
        public OracleInsertTestHelperEntity HelperEntity = new OracleInsertTestHelperEntity();

        public void InsertTableDb()
        {
            var tokenSource = new CancellationToken();
            var Task1 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor20TableDB>(SqQueries.insertOracleQuery("table1")));
            var Task2 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor20TableDB>(SqQueries.insertOracleQuery("table2")));
            var Task3 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor20TableDB>(SqQueries.insertOracleQuery("table3")));
            var Task4 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor20TableDB>(SqQueries.insertOracleQuery("table4")));
            var Task5 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor20TableDB>(SqQueries.insertOracleQuery("table5")));
            var Task6 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor20TableDB>(SqQueries.insertOracleQuery("table6")));
            var Task7 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor20TableDB>(SqQueries.insertOracleQuery("table7")));
            var Task8 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor20TableDB>(SqQueries.insertOracleQuery("table8")));
            var Task9 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor20TableDB>(SqQueries.insertOracleQuery("table9")));
            var Task10 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor20TableDB>(SqQueries.insertOracleQuery("table10")));
            var Task11 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor20TableDB>(SqQueries.insertOracleQuery("table11")));
            var Task12 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor20TableDB>(SqQueries.insertOracleQuery("table12")));
            var Task13 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor20TableDB>(SqQueries.insertOracleQuery("table13")));
            var Task14 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor20TableDB>(SqQueries.insertOracleQuery("table14")));
            var Task15 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor20TableDB>(SqQueries.insertOracleQuery("table15")));
            var Task16 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor20TableDB>(SqQueries.insertOracleQuery("table16")));
            var Task17 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor20TableDB>(SqQueries.insertOracleQuery("table17")));
            var Task18 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor20TableDB>(SqQueries.insertOracleQuery("table18")));
            var Task19 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor20TableDB>(SqQueries.insertOracleQuery("table19")));
            var Task20 = new Task(() => HelperEntity.ExecuteSqlInsert<OracleContextFor20TableDB>(SqQueries.insertOracleQuery("table20")));

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