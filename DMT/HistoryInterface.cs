using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMT
{
    interface HistoryInterface
    {
        /// <summary>
        /// Сохранения текста 
        /// </summary>
        /// <param name="First"></param>
        /// <param name="Last"></param>
        void Save(string First, string Last);

        /// <summary>
        /// Загрузка текста 
        /// </summary>
        void Load();
    }
}
