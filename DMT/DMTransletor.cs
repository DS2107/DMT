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
                case "азербайджанский":

                    lp.InputLang = Lang.Az;

                    break;
                case "албанский":

                    lp.InputLang = Lang.Sq;

                    break;
                case "английский":

                    lp.InputLang = Lang.En;

                    break;
                case "арабский":
                    break;
                case "армянский":

                    lp.InputLang = Lang.Hy;

                    break;
                case "африкаанс":
                    break;
                case "баскский":
                    break;
                case "башкирский":
                    break;
                case "белорусский":

                    lp.InputLang = Lang.Be;

                    break;
                case "бенгальский":
                    break;
                case "болгарский":

                    lp.InputLang = Lang.Bg;

                    break;
                case "боснийский":
                    break;
                case "валлийский":
                    break;
                case "венгерский":

                    lp.InputLang = Lang.Hu;

                    break;
                case "вьетнамский":
                    break;
                case "гаитянский":
                    break;
                case "галисийский":
                    break;
                case "голландский":
                    break;
                case "Греческий":

                    lp.InputLang = Lang.El;

                    break;
                case "грузинский":
                    break;
                case "гуджарати":
                    break;
                case "датский":

                    lp.InputLang = Lang.Da;

                    break;
                case "иврит":
                    break;
                case "индонезийский":
                    break;
                case "ирландский":
                    break;
                case "исландский":
                    break;
                case "испанский":

                    lp.InputLang = Lang.Es;

                    break;
                case "итальянский":

                    lp.InputLang = Lang.It;

                    break;
                case "казахский":
                    break;
                case "каннада":
                    break;
                case "каталанский":

                    lp.InputLang = Lang.Ca;

                    break;
                case "киргизский":
                    break;
                case "китайский":
                    break;
                case "корейский":
                    break;
                case "латынь":
                    break;
                case "латышский":

                    lp.InputLang = Lang.Lv;

                    break;
                case "литовский":

                    lp.InputLang = Lang.Lt;

                    break;
                case "македонский":

                    lp.InputLang = Lang.Mk;

                    break;
                case "малагасийский":
                    break;
                case "малайский":
                    break;
                case "мальтийский":
                    break;
                case "монгольский":
                    break;
                case "немецкий":

                    lp.InputLang = Lang.De;

                    break;
                case "норвежский":

                    lp.InputLang = Lang.No;

                    break;
                case "панджаби":
                    break;
                case "персидский":
                    break;
                case "польский":

                    lp.InputLang = Lang.Pl;

                    break;
                case "португальский":

                    lp.InputLang = Lang.Pt;

                    break;
                case "румынский":

                    lp.InputLang = Lang.Ro;

                    break;
                case "русский":

                    lp.InputLang = Lang.Ru;

                    break;
                case "сербский":

                    lp.InputLang = Lang.Sr;

                    break;
                case "сингальский":
                    break;
                case "словацкий":

                    lp.InputLang = Lang.Sk;

                    break;
                case "словенский":

                    lp.InputLang = Lang.Sl;

                    break;
                case "суахили":
                    break;
                case "тагальский":
                    break;
                case "таджикский":
                    break;
                case "тайский":
                    break;
                case "тамильский":
                    break;
                case "татарский":
                    break;
                case "турецкий":

                    lp.InputLang = Lang.Tr;

                    break;
                case "удмуртский":
                    break;
                case "узбекский":
                    break;
                case "украинский":

                    lp.InputLang = Lang.Uk;

                    break;
                case "урду":
                    break;
                case "финский":

                    lp.InputLang = Lang.Fi;

                    break;
                case "французский":

                    lp.InputLang = Lang.Fr;

                    break;
                case "хорватский":

                    lp.InputLang = Lang.Hr;

                    break;
                case "хинди":
                    break;
                case "чешский":

                    lp.InputLang = Lang.Cs;

                    break;
                case "шведский":

                    lp.InputLang = Lang.Sv;

                    break;
                case "эльфийский (cиндарин)":
                    break;
                case "эстонский":

                    lp.InputLang = Lang.Et;

                    break;
                case "японский":
                    break;
            }

            #endregion

            #region OutputLang

            switch (outputLang)
            {
                case "азербайджанский":

                    lp.OutputLang = Lang.Az;

                    break;
                case "албанский":

                    lp.OutputLang = Lang.Sq;

                    break;
                case "английский":

                    lp.OutputLang = Lang.En;

                    break;
                case "арабский":
                    break;
                case "армянский":

                    lp.OutputLang = Lang.Hy;

                    break;
                case "африкаанс":
                    break;
                case "баскский":
                    break;
                case "башкирский":
                    break;
                case "белорусский":

                    lp.OutputLang = Lang.Be;

                    break;
                case "бенгальский":
                    break;
                case "болгарский":

                    lp.OutputLang = Lang.Bg;

                    break;
                case "боснийский":
                    break;
                case "валлийский":
                    break;
                case "венгерский":

                    lp.OutputLang = Lang.Hu;

                    break;
                case "вьетнамский":
                    break;
                case "гаитянский":
                    break;
                case "галисийский":
                    break;
                case "голландский":
                    break;
                case "Греческий":

                    lp.OutputLang = Lang.El;

                    break;
                case "грузинский":
                    break;
                case "гуджарати":
                    break;
                case "датский":

                    lp.OutputLang = Lang.Da;

                    break;
                case "иврит":
                    break;
                case "индонезийский":
                    break;
                case "ирландский":
                    break;
                case "исландский":
                    break;
                case "испанский":

                    lp.OutputLang = Lang.Es;

                    break;
                case "итальянский":

                    lp.OutputLang = Lang.It;

                    break;
                case "казахский":
                    break;
                case "каннада":
                    break;
                case "каталанский":

                    lp.OutputLang = Lang.Ca;

                    break;
                case "киргизский":
                    break;
                case "китайский":
                    break;
                case "корейский":
                    break;
                case "латынь":
                    break;
                case "латышский":

                    lp.OutputLang = Lang.Lv;

                    break;
                case "литовский":

                    lp.OutputLang = Lang.Lt;

                    break;
                case "македонский":

                    lp.OutputLang = Lang.Mk;

                    break;
                case "малагасийский":
                    break;
                case "малайский":
                    break;
                case "мальтийский":
                    break;
                case "монгольский":
                    break;
                case "немецкий":

                    lp.OutputLang = Lang.De;

                    break;
                case "норвежский":

                    lp.OutputLang = Lang.No;

                    break;
                case "панджаби":
                    break;
                case "персидский":
                    break;
                case "польский":

                    lp.OutputLang = Lang.Pl;

                    break;
                case "португальский":

                    lp.OutputLang = Lang.Pt;

                    break;
                case "румынский":

                    lp.OutputLang = Lang.Ro;

                    break;
                case "русский":

                    lp.OutputLang = Lang.Ru;

                    break;
                case "сербский":

                    lp.OutputLang = Lang.Sr;

                    break;
                case "сингальский":
                    break;
                case "словацкий":

                    lp.OutputLang = Lang.Sk;

                    break;
                case "словенский":

                    lp.OutputLang = Lang.Sl;

                    break;
                case "суахили":
                    break;
                case "тагальский":
                    break;
                case "таджикский":
                    break;
                case "тайский":
                    break;
                case "тамильский":
                    break;
                case "татарский":
                    break;
                case "турецкий":

                    lp.OutputLang = Lang.Tr;

                    break;
                case "удмуртский":
                    break;
                case "узбекский":
                    break;
                case "украинский":

                    lp.OutputLang = Lang.Uk;

                    break;
                case "урду":
                    break;
                case "финский":

                    lp.OutputLang = Lang.Fi;

                    break;
                case "французский":

                    lp.OutputLang = Lang.Fr;

                    break;
                case "хорватский":

                    lp.OutputLang = Lang.Hr;

                    break;
                case "хинди":
                    break;
                case "чешский":

                    lp.OutputLang = Lang.Cs;

                    break;
                case "шведский":

                    lp.OutputLang = Lang.Sv;

                    break;
                case "эльфийский (cиндарин)":
                    break;
                case "эстонский":

                    lp.OutputLang = Lang.Et;

                    break;
                case "японский":
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
