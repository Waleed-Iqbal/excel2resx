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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.InputExcelFilePath = new System.Windows.Forms.Label();
            this.OutputResxFilePath = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(486, 20);
            this.textBox1.TabIndex = 1;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(484, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(18, 184);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(484, 254);
            this.textBox3.TabIndex = 5;
            // 
            // resxGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.OutputResxFilePath);
            this.Controls.Add(this.InputExcelFilePath);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Generate_resx);
            this.Name = "resxGenerator";
            this.Text = "resx Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate_resx;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label InputExcelFilePath;
        private System.Windows.Forms.Label OutputResxFilePath;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

