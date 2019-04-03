using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tests.Tests.SqlServerTests.EntityTest.HelperForTest;

namespace Tests.Tests.SqlServerTests.EntityTest._20TableDb
{
   public  class SqlServerUpdate20TableDbENTITY
    {
        UpdateTestHelperEntity2 updateTestHelperEntity2 = new UpdateTestHelperEntity2();
        public void UpdateTableContext20Db()
        {
            var tokenSource = new CancellationToken();
            var Task1 = new Task(() => updateTestHelperEntity2.UpdateTableContext201());
            var Task2 = new Task(() => updateTestHelperEntity2.UpdateTableContext202());
            var Task3 = new Task(() => updateTestHelperEntity2.UpdateTableContext203());
            var Task4 = new Task(() => updateTestHelperEntity2.UpdateTableContext204());
            var Task5 = new Task(() => updateTestHelperEntity2.UpdateTableContext205());
            var Task6 = new Task(() => updateTestHelperEntity2.UpdateTableContext206());
            var Task7 = new Task(() => updateTestHelperEntity2.UpdateTableContext207());
            var Task8 = new Task(() => updateTestHelperEntity2.UpdateTableContext208());
            var Task9 = new Task(() => updateTestHelperEntity2.UpdateTableContext209());
            var Task10 = new Task(() => updateTestHelperEntity2.UpdateTableContext2010());
            var Task11 = new Task(() => updateTestHelperEntity2.UpdateTableContext211());
            var Task12 = new Task(() => updateTestHelperEntity2.UpdateTableContext212());
            var Task13 = new Task(() => updateTestHelperEntity2.UpdateTableContext213());
            var Task14 = new Task(() => updateTestHelperEntity2.UpdateTableContext214());
            var Task15 = new Task(() => updateTestHelperEntity2.UpdateTableContext215());
            var Task16 = new Task(() => updateTestHelperEntity2.UpdateTableContext216());
            var Task17 = new Task(() => updateTestHelperEntity2.UpdateTableContext217());
            var Task18 = new Task(() => updateTestHelperEntity2.UpdateTableContext218());
            var Task19 = new Task(() => updateTestHelperEntity2.UpdateTableContext219());
            var Task20 = new Task(() => updateTestHelperEntity2.UpdateTableContext220());

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
