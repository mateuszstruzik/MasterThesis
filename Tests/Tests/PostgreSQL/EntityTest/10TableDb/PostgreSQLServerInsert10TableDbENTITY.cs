﻿using DataExtract.Models.EntityContext;
using DataExtract.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tests.Tests.PostgreSQL.EntityTest.PostgresHelperForTest;

namespace Tests.Tests.PostgreSQL.EntityTest._10TableDb
{
    public class PostgreSQLServerInsert10TableDbENTITY
    {
        public PostgreSQLInsertTestHelperEntity HelperEntity = new PostgreSQLInsertTestHelperEntity();

        public void InsertTableDb()
        {
            var tokenSource = new CancellationToken();
            var Task1 = new Task(() => HelperEntity.ExecuteSqlInsert<PostgreSQLContextFor10TableDB>(SqQueries.insertPostggreQuery("table1")));
            var Task2 = new Task(() => HelperEntity.ExecuteSqlInsert<PostgreSQLContextFor10TableDB>(SqQueries.insertPostggreQuery("table2")));
            var Task3 = new Task(() => HelperEntity.ExecuteSqlInsert<PostgreSQLContextFor10TableDB>(SqQueries.insertPostggreQuery("table3")));
            var Task4 = new Task(() => HelperEntity.ExecuteSqlInsert<PostgreSQLContextFor10TableDB>(SqQueries.insertPostggreQuery("table4")));
            var Task5 = new Task(() => HelperEntity.ExecuteSqlInsert<PostgreSQLContextFor10TableDB>(SqQueries.insertPostggreQuery("table5")));
            var Task6 = new Task(() => HelperEntity.ExecuteSqlInsert<PostgreSQLContextFor10TableDB>(SqQueries.insertPostggreQuery("table6")));
            var Task7 = new Task(() => HelperEntity.ExecuteSqlInsert<PostgreSQLContextFor10TableDB>(SqQueries.insertPostggreQuery("table7")));
            var Task8 = new Task(() => HelperEntity.ExecuteSqlInsert<PostgreSQLContextFor10TableDB>(SqQueries.insertPostggreQuery("table8")));
            var Task9 = new Task(() => HelperEntity.ExecuteSqlInsert<PostgreSQLContextFor10TableDB>(SqQueries.insertPostggreQuery("table9")));
            var Task10 = new Task(() => HelperEntity.ExecuteSqlInsert<PostgreSQLContextFor10TableDB>(SqQueries.insertPostggreQuery("table10")));

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