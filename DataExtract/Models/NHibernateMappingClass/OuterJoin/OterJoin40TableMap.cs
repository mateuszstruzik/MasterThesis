using DataExtract.Models.ModelsForTests;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.NHibernateMappingClass.OuterJoin
{
    public class OterJoin40TableMap : ClassMap<ModelFor40TableOuterJoin>
    {
        public OterJoin40TableMap()
        {
            Id(x => x.ID).Column("ID");
            Map(x => x.T1C2).Column("T1C2");
            Map(x => x.T2C3).Column("T2C3");
            Map(x => x.T3C4).Column("T3C4");
            Map(x => x.T4C5).Column("T4C5");
            Map(x => x.T5C6).Column("T5C6");
            Map(x => x.T6C7).Column("T6C7");
            Map(x => x.T7C8).Column("T7C8");
            Map(x => x.T8C9).Column("T8C9");
            Map(x => x.T9C10).Column("T9C10");
            Map(x => x.T10C11).Column("T10C11");
            Map(x => x.T11C2).Column("T11C2");
            Map(x => x.T12C3).Column("T12C3");
            Map(x => x.T13C4).Column("T13C4");
            Map(x => x.T14C5).Column("T14C5");
            Map(x => x.T15C6).Column("T15C6");
            Map(x => x.T16C7).Column("T16C7");
            Map(x => x.T17C8).Column("T17C8");
            Map(x => x.T18C9).Column("T18C9");
            Map(x => x.T19C10).Column("T19C10");
            Map(x => x.T20C11).Column("T20C11");
            Map(x => x.T21C2).Column("T21C2");
            Map(x => x.T22C3).Column("T22C3");
            Map(x => x.T23C4).Column("T23C4");
            Map(x => x.T24C5).Column("T24C5");
            Map(x => x.T25C6).Column("T25C6");
            Map(x => x.T26C7).Column("T26C7");
            Map(x => x.T27C8).Column("T27C8");
            Map(x => x.T28C9).Column("T28C9");
            Map(x => x.T29C10).Column("T29C10");
            Map(x => x.T30C11).Column("T30C11");
            Map(x => x.T31C2).Column("T31C2");
            Map(x => x.T32C3).Column("T32C3");
            Map(x => x.T33C4).Column("T33C4");
            Map(x => x.T34C5).Column("T34C5");
            Map(x => x.T35C6).Column("T35C6");
            Map(x => x.T36C7).Column("T36C7");
            Map(x => x.T37C8).Column("T37C8");
            Map(x => x.T38C9).Column("T38C9");
            Map(x => x.T39C10).Column("T39C10");
            Map(x => x.T40C11).Column("T40C11");
        }
    }
}
