using Internship2024.EditModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship2024.Services
{
    public class AreaEditService : IAreaEditService
    {
        IAreaEditRepository _repository;
        public AreaEditService(IAreaEditRepository repository) {
            _repository = repository;
        }
        public pl_areaRow GetAreaByTablePid(long table_pid)
        {
            return _repository.GetAreaByTablePid(table_pid);
        }

        public pl_objectRow[] GetDropDownValue()
        {
            return _repository.GetDropDownValue();
        }

        public void UpdateArea(pl_areaRow objAreaRow)
        {
            _repository.UpdateArea(objAreaRow);
        }
    }
}
