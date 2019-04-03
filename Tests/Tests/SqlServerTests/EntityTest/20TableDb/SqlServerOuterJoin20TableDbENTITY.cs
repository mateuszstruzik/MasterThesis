using DataExtract.Models.EntityContext._20TableDB;
using DataExtract.Models.ModelsForTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests.Tests.SqlServerTests.EntityTest._20TableDb
{
    public class SqlServerOuterJoin20TableDbENTITY
    {
        public IEnumerable<ModelFor20TableOuterJoin> GetOuterJoin()
        {
            IEnumerable<ModelFor20TableOuterJoin> result;
            using (var context = new SqlServerContextFor20TableDB())
            {
                result = (from tab1 in context.Table_1
                          join tab2c in context.Table_2 on tab1.Column_1_TAB1 equals tab2c.Column_1_TAB2 into tab2p
                          from tab2 in tab2p.DefaultIfEmpty()
                          join tab3c in context.Table_3 on tab2.Column_1_TAB2 equals tab3c.Column_1_TAB3 into tab3p
                          from tab3 in tab3p.DefaultIfEmpty()
                          join tab4c in context.Table_4 on tab3.Column_1_TAB3 equals tab4c.Column_1_TAB4 into tab4p
                          from tab4 in tab4p.DefaultIfEmpty()
                          join tab5c in context.Table_5 on tab4.Column_1_TAB4 equals tab5c.Column_1_TAB5 into tab5p
                          from tab5 in tab5p.DefaultIfEmpty()
                          join tab6c in context.Table_6 on tab5.Column_1_TAB5 equals tab6c.Column_1_TAB6 into tab6p
                          from tab6 in tab6p.DefaultIfEmpty()
                          join tab7c in context.Table_7 on tab6.Column_1_TAB6 equals tab7c.Column_1_TAB7 into tab7p
                          from tab7 in tab7p.DefaultIfEmpty()
                          join tab8c in context.Table_8 on tab7.Column_1_TAB7 equals tab8c.Column_1_TAB8 into tab8p
                          from tab8 in tab8p.DefaultIfEmpty()
                          join tab9c in context.Table_9 on tab8.Column_1_TAB8 equals tab9c.Column_1_TAB9 into tab9c
                          from tab9 in tab9c.DefaultIfEmpty()
                          join tab10c in context.Table_10 on tab9.Column_1_TAB9 equals tab10c.Column_1_TAB10 into tab10p
                          from tab10 in tab10p.DefaultIfEmpty()
                          join tab11c in context.Table_11 on tab10.Column_1_TAB10 equals tab11c.Column_1_TAB1 into tab11p
                          from tab11 in tab11p.DefaultIfEmpty()
                          join tab12c in context.Table_12 on tab11.Column_1_TAB1 equals tab12c.Column_1_TAB2 into tab12p
                          from tab12 in tab12p.DefaultIfEmpty()
                          join tab13c in context.Table_13 on tab12.Column_1_TAB2 equals tab13c.Column_1_TAB3 into tab13p
                          from tab13 in tab13p.DefaultIfEmpty()
                          join tab14c in context.Table_14 on tab13.Column_1_TAB3 equals tab14c.Column_1_TAB4 into tab14p
                          from tab14 in tab14p.DefaultIfEmpty()
                          join tab15c in context.Table_15 on tab14.Column_1_TAB4 equals tab15c.Column_1_TAB5 into tab15p
                          from tab15 in tab15p.DefaultIfEmpty()
                          join tab16c in context.Table_16 on tab15.Column_1_TAB5 equals tab16c.Column_1_TAB6 into tab16p
                          from tab16 in tab16p.DefaultIfEmpty()
                          join tab17c in context.Table_17 on tab16.Column_1_TAB6 equals tab17c.Column_1_TAB7 into tab17p
                          from tab17 in tab17p.DefaultIfEmpty()
                          join tab18c in context.Table_18 on tab17.Column_1_TAB7 equals tab18c.Column_1_TAB8 into tab18p
                          from tab18 in tab18p.DefaultIfEmpty()
                          join tab19c in context.Table_19 on tab18.Column_1_TAB8 equals tab19c.Column_1_TAB9 into tab19p
                          from tab19 in tab19p.DefaultIfEmpty()
                          join tab20c in context.Table_20 on tab19.Column_1_TAB9 equals tab20c.Column_1_TAB10 into tab20p
                          from tab20 in tab20p.DefaultIfEmpty()
                          select new ModelFor20TableOuterJoin
                          {
                              ID = tab1.Column_1_TAB1,
                              T1C2 = tab1.Column_2_TAB1,
                              T2C3 = tab2.Column_3_TAB2,
                              T3C4 = tab3.Column_4_TAB3,
                              T4C5 = tab4.Column_5_TAB4,
                              T5C6 = tab5.Column_6_TAB5,
                              T6C7 = tab6.Column_7_TAB6,
                              T7C8 = tab7.Column_8_TAB7,
                              T8C9 = tab8.Column_9_TAB8,
                              T9C10 = tab9.Column_10_TAB9,
                              T10C11 = tab10.Column_11_TAB10,
                              T11C2 = tab11.Column_2_TAB1,
                              T12C3 = tab12.Column_3_TAB2,
                              T13C4 = tab13.Column_4_TAB3,
                              T14C5 = tab14.Column_5_TAB4,
                              T15C6 = tab15.Column_6_TAB5,
                              T16C7 = tab16.Column_7_TAB6,
                              T17C8 = tab17.Column_8_TAB7,
                              T18C9 = tab18.Column_9_TAB8,
                              T19C10 = tab19.Column_10_TAB9,
                              T20C11 = tab20.Column_11_TAB10
                          }).ToList();


            }
            return result;
        }

        public void GetOuterJoinResultsMultiUser()
        {
            var tokenSource = new CancellationToken();
            var outerJoinsTask1 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask2 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask3 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask4 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask5 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask6 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask7 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask8 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask9 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask10 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask11 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask12 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask13 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask14 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask15 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask16 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask17 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask18 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask19 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask20 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask21 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask22 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask23 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask24 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask25 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask26 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask27 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask28 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask29 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask30 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask31 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask32 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask33 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask34 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask35 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask36 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask37 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask38 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask39 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            var outerJoinsTask40 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            //var outerJoinsTask41 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            //var outerJoinsTask42 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            //var outerJoinsTask43 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            //var outerJoinsTask44 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            //var outerJoinsTask45 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            //var outerJoinsTask46 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            //var outerJoinsTask47 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            //var outerJoinsTask48 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            //var outerJoinsTask49 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());
            //var outerJoinsTask50 = new Task<IEnumerable<ModelFor20TableOuterJoin>>(() => GetOuterJoin());


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

        }
    }
}
