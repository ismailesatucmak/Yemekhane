using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using a7.a2096;

namespace a7;

public class a613 : XtraForm
{
	private long a531 = -1L;

	private IContainer a532 = null;

	public GroupBox a533;

	public GridControl a534;

	public ContextMenuStrip a535;

	private ToolStripMenuItem a536;

	public ToolStripMenuItem a537;

	public GridView a538;

	public Label a539;

	public Label a540;

	public Label a541;

	public Label a542;

	public Label a543;

	public Label a544;

	public Label a545;

	public TextBox a546;

	public TextBox a547;

	public TextBox a548;

	public Panel a549;

	public Button a550;

	public Button a551;

	public Label a552;

	private GridColumn a553;

	private GridColumn a554;

	private GridColumn a555;

	private GridColumn a556;

	private GridColumn a557;

	private GridColumn a558;

	private GridColumn a559;

	private GridColumn a560;

	public System.Windows.Forms.ComboBox a561;

	public System.Windows.Forms.ComboBox a562;

	private Label a563;

	public Button a564;

	public PictureBox a565;

	public TextBox a566;

	public Label a567;

	public Button a568;

	public TextBox a569;

	private GridColumn a570;

	public System.Windows.Forms.ComboBox a571;

	public System.Windows.Forms.ComboBox a572;

	private Label a573;

	private GridColumn a574;

	public System.Windows.Forms.ComboBox a575;

	private Label a576;

	public a613()
	{
		a610();
		a1984.a1891(this);
		a1984.a1964(a612("rťɓ\u035bўՈػݓ\u085dऴ\u0a56\u0b52\u0c5cഴ๕ཀ\u105eᅝሯፗᑘᕇᙇᝏᡄ᥍\u1a58ᭋ᱀ᵖṈ\u1f47⁛"), a561, a562);
		a571.SelectedIndex = 0;
		a577();
		a575.SelectedIndex = 0;
	}

	public void a577()
	{
		DataTable dataSource = a2147.a2105(a612(">Ŏə\u0357џ՚\u064c\u0737\u085f\u0951ਸ\u0b52\u0c56\u0d42\u0e5fབ၏ᅉሠፀᑟᕅᙄᝆᡈ᥌ᩇᭊ᱃ᵅṉΐ₭↴⊺⎩Ⓙ◕⚳➶⢤⦡⪺⮼Ⲻⶴ⺨⿃ィㆬ㊯㎪㒮㖻㚭㞴㣊㧅㪽㮶㲩㶭㺥㾒䂛䆐䊙䎉䒑䖜䚂䟪䣾䦆䪑䮟䲗䶒亄俯傏冉劅叫和喛嚇垊壦妜媑守岎嶄庍忺惡懰拹揩擱旼曢林棡槽櫱毡泷涑滹濫炓燹犝玅瓳痼監矫磣秨竡篼糯緤绲翀胗臙芵获蓎薨蚶蟎裃觞諘诖賟跔軏迂郋釟鋓鏂铎閥隨韆飂駈髍鯍鲮鷀黄鼲ꀷꄳꈨꌲꐪꔰꙅꝟ꠵ꤴꨧꬶ걒괦길꼪뀠녍눸덚둄딨똬뜪렯뤫멙뭓뱂봵븨뼚쀐셽쉻쌐쐯씵옴윶져졤쨷쩢챵쵱츇켇퀋턃퉬팟푻핧혉휃\ud80b\ud90c\uda0a\udb7e\udc73\udd61\ude14\udf77\ue07b\ue173\ue21c\ue31c\ue468\ue558\ue648\ue758\ue844\ue941\ueac2\ueb41\uec15\ued11\uee75\uef63\uf07d\uf168\uf20c\uf30c\uf473\uf5df\uf646\uf742\uf852樓漢תּﰅﴁ﹥ｑZĴȼ\u035dшՖ\u0655\u0737ࡃ\u0946\u0a51\u0b41\u0c41റไ\u0f3e\u102eᅚቄፎᑘᕌᘨᝆᡍᥑᩍᭅ᰿ᴰ"));
		a534.DataSource = dataSource;
	}

	public void a578()
	{
		a548.Text = a612("");
		a569.Text = a612("");
		a547.Text = a612("");
		a546.Text = a612("");
		a566.Text = a612("");
		a569.Text = a612("");
		a571.SelectedIndex = 0;
	}

	public void a579()
	{
		a572.SelectedIndex = a571.SelectedIndex;
		if (a572.Text != a612("1"))
		{
			a569.Text = a612("NŁɀ\u0343тՅل\u0747");
		}
		if (a548.Text == a612("") || a547.Text == a612("") || a546.Text == a612("") || a569.Text == a612(""))
		{
			MessageBox.Show(a612("mǜɫ\u0378Ѹղػݛࡵॹ\u0a79\u0b7a\u0c74൦༢༲ၓᅿፐጮᑏᐽᙹᝫᡢᥥ\u1a66᭿ᴴᵪἲὸ\u202f"), a612("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		a561.SelectedIndex = a562.SelectedIndex;
		if (a561.Text == a612(""))
		{
			MessageBox.Show(a612("PǧɮͿѽչضݗࡽॡਲଡ଼\u0c75ൽ\u0e65ཨၶᄫ\u125e፨ᑦᐶᙫᝩᡥ\u197aᬳ\u1b6f"), a612("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		if (a569.Text.Length < 8)
		{
			MessageBox.Show(a612("lŇɗ\u0350Ѓլ\u0654ݍࡾ६\u0a7c୯പഺม༸ၼᅷቧ፱ᑸᕦᙴ\u1774ᡪᥠᨭ᭩ᱠᵹṠὣ‧Ⅹ≩⍥⑮╣♻"), a612("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		if (!(a546.Text == a566.Text))
		{
			MessageBox.Show(a612("ĞŖɘ\u034fљ\u0557\u065f\u074b\u0818ॵ\u0a5f\u0b47\u0c56൚เམတᅆቂፈᐌᕞᙓ\u175c\u1977᥊ᩓ᭜\u1c4bᵑḌἁⅾⅶ≸⍯⑹╵♳❣⡱⤷⩂⭰Ɀⵡ\u2e73⽣〰ㅄ㉡㍣㑸㕹㙥㝥㠨㥂㩢㭬㱪㵪㹸㼯"), a612("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			a546.Focus();
			return;
		}
		a1344.a1307();
		if (a531 < 0)
		{
			if (a572.Text == a612("1") && a2147.a2100(a612("uŠɨ\u0366ѡյ\u0600ݖ\u085aऽਗ਼\u0b49\u0c55ൔ\u0e38ག၅ᅐቆፀᐲᕆᙘᝊᡜ᥈ᨬ\u1b40\u1c4bᵛṜὉ⁉⅍≁⍛\u243f┦") + a569.Text + a612("&")))
			{
				MessageBox.Show(a612("dŐȄ\u0368уՓ\u0654\u073fࡐ२\u0a71\u0b7a౨൸\u0e6bฦ\u1036ᅑት፻ᑳᔱᛆᝡᡭᥨᨬ\u1b40ᱫᵰṬὢ\u2062Ⅼ≨⍮⑫\u245e"), a612("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			a1344.a1271.CommandText = a612("\u0095ǽ\u02fdϡӴעۻގ\u08e4\u09e2\u0aff\u0be5ಉ\u0dfd\u0ef4\u0fe3ჷᇷኋᏣᓥᗳᛐ\u17c7ᣜ᧘\u1ab7ᯑ\u1ccc\u1dd4ớῗ\u20db⇝⋐⏛ⓐ◔⛆➢⣞⧅⫍⯘Ⳍⶤ⻌⿇プ㇐㋍㏍㓉㗅㘧㝒㠰㤽㨸㬻㰽㴪㸲㼥䁙䄭䈦䌹䐽䔵䘢䜫䠲䤡䨮䬸䰶䴡丣佊値儯刷匫吧啌嘞圚堐夕娕孳屹崎帖弚怀愑戀捺搑攑昋朝栂椕樊欎汥洈渌漓瀉焈爂猌琈甃癶睿硹祵稗筺籪統繱罤聰脘艳荹葰蕢虻蝠衢襤詮譲谅赨蹪轧遦酥鉧鍰鑤镳阳非顄饉驐魖鱜鵕鹒齉ꁘꅑꉁꍍꑘꕔ꘣Ꝏꡌ\ua947꩟ꭃ걏괤깇꽇끁녉뉊덌됨");
		}
		else
		{
			a1344.a1271.CommandText = a612("\u0099ǭ\u02e7ϲӴנ۶ޒ\u08e4\u09e3૪\u0bfc\u0cfeඌ\u0ef8\u0fefჽᆈዦᏢᓶᗫ\u16fa៣ᣥᦝ\u1adfᯟ\u1cd9\u1dcfỔῃ\u20d8⇜⊻⏝Ⓚ◘⛟⟓⣟⧙⫌⯇Ⳍⷈ⻂⾷ド㇃㋒㏊㓉㗅㛍㟋㣂㧉㨾㬺㰴㵐㸨㼳䀿䄪䈲䍋䐵䔧䘺䜴䠣䤵䩃䬥䰬䴾丿伤倦儠刢匾员唤嘨圣堳头娑嬑尕崙布彶恹愕或挕搔攐昁朗栂業樏欃氌洏渊漎瀛焍爔獪琜甑瘈眎砄礍空筡籰絹繩罥聰腼舊荶葬蕡虸蝾衴襽詪譱豠赩蹹轵遠酬鈋鍧鑮镰陪靤頜饠驞魕鱉鵕鹝鼶ꁘꅜꉚꍟꑛꔩꙓꝓꡕ\ua95dꩆꭀ갭굛깃꽏끛녍눧덏둁딹뙃띋롅");
			a1344.a1271.Parameters.Add(a612("KŅ"), SqlDbType.Int).Value = a531;
		}
		a1344.a1271.Parameters.Add(a612("Fłɖ\u034bњՃم"), SqlDbType.VarChar).Value = a548.Text;
		a1344.a1271.Parameters.Add(a612("GŞɆ\u0345щՉ\u064f\u0746ࡍ\u0942\u0a46\u0b48"), SqlDbType.VarChar).Value = a547.Text;
		a1344.a1271.Parameters.Add(a612("VōɅ\u0350ф"), SqlDbType.VarChar).Value = a546.Text;
		a1344.a1271.Parameters.Add(a612("Bŉɕ\u0352ыՋ\u064b\u0747\u0859"), SqlDbType.VarChar).Value = a569.Text;
		a1344.a1271.Parameters.Add(a612("EņɅ\u0344рՑهݒ"), SqlDbType.VarChar).Value = a1344.a1306();
		a1344.a1271.Parameters.Add(a612("WŘɇ\u0347яՄ\u064dݘࡋ\u0940\u0a56ଡ଼\u0c4b\u0d45"), SqlDbType.Int).Value = Convert.ToInt16(a561.Text);
		a1344.a1271.Parameters.Add(a612("Dŏɗ\u034bч"), SqlDbType.Int).Value = 1;
		a1344.a1271.Parameters.Add(a612("DŀɎ\u034bя"), SqlDbType.Int).Value = Convert.ToInt16(a572.Text);
		try
		{
			a1344.a1271.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
		a577();
		a578();
	}

	public void a580()
	{
		try
		{
			int num = Convert.ToInt32(a538.GetFocusedRowCellValue(a612("KŅ")).ToString());
			if (MessageBox.Show(a612("gŞɆ\u0345щՉܗ\u0746कग़ଓ\u0b01\u0c73൶\u0e72\u0f70ၹᅰሺሩᑫᕣᙳ\u1771\u187d\u180c\u1a7b᭿ᱹᵵṫἭ⁉Ⅶ≣⍧⑥╮♵❬⡪⥪⩸⬯"), a612("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.Cancel)
			{
				return;
			}
			a2147.a2128(a612("wűɤ\u035eъ\u0558ؼݎࡉड़\u0a4a\u0b44శ\u0d46๑ཇ\u1032ᅐቛ\u135bᑇᕋᘱ\u173bᠪᥞᩀ\u1b42᱔ᵀḤὊ⁆ℼ") + num, a612("BŠɨ\u0366Ѷդ"));
		}
		catch
		{
		}
		a577();
	}

	public void a581()
	{
		try
		{
			a531 = Convert.ToInt32(a538.GetFocusedRowCellValue(a612("KŅ")).ToString());
			a548.Text = a538.GetFocusedRowCellValue(a612("Fłɖ\u034bњՃم")).ToString();
			a547.Text = a538.GetFocusedRowCellValue(a612("GŞɆ\u0345щՉ\u064f\u0746ࡍ\u0942\u0a46\u0b48")).ToString();
			a546.Text = a538.GetFocusedRowCellValue(a612("VōɅ\u0350ф")).ToString();
			a566.Text = a538.GetFocusedRowCellValue(a612("VōɅ\u0350ф")).ToString();
			a569.Text = a538.GetFocusedRowCellValue(a612("Bŉɕ\u0352ыՋ\u064b\u0747\u0859")).ToString();
			a562.SelectedIndex = a561.Items.IndexOf(a538.GetFocusedRowCellValue(a612("WŘɇ\u0347яՄ\u064dݘࡋ\u0940\u0a56ଡ଼\u0c4b\u0d45")).ToString());
			a571.SelectedIndex = a572.Items.IndexOf(a538.GetFocusedRowCellValue(a612("DŀɎ\u034bя")).ToString());
		}
		catch
		{
		}
	}

	private void a584(object a582, EventArgs a583)
	{
		a579();
	}

	private void a587(object a585, EventArgs a586)
	{
		a531 = -1L;
		a579();
	}

	private void a590(object a588, EventArgs a589)
	{
		a821 a2269 = new a821();
		a2006 a2270 = new a2006(a2269, 30);
		a2270.ShowDialog();
		a1984.a1964(a612("rťɓ\u035bўՈػݓ\u085dऴ\u0a56\u0b52\u0c5cഴ๕ཀ\u105eᅝሯፗᑘᕇᙇᝏᡄ᥍\u1a58ᭋ᱀ᵖṈ\u1f47⁛"), a561, a562);
	}

	private void a593(object a591, EventArgs a592)
	{
		a580();
	}

	private void a596(object a594, EventArgs a595)
	{
	}

	private void a599(object a597, EventArgs a598)
	{
		a569.Text = a1344.a1303();
	}

	private void a602(object a600, KeyPressEventArgs a601)
	{
	}

	private void a605(object a603, EventArgs a604)
	{
		a581();
	}

	private void a608(object a606, EventArgs a607)
	{
		a581();
	}

	protected override void Dispose(bool a609)
	{
		if (a609 && a532 != null)
		{
			a532.Dispose();
		}
		base.Dispose(a609);
	}

	private void a610()
	{
		a532 = new Container();
		a533 = new GroupBox();
		a571 = new System.Windows.Forms.ComboBox();
		a568 = new Button();
		a569 = new TextBox();
		a566 = new TextBox();
		a565 = new PictureBox();
		a564 = new Button();
		a562 = new System.Windows.Forms.ComboBox();
		a573 = new Label();
		a563 = new Label();
		a534 = new GridControl();
		a535 = new ContextMenuStrip(a532);
		a536 = new ToolStripMenuItem();
		a537 = new ToolStripMenuItem();
		a538 = new GridView();
		a553 = new GridColumn();
		a554 = new GridColumn();
		a555 = new GridColumn();
		a556 = new GridColumn();
		a557 = new GridColumn();
		a558 = new GridColumn();
		a559 = new GridColumn();
		a570 = new GridColumn();
		a560 = new GridColumn();
		a574 = new GridColumn();
		a539 = new Label();
		a540 = new Label();
		a541 = new Label();
		a542 = new Label();
		a552 = new Label();
		a567 = new Label();
		a543 = new Label();
		a544 = new Label();
		a545 = new Label();
		a546 = new TextBox();
		a547 = new TextBox();
		a548 = new TextBox();
		a572 = new System.Windows.Forms.ComboBox();
		a561 = new System.Windows.Forms.ComboBox();
		a549 = new Panel();
		a550 = new Button();
		a551 = new Button();
		a576 = new Label();
		a575 = new System.Windows.Forms.ComboBox();
		a533.SuspendLayout();
		((ISupportInitialize)a565).BeginInit();
		((ISupportInitialize)a534).BeginInit();
		a535.SuspendLayout();
		((ISupportInitialize)a538).BeginInit();
		a549.SuspendLayout();
		SuspendLayout();
		a533.Controls.Add(a575);
		a533.Controls.Add(a571);
		a533.Controls.Add(a568);
		a533.Controls.Add(a569);
		a533.Controls.Add(a566);
		a533.Controls.Add(a565);
		a533.Controls.Add(a564);
		a533.Controls.Add(a576);
		a533.Controls.Add(a562);
		a533.Controls.Add(a573);
		a533.Controls.Add(a563);
		a533.Controls.Add(a534);
		a533.Controls.Add(a539);
		a533.Controls.Add(a540);
		a533.Controls.Add(a541);
		a533.Controls.Add(a542);
		a533.Controls.Add(a552);
		a533.Controls.Add(a567);
		a533.Controls.Add(a543);
		a533.Controls.Add(a544);
		a533.Controls.Add(a545);
		a533.Controls.Add(a546);
		a533.Controls.Add(a547);
		a533.Controls.Add(a548);
		a533.Location = new Point(10, 2);
		a533.Name = a612("nźɨͳѵՆ٬ݺ࠰");
		a533.Size = new Size(775, 566);
		a533.TabIndex = 0;
		a533.TabStop = false;
		a571.DropDownStyle = ComboBoxStyle.DropDownList;
		a571.Font = new Font(a612("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a571.FormattingEnabled = true;
		a571.Items.AddRange(new object[3]
		{
			a612("BŽɫ\u036aѤժ\u0732ݡर"),
			a612("ZŦɶ\u036aѶշ۴ݳ"),
			a612("QǱɨ\u0360Ѱժ١ݨ")
		});
		a571.Location = new Point(97, 162);
		a571.Name = a612("hŨɎ\u0361ѵկٶݐࡪॲ੨");
		a571.Size = new Size(268, 26);
		a571.TabIndex = 5;
		a568.Image = a2268.a2305;
		a568.ImageAlign = ContentAlignment.MiddleLeft;
		a568.Location = new Point(262, 215);
		a568.Name = a612("kżɩ\u034dѤնٷ\u074c\u086e");
		a568.Size = new Size(42, 33);
		a568.TabIndex = 7;
		a568.UseVisualStyleBackColor = true;
		a568.Click += a599;
		a569.Font = new Font(a612("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 15.75f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a569.Location = new Point(97, 216);
		a569.MaxLength = 8;
		a569.Name = a612("}Űɳ\u034dѤնٷ\u074c\u086e");
		a569.Size = new Size(165, 31);
		a569.TabIndex = 6;
		a569.KeyPress += a602;
		a566.Font = new Font(a612("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a566.Location = new Point(97, 107);
		a566.Name = a612("zŵɸ\u0358ѣկٺݢࡒॠ੯ୱ\u0c63൳");
		a566.PasswordChar = '*';
		a566.Size = new Size(268, 26);
		a566.TabIndex = 3;
		a565.Image = a2268.a2276;
		a565.Location = new Point(452, 10);
		a565.Name = a612("{ţɪͼѲմ٠\u0746\u086cॺਰ");
		a565.Size = new Size(317, 221);
		a565.TabIndex = 86;
		a565.TabStop = false;
		a564.BackColor = Color.White;
		a564.Font = new Font(a612("RŤɬ\u036cѯՠ"), 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a564.ForeColor = Color.Black;
		a564.Location = new Point(337, 133);
		a564.Name = a612("oŸɥ\u0347Ѭպ٬ݣࡿ\u0941੨୮\u0c64");
		a564.Size = new Size(29, 29);
		a564.TabIndex = 85;
		a564.Text = a612("*");
		a564.UseVisualStyleBackColor = false;
		a564.Click += a590;
		a562.DropDownStyle = ComboBoxStyle.DropDownList;
		a562.Font = new Font(a612("RŤɬ\u036cѯՠ"), 12f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a562.FormattingEnabled = true;
		a562.Location = new Point(97, 134);
		a562.Name = a612("kťɋ\u0360Ѷը٧ݻ");
		a562.Size = new Size(240, 27);
		a562.TabIndex = 4;
		a573.AutoSize = true;
		a573.Location = new Point(20, 169);
		a573.Name = a612("kŧɧ\u0361ѯԳذ");
		a573.Size = new Size(63, 13);
		a573.TabIndex = 61;
		a573.Text = a612("EŸɠ\u0367ѫէ\u0739ݤषथ\u0a50୪\u0c72൨");
		a563.AutoSize = true;
		a563.Location = new Point(20, 142);
		a563.Name = a612("jŤɦ\u0366ѮԸ");
		a563.Size = new Size(41, 13);
		a563.TabIndex = 61;
		a563.Text = a612("KŠɶ\u0368ѧջ");
		a534.ContextMenuStrip = a535;
		a534.EmbeddedNavigator.Name = a612("");
		a534.Font = new Font(a612("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a534.Location = new Point(14, 298);
		a534.LookAndFeel.SkinName = a612("GżɻͳѯՖ٭ݨ\u086b९");
		a534.LookAndFeel.UseDefaultLookAndFeel = false;
		a534.MainView = a538;
		a534.Name = a612("kŹɣ\u036dыը٨ݱࡶ६੮ର");
		a534.Size = new Size(749, 197);
		a534.TabIndex = 8;
		a534.ViewCollection.AddRange(new BaseView[1] { a538 });
		a534.DoubleClick += a608;
		a535.Items.AddRange(new ToolStripItem[2] { a536, a537 });
		a535.Name = a612("rſɡͺѨմٿ\u0747\u086c०ੲ\u0b55\u0c71൶\u0e6a\u0f72\u1030");
		a535.Size = new Size(137, 80);
		a536.Image = a2268.a2289;
		a536.ImageScaling = ToolStripItemImageScaling.None;
		a536.Name = a612("~Ǥɹ\u0375Ѱոٿݷࡅॿ\u0a60\u0b62\u0c5e൸\u0e79ལၹᅅቢ፨ᑰᕍᙷᝧᡬ");
		a536.Size = new Size(136, 38);
		a536.Text = a612("Oǻɨ\u0366ѡկٮݤ");
		a536.Click += a605;
		a537.Image = a2268.a2341;
		a537.ImageScaling = ToolStripItemImageScaling.None;
		a537.Name = a612("gźɾ\u0345ѿՠ٢ݞࡸॹ\u0a63\u0b79\u0c45\u0d62\u0e68\u0f70၍ᅷቧ፬");
		a537.Size = new Size(136, 38);
		a537.Text = a612("Pūɭ");
		a537.Click += a593;
		a538.BorderStyle = BorderStyles.NoBorder;
		a538.Columns.AddRange(new GridColumn[10] { a553, a554, a555, a556, a557, a558, a559, a570, a560, a574 });
		a538.FocusRectStyle = DrawFocusRectStyle.RowFocus;
		a538.GridControl = a534;
		a538.Name = a612("nźɮ\u0362ѓխ٦ݵ࠰");
		a538.OptionsBehavior.Editable = false;
		a538.OptionsCustomization.AllowFilter = false;
		a538.OptionsCustomization.AllowGroup = false;
		a538.OptionsCustomization.AllowSort = false;
		a538.OptionsFilter.AllowFilterEditor = false;
		a538.OptionsView.ShowGroupPanel = false;
		a553.Caption = a612("KŅ");
		a553.FieldName = a612("KŅ");
		a553.Name = a612("lŸɠ\u036cфթ٩ݱ\u086e६ਰ");
		a554.Caption = a612("Kŭ\u0339\u0327ѕժٽݢࡦ࠰");
		a554.FieldName = a612("Fłɖ\u034bњՃم");
		a554.Name = a612("lŸɠ\u036cфթ٩ݱ\u086e६ਲ਼");
		a554.Visible = true;
		a554.VisibleIndex = 0;
		a554.Width = 123;
		a555.Caption = a612("FŹɧ\u0366Ѩզ\u0736ݥऴत\u0a42୦ര");
		a555.FieldName = a612("GŞɆ\u0345щՉ\u064f\u0746ࡍ\u0942\u0a46\u0b48");
		a555.Name = a612("lŸɠ\u036cфթ٩ݱ\u086e६ਲ");
		a555.Visible = true;
		a555.VisibleIndex = 1;
		a555.Width = 146;
		a556.Caption = a612("VŭɥͰѤ");
		a556.FieldName = a612("VōɅ\u0350ф");
		a556.Name = a612("lŸɠ\u036cфթ٩ݱ\u086e६ਵ");
		a556.Width = 130;
		a557.Caption = a612("LŧɷͰУՌٮ");
		a557.FieldName = a612("Bŉɕ\u0352ыՋ\u064b\u0747\u0859");
		a557.Name = a612("lŸɠ\u036cфթ٩ݱ\u086e६\u0a34");
		a557.Visible = true;
		a557.VisibleIndex = 3;
		a557.Width = 111;
		a558.Caption = a612("Dũɤ\u0326фՠٱݧࡲ");
		a558.FieldName = a612("EņɅ\u0344рՑهݒ");
		a558.Name = a612("lŸɠ\u036cфթ٩ݱ\u086e६\u0a37");
		a558.Width = 104;
		a559.Caption = a612("Vǲɦ\u0360Ѯէ٬ܨࡊ\u0963\u0a77୯౦൸\u0e68");
		a559.FieldName = a612("Třɀ\u0346ьՅق\u074bࡀ\u0956\u0a48\u0b47\u0c5b");
		a559.Name = a612("lŸɠ\u036cфթ٩ݱ\u086e६ਸ਼");
		a559.Visible = true;
		a559.VisibleIndex = 2;
		a559.Width = 231;
		a570.Caption = a612("Dŭɵ\u036dѠվأ\u074bࡅ");
		a570.FieldName = a612("WŘɇ\u0347яՄ\u064dݘࡋ\u0940\u0a56ଡ଼\u0c4b\u0d45");
		a570.Name = a612("lŸɠ\u036cфթ٩ݱ\u086e६ਸ");
		a560.Caption = a612("DŠɮ\u036bѯ");
		a560.FieldName = a612("DŀɎ\u034bя");
		a560.Name = a612("lŸɠ\u036cфթ٩ݱ\u086e६ਹ");
		a560.Width = 49;
		a574.Caption = a612("EŸɠ\u0367ѫէ\u0739ݤषथ\u0a50୪\u0c72൨");
		a574.FieldName = a612("HŌɊ\u034fыՐيݒࡈ");
		a574.Name = a612("kŹɣ\u036dыը٪ݰࡩ७ਲ਼\u0b31");
		a574.Visible = true;
		a574.VisibleIndex = 4;
		a574.Width = 121;
		a539.AutoSize = true;
		a539.Location = new Point(20, 253);
		a539.Name = a612("jŤɦ\u0366ѮԲ");
		a539.Size = new Size(548, 13);
		a539.TabIndex = 59;
		a539.Text = a612("5ĈȐ\u0317Лԗ\u0749ܔ\u0947\u0955ਸ਼ଚఞഖน༃ဋᄟህጅᐃᕉᘄល᠒ᤃᨁᬍ᱂ᴥḉἴ‵ℼ∨⌷\u2433┺☽❷⠑⤼⨦⬺ⰼⴸ⸪⽡のㄌ㈨㌦㐣㔧㙨㜞㠣㤱㨯㬪㰱㴨㸮㽚䀞䅎䉝䍓䑓䕉䘘䝘䡚䥔䩚䬓䱙䵄乜佃偏元匝午唛唉噑坆塂奄娄孈屗嵍幌彾恰怬承截摶數晪朷桴楠樴歵汽浣湽潺瀮煪狺獹瑯畫癡睫硯祷穨筦籰累");
		a540.AutoSize = true;
		a540.Font = new Font(a612("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a540.Location = new Point(17, 278);
		a540.Name = a612("jŤɦ\u0366Ѯ\u0530");
		a540.Size = new Size(92, 13);
		a540.TabIndex = 55;
		a540.Text = a612("Zťɣ\u0362Ѭբ\u073aݩसन\u0a4b୯\u0c76൰\u0e66\u0f71\u1068");
		a541.BackColor = Color.FromArgb(128, 255, 128);
		a541.BorderStyle = BorderStyle.Fixed3D;
		a541.FlatStyle = FlatStyle.Flat;
		a541.ForeColor = Color.DarkOrange;
		a541.Location = new Point(16, 270);
		a541.Name = a612("kŧɧ\u0361ѯԳز");
		a541.Size = new Size(745, 3);
		a541.TabIndex = 54;
		a542.AutoSize = true;
		a542.Font = new Font(a612("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a542.Location = new Point(11, 10);
		a542.Name = a612("jŤɦ\u0366ѮԹ");
		a542.Size = new Size(97, 13);
		a542.TabIndex = 0;
		a542.Text = a612("XŧɽͼѮՠ\u073cݯ\u093aप\u0a4bୡ౫ൡ\u0e6cཨၦᅰቨ");
		a552.AutoSize = true;
		a552.Location = new Point(20, 227);
		a552.Name = a612("jŤɦ\u0366ѮԶ");
		a552.Size = new Size(43, 13);
		a552.TabIndex = 49;
		a552.Text = a612("LŧɷͰУՌٮ");
		a567.AutoSize = true;
		a567.Location = new Point(20, 115);
		a567.Name = a612("kŧɧ\u0361ѯԳر");
		a567.Size = new Size(63, 13);
		a567.TabIndex = 49;
		a567.Text = a612("ŒŢɬͻѭԧ\u0652ݠ\u086fॱ\u0a63୳");
		a543.AutoSize = true;
		a543.Location = new Point(20, 88);
		a543.Name = a612("jŤɦ\u0366ѮԴ");
		a543.Size = new Size(29, 13);
		a543.TabIndex = 49;
		a543.Text = a612("śŭɥͰѤ");
		a544.AutoSize = true;
		a544.Location = new Point(20, 61);
		a544.Name = a612("jŤɦ\u0366ѮԵ");
		a544.Size = new Size(62, 13);
		a544.TabIndex = 49;
		a544.Text = a612("FŹɧ\u0366Ѩզ\u0736ݥऴत\u0a42୦ര");
		a545.AutoSize = true;
		a545.Location = new Point(20, 34);
		a545.Name = a612("jŤɦ\u0366ѮԷ");
		a545.Size = new Size(57, 13);
		a545.TabIndex = 49;
		a545.Text = a612("Kŭ\u0339\u0327ѕժٽݢࡦ࠰");
		a546.Font = new Font(a612("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a546.Location = new Point(97, 80);
		a546.Name = a612("|ſɲ\u0356ѭե\u0670ݤ");
		a546.PasswordChar = '*';
		a546.Size = new Size(268, 26);
		a546.TabIndex = 2;
		a547.Font = new Font(a612("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a547.Location = new Point(97, 53);
		a547.Name = a612("{Ŷɹ\u0347Ѿզ٥ݩࡩ९੦୭\u0c42൦\u0e68");
		a547.Size = new Size(268, 26);
		a547.TabIndex = 1;
		a548.Font = new Font(a612("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a548.Location = new Point(97, 26);
		a548.Name = a612("xųɾ\u0348Ѭծ\u0655ݪࡽ\u0962੦୨");
		a548.Size = new Size(268, 26);
		a548.TabIndex = 0;
		a572.DropDownStyle = ComboBoxStyle.DropDownList;
		a572.Font = new Font(a612("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a572.FormattingEnabled = true;
		a572.Items.AddRange(new object[3]
		{
			a612("1"),
			a612("0"),
			a612("3")
		});
		a572.Location = new Point(839, 209);
		a572.Name = a612("nŮɌ\u0363ѻաٴݒ\u086cॴ੪\u0b4b\u0c45");
		a572.Size = new Size(43, 26);
		a572.TabIndex = 89;
		a561.DropDownStyle = ComboBoxStyle.DropDownList;
		a561.Font = new Font(a612("RŤɬ\u036cѯՠ"), 12f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a561.FormattingEnabled = true;
		a561.Location = new Point(839, 176);
		a561.Name = a612("iūɅ\u0362Ѵծ١ݹࡋ\u0945");
		a561.Size = new Size(35, 27);
		a561.TabIndex = 62;
		a549.BackColor = Color.FromArgb(233, 235, 236);
		a549.Controls.Add(a550);
		a549.Controls.Add(a551);
		a549.Dock = DockStyle.Bottom;
		a549.Location = new Point(0, 574);
		a549.Name = a612("vŤɪ\u0366Ѯ\u0530");
		a549.Size = new Size(791, 37);
		a549.TabIndex = 1;
		a550.Dock = DockStyle.Fill;
		a550.Location = new Point(366, 0);
		a550.Name = a612("jųɨ\u0346ѭը٫ݲ");
		a550.Size = new Size(425, 37);
		a550.TabIndex = 1;
		a550.Text = a612("Oǻɨ\u0366ѡկٮݤ");
		a550.UseVisualStyleBackColor = true;
		a550.Click += a584;
		a551.Dock = DockStyle.Left;
		a551.Location = new Point(0, 0);
		a551.Name = a612("kżɩ\u034dѤս٧ݧࡵ");
		a551.Size = new Size(366, 37);
		a551.TabIndex = 0;
		a551.Text = a612("MŤɽ\u0367ѧյ");
		a551.UseVisualStyleBackColor = true;
		a551.Click += a587;
		a576.AutoSize = true;
		a576.Location = new Point(20, 197);
		a576.Name = a612("jŤɦ\u0366ѮԳ");
		a576.Size = new Size(21, 13);
		a576.TabIndex = 61;
		a576.Text = a612("Wūɱ");
		a575.DropDownStyle = ComboBoxStyle.DropDownList;
		a575.Font = new Font(a612("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a575.FormattingEnabled = true;
		a575.Items.AddRange(new object[3]
		{
			a612("Xłɔ\u0356ыՍهݍ"),
			a612("TŇɃ"),
			a612("Iőɋ\u034eуՕ")
		});
		a575.Location = new Point(97, 189);
		a575.Name = a612("fŦɗ\u036bѱ");
		a575.Size = new Size(207, 26);
		a575.TabIndex = 5;
		Appearance.BackColor = Color.White;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(791, 611);
		Controls.Add(a572);
		Controls.Add(a533);
		Controls.Add(a561);
		Controls.Add(a549);
		MaximizeBox = false;
		MaximumSize = new Size(807, 650);
		Name = a612("Kžɦ\u035fѺխٵݵࡑ॥੭୫౬");
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a612("XŧɽͼѮՠ\u073cݯ\u093aप\u0a5d୩౩ష\u0e68ཨ\u1062ᅯበ");
		a533.ResumeLayout(performLayout: false);
		a533.PerformLayout();
		((ISupportInitialize)a565).EndInit();
		((ISupportInitialize)a534).EndInit();
		a535.ResumeLayout(performLayout: false);
		((ISupportInitialize)a538).EndInit();
		a549.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	private static string a612(string a611)
	{
		int length = a611.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a611[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
