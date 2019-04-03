using DataExtract.Models.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tests.Tests.PostgreSQL.NHibernate.HelperForTests;

namespace Tests.Tests.PostgreSQL.NHibernate._40TableDb
{
    public class PostgreSQLUpdate40TableDbNHIBERNATE
    {
        public PostgreSQLUpdateTestHelperNHIBERNATE TestHelperNHIBERNATE;
        public string ConnectionString;
        public PostgreSQLUpdate40TableDbNHIBERNATE()
        {
            TestHelperNHIBERNATE = new PostgreSQLUpdateTestHelperNHIBERNATE();
            ConnectionString = "PostgreSQLServer40Table";
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
            var Task21 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_21>(ConnectionString));
            var Task22 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_22>(ConnectionString));
            var Task23 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_23>(ConnectionString));
            var Task24 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_24>(ConnectionString));
            var Task25 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_25>(ConnectionString));
            var Task26 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_26>(ConnectionString));
            var Task27 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_27>(ConnectionString));
            var Task28 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_28>(ConnectionString));
            var Task29 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_29>(ConnectionString));
            var Task30 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_30>(ConnectionString));
            var Task31 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_31>(ConnectionString));
            var Task32 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_32>(ConnectionString));
            var Task33 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_33>(ConnectionString));
            var Task34 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_34>(ConnectionString));
            var Task35 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_35>(ConnectionString));
            var Task36 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_36>(ConnectionString));
            var Task37 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_37>(ConnectionString));
            var Task38 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_38>(ConnectionString));
            var Task39 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_39>(ConnectionString));
            var Task40 = new Task(() => TestHelperNHIBERNATE.UpdateTable<Table_40>(ConnectionString));

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
