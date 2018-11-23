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

        private void EnableGenerateButton()
        {
            if (InputValidations.AreInputsValid())
            {
                btn_Generate_resx.Enabled = true;
            }
        }

        private void resxGenerator_Load(object sender, EventArgs e)
        {

        }

        private void input_excel_path_TextChanged(object sender, EventArgs e)
        {
            if(InputValidations.IsInputExcelFilePathValid(tb_input_excel_path.Text))
            {
                EnableGenerateButton();
            }
            else
            {
                MessageBox.Show(Constants.INVALID_INPUT_FILE_PATH_ERROR);
                tb_input_excel_path.Text = string.Empty;
            }
        }

        private void output_resx_path_TextChanged(object sender, EventArgs e)
        {
            if (InputValidations.IsOutputFolderPathValid(tb_output_resx_path.Text))
            {
                EnableGenerateButton();
            }
            else
            {
                MessageBox.Show(Constants.INVALID_OUTPUT_DIRECTORY_PATH_ERROR);
                tb_output_resx_path.Text = string.Empty;
            }
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
            if (InputValidations.IsExcelSheetInRightFormat(tb_input_excel_path.Text))
            {
                ResxGenerator.Generate(tb_input_excel_path.Text);
            }
        }
    }
}
