using DataExtract.Models.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.ModelsForTests
{
    public class ModelFor20TableOuterJoin : IModels
    {
        public virtual int ID { get; set; }
        public virtual string T1C2 { get; set; }
        public virtual string T2C3 { get; set; }
        public virtual string T3C4 { get; set; }
        public virtual string T4C5 { get; set; }
        public virtual string T5C6 { get; set; }
        public virtual string T6C7 { get; set; }
        public virtual string T7C8 { get; set; }
        public virtual string T8C9 { get; set; }
        public virtual string T9C10 { get; set; }
        public virtual string T10C11 { get; set; }
        public virtual string T11C2 { get; set; }
        public virtual string T12C3 { get; set; }
        public virtual string T13C4 { get; set; }
        public virtual string T14C5 { get; set; }
        public virtual string T15C6 { get; set; }
        public virtual string T16C7 { get; set; }
        public virtual string T17C8 { get; set; }
        public virtual string T18C9 { get; set; }
        public virtual string T19C10 { get; set; }
        public virtual string T20C11 { get; set; }
        public ModelFor20TableOuterJoin()
        {

        }
        public virtual void SetModel(int id, List<string> propertyList)
        {
            ID = id;
            T1C2 = propertyList[0];
            T2C3 = propertyList[1];
            T3C4 = propertyList[2];
            T4C5 = propertyList[3];
            T5C6 = propertyList[4];
            T6C7 = propertyList[5];
            T7C8 = propertyList[6];
            T8C9 = propertyList[7];
            T9C10 = propertyList[8];
            T10C11 = propertyList[9];
            T11C2 = propertyList[10];
            T12C3 = propertyList[11];
            T13C4 = propertyList[12];
            T14C5 = propertyList[13];
            T15C6 = propertyList[14];
            T16C7 = propertyList[15];
            T17C8 = propertyList[16];
            T18C9 = propertyList[17];
            T19C10 = propertyList[18];
            T20C11 = propertyList[19];
        }
    }
}
