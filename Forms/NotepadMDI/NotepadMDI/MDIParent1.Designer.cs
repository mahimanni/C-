﻿namespace NotepadMDI
{
    partial class MDIParent1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            menuStrip = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            printToolStripMenuItem = new ToolStripMenuItem();
            printPreviewToolStripMenuItem = new ToolStripMenuItem();
            printSetupToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editMenu = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            viewMenu = new ToolStripMenuItem();
            toolBarToolStripMenuItem = new ToolStripMenuItem();
            statusBarToolStripMenuItem = new ToolStripMenuItem();
            toolsMenu = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            windowsMenu = new ToolStripMenuItem();
            newWindowToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            closeAllToolStripMenuItem = new ToolStripMenuItem();
            arrangeIconsToolStripMenuItem = new ToolStripMenuItem();
            helpMenu = new ToolStripMenuItem();
            contentsToolStripMenuItem = new ToolStripMenuItem();
            indexToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            newToolStripButton = new ToolStripButton();
            openToolStripButton = new ToolStripButton();
            saveToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            printToolStripButton = new ToolStripButton();
            printPreviewToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            helpToolStripButton = new ToolStripButton();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            richTextBox1 = new RichTextBox();
            toolStripButton1 = new Button();
            toolStripButton2 = new Button();
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenu, editMenu, viewMenu, toolsMenu, windowsMenu, helpMenu });
            menuStrip.Location = new Point(0, 0);
            menuStrip.MdiWindowListItem = windowsMenu;
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(10, 4, 0, 4);
            menuStrip.Size = new Size(1053, 37);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator3, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator4, printToolStripMenuItem, printPreviewToolStripMenuItem, printSetupToolStripMenuItem, toolStripSeparator5, exitToolStripMenuItem });
            fileMenu.ImageTransparentColor = SystemColors.ActiveBorder;
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(54, 29);
            fileMenu.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.ImageTransparentColor = Color.Black;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(223, 34);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += ShowNewForm;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Black;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(223, 34);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += OpenFile;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(220, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = Color.Black;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(223, 34);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(223, 34);
            saveAsToolStripMenuItem.Text = "Save &As";
            saveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(220, 6);
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Image = (Image)resources.GetObject("printToolStripMenuItem.Image");
            printToolStripMenuItem.ImageTransparentColor = Color.Black;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem.Size = new Size(223, 34);
            printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Image = (Image)resources.GetObject("printPreviewToolStripMenuItem.Image");
            printPreviewToolStripMenuItem.ImageTransparentColor = Color.Black;
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new Size(223, 34);
            printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // printSetupToolStripMenuItem
            // 
            printSetupToolStripMenuItem.Name = "printSetupToolStripMenuItem";
            printSetupToolStripMenuItem.Size = new Size(223, 34);
            printSetupToolStripMenuItem.Text = "Print Setup";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(220, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(223, 34);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += ExitToolsStripMenuItem_Click;
            // 
            // editMenu
            // 
            editMenu.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator6, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator7, selectAllToolStripMenuItem });
            editMenu.Name = "editMenu";
            editMenu.Size = new Size(58, 29);
            editMenu.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Image = (Image)resources.GetObject("undoToolStripMenuItem.Image");
            undoToolStripMenuItem.ImageTransparentColor = Color.Black;
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(270, 34);
            undoToolStripMenuItem.Text = "&Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Image = (Image)resources.GetObject("redoToolStripMenuItem.Image");
            redoToolStripMenuItem.ImageTransparentColor = Color.Black;
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(270, 34);
            redoToolStripMenuItem.Text = "&Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(267, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = (Image)resources.GetObject("cutToolStripMenuItem.Image");
            cutToolStripMenuItem.ImageTransparentColor = Color.Black;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(270, 34);
            cutToolStripMenuItem.Text = "Cu&t";
            cutToolStripMenuItem.Click += CutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
            copyToolStripMenuItem.ImageTransparentColor = Color.Black;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(270, 34);
            copyToolStripMenuItem.Text = "&Copy";
            copyToolStripMenuItem.Click += CopyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
            pasteToolStripMenuItem.ImageTransparentColor = Color.Black;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(270, 34);
            pasteToolStripMenuItem.Text = "&Paste";
            pasteToolStripMenuItem.Click += PasteToolStripMenuItem_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(267, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem.Size = new Size(270, 34);
            selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // viewMenu
            // 
            viewMenu.DropDownItems.AddRange(new ToolStripItem[] { toolBarToolStripMenuItem, statusBarToolStripMenuItem });
            viewMenu.Name = "viewMenu";
            viewMenu.Size = new Size(65, 29);
            viewMenu.Text = "&View";
            // 
            // toolBarToolStripMenuItem
            // 
            toolBarToolStripMenuItem.Checked = true;
            toolBarToolStripMenuItem.CheckOnClick = true;
            toolBarToolStripMenuItem.CheckState = CheckState.Checked;
            toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            toolBarToolStripMenuItem.Size = new Size(192, 34);
            toolBarToolStripMenuItem.Text = "&Toolbar";
            toolBarToolStripMenuItem.Click += ToolBarToolStripMenuItem_Click;
            // 
            // statusBarToolStripMenuItem
            // 
            statusBarToolStripMenuItem.Checked = true;
            statusBarToolStripMenuItem.CheckOnClick = true;
            statusBarToolStripMenuItem.CheckState = CheckState.Checked;
            statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            statusBarToolStripMenuItem.Size = new Size(192, 34);
            statusBarToolStripMenuItem.Text = "&Status Bar";
            statusBarToolStripMenuItem.Click += StatusBarToolStripMenuItem_Click;
            // 
            // toolsMenu
            // 
            toolsMenu.DropDownItems.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            toolsMenu.Name = "toolsMenu";
            toolsMenu.Size = new Size(69, 29);
            toolsMenu.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(178, 34);
            optionsToolStripMenuItem.Text = "&Options";
            // 
            // windowsMenu
            // 
            windowsMenu.DropDownItems.AddRange(new ToolStripItem[] { newWindowToolStripMenuItem, cascadeToolStripMenuItem, tileVerticalToolStripMenuItem, tileHorizontalToolStripMenuItem, closeAllToolStripMenuItem, arrangeIconsToolStripMenuItem });
            windowsMenu.Name = "windowsMenu";
            windowsMenu.Size = new Size(102, 29);
            windowsMenu.Text = "&Windows";
            // 
            // newWindowToolStripMenuItem
            // 
            newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            newWindowToolStripMenuItem.Size = new Size(227, 34);
            newWindowToolStripMenuItem.Text = "&New Window";
            newWindowToolStripMenuItem.Click += ShowNewForm;
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(227, 34);
            cascadeToolStripMenuItem.Text = "&Cascade";
            cascadeToolStripMenuItem.Click += CascadeToolStripMenuItem_Click;
            // 
            // tileVerticalToolStripMenuItem
            // 
            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.Size = new Size(227, 34);
            tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            tileVerticalToolStripMenuItem.Click += TileVerticalToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new Size(227, 34);
            tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            tileHorizontalToolStripMenuItem.Click += TileHorizontalToolStripMenuItem_Click;
            // 
            // closeAllToolStripMenuItem
            // 
            closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            closeAllToolStripMenuItem.Size = new Size(227, 34);
            closeAllToolStripMenuItem.Text = "C&lose All";
            closeAllToolStripMenuItem.Click += CloseAllToolStripMenuItem_Click;
            // 
            // arrangeIconsToolStripMenuItem
            // 
            arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            arrangeIconsToolStripMenuItem.Size = new Size(227, 34);
            arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            arrangeIconsToolStripMenuItem.Click += ArrangeIconsToolStripMenuItem_Click;
            // 
            // helpMenu
            // 
            helpMenu.DropDownItems.AddRange(new ToolStripItem[] { contentsToolStripMenuItem, indexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator8, aboutToolStripMenuItem });
            helpMenu.Name = "helpMenu";
            helpMenu.Size = new Size(65, 29);
            helpMenu.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F1;
            contentsToolStripMenuItem.Size = new Size(255, 34);
            contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            indexToolStripMenuItem.Image = (Image)resources.GetObject("indexToolStripMenuItem.Image");
            indexToolStripMenuItem.ImageTransparentColor = Color.Black;
            indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            indexToolStripMenuItem.Size = new Size(255, 34);
            indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Image = (Image)resources.GetObject("searchToolStripMenuItem.Image");
            searchToolStripMenuItem.ImageTransparentColor = Color.Black;
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(255, 34);
            searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(252, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(255, 34);
            aboutToolStripMenuItem.Text = "&About ... ...";
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(24, 24);
            toolStrip.Items.AddRange(new ToolStripItem[] { newToolStripButton, openToolStripButton, saveToolStripButton, toolStripSeparator1, printToolStripButton, printPreviewToolStripButton, toolStripSeparator2, helpToolStripButton });
            toolStrip.Location = new Point(0, 37);
            toolStrip.Name = "toolStrip";
            toolStrip.Padding = new Padding(0, 0, 3, 0);
            toolStrip.Size = new Size(1053, 33);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "ToolStrip";
            // 
            // newToolStripButton
            // 
            newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButton.Image = (Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = Color.Black;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(34, 28);
            newToolStripButton.Text = "New";
            newToolStripButton.Click += ShowNewForm;
            // 
            // openToolStripButton
            // 
            openToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openToolStripButton.Image = (Image)resources.GetObject("openToolStripButton.Image");
            openToolStripButton.ImageTransparentColor = Color.Black;
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Size = new Size(34, 28);
            openToolStripButton.Text = "Open";
            openToolStripButton.Click += OpenFile;
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = Color.Black;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(34, 28);
            saveToolStripButton.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 33);
            // 
            // printToolStripButton
            // 
            printToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            printToolStripButton.Image = (Image)resources.GetObject("printToolStripButton.Image");
            printToolStripButton.ImageTransparentColor = Color.Black;
            printToolStripButton.Name = "printToolStripButton";
            printToolStripButton.Size = new Size(34, 28);
            printToolStripButton.Text = "Print";
            // 
            // printPreviewToolStripButton
            // 
            printPreviewToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            printPreviewToolStripButton.Image = (Image)resources.GetObject("printPreviewToolStripButton.Image");
            printPreviewToolStripButton.ImageTransparentColor = Color.Black;
            printPreviewToolStripButton.Name = "printPreviewToolStripButton";
            printPreviewToolStripButton.Size = new Size(34, 28);
            printPreviewToolStripButton.Text = "Print Preview";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 33);
            // 
            // helpToolStripButton
            // 
            helpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            helpToolStripButton.Image = (Image)resources.GetObject("helpToolStripButton.Image");
            helpToolStripButton.ImageTransparentColor = Color.Black;
            helpToolStripButton.Name = "helpToolStripButton";
            helpToolStripButton.Size = new Size(34, 28);
            helpToolStripButton.Text = "Help";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 839);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(2, 0, 23, 0);
            statusStrip.Size = new Size(1053, 32);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(60, 25);
            toolStripStatusLabel.Text = "Status";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(288, 157);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(161, 144);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // toolStripButton1
            // 
            toolStripButton1.BackColor = SystemColors.ActiveCaptionText;
            toolStripButton1.ForeColor = SystemColors.ButtonFace;
            toolStripButton1.Location = new Point(225, 320);
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(131, 34);
            toolStripButton1.TabIndex = 5;
            toolStripButton1.Text = "DarkMode🌚";
            toolStripButton1.UseVisualStyleBackColor = false;
            toolStripButton1.Click += toolStripButton1_Click_1;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Location = new Point(362, 320);
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(126, 34);
            toolStripButton2.TabIndex = 6;
            toolStripButton2.Text = "LightMode🌝";
            toolStripButton2.UseVisualStyleBackColor = true;
            toolStripButton2.Click += toolStripButton2_Click_1;
            // 
            // MDIParent1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 871);
            Controls.Add(toolStripButton2);
            Controls.Add(toolStripButton1);
            Controls.Add(richTextBox1);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(5, 6, 5, 6);
            Name = "MDIParent1";
            Text = "MDIParent1";
            Load += MDIParent1_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem printSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton printPreviewToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private RichTextBox richTextBox1;
        private Button toolStripButton1;
        private Button toolStripButton2;
    }
}


