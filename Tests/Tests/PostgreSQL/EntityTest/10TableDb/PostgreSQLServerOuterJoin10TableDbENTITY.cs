using DataExtract.Models.EntityContext;
using DataExtract.Models.ModelsForTests;
using DataExtract.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests.Tests.PostgreSQL.EntityTest._10TableDb
{
    public class PostgreSQLServerOuterJoin10TableDbENTITY
    {
        public IEnumerable<ModelFor10TableOuterJoin> GetOuterJoin()
        {
            IEnumerable<ModelFor10TableOuterJoin> result;
            using (var context = new PostgreSQLContextFor10TableDB())
            {
                result = context.Database.SqlQuery<ModelFor10TableOuterJoin>(SqQueries.SqlSerwerOuterJoin10Table).ToList();
            }

            return result;
        }

        public void GetOuterJoinResultsMultiUser()
        {
            var tokenSource = new CancellationToken();
            var outerJoinsTask1 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask2 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask3 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask4 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask5 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask6 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask7 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask8 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask9 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask10 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask11 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask12 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask13 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask14 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask15 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask16 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask17 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask18 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask19 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask20 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask21 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask22 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask23 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask24 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask25 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask26 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask27 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask28 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask29 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask30 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask31 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask32 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask33 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask34 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask35 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask36 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask37 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask38 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask39 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask40 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask41 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask42 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask43 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask44 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask45 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask46 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask47 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask48 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask49 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask50 = new Task<IEnumerable<ModelFor10TableOuterJoin>>(() => GetOuterJoin());


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
            outerJoinsTask41.Start();
            outerJoinsTask42.Start();
            outerJoinsTask43.Start();
            outerJoinsTask44.Start();
            outerJoinsTask45.Start();
            outerJoinsTask46.Start();
            outerJoinsTask47.Start();
            outerJoinsTask48.Start();
            outerJoinsTask49.Start();
            outerJoinsTask50.Start();


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
            outerJoinsTask41,
            outerJoinsTask42,
            outerJoinsTask43,
            outerJoinsTask44,
            outerJoinsTask45,
            outerJoinsTask46,
            outerJoinsTask47,
            outerJoinsTask48,
            outerJoinsTask49,
            outerJoinsTask50,
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
            var result41 = outerJoinsTask41.Result;
            var result42 = outerJoinsTask42.Result;
            var result43 = outerJoinsTask43.Result;
            var result44 = outerJoinsTask44.Result;
            var result45 = outerJoinsTask45.Result;
            var result46 = outerJoinsTask46.Result;
            var result47 = outerJoinsTask47.Result;
            var result48 = outerJoinsTask48.Result;
            var result49 = outerJoinsTask49.Result;
            var result50 = outerJoinsTask50.Result;

        }
    }
}
