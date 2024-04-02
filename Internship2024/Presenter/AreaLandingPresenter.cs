using Internship2024.Model;
using Internship2024.Services;
using Internship2024.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Internship2024.Presenter
{
    public class AreaLandingPresenter
    {
        IAreaLandingView _view;
        IAreaLandingService _service;
        public AreaLandingPresenter(IAreaLandingView view, IAreaLandingService areaLandingService)
        {
            _view = view;
            _service = areaLandingService;
        }

        public void InitializePage()
        {
            try
            {
                List<pl_areaRow> rows = _service.getAllAreaRows();
                _view.UGAreaLanding.DataSource = rows;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Exception Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
