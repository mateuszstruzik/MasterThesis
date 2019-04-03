using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.TableModels
{
    public class Table_22 : IModels
    {
        [Key]
        public virtual int Column_1_TAB2 { get; set; }
        public virtual string Column_2_TAB2 { get; set; }
        public virtual string Column_3_TAB2 { get; set; }
        public virtual string Column_4_TAB2 { get; set; }
        public virtual string Column_5_TAB2 { get; set; }
        public virtual string Column_6_TAB2 { get; set; }
        public virtual string Column_7_TAB2 { get; set; }
        public virtual string Column_8_TAB2 { get; set; }
        public virtual string Column_9_TAB2 { get; set; }
        public virtual string Column_10_TAB2 { get; set; }
        public virtual string Column_11_TAB2 { get; set; }
        public virtual string Column_12_TAB2 { get; set; }
        public virtual string Column_13_TAB2 { get; set; }
        public virtual string Column_14_TAB2 { get; set; }
        public virtual string Column_15_TAB2 { get; set; }

        public Table_22()
        {

        }
        public virtual void SetModel(int id, List<string> propertyList)
        {
            Column_1_TAB2 = id;
            Column_2_TAB2 = propertyList[0];
            Column_3_TAB2 = propertyList[1];
            Column_4_TAB2 = propertyList[2];
            Column_5_TAB2 = propertyList[3];
            Column_6_TAB2 = propertyList[4];
            Column_7_TAB2 = propertyList[5];
            Column_8_TAB2 = propertyList[6];
            Column_9_TAB2 = propertyList[7];
            Column_10_TAB2 = propertyList[8];
            Column_11_TAB2 = propertyList[9];
            Column_12_TAB2 = propertyList[10];
            Column_13_TAB2 = propertyList[11];
            Column_14_TAB2 = propertyList[12];
            Column_15_TAB2 = propertyList[13];

        }
    }
}

