using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.TableModels
{
    public interface IModels
    {
        void SetModel(int id, List<string> propertyList);
    }
}
