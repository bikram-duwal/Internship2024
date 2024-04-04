using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship2024.EditModel
{
    public interface IAreaEditRepository
    {
         void UpdateArea(pl_areaRow objAreaRow);
        pl_areaRow LoadFormValue();
        pl_objectRow[] GetDropDownValue();
        string DropDownName();
    }
}
