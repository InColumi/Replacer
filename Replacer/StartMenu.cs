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
        private List<string> _fileNames;

        public StartMenu()
        {
            _path = string.Empty;
            _files = new List<string>();
            _fileNames = new List<string>();
            InitializeComponent();
        }

        private void Initialize()
        {
            _path = GetDirectory();
            if (_path != string.Empty)
            {
                SetFiles();
                textBoxShowPath.Text = _path;
                SetNameFiles();
            }
        }

        private void ClearVariable()
        {
            _path = string.Empty;
            _files.Clear();
            _fileNames.Clear();
        }

        private void ClearInterface()
        {
            textBoxShowPath.Clear();
            textBoxInputDelete.Clear();
            listBoxChanges.Items.Clear();
        }

        private void SetNameFiles()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(_path);
            var files = directoryInfo.GetFiles("*.txt");
            foreach (var file in files)
            {
                _fileNames.Add(file.Name);
            }
        }

        private void SetFiles()
        {
            _files = Directory.GetFiles(_path, "*.txt").ToList<string>();
            if (_files.Count == 0)
            {
                MessageBox.Show($"Файлов с расширением txt в папке {_path} - нет.");
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

        private string DeleteWord(string word, string text)
        {
            return text.Replace(word, string.Empty);
        }

        private string ReplaceWord(string word, string text)
        {
            string[] forRaplace = word.Split('#');
            return text.Replace(forRaplace[0], forRaplace[1]);
        }

        private void ReplaceFiles(List<string> words, Func<string, string, string> func)
        {
            listBoxChanges.Items.Clear();
            bool isContains = false;
            for (int i = 0; i < _files.Count; i++)
            {
                string text = File.ReadAllText(_files[i]);
                if (text != string.Empty)
                {
                    foreach (var word in words)
                    {
                        if (text.Contains(word.Split('#')[0]))
                        {
                            text = func(word, text);
                            isContains = true;
                        }
                    }
                    if (isContains)
                    {
                        while (text.Contains("  "))
                        {
                            text = text.Replace("  ", " ");
                        }
                        File.Delete(_files[i]);
                        using (StreamWriter stream = new StreamWriter(File.OpenWrite(_files[i])))
                        {
                            stream.WriteAsync(text).Wait();
                        }

                        listBoxChanges.Items.Add(_fileNames[i]);
                        isContains = false;
                    }
                }
            }
        }

        private void SplitAndReplace()
        {
            if (_path != string.Empty && _files.Count != 0)
            {
                List<string> words;
                if (tabControl.SelectedTab.Text == "Удаление")
                {
                    words = textBoxInputDelete.Text.Split(',').ToList<string>();
                    ReplaceFiles(words, DeleteWord);
                    words.Remove("");
                }
                else if (tabControl.SelectedTab.Text == "Замена")
                {
                    words = textBoxInputReplace.Text.Split(',').ToList<string>();
                    words.Remove("");
                    ReplaceFiles(words, ReplaceWord);
                }
                else
                {
                    throw new Exception("Check tabContol");
                }
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
            ClearVariable();
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

        private void textBoxInputReplace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Text == "Удаление")
            {
                labelExample.Text = "Пример: слово1,слово2,слово3,слово4,слово5";
            }
            else if (tabControl.SelectedTab.Text == "Замена")
            {
                labelExample.Text = "Пример: слово1#слово2,слово3#слово4,слово5#слово6";
            }
        }
    }
}
