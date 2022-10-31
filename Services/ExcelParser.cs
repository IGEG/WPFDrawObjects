using MiniExcelLibs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDrawObjects.Services
{
    /// <summary>
    /// Парсер файлов excel (библиотека MiniExcel)
    /// </summary>
    internal class ExcelParser : IParser
    {
        public IEnumerable<T> Parse<T>(string path) where T : class, new()
        {
            var records = MiniExcel.Query<T>(path);
            return records;
        }
    }
}
