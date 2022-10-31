using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CsvHelper;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPFDrawObjects.Models;
using WPFDrawObjects.Services;
using CsvParser = WPFDrawObjects.Services.CsvParser;

namespace WPFDrawObjects.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject

    {
        [ObservableProperty] private ObservableCollection<DrawObject> _objectCollection;
        [ObservableProperty] private DrawObject _selectedObject;

        private ICommand _clickCommand;
        public ICommand ClickCommand { get => _clickCommand; set => SetProperty(ref _clickCommand, value); }

        public MainWindowViewModel()
    {
        var excelParser = new ExcelParser();
        ClickCommand = new RelayCommand(OpenFile);
    }
        private void OpenFile()
        {
            //открываем файл с расширением .xlsx или .csv 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|Csv files (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() != true)
                return;
            //метод по выбору парсера в зависимости от расширения выбранного файла
            ShiftExctension(openFileDialog);
            
        }
        private void ShiftExctension(OpenFileDialog openFileDialog)
        {
            var fileName = openFileDialog.FileName;

            var exctension = fileName.Substring(fileName.LastIndexOf('.'));
            if (exctension == ".xlsx")
            {
                //парсер excel 
                var excelParser = new ExcelParser();
                ObjectCollection = new ObservableCollection<DrawObject>(excelParser.Parse<DrawObject>($"{fileName}"));
            }
            else if (exctension == ".csv")
            {
                //парcер csv
                var csvParser = new CsvParser();
                ObjectCollection = new ObservableCollection<DrawObject>(csvParser.Parse<DrawObject>($"{fileName}"));
            }
            else
            {
                MessageBox.Show("файл не поддерживается");
            }
        }
    }
}
