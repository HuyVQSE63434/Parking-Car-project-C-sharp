namespace winformProject.GUI
{
    partial class AddNewCarForm
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
            this.components = new System.ComponentModel.Container();
            this.PicBoxCarLicence = new System.Windows.Forms.PictureBox();
            this.btnUploadLicense = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCarName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLicensePlate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCarLicence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBoxCarLicence
            // 
            this.PicBoxCarLicence.BackColor = System.Drawing.Color.Aquamarine;
            this.PicBoxCarLicence.Location = new System.Drawing.Point(847, 34);
            this.PicBoxCarLicence.Name = "PicBoxCarLicence";
            this.PicBoxCarLicence.Size = new System.Drawing.Size(560, 497);
            this.PicBoxCarLicence.TabIndex = 0;
            this.PicBoxCarLicence.TabStop = false;
            // 
            // btnUploadLicense
            // 
            this.btnUploadLicense.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnUploadLicense.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnUploadLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUploadLicense.BorderRadius = 0;
            this.btnUploadLicense.ButtonText = "Upload car license picture";
            this.btnUploadLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadLicense.DisabledColor = System.Drawing.Color.Gray;
            this.btnUploadLicense.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUploadLicense.Iconimage = global::winformProject.Properties.Resources.Customer_96px;
            this.btnUploadLicense.Iconimage_right = null;
            this.btnUploadLicense.Iconimage_right_Selected = null;
            this.btnUploadLicense.Iconimage_Selected = null;
            this.btnUploadLicense.IconMarginLeft = 0;
            this.btnUploadLicense.IconMarginRight = 0;
            this.btnUploadLicense.IconRightVisible = true;
            this.btnUploadLicense.IconRightZoom = 0D;
            this.btnUploadLicense.IconVisible = true;
            this.btnUploadLicense.IconZoom = 90D;
            this.btnUploadLicense.IsTab = false;
            this.btnUploadLicense.Location = new System.Drawing.Point(847, 579);
            this.btnUploadLicense.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.btnUploadLicense.Name = "btnUploadLicense";
            this.btnUploadLicense.Normalcolor = System.Drawing.Color.DarkSeaGreen;
            this.btnUploadLicense.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUploadLicense.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUploadLicense.selected = false;
            this.btnUploadLicense.Size = new System.Drawing.Size(560, 95);
            this.btnUploadLicense.TabIndex = 16;
            this.btnUploadLicense.Text = "Upload car license picture";
            this.btnUploadLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadLicense.Textcolor = System.Drawing.Color.White;
            this.btnUploadLicense.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadLicense.Click += new System.EventHandler(this.btnUploadLicense_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Car Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "License Plate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "User:";
            // 
            // txtCarName
            // 
            this.txtCarName.Depth = 0;
            this.txtCarName.Hint = "";
            this.txtCarName.Location = new System.Drawing.Point(219, 117);
            this.txtCarName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCarName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.PasswordChar = '\0';
            this.txtCarName.SelectedText = "";
            this.txtCarName.SelectionLength = 0;
            this.txtCarName.SelectionStart = 0;
            this.txtCarName.Size = new System.Drawing.Size(568, 50);
            this.txtCarName.TabIndex = 20;
            this.txtCarName.UseSystemPasswordChar = false;
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Depth = 0;
            this.txtLicensePlate.Hint = "";
            this.txtLicensePlate.Location = new System.Drawing.Point(219, 207);
            this.txtLicensePlate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtLicensePlate.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.PasswordChar = '\0';
            this.txtLicensePlate.SelectedText = "";
            this.txtLicensePlate.SelectionLength = 0;
            this.txtLicensePlate.SelectionStart = 0;
            this.txtLicensePlate.Size = new System.Drawing.Size(568, 50);
            this.txtLicensePlate.TabIndex = 21;
            this.txtLicensePlate.UseSystemPasswordChar = false;
            // 
            // cbUser
            // 
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(219, 323);
            this.cbUser.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(197, 39);
            this.cbUser.TabIndex = 22;
            this.cbUser.Text = "User";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(219, 619);
            this.btnSave.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 55);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Location = new System.Drawing.Point(587, 619);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(200, 55);
            this.BtnCancel.TabIndex = 24;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddNewCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1437, 700);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUploadLicense);
            this.Controls.Add(this.PicBoxCarLicence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewCarForm";
            this.Load += new System.EventHandler(this.AddNewCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCarLicence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxCarLicence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnUploadLicense;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCarName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLicensePlate;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}