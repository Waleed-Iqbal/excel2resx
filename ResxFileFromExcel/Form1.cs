using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResxFileFromExcel
{
    public partial class resxGenerator : Form
    {

        public bool isCorrectInputPathGiven = false;
        public bool isCorrectOutputPathGiven = false;

        public resxGenerator()
        {
            InitializeComponent();
        }

        private void OutputResxFilePath_Click(object sender, EventArgs e)
        {

        }

        private void InputExcelFilePath_Click(object sender, EventArgs e)
        {

        }

        private void Generate_resx_Click(object sender, EventArgs e)
        {

        }

        private void input_excel_path_TextChanged(object sender, EventArgs e)
        {
            // do validation here
            isCorrectInputPathGiven = true;
        }

        private void output_resx_path_TextChanged(object sender, EventArgs e)
        {
            // do validation here
            isCorrectOutputPathGiven = true;
        }
    }
}
