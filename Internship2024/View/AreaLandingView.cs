using Infragistics.Win.UltraWinGrid;
using Internship2024.Presenter;
using Internship2024.Repository;
using Internship2024.Services;
using System;
using System.Windows.Forms;

namespace Internship2024.View
{
    public partial class AreaLandingView : Form, IAreaLandingView
    {
        public AreaLandingPresenter _presenter { get; set; }
        Internship2024DB _objTran;
        public UltraGrid UGAreaLanding { get => this.ugAreaLanding; }

        public AreaLandingView(Internship2024DB objTran)
        {
            InitializeComponent();
            _objTran = objTran;

            AreaLandingRepository repository = new AreaLandingRepository(objTran);
            AreaLandingService service = new AreaLandingService(repository);
            this._presenter = new AreaLandingPresenter(this, service) ;
            this._presenter.InitializePage();
        }

        private void btnAuditLog_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UltraGridRow selectedRow = UGAreaLanding.ActiveRow;
            if (selectedRow != null)
            {
                long table_pid = (selectedRow.ListObject as pl_areaRow).Table_pid;
                AreaEditView areaEditView = new AreaEditView(_objTran, table_pid);
                areaEditView.Show();
                areaEditView.FormClosing += editViewOnClose;
                areaEditView.FormClosed += editViewOnClose;
                return;
            }
            MessageBox.Show("Please select a row");
        }

        private void editViewOnClose(object sender, EventArgs e)
        {
            MessageBox.Show("CLOSED");
            _presenter.InitializePage();
        }
    }
}
