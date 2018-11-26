using System;

namespace ResxFileFromExcel
{
    partial class resxGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(resxGenerator));
            this.btn_Generate_resx = new System.Windows.Forms.Button();
            this.tb_input_excel_path = new System.Windows.Forms.TextBox();
            this.InputExcelFilePath = new System.Windows.Forms.Label();
            this.OutputResxFilePath = new System.Windows.Forms.Label();
            this.tb_output_resx_path = new System.Windows.Forms.TextBox();
            this.generationLog = new System.Windows.Forms.TextBox();
            this.btn_BrowseInputFile = new System.Windows.Forms.Button();
            this.btn_BrowseForOutput = new System.Windows.Forms.Button();
            this.cb_Greek = new System.Windows.Forms.CheckBox();
            this.cb_Dutch = new System.Windows.Forms.CheckBox();
            this.cb_German = new System.Windows.Forms.CheckBox();
            this.cb_French = new System.Windows.Forms.CheckBox();
            this.cb_English = new System.Windows.Forms.CheckBox();
            this.cb_Spanish = new System.Windows.Forms.CheckBox();
            this.cb_Swedish = new System.Windows.Forms.CheckBox();
            this.cb_Italian = new System.Windows.Forms.CheckBox();
            this.cb_Norwegian = new System.Windows.Forms.CheckBox();
            this.cb_Portuguese = new System.Windows.Forms.CheckBox();
            this.gb_SelectLanguages = new System.Windows.Forms.GroupBox();
            this.panel_SelectLanguages = new System.Windows.Forms.Panel();
            this.cb_SelectAll = new System.Windows.Forms.CheckBox();
            this.lbl_GenerationLog = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.gb_SelectLanguages.SuspendLayout();
            this.panel_SelectLanguages.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Generate_resx
            // 
            this.btn_Generate_resx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Generate_resx.Location = new System.Drawing.Point(371, 273);
            this.btn_Generate_resx.Name = "btn_Generate_resx";
            this.btn_Generate_resx.Size = new System.Drawing.Size(98, 27);
            this.btn_Generate_resx.TabIndex = 0;
            this.btn_Generate_resx.Text = "Generate";
            this.btn_Generate_resx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Generate_resx.UseVisualStyleBackColor = true;
            this.btn_Generate_resx.Click += new System.EventHandler(this.Generate_resx_Click);
            // 
            // tb_input_excel_path
            // 
            this.tb_input_excel_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_input_excel_path.Location = new System.Drawing.Point(14, 41);
            this.tb_input_excel_path.Name = "tb_input_excel_path";
            this.tb_input_excel_path.Size = new System.Drawing.Size(374, 20);
            this.tb_input_excel_path.TabIndex = 1;
            this.tb_input_excel_path.TextChanged += new System.EventHandler(this.input_excel_path_TextChanged);
            // 
            // InputExcelFilePath
            // 
            this.InputExcelFilePath.AutoSize = true;
            this.InputExcelFilePath.Location = new System.Drawing.Point(12, 20);
            this.InputExcelFilePath.Name = "InputExcelFilePath";
            this.InputExcelFilePath.Size = new System.Drawing.Size(107, 13);
            this.InputExcelFilePath.TabIndex = 2;
            this.InputExcelFilePath.Text = "Input: Excel File Path";
            // 
            // OutputResxFilePath
            // 
            this.OutputResxFilePath.AutoSize = true;
            this.OutputResxFilePath.Location = new System.Drawing.Point(14, 79);
            this.OutputResxFilePath.Name = "OutputResxFilePath";
            this.OutputResxFilePath.Size = new System.Drawing.Size(120, 13);
            this.OutputResxFilePath.TabIndex = 3;
            this.OutputResxFilePath.Text = "Output: resx Files Folder";
            // 
            // tb_output_resx_path
            // 
            this.tb_output_resx_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_output_resx_path.Location = new System.Drawing.Point(16, 103);
            this.tb_output_resx_path.Name = "tb_output_resx_path";
            this.tb_output_resx_path.Size = new System.Drawing.Size(372, 20);
            this.tb_output_resx_path.TabIndex = 4;
            this.tb_output_resx_path.TextChanged += new System.EventHandler(this.output_resx_path_TextChanged);
            // 
            // generationLog
            // 
            this.generationLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generationLog.Enabled = false;
            this.generationLog.Location = new System.Drawing.Point(17, 307);
            this.generationLog.Multiline = true;
            this.generationLog.Name = "generationLog";
            this.generationLog.Size = new System.Drawing.Size(454, 219);
            this.generationLog.TabIndex = 5;
            // 
            // btn_BrowseInputFile
            // 
            this.btn_BrowseInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BrowseInputFile.Location = new System.Drawing.Point(394, 40);
            this.btn_BrowseInputFile.Name = "btn_BrowseInputFile";
            this.btn_BrowseInputFile.Size = new System.Drawing.Size(75, 23);
            this.btn_BrowseInputFile.TabIndex = 6;
            this.btn_BrowseInputFile.Text = "Browse";
            this.btn_BrowseInputFile.UseVisualStyleBackColor = true;
            this.btn_BrowseInputFile.Click += new System.EventHandler(this.BrowseInputFile_Click);
            // 
            // btn_BrowseForOutput
            // 
            this.btn_BrowseForOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BrowseForOutput.Location = new System.Drawing.Point(395, 102);
            this.btn_BrowseForOutput.Name = "btn_BrowseForOutput";
            this.btn_BrowseForOutput.Size = new System.Drawing.Size(75, 23);
            this.btn_BrowseForOutput.TabIndex = 7;
            this.btn_BrowseForOutput.Text = "Browse";
            this.btn_BrowseForOutput.UseVisualStyleBackColor = true;
            this.btn_BrowseForOutput.Click += new System.EventHandler(this.BrowseForOutput_Click);
            // 
            // cb_Greek
            // 
            this.cb_Greek.AutoSize = true;
            this.cb_Greek.Location = new System.Drawing.Point(346, 84);
            this.cb_Greek.Name = "cb_Greek";
            this.cb_Greek.Size = new System.Drawing.Size(55, 17);
            this.cb_Greek.TabIndex = 8;
            this.cb_Greek.Text = "Greek";
            this.cb_Greek.UseVisualStyleBackColor = true;
            this.cb_Greek.CheckedChanged += new System.EventHandler(this.cb_Greek_CheckedChanged);
            // 
            // cb_Dutch
            // 
            this.cb_Dutch.AutoSize = true;
            this.cb_Dutch.Location = new System.Drawing.Point(8, 48);
            this.cb_Dutch.Name = "cb_Dutch";
            this.cb_Dutch.Size = new System.Drawing.Size(55, 17);
            this.cb_Dutch.TabIndex = 9;
            this.cb_Dutch.Text = "Dutch";
            this.cb_Dutch.UseVisualStyleBackColor = true;
            this.cb_Dutch.CheckedChanged += new System.EventHandler(this.cb_Dutch_CheckedChanged);
            // 
            // cb_German
            // 
            this.cb_German.AutoSize = true;
            this.cb_German.Location = new System.Drawing.Point(262, 48);
            this.cb_German.Name = "cb_German";
            this.cb_German.Size = new System.Drawing.Size(63, 17);
            this.cb_German.TabIndex = 10;
            this.cb_German.Text = "German";
            this.cb_German.UseVisualStyleBackColor = true;
            this.cb_German.CheckedChanged += new System.EventHandler(this.cb_German_CheckedChanged);
            // 
            // cb_French
            // 
            this.cb_French.AutoSize = true;
            this.cb_French.Location = new System.Drawing.Point(180, 48);
            this.cb_French.Name = "cb_French";
            this.cb_French.Size = new System.Drawing.Size(59, 17);
            this.cb_French.TabIndex = 11;
            this.cb_French.Text = "French";
            this.cb_French.UseVisualStyleBackColor = true;
            this.cb_French.CheckedChanged += new System.EventHandler(this.cb_French_CheckedChanged);
            // 
            // cb_English
            // 
            this.cb_English.AutoSize = true;
            this.cb_English.Location = new System.Drawing.Point(95, 48);
            this.cb_English.Name = "cb_English";
            this.cb_English.Size = new System.Drawing.Size(60, 17);
            this.cb_English.TabIndex = 12;
            this.cb_English.Text = "English";
            this.cb_English.UseVisualStyleBackColor = true;
            this.cb_English.CheckedChanged += new System.EventHandler(this.cb_English_CheckedChanged);
            // 
            // cb_Spanish
            // 
            this.cb_Spanish.AutoSize = true;
            this.cb_Spanish.Location = new System.Drawing.Point(180, 84);
            this.cb_Spanish.Name = "cb_Spanish";
            this.cb_Spanish.Size = new System.Drawing.Size(64, 17);
            this.cb_Spanish.TabIndex = 13;
            this.cb_Spanish.Text = "Spanish";
            this.cb_Spanish.UseVisualStyleBackColor = true;
            this.cb_Spanish.CheckedChanged += new System.EventHandler(this.cb_Spanish_CheckedChanged);
            // 
            // cb_Swedish
            // 
            this.cb_Swedish.AutoSize = true;
            this.cb_Swedish.Location = new System.Drawing.Point(262, 84);
            this.cb_Swedish.Name = "cb_Swedish";
            this.cb_Swedish.Size = new System.Drawing.Size(66, 17);
            this.cb_Swedish.TabIndex = 14;
            this.cb_Swedish.Text = "Swedish";
            this.cb_Swedish.UseVisualStyleBackColor = true;
            this.cb_Swedish.CheckedChanged += new System.EventHandler(this.cb_Swedish_CheckedChanged);
            // 
            // cb_Italian
            // 
            this.cb_Italian.AutoSize = true;
            this.cb_Italian.Location = new System.Drawing.Point(346, 48);
            this.cb_Italian.Name = "cb_Italian";
            this.cb_Italian.Size = new System.Drawing.Size(54, 17);
            this.cb_Italian.TabIndex = 15;
            this.cb_Italian.Text = "Italian";
            this.cb_Italian.UseVisualStyleBackColor = true;
            this.cb_Italian.CheckedChanged += new System.EventHandler(this.cb_Italian_CheckedChanged);
            // 
            // cb_Norwegian
            // 
            this.cb_Norwegian.AutoSize = true;
            this.cb_Norwegian.Location = new System.Drawing.Point(8, 84);
            this.cb_Norwegian.Name = "cb_Norwegian";
            this.cb_Norwegian.Size = new System.Drawing.Size(77, 17);
            this.cb_Norwegian.TabIndex = 16;
            this.cb_Norwegian.Text = "Norwegian";
            this.cb_Norwegian.UseVisualStyleBackColor = true;
            this.cb_Norwegian.CheckedChanged += new System.EventHandler(this.cb_Norwegian_CheckedChanged);
            // 
            // cb_Portuguese
            // 
            this.cb_Portuguese.AutoSize = true;
            this.cb_Portuguese.Location = new System.Drawing.Point(95, 84);
            this.cb_Portuguese.Name = "cb_Portuguese";
            this.cb_Portuguese.Size = new System.Drawing.Size(80, 17);
            this.cb_Portuguese.TabIndex = 17;
            this.cb_Portuguese.Text = "Portuguese";
            this.cb_Portuguese.UseVisualStyleBackColor = true;
            this.cb_Portuguese.CheckedChanged += new System.EventHandler(this.cb_Portuguese_CheckedChanged);
            // 
            // gb_SelectLanguages
            // 
            this.gb_SelectLanguages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_SelectLanguages.Controls.Add(this.panel_SelectLanguages);
            this.gb_SelectLanguages.Location = new System.Drawing.Point(17, 139);
            this.gb_SelectLanguages.Name = "gb_SelectLanguages";
            this.gb_SelectLanguages.Size = new System.Drawing.Size(452, 126);
            this.gb_SelectLanguages.TabIndex = 19;
            this.gb_SelectLanguages.TabStop = false;
            this.gb_SelectLanguages.Text = "Select Languages";
            // 
            // panel_SelectLanguages
            // 
            this.panel_SelectLanguages.Controls.Add(this.cb_SelectAll);
            this.panel_SelectLanguages.Controls.Add(this.cb_Italian);
            this.panel_SelectLanguages.Controls.Add(this.cb_Norwegian);
            this.panel_SelectLanguages.Controls.Add(this.cb_English);
            this.panel_SelectLanguages.Controls.Add(this.cb_Portuguese);
            this.panel_SelectLanguages.Controls.Add(this.cb_Spanish);
            this.panel_SelectLanguages.Controls.Add(this.cb_Greek);
            this.panel_SelectLanguages.Controls.Add(this.cb_French);
            this.panel_SelectLanguages.Controls.Add(this.cb_Dutch);
            this.panel_SelectLanguages.Controls.Add(this.cb_Swedish);
            this.panel_SelectLanguages.Controls.Add(this.cb_German);
            this.panel_SelectLanguages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_SelectLanguages.Location = new System.Drawing.Point(3, 16);
            this.panel_SelectLanguages.Name = "panel_SelectLanguages";
            this.panel_SelectLanguages.Size = new System.Drawing.Size(446, 107);
            this.panel_SelectLanguages.TabIndex = 19;
            // 
            // cb_SelectAll
            // 
            this.cb_SelectAll.AutoSize = true;
            this.cb_SelectAll.Location = new System.Drawing.Point(8, 14);
            this.cb_SelectAll.Name = "cb_SelectAll";
            this.cb_SelectAll.Size = new System.Drawing.Size(70, 17);
            this.cb_SelectAll.TabIndex = 18;
            this.cb_SelectAll.Text = "Select All";
            this.cb_SelectAll.UseVisualStyleBackColor = true;
            this.cb_SelectAll.CheckedChanged += new System.EventHandler(this.cb_SelectAll_CheckedChanged);
            // 
            // lbl_GenerationLog
            // 
            this.lbl_GenerationLog.AutoSize = true;
            this.lbl_GenerationLog.Location = new System.Drawing.Point(21, 290);
            this.lbl_GenerationLog.Name = "lbl_GenerationLog";
            this.lbl_GenerationLog.Size = new System.Drawing.Size(28, 13);
            this.lbl_GenerationLog.TabIndex = 20;
            this.lbl_GenerationLog.Text = "Log:";
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.Location = new System.Drawing.Point(383, 535);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(87, 23);
            this.Close.TabIndex = 21;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // resxGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(490, 568);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.lbl_GenerationLog);
            this.Controls.Add(this.gb_SelectLanguages);
            this.Controls.Add(this.btn_BrowseForOutput);
            this.Controls.Add(this.btn_BrowseInputFile);
            this.Controls.Add(this.generationLog);
            this.Controls.Add(this.tb_output_resx_path);
            this.Controls.Add(this.OutputResxFilePath);
            this.Controls.Add(this.InputExcelFilePath);
            this.Controls.Add(this.tb_input_excel_path);
            this.Controls.Add(this.btn_Generate_resx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(220, 400);
            this.Name = "resxGenerator";
            this.Text = "resx Generator";
            this.Load += new System.EventHandler(this.resxGenerator_Load);
            this.gb_SelectLanguages.ResumeLayout(false);
            this.panel_SelectLanguages.ResumeLayout(false);
            this.panel_SelectLanguages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button btn_Generate_resx;
        private System.Windows.Forms.TextBox tb_input_excel_path;
        private System.Windows.Forms.Label InputExcelFilePath;
        private System.Windows.Forms.Label OutputResxFilePath;
        private System.Windows.Forms.TextBox tb_output_resx_path;
        private System.Windows.Forms.TextBox generationLog;
        private System.Windows.Forms.Button btn_BrowseInputFile;
        private System.Windows.Forms.Button btn_BrowseForOutput;
        private System.Windows.Forms.CheckBox cb_Greek;
        private System.Windows.Forms.CheckBox cb_Dutch;
        private System.Windows.Forms.CheckBox cb_German;
        private System.Windows.Forms.CheckBox cb_French;
        private System.Windows.Forms.CheckBox cb_English;
        private System.Windows.Forms.CheckBox cb_Spanish;
        private System.Windows.Forms.CheckBox cb_Swedish;
        private System.Windows.Forms.CheckBox cb_Italian;
        private System.Windows.Forms.CheckBox cb_Norwegian;
        private System.Windows.Forms.CheckBox cb_Portuguese;
        private System.Windows.Forms.GroupBox gb_SelectLanguages;
        private System.Windows.Forms.Label lbl_GenerationLog;
        private System.Windows.Forms.CheckBox cb_SelectAll;
        private System.Windows.Forms.Panel panel_SelectLanguages;
        private System.Windows.Forms.Button Close;
    }
}

