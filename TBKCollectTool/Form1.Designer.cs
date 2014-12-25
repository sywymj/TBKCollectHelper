namespace TBKCollectTool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxUrl = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonCollect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveCSV = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExportToDB = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDisp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMakeLink = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelSelectCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarToDb = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelLog = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxEms = new System.Windows.Forms.CheckBox();
            this.textBoxCateID = new System.Windows.Forms.TextBox();
            this.checkBoxPxj = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.textBoxProductTableName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDbName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDbPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDbUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDbPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDbServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBoxModify = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dateTimePickerAddF = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAddB = new System.Windows.Forms.DateTimePicker();
            this.checkBoxIsTmall = new System.Windows.Forms.CheckBox();
            this.buttonModifyToDB = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.textBoxModifyCatiID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePickerModifyF = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTimePickerModifyB = new System.Windows.Forms.DateTimePicker();
            this.checkBoxModifyPxj = new System.Windows.Forms.CheckBox();
            this.checkBoxModifyEms = new System.Windows.Forms.CheckBox();
            this.groupBoxQuery = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxQueryNumiiD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxQueryKey = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxQueryCateID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerQueryE = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePickerQueryB = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.treeViewEmsSeparate = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEmsCopyID = new System.Windows.Forms.Button();
            this.buttonEmsSeparate = new System.Windows.Forms.Button();
            this.richTextBoxLinkEmsSeparater = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBoxModify.SuspendLayout();
            this.groupBoxQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonHome,
            this.toolStripButtonBack,
            this.toolStripButtonNext,
            this.toolStripButtonFresh,
            this.toolStripSeparator1,
            this.toolStripTextBoxUrl,
            this.toolStripButtonCollect,
            this.toolStripButtonClear,
            this.toolStripButtonSaveCSV,
            this.toolStripButtonExportToDB,
            this.toolStripButtonDisp,
            this.toolStripButtonMakeLink});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(918, 49);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonHome
            // 
            this.toolStripButtonHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHome.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHome.Image")));
            this.toolStripButtonHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHome.Name = "toolStripButtonHome";
            this.toolStripButtonHome.Size = new System.Drawing.Size(23, 46);
            this.toolStripButtonHome.Text = "主页";
            this.toolStripButtonHome.ToolTipText = "主页";
            this.toolStripButtonHome.Click += new System.EventHandler(this.toolStripButtonHome_Click);
            // 
            // toolStripButtonBack
            // 
            this.toolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBack.Image")));
            this.toolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBack.Name = "toolStripButtonBack";
            this.toolStripButtonBack.Size = new System.Drawing.Size(23, 46);
            this.toolStripButtonBack.Text = "toolStripButton2";
            this.toolStripButtonBack.ToolTipText = "上一个";
            this.toolStripButtonBack.Click += new System.EventHandler(this.toolStripButtonBack_Click);
            // 
            // toolStripButtonNext
            // 
            this.toolStripButtonNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNext.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNext.Image")));
            this.toolStripButtonNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNext.Name = "toolStripButtonNext";
            this.toolStripButtonNext.Size = new System.Drawing.Size(23, 46);
            this.toolStripButtonNext.Text = "toolStripButton3";
            this.toolStripButtonNext.ToolTipText = "下一个";
            this.toolStripButtonNext.Click += new System.EventHandler(this.toolStripButtonNext_Click);
            // 
            // toolStripButtonFresh
            // 
            this.toolStripButtonFresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFresh.Image")));
            this.toolStripButtonFresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFresh.Name = "toolStripButtonFresh";
            this.toolStripButtonFresh.Size = new System.Drawing.Size(23, 46);
            this.toolStripButtonFresh.Text = "toolStripButton4";
            this.toolStripButtonFresh.ToolTipText = "刷新";
            this.toolStripButtonFresh.Click += new System.EventHandler(this.toolStripButtonFresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 49);
            // 
            // toolStripTextBoxUrl
            // 
            this.toolStripTextBoxUrl.AutoSize = false;
            this.toolStripTextBoxUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxUrl.Name = "toolStripTextBoxUrl";
            this.toolStripTextBoxUrl.Size = new System.Drawing.Size(400, 23);
            this.toolStripTextBoxUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxUrl_KeyUp);
            // 
            // toolStripButtonCollect
            // 
            this.toolStripButtonCollect.AutoSize = false;
            this.toolStripButtonCollect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCollect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCollect.Image")));
            this.toolStripButtonCollect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonCollect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCollect.Name = "toolStripButtonCollect";
            this.toolStripButtonCollect.Size = new System.Drawing.Size(55, 46);
            this.toolStripButtonCollect.Text = "采集(&S)";
            this.toolStripButtonCollect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonCollect.ToolTipText = "采集";
            this.toolStripButtonCollect.Click += new System.EventHandler(this.toolStripButtonCollect_Click);
            // 
            // toolStripButtonClear
            // 
            this.toolStripButtonClear.AutoSize = false;
            this.toolStripButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClear.Image")));
            this.toolStripButtonClear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Size = new System.Drawing.Size(46, 46);
            this.toolStripButtonClear.Text = "清空";
            this.toolStripButtonClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonClear.ToolTipText = "清空";
            this.toolStripButtonClear.Click += new System.EventHandler(this.toolStripButtonClear_Click);
            // 
            // toolStripButtonSaveCSV
            // 
            this.toolStripButtonSaveCSV.AutoSize = false;
            this.toolStripButtonSaveCSV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveCSV.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveCSV.Image")));
            this.toolStripButtonSaveCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveCSV.Name = "toolStripButtonSaveCSV";
            this.toolStripButtonSaveCSV.Size = new System.Drawing.Size(46, 46);
            this.toolStripButtonSaveCSV.Text = "导出CSV";
            this.toolStripButtonSaveCSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonSaveCSV.ToolTipText = "导出CSV";
            this.toolStripButtonSaveCSV.Click += new System.EventHandler(this.toolStripButtonSaveCSV_Click);
            // 
            // toolStripButtonExportToDB
            // 
            this.toolStripButtonExportToDB.AutoSize = false;
            this.toolStripButtonExportToDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExportToDB.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExportToDB.Image")));
            this.toolStripButtonExportToDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExportToDB.Name = "toolStripButtonExportToDB";
            this.toolStripButtonExportToDB.Size = new System.Drawing.Size(46, 46);
            this.toolStripButtonExportToDB.Text = "导入到数据库";
            this.toolStripButtonExportToDB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonExportToDB.Click += new System.EventHandler(this.toolStripButtonExportToDB_Click);
            // 
            // toolStripButtonDisp
            // 
            this.toolStripButtonDisp.AutoSize = false;
            this.toolStripButtonDisp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDisp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDisp.Image")));
            this.toolStripButtonDisp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDisp.Name = "toolStripButtonDisp";
            this.toolStripButtonDisp.Size = new System.Drawing.Size(46, 46);
            this.toolStripButtonDisp.Text = "显示已选择商品信息";
            this.toolStripButtonDisp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonDisp.Click += new System.EventHandler(this.toolStripButtonDisp_Click);
            // 
            // toolStripButtonMakeLink
            // 
            this.toolStripButtonMakeLink.AutoSize = false;
            this.toolStripButtonMakeLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMakeLink.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMakeLink.Image")));
            this.toolStripButtonMakeLink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMakeLink.Name = "toolStripButtonMakeLink";
            this.toolStripButtonMakeLink.Size = new System.Drawing.Size(46, 46);
            this.toolStripButtonMakeLink.Text = "复制产品链接";
            this.toolStripButtonMakeLink.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonMakeLink.Click += new System.EventHandler(this.toolStripButtonMakeLink_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSelectCount,
            this.toolStripProgressBarToDb,
            this.toolStripStatusLabelLog});
            this.statusStrip1.Location = new System.Drawing.Point(0, 653);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(918, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelSelectCount
            // 
            this.toolStripStatusLabelSelectCount.AutoSize = false;
            this.toolStripStatusLabelSelectCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelSelectCount.Name = "toolStripStatusLabelSelectCount";
            this.toolStripStatusLabelSelectCount.Size = new System.Drawing.Size(200, 17);
            this.toolStripStatusLabelSelectCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBarToDb
            // 
            this.toolStripProgressBarToDb.Name = "toolStripProgressBarToDb";
            this.toolStripProgressBarToDb.Size = new System.Drawing.Size(150, 16);
            // 
            // toolStripStatusLabelLog
            // 
            this.toolStripStatusLabelLog.AutoSize = false;
            this.toolStripStatusLabelLog.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelLog.Name = "toolStripStatusLabelLog";
            this.toolStripStatusLabelLog.Size = new System.Drawing.Size(551, 17);
            this.toolStripStatusLabelLog.Spring = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(918, 604);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(910, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "浏览器";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(904, 572);
            this.webBrowser1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(910, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "系统设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(904, 572);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.checkBoxEms);
            this.groupBox3.Controls.Add(this.textBoxCateID);
            this.groupBox3.Controls.Add(this.checkBoxPxj);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(7, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 132);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "导出文件参数设置";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "开始时间：";
            // 
            // checkBoxEms
            // 
            this.checkBoxEms.AutoSize = true;
            this.checkBoxEms.Location = new System.Drawing.Point(10, 20);
            this.checkBoxEms.Name = "checkBoxEms";
            this.checkBoxEms.Size = new System.Drawing.Size(48, 16);
            this.checkBoxEms.TabIndex = 0;
            this.checkBoxEms.Text = "包邮";
            this.checkBoxEms.UseVisualStyleBackColor = true;
            // 
            // textBoxCateID
            // 
            this.textBoxCateID.Location = new System.Drawing.Point(75, 96);
            this.textBoxCateID.Name = "textBoxCateID";
            this.textBoxCateID.Size = new System.Drawing.Size(148, 21);
            this.textBoxCateID.TabIndex = 7;
            // 
            // checkBoxPxj
            // 
            this.checkBoxPxj.AutoSize = true;
            this.checkBoxPxj.Location = new System.Drawing.Point(75, 19);
            this.checkBoxPxj.Name = "checkBoxPxj";
            this.checkBoxPxj.Size = new System.Drawing.Size(72, 16);
            this.checkBoxPxj.TabIndex = 1;
            this.checkBoxPxj.Text = "拍下减价";
            this.checkBoxPxj.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "分类编码：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(75, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 21);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "结束时间：";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(75, 68);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(148, 21);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSaveConfig);
            this.groupBox1.Controls.Add(this.textBoxProductTableName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxDbName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxDbPass);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxDbUser);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxDbPort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxDbServer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 209);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库参数";
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.Location = new System.Drawing.Point(84, 181);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(125, 23);
            this.buttonSaveConfig.TabIndex = 12;
            this.buttonSaveConfig.Text = "保存设置";
            this.buttonSaveConfig.UseVisualStyleBackColor = true;
            this.buttonSaveConfig.Click += new System.EventHandler(this.buttonSaveConfig_Click);
            // 
            // textBoxProductTableName
            // 
            this.textBoxProductTableName.Location = new System.Drawing.Point(84, 153);
            this.textBoxProductTableName.Name = "textBoxProductTableName";
            this.textBoxProductTableName.Size = new System.Drawing.Size(139, 21);
            this.textBoxProductTableName.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "商品表名称：";
            // 
            // textBoxDbName
            // 
            this.textBoxDbName.Location = new System.Drawing.Point(84, 126);
            this.textBoxDbName.Name = "textBoxDbName";
            this.textBoxDbName.Size = new System.Drawing.Size(139, 21);
            this.textBoxDbName.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "数据库名称：";
            // 
            // textBoxDbPass
            // 
            this.textBoxDbPass.Location = new System.Drawing.Point(84, 99);
            this.textBoxDbPass.Name = "textBoxDbPass";
            this.textBoxDbPass.PasswordChar = '*';
            this.textBoxDbPass.Size = new System.Drawing.Size(139, 21);
            this.textBoxDbPass.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "数据库密码：";
            // 
            // textBoxDbUser
            // 
            this.textBoxDbUser.Location = new System.Drawing.Point(84, 72);
            this.textBoxDbUser.Name = "textBoxDbUser";
            this.textBoxDbUser.Size = new System.Drawing.Size(139, 21);
            this.textBoxDbUser.TabIndex = 5;
            this.textBoxDbUser.Text = "root";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "数据库用户：";
            // 
            // textBoxDbPort
            // 
            this.textBoxDbPort.Location = new System.Drawing.Point(84, 45);
            this.textBoxDbPort.Name = "textBoxDbPort";
            this.textBoxDbPort.Size = new System.Drawing.Size(139, 21);
            this.textBoxDbPort.TabIndex = 3;
            this.textBoxDbPort.Text = "3306";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "数据库端口：";
            // 
            // textBoxDbServer
            // 
            this.textBoxDbServer.Location = new System.Drawing.Point(84, 18);
            this.textBoxDbServer.Name = "textBoxDbServer";
            this.textBoxDbServer.Size = new System.Drawing.Size(139, 21);
            this.textBoxDbServer.TabIndex = 1;
            this.textBoxDbServer.Text = "localhost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "数据库地址：";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(910, 578);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "数据查询";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxModify);
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxQuery);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridViewProduct);
            this.splitContainer2.Size = new System.Drawing.Size(904, 572);
            this.splitContainer2.SplitterDistance = 245;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBoxModify
            // 
            this.groupBoxModify.Controls.Add(this.label18);
            this.groupBoxModify.Controls.Add(this.dateTimePickerAddF);
            this.groupBoxModify.Controls.Add(this.dateTimePickerAddB);
            this.groupBoxModify.Controls.Add(this.checkBoxIsTmall);
            this.groupBoxModify.Controls.Add(this.buttonModifyToDB);
            this.groupBoxModify.Controls.Add(this.buttonModify);
            this.groupBoxModify.Controls.Add(this.textBoxModifyCatiID);
            this.groupBoxModify.Controls.Add(this.label15);
            this.groupBoxModify.Controls.Add(this.label16);
            this.groupBoxModify.Controls.Add(this.dateTimePickerModifyF);
            this.groupBoxModify.Controls.Add(this.label17);
            this.groupBoxModify.Controls.Add(this.dateTimePickerModifyB);
            this.groupBoxModify.Controls.Add(this.checkBoxModifyPxj);
            this.groupBoxModify.Controls.Add(this.checkBoxModifyEms);
            this.groupBoxModify.Location = new System.Drawing.Point(9, 347);
            this.groupBoxModify.Name = "groupBoxModify";
            this.groupBoxModify.Size = new System.Drawing.Size(225, 220);
            this.groupBoxModify.TabIndex = 11;
            this.groupBoxModify.TabStop = false;
            this.groupBoxModify.Text = "数据修改";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 138);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 21;
            this.label18.Text = "上传时间：";
            // 
            // dateTimePickerAddF
            // 
            this.dateTimePickerAddF.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerAddF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAddF.Location = new System.Drawing.Point(68, 150);
            this.dateTimePickerAddF.Name = "dateTimePickerAddF";
            this.dateTimePickerAddF.Size = new System.Drawing.Size(151, 21);
            this.dateTimePickerAddF.TabIndex = 20;
            this.dateTimePickerAddF.Value = new System.DateTime(2014, 12, 23, 15, 50, 32, 0);
            // 
            // dateTimePickerAddB
            // 
            this.dateTimePickerAddB.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerAddB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAddB.Location = new System.Drawing.Point(68, 123);
            this.dateTimePickerAddB.Name = "dateTimePickerAddB";
            this.dateTimePickerAddB.Size = new System.Drawing.Size(151, 21);
            this.dateTimePickerAddB.TabIndex = 19;
            this.dateTimePickerAddB.Value = new System.DateTime(2014, 12, 23, 15, 50, 32, 0);
            // 
            // checkBoxIsTmall
            // 
            this.checkBoxIsTmall.AutoSize = true;
            this.checkBoxIsTmall.Checked = true;
            this.checkBoxIsTmall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsTmall.Location = new System.Drawing.Point(162, 20);
            this.checkBoxIsTmall.Name = "checkBoxIsTmall";
            this.checkBoxIsTmall.Size = new System.Drawing.Size(48, 16);
            this.checkBoxIsTmall.TabIndex = 18;
            this.checkBoxIsTmall.Text = "天猫";
            this.checkBoxIsTmall.UseVisualStyleBackColor = true;
            // 
            // buttonModifyToDB
            // 
            this.buttonModifyToDB.Location = new System.Drawing.Point(118, 190);
            this.buttonModifyToDB.Name = "buttonModifyToDB";
            this.buttonModifyToDB.Size = new System.Drawing.Size(99, 23);
            this.buttonModifyToDB.TabIndex = 17;
            this.buttonModifyToDB.Text = "导入数据库";
            this.buttonModifyToDB.UseVisualStyleBackColor = true;
            this.buttonModifyToDB.Click += new System.EventHandler(this.buttonModifyToDB_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(6, 190);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(93, 23);
            this.buttonModify.TabIndex = 16;
            this.buttonModify.Text = "更    改";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // textBoxModifyCatiID
            // 
            this.textBoxModifyCatiID.Location = new System.Drawing.Point(68, 96);
            this.textBoxModifyCatiID.Name = "textBoxModifyCatiID";
            this.textBoxModifyCatiID.Size = new System.Drawing.Size(147, 21);
            this.textBoxModifyCatiID.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 14;
            this.label15.Text = "分类编码：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 13;
            this.label16.Text = "结束时间：";
            // 
            // dateTimePickerModifyF
            // 
            this.dateTimePickerModifyF.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerModifyF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerModifyF.Location = new System.Drawing.Point(68, 68);
            this.dateTimePickerModifyF.Name = "dateTimePickerModifyF";
            this.dateTimePickerModifyF.Size = new System.Drawing.Size(151, 21);
            this.dateTimePickerModifyF.TabIndex = 12;
            this.dateTimePickerModifyF.Value = new System.DateTime(2014, 12, 23, 11, 12, 23, 0);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 11;
            this.label17.Text = "开始时间：";
            // 
            // dateTimePickerModifyB
            // 
            this.dateTimePickerModifyB.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerModifyB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerModifyB.Location = new System.Drawing.Point(68, 41);
            this.dateTimePickerModifyB.Name = "dateTimePickerModifyB";
            this.dateTimePickerModifyB.Size = new System.Drawing.Size(151, 21);
            this.dateTimePickerModifyB.TabIndex = 10;
            this.dateTimePickerModifyB.Value = new System.DateTime(2014, 12, 23, 11, 12, 29, 0);
            // 
            // checkBoxModifyPxj
            // 
            this.checkBoxModifyPxj.AutoSize = true;
            this.checkBoxModifyPxj.Checked = true;
            this.checkBoxModifyPxj.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxModifyPxj.Location = new System.Drawing.Point(84, 20);
            this.checkBoxModifyPxj.Name = "checkBoxModifyPxj";
            this.checkBoxModifyPxj.Size = new System.Drawing.Size(72, 16);
            this.checkBoxModifyPxj.TabIndex = 9;
            this.checkBoxModifyPxj.Text = "拍下减价";
            this.checkBoxModifyPxj.UseVisualStyleBackColor = true;
            // 
            // checkBoxModifyEms
            // 
            this.checkBoxModifyEms.AutoSize = true;
            this.checkBoxModifyEms.Checked = true;
            this.checkBoxModifyEms.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxModifyEms.Location = new System.Drawing.Point(11, 20);
            this.checkBoxModifyEms.Name = "checkBoxModifyEms";
            this.checkBoxModifyEms.Size = new System.Drawing.Size(48, 16);
            this.checkBoxModifyEms.TabIndex = 8;
            this.checkBoxModifyEms.Text = "包邮";
            this.checkBoxModifyEms.UseVisualStyleBackColor = true;
            // 
            // groupBoxQuery
            // 
            this.groupBoxQuery.Controls.Add(this.label14);
            this.groupBoxQuery.Controls.Add(this.textBoxQueryNumiiD);
            this.groupBoxQuery.Controls.Add(this.button1);
            this.groupBoxQuery.Controls.Add(this.textBoxQueryKey);
            this.groupBoxQuery.Controls.Add(this.label13);
            this.groupBoxQuery.Controls.Add(this.textBoxQueryCateID);
            this.groupBoxQuery.Controls.Add(this.label10);
            this.groupBoxQuery.Controls.Add(this.label11);
            this.groupBoxQuery.Controls.Add(this.dateTimePickerQueryE);
            this.groupBoxQuery.Controls.Add(this.label12);
            this.groupBoxQuery.Controls.Add(this.dateTimePickerQueryB);
            this.groupBoxQuery.Location = new System.Drawing.Point(9, 3);
            this.groupBoxQuery.Name = "groupBoxQuery";
            this.groupBoxQuery.Size = new System.Drawing.Size(225, 338);
            this.groupBoxQuery.TabIndex = 10;
            this.groupBoxQuery.TabStop = false;
            this.groupBoxQuery.Text = "数据查询";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 12);
            this.label14.TabIndex = 18;
            this.label14.Text = "商品ID(Num__IID)：";
            // 
            // textBoxQueryNumiiD
            // 
            this.textBoxQueryNumiiD.Location = new System.Drawing.Point(13, 151);
            this.textBoxQueryNumiiD.Multiline = true;
            this.textBoxQueryNumiiD.Name = "textBoxQueryNumiiD";
            this.textBoxQueryNumiiD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQueryNumiiD.Size = new System.Drawing.Size(202, 152);
            this.textBoxQueryNumiiD.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxQueryKey
            // 
            this.textBoxQueryKey.Enabled = false;
            this.textBoxQueryKey.Location = new System.Drawing.Point(68, 102);
            this.textBoxQueryKey.Name = "textBoxQueryKey";
            this.textBoxQueryKey.Size = new System.Drawing.Size(151, 21);
            this.textBoxQueryKey.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Location = new System.Drawing.Point(5, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 14;
            this.label13.Text = "商品标题：";
            // 
            // textBoxQueryCateID
            // 
            this.textBoxQueryCateID.Location = new System.Drawing.Point(68, 75);
            this.textBoxQueryCateID.Name = "textBoxQueryCateID";
            this.textBoxQueryCateID.Size = new System.Drawing.Size(151, 21);
            this.textBoxQueryCateID.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "分类编码：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "---至---";
            // 
            // dateTimePickerQueryE
            // 
            this.dateTimePickerQueryE.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerQueryE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerQueryE.Location = new System.Drawing.Point(68, 47);
            this.dateTimePickerQueryE.Name = "dateTimePickerQueryE";
            this.dateTimePickerQueryE.Size = new System.Drawing.Size(151, 21);
            this.dateTimePickerQueryE.TabIndex = 10;
            this.dateTimePickerQueryE.Value = new System.DateTime(2014, 12, 23, 11, 12, 7, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "发布时间：";
            // 
            // dateTimePickerQueryB
            // 
            this.dateTimePickerQueryB.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerQueryB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerQueryB.Location = new System.Drawing.Point(68, 20);
            this.dateTimePickerQueryB.Name = "dateTimePickerQueryB";
            this.dateTimePickerQueryB.Size = new System.Drawing.Size(151, 21);
            this.dateTimePickerQueryB.TabIndex = 8;
            this.dateTimePickerQueryB.Value = new System.DateTime(2014, 12, 23, 11, 12, 13, 0);
            this.dateTimePickerQueryB.ValueChanged += new System.EventHandler(this.dateTimePickerQueryB_ValueChanged);
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProduct.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewProduct.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersVisible = false;
            this.dataGridViewProduct.RowTemplate.Height = 23;
            this.dataGridViewProduct.Size = new System.Drawing.Size(653, 570);
            this.dataGridViewProduct.TabIndex = 0;
            this.dataGridViewProduct.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewProduct_CellBeginEdit);
            this.dataGridViewProduct.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellValueChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(910, 578);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "邮费分离";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.treeViewEmsSeparate);
            this.splitContainer3.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.richTextBoxLinkEmsSeparater);
            this.splitContainer3.Size = new System.Drawing.Size(904, 572);
            this.splitContainer3.SplitterDistance = 241;
            this.splitContainer3.TabIndex = 0;
            // 
            // treeViewEmsSeparate
            // 
            this.treeViewEmsSeparate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewEmsSeparate.Location = new System.Drawing.Point(0, 43);
            this.treeViewEmsSeparate.Name = "treeViewEmsSeparate";
            this.treeViewEmsSeparate.Size = new System.Drawing.Size(239, 527);
            this.treeViewEmsSeparate.TabIndex = 2;
            this.treeViewEmsSeparate.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewEmsSeparate_NodeMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonEmsCopyID);
            this.panel1.Controls.Add(this.buttonEmsSeparate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 43);
            this.panel1.TabIndex = 1;
            // 
            // buttonEmsCopyID
            // 
            this.buttonEmsCopyID.AutoSize = true;
            this.buttonEmsCopyID.Image = global::TBKCollectTool.Properties.Resources.glyphicons_195_circle_info;
            this.buttonEmsCopyID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmsCopyID.Location = new System.Drawing.Point(86, 6);
            this.buttonEmsCopyID.Name = "buttonEmsCopyID";
            this.buttonEmsCopyID.Size = new System.Drawing.Size(97, 32);
            this.buttonEmsCopyID.TabIndex = 1;
            this.buttonEmsCopyID.Text = "复制商品ID";
            this.buttonEmsCopyID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEmsCopyID.UseVisualStyleBackColor = true;
            this.buttonEmsCopyID.Click += new System.EventHandler(this.buttonEmsCopyID_Click);
            // 
            // buttonEmsSeparate
            // 
            this.buttonEmsSeparate.AutoSize = true;
            this.buttonEmsSeparate.Image = global::TBKCollectTool.Properties.Resources.glyphicons_009_magic;
            this.buttonEmsSeparate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmsSeparate.Location = new System.Drawing.Point(4, 6);
            this.buttonEmsSeparate.Name = "buttonEmsSeparate";
            this.buttonEmsSeparate.Size = new System.Drawing.Size(67, 31);
            this.buttonEmsSeparate.TabIndex = 0;
            this.buttonEmsSeparate.Text = "分离";
            this.buttonEmsSeparate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEmsSeparate.UseVisualStyleBackColor = true;
            this.buttonEmsSeparate.Click += new System.EventHandler(this.buttonEmsSeparate_Click);
            // 
            // richTextBoxLinkEmsSeparater
            // 
            this.richTextBoxLinkEmsSeparater.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLinkEmsSeparater.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxLinkEmsSeparater.Name = "richTextBoxLinkEmsSeparater";
            this.richTextBoxLinkEmsSeparater.Size = new System.Drawing.Size(657, 570);
            this.richTextBoxLinkEmsSeparater.TabIndex = 0;
            this.richTextBoxLinkEmsSeparater.Text = "请将商品链接复制到此处，然后点击分离按钮。";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "CSV文件|*.csv";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 675);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Html2CSV Ver:2.51 (By Tianmimi QQ:4284607)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.groupBoxModify.ResumeLayout(false);
            this.groupBoxModify.PerformLayout();
            this.groupBoxQuery.ResumeLayout(false);
            this.groupBoxQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonHome;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.ToolStripButton toolStripButtonNext;
        private System.Windows.Forms.ToolStripButton toolStripButtonFresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxUrl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveCSV;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCollect;
        private System.Windows.Forms.ToolStripButton toolStripButtonClear;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSelectCount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton toolStripButtonExportToDB;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxPxj;
        private System.Windows.Forms.CheckBox checkBoxEms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBoxCateID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDbName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDbPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDbUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDbPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDbServer;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarToDb;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLog;
        private System.Windows.Forms.TextBox textBoxProductTableName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripButton toolStripButtonDisp;
        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBoxQuery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxQueryKey;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxQueryCateID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerQueryE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePickerQueryB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxQueryNumiiD;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.GroupBox groupBoxModify;
        private System.Windows.Forms.TextBox textBoxModifyCatiID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateTimePickerModifyF;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateTimePickerModifyB;
        private System.Windows.Forms.CheckBox checkBoxModifyPxj;
        private System.Windows.Forms.CheckBox checkBoxModifyEms;
        private System.Windows.Forms.Button buttonModifyToDB;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripButton toolStripButtonMakeLink;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TreeView treeViewEmsSeparate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBoxLinkEmsSeparater;
        private System.Windows.Forms.Button buttonEmsSeparate;
        private System.Windows.Forms.Button buttonEmsCopyID;
        private System.Windows.Forms.CheckBox checkBoxIsTmall;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddF;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddB;

    }
}

