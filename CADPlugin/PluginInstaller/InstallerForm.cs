using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginInstaller
{
    public partial class InstallerForm : Form
    {
        #region Private Members

        /// <summary>
        /// Название утилиты RegAsm
        /// </summary>
        private const string _regAsmFilename = "RegAsm.exe";

        /// <summary>
        /// Папка NET Framework 64-битной версии
        /// </summary>
        private string _regAsmWindowsPath = "Microsoft.NET\\Framework64";

        #endregion

        #region Constructor

        /// <summary>
        /// Конструктор
        /// </summary>
        public InstallerForm()
        {
            InitializeComponent();

            LocateRegAsm();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Проверка наличия SolidWorks, regasm и плагина
        /// </summary>
        /// <returns></returns>
        private bool SanityCheck()
        {
            // Проверка наличия RegAsm
            if (string.IsNullOrEmpty(RegAsmPath.Text) || !File.Exists(RegAsmPath.Text))
            {
                MessageBox.Show("Please specify a path to a valid RegAsm application", "No RegAsm found");
                return false;
            }

            // Проверка DLL
            if (string.IsNullOrEmpty(DllPath.Text) || !File.Exists(DllPath.Text))
            {
                MessageBox.Show("Please specify a path to a valid SolidWorks Plugin dll", "No Add-in found");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Пытается найти RegAsm и установить его в качестве пути
        /// </summary>
        private void LocateRegAsm()
        {
            // Locate SolidWorks exe in Program Files
            var results = new List<string>();
            FindByFilename(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), _regAsmWindowsPath), null, _regAsmFilename, results);

            // If we have at least one, use the last one (so newest version)
            if (results?.Count > 0)
                RegAsmPath.Text = results.Last();
        }

        /// <summary>
        /// Находит все файлы, которые совпадают с шаблоном поиска
        /// Ищет рекурсивно
        /// </summary>
        /// <param name="path">Путь, в пределах которого проводится поиск</param>
        /// <param name="pathContains">Путь, согласно которому поиск проходит ниже по дереву</param>
        /// <param name="filename">Название нужного файла</param>
        /// <param name="results">Найденные результаты</param>
        /// <returns></returns>
        private void FindByFilename(string path, string pathContains, string filename, List<string> results = null)
        {
            // Создать новый список, если на вход ничего не пришло
            if (results == null)
                results = new List<string>();

            // Получить все файлы в текущей папке
            try
            {
                var files = Directory.EnumerateFiles(path).Where(f => string.Equals(Path.GetFileName(f), filename, StringComparison.InvariantCultureIgnoreCase)).ToList();
                if (files?.Count > 0)
                    results.AddRange(files);
            }
            catch
            {
                // ignored
            }

            // Поиск по всем подпапкам
            try
            {
                pathContains = pathContains?.ToLower();

                // Поиск в подходящих директориях
                Directory.EnumerateDirectories(path).Where(f => string.IsNullOrEmpty(pathContains) || f.ToLower().Contains(pathContains)).ToList().ForEach(dir => FindByFilename(dir, null, filename, results));
            }
            catch
            {
                // ignored
            }
        }



        #endregion

        #region Handlers

        private void RegAsmBrowseButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = $"RegAsm | {_regAsmFilename}",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Windows)
            };
            var result = ofd.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            // If they selected a file, use that
            RegAsmPath.Text = ofd.FileName;
        }

        private void DllBrowseButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = $"Add-in Dll | *.dll",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            var result = ofd.ShowDialog();

            if (result == DialogResult.Cancel)
                return;
            DllPath.Text = ofd.FileName;
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            if (!SanityCheck())
                return;

            // Запуск RegAsm с путем к DLL в качестве аргумента
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = RegAsmPath.Text,
                    Arguments = $"/codebase \"{DllPath.Text}\"",
                    // Запуск от админа
                    Verb = "runas",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();

            var result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            if (process.ExitCode == 0)
                MessageBox.Show("Add-in was successfully registered", "Success");
            else
                MessageBox.Show(result, "Unexpected Response", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void UninstallButton_Click(object sender, EventArgs e)
        {
            if (!SanityCheck())
                return;

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = RegAsmPath.Text,
                    Arguments = $"/u \"{DllPath.Text}\"",
                    Verb = "runas",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();

            var result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            if (process.ExitCode == 0)
                MessageBox.Show("Add-in was successfully unregistered", "Success");
            else
                MessageBox.Show(result, "Unexpected Response", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion


    }
}
