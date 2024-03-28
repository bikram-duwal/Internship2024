namespace Internship2024
{
    partial class Edit_Area
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUniqueCode = new Infragistics.Win.Misc.UltraLabel();
            this.lblAreaName = new Infragistics.Win.Misc.UltraLabel();
            this.lblAreaCode = new Infragistics.Win.Misc.UltraLabel();
            this.lblDepartmentName = new Infragistics.Win.Misc.UltraLabel();
            this.lblDescription = new Infragistics.Win.Misc.UltraLabel();
            this.btnCancel = new Infragistics.Win.Misc.UltraButton();
            this.btnSave = new Infragistics.Win.Misc.UltraButton();
            this.txtUniqueCode = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtAreaName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtAreaCode = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.cbDispensing = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.cbIsActive = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.txtDescription = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.cmbDepartment = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            ((System.ComponentModel.ISupportInitialize)(this.txtUniqueCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAreaName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAreaCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDispensing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUniqueCode
            // 
            this.lblUniqueCode.Location = new System.Drawing.Point(31, 66);
            this.lblUniqueCode.Name = "lblUniqueCode";
            this.lblUniqueCode.Size = new System.Drawing.Size(100, 23);
            this.lblUniqueCode.TabIndex = 0;
            this.lblUniqueCode.Text = "Unique Code";
            // 
            // lblAreaName
            // 
            this.lblAreaName.Location = new System.Drawing.Point(31, 119);
            this.lblAreaName.Name = "lblAreaName";
            this.lblAreaName.Size = new System.Drawing.Size(100, 23);
            this.lblAreaName.TabIndex = 1;
            this.lblAreaName.Text = "Area Name";
            // 
            // lblAreaCode
            // 
            this.lblAreaCode.Location = new System.Drawing.Point(31, 173);
            this.lblAreaCode.Name = "lblAreaCode";
            this.lblAreaCode.Size = new System.Drawing.Size(100, 23);
            this.lblAreaCode.TabIndex = 2;
            this.lblAreaCode.Text = "Area Code";
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblDepartmentName.Location = new System.Drawing.Point(31, 229);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(129, 23);
            this.lblDepartmentName.TabIndex = 3;
            this.lblDepartmentName.Text = "Department Name";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblDescription.Location = new System.Drawing.Point(501, 65);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(94, 23);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(619, 397);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(752, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUniqueCode
            // 
            this.txtUniqueCode.Location = new System.Drawing.Point(169, 65);
            this.txtUniqueCode.Name = "txtUniqueCode";
            this.txtUniqueCode.Size = new System.Drawing.Size(236, 24);
            this.txtUniqueCode.TabIndex = 7;
            // 
            // txtAreaName
            // 
            this.txtAreaName.Location = new System.Drawing.Point(169, 118);
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.Size = new System.Drawing.Size(236, 24);
            this.txtAreaName.TabIndex = 8;
            // 
            // txtAreaCode
            // 
            this.txtAreaCode.Location = new System.Drawing.Point(169, 172);
            this.txtAreaCode.Name = "txtAreaCode";
            this.txtAreaCode.Size = new System.Drawing.Size(236, 24);
            this.txtAreaCode.TabIndex = 9;
            // 
            // cbDispensing
            // 
            this.cbDispensing.Location = new System.Drawing.Point(31, 278);
            this.cbDispensing.Name = "cbDispensing";
            this.cbDispensing.Size = new System.Drawing.Size(164, 28);
            this.cbDispensing.TabIndex = 11;
            this.cbDispensing.Text = "Is For Dispensing";
            // 
            // cbIsActive
            // 
            this.cbIsActive.Location = new System.Drawing.Point(31, 330);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(164, 28);
            this.cbIsActive.TabIndex = 12;
            this.cbIsActive.Text = "Is Active";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(619, 62);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(344, 172);
            this.txtDescription.TabIndex = 13;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Location = new System.Drawing.Point(169, 228);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(236, 24);
            this.cmbDepartment.TabIndex = 14;
            // 
            // Edit_Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 518);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.cbDispensing);
            this.Controls.Add(this.txtAreaCode);
            this.Controls.Add(this.txtAreaName);
            this.Controls.Add(this.txtUniqueCode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.lblAreaCode);
            this.Controls.Add(this.lblAreaName);
            this.Controls.Add(this.lblUniqueCode);
            this.Name = "Edit_Area";
            this.Text = "Edit_Area";
            ((System.ComponentModel.ISupportInitialize)(this.txtUniqueCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAreaName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAreaCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDispensing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel lblUniqueCode;
        private Infragistics.Win.Misc.UltraLabel lblAreaName;
        private Infragistics.Win.Misc.UltraLabel lblAreaCode;
        private Infragistics.Win.Misc.UltraLabel lblDepartmentName;
        private Infragistics.Win.Misc.UltraLabel lblDescription;
        private Infragistics.Win.Misc.UltraButton btnCancel;
        private Infragistics.Win.Misc.UltraButton btnSave;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtUniqueCode;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtAreaName;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtAreaCode;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor cbDispensing;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor cbIsActive;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtDescription;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cmbDepartment;
    }
}