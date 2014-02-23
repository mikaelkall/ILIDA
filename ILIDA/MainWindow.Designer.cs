namespace ILIDA
{
    partial class Form_MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainWindow));
            this.treeview_Definitions = new System.Windows.Forms.TreeView();
            this.tabControl_DefinitionWindow = new System.Windows.Forms.TabControl();
            this.tabPage_CodeView = new System.Windows.Forms.TabPage();
            this.richTextBox_codeView = new System.Windows.Forms.RichTextBox();
            this.tabPage_IlCode = new System.Windows.Forms.TabPage();
            this.richTextBox_Il_CodeView = new System.Windows.Forms.RichTextBox();
            this.tabPage_hexeditor = new System.Windows.Forms.TabPage();
            this.m_edtHex = new HexEdit.HexEditBox();
            this.tabPage_DeObfuscator = new System.Windows.Forms.TabPage();
            this.richTextBox_AssemblyInfo = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_OpenFile = new System.Windows.Forms.ToolStripButton();
            this.richTextBox_HexEditView = new System.Windows.Forms.RichTextBox();
            this.richTextBox_HexEditAsciiWindow = new System.Windows.Forms.RichTextBox();
            this.tabControl_DefinitionWindow.SuspendLayout();
            this.tabPage_CodeView.SuspendLayout();
            this.tabPage_IlCode.SuspendLayout();
            this.tabPage_hexeditor.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeview_Definitions
            // 
            this.treeview_Definitions.Location = new System.Drawing.Point(1, 129);
            this.treeview_Definitions.Name = "treeview_Definitions";
            this.treeview_Definitions.Size = new System.Drawing.Size(236, 624);
            this.treeview_Definitions.TabIndex = 0;
            this.treeview_Definitions.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeview_Definitions_AfterSelect);
            // 
            // tabControl_DefinitionWindow
            // 
            this.tabControl_DefinitionWindow.Controls.Add(this.tabPage_CodeView);
            this.tabControl_DefinitionWindow.Controls.Add(this.tabPage_IlCode);
            this.tabControl_DefinitionWindow.Controls.Add(this.tabPage_hexeditor);
            this.tabControl_DefinitionWindow.Controls.Add(this.tabPage_DeObfuscator);
            this.tabControl_DefinitionWindow.Location = new System.Drawing.Point(236, 129);
            this.tabControl_DefinitionWindow.Name = "tabControl_DefinitionWindow";
            this.tabControl_DefinitionWindow.SelectedIndex = 0;
            this.tabControl_DefinitionWindow.Size = new System.Drawing.Size(862, 624);
            this.tabControl_DefinitionWindow.TabIndex = 1;
            // 
            // tabPage_CodeView
            // 
            this.tabPage_CodeView.Controls.Add(this.richTextBox_codeView);
            this.tabPage_CodeView.Location = new System.Drawing.Point(4, 22);
            this.tabPage_CodeView.Name = "tabPage_CodeView";
            this.tabPage_CodeView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CodeView.Size = new System.Drawing.Size(854, 598);
            this.tabPage_CodeView.TabIndex = 0;
            this.tabPage_CodeView.Text = ".NET Code";
            this.tabPage_CodeView.UseVisualStyleBackColor = true;
            // 
            // richTextBox_codeView
            // 
            this.richTextBox_codeView.Location = new System.Drawing.Point(4, 7);
            this.richTextBox_codeView.Name = "richTextBox_codeView";
            this.richTextBox_codeView.Size = new System.Drawing.Size(847, 585);
            this.richTextBox_codeView.TabIndex = 0;
            this.richTextBox_codeView.Text = "";
            // 
            // tabPage_IlCode
            // 
            this.tabPage_IlCode.Controls.Add(this.richTextBox_Il_CodeView);
            this.tabPage_IlCode.Location = new System.Drawing.Point(4, 22);
            this.tabPage_IlCode.Name = "tabPage_IlCode";
            this.tabPage_IlCode.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_IlCode.Size = new System.Drawing.Size(854, 598);
            this.tabPage_IlCode.TabIndex = 1;
            this.tabPage_IlCode.Text = "IL Code";
            this.tabPage_IlCode.UseVisualStyleBackColor = true;
            // 
            // richTextBox_Il_CodeView
            // 
            this.richTextBox_Il_CodeView.Location = new System.Drawing.Point(6, 3);
            this.richTextBox_Il_CodeView.Name = "richTextBox_Il_CodeView";
            this.richTextBox_Il_CodeView.Size = new System.Drawing.Size(852, 599);
            this.richTextBox_Il_CodeView.TabIndex = 0;
            this.richTextBox_Il_CodeView.Text = "";
            // 
            // tabPage_hexeditor
            // 
            this.tabPage_hexeditor.Controls.Add(this.richTextBox_HexEditAsciiWindow);
            this.tabPage_hexeditor.Controls.Add(this.m_edtHex);
            this.tabPage_hexeditor.Location = new System.Drawing.Point(4, 22);
            this.tabPage_hexeditor.Name = "tabPage_hexeditor";
            this.tabPage_hexeditor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_hexeditor.Size = new System.Drawing.Size(854, 598);
            this.tabPage_hexeditor.TabIndex = 2;
            this.tabPage_hexeditor.Text = "HexEditor";
            this.tabPage_hexeditor.UseVisualStyleBackColor = true;
            // 
            // m_edtHex
            // 
            this.m_edtHex.Location = new System.Drawing.Point(0, 0);
            this.m_edtHex.Name = "m_edtHex";
            this.m_edtHex.Size = new System.Drawing.Size(246, 598);
            this.m_edtHex.TabIndex = 0;
            this.m_edtHex.Text = "";
            // 
            // tabPage_DeObfuscator
            // 
            this.tabPage_DeObfuscator.Location = new System.Drawing.Point(4, 22);
            this.tabPage_DeObfuscator.Name = "tabPage_DeObfuscator";
            this.tabPage_DeObfuscator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DeObfuscator.Size = new System.Drawing.Size(854, 598);
            this.tabPage_DeObfuscator.TabIndex = 3;
            this.tabPage_DeObfuscator.Text = "Deobfuscator";
            this.tabPage_DeObfuscator.UseVisualStyleBackColor = true;
            // 
            // richTextBox_AssemblyInfo
            // 
            this.richTextBox_AssemblyInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_AssemblyInfo.Location = new System.Drawing.Point(1, 0);
            this.richTextBox_AssemblyInfo.Name = "richTextBox_AssemblyInfo";
            this.richTextBox_AssemblyInfo.Size = new System.Drawing.Size(1097, 123);
            this.richTextBox_AssemblyInfo.TabIndex = 2;
            this.richTextBox_AssemblyInfo.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_OpenFile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1098, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_OpenFile
            // 
            this.toolStripButton_OpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_OpenFile.Image")));
            this.toolStripButton_OpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_OpenFile.Name = "toolStripButton_OpenFile";
            this.toolStripButton_OpenFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_OpenFile.Text = "Open File";
            this.toolStripButton_OpenFile.Click += new System.EventHandler(this.toolStripButton_OpenFile_Click);
            // 
            // richTextBox_HexEditView
            // 
            this.richTextBox_HexEditView.Location = new System.Drawing.Point(4, 7);
            this.richTextBox_HexEditView.Name = "richTextBox_HexEditView";
            this.richTextBox_HexEditView.Size = new System.Drawing.Size(844, 595);
            this.richTextBox_HexEditView.TabIndex = 0;
            this.richTextBox_HexEditView.Text = "";
            // 
            // richTextBox_HexEditAsciiWindow
            // 
            this.richTextBox_HexEditAsciiWindow.Location = new System.Drawing.Point(252, 0);
            this.richTextBox_HexEditAsciiWindow.Name = "richTextBox_HexEditAsciiWindow";
            this.richTextBox_HexEditAsciiWindow.Size = new System.Drawing.Size(606, 602);
            this.richTextBox_HexEditAsciiWindow.TabIndex = 1;
            this.richTextBox_HexEditAsciiWindow.Text = "";
            // 
            // Form_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 755);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox_AssemblyInfo);
            this.Controls.Add(this.tabControl_DefinitionWindow);
            this.Controls.Add(this.treeview_Definitions);
            this.Name = "Form_MainWindow";
            this.Text = "ILIDA";
            this.tabControl_DefinitionWindow.ResumeLayout(false);
            this.tabPage_CodeView.ResumeLayout(false);
            this.tabPage_IlCode.ResumeLayout(false);
            this.tabPage_hexeditor.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeview_Definitions;
        private System.Windows.Forms.TabControl tabControl_DefinitionWindow;
        private System.Windows.Forms.TabPage tabPage_CodeView;
        private System.Windows.Forms.TabPage tabPage_IlCode;
        private System.Windows.Forms.RichTextBox richTextBox_AssemblyInfo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_OpenFile;
        private System.Windows.Forms.TabPage tabPage_hexeditor;
        private System.Windows.Forms.TabPage tabPage_DeObfuscator;
        private System.Windows.Forms.RichTextBox richTextBox_codeView;
        private System.Windows.Forms.RichTextBox richTextBox_Il_CodeView;
        private System.Windows.Forms.RichTextBox richTextBox_HexEditView;
        private System.Windows.Forms.RichTextBox richTextBox_HexEditAsciiWindow;
    }
}

