using DataExtract.Queries;
using DataExtract.Repository.SQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests.Tests.SqlServerTests.ADOTESTS._80TableDB
{
    public class SqlServerInsert80TableDbADO
    {
        private static int objectNumber = 60;
        public SqlServerRpositoryAdo[] RpositoryArray = new SqlServerRpositoryAdo[objectNumber];
        public SqlServerInsert80TableDbADO()
        {

            for (int i = 0; i < objectNumber; i++)
            {
                RpositoryArray[i] = new SqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings["SqlServer80Table"].ConnectionString);
            }
        }

        public void InsertTableDb()
        {
            var tokenSource = new CancellationToken();
            var Task1 = new Task(() => RpositoryArray[0].InsertToTable(SqQueries.insertQuery("table1")));
            var Task2 = new Task(() => RpositoryArray[1].InsertToTable(SqQueries.insertQuery("table2")));
            var Task3 = new Task(() => RpositoryArray[2].InsertToTable(SqQueries.insertQuery("table3")));
            var Task4 = new Task(() => RpositoryArray[3].InsertToTable(SqQueries.insertQuery("table4")));
            var Task5 = new Task(() => RpositoryArray[4].InsertToTable(SqQueries.insertQuery("table5")));
            var Task6 = new Task(() => RpositoryArray[5].InsertToTable(SqQueries.insertQuery("table6")));
            var Task7 = new Task(() => RpositoryArray[6].InsertToTable(SqQueries.insertQuery("table7")));
            var Task8 = new Task(() => RpositoryArray[7].InsertToTable(SqQueries.insertQuery("table8")));
            var Task9 = new Task(() => RpositoryArray[8].InsertToTable(SqQueries.insertQuery("table9")));
            var Task10 = new Task(() => RpositoryArray[9].InsertToTable(SqQueries.insertQuery("table10")));
            var Task11 = new Task(() => RpositoryArray[10].InsertToTable(SqQueries.insertQuery("table11")));
            var Task12 = new Task(() => RpositoryArray[11].InsertToTable(SqQueries.insertQuery("table12")));
            var Task13 = new Task(() => RpositoryArray[12].InsertToTable(SqQueries.insertQuery("table13")));
            var Task14 = new Task(() => RpositoryArray[13].InsertToTable(SqQueries.insertQuery("table14")));
            var Task15 = new Task(() => RpositoryArray[14].InsertToTable(SqQueries.insertQuery("table15")));
            var Task16 = new Task(() => RpositoryArray[15].InsertToTable(SqQueries.insertQuery("table16")));
            var Task17 = new Task(() => RpositoryArray[16].InsertToTable(SqQueries.insertQuery("table17")));
            var Task18 = new Task(() => RpositoryArray[17].InsertToTable(SqQueries.insertQuery("table18")));
            var Task19 = new Task(() => RpositoryArray[18].InsertToTable(SqQueries.insertQuery("table19")));
            var Task20 = new Task(() => RpositoryArray[19].InsertToTable(SqQueries.insertQuery("table20")));
            var Task21 = new Task(() => RpositoryArray[20].InsertToTable(SqQueries.insertQuery("table21")));
            var Task22 = new Task(() => RpositoryArray[21].InsertToTable(SqQueries.insertQuery("table22")));
            var Task23 = new Task(() => RpositoryArray[22].InsertToTable(SqQueries.insertQuery("table23")));
            var Task24 = new Task(() => RpositoryArray[23].InsertToTable(SqQueries.insertQuery("table24")));
            var Task25 = new Task(() => RpositoryArray[24].InsertToTable(SqQueries.insertQuery("table25")));
            var Task26 = new Task(() => RpositoryArray[25].InsertToTable(SqQueries.insertQuery("table26")));
            var Task27 = new Task(() => RpositoryArray[26].InsertToTable(SqQueries.insertQuery("table27")));
            var Task28 = new Task(() => RpositoryArray[27].InsertToTable(SqQueries.insertQuery("table28")));
            var Task29 = new Task(() => RpositoryArray[28].InsertToTable(SqQueries.insertQuery("table29")));
            var Task30 = new Task(() => RpositoryArray[29].InsertToTable(SqQueries.insertQuery("table30")));
            var Task31 = new Task(() => RpositoryArray[30].InsertToTable(SqQueries.insertQuery("table31")));
            var Task32 = new Task(() => RpositoryArray[31].InsertToTable(SqQueries.insertQuery("table32")));
            var Task33 = new Task(() => RpositoryArray[32].InsertToTable(SqQueries.insertQuery("table33")));
            var Task34 = new Task(() => RpositoryArray[33].InsertToTable(SqQueries.insertQuery("table34")));
            var Task35 = new Task(() => RpositoryArray[34].InsertToTable(SqQueries.insertQuery("table35")));
            var Task36 = new Task(() => RpositoryArray[35].InsertToTable(SqQueries.insertQuery("table36")));
            var Task37 = new Task(() => RpositoryArray[36].InsertToTable(SqQueries.insertQuery("table37")));
            var Task38 = new Task(() => RpositoryArray[37].InsertToTable(SqQueries.insertQuery("table38")));
            var Task39 = new Task(() => RpositoryArray[38].InsertToTable(SqQueries.insertQuery("table39")));
            var Task40 = new Task(() => RpositoryArray[39].InsertToTable(SqQueries.insertQuery("table40")));
            var Task41 = new Task(() => RpositoryArray[40].InsertToTable(SqQueries.insertQuery("table41")));
            var Task42 = new Task(() => RpositoryArray[41].InsertToTable(SqQueries.insertQuery("table42")));
            var Task43 = new Task(() => RpositoryArray[42].InsertToTable(SqQueries.insertQuery("table43")));
            var Task44 = new Task(() => RpositoryArray[43].InsertToTable(SqQueries.insertQuery("table44")));
            var Task45 = new Task(() => RpositoryArray[44].InsertToTable(SqQueries.insertQuery("table45")));
            var Task46 = new Task(() => RpositoryArray[45].InsertToTable(SqQueries.insertQuery("table46")));
            var Task47 = new Task(() => RpositoryArray[46].InsertToTable(SqQueries.insertQuery("table47")));
            var Task48 = new Task(() => RpositoryArray[47].InsertToTable(SqQueries.insertQuery("table48")));
            var Task49 = new Task(() => RpositoryArray[48].InsertToTable(SqQueries.insertQuery("table49")));
            var Task50 = new Task(() => RpositoryArray[49].InsertToTable(SqQueries.insertQuery("table50")));
            var Task51 = new Task(() => RpositoryArray[50].InsertToTable(SqQueries.insertQuery("table51")));
            var Task52 = new Task(() => RpositoryArray[51].InsertToTable(SqQueries.insertQuery("table52")));
            var Task53 = new Task(() => RpositoryArray[52].InsertToTable(SqQueries.insertQuery("table53")));
            var Task54 = new Task(() => RpositoryArray[53].InsertToTable(SqQueries.insertQuery("table54")));
            var Task55 = new Task(() => RpositoryArray[54].InsertToTable(SqQueries.insertQuery("table55")));
            var Task56 = new Task(() => RpositoryArray[55].InsertToTable(SqQueries.insertQuery("table56")));
            var Task57 = new Task(() => RpositoryArray[56].InsertToTable(SqQueries.insertQuery("table57")));
            var Task58 = new Task(() => RpositoryArray[57].InsertToTable(SqQueries.insertQuery("table58")));
            var Task59 = new Task(() => RpositoryArray[58].InsertToTable(SqQueries.insertQuery("table59")));
            var Task60 = new Task(() => RpositoryArray[59].InsertToTable(SqQueries.insertQuery("table60")));

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
