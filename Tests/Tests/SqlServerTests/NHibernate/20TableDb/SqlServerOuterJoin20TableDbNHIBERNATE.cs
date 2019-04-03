using DataExtract.Models.ModelsForTests;
using DataExtract.Queries;
using DataExtract.Repository.SQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests.Tests.SqlServerTests.NHibernate._20TableDb
{
    public class SqlServerOuterJoin20TableDbNHIBERNATE
    {
        private SqlServerRepositoryNHibernate SqlServerRepository;
        private static int objectNumber = 50;
        private SqlServerRepositoryNHibernate[] RpositoryArray = new SqlServerRepositoryNHibernate[objectNumber];

        public SqlServerOuterJoin20TableDbNHIBERNATE()
        {
            SqlServerRepository = new SqlServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings["SqlServer20Table"].ConnectionString);

            for (int i = 0; i < objectNumber; i++)
            {
                RpositoryArray[i] = new SqlServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings["SqlServer20Table"].ConnectionString);
            }
        }

        public List<ModelFor20TableOuterJoin> GetOuterJoinResults()
        {
            var newObj = new ModelFor20TableOuterJoin();
            var result = SqlServerRepository.GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table);

            return result;
        }

        public void GetOuterJoinResultsMultiUser()
        {
            var tokenSource = new CancellationToken();
            var outerJoinsTask1 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[0].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask2 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[1].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask3 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[2].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask4 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[3].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask5 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[4].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask6 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[5].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask7 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[6].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask8 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[7].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask9 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[8].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask10 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[9].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask11 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[10].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask12 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[11].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask13 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[12].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask14 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[13].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask15 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[14].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask16 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[15].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask17 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[16].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask18 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[17].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask19 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[18].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask20 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[19].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask21 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[20].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask22 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[21].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask23 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[22].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask24 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[23].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask25 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[24].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask26 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[25].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask27 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[26].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask28 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[27].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask29 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[28].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask30 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[29].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask31 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[30].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask32 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[31].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask33 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[32].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask34 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[33].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask35 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[34].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask36 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[35].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask37 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[36].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask38 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[37].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask39 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[38].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            var outerJoinsTask40 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[39].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            //var outerJoinsTask41 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[40].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            //var outerJoinsTask42 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[41].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            //var outerJoinsTask43 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[42].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            //var outerJoinsTask44 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[43].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            //var outerJoinsTask45 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[44].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            //var outerJoinsTask46 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[45].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            //var outerJoinsTask47 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[46].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            //var outerJoinsTask48 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[47].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            //var outerJoinsTask49 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[48].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));
            //var outerJoinsTask50 = new Task<IList<ModelFor20TableOuterJoin>>(() => RpositoryArray[49].GeJoinFromTableDB<ModelFor20TableOuterJoin>(SqQueries.OuterJoin20Table));

            outerJoinsTask1.Start();
            outerJoinsTask2.Start();
            outerJoinsTask3.Start();
            outerJoinsTask4.Start();
            outerJoinsTask5.Start();
            outerJoinsTask6.Start();
            outerJoinsTask7.Start();
            outerJoinsTask8.Start();
            outerJoinsTask9.Start();
            outerJoinsTask10.Start();
            outerJoinsTask11.Start();
            outerJoinsTask12.Start();
            outerJoinsTask13.Start();
            outerJoinsTask14.Start();
            outerJoinsTask15.Start();
            outerJoinsTask16.Start();
            outerJoinsTask17.Start();
            outerJoinsTask18.Start();
            outerJoinsTask19.Start();
            outerJoinsTask20.Start();
            outerJoinsTask21.Start();
            outerJoinsTask22.Start();
            outerJoinsTask23.Start();
            outerJoinsTask24.Start();
            outerJoinsTask25.Start();
            outerJoinsTask26.Start();
            outerJoinsTask27.Start();
            outerJoinsTask28.Start();
            outerJoinsTask29.Start();
            outerJoinsTask30.Start();
            outerJoinsTask31.Start();
            outerJoinsTask32.Start();
            outerJoinsTask33.Start();
            outerJoinsTask34.Start();
            outerJoinsTask35.Start();
            outerJoinsTask36.Start();
            outerJoinsTask37.Start();
            outerJoinsTask38.Start();
            outerJoinsTask39.Start();
            outerJoinsTask40.Start();
            //outerJoinsTask41.Start();
            //outerJoinsTask42.Start();
            //outerJoinsTask43.Start();
            //outerJoinsTask44.Start();
            //outerJoinsTask45.Start();
            //outerJoinsTask46.Start();
            //outerJoinsTask47.Start();
            //outerJoinsTask48.Start();
            //outerJoinsTask49.Start();
            //outerJoinsTask50.Start();


            new MultitaskingMonitor().WaitAll(new Task[] { outerJoinsTask1,
            outerJoinsTask2,
            outerJoinsTask3,
            outerJoinsTask4,
            outerJoinsTask5,
            outerJoinsTask6,
            outerJoinsTask7,
            outerJoinsTask8,
            outerJoinsTask9,
            outerJoinsTask10,
            outerJoinsTask11,
            outerJoinsTask12,
            outerJoinsTask13,
            outerJoinsTask14,
            outerJoinsTask15,
            outerJoinsTask16,
            outerJoinsTask17,
            outerJoinsTask18,
            outerJoinsTask19,
            outerJoinsTask20,
            outerJoinsTask21,
            outerJoinsTask22,
            outerJoinsTask23,
            outerJoinsTask24,
            outerJoinsTask25,
            outerJoinsTask26,
            outerJoinsTask27,
            outerJoinsTask28,
            outerJoinsTask29,
            outerJoinsTask30,
            outerJoinsTask31,
            outerJoinsTask32,
            outerJoinsTask33,
            outerJoinsTask34,
            outerJoinsTask35,
            outerJoinsTask36,
            outerJoinsTask37,
            outerJoinsTask38,
            outerJoinsTask39,
            outerJoinsTask40,
            //outerJoinsTask41,
            //outerJoinsTask42,
            //outerJoinsTask43,
            //outerJoinsTask44,
            //outerJoinsTask45,
            //outerJoinsTask46,
            //outerJoinsTask47,
            //outerJoinsTask48,
            //outerJoinsTask49,
            //outerJoinsTask50,
            }, tokenSource);

            var result1 = outerJoinsTask1.Result;
            var result2 = outerJoinsTask2.Result;
            var result3 = outerJoinsTask1.Result;
            var result4 = outerJoinsTask2.Result;
            var result5 = outerJoinsTask3.Result;
            var result6 = outerJoinsTask4.Result;
            var result7 = outerJoinsTask5.Result;
            var result8 = outerJoinsTask6.Result;
            var result9 = outerJoinsTask7.Result;
            var result10 = outerJoinsTask8.Result;
            var result11 = outerJoinsTask9.Result;
            var result12 = outerJoinsTask11.Result;
            var result13 = outerJoinsTask12.Result;
            var result14 = outerJoinsTask13.Result;
            var result15 = outerJoinsTask14.Result;
            var result16 = outerJoinsTask15.Result;
            var result17 = outerJoinsTask16.Result;
            var result18 = outerJoinsTask17.Result;
            var result19 = outerJoinsTask18.Result;
            var result20 = outerJoinsTask19.Result;
            var result21 = outerJoinsTask20.Result;
            var result22 = outerJoinsTask21.Result;
            var result23 = outerJoinsTask22.Result;
            var result24 = outerJoinsTask23.Result;
            var result25 = outerJoinsTask24.Result;
            var result26 = outerJoinsTask25.Result;
            var result27 = outerJoinsTask26.Result;
            var result28 = outerJoinsTask27.Result;
            var result29 = outerJoinsTask28.Result;
            var result30 = outerJoinsTask29.Result;
            var result31 = outerJoinsTask31.Result;
            var result32 = outerJoinsTask32.Result;
            var result33 = outerJoinsTask33.Result;
            var result34 = outerJoinsTask34.Result;
            var result35 = outerJoinsTask35.Result;
            var result36 = outerJoinsTask36.Result;
            var result37 = outerJoinsTask37.Result;
            var result38 = outerJoinsTask38.Result;
            var result39 = outerJoinsTask39.Result;
            var result40 = outerJoinsTask40.Result;
            //var result41 = outerJoinsTask41.Result;
            //var result42 = outerJoinsTask42.Result;
            //var result43 = outerJoinsTask43.Result;
            //var result44 = outerJoinsTask44.Result;
            //var result45 = outerJoinsTask45.Result;
            //var result46 = outerJoinsTask46.Result;
            //var result47 = outerJoinsTask47.Result;
            //var result48 = outerJoinsTask48.Result;
            //var result49 = outerJoinsTask49.Result;
            //var result50 = outerJoinsTask50.Result;

            //SqlServerRepository.SessionClose();//
        }
    }
}
