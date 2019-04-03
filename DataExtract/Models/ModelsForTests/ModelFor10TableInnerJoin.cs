using DataExtract.Models.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.ModelsForTests
{
    public class ModelFor10TableInnerJoin : IModels 
    {
        public virtual int ID { get; set; }
        public virtual string T1C2 { get; set; }
        public virtual string T1C3 { get; set; }
        public virtual string T2C4 { get; set; }
        public virtual string T2C5 { get; set; }
        public virtual string T2C6 { get; set; }
        public virtual string T3C7 { get; set; }
        public virtual string T3C8 { get; set; }
        public virtual string T3C9 { get; set; }
        public virtual string T4C10 { get; set; }
        public virtual string T4C11 { get; set; }
        public virtual string T4C12 { get; set; }
        public virtual string T5C13 { get; set; }
        public virtual string T5C14 { get; set; }
        public virtual string T5C15 { get; set; }
        public virtual string T6C16 { get; set; }
        public virtual string T6C17 { get; set; }
        public virtual string T6C18 { get; set; }
        public virtual string T7C19 { get; set; }
        public virtual string T7C20 { get; set; }
        public virtual string T7C21 { get; set; }
        public virtual string T8C22 { get; set; }
        public virtual string T8C23 { get; set; }
        public virtual string T8C24 { get; set; }
        public virtual string T9C2 { get; set; }
        public virtual string T9C10 { get; set; }
        public virtual string T9C20 { get; set; }
        public virtual string T10C5 { get; set; }
        public virtual string T10C10 { get; set; }
        public virtual string T10C15 { get; set; }
        public ModelFor10TableInnerJoin()
        {

        }
        public virtual void SetModel(int id, List<string> propertyList)
        {
            ID = id;
            T1C2 = propertyList[0];
            T1C3 = propertyList[1];
            T2C4 = propertyList[2];
            T2C5 = propertyList[3];
            T2C6 = propertyList[4];
            T3C7 = propertyList[5];
            T3C8 = propertyList[6];
            T3C9 = propertyList[7];
            T4C10 = propertyList[8];
            T4C11 = propertyList[9];
            T4C12 = propertyList[10];
            T5C13 = propertyList[11];
            T5C14 = propertyList[12];
            T5C15 = propertyList[13];
            T6C16 = propertyList[14];
            T6C17 = propertyList[15];
            T6C18 = propertyList[16];
            T7C19 = propertyList[17];
            T7C20 = propertyList[18];
            T7C21 = propertyList[19];
            T8C22 = propertyList[20];
            T8C23 = propertyList[21];
            T8C24 = propertyList[22];
            T9C2 = propertyList[23];
            T9C10 = propertyList[24];
            T9C20 = propertyList[25];
            T10C5 = propertyList[26];
            T10C10 = propertyList[27];
            T10C15 = propertyList[28];
        }

    }
}
