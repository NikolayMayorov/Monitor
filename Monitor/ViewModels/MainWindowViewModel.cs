using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string FileName
        {
            get => _fileName;
            set
            {
                _fileName = value;
               RaisePropertyChanged();
            }
        }
        public RelayCommand OpenFileProgram { get; }



        #region private
        public string _fileName;
        #endregion

        public MainWindowViewModel()
        {
            OpenFileProgram = new RelayCommand(OnOpenFileProgram);
        }

        private void OnOpenFileProgram()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                FileName = openFileDialog.FileName;
                using (FileStream fstream = File.OpenRead(openFileDialog.FileName))
                {
                    byte[] array = new byte[fstream.Length];
                    fstream.Read(array, 0, array.Length);

      
                }
            }
        }
    }
}
