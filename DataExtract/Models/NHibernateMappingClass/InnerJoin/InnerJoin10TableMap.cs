using DataExtract.Models.ModelsForTests;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.NHibernateMappingClass.InnerJoin
{
    public class InnerJoin10TableMap : ClassMap<ModelFor10TableInnerJoin>
    {
        public InnerJoin10TableMap()
        {
            Id(x => x.ID).Column("ID");
            Map(x => x.T1C2).Column("T1C2");
            Map(x => x.T1C3).Column("T1C3");
            Map(x => x.T2C4).Column("T2C4");
            Map(x => x.T2C5).Column("T2C5");
            Map(x => x.T2C6).Column("T2C6");
            Map(x => x.T3C7).Column("T3C7");
            Map(x => x.T3C8).Column("T3C8");
            Map(x => x.T3C9).Column("T3C9");
            Map(x => x.T4C10).Column("T4C10");
            Map(x => x.T4C11).Column("T4C11");
            Map(x => x.T4C12).Column("T4C12");
            Map(x => x.T5C13).Column("T5C13");
            Map(x => x.T5C14).Column("T5C14");
            Map(x => x.T5C15).Column("T5C15");
            Map(x => x.T6C16).Column("T6C16");
            Map(x => x.T6C17).Column("T6C17");
            Map(x => x.T6C18).Column("T6C18");
            Map(x => x.T7C19).Column("T7C19");
            Map(x => x.T7C20).Column("T7C20");
            Map(x => x.T7C21).Column("T7C21");
            Map(x => x.T8C22).Column("T8C22");
            Map(x => x.T8C23).Column("T8C23");
            Map(x => x.T8C24).Column("T8C24");
            Map(x => x.T9C2).Column("T9C2");
            Map(x => x.T9C10).Column("T9C10");
            Map(x => x.T9C20).Column("T9C20");
            Map(x => x.T10C5).Column("T10C5");
            Map(x => x.T10C10).Column("T10C10");
            Map(x => x.T10C15).Column("T10C15");
        }
    }
}
