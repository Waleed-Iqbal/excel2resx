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
            this.Generate_resx = new System.Windows.Forms.Button();
            this.input_excel_path = new System.Windows.Forms.TextBox();
            this.InputExcelFilePath = new System.Windows.Forms.Label();
            this.OutputResxFilePath = new System.Windows.Forms.Label();
            this.output_resx_path = new System.Windows.Forms.TextBox();
            this.generationLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Generate_resx
            // 
            this.Generate_resx.Location = new System.Drawing.Point(224, 149);
            this.Generate_resx.Name = "Generate_resx";
            this.Generate_resx.Size = new System.Drawing.Size(75, 23);
            this.Generate_resx.TabIndex = 0;
            this.Generate_resx.Text = "Generate";
            this.Generate_resx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Generate_resx.UseVisualStyleBackColor = true;
            this.Generate_resx.Click += new System.EventHandler(this.Generate_resx_Click);
            // 
            // input_excel_path
            // 
            this.input_excel_path.Location = new System.Drawing.Point(16, 48);
            this.input_excel_path.Name = "input_excel_path";
            this.input_excel_path.Size = new System.Drawing.Size(486, 20);
            this.input_excel_path.TabIndex = 1;
            this.input_excel_path.TextChanged += new System.EventHandler(this.input_excel_path_TextChanged);
            // 
            // InputExcelFilePath
            // 
            this.InputExcelFilePath.AutoSize = true;
            this.InputExcelFilePath.Location = new System.Drawing.Point(16, 20);
            this.InputExcelFilePath.Name = "InputExcelFilePath";
            this.InputExcelFilePath.Size = new System.Drawing.Size(107, 13);
            this.InputExcelFilePath.TabIndex = 2;
            this.InputExcelFilePath.Text = "Input: Excel File Path";
            this.InputExcelFilePath.Click += new System.EventHandler(this.InputExcelFilePath_Click);
            // 
            // OutputResxFilePath
            // 
            this.OutputResxFilePath.AutoSize = true;
            this.OutputResxFilePath.Location = new System.Drawing.Point(15, 86);
            this.OutputResxFilePath.Name = "OutputResxFilePath";
            this.OutputResxFilePath.Size = new System.Drawing.Size(108, 13);
            this.OutputResxFilePath.TabIndex = 3;
            this.OutputResxFilePath.Text = "Output: resx File Path";
            this.OutputResxFilePath.Click += new System.EventHandler(this.OutputResxFilePath_Click);
            // 
            // output_resx_path
            // 
            this.output_resx_path.Location = new System.Drawing.Point(18, 112);
            this.output_resx_path.Name = "output_resx_path";
            this.output_resx_path.Size = new System.Drawing.Size(484, 20);
            this.output_resx_path.TabIndex = 4;
            this.output_resx_path.TextChanged += new System.EventHandler(this.output_resx_path_TextChanged);
            // 
            // generationLog
            // 
            this.generationLog.Location = new System.Drawing.Point(18, 184);
            this.generationLog.Multiline = true;
            this.generationLog.Name = "generationLog";
            this.generationLog.Size = new System.Drawing.Size(484, 254);
            this.generationLog.TabIndex = 5;
            // 
            // resxGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.generationLog);
            this.Controls.Add(this.output_resx_path);
            this.Controls.Add(this.OutputResxFilePath);
            this.Controls.Add(this.InputExcelFilePath);
            this.Controls.Add(this.input_excel_path);
            this.Controls.Add(this.Generate_resx);
            this.Name = "resxGenerator";
            this.Text = "resx Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate_resx;
        private System.Windows.Forms.TextBox input_excel_path;
        private System.Windows.Forms.Label InputExcelFilePath;
        private System.Windows.Forms.Label OutputResxFilePath;
        private System.Windows.Forms.TextBox output_resx_path;
        private System.Windows.Forms.TextBox generationLog;
    }
}

