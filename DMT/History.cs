using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMT
{
    class History : HistoryInterface
    {
        string writePath = "HistryDMT.txt"; 
        /// <summary>
        /// Конструктор(пустой)
        /// </summary>
        public History()
        {

        } // History

        public void Save(string First, string Last)
        {
            First = First + " - " + Last;
          
            if (File.Exists(writePath))
            {
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine(First);
                    sw.Close();
                }
            }
            else
            {
                using (FileStream fs = File.Create(writePath))
                {
                    fs.Close();
                    using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.UTF8))
                    {
                        sw.WriteLine(First);
                        sw.Close();
                    }
                } 
            }
            
        } // Save

        public void Load()
        {
           
               
        } // Save

    }
}
