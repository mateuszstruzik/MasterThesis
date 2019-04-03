using DataExtract.Models.EntityContext._20TableDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tests.Tests.SqlServerTests.EntityTest.HelperForTest;

namespace Tests.Tests.SqlServerTests.EntityTest._20TableDb
{
    public class SqlServerDelete20TableDbENTITY
    {
        DeleteTestHelperEntity helperEntity = new DeleteTestHelperEntity();
        public void DeleteTableDb()
        {
            var tokenSource = new CancellationToken();
            var Task1 = new Task(() => helperEntity.DeleteTableContext1<SqlServerContextFor20TableDB>("table_1"));
            var Task2 = new Task(() => helperEntity.DeleteTableContext2<SqlServerContextFor20TableDB>("table_2"));
            var Task3 = new Task(() => helperEntity.DeleteTableContext3<SqlServerContextFor20TableDB>("table_3"));
            var Task4 = new Task(() => helperEntity.DeleteTableContext4<SqlServerContextFor20TableDB>("table_4"));
            var Task5 = new Task(() => helperEntity.DeleteTableContext5<SqlServerContextFor20TableDB>("table_5"));
            var Task6 = new Task(() => helperEntity.DeleteTableContext6<SqlServerContextFor20TableDB>("table_6"));
            var Task7 = new Task(() => helperEntity.DeleteTableContext7<SqlServerContextFor20TableDB>("table_7"));
            var Task8 = new Task(() => helperEntity.DeleteTableContext8<SqlServerContextFor20TableDB>("table_8"));
            var Task9 = new Task(() => helperEntity.DeleteTableContext9<SqlServerContextFor20TableDB>("table_9"));
            var Task10 = new Task(() => helperEntity.DeleteTableContext10<SqlServerContextFor20TableDB>("table_10"));
            var Task11 = new Task(() => helperEntity.DeleteTableContext1<SqlServerContextFor20TableDB>("table_11"));
            var Task12 = new Task(() => helperEntity.DeleteTableContext2<SqlServerContextFor20TableDB>("table_12"));
            var Task13 = new Task(() => helperEntity.DeleteTableContext3<SqlServerContextFor20TableDB>("table_13"));
            var Task14 = new Task(() => helperEntity.DeleteTableContext4<SqlServerContextFor20TableDB>("table_14"));
            var Task15 = new Task(() => helperEntity.DeleteTableContext5<SqlServerContextFor20TableDB>("table_15"));
            var Task16 = new Task(() => helperEntity.DeleteTableContext6<SqlServerContextFor20TableDB>("table_16"));
            var Task17 = new Task(() => helperEntity.DeleteTableContext7<SqlServerContextFor20TableDB>("table_17"));
            var Task18 = new Task(() => helperEntity.DeleteTableContext8<SqlServerContextFor20TableDB>("table_18"));
            var Task19 = new Task(() => helperEntity.DeleteTableContext9<SqlServerContextFor20TableDB>("table_19"));
            var Task20 = new Task(() => helperEntity.DeleteTableContext10<SqlServerContextFor20TableDB>("table_20"));

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
