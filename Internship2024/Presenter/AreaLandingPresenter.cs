using Internship2024.Model;
using Internship2024.Services;
using Internship2024.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internship2024.Presenter
{
    public class AreaLandingPresenter
    {
        IAreaLandingView _view;
        AreaLandingRepository _areaLandingService;
        public AreaLandingPresenter(IAreaLandingView view, AreaLandingRepository areaLandingService)
        {
            _view = view;
            _areaLandingService = areaLandingService;
        }

        public void InitializePage()
        {
            try
            {
                List<Area> rows = _areaLandingService.getAllAreaRows();
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
