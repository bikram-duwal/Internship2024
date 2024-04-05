using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship2024.Services
{
    public interface IAreaEditService
    {
        void UpdateArea(pl_areaRow objAreaRow);
        pl_areaRow GetAreaByTablePid(long table_pid);
        pl_objectRow[] GetDropDownValue();
    }
}
