using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Printing.IndexedProperties;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Diagnostics;
using System.Windows.Input;
using Microsoft.Win32;
using ToolDev.Models;

namespace ToolDev.ViewModels
{
    /// <summary>
    /// This class handles the opening, loading, new and recent of documents via the text editor
    /// </summary>
    public class FileViewModel
    {
        public DocumentModel Document { get; private set; }

        public ICommand NewCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand OpenCommand { get; }
        public ICommand RecentCommand { get; }
        public ICommand ExitCommand { get; }

        private List<string> RecentFilesList = new List<string>();

        public FileViewModel(DocumentModel document)
        {
            Document = document;

            NewCommand = new RelayCommand(NewFile);
            SaveCommand = new RelayCommand(SaveFile);
            OpenCommand = new RelayCommand(OpenFile);
            RecentCommand = new RelayCommand(RecentFiles);
            ExitCommand = new RelayCommand(ExitProgram);
        }

        private void ExitProgram()
        {
            Application.Current.Shutdown();
        }

        private void NewFile()
        {
            Document.FileName = string.Empty;
            Document.FilePath = string.Empty;
            Document.Text = string.Empty;
        }
       
        private void OpenFile()
        {
            var openDialog = new OpenFileDialog();
            openDialog.Filter = "Binary Files (*.bin)|*.bin|All files(*.*)|*.*";
            openDialog.FilterIndex = 2;

            if (openDialog.ShowDialog() == true)
            {
                DockFile(openDialog);
                if (openDialog.FileName != "")
                {
                    using (FileStream fs = new FileStream(openDialog.FileName, FileMode.Open))
                    {
                        using (BinaryReader br = new BinaryReader(fs))
                        {
                            if (br.BaseStream.Length >= 1)
                            {
                                Document.Text = br.ReadString();
                            }
                        }
                    }

                    AddRecentFiles(openDialog.FileName);
                }
                else
                {
                    string message = "File does not exits";
                    MessageBox.Show(message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void SaveFile()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary Files (*.bin)|*.bin|All files(*.*)|*.*";
            saveFileDialog.FilterIndex = 1;

            if (saveFileDialog.ShowDialog() == true)
            {
                DockFile(saveFileDialog);

                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    using (BinaryWriter bw = new BinaryWriter(fs))
                    {
                        bw.Write(Document.Text);
                    }
                }
            }
        }


        //generic to save file's properties (name and filepath)
        private void DockFile<T>(T dialog) where T : FileDialog
        {
            Document.FilePath = dialog.FileName;
            Document.FileName = dialog.SafeFileName;
        }

        private void AddRecentFiles(string files)
        {
            if (RecentFilesList != null)
            {
                RecentFilesList.Add(files);
            }
        }

        private void RecentFiles()
        {
            if (RecentFilesList.Count != 0)
            {
                var message = string.Join(Environment.NewLine, RecentFilesList);
                MessageBox.Show(message, "Recent Files Accessed At:", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("No recent files accessed", "Recent Files", MessageBoxButton.OK);
            }
        }
    }
}
