using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using a7.a2096;

namespace a7;

public class a2086 : XtraForm
{
	private IContainer a2009 = null;

	public GridControl a2010;

	public ContextMenuStrip a2011;

	private ToolStripMenuItem a2012;

	public ToolStripMenuItem a2013;

	public GridView a2014;

	public System.Windows.Forms.ComboBox a2015;

	public GroupBox a2016;

	public Label a2017;

	public Label a2018;

	public Label a2019;

	public Label a2020;

	public Label a2021;

	public Label a2022;

	public Label a2023;

	public TextBox a2024;

	public Panel a2025;

	public Button a2026;

	public Button a2027;

	public System.Windows.Forms.ComboBox a2028;

	public Label a2029;

	public TextBox a2030;

	private PictureBox a2031;

	private GridColumn a2032;

	private GridColumn a2033;

	private GridColumn a2034;

	private GridColumn a2035;

	private GridColumn a2036;

	public Button a2037;

	public Label a2038;

	public Label a2039;

	public Label a2040;

	private CheckedListBox a2041;

	private CheckedListBox a2042;

	public Label a2043;

	public TextBox a2044;

	private GridColumn a2045;

	private GridColumn a2046;

	private CheckEdit a2047;

	private GridColumn a2048;

	private CheckEdit a2049;

	private GridColumn a2050;

	private RepositoryItemCheckEdit a2051;

	private long a2052 = -1L;

	protected override void Dispose(bool a2053)
	{
		if (a2053 && a2009 != null)
		{
			a2009.Dispose();
		}
		base.Dispose(a2053);
	}

	private void a2054()
	{
		a2009 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(a2086));
		a2010 = new GridControl();
		a2011 = new ContextMenuStrip(a2009);
		a2012 = new ToolStripMenuItem();
		a2013 = new ToolStripMenuItem();
		a2014 = new GridView();
		a2048 = new GridColumn();
		a2032 = new GridColumn();
		a2033 = new GridColumn();
		a2034 = new GridColumn();
		a2035 = new GridColumn();
		a2036 = new GridColumn();
		a2045 = new GridColumn();
		a2046 = new GridColumn();
		a2015 = new System.Windows.Forms.ComboBox();
		a2016 = new GroupBox();
		a2047 = new CheckEdit();
		a2040 = new Label();
		a2043 = new Label();
		a2044 = new TextBox();
		a2041 = new CheckedListBox();
		a2037 = new Button();
		a2017 = new Label();
		a2039 = new Label();
		a2018 = new Label();
		a2019 = new Label();
		a2020 = new Label();
		a2021 = new Label();
		a2038 = new Label();
		a2029 = new Label();
		a2022 = new Label();
		a2023 = new Label();
		a2030 = new TextBox();
		a2024 = new TextBox();
		a2031 = new PictureBox();
		a2025 = new Panel();
		a2026 = new Button();
		a2027 = new Button();
		a2028 = new System.Windows.Forms.ComboBox();
		a2042 = new CheckedListBox();
		a2049 = new CheckEdit();
		a2050 = new GridColumn();
		a2051 = new RepositoryItemCheckEdit();
		((ISupportInitialize)a2010).BeginInit();
		a2011.SuspendLayout();
		((ISupportInitialize)a2014).BeginInit();
		a2016.SuspendLayout();
		((ISupportInitialize)a2047.Properties).BeginInit();
		((ISupportInitialize)a2031).BeginInit();
		a2025.SuspendLayout();
		((ISupportInitialize)a2049.Properties).BeginInit();
		((ISupportInitialize)a2051).BeginInit();
		SuspendLayout();
		a2010.ContextMenuStrip = a2011;
		a2010.EmbeddedNavigator.Name = a2085("");
		a2010.Font = new Font(a2085("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a2010.Location = new Point(10, 295);
		a2010.LookAndFeel.SkinName = a2085("GżɻͳѯՖ٭ݨ\u086b९");
		a2010.LookAndFeel.UseDefaultLookAndFeel = false;
		a2010.MainView = a2014;
		a2010.Name = a2085("kŹɣ\u036dыը٨ݱࡶ६੮ର");
		a2010.RepositoryItems.AddRange(new RepositoryItem[1] { a2051 });
		a2010.Size = new Size(826, 286);
		a2010.TabIndex = 7;
		a2010.ViewCollection.AddRange(new BaseView[1] { a2014 });
		a2010.DoubleClick += a2083;
		a2011.Items.AddRange(new ToolStripItem[2] { a2012, a2013 });
		a2011.Name = a2085("rſɡͺѨմٿ\u0747\u086c०ੲ\u0b55\u0c71൶\u0e6a\u0f72\u1030");
		a2011.Size = new Size(137, 80);
		a2012.Image = a2268.a2289;
		a2012.ImageScaling = ToolStripItemImageScaling.None;
		a2012.Name = a2085("~Ǥɹ\u0375Ѱոٿݷࡅॿ\u0a60\u0b62\u0c5e൸\u0e79ལၹᅅቢ፨ᑰᕍᙷᝧᡬ");
		a2012.Size = new Size(136, 38);
		a2012.Text = a2085("Oǻɨ\u0366ѡկٮݤ");
		a2012.Click += a2074;
		a2013.Image = a2268.a2341;
		a2013.ImageScaling = ToolStripItemImageScaling.None;
		a2013.Name = a2085("gźɾ\u0345ѿՠ٢ݞࡸॹ\u0a63\u0b79\u0c45\u0d62\u0e68\u0f70၍ᅷቧ፬");
		a2013.Size = new Size(136, 38);
		a2013.Text = a2085("Pūɭ");
		a2013.Click += a2071;
		a2014.BorderStyle = BorderStyles.NoBorder;
		a2014.Columns.AddRange(new GridColumn[9] { a2048, a2032, a2033, a2034, a2035, a2036, a2045, a2046, a2050 });
		a2014.FocusRectStyle = DrawFocusRectStyle.RowFocus;
		a2014.GridControl = a2010;
		a2014.Name = a2085("nźɮ\u0362ѓխ٦ݵ࠰");
		a2014.OptionsBehavior.Editable = false;
		a2014.OptionsCustomization.AllowFilter = false;
		a2014.OptionsCustomization.AllowGroup = false;
		a2014.OptionsCustomization.AllowSort = false;
		a2014.OptionsFilter.AllowFilterEditor = false;
		a2014.OptionsView.ShowGroupPanel = false;
		a2048.Caption = a2085("KŅ");
		a2048.FieldName = a2085("KŅ");
		a2048.Name = a2085("lŸɠ\u036cфթ٩ݱ\u086e६ਰ");
		a2032.Caption = a2085("Jšɯ\u0367ѿԤ\u064eݣࡢ");
		a2032.FieldName = a2085("JŁɏ\u0347џ՛\u064e\u0743ࡂ");
		a2032.Name = a2085("lŸɠ\u036cфթ٩ݱ\u086e६ਲ਼");
		a2032.Visible = true;
		a2032.VisibleIndex = 0;
		a2032.Width = 151;
		a2033.Caption = a2085("IǠ\u0337\u036eѨբٯݠ");
		a2033.FieldName = a2085("KŎɎ\u0344ў՜\u064bݑ");
		a2033.Name = a2085("lŸɠ\u036cфթ٩ݱ\u086e६ਲ");
		a2033.Visible = true;
		a2033.VisibleIndex = 1;
		a2033.Width = 230;
		a2034.Caption = a2085("TŬɰ\u0375");
		a2034.FieldName = a2085("TŌɐ\u0355");
		a2034.Name = a2085("lŸɠ\u036cфթ٩ݱ\u086e६ਵ");
		a2034.Width = 53;
		a2035.Caption = a2085("KŠɶ\u0368ѧջ");
		a2035.FieldName = a2085("Kŀɖ\u0348ч՛");
		a2035.Name = a2085("lŸɠ\u036cфթ٩ݱ\u086e६\u0a37");
		a2035.Visible = true;
		a2035.VisibleIndex = 2;
		a2035.Width = 270;
		a2036.Caption = a2085("Dŭɵ\u036dѠվأ\u074bࡅ");
		a2036.FieldName = a2085("HŅɄ\u0342шՁ\u064eݕࡄ\u094d\u0a55\u0b4d\u0c40൞\u0e5cཋ၅");
		a2036.Name = a2085("lŸɠ\u036cфթ٩ݱ\u086e६\u0a34");
		a2045.AppearanceHeader.Options.UseTextOptions = true;
		a2045.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Far;
		a2045.Caption = a2085("_ŮɸͿѡԧلݠࡠ०੮୨");
		a2045.FieldName = a2085("^ŉə\u035cр՛\u0658\u0744ࡀ\u0940\u0a46\u0b4e\u0c48");
		a2045.Name = a2085("lŸɠ\u036cфթ٩ݱ\u086e६ਸ਼");
		a2045.Visible = true;
		a2045.VisibleIndex = 3;
		a2045.Width = 88;
		a2046.Caption = a2085("HŨɣ\u036eѿՠؤ\u0744\u08f4ॳ");
		a2046.FieldName = a2085("HňɃ\u034eџՀ\u065b\u0744ࡍ\u0953");
		a2046.Name = a2085("lŸɠ\u036cфթ٩ݱ\u086e६ਹ");
		a2046.Visible = true;
		a2046.VisibleIndex = 4;
		a2046.Width = 70;
		a2015.DropDownStyle = ComboBoxStyle.DropDownList;
		a2015.Font = new Font(a2085("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a2015.FormattingEnabled = true;
		a2015.Location = new Point(125, 54);
		a2015.Name = a2085("kťɋ\u0360Ѷը٧ݻ");
		a2015.Size = new Size(269, 26);
		a2015.TabIndex = 2;
		a2016.Controls.Add(a2049);
		a2016.Controls.Add(a2047);
		a2016.Controls.Add(a2040);
		a2016.Controls.Add(a2043);
		a2016.Controls.Add(a2044);
		a2016.Controls.Add(a2041);
		a2016.Controls.Add(a2037);
		a2016.Controls.Add(a2015);
		a2016.Controls.Add(a2010);
		a2016.Controls.Add(a2017);
		a2016.Controls.Add(a2039);
		a2016.Controls.Add(a2018);
		a2016.Controls.Add(a2019);
		a2016.Controls.Add(a2020);
		a2016.Controls.Add(a2021);
		a2016.Controls.Add(a2038);
		a2016.Controls.Add(a2029);
		a2016.Controls.Add(a2022);
		a2016.Controls.Add(a2023);
		a2016.Controls.Add(a2030);
		a2016.Controls.Add(a2024);
		a2016.Controls.Add(a2031);
		a2016.Location = new Point(8, -5);
		a2016.Name = a2085("nźɨͳѵՆ٬ݺ࠰");
		a2016.Size = new Size(849, 599);
		a2016.TabIndex = 0;
		a2016.TabStop = false;
		a2047.Location = new Point(204, 111);
		a2047.Name = a2085("išɎ\u036eѿդ\u0670\u0744\u086dॳ");
		a2047.Properties.Appearance.Font = new Font(a2085("RŤɬ\u036cѯՠ"), 10f);
		a2047.Properties.Appearance.Options.UseFont = true;
		a2047.Properties.Caption = a2085("bžɵʹѥվغݞ\u08ee॥ਸ਼\u0b56౽ൻ\u0e73ཫᄡᄯቁ፡ᑭᕹᙫᝢᠨᥓ\u1a67\u1b6bᴵᵮṮὠ");
		a2047.Size = new Size(219, 21);
		a2047.TabIndex = 91;
		a2040.AutoSize = true;
		a2040.Font = new Font(a2085("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a2040.Location = new Point(428, 148);
		a2040.Name = a2085("kŧɧ\u0361ѯԳر");
		a2040.Size = new Size(43, 13);
		a2040.TabIndex = 0;
		a2040.Text = a2085("RſɤͶԲԢػ");
		a2043.AutoSize = true;
		a2043.Location = new Point(22, 116);
		a2043.Name = a2085("kŧɧ\u0361ѯԳذ");
		a2043.Size = new Size(67, 13);
		a2043.TabIndex = 90;
		a2043.Text = a2085("^ũɹͼѠջا\u0744ࡠॠ੦୮౨");
		a2044.Font = new Font(a2085("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a2044.Location = new Point(125, 108);
		a2044.MaxLength = 5;
		a2044.Name = a2085("{Ŷɹ\u035fѮոٿݡࡴ\u0944\u0a60ୠ౦൮\u0e68");
		a2044.Size = new Size(73, 26);
		a2044.TabIndex = 4;
		a2044.Text = a2085("4įȲ\u0331");
		a2044.TextAlign = HorizontalAlignment.Right;
		a2041.CheckOnClick = true;
		a2041.FormattingEnabled = true;
		a2041.Location = new Point(125, 161);
		a2041.Name = a2085("nŤɇ\u0363Ѻռـݴࡰॴ\u0a42୦౨");
		a2041.Size = new Size(297, 84);
		a2041.TabIndex = 5;
		a2037.BackColor = Color.White;
		a2037.Font = new Font(a2085("RŤɬ\u036cѯՠ"), 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a2037.ForeColor = Color.Black;
		a2037.Location = new Point(394, 53);
		a2037.Name = a2085("oŸɥ\u0347Ѭպ٬ݣࡿ\u0941੨୮\u0c64");
		a2037.Size = new Size(29, 28);
		a2037.TabIndex = 86;
		a2037.Text = a2085("*");
		a2037.UseVisualStyleBackColor = false;
		a2037.Click += a2077;
		a2017.AutoSize = true;
		a2017.Location = new Point(2, 585);
		a2017.Name = a2085("jŤɦ\u0366ѮԳ");
		a2017.Size = new Size(255, 13);
		a2017.TabIndex = 60;
		a2017.Text = a2085("~ŕɓ\u035bуԘٵݟ\u0859\u0953ਗ਼\u0b5e\u0c54\u0d42ๆཀ၄ᄌቬᏖᑇᕋᙂᝊᡉ\u1941ᩎᭇ\u1c4aᴀṶΌ⁴ⅲ∻⍶⑰╫♣❳⡬⥱⨳⯵ⱸ\u2d76\u2e7b⼮べ〽㉠㍦㑨㕱㜶㝨㤴㥾㨭㬏㰋");
		a2039.AutoSize = true;
		a2039.Location = new Point(428, 163);
		a2039.Name = a2085("jŤɦ\u0366ѮԸ");
		a2039.Size = new Size(118, 52);
		a2039.TabIndex = 59;
		a2039.Text = a2085("\u0014ĠȤ\u0320ѯԩب\u07ab\u0822ࠕ੩\u0b31దവฤ༯\u1063ᅏቋጬᑖᕍᙉ\u1759ᡈᥓ\u1a57᭜᱒ᵘḕ\u1f47⁖⇕≘⍜⑊╀☍✡⠡⥍⩛⭝ⱗⵊ⹄⽖〃ㅀ㉔㌀㑫㕻㙯㝱㡲㥴㩸㭴㱳㵳㹻㼴䀞䄘䉶䍵䓨䕧䝒䜬䡲䥫䩹䭩䱪䵧乿佨偢兰刯");
		a2018.AutoSize = true;
		a2018.Location = new Point(13, 255);
		a2018.Name = a2085("jŤɦ\u0366ѮԲ");
		a2018.Size = new Size(420, 13);
		a2018.TabIndex = 6;
		a2018.Text = a2085("\u0016ĽȻ\u0333ЫԼخ\u073cॼढ੫ଇనഫ\u0e67༇အᄶሦጱᐭᔥᙍ\u1757᠑ᤜ\u1a78᭓᱑ᵙṍ\u1f5a\u2054ⅆ∓⍓ⓖ␁♃☟⡟⥇⩎⭄Ⰹⵍ⹌⽔いㅊ㉏㍃㑓㐑㙱㝺㡼㤼㩢㭻㱣㵹㹥㼸䀵䇂䉡䍼䑴䐏䙦䝠䠭䥁䩈䭘䰹䴺个伵偃儴刻匰呃");
		a2019.AutoSize = true;
		a2019.Font = new Font(a2085("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a2019.Location = new Point(12, 279);
		a2019.Name = a2085("jŤɦ\u0366Ѯ\u0530");
		a2019.Size = new Size(96, 13);
		a2019.TabIndex = 55;
		a2019.Text = a2085("DŪɼ\u0360ѥե٫ݥࠨ\u094b੯୶\u0c70൦\u0e71ཨ");
		a2020.BackColor = Color.FromArgb(128, 255, 128);
		a2020.BorderStyle = BorderStyle.Fixed3D;
		a2020.FlatStyle = FlatStyle.Flat;
		a2020.ForeColor = Color.DarkOrange;
		a2020.Location = new Point(13, 272);
		a2020.Name = a2085("kŧɧ\u0361ѯԳز");
		a2020.Size = new Size(823, 3);
		a2020.TabIndex = 54;
		a2021.AutoSize = true;
		a2021.Font = new Font(a2085("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a2021.Location = new Point(7, 8);
		a2021.Name = a2085("jŤɦ\u0366ѮԹ");
		a2021.Size = new Size(92, 13);
		a2021.TabIndex = 0;
		a2021.Text = a2085("DŪɼ\u0360ѥե٫ݥࠨ\u0945੯୩\u0c63൪\u0e71ཨ");
		a2038.AutoSize = true;
		a2038.Location = new Point(22, 163);
		a2038.Name = a2085("jŤɦ\u0366ѮԴ");
		a2038.Size = new Size(89, 26);
		a2038.TabIndex = 49;
		a2038.Text = a2085("^Ūɢ\u0366еՓٶߵࡸࡏਯ\u0b57౬ൿ\u0e6aཡငᄂቋ፯ᑶᕰᙦ\u1771ᡨ");
		a2029.AutoSize = true;
		a2029.Location = new Point(22, 87);
		a2029.Name = a2085("jŤɦ\u0366ѮԶ");
		a2029.Size = new Size(48, 13);
		a2029.TabIndex = 49;
		a2029.Text = a2085("IǠ\u0337\u036eѨբٯݠ");
		a2022.AutoSize = true;
		a2022.Location = new Point(22, 60);
		a2022.Name = a2085("jŤɦ\u0366ѮԵ");
		a2022.Size = new Size(41, 13);
		a2022.TabIndex = 49;
		a2022.Text = a2085("KŠɶ\u0368ѧջ");
		a2023.AutoSize = true;
		a2023.Location = new Point(22, 32);
		a2023.Name = a2085("jŤɦ\u0366ѮԷ");
		a2023.Size = new Size(55, 13);
		a2023.TabIndex = 49;
		a2023.Text = a2085("Jšɯ\u0367ѿԤ\u064eݣࡢ");
		a2030.Font = new Font(a2085("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a2030.Location = new Point(125, 81);
		a2030.MaxLength = 50;
		a2030.Name = a2085("~űɼ\u0344ѯխ٥ݹࡋ\u0951");
		a2030.Size = new Size(297, 26);
		a2030.TabIndex = 3;
		a2024.Font = new Font(a2085("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a2024.Location = new Point(125, 27);
		a2024.MaxLength = 20;
		a2024.Name = a2085("\u007fŲɽ\u034bѮծ٤ݾࡎ\u0963\u0a62");
		a2024.Size = new Size(297, 26);
		a2024.TabIndex = 0;
		a2031.Image = (Image)componentResourceManager.GetObject(a2085("aŹɬͺѸվٮ\u0748ࡦ॰ਸ਼ନ\u0c4c൩\u0e62ཥ\u1064"));
		a2031.Location = new Point(565, 17);
		a2031.Name = a2085("{ţɪͼѲմ٠\u0746\u086cॺਰ");
		a2031.Size = new Size(281, 228);
		a2031.SizeMode = PictureBoxSizeMode.StretchImage;
		a2031.TabIndex = 62;
		a2031.TabStop = false;
		a2025.BackColor = Color.FromArgb(233, 235, 236);
		a2025.Controls.Add(a2026);
		a2025.Controls.Add(a2027);
		a2025.Dock = DockStyle.Bottom;
		a2025.Location = new Point(0, 598);
		a2025.Name = a2085("vŤɪ\u0366Ѯ\u0530");
		a2025.Size = new Size(867, 37);
		a2025.TabIndex = 1;
		a2026.Dock = DockStyle.Fill;
		a2026.Location = new Point(432, 0);
		a2026.Name = a2085("jųɨ\u0346ѭը٫ݲ");
		a2026.Size = new Size(435, 37);
		a2026.TabIndex = 1;
		a2026.Text = a2085("Oǻɨ\u0366ѡկٮݤ");
		a2026.UseVisualStyleBackColor = true;
		a2026.Click += a2062;
		a2027.Dock = DockStyle.Left;
		a2027.Location = new Point(0, 0);
		a2027.Name = a2085("kżɩ\u034dѤս٧ݧࡵ");
		a2027.Size = new Size(432, 37);
		a2027.TabIndex = 0;
		a2027.Text = a2085("MŤɽ\u0367ѧյ");
		a2027.UseVisualStyleBackColor = true;
		a2027.Click += a2068;
		a2028.DropDownStyle = ComboBoxStyle.DropDownList;
		a2028.Font = new Font(a2085("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a2028.FormattingEnabled = true;
		a2028.Location = new Point(1101, 17);
		a2028.Name = a2085("iūɅ\u0362Ѵծ١ݹࡋ\u0945");
		a2028.Size = new Size(41, 26);
		a2028.TabIndex = 64;
		a2042.FormattingEnabled = true;
		a2042.Location = new Point(1101, 49);
		a2042.Name = a2085("oţɆ\u0360ѻճفݷࡱॳ\u0a4b\u0b45");
		a2042.Size = new Size(177, 100);
		a2042.TabIndex = 88;
		a2049.Location = new Point(123, 138);
		a2049.Name = a2085("wŻɁͰѴժ٭ݨ\u085f८\u0a78\u0b7fౡ൴ไའ\u1060ᅦቮ፨");
		a2049.Properties.Appearance.Font = new Font(a2085("RŤɬ\u036cѯՠ"), 10f);
		a2049.Properties.Appearance.Options.UseFont = true;
		a2049.Properties.Caption = a2085("KŶɲͰѷնز\u0742ࡵॽ\u0a78\u0b64౿ഫ\u0e48ཬ\u106cᅢቪ፬ᐤᕇ\u16feᙞ");
		a2049.Size = new Size(174, 21);
		a2049.TabIndex = 91;
		a2050.Caption = a2085("KŶɲͰѷնز\u0742ࡵॽ\u0a78\u0b64౿ഫ\u0e48ཬ\u106cᅢቪ፬ᐤᕇ\u16feᙞ");
		a2050.ColumnEdit = a2051;
		a2050.FieldName = a2085("GŒɖ\u0354ѓՊ\u0651ݞࡉख़ੜ\u0b40\u0c5b൘ไཀ၀ᅆ\u124eፈ");
		a2050.Name = a2085("lŸɠ\u036cфթ٩ݱ\u086e६ਸ");
		a2050.OptionsColumn.AllowEdit = false;
		a2050.Visible = true;
		a2050.VisibleIndex = 5;
		a2051.AutoHeight = false;
		a2051.Name = a2085("jŲɦͺѧպ٦ݾࡢॶ\u0a47\u0b79౩൦\u0e49ཡ\u106dᅤቭፀᑠᕪᙶᜰ");
		a2051.ValueChecked = a2085("D");
		a2051.ValueUnchecked = a2085("I");
		Appearance.BackColor = Color.White;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(867, 635);
		Controls.Add(a2016);
		Controls.Add(a2042);
		Controls.Add(a2025);
		Controls.Add(a2028);
		MaximizeBox = false;
		MaximumSize = new Size(971, 674);
		Name = a2085("VŽɣ\u0359ѩչ٧ݠࡦ०੪\u0b51\u0c65൭\u0e6bཬ");
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a2085("ZŨɾ\u0366ѣէ٩ݫ\u0826\u0951\u0a65୭ള൬");
		((ISupportInitialize)a2010).EndInit();
		a2011.ResumeLayout(performLayout: false);
		((ISupportInitialize)a2014).EndInit();
		a2016.ResumeLayout(performLayout: false);
		a2016.PerformLayout();
		((ISupportInitialize)a2047.Properties).EndInit();
		((ISupportInitialize)a2031).EndInit();
		a2025.ResumeLayout(performLayout: false);
		((ISupportInitialize)a2049.Properties).EndInit();
		((ISupportInitialize)a2051).EndInit();
		ResumeLayout(performLayout: false);
	}

	public a2086()
	{
		a2054();
		a1984.a1891(this);
		a1984.a1975(a2085("gŶɾʹѳջ؎ݤࡨइ\u0a61୨౺൳\u0e79རၶᅶቲ\u137eᑡᕛᙗ\u173dᡚ᥉\u1a55᭔\u1c38ᵜṗ\u1f47\u2040⅌≕⍃⑅╟☮❚⡄⥎⩘⭌Ⱘⵆ⹍⽑きㅅ㈿㌰"), a2042, a2041);
		a1984.a1964(a2085("rťɓ\u035bўՈػݓ\u085dऴ\u0a56\u0b52\u0c5cഴ๕ཀ\u105eᅝሯፗᑘᕇᙇᝏᡄ᥍\u1a58ᭋ᱀ᵖṈ\u1f47⁛"), a2028, a2015);
		a2055();
	}

	public void a2055()
	{
		int focusedRowHandle = a2014.FocusedRowHandle;
		DataTable dataSource = a2147.a2105(a2085(">Ŏə\u0357џ՚\u064c\u0737ࡂत\u0a3a\u0b5a\u0c56ഽไ\u0f3eဠᅎቅፃᑋᕓᙗᝊᡇ᥆ᨨ᭗\u1c33ᴯṃᾶ₶↼⊦⎤⒳▩⛔➣⣇⧛⪤⮼Ⲡⶥ⻜⾻ミ㇃㊵㎾㒡㖥㚭㞪㢣㦺㪩㮦㲰㶪㺥㾅䂁䆔䊘䏷䒎䗨䛶䞄䢓䦇䪂䮚䲁䶎互侊傊冈劀厂哦喝囹埩墕妄媀宆岁嶄废忬惻懯拪揲擩旦曺柲棲槰櫸毺沞涑滲濮烥燤狵珮瓵痮盧矵碛秦竫篭糴緤绲翋肶臟苕菏蒶薱蛛蟖装觐誴评賚跔軞辯郚醼銢鏉铋闂雁韞飃駚髃鯌鳐鶼麧鼺ꁙꅝꈨꌳꐿꔷꙘꝆꡖꤰ\uaa38ꬠ갷굑김꽏뀫넣눨덂둃땅뙈뜪렣뤷먯묦밸뵜빈뼌쀛섑숙쌘쐎앹옙윓젟쥵쨒쬁찝촜칰켖퀛턆툀팎퐇플혗휊\ud803\ud917\uda0f\udb06\udc18\udd61\ude17\udf77\ue07b\ue16f\ue279\ue31b\ue473\ue57d\ue605\ue763\ue807\ue91b\uea6d\ueb66\uec79\ued7d\uee75\uef62\uf06b\uf172\uf261\uf36e\uf478\uf562\uf66d\uf77d\uf879塞褐\ufb0aﰂﵧﹲｐSĽɈ\u035eшՔ\u0651ݙࡗख़\u0a58\u0b56\u0c40റไ\u0f3e\u102eᅚቄፎᑘᕌᘨᝆᡍᥑᩍᭅ᰿ᴰ"));
		a2010.DataSource = dataSource;
		if (focusedRowHandle > 0 && a2014.RowCount >= focusedRowHandle)
		{
			a2014.FocusedRowHandle = focusedRowHandle;
		}
	}

	public void a2056()
	{
		a2024.Text = a2085("");
		for (int i = 0; i < a2041.Items.Count; i++)
		{
			a2041.SetItemChecked(i, value: false);
		}
		a2047.Checked = false;
		a2049.Checked = false;
		a2030.Text = a2085("");
		a2044.Text = a2085("4įȲ\u0331");
	}

	public void a2057()
	{
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e->IL048e: Incompatible stack heights: 2 vs 0
		for (int i = 0; i < a2041.Items.Count; i++)
		{
			a2042.SetItemCheckState(i, a2041.GetItemCheckState(i));
		}
		if (a2024.Text == a2085(""))
		{
			MessageBox.Show(a2085("oǞɕ\u0346Ѻհؽݟࡲॲ\u0a78\u0b62ദ൸\u0e35ཙ\u1072ᅱሱፑᑽᕫᙾᝥᡥᥣᨩ᭏ᱮᵴṬὪ\u206aⅸ∯"), a2085("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			a2024.Focus();
			return;
		}
		if (a2030.Text == a2085(""))
		{
			MessageBox.Show(a2085("Tǫɢͳѱսزݐ\u08f7࠾\u0a65ୡ౭൦\u0e6b༩၏ᅮቴ፬ᑪᕪᙸᜯ"), a2085("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			a2030.Focus();
			return;
		}
		try
		{
			Convert.ToDecimal(a2044.Text);
		}
		catch
		{
			MessageBox.Show(a2085("LŻɯ\u036aѲթعݚࡲॲ\u0a70\u0b78౺ർ\u0e78༰၄ᅡባ፸ᑹᕥᙥᜨᡂᥢ\u1a6c᭪ᱪᵸḯ"), a2085("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			a2044.Focus();
			return;
		}
		a2028.SelectedIndex = a2015.SelectedIndex;
		a1344.a1307();
		if (a2052 < 0)
		{
			a1344.a1271.CommandText = a2085("ÅƭʭαҤ\u05b2ڋ߾\u0894\u0992એக\u0cf9ඌຒ\u0f84႘ᆝኝ᎓ᒝᖜᚊវᣥᦏ᪂\u1b82ᲈᶒẘᾋ₄ↇ⋯⎁⒈█⛾⟤⣢⧵⫫\u2b96⳩\u2df7⻥\u2fe2\u3099\u31ed㋦㏹㓽㗵㛢㟫㣲㧡㫮㯸㳢㷭㻽㿹䃬䇠䊏䏱䓤䗲䛉䟗䣎䧃䫙䯟䳝䷝仛俟傹凖勒叙哘嗉囊埑壊姃嫙宦峚巉廃心惆懁拜揑擄旒昩朷栮椣樹欿氽洽渻漿灙焵爸猦琸甶癆睎砻礭稧笿簬紻繏缦耦脭舫茣萻蔿蘒蜟蠞襰訛謙谐贐踖輌逊鄝鈃鍾鐑销阀霜頙饠騋鬓鰜鴃鸋鼃ꀈꄁꈜꌏꐄꔒ\ua674Ꝼꡧꥣꩲꭾ강굸깤꽳끧녢뉺덡둮땲뙪띪롨률멢묆뱩뵪빦뽭쁬셽쉦썽쑦앯왍윲졝쥏쩚쭞챜쵛칒콉큆텑퉁퍄푘핃홐흌\ud848\ud948\uda4e\udb46\udc40\udd24\ude47\udf47\ue04e\ue150\ue24a\ue344\ue428");
		}
		else
		{
			a1344.a1271.CommandText = a2085("ÊƼʸΣҧ\u05b1ڡ߃ࢶতલஒಗඓຝ\u0f97႖ᆜኊ\u13f7ᒅᖐ\u1680៳ᢑᦘ᪘ᮎᲔᶒẁᾊ₉⇴⊈⎄⒏▍⚅➙⢝⦌⪁⯼Ⲓ\u2dfe\u2ef5⿳・㇣㋧㏾㓦㖈㛴㟰㣻㧹㫱㯵㳱㷤㻼㾇䃺䇦䋺䏳䒛䗥䛴䟬䣰䧵䪌䯆䳋䷖仐俞僗凜勇叚哓嗇囟埖壈姎嫙寋岳巍廕忞惁懅拍揊擃旚曉柆棐槊櫅欥氡洴游潗灚焪爽猥琠甼瘧眬砰礴稴笪簢紤繑缫耹脬舺茱萯蔶蘻蜡蠧褥訥謓谗赱踞輚逑鄐鈁錒鐉锒阛霁顯餑騒鬎鰅鴄鸕鼎ꀕꄎꈇꌕꑪꔖꘅ\ua707ꠇ꤂ꨅꭠ걭굸깮꽭끳녪뉧덵둳땱뙱띿롻뤌며뭼뱯뵩빩뽨쁯셶쉻썢쑴앳왭읰졽쥣쩥쭛챛쵑칕켷큛텒퉌퍞푐픨화흒\ud859\ud945\uda59\udb49\udc2e\udd5a\ude44\udf4e\ue058\ue14c\ue228\ue34e\ue442\ue538\ue644\ue74a\ue846\ue921");
			a1344.a1271.Parameters.Add(a2085("KŅ"), SqlDbType.Int).Value = a2052;
		}
		a1344.a1271.Parameters.Add(a2085("JŁɏ\u0347џ՛\u064e\u0743ࡂ"), SqlDbType.VarChar).Value = a2024.Text;
		a1344.a1271.Parameters.Add(a2085("KŎɎ\u0344ў՜\u064bݑ"), SqlDbType.VarChar).Value = a2030.Text;
		a1344.a1271.Parameters.Add(a2085("TŌɐ\u0355"), SqlDbType.Int).Value = 6666;
		a1344.a1271.Parameters.Add(a2085("HŅɄ\u0342шՁ\u064eݕࡄ\u094d\u0a55\u0b4d\u0c40൞\u0e5cཋ၅"), SqlDbType.Int).Value = Convert.ToInt32(a2028.Text);
		a1344.a1271.Parameters.Add(a2085("^ŉə\u035cр՛\u0658\u0744ࡀ\u0940\u0a46\u0b4e\u0c48"), SqlDbType.Decimal).Value = Convert.ToDecimal(a2044.Text);
		if (a2047.Checked)
		{
			a1344.a1271.Parameters.Add(a2085("HňɃ\u034eџՀ\u065b\u0744ࡍ\u0953"), SqlDbType.NVarChar).Value = a2085("D");
		}
		else
		{
			a1344.a1271.Parameters.Add(a2085("HňɃ\u034eџՀ\u065b\u0744ࡍ\u0953"), SqlDbType.NVarChar).Value = a2085("I");
		}
		if (a2049.Checked)
		{
			a1344.a1271.Parameters.Add(a2085("GŒɖ\u0354ѓՊ\u0651ݞࡉख़ੜ\u0b40\u0c5b൘ไཀ၀ᅆ\u124eፈ"), SqlDbType.NVarChar).Value = a2085("D");
		}
		else
		{
			a1344.a1271.Parameters.Add(a2085("GŒɖ\u0354ѓՊ\u0651ݞࡉख़ੜ\u0b40\u0c5b൘ไཀ၀ᅆ\u124eፈ"), SqlDbType.NVarChar).Value = a2085("I");
		}
		a1344.a1271.Parameters.Add(a2085("Dŏɗ\u034bч"), SqlDbType.Int).Value = 1;
		try
		{
			a1344.a1271.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
		if (a2052 < 0)
		{
			a2052 = a2147.a2113(a2085("Lśɑ\u0359јՎعݕࡖ\u094e\u0a3dଢ଼\u0c57\u0d3b\u0e31བၝᅁቀጬᑟᕏᙛᝅᡎ᥈ᩄᭈᱏᵇṓ"));
			a2147.a2128(a2085("wŷɽ\u0375ѻի؍ݪࡹ॥\u0a64ଈౠ൴\u0e70\u0f74ၼᅶቤ፲ᑒᕗᙓ\u175dᡗ᥅ᩒ᭑᱄ᵟṁἴ⁄⅚≔⍂⑊┮♙❉⡙⥇⩀⭆ⱆⵊ⹚⽍ぇㄿ㈦") + a2052 + a2085("&"), a2085("BŀɈ\u0346іՄ"));
			for (int i = 0; i < a2042.CheckedItems.Count; i++)
			{
				checked
				{
					_ = /*Error near IL_0418: Stack underflow*/+ /*Error near IL_0418: Stack underflow*/;
					/*Error near IL_0418: ldarg 1 (out-of-bounds)*/;
					string text = ((CheckedListBox)/*Error near IL_041a: ldarg 2 (out-of-bounds)*/).CheckedItems[i].ToString();
					a2147.a2128(a2085("wųɯ;Ѩխ\u0618ݾࡸॡ\u0a7bଓ\u0c75\u0d63\u0e65\u0f7f\u1071ᅹቩ፹ᑧᕠᙦᝦᡪ\u197a\u1a6f᭪ᱱᵨṴἿ‶⅚≎⍎⑊╆♑❓⠺⥁⩑⭁ⱟⵘ\u2e5e⽎あㅒ㉅㍏㐣㔩㙞㝆㡊㥐㩁㭐㰪㴦") + text + a2085("$ĮȦ") + a2052 + a2085("%Ĩ"), a2085("Oŋɗ\u0346ѐՕ"));
				}
			}
		}
		else
		{
			a2147.a2128(a2085("wŷɽ\u0375ѻի؍ݪࡹ॥\u0a64ଈౠ൴\u0e70\u0f74ၼᅶቤ፲ᑒᕗᙓ\u175dᡗ᥅ᩒ᭑᱄ᵟṁἴ⁄⅚≔⍂⑊┮♙❉⡙⥇⩀⭆ⱆⵊ⹚⽍ぇㄿ㈦") + a2052 + a2085("&"), a2085("BŀɈ\u0346іՄ"));
			for (int i = 0; i < a2042.CheckedItems.Count; i++)
			{
				string text = a2042.CheckedItems[i].ToString();
				a2147.a2128(a2085("wųɯ;Ѩխ\u0618ݾࡸॡ\u0a7bଓ\u0c75\u0d63\u0e65\u0f7f\u1071ᅹቩ፹ᑧᕠᙦᝦᡪ\u197a\u1a6f᭪ᱱᵨṴἿ‶⅚≎⍎⑊╆♑❓⠺⥁⩑⭁ⱟⵘ\u2e5e⽎あㅒ㉅㍏㐣㔩㙞㝆㡊㥐㩁㭐㰪㴦") + text + a2085("$ĮȦ") + a2052 + a2085("%Ĩ"), a2085("Oŋɗ\u0346ѐՕ"));
			}
		}
		a2052 = -1L;
		a2055();
		a2056();
	}

	public void a2058()
	{
		try
		{
			int num = Convert.ToInt32(a2014.GetFocusedRowCellValue(a2085("KŅ")).ToString());
			if (MessageBox.Show(a2085("~Ōɚ\u034aяՋمݏࡋ\u0901ੳ୶\u0c72൰\u0e79\u0f70\u103aဩቫ፣ᑳᕱᙽᘌ\u187b\u197f\u1a79᭵ᱫᴭṉὦ\u2063Ⅷ≥⍮⑵╬♪❪⡸⤯"), a2085("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.Cancel)
			{
				return;
			}
			a2147.a2128(a2085("}ŷɢ\u0364Ѱզ\u0602ݵࡥ\u094d\u0a53\u0b54\u0c52൚๖ཕၝᅅሶፆᑑᕇᘲᝐᡛᥛᩇᭋ\u1c31ᴻḪ\u1f5e\u2040⅂≔⍀␤╊♆✼") + num, a2085("BŠɨ\u0366Ѷդ"));
		}
		catch
		{
		}
		a2055();
	}

	public void a2059()
	{
		if (a2014.RowCount > 0)
		{
			a2056();
			if (a2014.GetFocusedRowCellValue(a2085("HňɃ\u034eџՀ\u065b\u0744ࡍ\u0953")).ToString() == a2085("Pűɷ\u0364"))
			{
				a2047.Checked = true;
			}
			else
			{
				a2047.Checked = false;
			}
			if (a2014.GetFocusedRowCellValue(a2085("GŒɖ\u0354ѓՊ\u0651ݞࡉख़ੜ\u0b40\u0c5b൘ไཀ၀ᅆ\u124eፈ")).ToString() == a2085("D"))
			{
				a2049.Checked = true;
			}
			else
			{
				a2049.Checked = false;
			}
			a2052 = Convert.ToInt32(a2014.GetFocusedRowCellValue(a2085("KŅ")).ToString());
			a2024.Text = a2014.GetFocusedRowCellValue(a2085("JŁɏ\u0347џ՛\u064e\u0743ࡂ")).ToString();
			a2030.Text = a2014.GetFocusedRowCellValue(a2085("KŎɎ\u0344ў՜\u064bݑ")).ToString();
			a2044.Text = a2014.GetFocusedRowCellValue(a2085("^ŉə\u035cр՛\u0658\u0744ࡀ\u0940\u0a46\u0b4e\u0c48")).ToString();
			a2015.SelectedIndex = a2028.Items.IndexOf(a2014.GetFocusedRowCellValue(a2085("HŅɄ\u0342шՁ\u064eݕࡄ\u094d\u0a55\u0b4d\u0c40൞\u0e5cཋ၅")).ToString());
			DataTable dataTable = a2147.a2105(a2085("hſɵͽѴբ\u0615ݳࡡ१\u0a61୯౦൪ญཪၹᅥቤገᑠᕴᙰ\u1774\u187c\u1976\u1a64\u1b72᱒ᵗṓὝ⁗ⅅ≒⍑⑄╟♁✴⡄⥚⩔⭂ⱊ\u2d2e⹙⽉すㅇ㉀㍆㑆㕊㙚㝍㡇㤿㨦") + a2052 + a2085("&"));
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				a2041.SetItemChecked(a2042.Items.IndexOf(dataTable.Rows[i][0].ToString()), value: true);
			}
		}
	}

	private void a2062(object a2060, EventArgs a2061)
	{
		a2057();
	}

	private void a2065(object a2063, KeyPressEventArgs a2064)
	{
		if (!char.IsControl(a2064.KeyChar) && !char.IsDigit(a2064.KeyChar))
		{
			a2064.Handled = true;
		}
	}

	private void a2068(object a2066, EventArgs a2067)
	{
		a2052 = -1L;
		a2057();
	}

	private void a2071(object a2069, EventArgs a2070)
	{
		a2058();
	}

	private void a2074(object a2072, EventArgs a2073)
	{
		a2059();
	}

	private void a2077(object a2075, EventArgs a2076)
	{
		a821 a2269 = new a821();
		a2006 a2270 = new a2006(a2269, 30);
		a2270.ShowDialog();
		a1984.a1964(a2085("rťɓ\u035bўՈػݓ\u085dऴ\u0a56\u0b52\u0c5cഴ๕ཀ\u105eᅝሯፗᑘᕇᙇᝏᡄ᥍\u1a58ᭋ᱀ᵖṈ\u1f47⁛"), a2028, a2015);
	}

	private void a2080(object a2078, EventArgs a2079)
	{
	}

	private void a2083(object a2081, EventArgs a2082)
	{
		a2059();
	}

	private static string a2085(string a2084)
	{
		int length = a2084.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a2084[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
