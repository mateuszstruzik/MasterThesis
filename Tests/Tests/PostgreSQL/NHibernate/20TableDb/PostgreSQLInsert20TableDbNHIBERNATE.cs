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

namespace Tests.Tests.PostgreSQL.NHibernate._20TableDb
{
    public class PostgreSQLInsert20TableDbNHIBERNATE
    {

        public PostgreSQLServerRepositoryNHibernate SqlServerRepositoryNHibernate;
        private static int objectNumber = 20;
        public PostgreSQLServerRepositoryNHibernate[] RpositoryArray = new PostgreSQLServerRepositoryNHibernate[objectNumber];

        public PostgreSQLInsert20TableDbNHIBERNATE()
        {

            for (int i = 0; i < objectNumber; i++)
            {
                RpositoryArray[i] = new PostgreSQLServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings["PostgreSQLServer20Table"].ConnectionString);
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
            }, tokenSource);

        }
    }
}
