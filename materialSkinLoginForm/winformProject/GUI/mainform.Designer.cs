namespace winformProject.GUI
{
    partial class mainform
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
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.welcomLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelAnimator = new AnimatorNS.Animator(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slidemenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCarManage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUserManage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.UserAvatar = new System.Windows.Forms.PictureBox();
            this.BtnMenuIcon = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.slidemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenuIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Navy;
            this.header.Controls.Add(this.bunifuImageButton2);
            this.header.Controls.Add(this.welcomLabel);
            this.header.Controls.Add(this.bunifuImageButton1);
            this.panelAnimator.SetDecoration(this.header, AnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(962, 37);
            this.header.TabIndex = 0;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Navy;
            this.panelAnimator.SetDecoration(this.bunifuImageButton2, AnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(915, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(47, 37);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // welcomLabel
            // 
            this.welcomLabel.AutoSize = true;
            this.panelAnimator.SetDecoration(this.welcomLabel, AnimatorNS.DecorationType.None);
            this.welcomLabel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.welcomLabel.Location = new System.Drawing.Point(56, 9);
            this.welcomLabel.Name = "welcomLabel";
            this.welcomLabel.Size = new System.Drawing.Size(335, 47);
            this.welcomLabel.TabIndex = 1;
            this.welcomLabel.Text = "Smart Parking";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.AliceBlue;
            this.panelAnimator.SetDecoration(this.bunifuImageButton1, AnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuImageButton1.Image = global::winformProject.Properties.Resources.kisspng_logo_brand_font_perfect_car_parking_3d_5b1c609fae30503;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(50, 37);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelAnimator
            // 
            this.panelAnimator.AnimationType = AnimatorNS.AnimationType.Custom;
            this.panelAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.panelAnimator.DefaultAnimation = animation1;
            // 
            // contextMenuStrip1
            // 
            this.panelAnimator.SetDecoration(this.contextMenuStrip1, AnimatorNS.DecorationType.None);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showUpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 96);
            // 
            // showUpToolStripMenuItem
            // 
            this.showUpToolStripMenuItem.Name = "showUpToolStripMenuItem";
            this.showUpToolStripMenuItem.Size = new System.Drawing.Size(212, 46);
            this.showUpToolStripMenuItem.Text = "Show up";
            this.showUpToolStripMenuItem.Click += new System.EventHandler(this.showUpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(212, 46);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // slidemenu
            // 
            this.slidemenu.BackColor = System.Drawing.Color.Transparent;
            this.slidemenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slidemenu.BackgroundImage")));
            this.slidemenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slidemenu.Controls.Add(this.bunifuFlatButton4);
            this.slidemenu.Controls.Add(this.btnCarManage);
            this.slidemenu.Controls.Add(this.btnUserManage);
            this.slidemenu.Controls.Add(this.bunifuFlatButton1);
            this.slidemenu.Controls.Add(this.UserAvatar);
            this.slidemenu.Controls.Add(this.BtnMenuIcon);
            this.panelAnimator.SetDecoration(this.slidemenu, AnimatorNS.DecorationType.None);
            this.slidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidemenu.GradientBottomLeft = System.Drawing.Color.MediumBlue;
            this.slidemenu.GradientBottomRight = System.Drawing.Color.LightSkyBlue;
            this.slidemenu.GradientTopLeft = System.Drawing.Color.MidnightBlue;
            this.slidemenu.GradientTopRight = System.Drawing.Color.Lavender;
            this.slidemenu.Location = new System.Drawing.Point(0, 37);
            this.slidemenu.Name = "slidemenu";
            this.slidemenu.Quality = 10;
            this.slidemenu.Size = new System.Drawing.Size(250, 489);
            this.slidemenu.TabIndex = 1;
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "PARKING MANAGEMENT";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.bunifuFlatButton4, AnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 367);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(250, 48);
            this.bunifuFlatButton4.TabIndex = 5;
            this.bunifuFlatButton4.Text = "PARKING MANAGEMENT";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // btnCarManage
            // 
            this.btnCarManage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCarManage.BackColor = System.Drawing.Color.Transparent;
            this.btnCarManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarManage.BorderRadius = 0;
            this.btnCarManage.ButtonText = "CAR MANAGEMENT";
            this.btnCarManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.btnCarManage, AnimatorNS.DecorationType.None);
            this.btnCarManage.DisabledColor = System.Drawing.Color.Gray;
            this.btnCarManage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCarManage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCarManage.Iconimage")));
            this.btnCarManage.Iconimage_right = null;
            this.btnCarManage.Iconimage_right_Selected = null;
            this.btnCarManage.Iconimage_Selected = null;
            this.btnCarManage.IconMarginLeft = 0;
            this.btnCarManage.IconMarginRight = 0;
            this.btnCarManage.IconRightVisible = true;
            this.btnCarManage.IconRightZoom = 0D;
            this.btnCarManage.IconVisible = true;
            this.btnCarManage.IconZoom = 90D;
            this.btnCarManage.IsTab = false;
            this.btnCarManage.Location = new System.Drawing.Point(0, 313);
            this.btnCarManage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCarManage.Name = "btnCarManage";
            this.btnCarManage.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCarManage.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnCarManage.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCarManage.selected = false;
            this.btnCarManage.Size = new System.Drawing.Size(250, 48);
            this.btnCarManage.TabIndex = 4;
            this.btnCarManage.Text = "CAR MANAGEMENT";
            this.btnCarManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarManage.Textcolor = System.Drawing.Color.White;
            this.btnCarManage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarManage.Click += new System.EventHandler(this.btnCarManage_Click);
            // 
            // btnUserManage
            // 
            this.btnUserManage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUserManage.BackColor = System.Drawing.Color.Transparent;
            this.btnUserManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserManage.BorderRadius = 0;
            this.btnUserManage.ButtonText = "USER MANAGEMENT";
            this.btnUserManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.btnUserManage, AnimatorNS.DecorationType.None);
            this.btnUserManage.DisabledColor = System.Drawing.Color.Gray;
            this.btnUserManage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUserManage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUserManage.Iconimage")));
            this.btnUserManage.Iconimage_right = null;
            this.btnUserManage.Iconimage_right_Selected = null;
            this.btnUserManage.Iconimage_Selected = null;
            this.btnUserManage.IconMarginLeft = 0;
            this.btnUserManage.IconMarginRight = 0;
            this.btnUserManage.IconRightVisible = true;
            this.btnUserManage.IconRightZoom = 0D;
            this.btnUserManage.IconVisible = true;
            this.btnUserManage.IconZoom = 90D;
            this.btnUserManage.IsTab = false;
            this.btnUserManage.Location = new System.Drawing.Point(0, 259);
            this.btnUserManage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnUserManage.Name = "btnUserManage";
            this.btnUserManage.Normalcolor = System.Drawing.Color.Transparent;
            this.btnUserManage.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnUserManage.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUserManage.selected = false;
            this.btnUserManage.Size = new System.Drawing.Size(250, 48);
            this.btnUserManage.TabIndex = 3;
            this.btnUserManage.Text = "USER MANAGEMENT";
            this.btnUserManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManage.Textcolor = System.Drawing.Color.White;
            this.btnUserManage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManage.Click += new System.EventHandler(this.btnUserManage_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "VIEW YOUR PROFILE";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.bunifuFlatButton1, AnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 205);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(250, 48);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "VIEW YOUR PROFILE";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // UserAvatar
            // 
            this.UserAvatar.BackColor = System.Drawing.Color.Transparent;
            this.panelAnimator.SetDecoration(this.UserAvatar, AnimatorNS.DecorationType.None);
            this.UserAvatar.Location = new System.Drawing.Point(56, 6);
            this.UserAvatar.Name = "UserAvatar";
            this.UserAvatar.Size = new System.Drawing.Size(135, 135);
            this.UserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserAvatar.TabIndex = 1;
            this.UserAvatar.TabStop = false;
            // 
            // BtnMenuIcon
            // 
            this.BtnMenuIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMenuIcon.BackColor = System.Drawing.Color.Transparent;
            this.panelAnimator.SetDecoration(this.BtnMenuIcon, AnimatorNS.DecorationType.None);
            this.BtnMenuIcon.Image = global::winformProject.Properties.Resources.menu1;
            this.BtnMenuIcon.ImageActive = null;
            this.BtnMenuIcon.Location = new System.Drawing.Point(197, 3);
            this.BtnMenuIcon.Name = "BtnMenuIcon";
            this.BtnMenuIcon.Size = new System.Drawing.Size(50, 50);
            this.BtnMenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMenuIcon.TabIndex = 0;
            this.BtnMenuIcon.TabStop = false;
            this.BtnMenuIcon.Zoom = 10;
            this.BtnMenuIcon.Click += new System.EventHandler(this.BtnMenuIcon_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Run behind";
            this.notifyIcon1.BalloonTipTitle = "SmartPrking";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Smart Parking";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notificationIcon_DoubleClick);
            // 
            // mainform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 526);
            this.Controls.Add(this.slidemenu);
            this.Controls.Add(this.header);
            this.panelAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainform";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.slidemenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenuIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel welcomLabel;
        private Bunifu.Framework.UI.BunifuGradientPanel slidemenu;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton BtnMenuIcon;
        private System.Windows.Forms.PictureBox UserAvatar;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton btnCarManage;
        private Bunifu.Framework.UI.BunifuFlatButton btnUserManage;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private AnimatorNS.Animator panelAnimator;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}