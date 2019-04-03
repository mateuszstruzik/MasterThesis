using DataExtract.Models.ModelsForTests;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.NHibernateMappingClass.SqlServer
{
    public class OterJoin10TableMap : ClassMap<ModelFor10TableOuterJoin>
    {
        public OterJoin10TableMap()
        {
            Id(x => x.ID).Column("Column_1_TAB1");
            Map(x => x.T1C2).Column("Column_2_TAB1");
            Map(x => x.T2C3).Column("Column_3_TAB2");
            Map(x => x.T3C4).Column("Column_4_TAB3");
            Map(x => x.T4C5).Column("Column_5_TAB4");
            Map(x => x.T5C6).Column("Column_6_TAB5");
            Map(x => x.T6C7).Column("Column_7_TAB6");
            Map(x => x.T7C8).Column("Column_8_TAB7");
            Map(x => x.T8C9).Column("Column_9_TAB8");
            Map(x => x.T9C10).Column("Column_10_TAB9");
            Map(x => x.T10C11).Column("Column_11_TAB10");
        }
    }
}
