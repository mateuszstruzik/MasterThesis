using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tests.Tests.SqlServerTests.ADOTESTS.HelperForTests;

namespace Tests.Tests.SqlServerTests.ADOTESTS._10TableDB
{
    public class SqlServerDelete10TableDbADO
    {
        public DeleteTestHelper TestHelper;

        public SqlServerDelete10TableDbADO()
        {
            TestHelper = new DeleteTestHelper("SqlServer10Table");
        }

        public void DeleteTableDb()
        {
            var tokenSource = new CancellationToken();
            var Task1 = new Task(() => TestHelper.DeleteFromTableByRecord1("Table_1"));
            var Task2 = new Task(() => TestHelper.DeleteFromTableByRecord2("Table_2"));
            var Task3 = new Task(() => TestHelper.DeleteFromTableByRecord3("Table_3"));
            var Task4 = new Task(() => TestHelper.DeleteFromTableByRecord4("Table_4"));
            var Task5 = new Task(() => TestHelper.DeleteFromTableByRecord5("Table_5"));
            var Task6 = new Task(() => TestHelper.DeleteFromTableByRecord6("Table_6"));
            var Task7 = new Task(() => TestHelper.DeleteFromTableByRecord7("Table_7"));
            var Task8 = new Task(() => TestHelper.DeleteFromTableByRecord8("Table_8"));
            var Task9 = new Task(() => TestHelper.DeleteFromTableByRecord9("Table_9"));
            var Task10 = new Task(() => TestHelper.DeleteFromTableByRecord10("Table_10"));

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

            new MultitaskingMonitor().WaitAll(new Task[] { Task1,
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
