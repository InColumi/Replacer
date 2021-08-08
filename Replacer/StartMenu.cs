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

namespace Replacer
{
    public partial class StartMenu : Form
    {
        private string _path = string.Empty;
        private List
        public StartMenu()
        {
            InitializeComponent();
        }

        private void buttonBrowser_Click(object sender, EventArgs e)
        {
            SetPath();
            textBoxShowPath.Text = _path;
        }

        private void SetPath()
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            browserDialog.Description = "Выберете папку";
            browserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            browserDialog.ShowNewFolderButton = true;
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                _path = browserDialog.SelectedPath;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_path != string.Empty && Directory.Exists(_path))
            {
                List<string> lines = textBoxInputDelete.Text.Split(',').ToList<string>();
                lines.Remove("");
            }
            else
            {
                MessageBox.Show("Выберете папку с файлами");
            }
        }

        private void textBoxShowPath_TextChanged(object sender, EventArgs e)
        {
            _path = textBoxShowPath.Text;
        }
    }
}
