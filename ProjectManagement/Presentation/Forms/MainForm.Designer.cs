namespace Presentation
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.m_menuBar = new System.Windows.Forms.MenuStrip();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewPaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seachPaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checklistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newChecklistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_statusBar = new System.Windows.Forms.StatusStrip();
            this.m_numOfProjects = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_numOfSelectedProprojects = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_splitContainerDirectoryTree = new System.Windows.Forms.SplitContainer();
            this.m_directoryTreeView = new Presentation.Controls.TreeviewExplorer();
            this.m_spliterContainerSeachBox = new System.Windows.Forms.SplitContainer();
            this.m_grpSearch = new System.Windows.Forms.GroupBox();
            this.m_cboSeachType = new System.Windows.Forms.ComboBox();
            this.m_btnSearch = new System.Windows.Forms.Button();
            this.m_iconList = new System.Windows.Forms.ImageList(this.components);
            this.m_textboxSearchBox = new System.Windows.Forms.TextBox();
            this.m_grpFilters = new System.Windows.Forms.GroupBox();
            this.m_filterContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.m_btnAddFilter = new System.Windows.Forms.Button();
            this.m_spliterContainerPreviewPane = new System.Windows.Forms.SplitContainer();
            this.m_projectExplorer = new Presentation.Controls.ProjectExplorer();
            this.m_previewPane = new System.Windows.Forms.RichTextBox();
            this.m_menuBar.SuspendLayout();
            this.m_statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_splitContainerDirectoryTree)).BeginInit();
            this.m_splitContainerDirectoryTree.Panel1.SuspendLayout();
            this.m_splitContainerDirectoryTree.Panel2.SuspendLayout();
            this.m_splitContainerDirectoryTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_spliterContainerSeachBox)).BeginInit();
            this.m_spliterContainerSeachBox.Panel1.SuspendLayout();
            this.m_spliterContainerSeachBox.Panel2.SuspendLayout();
            this.m_spliterContainerSeachBox.SuspendLayout();
            this.m_grpSearch.SuspendLayout();
            this.m_grpFilters.SuspendLayout();
            this.m_filterContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_spliterContainerPreviewPane)).BeginInit();
            this.m_spliterContainerPreviewPane.Panel1.SuspendLayout();
            this.m_spliterContainerPreviewPane.Panel2.SuspendLayout();
            this.m_spliterContainerPreviewPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_menuBar
            // 
            this.m_menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.checklistToolStripMenuItem});
            this.m_menuBar.Location = new System.Drawing.Point(3, 3);
            this.m_menuBar.Name = "m_menuBar";
            this.m_menuBar.Size = new System.Drawing.Size(768, 24);
            this.m_menuBar.TabIndex = 0;
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.projectsToolStripMenuItem.Text = "Projects";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddNewProject);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directoryTreeToolStripMenuItem,
            this.statusBarToolStripMenuItem,
            this.previewPaneToolStripMenuItem,
            this.seachPaneToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // directoryTreeToolStripMenuItem
            // 
            this.directoryTreeToolStripMenuItem.Checked = true;
            this.directoryTreeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.directoryTreeToolStripMenuItem.Name = "directoryTreeToolStripMenuItem";
            this.directoryTreeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.directoryTreeToolStripMenuItem.Text = "Directory Tree";
            this.directoryTreeToolStripMenuItem.Click += new System.EventHandler(this.showHideDirectoryTree);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.statusBarToolStripMenuItem.Text = "Status Bar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.showHideStatusBar);
            // 
            // previewPaneToolStripMenuItem
            // 
            this.previewPaneToolStripMenuItem.Checked = true;
            this.previewPaneToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.previewPaneToolStripMenuItem.Name = "previewPaneToolStripMenuItem";
            this.previewPaneToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.previewPaneToolStripMenuItem.Text = "Preview Pane";
            this.previewPaneToolStripMenuItem.Click += new System.EventHandler(this.showHidePreviewPane);
            // 
            // seachPaneToolStripMenuItem
            // 
            this.seachPaneToolStripMenuItem.Checked = true;
            this.seachPaneToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.seachPaneToolStripMenuItem.Name = "seachPaneToolStripMenuItem";
            this.seachPaneToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.seachPaneToolStripMenuItem.Text = "Seach Pane";
            this.seachPaneToolStripMenuItem.Click += new System.EventHandler(this.showHideSeachPane);
            // 
            // checklistToolStripMenuItem
            // 
            this.checklistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newChecklistToolStripMenuItem,
            this.compareToolStripMenuItem,
            this.editToolStripMenuItem});
            this.checklistToolStripMenuItem.Name = "checklistToolStripMenuItem";
            this.checklistToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.checklistToolStripMenuItem.Text = "Checklist";
            // 
            // newChecklistToolStripMenuItem
            // 
            this.newChecklistToolStripMenuItem.Name = "newChecklistToolStripMenuItem";
            this.newChecklistToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newChecklistToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.newChecklistToolStripMenuItem.Text = "New";
            this.newChecklistToolStripMenuItem.Click += new System.EventHandler(this.createChecklist);
            // 
            // compareToolStripMenuItem
            // 
            this.compareToolStripMenuItem.Name = "compareToolStripMenuItem";
            this.compareToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.compareToolStripMenuItem.Text = "Compare";
            this.compareToolStripMenuItem.Click += new System.EventHandler(this.compareToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.editToolStripMenuItem.Text = "Open";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // m_statusBar
            // 
            this.m_statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_numOfProjects,
            this.m_numOfSelectedProprojects});
            this.m_statusBar.Location = new System.Drawing.Point(3, 465);
            this.m_statusBar.Name = "m_statusBar";
            this.m_statusBar.Size = new System.Drawing.Size(768, 22);
            this.m_statusBar.TabIndex = 1;
            // 
            // m_numOfProjects
            // 
            this.m_numOfProjects.Name = "m_numOfProjects";
            this.m_numOfProjects.Size = new System.Drawing.Size(58, 17);
            this.m_numOfProjects.Text = "0 Projects";
            // 
            // m_numOfSelectedProprojects
            // 
            this.m_numOfSelectedProprojects.Name = "m_numOfSelectedProprojects";
            this.m_numOfSelectedProprojects.Size = new System.Drawing.Size(60, 17);
            this.m_numOfSelectedProprojects.Text = "0 Selected";
            // 
            // m_splitContainerDirectoryTree
            // 
            this.m_splitContainerDirectoryTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_splitContainerDirectoryTree.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.m_splitContainerDirectoryTree.Location = new System.Drawing.Point(3, 27);
            this.m_splitContainerDirectoryTree.Name = "m_splitContainerDirectoryTree";
            // 
            // m_splitContainerDirectoryTree.Panel1
            // 
            this.m_splitContainerDirectoryTree.Panel1.Controls.Add(this.m_directoryTreeView);
            // 
            // m_splitContainerDirectoryTree.Panel2
            // 
            this.m_splitContainerDirectoryTree.Panel2.Controls.Add(this.m_spliterContainerSeachBox);
            this.m_splitContainerDirectoryTree.Size = new System.Drawing.Size(768, 438);
            this.m_splitContainerDirectoryTree.SplitterDistance = 181;
            this.m_splitContainerDirectoryTree.TabIndex = 2;
            // 
            // m_directoryTreeView
            // 
            this.m_directoryTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_directoryTreeView.Location = new System.Drawing.Point(0, 0);
            this.m_directoryTreeView.Name = "m_directoryTreeView";
            this.m_directoryTreeView.Size = new System.Drawing.Size(181, 438);
            this.m_directoryTreeView.TabIndex = 0;
            // 
            // m_spliterContainerSeachBox
            // 
            this.m_spliterContainerSeachBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_spliterContainerSeachBox.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.m_spliterContainerSeachBox.Location = new System.Drawing.Point(0, 0);
            this.m_spliterContainerSeachBox.Name = "m_spliterContainerSeachBox";
            this.m_spliterContainerSeachBox.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // m_spliterContainerSeachBox.Panel1
            // 
            this.m_spliterContainerSeachBox.Panel1.Controls.Add(this.m_grpSearch);
            this.m_spliterContainerSeachBox.Panel1.Controls.Add(this.m_grpFilters);
            this.m_spliterContainerSeachBox.Panel1MinSize = 1;
            // 
            // m_spliterContainerSeachBox.Panel2
            // 
            this.m_spliterContainerSeachBox.Panel2.Controls.Add(this.m_spliterContainerPreviewPane);
            this.m_spliterContainerSeachBox.Size = new System.Drawing.Size(583, 438);
            this.m_spliterContainerSeachBox.SplitterDistance = 90;
            this.m_spliterContainerSeachBox.TabIndex = 0;
            // 
            // m_grpSearch
            // 
            this.m_grpSearch.Controls.Add(this.m_cboSeachType);
            this.m_grpSearch.Controls.Add(this.m_btnSearch);
            this.m_grpSearch.Controls.Add(this.m_textboxSearchBox);
            this.m_grpSearch.Location = new System.Drawing.Point(3, 3);
            this.m_grpSearch.Name = "m_grpSearch";
            this.m_grpSearch.Size = new System.Drawing.Size(575, 42);
            this.m_grpSearch.TabIndex = 4;
            this.m_grpSearch.TabStop = false;
            this.m_grpSearch.Text = "Search";
            // 
            // m_cboSeachType
            // 
            this.m_cboSeachType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_cboSeachType.Items.AddRange(new object[] {
            "Project Name",
            "Group Name",
            "Last Update Time"});
            this.m_cboSeachType.Location = new System.Drawing.Point(335, 16);
            this.m_cboSeachType.Name = "m_cboSeachType";
            this.m_cboSeachType.Size = new System.Drawing.Size(116, 21);
            this.m_cboSeachType.TabIndex = 5;
            this.m_cboSeachType.Text = "Project Name";
            // 
            // m_btnSearch
            // 
            this.m_btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnSearch.ImageIndex = 215;
            this.m_btnSearch.ImageList = this.m_iconList;
            this.m_btnSearch.Location = new System.Drawing.Point(457, 16);
            this.m_btnSearch.Name = "m_btnSearch";
            this.m_btnSearch.Size = new System.Drawing.Size(112, 21);
            this.m_btnSearch.TabIndex = 4;
            this.m_btnSearch.UseVisualStyleBackColor = true;
            this.m_btnSearch.Click += new System.EventHandler(this.seachForProjects);
            // 
            // m_iconList
            // 
            this.m_iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("m_iconList.ImageStream")));
            this.m_iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.m_iconList.Images.SetKeyName(0, "3d bar chart.ico");
            this.m_iconList.Images.SetKeyName(1, "Abort.ico");
            this.m_iconList.Images.SetKeyName(2, "About.ico");
            this.m_iconList.Images.SetKeyName(3, "Accounting.ico");
            this.m_iconList.Images.SetKeyName(4, "Add.ico");
            this.m_iconList.Images.SetKeyName(5, "Address book.ico");
            this.m_iconList.Images.SetKeyName(6, "Alarm clock.ico");
            this.m_iconList.Images.SetKeyName(7, "Alarm.ico");
            this.m_iconList.Images.SetKeyName(8, "Alert.ico");
            this.m_iconList.Images.SetKeyName(9, "Alien.ico");
            this.m_iconList.Images.SetKeyName(10, "Anchor.ico");
            this.m_iconList.Images.SetKeyName(11, "Application.ico");
            this.m_iconList.Images.SetKeyName(12, "Apply.ico");
            this.m_iconList.Images.SetKeyName(13, "Back.ico");
            this.m_iconList.Images.SetKeyName(14, "Bad mark.ico");
            this.m_iconList.Images.SetKeyName(15, "Bee.ico");
            this.m_iconList.Images.SetKeyName(16, "Black bookmark.ico");
            this.m_iconList.Images.SetKeyName(17, "Black pin.ico");
            this.m_iconList.Images.SetKeyName(18, "Black tag.ico");
            this.m_iconList.Images.SetKeyName(19, "Blog.ico");
            this.m_iconList.Images.SetKeyName(20, "Blue bookmark.ico");
            this.m_iconList.Images.SetKeyName(21, "Blue key.ico");
            this.m_iconList.Images.SetKeyName(22, "Blue pin.ico");
            this.m_iconList.Images.SetKeyName(23, "Blue tag.ico");
            this.m_iconList.Images.SetKeyName(24, "Bomb.ico");
            this.m_iconList.Images.SetKeyName(25, "Bookmark.ico");
            this.m_iconList.Images.SetKeyName(26, "Boss.ico");
            this.m_iconList.Images.SetKeyName(27, "Bottom.ico");
            this.m_iconList.Images.SetKeyName(28, "Briefcase.ico");
            this.m_iconList.Images.SetKeyName(29, "Brush.ico");
            this.m_iconList.Images.SetKeyName(30, "Bubble.ico");
            this.m_iconList.Images.SetKeyName(31, "Buy.ico");
            this.m_iconList.Images.SetKeyName(32, "Calculator.ico");
            this.m_iconList.Images.SetKeyName(33, "Calendar.ico");
            this.m_iconList.Images.SetKeyName(34, "Cancel.ico");
            this.m_iconList.Images.SetKeyName(35, "Car key.ico");
            this.m_iconList.Images.SetKeyName(36, "CD.ico");
            this.m_iconList.Images.SetKeyName(37, "Clipboard.ico");
            this.m_iconList.Images.SetKeyName(38, "Clock.ico");
            this.m_iconList.Images.SetKeyName(39, "Coin.ico");
            this.m_iconList.Images.SetKeyName(40, "Comment.ico");
            this.m_iconList.Images.SetKeyName(41, "Company.ico");
            this.m_iconList.Images.SetKeyName(42, "Compass.ico");
            this.m_iconList.Images.SetKeyName(43, "Component.ico");
            this.m_iconList.Images.SetKeyName(44, "Computer 16x16.ico");
            this.m_iconList.Images.SetKeyName(45, "Copy.ico");
            this.m_iconList.Images.SetKeyName(46, "Create.ico");
            this.m_iconList.Images.SetKeyName(47, "Cut.ico");
            this.m_iconList.Images.SetKeyName(48, "Danger.ico");
            this.m_iconList.Images.SetKeyName(49, "Database.ico");
            this.m_iconList.Images.SetKeyName(50, "Delete.ico");
            this.m_iconList.Images.SetKeyName(51, "Delivery.ico");
            this.m_iconList.Images.SetKeyName(52, "Diagram.ico");
            this.m_iconList.Images.SetKeyName(53, "Dial.ico");
            this.m_iconList.Images.SetKeyName(54, "Disaster.ico");
            this.m_iconList.Images.SetKeyName(55, "Display 16x16.ico");
            this.m_iconList.Images.SetKeyName(56, "Dollar.ico");
            this.m_iconList.Images.SetKeyName(57, "Door.ico");
            this.m_iconList.Images.SetKeyName(58, "Down.ico");
            this.m_iconList.Images.SetKeyName(59, "Download.ico");
            this.m_iconList.Images.SetKeyName(60, "Downloads folder.ico");
            this.m_iconList.Images.SetKeyName(61, "Earth.ico");
            this.m_iconList.Images.SetKeyName(62, "Eject.ico");
            this.m_iconList.Images.SetKeyName(63, "E-mail.ico");
            this.m_iconList.Images.SetKeyName(64, "Equipment.ico");
            this.m_iconList.Images.SetKeyName(65, "Erase.ico");
            this.m_iconList.Images.SetKeyName(66, "Error.ico");
            this.m_iconList.Images.SetKeyName(67, "Euro.ico");
            this.m_iconList.Images.SetKeyName(68, "Exit.ico");
            this.m_iconList.Images.SetKeyName(69, "Expand.ico");
            this.m_iconList.Images.SetKeyName(70, "Eye.ico");
            this.m_iconList.Images.SetKeyName(71, "Fall.ico");
            this.m_iconList.Images.SetKeyName(72, "Fast-forward.ico");
            this.m_iconList.Images.SetKeyName(73, "Favourites.ico");
            this.m_iconList.Images.SetKeyName(74, "Female symbol.ico");
            this.m_iconList.Images.SetKeyName(75, "Female.ico");
            this.m_iconList.Images.SetKeyName(76, "Film.ico");
            this.m_iconList.Images.SetKeyName(77, "Filter.ico");
            this.m_iconList.Images.SetKeyName(78, "Find.ico");
            this.m_iconList.Images.SetKeyName(79, "First record.ico");
            this.m_iconList.Images.SetKeyName(80, "First.ico");
            this.m_iconList.Images.SetKeyName(81, "Flag.ico");
            this.m_iconList.Images.SetKeyName(82, "Flash drive.ico");
            this.m_iconList.Images.SetKeyName(83, "Folder.ico");
            this.m_iconList.Images.SetKeyName(84, "Forbidden.ico");
            this.m_iconList.Images.SetKeyName(85, "Forward.ico");
            this.m_iconList.Images.SetKeyName(86, "Free bsd.ico");
            this.m_iconList.Images.SetKeyName(87, "Gift.ico");
            this.m_iconList.Images.SetKeyName(88, "Globe.ico");
            this.m_iconList.Images.SetKeyName(89, "Go back.ico");
            this.m_iconList.Images.SetKeyName(90, "Go forward.ico");
            this.m_iconList.Images.SetKeyName(91, "Go.ico");
            this.m_iconList.Images.SetKeyName(92, "Good mark.ico");
            this.m_iconList.Images.SetKeyName(93, "Green bookmark.ico");
            this.m_iconList.Images.SetKeyName(94, "Green pin.ico");
            this.m_iconList.Images.SetKeyName(95, "Green tag.ico");
            this.m_iconList.Images.SetKeyName(96, "Hard disk.ico");
            this.m_iconList.Images.SetKeyName(97, "Heart.ico");
            this.m_iconList.Images.SetKeyName(98, "Help book 3d.ico");
            this.m_iconList.Images.SetKeyName(99, "Help book.ico");
            this.m_iconList.Images.SetKeyName(100, "Help symbol.ico");
            this.m_iconList.Images.SetKeyName(101, "Help.ico");
            this.m_iconList.Images.SetKeyName(102, "Hint.ico");
            this.m_iconList.Images.SetKeyName(103, "History.ico");
            this.m_iconList.Images.SetKeyName(104, "Home.ico");
            this.m_iconList.Images.SetKeyName(105, "Hourglass.ico");
            this.m_iconList.Images.SetKeyName(106, "How-to.ico");
            this.m_iconList.Images.SetKeyName(107, "Hungup.ico");
            this.m_iconList.Images.SetKeyName(108, "Info.ico");
            this.m_iconList.Images.SetKeyName(109, "In-yang.ico");
            this.m_iconList.Images.SetKeyName(110, "Iphone.ico");
            this.m_iconList.Images.SetKeyName(111, "Key.ico");
            this.m_iconList.Images.SetKeyName(112, "Last recor.ico");
            this.m_iconList.Images.SetKeyName(113, "Last.ico");
            this.m_iconList.Images.SetKeyName(114, "Left-right.ico");
            this.m_iconList.Images.SetKeyName(115, "Letter.ico");
            this.m_iconList.Images.SetKeyName(116, "Lightning.ico");
            this.m_iconList.Images.SetKeyName(117, "Liner.ico");
            this.m_iconList.Images.SetKeyName(118, "Linux.ico");
            this.m_iconList.Images.SetKeyName(119, "List.ico");
            this.m_iconList.Images.SetKeyName(120, "Load.ico");
            this.m_iconList.Images.SetKeyName(121, "Lock.ico");
            this.m_iconList.Images.SetKeyName(122, "Low rating.ico");
            this.m_iconList.Images.SetKeyName(123, "Magic wand.ico");
            this.m_iconList.Images.SetKeyName(124, "Mail.ico");
            this.m_iconList.Images.SetKeyName(125, "Male symbol.ico");
            this.m_iconList.Images.SetKeyName(126, "Male.ico");
            this.m_iconList.Images.SetKeyName(127, "Medium rating.ico");
            this.m_iconList.Images.SetKeyName(128, "Message.ico");
            this.m_iconList.Images.SetKeyName(129, "Mobile-phone.ico");
            this.m_iconList.Images.SetKeyName(130, "Modify.ico");
            this.m_iconList.Images.SetKeyName(131, "Move.ico");
            this.m_iconList.Images.SetKeyName(132, "Movie.ico");
            this.m_iconList.Images.SetKeyName(133, "Music.ico");
            this.m_iconList.Images.SetKeyName(134, "Mute.ico");
            this.m_iconList.Images.SetKeyName(135, "Network connection.ico");
            this.m_iconList.Images.SetKeyName(136, "New document.ico");
            this.m_iconList.Images.SetKeyName(137, "New.ico");
            this.m_iconList.Images.SetKeyName(138, "Next track.ico");
            this.m_iconList.Images.SetKeyName(139, "Next.ico");
            this.m_iconList.Images.SetKeyName(140, "No.ico");
            this.m_iconList.Images.SetKeyName(141, "No-entry.ico");
            this.m_iconList.Images.SetKeyName(142, "Notes.ico");
            this.m_iconList.Images.SetKeyName(143, "OK.ico");
            this.m_iconList.Images.SetKeyName(144, "Paste.ico");
            this.m_iconList.Images.SetKeyName(145, "Pause.ico");
            this.m_iconList.Images.SetKeyName(146, "People.ico");
            this.m_iconList.Images.SetKeyName(147, "Percent.ico");
            this.m_iconList.Images.SetKeyName(148, "Person.ico");
            this.m_iconList.Images.SetKeyName(149, "Phone number.ico");
            this.m_iconList.Images.SetKeyName(150, "Phone.ico");
            this.m_iconList.Images.SetKeyName(151, "Picture.ico");
            this.m_iconList.Images.SetKeyName(152, "Pie chart.ico");
            this.m_iconList.Images.SetKeyName(153, "Pinion.ico");
            this.m_iconList.Images.SetKeyName(154, "Play.ico");
            this.m_iconList.Images.SetKeyName(155, "Playback.ico");
            this.m_iconList.Images.SetKeyName(156, "Play-music.ico");
            this.m_iconList.Images.SetKeyName(157, "Previous record.ico");
            this.m_iconList.Images.SetKeyName(158, "Previous.ico");
            this.m_iconList.Images.SetKeyName(159, "Print.ico");
            this.m_iconList.Images.SetKeyName(160, "Problem.ico");
            this.m_iconList.Images.SetKeyName(161, "Question.ico");
            this.m_iconList.Images.SetKeyName(162, "Radiation.ico");
            this.m_iconList.Images.SetKeyName(163, "Raise.ico");
            this.m_iconList.Images.SetKeyName(164, "Record.ico");
            this.m_iconList.Images.SetKeyName(165, "Red bookmark.ico");
            this.m_iconList.Images.SetKeyName(166, "Red mark.ico");
            this.m_iconList.Images.SetKeyName(167, "Red pin.ico");
            this.m_iconList.Images.SetKeyName(168, "Red star.ico");
            this.m_iconList.Images.SetKeyName(169, "Red tag.ico");
            this.m_iconList.Images.SetKeyName(170, "Redo.ico");
            this.m_iconList.Images.SetKeyName(171, "Refresh.ico");
            this.m_iconList.Images.SetKeyName(172, "Remove.ico");
            this.m_iconList.Images.SetKeyName(173, "Repair.ico");
            this.m_iconList.Images.SetKeyName(174, "Report.ico");
            this.m_iconList.Images.SetKeyName(175, "Retort.ico");
            this.m_iconList.Images.SetKeyName(176, "Rewind.ico");
            this.m_iconList.Images.SetKeyName(177, "Sad.ico");
            this.m_iconList.Images.SetKeyName(178, "Save.ico");
            this.m_iconList.Images.SetKeyName(179, "Schedule.ico");
            this.m_iconList.Images.SetKeyName(180, "Script.ico");
            this.m_iconList.Images.SetKeyName(181, "Search.ico");
            this.m_iconList.Images.SetKeyName(182, "Shield 16x16.ico");
            this.m_iconList.Images.SetKeyName(183, "Shopping cart.ico");
            this.m_iconList.Images.SetKeyName(184, "Silence.ico");
            this.m_iconList.Images.SetKeyName(185, "Smile.ico");
            this.m_iconList.Images.SetKeyName(186, "Sound.ico");
            this.m_iconList.Images.SetKeyName(187, "Stock graph.ico");
            this.m_iconList.Images.SetKeyName(188, "Stop sign.ico");
            this.m_iconList.Images.SetKeyName(189, "Stop.ico");
            this.m_iconList.Images.SetKeyName(190, "Stopwatch.ico");
            this.m_iconList.Images.SetKeyName(191, "Sum.ico");
            this.m_iconList.Images.SetKeyName(192, "Sync.ico");
            this.m_iconList.Images.SetKeyName(193, "Table.ico");
            this.m_iconList.Images.SetKeyName(194, "Target.ico");
            this.m_iconList.Images.SetKeyName(195, "Taxi.ico");
            this.m_iconList.Images.SetKeyName(196, "Terminate.ico");
            this.m_iconList.Images.SetKeyName(197, "Text preview.ico");
            this.m_iconList.Images.SetKeyName(198, "Text.ico");
            this.m_iconList.Images.SetKeyName(199, "Thumbs down.ico");
            this.m_iconList.Images.SetKeyName(200, "Thumbs up.ico");
            this.m_iconList.Images.SetKeyName(201, "Toolbox.ico");
            this.m_iconList.Images.SetKeyName(202, "Top.ico");
            this.m_iconList.Images.SetKeyName(203, "Trackback.ico");
            this.m_iconList.Images.SetKeyName(204, "Trash.ico");
            this.m_iconList.Images.SetKeyName(205, "Tune.ico");
            this.m_iconList.Images.SetKeyName(206, "Turn off.ico");
            this.m_iconList.Images.SetKeyName(207, "Twitter.ico");
            this.m_iconList.Images.SetKeyName(208, "Undo.ico");
            this.m_iconList.Images.SetKeyName(209, "Unlock.ico");
            this.m_iconList.Images.SetKeyName(210, "Up.ico");
            this.m_iconList.Images.SetKeyName(211, "Update.ico");
            this.m_iconList.Images.SetKeyName(212, "Up-down.ico");
            this.m_iconList.Images.SetKeyName(213, "Upload.ico");
            this.m_iconList.Images.SetKeyName(214, "User group.ico");
            this.m_iconList.Images.SetKeyName(215, "View.ico");
            this.m_iconList.Images.SetKeyName(216, "Volume.ico");
            this.m_iconList.Images.SetKeyName(217, "Wallet.ico");
            this.m_iconList.Images.SetKeyName(218, "Warning.ico");
            this.m_iconList.Images.SetKeyName(219, "Wrench.ico");
            this.m_iconList.Images.SetKeyName(220, "Yellow bookmark.ico");
            this.m_iconList.Images.SetKeyName(221, "Yellow pin.ico");
            this.m_iconList.Images.SetKeyName(222, "Yellow tag.ico");
            this.m_iconList.Images.SetKeyName(223, "Yes.ico");
            this.m_iconList.Images.SetKeyName(224, "Zoom.ico");
            // 
            // m_textboxSearchBox
            // 
            this.m_textboxSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_textboxSearchBox.Location = new System.Drawing.Point(6, 16);
            this.m_textboxSearchBox.Name = "m_textboxSearchBox";
            this.m_textboxSearchBox.Size = new System.Drawing.Size(323, 20);
            this.m_textboxSearchBox.TabIndex = 3;
            this.m_textboxSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxSearchShortcut);
            // 
            // m_grpFilters
            // 
            this.m_grpFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_grpFilters.Controls.Add(this.m_filterContainer);
            this.m_grpFilters.Location = new System.Drawing.Point(3, 45);
            this.m_grpFilters.Name = "m_grpFilters";
            this.m_grpFilters.Size = new System.Drawing.Size(575, 46);
            this.m_grpFilters.TabIndex = 3;
            this.m_grpFilters.TabStop = false;
            this.m_grpFilters.Text = "Tag Filter";
            // 
            // m_filterContainer
            // 
            this.m_filterContainer.AutoScroll = true;
            this.m_filterContainer.Controls.Add(this.m_btnAddFilter);
            this.m_filterContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_filterContainer.Location = new System.Drawing.Point(3, 16);
            this.m_filterContainer.Name = "m_filterContainer";
            this.m_filterContainer.Size = new System.Drawing.Size(569, 27);
            this.m_filterContainer.TabIndex = 0;
            // 
            // m_btnAddFilter
            // 
            this.m_btnAddFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnAddFilter.Location = new System.Drawing.Point(3, 3);
            this.m_btnAddFilter.Name = "m_btnAddFilter";
            this.m_btnAddFilter.Size = new System.Drawing.Size(30, 20);
            this.m_btnAddFilter.TabIndex = 0;
            this.m_btnAddFilter.Text = "+";
            this.m_btnAddFilter.UseVisualStyleBackColor = true;
            this.m_btnAddFilter.Click += new System.EventHandler(this.m_btnAddFilter_Click);
            // 
            // m_spliterContainerPreviewPane
            // 
            this.m_spliterContainerPreviewPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_spliterContainerPreviewPane.Location = new System.Drawing.Point(0, 0);
            this.m_spliterContainerPreviewPane.Name = "m_spliterContainerPreviewPane";
            // 
            // m_spliterContainerPreviewPane.Panel1
            // 
            this.m_spliterContainerPreviewPane.Panel1.Controls.Add(this.m_projectExplorer);
            // 
            // m_spliterContainerPreviewPane.Panel2
            // 
            this.m_spliterContainerPreviewPane.Panel2.Controls.Add(this.m_previewPane);
            this.m_spliterContainerPreviewPane.Size = new System.Drawing.Size(583, 344);
            this.m_spliterContainerPreviewPane.SplitterDistance = 374;
            this.m_spliterContainerPreviewPane.TabIndex = 1;
            // 
            // m_projectExplorer
            // 
            this.m_projectExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_projectExplorer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_projectExplorer.Location = new System.Drawing.Point(3, 3);
            this.m_projectExplorer.Name = "m_projectExplorer";
            this.m_projectExplorer.Size = new System.Drawing.Size(369, 338);
            this.m_projectExplorer.TabIndex = 0;
            // 
            // m_previewPane
            // 
            this.m_previewPane.BackColor = System.Drawing.Color.White;
            this.m_previewPane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_previewPane.CausesValidation = false;
            this.m_previewPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_previewPane.Location = new System.Drawing.Point(0, 0);
            this.m_previewPane.Name = "m_previewPane";
            this.m_previewPane.ReadOnly = true;
            this.m_previewPane.Size = new System.Drawing.Size(205, 344);
            this.m_previewPane.TabIndex = 0;
            this.m_previewPane.TabStop = false;
            this.m_previewPane.Text = "Group 7:\n - Lê Minh Trung\n - Nguyễn Hoàng Thái\n - .............\n\nProject Overview" +
    "\n - Hotel Managerment Software for 3-star-awarded-hotel Tan Son Nhat.\n\nNote(s):\n" +
    " - Note 1\n - Note 2\n - Note 3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 490);
            this.Controls.Add(this.m_splitContainerDirectoryTree);
            this.Controls.Add(this.m_statusBar);
            this.Controls.Add(this.m_menuBar);
            this.MainMenuStrip = this.m_menuBar;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Course Projects Manager";
            this.m_menuBar.ResumeLayout(false);
            this.m_menuBar.PerformLayout();
            this.m_statusBar.ResumeLayout(false);
            this.m_statusBar.PerformLayout();
            this.m_splitContainerDirectoryTree.Panel1.ResumeLayout(false);
            this.m_splitContainerDirectoryTree.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_splitContainerDirectoryTree)).EndInit();
            this.m_splitContainerDirectoryTree.ResumeLayout(false);
            this.m_spliterContainerSeachBox.Panel1.ResumeLayout(false);
            this.m_spliterContainerSeachBox.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_spliterContainerSeachBox)).EndInit();
            this.m_spliterContainerSeachBox.ResumeLayout(false);
            this.m_grpSearch.ResumeLayout(false);
            this.m_grpSearch.PerformLayout();
            this.m_grpFilters.ResumeLayout(false);
            this.m_filterContainer.ResumeLayout(false);
            this.m_spliterContainerPreviewPane.Panel1.ResumeLayout(false);
            this.m_spliterContainerPreviewPane.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_spliterContainerPreviewPane)).EndInit();
            this.m_spliterContainerPreviewPane.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip m_menuBar;
        private System.Windows.Forms.StatusStrip m_statusBar;
        private System.Windows.Forms.SplitContainer m_splitContainerDirectoryTree;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel m_numOfProjects;
        private System.Windows.Forms.ToolStripStatusLabel m_numOfSelectedProprojects;
        private System.Windows.Forms.ToolStripMenuItem previewPaneToolStripMenuItem;
        private System.Windows.Forms.SplitContainer m_spliterContainerSeachBox;
        private System.Windows.Forms.SplitContainer m_spliterContainerPreviewPane;
        private System.Windows.Forms.RichTextBox m_previewPane;
        private System.Windows.Forms.ImageList m_iconList;
        private System.Windows.Forms.ToolStripMenuItem checklistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newChecklistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compareToolStripMenuItem;
        private Controls.ProjectExplorer m_projectExplorer;
        private System.Windows.Forms.ToolStripMenuItem seachPaneToolStripMenuItem;
        private System.Windows.Forms.GroupBox m_grpFilters;
        private System.Windows.Forms.FlowLayoutPanel m_filterContainer;
        private System.Windows.Forms.Button m_btnAddFilter;
        private Controls.TreeviewExplorer m_directoryTreeView;
        private System.Windows.Forms.GroupBox m_grpSearch;
        private System.Windows.Forms.ComboBox m_cboSeachType;
        private System.Windows.Forms.Button m_btnSearch;
        private System.Windows.Forms.TextBox m_textboxSearchBox;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;

    }
}