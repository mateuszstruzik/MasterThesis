using DataExtract.Models.EntityContext;
using DataExtract.Models.ModelsForTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests.Tests.OracleDbServeTests.EntityTests._10TableDB
{
    public class OracleServerInnerJoin10TableDbENTITY
    {
        public IEnumerable<ModelFor10TableInnerJoin> GetJoin()
        {
            IEnumerable<ModelFor10TableInnerJoin> result;
            using (var context = new OracleContextFor10TableDB())
            {
                result = (from tab1 in context.Table_1
                          join tab2c in context.Table_2 on tab1.Column_1_TAB1 equals tab2c.Column_1_TAB2 into tab2p
                          from tab2 in tab2p
                          join tab3c in context.Table_3 on tab2.Column_1_TAB2 equals tab3c.Column_1_TAB3 into tab3p
                          from tab3 in tab3p
                          join tab4c in context.Table_4 on tab3.Column_1_TAB3 equals tab4c.Column_1_TAB4 into tab4p
                          from tab4 in tab4p
                          join tab5c in context.Table_5 on tab4.Column_1_TAB4 equals tab5c.Column_1_TAB5 into tab5p
                          from tab5 in tab5p
                          join tab6c in context.Table_6 on tab5.Column_1_TAB5 equals tab6c.Column_1_TAB6 into tab6p
                          from tab6 in tab6p
                          join tab7c in context.Table_7 on tab6.Column_1_TAB6 equals tab7c.Column_1_TAB7 into tab7p
                          from tab7 in tab7p
                          join tab8c in context.Table_8 on tab7.Column_1_TAB7 equals tab8c.Column_1_TAB8 into tab8p
                          from tab8 in tab8p
                          join tab9c in context.Table_9 on tab8.Column_1_TAB8 equals tab9c.Column_1_TAB9 into tab9c
                          from tab9 in tab9c
                          join tab10c in context.Table_10 on tab9.Column_1_TAB9 equals tab10c.Column_1_TAB10 into tab10p
                          from tab10 in tab10p
                          select new ModelFor10TableInnerJoin
                          {
                              ID = tab1.Column_1_TAB1,
                              T1C2 = tab1.Column_2_TAB1,
                              T1C3 = tab1.Column_3_TAB1,
                              T2C4 = tab2.Column_4_TAB2,
                              T2C5 = tab2.Column_5_TAB2,
                              T2C6 = tab2.Column_6_TAB2,
                              T3C7 = tab3.Column_7_TAB3,
                              T3C8 = tab3.Column_8_TAB3,
                              T3C9 = tab3.Column_9_TAB3,
                              T4C10 = tab4.Column_10_TAB4,
                              T4C11 = tab4.Column_11_TAB4,
                              T4C12 = tab4.Column_12_TAB4,
                              T5C13 = tab4.Column_13_TAB4,
                              T5C14 = tab5.Column_14_TAB5,
                              T5C15 = tab5.Column_15_TAB5,
                              T6C16 = tab6.Column_16_TAB6,
                              T6C17 = tab6.Column_17_TAB6,
                              T6C18 = tab6.Column_18_TAB6,
                              T7C19 = tab7.Column_19_TAB7,
                              T7C20 = tab7.Column_20_TAB7,
                              T7C21 = tab7.Column_21_TAB7,
                              T8C22 = tab8.Column_22_TAB8,
                              T8C23 = tab8.Column_23_TAB8,
                              T8C24 = tab8.Column_24_TAB8,
                              T9C2 = tab9.Column_2_TAB9,
                              T9C10 = tab9.Column_10_TAB9,
                              T9C20 = tab9.Column_20_TAB9,
                              T10C5 = tab10.Column_5_TAB10,
                              T10C10 = tab10.Column_10_TAB10,
                              T10C15 = tab10.Column_15_TAB10
                          }).ToList();


            }
            return result;
        }

        public void GetJoinResultsMultiUser()
        {
            var tokenSource = new CancellationToken();
            var JoinsTask1 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            var JoinsTask2 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            var JoinsTask3 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            var JoinsTask4 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            var JoinsTask5 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            var JoinsTask6 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            var JoinsTask7 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            var JoinsTask8 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            var JoinsTask9 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            var JoinsTask10 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask11 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask12 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask13 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask14 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask15 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask16 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask17 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask18 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask19 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask20 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask21 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask22 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask23 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask24 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask25 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask26 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask27 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask28 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask29 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask30 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask31 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask32 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask33 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask34 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask35 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask36 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask37 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask38 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask39 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask40 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask41 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask42 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask43 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask44 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask45 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask46 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask47 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask48 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask49 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());
            //var JoinsTask50 = new Task<IEnumerable<ModelFor10TableInnerJoin>>(() => GetJoin());


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
            //JoinsTask11.Start();
            //JoinsTask12.Start();
            //JoinsTask13.Start();
            //JoinsTask14.Start();
            //JoinsTask15.Start();
            //JoinsTask16.Start();
            //JoinsTask17.Start();
            //JoinsTask18.Start();
            //JoinsTask19.Start();
            //JoinsTask20.Start();
            //JoinsTask21.Start();
            //JoinsTask22.Start();
            //JoinsTask23.Start();
            //JoinsTask24.Start();
            //JoinsTask25.Start();
            //JoinsTask26.Start();
            //JoinsTask27.Start();
            //JoinsTask28.Start();
            //JoinsTask29.Start();
            //JoinsTask30.Start();
            //JoinsTask31.Start();
            //JoinsTask32.Start();
            //JoinsTask33.Start();
            //JoinsTask34.Start();
            //JoinsTask35.Start();
            //JoinsTask36.Start();
            //JoinsTask37.Start();
            //JoinsTask38.Start();
            //JoinsTask39.Start();
            //JoinsTask40.Start();
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
            //JoinsTask11,
            //JoinsTask12,
            //JoinsTask13,
            //JoinsTask14,
            //JoinsTask15,
            //JoinsTask16,
            //JoinsTask17,
            //JoinsTask18,
            //JoinsTask19,
            //JoinsTask20,
            //JoinsTask21,
            //JoinsTask22,
            //JoinsTask23,
            //JoinsTask24,
            //JoinsTask25,
            //JoinsTask26,
            //JoinsTask27,
            //JoinsTask28,
            //JoinsTask29,
            //JoinsTask30,
            //JoinsTask31,
            //JoinsTask32,
            //JoinsTask33,
            //JoinsTask34,
            //JoinsTask35,
            //JoinsTask36,
            //JoinsTask37,
            //JoinsTask38,
            //JoinsTask39,
            //JoinsTask40,
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
            var result3 = JoinsTask3.Result;
            var result4 = JoinsTask4.Result;
            var result5 = JoinsTask5.Result;
            var result6 = JoinsTask6.Result;
            var result7 = JoinsTask7.Result;
            var result8 = JoinsTask8.Result;
            var result9 = JoinsTask9.Result;
            var result10 = JoinsTask10.Result;
            //var result11 = JoinsTask11.Result;
            //var result12 = JoinsTask12.Result;
            //var result13 = JoinsTask13.Result;
            //var result14 = JoinsTask14.Result;
            //var result15 = JoinsTask15.Result;
            //var result16 = JoinsTask16.Result;
            //var result17 = JoinsTask17.Result;
            //var result18 = JoinsTask18.Result;
            //var result19 = JoinsTask19.Result;
            //var result20 = JoinsTask20.Result;
            //var result21 = JoinsTask20.Result;
            //var result22 = JoinsTask21.Result;
            //var result23 = JoinsTask22.Result;
            //var result24 = JoinsTask23.Result;
            //var result25 = JoinsTask24.Result;
            //var result26 = JoinsTask25.Result;
            //var result27 = JoinsTask26.Result;
            //var result28 = JoinsTask27.Result;
            //var result29 = JoinsTask28.Result;
            //var result30 = JoinsTask29.Result;
            //var result31 = JoinsTask31.Result;
            //var result32 = JoinsTask32.Result;
            //var result33 = JoinsTask33.Result;
            //var result34 = JoinsTask34.Result;
            //var result35 = JoinsTask35.Result;
            //var result36 = JoinsTask36.Result;
            //var result37 = JoinsTask37.Result;
            //var result38 = JoinsTask38.Result;
            //var result39 = JoinsTask39.Result;
            //var result40 = JoinsTask40.Result;
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
        }
    }
}
