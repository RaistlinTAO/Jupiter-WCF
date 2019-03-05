namespace Jupiter.UI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange1 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange2 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange3 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAccount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdAccount = new System.Windows.Forms.Button();
            this.txtMac = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdAdvance = new System.Windows.Forms.Button();
            this.cmdProcess = new System.Windows.Forms.Button();
            this.txtMemSize = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAccountNumber = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOffline = new System.Windows.Forms.Label();
            this.txtOnline = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdMinimal = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdStart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstWorkstations = new DevExpress.XtraEditors.ImageListBoxControl();
            this.imgStatus = new System.Windows.Forms.ImageList(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmdName = new System.Windows.Forms.Label();
            this.circularGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleNeedleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleSpindleCapComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstWorkstations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstLog
            // 
            this.lstLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLog.ForeColor = System.Drawing.Color.Yellow;
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(6, 20);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(349, 156);
            this.lstLog.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmdAccount);
            this.groupBox1.Controls.Add(this.txtMac);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmdAdvance);
            this.groupBox1.Controls.Add(this.cmdProcess);
            this.groupBox1.Controls.Add(this.txtMemSize);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(586, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 355);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // txtAccount
            // 
            this.txtAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtAccount.Location = new System.Drawing.Point(15, 273);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(194, 21);
            this.txtAccount.TabIndex = 12;
            this.txtAccount.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(12, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Account occupied:";
            // 
            // cmdAccount
            // 
            this.cmdAccount.BackColor = System.Drawing.Color.Gray;
            this.cmdAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAccount.Location = new System.Drawing.Point(115, 326);
            this.cmdAccount.Name = "cmdAccount";
            this.cmdAccount.Size = new System.Drawing.Size(94, 23);
            this.cmdAccount.TabIndex = 10;
            this.cmdAccount.Text = "Account";
            this.cmdAccount.UseVisualStyleBackColor = false;
            this.cmdAccount.Click += new System.EventHandler(this.cmdAccount_Click);
            // 
            // txtMac
            // 
            this.txtMac.ForeColor = System.Drawing.Color.White;
            this.txtMac.Location = new System.Drawing.Point(15, 221);
            this.txtMac.Name = "txtMac";
            this.txtMac.Size = new System.Drawing.Size(194, 21);
            this.txtMac.TabIndex = 9;
            this.txtMac.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(12, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mac Address:";
            // 
            // cmdAdvance
            // 
            this.cmdAdvance.BackColor = System.Drawing.Color.Gray;
            this.cmdAdvance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAdvance.Location = new System.Drawing.Point(6, 326);
            this.cmdAdvance.Name = "cmdAdvance";
            this.cmdAdvance.Size = new System.Drawing.Size(94, 23);
            this.cmdAdvance.TabIndex = 7;
            this.cmdAdvance.Text = "Advance";
            this.cmdAdvance.UseVisualStyleBackColor = false;
            this.cmdAdvance.Click += new System.EventHandler(this.cmdAdvance_Click);
            // 
            // cmdProcess
            // 
            this.cmdProcess.BackColor = System.Drawing.Color.Gray;
            this.cmdProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdProcess.Location = new System.Drawing.Point(6, 297);
            this.cmdProcess.Name = "cmdProcess";
            this.cmdProcess.Size = new System.Drawing.Size(203, 23);
            this.cmdProcess.TabIndex = 6;
            this.cmdProcess.Text = "Check Processes";
            this.cmdProcess.UseVisualStyleBackColor = false;
            this.cmdProcess.Click += new System.EventHandler(this.cmdProcess_Click);
            // 
            // txtMemSize
            // 
            this.txtMemSize.AutoSize = true;
            this.txtMemSize.ForeColor = System.Drawing.Color.Fuchsia;
            this.txtMemSize.Location = new System.Drawing.Point(15, 170);
            this.txtMemSize.Name = "txtMemSize";
            this.txtMemSize.Size = new System.Drawing.Size(25, 13);
            this.txtMemSize.TabIndex = 5;
            this.txtMemSize.Text = "N/A";
            // 
            // txtIP
            // 
            this.txtIP.AutoSize = true;
            this.txtIP.ForeColor = System.Drawing.Color.YellowGreen;
            this.txtIP.Location = new System.Drawing.Point(15, 112);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(25, 13);
            this.txtIP.TabIndex = 4;
            this.txtIP.Text = "N/A";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtName.Location = new System.Drawing.Point(15, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(25, 13);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Memory Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Computer Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAccountNumber);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtOffline);
            this.groupBox2.Controls.Add(this.txtOnline);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmdMinimal);
            this.groupBox2.Controls.Add(this.cmdStop);
            this.groupBox2.Controls.Add(this.cmdStart);
            this.groupBox2.Location = new System.Drawing.Point(379, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 186);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dashboard";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtAccountNumber.Location = new System.Drawing.Point(341, 69);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(66, 16);
            this.txtAccountNumber.TabIndex = 9;
            this.txtAccountNumber.Text = "0";
            this.txtAccountNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(18, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Account Avaliable:";
            // 
            // txtOffline
            // 
            this.txtOffline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtOffline.Location = new System.Drawing.Point(341, 44);
            this.txtOffline.Name = "txtOffline";
            this.txtOffline.Size = new System.Drawing.Size(66, 16);
            this.txtOffline.TabIndex = 7;
            this.txtOffline.Text = "0";
            this.txtOffline.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtOnline
            // 
            this.txtOnline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtOnline.Location = new System.Drawing.Point(341, 20);
            this.txtOnline.Name = "txtOnline";
            this.txtOnline.Size = new System.Drawing.Size(66, 16);
            this.txtOnline.TabIndex = 6;
            this.txtOnline.Text = "0";
            this.txtOnline.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(18, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Offline Workstations:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(18, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Online Workstations:";
            // 
            // cmdMinimal
            // 
            this.cmdMinimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMinimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdMinimal.Location = new System.Drawing.Point(341, 157);
            this.cmdMinimal.Name = "cmdMinimal";
            this.cmdMinimal.Size = new System.Drawing.Size(75, 23);
            this.cmdMinimal.TabIndex = 3;
            this.cmdMinimal.Text = "Minimal";
            this.cmdMinimal.UseVisualStyleBackColor = true;
            this.cmdMinimal.Click += new System.EventHandler(this.cmdMinimal_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdStop.Location = new System.Drawing.Point(260, 157);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(75, 23);
            this.cmdStop.TabIndex = 2;
            this.cmdStop.Text = "Stop";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdStart
            // 
            this.cmdStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdStart.Location = new System.Drawing.Point(179, 157);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 23);
            this.cmdStart.TabIndex = 1;
            this.cmdStart.Text = "&Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstLog);
            this.groupBox3.Location = new System.Drawing.Point(12, 393);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 186);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstWorkstations);
            this.groupBox4.Location = new System.Drawing.Point(12, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(568, 355);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Workstations";
            // 
            // lstWorkstations
            // 
            this.lstWorkstations.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.lstWorkstations.Appearance.BackColor2 = System.Drawing.Color.White;
            this.lstWorkstations.Appearance.BorderColor = System.Drawing.Color.Red;
            this.lstWorkstations.Appearance.ForeColor = System.Drawing.Color.Aqua;
            this.lstWorkstations.Appearance.Options.UseBackColor = true;
            this.lstWorkstations.Appearance.Options.UseBorderColor = true;
            this.lstWorkstations.Appearance.Options.UseForeColor = true;
            this.lstWorkstations.Appearance.Options.UseImage = true;
            this.lstWorkstations.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lstWorkstations.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Standard;
            this.lstWorkstations.ImageList = this.imgStatus;
            this.lstWorkstations.Location = new System.Drawing.Point(6, 20);
            this.lstWorkstations.Name = "lstWorkstations";
            this.lstWorkstations.Size = new System.Drawing.Size(556, 329);
            this.lstWorkstations.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.lstWorkstations.TabIndex = 0;
            this.lstWorkstations.SelectedIndexChanged += new System.EventHandler(this.lstWorkstations_SelectedIndexChanged);
            // 
            // imgStatus
            // 
            this.imgStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgStatus.ImageStream")));
            this.imgStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.imgStatus.Images.SetKeyName(0, "G.png");
            this.imgStatus.Images.SetKeyName(1, "R.png");
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(352, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(101, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Jupiter Core Server";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // cmdName
            // 
            this.cmdName.AutoSize = true;
            this.cmdName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdName.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmdName.Location = new System.Drawing.Point(686, 9);
            this.cmdName.Name = "cmdName";
            this.cmdName.Size = new System.Drawing.Size(115, 13);
            this.cmdName.TabIndex = 8;
            this.cmdName.Text = "Code by : Raistlin TAO";
            this.cmdName.Click += new System.EventHandler(this.cmdName_Click);
            // 
            // circularGauge1
            // 
            this.circularGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 248, 248);
            this.circularGauge1.Name = "circularGauge1";
            // 
            // arcScaleComponent1
            // 
            this.arcScaleComponent1.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8F);
            this.arcScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#393939");
            this.arcScaleComponent1.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.arcScaleComponent1.EndAngle = 60F;
            this.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent1.MajorTickmark.ShapeOffset = -6F;
            this.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style22_1;
            this.arcScaleComponent1.MajorTickmark.TextOffset = 13F;
            this.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent1.MaxValue = 100F;
            this.arcScaleComponent1.MinorTickCount = 4;
            this.arcScaleComponent1.MinorTickmark.ShapeOffset = -6F;
            this.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style22_2;
            this.arcScaleComponent1.Name = "scale1";
            this.arcScaleComponent1.RadiusX = 70F;
            this.arcScaleComponent1.RadiusY = 70F;
            arcScaleRange1.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#95C573");
            arcScaleRange1.EndThickness = 6F;
            arcScaleRange1.EndValue = 33F;
            arcScaleRange1.Name = "Range0";
            arcScaleRange1.ShapeOffset = 29F;
            arcScaleRange1.StartThickness = 6F;
            arcScaleRange2.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#F4C570");
            arcScaleRange2.EndThickness = 6F;
            arcScaleRange2.EndValue = 66F;
            arcScaleRange2.Name = "Range1";
            arcScaleRange2.ShapeOffset = 29F;
            arcScaleRange2.StartThickness = 6F;
            arcScaleRange2.StartValue = 33F;
            arcScaleRange3.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#DC615D");
            arcScaleRange3.EndThickness = 6F;
            arcScaleRange3.EndValue = 100F;
            arcScaleRange3.Name = "Range2";
            arcScaleRange3.ShapeOffset = 29F;
            arcScaleRange3.StartThickness = 6F;
            arcScaleRange3.StartValue = 66F;
            this.arcScaleComponent1.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            arcScaleRange1,
            arcScaleRange2,
            arcScaleRange3});
            this.arcScaleComponent1.StartAngle = -240F;
            // 
            // arcScaleBackgroundLayerComponent1
            // 
            this.arcScaleBackgroundLayerComponent1.Name = "bg1";
            this.arcScaleBackgroundLayerComponent1.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.496F);
            this.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style22;
            this.arcScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // arcScaleNeedleComponent1
            // 
            this.arcScaleNeedleComponent1.EndOffset = 3F;
            this.arcScaleNeedleComponent1.Name = "needle1";
            this.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style22;
            this.arcScaleNeedleComponent1.ZOrder = -50;
            // 
            // arcScaleSpindleCapComponent1
            // 
            this.arcScaleSpindleCapComponent1.Name = "circularGauge8_SpindleCap1";
            this.arcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style22;
            this.arcScaleSpindleCapComponent1.Size = new System.Drawing.SizeF(28F, 28F);
            this.arcScaleSpindleCapComponent1.ZOrder = -100;
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 591);
            this.Controls.Add(this.cmdName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jupiter Core Server";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstWorkstations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Button cmdMinimal;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label cmdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Button cmdAdvance;
        private System.Windows.Forms.Button cmdProcess;
        private System.Windows.Forms.Label txtMemSize;
        private System.Windows.Forms.Label txtIP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtMac;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent arcScaleSpindleCapComponent1;
        private DevExpress.XtraEditors.ImageListBoxControl lstWorkstations;
        private System.Windows.Forms.ImageList imgStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtOffline;
        private System.Windows.Forms.Label txtOnline;
        private System.Windows.Forms.Button cmdAccount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtAccount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtAccountNumber;
    }
}