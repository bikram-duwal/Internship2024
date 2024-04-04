using Infragistics.Win.UltraWinGrid;
using Internship2024.Presenter;
using Internship2024.Repository;
using Internship2024.Services;
using System;
using System.Windows.Forms;

namespace Internship2024.View
{
    public partial class EquipmentLandingView : Form, IEquipmentLandingView
    {
        public EquipmentLandingPresenter Presenter { get; set; }
        public UltraGrid UGEquipmentLanding { get => this.ugEquipmentLanding; }

        public EquipmentLandingView()
        {
            InitializeComponent();
            Internship2024DB objTran = new Internship2024DB();

            EquipmentLandingRepository repository = new EquipmentLandingRepository(objTran);
            EquipmentLandingService service = new EquipmentLandingService(repository);
            this.Presenter = new EquipmentLandingPresenter(this, service) ;
            this.Presenter.LoadData();
        }

        private void btnAuditLog_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
