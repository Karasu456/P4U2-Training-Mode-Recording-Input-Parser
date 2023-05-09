namespace P4U2_Training_Mode_Recording_Input_Parsing_Tool
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDirection = new System.Windows.Forms.Label();
            this.checkboxRecordingLeft = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.checkboxRecordingRight = new System.Windows.Forms.CheckBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.radioRecordingAll = new System.Windows.Forms.RadioButton();
            this.lblOutputDirectory = new System.Windows.Forms.Label();
            this.lblSaveDirectory = new System.Windows.Forms.Label();
            this.textboxOutputDirectory = new System.Windows.Forms.TextBox();
            this.textboxSaveDirectory = new System.Windows.Forms.TextBox();
            this.checkboxOutputTxtFiles = new System.Windows.Forms.CheckBox();
            this.radioRecording2 = new System.Windows.Forms.RadioButton();
            this.checkboxOutputEKEY = new System.Windows.Forms.CheckBox();
            this.checkboxOutputKEY = new System.Windows.Forms.CheckBox();
            this.radioRecording1 = new System.Windows.Forms.RadioButton();
            this.lblMode = new System.Windows.Forms.Label();
            this.radioRecording3 = new System.Windows.Forms.RadioButton();
            this.lblRecording = new System.Windows.Forms.Label();
            this.radioRecording4 = new System.Windows.Forms.RadioButton();
            this.radioRecording5 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxParsedRecordingKEY = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.stripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuSetOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuDocumentation = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.lblDirection);
            this.panel1.Controls.Add(this.checkboxRecordingLeft);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.checkboxRecordingRight);
            this.panel1.Controls.Add(this.btnParse);
            this.panel1.Controls.Add(this.radioRecordingAll);
            this.panel1.Controls.Add(this.lblOutputDirectory);
            this.panel1.Controls.Add(this.lblSaveDirectory);
            this.panel1.Controls.Add(this.textboxOutputDirectory);
            this.panel1.Controls.Add(this.textboxSaveDirectory);
            this.panel1.Controls.Add(this.checkboxOutputTxtFiles);
            this.panel1.Controls.Add(this.radioRecording2);
            this.panel1.Controls.Add(this.checkboxOutputEKEY);
            this.panel1.Controls.Add(this.checkboxOutputKEY);
            this.panel1.Controls.Add(this.radioRecording1);
            this.panel1.Controls.Add(this.lblMode);
            this.panel1.Controls.Add(this.radioRecording3);
            this.panel1.Controls.Add(this.lblRecording);
            this.panel1.Controls.Add(this.radioRecording4);
            this.panel1.Controls.Add(this.radioRecording5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 504);
            this.panel1.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(132, 469);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 27);
            this.btnClear.TabIndex = 26;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear Data";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblDirection.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDirection.Location = new System.Drawing.Point(3, 244);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(116, 15);
            this.lblDirection.TabIndex = 25;
            this.lblDirection.Text = "Recording Direction:";
            // 
            // checkboxRecordingLeft
            // 
            this.checkboxRecordingLeft.AutoSize = true;
            this.checkboxRecordingLeft.BackColor = System.Drawing.SystemColors.Control;
            this.checkboxRecordingLeft.Checked = true;
            this.checkboxRecordingLeft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxRecordingLeft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkboxRecordingLeft.Location = new System.Drawing.Point(12, 262);
            this.checkboxRecordingLeft.Name = "checkboxRecordingLeft";
            this.checkboxRecordingLeft.Size = new System.Drawing.Size(97, 19);
            this.checkboxRecordingLeft.TabIndex = 24;
            this.checkboxRecordingLeft.TabStop = false;
            this.checkboxRecordingLeft.Text = "Facing Right?";
            this.checkboxRecordingLeft.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(85, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "- カラス - ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(12, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 50);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "P4U2 Training Mode \r\nRecording Input Parser";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkboxRecordingRight
            // 
            this.checkboxRecordingRight.AutoSize = true;
            this.checkboxRecordingRight.BackColor = System.Drawing.SystemColors.Control;
            this.checkboxRecordingRight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkboxRecordingRight.Location = new System.Drawing.Point(12, 287);
            this.checkboxRecordingRight.Name = "checkboxRecordingRight";
            this.checkboxRecordingRight.Size = new System.Drawing.Size(89, 19);
            this.checkboxRecordingRight.TabIndex = 23;
            this.checkboxRecordingRight.TabStop = false;
            this.checkboxRecordingRight.Text = "Facing Left?";
            this.checkboxRecordingRight.UseVisualStyleBackColor = false;
            // 
            // btnParse
            // 
            this.btnParse.BackColor = System.Drawing.SystemColors.Control;
            this.btnParse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnParse.Location = new System.Drawing.Point(3, 469);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(123, 27);
            this.btnParse.TabIndex = 18;
            this.btnParse.TabStop = false;
            this.btnParse.Text = "Parse Input Data";
            this.btnParse.UseVisualStyleBackColor = false;
            this.btnParse.Click += new System.EventHandler(this.BtnParse_Click);
            // 
            // radioRecordingAll
            // 
            this.radioRecordingAll.AutoSize = true;
            this.radioRecordingAll.BackColor = System.Drawing.SystemColors.Control;
            this.radioRecordingAll.Checked = true;
            this.radioRecordingAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioRecordingAll.Location = new System.Drawing.Point(130, 222);
            this.radioRecordingAll.Name = "radioRecordingAll";
            this.radioRecordingAll.Size = new System.Drawing.Size(39, 19);
            this.radioRecordingAll.TabIndex = 17;
            this.radioRecordingAll.TabStop = true;
            this.radioRecordingAll.Text = "All";
            this.radioRecordingAll.UseVisualStyleBackColor = false;
            // 
            // lblOutputDirectory
            // 
            this.lblOutputDirectory.AutoSize = true;
            this.lblOutputDirectory.BackColor = System.Drawing.SystemColors.Control;
            this.lblOutputDirectory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblOutputDirectory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOutputDirectory.Location = new System.Drawing.Point(3, 374);
            this.lblOutputDirectory.Name = "lblOutputDirectory";
            this.lblOutputDirectory.Size = new System.Drawing.Size(100, 15);
            this.lblOutputDirectory.TabIndex = 16;
            this.lblOutputDirectory.Text = "Output Directory:";
            // 
            // lblSaveDirectory
            // 
            this.lblSaveDirectory.AutoSize = true;
            this.lblSaveDirectory.BackColor = System.Drawing.SystemColors.Control;
            this.lblSaveDirectory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblSaveDirectory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSaveDirectory.Location = new System.Drawing.Point(3, 86);
            this.lblSaveDirectory.Name = "lblSaveDirectory";
            this.lblSaveDirectory.Size = new System.Drawing.Size(87, 15);
            this.lblSaveDirectory.TabIndex = 6;
            this.lblSaveDirectory.Text = "Save Directory:";
            // 
            // textboxOutputDirectory
            // 
            this.textboxOutputDirectory.BackColor = System.Drawing.SystemColors.Control;
            this.textboxOutputDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxOutputDirectory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textboxOutputDirectory.Location = new System.Drawing.Point(3, 392);
            this.textboxOutputDirectory.Multiline = true;
            this.textboxOutputDirectory.Name = "textboxOutputDirectory";
            this.textboxOutputDirectory.ReadOnly = true;
            this.textboxOutputDirectory.Size = new System.Drawing.Size(236, 46);
            this.textboxOutputDirectory.TabIndex = 15;
            this.textboxOutputDirectory.TabStop = false;
            // 
            // textboxSaveDirectory
            // 
            this.textboxSaveDirectory.BackColor = System.Drawing.SystemColors.Control;
            this.textboxSaveDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxSaveDirectory.CausesValidation = false;
            this.textboxSaveDirectory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textboxSaveDirectory.Location = new System.Drawing.Point(3, 104);
            this.textboxSaveDirectory.Multiline = true;
            this.textboxSaveDirectory.Name = "textboxSaveDirectory";
            this.textboxSaveDirectory.ReadOnly = true;
            this.textboxSaveDirectory.Size = new System.Drawing.Size(236, 46);
            this.textboxSaveDirectory.TabIndex = 5;
            this.textboxSaveDirectory.TabStop = false;
            // 
            // checkboxOutputTxtFiles
            // 
            this.checkboxOutputTxtFiles.AutoSize = true;
            this.checkboxOutputTxtFiles.BackColor = System.Drawing.SystemColors.Control;
            this.checkboxOutputTxtFiles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkboxOutputTxtFiles.Location = new System.Drawing.Point(3, 444);
            this.checkboxOutputTxtFiles.Name = "checkboxOutputTxtFiles";
            this.checkboxOutputTxtFiles.Size = new System.Drawing.Size(136, 19);
            this.checkboxOutputTxtFiles.TabIndex = 14;
            this.checkboxOutputTxtFiles.TabStop = false;
            this.checkboxOutputTxtFiles.Text = "Generate Text File(s)?";
            this.checkboxOutputTxtFiles.UseVisualStyleBackColor = false;
            // 
            // radioRecording2
            // 
            this.radioRecording2.AutoSize = true;
            this.radioRecording2.BackColor = System.Drawing.SystemColors.Control;
            this.radioRecording2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioRecording2.Location = new System.Drawing.Point(12, 197);
            this.radioRecording2.Name = "radioRecording2";
            this.radioRecording2.Size = new System.Drawing.Size(88, 19);
            this.radioRecording2.TabIndex = 6;
            this.radioRecording2.Text = "Recording 2";
            this.radioRecording2.UseVisualStyleBackColor = false;
            // 
            // checkboxOutputEKEY
            // 
            this.checkboxOutputEKEY.AutoSize = true;
            this.checkboxOutputEKEY.BackColor = System.Drawing.SystemColors.Control;
            this.checkboxOutputEKEY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkboxOutputEKEY.Location = new System.Drawing.Point(12, 327);
            this.checkboxOutputEKEY.Name = "checkboxOutputEKEY";
            this.checkboxOutputEKEY.Size = new System.Drawing.Size(139, 19);
            this.checkboxOutputEKEY.TabIndex = 13;
            this.checkboxOutputEKEY.TabStop = false;
            this.checkboxOutputEKEY.Text = "Enemy Dummy Input";
            this.checkboxOutputEKEY.UseVisualStyleBackColor = false;
            // 
            // checkboxOutputKEY
            // 
            this.checkboxOutputKEY.AutoSize = true;
            this.checkboxOutputKEY.BackColor = System.Drawing.SystemColors.Control;
            this.checkboxOutputKEY.Checked = true;
            this.checkboxOutputKEY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxOutputKEY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkboxOutputKEY.Location = new System.Drawing.Point(12, 352);
            this.checkboxOutputKEY.Name = "checkboxOutputKEY";
            this.checkboxOutputKEY.Size = new System.Drawing.Size(136, 19);
            this.checkboxOutputKEY.TabIndex = 12;
            this.checkboxOutputKEY.TabStop = false;
            this.checkboxOutputKEY.Text = "Demonstration Input";
            this.checkboxOutputKEY.UseVisualStyleBackColor = false;
            // 
            // radioRecording1
            // 
            this.radioRecording1.AutoSize = true;
            this.radioRecording1.BackColor = System.Drawing.SystemColors.Control;
            this.radioRecording1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioRecording1.Location = new System.Drawing.Point(12, 172);
            this.radioRecording1.Name = "radioRecording1";
            this.radioRecording1.Size = new System.Drawing.Size(88, 19);
            this.radioRecording1.TabIndex = 5;
            this.radioRecording1.Text = "Recording 1";
            this.radioRecording1.UseVisualStyleBackColor = false;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.BackColor = System.Drawing.SystemColors.Control;
            this.lblMode.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMode.Location = new System.Drawing.Point(3, 309);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(82, 15);
            this.lblMode.TabIndex = 10;
            this.lblMode.Text = "Output Mode:";
            // 
            // radioRecording3
            // 
            this.radioRecording3.AutoSize = true;
            this.radioRecording3.BackColor = System.Drawing.SystemColors.Control;
            this.radioRecording3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioRecording3.Location = new System.Drawing.Point(12, 222);
            this.radioRecording3.Name = "radioRecording3";
            this.radioRecording3.Size = new System.Drawing.Size(88, 19);
            this.radioRecording3.TabIndex = 7;
            this.radioRecording3.Text = "Recording 3";
            this.radioRecording3.UseVisualStyleBackColor = false;
            // 
            // lblRecording
            // 
            this.lblRecording.AutoSize = true;
            this.lblRecording.BackColor = System.Drawing.SystemColors.Control;
            this.lblRecording.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblRecording.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRecording.Location = new System.Drawing.Point(3, 153);
            this.lblRecording.Name = "lblRecording";
            this.lblRecording.Size = new System.Drawing.Size(144, 15);
            this.lblRecording.TabIndex = 11;
            this.lblRecording.Text = "Select Recording to Parse:";
            // 
            // radioRecording4
            // 
            this.radioRecording4.AutoSize = true;
            this.radioRecording4.BackColor = System.Drawing.SystemColors.Control;
            this.radioRecording4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioRecording4.Location = new System.Drawing.Point(130, 172);
            this.radioRecording4.Name = "radioRecording4";
            this.radioRecording4.Size = new System.Drawing.Size(88, 19);
            this.radioRecording4.TabIndex = 8;
            this.radioRecording4.Text = "Recording 4";
            this.radioRecording4.UseVisualStyleBackColor = false;
            // 
            // radioRecording5
            // 
            this.radioRecording5.AutoSize = true;
            this.radioRecording5.BackColor = System.Drawing.SystemColors.Control;
            this.radioRecording5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioRecording5.Location = new System.Drawing.Point(130, 197);
            this.radioRecording5.Name = "radioRecording5";
            this.radioRecording5.Size = new System.Drawing.Size(88, 19);
            this.radioRecording5.TabIndex = 9;
            this.radioRecording5.Text = "Recording 5";
            this.radioRecording5.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Parsed Recording(s)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textboxParsedRecordingKEY
            // 
            this.textboxParsedRecordingKEY.BackColor = System.Drawing.SystemColors.Control;
            this.textboxParsedRecordingKEY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxParsedRecordingKEY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxParsedRecordingKEY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textboxParsedRecordingKEY.Location = new System.Drawing.Point(0, 19);
            this.textboxParsedRecordingKEY.Multiline = true;
            this.textboxParsedRecordingKEY.Name = "textboxParsedRecordingKEY";
            this.textboxParsedRecordingKEY.ReadOnly = true;
            this.textboxParsedRecordingKEY.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxParsedRecordingKEY.Size = new System.Drawing.Size(231, 481);
            this.textboxParsedRecordingKEY.TabIndex = 21;
            this.textboxParsedRecordingKEY.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.textboxParsedRecordingKEY);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(242, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 504);
            this.panel3.TabIndex = 3;
            // 
            // stripMenuFile
            // 
            this.stripMenuFile.CheckOnClick = true;
            this.stripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuOpen,
            this.stripMenuSetOutput,
            this.stripMenuClose});
            this.stripMenuFile.Name = "stripMenuFile";
            this.stripMenuFile.Size = new System.Drawing.Size(37, 20);
            this.stripMenuFile.Text = "File";
            // 
            // stripMenuOpen
            // 
            this.stripMenuOpen.Name = "stripMenuOpen";
            this.stripMenuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.stripMenuOpen.Size = new System.Drawing.Size(266, 22);
            this.stripMenuOpen.Text = "Load Save File...";
            this.stripMenuOpen.Click += new System.EventHandler(this.StripMenuOpen_Click);
            // 
            // stripMenuSetOutput
            // 
            this.stripMenuSetOutput.Name = "stripMenuSetOutput";
            this.stripMenuSetOutput.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.stripMenuSetOutput.Size = new System.Drawing.Size(266, 22);
            this.stripMenuSetOutput.Text = "Set Output Directory...";
            this.stripMenuSetOutput.Click += new System.EventHandler(this.StripMenuSetOutput_Click);
            // 
            // stripMenuClose
            // 
            this.stripMenuClose.Name = "stripMenuClose";
            this.stripMenuClose.Size = new System.Drawing.Size(266, 22);
            this.stripMenuClose.Text = "Close";
            this.stripMenuClose.Click += new System.EventHandler(this.StripMenuClose_Click);
            // 
            // stripMenuHelp
            // 
            this.stripMenuHelp.CheckOnClick = true;
            this.stripMenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuDocumentation});
            this.stripMenuHelp.Name = "stripMenuHelp";
            this.stripMenuHelp.Size = new System.Drawing.Size(44, 20);
            this.stripMenuHelp.Text = "Help";
            // 
            // stripMenuDocumentation
            // 
            this.stripMenuDocumentation.Name = "stripMenuDocumentation";
            this.stripMenuDocumentation.Size = new System.Drawing.Size(157, 22);
            this.stripMenuDocumentation.Text = "Documentation";
            this.stripMenuDocumentation.Click += new System.EventHandler(this.StripMenuDocumentation_Click);
            // 
            // stripMenuAbout
            // 
            this.stripMenuAbout.CheckOnClick = true;
            this.stripMenuAbout.Name = "stripMenuAbout";
            this.stripMenuAbout.Size = new System.Drawing.Size(52, 20);
            this.stripMenuAbout.Text = "About";
            this.stripMenuAbout.Click += new System.EventHandler(this.StripMenuAbout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowItemReorder = true;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuFile,
            this.stripMenuHelp,
            this.stripMenuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(477, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(477, 528);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "P4U2 Training Mode Recording Input Parser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Label lblSaveDirectory;
        private TextBox textboxSaveDirectory;
        private RadioButton radioRecording1;
        private RadioButton radioRecording2;
        private RadioButton radioRecording3;
        private RadioButton radioRecording4;
        private RadioButton radioRecording5;
        private Label lblMode;
        private Label lblRecording;
        private CheckBox checkboxOutputKEY;
        private CheckBox checkboxOutputEKEY;
        private Button btnParse;
        private RadioButton radioRecordingAll;
        private Label lblOutputDirectory;
        private TextBox textboxOutputDirectory;
        private CheckBox checkboxOutputTxtFiles;
        private Label label5;
        public TextBox textboxParsedRecordingKEY;
        private Label lblTitle;
        private Label label3;
        private Panel panel3;
        private Label lblDirection;
        private CheckBox checkboxRecordingLeft;
        private CheckBox checkboxRecordingRight;
        private ToolStripMenuItem stripMenuFile;
        private ToolStripMenuItem stripMenuOpen;
        private ToolStripMenuItem stripMenuClose;
        private ToolStripMenuItem stripMenuHelp;
        private ToolStripMenuItem stripMenuDocumentation;
        private ToolStripMenuItem stripMenuAbout;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem stripMenuSetOutput;
        private Button btnClear;
    }
}