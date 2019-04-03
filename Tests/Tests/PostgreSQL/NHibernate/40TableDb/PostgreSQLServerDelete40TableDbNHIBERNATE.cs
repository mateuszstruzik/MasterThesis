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
    public class PostgreSQLServerDelete40TableDbNHIBERNATE
    {
        public PostgreSQLDeleteTestHelperNHIBERNATE TestHelper;

        public PostgreSQLServerDelete40TableDbNHIBERNATE()
        {
            TestHelper = new PostgreSQLDeleteTestHelperNHIBERNATE("PostgreSQLServer40Table");
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
            var Task21 = new Task(() => TestHelper.DeleteFromTableByRecord1<Table_21>("Table_21"));
            var Task22 = new Task(() => TestHelper.DeleteFromTableByRecord2<Table_22>("Table_22"));
            var Task23 = new Task(() => TestHelper.DeleteFromTableByRecord3<Table_23>("Table_23"));
            var Task24 = new Task(() => TestHelper.DeleteFromTableByRecord4<Table_24>("Table_24"));
            var Task25 = new Task(() => TestHelper.DeleteFromTableByRecord5<Table_25>("Table_25"));
            var Task26 = new Task(() => TestHelper.DeleteFromTableByRecord6<Table_26>("Table_26"));
            var Task27 = new Task(() => TestHelper.DeleteFromTableByRecord7<Table_27>("Table_27"));
            var Task28 = new Task(() => TestHelper.DeleteFromTableByRecord8<Table_28>("Table_28"));
            var Task29 = new Task(() => TestHelper.DeleteFromTableByRecord9<Table_29>("Table_29"));
            var Task30 = new Task(() => TestHelper.DeleteFromTableByRecord10<Table_30>("Table_30"));
            var Task31 = new Task(() => TestHelper.DeleteFromTableByRecord1<Table_31>("Table_31"));
            var Task32 = new Task(() => TestHelper.DeleteFromTableByRecord2<Table_32>("Table_32"));
            var Task33 = new Task(() => TestHelper.DeleteFromTableByRecord3<Table_33>("Table_33"));
            var Task34 = new Task(() => TestHelper.DeleteFromTableByRecord4<Table_34>("Table_34"));
            var Task35 = new Task(() => TestHelper.DeleteFromTableByRecord5<Table_35>("Table_35"));
            var Task36 = new Task(() => TestHelper.DeleteFromTableByRecord6<Table_36>("Table_36"));
            var Task37 = new Task(() => TestHelper.DeleteFromTableByRecord7<Table_37>("Table_37"));
            var Task38 = new Task(() => TestHelper.DeleteFromTableByRecord8<Table_38>("Table_38"));
            var Task39 = new Task(() => TestHelper.DeleteFromTableByRecord9<Table_39>("Table_39"));
            var Task40 = new Task(() => TestHelper.DeleteFromTableByRecord10<Table_40>("Table_40"));

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
