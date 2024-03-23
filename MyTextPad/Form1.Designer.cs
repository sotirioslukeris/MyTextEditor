namespace MyTextPad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            menuNew = new ToolStripMenuItem();
            menuOpen = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            menuSave = new ToolStripMenuItem();
            menuSaveAs = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuExit = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            menuUndo = new ToolStripMenuItem();
            menuRedo = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            menuCut = new ToolStripMenuItem();
            menuCopy = new ToolStripMenuItem();
            menuPaste = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            menuSelectAll = new ToolStripMenuItem();
            menuFormat = new ToolStripMenuItem();
            menuWordWrap = new ToolStripMenuItem();
            menuFont = new ToolStripMenuItem();
            backgroundToolStripMenuItem = new ToolStripMenuItem();
            vToolStripMenuItem = new ToolStripMenuItem();
            viewStatusStrip = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            fontDLG = new FontDialog();
            openDLG = new OpenFileDialog();
            saveDLG = new SaveFileDialog();
            colorDLG = new ColorDialog();
            rtb = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, menuFormat, vToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(976, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuNew, menuOpen, toolStripSeparator, menuSave, menuSaveAs, toolStripSeparator1, menuExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "&File";
            // 
            // menuNew
            // 
            menuNew.Image = (Image)resources.GetObject("menuNew.Image");
            menuNew.ImageTransparentColor = Color.Magenta;
            menuNew.Name = "menuNew";
            menuNew.ShortcutKeys = Keys.Control | Keys.N;
            menuNew.Size = new Size(285, 34);
            menuNew.Text = "&New";
            menuNew.Click += menuNew_Click;
            // 
            // menuOpen
            // 
            menuOpen.Image = (Image)resources.GetObject("menuOpen.Image");
            menuOpen.ImageTransparentColor = Color.Magenta;
            menuOpen.Name = "menuOpen";
            menuOpen.ShortcutKeys = Keys.Control | Keys.O;
            menuOpen.Size = new Size(285, 34);
            menuOpen.Text = "&Open";
            menuOpen.Click += menuOpen_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(282, 6);
            // 
            // menuSave
            // 
            menuSave.Image = (Image)resources.GetObject("menuSave.Image");
            menuSave.ImageTransparentColor = Color.Magenta;
            menuSave.Name = "menuSave";
            menuSave.ShortcutKeys = Keys.Control | Keys.S;
            menuSave.Size = new Size(285, 34);
            menuSave.Text = "&Save";
            menuSave.Click += menuSave_Click;
            // 
            // menuSaveAs
            // 
            menuSaveAs.Name = "menuSaveAs";
            menuSaveAs.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            menuSaveAs.Size = new Size(285, 34);
            menuSaveAs.Text = "Save &As";
            menuSaveAs.Click += menuSaveAs_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(282, 6);
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(285, 34);
            menuExit.Text = "E&xit";
            menuExit.Click += menuExit_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuUndo, menuRedo, toolStripSeparator3, menuCut, menuCopy, menuPaste, toolStripSeparator4, menuSelectAll });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // menuUndo
            // 
            menuUndo.Name = "menuUndo";
            menuUndo.ShortcutKeys = Keys.Control | Keys.Z;
            menuUndo.Size = new Size(248, 34);
            menuUndo.Text = "&Undo";
            menuUndo.Click += menuUndo_Click;
            // 
            // menuRedo
            // 
            menuRedo.Name = "menuRedo";
            menuRedo.ShortcutKeys = Keys.Control | Keys.Y;
            menuRedo.Size = new Size(248, 34);
            menuRedo.Text = "&Redo";
            menuRedo.Click += menuRedo_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(245, 6);
            // 
            // menuCut
            // 
            menuCut.Image = (Image)resources.GetObject("menuCut.Image");
            menuCut.ImageTransparentColor = Color.Magenta;
            menuCut.Name = "menuCut";
            menuCut.ShortcutKeys = Keys.Control | Keys.X;
            menuCut.Size = new Size(248, 34);
            menuCut.Text = "Cu&t";
            menuCut.Click += menuCut_Click;
            // 
            // menuCopy
            // 
            menuCopy.Image = (Image)resources.GetObject("menuCopy.Image");
            menuCopy.ImageTransparentColor = Color.Magenta;
            menuCopy.Name = "menuCopy";
            menuCopy.ShortcutKeys = Keys.Control | Keys.C;
            menuCopy.Size = new Size(248, 34);
            menuCopy.Text = "&Copy";
            menuCopy.Click += menuCopy_Click;
            // 
            // menuPaste
            // 
            menuPaste.Image = (Image)resources.GetObject("menuPaste.Image");
            menuPaste.ImageTransparentColor = Color.Magenta;
            menuPaste.Name = "menuPaste";
            menuPaste.ShortcutKeys = Keys.Control | Keys.V;
            menuPaste.Size = new Size(248, 34);
            menuPaste.Text = "&Paste";
            menuPaste.Click += menuPaste_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(245, 6);
            // 
            // menuSelectAll
            // 
            menuSelectAll.Name = "menuSelectAll";
            menuSelectAll.ShortcutKeys = Keys.Control | Keys.A;
            menuSelectAll.Size = new Size(248, 34);
            menuSelectAll.Text = "Select &All";
            menuSelectAll.Click += menuSelectAll_Click;
            // 
            // menuFormat
            // 
            menuFormat.Checked = true;
            menuFormat.CheckState = CheckState.Indeterminate;
            menuFormat.DropDownItems.AddRange(new ToolStripItem[] { menuWordWrap, menuFont, backgroundToolStripMenuItem });
            menuFormat.Name = "menuFormat";
            menuFormat.Size = new Size(85, 29);
            menuFormat.Text = "Forma&t";
            // 
            // menuWordWrap
            // 
            menuWordWrap.Name = "menuWordWrap";
            menuWordWrap.Size = new Size(209, 34);
            menuWordWrap.Text = "&Word Wrap";
            menuWordWrap.Click += menuWordWrap_Click;
            // 
            // menuFont
            // 
            menuFont.Name = "menuFont";
            menuFont.Size = new Size(209, 34);
            menuFont.Text = "Font";
            menuFont.Click += menuFont_Click;
            // 
            // backgroundToolStripMenuItem
            // 
            backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            backgroundToolStripMenuItem.Size = new Size(209, 34);
            backgroundToolStripMenuItem.Text = "Background";
            backgroundToolStripMenuItem.Click += backgroundToolStripMenuItem_Click;
            // 
            // vToolStripMenuItem
            // 
            vToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewStatusStrip });
            vToolStripMenuItem.Name = "vToolStripMenuItem";
            vToolStripMenuItem.Size = new Size(65, 29);
            vToolStripMenuItem.Text = "View";
            // 
            // viewStatusStrip
            // 
            viewStatusStrip.CheckOnClick = true;
            viewStatusStrip.Name = "viewStatusStrip";
            viewStatusStrip.Size = new Size(202, 34);
            viewStatusStrip.Text = "Status strip";
            viewStatusStrip.Click += viewStatusStrip_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Location = new Point(0, 534);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(976, 28);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip";
            statusStrip.Visible = false;
            // 
            // openDLG
            // 
            openDLG.FileName = "openFileDialog1";
            // 
            // rtb
            // 
            rtb.Dock = DockStyle.Fill;
            rtb.Location = new Point(0, 33);
            rtb.Name = "rtb";
            rtb.Size = new Size(976, 529);
            rtb.TabIndex = 2;
            rtb.Text = "";
            rtb.WordWrap = false;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(976, 562);
            Controls.Add(rtb);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "My Text Pad - Unsaved file";
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem menuNew;
        private ToolStripMenuItem menuOpen;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem menuSave;
        private ToolStripMenuItem menuSaveAs;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem menuUndo;
        private ToolStripMenuItem menuRedo;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem menuCut;
        private ToolStripMenuItem menuCopy;
        private ToolStripMenuItem menuPaste;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem menuSelectAll;
        private ToolStripMenuItem menuFormat;
        private ToolStripMenuItem menuWordWrap;
        private ToolStripMenuItem menuFont;
        private StatusStrip statusStrip;
        private FontDialog fontDLG;
        private OpenFileDialog openDLG;
        private SaveFileDialog saveDLG;
        private ColorDialog colorDLG;
        private RichTextBox rtb;
        private ToolStripMenuItem backgroundToolStripMenuItem;
        private ToolStripMenuItem vToolStripMenuItem;
        private ToolStripMenuItem viewStatusStrip;
    }
}
