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
    public partial class Equipment_Master_Setup : Form
    {
        public Equipment_Master_Setup()
        {
            InitializeComponent();
        }

        Internship2024DB objTran = null;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ultraButton2_Click(object sender, EventArgs e)
        {
            objTran = new Internship2024DB();
            if (objTran != null)
            {
                MessageBox.Show($"Connected to: {objTran.Connection.Database}");
            }
            try
            {
                Make make = new Make(objTran);
                MakeRow makeRow = make.GetRow("Name = 'name'");
                pl_string objpl_string = new pl_string(objTran);
                pl_stringRow objpl_stringRow = null;


                objTran.BeginTransaction();
                if (makeRow != null)
                {
                  //  MessageBox.Show(makeRow.Name);
                }
                else
                {
                    makeRow = new MakeRow();
                    makeRow.Name = txtName.Text;
                    makeRow.CreatedDate = DateTime.Now;
                    makeRow.ModifiedDate = DateTime.Now;
                    makeRow.UniqueCode = txtDescription.Text;
                    makeRow.Caption = "null";
                    makeRow.Details1 = txtContact.Text;
                    makeRow.Details2 = txtPhone.Text;
                    makeRow.Details3 = txtEmail.Text;
                    makeRow.Details4 = txtFax.Text;
                    makeRow.Details5 = txtDetails5.Text;
                    makeRow.CreatedBy = 2;
                    makeRow.ModifiedBy = 3;


                    make.Insert(makeRow);
                    MessageBox.Show($"{makeRow.Name} has been added successfully");

                    //objpl_stringRow = new pl_stringRow();
                    //objpl_stringRow.Table_pid = 1;
                    //objpl_stringRow.Column_type = "test_column_type";
                    //objpl_stringRow.Data_value = "test_data_value";
                    //objpl_string.Insert(objpl_stringRow);


                }
                objTran.CommitTransaction();
            }
            catch (Exception)
            {

                objTran.RollbackTransaction();
            }
            finally
            {
                objTran.Dispose();
            }

        }
    }
}
