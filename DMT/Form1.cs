using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DMT
{
    public partial class Form1 : Form
    {
        public static Form1 Instance { get; private set; } // тут будет форма
        ComboBox cb;
        DMTransletor dm;
        History history = new History();
        public Form1()
        {
            InitializeComponent();
            if (File.Exists("HistryDMT.txt"))
            {
                var lines = File.ReadAllLines("HistryDMT.txt",Encoding.UTF8);

                foreach (var str in lines)
                {

                    listBox1.Items.Add(str);
                }
            } // if
       
        dm = new DMTransletor();
           
          
            // При запуске программы ComboBox Будут не пустые 
            CB_FirstLang.SelectedItem = "русский";
            CB_LastLang.SelectedItem = "английский";

            // КомбоБокс для замены 
            cb = new ComboBox();

            cb.Items.AddRange(new object[]
            {
            "азербайджанский",
            "албанский",
            "амхарский\t",
            "английский",
            "арабский",
            "армянский",
            "африкаанс",
            "баскский",
            "башкирский",
            "белорусский",
            "бенгальский",
            "бирманский",
            "болгарский",
            "боснийский",
            "валлийский",
            "венгерский",
            "вьетнамский",
            "гаитянский (креольский)\t",
            "галисийский",
            "голландский",
            "горномарийский",
            "греческий",
            "грузинский",
            "гуджарати",
            "датский",
            "иврит",
            "идиш",
            "индонезийский",
            "ирландский",
            "итальянский",
            "исландский",
            "испанский",
            "казахский",
            "каннада",
            "каталанский",
            "киргизский",
            "китайский",
            "корейский",
            "коса",
            "кхмерский",
            "лаосский",
            "латынь",
            "латышский",
            "литовский",
            "люксембургский",
            "малагасийский",
            "малайский",
            "малаялам",
            "мальтийский",
            "македонский",
            "маори",
            "маратхи",
            "марийский",
            "монгольский",
            "немецкий",
            "непальский",
            "норвежский\t",
            "панджаби",
            "папьяменто",
            "персидский",
            "польский",
            "португальский",
            "румынский",
            "русский",
            "себуанский",
            "сербский",
            "сингальский\t",
            "словацкий",
            "словенский\t",
            "суахили",
            "сунданский",
            "таджикский",
            "тайский",
            "тагальский",
            "тамильский",
            "татарский",
            "телугу",
            "турецкий\t",
            "удмуртский\t",
            "узбекский",
            "украинский",
            "урду",
            "финский",
            "французский",
            "хинди",
            "хорватский",
            "чешский",
            "шведский",
            "шотландский",
            "эстонский",
            "эсперанто\t",
            "яванский\t",
            "японский"
            });
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();

        } // CloseBut_Click

        private void MinimBut_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        } // MinimBut_Click

        private void RussinButton_Click(object sender, EventArgs e)
        {
            CB_FirstLang.SelectedItem = "русский";
        } // RussinButton_Click

        private void BT_England_Click(object sender, EventArgs e)
        {
            CB_FirstLang.SelectedItem = "английский";
        } // BT_England_Click

        private void BT_russianLast_Click(object sender, EventArgs e)
        {
            CB_LastLang.SelectedItem = "русский";
        } // BT_russianLast_Click

        private void BT_EnglandLast_Click(object sender, EventArgs e)
        {
            CB_LastLang.SelectedItem = "английский";

        } // BT_EnglandLast_Click

        private void BT_Reset_Click(object sender, EventArgs e)
        {
            cb.SelectedItem = CB_LastLang.SelectedItem;

            CB_LastLang.SelectedItem = CB_FirstLang.SelectedItem;

            CB_FirstLang.SelectedItem = cb.SelectedItem;
        } // BT_Reset_Click

        private void BT_Translete_Click(object sender, EventArgs e)
        {
            TB_LastText.Clear();

            TB_LastText.Text = dm.Translator(TB_FirstText.Text, dm.GetPair(CB_FirstLang.SelectedItem.ToString(), CB_LastLang.SelectedItem.ToString()));
            history.Save(TB_FirstText.Text, TB_LastText.Text);

            if (File.Exists("HistryDMT.txt"))
            {
                var lines = File.ReadAllLines("HistryDMT.txt", Encoding.UTF8);
                listBox1.Items.Clear();
                foreach (var str in lines)
                {

                    listBox1.Items.Add(str);
                }
            } // if
        } // BT_Translete_Click

        private void TB_FirstText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TB_LastText.Clear();

                TB_LastText.Text = dm.Translator(TB_FirstText.Text, dm.GetPair(CB_FirstLang.SelectedItem.ToString(), CB_LastLang.SelectedItem.ToString()));
                history.Save(TB_FirstText.Text, TB_LastText.Text);

                if (File.Exists("HistryDMT.txt"))
                {
                    var lines = File.ReadAllLines("HistryDMT.txt", Encoding.UTF8);
                    listBox1.Items.Clear();
                    foreach (var str in lines)
                    {

                        listBox1.Items.Add(str);
                    }
                } // if

            } // if
        } // TB_FirstText_KeyDown
    }
}
