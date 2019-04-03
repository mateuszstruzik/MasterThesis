﻿using DataExtract.Models.EntityContext._80TableDB;
using DataExtract.Models.ModelsForTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.OracleDbServeTests.EntityTests._80TableDB
{
    public class OracleServerOuterJoin80TableDbENTITY
    {
        public IEnumerable<ModelFor80TableOuterJoin> GetOuterJoin()
        {
            IEnumerable<ModelFor80TableOuterJoin> result;
            using (var context = new OracleContextFor80TableDB())
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
                          join tab21c in context.Table_21 on tab20.Column_1_TAB10 equals tab21c.Column_1_TAB1 into tab21p
                          from tab21 in tab21p.DefaultIfEmpty()
                          join tab22c in context.Table_22 on tab21.Column_1_TAB1 equals tab22c.Column_1_TAB2 into tab22p
                          from tab22 in tab22p.DefaultIfEmpty()
                          join tab23c in context.Table_23 on tab22.Column_1_TAB2 equals tab23c.Column_1_TAB3 into tab23p
                          from tab23 in tab23p.DefaultIfEmpty()
                          join tab24c in context.Table_24 on tab23.Column_1_TAB3 equals tab24c.Column_1_TAB4 into tab24p
                          from tab24 in tab24p.DefaultIfEmpty()
                          join tab25c in context.Table_25 on tab24.Column_1_TAB4 equals tab25c.Column_1_TAB5 into tab25p
                          from tab25 in tab25p.DefaultIfEmpty()
                          join tab26c in context.Table_26 on tab25.Column_1_TAB5 equals tab26c.Column_1_TAB6 into tab26p
                          from tab26 in tab26p.DefaultIfEmpty()
                          join tab27c in context.Table_27 on tab26.Column_1_TAB6 equals tab27c.Column_1_TAB7 into tab27p
                          from tab27 in tab27p.DefaultIfEmpty()
                          join tab28c in context.Table_28 on tab27.Column_1_TAB7 equals tab28c.Column_1_TAB8 into tab28p
                          from tab28 in tab28p.DefaultIfEmpty()
                          join tab29c in context.Table_29 on tab28.Column_1_TAB8 equals tab29c.Column_1_TAB9 into tab29p
                          from tab29 in tab29p.DefaultIfEmpty()
                          join tab30c in context.Table_30 on tab29.Column_1_TAB9 equals tab30c.Column_1_TAB10 into tab30p
                          from tab30 in tab30p.DefaultIfEmpty()
                          join tab31c in context.Table_31 on tab30.Column_1_TAB10 equals tab31c.Column_1_TAB1 into tab31p
                          from tab31 in tab31p.DefaultIfEmpty()
                          join tab32c in context.Table_32 on tab31.Column_1_TAB1 equals tab32c.Column_1_TAB2 into tab32p
                          from tab32 in tab32p.DefaultIfEmpty()
                          join tab33c in context.Table_33 on tab32.Column_1_TAB2 equals tab33c.Column_1_TAB3 into tab33p
                          from tab33 in tab33p.DefaultIfEmpty()
                          join tab34c in context.Table_34 on tab33.Column_1_TAB3 equals tab34c.Column_1_TAB4 into tab34p
                          from tab34 in tab34p.DefaultIfEmpty()
                          join tab35c in context.Table_35 on tab34.Column_1_TAB4 equals tab35c.Column_1_TAB5 into tab35p
                          from tab35 in tab35p.DefaultIfEmpty()
                          join tab36c in context.Table_36 on tab35.Column_1_TAB5 equals tab36c.Column_1_TAB6 into tab36p
                          from tab36 in tab36p.DefaultIfEmpty()
                          join tab37c in context.Table_37 on tab36.Column_1_TAB6 equals tab37c.Column_1_TAB7 into tab37p
                          from tab37 in tab37p.DefaultIfEmpty()
                          join tab38c in context.Table_38 on tab37.Column_1_TAB7 equals tab38c.Column_1_TAB8 into tab38p
                          from tab38 in tab38p.DefaultIfEmpty()
                          join tab39c in context.Table_39 on tab38.Column_1_TAB8 equals tab39c.Column_1_TAB9 into tab39p
                          from tab39 in tab39p.DefaultIfEmpty()
                          join tab40c in context.Table_40 on tab39.Column_1_TAB9 equals tab40c.Column_1_TAB10 into tab40p
                          from tab40 in tab40p.DefaultIfEmpty()
                          join tab41c in context.Table_41 on tab40.Column_1_TAB10 equals tab41c.Column_1_TAB1 into tab41p
                          from tab41 in tab41p.DefaultIfEmpty()
                          join tab42c in context.Table_42 on tab41.Column_1_TAB1 equals tab42c.Column_1_TAB2 into tab42p
                          from tab42 in tab42p.DefaultIfEmpty()
                          join tab43c in context.Table_43 on tab42.Column_1_TAB2 equals tab43c.Column_1_TAB3 into tab43p
                          from tab43 in tab43p.DefaultIfEmpty()
                          join tab44c in context.Table_44 on tab43.Column_1_TAB3 equals tab44c.Column_1_TAB4 into tab44p
                          from tab44 in tab44p.DefaultIfEmpty()
                          join tab45c in context.Table_45 on tab44.Column_1_TAB4 equals tab45c.Column_1_TAB5 into tab45p
                          from tab45 in tab45p.DefaultIfEmpty()
                          join tab46c in context.Table_46 on tab45.Column_1_TAB5 equals tab46c.Column_1_TAB6 into tab46p
                          from tab46 in tab46p.DefaultIfEmpty()
                          join tab47c in context.Table_47 on tab46.Column_1_TAB6 equals tab47c.Column_1_TAB7 into tab47p
                          from tab47 in tab47p.DefaultIfEmpty()
                          join tab48c in context.Table_48 on tab47.Column_1_TAB7 equals tab48c.Column_1_TAB8 into tab48p
                          from tab48 in tab48p.DefaultIfEmpty()
                          join tab49c in context.Table_49 on tab48.Column_1_TAB8 equals tab49c.Column_1_TAB9 into tab49p
                          from tab49 in tab49p.DefaultIfEmpty()
                          join tab50c in context.Table_50 on tab49.Column_1_TAB9 equals tab50c.Column_1_TAB10 into tab50p
                          from tab50 in tab50p.DefaultIfEmpty()
                          join tab51c in context.Table_51 on tab40.Column_1_TAB10 equals tab51c.Column_1_TAB1 into tab51p
                          from tab51 in tab51p.DefaultIfEmpty()
                          join tab52c in context.Table_52 on tab51.Column_1_TAB1 equals tab52c.Column_1_TAB2 into tab52p
                          from tab52 in tab52p.DefaultIfEmpty()
                          join tab53c in context.Table_53 on tab52.Column_1_TAB2 equals tab53c.Column_1_TAB3 into tab53p
                          from tab53 in tab53p.DefaultIfEmpty()
                          join tab54c in context.Table_54 on tab53.Column_1_TAB3 equals tab54c.Column_1_TAB4 into tab54p
                          from tab54 in tab54p.DefaultIfEmpty()
                          join tab55c in context.Table_55 on tab54.Column_1_TAB4 equals tab55c.Column_1_TAB5 into tab55p
                          from tab55 in tab55p.DefaultIfEmpty()
                          join tab56c in context.Table_56 on tab55.Column_1_TAB5 equals tab56c.Column_1_TAB6 into tab56p
                          from tab56 in tab56p.DefaultIfEmpty()
                          join tab57c in context.Table_57 on tab46.Column_1_TAB6 equals tab57c.Column_1_TAB7 into tab57p
                          from tab57 in tab57p.DefaultIfEmpty()
                          join tab58c in context.Table_58 on tab57.Column_1_TAB7 equals tab58c.Column_1_TAB8 into tab58p
                          from tab58 in tab58p.DefaultIfEmpty()
                          join tab59c in context.Table_59 on tab58.Column_1_TAB8 equals tab59c.Column_1_TAB9 into tab59p
                          from tab59 in tab59p.DefaultIfEmpty()
                          join tab60c in context.Table_60 on tab59.Column_1_TAB9 equals tab60c.Column_1_TAB10 into tab60p
                          from tab60 in tab60p.DefaultIfEmpty()
                          select new ModelFor80TableOuterJoin
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
                              T20C11 = tab20.Column_11_TAB10,
                              T21C2 = tab21.Column_2_TAB1,
                              T22C3 = tab22.Column_3_TAB2,
                              T23C4 = tab23.Column_4_TAB3,
                              T24C5 = tab24.Column_5_TAB4,
                              T25C6 = tab25.Column_6_TAB5,
                              T26C7 = tab26.Column_7_TAB6,
                              T27C8 = tab27.Column_8_TAB7,
                              T28C9 = tab28.Column_9_TAB8,
                              T29C10 = tab29.Column_10_TAB9,
                              T30C11 = tab30.Column_11_TAB10,
                              T31C2 = tab31.Column_2_TAB1,
                              T32C3 = tab32.Column_3_TAB2,
                              T33C4 = tab33.Column_4_TAB3,
                              T34C5 = tab34.Column_5_TAB4,
                              T35C6 = tab35.Column_6_TAB5,
                              T36C7 = tab36.Column_7_TAB6,
                              T37C8 = tab37.Column_8_TAB7,
                              T38C9 = tab38.Column_9_TAB8,
                              T39C10 = tab39.Column_10_TAB9,
                              T40C11 = tab40.Column_11_TAB10,
                              T41C2 = tab41.Column_2_TAB1,
                              T42C3 = tab42.Column_3_TAB2,
                              T43C4 = tab43.Column_4_TAB3,
                              T44C5 = tab44.Column_5_TAB4,
                              T45C6 = tab45.Column_6_TAB5,
                              T46C7 = tab46.Column_7_TAB6,
                              T47C8 = tab47.Column_8_TAB7,
                              T48C9 = tab48.Column_9_TAB8,
                              T49C10 = tab49.Column_10_TAB9,
                              T50C11 = tab50.Column_11_TAB10,
                              T51C2 = tab51.Column_2_TAB1,
                              T52C3 = tab52.Column_3_TAB2,
                              T53C4 = tab53.Column_4_TAB3,
                              T54C5 = tab54.Column_5_TAB4,
                              T55C6 = tab55.Column_6_TAB5,
                              T56C7 = tab56.Column_7_TAB6,
                              T57C8 = tab57.Column_8_TAB7,
                              T58C9 = tab58.Column_9_TAB8,
                              T59C10 = tab59.Column_10_TAB9,
                              T60C11 = tab60.Column_11_TAB10,
                          }).ToList();
            }
            return result;
        }
    }
}
