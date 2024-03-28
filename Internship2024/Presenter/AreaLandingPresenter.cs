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
        IAreaLandingView view;
        AreaLandingService areaLandingService;
        public AreaLandingPresenter(IAreaLandingView view, AreaLandingService areaLandingService)
        {
            this.view = view;
            this.areaLandingService = areaLandingService;
        }

        public void InitializePage()
        {
            try
            {
                List<AreaRow> rows = this.areaLandingService.getAllAreas();
                this.view.GridAreaLanding.DataSource = rows;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Exception Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
