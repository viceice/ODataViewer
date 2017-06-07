namespace DataServicesViewer
{
    partial class Shell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shell));
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.EntityTree = new System.Windows.Forms.TreeView();
            this.TreeViewContextMenuS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageListIcon = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MetaDataTabPage = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.QureyResulttabPage = new System.Windows.Forms.TabPage();
            this.QureyWebBrowser = new System.Windows.Forms.WebBrowser();
            this.ResultTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txbQuery = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tsBtnOpenWeb = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnShowMetadataTree = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.IntellisenseToolTip = new System.Windows.Forms.Label();
            this.IntellisenseTimer = new System.Windows.Forms.Timer(this.components);
            this.WPFHost = new System.Windows.Forms.Integration.ElementHost();
            this.intellisenseWPFControl = new DataServicesViewer.IntellisenseWPFControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.TreeViewContextMenuS.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.MetaDataTabPage.SuspendLayout();
            this.QureyResulttabPage.SuspendLayout();
            this.ResultTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mainSplitContainer.Location = new System.Drawing.Point(18, 195);
            this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.EntityTree);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.tabControl1);
            this.mainSplitContainer.Size = new System.Drawing.Size(1187, 455);
            this.mainSplitContainer.SplitterDistance = 218;
            this.mainSplitContainer.SplitterWidth = 6;
            this.mainSplitContainer.TabIndex = 13;
            // 
            // EntityTree
            // 
            this.EntityTree.ContextMenuStrip = this.TreeViewContextMenuS;
            this.EntityTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntityTree.ImageIndex = 0;
            this.EntityTree.ImageList = this.ImageListIcon;
            this.EntityTree.Location = new System.Drawing.Point(0, 0);
            this.EntityTree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EntityTree.Name = "EntityTree";
            this.EntityTree.SelectedImageIndex = 0;
            this.EntityTree.Size = new System.Drawing.Size(218, 455);
            this.EntityTree.TabIndex = 10;
            // 
            // TreeViewContextMenuS
            // 
            this.TreeViewContextMenuS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expandAllToolStripMenuItem,
            this.collapseToolStripMenuItem});
            this.TreeViewContextMenuS.Name = "TreeViewContextMenuS";
            this.TreeViewContextMenuS.Size = new System.Drawing.Size(150, 52);
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.expandAllToolStripMenuItem.Text = "Expand All";
            this.expandAllToolStripMenuItem.Click += new System.EventHandler(this.TreeViewExpandAll_Click);
            // 
            // collapseToolStripMenuItem
            // 
            this.collapseToolStripMenuItem.Name = "collapseToolStripMenuItem";
            this.collapseToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.collapseToolStripMenuItem.Text = "Collapse";
            this.collapseToolStripMenuItem.Click += new System.EventHandler(this.TreeViewCollapse_Click);
            // 
            // ImageListIcon
            // 
            this.ImageListIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListIcon.ImageStream")));
            this.ImageListIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListIcon.Images.SetKeyName(0, "PropertiesHS.png");
            this.ImageListIcon.Images.SetKeyName(1, "WebInsertHyperlinkHS.png");
            this.ImageListIcon.Images.SetKeyName(2, "folderopen.ico");
            this.ImageListIcon.Images.SetKeyName(3, "Folder.ico");
            this.ImageListIcon.Images.SetKeyName(4, "keys.ico");
            this.ImageListIcon.Images.SetKeyName(5, "Keys.png");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MetaDataTabPage);
            this.tabControl1.Controls.Add(this.QureyResulttabPage);
            this.tabControl1.Controls.Add(this.ResultTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(963, 455);
            this.tabControl1.TabIndex = 10;
            // 
            // MetaDataTabPage
            // 
            this.MetaDataTabPage.Controls.Add(this.webBrowser);
            this.MetaDataTabPage.Location = new System.Drawing.Point(4, 34);
            this.MetaDataTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MetaDataTabPage.Name = "MetaDataTabPage";
            this.MetaDataTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MetaDataTabPage.Size = new System.Drawing.Size(955, 417);
            this.MetaDataTabPage.TabIndex = 0;
            this.MetaDataTabPage.Text = "MetaData";
            this.MetaDataTabPage.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(4, 5);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webBrowser.MinimumSize = new System.Drawing.Size(30, 31);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(947, 407);
            this.webBrowser.TabIndex = 0;
            // 
            // QureyResulttabPage
            // 
            this.QureyResulttabPage.Controls.Add(this.QureyWebBrowser);
            this.QureyResulttabPage.Location = new System.Drawing.Point(4, 25);
            this.QureyResulttabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QureyResulttabPage.Name = "QureyResulttabPage";
            this.QureyResulttabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QureyResulttabPage.Size = new System.Drawing.Size(955, 426);
            this.QureyResulttabPage.TabIndex = 1;
            this.QureyResulttabPage.Text = "Qurey Result";
            this.QureyResulttabPage.UseVisualStyleBackColor = true;
            // 
            // QureyWebBrowser
            // 
            this.QureyWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QureyWebBrowser.Location = new System.Drawing.Point(4, 5);
            this.QureyWebBrowser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QureyWebBrowser.MinimumSize = new System.Drawing.Size(30, 31);
            this.QureyWebBrowser.Name = "QureyWebBrowser";
            this.QureyWebBrowser.Size = new System.Drawing.Size(1358, 863);
            this.QureyWebBrowser.TabIndex = 0;
            // 
            // ResultTabPage
            // 
            this.ResultTabPage.Controls.Add(this.dataGridView1);
            this.ResultTabPage.Location = new System.Drawing.Point(4, 25);
            this.ResultTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResultTabPage.Name = "ResultTabPage";
            this.ResultTabPage.Size = new System.Drawing.Size(955, 426);
            this.ResultTabPage.TabIndex = 2;
            this.ResultTabPage.Text = "Qurey Result in Grid";
            this.ResultTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1366, 873);
            this.dataGridView1.TabIndex = 0;
            // 
            // txbQuery
            // 
            this.txbQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbQuery.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuery.Location = new System.Drawing.Point(135, 120);
            this.txbQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbQuery.Name = "txbQuery";
            this.txbQuery.Size = new System.Drawing.Size(951, 31);
            this.txbQuery.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnGo.Location = new System.Drawing.Point(1097, 120);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(112, 31);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(18, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Qurey:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1223, 38);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 32);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(201, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 32);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(198, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(198, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(79, 32);
            this.aboutToolStripMenuItem1.Text = "&About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.copyToolStripButton,
            this.tsBtnOpenWeb,
            this.helpToolStripButton,
            this.btnShowMetadataTree});
            this.toolStrip1.Location = new System.Drawing.Point(0, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1223, 35);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(138, 32);
            this.newToolStripButton.Text = "&New Service";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(221, 32);
            this.copyToolStripButton.Text = "&Copy Service Full URL";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // tsBtnOpenWeb
            // 
            this.tsBtnOpenWeb.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnOpenWeb.Image")));
            this.tsBtnOpenWeb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnOpenWeb.Name = "tsBtnOpenWeb";
            this.tsBtnOpenWeb.Size = new System.Drawing.Size(200, 32);
            this.tsBtnOpenWeb.Text = "Open Web Browser";
            this.tsBtnOpenWeb.Click += new System.EventHandler(this.tsBtnOpenWeb_Click);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(180, 32);
            this.helpToolStripButton.Text = "&Show Intellisense";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // btnShowMetadataTree
            // 
            this.btnShowMetadataTree.Image = ((System.Drawing.Image)(resources.GetObject("btnShowMetadataTree.Image")));
            this.btnShowMetadataTree.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowMetadataTree.Name = "btnShowMetadataTree";
            this.btnShowMetadataTree.Size = new System.Drawing.Size(211, 32);
            this.btnShowMetadataTree.Text = "Show Metadata Tree";
            this.btnShowMetadataTree.Click += new System.EventHandler(this.ShowMetadataTree_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 683);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1223, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslbl
            // 
            this.tslbl.Name = "tslbl";
            this.tslbl.Size = new System.Drawing.Size(0, 17);
            // 
            // IntellisenseToolTip
            // 
            this.IntellisenseToolTip.AutoEllipsis = true;
            this.IntellisenseToolTip.AutoSize = true;
            this.IntellisenseToolTip.BackColor = System.Drawing.SystemColors.Info;
            this.IntellisenseToolTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntellisenseToolTip.CausesValidation = false;
            this.IntellisenseToolTip.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntellisenseToolTip.Location = new System.Drawing.Point(1164, 91);
            this.IntellisenseToolTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IntellisenseToolTip.Name = "IntellisenseToolTip";
            this.IntellisenseToolTip.Padding = new System.Windows.Forms.Padding(8);
            this.IntellisenseToolTip.Size = new System.Drawing.Size(82, 36);
            this.IntellisenseToolTip.TabIndex = 0;
            this.IntellisenseToolTip.Text = "Tooltip";
            this.IntellisenseToolTip.Visible = false;
            // 
            // IntellisenseTimer
            // 
            this.IntellisenseTimer.Interval = 2500;
            this.IntellisenseTimer.Tick += new System.EventHandler(this.IntellisenseTimer_Tick);
            // 
            // WPFHost
            // 
            this.WPFHost.Location = new System.Drawing.Point(135, 151);
            this.WPFHost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WPFHost.Name = "WPFHost";
            this.WPFHost.Size = new System.Drawing.Size(340, 219);
            this.WPFHost.TabIndex = 12;
            this.WPFHost.Text = "elementHost1";
            this.WPFHost.Child = this.intellisenseWPFControl;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1102, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 705);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.IntellisenseToolTip);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.WPFHost);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txbQuery);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Shell";
            this.Text = "OData Viewer";
            this.Load += new System.EventHandler(this.Shell_Load);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.TreeViewContextMenuS.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.MetaDataTabPage.ResumeLayout(false);
            this.QureyResulttabPage.ResumeLayout(false);
            this.ResultTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbQuery;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TreeView EntityTree;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ToolStripStatusLabel tslbl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MetaDataTabPage;
        private System.Windows.Forms.TabPage QureyResulttabPage;
        private System.Windows.Forms.WebBrowser QureyWebBrowser;
        private System.Windows.Forms.ImageList ImageListIcon;
        private System.Windows.Forms.ToolStripButton tsBtnOpenWeb;
        private System.Windows.Forms.TabPage ResultTabPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Integration.ElementHost WPFHost;
        private IntellisenseWPFControl intellisenseWPFControl;
        public System.Windows.Forms.Label IntellisenseToolTip;
        private System.Windows.Forms.Timer IntellisenseTimer;
        private System.Windows.Forms.ContextMenuStrip TreeViewContextMenuS;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnShowMetadataTree;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}