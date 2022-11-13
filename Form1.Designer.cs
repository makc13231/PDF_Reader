namespace PDF_JPG_Reader
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Search = new System.Windows.Forms.Button();
            this.LayoutForm = new System.Windows.Forms.TableLayoutPanel();
            this.LayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.LayoutOutput = new System.Windows.Forms.TableLayoutPanel();
            this.FilesSort = new System.Windows.Forms.ListBox();
            this.LabelOut = new System.Windows.Forms.Label();
            this.LayoutCenter = new System.Windows.Forms.TableLayoutPanel();
            this.LayoutCenterHelper = new System.Windows.Forms.TableLayoutPanel();
            this.Word = new System.Windows.Forms.TextBox();
            this.FlowsTabView = new System.Windows.Forms.TabControl();
            this.Flow0 = new System.Windows.Forms.TabPage();
            this.LayoutInfo0 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelFileNow0 = new System.Windows.Forms.Label();
            this.FileNow0 = new System.Windows.Forms.Label();
            this.LabelPageNow0 = new System.Windows.Forms.Label();
            this.FilePage0 = new System.Windows.Forms.Label();
            this.Resolution0 = new System.Windows.Forms.Label();
            this.LabelResolution0 = new System.Windows.Forms.Label();
            this.Flow1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelFileNow1 = new System.Windows.Forms.Label();
            this.FileNow1 = new System.Windows.Forms.Label();
            this.LabelPageNow1 = new System.Windows.Forms.Label();
            this.FilePage1 = new System.Windows.Forms.Label();
            this.LabelResolution1 = new System.Windows.Forms.Label();
            this.Resolution1 = new System.Windows.Forms.Label();
            this.Flow2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelFileNow2 = new System.Windows.Forms.Label();
            this.FileNow2 = new System.Windows.Forms.Label();
            this.LabelPageNow2 = new System.Windows.Forms.Label();
            this.FilePage2 = new System.Windows.Forms.Label();
            this.LabelResolution2 = new System.Windows.Forms.Label();
            this.Resolution2 = new System.Windows.Forms.Label();
            this.LabelSearchWord = new System.Windows.Forms.Label();
            this.LayoutInput = new System.Windows.Forms.TableLayoutPanel();
            this.SetFolder = new System.Windows.Forms.Button();
            this.FilesAll = new System.Windows.Forms.ListBox();
            this.labelIn = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ETALabel = new System.Windows.Forms.Label();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.LabelTimer = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.ETA = new System.Windows.Forms.Label();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenuTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SetFolderTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SetFlowsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Flow1TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Flow2TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Flow3TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator1TSMI = new System.Windows.Forms.ToolStripSeparator();
            this.FindMultipleWordsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchTheEntireFileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator2TSMI = new System.Windows.Forms.ToolStripSeparator();
            this.ResolutionForTesseractMenuTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this._800x600_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this._1280x720_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this._1600x900_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this._1920x1080_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this._2560x1440_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this._4096x2160_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator3TSMI = new System.Windows.Forms.ToolStripSeparator();
            this.SearchMenuTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchRegTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchSoftTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Folder = new System.Windows.Forms.FolderBrowserDialog();
            this.Tips = new System.Windows.Forms.ToolTip(this.components);
            this.LayoutForm.SuspendLayout();
            this.LayoutMain.SuspendLayout();
            this.LayoutOutput.SuspendLayout();
            this.LayoutCenter.SuspendLayout();
            this.LayoutCenterHelper.SuspendLayout();
            this.FlowsTabView.SuspendLayout();
            this.Flow0.SuspendLayout();
            this.LayoutInfo0.SuspendLayout();
            this.Flow1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Flow2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.LayoutInput.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Search.Enabled = false;
            this.Search.Location = new System.Drawing.Point(3, 345);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(208, 33);
            this.Search.TabIndex = 0;
            this.Search.Text = "Найти";
            this.Tips.SetToolTip(this.Search, "Начать процесс поиска");
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // LayoutForm
            // 
            this.LayoutForm.ColumnCount = 3;
            this.LayoutForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.LayoutForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.LayoutForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.LayoutForm.Controls.Add(this.LayoutMain, 1, 1);
            this.LayoutForm.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.LayoutForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutForm.Location = new System.Drawing.Point(0, 0);
            this.LayoutForm.Name = "LayoutForm";
            this.LayoutForm.RowCount = 3;
            this.LayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.LayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.LayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.LayoutForm.Size = new System.Drawing.Size(800, 472);
            this.LayoutForm.TabIndex = 2;
            // 
            // LayoutMain
            // 
            this.LayoutMain.ColumnCount = 3;
            this.LayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutMain.Controls.Add(this.LayoutOutput, 2, 0);
            this.LayoutMain.Controls.Add(this.LayoutCenter, 1, 0);
            this.LayoutMain.Controls.Add(this.LayoutInput, 0, 0);
            this.LayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutMain.Location = new System.Drawing.Point(69, 42);
            this.LayoutMain.Name = "LayoutMain";
            this.LayoutMain.RowCount = 1;
            this.LayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutMain.Size = new System.Drawing.Size(660, 387);
            this.LayoutMain.TabIndex = 6;
            // 
            // LayoutOutput
            // 
            this.LayoutOutput.ColumnCount = 1;
            this.LayoutOutput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutOutput.Controls.Add(this.Search, 0, 2);
            this.LayoutOutput.Controls.Add(this.FilesSort, 0, 1);
            this.LayoutOutput.Controls.Add(this.LabelOut, 0, 0);
            this.LayoutOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutOutput.Location = new System.Drawing.Point(443, 3);
            this.LayoutOutput.Name = "LayoutOutput";
            this.LayoutOutput.RowCount = 3;
            this.LayoutOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.LayoutOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutOutput.Size = new System.Drawing.Size(214, 381);
            this.LayoutOutput.TabIndex = 9;
            // 
            // FilesSort
            // 
            this.FilesSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesSort.FormattingEnabled = true;
            this.FilesSort.HorizontalScrollbar = true;
            this.FilesSort.Location = new System.Drawing.Point(3, 41);
            this.FilesSort.Name = "FilesSort";
            this.FilesSort.Size = new System.Drawing.Size(208, 298);
            this.FilesSort.TabIndex = 0;
            this.Tips.SetToolTip(this.FilesSort, "Здесь вы найдёте названия тех файлов,\r\nв которых было найдено нужное слово");
            this.FilesSort.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FilesSort_MouseDoubleClick);
            // 
            // LabelOut
            // 
            this.LabelOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelOut.AutoSize = true;
            this.LabelOut.Location = new System.Drawing.Point(75, 12);
            this.LabelOut.Name = "LabelOut";
            this.LabelOut.Size = new System.Drawing.Size(63, 13);
            this.LabelOut.TabIndex = 1;
            this.LabelOut.Text = "Найдено в:";
            // 
            // LayoutCenter
            // 
            this.LayoutCenter.ColumnCount = 1;
            this.LayoutCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutCenter.Controls.Add(this.LayoutCenterHelper, 0, 1);
            this.LayoutCenter.Controls.Add(this.LabelSearchWord, 0, 0);
            this.LayoutCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutCenter.Location = new System.Drawing.Point(223, 3);
            this.LayoutCenter.Name = "LayoutCenter";
            this.LayoutCenter.RowCount = 3;
            this.LayoutCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.LayoutCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutCenter.Size = new System.Drawing.Size(214, 381);
            this.LayoutCenter.TabIndex = 8;
            // 
            // LayoutCenterHelper
            // 
            this.LayoutCenterHelper.ColumnCount = 1;
            this.LayoutCenterHelper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutCenterHelper.Controls.Add(this.Word, 0, 0);
            this.LayoutCenterHelper.Controls.Add(this.FlowsTabView, 0, 1);
            this.LayoutCenterHelper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutCenterHelper.Location = new System.Drawing.Point(3, 41);
            this.LayoutCenterHelper.Name = "LayoutCenterHelper";
            this.LayoutCenterHelper.RowCount = 2;
            this.LayoutCenterHelper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.LayoutCenterHelper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutCenterHelper.Size = new System.Drawing.Size(208, 298);
            this.LayoutCenterHelper.TabIndex = 9;
            // 
            // Word
            // 
            this.Word.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Word.Enabled = false;
            this.Word.Location = new System.Drawing.Point(54, 3);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(100, 20);
            this.Word.TabIndex = 3;
            this.Tips.SetToolTip(this.Word, "Впишите сюда слово, которое хотите найти\r\nНапример: Орёл");
            this.Word.TextChanged += new System.EventHandler(this.Word_TextChanged);
            // 
            // FlowsTabView
            // 
            this.FlowsTabView.Controls.Add(this.Flow0);
            this.FlowsTabView.Controls.Add(this.Flow1);
            this.FlowsTabView.Controls.Add(this.Flow2);
            this.FlowsTabView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowsTabView.Location = new System.Drawing.Point(3, 29);
            this.FlowsTabView.Name = "FlowsTabView";
            this.FlowsTabView.SelectedIndex = 0;
            this.FlowsTabView.Size = new System.Drawing.Size(202, 266);
            this.FlowsTabView.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.FlowsTabView.TabIndex = 4;
            this.Tips.SetToolTip(this.FlowsTabView, "Здесь можно посмотреть, чем\r\nзанят каждый из поисковых потоков");
            // 
            // Flow0
            // 
            this.Flow0.BackColor = System.Drawing.Color.Transparent;
            this.Flow0.Controls.Add(this.LayoutInfo0);
            this.Flow0.Location = new System.Drawing.Point(4, 22);
            this.Flow0.Name = "Flow0";
            this.Flow0.Size = new System.Drawing.Size(194, 240);
            this.Flow0.TabIndex = 0;
            this.Flow0.Text = "Поток 1";
            // 
            // LayoutInfo0
            // 
            this.LayoutInfo0.BackColor = System.Drawing.Color.White;
            this.LayoutInfo0.ColumnCount = 1;
            this.LayoutInfo0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutInfo0.Controls.Add(this.LabelFileNow0, 0, 0);
            this.LayoutInfo0.Controls.Add(this.FileNow0, 0, 1);
            this.LayoutInfo0.Controls.Add(this.LabelPageNow0, 0, 2);
            this.LayoutInfo0.Controls.Add(this.FilePage0, 0, 3);
            this.LayoutInfo0.Controls.Add(this.Resolution0, 0, 5);
            this.LayoutInfo0.Controls.Add(this.LabelResolution0, 0, 4);
            this.LayoutInfo0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutInfo0.Location = new System.Drawing.Point(0, 0);
            this.LayoutInfo0.Name = "LayoutInfo0";
            this.LayoutInfo0.RowCount = 10;
            this.LayoutInfo0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutInfo0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutInfo0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutInfo0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutInfo0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutInfo0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutInfo0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutInfo0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutInfo0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutInfo0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutInfo0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutInfo0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutInfo0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutInfo0.Size = new System.Drawing.Size(194, 240);
            this.LayoutInfo0.TabIndex = 9;
            // 
            // LabelFileNow0
            // 
            this.LabelFileNow0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelFileNow0.AutoSize = true;
            this.LabelFileNow0.Location = new System.Drawing.Point(49, 5);
            this.LabelFileNow0.Name = "LabelFileNow0";
            this.LabelFileNow0.Size = new System.Drawing.Size(96, 13);
            this.LabelFileNow0.TabIndex = 10;
            this.LabelFileNow0.Text = "Просмотр файла:";
            // 
            // FileNow0
            // 
            this.FileNow0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FileNow0.AutoSize = true;
            this.FileNow0.Location = new System.Drawing.Point(89, 29);
            this.FileNow0.Name = "FileNow0";
            this.FileNow0.Size = new System.Drawing.Size(16, 13);
            this.FileNow0.TabIndex = 11;
            this.FileNow0.Text = "...";
            // 
            // LabelPageNow0
            // 
            this.LabelPageNow0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelPageNow0.AutoSize = true;
            this.LabelPageNow0.Location = new System.Drawing.Point(68, 53);
            this.LabelPageNow0.Name = "LabelPageNow0";
            this.LabelPageNow0.Size = new System.Drawing.Size(58, 13);
            this.LabelPageNow0.TabIndex = 12;
            this.LabelPageNow0.Text = "Страница:";
            // 
            // FilePage0
            // 
            this.FilePage0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FilePage0.AutoSize = true;
            this.FilePage0.Location = new System.Drawing.Point(89, 77);
            this.FilePage0.Name = "FilePage0";
            this.FilePage0.Size = new System.Drawing.Size(16, 13);
            this.FilePage0.TabIndex = 13;
            this.FilePage0.Text = "...";
            // 
            // Resolution0
            // 
            this.Resolution0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resolution0.AutoSize = true;
            this.Resolution0.Location = new System.Drawing.Point(89, 125);
            this.Resolution0.Name = "Resolution0";
            this.Resolution0.Size = new System.Drawing.Size(16, 13);
            this.Resolution0.TabIndex = 15;
            this.Resolution0.Text = "...";
            // 
            // LabelResolution0
            // 
            this.LabelResolution0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelResolution0.AutoSize = true;
            this.LabelResolution0.Location = new System.Drawing.Point(60, 101);
            this.LabelResolution0.Name = "LabelResolution0";
            this.LabelResolution0.Size = new System.Drawing.Size(73, 13);
            this.LabelResolution0.TabIndex = 14;
            this.LabelResolution0.Text = "Разрешение:";
            // 
            // Flow1
            // 
            this.Flow1.Controls.Add(this.tableLayoutPanel1);
            this.Flow1.Location = new System.Drawing.Point(4, 22);
            this.Flow1.Name = "Flow1";
            this.Flow1.Size = new System.Drawing.Size(194, 240);
            this.Flow1.TabIndex = 1;
            this.Flow1.Text = "Поток 2";
            this.Flow1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LabelFileNow1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FileNow1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelPageNow1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.FilePage1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LabelResolution1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Resolution1, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(194, 240);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // LabelFileNow1
            // 
            this.LabelFileNow1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelFileNow1.AutoSize = true;
            this.LabelFileNow1.Location = new System.Drawing.Point(49, 5);
            this.LabelFileNow1.Name = "LabelFileNow1";
            this.LabelFileNow1.Size = new System.Drawing.Size(96, 13);
            this.LabelFileNow1.TabIndex = 10;
            this.LabelFileNow1.Text = "Просмотр файла:";
            // 
            // FileNow1
            // 
            this.FileNow1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FileNow1.AutoSize = true;
            this.FileNow1.Location = new System.Drawing.Point(89, 29);
            this.FileNow1.Name = "FileNow1";
            this.FileNow1.Size = new System.Drawing.Size(16, 13);
            this.FileNow1.TabIndex = 11;
            this.FileNow1.Text = "...";
            // 
            // LabelPageNow1
            // 
            this.LabelPageNow1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelPageNow1.AutoSize = true;
            this.LabelPageNow1.Location = new System.Drawing.Point(68, 53);
            this.LabelPageNow1.Name = "LabelPageNow1";
            this.LabelPageNow1.Size = new System.Drawing.Size(58, 13);
            this.LabelPageNow1.TabIndex = 12;
            this.LabelPageNow1.Text = "Страница:";
            // 
            // FilePage1
            // 
            this.FilePage1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FilePage1.AutoSize = true;
            this.FilePage1.Location = new System.Drawing.Point(89, 77);
            this.FilePage1.Name = "FilePage1";
            this.FilePage1.Size = new System.Drawing.Size(16, 13);
            this.FilePage1.TabIndex = 13;
            this.FilePage1.Text = "...";
            // 
            // LabelResolution1
            // 
            this.LabelResolution1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelResolution1.AutoSize = true;
            this.LabelResolution1.Location = new System.Drawing.Point(60, 101);
            this.LabelResolution1.Name = "LabelResolution1";
            this.LabelResolution1.Size = new System.Drawing.Size(73, 13);
            this.LabelResolution1.TabIndex = 15;
            this.LabelResolution1.Text = "Разрешение:";
            // 
            // Resolution1
            // 
            this.Resolution1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resolution1.AutoSize = true;
            this.Resolution1.Location = new System.Drawing.Point(89, 125);
            this.Resolution1.Name = "Resolution1";
            this.Resolution1.Size = new System.Drawing.Size(16, 13);
            this.Resolution1.TabIndex = 16;
            this.Resolution1.Text = "...";
            // 
            // Flow2
            // 
            this.Flow2.Controls.Add(this.tableLayoutPanel2);
            this.Flow2.Location = new System.Drawing.Point(4, 22);
            this.Flow2.Name = "Flow2";
            this.Flow2.Size = new System.Drawing.Size(194, 240);
            this.Flow2.TabIndex = 2;
            this.Flow2.Text = "Поток 3";
            this.Flow2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.LabelFileNow2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.FileNow2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LabelPageNow2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.FilePage2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.LabelResolution2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.Resolution2, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 240);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // LabelFileNow2
            // 
            this.LabelFileNow2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelFileNow2.AutoSize = true;
            this.LabelFileNow2.Location = new System.Drawing.Point(49, 5);
            this.LabelFileNow2.Name = "LabelFileNow2";
            this.LabelFileNow2.Size = new System.Drawing.Size(96, 13);
            this.LabelFileNow2.TabIndex = 10;
            this.LabelFileNow2.Text = "Просмотр файла:";
            // 
            // FileNow2
            // 
            this.FileNow2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FileNow2.AutoSize = true;
            this.FileNow2.Location = new System.Drawing.Point(89, 29);
            this.FileNow2.Name = "FileNow2";
            this.FileNow2.Size = new System.Drawing.Size(16, 13);
            this.FileNow2.TabIndex = 11;
            this.FileNow2.Text = "...";
            // 
            // LabelPageNow2
            // 
            this.LabelPageNow2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelPageNow2.AutoSize = true;
            this.LabelPageNow2.Location = new System.Drawing.Point(68, 53);
            this.LabelPageNow2.Name = "LabelPageNow2";
            this.LabelPageNow2.Size = new System.Drawing.Size(58, 13);
            this.LabelPageNow2.TabIndex = 12;
            this.LabelPageNow2.Text = "Страница:";
            // 
            // FilePage2
            // 
            this.FilePage2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FilePage2.AutoSize = true;
            this.FilePage2.Location = new System.Drawing.Point(89, 77);
            this.FilePage2.Name = "FilePage2";
            this.FilePage2.Size = new System.Drawing.Size(16, 13);
            this.FilePage2.TabIndex = 13;
            this.FilePage2.Text = "...";
            // 
            // LabelResolution2
            // 
            this.LabelResolution2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelResolution2.AutoSize = true;
            this.LabelResolution2.Location = new System.Drawing.Point(60, 101);
            this.LabelResolution2.Name = "LabelResolution2";
            this.LabelResolution2.Size = new System.Drawing.Size(73, 13);
            this.LabelResolution2.TabIndex = 17;
            this.LabelResolution2.Text = "Разрешение:";
            // 
            // Resolution2
            // 
            this.Resolution2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resolution2.AutoSize = true;
            this.Resolution2.Location = new System.Drawing.Point(89, 125);
            this.Resolution2.Name = "Resolution2";
            this.Resolution2.Size = new System.Drawing.Size(16, 13);
            this.Resolution2.TabIndex = 16;
            this.Resolution2.Text = "...";
            // 
            // LabelSearchWord
            // 
            this.LabelSearchWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelSearchWord.AutoSize = true;
            this.LabelSearchWord.Location = new System.Drawing.Point(82, 12);
            this.LabelSearchWord.Name = "LabelSearchWord";
            this.LabelSearchWord.Size = new System.Drawing.Size(50, 13);
            this.LabelSearchWord.TabIndex = 2;
            this.LabelSearchWord.Text = "Ищется:";
            // 
            // LayoutInput
            // 
            this.LayoutInput.ColumnCount = 1;
            this.LayoutInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutInput.Controls.Add(this.SetFolder, 0, 2);
            this.LayoutInput.Controls.Add(this.FilesAll, 0, 1);
            this.LayoutInput.Controls.Add(this.labelIn, 0, 0);
            this.LayoutInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutInput.Location = new System.Drawing.Point(3, 3);
            this.LayoutInput.Name = "LayoutInput";
            this.LayoutInput.RowCount = 3;
            this.LayoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.LayoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutInput.Size = new System.Drawing.Size(214, 381);
            this.LayoutInput.TabIndex = 7;
            // 
            // SetFolder
            // 
            this.SetFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetFolder.Location = new System.Drawing.Point(3, 345);
            this.SetFolder.Name = "SetFolder";
            this.SetFolder.Size = new System.Drawing.Size(208, 33);
            this.SetFolder.TabIndex = 2;
            this.SetFolder.Text = "Выбор папки";
            this.Tips.SetToolTip(this.SetFolder, "Кнопка выбора папки с файлами pdf");
            this.SetFolder.UseVisualStyleBackColor = true;
            this.SetFolder.Click += new System.EventHandler(this.SetFolder_Click);
            // 
            // FilesAll
            // 
            this.FilesAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesAll.FormattingEnabled = true;
            this.FilesAll.HorizontalScrollbar = true;
            this.FilesAll.Location = new System.Drawing.Point(3, 41);
            this.FilesAll.Name = "FilesAll";
            this.FilesAll.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.FilesAll.Size = new System.Drawing.Size(208, 298);
            this.FilesAll.TabIndex = 0;
            this.Tips.SetToolTip(this.FilesAll, "Здесь показываюттся все файлы, которые\r\nбыли найдены в указанной вами папке");
            // 
            // labelIn
            // 
            this.labelIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIn.AutoSize = true;
            this.labelIn.Location = new System.Drawing.Point(78, 12);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(57, 13);
            this.labelIn.TabIndex = 1;
            this.labelIn.Text = "Поиск из:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.ETALabel, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.ProgressLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.LabelTimer, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.TimerLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.ETA, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.Progress, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(69, 435);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(660, 34);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // ETALabel
            // 
            this.ETALabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ETALabel.AutoSize = true;
            this.ETALabel.Location = new System.Drawing.Point(470, 2);
            this.ETALabel.Name = "ETALabel";
            this.ETALabel.Size = new System.Drawing.Size(159, 13);
            this.ETALabel.TabIndex = 17;
            this.ETALabel.Text = "Примерно осталось времени:";
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(300, 2);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(59, 13);
            this.ProgressLabel.TabIndex = 16;
            this.ProgressLabel.Text = "Прогресс:";
            // 
            // LabelTimer
            // 
            this.LabelTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelTimer.AutoSize = true;
            this.LabelTimer.Location = new System.Drawing.Point(45, 2);
            this.LabelTimer.Name = "LabelTimer";
            this.LabelTimer.Size = new System.Drawing.Size(129, 13);
            this.LabelTimer.TabIndex = 14;
            this.LabelTimer.Text = "Время с начала поиска:";
            // 
            // TimerLabel
            // 
            this.TimerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(102, 19);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(16, 13);
            this.TimerLabel.TabIndex = 15;
            this.TimerLabel.Text = "...";
            this.Tips.SetToolTip(this.TimerLabel, "Сколько времени занял поиск");
            // 
            // ETA
            // 
            this.ETA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ETA.AutoSize = true;
            this.ETA.Location = new System.Drawing.Point(542, 19);
            this.ETA.Name = "ETA";
            this.ETA.Size = new System.Drawing.Size(16, 13);
            this.ETA.TabIndex = 19;
            this.ETA.Text = "...";
            this.Tips.SetToolTip(this.ETA, "Указывает, сколько ещё примерно\r\nосталось ждать времени до конца поиска");
            // 
            // Progress
            // 
            this.Progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Progress.Location = new System.Drawing.Point(223, 20);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(214, 11);
            this.Progress.Step = 1;
            this.Progress.TabIndex = 20;
            this.Tips.SetToolTip(this.Progress, "Насколько процесс поиска закончил работу");
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuTSMI,
            this.SettingsMenuTSMI,
            this.AboutTSMI});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(800, 24);
            this.MainMenu.TabIndex = 12;
            this.MainMenu.Text = "menuStrip1";
            // 
            // FileMenuTSMI
            // 
            this.FileMenuTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetFolderTSMI});
            this.FileMenuTSMI.Name = "FileMenuTSMI";
            this.FileMenuTSMI.Size = new System.Drawing.Size(48, 20);
            this.FileMenuTSMI.Text = "Файл";
            // 
            // SetFolderTSMI
            // 
            this.SetFolderTSMI.Name = "SetFolderTSMI";
            this.SetFolderTSMI.Size = new System.Drawing.Size(153, 22);
            this.SetFolderTSMI.Text = "Выбор папки..";
            this.SetFolderTSMI.ToolTipText = "Кнопка выбора папки с файлами pdf";
            this.SetFolderTSMI.Click += new System.EventHandler(this.SetFolder_Click);
            // 
            // SettingsMenuTSMI
            // 
            this.SettingsMenuTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetFlowsTSMI,
            this.Separator1TSMI,
            this.FindMultipleWordsTSMI,
            this.SearchTheEntireFileTSMI,
            this.Separator2TSMI,
            this.ResolutionForTesseractMenuTSMI,
            this.Separator3TSMI,
            this.SearchMenuTSMI});
            this.SettingsMenuTSMI.Name = "SettingsMenuTSMI";
            this.SettingsMenuTSMI.Size = new System.Drawing.Size(79, 20);
            this.SettingsMenuTSMI.Text = "Настройки";
            // 
            // SetFlowsTSMI
            // 
            this.SetFlowsTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Flow1TSMI,
            this.Flow2TSMI,
            this.Flow3TSMI});
            this.SetFlowsTSMI.Name = "SetFlowsTSMI";
            this.SetFlowsTSMI.Size = new System.Drawing.Size(322, 22);
            this.SetFlowsTSMI.Text = "Выбрать кол-во поисковых потоков";
            this.SetFlowsTSMI.ToolTipText = "В зависимости от количества потоков,\r\nбудет менятся нагрузка на процессор.";
            // 
            // Flow1TSMI
            // 
            this.Flow1TSMI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Flow1TSMI.Name = "Flow1TSMI";
            this.Flow1TSMI.ShowShortcutKeys = false;
            this.Flow1TSMI.Size = new System.Drawing.Size(80, 22);
            this.Flow1TSMI.Text = "1";
            this.Flow1TSMI.ToolTipText = "Использовать один поток (медленно, низкое потребление мощностей)";
            this.Flow1TSMI.Click += new System.EventHandler(this.SettedFlows_Click);
            // 
            // Flow2TSMI
            // 
            this.Flow2TSMI.Name = "Flow2TSMI";
            this.Flow2TSMI.Size = new System.Drawing.Size(80, 22);
            this.Flow2TSMI.Text = "2";
            this.Flow2TSMI.ToolTipText = "Использовать два потока (средне, среднее потребление мощностей)";
            this.Flow2TSMI.Click += new System.EventHandler(this.SettedFlows_Click);
            // 
            // Flow3TSMI
            // 
            this.Flow3TSMI.Checked = true;
            this.Flow3TSMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Flow3TSMI.Name = "Flow3TSMI";
            this.Flow3TSMI.Size = new System.Drawing.Size(80, 22);
            this.Flow3TSMI.Text = "3";
            this.Flow3TSMI.ToolTipText = "Использовать три потока (быстро, большое потребление мощностей)";
            this.Flow3TSMI.Click += new System.EventHandler(this.SettedFlows_Click);
            // 
            // Separator1TSMI
            // 
            this.Separator1TSMI.Name = "Separator1TSMI";
            this.Separator1TSMI.Size = new System.Drawing.Size(319, 6);
            // 
            // FindMultipleWordsTSMI
            // 
            this.FindMultipleWordsTSMI.Name = "FindMultipleWordsTSMI";
            this.FindMultipleWordsTSMI.Size = new System.Drawing.Size(322, 22);
            this.FindMultipleWordsTSMI.Text = "Находить несколько слов (через ;)";
            this.FindMultipleWordsTSMI.ToolTipText = "Если выбрано, текстовая строка будет делить\r\nзаписанный в ней текст там, где стои" +
    "т \";\",\r\nпроверяя все варианты\r\nНапример: Король;Орёл\r\n";
            this.FindMultipleWordsTSMI.Click += new System.EventHandler(this.TSMI_Check_Click);
            // 
            // SearchTheEntireFileTSMI
            // 
            this.SearchTheEntireFileTSMI.Name = "SearchTheEntireFileTSMI";
            this.SearchTheEntireFileTSMI.Size = new System.Drawing.Size(322, 22);
            this.SearchTheEntireFileTSMI.Text = "Поиск во всём файле (не до 1-го вхождения)";
            this.SearchTheEntireFileTSMI.ToolTipText = resources.GetString("SearchTheEntireFileTSMI.ToolTipText");
            this.SearchTheEntireFileTSMI.Click += new System.EventHandler(this.TSMI_Check_Click);
            // 
            // Separator2TSMI
            // 
            this.Separator2TSMI.Name = "Separator2TSMI";
            this.Separator2TSMI.Size = new System.Drawing.Size(319, 6);
            // 
            // ResolutionForTesseractMenuTSMI
            // 
            this.ResolutionForTesseractMenuTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._800x600_TSMI,
            this._1280x720_TSMI,
            this._1600x900_TSMI,
            this._1920x1080_TSMI,
            this._2560x1440_TSMI,
            this._4096x2160_TSMI});
            this.ResolutionForTesseractMenuTSMI.Name = "ResolutionForTesseractMenuTSMI";
            this.ResolutionForTesseractMenuTSMI.Size = new System.Drawing.Size(322, 22);
            this.ResolutionForTesseractMenuTSMI.Text = "Разрешения для обработки";
            this.ResolutionForTesseractMenuTSMI.ToolTipText = resources.GetString("ResolutionForTesseractMenuTSMI.ToolTipText");
            // 
            // _800x600_TSMI
            // 
            this._800x600_TSMI.Name = "_800x600_TSMI";
            this._800x600_TSMI.Size = new System.Drawing.Size(128, 22);
            this._800x600_TSMI.Text = "800x600";
            this._800x600_TSMI.Click += new System.EventHandler(this.TSMI_Check_Click);
            // 
            // _1280x720_TSMI
            // 
            this._1280x720_TSMI.Name = "_1280x720_TSMI";
            this._1280x720_TSMI.Size = new System.Drawing.Size(128, 22);
            this._1280x720_TSMI.Text = "1280x720";
            this._1280x720_TSMI.Click += new System.EventHandler(this.TSMI_Check_Click);
            // 
            // _1600x900_TSMI
            // 
            this._1600x900_TSMI.Name = "_1600x900_TSMI";
            this._1600x900_TSMI.Size = new System.Drawing.Size(128, 22);
            this._1600x900_TSMI.Text = "1600x900";
            this._1600x900_TSMI.Click += new System.EventHandler(this.TSMI_Check_Click);
            // 
            // _1920x1080_TSMI
            // 
            this._1920x1080_TSMI.Checked = true;
            this._1920x1080_TSMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this._1920x1080_TSMI.Name = "_1920x1080_TSMI";
            this._1920x1080_TSMI.Size = new System.Drawing.Size(128, 22);
            this._1920x1080_TSMI.Text = "1920x1080";
            this._1920x1080_TSMI.Click += new System.EventHandler(this.TSMI_Check_Click);
            // 
            // _2560x1440_TSMI
            // 
            this._2560x1440_TSMI.Name = "_2560x1440_TSMI";
            this._2560x1440_TSMI.Size = new System.Drawing.Size(128, 22);
            this._2560x1440_TSMI.Text = "2560x1440";
            this._2560x1440_TSMI.Click += new System.EventHandler(this.TSMI_Check_Click);
            // 
            // _4096x2160_TSMI
            // 
            this._4096x2160_TSMI.Name = "_4096x2160_TSMI";
            this._4096x2160_TSMI.Size = new System.Drawing.Size(128, 22);
            this._4096x2160_TSMI.Text = "4096x2160";
            this._4096x2160_TSMI.Click += new System.EventHandler(this.TSMI_Check_Click);
            // 
            // Separator3TSMI
            // 
            this.Separator3TSMI.Name = "Separator3TSMI";
            this.Separator3TSMI.Size = new System.Drawing.Size(319, 6);
            // 
            // SearchMenuTSMI
            // 
            this.SearchMenuTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchRegTSMI,
            this.SearchSoftTSMI});
            this.SearchMenuTSMI.Name = "SearchMenuTSMI";
            this.SearchMenuTSMI.Size = new System.Drawing.Size(322, 22);
            this.SearchMenuTSMI.Text = "Поиск";
            this.SearchMenuTSMI.ToolTipText = "Выбор режима поиска слов(-а) в файлах";
            // 
            // SearchRegTSMI
            // 
            this.SearchRegTSMI.Name = "SearchRegTSMI";
            this.SearchRegTSMI.Size = new System.Drawing.Size(180, 22);
            this.SearchRegTSMI.Text = "Без учёта РеГиСтРа";
            this.SearchRegTSMI.ToolTipText = "Если выбрано, в файлах текст при поиске\r\nне будет учитывать регистр.\r\nНапример: О" +
    "рёл, орёл, ОрЁл не будут\r\nиметь в поиске разницы";
            this.SearchRegTSMI.Click += new System.EventHandler(this.TSMI_Check_Click);
            // 
            // SearchSoftTSMI
            // 
            this.SearchSoftTSMI.Name = "SearchSoftTSMI";
            this.SearchSoftTSMI.Size = new System.Drawing.Size(180, 22);
            this.SearchSoftTSMI.Text = "Мягкий";
            this.SearchSoftTSMI.ToolTipText = resources.GetString("SearchSoftTSMI.ToolTipText");
            this.SearchSoftTSMI.Click += new System.EventHandler(this.TSMI_Check_Click);
            // 
            // AboutTSMI
            // 
            this.AboutTSMI.Name = "AboutTSMI";
            this.AboutTSMI.Size = new System.Drawing.Size(94, 20);
            this.AboutTSMI.Text = "О программе";
            this.AboutTSMI.Click += new System.EventHandler(this.AboutTSMI_Click);
            // 
            // Folder
            // 
            this.Folder.Description = "Выберите папку с .pdf файлами..";
            this.Folder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.LayoutForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.Text = "PDF-Ищейка";
            this.LayoutForm.ResumeLayout(false);
            this.LayoutMain.ResumeLayout(false);
            this.LayoutOutput.ResumeLayout(false);
            this.LayoutOutput.PerformLayout();
            this.LayoutCenter.ResumeLayout(false);
            this.LayoutCenter.PerformLayout();
            this.LayoutCenterHelper.ResumeLayout(false);
            this.LayoutCenterHelper.PerformLayout();
            this.FlowsTabView.ResumeLayout(false);
            this.Flow0.ResumeLayout(false);
            this.LayoutInfo0.ResumeLayout(false);
            this.LayoutInfo0.PerformLayout();
            this.Flow1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Flow2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.LayoutInput.ResumeLayout(false);
            this.LayoutInput.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TableLayoutPanel LayoutForm;
        private System.Windows.Forms.Button SetFolder;
        private System.Windows.Forms.FolderBrowserDialog Folder;
        private System.Windows.Forms.TableLayoutPanel LayoutMain;
        private System.Windows.Forms.TableLayoutPanel LayoutOutput;
        private System.Windows.Forms.ListBox FilesSort;
        private System.Windows.Forms.Label LabelOut;
        private System.Windows.Forms.TableLayoutPanel LayoutCenter;
        private System.Windows.Forms.TableLayoutPanel LayoutInput;
        private System.Windows.Forms.ListBox FilesAll;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.Label LabelSearchWord;
        private System.Windows.Forms.TableLayoutPanel LayoutInfo0;
        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.Label FileNow0;
        private System.Windows.Forms.Label LabelFileNow0;
        private System.Windows.Forms.Label LabelPageNow0;
        private System.Windows.Forms.Label FilePage0;
        private System.Windows.Forms.Label LabelTimer;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.TableLayoutPanel LayoutCenterHelper;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.TabControl FlowsTabView;
        private System.Windows.Forms.TabPage Flow0;
        private System.Windows.Forms.TabPage Flow1;
        private System.Windows.Forms.TabPage Flow2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LabelFileNow1;
        private System.Windows.Forms.Label FileNow1;
        private System.Windows.Forms.Label LabelPageNow1;
        private System.Windows.Forms.Label FilePage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LabelFileNow2;
        private System.Windows.Forms.Label FileNow2;
        private System.Windows.Forms.Label LabelPageNow2;
        private System.Windows.Forms.Label FilePage2;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuTSMI;
        private System.Windows.Forms.ToolStripMenuItem SetFlowsTSMI;
        private System.Windows.Forms.ToolStripMenuItem Flow1TSMI;
        private System.Windows.Forms.ToolStripMenuItem Flow2TSMI;
        private System.Windows.Forms.ToolStripMenuItem Flow3TSMI;
        private System.Windows.Forms.ToolStripMenuItem FileMenuTSMI;
        private System.Windows.Forms.ToolStripMenuItem SetFolderTSMI;
        private System.Windows.Forms.ToolStripMenuItem AboutTSMI;
        private System.Windows.Forms.ToolStripSeparator Separator1TSMI;
        private System.Windows.Forms.ToolStripMenuItem FindMultipleWordsTSMI;
        private System.Windows.Forms.ToolStripMenuItem SearchTheEntireFileTSMI;
        private System.Windows.Forms.ToolStripSeparator Separator2TSMI;
        private System.Windows.Forms.ToolStripMenuItem ResolutionForTesseractMenuTSMI;
        private System.Windows.Forms.ToolStripMenuItem _800x600_TSMI;
        private System.Windows.Forms.ToolStripMenuItem _1280x720_TSMI;
        private System.Windows.Forms.ToolStripMenuItem _1600x900_TSMI;
        private System.Windows.Forms.ToolStripMenuItem _1920x1080_TSMI;
        private System.Windows.Forms.ToolStripMenuItem _2560x1440_TSMI;
        private System.Windows.Forms.ToolStripMenuItem _4096x2160_TSMI;
        private System.Windows.Forms.Label Resolution0;
        private System.Windows.Forms.Label LabelResolution0;
        private System.Windows.Forms.Label LabelResolution1;
        private System.Windows.Forms.Label Resolution1;
        private System.Windows.Forms.Label LabelResolution2;
        private System.Windows.Forms.Label Resolution2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label ETALabel;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.Label ETA;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.ToolStripSeparator Separator3TSMI;
        private System.Windows.Forms.ToolStripMenuItem SearchMenuTSMI;
        private System.Windows.Forms.ToolStripMenuItem SearchRegTSMI;
        private System.Windows.Forms.ToolStripMenuItem SearchSoftTSMI;
        private System.Windows.Forms.ToolTip Tips;
    }
}

