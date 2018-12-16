namespace winformProject.GUI
{
    partial class EmployeeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.DataGridEm = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnUndelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.BtnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnAddNew = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtLastNane = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.avtBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEm)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avtBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridEm
            // 
            this.DataGridEm.AllowUserToAddRows = false;
            this.DataGridEm.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridEm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridEm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridEm.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridEm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridEm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridEm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridEm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridEm.DoubleBuffered = true;
            this.DataGridEm.EnableHeadersVisualStyles = false;
            this.DataGridEm.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DataGridEm.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.DataGridEm.Location = new System.Drawing.Point(0, 432);
            this.DataGridEm.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DataGridEm.Name = "DataGridEm";
            this.DataGridEm.ReadOnly = true;
            this.DataGridEm.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridEm.Size = new System.Drawing.Size(1584, 410);
            this.DataGridEm.TabIndex = 2;
            this.DataGridEm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEm_CellContentClick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuGradientPanel1.Controls.Add(this.btnUndelete);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.txtSearch);
            this.bunifuGradientPanel1.Controls.Add(this.BtnDelete);
            this.bunifuGradientPanel1.Controls.Add(this.BtnUpdate);
            this.bunifuGradientPanel1.Controls.Add(this.BtnAddNew);
            this.bunifuGradientPanel1.Controls.Add(this.txtPhoneNum);
            this.bunifuGradientPanel1.Controls.Add(this.txtMail);
            this.bunifuGradientPanel1.Controls.Add(this.txtLastNane);
            this.bunifuGradientPanel1.Controls.Add(this.txtFirstName);
            this.bunifuGradientPanel1.Controls.Add(this.txtUserId);
            this.bunifuGradientPanel1.Controls.Add(this.label7);
            this.bunifuGradientPanel1.Controls.Add(this.label6);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.lbRole);
            this.bunifuGradientPanel1.Controls.Add(this.avtBox);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Aqua;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.PaleGoldenrod;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.GreenYellow;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1584, 842);
            this.bunifuGradientPanel1.TabIndex = 1;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // btnUndelete
            // 
            this.btnUndelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndelete.BackColor = System.Drawing.Color.Transparent;
            this.btnUndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUndelete.BorderRadius = 0;
            this.btnUndelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnUndelete.ButtonText = "UnDelete";
            this.btnUndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUndelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnUndelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUndelete.Iconimage = global::winformProject.Properties.Resources.Customer_96px1;
            this.btnUndelete.Iconimage_right = null;
            this.btnUndelete.Iconimage_right_Selected = null;
            this.btnUndelete.Iconimage_Selected = null;
            this.btnUndelete.IconMarginLeft = 0;
            this.btnUndelete.IconMarginRight = 0;
            this.btnUndelete.IconRightVisible = true;
            this.btnUndelete.IconRightZoom = 0D;
            this.btnUndelete.IconVisible = true;
            this.btnUndelete.IconZoom = 90D;
            this.btnUndelete.IsTab = false;
            this.btnUndelete.Location = new System.Drawing.Point(1116, 377);
            this.btnUndelete.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.btnUndelete.Name = "btnUndelete";
            this.btnUndelete.Normalcolor = System.Drawing.Color.Transparent;
            this.btnUndelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUndelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUndelete.selected = false;
            this.btnUndelete.Size = new System.Drawing.Size(431, 112);
            this.btnUndelete.TabIndex = 27;
            this.btnUndelete.Text = "UnDelete";
            this.btnUndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUndelete.Textcolor = System.Drawing.Color.Black;
            this.btnUndelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndelete.Click += new System.EventHandler(this.btnUndelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(645, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "Search:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(645, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Role:";
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSearch.Location = new System.Drawing.Point(797, 451);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(380, 38);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDelete.BorderRadius = 0;
            this.BtnDelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BtnDelete.ButtonText = "Delete";
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.BtnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnDelete.Iconimage = global::winformProject.Properties.Resources.Denied_48px;
            this.BtnDelete.Iconimage_right = null;
            this.BtnDelete.Iconimage_right_Selected = null;
            this.BtnDelete.Iconimage_Selected = null;
            this.BtnDelete.IconMarginLeft = 0;
            this.BtnDelete.IconMarginRight = 0;
            this.BtnDelete.IconRightVisible = true;
            this.BtnDelete.IconRightZoom = 0D;
            this.BtnDelete.IconVisible = true;
            this.BtnDelete.IconZoom = 90D;
            this.BtnDelete.IsTab = false;
            this.BtnDelete.Location = new System.Drawing.Point(1116, 260);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnDelete.selected = false;
            this.BtnDelete.Size = new System.Drawing.Size(431, 112);
            this.BtnDelete.TabIndex = 17;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.Textcolor = System.Drawing.Color.Black;
            this.BtnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUpdate.BorderRadius = 0;
            this.BtnUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BtnUpdate.ButtonText = "Update";
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.BtnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnUpdate.Iconimage = global::winformProject.Properties.Resources.Update_User_48px;
            this.BtnUpdate.Iconimage_right = null;
            this.BtnUpdate.Iconimage_right_Selected = null;
            this.BtnUpdate.Iconimage_Selected = null;
            this.BtnUpdate.IconMarginLeft = 0;
            this.BtnUpdate.IconMarginRight = 0;
            this.BtnUpdate.IconRightVisible = true;
            this.BtnUpdate.IconRightZoom = 0D;
            this.BtnUpdate.IconVisible = true;
            this.BtnUpdate.IconZoom = 90D;
            this.BtnUpdate.IsTab = false;
            this.BtnUpdate.Location = new System.Drawing.Point(1116, 143);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnUpdate.selected = false;
            this.BtnUpdate.Size = new System.Drawing.Size(431, 113);
            this.BtnUpdate.TabIndex = 16;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUpdate.Textcolor = System.Drawing.Color.Black;
            this.BtnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddNew.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddNew.BorderRadius = 0;
            this.BtnAddNew.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BtnAddNew.ButtonText = "Add New";
            this.BtnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddNew.DisabledColor = System.Drawing.Color.Gray;
            this.BtnAddNew.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAddNew.Iconimage = global::winformProject.Properties.Resources.Add_User_Male_48px;
            this.BtnAddNew.Iconimage_right = null;
            this.BtnAddNew.Iconimage_right_Selected = null;
            this.BtnAddNew.Iconimage_Selected = null;
            this.BtnAddNew.IconMarginLeft = 0;
            this.BtnAddNew.IconMarginRight = 0;
            this.BtnAddNew.IconRightVisible = true;
            this.BtnAddNew.IconRightZoom = 0D;
            this.BtnAddNew.IconVisible = true;
            this.BtnAddNew.IconZoom = 90D;
            this.BtnAddNew.IsTab = false;
            this.BtnAddNew.Location = new System.Drawing.Point(1116, 17);
            this.BtnAddNew.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnAddNew.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnAddNew.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAddNew.selected = false;
            this.BtnAddNew.Size = new System.Drawing.Size(431, 113);
            this.BtnAddNew.TabIndex = 13;
            this.BtnAddNew.Text = "Add New";
            this.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddNew.Textcolor = System.Drawing.Color.Black;
            this.BtnAddNew.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(800, 384);
            this.txtPhoneNum.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(465, 38);
            this.txtPhoneNum.TabIndex = 12;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(800, 322);
            this.txtMail.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(465, 38);
            this.txtMail.TabIndex = 11;
            // 
            // txtLastNane
            // 
            this.txtLastNane.Location = new System.Drawing.Point(800, 260);
            this.txtLastNane.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtLastNane.Name = "txtLastNane";
            this.txtLastNane.Size = new System.Drawing.Size(465, 38);
            this.txtLastNane.TabIndex = 10;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(800, 198);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(465, 38);
            this.txtFirstName.TabIndex = 9;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(800, 136);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(260, 38);
            this.txtUserId.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(645, 391);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 32);
            this.label7.TabIndex = 7;
            this.label7.Text = "PhoneNum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(645, 329);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(645, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(645, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(645, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.BackColor = System.Drawing.Color.Transparent;
            this.lbRole.Location = new System.Drawing.Point(792, 67);
            this.lbRole.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(152, 32);
            this.lbRole.TabIndex = 2;
            this.lbRole.Text = "Role name";
            // 
            // avtBox
            // 
            this.avtBox.Location = new System.Drawing.Point(27, 24);
            this.avtBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.avtBox.Name = "avtBox";
            this.avtBox.Size = new System.Drawing.Size(533, 477);
            this.avtBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avtBox.TabIndex = 0;
            this.avtBox.TabStop = false;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1584, 842);
            this.Controls.Add(this.DataGridEm);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "EmployeeForm";
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEm)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avtBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton BtnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAddNew;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtLastNane;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.PictureBox avtBox;
        private System.Windows.Forms.TextBox txtSearch;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridEm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnUndelete;
    }
}