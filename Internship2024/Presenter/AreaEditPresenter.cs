using Internship2024.EditModel;
using Internship2024.Services;
using Internship2024.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship2024.EditPresenter
{
    public class AreaEditPresenter
    {
        IAreaEditView _areaEditView;
        IAreaEditService _service;

        public AreaEditPresenter(
            IAreaEditView view, IAreaEditService service)
        {
            _areaEditView = view;
            view.Presenter = this;
            _service = service;
        }
        public void UpdateArea(pl_areaRow objAreaRow)
        {
            _service.UpdateArea(objAreaRow);
        }
        public pl_areaRow LoadFormValue(long table_pid)
        {
            pl_areaRow areaRow = _service.GetAreaByTablePid(table_pid);

            _areaEditView.UniqueCode = areaRow.Unique_code;
            _areaEditView.AreaCode= areaRow.Area_code;
            _areaEditView.AreaName = areaRow.Name;
            _areaEditView.Description = areaRow.Description;
            _areaEditView.IsForDispensing = areaRow.Is_for_dispensing;
            _areaEditView.IsActive = areaRow.Status;
            _areaEditView.DepartmentName = areaRow.Department_name;
            return areaRow;
        }
        public void LoadDropDownValue()
        {
            pl_objectRow[] rows= _service.GetDropDownValue();
            _areaEditView.DepartmentsName = rows;
        }
    }
}
