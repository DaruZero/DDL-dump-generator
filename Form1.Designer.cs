namespace DDL_dump_generator
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
            this.groupProperties = new System.Windows.Forms.GroupBox();
            this.comboBoxSuffix = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numFinal = new System.Windows.Forms.NumericUpDown();
            this.numStart = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textLink = new System.Windows.Forms.TextBox();
            this.groupOutput = new System.Windows.Forms.GroupBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.textFileName = new System.Windows.Forms.TextBox();
            this.groupProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
            this.groupOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupProperties
            // 
            this.groupProperties.Controls.Add(this.comboBoxSuffix);
            this.groupProperties.Controls.Add(this.label2);
            this.groupProperties.Controls.Add(this.label1);
            this.groupProperties.Controls.Add(this.numFinal);
            this.groupProperties.Controls.Add(this.numStart);
            this.groupProperties.Controls.Add(this.buttonGenerate);
            this.groupProperties.Controls.Add(this.textLink);
            this.groupProperties.Location = new System.Drawing.Point(8, 7);
            this.groupProperties.Margin = new System.Windows.Forms.Padding(2);
            this.groupProperties.Name = "groupProperties";
            this.groupProperties.Padding = new System.Windows.Forms.Padding(2);
            this.groupProperties.Size = new System.Drawing.Size(1018, 109);
            this.groupProperties.TabIndex = 4;
            this.groupProperties.TabStop = false;
            this.groupProperties.Text = "Properties";
            // 
            // comboBoxSuffix
            // 
            this.comboBoxSuffix.AllowDrop = true;
            this.comboBoxSuffix.FormattingEnabled = true;
            this.comboBoxSuffix.Items.AddRange(new object[] {
            "_SUB_ITA.mp4",
            "_ITA.mp4"});
            this.comboBoxSuffix.Location = new System.Drawing.Point(5, 81);
            this.comboBoxSuffix.Name = "comboBoxSuffix";
            this.comboBoxSuffix.Size = new System.Drawing.Size(176, 23);
            this.comboBoxSuffix.TabIndex = 2;
            this.comboBoxSuffix.Text = "Insert suffix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Finish with episode:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Start with episode:";
            // 
            // numFinal
            // 
            this.numFinal.Location = new System.Drawing.Point(362, 81);
            this.numFinal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numFinal.Name = "numFinal";
            this.numFinal.Size = new System.Drawing.Size(106, 23);
            this.numFinal.TabIndex = 4;
            // 
            // numStart
            // 
            this.numStart.Location = new System.Drawing.Point(226, 81);
            this.numStart.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numStart.Name = "numStart";
            this.numStart.Size = new System.Drawing.Size(106, 23);
            this.numStart.TabIndex = 3;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonGenerate.Location = new System.Drawing.Point(492, 63);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(78, 40);
            this.buttonGenerate.TabIndex = 5;
            this.buttonGenerate.Text = "Generate!";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textLink
            // 
            this.textLink.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textLink.Location = new System.Drawing.Point(4, 20);
            this.textLink.Margin = new System.Windows.Forms.Padding(2);
            this.textLink.Name = "textLink";
            this.textLink.PlaceholderText = "Insert link";
            this.textLink.Size = new System.Drawing.Size(1010, 23);
            this.textLink.TabIndex = 1;
            // 
            // groupOutput
            // 
            this.groupOutput.Controls.Add(this.buttonExport);
            this.groupOutput.Controls.Add(this.textOutput);
            this.groupOutput.Controls.Add(this.textFileName);
            this.groupOutput.Location = new System.Drawing.Point(8, 135);
            this.groupOutput.Margin = new System.Windows.Forms.Padding(2);
            this.groupOutput.Name = "groupOutput";
            this.groupOutput.Padding = new System.Windows.Forms.Padding(2);
            this.groupOutput.Size = new System.Drawing.Size(1018, 355);
            this.groupOutput.TabIndex = 5;
            this.groupOutput.TabStop = false;
            this.groupOutput.Text = "Output";
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.Gold;
            this.buttonExport.Location = new System.Drawing.Point(362, 328);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(78, 24);
            this.buttonExport.TabIndex = 8;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(4, 29);
            this.textOutput.Margin = new System.Windows.Forms.Padding(2);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.ReadOnly = true;
            this.textOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textOutput.Size = new System.Drawing.Size(1011, 295);
            this.textOutput.TabIndex = 6;
            // 
            // textFileName
            // 
            this.textFileName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textFileName.Location = new System.Drawing.Point(4, 328);
            this.textFileName.Margin = new System.Windows.Forms.Padding(2);
            this.textFileName.Name = "textFileName";
            this.textFileName.PlaceholderText = "File name (.txt)";
            this.textFileName.Size = new System.Drawing.Size(328, 23);
            this.textFileName.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 507);
            this.Controls.Add(this.groupOutput);
            this.Controls.Add(this.groupProperties);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1059, 550);
            this.MinimumSize = new System.Drawing.Size(1059, 550);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "DDL Dump Generator";
            this.groupProperties.ResumeLayout(false);
            this.groupProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
            this.groupOutput.ResumeLayout(false);
            this.groupOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupProperties;
        private NumericUpDown numFinal;
        private NumericUpDown numStart;
        private Button buttonGenerate;
        private TextBox textLink;
        private GroupBox groupOutput;
        private Button buttonExport;
        private TextBox textOutput;
        private TextBox textFileName;
        private ComboBox comboBoxSuffix;
        private Label label2;
        private Label label1;
    }
}