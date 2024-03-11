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
            panel1 = new Panel();
            btnClear = new Button();
            lblDirection = new Label();
            checkboxRecordingLeft = new CheckBox();
            label3 = new Label();
            lblTitle = new Label();
            checkboxRecordingRight = new CheckBox();
            btnParse = new Button();
            radioRecordingAll = new RadioButton();
            lblOutputDirectory = new Label();
            lblSaveDirectory = new Label();
            textboxOutputDirectory = new TextBox();
            textboxSaveDirectory = new TextBox();
            checkboxOutputTxtFiles = new CheckBox();
            radioRecording2 = new RadioButton();
            checkboxOutputEKEY = new CheckBox();
            checkboxOutputKEY = new CheckBox();
            radioRecording1 = new RadioButton();
            lblMode = new Label();
            radioRecording3 = new RadioButton();
            lblRecording = new Label();
            radioRecording4 = new RadioButton();
            radioRecording5 = new RadioButton();
            label5 = new Label();
            textboxParsedRecordingKEY = new TextBox();
            panel3 = new Panel();
            stripMenuFile = new ToolStripMenuItem();
            stripMenuOpen = new ToolStripMenuItem();
            stripMenuSetOutput = new ToolStripMenuItem();
            stripMenuClose = new ToolStripMenuItem();
            stripMenuHelp = new ToolStripMenuItem();
            stripMenuDocumentation = new ToolStripMenuItem();
            stripMenuAbout = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(lblDirection);
            panel1.Controls.Add(checkboxRecordingLeft);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(checkboxRecordingRight);
            panel1.Controls.Add(btnParse);
            panel1.Controls.Add(radioRecordingAll);
            panel1.Controls.Add(lblOutputDirectory);
            panel1.Controls.Add(lblSaveDirectory);
            panel1.Controls.Add(textboxOutputDirectory);
            panel1.Controls.Add(textboxSaveDirectory);
            panel1.Controls.Add(checkboxOutputTxtFiles);
            panel1.Controls.Add(radioRecording2);
            panel1.Controls.Add(checkboxOutputEKEY);
            panel1.Controls.Add(checkboxOutputKEY);
            panel1.Controls.Add(radioRecording1);
            panel1.Controls.Add(lblMode);
            panel1.Controls.Add(radioRecording3);
            panel1.Controls.Add(lblRecording);
            panel1.Controls.Add(radioRecording4);
            panel1.Controls.Add(radioRecording5);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 504);
            panel1.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Control;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = SystemColors.ControlText;
            btnClear.Location = new Point(132, 469);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(104, 27);
            btnClear.TabIndex = 26;
            btnClear.TabStop = false;
            btnClear.Text = "Clear Data";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += BtnClear_Click;
            // 
            // lblDirection
            // 
            lblDirection.AutoSize = true;
            lblDirection.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblDirection.ForeColor = SystemColors.ControlText;
            lblDirection.Location = new Point(3, 244);
            lblDirection.Name = "lblDirection";
            lblDirection.Size = new Size(116, 15);
            lblDirection.TabIndex = 25;
            lblDirection.Text = "Recording Direction:";
            // 
            // checkboxRecordingLeft
            // 
            checkboxRecordingLeft.AutoSize = true;
            checkboxRecordingLeft.BackColor = SystemColors.Control;
            checkboxRecordingLeft.ForeColor = SystemColors.ControlText;
            checkboxRecordingLeft.Location = new Point(10, 262);
            checkboxRecordingLeft.Name = "checkboxRecordingLeft";
            checkboxRecordingLeft.Size = new Size(89, 19);
            checkboxRecordingLeft.TabIndex = 24;
            checkboxRecordingLeft.TabStop = false;
            checkboxRecordingLeft.Text = "Facing Left?";
            checkboxRecordingLeft.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(85, 61);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 22;
            label3.Text = "- カラス - ";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.Control;
            lblTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ControlText;
            lblTitle.Location = new Point(12, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(206, 50);
            lblTitle.TabIndex = 19;
            lblTitle.Text = "P4U2 Training Mode \r\nRecording Input Parser";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkboxRecordingRight
            // 
            checkboxRecordingRight.AutoSize = true;
            checkboxRecordingRight.BackColor = SystemColors.Control;
            checkboxRecordingRight.Checked = true;
            checkboxRecordingRight.CheckState = CheckState.Checked;
            checkboxRecordingRight.ForeColor = SystemColors.ControlText;
            checkboxRecordingRight.Location = new Point(10, 287);
            checkboxRecordingRight.Name = "checkboxRecordingRight";
            checkboxRecordingRight.Size = new Size(97, 19);
            checkboxRecordingRight.TabIndex = 23;
            checkboxRecordingRight.TabStop = false;
            checkboxRecordingRight.Text = "Facing Right?";
            checkboxRecordingRight.UseVisualStyleBackColor = false;
            // 
            // btnParse
            // 
            btnParse.BackColor = SystemColors.Control;
            btnParse.FlatStyle = FlatStyle.Flat;
            btnParse.ForeColor = SystemColors.ControlText;
            btnParse.Location = new Point(3, 469);
            btnParse.Name = "btnParse";
            btnParse.Size = new Size(123, 27);
            btnParse.TabIndex = 18;
            btnParse.TabStop = false;
            btnParse.Text = "Parse Input Data";
            btnParse.UseVisualStyleBackColor = false;
            btnParse.Click += BtnParse_Click;
            // 
            // radioRecordingAll
            // 
            radioRecordingAll.AutoSize = true;
            radioRecordingAll.BackColor = SystemColors.Control;
            radioRecordingAll.Checked = true;
            radioRecordingAll.ForeColor = SystemColors.ControlText;
            radioRecordingAll.Location = new Point(130, 222);
            radioRecordingAll.Name = "radioRecordingAll";
            radioRecordingAll.Size = new Size(39, 19);
            radioRecordingAll.TabIndex = 17;
            radioRecordingAll.TabStop = true;
            radioRecordingAll.Text = "All";
            radioRecordingAll.UseVisualStyleBackColor = false;
            // 
            // lblOutputDirectory
            // 
            lblOutputDirectory.AutoSize = true;
            lblOutputDirectory.BackColor = SystemColors.Control;
            lblOutputDirectory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblOutputDirectory.ForeColor = SystemColors.ControlText;
            lblOutputDirectory.Location = new Point(3, 374);
            lblOutputDirectory.Name = "lblOutputDirectory";
            lblOutputDirectory.Size = new Size(100, 15);
            lblOutputDirectory.TabIndex = 16;
            lblOutputDirectory.Text = "Output Directory:";
            // 
            // lblSaveDirectory
            // 
            lblSaveDirectory.AutoSize = true;
            lblSaveDirectory.BackColor = SystemColors.Control;
            lblSaveDirectory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblSaveDirectory.ForeColor = SystemColors.ControlText;
            lblSaveDirectory.Location = new Point(3, 86);
            lblSaveDirectory.Name = "lblSaveDirectory";
            lblSaveDirectory.Size = new Size(87, 15);
            lblSaveDirectory.TabIndex = 6;
            lblSaveDirectory.Text = "Save Directory:";
            // 
            // textboxOutputDirectory
            // 
            textboxOutputDirectory.BackColor = SystemColors.Control;
            textboxOutputDirectory.BorderStyle = BorderStyle.None;
            textboxOutputDirectory.ForeColor = SystemColors.ControlText;
            textboxOutputDirectory.Location = new Point(3, 392);
            textboxOutputDirectory.Multiline = true;
            textboxOutputDirectory.Name = "textboxOutputDirectory";
            textboxOutputDirectory.ReadOnly = true;
            textboxOutputDirectory.Size = new Size(236, 46);
            textboxOutputDirectory.TabIndex = 15;
            textboxOutputDirectory.TabStop = false;
            // 
            // textboxSaveDirectory
            // 
            textboxSaveDirectory.BackColor = SystemColors.Control;
            textboxSaveDirectory.BorderStyle = BorderStyle.None;
            textboxSaveDirectory.CausesValidation = false;
            textboxSaveDirectory.ForeColor = SystemColors.ControlText;
            textboxSaveDirectory.Location = new Point(3, 104);
            textboxSaveDirectory.Multiline = true;
            textboxSaveDirectory.Name = "textboxSaveDirectory";
            textboxSaveDirectory.ReadOnly = true;
            textboxSaveDirectory.Size = new Size(236, 46);
            textboxSaveDirectory.TabIndex = 5;
            textboxSaveDirectory.TabStop = false;
            // 
            // checkboxOutputTxtFiles
            // 
            checkboxOutputTxtFiles.AutoSize = true;
            checkboxOutputTxtFiles.BackColor = SystemColors.Control;
            checkboxOutputTxtFiles.ForeColor = SystemColors.ControlText;
            checkboxOutputTxtFiles.Location = new Point(3, 444);
            checkboxOutputTxtFiles.Name = "checkboxOutputTxtFiles";
            checkboxOutputTxtFiles.Size = new Size(136, 19);
            checkboxOutputTxtFiles.TabIndex = 14;
            checkboxOutputTxtFiles.TabStop = false;
            checkboxOutputTxtFiles.Text = "Generate Text File(s)?";
            checkboxOutputTxtFiles.UseVisualStyleBackColor = false;
            // 
            // radioRecording2
            // 
            radioRecording2.AutoSize = true;
            radioRecording2.BackColor = SystemColors.Control;
            radioRecording2.ForeColor = SystemColors.ControlText;
            radioRecording2.Location = new Point(12, 197);
            radioRecording2.Name = "radioRecording2";
            radioRecording2.Size = new Size(88, 19);
            radioRecording2.TabIndex = 6;
            radioRecording2.Text = "Recording 2";
            radioRecording2.UseVisualStyleBackColor = false;
            // 
            // checkboxOutputEKEY
            // 
            checkboxOutputEKEY.AutoSize = true;
            checkboxOutputEKEY.BackColor = SystemColors.Control;
            checkboxOutputEKEY.ForeColor = SystemColors.ControlText;
            checkboxOutputEKEY.Location = new Point(12, 327);
            checkboxOutputEKEY.Name = "checkboxOutputEKEY";
            checkboxOutputEKEY.Size = new Size(139, 19);
            checkboxOutputEKEY.TabIndex = 13;
            checkboxOutputEKEY.TabStop = false;
            checkboxOutputEKEY.Text = "Enemy Dummy Input";
            checkboxOutputEKEY.UseVisualStyleBackColor = false;
            // 
            // checkboxOutputKEY
            // 
            checkboxOutputKEY.AutoSize = true;
            checkboxOutputKEY.BackColor = SystemColors.Control;
            checkboxOutputKEY.Checked = true;
            checkboxOutputKEY.CheckState = CheckState.Checked;
            checkboxOutputKEY.ForeColor = SystemColors.ControlText;
            checkboxOutputKEY.Location = new Point(12, 352);
            checkboxOutputKEY.Name = "checkboxOutputKEY";
            checkboxOutputKEY.Size = new Size(136, 19);
            checkboxOutputKEY.TabIndex = 12;
            checkboxOutputKEY.TabStop = false;
            checkboxOutputKEY.Text = "Demonstration Input";
            checkboxOutputKEY.UseVisualStyleBackColor = false;
            // 
            // radioRecording1
            // 
            radioRecording1.AutoSize = true;
            radioRecording1.BackColor = SystemColors.Control;
            radioRecording1.ForeColor = SystemColors.ControlText;
            radioRecording1.Location = new Point(12, 172);
            radioRecording1.Name = "radioRecording1";
            radioRecording1.Size = new Size(88, 19);
            radioRecording1.TabIndex = 5;
            radioRecording1.Text = "Recording 1";
            radioRecording1.UseVisualStyleBackColor = false;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.BackColor = SystemColors.Control;
            lblMode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblMode.ForeColor = SystemColors.ControlText;
            lblMode.Location = new Point(3, 309);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(82, 15);
            lblMode.TabIndex = 10;
            lblMode.Text = "Output Mode:";
            // 
            // radioRecording3
            // 
            radioRecording3.AutoSize = true;
            radioRecording3.BackColor = SystemColors.Control;
            radioRecording3.ForeColor = SystemColors.ControlText;
            radioRecording3.Location = new Point(12, 222);
            radioRecording3.Name = "radioRecording3";
            radioRecording3.Size = new Size(88, 19);
            radioRecording3.TabIndex = 7;
            radioRecording3.Text = "Recording 3";
            radioRecording3.UseVisualStyleBackColor = false;
            // 
            // lblRecording
            // 
            lblRecording.AutoSize = true;
            lblRecording.BackColor = SystemColors.Control;
            lblRecording.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblRecording.ForeColor = SystemColors.ControlText;
            lblRecording.Location = new Point(3, 153);
            lblRecording.Name = "lblRecording";
            lblRecording.Size = new Size(144, 15);
            lblRecording.TabIndex = 11;
            lblRecording.Text = "Select Recording to Parse:";
            // 
            // radioRecording4
            // 
            radioRecording4.AutoSize = true;
            radioRecording4.BackColor = SystemColors.Control;
            radioRecording4.ForeColor = SystemColors.ControlText;
            radioRecording4.Location = new Point(130, 172);
            radioRecording4.Name = "radioRecording4";
            radioRecording4.Size = new Size(88, 19);
            radioRecording4.TabIndex = 8;
            radioRecording4.Text = "Recording 4";
            radioRecording4.UseVisualStyleBackColor = false;
            // 
            // radioRecording5
            // 
            radioRecording5.AutoSize = true;
            radioRecording5.BackColor = SystemColors.Control;
            radioRecording5.ForeColor = SystemColors.ControlText;
            radioRecording5.Location = new Point(130, 197);
            radioRecording5.Name = "radioRecording5";
            radioRecording5.Size = new Size(88, 19);
            radioRecording5.TabIndex = 9;
            radioRecording5.Text = "Recording 5";
            radioRecording5.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Control;
            label5.Dock = DockStyle.Top;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(231, 19);
            label5.TabIndex = 19;
            label5.Text = "Parsed Recording(s)";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // textboxParsedRecordingKEY
            // 
            textboxParsedRecordingKEY.BackColor = SystemColors.Control;
            textboxParsedRecordingKEY.BorderStyle = BorderStyle.FixedSingle;
            textboxParsedRecordingKEY.Dock = DockStyle.Fill;
            textboxParsedRecordingKEY.ForeColor = SystemColors.ControlText;
            textboxParsedRecordingKEY.Location = new Point(0, 19);
            textboxParsedRecordingKEY.Multiline = true;
            textboxParsedRecordingKEY.Name = "textboxParsedRecordingKEY";
            textboxParsedRecordingKEY.ReadOnly = true;
            textboxParsedRecordingKEY.ScrollBars = ScrollBars.Vertical;
            textboxParsedRecordingKEY.Size = new Size(231, 481);
            textboxParsedRecordingKEY.TabIndex = 21;
            textboxParsedRecordingKEY.TabStop = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(textboxParsedRecordingKEY);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(242, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(235, 504);
            panel3.TabIndex = 3;
            // 
            // stripMenuFile
            // 
            stripMenuFile.CheckOnClick = true;
            stripMenuFile.DropDownItems.AddRange(new ToolStripItem[] { stripMenuOpen, stripMenuSetOutput, stripMenuClose });
            stripMenuFile.Name = "stripMenuFile";
            stripMenuFile.Size = new Size(37, 20);
            stripMenuFile.Text = "File";
            // 
            // stripMenuOpen
            // 
            stripMenuOpen.Name = "stripMenuOpen";
            stripMenuOpen.ShortcutKeys = Keys.Control | Keys.O;
            stripMenuOpen.Size = new Size(266, 22);
            stripMenuOpen.Text = "Load Save File...";
            stripMenuOpen.Click += StripMenuOpen_Click;
            // 
            // stripMenuSetOutput
            // 
            stripMenuSetOutput.Name = "stripMenuSetOutput";
            stripMenuSetOutput.ShortcutKeys = Keys.Control | Keys.Shift | Keys.O;
            stripMenuSetOutput.Size = new Size(266, 22);
            stripMenuSetOutput.Text = "Set Output Directory...";
            stripMenuSetOutput.Click += StripMenuSetOutput_Click;
            // 
            // stripMenuClose
            // 
            stripMenuClose.Name = "stripMenuClose";
            stripMenuClose.Size = new Size(266, 22);
            stripMenuClose.Text = "Close";
            stripMenuClose.Click += StripMenuClose_Click;
            // 
            // stripMenuHelp
            // 
            stripMenuHelp.CheckOnClick = true;
            stripMenuHelp.DropDownItems.AddRange(new ToolStripItem[] { stripMenuDocumentation });
            stripMenuHelp.Name = "stripMenuHelp";
            stripMenuHelp.Size = new Size(44, 20);
            stripMenuHelp.Text = "Help";
            // 
            // stripMenuDocumentation
            // 
            stripMenuDocumentation.Name = "stripMenuDocumentation";
            stripMenuDocumentation.Size = new Size(157, 22);
            stripMenuDocumentation.Text = "Documentation";
            stripMenuDocumentation.Click += StripMenuDocumentation_Click;
            // 
            // stripMenuAbout
            // 
            stripMenuAbout.CheckOnClick = true;
            stripMenuAbout.Name = "stripMenuAbout";
            stripMenuAbout.Size = new Size(52, 20);
            stripMenuAbout.Text = "About";
            stripMenuAbout.Click += StripMenuAbout_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.AllowItemReorder = true;
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Items.AddRange(new ToolStripItem[] { stripMenuFile, stripMenuHelp, stripMenuAbout });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(477, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(477, 528);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "P4U2 Training Mode Recording Input Parser";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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