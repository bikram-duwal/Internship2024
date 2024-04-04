using Internship2024.Model;
using Internship2024.Services;
using Internship2024.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Internship2024.Presenter
{
    public class EquipmentLandingPresenter
    {
        IEquipmentLandingView _view;
        IEquipmentLandingService _service;
        public EquipmentLandingPresenter(IEquipmentLandingView view, IEquipmentLandingService equipmentLandingService)
        {
            _view = view;
            _service = equipmentLandingService;
        }

        public void LoadData()
        {
            try
            {
                List<Equipment> rows = _service.getAllEquipmentRows();
                _view.UGEquipmentLanding.DataSource = rows;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Exception Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
