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
        private string _path;
        private List<string> _files;

        public StartMenu()
        {
            _path = string.Empty;
            _files = new List<string>();
            InitializeComponent();
        }

        private void Initialize()
        {
            _path = GetDirectory();
            if (_path != string.Empty)
            {
                _files = Directory.GetFiles(_path, "*.txt").ToList<string>();
                if (_files.Count == 0)
                {
                    MessageBox.Show($"Файлов с расширением txt в папке {_path} - нет.");
                }
                else
                {
                    textBoxShowPath.Text = _path;
                }
            }
        }

        private string GetDirectory()
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            browserDialog.Description = "Выберете папку";
            browserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            browserDialog.ShowNewFolderButton = true;
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                return browserDialog.SelectedPath;
            }
            else
            {
                return string.Empty;
            }
        }

        private void ReplaceFiles(string wordOld, string wordNew)
        {
            bool isReplaced = false;
            for (int i = 0; i < _files.Count; i++)
            {
                string text = File.ReadAllText(_files[i]);
                if (text != string.Empty)
                {
                    if (text.Contains(wordOld))
                    {
                        text = text.Replace(wordOld, wordNew);
                        isReplaced = true;
                    }

                    if (isReplaced)
                    {
                        while (text.Contains("  "))
                        {
                            text = text.Replace("  ", " ");
                        }
                        text = text.Trim();
                        File.Delete(_files[i]);
                        using (StreamWriter stream = new StreamWriter(File.OpenWrite(_files[i])))
                        {
                            stream.WriteAsync(text).Wait();
                        }
                        isReplaced = false;
                    }
                }
            }
        }

        private void SplitAndReplace()
        {
            if (_path != string.Empty && _files.Count != 0)
            {
                string wordNew = textBoxInputNew.Text;
                string wordOld = textBoxInputOld.Text;
                ReplaceFiles(wordOld, wordNew);
                labelDone.Visible = true;
            }
            else if (Directory.Exists(_path) == false)
            {
                MessageBox.Show("Папки по такому пути - нет");
            }
            else
            {
                MessageBox.Show("Выберете папку с файлами");
            }
        }

        private void buttonBrowser_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SplitAndReplace();
        }

        private void textBoxShowPath_TextChanged(object sender, EventArgs e)
        {
            _path = textBoxShowPath.Text;
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            SplitAndReplace();
        }

        private void textBoxInputOld_TextChanged(object sender, EventArgs e)
        {
            labelDone.Visible = false;
        }
    }
}
