using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tests.Tests.OracleDbServeTests.EntityTests.OracleHelperForTest;

namespace Tests.Tests.OracleDbServeTests.EntityTests._10TableDB
{
    public class OracleServerUpdate10TableDbENTITY
    {
        OracleUpdateTestHelperEntity updateTestHelperEntity = new OracleUpdateTestHelperEntity();
        public void UpdateTableContext10Db()
        {
            var tokenSource = new CancellationToken();
            var Task1 = new Task(() => updateTestHelperEntity.UpdateTableContext101());
            var Task2 = new Task(() => updateTestHelperEntity.UpdateTableContext102());
            var Task3 = new Task(() => updateTestHelperEntity.UpdateTableContext103());
            var Task4 = new Task(() => updateTestHelperEntity.UpdateTableContext104());
            var Task5 = new Task(() => updateTestHelperEntity.UpdateTableContext105());
            var Task6 = new Task(() => updateTestHelperEntity.UpdateTableContext106());
            var Task7 = new Task(() => updateTestHelperEntity.UpdateTableContext107());
            var Task8 = new Task(() => updateTestHelperEntity.UpdateTableContext108());
            var Task9 = new Task(() => updateTestHelperEntity.UpdateTableContext109());
            var Task10 = new Task(() => updateTestHelperEntity.UpdateTableContext1010());

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
