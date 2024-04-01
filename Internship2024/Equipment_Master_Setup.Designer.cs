namespace Internship2024
{
    partial class Equipment_Master_Setup
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            this.lblName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDetails5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDetails5 = new System.Windows.Forms.TextBox();
            this.ultraCheckEditor1 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.ultraButton1 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton2 = new Infragistics.Win.Misc.UltraButton();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCheckEditor1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(589, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(21, 81);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            this.lblDescription.Click += new System.EventHandler(this.txtName_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(21, 134);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            this.lblAddress.Click += new System.EventHandler(this.txtName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contact";
            this.label2.Click += new System.EventHandler(this.txtName_Click);
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(21, 182);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(24, 13);
            this.lblFax.TabIndex = 0;
            this.lblFax.Text = "Fax";
            this.lblFax.Click += new System.EventHandler(this.txtName_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(387, 182);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.txtName_Click);
            // 
            // lblDetails5
            // 
            this.lblDetails5.AutoSize = true;
            this.lblDetails5.Location = new System.Drawing.Point(21, 228);
            this.lblDetails5.Name = "lblDetails5";
            this.lblDetails5.Size = new System.Drawing.Size(48, 13);
            this.lblDetails5.TabIndex = 0;
            this.lblDetails5.Text = "Details 5";
            this.lblDetails5.Click += new System.EventHandler(this.txtName_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 64);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(589, 45);
            this.textBox2.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(93, 131);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(213, 32);
            this.txtAddress.TabIndex = 1;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(469, 131);
            this.txtContact.Multiline = true;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(213, 32);
            this.txtContact.TabIndex = 1;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(93, 179);
            this.txtFax.Multiline = true;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(213, 32);
            this.txtFax.TabIndex = 1;
            this.txtFax.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(469, 179);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(213, 32);
            this.txtEmail.TabIndex = 1;
            // 
            // txtDetails5
            // 
            this.txtDetails5.Location = new System.Drawing.Point(93, 225);
            this.txtDetails5.Multiline = true;
            this.txtDetails5.Name = "txtDetails5";
            this.txtDetails5.Size = new System.Drawing.Size(213, 35);
            this.txtDetails5.TabIndex = 1;
            this.txtDetails5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // ultraCheckEditor1
            // 
            this.ultraCheckEditor1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ultraCheckEditor1.BackColorInternal = System.Drawing.SystemColors.ActiveCaption;
            this.ultraCheckEditor1.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button;
            this.ultraCheckEditor1.Checked = true;
            this.ultraCheckEditor1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ultraCheckEditor1.Location = new System.Drawing.Point(37, 266);
            this.ultraCheckEditor1.Name = "ultraCheckEditor1";
            this.ultraCheckEditor1.Size = new System.Drawing.Size(131, 48);
            this.ultraCheckEditor1.TabIndex = 2;
            this.ultraCheckEditor1.Text = "Is Active";
            // 
            // ultraButton1
            // 
            this.ultraButton1.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button3D;
            appearance1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraButton1.HotTrackAppearance = appearance1;
            this.ultraButton1.Location = new System.Drawing.Point(469, 278);
            this.ultraButton1.Name = "ultraButton1";
            this.ultraButton1.Size = new System.Drawing.Size(75, 36);
            this.ultraButton1.TabIndex = 3;
            this.ultraButton1.Text = "Cancel";
            // 
            // ultraButton2
            // 
            appearance2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraButton2.HotTrackAppearance = appearance2;
            this.ultraButton2.Location = new System.Drawing.Point(607, 278);
            this.ultraButton2.Name = "ultraButton2";
            this.ultraButton2.Size = new System.Drawing.Size(75, 36);
            this.ultraButton2.TabIndex = 3;
            this.ultraButton2.Text = "Save";
            // 
            // Equipment_Master_Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ultraButton2);
            this.Controls.Add(this.ultraButton1);
            this.Controls.Add(this.ultraCheckEditor1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDetails5);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDetails5);
            this.Controls.Add(this.lblFax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Name = "Equipment_Master_Setup";
            this.Text = "Equipment_Master_Setup";
            this.Load += new System.EventHandler(this.Equipment_Master_Setup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraCheckEditor1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDetails5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDetails5;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor ultraCheckEditor1;
        private Infragistics.Win.Misc.UltraButton ultraButton1;
        private Infragistics.Win.Misc.UltraButton ultraButton2;
    }
}