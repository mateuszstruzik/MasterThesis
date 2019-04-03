using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tests.Tests.PostgreSQL.postgreSQLhelperForTest;

namespace Tests.Tests.PostgreSQL.AdoTests._20TableDB
{
    public class PostgreSQLServerUpdate20TableDbADO
    {
        public PostgreSQLUpdateTestHelper UpdateTestHelper;

        public PostgreSQLServerUpdate20TableDbADO()
        {
            UpdateTestHelper = new PostgreSQLUpdateTestHelper("PostgreSQLServer20Table");
        }

        public void UpdateTableDb()
        {
            var tokenSource = new CancellationToken();
            var Task1 = new Task(() => UpdateTestHelper.UpdateSchema1("Table_1"));
            var Task2 = new Task(() => UpdateTestHelper.UpdateSchema2("Table_2"));
            var Task3 = new Task(() => UpdateTestHelper.UpdateSchema3("Table_3"));
            var Task4 = new Task(() => UpdateTestHelper.UpdateSchema4("Table_4"));
            var Task5 = new Task(() => UpdateTestHelper.UpdateSchema5("Table_5"));
            var Task6 = new Task(() => UpdateTestHelper.UpdateSchema6("Table_6"));
            var Task7 = new Task(() => UpdateTestHelper.UpdateSchema7("Table_7"));
            var Task8 = new Task(() => UpdateTestHelper.UpdateSchema8("Table_8"));
            var Task9 = new Task(() => UpdateTestHelper.UpdateSchema9("Table_9"));
            var Task10 = new Task(() => UpdateTestHelper.UpdateSchema10("Table_10"));
            var Task11 = new Task(() => UpdateTestHelper.UpdateSchema1("Table_11"));
            var Task12 = new Task(() => UpdateTestHelper.UpdateSchema2("Table_12"));
            var Task13 = new Task(() => UpdateTestHelper.UpdateSchema3("Table_13"));
            var Task14 = new Task(() => UpdateTestHelper.UpdateSchema4("Table_14"));
            var Task15 = new Task(() => UpdateTestHelper.UpdateSchema5("Table_15"));
            var Task16 = new Task(() => UpdateTestHelper.UpdateSchema6("Table_16"));
            var Task17 = new Task(() => UpdateTestHelper.UpdateSchema7("Table_17"));
            var Task18 = new Task(() => UpdateTestHelper.UpdateSchema8("Table_18"));
            var Task19 = new Task(() => UpdateTestHelper.UpdateSchema9("Table_19"));
            var Task20 = new Task(() => UpdateTestHelper.UpdateSchema10("Table_20"));


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
