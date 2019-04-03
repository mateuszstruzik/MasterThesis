using DataExtract.Models.EntityContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tests.Tests.OracleDbServeTests.EntityTests.OracleHelperForTest;

namespace Tests.Tests.OracleDbServeTests.EntityTests._10TableDB
{
    public class OracleServerDelete10TableDbENTITY
    {
        OracleDeleteHelperEntity helperEntity = new OracleDeleteHelperEntity();
        public void DeleteTableDb()
        {
            var tokenSource = new CancellationToken();
            var Task1 = new Task(() => helperEntity.DeleteTableContext1<OracleContextFor10TableDB>("table_1"));
            var Task2 = new Task(() => helperEntity.DeleteTableContext2<OracleContextFor10TableDB>("table_2"));
            var Task3 = new Task(() => helperEntity.DeleteTableContext3<OracleContextFor10TableDB>("table_3"));
            var Task4 = new Task(() => helperEntity.DeleteTableContext4<OracleContextFor10TableDB>("table_4"));
            var Task5 = new Task(() => helperEntity.DeleteTableContext5<OracleContextFor10TableDB>("table_5"));
            var Task6 = new Task(() => helperEntity.DeleteTableContext6<OracleContextFor10TableDB>("table_6"));
            var Task7 = new Task(() => helperEntity.DeleteTableContext7<OracleContextFor10TableDB>("table_7"));
            var Task8 = new Task(() => helperEntity.DeleteTableContext8<OracleContextFor10TableDB>("table_8"));
            var Task9 = new Task(() => helperEntity.DeleteTableContext9<OracleContextFor10TableDB>("table_9"));
            var Task10 = new Task(() => helperEntity.DeleteTableContext10<OracleContextFor10TableDB>("table_10"));

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
