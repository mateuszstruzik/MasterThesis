using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.TableModels.SingleTablesModels
{
    public class Table_50 : IModels
    {
        [Key]
        public virtual int Column_1_TAB10 { get; set; }
        public virtual string Column_2_TAB10 { get; set; }
        public virtual string Column_3_TAB10 { get; set; }
        public virtual string Column_4_TAB10 { get; set; }
        public virtual string Column_5_TAB10 { get; set; }
        public virtual string Column_6_TAB10 { get; set; }
        public virtual string Column_7_TAB10 { get; set; }
        public virtual string Column_8_TAB10 { get; set; }
        public virtual string Column_9_TAB10 { get; set; }
        public virtual string Column_10_TAB10 { get; set; }
        public virtual string Column_11_TAB10 { get; set; }
        public virtual string Column_12_TAB10 { get; set; }
        public virtual string Column_13_TAB10 { get; set; }
        public virtual string Column_14_TAB10 { get; set; }
        public virtual string Column_15_TAB10 { get; set; }

        public Table_50()
        {

        }
        public virtual void SetModel(int id, List<string> propertyList)
        {
            Column_1_TAB10 = id;
            Column_2_TAB10 = propertyList[0];
            Column_3_TAB10 = propertyList[1];
            Column_4_TAB10 = propertyList[2];
            Column_5_TAB10 = propertyList[3];
            Column_6_TAB10 = propertyList[4];
            Column_7_TAB10 = propertyList[5];
            Column_8_TAB10 = propertyList[6];
            Column_9_TAB10 = propertyList[7];
            Column_10_TAB10 = propertyList[8];
            Column_11_TAB10 = propertyList[9];
            Column_12_TAB10 = propertyList[10];
            Column_13_TAB10 = propertyList[11];
            Column_14_TAB10 = propertyList[12];
            Column_15_TAB10 = propertyList[13];

        }
    }
}
