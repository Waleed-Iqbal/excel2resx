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
            this.btn_Generate_resx = new System.Windows.Forms.Button();
            this.tb_input_excel_path = new System.Windows.Forms.TextBox();
            this.InputExcelFilePath = new System.Windows.Forms.Label();
            this.OutputResxFilePath = new System.Windows.Forms.Label();
            this.tb_output_resx_path = new System.Windows.Forms.TextBox();
            this.generationLog = new System.Windows.Forms.TextBox();
            this.btn_BrowseInputFile = new System.Windows.Forms.Button();
            this.btn_BrowseForOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Generate_resx
            // 
            this.btn_Generate_resx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Generate_resx.Location = new System.Drawing.Point(153, 147);
            this.btn_Generate_resx.Name = "btn_Generate_resx";
            this.btn_Generate_resx.Size = new System.Drawing.Size(118, 30);
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
            this.tb_input_excel_path.Location = new System.Drawing.Point(18, 47);
            this.tb_input_excel_path.Name = "tb_input_excel_path";
            this.tb_input_excel_path.Size = new System.Drawing.Size(306, 20);
            this.tb_input_excel_path.TabIndex = 1;
            this.tb_input_excel_path.TextChanged += new System.EventHandler(this.input_excel_path_TextChanged);
            // 
            // InputExcelFilePath
            // 
            this.InputExcelFilePath.AutoSize = true;
            this.InputExcelFilePath.Location = new System.Drawing.Point(16, 20);
            this.InputExcelFilePath.Name = "InputExcelFilePath";
            this.InputExcelFilePath.Size = new System.Drawing.Size(107, 13);
            this.InputExcelFilePath.TabIndex = 2;
            this.InputExcelFilePath.Text = "Input: Excel File Path";
            // 
            // OutputResxFilePath
            // 
            this.OutputResxFilePath.AutoSize = true;
            this.OutputResxFilePath.Location = new System.Drawing.Point(15, 86);
            this.OutputResxFilePath.Name = "OutputResxFilePath";
            this.OutputResxFilePath.Size = new System.Drawing.Size(108, 13);
            this.OutputResxFilePath.TabIndex = 3;
            this.OutputResxFilePath.Text = "Output: resx File Path";
            // 
            // tb_output_resx_path
            // 
            this.tb_output_resx_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_output_resx_path.Location = new System.Drawing.Point(20, 111);
            this.tb_output_resx_path.Name = "tb_output_resx_path";
            this.tb_output_resx_path.Size = new System.Drawing.Size(304, 20);
            this.tb_output_resx_path.TabIndex = 4;
            this.tb_output_resx_path.TextChanged += new System.EventHandler(this.output_resx_path_TextChanged);
            // 
            // generationLog
            // 
            this.generationLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generationLog.Location = new System.Drawing.Point(20, 190);
            this.generationLog.Multiline = true;
            this.generationLog.Name = "generationLog";
            this.generationLog.Size = new System.Drawing.Size(386, 241);
            this.generationLog.TabIndex = 5;
            // 
            // btn_BrowseInputFile
            // 
            this.btn_BrowseInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BrowseInputFile.Location = new System.Drawing.Point(330, 47);
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
            this.btn_BrowseForOutput.Location = new System.Drawing.Point(331, 111);
            this.btn_BrowseForOutput.Name = "btn_BrowseForOutput";
            this.btn_BrowseForOutput.Size = new System.Drawing.Size(75, 23);
            this.btn_BrowseForOutput.TabIndex = 7;
            this.btn_BrowseForOutput.Text = "Browse";
            this.btn_BrowseForOutput.UseVisualStyleBackColor = true;
            this.btn_BrowseForOutput.Click += new System.EventHandler(this.BrowseForOutput_Click);
            // 
            // resxGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(422, 443);
            this.Controls.Add(this.btn_BrowseForOutput);
            this.Controls.Add(this.btn_BrowseInputFile);
            this.Controls.Add(this.generationLog);
            this.Controls.Add(this.tb_output_resx_path);
            this.Controls.Add(this.OutputResxFilePath);
            this.Controls.Add(this.InputExcelFilePath);
            this.Controls.Add(this.tb_input_excel_path);
            this.Controls.Add(this.btn_Generate_resx);
            this.MinimumSize = new System.Drawing.Size(220, 400);
            this.Name = "resxGenerator";
            this.Text = "resx Generator";
            this.Load += new System.EventHandler(this.resxGenerator_Load);
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
    }
}

