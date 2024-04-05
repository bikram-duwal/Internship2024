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
                EquipmentMaster objpl_object = new EquipmentMaster(objTran);
                EquipmentMasterRow objpl_objectRow = objpl_object.GetRow("name = 'test_name2'");


                objTran.BeginTransaction();
                if (objpl_objectRow != null)
                {
                    MessageBox.Show(objpl_objectRow.Description);
                }
                else
                {
                    objpl_objectRow = new EquipmentMasterRow();
                    objpl_objectRow.Description = "test_table";
                    objpl_objectRow.Name = "test_name2";
                    objpl_objectRow.Details1 = "tesdt";
                    objpl_objectRow.Details2 = "test 2";
                    objpl_objectRow.Details3 = "test 3";
                    objpl_objectRow.Details4 = "test 4";
                    objpl_objectRow.City = "test";
                    objpl_objectRow.IsActive = true;

                    objpl_object.Insert(objpl_objectRow);
                    MessageBox.Show($"{objpl_objectRow.Name} has been added successfully");

                    
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
