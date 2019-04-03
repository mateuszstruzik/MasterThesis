using DataExtract.Models.TableModels;
using DataExtract.Queries;
using DataExtract.Repository.PostgreSQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests.Tests.PostgreSQL.NHibernate._40TableDb
{
    public class PostgreSQLInsert40TableDbNHIBERNATE
    {
        public PostgreSQLServerRepositoryNHibernate SqlServerRepositoryNHibernate;
        private static int objectNumber = 40;
        public PostgreSQLServerRepositoryNHibernate[] RpositoryArray = new PostgreSQLServerRepositoryNHibernate[objectNumber];

        public PostgreSQLInsert40TableDbNHIBERNATE()
        {

            for (int i = 0; i < objectNumber; i++)
            {
                RpositoryArray[i] = new PostgreSQLServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings["PostgreSQLServer40Table"].ConnectionString);
            }
        }

        public void InsertTableDb()
        {
            var tokenSource = new CancellationToken();
            var Task1 = new Task(() => RpositoryArray[0].ExecuteSqlInsert<Table_1>(SqQueries.insertPostggreQuery("Ntable1")));
            var Task2 = new Task(() => RpositoryArray[1].ExecuteSqlInsert<Table_2>(SqQueries.insertPostggreQuery("Ntable2")));
            var Task3 = new Task(() => RpositoryArray[2].ExecuteSqlInsert<Table_3>(SqQueries.insertPostggreQuery("Ntable3")));
            var Task4 = new Task(() => RpositoryArray[3].ExecuteSqlInsert<Table_4>(SqQueries.insertPostggreQuery("Ntable4")));
            var Task5 = new Task(() => RpositoryArray[4].ExecuteSqlInsert<Table_5>(SqQueries.insertPostggreQuery("Ntable5")));
            var Task6 = new Task(() => RpositoryArray[5].ExecuteSqlInsert<Table_6>(SqQueries.insertPostggreQuery("Ntable6")));
            var Task7 = new Task(() => RpositoryArray[6].ExecuteSqlInsert<Table_7>(SqQueries.insertPostggreQuery("Ntable7")));
            var Task8 = new Task(() => RpositoryArray[7].ExecuteSqlInsert<Table_8>(SqQueries.insertPostggreQuery("Ntable8")));
            var Task9 = new Task(() => RpositoryArray[8].ExecuteSqlInsert<Table_9>(SqQueries.insertPostggreQuery("Ntable9")));
            var Task10 = new Task(() => RpositoryArray[9].ExecuteSqlInsert<Table_10>(SqQueries.insertPostggreQuery("Ntable10")));
            var Task11 = new Task(() => RpositoryArray[10].ExecuteSqlInsert<Table_11>(SqQueries.insertPostggreQuery("Ntable11")));
            var Task12 = new Task(() => RpositoryArray[11].ExecuteSqlInsert<Table_12>(SqQueries.insertPostggreQuery("Ntable12")));
            var Task13 = new Task(() => RpositoryArray[12].ExecuteSqlInsert<Table_13>(SqQueries.insertPostggreQuery("Ntable13")));
            var Task14 = new Task(() => RpositoryArray[13].ExecuteSqlInsert<Table_14>(SqQueries.insertPostggreQuery("Ntable14")));
            var Task15 = new Task(() => RpositoryArray[14].ExecuteSqlInsert<Table_15>(SqQueries.insertPostggreQuery("Ntable15")));
            var Task16 = new Task(() => RpositoryArray[15].ExecuteSqlInsert<Table_16>(SqQueries.insertPostggreQuery("Ntable16")));
            var Task17 = new Task(() => RpositoryArray[16].ExecuteSqlInsert<Table_17>(SqQueries.insertPostggreQuery("Ntable17")));
            var Task18 = new Task(() => RpositoryArray[17].ExecuteSqlInsert<Table_18>(SqQueries.insertPostggreQuery("Ntable18")));
            var Task19 = new Task(() => RpositoryArray[18].ExecuteSqlInsert<Table_19>(SqQueries.insertPostggreQuery("Ntable19")));
            var Task20 = new Task(() => RpositoryArray[19].ExecuteSqlInsert<Table_20>(SqQueries.insertPostggreQuery("Ntable20")));
            var Task21 = new Task(() => RpositoryArray[20].ExecuteSqlInsert<Table_21>(SqQueries.insertPostggreQuery("Ntable21")));
            var Task22 = new Task(() => RpositoryArray[21].ExecuteSqlInsert<Table_22>(SqQueries.insertPostggreQuery("Ntable22")));
            var Task23 = new Task(() => RpositoryArray[22].ExecuteSqlInsert<Table_23>(SqQueries.insertPostggreQuery("Ntable23")));
            var Task24 = new Task(() => RpositoryArray[23].ExecuteSqlInsert<Table_24>(SqQueries.insertPostggreQuery("Ntable24")));
            var Task25 = new Task(() => RpositoryArray[24].ExecuteSqlInsert<Table_25>(SqQueries.insertPostggreQuery("Ntable25")));
            var Task26 = new Task(() => RpositoryArray[25].ExecuteSqlInsert<Table_26>(SqQueries.insertPostggreQuery("Ntable26")));
            var Task27 = new Task(() => RpositoryArray[26].ExecuteSqlInsert<Table_27>(SqQueries.insertPostggreQuery("Ntable27")));
            var Task28 = new Task(() => RpositoryArray[27].ExecuteSqlInsert<Table_28>(SqQueries.insertPostggreQuery("Ntable28")));
            var Task29 = new Task(() => RpositoryArray[28].ExecuteSqlInsert<Table_29>(SqQueries.insertPostggreQuery("Ntable29")));
            var Task30 = new Task(() => RpositoryArray[29].ExecuteSqlInsert<Table_30>(SqQueries.insertPostggreQuery("Ntable30")));
            var Task31 = new Task(() => RpositoryArray[30].ExecuteSqlInsert<Table_31>(SqQueries.insertPostggreQuery("Ntable31")));
            var Task32 = new Task(() => RpositoryArray[31].ExecuteSqlInsert<Table_32>(SqQueries.insertPostggreQuery("Ntable32")));
            var Task33 = new Task(() => RpositoryArray[32].ExecuteSqlInsert<Table_33>(SqQueries.insertPostggreQuery("Ntable33")));
            var Task34 = new Task(() => RpositoryArray[33].ExecuteSqlInsert<Table_34>(SqQueries.insertPostggreQuery("Ntable34")));
            var Task35 = new Task(() => RpositoryArray[34].ExecuteSqlInsert<Table_35>(SqQueries.insertPostggreQuery("Ntable35")));
            var Task36 = new Task(() => RpositoryArray[35].ExecuteSqlInsert<Table_36>(SqQueries.insertPostggreQuery("Ntable36")));
            var Task37 = new Task(() => RpositoryArray[36].ExecuteSqlInsert<Table_37>(SqQueries.insertPostggreQuery("Ntable37")));
            var Task38 = new Task(() => RpositoryArray[37].ExecuteSqlInsert<Table_38>(SqQueries.insertPostggreQuery("Ntable38")));
            var Task39 = new Task(() => RpositoryArray[38].ExecuteSqlInsert<Table_39>(SqQueries.insertPostggreQuery("Ntable39")));
            var Task40 = new Task(() => RpositoryArray[39].ExecuteSqlInsert<Table_40>(SqQueries.insertPostggreQuery("Ntable40")));

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
