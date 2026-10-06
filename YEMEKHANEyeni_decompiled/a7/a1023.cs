using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FastReport;

namespace a7;

public class a1023 : XtraForm
{
	private IContainer a962 = null;

	public PictureBox a963;

	public GroupBox a964;

	public Label a965;

	public Label a966;

	public Label a967;

	public Label a968;

	public Label a969;

	public Label a970;

	public Label a971;

	public Label a972;

	public TextBox a973;

	public TextBox a974;

	public TextBox a975;

	public TextBox a976;

	public Label a977;

	public Button a978;

	public Panel a979;

	public Button a980;

	private CheckBox a981;

	private CheckBox a982;

	private CheckBox a983;

	public Label a984;

	private CheckBox a985;

	private CheckBox a986;

	private CheckBox a987;

	private CheckBox a988;

	private CheckBox a989;

	private CheckBox a990;

	private CheckBox a991;

	public Label a992;

	private Button a993;

	private Button a994;

	public Label a995;

	public Label a996;

	public TextBox a997;

	public TextBox a998;

	private Report a999 = new Report();

	protected override void Dispose(bool a1000)
	{
		if (a1000 && a962 != null)
		{
			a962.Dispose();
		}
		base.Dispose(a1000);
	}

	private void a1001()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(a1023));
		a963 = new PictureBox();
		a964 = new GroupBox();
		a994 = new Button();
		a993 = new Button();
		a985 = new CheckBox();
		a986 = new CheckBox();
		a987 = new CheckBox();
		a988 = new CheckBox();
		a989 = new CheckBox();
		a990 = new CheckBox();
		a991 = new CheckBox();
		a983 = new CheckBox();
		a982 = new CheckBox();
		a981 = new CheckBox();
		a965 = new Label();
		a966 = new Label();
		a967 = new Label();
		a995 = new Label();
		a968 = new Label();
		a969 = new Label();
		a996 = new Label();
		a970 = new Label();
		a971 = new Label();
		a992 = new Label();
		a972 = new Label();
		a997 = new TextBox();
		a973 = new TextBox();
		a998 = new TextBox();
		a974 = new TextBox();
		a975 = new TextBox();
		a984 = new Label();
		a976 = new TextBox();
		a977 = new Label();
		a978 = new Button();
		a979 = new Panel();
		a980 = new Button();
		((ISupportInitialize)a963).BeginInit();
		a964.SuspendLayout();
		a979.SuspendLayout();
		SuspendLayout();
		a963.Image = (Image)componentResourceManager.GetObject(a1022("aŹɬͺѸվٮ\u0748ࡦ॰ਸ਼ନ\u0c4c൩\u0e62ཥ\u1064"));
		a963.InitialImage = null;
		a963.Location = new Point(457, 13);
		a963.Name = a1022("{ţɪͼѲմ٠\u0746\u086cॺਰ");
		a963.Size = new Size(128, 128);
		a963.SizeMode = PictureBoxSizeMode.AutoSize;
		a963.TabIndex = 0;
		a963.TabStop = false;
		a964.Controls.Add(a994);
		a964.Controls.Add(a993);
		a964.Controls.Add(a985);
		a964.Controls.Add(a986);
		a964.Controls.Add(a987);
		a964.Controls.Add(a988);
		a964.Controls.Add(a989);
		a964.Controls.Add(a990);
		a964.Controls.Add(a991);
		a964.Controls.Add(a983);
		a964.Controls.Add(a982);
		a964.Controls.Add(a981);
		a964.Controls.Add(a963);
		a964.Controls.Add(a965);
		a964.Controls.Add(a966);
		a964.Controls.Add(a967);
		a964.Controls.Add(a995);
		a964.Controls.Add(a968);
		a964.Controls.Add(a969);
		a964.Controls.Add(a996);
		a964.Controls.Add(a970);
		a964.Controls.Add(a971);
		a964.Controls.Add(a992);
		a964.Controls.Add(a972);
		a964.Controls.Add(a997);
		a964.Controls.Add(a973);
		a964.Controls.Add(a998);
		a964.Controls.Add(a974);
		a964.Controls.Add(a975);
		a964.Controls.Add(a984);
		a964.Controls.Add(a976);
		a964.Controls.Add(a977);
		a964.Location = new Point(10, 0);
		a964.Name = a1022("nźɨͳѵՆ٬ݺ࠰");
		a964.Size = new Size(601, 393);
		a964.TabIndex = 0;
		a964.TabStop = false;
		a994.Location = new Point(173, 283);
		a994.Name = a1022("eųɱͰѬլس");
		a994.Size = new Size(157, 30);
		a994.TabIndex = 14;
		a994.Text = a1022("Cǥɳͻѳոٱ\u0733ࡔॸ\u0b4f୦మ\u0d49\u0e65\u0f71\u106bᅰቦሶᐦᔭᙃ\u17ffᡬ\u1928");
		a994.UseVisualStyleBackColor = true;
		a994.Click += a1020;
		a993.Location = new Point(14, 283);
		a993.Name = a1022("eųɱͰѬլذ");
		a993.Size = new Size(157, 30);
		a993.TabIndex = 13;
		a993.Text = a1022("BǦɲʹѲջ\u0670\u0734ࡕॻ\u0b4e\u0b79య\u0d4a\u0e64\u0f76\u106aᅳቧሹᐧᔮᙕᝥᡱᥣᨨ");
		a993.UseVisualStyleBackColor = true;
		a993.Click += a1017;
		a985.AutoSize = true;
		a985.Location = new Point(340, 85);
		a985.Name = a1022("dŮɵ\u0365ѹգٳ");
		a985.Size = new Size(53, 17);
		a985.TabIndex = 12;
		a985.Text = a1022("Uťɹ\u0363ѳ");
		a985.TextAlign = ContentAlignment.MiddleCenter;
		a985.UseVisualStyleBackColor = true;
		a986.AutoSize = true;
		a986.Location = new Point(340, 64);
		a986.Name = a1022("hŢɪͽѪէٷݰࡦॱ੨");
		a986.Size = new Size(74, 17);
		a986.TabIndex = 11;
		a986.Text = a1022("JŽɪ\u0367ѷհ٦ݱࡨ");
		a986.TextAlign = ContentAlignment.MiddleCenter;
		a986.UseVisualStyleBackColor = true;
		a987.AutoSize = true;
		a987.Checked = true;
		a987.CheckState = CheckState.Checked;
		a987.Location = new Point(257, 150);
		a987.Name = a1022("eŭɧͶѯՠ");
		a987.Size = new Size(53, 17);
		a987.TabIndex = 10;
		a987.Text = a1022("GŶɯ\u0360");
		a987.TextAlign = ContentAlignment.MiddleCenter;
		a987.UseVisualStyleBackColor = true;
		a988.AutoSize = true;
		a988.Checked = true;
		a988.CheckState = CheckState.Checked;
		a988.Location = new Point(257, 127);
		a988.Name = a1022("išɸ\u0362Ѵն١ݮࡠ।");
		a988.Size = new Size(73, 17);
		a988.TabIndex = 9;
		a988.Text = a1022("XŢɴɚѡծ٠ݤ");
		a988.TextAlign = ContentAlignment.MiddleCenter;
		a988.UseVisualStyleBackColor = true;
		a989.AutoSize = true;
		a989.Checked = true;
		a989.CheckState = CheckState.Checked;
		a989.Location = new Point(257, 106);
		a989.Name = a1022("eŭɧͱѱլ");
		a989.Size = new Size(74, 17);
		a989.TabIndex = 8;
		a989.Text = a1022("ÏŦɴɚѥծ٠ݠ");
		a989.TextAlign = ContentAlignment.MiddleCenter;
		a989.UseVisualStyleBackColor = true;
		a990.AutoSize = true;
		a990.Checked = true;
		a990.CheckState = CheckState.Checked;
		a990.Location = new Point(257, 85);
		a990.Name = a1022("eŭɷ\u0362Ѯը");
		a990.Size = new Size(42, 17);
		a990.TabIndex = 7;
		a990.Text = a1022("WŢɮȰ");
		a990.TextAlign = ContentAlignment.MiddleCenter;
		a990.UseVisualStyleBackColor = true;
		a991.AutoSize = true;
		a991.Checked = true;
		a991.CheckState = CheckState.Checked;
		a991.Location = new Point(257, 64);
		a991.Name = a1022("fŬɳ\u0378ѵ");
		a991.Size = new Size(70, 17);
		a991.TabIndex = 6;
		a991.Text = a1022("Yũɽ\u0367ѷհ٦ݱࡨ");
		a991.TextAlign = ContentAlignment.MiddleCenter;
		a991.UseVisualStyleBackColor = true;
		a983.AutoSize = true;
		a983.Checked = true;
		a983.CheckState = CheckState.Checked;
		a983.Location = new Point(257, 241);
		a983.Name = a1022("nŤɟ\u0349чէ\u064cݩ\u086b॰\u0a71୭౭");
		a983.Size = new Size(229, 17);
		a983.TabIndex = 17;
		a983.Text = a1022("xŨȊ\u0362сՊي\u074cࡏ\u0903੬\u0b54\u0c4dൾ\u0e6c\u0f7cၰᅺቨረᑶᐦᙸ᜵ᡀ\u1976\u1a79᭣ᱱᵽἿὣℽÅ≁⍦⑦╳♴❪⡨⤣⩇\u2b75");
		a983.TextAlign = ContentAlignment.MiddleCenter;
		a983.UseVisualStyleBackColor = true;
		a982.AutoSize = true;
		a982.Checked = true;
		a982.CheckState = CheckState.Checked;
		a982.Location = new Point(257, 214);
		a982.Name = a1022("jŠɀͳѫՉ٦ݬࡴ");
		a982.Size = new Size(174, 17);
		a982.TabIndex = 16;
		a982.Text = a1022("\\Ǧɷ\u0338юתپݸࡶॿੴର\u0c42൫\u0e63\u0ff0ၸᇶቧᏴᐧᕁᛳ\u1777ᡷᥧ\u1a73");
		a982.TextAlign = ContentAlignment.MiddleCenter;
		a982.UseVisualStyleBackColor = true;
		a981.AutoSize = true;
		a981.Checked = true;
		a981.CheckState = CheckState.Checked;
		a981.Location = new Point(257, 187);
		a981.Name = a1022("išɘ\u0366Ѵդىݦ\u086cॴ");
		a981.Size = new Size(177, 17);
		a981.TabIndex = 15;
		a981.Text = a1022("Lźɨ\u0378иՎ\u06eaݾࡸॶ\u0a7f୴ర\u0d42\u0e6bལჰᅸዶ፧ᓴᔧᙁ៳ᡷ\u1977\u1a67\u1b73");
		a981.TextAlign = ContentAlignment.MiddleCenter;
		a981.UseVisualStyleBackColor = true;
		a965.AutoSize = true;
		a965.BackColor = Color.Transparent;
		a965.Font = new Font(a1022("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a965.Location = new Point(11, 331);
		a965.Name = a1022("jŤɦ\u0366Ѯ\u0530");
		a965.Size = new Size(37, 13);
		a965.TabIndex = 55;
		a965.Text = a1022("PŽɢͰ\u0530");
		a966.BackColor = Color.FromArgb(128, 255, 128);
		a966.BorderStyle = BorderStyle.Fixed3D;
		a966.FlatStyle = FlatStyle.Flat;
		a966.Location = new Point(14, 325);
		a966.Name = a1022("kŧɧ\u0361ѯԳز");
		a966.Size = new Size(387, 3);
		a966.TabIndex = 54;
		a967.AutoSize = true;
		a967.Font = new Font(a1022("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a967.Location = new Point(14, 22);
		a967.Name = a1022("jŤɦ\u0366ѮԹ");
		a967.Size = new Size(138, 13);
		a967.TabIndex = 51;
		a967.Text = a1022("LǨɸ;Ѵս٪ܮ\u085d७\u0a79୫\u0c64൭\u0e73\u0f74\u1060ᅨቦ፰ᑨ");
		a995.AutoSize = true;
		a995.Location = new Point(14, 239);
		a995.Name = a1022("kŧɧ\u0361ѯԳس");
		a995.Size = new Size(91, 13);
		a995.TabIndex = 49;
		a995.Text = a1022("@źɢ\u0361Ѫվة\u0745ࡦॾਥ\u0b54\u0c62൰\u0e60");
		a968.AutoSize = true;
		a968.Location = new Point(14, 174);
		a968.Name = a1022("jŤɦ\u0366ѮԶ");
		a968.Size = new Size(118, 13);
		a968.TabIndex = 49;
		a968.Text = a1022("Yźɼ\u0364ѽպ٣ܭ\u085c४\u0a78୨న൞\u0efa\u0f6e\u1068ᅦቯ፤");
		a969.AutoSize = true;
		a969.Location = new Point(11, 347);
		a969.Name = a1022("jŤɦ\u0366ѮԵ");
		a969.Size = new Size(382, 39);
		a969.TabIndex = 49;
		a969.Text = componentResourceManager.GetString(a1022("gūɫ\u036dѫԲثݐࡦॺ\u0a75"));
		a996.AutoSize = true;
		a996.Location = new Point(14, 206);
		a996.Name = a1022("kŧɧ\u0361ѯԳذ");
		a996.Size = new Size(84, 13);
		a996.TabIndex = 49;
		a996.Text = a1022("AŹɣ\u0366ѫսب\u074a\u086f५ਤ\u0b44\u0cfe൯");
		a970.AutoSize = true;
		a970.Location = new Point(14, 141);
		a970.Name = a1022("jŤɦ\u0366ѮԲ");
		a970.Size = new Size(122, 13);
		a970.TabIndex = 49;
		a970.Text = a1022("Xŵɸ\u0361Ѹսٺݣ\u082dड़੪\u0b78౨ന\u0e5e\u0ffaၮᅨቦ፯ᑤ");
		a971.AutoSize = true;
		a971.Location = new Point(14, 107);
		a971.Name = a1022("jŤɦ\u0366ѮԳ");
		a971.Size = new Size(115, 13);
		a971.TabIndex = 49;
		a971.Text = a1022("^Żɿ\u0365Ѣջ٠ܬࡌ৶੧ନ\u0c5e\u0dfa\u0e6eཨၦᅯቤ");
		a992.AutoSize = true;
		a992.Location = new Point(254, 42);
		a992.Name = a1022("kŧɧ\u0361ѯԳر");
		a992.Size = new Size(127, 13);
		a992.TabIndex = 49;
		a992.Text = a1022("Aǫɽ\u0379ѱվٷ\u0731ࡉ८\u0a7e\u0a3cౠ൪\u0e69ཨ\u1063ᄧቁᏹᑪᕯᙧ\u1773");
		a972.AutoSize = true;
		a972.Location = new Point(14, 72);
		a972.Name = a1022("jŤɦ\u0366ѮԷ");
		a972.Size = new Size(119, 13);
		a972.TabIndex = 49;
		a972.Text = a1022("YŲɹ\u0362ѹբٻݠ\u082c\u094c\u0af6୧న൞\u0efa\u0f6e\u1068ᅦቯ፤");
		a997.Font = new Font(a1022("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a997.Location = new Point(164, 231);
		a997.MaxLength = 5;
		a997.Name = a1022("dŷɺ\u0342Ѹդ٧ݨࡼ\u094a੧\u0b7d\u0c54\u0d62\u0e70འ");
		a997.Size = new Size(68, 26);
		a997.TabIndex = 5;
		a997.Text = a1022("1");
		a997.TextAlign = HorizontalAlignment.Right;
		a997.KeyPress += a1006;
		a973.Font = new Font(a1022("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a973.Location = new Point(164, 166);
		a973.MaxLength = 5;
		a973.Name = a1022("~űɼ\u034aѯի\u0654ݢࡰॠ");
		a973.Size = new Size(68, 26);
		a973.TabIndex = 3;
		a973.Text = a1022("1");
		a973.TextAlign = HorizontalAlignment.Right;
		a973.KeyPress += a1006;
		a998.Font = new Font(a1022("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a998.Location = new Point(164, 198);
		a998.MaxLength = 5;
		a998.Name = a1022("{Ŷɹ\u0343ѿե٤ݩࡳ\u094b੬୪\u0c44൷\u0e6f");
		a998.Size = new Size(68, 26);
		a998.TabIndex = 4;
		a998.Text = a1022("1");
		a998.TextAlign = HorizontalAlignment.Right;
		a998.KeyPress += a1006;
		a974.Font = new Font(a1022("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a974.Location = new Point(164, 133);
		a974.MaxLength = 5;
		a974.Name = a1022("~űɼ\u034aѧս\u0654ݢࡰॠ");
		a974.Size = new Size(68, 26);
		a974.TabIndex = 2;
		a974.Text = a1022("1");
		a974.TextAlign = HorizontalAlignment.Right;
		a974.KeyPress += a1006;
		a975.Font = new Font(a1022("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a975.Location = new Point(164, 99);
		a975.MaxLength = 5;
		a975.Name = a1022("}Űɳ\u034bѬժلݷ\u086f");
		a975.Size = new Size(68, 26);
		a975.TabIndex = 1;
		a975.Text = a1022("1");
		a975.TextAlign = HorizontalAlignment.Right;
		a975.KeyPress += a1006;
		a984.AutoSize = true;
		a984.Location = new Point(25, 262);
		a984.Name = a1022("jŤɦ\u0366ѮԸ");
		a984.Size = new Size(0, 13);
		a984.TabIndex = 46;
		a976.Font = new Font(a1022("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a976.Location = new Point(164, 64);
		a976.MaxLength = 5;
		a976.Name = a1022("}Űɳ\u034bѤռلݷ\u086f");
		a976.Size = new Size(68, 26);
		a976.TabIndex = 0;
		a976.Text = a1022("1");
		a976.TextAlign = HorizontalAlignment.Right;
		a976.KeyPress += a1006;
		a977.AutoSize = true;
		a977.Location = new Point(25, 239);
		a977.Name = a1022("jŤɦ\u0366ѮԴ");
		a977.Size = new Size(0, 13);
		a977.TabIndex = 46;
		a978.Dock = DockStyle.Fill;
		a978.Location = new Point(301, 0);
		a978.Name = a1022("jųɨ\u0346ѭը٫ݲ");
		a978.Size = new Size(318, 37);
		a978.TabIndex = 1;
		a978.Text = a1022("Â5ɨȳ՞");
		a978.UseVisualStyleBackColor = true;
		a978.Click += a1012;
		a979.BackColor = Color.FromArgb(233, 235, 236);
		a979.Controls.Add(a978);
		a979.Controls.Add(a980);
		a979.Dock = DockStyle.Bottom;
		a979.Location = new Point(0, 399);
		a979.Name = a1022("vŤɪ\u0366Ѯ\u0530");
		a979.Size = new Size(619, 37);
		a979.TabIndex = 5;
		a980.Dock = DockStyle.Left;
		a980.Location = new Point(0, 0);
		a980.Name = a1022("kżɩ\u034dѤս٧ݧࡵ");
		a980.Size = new Size(301, 37);
		a980.TabIndex = 0;
		a980.Text = a1022("MŤɽ\u0367ѧյ");
		a980.UseVisualStyleBackColor = true;
		a980.Click += a1009;
		Appearance.BackColor = Color.White;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(619, 436);
		Controls.Add(a964);
		Controls.Add(a979);
		MaximizeBox = false;
		Name = a1022("Hſɡ\u034cѯէ٭ݫࡖ।੶\u0b62౯൲");
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a1022("UŴɾ\u036aѢԭ\u065cݪࡸ२\u0a65\u0b62\u0c72൷\u0e61\u0f6f\u1067ᅳ");
		((ISupportInitialize)a963).EndInit();
		a964.ResumeLayout(performLayout: false);
		a964.PerformLayout();
		a979.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public a1023()
	{
		a1001();
		a1984.a1891(this);
		a1002();
	}

	public void a1002()
	{
		DataTable dataTable = a2147.a2105(a1022("\u0097ǥ\u02f0ϸӶױۥސ\u08fbৡ\u0afd\u0b8cಚඊ\u0ee0\u0fec\u108bᇫዤᏼᓤᗷᛯឌᣒ᧗\u1ad3ᯛ\u1cce\u1dd4ẵ\u1fd5\u20d6⇎⋅⏕Ⓛ◓⚽⟝⣆⧀⫝⯍ⳙⷋ⺥⿇ビ㇉㋈㏅㓗㗏㛈㟎㠸㤫㨳㭐㰴㴮㸶㼵䀶䄢䈸䌵䐫䔢䘰䜢䠮䥂䨠䬩䰥䴿丮伽倩儧刮匰吪唤噍圭堚夐娈嬌尚崈帘弙怜愂戜挒摿敲昅朓栁椁樎欃氅洞減漇瀋煪爕猅琙甃瘓眔硺祭穴笐籨絻繵罱耛腵艴荦葠蕳虼蝲衮褂詽譩豹赹蹬轥遥酣鈉鍧鑶镯陠霌顜饋驐魝鱉鵎鹜齋ꁞꄺꉅꍕꑉꕓꙃꜰꡉ\ua95cꩂꭁ갫굚깈꽚끆녋뉀덐둑땇똡"));
		if (dataTable.Rows.Count > 0)
		{
			a976.Text = dataTable.Rows[0][a1022("Kńɜ\u0344їՏ")].ToString();
			a975.Text = dataTable.Rows[0][a1022("KŌɊ\u0344їՏ")].ToString();
			a974.Text = dataTable.Rows[0][a1022("JŇɝ\u0354тՐـ")].ToString();
			a973.Text = dataTable.Rows[0][a1022("Jŏɋ\u0354тՐـ")].ToString();
			a998.Text = dataTable.Rows[0][a1022("CşɅ\u0344щՓ\u064b\u074cࡊ\u0944\u0a57\u0b4f")].ToString();
			a997.Text = dataTable.Rows[0][a1022("BŘɄ\u0347ш՜ي\u0747\u085d\u0954\u0a42\u0b50\u0c40")].ToString();
			if (dataTable.Rows[0][a1022("AŎɄ\u035cяՒو\u0744ࡏ\u0957\u0a4b\u0b47")].ToString() == a1022("0"))
			{
				a982.Checked = true;
			}
			else
			{
				a982.Checked = false;
			}
			if (dataTable.Rows[0][a1022("@ŉɅ\u035fљՉ\u0655\u0747ࡄ\u094f\u0a57\u0b4b\u0c47")].ToString() == a1022("0"))
			{
				a981.Checked = true;
			}
			else
			{
				a981.Checked = false;
			}
			if (dataTable.Rows[0][a1022("_ŉɇ\u0347фՉ\u064bݐࡑ\u094d\u0a4d")].ToString() == a1022("0"))
			{
				a983.Checked = true;
			}
			else
			{
				a983.Checked = false;
			}
			if (dataTable.Rows[0][a1022("Yŉɝ\u0347їՐنݑࡈ")].ToString() == a1022("0"))
			{
				a991.Checked = true;
			}
			else
			{
				a991.Checked = false;
			}
			if (dataTable.Rows[0][a1022("WłɎ\u0348")].ToString() == a1022("0"))
			{
				a990.Checked = true;
			}
			else
			{
				a990.Checked = false;
			}
			if (dataTable.Rows[0][a1022("Kņɔ\u0356хՎـ\u0740")].ToString() == a1022("0"))
			{
				a989.Checked = true;
			}
			else
			{
				a989.Checked = false;
			}
			if (dataTable.Rows[0][a1022("Xłɔ\u0356сՎـ\u0744")].ToString() == a1022("0"))
			{
				a988.Checked = true;
			}
			else
			{
				a988.Checked = false;
			}
			if (dataTable.Rows[0][a1022("GŖɏ\u0340")].ToString() == a1022("0"))
			{
				a987.Checked = true;
			}
			else
			{
				a987.Checked = false;
			}
			if (dataTable.Rows[0][a1022("JŝɊ\u0347їՐنݑࡈ")].ToString() == a1022("0"))
			{
				a986.Checked = true;
			}
			else
			{
				a986.Checked = false;
			}
			if (dataTable.Rows[0][a1022("UŅə\u0343ѓ")].ToString() == a1022("0"))
			{
				a985.Checked = true;
			}
			else
			{
				a985.Checked = false;
			}
		}
	}

	public void a1003()
	{
		if (a976.Text == a1022("") || a975.Text == a1022("") || a974.Text == a1022("") || a973.Text == a1022(""))
		{
			MessageBox.Show(a1022("lǣɪͻѹյغݝࡽࠈੳ୧౸൶\u0e60\u0f78\u1030ᅄቡ፣ᑸᕹᙥᝥᠨ\u1942\u1a62\u1b6cᱪᵪṸἯ"), a1022("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		a1344.a1307();
		a1344.a1271.CommandText = a1022("Qőɟ\u0357хՕد\u0748\u085f\u0943\u0a46ପౙ\u0d49๕ཇ၈ᅁ\u1257ፐᑄ");
		try
		{
			a1344.a1271.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
		a1344.a1307();
		a1344.a1271.CommandText = a1022("}ĕȕ\u0309МԊ\u0603ݶ\u081cचਇଝ\u0c71\u0d00ฎ༜ဌᄁሎጞᐛᔍᙧᝮ᠈ᤅ\u1a1bᬅᰔᴎḓέ⁴ⅲ≼⍯⑷└♺❷⡭⥤⩲⭠Ɒⴜ\u2e62⽧っㅼ㉪㍸㑨㔄㙨㝲㡪㥩㩢㭶㱬㵩㹑㽙䁈䅒䈷䍕䑍䕗䙚䝗䡁䥙䩒䭊䱁䵑九住倡允剎卄呜問噒坈塄奏婗孋屇崬庲徻悳憩披掻撫方暶枽梡榽檵毞沥涳溡澡炮熣犥玾璻疧皫矊碵禥窹箣粳綴纚羍肔臰芈莛蒕薑蛻螕袔覆誀讓貜趒躎迢邝醉銙鎙钌閅隅鞃飩馇骖鮏鲀鷬黼鿫ꃰꇽꋩꏮꓼꗫ\ua6feꞚ\ua8e5꧵ꫩ꯳곣궙꺏꾎냻뇭닧돿듬뗻뚏럦루맥뫻믥보뷮뺳뿞샐쇕싕쏝쓌엖욻쟖죘징쫋쯂쳐췂컎쾢탍퇁틂폄퓙헉훕\ud7c7\ud8a9\ud9c4\udacc\udbd6\udcce\uddcd\ude3e\udf2a\ue030\ue135\ue235\ue33d\ue42c\ue536\ue65b\ue736\ue83a\ue920\uea3c\ueb3f\uec30\ued24\uee22\uef2f\uf035\uf13c\uf22a\uf338\uf428\uf544\uf627\uf72b\uf820浪喝ﬥﰴﴮ\ufe1e５\tĕȝͶЙԕ\u0612ܘࠀऄ\u0a12\u0b00ఐ\u0d11ค༚ငᄊቧጊᐝᔋᘉᜉ᠆ᤋᨍᬖᰓᴏṳἒ⁽Ⅼ≺⍠⑸╪♣❳⡦⥽⨟⭲Ɫ\u2d71\u2e63⽧、ㅬ㉨㍫㑻㕻㙦㝫㡧㥥㨏㭢㱱㵥㹍㽍䁘䅑䉙䍟䐵䕘䙔䝃䡘䥕䨿䭒䱒䵅乂住偟兘剎卙呀唤噇坖塄奞婂子尨");
		a1344.a1271.Parameters.Add(a1022("Kńɜ\u0344їՏ"), SqlDbType.Int).Value = Convert.ToInt32(a976.Text);
		a1344.a1271.Parameters.Add(a1022("KŌɊ\u0344їՏ"), SqlDbType.Int).Value = Convert.ToInt32(a975.Text);
		a1344.a1271.Parameters.Add(a1022("JŇɝ\u0354тՐـ"), SqlDbType.Int).Value = Convert.ToInt32(a974.Text);
		a1344.a1271.Parameters.Add(a1022("Jŏɋ\u0354тՐـ"), SqlDbType.Int).Value = Convert.ToInt32(a973.Text);
		a1344.a1271.Parameters.Add(a1022("CşɅ\u0344щՓ\u064b\u074cࡊ\u0944\u0a57\u0b4f"), SqlDbType.Int).Value = Convert.ToInt32(a998.Text);
		a1344.a1271.Parameters.Add(a1022("BŘɄ\u0347ш՜ي\u0747\u085d\u0954\u0a42\u0b50\u0c40"), SqlDbType.Int).Value = Convert.ToInt32(a997.Text);
		if (a982.Checked)
		{
			a1344.a1271.Parameters.Add(a1022("AŎɄ\u035cяՒو\u0744ࡏ\u0957\u0a4b\u0b47"), SqlDbType.Int).Value = 1;
		}
		else
		{
			a1344.a1271.Parameters.Add(a1022("AŎɄ\u035cяՒو\u0744ࡏ\u0957\u0a4b\u0b47"), SqlDbType.Int).Value = 0;
		}
		if (a981.Checked)
		{
			a1344.a1271.Parameters.Add(a1022("@ŉɅ\u035fљՉ\u0655\u0747ࡄ\u094f\u0a57\u0b4b\u0c47"), SqlDbType.Int).Value = 1;
		}
		else
		{
			a1344.a1271.Parameters.Add(a1022("@ŉɅ\u035fљՉ\u0655\u0747ࡄ\u094f\u0a57\u0b4b\u0c47"), SqlDbType.Int).Value = 0;
		}
		if (a983.Checked)
		{
			a1344.a1271.Parameters.Add(a1022("_ŉɇ\u0347фՉ\u064bݐࡑ\u094d\u0a4d"), SqlDbType.Int).Value = 1;
		}
		else
		{
			a1344.a1271.Parameters.Add(a1022("_ŉɇ\u0347фՉ\u064bݐࡑ\u094d\u0a4d"), SqlDbType.Int).Value = 0;
		}
		if (a991.Checked)
		{
			a1344.a1271.Parameters.Add(a1022("Yŉɝ\u0347їՐنݑࡈ"), SqlDbType.Int).Value = 1;
		}
		else
		{
			a1344.a1271.Parameters.Add(a1022("Yŉɝ\u0347їՐنݑࡈ"), SqlDbType.Int).Value = 0;
		}
		if (a990.Checked)
		{
			a1344.a1271.Parameters.Add(a1022("WłɎ\u0348"), SqlDbType.Int).Value = 1;
		}
		else
		{
			a1344.a1271.Parameters.Add(a1022("WłɎ\u0348"), SqlDbType.Int).Value = 0;
		}
		if (a989.Checked)
		{
			a1344.a1271.Parameters.Add(a1022("Kņɔ\u0356хՎـ\u0740"), SqlDbType.Int).Value = 1;
		}
		else
		{
			a1344.a1271.Parameters.Add(a1022("Kņɔ\u0356хՎـ\u0740"), SqlDbType.Int).Value = 0;
		}
		if (a988.Checked)
		{
			a1344.a1271.Parameters.Add(a1022("Xłɔ\u0356сՎـ\u0744"), SqlDbType.Int).Value = 1;
		}
		else
		{
			a1344.a1271.Parameters.Add(a1022("Xłɔ\u0356сՎـ\u0744"), SqlDbType.Int).Value = 0;
		}
		if (a987.Checked)
		{
			a1344.a1271.Parameters.Add(a1022("GŖɏ\u0340"), SqlDbType.Int).Value = 1;
		}
		else
		{
			a1344.a1271.Parameters.Add(a1022("GŖɏ\u0340"), SqlDbType.Int).Value = 0;
		}
		if (a986.Checked)
		{
			a1344.a1271.Parameters.Add(a1022("JŝɊ\u0347їՐنݑࡈ"), SqlDbType.Int).Value = 1;
		}
		else
		{
			a1344.a1271.Parameters.Add(a1022("JŝɊ\u0347їՐنݑࡈ"), SqlDbType.Int).Value = 0;
		}
		if (a985.Checked)
		{
			a1344.a1271.Parameters.Add(a1022("UŅə\u0343ѓ"), SqlDbType.Int).Value = 1;
		}
		else
		{
			a1344.a1271.Parameters.Add(a1022("UŅə\u0343ѓ"), SqlDbType.Int).Value = 0;
		}
		try
		{
			a1344.a1271.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			return;
		}
		MessageBox.Show(a1022("SŶɯȤѠԳܢ\u064eࡼ४\u0a63\u0b64బൿ\u0e6bཤ\u1069ᅪቪ፤ᑪᕧ\u1733ᜯ"), a1022("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		a1002();
	}

	private void a1006(object a1004, KeyPressEventArgs a1005)
	{
		a1005.Handled = !char.IsDigit(a1005.KeyChar) && !char.IsControl(a1005.KeyChar);
	}

	private void a1009(object a1007, EventArgs a1008)
	{
		a1003();
	}

	private void a1012(object a1010, EventArgs a1011)
	{
		Close();
	}

	public void a1013()
	{
		string text = a1022("HŅɄ\u0342шՁ\u064eݕࡏ\u0941\u0a54\u0b4fౚൔโཐ၀");
		a999.Clear();
		DataTable dataTable = new DataTable(a1022("HŅɄ\u0342шՁ\u064eݕࡏ\u0941\u0a54\u0b4fౚൔโཐ၀"));
		dataTable.Columns.Add(a1022("Mńɖ\u0357ьՎ"));
		dataTable.Columns.Add(a1022("Fłɖ\u034bњՃم"));
		dataTable.Columns.Add(a1022("PŀɌ\u034e"));
		dataTable.Columns.Add(a1022("PŝɌ\u0359ёՅ\u0651\u074bࡉ"));
		dataTable.Columns.Add(a1022("BłɈ\u034fтՁ\u0658\u0744ࡄ\u094f\u0a4a\u0b5b\u0c44"));
		dataTable.Columns.Add(a1022("KŌɏ\u0357уՓ"));
		dataTable.Columns.Add(a1022("]łɂ\u0359ыՂفݘࡄ\u0944\u0a4f\u0b4a\u0c5b\u0d44"));
		a999.RegisterData(dataTable, a1022("HŅɄ\u0342шՁ\u064eݕࡏ\u0941\u0a54\u0b4fౚൔโཐ၀"));
		string s = a1022("");
		if (a2147.a2100(a1022("tţɩ\u0361Ѡն\u0601ݩ\u085b\u093eਜ਼\u0b4e\u0c54\u0d57\u0e39ཛྷ\u105eᅌቔፍᑝᔲᙆ\u1758ᡊᥜᩈᬬᱏᵃṓὉ⁞ⅈ≄⍀⑊┿☦") + text + a1022("&")))
		{
			s = a2147.a2113(a1022("dųɹͱѰզ\u0611ݤࡠॾ\u0a0dଝఋ൹\u0e68\u0f7e\u1062ᅲቪ፷ᑷᕰᙨᝮᡘ\u193e\u1a5b᭎᱔ᵗḹ\u1f5c⁞⅌≔⍍\u245d┲♆❘⡊⥜⩈⬬ⱏⵃ⹓⽉ぞㅈ㉄㍀㑊㔿㘦") + text + a1022("&"), 0);
		}
		a999.LoadFromString(s);
		a999.Design();
		a1344.a1307();
		if (a2147.a2100(a1022("tţɩ\u0361Ѡն\u0601ݩ\u085b\u093eਜ਼\u0b4e\u0c54\u0d57\u0e39ཛྷ\u105eᅌቔፍᑝᔲᙆ\u1758ᡊᥜᩈᬬᱏᵃṓὉ⁞ⅈ≄⍀⑊┿☦") + text + a1022("&")))
		{
			if (MessageBox.Show(a1022("SŸɪ\u0378ѯխظݓࡿ९\u0a75୪౼റ๗\u0ff3\u1060ᅮቩ፧ᑦᕬᙦ\u1774ᡯᥫᨤ\u1b6eᱫᴾ"), a1022("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.Cancel)
			{
				return;
			}
			a1344.a1271.CommandText = a1022("`Ŧɮ\u0364Ѵ՚ؾݛࡎ\u0954\u0a57ହ\u0c5c൞\u0e4cཔ၍ᅝሲፆᑘᕊᙜᝈᠬ᥏ᩃ᭓᱉ᵞṈὄ\u2040⅊∿⌦") + text + a1022("&");
			try
			{
				a1344.a1271.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(a1022("NŤɰ\u0362иԡ") + ex.Message);
				return;
			}
		}
		a1344.a1271.Parameters.Clear();
		a1344.a1271.CommandText = a1022("\u0010ĖȄ\u0313ЇԀٳܛ\u081fऄ\u0a00୮ఉഅฑ་တᄆቧ፮ᐁᔍᘙᜃ᠘ᤎ\u1a7e᭺ᱴᴐṨύ\u206fⅽ≣⍹⑦╠♡❻⡿⥷⨃⭯ⱦ\u2d78\u2e62⽬\u3000ㄈ㉱㍧㑩㕱㙦㝱㠉㥠㩛㭗㱇㵝㹂㽔䁘䅜䉞䌺䑕䕇䙒䝄䡔䥄䩀䭝䱙䵞乂佄偎儤則升呎啐噊坄堨");
		a1344.a1271.Parameters.Add(a1022("MŁɝ\u0347ќՊق\u0746ࡈ"), SqlDbType.VarChar).Value = text;
		a1344.a1271.Parameters.Add(a1022("_Ŋɜ\u034cќՈ\u0655ݑࡖ\u094a\u0a4c\u0b46"), SqlDbType.NText).Value = a999.SaveToString();
		a1344.a1271.Parameters.Add(a1022("Dŏɗ\u034bч"), SqlDbType.VarChar).Value = a1022("D");
		try
		{
			a1344.a1271.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			MessageBox.Show(a1022("NŤɰ\u0362иԡ") + ex.Message);
		}
	}

	public void a1014()
	{
		string text = a1022("IŚɅ\u0341щՆ\u064fݖࡎ\u094e\u0a55\u0b4c\u0c5b\u0d44๗ཏ");
		a999.Clear();
		DataTable dataTable = new DataTable(a1022("IŚɅ\u0341щՆ\u064fݖࡎ\u094e\u0a55\u0b4c\u0c5b\u0d44๗ཏ"));
		dataTable.Columns.Add(a1022("Mńɖ\u0357ьՎ"));
		dataTable.Columns.Add(a1022("Fłɖ\u034bњՃم"));
		dataTable.Columns.Add(a1022("PŀɌ\u034e"));
		dataTable.Columns.Add(a1022("PŝɌ\u0359ёՅ\u0651\u074bࡉ"));
		dataTable.Columns.Add(a1022("MŇɃ\u0347щՉ\u0659ݑࡑ\u0957\u0a43\u0b53"));
		DataTable dataTable2 = new DataTable(a1022("Mņə\u035dѕՂ\u064bݒࡊ\u0942ਖ਼\u0b40\u0c57\u0d40๓ཋၛᅋቃፓ"));
		dataTable2.Columns.Add(a1022("Kńɗ\u034f"));
		dataTable2.Columns.Add(a1022("QŅɑ\u034bщ"));
		a999.RegisterData(dataTable, a1022("IŚɅ\u0341щՆ\u064fݖࡎ\u094e\u0a55\u0b4c\u0c5b\u0d44๗ཏ"));
		a999.RegisterData(dataTable2, a1022("Mņə\u035dѕՂ\u064bݒࡊ\u0942ਖ਼\u0b40\u0c57\u0d40๓ཋၛᅋቃፓ"));
		string s = a1022("");
		if (a2147.a2100(a1022("tţɩ\u0361Ѡն\u0601ݩ\u085b\u093eਜ਼\u0b4e\u0c54\u0d57\u0e39ཛྷ\u105eᅌቔፍᑝᔲᙆ\u1758ᡊᥜᩈᬬᱏᵃṓὉ⁞ⅈ≄⍀⑊┿☦") + text + a1022("&")))
		{
			s = a2147.a2113(a1022("dųɹͱѰզ\u0611ݤࡠॾ\u0a0dଝఋ൹\u0e68\u0f7e\u1062ᅲቪ፷ᑷᕰᙨᝮᡘ\u193e\u1a5b᭎᱔ᵗḹ\u1f5c⁞⅌≔⍍\u245d┲♆❘⡊⥜⩈⬬ⱏⵃ⹓⽉ぞㅈ㉄㍀㑊㔿㘦") + text + a1022("&"), 0);
		}
		a999.LoadFromString(s);
		a999.Design();
		a1344.a1307();
		if (a2147.a2100(a1022("tţɩ\u0361Ѡն\u0601ݩ\u085b\u093eਜ਼\u0b4e\u0c54\u0d57\u0e39ཛྷ\u105eᅌቔፍᑝᔲᙆ\u1758ᡊᥜᩈᬬᱏᵃṓὉ⁞ⅈ≄⍀⑊┿☦") + text + a1022("&")))
		{
			if (MessageBox.Show(a1022("SŸɪ\u0378ѯխظݓࡿ९\u0a75୪౼റ๗\u0ff3\u1060ᅮቩ፧ᑦᕬᙦ\u1774ᡯᥫᨤ\u1b6eᱫᴾ"), a1022("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.Cancel)
			{
				return;
			}
			a1344.a1271.CommandText = a1022("`Ŧɮ\u0364Ѵ՚ؾݛࡎ\u0954\u0a57ହ\u0c5c൞\u0e4cཔ၍ᅝሲፆᑘᕊᙜᝈᠬ᥏ᩃ᭓᱉ᵞṈὄ\u2040⅊∿⌦") + text + a1022("&");
			try
			{
				a1344.a1271.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(a1022("NŤɰ\u0362иԡ") + ex.Message);
				return;
			}
		}
		a1344.a1271.Parameters.Clear();
		a1344.a1271.CommandText = a1022("\u0010ĖȄ\u0313ЇԀٳܛ\u081fऄ\u0a00୮ఉഅฑ་တᄆቧ፮ᐁᔍᘙᜃ᠘ᤎ\u1a7e᭺ᱴᴐṨύ\u206fⅽ≣⍹⑦╠♡❻⡿⥷⨃⭯ⱦ\u2d78\u2e62⽬\u3000ㄈ㉱㍧㑩㕱㙦㝱㠉㥠㩛㭗㱇㵝㹂㽔䁘䅜䉞䌺䑕䕇䙒䝄䡔䥄䩀䭝䱙䵞乂佄偎儤則升呎啐噊坄堨");
		a1344.a1271.Parameters.Add(a1022("MŁɝ\u0347ќՊق\u0746ࡈ"), SqlDbType.VarChar).Value = text;
		a1344.a1271.Parameters.Add(a1022("_Ŋɜ\u034cќՈ\u0655ݑࡖ\u094a\u0a4c\u0b46"), SqlDbType.NText).Value = a999.SaveToString();
		a1344.a1271.Parameters.Add(a1022("Dŏɗ\u034bч"), SqlDbType.VarChar).Value = a1022("D");
		try
		{
			a1344.a1271.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			MessageBox.Show(a1022("NŤɰ\u0362иԡ") + ex.Message);
		}
	}

	private void a1017(object a1015, EventArgs a1016)
	{
		a1013();
	}

	private void a1020(object a1018, EventArgs a1019)
	{
		a1014();
	}

	private static string a1022(string a1021)
	{
		int length = a1021.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a1021[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
