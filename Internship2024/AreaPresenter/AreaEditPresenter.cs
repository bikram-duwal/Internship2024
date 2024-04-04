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
        pl_areaRow objAreaRowAll = new pl_areaRow();
        int Id;
        long Table_Id;
        public AreaEditPresenter(
            IAreaEditView view,IAreaEditRepository repository )
        {
            _areaEditRepository = repository;
            _areaEditView = view;
            view.Presenter = this;
        }
        public void UpdateArea(pl_areaRow objAreaRow)
        {
            

            try
            {
               
                objAreaRow.Id = 3;
                objAreaRow.Table_pid = Table_Id;

                _areaEditRepository.UpdateArea(objAreaRow);
            }
            catch (Exception ex)
            {
               

            }
        }
        public void LoadFormValue()
        {
            pl_areaRow objAreaRow = _areaEditRepository.LoadFormValue();
            //objAreaRowAll.Id = 3;
            //objAreaRowAll.Table_pid = objAreaRow.Table_pid;
            Id = 3;
            Table_Id=objAreaRow.Table_pid;



            _areaEditView.UniqueCode = objAreaRow.Unique_code;
            _areaEditView.AreaCode=objAreaRow.Area_code;
            _areaEditView.AreaName = objAreaRow.Name;
            _areaEditView.Description = objAreaRow.Description;
            _areaEditView.IsForDispensing = objAreaRow.Is_for_dispensing;
            _areaEditView.IsActive = objAreaRow.Status;
            
            
            

           
        }
        public void LoadDropDownValue()
        {
            pl_objectRow[] rows=_areaEditRepository.GetDropDownValue();
            _areaEditView.DepartmentsName = rows;

        }
        public void DropDownName()
        {
            string value= _areaEditRepository.DropDownName();
            _areaEditView.DepartmentName = value;
        }
           
    }
}
