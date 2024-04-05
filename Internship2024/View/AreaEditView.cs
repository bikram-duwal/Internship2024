using Internship2024.EditModel;
using Internship2024.EditPresenter;
using Internship2024.Services;
using System;
using System.Windows.Forms;

namespace Internship2024.View
{
    public partial class AreaEditView : Form, IAreaEditView
    {
        AreaEditPresenter _presenter;
        pl_areaRow objAreaRow;
        public AreaEditView(Internship2024DB objTran, long table_pid)
        {
            InitializeComponent();
            AreaEditRepository repository = new AreaEditRepository(objTran);
            AreaEditService service = new AreaEditService(repository);
            _presenter = new AreaEditPresenter(this, service);
            objAreaRow = _presenter.LoadFormValue(table_pid);
            _presenter.LoadDropDownValue();
        }

        public string UniqueCode
        {
            get { return txtUniqueCode.Text; }
            set { txtUniqueCode.Text = value; }
        }

        public string AreaName { 
            get { return txtAreaName.Text;}
            set { txtAreaName.Text = value;}
        
        
        }
        public string AreaCode {
            get { return txtAreaCode.Text;}
            set { txtAreaCode.Text = value;}
        }
        public string Description {
            get { return txtDescription.Text; }
            set { txtDescription.Text = value;}
        }
        public string DepartmentName
        {
         
            get { return cmbDepartmentName.Text; }
            set { cmbDepartmentName.Text = value; }

        }

        public bool IsActive
        {
            get
            {
                return cbIsActive.Checked;
            }
            set
                    {
                cbIsActive.Checked = value;


                }
        
        }
        public bool IsForDispensing {
            get { return cbDispensing.Checked; }
            
                set { cbDispensing.Checked = value; }
            }
       public void ShowMessage(string message)
        {
            MessageBox.Show(message);

        }
       
        public AreaEditPresenter Presenter { get; set; }
        public pl_objectRow[] DepartmentsName
        {
            get => (pl_objectRow[])cmbDepartmentName.DataSource;
            set
            {
                cmbDepartmentName.DataSource = value;
                cmbDepartmentName.ValueMember = "Table_pid";
                cmbDepartmentName.DisplayMember = "Name";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtUniqueCode.Text))
            {
                MessageBox.Show("Unique code cannot be null");
                return;
            }
            if(String.IsNullOrEmpty(txtAreaName.Text))
            {
                MessageBox.Show("Area name cannot be null");
                return;
            }
            if(String.IsNullOrEmpty(txtAreaCode.Text))
            {
                MessageBox.Show("Area Code cannot be null");
                return;
            }
            if(cmbDepartmentName.SelectedIndex==-1)
            {
                MessageBox.Show("Department Name cannot be null");
                return;
            }
            if(String.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Description  cannot be null");
                return;
            }
            objAreaRow.Unique_code = txtUniqueCode.Text;
            objAreaRow.Area_code = txtAreaCode.Text;
            objAreaRow.Description=txtDescription.Text;
            objAreaRow.Name=txtAreaName.Text;
            objAreaRow.Is_for_dispensing=cbDispensing.Checked;
            objAreaRow.Status=cbIsActive.Checked;
            objAreaRow.Department_id =(long)cmbDepartmentName.Value;
            try
            {
                _presenter.UpdateArea(objAreaRow);
                MessageBox.Show("Updated Successfully");
                this.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
