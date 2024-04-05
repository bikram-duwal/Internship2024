namespace Internship2024.View
{
    partial class AreaEditView
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
            this.cmbDepartmentName = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.grpButtons = new Infragistics.Win.Misc.UltraGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtUniqueCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAreaName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAreaCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDispensing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartmentName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpButtons)).BeginInit();
            this.grpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUniqueCode
            // 
            this.lblUniqueCode.Location = new System.Drawing.Point(27, 39);
            this.lblUniqueCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblUniqueCode.Name = "lblUniqueCode";
            this.lblUniqueCode.Size = new System.Drawing.Size(150, 36);
            this.lblUniqueCode.TabIndex = 0;
            this.lblUniqueCode.Text = "Unique Code";
            this.lblUniqueCode.Click += new System.EventHandler(this.lblUniqueCode_Click);
            // 
            // lblAreaName
            // 
            this.lblAreaName.Location = new System.Drawing.Point(27, 122);
            this.lblAreaName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblAreaName.Name = "lblAreaName";
            this.lblAreaName.Size = new System.Drawing.Size(150, 36);
            this.lblAreaName.TabIndex = 1;
            this.lblAreaName.Text = "Area Name";
            // 
            // lblAreaCode
            // 
            this.lblAreaCode.Location = new System.Drawing.Point(27, 206);
            this.lblAreaCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblAreaCode.Name = "lblAreaCode";
            this.lblAreaCode.Size = new System.Drawing.Size(150, 36);
            this.lblAreaCode.TabIndex = 2;
            this.lblAreaCode.Text = "Area Code";
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblDepartmentName.Location = new System.Drawing.Point(27, 294);
            this.lblDepartmentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(194, 36);
            this.lblDepartmentName.TabIndex = 3;
            this.lblDepartmentName.Text = "Department Name";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblDescription.Location = new System.Drawing.Point(580, 42);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(141, 36);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(22, 21);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(157, 21);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUniqueCode
            // 
            this.txtUniqueCode.Location = new System.Drawing.Point(235, 38);
            this.txtUniqueCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUniqueCode.Name = "txtUniqueCode";
            this.txtUniqueCode.ReadOnly = true;
            this.txtUniqueCode.Size = new System.Drawing.Size(324, 34);
            this.txtUniqueCode.TabIndex = 7;
            // 
            // txtAreaName
            // 
            this.txtAreaName.Location = new System.Drawing.Point(235, 120);
            this.txtAreaName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.Size = new System.Drawing.Size(324, 34);
            this.txtAreaName.TabIndex = 8;
            // 
            // txtAreaCode
            // 
            this.txtAreaCode.Location = new System.Drawing.Point(235, 205);
            this.txtAreaCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAreaCode.Name = "txtAreaCode";
            this.txtAreaCode.Size = new System.Drawing.Size(324, 34);
            this.txtAreaCode.TabIndex = 9;
            // 
            // cbDispensing
            // 
            this.cbDispensing.Location = new System.Drawing.Point(27, 370);
            this.cbDispensing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDispensing.Name = "cbDispensing";
            this.cbDispensing.Size = new System.Drawing.Size(246, 44);
            this.cbDispensing.TabIndex = 11;
            this.cbDispensing.Text = "Is For Dispensing";
            // 
            // cbIsActive
            // 
            this.cbIsActive.Location = new System.Drawing.Point(27, 452);
            this.cbIsActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(246, 44);
            this.cbIsActive.TabIndex = 12;
            this.cbIsActive.Text = "Is Active";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(717, 36);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(440, 184);
            this.txtDescription.TabIndex = 13;
            // 
            // cmbDepartmentName
            // 
            this.cmbDepartmentName.Location = new System.Drawing.Point(235, 292);
            this.cmbDepartmentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDepartmentName.Name = "cmbDepartmentName";
            this.cmbDepartmentName.Size = new System.Drawing.Size(324, 34);
            this.cmbDepartmentName.TabIndex = 14;
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnCancel);
            this.grpButtons.Controls.Add(this.btnSave);
            this.grpButtons.Location = new System.Drawing.Point(888, 566);
            this.grpButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(291, 75);
            this.grpButtons.TabIndex = 15;
            // 
            // AreaEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 655);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.cmbDepartmentName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.cbDispensing);
            this.Controls.Add(this.txtAreaCode);
            this.Controls.Add(this.txtAreaName);
            this.Controls.Add(this.txtUniqueCode);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.lblAreaCode);
            this.Controls.Add(this.lblAreaName);
            this.Controls.Add(this.lblUniqueCode);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AreaEditView";
            this.Text = "Edit Area";
            ((System.ComponentModel.ISupportInitialize)(this.txtUniqueCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAreaName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAreaCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDispensing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartmentName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpButtons)).EndInit();
            this.grpButtons.ResumeLayout(false);
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
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cmbDepartmentName;
        private Infragistics.Win.Misc.UltraGroupBox grpButtons;
    }
}