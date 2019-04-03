using DataExtract.Models.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tests.Tests.OracleDbServeTests.NHibernate.OracleHelperForTest;

namespace Tests.Tests.OracleDbServeTests.NHibernate._20TableDb
{
    public class OracleServerUpdate20TableDbNHIBERNATE
    {
        public OracleUpdateTestHelperNHIBERNATE TestHelperNHIBERNATE;
        public string ConnectionString;
        public OracleServerUpdate20TableDbNHIBERNATE()
        {
            TestHelperNHIBERNATE = new OracleUpdateTestHelperNHIBERNATE();
            ConnectionString = "OracleDbServer20TableNHIBERNATE";
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
            var Task11 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_11>(ConnectionString));
            var Task12 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_12>(ConnectionString));
            var Task13 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_13>(ConnectionString));
            var Task14 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_14>(ConnectionString));
            var Task15 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_15>(ConnectionString));
            var Task16 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_16>(ConnectionString));
            var Task17 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_17>(ConnectionString));
            var Task18 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_18>(ConnectionString));
            var Task19 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_19>(ConnectionString));
            var Task20 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_20>(ConnectionString));

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
