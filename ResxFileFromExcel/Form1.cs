using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResxFileFromExcel
{
    public partial class resxGenerator : Form
    {
        public resxGenerator()
        {
            InitializeComponent();
            btn_Generate_resx.Enabled = false;
        }

        private void resxGenerator_Load(object sender, EventArgs e)
        {

        }

        private void input_excel_path_TextChanged(object sender, EventArgs e)
        {
            // do validation here
        }

        private void output_resx_path_TextChanged(object sender, EventArgs e)
        {
            // do validation here
        }

       

        private void BrowseInputFile_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog selectFileDialog = new OpenFileDialog())
            {
                if (selectFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = selectFileDialog.FileName;
                    tb_input_excel_path.Text = filePath;
                }
            }
        }

        private void BrowseForOutput_Click(object sender, EventArgs e)
        {
            using (var openFolderDialog = new FolderBrowserDialog())
            { 
                if (openFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    string outputFolder = openFolderDialog.SelectedPath;
                    tb_output_resx_path.Text = outputFolder;
                }
            }
        }


        private void Generate_resx_Click(object sender, EventArgs e)
        {

        }
    }
}
