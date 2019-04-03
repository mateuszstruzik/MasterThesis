﻿using DataExtract.Models.ModelsForTests;
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
    public class PostgreSQLServerOuterJoin80TableDbNHIBERNATE
    {
        private PostgreSQLServerRepositoryNHibernate SqlServerRepository;
        private static int objectNumber = 50;
        private PostgreSQLServerRepositoryNHibernate[] RpositoryArray = new PostgreSQLServerRepositoryNHibernate[objectNumber];

        public PostgreSQLServerOuterJoin80TableDbNHIBERNATE()
        {
            SqlServerRepository = new PostgreSQLServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings["PostgreSQLServer80Table"].ConnectionString);

            for (int i = 0; i < objectNumber; i++)
            {
                RpositoryArray[i] = new PostgreSQLServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings["PostgreSQLServer80Table"].ConnectionString);
            }
        }

        public List<ModelFor80TableOuterJoin> GetOuterJoin()
        {
            var result = SqlServerRepository.GetJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table);

            return result;
        }

        public void GetOuterJoinResultsMultiUser()
        {
            var tokenSource = new CancellationToken();
            var outerJoinsTask1 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[0].GetJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            var outerJoinsTask2 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[1].GetJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            var outerJoinsTask3 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[2].GetJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            var outerJoinsTask4 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[3].GetJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            var outerJoinsTask5 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[4].GetJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            var outerJoinsTask6 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[5].GetJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            var outerJoinsTask7 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[6].GetJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            var outerJoinsTask8 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[7].GetJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            var outerJoinsTask9 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[8].GetJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            var outerJoinsTask10 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[9].GetJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask11 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[10].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask12 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[11].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask13 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[12].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask14 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[13].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask15 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[14].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask16 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[15].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask17 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[16].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask18 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[17].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask19 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[18].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask20 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[19].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask21 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[20].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask22 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[21].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask23 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[22].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask24 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[23].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask25 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[24].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask26 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[25].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask27 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[26].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask28 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[27].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask29 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[28].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask30 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[29].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask31 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[30].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask32 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[31].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask33 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[32].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask34 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[33].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask35 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[34].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask36 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[35].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask37 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[36].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask38 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[37].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask39 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[38].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask40 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[39].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask41 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[40].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask42 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[41].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask43 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[42].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask44 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[43].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask45 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[44].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask46 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[45].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask47 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[46].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask48 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[47].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask49 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[48].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));
            //var outerJoinsTask50 = new Task<IList<ModelFor80TableOuterJoin>>(() => RpositoryArray[49].GetOuterJoinFromTableDB<ModelFor80TableOuterJoin>(SqQueries.OuterJoin80Table));

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
            //outerJoinsTask11.Start();
            //outerJoinsTask12.Start();
            //outerJoinsTask13.Start();
            //outerJoinsTask14.Start();
            //outerJoinsTask15.Start();
            //outerJoinsTask16.Start();
            //outerJoinsTask17.Start();
            //outerJoinsTask18.Start();
            //outerJoinsTask19.Start();
            //outerJoinsTask20.Start();
            //outerJoinsTask21.Start();
            //outerJoinsTask22.Start();
            //outerJoinsTask23.Start();
            //outerJoinsTask24.Start();
            //outerJoinsTask25.Start();
            //outerJoinsTask26.Start();
            //outerJoinsTask27.Start();
            //outerJoinsTask28.Start();
            //outerJoinsTask29.Start();
            //outerJoinsTask30.Start();
            //outerJoinsTask31.Start();
            //outerJoinsTask32.Start();
            //outerJoinsTask33.Start();
            //outerJoinsTask34.Start();
            //outerJoinsTask35.Start();
            //outerJoinsTask36.Start();
            //outerJoinsTask37.Start();
            //outerJoinsTask38.Start();
            //outerJoinsTask39.Start();
            //outerJoinsTask40.Start();
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
            //outerJoinsTask11,
            //outerJoinsTask12,
            //outerJoinsTask13,
            //outerJoinsTask14,
            //outerJoinsTask15,
            //outerJoinsTask16,
            //outerJoinsTask17,
            //outerJoinsTask18,
            //outerJoinsTask19,
            //outerJoinsTask20,
            //outerJoinsTask21,
            //outerJoinsTask22,
            //outerJoinsTask23,
            //outerJoinsTask24,
            //outerJoinsTask25,
            //outerJoinsTask26,
            //outerJoinsTask27,
            //outerJoinsTask28,
            //outerJoinsTask29,
            //outerJoinsTask30,
            //outerJoinsTask31,
            //outerJoinsTask32,
            //outerJoinsTask33,
            //outerJoinsTask34,
            //outerJoinsTask35,
            //outerJoinsTask36,
            //outerJoinsTask37,
            //outerJoinsTask38,
            //outerJoinsTask39,
            //outerJoinsTask40,
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
            var result3 = outerJoinsTask3.Result;
            var result4 = outerJoinsTask4.Result;
            var result5 = outerJoinsTask5.Result;
            var result6 = outerJoinsTask6.Result;
            var result7 = outerJoinsTask7.Result;
            var result8 = outerJoinsTask8.Result;
            var result9 = outerJoinsTask9.Result;
            var result10 = outerJoinsTask10.Result;
            //var result11 = outerJoinsTask11.Result;
            //var result12 = outerJoinsTask12.Result;
            //var result13 = outerJoinsTask13.Result;
            //var result14 = outerJoinsTask14.Result;
            //var result15 = outerJoinsTask15.Result;
            //var result16 = outerJoinsTask16.Result;
            //var result17 = outerJoinsTask17.Result;
            //var result18 = outerJoinsTask18.Result;
            //var result19 = outerJoinsTask19.Result;
            //var result20 = outerJoinsTask20.Result;
            //var result21 = outerJoinsTask21.Result;
            //var result22 = outerJoinsTask22.Result;
            //var result23 = outerJoinsTask23.Result;
            //var result24 = outerJoinsTask24.Result;
            //var result25 = outerJoinsTask25.Result;
            //var result26 = outerJoinsTask26.Result;
            //var result27 = outerJoinsTask27.Result;
            //var result28 = outerJoinsTask28.Result;
            //var result29 = outerJoinsTask29.Result;
            //var result30 = outerJoinsTask30.Result;
            //var result31 = outerJoinsTask31.Result;
            //var result32 = outerJoinsTask32.Result;
            //var result33 = outerJoinsTask33.Result;
            //var result34 = outerJoinsTask34.Result;
            //var result35 = outerJoinsTask35.Result;
            //var result36 = outerJoinsTask36.Result;
            //var result37 = outerJoinsTask37.Result;
            //var result38 = outerJoinsTask38.Result;
            //var result39 = outerJoinsTask39.Result;
            //var result40 = outerJoinsTask40.Result;
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
