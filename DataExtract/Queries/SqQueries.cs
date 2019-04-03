using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataExtract.Queries
{
    public static class SqQueries
    {
        #region Select From single Table
        public static string SelectFromTable1 = @"Select * from Table_1";
        public static string SelectFromTable2 = @"Select * from Table_2";
        public static string SelectFromTable3 = @"Select * from Table_3";
        public static string SelectFromTable4 = @"Select * from Table_4";
        public static string SelectFromTable5 = @"Select * from Table_5";
        public static string SelectFromTable6 = @"Select * from Table_6";
        public static string SelectFromTable7 = @"Select * from Table_7";
        public static string SelectFromTable8 = @"Select * from Table_8";
        public static string SelectFromTable9 = @"Select * from Table_9";
        public static string SelectFromTable10 = @"Select * from Table_10";
        public static string SelectFromTable11 = @"Select * from Table_11";
        public static string SelectFromTable12 = @"Select * from Table_12";
        public static string SelectFromTable13 = @"Select * from Table_13";
        public static string SelectFromTable14 = @"Select * from Table_14";
        public static string SelectFromTable15 = @"Select * from Table_15";
        public static string SelectFromTable16 = @"Select * from Table_16";
        public static string SelectFromTable17 = @"Select * from Table_17";
        public static string SelectFromTable18 = @"Select * from Table_18";
        public static string SelectFromTable19 = @"Select * from Table_19";
        public static string SelectFromTable20 = @"Select * from Table_20";
        public static string SelectFromTable21 = @"Select * from Table_21";
        public static string SelectFromTable22 = @"Select * from Table_22";
        public static string SelectFromTable23 = @"Select * from Table_23";
        public static string SelectFromTable24 = @"Select * from Table_24";
        public static string SelectFromTable25 = @"Select * from Table_25";
        public static string SelectFromTable26 = @"Select * from Table_26";
        public static string SelectFromTable27 = @"Select * from Table_27";
        public static string SelectFromTable28 = @"Select * from Table_28";
        public static string SelectFromTable29 = @"Select * from Table_29";
        public static string SelectFromTable30 = @"Select * from Table_30";
        public static string SelectFromTable31 = @"Select * from Table_31";
        public static string SelectFromTable32 = @"Select * from Table_32";
        public static string SelectFromTable33 = @"Select * from Table_33";
        public static string SelectFromTable34 = @"Select * from Table_34";
        public static string SelectFromTable35 = @"Select * from Table_35";
        public static string SelectFromTable36 = @"Select * from Table_36";
        public static string SelectFromTable37 = @"Select * from Table_37";
        public static string SelectFromTable38 = @"Select * from Table_38";
        public static string SelectFromTable39 = @"Select * from Table_39";
        public static string SelectFromTable40 = @"Select * from Table_40";
        public static string SelectFromTable41 = @"Select * from Table_41";
        public static string SelectFromTable42 = @"Select * from Table_42";
        public static string SelectFromTable43 = @"Select * from Table_43";
        public static string SelectFromTable44 = @"Select * from Table_44";
        public static string SelectFromTable45 = @"Select * from Table_45";
        public static string SelectFromTable46 = @"Select * from Table_46";
        public static string SelectFromTable47 = @"Select * from Table_47";
        public static string SelectFromTable48 = @"Select * from Table_48";
        public static string SelectFromTable49 = @"Select * from Table_49";
        public static string SelectFromTable50 = @"Select * from Table_50";
        public static string SelectFromTable51 = @"Select * from Table_51";
        public static string SelectFromTable52 = @"Select * from Table_52";
        public static string SelectFromTable53 = @"Select * from Table_53";
        public static string SelectFromTable54 = @"Select * from Table_54";
        public static string SelectFromTable55 = @"Select * from Table_55";
        public static string SelectFromTable56 = @"Select * from Table_56";
        public static string SelectFromTable57 = @"Select * from Table_57";
        public static string SelectFromTable58 = @"Select * from Table_58";
        public static string SelectFromTable59 = @"Select * from Table_59";
        public static string SelectFromTable60 = @"Select * from Table_60";

        #endregion

        #region Outer Join SQlSERVER
        #region 10table
        public static string SqlSerwerOuterJoin10Table = @"select T1.Column_1_TAB1 as ID,
T1.Column_2_TAB1 as T1C2, 
T2.Column_3_TAB2 as T2C3,
T3.Column_4_TAB3 as T3C4,
T4.Column_5_TAB4 as T4C5,
T5.Column_6_TAB5 as T5C6,
T6.Column_7_TAB6 as T6C7,
T7.Column_8_TAB7 as T7C8,
T8.Column_9_TAB8 as T8C9,
T9.Column_10_TAB9 as T9C10,
T10.Column_11_TAB10 as T10C11
from Table_1 T1
Left Outer join Table_2 T2 
on T1.Column_1_TAB1 = T2.Column_1_TAB2
Left Outer join Table_3 T3 
on T2.Column_1_TAB2 = T3.Column_1_TAB3
Left Outer join Table_4 T4 
on T3.Column_1_TAB3 = T4.Column_1_TAB4
Left Outer join Table_5 T5 
on T4.Column_1_TAB4 = T5.Column_1_TAB5
Left Outer join Table_6 T6 
on T5.Column_1_TAB5 = T6.Column_1_TAB6
Left Outer join Table_7 T7 
on T6.Column_1_TAB6 = T7.Column_1_TAB7
Left Outer join Table_8 T8 
on T7.Column_1_TAB7 = T8.Column_1_TAB8
Left Outer join Table_9 T9 
on T8.Column_1_TAB8 = T9.Column_1_TAB9
Left Outer join Table_10 T10 
on T9.Column_1_TAB9 = T10.Column_1_TAB10";

        public static string SqlSerwerOuterJoin10TableNHIBERNATE = @"select 
T1.Column_1_TAB1, 
T1.Column_2_TAB1, 
T2.Column_3_TAB2, 
T3.Column_4_TAB3, 
T4.Column_5_TAB4, 
T5.Column_6_TAB5, 
T6.Column_7_TAB6, 
T7.Column_8_TAB7, 
T8.Column_9_TAB8, 
T9.Column_10_TAB9, 
T10.Column_11_TAB10 
from Table_1 T1
Left Outer join Table_2 T2 
on T1.Column_1_TAB1 = T2.Column_1_TAB2
Left Outer join Table_3 T3 
on T2.Column_1_TAB2 = T3.Column_1_TAB3
Left Outer join Table_4 T4 
on T3.Column_1_TAB3 = T4.Column_1_TAB4
Left Outer join Table_5 T5 
on T4.Column_1_TAB4 = T5.Column_1_TAB5
Left Outer join Table_6 T6 
on T5.Column_1_TAB5 = T6.Column_1_TAB6
Left Outer join Table_7 T7 
on T6.Column_1_TAB6 = T7.Column_1_TAB7
Left Outer join Table_8 T8 
on T7.Column_1_TAB7 = T8.Column_1_TAB8
Left Outer join Table_9 T9 
on T8.Column_1_TAB8 = T9.Column_1_TAB9
Left Outer join Table_10 T10 
on T9.Column_1_TAB9 = T10.Column_1_TAB10";
        #endregion
        #region 20table
        public static string OuterJoin20Table = @"select T1.Column_1_TAB1 as ID,
T1.Column_2_TAB1 as T1C2, 
T2.Column_3_TAB2 as T2C3,
T3.Column_4_TAB3 as T3C4,
T4.Column_5_TAB4 as T4C5,
T5.Column_6_TAB5 as T5C6,
T6.Column_7_TAB6 as T6C7,
T7.Column_8_TAB7 as T7C8,
T8.Column_9_TAB8 as T8C9,
T9.Column_10_TAB9 as T9C10,
T10.Column_11_TAB10 as T10C11,
T11.Column_2_TAB1 as T11C2,
T12.Column_3_TAB2 as T12C3,
T13.Column_4_TAB3 as T13C4,
T14.Column_5_TAB4 AS T14C5,
T15.Column_6_TAB5 AS T15C6,
T16.Column_7_TAB6 AS T16C7,
T17.Column_8_TAB7 AS T17C8,
T18.Column_9_TAB8 AS T18C9,
T19.Column_10_TAB9 AS T19C10,
T20.Column_11_TAB10 AS T20C11
from Table_1 T1
Left Outer join Table_2 T2 
on T1.Column_1_TAB1 = T2.Column_1_TAB2
Left Outer join Table_3 T3 
on T2.Column_1_TAB2 = T3.Column_1_TAB3
Left Outer join Table_4 T4 
on T3.Column_1_TAB3 = T4.Column_1_TAB4
Left Outer join Table_5 T5 
on T4.Column_1_TAB4 = T5.Column_1_TAB5
Left Outer join Table_6 T6 
on T5.Column_1_TAB5 = T6.Column_1_TAB6
Left Outer join Table_7 T7 
on T6.Column_1_TAB6 = T7.Column_1_TAB7
Left Outer join Table_8 T8 
on T7.Column_1_TAB7 = T8.Column_1_TAB8
Left Outer join Table_9 T9 
on T8.Column_1_TAB8 = T9.Column_1_TAB9
Left Outer join Table_10 T10 
on T9.Column_1_TAB9 = T10.Column_1_TAB10
Left Outer join Table_11 T11
on T10.Column_1_TAB10 = T11.Column_1_TAB1
Left Outer join Table_12 T12 
on T11.Column_1_TAB1 = T12.Column_1_TAB2
Left Outer join Table_13 T13
on T12.Column_1_TAB2 = T13.Column_1_TAB3
Left Outer join Table_14 T14
on T13.Column_1_TAB3 = T14.Column_1_TAB4
Left Outer join Table_15 T15
on T14.Column_1_TAB4 = T15.Column_1_TAB5
Left Outer join Table_16 T16
on T15.Column_1_TAB5 = T16.Column_1_TAB6
Left Outer join Table_17 T17
on T16.Column_1_TAB6 = T17.Column_1_TAB7
Left Outer join Table_18 T18
on T17.Column_1_TAB7 = T18.Column_1_TAB8
Left Outer join Table_19 T19
on T18.Column_1_TAB8= T19.Column_1_TAB9
Left Outer join Table_20 T20
on T19.Column_1_TAB9 = T20.Column_1_TAB10";

        public static string OuterJoin20TableNHIBERNATE = @"select T1.Column_1_TAB1,
T1.Column_2_TAB1, 
T2.Column_3_TAB2,
T3.Column_4_TAB3,
T4.Column_5_TAB4,
T5.Column_6_TAB5,
T6.Column_7_TAB6,
T7.Column_8_TAB7,
T8.Column_9_TAB8,
T9.Column_10_TAB9,
T10.Column_11_TAB10,
T11.Column_2_TAB1,
T12.Column_3_TAB2,
T13.Column_4_TAB3,
T14.Column_5_TAB4,
T15.Column_6_TAB5,
T16.Column_7_TAB6,
T17.Column_8_TAB7,
T18.Column_9_TAB8,
T19.Column_10_TAB9,
T20.Column_11_TAB10
from Table_1 T1
Left Outer join Table_2 T2 
on T1.Column_1_TAB1 = T2.Column_1_TAB2
Left Outer join Table_3 T3 
on T2.Column_1_TAB2 = T3.Column_1_TAB3
Left Outer join Table_4 T4 
on T3.Column_1_TAB3 = T4.Column_1_TAB4
Left Outer join Table_5 T5 
on T4.Column_1_TAB4 = T5.Column_1_TAB5
Left Outer join Table_6 T6 
on T5.Column_1_TAB5 = T6.Column_1_TAB6
Left Outer join Table_7 T7 
on T6.Column_1_TAB6 = T7.Column_1_TAB7
Left Outer join Table_8 T8 
on T7.Column_1_TAB7 = T8.Column_1_TAB8
Left Outer join Table_9 T9 
on T8.Column_1_TAB8 = T9.Column_1_TAB9
Left Outer join Table_10 T10 
on T9.Column_1_TAB9 = T10.Column_1_TAB10
Left Outer join Table_11 T11
on T10.Column_1_TAB10 = T11.Column_1_TAB1
Left Outer join Table_12 T12 
on T11.Column_1_TAB1 = T12.Column_1_TAB2
Left Outer join Table_13 T13
on T12.Column_1_TAB2 = T13.Column_1_TAB3
Left Outer join Table_14 T14
on T13.Column_1_TAB3 = T14.Column_1_TAB4
Left Outer join Table_15 T15
on T14.Column_1_TAB4 = T15.Column_1_TAB5
Left Outer join Table_16 T16
on T15.Column_1_TAB5 = T16.Column_1_TAB6
Left Outer join Table_17 T17
on T16.Column_1_TAB6 = T17.Column_1_TAB7
Left Outer join Table_18 T18
on T17.Column_1_TAB7 = T18.Column_1_TAB8
Left Outer join Table_19 T19
on T18.Column_1_TAB8= T19.Column_1_TAB9
Left Outer join Table_20 T20
on T19.Column_1_TAB9 = T20.Column_1_TAB10;";
        #endregion
        #region 40table
        public static string OuterJoin40Table = @"select T1.Column_1_TAB1 as ID,
T1.Column_2_TAB1 as T1C2, 
T2.Column_3_TAB2 as T2C3,
T3.Column_4_TAB3 as T3C4,
T4.Column_5_TAB4 as T4C5,
T5.Column_6_TAB5 as T5C6,
T6.Column_7_TAB6 as T6C7,
T7.Column_8_TAB7 as T7C8,
T8.Column_9_TAB8 as T8C9,
T9.Column_10_TAB9 as T9C10,
T10.Column_11_TAB10 as T10C11,
T11.Column_2_TAB1 as T11C2,
T12.Column_3_TAB2 as T12C3,
T13.Column_4_TAB3 as T13C4,
T14.Column_5_TAB4 AS T14C5,
T15.Column_6_TAB5 AS T15C6,
T16.Column_7_TAB6 AS T16C7,
T17.Column_8_TAB7 AS T17C8,
T18.Column_9_TAB8 AS T18C9,
T19.Column_10_TAB9 AS T19C10,
T20.Column_11_TAB10 AS T20C11,
T21.Column_2_TAB1 as T21C2, 
T22.Column_3_TAB2 as T22C3,
T23.Column_4_TAB3 as T23C4,
T24.Column_5_TAB4 as T24C5,
T25.Column_6_TAB5 as T25C6,
T26.Column_7_TAB6 as T26C7,
T27.Column_8_TAB7 as T27C8,
T28.Column_9_TAB8 as T28C9,
T29.Column_10_TAB9 as T29C10,
T30.Column_11_TAB10 as T30C11,
T31.Column_2_TAB1 as T31C2, 
T32.Column_3_TAB2 as T32C3,
T33.Column_4_TAB3 as T33C4,
T34.Column_5_TAB4 as T34C5,
T35.Column_6_TAB5 as T35C6,
T36.Column_7_TAB6 as T36C7,
T37.Column_8_TAB7 as T37C8,
T38.Column_9_TAB8 as T38C9,
T39.Column_10_TAB9 as T39C10,
T40.Column_11_TAB10 as T40C11
from Table_1 T1
Left Outer join Table_2 T2 
on T1.Column_1_TAB1 = T2.Column_1_TAB2
Left Outer join Table_3 T3 
on T2.Column_1_TAB2 = T3.Column_1_TAB3
Left Outer join Table_4 T4 
on T3.Column_1_TAB3 = T4.Column_1_TAB4
Left Outer join Table_5 T5 
on T4.Column_1_TAB4 = T5.Column_1_TAB5
Left Outer join Table_6 T6 
on T5.Column_1_TAB5 = T6.Column_1_TAB6
Left Outer join Table_7 T7 
on T6.Column_1_TAB6 = T7.Column_1_TAB7
Left Outer join Table_8 T8 
on T7.Column_1_TAB7 = T8.Column_1_TAB8
Left Outer join Table_9 T9 
on T8.Column_1_TAB8 = T9.Column_1_TAB9
Left Outer join Table_10 T10 
on T9.Column_1_TAB9 = T10.Column_1_TAB10
Left Outer join Table_11 T11
on T10.Column_1_TAB10 = T11.Column_1_TAB1
Left Outer join Table_12 T12 
on T11.Column_1_TAB1 = T12.Column_1_TAB2
Left Outer join Table_13 T13
on T12.Column_1_TAB2 = T13.Column_1_TAB3
Left Outer join Table_14 T14
on T13.Column_1_TAB3 = T14.Column_1_TAB4
Left Outer join Table_15 T15
on T14.Column_1_TAB4 = T15.Column_1_TAB5
Left Outer join Table_16 T16
on T15.Column_1_TAB5 = T16.Column_1_TAB6
Left Outer join Table_17 T17
on T16.Column_1_TAB6 = T17.Column_1_TAB7
Left Outer join Table_18 T18
on T17.Column_1_TAB7 = T18.Column_1_TAB8
Left Outer join Table_19 T19
on T18.Column_1_TAB8= T19.Column_1_TAB9
Left Outer join Table_20 T20
on T19.Column_1_TAB9 = T20.Column_1_TAB10
Left Outer join Table_21 T21
on T20.Column_1_TAB10 = T21.Column_1_TAB1
Left Outer join Table_22 T22
on T21.Column_1_TAB1 = T22.Column_1_TAB2
Left Outer join Table_23 T23
on T22.Column_1_TAB2 = T23.Column_1_TAB3
Left Outer join Table_24 T24
on T23.Column_1_TAB3 = T24.Column_1_TAB4
Left Outer join Table_25 T25
on T24.Column_1_TAB4 = T25.Column_1_TAB5
Left Outer join Table_26 T26
on T25.Column_1_TAB5 = T26.Column_1_TAB6
Left Outer join Table_27 T27
on T26.Column_1_TAB6 = T27.Column_1_TAB7
Left Outer join Table_28 T28
on T27.Column_1_TAB7 = T28.Column_1_TAB8
Left Outer join Table_29 T29
on T28.Column_1_TAB8 = T29.Column_1_TAB9
Left Outer join Table_30 T30
on T29.Column_1_TAB9 = T30.Column_1_TAB10
Left Outer join Table_31 T31
on T30.Column_1_TAB10 = T31.Column_1_TAB1
Left Outer join Table_32 T32
on T31.Column_1_TAB1 = T32.Column_1_TAB2
Left Outer join Table_33 T33
on T32.Column_1_TAB2 = T33.Column_1_TAB3
Left Outer join Table_34 T34
on T33.Column_1_TAB3 = T34.Column_1_TAB4
Left Outer join Table_35 T35
on T34.Column_1_TAB4 = T35.Column_1_TAB5
Left Outer join Table_36 T36
on T35.Column_1_TAB5 = T36.Column_1_TAB6
Left Outer join Table_37 T37
on T36.Column_1_TAB6 = T37.Column_1_TAB7
Left Outer join Table_38 T38
on T37.Column_1_TAB7 = T38.Column_1_TAB8
Left Outer join Table_39 T39
on T38.Column_1_TAB8 = T39.Column_1_TAB9
Left Outer join Table_40 T40
on T39.Column_1_TAB9 = T40.Column_1_TAB10";
        #endregion
        #region 80table
        public static string OuterJoin80Table = @"select T1.Column_1_TAB1 as ID,
T1.Column_2_TAB1 as T1C2, 
T2.Column_3_TAB2 as T2C3,
T3.Column_4_TAB3 as T3C4,
T4.Column_5_TAB4 as T4C5,
T5.Column_6_TAB5 as T5C6,
T6.Column_7_TAB6 as T6C7,
T7.Column_8_TAB7 as T7C8,
T8.Column_9_TAB8 as T8C9,
T9.Column_10_TAB9 as T9C10,
T10.Column_11_TAB10 as T10C11,
T11.Column_2_TAB1 as T11C2,
T12.Column_3_TAB2 as T12C3,
T13.Column_4_TAB3 as T13C4,
T14.Column_5_TAB4 AS T14C5,
T15.Column_6_TAB5 AS T15C6,
T16.Column_7_TAB6 AS T16C7,
T17.Column_8_TAB7 AS T17C8,
T18.Column_9_TAB8 AS T18C9,
T19.Column_10_TAB9 AS T19C10,
T20.Column_11_TAB10 AS T20C11,
T21.Column_2_TAB1 as T21C2, 
T22.Column_3_TAB2 as T22C3,
T23.Column_4_TAB3 as T23C4,
T24.Column_5_TAB4 as T24C5,
T25.Column_6_TAB5 as T25C6,
T26.Column_7_TAB6 as T26C7,
T27.Column_8_TAB7 as T27C8,
T28.Column_9_TAB8 as T28C9,
T29.Column_10_TAB9 as T29C10,
T30.Column_11_TAB10 as T30C11,
T31.Column_2_TAB1 as T31C2, 
T32.Column_3_TAB2 as T32C3,
T33.Column_4_TAB3 as T33C4,
T34.Column_5_TAB4 as T34C5,
T35.Column_6_TAB5 as T35C6,
T36.Column_7_TAB6 as T36C7,
T37.Column_8_TAB7 as T37C8,
T38.Column_9_TAB8 as T38C9,
T39.Column_10_TAB9 as T39C10,
T40.Column_11_TAB10 as T40C11,
T41.Column_2_TAB1 as T41C2, 
T42.Column_3_TAB2 as T42C3,
T43.Column_4_TAB3 as T43C4,
T44.Column_5_TAB4 as T44C5,
T45.Column_6_TAB5 as T45C6,
T46.Column_7_TAB6 as T46C7,
T47.Column_8_TAB7 as T47C8,
T48.Column_9_TAB8 as T48C9,
T49.Column_10_TAB9 as T49C10,
T50.Column_11_TAB10 as T50C11,
T51.Column_2_TAB1 as T51C2, 
T52.Column_3_TAB2 as T52C3,
T53.Column_4_TAB3 as T53C4,
T54.Column_5_TAB4 as T54C5,
T55.Column_6_TAB5 as T55C6,
T56.Column_7_TAB6 as T56C7,
T57.Column_8_TAB7 as T57C8,
T58.Column_9_TAB8 as T58C9,
T59.Column_10_TAB9 as T59C10,
T60.Column_11_TAB10 as T60C11
from Table_1 T1
Left Outer join Table_2 T2 
on T1.Column_1_TAB1 = T2.Column_1_TAB2
Left Outer join Table_3 T3 
on T2.Column_1_TAB2 = T3.Column_1_TAB3
Left Outer join Table_4 T4 
on T3.Column_1_TAB3 = T4.Column_1_TAB4
Left Outer join Table_5 T5 
on T4.Column_1_TAB4 = T5.Column_1_TAB5
Left Outer join Table_6 T6 
on T5.Column_1_TAB5 = T6.Column_1_TAB6
Left Outer join Table_7 T7 
on T6.Column_1_TAB6 = T7.Column_1_TAB7
Left Outer join Table_8 T8 
on T7.Column_1_TAB7 = T8.Column_1_TAB8
Left Outer join Table_9 T9 
on T8.Column_1_TAB8 = T9.Column_1_TAB9
Left Outer join Table_10 T10 
on T9.Column_1_TAB9 = T10.Column_1_TAB10
Left Outer join Table_11 T11
on T10.Column_1_TAB10 = T11.Column_1_TAB1
Left Outer join Table_12 T12 
on T11.Column_1_TAB1 = T12.Column_1_TAB2
Left Outer join Table_13 T13
on T12.Column_1_TAB2 = T13.Column_1_TAB3
Left Outer join Table_14 T14
on T13.Column_1_TAB3 = T14.Column_1_TAB4
Left Outer join Table_15 T15
on T14.Column_1_TAB4 = T15.Column_1_TAB5
Left Outer join Table_16 T16
on T15.Column_1_TAB5 = T16.Column_1_TAB6
Left Outer join Table_17 T17
on T16.Column_1_TAB6 = T17.Column_1_TAB7
Left Outer join Table_18 T18
on T17.Column_1_TAB7 = T18.Column_1_TAB8
Left Outer join Table_19 T19
on T18.Column_1_TAB8= T19.Column_1_TAB9
Left Outer join Table_20 T20
on T19.Column_1_TAB9 = T20.Column_1_TAB10
Left Outer join Table_21 T21
on T20.Column_1_TAB10 = T21.Column_1_TAB1
Left Outer join Table_22 T22
on T21.Column_1_TAB1 = T22.Column_1_TAB2
Left Outer join Table_23 T23
on T22.Column_1_TAB2 = T23.Column_1_TAB3
Left Outer join Table_24 T24
on T23.Column_1_TAB3 = T24.Column_1_TAB4
Left Outer join Table_25 T25
on T24.Column_1_TAB4 = T25.Column_1_TAB5
Left Outer join Table_26 T26
on T25.Column_1_TAB5 = T26.Column_1_TAB6
Left Outer join Table_27 T27
on T26.Column_1_TAB6 = T27.Column_1_TAB7
Left Outer join Table_28 T28
on T27.Column_1_TAB7 = T28.Column_1_TAB8
Left Outer join Table_29 T29
on T28.Column_1_TAB8 = T29.Column_1_TAB9
Left Outer join Table_30 T30
on T29.Column_1_TAB9 = T30.Column_1_TAB10
Left Outer join Table_31 T31
on T30.Column_1_TAB10 = T31.Column_1_TAB1
Left Outer join Table_32 T32
on T31.Column_1_TAB1 = T32.Column_1_TAB2
Left Outer join Table_33 T33
on T32.Column_1_TAB2 = T33.Column_1_TAB3
Left Outer join Table_34 T34
on T33.Column_1_TAB3 = T34.Column_1_TAB4
Left Outer join Table_35 T35
on T34.Column_1_TAB4 = T35.Column_1_TAB5
Left Outer join Table_36 T36
on T35.Column_1_TAB5 = T36.Column_1_TAB6
Left Outer join Table_37 T37
on T36.Column_1_TAB6 = T37.Column_1_TAB7
Left Outer join Table_38 T38
on T37.Column_1_TAB7 = T38.Column_1_TAB8
Left Outer join Table_39 T39
on T38.Column_1_TAB8 = T39.Column_1_TAB9
Left Outer join Table_40 T40
on T39.Column_1_TAB9 = T40.Column_1_TAB10
Left Outer join  Table_41 T41
on T40.Column_1_TAB10 = T41.Column_1_TAB1
Left Outer join Table_42 T42 
on T41.Column_1_TAB1 = T42.Column_1_TAB2
Left Outer join Table_43 T43 
on T42.Column_1_TAB2 = T43.Column_1_TAB3
Left Outer join Table_44 T44 
on T43.Column_1_TAB3 = T44.Column_1_TAB4
Left Outer join Table_45 T45 
on T44.Column_1_TAB4 = T45.Column_1_TAB5
Left Outer join Table_46 T46 
on T45.Column_1_TAB5 = T46.Column_1_TAB6
Left Outer join Table_47 T47 
on T46.Column_1_TAB6 = T47.Column_1_TAB7
Left Outer join Table_48 T48 
on T47.Column_1_TAB7 = T48.Column_1_TAB8
Left Outer join Table_9 T49 
on T48.Column_1_TAB8 = T49.Column_1_TAB9
Left Outer join Table_50 T50 
on T49.Column_1_TAB9 = T50.Column_1_TAB10
Left Outer join  Table_51 T51
on T50.Column_1_TAB10 = T51.Column_1_TAB1
Left Outer join Table_52 T52 
on T51.Column_1_TAB1 = T52.Column_1_TAB2
Left Outer join Table_53 T53 
on T52.Column_1_TAB2 = T53.Column_1_TAB3
Left Outer join Table_54 T54 
on T53.Column_1_TAB3 = T54.Column_1_TAB4
Left Outer join Table_55 T55 
on T54.Column_1_TAB4 = T55.Column_1_TAB5
Left Outer join Table_56 T56 
on T55.Column_1_TAB5 = T56.Column_1_TAB6
Left Outer join Table_57 T57 
on T56.Column_1_TAB6 = T57.Column_1_TAB7
Left Outer join Table_58 T58 
on T57.Column_1_TAB7 = T58.Column_1_TAB8
Left Outer join Table_59 T59 
on T58.Column_1_TAB8 = T59.Column_1_TAB9
Left Outer join Table_60 T60 
on T59.Column_1_TAB9 = T60.Column_1_TAB10
";
        #endregion
        #endregion

        #region Inner Join 
        #region 10Table
        public static string InnerJoin10Table = @"Select T1.Column_1_TAB1 as ID, T1.Column_2_TAB1 as T1C2, T1.Column_3_TAB1 as T1C3,
T2.Column_4_TAB2 as T2C4, T2.Column_5_TAB2 as T2C5, T2.Column_6_TAB2 as T2C6,
T3.Column_7_TAB3 as T3C7, T3.Column_8_TAB3 as T3C8, T3.Column_9_TAB3 as T3C9,
T4.Column_10_TAB4 as T4C10, T4.Column_11_TAB4 as T4C11, T4.Column_12_TAB4 as T4C12,
T5.Column_13_TAB5 as T5C13, T5.Column_14_TAB5 as T5C14, T5.Column_15_TAB5 as T5C15,
T6.Column_16_TAB6 as T6C16, T6.Column_17_TAB6 as T6C17, T6.Column_18_TAB6 as T6C18,
T7.Column_19_TAB7 as T7C19, T7.Column_20_TAB7 as T7C20, T7.Column_21_TAB7 as T7C21,
T8.Column_22_TAB8 as T8C22, T8.Column_23_TAB8 as T8C23, T8.Column_24_TAB8 as T8C24,
T9.Column_2_TAB9 as T9C2, T9.Column_10_TAB9 as T9C10, T9.Column_20_TAB9 as T9C20,
T10.Column_5_TAB10 as T10C5, T10.Column_10_TAB10 as T10C10, T10.Column_15_TAB10 as T10C15 
from Table_1 T1
inner join  Table_2 T2 on T1.Column_1_TAB1 = T2.Column_1_TAB2
inner join Table_3 T3 on T2.Column_1_TAB2 = T3.Column_1_TAB3
inner join Table_4 T4 on T3.Column_1_TAB3 = T4.Column_1_TAB4
inner join Table_5 T5 on T4.Column_1_TAB4 = T5.Column_1_TAB5 
inner join Table_6 T6 on T5.Column_1_TAB5 = T6.Column_1_TAB6
inner join Table_7 T7 on T6.Column_1_TAB6 = T7.Column_1_TAB7 
inner join Table_8 T8 on T7.Column_1_TAB7 = T8.Column_1_TAB8
inner join Table_9 T9 on T8.Column_1_TAB8 = T9.Column_1_TAB9
inner join Table_10 T10 on T9.Column_1_TAB9 = T10.Column_1_TAB10";
        #endregion
        #region 20Table
        public static string InnerJoin20Table = @"Select T1.Column_1_TAB1 as ID, T1.Column_2_TAB1 as T1C2, T1.Column_3_TAB1 as T1C3,
T2.Column_4_TAB2 as T2C4, T2.Column_5_TAB2 as T2C5, T2.Column_6_TAB2 as T2C6,
T3.Column_7_TAB3 as T3C7, T3.Column_8_TAB3 as T3C8, T3.Column_9_TAB3 as T3C9,
T4.Column_10_TAB4 as T4C10, T4.Column_11_TAB4 as T4C11, T4.Column_12_TAB4 as T4C12,
T5.Column_13_TAB5 as T5C13, T5.Column_14_TAB5 as T5C14, T5.Column_15_TAB5 as T5C15,
T6.Column_16_TAB6 as T6C16, T6.Column_17_TAB6 as T6C17, T6.Column_18_TAB6 as T6C18,
T7.Column_19_TAB7 as T7C19, T7.Column_20_TAB7 as T7C20, T7.Column_21_TAB7 as T7C21,
T8.Column_22_TAB8 as T8C22, T8.Column_23_TAB8 as T8C23, T8.Column_24_TAB8 as T8C24,
T9.Column_2_TAB9 as T9C2, T9.Column_10_TAB9 as T9C10, T9.Column_20_TAB9 as T9C20,
T10.Column_5_TAB10 as T10C5, T10.Column_10_TAB10 as T10C15, T10.Column_15_TAB10 as T10C10, 
T11.Column_10_TAB1 as T11C10, T11.Column_2_TAB1 as T11C2, T11.Column_3_TAB1 as T11C3,
T12.Column_4_TAB2 as T12C4, T12.Column_5_TAB2 as T12C5, T12.Column_6_TAB2 as T12C6,
T13.Column_7_TAB3 as T13C7, T13.Column_8_TAB3 as T13C8, T13.Column_9_TAB3 as T13C9,
T14.Column_10_TAB4 as T14C10, T14.Column_11_TAB4 as T14C11, T14.Column_12_TAB4 as T14C12,
T15.Column_13_TAB5 as T15C13, T15.Column_14_TAB5 as T15C14, T15.Column_15_TAB5 as T15C15,
T16.Column_16_TAB6 as T16C16, T16.Column_17_TAB6 as T16C17, T16.Column_18_TAB6 as T16C18,
T17.Column_19_TAB7 as T17C19, T17.Column_20_TAB7 as T17C20, T17.Column_21_TAB7 as T17C21,
T18.Column_22_TAB8 as T18C22, T18.Column_23_TAB8 as T18C23, T18.Column_24_TAB8 as T18C24,
T19.Column_2_TAB9 as T19C2, T19.Column_10_TAB9 as T19C10, T19.Column_20_TAB9 as T19C20,
T20.Column_5_TAB10 as T20C5, T20.Column_10_TAB10 as T20C10, T20.Column_15_TAB10 as T20C15 
from Table_1 T1
inner join  Table_2 T2 on T1.Column_1_TAB1 = T2.Column_1_TAB2
inner join Table_3 T3 on T2.Column_1_TAB2 = T3.Column_1_TAB3
inner join Table_4 T4 on T3.Column_1_TAB3 = T4.Column_1_TAB4
inner join Table_5 T5 on T4.Column_1_TAB4 = T5.Column_1_TAB5 
inner join Table_6 T6 on T5.Column_1_TAB5 = T6.Column_1_TAB6
inner join Table_7 T7 on T6.Column_1_TAB6 = T7.Column_1_TAB7 
inner join Table_8 T8 on T7.Column_1_TAB7 = T8.Column_1_TAB8
inner join Table_9 T9 on T8.Column_1_TAB8 = T9.Column_1_TAB9
inner join Table_10 T10 on T9.Column_1_TAB9 = T10.Column_1_TAB10
inner join Table_11 T11 on T10.Column_1_TAB10 = T11.Column_1_TAB1
inner join Table_12 T12 on T11.Column_1_TAB1 = T12.Column_1_TAB2
inner join Table_13 T13 on T12.Column_1_TAB2 = T13.Column_1_TAB3
inner join Table_14 T14 on T13.Column_1_TAB3 = T14.Column_1_TAB4
inner join Table_15 T15 on T14.Column_1_TAB4 = T15.Column_1_TAB5 
inner join Table_16 T16 on T15.Column_1_TAB5 = T16.Column_1_TAB6
inner join Table_17 T17 on T16.Column_1_TAB6 = T17.Column_1_TAB7 
inner join Table_18 T18 on T17.Column_1_TAB7 = T18.Column_1_TAB8 
inner join Table_19 T19 on T18.Column_1_TAB8 = T19.Column_1_TAB9
inner join Table_20 T20 on T19.Column_1_TAB9 = T20.Column_1_TAB10";
        #endregion
        #endregion

        #region Update tables
        #region 10ColumnTable
        public static string Column10TableUpdate(string tableName)
        {
            string query = @"Update " + tableName + " set Column_2_TAB1 = @Update, Column_3_TAB1 = @Update, Column_4_TAB1 = @Update, Column_5_TAB1= @Update, Column_6_TAB1= @Update, Column_7_TAB1= @Update, Column_8_TAB1= @Update, Column_9_TAB1= @Update, Column_10_TAB1= @Update where Column_1_TAB1 = @ColumnNumber";
            return query;
        }

        public static string Column15With2TableUpdate(string tableName)
        {
            string query = @"Update " + tableName +
                " set Column_2_TAB2 = @Update, Column_3_TAB2 = @Update, Column_4_TAB2 = @Update, Column_5_TAB2= @Update, Column_6_TAB2= @Update, Column_7_TAB2= @Update, Column_8_TAB2= @Update, Column_9_TAB2= @Update, Column_10_TAB2= @Update " +
" where Column_1_TAB2 = @ColumnNumber";
            return query;
        }

        public static string Column15With10TableUpdate(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB10 = @Update, Column_3_TAB10 = @Update, Column_4_TAB10 = @Update, Column_5_TAB10= @Update, Column_6_TAB10= @Update, Column_7_TAB10= @Update, Column_8_TAB10= @Update, Column_9_TAB10= @Update, Column_10_TAB10= @Update " +
"where Column_1_TAB10 = @ColumnNumber";
            return query;
        }

        public static string Column20With3TableUpdate(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB3 = @Update, Column_3_TAB3 = @Update, Column_4_TAB3 = @Update, Column_5_TAB3= @Update, Column_6_TAB3= @Update, Column_7_TAB3= @Update, Column_8_TAB3= @Update, Column_9_TAB3= @Update, Column_10_TAB3= @Update " +
" where Column_1_TAB3 = @ColumnNumber";
            return query;
        }

        public static string Column20With9TableUpdate(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB9 = @Update, Column_3_TAB9 = @Update, Column_4_TAB9 = @Update, Column_5_TAB9= @Update, Column_6_TAB9= @Update, Column_7_TAB9= @Update, Column_8_TAB9= @Update, Column_9_TAB9= @Update, Column_10_TAB9= @Update " +
 "where Column_1_TAB9 = @ColumnNumber";
            return query;
        }

        public static string Column25With4TableUpdate(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB4 = @Update, Column_3_TAB4 = @Update, Column_4_TAB4 = @Update, Column_5_TAB4= @Update, Column_6_TAB4= @Update, Column_7_TAB4= @Update, Column_8_TAB4= @Update, Column_9_TAB4= @Update, Column_10_TAB4= @Update " +
    "where Column_1_TAB4 = @ColumnNumber";
            return query;
        }

        public static string Column25With8TableUpdate(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB8 = @Update, Column_3_TAB8 = @Update, Column_4_TAB8 = @Update, Column_5_TAB8= @Update, Column_6_TAB8= @Update, Column_7_TAB8= @Update, Column_8_TAB8= @Update, Column_9_TAB8= @Update, Column_10_TAB8= @Update " +
    "where Column_1_TAB8 = @ColumnNumber";
            return query;
        }

        public static string Column30With5TableUpdate(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB5 = @Update, Column_3_TAB5 = @Update, Column_4_TAB5 = @Update, Column_5_TAB5= @Update, Column_6_TAB5= @Update, Column_7_TAB5= @Update, Column_8_TAB5= @Update, Column_9_TAB5= @Update, Column_10_TAB5= @Update " +
    "where Column_1_TAB5 = @ColumnNumber";
            return query;
        }

        public static string Column30With7TableUpdate(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB7 = @Update, Column_3_TAB7 = @Update, Column_4_TAB7 = @Update, Column_5_TAB7= @Update, Column_6_TAB7= @Update, Column_7_TAB7= @Update, Column_8_TAB7= @Update, Column_9_TAB7= @Update, Column_10_TAB7= @Update " +
    "where Column_1_TAB7 = @ColumnNumber";
            return query;
        }

        public static string Column35With6TableUpdate(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB6 = @Update, Column_3_TAB6 = @Update, Column_4_TAB6 = @Update, Column_5_TAB6= @Update, Column_6_TAB6= @Update, Column_7_TAB6= @Update, Column_8_TAB6= @Update, Column_9_TAB6= @Update, Column_10_TAB6= @Update " +
    "where Column_1_TAB6 = @ColumnNumber";
            return query;
        }
        #endregion

        #region OracleUpdateVersion 
        public static string Column10TableUpdateOracle(string tableName)
        {
            string query = @"Update " + tableName + " set Column_2_TAB1 = :UpdValue, Column_3_TAB1 = :UpdValue, Column_4_TAB1 = :UpdValue, Column_5_TAB1= :UpdValue, Column_6_TAB1= :UpdValue, Column_7_TAB1= :UpdValue, Column_8_TAB1= :UpdValue, Column_9_TAB1= :UpdValue, Column_10_TAB1= :UpdValue where Column_1_TAB1 = :ColumnNumber";
            return query;
        }

        public static string Column15With2TableUpdateOracle(string tableName)
        {
            string query = @"Update " + tableName +
                " set Column_2_TAB2 = :UpdValue, Column_3_TAB2 = :UpdValue, Column_4_TAB2 = :UpdValue, Column_5_TAB2= :UpdValue, Column_6_TAB2= :UpdValue, Column_7_TAB2= :UpdValue, Column_8_TAB2= :UpdValue, Column_9_TAB2= :UpdValue, Column_10_TAB2= :UpdValue " +
" where Column_1_TAB2 = :ColumnNumber";
            return query;
        }

        public static string Column15With10TableUpdateOracle(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB10 = :UpdValue, Column_3_TAB10 = :UpdValue, Column_4_TAB10 = :UpdValue, Column_5_TAB10= :UpdValue, Column_6_TAB10= :UpdValue, Column_7_TAB10= :UpdValue, Column_8_TAB10= :UpdValue, Column_9_TAB10= :UpdValue, Column_10_TAB10= :UpdValue " +
"where Column_1_TAB10 = :ColumnNumber";
            return query;
        }

        public static string Column20With3TableUpdateOracle(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB3 = :UpdValue, Column_3_TAB3 = :UpdValue, Column_4_TAB3 = :UpdValue, Column_5_TAB3= :UpdValue, Column_6_TAB3= :UpdValue, Column_7_TAB3= :UpdValue, Column_8_TAB3= :UpdValue, Column_9_TAB3= :UpdValue, Column_10_TAB3= :UpdValue " +
" where Column_1_TAB3 = :ColumnNumber";
            return query;
        }

        public static string Column20With9TableUpdateOracle(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB9 = :UpdValue, Column_3_TAB9 = :UpdValue, Column_4_TAB9 = :UpdValue, Column_5_TAB9= :UpdValue, Column_6_TAB9= :UpdValue, Column_7_TAB9= :UpdValue, Column_8_TAB9= :UpdValue, Column_9_TAB9= :UpdValue, Column_10_TAB9= :UpdValue " +
 "where Column_1_TAB9 = :ColumnNumber";
            return query;
        }

        public static string Column25With4TableUpdateOracle(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB4 = :UpdValue, Column_3_TAB4 = :UpdValue, Column_4_TAB4 = :UpdValue, Column_5_TAB4= :UpdValue, Column_6_TAB4= :UpdValue, Column_7_TAB4= :UpdValue, Column_8_TAB4= :UpdValue, Column_9_TAB4= :UpdValue, Column_10_TAB4= :UpdValue " +
    "where Column_1_TAB4 = :ColumnNumber";
            return query;
        }

        public static string Column25With8TableUpdateOracle(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB8 = :UpdValue, Column_3_TAB8 = :UpdValue, Column_4_TAB8 = :UpdValue, Column_5_TAB8= :UpdValue, Column_6_TAB8= :UpdValue, Column_7_TAB8= :UpdValue, Column_8_TAB8= :UpdValue, Column_9_TAB8= :UpdValue, Column_10_TAB8= :UpdValue " +
    "where Column_1_TAB8 = :ColumnNumber";
            return query;
        }

        public static string Column30With5TableUpdateOracle(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB5 = :UpdValue, Column_3_TAB5 = :UpdValue, Column_4_TAB5 = :UpdValue, Column_5_TAB5= :UpdValue, Column_6_TAB5= :UpdValue, Column_7_TAB5= :UpdValue, Column_8_TAB5= :UpdValue, Column_9_TAB5= :UpdValue, Column_10_TAB5= :UpdValue " +
    "where Column_1_TAB5 = :ColumnNumber";
            return query;
        }

        public static string Column30With7TableUpdateOracle(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB7 = :UpdValue, Column_3_TAB7 = :UpdValue, Column_4_TAB7 = :UpdValue, Column_5_TAB7= :UpdValue, Column_6_TAB7= :UpdValue, Column_7_TAB7= :UpdValue, Column_8_TAB7= :UpdValue, Column_9_TAB7= :UpdValue, Column_10_TAB7= :UpdValue " +
    "where Column_1_TAB7 = :ColumnNumber";
            return query;
        }

        public static string Column35With6TableUpdateOracle(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB6 = :UpdValue, Column_3_TAB6 = :UpdValue, Column_4_TAB6 = :UpdValue, Column_5_TAB6= :UpdValue, Column_6_TAB6= :UpdValue, Column_7_TAB6= :UpdValue, Column_8_TAB6= :UpdValue, Column_9_TAB6= :UpdValue, Column_10_TAB6= :UpdValue " +
    "where Column_1_TAB6 = :ColumnNumber";
            return query;
        }
        #endregion

        #endregion

        #region select by rows oracle
        public static string SelectByRecordFromTable1(string tableName, int record) { string query = @"Select * from " + tableName + " where Column_1_TAB1 = " + record + ""; return query; }
        public static string SelectByRecordFromTable2(string tableName, int record) { string query = @"Select * from " + tableName + " where Column_1_TAB2 = " + record + ""; return query; }
        public static string SelectByRecordFromTable3(string tableName, int record) { string query = @"Select * from " + tableName + " where Column_1_TAB3 = " + record + ""; return query; }
        public static string SelectByRecordFromTable4(string tableName, int record) { string query = @"Select * from " + tableName + " where Column_1_TAB4 = " + record + ""; return query; }
        public static string SelectByRecordFromTable5(string tableName, int record) { string query = @"Select * from " + tableName + " where Column_1_TAB5 = " + record + ""; return query; }
        public static string SelectByRecordFromTable6(string tableName, int record) { string query = @"Select * from " + tableName + " where Column_1_TAB6 = " + record + ""; return query; }
        public static string SelectByRecordFromTable7(string tableName, int record) { string query = @"Select * from " + tableName + " where Column_1_TAB7 = " + record + ""; return query; }
        public static string SelectByRecordFromTable8(string tableName, int record) { string query = @"Select * from " + tableName + " where Column_1_TAB8 = " + record + ""; return query; }
        public static string SelectByRecordFromTable9(string tableName, int record) { string query = @"Select * from " + tableName + " where Column_1_TAB9 = " + record + ""; return query; }
        public static string SelectByRecordFromTable10(string tableName, int record) { string query = @"Select * from " + tableName + " where Column_1_TAB10 = " + record + ""; return query; }

        #endregion

        #region PostgresUpdateVersion 
        public static string Column10TableUpdatePostgres(string tableName)
        {
            string query = @"Update " + tableName + " set Column_2_TAB1 = @UpdValue, Column_3_TAB1 = @UpdValue, Column_4_TAB1 = @UpdValue, Column_5_TAB1= @UpdValue, Column_6_TAB1= @UpdValue, Column_7_TAB1= @UpdValue, Column_8_TAB1= @UpdValue, Column_9_TAB1= @UpdValue, Column_10_TAB1= @UpdValue where Column_1_TAB1 = @ColumnNumber";
            return query;
        }

        public static string Column15With2TableUpdatePostgres(string tableName)
        {
            string query = @"Update " + tableName +
                " set Column_2_TAB2 = @UpdValue, Column_3_TAB2 = @UpdValue, Column_4_TAB2 = @UpdValue, Column_5_TAB2= @UpdValue, Column_6_TAB2= @UpdValue, Column_7_TAB2= @UpdValue, Column_8_TAB2= @UpdValue, Column_9_TAB2= @UpdValue, Column_10_TAB2= @UpdValue " +
" where Column_1_TAB2 = @ColumnNumber";
            return query;
        }

        public static string Column15With10TableUpdatePostgres(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB10 = @UpdValue, Column_3_TAB10 = @UpdValue, Column_4_TAB10 = @UpdValue, Column_5_TAB10= @UpdValue, Column_6_TAB10= @UpdValue, Column_7_TAB10= @UpdValue, Column_8_TAB10= @UpdValue, Column_9_TAB10= @UpdValue, Column_10_TAB10= @UpdValue " +
"where Column_1_TAB10 = @ColumnNumber";
            return query;
        }

        public static string Column20With3TableUpdatePostgres(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB3 = @UpdValue, Column_3_TAB3 = @UpdValue, Column_4_TAB3 = @UpdValue, Column_5_TAB3= @UpdValue, Column_6_TAB3= @UpdValue, Column_7_TAB3= @UpdValue, Column_8_TAB3= @UpdValue, Column_9_TAB3= @UpdValue, Column_10_TAB3= @UpdValue " +
" where Column_1_TAB3 = @ColumnNumber";
            return query;
        }

        public static string Column20With9TableUpdatePostgres(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB9 = @UpdValue, Column_3_TAB9 = @UpdValue, Column_4_TAB9 = @UpdValue, Column_5_TAB9= @UpdValue, Column_6_TAB9= @UpdValue, Column_7_TAB9= @UpdValue, Column_8_TAB9= @UpdValue, Column_9_TAB9= @UpdValue, Column_10_TAB9= @UpdValue " +
 "where Column_1_TAB9 = @ColumnNumber";
            return query;
        }

        public static string Column25With4TableUpdatePostgres(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB4 = @UpdValue, Column_3_TAB4 = @UpdValue, Column_4_TAB4 = @UpdValue, Column_5_TAB4= @UpdValue, Column_6_TAB4= @UpdValue, Column_7_TAB4= @UpdValue, Column_8_TAB4= @UpdValue, Column_9_TAB4= @UpdValue, Column_10_TAB4= @UpdValue " +
    "where Column_1_TAB4 = @ColumnNumber";
            return query;
        }

        public static string Column25With8TableUpdatePostgres(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB8 = @UpdValue, Column_3_TAB8 = @UpdValue, Column_4_TAB8 = @UpdValue, Column_5_TAB8= @UpdValue, Column_6_TAB8= @UpdValue, Column_7_TAB8= @UpdValue, Column_8_TAB8= @UpdValue, Column_9_TAB8= @UpdValue, Column_10_TAB8= @UpdValue " +
    "where Column_1_TAB8 = @ColumnNumber";
            return query;
        }

        public static string Column30With5TableUpdatePostgres(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB5 = @UpdValue, Column_3_TAB5 = @UpdValue, Column_4_TAB5 = @UpdValue, Column_5_TAB5= @UpdValue, Column_6_TAB5= @UpdValue, Column_7_TAB5= @UpdValue, Column_8_TAB5= @UpdValue, Column_9_TAB5= @UpdValue, Column_10_TAB5= @UpdValue " +
    "where Column_1_TAB5 = @ColumnNumber";
            return query;
        }

        public static string Column30With7TableUpdatePostgres(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB7 = @UpdValue, Column_3_TAB7 = @UpdValue, Column_4_TAB7 = @UpdValue, Column_5_TAB7= @UpdValue, Column_6_TAB7= @UpdValue, Column_7_TAB7= @UpdValue, Column_8_TAB7= @UpdValue, Column_9_TAB7= @UpdValue, Column_10_TAB7= @UpdValue " +
    "where Column_1_TAB7 = @ColumnNumber";
            return query;
        }

        public static string Column35With6TableUpdatePostgres(string tableName)
        {
            string query = @"Update " + tableName +
    " set Column_2_TAB6 = @UpdValue, Column_3_TAB6 = @UpdValue, Column_4_TAB6 = @UpdValue, Column_5_TAB6= @UpdValue, Column_6_TAB6= @UpdValue, Column_7_TAB6= @UpdValue, Column_8_TAB6=  @UpdValue, Column_9_TAB6=  @UpdValue, Column_10_TAB6=  @UpdValue " +
    "where Column_1_TAB6 = @ColumnNumber";
            return query;
        }
        #endregion
        #region sqldelete
        public static string DeleteFromTableByREcord1(string tableName)
        {
            string query = @"delete from " + tableName + " where Column_1_TAB1 = @ColumnNumber";
            return query; 
        }
        public static string DeleteFromTableByREcord2(string tableName)
        {
            string query = @"delete from " + tableName + " where Column_1_TAB2 = @ColumnNumber";
            return query;
        }
        public static string DeleteFromTableByREcord3(string tableName)
        {
            string query = @"delete from " + tableName + " where Column_1_TAB3 = @ColumnNumber";
            return query;
        }
        public static string DeleteFromTableByREcord4(string tableName)
        {
            string query = @"delete from " + tableName + " where Column_1_TAB4 = @ColumnNumber";
            return query;
        }
        public static string DeleteFromTableByREcord5(string tableName)
        {
            string query = @"delete from " + tableName + " where Column_1_TAB5 = @ColumnNumber";
            return query;
        }
        public static string DeleteFromTableByREcord6(string tableName)
        {
            string query = @"delete from " + tableName + " where Column_1_TAB6 = @ColumnNumber";
            return query;
        }
        public static string DeleteFromTableByREcord7(string tableName)
        {
            string query = @"delete from " + tableName + " where Column_1_TAB7 = @ColumnNumber";
            return query;
        }
        public static string DeleteFromTableByREcord8(string tableName)
        {
            string query = @"delete from " + tableName + " where Column_1_TAB8 = @ColumnNumber";
            return query;
        }
        public static string DeleteFromTableByREcord9(string tableName)
        {
            string query = @"delete from " + tableName + " where Column_1_TAB9 = @ColumnNumber";
            return query;
        }
        public static string DeleteFromTableByREcord10(string tableName)
        {
            string query = @"delete from " + tableName + " where Column_1_TAB10 = @ColumnNumber";
            return query;
        }
        #endregion

        #region sqldelete with :
        public static string DeleteFromTableByREcordOrac1(string tableName)
        {
            string query = @"delete from " + tableName + " where Column_1_TAB1 = :ColumnNumber";
            return query;
        }
        public static string DeleteFromTableByREcordOrac2(string tableName)
        {
            string query = @"delete from " + tableName + " where Column_1_TAB2 = :ColumnNumber";
            return query;
        }
        public static string DeleteFromTableByREcordOrac3(string tableName)
        {
            string query = @"delete from " + tableName + " where Column_1_TAB3 = :ColumnNumber";
            return query;
        }
        public static string DeleteFromTableByREcordOrac4(string tableName)
        {
            string query = @"delete from " + tableName + " where Column_1_TAB4 = :ColumnNumber";
            return query;
        }
        public static string DeleteFromTableByREcordOrac5(string tableName)
        {
            string query = @"delete from " + tableName + " where Column_1_TAB5 = :ColumnNumber";
            return query;
        }
        public static string DeleteFromTableByREcordOrac6(string tableName)
        {
            string query = @"delete from " + tableName + " where Column_1_TAB6 = :ColumnNumber";
            return query;
        }
        public static string DeleteFromTableByREcordOrac7(string tableName)
        {
            string query = @"delete from " + tableName + " where Column_1_TAB7 = :ColumnNumber";
            return query;
        }
        public static string DeleteFromTableByREcordOrac8(string tableName)
        {
            string query = @"delete from " + tableName + " where Column_1_TAB8 = :ColumnNumber";
            return query;
        }
        public static string DeleteFromTableByREcordOrac9(string tableName)
        {
            string query = @"delete from " + tableName + " where Column_1_TAB9 = :ColumnNumber";
            return query;
        }
        public static string DeleteFromTableByREcordOrac10(string tableName)
        {
            string query = @"delete from " + tableName + " where Column_1_TAB10 = :ColumnNumber";
            return query;
        }
        #endregion
        #region insert query
        public static string[] insertQuery(string scriptName)
        {
            string sql = "";
            using (FileStream strm = File.OpenRead(@"F:\magisterka\C#code\magisterka\scripts\sqlserver\" + scriptName + ".sql"))
            {
                StreamReader reader = new StreamReader(strm);
                sql = reader.ReadToEnd();
            }
            Regex regex = new Regex("^GO", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            string[] query = regex.Split(sql);
                //string query = File.ReadAllText(@"F:\magisterka\C#code\magisterka\scripts\sqlserver\" + scriptName + ".sql");
                return query;
        }
        #endregion

        #region insert oracle query
        public static string[] insertOracleQuery(string scriptName)
        {
            string sql = "";
            using (FileStream strm = File.OpenRead(@"F:\magisterka\C#code\magisterka\scripts\oracle\" + scriptName + ".sql"))
            {
                StreamReader reader = new StreamReader(strm);
                sql = reader.ReadToEnd();
            }
            Regex regex = new Regex(";", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            string[] query = regex.Split(sql);
            //string query = File.ReadAllText(@"F:\magisterka\C#code\magisterka\scripts\sqlserver\" + scriptName + ".sql");
            return query;
        }
        #endregion

        #region insert query
        public static string[] insertPostggreQuery(string scriptName)
        {
            char[] charsToTrim = { '"' };
            string sql = "";
            using (FileStream strm = File.OpenRead(@"F:\magisterka\C#code\magisterka\scripts\postgres\" + scriptName + ".sql"))
            {
                StreamReader reader = new StreamReader(strm);
                sql = reader.ReadToEnd();
            }

            Regex regex = new Regex(";", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            string[] query = regex.Split(sql);
            //string query = File.ReadAllText(@"F:\magisterka\C#code\magisterka\scripts\sqlserver\" + scriptName + ".sql");
            return query;
        }
        #endregion
    }
}
