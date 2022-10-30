using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDrawObjects.Models
{
    public partial class DrawObject: ObservableObject
    {
        [ObservableProperty] private string _name;

        [ObservableProperty] private double _distance;

        [ObservableProperty] private double _angle;

        [ObservableProperty] private double _width;

        [ObservableProperty] private double _hegth;

        [ObservableProperty] private string _isDefect;

    }
}
