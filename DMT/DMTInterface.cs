using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexLinguistics.NET;

namespace DMT
{
    interface DMTInterface
    {
       /// <summary>
       /// Определение языка
       /// </summary>
       /// <param name="inputLang">Первый язык</param>
       /// <param name="outputLang">Второй язык</param>
       /// <returns></returns>
       LangPair GetPair(string inputLang, string outputLang);



       /// <summary>
       /// Перевод
       /// </summary>
       /// <param name="wordTotranslete">Текст, который надо перевести</param>
       /// <param name="lang">Язык на который надо перевести</param>
       /// <returns></returns>
       string Translator(string wordTotranslete, LangPair lang);




    }
}
