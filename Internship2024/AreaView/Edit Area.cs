using Internship2024.AreaEditView;
using Internship2024.EditModel;
using Internship2024.EditPresenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Internship2024
{
    public partial class Edit_Area : Form, IAreaEditView
    {
        AreaEditPresenter _presenter;
        pl_areaRow objAreaRow=new pl_areaRow();
        Internship2024DB _objTran = null;
        public Edit_Area()
        {
          
          
            _presenter = new AreaEditPresenter(this, new AreaEditRepository());
            InitializeComponent();
            _objTran = new Internship2024DB();
            _presenter.LoadFormValue();
            _presenter.LoadDropDownValue();
            _presenter.DropDownName();
        
          

           
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
            
            if(txtUniqueCode.Text=="")
            {
                MessageBox.Show("Unique code cannot be null");
            }
            else if(txtAreaName.Text=="")
            {
                MessageBox.Show("Area name cannot be null");

            }
            else if(txtAreaCode.Text=="")
            {
                MessageBox.Show("Area Code cannot be null");
            }
            else if(cmbDepartmentName.SelectedIndex==-1)
            {
                MessageBox.Show("Department Name cannot be null");
            }
            else if(txtDescription.Text=="")
            {
                MessageBox.Show("Description  cannot be null");
            }
            else
            {
              
                objAreaRow.Unique_code = txtUniqueCode.Text;
                objAreaRow.Area_code = txtAreaCode.Text;
                objAreaRow.Description=txtDescription.Text;
                objAreaRow.Name=txtAreaName.Text;
                objAreaRow.Is_for_dispensing=cbDispensing.Checked;
                objAreaRow.Status=cbIsActive.Checked;
                objAreaRow.Department_id =(long)cmbDepartmentName.Value;
            
             
                _presenter.UpdateArea(objAreaRow);
                MessageBox.Show("The value is printed successfully");

            }
           
        }

       
       
    }
}
