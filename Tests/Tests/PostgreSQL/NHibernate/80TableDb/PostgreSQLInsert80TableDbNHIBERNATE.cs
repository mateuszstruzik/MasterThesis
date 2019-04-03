using DataExtract.Models.TableModels;
using DataExtract.Models.TableModels.SingleTablesModels;
using DataExtract.Queries;
using DataExtract.Repository.PostgreSQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests.Tests.PostgreSQL.NHibernate._80TableDb
{
    public class PostgreSQLInsert80TableDbNHIBERNATE
    {
        public PostgreSQLServerRepositoryNHibernate SqlServerRepositoryNHibernate;
        private static int objectNumber = 60;
        public PostgreSQLServerRepositoryNHibernate[] RpositoryArray = new PostgreSQLServerRepositoryNHibernate[objectNumber];

        public PostgreSQLInsert80TableDbNHIBERNATE()
        {

            for (int i = 0; i < objectNumber; i++)
            {
                RpositoryArray[i] = new PostgreSQLServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings["PostgreSQLServer80Table"].ConnectionString);
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
            var Task41 = new Task(() => RpositoryArray[40].ExecuteSqlInsert<Table_41>(SqQueries.insertPostggreQuery("Ntable41")));
            var Task42 = new Task(() => RpositoryArray[41].ExecuteSqlInsert<Table_42>(SqQueries.insertPostggreQuery("Ntable42")));
            var Task43 = new Task(() => RpositoryArray[42].ExecuteSqlInsert<Table_43>(SqQueries.insertPostggreQuery("Ntable43")));
            var Task44 = new Task(() => RpositoryArray[43].ExecuteSqlInsert<Table_44>(SqQueries.insertPostggreQuery("Ntable44")));
            var Task45 = new Task(() => RpositoryArray[44].ExecuteSqlInsert<Table_45>(SqQueries.insertPostggreQuery("Ntable45")));
            var Task46 = new Task(() => RpositoryArray[45].ExecuteSqlInsert<Table_46>(SqQueries.insertPostggreQuery("Ntable46")));
            var Task47 = new Task(() => RpositoryArray[46].ExecuteSqlInsert<Table_47>(SqQueries.insertPostggreQuery("Ntable47")));
            var Task48 = new Task(() => RpositoryArray[47].ExecuteSqlInsert<Table_48>(SqQueries.insertPostggreQuery("Ntable48")));
            var Task49 = new Task(() => RpositoryArray[48].ExecuteSqlInsert<Table_49>(SqQueries.insertPostggreQuery("Ntable49")));
            var Task50 = new Task(() => RpositoryArray[49].ExecuteSqlInsert<Table_50>(SqQueries.insertPostggreQuery("Ntable50")));
            var Task51 = new Task(() => RpositoryArray[50].ExecuteSqlInsert<Table_51>(SqQueries.insertPostggreQuery("Ntable51")));
            var Task52 = new Task(() => RpositoryArray[51].ExecuteSqlInsert<Table_52>(SqQueries.insertPostggreQuery("Ntable52")));
            var Task53 = new Task(() => RpositoryArray[52].ExecuteSqlInsert<Table_53>(SqQueries.insertPostggreQuery("Ntable53")));
            var Task54 = new Task(() => RpositoryArray[53].ExecuteSqlInsert<Table_54>(SqQueries.insertPostggreQuery("Ntable54")));
            var Task55 = new Task(() => RpositoryArray[54].ExecuteSqlInsert<Table_55>(SqQueries.insertPostggreQuery("Ntable55")));
            var Task56 = new Task(() => RpositoryArray[55].ExecuteSqlInsert<Table_56>(SqQueries.insertPostggreQuery("Ntable56")));
            var Task57 = new Task(() => RpositoryArray[56].ExecuteSqlInsert<Table_57>(SqQueries.insertPostggreQuery("Ntable57")));
            var Task58 = new Task(() => RpositoryArray[57].ExecuteSqlInsert<Table_58>(SqQueries.insertPostggreQuery("Ntable58")));
            var Task59 = new Task(() => RpositoryArray[58].ExecuteSqlInsert<Table_59>(SqQueries.insertPostggreQuery("Ntable59")));
            var Task60 = new Task(() => RpositoryArray[59].ExecuteSqlInsert<Table_60>(SqQueries.insertPostggreQuery("Ntable60")));


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
