using DataExtract.Models.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tests.Tests.OracleDbServeTests.NHibernate.OracleHelperForTest;

namespace Tests.Tests.OracleDbServeTests.NHibernate._10TableDb
{
    public class OracleServerUpdate10TableDbNHIBERNATE
    {
        public OracleUpdateTestHelperNHIBERNATE TestHelperNHIBERNATE;
        public string ConnectionString;
        public OracleServerUpdate10TableDbNHIBERNATE()
        {
            TestHelperNHIBERNATE = new OracleUpdateTestHelperNHIBERNATE();
            ConnectionString = "OracleDbServer10TableNHIBERNATE";
        }

        public void UpdateTable()
        {
            var tokenSource = new CancellationToken();
            var Task1 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_1>(ConnectionString));
            var Task2 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_2>(ConnectionString));
            var Task3 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_3>(ConnectionString));
            var Task4 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_4>(ConnectionString));
            var Task5 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_5>(ConnectionString));
            var Task6 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_6>(ConnectionString));
            var Task7 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_7>(ConnectionString));
            var Task8 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_8>(ConnectionString));
            var Task9 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_9>(ConnectionString));
            var Task10 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_10>(ConnectionString));

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
