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
    public class OracleServerDelete20TableDbNHIBERNATE
    {
        public OracleDeleteTestHelperNHIBERNATE TestHelper;

        public OracleServerDelete20TableDbNHIBERNATE()
        {
            TestHelper = new OracleDeleteTestHelperNHIBERNATE("OracleDbServer20TableNHIBERNATE");
        }

        public void DeleteTableDb()
        {
            var tokenSource = new CancellationToken();
            var Task1 = new Task(() => TestHelper.DeleteFromTableByRecord1<Table_1>("Table_1"));
            var Task2 = new Task(() => TestHelper.DeleteFromTableByRecord2<Table_2>("Table_2"));
            var Task3 = new Task(() => TestHelper.DeleteFromTableByRecord3<Table_3>("Table_3"));
            var Task4 = new Task(() => TestHelper.DeleteFromTableByRecord4<Table_4>("Table_4"));
            var Task5 = new Task(() => TestHelper.DeleteFromTableByRecord5<Table_5>("Table_5"));
            var Task6 = new Task(() => TestHelper.DeleteFromTableByRecord6<Table_6>("Table_6"));
            var Task7 = new Task(() => TestHelper.DeleteFromTableByRecord7<Table_7>("Table_7"));
            var Task8 = new Task(() => TestHelper.DeleteFromTableByRecord8<Table_8>("Table_8"));
            var Task9 = new Task(() => TestHelper.DeleteFromTableByRecord9<Table_9>("Table_9"));
            var Task10 = new Task(() => TestHelper.DeleteFromTableByRecord10<Table_10>("Table_10"));
            var Task11 = new Task(() => TestHelper.DeleteFromTableByRecord1<Table_11>("Table_11"));
            var Task12 = new Task(() => TestHelper.DeleteFromTableByRecord2<Table_12>("Table_12"));
            var Task13 = new Task(() => TestHelper.DeleteFromTableByRecord3<Table_13>("Table_13"));
            var Task14 = new Task(() => TestHelper.DeleteFromTableByRecord4<Table_14>("Table_14"));
            var Task15 = new Task(() => TestHelper.DeleteFromTableByRecord5<Table_15>("Table_15"));
            var Task16 = new Task(() => TestHelper.DeleteFromTableByRecord6<Table_16>("Table_16"));
            var Task17 = new Task(() => TestHelper.DeleteFromTableByRecord7<Table_17>("Table_17"));
            var Task18 = new Task(() => TestHelper.DeleteFromTableByRecord8<Table_18>("Table_18"));
            var Task19 = new Task(() => TestHelper.DeleteFromTableByRecord9<Table_19>("Table_19"));
            var Task20 = new Task(() => TestHelper.DeleteFromTableByRecord10<Table_20>("Table_20"));

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
