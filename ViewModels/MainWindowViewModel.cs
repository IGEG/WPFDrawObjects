using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDrawObjects.Models;
using WPFDrawObjects.Services;

namespace WPFDrawObjects.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject

    {
        [ObservableProperty] private ObservableCollection<DrawObject> _objectCollection;
        [ObservableProperty] private DrawObject _selectedObject;

    public MainWindowViewModel()
    {
        var excelParser = new ExcelParser();
        var csvParser = new CsvParser();
        ObjectCollection = new ObservableCollection<DrawObject>(csvParser.Parse<DrawObject>(@"C:\Users\igor1\Desktop\Тест C#\objects.csv"));
    }
}
}
