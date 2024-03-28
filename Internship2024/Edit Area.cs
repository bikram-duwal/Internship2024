using Internship2024.AreaEditView;
using Internship2024.EditPresenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internship2024
{
    public partial class Edit_Area : Form, IAreaEditView
    {
        public Edit_Area()
        {
            InitializeComponent();
           
        }
        public string UniqueCode
        {
            get { return txtAreaCode.Text; }
            set { txtAreaCode.Text = value; }
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
        public string DepartmentName {

            get { return cmbDepartment.SelectedItem.ToString(); }
            set { cmbDepartment.SelectedItem = value; }
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
            
                set { cbIsActive.Checked = value; }
            }
        public AreaEditPresenter Presenter { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Presenter.UpdateArea();
            MessageBox.Show("The value is printed successfully");
        }
    }
}
