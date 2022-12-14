using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDrawObjects.Services
{
    /// <summary>
    /// Интерфейс для всех парсеров
    /// </summary>
    public interface IParser
    {
        IEnumerable<T> Parse<T>(string path) where T : class, new();
    }
}
