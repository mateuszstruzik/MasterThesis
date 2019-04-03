using DataExtract.Models.ModelsForTests;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.NHibernateMappingClass.InnerJoin
{
    public class InnerJoin20TableMap : ClassMap<ModelFor20TableInnerJoin>
    {
        public InnerJoin20TableMap()
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
            Map(x => x.T11C10).Column("T11C10");
            Map(x => x.T11C2).Column("T11C2");
            Map(x => x.T11C3).Column("T11C3");
            Map(x => x.T12C4).Column("T12C4");
            Map(x => x.T12C5).Column("T12C5");
            Map(x => x.T12C6).Column("T12C6");
            Map(x => x.T13C7).Column("T13C7");
            Map(x => x.T13C8).Column("T13C8");
            Map(x => x.T13C9).Column("T13C9");
            Map(x => x.T14C10).Column("T14C10");
            Map(x => x.T14C11).Column("T14C11");
            Map(x => x.T14C12).Column("T14C12");
            Map(x => x.T15C13).Column("T15C13");
            Map(x => x.T15C14).Column("T15C14");
            Map(x => x.T15C15).Column("T15C15");
            Map(x => x.T16C16).Column("T16C16");
            Map(x => x.T16C17).Column("T16C17");
            Map(x => x.T16C18).Column("T16C18");
            Map(x => x.T17C19).Column("T17C19");
            Map(x => x.T17C20).Column("T17C20");
            Map(x => x.T17C21).Column("T17C21");
            Map(x => x.T18C22).Column("T18C22");
            Map(x => x.T18C23).Column("T18C23");
            Map(x => x.T18C24).Column("T18C24");
            Map(x => x.T19C2).Column("T19C2");
            Map(x => x.T19C10).Column("T19C10");
            Map(x => x.T19C20).Column("T19C20");
            Map(x => x.T20C5).Column("T20C5");
            Map(x => x.T20C10).Column("T20C10");
            Map(x => x.T20C15).Column("T20C15");
        }
    }
}
