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
            panel5 = new Panel();
            radioOutputDirectionLeft = new RadioButton();
            radioOutputDirectionRight = new RadioButton();
            lblMode = new Label();
            panel4 = new Panel();
            radioInitialDirectionLeft = new RadioButton();
            lblDirection = new Label();
            radioInitialDirectionRight = new RadioButton();
            panel2 = new Panel();
            radioRecording4 = new RadioButton();
            radioRecording5 = new RadioButton();
            radioRecording3 = new RadioButton();
            radioRecording1 = new RadioButton();
            radioRecording2 = new RadioButton();
            radioRecordingAll = new RadioButton();
            lblRecording = new Label();
            btnClear = new Button();
            label3 = new Label();
            lblTitle = new Label();
            btnParse = new Button();
            lblOutputDirectory = new Label();
            lblSaveDirectory = new Label();
            textboxOutputDirectory = new TextBox();
            textboxSaveDirectory = new TextBox();
            checkboxOutputTxtFiles = new CheckBox();
            label5 = new Label();
            textboxParsedRecordingKEY = new TextBox();
            panel3 = new Panel();
            menuStrip2 = new MenuStrip();
            rawInputDataToolStripMenuItem = new ToolStripMenuItem();
            cleanInputDataToolStripMenuItem = new ToolStripMenuItem();
            stripMenuFile = new ToolStripMenuItem();
            stripMenuOpen = new ToolStripMenuItem();
            stripMenuSetOutput = new ToolStripMenuItem();
            stripMenuClose = new ToolStripMenuItem();
            stripMenuHelp = new ToolStripMenuItem();
            stripMenuDocumentation = new ToolStripMenuItem();
            stripMenuAbout = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            menuStrip2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnParse);
            panel1.Controls.Add(lblOutputDirectory);
            panel1.Controls.Add(lblSaveDirectory);
            panel1.Controls.Add(textboxOutputDirectory);
            panel1.Controls.Add(textboxSaveDirectory);
            panel1.Controls.Add(checkboxOutputTxtFiles);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 513);
            panel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(radioOutputDirectionLeft);
            panel5.Controls.Add(radioOutputDirectionRight);
            panel5.Controls.Add(lblMode);
            panel5.Location = new Point(3, 312);
            panel5.Name = "panel5";
            panel5.Size = new Size(227, 68);
            panel5.TabIndex = 28;
            // 
            // radioOutputDirectionLeft
            // 
            radioOutputDirectionLeft.AutoSize = true;
            radioOutputDirectionLeft.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioOutputDirectionLeft.Location = new Point(7, 45);
            radioOutputDirectionLeft.Name = "radioOutputDirectionLeft";
            radioOutputDirectionLeft.Size = new Size(107, 19);
            radioOutputDirectionLeft.TabIndex = 15;
            radioOutputDirectionLeft.Text = "Facing Left (<-)";
            radioOutputDirectionLeft.UseVisualStyleBackColor = true;
            // 
            // radioOutputDirectionRight
            // 
            radioOutputDirectionRight.AutoSize = true;
            radioOutputDirectionRight.Checked = true;
            radioOutputDirectionRight.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioOutputDirectionRight.Location = new Point(7, 21);
            radioOutputDirectionRight.Name = "radioOutputDirectionRight";
            radioOutputDirectionRight.Size = new Size(115, 19);
            radioOutputDirectionRight.TabIndex = 14;
            radioOutputDirectionRight.TabStop = true;
            radioOutputDirectionRight.Text = "Facing Right (->)";
            radioOutputDirectionRight.UseVisualStyleBackColor = true;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.BackColor = SystemColors.Control;
            lblMode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblMode.ForeColor = SystemColors.ControlText;
            lblMode.Location = new Point(0, 3);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(143, 15);
            lblMode.TabIndex = 10;
            lblMode.Text = "Desired Output Direction:";
            // 
            // panel4
            // 
            panel4.Controls.Add(radioInitialDirectionLeft);
            panel4.Controls.Add(lblDirection);
            panel4.Controls.Add(radioInitialDirectionRight);
            panel4.Location = new Point(3, 242);
            panel4.Name = "panel4";
            panel4.Size = new Size(227, 73);
            panel4.TabIndex = 27;
            // 
            // radioInitialDirectionLeft
            // 
            radioInitialDirectionLeft.AutoSize = true;
            radioInitialDirectionLeft.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioInitialDirectionLeft.Location = new Point(7, 45);
            radioInitialDirectionLeft.Name = "radioInitialDirectionLeft";
            radioInitialDirectionLeft.Size = new Size(107, 19);
            radioInitialDirectionLeft.TabIndex = 17;
            radioInitialDirectionLeft.Text = "Facing Left (<-)";
            radioInitialDirectionLeft.UseVisualStyleBackColor = true;
            // 
            // lblDirection
            // 
            lblDirection.AutoSize = true;
            lblDirection.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblDirection.ForeColor = SystemColors.ControlText;
            lblDirection.Location = new Point(0, 5);
            lblDirection.Name = "lblDirection";
            lblDirection.Size = new Size(149, 15);
            lblDirection.TabIndex = 25;
            lblDirection.Text = "Initial Recording Direction:";
            // 
            // radioInitialDirectionRight
            // 
            radioInitialDirectionRight.AutoSize = true;
            radioInitialDirectionRight.Checked = true;
            radioInitialDirectionRight.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioInitialDirectionRight.Location = new Point(7, 21);
            radioInitialDirectionRight.Name = "radioInitialDirectionRight";
            radioInitialDirectionRight.Size = new Size(115, 19);
            radioInitialDirectionRight.TabIndex = 16;
            radioInitialDirectionRight.TabStop = true;
            radioInitialDirectionRight.Text = "Facing Right (->)";
            radioInitialDirectionRight.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(radioRecording4);
            panel2.Controls.Add(radioRecording5);
            panel2.Controls.Add(radioRecording3);
            panel2.Controls.Add(radioRecording1);
            panel2.Controls.Add(radioRecording2);
            panel2.Controls.Add(radioRecordingAll);
            panel2.Controls.Add(lblRecording);
            panel2.Location = new Point(3, 144);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 100);
            panel2.TabIndex = 22;
            // 
            // radioRecording4
            // 
            radioRecording4.AutoSize = true;
            radioRecording4.BackColor = SystemColors.Control;
            radioRecording4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioRecording4.ForeColor = SystemColors.ControlText;
            radioRecording4.Location = new Point(120, 23);
            radioRecording4.Name = "radioRecording4";
            radioRecording4.Size = new Size(89, 19);
            radioRecording4.TabIndex = 8;
            radioRecording4.Text = "Recording 4";
            radioRecording4.UseVisualStyleBackColor = false;
            // 
            // radioRecording5
            // 
            radioRecording5.AutoSize = true;
            radioRecording5.BackColor = SystemColors.Control;
            radioRecording5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioRecording5.ForeColor = SystemColors.ControlText;
            radioRecording5.Location = new Point(120, 48);
            radioRecording5.Name = "radioRecording5";
            radioRecording5.Size = new Size(89, 19);
            radioRecording5.TabIndex = 9;
            radioRecording5.Text = "Recording 5";
            radioRecording5.UseVisualStyleBackColor = false;
            // 
            // radioRecording3
            // 
            radioRecording3.AutoSize = true;
            radioRecording3.BackColor = SystemColors.Control;
            radioRecording3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioRecording3.ForeColor = SystemColors.ControlText;
            radioRecording3.Location = new Point(7, 73);
            radioRecording3.Name = "radioRecording3";
            radioRecording3.Size = new Size(89, 19);
            radioRecording3.TabIndex = 7;
            radioRecording3.Text = "Recording 3";
            radioRecording3.UseVisualStyleBackColor = false;
            // 
            // radioRecording1
            // 
            radioRecording1.AutoSize = true;
            radioRecording1.BackColor = SystemColors.Control;
            radioRecording1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioRecording1.ForeColor = SystemColors.ControlText;
            radioRecording1.Location = new Point(7, 23);
            radioRecording1.Name = "radioRecording1";
            radioRecording1.Size = new Size(87, 19);
            radioRecording1.TabIndex = 5;
            radioRecording1.Text = "Recording 1";
            radioRecording1.UseVisualStyleBackColor = false;
            // 
            // radioRecording2
            // 
            radioRecording2.AutoSize = true;
            radioRecording2.BackColor = SystemColors.Control;
            radioRecording2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioRecording2.ForeColor = SystemColors.ControlText;
            radioRecording2.Location = new Point(7, 48);
            radioRecording2.Name = "radioRecording2";
            radioRecording2.Size = new Size(89, 19);
            radioRecording2.TabIndex = 6;
            radioRecording2.Text = "Recording 2";
            radioRecording2.UseVisualStyleBackColor = false;
            // 
            // radioRecordingAll
            // 
            radioRecordingAll.AutoSize = true;
            radioRecordingAll.BackColor = SystemColors.Control;
            radioRecordingAll.Checked = true;
            radioRecordingAll.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioRecordingAll.ForeColor = SystemColors.ControlText;
            radioRecordingAll.Location = new Point(120, 73);
            radioRecordingAll.Name = "radioRecordingAll";
            radioRecordingAll.Size = new Size(39, 19);
            radioRecordingAll.TabIndex = 17;
            radioRecordingAll.TabStop = true;
            radioRecordingAll.Text = "All";
            radioRecordingAll.UseVisualStyleBackColor = false;
            // 
            // lblRecording
            // 
            lblRecording.AutoSize = true;
            lblRecording.BackColor = SystemColors.Control;
            lblRecording.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblRecording.ForeColor = SystemColors.ControlText;
            lblRecording.Location = new Point(0, 5);
            lblRecording.Name = "lblRecording";
            lblRecording.Size = new Size(144, 15);
            lblRecording.TabIndex = 11;
            lblRecording.Text = "Select Recording to Parse:";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Control;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = SystemColors.ControlText;
            btnClear.Location = new Point(123, 478);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 27);
            btnClear.TabIndex = 26;
            btnClear.TabStop = false;
            btnClear.Text = "Clear Data";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += BtnClear_Click;
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
            // btnParse
            // 
            btnParse.BackColor = SystemColors.Control;
            btnParse.FlatStyle = FlatStyle.Flat;
            btnParse.ForeColor = SystemColors.ControlText;
            btnParse.Location = new Point(10, 478);
            btnParse.Name = "btnParse";
            btnParse.Size = new Size(107, 27);
            btnParse.TabIndex = 18;
            btnParse.TabStop = false;
            btnParse.Text = "Parse Input Data";
            btnParse.UseVisualStyleBackColor = false;
            btnParse.Click += BtnParse_Click;
            // 
            // lblOutputDirectory
            // 
            lblOutputDirectory.AutoSize = true;
            lblOutputDirectory.BackColor = SystemColors.Control;
            lblOutputDirectory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblOutputDirectory.ForeColor = SystemColors.ControlText;
            lblOutputDirectory.Location = new Point(3, 383);
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
            lblSaveDirectory.Location = new Point(3, 74);
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
            textboxOutputDirectory.Location = new Point(10, 401);
            textboxOutputDirectory.Multiline = true;
            textboxOutputDirectory.Name = "textboxOutputDirectory";
            textboxOutputDirectory.ReadOnly = true;
            textboxOutputDirectory.Size = new Size(220, 46);
            textboxOutputDirectory.TabIndex = 15;
            textboxOutputDirectory.TabStop = false;
            // 
            // textboxSaveDirectory
            // 
            textboxSaveDirectory.BackColor = SystemColors.Control;
            textboxSaveDirectory.BorderStyle = BorderStyle.None;
            textboxSaveDirectory.CausesValidation = false;
            textboxSaveDirectory.ForeColor = SystemColors.ControlText;
            textboxSaveDirectory.Location = new Point(10, 92);
            textboxSaveDirectory.Multiline = true;
            textboxSaveDirectory.Name = "textboxSaveDirectory";
            textboxSaveDirectory.ReadOnly = true;
            textboxSaveDirectory.Size = new Size(220, 46);
            textboxSaveDirectory.TabIndex = 5;
            textboxSaveDirectory.TabStop = false;
            // 
            // checkboxOutputTxtFiles
            // 
            checkboxOutputTxtFiles.AutoSize = true;
            checkboxOutputTxtFiles.BackColor = SystemColors.Control;
            checkboxOutputTxtFiles.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkboxOutputTxtFiles.ForeColor = SystemColors.ControlText;
            checkboxOutputTxtFiles.Location = new Point(10, 453);
            checkboxOutputTxtFiles.Name = "checkboxOutputTxtFiles";
            checkboxOutputTxtFiles.Size = new Size(137, 19);
            checkboxOutputTxtFiles.TabIndex = 14;
            checkboxOutputTxtFiles.TabStop = false;
            checkboxOutputTxtFiles.Text = "Generate Text File(s)?";
            checkboxOutputTxtFiles.UseVisualStyleBackColor = false;
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
            textboxParsedRecordingKEY.Dock = DockStyle.Bottom;
            textboxParsedRecordingKEY.ForeColor = SystemColors.ControlText;
            textboxParsedRecordingKEY.Location = new Point(0, 43);
            textboxParsedRecordingKEY.Multiline = true;
            textboxParsedRecordingKEY.Name = "textboxParsedRecordingKEY";
            textboxParsedRecordingKEY.ReadOnly = true;
            textboxParsedRecordingKEY.ScrollBars = ScrollBars.Vertical;
            textboxParsedRecordingKEY.Size = new Size(231, 466);
            textboxParsedRecordingKEY.TabIndex = 21;
            textboxParsedRecordingKEY.TabStop = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(textboxParsedRecordingKEY);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(menuStrip2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(242, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(235, 513);
            panel3.TabIndex = 3;
            // 
            // menuStrip2
            // 
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.Items.AddRange(new ToolStripItem[] { rawInputDataToolStripMenuItem, cleanInputDataToolStripMenuItem });
            menuStrip2.Location = new Point(1, 19);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.RenderMode = ToolStripRenderMode.System;
            menuStrip2.Size = new Size(350, 24);
            menuStrip2.TabIndex = 22;
            menuStrip2.Text = "menuStrip2";
            menuStrip2.ItemClicked += menuStrip2_ItemClicked;
            // 
            // rawInputDataToolStripMenuItem
            // 
            rawInputDataToolStripMenuItem.Checked = true;
            rawInputDataToolStripMenuItem.CheckOnClick = true;
            rawInputDataToolStripMenuItem.CheckState = CheckState.Checked;
            rawInputDataToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rawInputDataToolStripMenuItem.Name = "rawInputDataToolStripMenuItem";
            rawInputDataToolStripMenuItem.Size = new Size(101, 20);
            rawInputDataToolStripMenuItem.Text = "Raw Input Data";
            rawInputDataToolStripMenuItem.ToolTipText = "Display's the raw input data without any input cleanup.";
            // 
            // cleanInputDataToolStripMenuItem
            // 
            cleanInputDataToolStripMenuItem.CheckOnClick = true;
            cleanInputDataToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cleanInputDataToolStripMenuItem.Name = "cleanInputDataToolStripMenuItem";
            cleanInputDataToolStripMenuItem.Size = new Size(121, 20);
            cleanInputDataToolStripMenuItem.Text = "Cleaned Input Data";
            cleanInputDataToolStripMenuItem.ToolTipText = "Displays the cleaned up input data.";
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
            ClientSize = new Size(477, 537);
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
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
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
        private ToolStripMenuItem stripMenuFile;
        private ToolStripMenuItem stripMenuOpen;
        private ToolStripMenuItem stripMenuClose;
        private ToolStripMenuItem stripMenuHelp;
        private ToolStripMenuItem stripMenuDocumentation;
        private ToolStripMenuItem stripMenuAbout;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem stripMenuSetOutput;
        private Button btnClear;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private RadioButton radioOutputDirectionLeft;
        private RadioButton radioOutputDirectionRight;
        private RadioButton radioInitialDirectionLeft;
        private RadioButton radioInitialDirectionRight;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem rawInputDataToolStripMenuItem;
        private ToolStripMenuItem cleanInputDataToolStripMenuItem;
    }
}