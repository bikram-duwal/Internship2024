using Infragistics.Win.UltraWinGrid;
using Internship2024.Presenter;
using Internship2024.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internship2024.View
{
    public partial class AreaLandingView : Form, IAreaLandingView
    {
        public AreaLandingPresenter Presenter { get; set; }
        public UltraGrid GridAreaLanding { get => this.gridAreaLanding; }

        public AreaLandingView()
        {
            InitializeComponent();
            Internship2024DB objTran = new Internship2024DB();
            if (objTran == null)
            {
                MessageBox.Show("Error Connecting to Database", "Database Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AreaLandingService service = new AreaLandingService(objTran);
            this.Presenter = new AreaLandingPresenter(this, service);
            this.Presenter.InitializePage();
        }

        private void btnAuditLog_Click(object sender, EventArgs e)
        {
           
        }
    }
}
