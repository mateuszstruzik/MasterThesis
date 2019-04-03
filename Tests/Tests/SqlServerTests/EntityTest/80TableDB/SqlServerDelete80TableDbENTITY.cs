using DataExtract.Models.EntityContext._80TableDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tests.Tests.SqlServerTests.EntityTest.HelperForTest;

namespace Tests.Tests.SqlServerTests.EntityTest._80TableDB
{
    public class SqlServerDelete80TableDbENTITY
    {

        DeleteTestHelperEntity helperEntity = new DeleteTestHelperEntity();
        public void DeleteTableDb()
        {
            var tokenSource = new CancellationToken();
            var Task1 = new Task(() => helperEntity.DeleteTableContext1<SqlServerContextFor80TableDB>("table_1"));
            var Task2 = new Task(() => helperEntity.DeleteTableContext2<SqlServerContextFor80TableDB>("table_2"));
            var Task3 = new Task(() => helperEntity.DeleteTableContext3<SqlServerContextFor80TableDB>("table_3"));
            var Task4 = new Task(() => helperEntity.DeleteTableContext4<SqlServerContextFor80TableDB>("table_4"));
            var Task5 = new Task(() => helperEntity.DeleteTableContext5<SqlServerContextFor80TableDB>("table_5"));
            var Task6 = new Task(() => helperEntity.DeleteTableContext6<SqlServerContextFor80TableDB>("table_6"));
            var Task7 = new Task(() => helperEntity.DeleteTableContext7<SqlServerContextFor80TableDB>("table_7"));
            var Task8 = new Task(() => helperEntity.DeleteTableContext8<SqlServerContextFor80TableDB>("table_8"));
            var Task9 = new Task(() => helperEntity.DeleteTableContext9<SqlServerContextFor80TableDB>("table_9"));
            var Task10 = new Task(() => helperEntity.DeleteTableContext10<SqlServerContextFor80TableDB>("table_10"));
            var Task11 = new Task(() => helperEntity.DeleteTableContext1<SqlServerContextFor80TableDB>("table_11"));
            var Task12 = new Task(() => helperEntity.DeleteTableContext2<SqlServerContextFor80TableDB>("table_12"));
            var Task13 = new Task(() => helperEntity.DeleteTableContext3<SqlServerContextFor80TableDB>("table_13"));
            var Task14 = new Task(() => helperEntity.DeleteTableContext4<SqlServerContextFor80TableDB>("table_14"));
            var Task15 = new Task(() => helperEntity.DeleteTableContext5<SqlServerContextFor80TableDB>("table_15"));
            var Task16 = new Task(() => helperEntity.DeleteTableContext6<SqlServerContextFor80TableDB>("table_16"));
            var Task17 = new Task(() => helperEntity.DeleteTableContext7<SqlServerContextFor80TableDB>("table_17"));
            var Task18 = new Task(() => helperEntity.DeleteTableContext8<SqlServerContextFor80TableDB>("table_18"));
            var Task19 = new Task(() => helperEntity.DeleteTableContext9<SqlServerContextFor80TableDB>("table_19"));
            var Task20 = new Task(() => helperEntity.DeleteTableContext10<SqlServerContextFor80TableDB>("table_20"));
            var Task21 = new Task(() => helperEntity.DeleteTableContext1<SqlServerContextFor80TableDB>("table_21"));
            var Task22 = new Task(() => helperEntity.DeleteTableContext2<SqlServerContextFor80TableDB>("table_22"));
            var Task23 = new Task(() => helperEntity.DeleteTableContext3<SqlServerContextFor80TableDB>("table_23"));
            var Task24 = new Task(() => helperEntity.DeleteTableContext4<SqlServerContextFor80TableDB>("table_24"));
            var Task25 = new Task(() => helperEntity.DeleteTableContext5<SqlServerContextFor80TableDB>("table_25"));
            var Task26 = new Task(() => helperEntity.DeleteTableContext6<SqlServerContextFor80TableDB>("table_26"));
            var Task27 = new Task(() => helperEntity.DeleteTableContext7<SqlServerContextFor80TableDB>("table_27"));
            var Task28 = new Task(() => helperEntity.DeleteTableContext8<SqlServerContextFor80TableDB>("table_28"));
            var Task29 = new Task(() => helperEntity.DeleteTableContext9<SqlServerContextFor80TableDB>("table_29"));
            var Task30 = new Task(() => helperEntity.DeleteTableContext10<SqlServerContextFor80TableDB>("table_30"));
            var Task31 = new Task(() => helperEntity.DeleteTableContext1<SqlServerContextFor80TableDB>("table_31"));
            var Task32 = new Task(() => helperEntity.DeleteTableContext2<SqlServerContextFor80TableDB>("table_32"));
            var Task33 = new Task(() => helperEntity.DeleteTableContext3<SqlServerContextFor80TableDB>("table_33"));
            var Task34 = new Task(() => helperEntity.DeleteTableContext4<SqlServerContextFor80TableDB>("table_34"));
            var Task35 = new Task(() => helperEntity.DeleteTableContext5<SqlServerContextFor80TableDB>("table_35"));
            var Task36 = new Task(() => helperEntity.DeleteTableContext6<SqlServerContextFor80TableDB>("table_36"));
            var Task37 = new Task(() => helperEntity.DeleteTableContext7<SqlServerContextFor80TableDB>("table_37"));
            var Task38 = new Task(() => helperEntity.DeleteTableContext8<SqlServerContextFor80TableDB>("table_38"));
            var Task39 = new Task(() => helperEntity.DeleteTableContext9<SqlServerContextFor80TableDB>("table_39"));
            var Task40 = new Task(() => helperEntity.DeleteTableContext10<SqlServerContextFor80TableDB>("table_40"));
            var Task41 = new Task(() => helperEntity.DeleteTableContext1<SqlServerContextFor80TableDB>("table_41"));
            var Task42 = new Task(() => helperEntity.DeleteTableContext2<SqlServerContextFor80TableDB>("table_42"));
            var Task43 = new Task(() => helperEntity.DeleteTableContext3<SqlServerContextFor80TableDB>("table_43"));
            var Task44 = new Task(() => helperEntity.DeleteTableContext4<SqlServerContextFor80TableDB>("table_44"));
            var Task45 = new Task(() => helperEntity.DeleteTableContext5<SqlServerContextFor80TableDB>("table_45"));
            var Task46 = new Task(() => helperEntity.DeleteTableContext6<SqlServerContextFor80TableDB>("table_46"));
            var Task47 = new Task(() => helperEntity.DeleteTableContext7<SqlServerContextFor80TableDB>("table_47"));
            var Task48 = new Task(() => helperEntity.DeleteTableContext8<SqlServerContextFor80TableDB>("table_48"));
            var Task49 = new Task(() => helperEntity.DeleteTableContext9<SqlServerContextFor80TableDB>("table_49"));
            var Task50 = new Task(() => helperEntity.DeleteTableContext10<SqlServerContextFor80TableDB>("table_50"));
            var Task51 = new Task(() => helperEntity.DeleteTableContext1<SqlServerContextFor80TableDB>("table_51"));
            var Task52 = new Task(() => helperEntity.DeleteTableContext2<SqlServerContextFor80TableDB>("table_52"));
            var Task53 = new Task(() => helperEntity.DeleteTableContext3<SqlServerContextFor80TableDB>("table_53"));
            var Task54 = new Task(() => helperEntity.DeleteTableContext4<SqlServerContextFor80TableDB>("table_54"));
            var Task55 = new Task(() => helperEntity.DeleteTableContext5<SqlServerContextFor80TableDB>("table_55"));
            var Task56 = new Task(() => helperEntity.DeleteTableContext6<SqlServerContextFor80TableDB>("table_56"));
            var Task57 = new Task(() => helperEntity.DeleteTableContext7<SqlServerContextFor80TableDB>("table_57"));
            var Task58 = new Task(() => helperEntity.DeleteTableContext8<SqlServerContextFor80TableDB>("table_58"));
            var Task59 = new Task(() => helperEntity.DeleteTableContext9<SqlServerContextFor80TableDB>("table_59"));
            var Task60 = new Task(() => helperEntity.DeleteTableContext10<SqlServerContextFor80TableDB>("table_60"));

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
            Task41.Start();
            Task42.Start();
            Task43.Start();
            Task44.Start();
            Task45.Start();
            Task46.Start();
            Task47.Start();
            Task48.Start();
            Task49.Start();
            Task50.Start();
            Task51.Start();
            Task52.Start();
            Task53.Start();
            Task54.Start();
            Task55.Start();
            Task56.Start();
            Task57.Start();
            Task58.Start();
            Task59.Start();
            Task60.Start();

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
            Task41,
            Task42,
            Task43,
            Task44,
            Task45,
            Task46,
            Task47,
            Task48,
            Task49,
            Task50,
            Task51,
            Task52,
            Task53,
            Task54,
            Task55,
            Task56,
            Task57,
            Task58,
            Task59,
            Task60,
            }, tokenSource);
        }
    }
}
