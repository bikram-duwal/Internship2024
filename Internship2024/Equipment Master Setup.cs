using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void Equipment_Master_Setup_Load(object sender, EventArgs e)
        {
            Load_combo_value();
        }

        private void cmbEquipmentMasterSetup_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            
        }

        //public void random()
        //{
        //    Internship2024DB dB = new Internship2024DB();
        //    Make make = new Make(dB);

        //    MakeRow makeRow = new MakeRow();
        //    makeRow = make.GetRow("id = 5");

        //    DataTable dt = new DataTable();
        //    dt = make.GetAsDataTable("column_type = .....", "");
            
        //}

        public void Load_combo_value()
        {
            Internship2024DB db = new Internship2024DB();
            try
            {
                db.BeginTransaction();
                pl_combo_value combo_Value = new pl_combo_value(db);
                //SqlCommand cmd = db.CreateCommand("GetAllColumnTypes", true);
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dt = combo_Value.GetAsDataTable("column_type = '" + "Equipment_Master_Type'", "");


                //da.Fill(dt);

                cmbEquipmentMasterSetup.DataSource = dt;
                //cmbEquipmentMasterSetup.DataBind();

                cmbEquipmentMasterSetup.DisplayLayout.Bands[0].Columns["column_type"].Hidden = true;
                cmbEquipmentMasterSetup.DisplayLayout.Bands[0].Columns["combo_value_id"].Hidden = true;
                cmbEquipmentMasterSetup.DisplayLayout.Bands[0].Columns["combo_value"].Header.Caption = "Configuration Items";
                //cmbEquipmentMasterSetup.DropDownWidth = 1;
                //cmbEquipmentMasterSetup.DisplayLayout.Bands[0].Columns["combo_value"].Width = cmbEquipmentMasterSetup.DropDownWidth - 2;
                db.CommitTransaction();
            }
            catch (Exception ex)
            {
                db.RollbackTransaction();
                MessageBox.Show("An error occured " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.Close();
                db.Dispose();
            }

        }
    }
}
