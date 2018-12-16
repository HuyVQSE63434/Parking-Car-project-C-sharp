namespace winformProject.GUI
{
    partial class ParkingManager
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.historyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblHistorysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartParkingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartParkingDataSet = new winformProject.smartParkingDataSet();
            this.btnPperM = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMperM = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCars = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbParked = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTimes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbFNames = new System.Windows.Forms.Label();
            this.tblHistorysTableAdapter = new winformProject.smartParkingDataSetTableAdapters.tblHistorysTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHistorysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartParkingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartParkingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(914, 2);
            this.chart1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chart1.Size = new System.Drawing.Size(986, 511);
            this.chart1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dgvHistory);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(0, 618);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(1898, 548);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Histories";
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AutoGenerateColumns = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.historyIDDataGridViewTextBoxColumn,
            this.carIDDataGridViewTextBoxColumn,
            this.timeInDataGridViewTextBoxColumn,
            this.timeOutDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn,
            this.keyCodeDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.dgvHistory.DataSource = this.tblHistorysBindingSource;
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHistory.Location = new System.Drawing.Point(8, 55);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowTemplate.Height = 37;
            this.dgvHistory.Size = new System.Drawing.Size(1882, 486);
            this.dgvHistory.TabIndex = 0;
            // 
            // historyIDDataGridViewTextBoxColumn
            // 
            this.historyIDDataGridViewTextBoxColumn.DataPropertyName = "historyID";
            this.historyIDDataGridViewTextBoxColumn.HeaderText = "historyID";
            this.historyIDDataGridViewTextBoxColumn.Name = "historyIDDataGridViewTextBoxColumn";
            this.historyIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carIDDataGridViewTextBoxColumn
            // 
            this.carIDDataGridViewTextBoxColumn.DataPropertyName = "carID";
            this.carIDDataGridViewTextBoxColumn.HeaderText = "carID";
            this.carIDDataGridViewTextBoxColumn.Name = "carIDDataGridViewTextBoxColumn";
            this.carIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeInDataGridViewTextBoxColumn
            // 
            this.timeInDataGridViewTextBoxColumn.DataPropertyName = "timeIn";
            this.timeInDataGridViewTextBoxColumn.HeaderText = "timeIn";
            this.timeInDataGridViewTextBoxColumn.Name = "timeInDataGridViewTextBoxColumn";
            this.timeInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeOutDataGridViewTextBoxColumn
            // 
            this.timeOutDataGridViewTextBoxColumn.DataPropertyName = "timeOut";
            this.timeOutDataGridViewTextBoxColumn.HeaderText = "timeOut";
            this.timeOutDataGridViewTextBoxColumn.Name = "timeOutDataGridViewTextBoxColumn";
            this.timeOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "money";
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            this.moneyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keyCodeDataGridViewTextBoxColumn
            // 
            this.keyCodeDataGridViewTextBoxColumn.DataPropertyName = "keyCode";
            this.keyCodeDataGridViewTextBoxColumn.HeaderText = "keyCode";
            this.keyCodeDataGridViewTextBoxColumn.Name = "keyCodeDataGridViewTextBoxColumn";
            this.keyCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "userID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblHistorysBindingSource
            // 
            this.tblHistorysBindingSource.DataMember = "tblHistorys";
            this.tblHistorysBindingSource.DataSource = this.smartParkingDataSetBindingSource;
            // 
            // smartParkingDataSetBindingSource
            // 
            this.smartParkingDataSetBindingSource.DataSource = this.smartParkingDataSet;
            this.smartParkingDataSetBindingSource.Position = 0;
            // 
            // smartParkingDataSet
            // 
            this.smartParkingDataSet.DataSetName = "smartParkingDataSet";
            this.smartParkingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPperM
            // 
            this.btnPperM.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPperM.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPperM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPperM.BorderRadius = 0;
            this.btnPperM.ButtonText = "Parked Per Month";
            this.btnPperM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPperM.DisabledColor = System.Drawing.Color.Gray;
            this.btnPperM.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPperM.Iconimage = global::winformProject.Properties.Resources.icons8_Garage_32;
            this.btnPperM.Iconimage_right = null;
            this.btnPperM.Iconimage_right_Selected = null;
            this.btnPperM.Iconimage_Selected = null;
            this.btnPperM.IconMarginLeft = 0;
            this.btnPperM.IconMarginRight = 0;
            this.btnPperM.IconRightVisible = true;
            this.btnPperM.IconRightZoom = 0D;
            this.btnPperM.IconVisible = true;
            this.btnPperM.IconZoom = 90D;
            this.btnPperM.IsTab = false;
            this.btnPperM.Location = new System.Drawing.Point(13, 14);
            this.btnPperM.Margin = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.btnPperM.Name = "btnPperM";
            this.btnPperM.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnPperM.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPperM.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPperM.selected = false;
            this.btnPperM.Size = new System.Drawing.Size(402, 107);
            this.btnPperM.TabIndex = 7;
            this.btnPperM.Text = "Parked Per Month";
            this.btnPperM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPperM.Textcolor = System.Drawing.Color.White;
            this.btnPperM.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPperM.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnMperM
            // 
            this.btnMperM.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMperM.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMperM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMperM.BorderRadius = 0;
            this.btnMperM.ButtonText = "Money Per Month";
            this.btnMperM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMperM.DisabledColor = System.Drawing.Color.Gray;
            this.btnMperM.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMperM.Iconimage = global::winformProject.Properties.Resources.icons8_Fund_Accounting_481;
            this.btnMperM.Iconimage_right = null;
            this.btnMperM.Iconimage_right_Selected = null;
            this.btnMperM.Iconimage_Selected = null;
            this.btnMperM.IconMarginLeft = 0;
            this.btnMperM.IconMarginRight = 0;
            this.btnMperM.IconRightVisible = true;
            this.btnMperM.IconRightZoom = 0D;
            this.btnMperM.IconVisible = true;
            this.btnMperM.IconZoom = 90D;
            this.btnMperM.IsTab = false;
            this.btnMperM.Location = new System.Drawing.Point(486, 14);
            this.btnMperM.Margin = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.btnMperM.Name = "btnMperM";
            this.btnMperM.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnMperM.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMperM.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMperM.selected = false;
            this.btnMperM.Size = new System.Drawing.Size(402, 107);
            this.btnMperM.TabIndex = 3;
            this.btnMperM.Text = "Money Per Month";
            this.btnMperM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMperM.Textcolor = System.Drawing.Color.White;
            this.btnMperM.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMperM.Click += new System.EventHandler(this.btnMperM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(39, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "User:";
            // 
            // cbUser
            // 
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(233, 248);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(294, 39);
            this.cbUser.TabIndex = 11;
            this.cbUser.SelectedIndexChanged += new System.EventHandler(this.cbUser_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(39, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 46);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cars:";
            // 
            // lbCars
            // 
            this.lbCars.AutoSize = true;
            this.lbCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCars.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbCars.Location = new System.Drawing.Point(225, 386);
            this.lbCars.Name = "lbCars";
            this.lbCars.Size = new System.Drawing.Size(286, 46);
            this.lbCars.TabIndex = 13;
            this.lbCars.Text = "number of cars";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(39, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 46);
            this.label3.TabIndex = 14;
            this.label3.Text = "parked:";
            // 
            // lbParked
            // 
            this.lbParked.AutoSize = true;
            this.lbParked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParked.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbParked.Location = new System.Drawing.Point(245, 467);
            this.lbParked.Name = "lbParked";
            this.lbParked.Size = new System.Drawing.Size(338, 46);
            this.lbParked.TabIndex = 15;
            this.lbParked.Text = "Number of parked";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(39, 544);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 46);
            this.label4.TabIndex = 16;
            this.label4.Text = "Times:";
            // 
            // lbTimes
            // 
            this.lbTimes.AutoSize = true;
            this.lbTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimes.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbTimes.Location = new System.Drawing.Point(225, 544);
            this.lbTimes.Name = "lbTimes";
            this.lbTimes.Size = new System.Drawing.Size(489, 46);
            this.lbTimes.TabIndex = 17;
            this.lbTimes.Text = "Number of times of parked";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(39, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 46);
            this.label5.TabIndex = 18;
            this.label5.Text = "Full name:";
            // 
            // lbFNames
            // 
            this.lbFNames.AutoSize = true;
            this.lbFNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFNames.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbFNames.Location = new System.Drawing.Point(267, 308);
            this.lbFNames.Name = "lbFNames";
            this.lbFNames.Size = new System.Drawing.Size(181, 46);
            this.lbFNames.TabIndex = 19;
            this.lbFNames.Text = "full name";
            // 
            // tblHistorysTableAdapter
            // 
            this.tblHistorysTableAdapter.ClearBeforeFill = true;
            // 
            // ParkingManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1898, 1166);
            this.Controls.Add(this.lbFNames);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTimes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbParked);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCars);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPperM);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMperM);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ParkingManager";
            this.Text = "ParkingManager";
            this.Load += new System.EventHandler(this.ParkingManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHistorysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartParkingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartParkingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Bunifu.Framework.UI.BunifuFlatButton btnMperM;
        private Bunifu.Framework.UI.BunifuFlatButton btnPperM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCars;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbParked;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTimes;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbFNames;
        private System.Windows.Forms.BindingSource smartParkingDataSetBindingSource;
        private smartParkingDataSet smartParkingDataSet;
        private System.Windows.Forms.BindingSource tblHistorysBindingSource;
        private smartParkingDataSetTableAdapters.tblHistorysTableAdapter tblHistorysTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn historyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
    }
}