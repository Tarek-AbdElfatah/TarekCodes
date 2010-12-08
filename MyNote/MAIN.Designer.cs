namespace MyNote
{
    partial class MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MSFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MsAddNewSection = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافةموضوعجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSChangeMainPath = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSSave = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMSAddNewSection = new System.Windows.Forms.ToolStripMenuItem();
            this.CMSAddNewSubSection = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeView1.RightToLeftLayout = true;
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(171, 357);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "My-Computer.ico");
            this.imageList1.Images.SetKeyName(1, "Folder-close_blue.ico");
            this.imageList1.Images.SetKeyName(2, "RTF.ico");
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(450, 357);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 59);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeView1);
            this.splitContainer1.Size = new System.Drawing.Size(625, 357);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSFile,
            this.MSChangeMainPath});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(625, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MSFile
            // 
            this.MSFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsAddNewSection,
            this.اضافةموضوعجديدToolStripMenuItem});
            this.MSFile.Name = "MSFile";
            this.MSFile.Size = new System.Drawing.Size(39, 20);
            this.MSFile.Text = "ملف";
            // 
            // MsAddNewSection
            // 
            this.MsAddNewSection.Name = "MsAddNewSection";
            this.MsAddNewSection.Size = new System.Drawing.Size(160, 22);
            this.MsAddNewSection.Text = "اضافة قسم جديد";
            // 
            // اضافةموضوعجديدToolStripMenuItem
            // 
            this.اضافةموضوعجديدToolStripMenuItem.Name = "اضافةموضوعجديدToolStripMenuItem";
            this.اضافةموضوعجديدToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.اضافةموضوعجديدToolStripMenuItem.Text = "اضافة موضوع جديد";
            // 
            // MSChangeMainPath
            // 
            this.MSChangeMainPath.Name = "MSChangeMainPath";
            this.MSChangeMainPath.Size = new System.Drawing.Size(120, 20);
            this.MSChangeMainPath.Text = "تغيير المسار الرئيسى";
            this.MSChangeMainPath.Click += new System.EventHandler(this.MSChangeMainPath_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(625, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSSave
            // 
            this.TSSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSSave.Image = ((System.Drawing.Image)(resources.GetObject("TSSave.Image")));
            this.TSSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSSave.Name = "TSSave";
            this.TSSave.Size = new System.Drawing.Size(23, 22);
            this.TSSave.Text = "toolStripButton1";
            this.TSSave.Click += new System.EventHandler(this.TSSave_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMSAddNewSection,
            this.CMSAddNewSubSection});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 48);
            // 
            // CMSAddNewSection
            // 
            this.CMSAddNewSection.Name = "CMSAddNewSection";
            this.CMSAddNewSection.Size = new System.Drawing.Size(174, 22);
            this.CMSAddNewSection.Text = "اضافة قسم جديد";
            this.CMSAddNewSection.Click += new System.EventHandler(this.CMSAddNewSection_Click);
            // 
            // CMSAddNewSubSection
            // 
            this.CMSAddNewSubSection.Name = "CMSAddNewSubSection";
            this.CMSAddNewSubSection.Size = new System.Drawing.Size(174, 22);
            this.CMSAddNewSubSection.Text = "اضافة فرع داخل قسم";
            this.CMSAddNewSubSection.Click += new System.EventHandler(this.CMSAddNewSubSection_Click);
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 428);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MAIN";
            this.Text = "مدونتى";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MSFile;
        private System.Windows.Forms.ToolStripMenuItem MsAddNewSection;
        private System.Windows.Forms.ToolStripMenuItem اضافةموضوعجديدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MSChangeMainPath;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CMSAddNewSection;
        private System.Windows.Forms.ToolStripMenuItem CMSAddNewSubSection;
    }
}

