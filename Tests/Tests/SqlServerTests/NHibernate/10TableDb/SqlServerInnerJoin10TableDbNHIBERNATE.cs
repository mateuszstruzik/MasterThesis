﻿using DataExtract.Models.ModelsForTests;
using DataExtract.Queries;
using DataExtract.Repository.SQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests.Tests.SqlServerTests.NHibernate._10TableDb
{
    public class SqlServerInnerJoin10TableDbNHIBERNATE
    {
        private SqlServerRepositoryNHibernate SqlServerRepository;
        private static int objectNumber = 50;
        private SqlServerRepositoryNHibernate[] RpositoryArray = new SqlServerRepositoryNHibernate[objectNumber];

        public SqlServerInnerJoin10TableDbNHIBERNATE()
        {
            SqlServerRepository = new SqlServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings["SqlServer10TableENT"].ConnectionString);

            for (int i = 0; i < objectNumber; i++)
            {
                RpositoryArray[i] = new SqlServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings["SqlServer10TableENT"].ConnectionString);
            }
        }

        public List<ModelFor10TableInnerJoin> GetJoin()
        {
            var result = SqlServerRepository.GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table);

            return result;
        }

        public void GetOuterJoinResultsMultiUser()
        {
            var tokenSource = new CancellationToken();
            var JoinsTask1 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[0].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask2 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[1].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask3 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[2].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask4 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[3].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask5 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[4].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask6 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[5].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask7 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[6].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask8 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[7].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask9 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[8].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask10 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[9].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask11 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[10].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask12 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[11].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask13 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[12].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask14 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[13].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask15 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[14].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask16 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[15].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask17 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[16].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask18 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[17].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask19 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[18].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask20 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[19].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask21 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[20].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask22 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[21].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask23 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[22].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask24 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[23].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask25 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[24].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask26 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[25].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask27 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[26].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask28 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[27].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask29 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[28].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask30 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[29].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask31 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[30].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask32 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[31].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask33 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[32].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask34 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[33].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask35 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[34].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask36 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[35].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask37 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[36].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask38 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[37].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask39 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[38].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask40 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[39].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask41 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[40].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask42 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[41].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask43 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[42].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask44 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[43].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask45 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[44].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask46 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[45].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask47 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[46].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask48 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[47].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask49 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[48].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));
            var JoinsTask50 = new Task<IList<ModelFor10TableInnerJoin>>(() => RpositoryArray[49].GeJoinFromTableDB<ModelFor10TableInnerJoin>(SqQueries.InnerJoin10Table));

            JoinsTask1.Start();
            JoinsTask2.Start();
            JoinsTask3.Start();
            JoinsTask4.Start();
            JoinsTask5.Start();
            JoinsTask6.Start();
            JoinsTask7.Start();
            JoinsTask8.Start();
            JoinsTask9.Start();
            JoinsTask10.Start();
            JoinsTask11.Start();
            JoinsTask12.Start();
            JoinsTask13.Start();
            JoinsTask14.Start();
            JoinsTask15.Start();
            JoinsTask16.Start();
            JoinsTask17.Start();
            JoinsTask18.Start();
            JoinsTask19.Start();
            JoinsTask20.Start();
            JoinsTask21.Start();
            JoinsTask22.Start();
            JoinsTask23.Start();
            JoinsTask24.Start();
            JoinsTask25.Start();
            JoinsTask26.Start();
            JoinsTask27.Start();
            JoinsTask28.Start();
            JoinsTask29.Start();
            JoinsTask30.Start();
            JoinsTask31.Start();
            JoinsTask32.Start();
            JoinsTask33.Start();
            JoinsTask34.Start();
            JoinsTask35.Start();
            JoinsTask36.Start();
            JoinsTask37.Start();
            JoinsTask38.Start();
            JoinsTask39.Start();
            JoinsTask40.Start();
            //JoinsTask41.Start();
            //JoinsTask42.Start();
            //JoinsTask43.Start();
            //JoinsTask44.Start();
            //JoinsTask45.Start();
            //JoinsTask46.Start();
            //JoinsTask47.Start();
            //JoinsTask48.Start();
            //JoinsTask49.Start();
            //JoinsTask50.Start();


            new MultitaskingMonitor().WaitAll(new Task[] { JoinsTask1,
            JoinsTask2,
            JoinsTask3,
            JoinsTask4,
            JoinsTask5,
            JoinsTask6,
            JoinsTask7,
            JoinsTask8,
            JoinsTask9,
            JoinsTask10,
            JoinsTask11,
            JoinsTask12,
            JoinsTask13,
            JoinsTask14,
            JoinsTask15,
            JoinsTask16,
            JoinsTask17,
            JoinsTask18,
            JoinsTask19,
            JoinsTask20,
            JoinsTask21,
            JoinsTask22,
            JoinsTask23,
            JoinsTask24,
            JoinsTask25,
            JoinsTask26,
            JoinsTask27,
            JoinsTask28,
            JoinsTask29,
            JoinsTask30,
            JoinsTask31,
            JoinsTask32,
            JoinsTask33,
            JoinsTask34,
            JoinsTask35,
            JoinsTask36,
            JoinsTask37,
            JoinsTask38,
            JoinsTask39,
            JoinsTask40,
            //JoinsTask41,
            //JoinsTask42,
            //JoinsTask43,
            //JoinsTask44,
            //JoinsTask45,
            //JoinsTask46,
            //JoinsTask47,
            //JoinsTask48,
            //JoinsTask49,
            //JoinsTask50,
            }, tokenSource);

            var result1 = JoinsTask1.Result;
            var result2 = JoinsTask2.Result;
            var result3 = JoinsTask1.Result;
            var result4 = JoinsTask2.Result;
            var result5 = JoinsTask3.Result;
            var result6 = JoinsTask4.Result;
            var result7 = JoinsTask5.Result;
            var result8 = JoinsTask6.Result;
            var result9 = JoinsTask7.Result;
            var result10 = JoinsTask8.Result;
            var result11 = JoinsTask9.Result;
            var result12 = JoinsTask11.Result;
            var result13 = JoinsTask12.Result;
            var result14 = JoinsTask13.Result;
            var result15 = JoinsTask14.Result;
            var result16 = JoinsTask15.Result;
            var result17 = JoinsTask16.Result;
            var result18 = JoinsTask17.Result;
            var result19 = JoinsTask18.Result;
            var result20 = JoinsTask19.Result;
            var result21 = JoinsTask20.Result;
            var result22 = JoinsTask21.Result;
            var result23 = JoinsTask22.Result;
            var result24 = JoinsTask23.Result;
            var result25 = JoinsTask24.Result;
            var result26 = JoinsTask25.Result;
            var result27 = JoinsTask26.Result;
            var result28 = JoinsTask27.Result;
            var result29 = JoinsTask28.Result;
            var result30 = JoinsTask29.Result;
            var result31 = JoinsTask31.Result;
            var result32 = JoinsTask32.Result;
            var result33 = JoinsTask33.Result;
            var result34 = JoinsTask34.Result;
            var result35 = JoinsTask35.Result;
            var result36 = JoinsTask36.Result;
            var result37 = JoinsTask37.Result;
            var result38 = JoinsTask38.Result;
            var result39 = JoinsTask39.Result;
            var result40 = JoinsTask40.Result;
            //var result41 = JoinsTask41.Result;
            //var result42 = JoinsTask42.Result;
            //var result43 = JoinsTask43.Result;
            //var result44 = JoinsTask44.Result;
            //var result45 = JoinsTask45.Result;
            //var result46 = JoinsTask46.Result;
            //var result47 = JoinsTask47.Result;
            //var result48 = JoinsTask48.Result;
            //var result49 = JoinsTask49.Result;
            //var result50 = JoinsTask50.Result;

            //SqlServerRepository.SessionClose();//
        }
    }
}
