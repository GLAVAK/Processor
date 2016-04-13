namespace MyProcessorIDE
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainerAssemmblerOutput = new System.Windows.Forms.SplitContainer();
            this.textBoxAssembler = new FastColoredTextBoxNS.FastColoredTextBox();
            this.toolStripAssembler = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAssemblerNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAssemblerSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAssemblerOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAssemble = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelAssemblerFilename = new System.Windows.Forms.ToolStripLabel();
            this.textBoxOutput = new FastColoredTextBoxNS.FastColoredTextBox();
            this.toolStripOutput = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOutputSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOutputSaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelOutputSave = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAssemmblerOutput)).BeginInit();
            this.splitContainerAssemmblerOutput.Panel1.SuspendLayout();
            this.splitContainerAssemmblerOutput.Panel2.SuspendLayout();
            this.splitContainerAssemmblerOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAssembler)).BeginInit();
            this.toolStripAssembler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxOutput)).BeginInit();
            this.toolStripOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerAssemmblerOutput
            // 
            this.splitContainerAssemmblerOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAssemmblerOutput.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAssemmblerOutput.Name = "splitContainerAssemmblerOutput";
            // 
            // splitContainerAssemmblerOutput.Panel1
            // 
            this.splitContainerAssemmblerOutput.Panel1.Controls.Add(this.textBoxAssembler);
            this.splitContainerAssemmblerOutput.Panel1.Controls.Add(this.toolStripAssembler);
            // 
            // splitContainerAssemmblerOutput.Panel2
            // 
            this.splitContainerAssemmblerOutput.Panel2.Controls.Add(this.textBoxOutput);
            this.splitContainerAssemmblerOutput.Panel2.Controls.Add(this.toolStripOutput);
            this.splitContainerAssemmblerOutput.Size = new System.Drawing.Size(1056, 751);
            this.splitContainerAssemmblerOutput.SplitterDistance = 600;
            this.splitContainerAssemmblerOutput.TabIndex = 0;
            // 
            // textBoxAssembler
            // 
            this.textBoxAssembler.AcceptsTab = false;
            this.textBoxAssembler.AllowMacroRecording = false;
            this.textBoxAssembler.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.textBoxAssembler.AutoIndent = false;
            this.textBoxAssembler.AutoIndentChars = false;
            this.textBoxAssembler.AutoIndentExistingLines = false;
            this.textBoxAssembler.AutoScrollMinSize = new System.Drawing.Size(27, 17);
            this.textBoxAssembler.BackBrush = null;
            this.textBoxAssembler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.textBoxAssembler.CaretColor = System.Drawing.Color.White;
            this.textBoxAssembler.CharHeight = 17;
            this.textBoxAssembler.CharWidth = 8;
            this.textBoxAssembler.CommentPrefix = "%";
            this.textBoxAssembler.CurrentLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(46)))));
            this.textBoxAssembler.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAssembler.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.textBoxAssembler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAssembler.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F);
            this.textBoxAssembler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.textBoxAssembler.Hotkeys = resources.GetString("textBoxAssembler.Hotkeys");
            this.textBoxAssembler.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.textBoxAssembler.IsReplaceMode = false;
            this.textBoxAssembler.LineNumberColor = System.Drawing.Color.IndianRed;
            this.textBoxAssembler.LineNumberStartValue = ((uint)(0u));
            this.textBoxAssembler.Location = new System.Drawing.Point(0, 25);
            this.textBoxAssembler.Name = "textBoxAssembler";
            this.textBoxAssembler.Paddings = new System.Windows.Forms.Padding(0);
            this.textBoxAssembler.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxAssembler.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("textBoxAssembler.ServiceColors")));
            this.textBoxAssembler.Size = new System.Drawing.Size(600, 726);
            this.textBoxAssembler.TabIndex = 1;
            this.textBoxAssembler.Zoom = 100;
            this.textBoxAssembler.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.textBoxAssembler_TextChanged);
            // 
            // toolStripAssembler
            // 
            this.toolStripAssembler.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripAssembler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAssemblerNew,
            this.toolStripButtonAssemblerSave,
            this.toolStripButtonAssemblerOpen,
            this.toolStripButtonAssemble,
            this.toolStripLabelAssemblerFilename});
            this.toolStripAssembler.Location = new System.Drawing.Point(0, 0);
            this.toolStripAssembler.Name = "toolStripAssembler";
            this.toolStripAssembler.Size = new System.Drawing.Size(600, 25);
            this.toolStripAssembler.TabIndex = 2;
            // 
            // toolStripButtonAssemblerNew
            // 
            this.toolStripButtonAssemblerNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAssemblerNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAssemblerNew.Image")));
            this.toolStripButtonAssemblerNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAssemblerNew.Name = "toolStripButtonAssemblerNew";
            this.toolStripButtonAssemblerNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAssemblerNew.Text = "New";
            this.toolStripButtonAssemblerNew.Click += new System.EventHandler(this.toolStripButtonAssemblerNew_Click);
            // 
            // toolStripButtonAssemblerSave
            // 
            this.toolStripButtonAssemblerSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAssemblerSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAssemblerSave.Image")));
            this.toolStripButtonAssemblerSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAssemblerSave.Name = "toolStripButtonAssemblerSave";
            this.toolStripButtonAssemblerSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAssemblerSave.Text = "Save";
            this.toolStripButtonAssemblerSave.Click += new System.EventHandler(this.toolStripButtonAssemblerSave_Click);
            // 
            // toolStripButtonAssemblerOpen
            // 
            this.toolStripButtonAssemblerOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAssemblerOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAssemblerOpen.Image")));
            this.toolStripButtonAssemblerOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAssemblerOpen.Name = "toolStripButtonAssemblerOpen";
            this.toolStripButtonAssemblerOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAssemblerOpen.Text = "Open";
            this.toolStripButtonAssemblerOpen.ToolTipText = "Open";
            this.toolStripButtonAssemblerOpen.Click += new System.EventHandler(this.toolStripButtonAssemblerOpen_Click);
            // 
            // toolStripButtonAssemble
            // 
            this.toolStripButtonAssemble.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAssemble.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAssemble.Image")));
            this.toolStripButtonAssemble.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAssemble.Name = "toolStripButtonAssemble";
            this.toolStripButtonAssemble.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAssemble.Text = "Assemble";
            this.toolStripButtonAssemble.Click += new System.EventHandler(this.toolStripButtonAssemble_Click);
            // 
            // toolStripLabelAssemblerFilename
            // 
            this.toolStripLabelAssemblerFilename.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelAssemblerFilename.Name = "toolStripLabelAssemblerFilename";
            this.toolStripLabelAssemblerFilename.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabelAssemblerFilename.Text = "untitled";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.AcceptsTab = false;
            this.textBoxOutput.AllowMacroRecording = false;
            this.textBoxOutput.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.textBoxOutput.AutoIndent = false;
            this.textBoxOutput.AutoIndentChars = false;
            this.textBoxOutput.AutoIndentExistingLines = false;
            this.textBoxOutput.AutoScrollMinSize = new System.Drawing.Size(27, 17);
            this.textBoxOutput.BackBrush = null;
            this.textBoxOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.textBoxOutput.CaretColor = System.Drawing.Color.White;
            this.textBoxOutput.CharHeight = 17;
            this.textBoxOutput.CharWidth = 8;
            this.textBoxOutput.CommentPrefix = "";
            this.textBoxOutput.CurrentLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(46)))));
            this.textBoxOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxOutput.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F);
            this.textBoxOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.textBoxOutput.Hotkeys = resources.GetString("textBoxOutput.Hotkeys");
            this.textBoxOutput.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.textBoxOutput.IsReplaceMode = false;
            this.textBoxOutput.LineNumberColor = System.Drawing.Color.IndianRed;
            this.textBoxOutput.LineNumberStartValue = ((uint)(0u));
            this.textBoxOutput.Location = new System.Drawing.Point(0, 25);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Paddings = new System.Windows.Forms.Padding(0);
            this.textBoxOutput.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxOutput.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("textBoxOutput.ServiceColors")));
            this.textBoxOutput.Size = new System.Drawing.Size(452, 726);
            this.textBoxOutput.TabIndex = 0;
            this.textBoxOutput.Zoom = 100;
            this.textBoxOutput.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.textBoxOutput_TextChanged);
            // 
            // toolStripOutput
            // 
            this.toolStripOutput.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripOutput.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOutputSave,
            this.toolStripButtonOutputSaveAs,
            this.toolStripLabelOutputSave});
            this.toolStripOutput.Location = new System.Drawing.Point(0, 0);
            this.toolStripOutput.Name = "toolStripOutput";
            this.toolStripOutput.Size = new System.Drawing.Size(452, 25);
            this.toolStripOutput.TabIndex = 1;
            // 
            // toolStripButtonOutputSave
            // 
            this.toolStripButtonOutputSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOutputSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOutputSave.Image")));
            this.toolStripButtonOutputSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOutputSave.Name = "toolStripButtonOutputSave";
            this.toolStripButtonOutputSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOutputSave.Text = "Save";
            this.toolStripButtonOutputSave.Click += new System.EventHandler(this.toolStripButtonOutputSave_Click);
            // 
            // toolStripButtonOutputSaveAs
            // 
            this.toolStripButtonOutputSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOutputSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOutputSaveAs.Image")));
            this.toolStripButtonOutputSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOutputSaveAs.Name = "toolStripButtonOutputSaveAs";
            this.toolStripButtonOutputSaveAs.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOutputSaveAs.Text = "Save as";
            this.toolStripButtonOutputSaveAs.Click += new System.EventHandler(this.toolStripButtonOutputSaveAs_Click);
            // 
            // toolStripLabelOutputSave
            // 
            this.toolStripLabelOutputSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelOutputSave.Name = "toolStripLabelOutputSave";
            this.toolStripLabelOutputSave.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabelOutputSave.Text = "untitled";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 751);
            this.Controls.Add(this.splitContainerAssemmblerOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "My Processor IDE";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainerAssemmblerOutput.Panel1.ResumeLayout(false);
            this.splitContainerAssemmblerOutput.Panel1.PerformLayout();
            this.splitContainerAssemmblerOutput.Panel2.ResumeLayout(false);
            this.splitContainerAssemmblerOutput.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAssemmblerOutput)).EndInit();
            this.splitContainerAssemmblerOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAssembler)).EndInit();
            this.toolStripAssembler.ResumeLayout(false);
            this.toolStripAssembler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxOutput)).EndInit();
            this.toolStripOutput.ResumeLayout(false);
            this.toolStripOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerAssemmblerOutput;
        private FastColoredTextBoxNS.FastColoredTextBox textBoxOutput;
        private System.Windows.Forms.ToolStrip toolStripAssembler;
        private System.Windows.Forms.ToolStripButton toolStripButtonAssemblerSave;
        private System.Windows.Forms.ToolStripLabel toolStripLabelAssemblerFilename;
        private System.Windows.Forms.ToolStrip toolStripOutput;
        private System.Windows.Forms.ToolStripButton toolStripButtonOutputSave;
        private System.Windows.Forms.ToolStripLabel toolStripLabelOutputSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonAssemblerOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonAssemble;
        private FastColoredTextBoxNS.FastColoredTextBox textBoxAssembler;
        private System.Windows.Forms.ToolStripButton toolStripButtonAssemblerNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonOutputSaveAs;
    }
}

