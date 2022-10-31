using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDrawObjects.Services
{
    /// <summary>
    /// Парсер файлов csv (библиотека CsvHelper)
    /// </summary>
    internal class CsvParser : IParser
    {
        private CsvConfiguration _config = new(CultureInfo.CurrentCulture)
        {
            Delimiter = ";"
          
            
        };
        public IEnumerable<T> Parse<T>(string path) where T : class, new()
        {
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, _config);
            var records = csv.GetRecords<T>().ToList();

            return records;
        }
    }
}
