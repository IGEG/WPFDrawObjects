using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDrawObjects.Services
{
    public class ScaleService
    {
        private int _scale = 20;

        public double Scale(double number)
        {
            return number * _scale;
        }
    }
}
