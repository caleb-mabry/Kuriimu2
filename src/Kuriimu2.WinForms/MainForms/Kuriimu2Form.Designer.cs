using System.Windows.Forms;
using Kuriimu2.WinForms.Controls;

namespace Kuriimu2.WinForms.MainForms
{
    partial class Kuriimu2Form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWithPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textSequenceSearcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchExtractorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchInjectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciphersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compressionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decompressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawImageViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageTranscoderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFiles = new System.Windows.Forms.TabControl();
            this.tabCloseButtons = new System.Windows.Forms.ImageList(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.operationStatusBar = new System.Windows.Forms.StatusStrip();
            this.operationTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBarToolStrip = new Kuriimu2.WinForms.Controls.Kuriimu2ProgressBarToolStrip();
            this.statusLabelToolStrip = new System.Windows.Forms.ToolStripLabel();
            this.mnuMain.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.operationStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.ciphersToolStripMenuItem,
            this.hashesToolStripMenuItem,
            this.compressionsToolStripMenuItem,
            this.rawImageViewerToolStripMenuItem,
            this.imageTranscoderToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(2, 3, 0, 3);
            this.mnuMain.Size = new System.Drawing.Size(1275, 30);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openWithPluginToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openWithPluginToolStripMenuItem
            // 
            this.openWithPluginToolStripMenuItem.Name = "openWithPluginToolStripMenuItem";
            this.openWithPluginToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.openWithPluginToolStripMenuItem.Text = "Open with &Plugin";
            this.openWithPluginToolStripMenuItem.Click += new System.EventHandler(this.openWithPluginToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textSequenceSearcherToolStripMenuItem,
            this.batchExtractorToolStripMenuItem,
            this.batchInjectorToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // textSequenceSearcherToolStripMenuItem
            // 
            this.textSequenceSearcherToolStripMenuItem.Name = "textSequenceSearcherToolStripMenuItem";
            this.textSequenceSearcherToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.textSequenceSearcherToolStripMenuItem.Text = "Text Sequence Searcher";
            this.textSequenceSearcherToolStripMenuItem.Click += new System.EventHandler(this.textSequenceSearcherToolStripMenuItem_Click);
            // 
            // batchExtractorToolStripMenuItem
            // 
            this.batchExtractorToolStripMenuItem.Name = "batchExtractorToolStripMenuItem";
            this.batchExtractorToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.batchExtractorToolStripMenuItem.Text = "Batch Extract";
            this.batchExtractorToolStripMenuItem.Click += new System.EventHandler(this.batchExtractorToolStripMenuItem_Click);
            // 
            // batchInjectorToolStripMenuItem
            // 
            this.batchInjectorToolStripMenuItem.Name = "batchInjectorToolStripMenuItem";
            this.batchInjectorToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.batchInjectorToolStripMenuItem.Text = "Batch Inject";
            this.batchInjectorToolStripMenuItem.Click += new System.EventHandler(this.batchInjectorToolStripMenuItem_Click);
            // 
            // ciphersToolStripMenuItem
            // 
            this.ciphersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptToolStripMenuItem,
            this.decryptToolStripMenuItem});
            this.ciphersToolStripMenuItem.Name = "ciphersToolStripMenuItem";
            this.ciphersToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.ciphersToolStripMenuItem.Text = "Ciphers";
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.encryptToolStripMenuItem.Text = "Encrypt";
            this.encryptToolStripMenuItem.Click += new System.EventHandler(this.encryptToolStripMenuItem_Click);
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.decryptToolStripMenuItem.Text = "Decrypt";
            this.decryptToolStripMenuItem.Click += new System.EventHandler(this.decryptToolStripMenuItem_Click);
            // 
            // hashesToolStripMenuItem
            // 
            this.hashesToolStripMenuItem.Name = "hashesToolStripMenuItem";
            this.hashesToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.hashesToolStripMenuItem.Text = "Hashes";
            this.hashesToolStripMenuItem.Click += new System.EventHandler(this.hashesToolStripMenuItem_Click);
            // 
            // compressionsToolStripMenuItem
            // 
            this.compressionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decompressToolStripMenuItem,
            this.compressToolStripMenuItem});
            this.compressionsToolStripMenuItem.Name = "compressionsToolStripMenuItem";
            this.compressionsToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.compressionsToolStripMenuItem.Text = "Compressions";
            // 
            // decompressToolStripMenuItem
            // 
            this.decompressToolStripMenuItem.Name = "decompressToolStripMenuItem";
            this.decompressToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.decompressToolStripMenuItem.Text = "Decompress";
            this.decompressToolStripMenuItem.Click += new System.EventHandler(this.decompressToolStripMenuItem_Click);
            // 
            // compressToolStripMenuItem
            // 
            this.compressToolStripMenuItem.Name = "compressToolStripMenuItem";
            this.compressToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.compressToolStripMenuItem.Text = "Compress";
            this.compressToolStripMenuItem.Click += new System.EventHandler(this.compressToolStripMenuItem_Click);
            // 
            // rawImageViewerToolStripMenuItem
            // 
            this.rawImageViewerToolStripMenuItem.Name = "rawImageViewerToolStripMenuItem";
            this.rawImageViewerToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.rawImageViewerToolStripMenuItem.Text = "Raw Image Viewer";
            this.rawImageViewerToolStripMenuItem.Click += new System.EventHandler(this.rawImageViewerToolStripMenuItem_Click);
            // 
            // imageTranscoderToolStripMenuItem
            // 
            this.imageTranscoderToolStripMenuItem.Enabled = false;
            this.imageTranscoderToolStripMenuItem.Name = "imageTranscoderToolStripMenuItem";
            this.imageTranscoderToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.imageTranscoderToolStripMenuItem.Text = "Image Transcoder";
            // 
            // openFiles
            // 
            this.openFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openFiles.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.openFiles.ImageList = this.tabCloseButtons;
            this.openFiles.Location = new System.Drawing.Point(5, 3);
            this.openFiles.Margin = new System.Windows.Forms.Padding(0);
            this.openFiles.Name = "openFiles";
            this.openFiles.Padding = new System.Drawing.Point(8, 3);
            this.openFiles.SelectedIndex = 0;
            this.openFiles.Size = new System.Drawing.Size(1269, 798);
            this.openFiles.TabIndex = 1;
            this.openFiles.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.openFiles_DrawItem);
            this.openFiles.MouseUp += new System.Windows.Forms.MouseEventHandler(this.openFiles_MouseUp);
            // 
            // tabCloseButtons
            // 
            this.tabCloseButtons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.tabCloseButtons.ImageSize = new System.Drawing.Size(16, 16);
            this.tabCloseButtons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.openFiles);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 30);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(5, 3, 1, 3);
            this.pnlMain.Size = new System.Drawing.Size(1275, 804);
            this.pnlMain.TabIndex = 2;
            // 
            // operationStatusBar
            // 
            this.operationStatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.operationStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationTimer,
            this.progressBarToolStrip,
            this.statusLabelToolStrip});
            this.operationStatusBar.Location = new System.Drawing.Point(0, 834);
            this.operationStatusBar.Name = "operationStatusBar";
            this.operationStatusBar.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.operationStatusBar.Size = new System.Drawing.Size(1275, 23);
            this.operationStatusBar.TabIndex = 3;
            // 
            // operationTimer
            // 
            this.operationTimer.Name = "operationTimer";
            this.operationTimer.Size = new System.Drawing.Size(0, 17);
            // 
            // progressBarToolStrip
            // 
            this.progressBarToolStrip.Name = "progressBarToolStrip";
            this.progressBarToolStrip.Padding = new System.Windows.Forms.Padding(2);
            this.progressBarToolStrip.ProgressColor = System.Drawing.Color.LimeGreen;
            this.progressBarToolStrip.Size = new System.Drawing.Size(486, 21);
            this.progressBarToolStrip.TextColor = System.Drawing.Color.Black;
            this.progressBarToolStrip.Value = 0;
            // 
            // statusLabelToolStrip
            // 
            this.statusLabelToolStrip.Name = "statusLabelToolStrip";
            this.statusLabelToolStrip.Size = new System.Drawing.Size(0, 21);
            // 
            // Kuriimu2Form
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 857);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.operationStatusBar);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Kuriimu2Form";
            this.Text = "Kuriimu2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kuriimu2_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Kuriimu2_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Kuriimu2_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Kuriimu2_KeyDown);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.operationStatusBar.ResumeLayout(false);
            this.operationStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TabControl openFiles;
        private System.Windows.Forms.ImageList tabCloseButtons;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.StatusStrip operationStatusBar;
        private Kuriimu2ProgressBarToolStrip progressBarToolStrip;
        private System.Windows.Forms.ToolStripLabel statusLabelToolStrip;
        private System.Windows.Forms.ToolStripStatusLabel operationTimer;
        private System.Windows.Forms.ToolStripMenuItem openWithPluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textSequenceSearcherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchExtractorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchInjectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciphersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hashesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compressionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rawImageViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageTranscoderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decompressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compressToolStripMenuItem;
    }
}

