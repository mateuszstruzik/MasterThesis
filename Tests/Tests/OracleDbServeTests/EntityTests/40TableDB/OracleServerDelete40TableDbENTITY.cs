using DataExtract.Models.EntityContext._40TableDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tests.Tests.OracleDbServeTests.EntityTests.OracleHelperForTest;

namespace Tests.Tests.OracleDbServeTests.EntityTests._40TableDB
{
    public class OracleServerDelete40TableDbENTITY
    {
        OracleDeleteHelperEntity helperEntity = new OracleDeleteHelperEntity();
        public void DeleteTableDb()
        {
            var tokenSource = new CancellationToken();
            var Task1 = new Task(() => helperEntity.DeleteTableContext1<OracleContextFor40TableDB>("table_1"));
            var Task2 = new Task(() => helperEntity.DeleteTableContext2<OracleContextFor40TableDB>("table_2"));
            var Task3 = new Task(() => helperEntity.DeleteTableContext3<OracleContextFor40TableDB>("table_3"));
            var Task4 = new Task(() => helperEntity.DeleteTableContext4<OracleContextFor40TableDB>("table_4"));
            var Task5 = new Task(() => helperEntity.DeleteTableContext5<OracleContextFor40TableDB>("table_5"));
            var Task6 = new Task(() => helperEntity.DeleteTableContext6<OracleContextFor40TableDB>("table_6"));
            var Task7 = new Task(() => helperEntity.DeleteTableContext7<OracleContextFor40TableDB>("table_7"));
            var Task8 = new Task(() => helperEntity.DeleteTableContext8<OracleContextFor40TableDB>("table_8"));
            var Task9 = new Task(() => helperEntity.DeleteTableContext9<OracleContextFor40TableDB>("table_9"));
            var Task10 = new Task(() => helperEntity.DeleteTableContext10<OracleContextFor40TableDB>("table_10"));
            var Task11 = new Task(() => helperEntity.DeleteTableContext1<OracleContextFor40TableDB>("table_11"));
            var Task12 = new Task(() => helperEntity.DeleteTableContext2<OracleContextFor40TableDB>("table_12"));
            var Task13 = new Task(() => helperEntity.DeleteTableContext3<OracleContextFor40TableDB>("table_13"));
            var Task14 = new Task(() => helperEntity.DeleteTableContext4<OracleContextFor40TableDB>("table_14"));
            var Task15 = new Task(() => helperEntity.DeleteTableContext5<OracleContextFor40TableDB>("table_15"));
            var Task16 = new Task(() => helperEntity.DeleteTableContext6<OracleContextFor40TableDB>("table_16"));
            var Task17 = new Task(() => helperEntity.DeleteTableContext7<OracleContextFor40TableDB>("table_17"));
            var Task18 = new Task(() => helperEntity.DeleteTableContext8<OracleContextFor40TableDB>("table_18"));
            var Task19 = new Task(() => helperEntity.DeleteTableContext9<OracleContextFor40TableDB>("table_19"));
            var Task20 = new Task(() => helperEntity.DeleteTableContext10<OracleContextFor40TableDB>("table_20"));
            var Task21 = new Task(() => helperEntity.DeleteTableContext1<OracleContextFor40TableDB>("table_21"));
            var Task22 = new Task(() => helperEntity.DeleteTableContext2<OracleContextFor40TableDB>("table_22"));
            var Task23 = new Task(() => helperEntity.DeleteTableContext3<OracleContextFor40TableDB>("table_23"));
            var Task24 = new Task(() => helperEntity.DeleteTableContext4<OracleContextFor40TableDB>("table_24"));
            var Task25 = new Task(() => helperEntity.DeleteTableContext5<OracleContextFor40TableDB>("table_25"));
            var Task26 = new Task(() => helperEntity.DeleteTableContext6<OracleContextFor40TableDB>("table_26"));
            var Task27 = new Task(() => helperEntity.DeleteTableContext7<OracleContextFor40TableDB>("table_27"));
            var Task28 = new Task(() => helperEntity.DeleteTableContext8<OracleContextFor40TableDB>("table_28"));
            var Task29 = new Task(() => helperEntity.DeleteTableContext9<OracleContextFor40TableDB>("table_29"));
            var Task30 = new Task(() => helperEntity.DeleteTableContext10<OracleContextFor40TableDB>("table_30"));
            var Task31 = new Task(() => helperEntity.DeleteTableContext1<OracleContextFor40TableDB>("table_31"));
            var Task32 = new Task(() => helperEntity.DeleteTableContext2<OracleContextFor40TableDB>("table_32"));
            var Task33 = new Task(() => helperEntity.DeleteTableContext3<OracleContextFor40TableDB>("table_33"));
            var Task34 = new Task(() => helperEntity.DeleteTableContext4<OracleContextFor40TableDB>("table_34"));
            var Task35 = new Task(() => helperEntity.DeleteTableContext5<OracleContextFor40TableDB>("table_35"));
            var Task36 = new Task(() => helperEntity.DeleteTableContext6<OracleContextFor40TableDB>("table_36"));
            var Task37 = new Task(() => helperEntity.DeleteTableContext7<OracleContextFor40TableDB>("table_37"));
            var Task38 = new Task(() => helperEntity.DeleteTableContext8<OracleContextFor40TableDB>("table_38"));
            var Task39 = new Task(() => helperEntity.DeleteTableContext9<OracleContextFor40TableDB>("table_39"));
            var Task40 = new Task(() => helperEntity.DeleteTableContext10<OracleContextFor40TableDB>("table_40"));

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
