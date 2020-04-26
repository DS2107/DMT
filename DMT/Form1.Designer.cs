namespace DMT
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTag = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MinimBut = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CloseBut = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.CB_FirstLang = new System.Windows.Forms.ComboBox();
            this.BT_russianLast = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BT_England = new Bunifu.Framework.UI.BunifuThinButton2();
            this.RussinButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BT_EnglandLast = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BT_Translete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TB_FirstText = new Bunifu.Framework.BunifuCustomTextbox();
            this.TB_LastText = new Bunifu.Framework.BunifuCustomTextbox();
            this.CB_LastLang = new System.Windows.Forms.ComboBox();
            this.BT_Reset = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelTag);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 42);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DMT.Properties.Resources.Title1;
            this.pictureBox1.Location = new System.Drawing.Point(76, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTag.ForeColor = System.Drawing.Color.LightGray;
            this.labelTag.Location = new System.Drawing.Point(12, 9);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(58, 26);
            this.labelTag.TabIndex = 2;
            this.labelTag.Text = "DMT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.MinimBut);
            this.panel2.Controls.Add(this.CloseBut);
            this.panel2.Location = new System.Drawing.Point(127, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 42);
            this.panel2.TabIndex = 1;
            // 
            // MinimBut
            // 
            this.MinimBut.ActiveBorderThickness = 1;
            this.MinimBut.ActiveCornerRadius = 3;
            this.MinimBut.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.MinimBut.ActiveForecolor = System.Drawing.Color.White;
            this.MinimBut.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.MinimBut.BackColor = System.Drawing.Color.SteelBlue;
            this.MinimBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimBut.BackgroundImage")));
            this.MinimBut.ButtonText = " _";
            this.MinimBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimBut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimBut.ForeColor = System.Drawing.Color.SeaGreen;
            this.MinimBut.IdleBorderThickness = 1;
            this.MinimBut.IdleCornerRadius = 20;
            this.MinimBut.IdleFillColor = System.Drawing.Color.Transparent;
            this.MinimBut.IdleForecolor = System.Drawing.Color.Maroon;
            this.MinimBut.IdleLineColor = System.Drawing.Color.Transparent;
            this.MinimBut.Location = new System.Drawing.Point(800, 8);
            this.MinimBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimBut.Name = "MinimBut";
            this.MinimBut.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.MinimBut.Size = new System.Drawing.Size(24, 25);
            this.MinimBut.TabIndex = 13;
            this.MinimBut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MinimBut.Click += new System.EventHandler(this.MinimBut_Click);
            // 
            // CloseBut
            // 
            this.CloseBut.ActiveBorderThickness = 1;
            this.CloseBut.ActiveCornerRadius = 3;
            this.CloseBut.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.CloseBut.ActiveForecolor = System.Drawing.Color.White;
            this.CloseBut.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.CloseBut.BackColor = System.Drawing.Color.SteelBlue;
            this.CloseBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseBut.BackgroundImage")));
            this.CloseBut.ButtonText = "X";
            this.CloseBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBut.ForeColor = System.Drawing.Color.SeaGreen;
            this.CloseBut.IdleBorderThickness = 1;
            this.CloseBut.IdleCornerRadius = 20;
            this.CloseBut.IdleFillColor = System.Drawing.Color.Transparent;
            this.CloseBut.IdleForecolor = System.Drawing.Color.Maroon;
            this.CloseBut.IdleLineColor = System.Drawing.Color.Transparent;
            this.CloseBut.Location = new System.Drawing.Point(832, 8);
            this.CloseBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.CloseBut.Size = new System.Drawing.Size(24, 25);
            this.CloseBut.TabIndex = 12;
            this.CloseBut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel2;
            this.bunifuDragControl2.Vertical = true;
            // 
            // CB_FirstLang
            // 
            this.CB_FirstLang.FormattingEnabled = true;
            this.CB_FirstLang.Items.AddRange(new object[] {
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
            "японский"});
            this.CB_FirstLang.Location = new System.Drawing.Point(6, 305);
            this.CB_FirstLang.Name = "CB_FirstLang";
            this.CB_FirstLang.Size = new System.Drawing.Size(205, 21);
            this.CB_FirstLang.TabIndex = 2;
            // 
            // BT_russianLast
            // 
            this.BT_russianLast.ActiveBorderThickness = 1;
            this.BT_russianLast.ActiveCornerRadius = 20;
            this.BT_russianLast.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BT_russianLast.ActiveForecolor = System.Drawing.Color.White;
            this.BT_russianLast.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BT_russianLast.BackColor = System.Drawing.Color.White;
            this.BT_russianLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_russianLast.BackgroundImage")));
            this.BT_russianLast.ButtonText = "Русский";
            this.BT_russianLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_russianLast.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_russianLast.ForeColor = System.Drawing.Color.SeaGreen;
            this.BT_russianLast.IdleBorderThickness = 1;
            this.BT_russianLast.IdleCornerRadius = 10;
            this.BT_russianLast.IdleFillColor = System.Drawing.Color.White;
            this.BT_russianLast.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BT_russianLast.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BT_russianLast.Location = new System.Drawing.Point(568, 53);
            this.BT_russianLast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BT_russianLast.Name = "BT_russianLast";
            this.BT_russianLast.Size = new System.Drawing.Size(184, 37);
            this.BT_russianLast.TabIndex = 4;
            this.BT_russianLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BT_russianLast.Click += new System.EventHandler(this.BT_russianLast_Click);
            // 
            // BT_England
            // 
            this.BT_England.ActiveBorderThickness = 1;
            this.BT_England.ActiveCornerRadius = 20;
            this.BT_England.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BT_England.ActiveForecolor = System.Drawing.Color.White;
            this.BT_England.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BT_England.BackColor = System.Drawing.Color.White;
            this.BT_England.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_England.BackgroundImage")));
            this.BT_England.ButtonText = "Английский";
            this.BT_England.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_England.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_England.ForeColor = System.Drawing.Color.SeaGreen;
            this.BT_England.IdleBorderThickness = 1;
            this.BT_England.IdleCornerRadius = 10;
            this.BT_England.IdleFillColor = System.Drawing.Color.White;
            this.BT_England.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BT_England.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BT_England.Location = new System.Drawing.Point(246, 53);
            this.BT_England.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BT_England.Name = "BT_England";
            this.BT_England.Size = new System.Drawing.Size(184, 37);
            this.BT_England.TabIndex = 5;
            this.BT_England.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BT_England.Click += new System.EventHandler(this.BT_England_Click);
            // 
            // RussinButton
            // 
            this.RussinButton.ActiveBorderThickness = 1;
            this.RussinButton.ActiveCornerRadius = 20;
            this.RussinButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.RussinButton.ActiveForecolor = System.Drawing.Color.White;
            this.RussinButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.RussinButton.BackColor = System.Drawing.Color.White;
            this.RussinButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RussinButton.BackgroundImage")));
            this.RussinButton.ButtonText = "Русский";
            this.RussinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RussinButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RussinButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.RussinButton.IdleBorderThickness = 1;
            this.RussinButton.IdleCornerRadius = 10;
            this.RussinButton.IdleFillColor = System.Drawing.Color.White;
            this.RussinButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.RussinButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.RussinButton.Location = new System.Drawing.Point(6, 53);
            this.RussinButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RussinButton.Name = "RussinButton";
            this.RussinButton.Size = new System.Drawing.Size(184, 37);
            this.RussinButton.TabIndex = 6;
            this.RussinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RussinButton.Click += new System.EventHandler(this.RussinButton_Click);
            // 
            // BT_EnglandLast
            // 
            this.BT_EnglandLast.ActiveBorderThickness = 1;
            this.BT_EnglandLast.ActiveCornerRadius = 20;
            this.BT_EnglandLast.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BT_EnglandLast.ActiveForecolor = System.Drawing.Color.White;
            this.BT_EnglandLast.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BT_EnglandLast.BackColor = System.Drawing.Color.White;
            this.BT_EnglandLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_EnglandLast.BackgroundImage")));
            this.BT_EnglandLast.ButtonText = "Английский";
            this.BT_EnglandLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_EnglandLast.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_EnglandLast.ForeColor = System.Drawing.Color.SeaGreen;
            this.BT_EnglandLast.IdleBorderThickness = 1;
            this.BT_EnglandLast.IdleCornerRadius = 10;
            this.BT_EnglandLast.IdleFillColor = System.Drawing.Color.White;
            this.BT_EnglandLast.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BT_EnglandLast.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BT_EnglandLast.Location = new System.Drawing.Point(808, 53);
            this.BT_EnglandLast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BT_EnglandLast.Name = "BT_EnglandLast";
            this.BT_EnglandLast.Size = new System.Drawing.Size(184, 37);
            this.BT_EnglandLast.TabIndex = 7;
            this.BT_EnglandLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BT_EnglandLast.Click += new System.EventHandler(this.BT_EnglandLast_Click);
            // 
            // BT_Translete
            // 
            this.BT_Translete.Active = false;
            this.BT_Translete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BT_Translete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BT_Translete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Translete.BorderRadius = 0;
            this.BT_Translete.ButtonText = "Превод";
            this.BT_Translete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_Translete.DisabledColor = System.Drawing.Color.Gray;
            this.BT_Translete.Iconcolor = System.Drawing.Color.Transparent;
            this.BT_Translete.Iconimage = ((System.Drawing.Image)(resources.GetObject("BT_Translete.Iconimage")));
            this.BT_Translete.Iconimage_right = null;
            this.BT_Translete.Iconimage_right_Selected = null;
            this.BT_Translete.Iconimage_Selected = null;
            this.BT_Translete.IconMarginLeft = 0;
            this.BT_Translete.IconMarginRight = 0;
            this.BT_Translete.IconRightVisible = true;
            this.BT_Translete.IconRightZoom = 0D;
            this.BT_Translete.IconVisible = true;
            this.BT_Translete.IconZoom = 90D;
            this.BT_Translete.IsTab = false;
            this.BT_Translete.Location = new System.Drawing.Point(861, 390);
            this.BT_Translete.Name = "BT_Translete";
            this.BT_Translete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BT_Translete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BT_Translete.OnHoverTextColor = System.Drawing.Color.White;
            this.BT_Translete.selected = false;
            this.BT_Translete.Size = new System.Drawing.Size(117, 48);
            this.BT_Translete.TabIndex = 8;
            this.BT_Translete.Text = "Превод";
            this.BT_Translete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Translete.Textcolor = System.Drawing.Color.White;
            this.BT_Translete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Translete.Click += new System.EventHandler(this.BT_Translete_Click);
            // 
            // TB_FirstText
            // 
            this.TB_FirstText.BorderColor = System.Drawing.Color.SeaGreen;
            this.TB_FirstText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_FirstText.Location = new System.Drawing.Point(6, 89);
            this.TB_FirstText.Multiline = true;
            this.TB_FirstText.Name = "TB_FirstText";
            this.TB_FirstText.Size = new System.Drawing.Size(424, 210);
            this.TB_FirstText.TabIndex = 9;
            // 
            // TB_LastText
            // 
            this.TB_LastText.BorderColor = System.Drawing.Color.SeaGreen;
            this.TB_LastText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_LastText.Location = new System.Drawing.Point(568, 89);
            this.TB_LastText.Multiline = true;
            this.TB_LastText.Name = "TB_LastText";
            this.TB_LastText.Size = new System.Drawing.Size(424, 210);
            this.TB_LastText.TabIndex = 10;
            // 
            // CB_LastLang
            // 
            this.CB_LastLang.FormattingEnabled = true;
            this.CB_LastLang.Items.AddRange(new object[] {
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
            "японский"});
            this.CB_LastLang.Location = new System.Drawing.Point(568, 305);
            this.CB_LastLang.Name = "CB_LastLang";
            this.CB_LastLang.Size = new System.Drawing.Size(205, 21);
            this.CB_LastLang.TabIndex = 12;
            // 
            // BT_Reset
            // 
            this.BT_Reset.ActiveBorderThickness = 1;
            this.BT_Reset.ActiveCornerRadius = 20;
            this.BT_Reset.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.BT_Reset.ActiveForecolor = System.Drawing.Color.White;
            this.BT_Reset.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.BT_Reset.BackColor = System.Drawing.Color.White;
            this.BT_Reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Reset.BackgroundImage")));
            this.BT_Reset.ButtonText = "Поменять языки";
            this.BT_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_Reset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Reset.ForeColor = System.Drawing.Color.SeaGreen;
            this.BT_Reset.IdleBorderThickness = 1;
            this.BT_Reset.IdleCornerRadius = 5;
            this.BT_Reset.IdleFillColor = System.Drawing.Color.White;
            this.BT_Reset.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BT_Reset.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BT_Reset.Location = new System.Drawing.Point(437, 151);
            this.BT_Reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BT_Reset.Name = "BT_Reset";
            this.BT_Reset.Size = new System.Drawing.Size(124, 63);
            this.BT_Reset.TabIndex = 13;
            this.BT_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BT_Reset.Click += new System.EventHandler(this.BT_Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(996, 450);
            this.Controls.Add(this.BT_Reset);
            this.Controls.Add(this.CB_LastLang);
            this.Controls.Add(this.TB_LastText);
            this.Controls.Add(this.TB_FirstText);
            this.Controls.Add(this.BT_Translete);
            this.Controls.Add(this.BT_EnglandLast);
            this.Controls.Add(this.RussinButton);
            this.Controls.Add(this.BT_England);
            this.Controls.Add(this.BT_russianLast);
            this.Controls.Add(this.CB_FirstLang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.ComboBox CB_FirstLang;
        private Bunifu.Framework.UI.BunifuFlatButton BT_Translete;
        private Bunifu.Framework.UI.BunifuThinButton2 BT_EnglandLast;
        private Bunifu.Framework.UI.BunifuThinButton2 RussinButton;
        private Bunifu.Framework.UI.BunifuThinButton2 BT_England;
        private Bunifu.Framework.UI.BunifuThinButton2 BT_russianLast;
        private Bunifu.Framework.BunifuCustomTextbox TB_LastText;
        private Bunifu.Framework.BunifuCustomTextbox TB_FirstText;
        private Bunifu.Framework.UI.BunifuThinButton2 CloseBut;
        private Bunifu.Framework.UI.BunifuThinButton2 MinimBut;
        private System.Windows.Forms.ComboBox CB_LastLang;
        private Bunifu.Framework.UI.BunifuThinButton2 BT_Reset;
    }
}

