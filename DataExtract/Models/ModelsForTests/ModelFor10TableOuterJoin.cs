using DataExtract.Models.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.ModelsForTests
{
    public class ModelFor10TableOuterJoin : IModels
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
        public ModelFor10TableOuterJoin()
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
        }
    }
}
