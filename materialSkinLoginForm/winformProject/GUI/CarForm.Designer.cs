namespace winformProject.GUI
{
    partial class CarForm
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
            System.Windows.Forms.Label carIdLabel;
            System.Windows.Forms.Label carNameLabel;
            System.Windows.Forms.Label licensePlateLabel;
            System.Windows.Forms.Label userIdLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridCar = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.carIdTextBox = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.carNameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.licensePlateTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.UserIDDropD = new System.Windows.Forms.ComboBox();
            this.statusLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUndelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.avtBox = new System.Windows.Forms.PictureBox();
            this.btnDeleteCar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdateCar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddCar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.carIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensePlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carIFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            carIdLabel = new System.Windows.Forms.Label();
            carNameLabel = new System.Windows.Forms.Label();
            licensePlateLabel = new System.Windows.Forms.Label();
            userIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carIFBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // carIdLabel
            // 
            carIdLabel.AutoSize = true;
            carIdLabel.Location = new System.Drawing.Point(595, 83);
            carIdLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            carIdLabel.Name = "carIdLabel";
            carIdLabel.Size = new System.Drawing.Size(98, 32);
            carIdLabel.TabIndex = 2;
            carIdLabel.Text = "Car Id:";
            // 
            // carNameLabel
            // 
            carNameLabel.AutoSize = true;
            carNameLabel.Location = new System.Drawing.Point(581, 160);
            carNameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            carNameLabel.Name = "carNameLabel";
            carNameLabel.Size = new System.Drawing.Size(150, 32);
            carNameLabel.TabIndex = 4;
            carNameLabel.Text = "Car Name:";
            // 
            // licensePlateLabel
            // 
            licensePlateLabel.AutoSize = true;
            licensePlateLabel.Location = new System.Drawing.Point(581, 289);
            licensePlateLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            licensePlateLabel.Name = "licensePlateLabel";
            licensePlateLabel.Size = new System.Drawing.Size(186, 32);
            licensePlateLabel.TabIndex = 6;
            licensePlateLabel.Text = "license Plate:";
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new System.Drawing.Point(581, 396);
            userIdLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(112, 32);
            userIdLabel.TabIndex = 8;
            userIdLabel.Text = "User Id:";
            // 
            // DataGridCar
            // 
            this.DataGridCar.AllowUserToAddRows = false;
            this.DataGridCar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridCar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridCar.AutoGenerateColumns = false;
            this.DataGridCar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridCar.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridCar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridCar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIdDataGridViewTextBoxColumn,
            this.carNameDataGridViewTextBoxColumn,
            this.licensePlateDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.Status});
            this.DataGridCar.DataSource = this.carIFBindingSource;
            this.DataGridCar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridCar.DoubleBuffered = true;
            this.DataGridCar.EnableHeadersVisualStyles = false;
            this.DataGridCar.HeaderBgColor = System.Drawing.Color.MediumSlateBlue;
            this.DataGridCar.HeaderForeColor = System.Drawing.Color.Aqua;
            this.DataGridCar.Location = new System.Drawing.Point(0, 375);
            this.DataGridCar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DataGridCar.Name = "DataGridCar";
            this.DataGridCar.ReadOnly = true;
            this.DataGridCar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridCar.Size = new System.Drawing.Size(1584, 467);
            this.DataGridCar.TabIndex = 11;
            this.DataGridCar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCar_CellContentClick);
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 534);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nearest Photo";
            // 
            // carIdTextBox
            // 
            this.carIdTextBox.AutoSize = true;
            this.carIdTextBox.Location = new System.Drawing.Point(811, 83);
            this.carIdTextBox.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.carIdTextBox.Name = "carIdTextBox";
            this.carIdTextBox.Size = new System.Drawing.Size(90, 32);
            this.carIdTextBox.TabIndex = 18;
            this.carIdTextBox.Text = "Car Id";
            // 
            // carNameTextBox
            // 
            this.carNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carNameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.carNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.carNameTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.carNameTextBox.HintText = "";
            this.carNameTextBox.isPassword = false;
            this.carNameTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.carNameTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.carNameTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.carNameTextBox.LineThickness = 3;
            this.carNameTextBox.Location = new System.Drawing.Point(816, 141);
            this.carNameTextBox.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.carNameTextBox.Name = "carNameTextBox";
            this.carNameTextBox.Size = new System.Drawing.Size(483, 107);
            this.carNameTextBox.TabIndex = 19;
            this.carNameTextBox.Text = "Car Name";
            this.carNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.carNameTextBox.OnValueChanged += new System.EventHandler(this.carNameTextBox_OnValueChanged);
            // 
            // licensePlateTextBox
            // 
            this.licensePlateTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.licensePlateTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.licensePlateTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.licensePlateTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.licensePlateTextBox.HintText = "";
            this.licensePlateTextBox.isPassword = false;
            this.licensePlateTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.licensePlateTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.licensePlateTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.licensePlateTextBox.LineThickness = 3;
            this.licensePlateTextBox.Location = new System.Drawing.Point(816, 260);
            this.licensePlateTextBox.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.licensePlateTextBox.Name = "licensePlateTextBox";
            this.licensePlateTextBox.Size = new System.Drawing.Size(483, 107);
            this.licensePlateTextBox.TabIndex = 20;
            this.licensePlateTextBox.Text = "license plate";
            this.licensePlateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UserIDDropD
            // 
            this.UserIDDropD.FormattingEnabled = true;
            this.UserIDDropD.Location = new System.Drawing.Point(816, 396);
            this.UserIDDropD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserIDDropD.Name = "UserIDDropD";
            this.UserIDDropD.Size = new System.Drawing.Size(223, 39);
            this.UserIDDropD.TabIndex = 23;
            this.UserIDDropD.Text = "UserId";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(1067, 403);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(98, 32);
            this.statusLabel.TabIndex = 24;
            this.statusLabel.Text = "status ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 25;
            this.label2.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(816, 472);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(527, 38);
            this.txtSearch.TabIndex = 26;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnUndelete
            // 
            this.btnUndelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndelete.BackColor = System.Drawing.Color.Transparent;
            this.btnUndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUndelete.BorderRadius = 0;
            this.btnUndelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnUndelete.ButtonText = "UnDelete Car";
            this.btnUndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUndelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnUndelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUndelete.Iconimage = global::winformProject.Properties.Resources.icons8_undelete_48;
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
            this.btnUndelete.Location = new System.Drawing.Point(1111, 331);
            this.btnUndelete.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.btnUndelete.Name = "btnUndelete";
            this.btnUndelete.Normalcolor = System.Drawing.Color.Transparent;
            this.btnUndelete.OnHovercolor = System.Drawing.Color.Fuchsia;
            this.btnUndelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUndelete.selected = false;
            this.btnUndelete.Size = new System.Drawing.Size(428, 86);
            this.btnUndelete.TabIndex = 27;
            this.btnUndelete.Text = "UnDelete Car";
            this.btnUndelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUndelete.Textcolor = System.Drawing.Color.Black;
            this.btnUndelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndelete.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // avtBox
            // 
            this.avtBox.Image = global::winformProject.Properties.Resources.anh_troll_facebook_10;
            this.avtBox.Location = new System.Drawing.Point(32, 29);
            this.avtBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.avtBox.Name = "avtBox";
            this.avtBox.Size = new System.Drawing.Size(533, 477);
            this.avtBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avtBox.TabIndex = 22;
            this.avtBox.TabStop = false;
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCar.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteCar.BorderRadius = 0;
            this.btnDeleteCar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnDeleteCar.ButtonText = "Delete Car";
            this.btnDeleteCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCar.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteCar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteCar.Iconimage = global::winformProject.Properties.Resources.icons8_delete_64;
            this.btnDeleteCar.Iconimage_right = null;
            this.btnDeleteCar.Iconimage_right_Selected = null;
            this.btnDeleteCar.Iconimage_Selected = null;
            this.btnDeleteCar.IconMarginLeft = 0;
            this.btnDeleteCar.IconMarginRight = 0;
            this.btnDeleteCar.IconRightVisible = true;
            this.btnDeleteCar.IconRightZoom = 0D;
            this.btnDeleteCar.IconVisible = true;
            this.btnDeleteCar.IconZoom = 90D;
            this.btnDeleteCar.IsTab = false;
            this.btnDeleteCar.Location = new System.Drawing.Point(1111, 228);
            this.btnDeleteCar.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDeleteCar.OnHovercolor = System.Drawing.Color.Fuchsia;
            this.btnDeleteCar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteCar.selected = false;
            this.btnDeleteCar.Size = new System.Drawing.Size(428, 93);
            this.btnDeleteCar.TabIndex = 15;
            this.btnDeleteCar.Text = "Delete Car";
            this.btnDeleteCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteCar.Textcolor = System.Drawing.Color.Black;
            this.btnDeleteCar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdateCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateCar.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateCar.BorderRadius = 0;
            this.btnUpdateCar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnUpdateCar.ButtonText = "Update Car";
            this.btnUpdateCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateCar.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateCar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateCar.Iconimage = global::winformProject.Properties.Resources.icons8_downloading_updates_64;
            this.btnUpdateCar.Iconimage_right = null;
            this.btnUpdateCar.Iconimage_right_Selected = null;
            this.btnUpdateCar.Iconimage_Selected = null;
            this.btnUpdateCar.IconMarginLeft = 0;
            this.btnUpdateCar.IconMarginRight = 0;
            this.btnUpdateCar.IconRightVisible = true;
            this.btnUpdateCar.IconRightZoom = 0D;
            this.btnUpdateCar.IconVisible = true;
            this.btnUpdateCar.IconZoom = 90D;
            this.btnUpdateCar.IsTab = false;
            this.btnUpdateCar.Location = new System.Drawing.Point(1111, 121);
            this.btnUpdateCar.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnUpdateCar.OnHovercolor = System.Drawing.Color.Fuchsia;
            this.btnUpdateCar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateCar.selected = false;
            this.btnUpdateCar.Size = new System.Drawing.Size(428, 95);
            this.btnUpdateCar.TabIndex = 14;
            this.btnUpdateCar.Text = "Update Car";
            this.btnUpdateCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateCar.Textcolor = System.Drawing.Color.Black;
            this.btnUpdateCar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCar.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCar.BorderRadius = 0;
            this.btnAddCar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnAddCar.ButtonText = "Add New Car";
            this.btnAddCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddCar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddCar.Iconimage = global::winformProject.Properties.Resources.icons8_plus_64;
            this.btnAddCar.Iconimage_right = null;
            this.btnAddCar.Iconimage_right_Selected = null;
            this.btnAddCar.Iconimage_Selected = null;
            this.btnAddCar.IconMarginLeft = 0;
            this.btnAddCar.IconMarginRight = 0;
            this.btnAddCar.IconRightVisible = true;
            this.btnAddCar.IconRightZoom = 0D;
            this.btnAddCar.IconVisible = true;
            this.btnAddCar.IconZoom = 90D;
            this.btnAddCar.IsTab = false;
            this.btnAddCar.Location = new System.Drawing.Point(1111, 20);
            this.btnAddCar.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAddCar.OnHovercolor = System.Drawing.Color.Fuchsia;
            this.btnAddCar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddCar.selected = false;
            this.btnAddCar.Size = new System.Drawing.Size(428, 94);
            this.btnAddCar.TabIndex = 13;
            this.btnAddCar.Text = "Add New Car";
            this.btnAddCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCar.Textcolor = System.Drawing.Color.Black;
            this.btnAddCar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // carIdDataGridViewTextBoxColumn
            // 
            this.carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
            this.carIdDataGridViewTextBoxColumn.HeaderText = "CarId";
            this.carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
            this.carIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carNameDataGridViewTextBoxColumn
            // 
            this.carNameDataGridViewTextBoxColumn.DataPropertyName = "CarName";
            this.carNameDataGridViewTextBoxColumn.HeaderText = "CarName";
            this.carNameDataGridViewTextBoxColumn.Name = "carNameDataGridViewTextBoxColumn";
            this.carNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // licensePlateDataGridViewTextBoxColumn
            // 
            this.licensePlateDataGridViewTextBoxColumn.DataPropertyName = "licensePlate";
            this.licensePlateDataGridViewTextBoxColumn.HeaderText = "licensePlate";
            this.licensePlateDataGridViewTextBoxColumn.Name = "licensePlateDataGridViewTextBoxColumn";
            this.licensePlateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carIFBindingSource
            // 
            this.carIFBindingSource.DataSource = typeof(winformProject.DTO.CarIF);
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1584, 842);
            this.Controls.Add(this.btnUndelete);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.UserIDDropD);
            this.Controls.Add(this.avtBox);
            this.Controls.Add(this.licensePlateTextBox);
            this.Controls.Add(this.carNameTextBox);
            this.Controls.Add(this.carIdTextBox);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnUpdateCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridCar);
            this.Controls.Add(carIdLabel);
            this.Controls.Add(carNameLabel);
            this.Controls.Add(licensePlateLabel);
            this.Controls.Add(userIdLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "CarForm";
            this.Text = "CarForm";
            this.Load += new System.EventHandler(this.CarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carIFBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource carIFBindingSource;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddCar;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateCar;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteCar;
        private Bunifu.Framework.UI.BunifuCustomLabel carIdTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox carNameTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox licensePlateTextBox;
        private System.Windows.Forms.PictureBox avtBox;
        private System.Windows.Forms.ComboBox UserIDDropD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private Bunifu.Framework.UI.BunifuCustomLabel statusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnUndelete;
    }
}