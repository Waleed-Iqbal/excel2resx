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
            btn_Generate_resx.Enabled = InputValidations.ArePathsInputsValid() && IsAtleastOneLanguageSelected();
        }

        private void resxGenerator_Load(object sender, EventArgs e)
        {

        }

        private void input_excel_path_TextChanged(object sender, EventArgs e)
        {
            if (InputValidations.IsInputExcelFilePathValid(tb_input_excel_path.Text))
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
            if (InputValidations.IsExcelSheetInRightFormat(tb_input_excel_path.Text) && InputValidations.IsALanguageSelected)
            {
                ResxGenerator.Generate(tb_input_excel_path.Text);
            }
            else
            {
                MessageBox.Show(Constants.INVALID_INPUT_FILE_ERROR);
            }
        }

        #region Language Check Boxes Handlers
        private void UpdateAllLanguagesSelection(bool? state)
        {
            if (state == null)
            {
                cb_Dutch.Checked = SupportedLangues.DutchSelected;
                cb_Greek.Checked = SupportedLangues.GreekSelected;
                cb_French.Checked = SupportedLangues.FrenchSelected;
                cb_German.Checked = SupportedLangues.GermanSelected;
                cb_English.Checked = SupportedLangues.EnglishSelected;
                cb_Italian.Checked = SupportedLangues.ItalianSelected;
                cb_Spanish.Checked = SupportedLangues.SpanishSelected;
                cb_Swedish.Checked = SupportedLangues.SwedishSelected;
                cb_Norwegian.Checked = SupportedLangues.NorwegianSelected;
                cb_Portuguese.Checked = SupportedLangues.PortugueseSelected;
            }
            else
            {

                cb_Dutch.Checked = (bool)state;
                cb_Greek.Checked = (bool)state;
                cb_French.Checked = (bool)state;
                cb_German.Checked = (bool)state;
                cb_English.Checked = (bool)state;
                cb_Italian.Checked = (bool)state;
                cb_Spanish.Checked = (bool)state;
                cb_Swedish.Checked = (bool)state;
                cb_Norwegian.Checked = (bool)state;
                cb_Portuguese.Checked = (bool)state;
            }
        }

        private bool IsAtleastOneLanguageSelected()
        {
            return cb_Dutch.Checked ||
              cb_Greek.Checked ||
              cb_French.Checked ||
              cb_German.Checked ||
              cb_English.Checked ||
              cb_Italian.Checked ||
              cb_Spanish.Checked ||
              cb_Swedish.Checked ||
              cb_Norwegian.Checked ||
              cb_Portuguese.Checked;
        }

        private bool AreAllLanguagesSelected()
        {
            return cb_Dutch.Checked &&
              cb_Greek.Checked &&
              cb_French.Checked &&
              cb_German.Checked &&
              cb_English.Checked &&
              cb_Italian.Checked &&
              cb_Spanish.Checked &&
              cb_Swedish.Checked &&
              cb_Norwegian.Checked &&
              cb_Portuguese.Checked;
        }

        private bool selectAllChangeAfterLanguageUpdate = false;

        private void UpdateLanguageSelection()
        {
            InputValidations.IsALanguageSelected = IsAtleastOneLanguageSelected();
            InputValidations.AreAllLanguagesSelected = AreAllLanguagesSelected();

            selectAllChangeAfterLanguageUpdate = true;
            cb_SelectAll.Checked = InputValidations.AreAllLanguagesSelected;
            EnableGenerateButton();
        }

        private void cb_SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (selectAllChangeAfterLanguageUpdate && InputValidations.AreAllLanguagesSelected && !cb_SelectAll.Checked)
            {
                selectAllChangeAfterLanguageUpdate = false;
                UpdateAllLanguagesSelection(false);
                return;
            }

            InputValidations.AreAllLanguagesSelected = cb_SelectAll.Checked;
            if (!InputValidations.AreAllLanguagesSelected)
            {
                UpdateAllLanguagesSelection(null);
            }
            else
            {
                UpdateAllLanguagesSelection(true);
            }
        }

        private void cb_Dutch_CheckedChanged(object sender, EventArgs e)
        {
            SupportedLangues.DutchSelected = cb_Dutch.Checked;
            UpdateLanguageSelection();
        }

        private void cb_English_CheckedChanged(object sender, EventArgs e)
        {
            SupportedLangues.EnglishSelected = cb_English.Checked;
            UpdateLanguageSelection();
        }

        private void cb_French_CheckedChanged(object sender, EventArgs e)
        {
            SupportedLangues.FrenchSelected = cb_French.Checked;
            UpdateLanguageSelection();
        }

        private void cb_German_CheckedChanged(object sender, EventArgs e)
        {
            SupportedLangues.GermanSelected = cb_German.Checked;
            UpdateLanguageSelection();
        }

        private void cb_Italian_CheckedChanged(object sender, EventArgs e)
        {
            SupportedLangues.ItalianSelected = cb_Italian.Checked;
            UpdateLanguageSelection();
        }

        private void cb_Norwegian_CheckedChanged(object sender, EventArgs e)
        {
            SupportedLangues.NorwegianSelected = cb_Norwegian.Checked;
            UpdateLanguageSelection();
        }

        private void cb_Portuguese_CheckedChanged(object sender, EventArgs e)
        {
            SupportedLangues.PortugueseSelected = cb_Portuguese.Checked;
            UpdateLanguageSelection();
        }

        private void cb_Spanish_CheckedChanged(object sender, EventArgs e)
        {
            SupportedLangues.SpanishSelected = cb_Spanish.Checked;
            UpdateLanguageSelection();
        }

        private void cb_Swedish_CheckedChanged(object sender, EventArgs e)
        {
            SupportedLangues.SwedishSelected = cb_Swedish.Checked;
            UpdateLanguageSelection();
        }

        private void cb_Greek_CheckedChanged(object sender, EventArgs e)
        {
            SupportedLangues.GreekSelected = cb_Greek.Checked;
            UpdateLanguageSelection();
        }
        #endregion Language Check Boxes Handler

    }
}
