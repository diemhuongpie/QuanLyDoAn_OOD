namespace Presentation.Controlers
{
    partial class ProjectDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectDisplay));
            this.m_splitContainerProgressBar = new System.Windows.Forms.SplitContainer();
            this.m_progressBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.m_smallIcons = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.m_authors = new System.Windows.Forms.Button();
            this.m_lastUpdate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_contexMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seeMoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.m_splitContainerProgressBar)).BeginInit();
            this.m_splitContainerProgressBar.Panel1.SuspendLayout();
            this.m_splitContainerProgressBar.Panel2.SuspendLayout();
            this.m_splitContainerProgressBar.SuspendLayout();
            this.m_contexMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_splitContainerProgressBar
            // 
            this.m_splitContainerProgressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_splitContainerProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_splitContainerProgressBar.IsSplitterFixed = true;
            this.m_splitContainerProgressBar.Location = new System.Drawing.Point(0, 0);
            this.m_splitContainerProgressBar.Margin = new System.Windows.Forms.Padding(0);
            this.m_splitContainerProgressBar.Name = "m_splitContainerProgressBar";
            this.m_splitContainerProgressBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // m_splitContainerProgressBar.Panel1
            // 
            this.m_splitContainerProgressBar.Panel1.Controls.Add(this.m_progressBar);
            this.m_splitContainerProgressBar.Panel1MinSize = 5;
            // 
            // m_splitContainerProgressBar.Panel2
            // 
            this.m_splitContainerProgressBar.Panel2.Controls.Add(this.button1);
            this.m_splitContainerProgressBar.Panel2.Controls.Add(this.button2);
            this.m_splitContainerProgressBar.Panel2.Controls.Add(this.m_authors);
            this.m_splitContainerProgressBar.Panel2.Controls.Add(this.m_lastUpdate);
            this.m_splitContainerProgressBar.Panel2.Controls.Add(this.label2);
            this.m_splitContainerProgressBar.Panel2.Controls.Add(this.label1);
            this.m_splitContainerProgressBar.Panel2MinSize = 5;
            this.m_splitContainerProgressBar.Size = new System.Drawing.Size(299, 52);
            this.m_splitContainerProgressBar.SplitterDistance = 24;
            this.m_splitContainerProgressBar.SplitterWidth = 1;
            this.m_splitContainerProgressBar.TabIndex = 0;
            // 
            // m_progressBar
            // 
            this.m_progressBar.BackColor = System.Drawing.Color.White;
            this.m_progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_progressBar.Location = new System.Drawing.Point(0, 0);
            this.m_progressBar.Name = "m_progressBar";
            this.m_progressBar.Size = new System.Drawing.Size(297, 22);
            this.m_progressBar.Step = 1;
            this.m_progressBar.TabIndex = 1;
            this.m_progressBar.Value = 72;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ImageIndex = 142;
            this.button1.ImageList = this.m_smallIcons;
            this.button1.Location = new System.Drawing.Point(200, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // m_smallIcons
            // 
            this.m_smallIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("m_smallIcons.ImageStream")));
            this.m_smallIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.m_smallIcons.Images.SetKeyName(0, "3d bar chart.ico");
            this.m_smallIcons.Images.SetKeyName(1, "Abort.ico");
            this.m_smallIcons.Images.SetKeyName(2, "About.ico");
            this.m_smallIcons.Images.SetKeyName(3, "Accounting.ico");
            this.m_smallIcons.Images.SetKeyName(4, "Add.ico");
            this.m_smallIcons.Images.SetKeyName(5, "Address book.ico");
            this.m_smallIcons.Images.SetKeyName(6, "Alarm clock.ico");
            this.m_smallIcons.Images.SetKeyName(7, "Alarm.ico");
            this.m_smallIcons.Images.SetKeyName(8, "Alert.ico");
            this.m_smallIcons.Images.SetKeyName(9, "Alien.ico");
            this.m_smallIcons.Images.SetKeyName(10, "Anchor.ico");
            this.m_smallIcons.Images.SetKeyName(11, "Application.ico");
            this.m_smallIcons.Images.SetKeyName(12, "Apply.ico");
            this.m_smallIcons.Images.SetKeyName(13, "Back.ico");
            this.m_smallIcons.Images.SetKeyName(14, "Bad mark.ico");
            this.m_smallIcons.Images.SetKeyName(15, "Bee.ico");
            this.m_smallIcons.Images.SetKeyName(16, "Black bookmark.ico");
            this.m_smallIcons.Images.SetKeyName(17, "Black pin.ico");
            this.m_smallIcons.Images.SetKeyName(18, "Black tag.ico");
            this.m_smallIcons.Images.SetKeyName(19, "Blog.ico");
            this.m_smallIcons.Images.SetKeyName(20, "Blue bookmark.ico");
            this.m_smallIcons.Images.SetKeyName(21, "Blue key.ico");
            this.m_smallIcons.Images.SetKeyName(22, "Blue pin.ico");
            this.m_smallIcons.Images.SetKeyName(23, "Blue tag.ico");
            this.m_smallIcons.Images.SetKeyName(24, "Bomb.ico");
            this.m_smallIcons.Images.SetKeyName(25, "Bookmark.ico");
            this.m_smallIcons.Images.SetKeyName(26, "Boss.ico");
            this.m_smallIcons.Images.SetKeyName(27, "Bottom.ico");
            this.m_smallIcons.Images.SetKeyName(28, "Briefcase.ico");
            this.m_smallIcons.Images.SetKeyName(29, "Brush.ico");
            this.m_smallIcons.Images.SetKeyName(30, "Bubble.ico");
            this.m_smallIcons.Images.SetKeyName(31, "Buy.ico");
            this.m_smallIcons.Images.SetKeyName(32, "Calculator.ico");
            this.m_smallIcons.Images.SetKeyName(33, "Calendar.ico");
            this.m_smallIcons.Images.SetKeyName(34, "Cancel.ico");
            this.m_smallIcons.Images.SetKeyName(35, "Car key.ico");
            this.m_smallIcons.Images.SetKeyName(36, "CD.ico");
            this.m_smallIcons.Images.SetKeyName(37, "Clipboard.ico");
            this.m_smallIcons.Images.SetKeyName(38, "Clock.ico");
            this.m_smallIcons.Images.SetKeyName(39, "Coin.ico");
            this.m_smallIcons.Images.SetKeyName(40, "Comment.ico");
            this.m_smallIcons.Images.SetKeyName(41, "Company.ico");
            this.m_smallIcons.Images.SetKeyName(42, "Compass.ico");
            this.m_smallIcons.Images.SetKeyName(43, "Component.ico");
            this.m_smallIcons.Images.SetKeyName(44, "Computer 16x16.ico");
            this.m_smallIcons.Images.SetKeyName(45, "Copy.ico");
            this.m_smallIcons.Images.SetKeyName(46, "Create.ico");
            this.m_smallIcons.Images.SetKeyName(47, "Cut.ico");
            this.m_smallIcons.Images.SetKeyName(48, "Danger.ico");
            this.m_smallIcons.Images.SetKeyName(49, "Database.ico");
            this.m_smallIcons.Images.SetKeyName(50, "Delete.ico");
            this.m_smallIcons.Images.SetKeyName(51, "Delivery.ico");
            this.m_smallIcons.Images.SetKeyName(52, "Diagram.ico");
            this.m_smallIcons.Images.SetKeyName(53, "Dial.ico");
            this.m_smallIcons.Images.SetKeyName(54, "Disaster.ico");
            this.m_smallIcons.Images.SetKeyName(55, "Display 16x16.ico");
            this.m_smallIcons.Images.SetKeyName(56, "Dollar.ico");
            this.m_smallIcons.Images.SetKeyName(57, "Door.ico");
            this.m_smallIcons.Images.SetKeyName(58, "Down.ico");
            this.m_smallIcons.Images.SetKeyName(59, "Download.ico");
            this.m_smallIcons.Images.SetKeyName(60, "Downloads folder.ico");
            this.m_smallIcons.Images.SetKeyName(61, "Earth.ico");
            this.m_smallIcons.Images.SetKeyName(62, "Eject.ico");
            this.m_smallIcons.Images.SetKeyName(63, "E-mail.ico");
            this.m_smallIcons.Images.SetKeyName(64, "Equipment.ico");
            this.m_smallIcons.Images.SetKeyName(65, "Erase.ico");
            this.m_smallIcons.Images.SetKeyName(66, "Error.ico");
            this.m_smallIcons.Images.SetKeyName(67, "Euro.ico");
            this.m_smallIcons.Images.SetKeyName(68, "Exit.ico");
            this.m_smallIcons.Images.SetKeyName(69, "Expand.ico");
            this.m_smallIcons.Images.SetKeyName(70, "Eye.ico");
            this.m_smallIcons.Images.SetKeyName(71, "Fall.ico");
            this.m_smallIcons.Images.SetKeyName(72, "Fast-forward.ico");
            this.m_smallIcons.Images.SetKeyName(73, "Favourites.ico");
            this.m_smallIcons.Images.SetKeyName(74, "Female symbol.ico");
            this.m_smallIcons.Images.SetKeyName(75, "Female.ico");
            this.m_smallIcons.Images.SetKeyName(76, "Film.ico");
            this.m_smallIcons.Images.SetKeyName(77, "Filter.ico");
            this.m_smallIcons.Images.SetKeyName(78, "Find.ico");
            this.m_smallIcons.Images.SetKeyName(79, "First record.ico");
            this.m_smallIcons.Images.SetKeyName(80, "First.ico");
            this.m_smallIcons.Images.SetKeyName(81, "Flag.ico");
            this.m_smallIcons.Images.SetKeyName(82, "Flash drive.ico");
            this.m_smallIcons.Images.SetKeyName(83, "Folder.ico");
            this.m_smallIcons.Images.SetKeyName(84, "Forbidden.ico");
            this.m_smallIcons.Images.SetKeyName(85, "Forward.ico");
            this.m_smallIcons.Images.SetKeyName(86, "Free bsd.ico");
            this.m_smallIcons.Images.SetKeyName(87, "Gift.ico");
            this.m_smallIcons.Images.SetKeyName(88, "Globe.ico");
            this.m_smallIcons.Images.SetKeyName(89, "Go back.ico");
            this.m_smallIcons.Images.SetKeyName(90, "Go forward.ico");
            this.m_smallIcons.Images.SetKeyName(91, "Go.ico");
            this.m_smallIcons.Images.SetKeyName(92, "Good mark.ico");
            this.m_smallIcons.Images.SetKeyName(93, "Green bookmark.ico");
            this.m_smallIcons.Images.SetKeyName(94, "Green pin.ico");
            this.m_smallIcons.Images.SetKeyName(95, "Green tag.ico");
            this.m_smallIcons.Images.SetKeyName(96, "Hard disk.ico");
            this.m_smallIcons.Images.SetKeyName(97, "Heart.ico");
            this.m_smallIcons.Images.SetKeyName(98, "Help book 3d.ico");
            this.m_smallIcons.Images.SetKeyName(99, "Help book.ico");
            this.m_smallIcons.Images.SetKeyName(100, "Help symbol.ico");
            this.m_smallIcons.Images.SetKeyName(101, "Help.ico");
            this.m_smallIcons.Images.SetKeyName(102, "Hint.ico");
            this.m_smallIcons.Images.SetKeyName(103, "History.ico");
            this.m_smallIcons.Images.SetKeyName(104, "Home.ico");
            this.m_smallIcons.Images.SetKeyName(105, "Hourglass.ico");
            this.m_smallIcons.Images.SetKeyName(106, "How-to.ico");
            this.m_smallIcons.Images.SetKeyName(107, "Hungup.ico");
            this.m_smallIcons.Images.SetKeyName(108, "Info.ico");
            this.m_smallIcons.Images.SetKeyName(109, "In-yang.ico");
            this.m_smallIcons.Images.SetKeyName(110, "Iphone.ico");
            this.m_smallIcons.Images.SetKeyName(111, "Key.ico");
            this.m_smallIcons.Images.SetKeyName(112, "Last recor.ico");
            this.m_smallIcons.Images.SetKeyName(113, "Last.ico");
            this.m_smallIcons.Images.SetKeyName(114, "Left-right.ico");
            this.m_smallIcons.Images.SetKeyName(115, "Letter.ico");
            this.m_smallIcons.Images.SetKeyName(116, "Lightning.ico");
            this.m_smallIcons.Images.SetKeyName(117, "Liner.ico");
            this.m_smallIcons.Images.SetKeyName(118, "Linux.ico");
            this.m_smallIcons.Images.SetKeyName(119, "List.ico");
            this.m_smallIcons.Images.SetKeyName(120, "Load.ico");
            this.m_smallIcons.Images.SetKeyName(121, "Lock.ico");
            this.m_smallIcons.Images.SetKeyName(122, "Low rating.ico");
            this.m_smallIcons.Images.SetKeyName(123, "Magic wand.ico");
            this.m_smallIcons.Images.SetKeyName(124, "Mail.ico");
            this.m_smallIcons.Images.SetKeyName(125, "Male symbol.ico");
            this.m_smallIcons.Images.SetKeyName(126, "Male.ico");
            this.m_smallIcons.Images.SetKeyName(127, "Medium rating.ico");
            this.m_smallIcons.Images.SetKeyName(128, "Message.ico");
            this.m_smallIcons.Images.SetKeyName(129, "Mobile-phone.ico");
            this.m_smallIcons.Images.SetKeyName(130, "Modify.ico");
            this.m_smallIcons.Images.SetKeyName(131, "Move.ico");
            this.m_smallIcons.Images.SetKeyName(132, "Movie.ico");
            this.m_smallIcons.Images.SetKeyName(133, "Music.ico");
            this.m_smallIcons.Images.SetKeyName(134, "Mute.ico");
            this.m_smallIcons.Images.SetKeyName(135, "Network connection.ico");
            this.m_smallIcons.Images.SetKeyName(136, "New document.ico");
            this.m_smallIcons.Images.SetKeyName(137, "New.ico");
            this.m_smallIcons.Images.SetKeyName(138, "Next track.ico");
            this.m_smallIcons.Images.SetKeyName(139, "Next.ico");
            this.m_smallIcons.Images.SetKeyName(140, "No.ico");
            this.m_smallIcons.Images.SetKeyName(141, "No-entry.ico");
            this.m_smallIcons.Images.SetKeyName(142, "Notes.ico");
            this.m_smallIcons.Images.SetKeyName(143, "OK.ico");
            this.m_smallIcons.Images.SetKeyName(144, "Paste.ico");
            this.m_smallIcons.Images.SetKeyName(145, "Pause.ico");
            this.m_smallIcons.Images.SetKeyName(146, "People.ico");
            this.m_smallIcons.Images.SetKeyName(147, "Percent.ico");
            this.m_smallIcons.Images.SetKeyName(148, "Person.ico");
            this.m_smallIcons.Images.SetKeyName(149, "Phone number.ico");
            this.m_smallIcons.Images.SetKeyName(150, "Phone.ico");
            this.m_smallIcons.Images.SetKeyName(151, "Picture.ico");
            this.m_smallIcons.Images.SetKeyName(152, "Pie chart.ico");
            this.m_smallIcons.Images.SetKeyName(153, "Pinion.ico");
            this.m_smallIcons.Images.SetKeyName(154, "Play.ico");
            this.m_smallIcons.Images.SetKeyName(155, "Playback.ico");
            this.m_smallIcons.Images.SetKeyName(156, "Play-music.ico");
            this.m_smallIcons.Images.SetKeyName(157, "Previous record.ico");
            this.m_smallIcons.Images.SetKeyName(158, "Previous.ico");
            this.m_smallIcons.Images.SetKeyName(159, "Print.ico");
            this.m_smallIcons.Images.SetKeyName(160, "Problem.ico");
            this.m_smallIcons.Images.SetKeyName(161, "Question.ico");
            this.m_smallIcons.Images.SetKeyName(162, "Radiation.ico");
            this.m_smallIcons.Images.SetKeyName(163, "Raise.ico");
            this.m_smallIcons.Images.SetKeyName(164, "Record.ico");
            this.m_smallIcons.Images.SetKeyName(165, "Red bookmark.ico");
            this.m_smallIcons.Images.SetKeyName(166, "Red mark.ico");
            this.m_smallIcons.Images.SetKeyName(167, "Red pin.ico");
            this.m_smallIcons.Images.SetKeyName(168, "Red star.ico");
            this.m_smallIcons.Images.SetKeyName(169, "Red tag.ico");
            this.m_smallIcons.Images.SetKeyName(170, "Redo.ico");
            this.m_smallIcons.Images.SetKeyName(171, "Refresh.ico");
            this.m_smallIcons.Images.SetKeyName(172, "Remove.ico");
            this.m_smallIcons.Images.SetKeyName(173, "Repair.ico");
            this.m_smallIcons.Images.SetKeyName(174, "Report.ico");
            this.m_smallIcons.Images.SetKeyName(175, "Retort.ico");
            this.m_smallIcons.Images.SetKeyName(176, "Rewind.ico");
            this.m_smallIcons.Images.SetKeyName(177, "Sad.ico");
            this.m_smallIcons.Images.SetKeyName(178, "Save.ico");
            this.m_smallIcons.Images.SetKeyName(179, "Schedule.ico");
            this.m_smallIcons.Images.SetKeyName(180, "Script.ico");
            this.m_smallIcons.Images.SetKeyName(181, "Search.ico");
            this.m_smallIcons.Images.SetKeyName(182, "Shield 16x16.ico");
            this.m_smallIcons.Images.SetKeyName(183, "Shopping cart.ico");
            this.m_smallIcons.Images.SetKeyName(184, "Silence.ico");
            this.m_smallIcons.Images.SetKeyName(185, "Smile.ico");
            this.m_smallIcons.Images.SetKeyName(186, "Sound.ico");
            this.m_smallIcons.Images.SetKeyName(187, "Stock graph.ico");
            this.m_smallIcons.Images.SetKeyName(188, "Stop sign.ico");
            this.m_smallIcons.Images.SetKeyName(189, "Stop.ico");
            this.m_smallIcons.Images.SetKeyName(190, "Stopwatch.ico");
            this.m_smallIcons.Images.SetKeyName(191, "Sum.ico");
            this.m_smallIcons.Images.SetKeyName(192, "Sync.ico");
            this.m_smallIcons.Images.SetKeyName(193, "Table.ico");
            this.m_smallIcons.Images.SetKeyName(194, "Target.ico");
            this.m_smallIcons.Images.SetKeyName(195, "Taxi.ico");
            this.m_smallIcons.Images.SetKeyName(196, "Terminate.ico");
            this.m_smallIcons.Images.SetKeyName(197, "Text preview.ico");
            this.m_smallIcons.Images.SetKeyName(198, "Text.ico");
            this.m_smallIcons.Images.SetKeyName(199, "Thumbs down.ico");
            this.m_smallIcons.Images.SetKeyName(200, "Thumbs up.ico");
            this.m_smallIcons.Images.SetKeyName(201, "Toolbox.ico");
            this.m_smallIcons.Images.SetKeyName(202, "Top.ico");
            this.m_smallIcons.Images.SetKeyName(203, "Trackback.ico");
            this.m_smallIcons.Images.SetKeyName(204, "Trash.ico");
            this.m_smallIcons.Images.SetKeyName(205, "Tune.ico");
            this.m_smallIcons.Images.SetKeyName(206, "Turn off.ico");
            this.m_smallIcons.Images.SetKeyName(207, "Twitter.ico");
            this.m_smallIcons.Images.SetKeyName(208, "Undo.ico");
            this.m_smallIcons.Images.SetKeyName(209, "Unlock.ico");
            this.m_smallIcons.Images.SetKeyName(210, "Up.ico");
            this.m_smallIcons.Images.SetKeyName(211, "Update.ico");
            this.m_smallIcons.Images.SetKeyName(212, "Up-down.ico");
            this.m_smallIcons.Images.SetKeyName(213, "Upload.ico");
            this.m_smallIcons.Images.SetKeyName(214, "User group.ico");
            this.m_smallIcons.Images.SetKeyName(215, "View.ico");
            this.m_smallIcons.Images.SetKeyName(216, "Volume.ico");
            this.m_smallIcons.Images.SetKeyName(217, "Wallet.ico");
            this.m_smallIcons.Images.SetKeyName(218, "Warning.ico");
            this.m_smallIcons.Images.SetKeyName(219, "Wrench.ico");
            this.m_smallIcons.Images.SetKeyName(220, "Yellow bookmark.ico");
            this.m_smallIcons.Images.SetKeyName(221, "Yellow pin.ico");
            this.m_smallIcons.Images.SetKeyName(222, "Yellow tag.ico");
            this.m_smallIcons.Images.SetKeyName(223, "Yes.ico");
            this.m_smallIcons.Images.SetKeyName(224, "Zoom.ico");
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ImageIndex = 219;
            this.button2.ImageList = this.m_smallIcons;
            this.button2.Location = new System.Drawing.Point(232, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // m_authors
            // 
            this.m_authors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_authors.BackColor = System.Drawing.Color.Transparent;
            this.m_authors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.m_authors.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.m_authors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_authors.ImageIndex = 50;
            this.m_authors.ImageList = this.m_smallIcons;
            this.m_authors.Location = new System.Drawing.Point(264, 18);
            this.m_authors.Name = "m_authors";
            this.m_authors.Size = new System.Drawing.Size(26, 23);
            this.m_authors.TabIndex = 3;
            this.m_authors.UseVisualStyleBackColor = false;
            // 
            // m_lastUpdate
            // 
            this.m_lastUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_lastUpdate.AutoSize = true;
            this.m_lastUpdate.BackColor = System.Drawing.Color.Transparent;
            this.m_lastUpdate.Location = new System.Drawing.Point(173, 2);
            this.m_lastUpdate.Name = "m_lastUpdate";
            this.m_lastUpdate.Size = new System.Drawing.Size(121, 13);
            this.m_lastUpdate.TabIndex = 2;
            this.m_lastUpdate.Text = "Last update: 5/10/2015";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group 7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Management";
            // 
            // m_contexMenu
            // 
            this.m_contexMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seeMoreToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.addNoteToolStripMenuItem});
            this.m_contexMenu.Name = "m_contexMenu";
            this.m_contexMenu.Size = new System.Drawing.Size(124, 70);
            // 
            // seeMoreToolStripMenuItem
            // 
            this.seeMoreToolStripMenuItem.Name = "seeMoreToolStripMenuItem";
            this.seeMoreToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.seeMoreToolStripMenuItem.Text = "See more";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.addNoteToolStripMenuItem.Text = "Add note";
            // 
            // ProjectDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.m_splitContainerProgressBar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ProjectDisplay";
            this.Size = new System.Drawing.Size(299, 52);
            this.m_splitContainerProgressBar.Panel1.ResumeLayout(false);
            this.m_splitContainerProgressBar.Panel2.ResumeLayout(false);
            this.m_splitContainerProgressBar.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_splitContainerProgressBar)).EndInit();
            this.m_splitContainerProgressBar.ResumeLayout(false);
            this.m_contexMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer m_splitContainerProgressBar;
        private System.Windows.Forms.ProgressBar m_progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label m_lastUpdate;
        private System.Windows.Forms.Button m_authors;
        private System.Windows.Forms.ImageList m_smallIcons;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip m_contexMenu;
        private System.Windows.Forms.ToolStripMenuItem seeMoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;



    }
}
