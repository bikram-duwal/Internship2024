using Internship2024.AreaEditView;
using Internship2024.EditModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship2024.EditPresenter
{
    public class AreaEditPresenter
    {
        private readonly IAreaEditRepository _areaEditRepository;
        private readonly IAreaEditView _areaEditView;
        public AreaEditPresenter(
            IAreaEditView view,IAreaEditRepository repository )
        {
            _areaEditRepository = repository;
            _areaEditView = view;
            view.Presenter = this;
        }
        public void UpdateArea()
        {
            AreaEdit areaedit = new AreaEdit { AreaName = _areaEditView.AreaName, 
                UniqueCode = _areaEditView.UniqueCode, 
                AreaCode = _areaEditView.AreaCode, DepartmentName = _areaEditView.DepartmentName,
                Description = _areaEditView.Description, IsActive = _areaEditView.IsActive,
                IsForDispensing = _areaEditView.IsForDispensing };
            _areaEditRepository.UpdateArea(areaedit);
            Console.WriteLine(" The value are " + areaedit.UniqueCode + " Area Name" + areaedit.AreaName + " Area Code=" + areaedit.AreaCode + " Department Name=" + areaedit.DepartmentName + "Description=" + areaedit.Description + "Is for dispensing" + areaedit.IsForDispensing + "Is active" + areaedit.IsActive);
        }
    }
}
