using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexLinguistics.NET;


namespace DMT
{
    class DMTransletor:DMTInterface
    {
        YandexLinguistics.NET.Translator tr;
   
        // Ключ ApiYandex
        const string ApiToken = "trnsl.1.1.20200426T145914Z.d3076815a23656e8.c870458b55ce817bc753f9ed9bece941e53bc9aa";
        
        /// <summary>
        /// Конструктор ьез параметров который получает Ключ и проверяет 
        /// </summary>
        public DMTransletor()
        {
            tr = new YandexLinguistics.NET.Translator(ApiToken);

        } // DMTransletor


        /// <summary>
        /// Выбор языка
        /// </summary>
        /// <param name="inputLang"></param>
        /// <param name="outputLang"></param>
        /// <returns></returns>
        public LangPair GetPair(string inputLang, string outputLang)
        {
            LangPair lp = new LangPair();

            #region InputLang

            switch (inputLang)
            {
              
                case "английский":

                    lp.InputLang = Lang.En;

                    break;              
                case "белорусский":

                    lp.InputLang = Lang.Be;

                    break;
               
                case "русский":

                    lp.InputLang = Lang.Ru;

                    break;
               
                case "украинский":

                    lp.InputLang = Lang.Uk;

                    break;
              
                case "французский":

                    lp.InputLang = Lang.Fr;

                    break;
             
            }

            #endregion

            #region OutputLang

            switch (outputLang)
            {
                case "английский":

                    lp.OutputLang = Lang.En;

                    break;
                case "белорусский":

                    lp.OutputLang = Lang.Be;

                    break;

                case "русский":

                    lp.OutputLang = Lang.Ru;

                    break;

                case "украинский":

                    lp.OutputLang = Lang.Uk;

                    break;

                case "французский":

                    lp.OutputLang = Lang.Fr;

                    break;
            }

            #endregion

            return lp;
        } // 

        /// <summary>
        /// Выполнение перевода
        /// </summary>
        /// <param name="wordTotranslete">Текст для перевода</param>
        /// <param name="lang">Определенный язык</param>
        /// <returns></returns>
        public string Translator(string wordTotranslete,LangPair lang)
        {
            // Вернуть текст
            return tr.Translate(wordTotranslete, lang).Text;
            
        } // translator

    }
}
