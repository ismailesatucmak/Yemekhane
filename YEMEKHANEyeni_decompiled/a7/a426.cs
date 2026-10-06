using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Calendar;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraNavBar;
using DevExpress.XtraNavBar.ViewInfo;
using DevExpress.XtraScheduler;
using DevExpress.XtraTab;
using FastReport;
using a7.a2096;
using a7.a2267;

namespace a7;

public class a426 : XtraForm
{
	public class YukluTar
	{
		public DateTime Tarih { get; set; }

		public int Durum { get; set; }

		public YukluTar()
		{
			Tarih = DateTime.Now.Date;
			Durum = 0;
		}
	}

	public const short a10 = 128;

	public const short a11 = -1;

	public const uint a12 = 2147483648u;

	public const uint a13 = 1073741824u;

	public const uint a14 = 1u;

	public const uint a15 = 2u;

	public const uint a16 = 3u;

	private IContainer a17 = null;

	public ToolStripMenuItem a18;

	public ToolStripMenuItem a19;

	public ToolStripMenuItem a20;

	public ToolStripSeparator a21;

	public ToolStripMenuItem a22;

	public ToolStripMenuItem a23;

	public ToolStripMenuItem a24;

	public ToolStripMenuItem a25;

	public ToolStripMenuItem a26;

	public ToolStripMenuItem a27;

	public ToolStripMenuItem a28;

	public ToolStripMenuItem a29;

	public ToolStripMenuItem a30;

	private ToolStripMenuItem a31;

	private ToolStripMenuItem a32;

	private ToolStripMenuItem a33;

	public MenuStrip a34;

	public ToolStripMenuItem a35;

	public ToolStripMenuItem a36;

	public ToolStripMenuItem a37;

	public ToolStripSeparator a38;

	public ToolStripMenuItem a39;

	public ToolStripMenuItem a40;

	public ToolStripMenuItem a41;

	public ToolStripMenuItem a42;

	public ToolStripMenuItem a43;

	public ToolStripMenuItem a44;

	public ToolStripMenuItem a45;

	private ToolStripMenuItem a46;

	private ToolStripMenuItem a47;

	private ToolStripMenuItem a48;

	public ToolStripMenuItem a49;

	public NavBarControl a50;

	private NavBarGroup a51;

	private NavBarItem a52;

	public NavBarGroup a53;

	public NavBarItem a54;

	public NavBarItem a55;

	public NavBarGroup a56;

	public NavBarItem a57;

	public NavBarItem a58;

	public NavBarGroup a59;

	public NavBarItem a60;

	public NavBarItem a61;

	public NavBarGroup a62;

	private NavBarItem a63;

	public NavBarItem a64;

	public NavBarItem a65;

	public NavBarItem a66;

	public NavBarItem a67;

	public NavBarItem a68;

	public NavBarItem a69;

	public NavBarItem a70;

	public NavBarItem a71;

	public NavBarItem a72;

	public NavBarItem a73;

	public NavBarItem a74;

	public XtraTabControl a75;

	public XtraTabPage a76;

	public GridControl a77;

	public GridView a78;

	public RepositoryItemTextEdit a79;

	public GroupBox a80;

	public XtraTabPage a81;

	public GridControl a82;

	public GridView a83;

	public RepositoryItemButtonEdit a84;

	public RepositoryItemButtonEdit a85;

	public RepositoryItemTimeEdit a86;

	public RepositoryItemDateEdit a87;

	public RepositoryItemButtonEdit a88;

	public RepositoryItemButtonEdit a89;

	public RepositoryItemButtonEdit a90;

	public GroupBox a91;

	public Label a92;

	public Label a93;

	public Label a94;

	public Button a95;

	public Button a96;

	public Label a97;

	private DateNavigator a98;

	public Button a99;

	public Button a100;

	public Button a101;

	public Button a102;

	public Button a103;

	public Button a104;

	public Button a105;

	public Button a106;

	private TextBox a107;

	private NavBarItem a108;

	private NavBarItem a109;

	private NavBarGroup a110;

	private NavBarItem a111;

	private NavBarItem a112;

	private System.Windows.Forms.ComboBox a113;

	private NavBarItem a114;

	private System.Windows.Forms.ComboBox a115;

	private Label a116;

	private GridColumn a117;

	private GridColumn a118;

	private GridColumn a119;

	private GridColumn a120;

	private GridColumn a121;

	private GridColumn a122;

	private GridColumn a123;

	private GridColumn a124;

	private GridColumn a125;

	private GridColumn a126;

	private GridColumn a127;

	private GridColumn a128;

	private GridColumn a129;

	private GridColumn a130;

	private GridColumn a131;

	private GridColumn a132;

	public ContextMenuStrip a133;

	private ToolStripMenuItem a134;

	public ToolStripMenuItem a135;

	private TextBox a136;

	public Button a137;

	public Button a138;

	public Button a139;

	public Button a140;

	public Button a141;

	public Button a142;

	public Button a143;

	public Button a144;

	public Button a145;

	public Button a146;

	public Button a147;

	public Button a148;

	private NavBarItem a149;

	private ToolStripMenuItem a150;

	private ToolStripSeparator a151;

	private ToolStripMenuItem a152;

	private ToolStripMenuItem a153;

	private ToolStripMenuItem a154;

	private ToolStripMenuItem a155;

	private ToolStripMenuItem a156;

	private ToolStripMenuItem a157;

	private ToolStripMenuItem a158;

	private PictureBox a159;

	public ContextMenuStrip a160;

	private ToolStripMenuItem a161;

	public ToolStripMenuItem a162;

	private NavBarItem a163;

	private ToolStripMenuItem a164;

	public Label a165;

	private NavBarItem a166;

	private Timer a167;

	private Label a168;

	public Label a169;

	public Label a170;

	public Label a171;

	public Label a172;

	public Label a173;

	private TextBox a174;

	private TextBox a175;

	private TextBox a176;

	private TextBox a177;

	public Button a178;

	private NavBarItem a179;

	private NavBarItem a180;

	private StatusStrip a181;

	private NavBarItem a182;

	private ToolStripMenuItem a183;

	private NavBarItem a184;

	private Label a185;

	private RepositoryItemCheckEdit a186;

	private ToolStripMenuItem a187;

	private GridColumn a188;

	private RepositoryItemCheckEdit a189;

	private GridColumn a190;

	private GridColumn a191;

	private ToolStripMenuItem a192;

	private GridColumn a193;

	public List<DateTime> a194 = new List<DateTime>();

	public List<YukluTar> a195 = new List<YukluTar>();

	public int a196 = 0;

	public string a197 = a425("");

	public a2189 a198 = default;

	private a1344.CUSTUMERINFO a199 = new a1344.CUSTUMERINFO();

	private Report a200 = new Report();

	private bool a201 = false;

	protected override void Dispose(bool a202)
	{
		if (a202 && a17 != null)
		{
			a17.Dispose();
		}
		base.Dispose(a202);
	}

	private void a203()
	{
		a17 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(a426));
		a18 = new ToolStripMenuItem();
		a19 = new ToolStripMenuItem();
		a20 = new ToolStripMenuItem();
		a21 = new ToolStripSeparator();
		a22 = new ToolStripMenuItem();
		a23 = new ToolStripMenuItem();
		a24 = new ToolStripMenuItem();
		a25 = new ToolStripMenuItem();
		a26 = new ToolStripMenuItem();
		a27 = new ToolStripMenuItem();
		a28 = new ToolStripMenuItem();
		a29 = new ToolStripMenuItem();
		a30 = new ToolStripMenuItem();
		a31 = new ToolStripMenuItem();
		a32 = new ToolStripMenuItem();
		a33 = new ToolStripMenuItem();
		a34 = new MenuStrip();
		a35 = new ToolStripMenuItem();
		a36 = new ToolStripMenuItem();
		a37 = new ToolStripMenuItem();
		a38 = new ToolStripSeparator();
		a39 = new ToolStripMenuItem();
		a40 = new ToolStripMenuItem();
		a41 = new ToolStripMenuItem();
		a42 = new ToolStripMenuItem();
		a43 = new ToolStripMenuItem();
		a44 = new ToolStripMenuItem();
		a45 = new ToolStripMenuItem();
		a164 = new ToolStripMenuItem();
		a46 = new ToolStripMenuItem();
		a47 = new ToolStripMenuItem();
		a48 = new ToolStripMenuItem();
		a153 = new ToolStripMenuItem();
		a154 = new ToolStripMenuItem();
		a155 = new ToolStripMenuItem();
		a156 = new ToolStripMenuItem();
		a157 = new ToolStripMenuItem();
		a158 = new ToolStripMenuItem();
		a183 = new ToolStripMenuItem();
		a49 = new ToolStripMenuItem();
		a150 = new ToolStripMenuItem();
		a151 = new ToolStripSeparator();
		a152 = new ToolStripMenuItem();
		a50 = new NavBarControl();
		a53 = new NavBarGroup();
		a54 = new NavBarItem();
		a55 = new NavBarItem();
		a180 = new NavBarItem();
		a56 = new NavBarGroup();
		a57 = new NavBarItem();
		a58 = new NavBarItem();
		a59 = new NavBarGroup();
		a60 = new NavBarItem();
		a61 = new NavBarItem();
		a163 = new NavBarItem();
		a184 = new NavBarItem();
		a62 = new NavBarGroup();
		a63 = new NavBarItem();
		a149 = new NavBarItem();
		a166 = new NavBarItem();
		a182 = new NavBarItem();
		a110 = new NavBarGroup();
		a114 = new NavBarItem();
		a112 = new NavBarItem();
		a108 = new NavBarItem();
		a109 = new NavBarItem();
		a111 = new NavBarItem();
		a179 = new NavBarItem();
		a51 = new NavBarGroup();
		a52 = new NavBarItem();
		a64 = new NavBarItem();
		a65 = new NavBarItem();
		a66 = new NavBarItem();
		a67 = new NavBarItem();
		a68 = new NavBarItem();
		a69 = new NavBarItem();
		a70 = new NavBarItem();
		a71 = new NavBarItem();
		a72 = new NavBarItem();
		a73 = new NavBarItem();
		a74 = new NavBarItem();
		a75 = new XtraTabControl();
		a81 = new XtraTabPage();
		a82 = new GridControl();
		a160 = new ContextMenuStrip(a17);
		a161 = new ToolStripMenuItem();
		a162 = new ToolStripMenuItem();
		a83 = new GridView();
		a117 = new GridColumn();
		a118 = new GridColumn();
		a119 = new GridColumn();
		a120 = new GridColumn();
		a121 = new GridColumn();
		a122 = new GridColumn();
		a123 = new GridColumn();
		a124 = new GridColumn();
		a125 = new GridColumn();
		a84 = new RepositoryItemButtonEdit();
		a85 = new RepositoryItemButtonEdit();
		a86 = new RepositoryItemTimeEdit();
		a87 = new RepositoryItemDateEdit();
		a88 = new RepositoryItemButtonEdit();
		a89 = new RepositoryItemButtonEdit();
		a90 = new RepositoryItemButtonEdit();
		a186 = new RepositoryItemCheckEdit();
		a91 = new GroupBox();
		a99 = new Button();
		a101 = new Button();
		a176 = new TextBox();
		a177 = new TextBox();
		a174 = new TextBox();
		a175 = new TextBox();
		a171 = new Label();
		a169 = new Label();
		a172 = new Label();
		a173 = new Label();
		a170 = new Label();
		a159 = new PictureBox();
		a136 = new TextBox();
		a107 = new TextBox();
		a178 = new Button();
		a100 = new Button();
		a102 = new Button();
		a137 = new Button();
		a138 = new Button();
		a139 = new Button();
		a140 = new Button();
		a141 = new Button();
		a142 = new Button();
		a143 = new Button();
		a144 = new Button();
		a145 = new Button();
		a146 = new Button();
		a147 = new Button();
		a148 = new Button();
		a103 = new Button();
		a104 = new Button();
		a105 = new Button();
		a106 = new Button();
		a165 = new Label();
		a92 = new Label();
		a93 = new Label();
		a94 = new Label();
		a76 = new XtraTabPage();
		a77 = new GridControl();
		a133 = new ContextMenuStrip(a17);
		a134 = new ToolStripMenuItem();
		a135 = new ToolStripMenuItem();
		a187 = new ToolStripMenuItem();
		a192 = new ToolStripMenuItem();
		a78 = new GridView();
		a126 = new GridColumn();
		a127 = new GridColumn();
		a128 = new GridColumn();
		a129 = new GridColumn();
		a130 = new GridColumn();
		a193 = new GridColumn();
		a131 = new GridColumn();
		a132 = new GridColumn();
		a188 = new GridColumn();
		a189 = new RepositoryItemCheckEdit();
		a190 = new GridColumn();
		a191 = new GridColumn();
		a79 = new RepositoryItemTextEdit();
		a80 = new GroupBox();
		a185 = new Label();
		a116 = new Label();
		a113 = new System.Windows.Forms.ComboBox();
		a98 = new DateNavigator();
		a95 = new Button();
		a96 = new Button();
		a97 = new Label();
		a115 = new System.Windows.Forms.ComboBox();
		a168 = new Label();
		a167 = new Timer(a17);
		a181 = new StatusStrip();
		a34.SuspendLayout();
		((ISupportInitialize)a50).BeginInit();
		((ISupportInitialize)a75).BeginInit();
		a75.SuspendLayout();
		a81.SuspendLayout();
		((ISupportInitialize)a82).BeginInit();
		a160.SuspendLayout();
		((ISupportInitialize)a83).BeginInit();
		((ISupportInitialize)a84).BeginInit();
		((ISupportInitialize)a85).BeginInit();
		((ISupportInitialize)a86).BeginInit();
		((ISupportInitialize)a87).BeginInit();
		((ISupportInitialize)a87.VistaTimeProperties).BeginInit();
		((ISupportInitialize)a88).BeginInit();
		((ISupportInitialize)a89).BeginInit();
		((ISupportInitialize)a90).BeginInit();
		((ISupportInitialize)a186).BeginInit();
		a91.SuspendLayout();
		((ISupportInitialize)a159).BeginInit();
		a76.SuspendLayout();
		((ISupportInitialize)a77).BeginInit();
		a133.SuspendLayout();
		((ISupportInitialize)a78).BeginInit();
		((ISupportInitialize)a189).BeginInit();
		((ISupportInitialize)a79).BeginInit();
		a80.SuspendLayout();
		((ISupportInitialize)a98).BeginInit();
		SuspendLayout();
		a18.Name = a425("áŸɞ\u0375ѪУمݿࡠ\u0962ਫ਼\u0b78౹\u0d63\u0e79ཅ\u1062ᅨተፍᑷᕧᙬ");
		a18.Size = new Size(158, 22);
		a18.Text = a425("ÞũȦ\u034eѥպ\u0733ݵ");
		a19.Name = a425("uŷɹ\u036eѺմٹݲࡆॾ\u0a7f\u0b63ౝ൹\u0e7eརၺᅄቭ፩ᑳᕌᙰᝦᡯ\u1930");
		a19.Size = new Size(158, 22);
		a19.Text = a425("GũɧͼѨբٯݠ");
		a20.Name = a425("zżɲȪՅմٹݹदࡊ\u0a78୶౿\u0d45\u0e7fའ\u1062ᅞቸ፹ᑣᕹᙅᝢᡨᥰᩍ᭷ᱧᵬ");
		a20.Size = new Size(158, 22);
		a20.Text = a425("JŬɢȺՕդ٩ݩ\u0826࠵\u0b5b୯౧൬");
		a21.Name = a425("fžɿ\u0363ѝչپݢࡺ\u0944੭୩\u0c73\u0d4c\u0e70སၯᄰ");
		a21.Size = new Size(155, 6);
		a22.Name = a425("ñ$ɿȢՍՅٿݠࡢफ़\u0a78\u0b79\u0c63൹ๅར\u1068ᅰቍ፷ᑧᕬ");
		a22.Size = new Size(158, 22);
		a22.Text = a425("Â5ɨȳ՞");
		a23.Name = a425("nŸɮ\u0368ѵշٽݻ\u085dॴ੭ਢ౦\u0d45\u0e7fའ\u1062ᅞቸ፹ᑣᕹᙅᝢᡨᥰᩍ᭷ᱧᵬ");
		a23.Size = new Size(174, 22);
		a23.Text = a425("^Ũɾ\u0378ѥէ٭ݫ\u0826\u094e\u0a65\u0b7aള൵");
		a24.Name = a425("Pźɬ\u036eѳյٿݵࡔॾ\u0a65ୡ\u0c71ൠ\u0e7bཅၿᅠቢ\u135eᑸᕹᙣ\u1779ᡅᥢ\u1a68\u1b70ᱍᵷṧὬ");
		a24.Size = new Size(174, 22);
		a24.Text = a425("@Ūɼ;ѣեٯݥࠨ\u094b੯୶\u0c70൦\u0e71ཨ");
		a25.Name = a425("EńɎͺѲՍٽݩࡻॴ\u0a7d\u0b63\u0c64൰\u0e78\u0f76\u1060ᅅቿ፠ᑢᕞᙸ\u1779ᡣ\u1979ᩅ᭢ᱨᵰṍί\u2067Ⅼ");
		a25.Size = new Size(174, 22);
		a25.Text = a425("UŴɾ\u036aѢԭ\u065cݪࡸ२\u0a65\u0b62\u0c72൷\u0e61\u0f6f\u1067ᅳ");
		a26.Name = a425("gŸɨͰѳյٽݹࡲॼ੦\u0b7e౷\u0d45\u0e7fའ\u1062ᅞቸ፹ᑣᕹᙅᝢᡨᥰᩍ᭷ᱧᵬ");
		a26.Size = new Size(174, 22);
		a26.Text = a425("Tũɿ\u0361Ѡդ٢ݨࡡ७\u0a71୯\u0c64");
		a27.Name = a425("uŲɲͽѳվٱݥࡷ०੭\u0b7c౼\u0d45\u0e7fའ\u1062ᅞቸ፹ᑣᕹᙅᝢᡨᥰᩍ᭷ᱧᵬ");
		a27.Size = new Size(170, 22);
		a27.Text = a425("Fţɥ\u036cѠկۻݴࡤॷ\u0a7a୭౯");
		a28.Name = a425("tŪɪͱѮչٻݸࡲॠ\u0a45\u0b7fౠ\u0d62\u0e5e\u0f78ၹᅣቹፅᑢᕨᙰᝍᡷᥧ\u1a6c");
		a28.Size = new Size(170, 22);
		a28.Text = a425("EŹɻ\u036eѿժ٪ݯࡣॳ");
		a29.Name = a425("`ǯɠ\u0345ѿՠ٢ݞࡸॹ\u0a63\u0b79\u0c45\u0d62\u0e68\u0f70၍ᅷቧ፬");
		a29.Size = new Size(170, 22);
		a29.Text = a425("]Ǵɵ\u0326ёե٭س\u086c");
		a30.Name = a425("użɼͲѨՅٿݠࡢफ़\u0a78\u0b79\u0c63൹ๅར\u1068ᅰቍ፷ᑧᕬ");
		a30.Size = new Size(170, 22);
		a30.Text = a425("Hţɡ\u0369ѽԦ\u0651ݥ\u086d࠳੬");
		a31.Name = a425("hźɨͰѾղقݴࡺ\u0822\u0a7f\u0b45౿ൠ\u0e62ཞၸᅹባ፹ᑅᕢᙨᝰᡍ\u1977\u1a67\u1b6c");
		a31.Size = new Size(170, 22);
		a31.Text = a425("XŪɸ\u0360Ѯբئݑࡥ७ଳ୬");
		a32.Name = a425("DŋɳͻѯՊپݎࡸ४੶\u0b7b\u0c74൸\u0e72འ၅ᅿበ።ᑞᕸᙹᝣ\u1879᥅\u1a62᭨ᱰᵍṷὧ\u206c");
		a32.Size = new Size(170, 22);
		a32.Text = a425("Wźɼ\u036aѼԭٺݮ\u082aढ़੩୵౧൨\u0e65\u0f6f\u1063ᅳ");
		a33.Name = a425("CŁ\u0300ͲѼղٯثࡘॡ੶\u0b64౹൵\u0e61ร၅ᅿበ።ᑞᕸᙹᝣ\u1879᥅\u1a62᭨ᱰᵍṷὧ\u206c");
		a33.Size = new Size(160, 22);
		a33.Text = a425("Sű\u0310\u0362Ѭբٿػ\u0829\u0949\u0a7e୧౷൨\u0e62\u0f70ᄰ");
		a34.GripStyle = ToolStripGripStyle.Visible;
		a34.Items.AddRange(new ToolStripItem[6] { a35, a40, a43, a46, a153, a49 });
		a34.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
		a34.Location = new Point(0, 0);
		a34.Name = a425("gŬɦͲѕձٶݪࡲर");
		a34.Size = new Size(1175, 24);
		a34.TabIndex = 9;
		a34.Text = a425("gŬɦͲѕձٶݪࡲर");
		a35.DropDownItems.AddRange(new ToolStripItem[4] { a36, a37, a38, a39 });
		a35.Name = a425("fžɿ\u0363ѝչپݢࡺ\u0944੭୩\u0c73\u0d4c\u0e70སၯᄳ");
		a35.Size = new Size(45, 20);
		a35.Text = a425("Nťɺȳѵ");
		a36.Image = (Image)componentResourceManager.GetObject(a425("lŸɹ\u0379чէ٠ݸࡠ\u0942੫\u0b63౹\u0d42\u0e7eཬၥᄴረፌᑩᕢᙥᝤ"));
		a36.ImageScaling = ToolStripItemImageScaling.None;
		a36.Name = a425("fžɿ\u0363ѝչپݢࡺ\u0944੭୩\u0c73\u0d4c\u0e70སၯᄲ");
		a36.Size = new Size(156, 52);
		a36.Text = a425("AŨɺͳЦՎ٥ݺळॵ");
		a36.Click += a326;
		a37.Enabled = false;
		a37.Image = (Image)componentResourceManager.GetObject(a425("lŸɹ\u0379чէ٠ݸࡠ\u0942੫\u0b63౹\u0d42\u0e7eཬၥᄳረፌᑩᕢᙥᝤ"));
		a37.ImageScaling = ToolStripItemImageScaling.None;
		a37.Name = a425("fžɿ\u0363ѝչپݢࡺ\u0944੭୩\u0c73\u0d4c\u0e70སၯᄵ");
		a37.Size = new Size(156, 52);
		a37.Text = a425("AŨɺͳЦՇ٨ݬࡩ।");
		a37.Click += a396;
		a38.Name = a425("gŽɾͼќպٿݥࡻख़੬\u0b78౦൴\u0e64\u0f70\u106cᅰሰ");
		a38.Size = new Size(153, 6);
		a39.Image = (Image)componentResourceManager.GetObject(a425("lŸɹ\u0379чէ٠ݸࡠ\u0942੫\u0b63౹\u0d42\u0e7eཬၥᄱረፌᑩᕢᙥᝤ"));
		a39.ImageScaling = ToolStripItemImageScaling.None;
		a39.Name = a425("fžɿ\u0363ѝչپݢࡺ\u0944੭୩\u0c73\u0d4c\u0e70སၯᄷ");
		a39.Size = new Size(156, 52);
		a39.Text = a425("Â5ɨȳ՞");
		a39.Click += a329;
		a40.DropDownItems.AddRange(new ToolStripItem[2] { a41, a42 });
		a40.Name = a425("fžɿ\u0363ѝչپݢࡺ\u0944੭୩\u0c73\u0d4c\u0e70སၯᄶ");
		a40.Size = new Size(78, 20);
		a40.Text = a425("Sǵɣ\u036bѣը١ݯࡧॳ");
		a41.Image = (Image)componentResourceManager.GetObject(a425("lŸɹ\u0379чէ٠ݸࡠ\u0942੫\u0b63౹\u0d42\u0e7eཬၥᄿረፌᑩᕢᙥᝤ"));
		a41.ImageScaling = ToolStripItemImageScaling.None;
		a41.Name = a425("fžɿ\u0363ѝչپݢࡺ\u0944੭୩\u0c73\u0d4c\u0e70སၯᄹ");
		a41.Size = new Size(162, 38);
		a41.Text = a425("\\Ūɸ\u0368Ш՞ۺݮࡨ०੯\u0b64");
		a41.Click += a332;
		a42.Image = (Image)componentResourceManager.GetObject(a425("lŸɹ\u0379чէ٠ݸࡠ\u0942੫\u0b63౹\u0d42\u0e7eཬၥᄾረፌᑩᕢᙥᝤ"));
		a42.ImageScaling = ToolStripItemImageScaling.None;
		a42.Name = a425("fžɿ\u0363ѝչپݢࡺ\u0944੭୩\u0c73\u0d4c\u0e70སၯᄸ");
		a42.Size = new Size(162, 38);
		a42.Text = a425("LǶɧ\u0328ў\u05faٮݨࡦ९\u0a64");
		a42.Click += a335;
		a43.DropDownItems.AddRange(new ToolStripItem[3] { a44, a45, a164 });
		a43.Name = a425("gŽɾͼќպٿݥࡻ\u0947੬୦\u0c72൏\u0e71ཡၮᄳሳ");
		a43.Size = new Size(63, 20);
		a43.Text = a425("ZŦɶ\u036aѶկ٣ݳ");
		a44.Image = (Image)componentResourceManager.GetObject(a425("mŷɸͺцՠ١ݻࡡढ़੪ୠ౸\u0d45\u0e7f\u0f6f\u1064ᄹሴጨᑌᕩᙢᝥᡤ"));
		a44.ImageScaling = ToolStripItemImageScaling.None;
		a44.Name = a425("gŽɾͼќպٿݥࡻ\u0947੬୦\u0c72൏\u0e71ཡၮᄳሲ");
		a44.Size = new Size(200, 54);
		a44.Text = a425("YŤɼ\u0363ѯգ\u073dݦ\u082aज़੩୷౩൷\u0e68རၰ\u1030");
		a44.Click += a338;
		a45.Image = (Image)componentResourceManager.GetObject(a425("mŷɸͺцՠ١ݻࡡढ़੪ୠ౸\u0d45\u0e7f\u0f6f\u1064ᄹሳጨᑌᕩᙢᝥᡤ"));
		a45.ImageScaling = ToolStripItemImageScaling.None;
		a45.Name = a425("gŽɾͼќպٿݥࡻ\u0947੬୦\u0c72൏\u0e71ཡၮᄳስ");
		a45.Size = new Size(200, 54);
		a45.Text = a425("Kšɡ\u0379ѦԪ\u065bݩࡷ३\u0a77୨\u0c62൰༰");
		a45.Click += a341;
		a164.Image = (Image)componentResourceManager.GetObject(a425("DǞɏͲѾծٲݮࡷॻ੫\u0a29\u0c43൹\u0e7a\u0f78၀ᅦባ፹ᑿᕃᙨᝢ\u187e\u1943\u1a7d\u1b6dᱪᴨṌὩ\u2062Ⅵ≤"));
		a164.ImageScaling = ToolStripItemImageScaling.None;
		a164.Name = a425("zǠɵ\u0348Ѹըٸݤࡹॵ\u0a61ਣ\u0c45ൿ\u0e60ར\u105eᅸቹ፣ᑹᕅᙢᝨᡰ᥍\u1a77᭧ᱬ");
		a164.Size = new Size(200, 54);
		a164.Text = a425("Jǰɥ\u032aћթٷݩࡷ२\u0a62୰ര");
		a164.Click += a374;
		a46.DropDownItems.AddRange(new ToolStripItem[2] { a47, a48 });
		a46.Name = a425("`żɽͽуջټݤࡼ\u0946੯୧౽\u0d46\u0e7fཤၶᅯባ፳");
		a46.Size = new Size(56, 20);
		a46.Text = a425("FſɤͶѯգٳ");
		a47.Image = (Image)componentResourceManager.GetObject(a425("mŷɸͺцՠ١ݻࡡढ़੪ୠ౸\u0d45\u0e7f\u0f6f\u1064ᄺሷጨᑌᕩᙢᝥᡤ"));
		a47.ImageScaling = ToolStripItemImageScaling.None;
		a47.Name = a425("gŽɾͼќպٿݥࡻ\u0947੬୦\u0c72൏\u0e71ཡၮᄰሱ");
		a47.Size = new Size(190, 38);
		a47.Text = a425("UŴɾ\u036aѢԭ\u065cݪࡸ२\u0a65\u0b62\u0c72൷\u0e61\u0f6f\u1067ᅳ");
		a47.Click += a359;
		a48.Image = (Image)componentResourceManager.GetObject(a425("Jņ\u0339\u0349хՍ\u0656\u0610ࡡ०\u0a7f୯\u0c70ൺ\u0e68ศ၌ᅸቹ፹ᑇᕧᙠ\u1778ᡠ\u1942\u1a6b᭣ᱹᵂṾὬ\u2065ℶ∨⍌⑩╢♥❤"));
		a48.ImageScaling = ToolStripItemImageScaling.None;
		a48.Name = a425("@ŀ\u033fͳѿճ٨ت\u085bॠ\u0a79\u0b65౺൴\u0e66ย၆ᅾቿ፣ᑝᕹᙾᝢ\u187a᥄\u1a6d᭩ᱳᵌṰὦ\u206fℰ");
		a48.Size = new Size(190, 38);
		a48.Text = a425("Sű\u0310\u0362Ѭբٿػ\u0829\u0949\u0a7e୧౷൨\u0e62\u0f70ᄰ");
		a48.Click += a362;
		a153.DropDownItems.AddRange(new ToolStripItem[6] { a154, a155, a156, a157, a158, a183 });
		a153.Name = a425("aŻɼ;тդٽݧࡽ\u0941੮\u0b64౼൜\u0e66ཨ\u106cᅩቯ፣ᑳ");
		a153.Size = new Size(92, 20);
		a153.Text = a425("XŪɤȸѥի٧ݨࡥ९\u0a63୳");
		a154.Image = (Image)componentResourceManager.GetObject(a425("Òń\u02de\u034fѴվٳجࡲॷ\u0a7b୴౹\u0d43\u0e79\u0f7aၸᅀቦ፣ᑹᕿᙃᝨᡢ\u197eᩃ᭽ᱭᵪḨὌ\u2069Ⅲ≥⍤"));
		a154.ImageScaling = ToolStripItemImageScaling.None;
		a154.Name = a425("èźˠ\u0375юոٵئࡸॹ\u0a75\u0b7e\u0c73\u0d45\u0e7fའ\u1062ᅞቸ፹ᑣᕹᙅᝢᡨᥰᩍ᭷ᱧᵬ");
		a154.Size = new Size(220, 54);
		a154.Text = a425("ØŪ\u02f0\u0365Ъ՝٩ݪष५੨\u0b62౯ൠ");
		a154.Click += a344;
		a155.Image = (Image)componentResourceManager.GetObject(a425("Cņɔ\u0351ѣՑ\u0657ݑࡴॾ\u0a70ਬ\u0c71൷\u0e7b\u0f74ၹᅃቹ፺ᑸᕀᙦᝣ\u1879\u197fᩃ᭨ᱢᵾṃώ\u206dⅪ∨⍌⑩╢♥❤"));
		a155.ImageScaling = ToolStripItemImageScaling.None;
		a155.Name = a425("Iŀɒ\u036bљկ٩ݫࡎॸ੶ਦ౻൹\u0e75\u0f7e\u1073ᅅቿ፠ᑢᕞᙸ\u1779ᡣ\u1979ᩅ᭢ᱨᵰṍί\u2067Ⅼ");
		a155.Size = new Size(220, 54);
		a155.Text = a425("Xųɣ\u0364ЯՉٿݹࡻप\u0a5d୩౩ష\u0e68ཨ\u1062ᅯበ");
		a155.Click += a347;
		a156.Image = (Image)componentResourceManager.GetObject(a425("Bŝɋ\u034aфՊܒ\u0741ऐॴ\u0a7e୰ബ൱\u0e77\u0f7b\u1074ᅹቃ፹ᑺᕸᙀᝦᡣ\u1979\u1a7f\u1b43ᱨᵢṾὃ⁽Ⅽ≪⌨\u244c╩♢❥⡤"));
		a156.ImageScaling = ToolStripItemImageScaling.None;
		a156.Name = a425("Hŗɍ\u034cѾհܬݿप\u094e\u0a78୶ദൻ\u0e79\u0f75ၾᅳቅ\u137fᑠᕢᙞ\u1778\u1879ᥣ\u1a79ᭅᱢᵨṰὍ⁷Ⅷ≬");
		a156.Size = new Size(220, 54);
		a156.Text = a425("XŧɽͼѮՠ\u073cݯ\u093aप\u0a5d୩౩ష\u0e68ཨ\u1062ᅯበ");
		a156.Click += a350;
		a157.Image = (Image)componentResourceManager.GetObject(a425("Kŀɖ\u0348ч՛ٴݾࡰ\u082c\u0a71୷౻൴\u0e79གྷၹᅺቸፀᑦᕣᙹ\u177fᡃᥨ\u1a62᭾᱃ᵽṭὪ\u2028⅌≩⍢⑥╤"));
		a157.ImageScaling = ToolStripItemImageScaling.None;
		a157.Name = a425("MźɬͶѹա\u064eݸࡶ\u0826\u0a7b\u0b79\u0c75ൾ\u0e73ཅၿᅠቢ\u135eᑸᕹᙣ\u1779ᡅᥢ\u1a68\u1b70ᱍᵷṧὬ");
		a157.Size = new Size(220, 54);
		a157.Text = a425("]Ūɼ\u0366ѩձتݝࡩ३ଷ୨౨\u0d62\u0e6fའ");
		a157.Click += a353;
		a158.Image = (Image)componentResourceManager.GetObject(a425("SŃɗ\u0349ъՌـ\u074cࡋॿੳਭ\u0c76൶\u0e78\u0f75၃ᅹቺ፸ᑀᕦᙣ\u1779\u187f\u1943\u1a68᭢᱾ᵃṽὭ\u206aℨ≌⍩③╥♤"));
		a158.ImageScaling = ToolStripItemImageScaling.None;
		a158.Name = a425("UŅɭͳѴղٺݶࡍॹ\u0a79ਧ౸൸\u0e72\u0f7f၅ᅿበ።ᑞᕸᙹᝣ\u1879᥅\u1a62᭨ᱰᵍṷὧ\u206c");
		a158.Size = new Size(220, 54);
		a158.Text = a425("FŴɢ\u0362ѧգ٭ݧ\u082aढ़੩୩ഷ൨\u0e68རၯᅠ");
		a158.Click += a356;
		a183.Image = a2268.a2289;
		a183.ImageScaling = ToolStripItemImageScaling.None;
		a183.Name = a425("Vńɓ\u036bѕռٮݯࡎॸ੶ਦ౻൹\u0e75\u0f7e\u1073ᅅቿ፠ᑢᕞᙸ\u1779ᡣ\u1979ᩅ᭢ᱨᵰṍί\u2067Ⅼ");
		a183.Size = new Size(220, 54);
		a183.Text = a425("Gŷɢ\u0364ЯՅ٬ݾࡿप\u0a5d୩౩ష\u0e68ཨ\u1062ᅯበ");
		a183.Click += a414;
		a49.DropDownItems.AddRange(new ToolStripItem[3] { a150, a151, a152 });
		a49.Name = a425("gŽɾͼќպٿݥࡻ\u0947੬୦\u0c72൏\u0e71ཡၮᄰሰ");
		a49.Size = new Size(57, 20);
		a49.Text = a425("_Ťɶ\u0367Գլ");
		a150.Image = (Image)componentResourceManager.GetObject(a425("wſɶͷԪմٽݹࡃॹ\u0a7a\u0b78\u0c40൦\u0e63\u0f79ၿᅃቨ።ᑾᕃᙽ\u176dᡪ\u1928ᩌ᭩ᱢᵥṤ"));
		a150.ImageScaling = ToolStripItemImageScaling.None;
		a150.Name = a425("qŹɼͽԤպٷݳࡅॿ\u0a60\u0b62\u0c5e൸\u0e79ལၹᅅቢ፨ᑰᕍᙷᝧᡬ");
		a150.Size = new Size(197, 54);
		a150.Text = a425("@Ŧɭ\u036eԵխ٦ݠ");
		a150.Click += a411;
		a151.Name = a425("fžɿ\u0363ѝչپݢࡺ\u0944੭୩\u0c73\u0d4c\u0e70སၯᄴ");
		a151.Size = new Size(194, 6);
		a152.Image = (Image)componentResourceManager.GetObject(a425("Lœɉ\u0348тՌܐݍࡔ\u082f\u0a71\u0b7d౭൯\u0e63\u0f6d၃ᅹቺ፸ᑀᕦᙣ\u1779\u187f\u1943\u1a68᭢᱾ᵃṽὭ\u206aℨ≌⍩③╥♤"));
		a152.ImageScaling = ToolStripItemImageScaling.None;
		a152.Name = a425("JŕɳͲѼղܪݷࡒ\u0829\u0a7b୷\u0c63ൡ\u0e69ཧ၅ᅿበ።ᑞᕸᙹᝣ\u1879᥅\u1a62᭨ᱰᵍṷὧ\u206c");
		a152.Size = new Size(197, 54);
		a152.Text = a425("Zťɣ\u0362Ѭբ\u073aݧ\u0829\u0943ଶ୪\u0c64൲\u0e76\u0f78\u1074");
		a50.ActiveGroup = a53;
		a50.Appearance.GroupHeader.Font = new Font(a425("RŤɬ\u036cѯՠ"), 9.75f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a50.Appearance.GroupHeader.ForeColor = Color.DimGray;
		a50.Appearance.GroupHeader.Options.UseFont = true;
		a50.Appearance.GroupHeader.Options.UseForeColor = true;
		a50.Appearance.GroupHeader.Options.UseImage = true;
		a50.Appearance.GroupHeaderPressed.Options.UseImage = true;
		a50.Appearance.Item.Options.UseTextOptions = true;
		a50.Appearance.Item.TextOptions.HAlignment = HorzAlignment.Near;
		a50.Appearance.ItemActive.Options.UseTextOptions = true;
		a50.Appearance.ItemActive.TextOptions.HAlignment = HorzAlignment.Near;
		a50.Appearance.ItemDisabled.Options.UseTextOptions = true;
		a50.Appearance.ItemDisabled.TextOptions.HAlignment = HorzAlignment.Near;
		a50.Appearance.ItemHotTracked.Options.UseTextOptions = true;
		a50.Appearance.ItemHotTracked.TextOptions.HAlignment = HorzAlignment.Near;
		a50.BackColor = Color.White;
		a50.BorderStyle = BorderStyles.Simple;
		a50.Dock = DockStyle.Left;
		a50.Groups.AddRange(new NavBarGroup[6] { a53, a56, a59, a62, a110, a51 });
		a50.Items.AddRange(new NavBarItem[31]
		{
			a64, a55, a54, a65, a66, a57, a67, a68, a69, a70,
			a71, a72, a73, a58, a74, a60, a61, a52, a63, a109,
			a108, a111, a112, a114, a149, a163, a166, a179, a180, a182,
			a184
		});
		a50.Location = new Point(0, 24);
		a50.LookAndFeel.SkinName = a425("GżɻͳѯՖ٭ݨ\u086b९");
		a50.LookAndFeel.Style = LookAndFeelStyle.Style3D;
		a50.LookAndFeel.UseDefaultLookAndFeel = false;
		a50.Name = a425("hŤɲ\u0341ѣճ");
		a50.OptionsNavPane.ExpandedWidth = 140;
		a50.Size = new Size(238, 469);
		a50.TabIndex = 10;
		a50.Text = a425("`Ŭɺ\u0349ѫջ\u064bݨࡨॱ੶୬౮ള");
		a50.View = new SkinExplorerBarViewInfoRegistrator();
		a50.MouseDown += a377;
		a53.Appearance.Font = new Font(a425("RŤɬ\u036cѯՠ"), 12f);
		a53.Appearance.Options.UseFont = true;
		a53.Caption = a425("Nťɺȳѵ");
		a53.ItemLinks.AddRange(new NavBarItemLink[3]
		{
			new NavBarItemLink(a54),
			new NavBarItemLink(a55),
			new NavBarItemLink(a180)
		});
		a53.Name = a425("Eūɿ\u034aѦմ\u064eݥࡺ५\u0a75");
		a54.Caption = a425("AŨɺͳЦՎ٥ݺळॵ");
		a54.Name = a425("kźɈ\u0368юեٺݫࡵ");
		a54.SmallImage = (Image)componentResourceManager.GetObject(a425("všɝͿћծٷݤࡸथਖ਼\u0b64౩൫\u0e6aཌ\u1069ᅢብ፤"));
		a54.LinkClicked += a260;
		a55.Caption = a425("DŠɾ\u0361ѹԫفݨࡺॳਦਵ൛൯\u0e67ཬ");
		a55.Name = a425("hŻɇ\u0369ѧռ٨ݢ\u086fॠ");
		a55.SmallImage = (Image)componentResourceManager.GetObject(a425("wŦɜͼѰթ٣ݯࡠ७ਥ\u0b59\u0c64൩\u0e6bཪ၌ᅩቢ፥ᑤ"));
		a55.LinkClicked += a393;
		a180.Caption = a425("^ŵɡ\u0366б՝٪ݼࡦ३\u0a71\u0b63\u0c29\u0d4c\u0e62น\u106cၛቪ፯ᑨ");
		a180.Name = a425("eūɿ\u034aѦմ\u064cݰࡦ९ਵ");
		a180.SmallImage = (Image)componentResourceManager.GetObject(a425("xŴɢ\u0351ѳգ\u0659ݻ\u086bॠਸଥౙ\u0d64\u0e69ཫ\u106aᅌቩ።ᑥᕤ"));
		a180.LinkClicked += a399;
		a56.Appearance.Font = new Font(a425("RŤɬ\u036cѯՠ"), 12f);
		a56.Appearance.Options.UseFont = true;
		a56.Caption = a425("Sǵɣ\u036bѣը١ݯࡧॳ");
		a56.ItemLinks.AddRange(new NavBarItemLink[2]
		{
			new NavBarItemLink(a57),
			new NavBarItemLink(a58)
		});
		a56.Name = a425("^Ůɸ\u034fѭչ\u0653ݼࡣ५\u0a63୨ౡ൯\u0e67\u0f73");
		a57.Caption = a425("\\Ūɸ\u0368Ш՞ۺݮࡨ०੯\u0b64");
		a57.Name = a425("nŹɉ\u0360Ѡզټݑࡥ७੫୬");
		a57.SmallImage = (Image)componentResourceManager.GetObject(a425("uŤɖͽѻճ٫\u0744\u086eॠ\u0a64ୡథ൙\u0e64ཀྵ\u106bᅪቌ፩ᑢᕥᙤ"));
		a57.LinkClicked += a290;
		a58.Caption = a425("LǶɧ\u0328ў\u05faٮݨࡦ९\u0a64");
		a58.Name = a425("pţɕ\u0364Ѣըپݝ\u086fढ़੩୵౧൨\u0e65\u0f6f\u1063ᅳ");
		a58.SmallImage = (Image)componentResourceManager.GetObject(a425("\u007fŮɞͱѵս٥\u0740ࡰ\u0940ੲୠ\u0c70ൽ\u0e6eར\u106cᅾሥፙᑤᕩᙫᝪᡌᥩ\u1a62᭥ᱤ"));
		a58.LinkClicked += a296;
		a59.Appearance.Font = new Font(a425("RŤɬ\u036cѯՠ"), 12f);
		a59.Appearance.Options.UseFont = true;
		a59.Caption = a425("ZŦɶ\u036aѶկ٣ݳ");
		a59.ItemLinks.AddRange(new NavBarItemLink[4]
		{
			new NavBarItemLink(a60),
			new NavBarItemLink(a61),
			new NavBarItemLink(a163),
			new NavBarItemLink(a184)
		});
		a59.Name = a425("@Ŭɺ\u0349ѫջ\u065aݦࡶ४੶୯\u0c63൳");
		a60.Caption = a425("YŤɼ\u0363ѯգ\u073dݦ\u082aज़੩୷౩൷\u0e68རၰ\u1030");
		a60.Name = a425("lſɜ\u0379ѥդ٧ݴࡿ४੪୯\u0c63൳");
		a60.SmallImage = (Image)componentResourceManager.GetObject(a425("{Ūɇ\u0364Ѻչټݡࡨॿ\u0a61\u0b62౬ൾลཙ\u1064ᅩቫ፪ᑌᕩᙢᝥᡤ"));
		a60.LinkClicked += a278;
		a61.Caption = a425("Kšɡ\u0379ѦԪ\u065bݩࡷ३\u0a77୨\u0c62൰༰");
		a61.Name = a425("mżɝ;Ѥէ٦ݻࡾ३੫\u0b50౪൲\u0e68");
		a61.SmallImage = (Image)componentResourceManager.GetObject(a425("xūɈ\u0365ѹոٻݠ\u086bॾ\u0a7e\u0b5b౧ൽ\u0e65༥\u1059ᅤቩ፫ᑪᕌᙩᝢᡥᥤ"));
		a61.LinkClicked += a281;
		a163.Caption = a425("Jǰɥ\u032aћթٷݩࡷ२\u0a62୰ര");
		a163.Name = a425("eūɿ\u034aѦմ\u064cݰࡦ९ਲ਼");
		a163.SmallImage = (Image)componentResourceManager.GetObject(a425("xŴɢ\u0351ѳգ\u0659ݻ\u086bॠ\u0a3eଥౙ\u0d64\u0e69ཫ\u106aᅌቩ።ᑥᕤ"));
		a163.LinkClicked += a371;
		a184.Caption = a425("DŧɢͿѠԪ\u065bݩࡷ३\u0a77୨\u0c62൰༰");
		a184.Name = a425("eūɿ\u034aѦմ\u064cݰࡦ९\u0a37");
		a184.SmallImage = a2268.a2287;
		a184.LinkClicked += a417;
		a62.Appearance.Font = new Font(a425("RŤɬ\u036cѯՠ"), 12f);
		a62.Appearance.Options.UseFont = true;
		a62.Caption = a425("FſɤͶѯգٳ");
		a62.ItemLinks.AddRange(new NavBarItemLink[4]
		{
			new NavBarItemLink(a63),
			new NavBarItemLink(a149),
			new NavBarItemLink(a166),
			new NavBarItemLink(a182)
		});
		a62.Name = a425("Cŭɽ\u0348Ѩպنݿࡤॶ੯\u0b63\u0c73");
		a63.Caption = a425("Sű\u0310\u0362Ѭբٿػ\u0829\u0949\u0a7e୧౷൨\u0e62\u0f70ᄰ");
		a63.Name = a425("pţɒ\u036eѩա٭ݥࡾॠ\u0a49\u0b7e౧൷\u0e68རၰᅨ");
		a63.SmallImage = (Image)componentResourceManager.GetObject(a425("\u007fŮəͻѾմٶݸࡡॽ\u0a52୫\u0c70\u0d62\u0e63\u0f6fၿᅥሥፙᑤᕩᙫᝪᡌᥩ\u1a62᭥ᱤ"));
		a63.LinkClicked += a266;
		a149.Caption = a425("UŴɾ\u036aѢԭ\u065cݪࡸ२\u0a65\u0b62\u0c72൷\u0e61\u0f6f\u1067ᅳ");
		a149.Name = a425("eūɿ\u034aѦմ\u064cݰࡦ९ਰ");
		a149.SmallImage = (Image)componentResourceManager.GetObject(a425("xŴɢ\u0351ѳգ\u0659ݻ\u086bॠ\u0a3dଥౙ\u0d64\u0e69ཫ\u106aᅌቩ።ᑥᕤ"));
		a149.LinkClicked += a293;
		a166.Caption = a425("XŧɽͼѮՠ\u073cݯ\u093aप\u0a44୭\u0c74൧\u0e6fཨ\u1062ᅰጰ");
		a166.Name = a425("eūɿ\u034aѦմ\u064cݰࡦ९ਲ");
		a166.SmallImage = (Image)componentResourceManager.GetObject(a425("xŴɢ\u0351ѳգ\u0659ݻ\u086bॠ\u0a3fଥౙ\u0d64\u0e69ཫ\u106aᅌቩ።ᑥᕤ"));
		a166.LinkClicked += a380;
		a182.Caption = a425("AŷɢͽѦԮ\u0659ݭࡿ\u0963\u0a65ନ\u0c40\u0dfa\u0e6bཨၦᅰቨ");
		a182.Name = a425("eūɿ\u034aѦմ\u064cݰࡦ९\u0a34");
		a182.SmallImage = (Image)componentResourceManager.GetObject(a425("xŴɢ\u0351ѳգ\u0659ݻ\u086bॠਹଥౙ\u0d64\u0e69ཫ\u106aᅌቩ።ᑥᕤ"));
		a182.LinkClicked += a402;
		a110.Appearance.Font = new Font(a425("RŤɬ\u036cѯՠ"), 12f);
		a110.Appearance.Options.UseFont = true;
		a110.Caption = a425("XŪɤȸѥի٧ݨࡥ९\u0a63୳");
		a110.ItemLinks.AddRange(new NavBarItemLink[6]
		{
			new NavBarItemLink(a114),
			new NavBarItemLink(a112),
			new NavBarItemLink(a108),
			new NavBarItemLink(a109),
			new NavBarItemLink(a111),
			new NavBarItemLink(a179)
		});
		a110.Name = a425("\\Űɦ\u034dѯտ\u0658ݪࡤॠ\u0a65୫౧൨\u0e65\u0f6f\u1063ᅳ");
		a114.Caption = a425("Ø\u0012\u02f0\u0365Ъ՝٩ݩष२੨\u0b62౯ൠ");
		a114.Name = a425("iŸɆ\u036fѲը\u0651ݥ\u086d५੬");
		a114.SmallImage = (Image)componentResourceManager.GetObject(a425("tŧɛʹѧտلݮࡠ।\u0a61ଥౙ\u0d64\u0e69ཫ\u106aᅌቩ።ᑥᕤ"));
		a114.LinkClicked += a275;
		a112.Caption = a425("Xųɣ\u0364ЯՉٿݹࡻप\u0a5d୩౩ష\u0e68ཨ\u1062ᅯበ");
		a112.Name = a425("hŻɃ\u0366Ѵձكݱࡷॱ");
		a112.SmallImage = (Image)componentResourceManager.GetObject(a425("wŦɘͳѣդوݼࡸॼਥ\u0b59\u0c64൩\u0e6bཪ၌ᅩቢ፥ᑤ"));
		a112.LinkClicked += a263;
		a108.Caption = a425("XŧɽͼѮՠ\u073cݯ\u093aप\u0a5d୩౩ష\u0e68ཨ\u1062ᅯበ");
		a108.Name = a425("rŽɅ\u0378Ѡէ٫ݧࡡ।੯\u0b51\u0c65൭\u0e6bཬ");
		a108.SmallImage = (Image)componentResourceManager.GetObject(a425("yŨɒ\u036dѻպٴݺࡺॱ\u0a78\u0b44౮ൠ\u0e64ཡဥᅙቤ፩ᑫᕪᙌᝩᡢᥥ\u1a64"));
		a108.LinkClicked += a248;
		a109.Caption = a425("AŮɸ\u0362ѭսئݑࡥ७ଳ୬");
		a109.Name = a425("ožɆ\u036fѻգ٢ݼࡑ॥੭୫౬");
		a109.SmallImage = (Image)componentResourceManager.GetObject(a425("zťɛͰѦոٷݫࡄ८\u0a60\u0b64ౡഥ๙ཤ\u1069ᅫቪፌᑩᕢᙥᝤ"));
		a109.LinkClicked += a251;
		a111.Caption = a425("FŴɢ\u0362ѧգ٭ݧ\u082aढ़੩୩ഷ൨\u0e68རၯᅠ");
		a111.Name = a425("qŠɅ\u0375ѽգ٤ݢࡪ०\u0a5d୩౩൯\u0e68ཨ\u1062ᅯበ");
		a111.SmallImage = (Image)componentResourceManager.GetObject(a425("|ůɈ;Ѩմٱݹࡷॹ\u0a40୲౼൸\u0e7dལၯᅠቭጥᑙᕤᙩᝫᡪ᥌\u1a69᭢ᱥᵤ"));
		a111.LinkClicked += a269;
		a179.Caption = a425("Gŷɢ\u0364ЯՅ٬ݾࡿप\u0a5d୩౩ష\u0e68ཨ\u1062ᅯበ");
		a179.Name = a425("hŻɜ\u0362ѵձ\u064fݢࡰॵ");
		a179.SmallImage = (Image)componentResourceManager.GetObject(a425("wŦɇͷѢդلݯࡿॸਥ\u0b59\u0c64൩\u0e6bཪ၌ᅩቢ፥ᑤ"));
		a179.LinkClicked += a390;
		a51.Appearance.Font = new Font(a425("RŤɬ\u036cѯՠ"), 12f);
		a51.Appearance.Options.UseFont = true;
		a51.Caption = a425("Â5ɨȳ՞");
		a51.ItemLinks.AddRange(new NavBarItemLink[1]
		{
			new NavBarItemLink(a52)
		});
		a51.Name = a425("Eūɿ\u034aѦմنݭࡨ५ੲ");
		a52.Caption = a425("Â5ɨȳ՞");
		a52.Name = a425("bŪɼ\u034bѩյ\u064fݱࡡ८ਲ਼ସ");
		a52.SmallImage = (Image)componentResourceManager.GetObject(a425("yŷɣ\u0356Ѳՠ\u0658ݤࡪ\u0963\u0a3cଵథ൙\u0e64ཀྵ\u106bᅪቌ፩ᑢᕥᙤ"));
		a52.LinkClicked += a254;
		a64.Caption = a425("JŬɢȺՕդ٩ݩ\u0826࠵\u0b5b୯౧൬");
		a64.Name = a425("mżɉ\u036dѥգٺݥࡦ२\u0a4c୷౯൧\u0e6c");
		a65.Caption = a425("^Ũɾ\u0378ѥէ٭ݫ\u0826\u094e\u0a65\u0b7aള൵");
		a65.Name = a425("mżɝ\u0369ѹչ٦ݦࡢ४\u0a4e\u0b65౺൫\u0e75");
		a66.Caption = a425("]Ǵɵ\u0326ёե٭س\u086c");
		a66.Name = a425("hŻɜͲѴՑ٥ݭ\u086b६");
		a67.Caption = a425("XŪɸ\u0360Ѯբئݑࡥ७ଳ୬");
		a67.Name = a425("ožɟ\u036bѻա١ݣࡑ॥੭୫౬");
		a68.Caption = a425("EŹɻ\u036eѿժ٪ݯࡣॳ");
		a68.Name = a425("nŹɅ\u0379ѻծٿݪࡪ९\u0a63୳");
		a69.Caption = a425("UŴɾ\u036aѢԭ\u065cݪࡸ२\u0a65\u0b62\u0c72൷\u0e61\u0f6f\u1067ᅳ");
		a69.Name = a425("qŠɖ\u0375ѡի١ݜࡪॸ੨\u0b65౦൲\u0e77ཡၯᅧታ");
		a70.Caption = a425("Fţɥ\u036cѠկۻݴࡤॷ\u0a7a୭౯");
		a70.Name = a425("mżɆ\u0363ѥլ٠ݯ\u086eॴ\u0a64୷౺൭\u0e6f");
		a71.Caption = a425("bŪɼ\u034bѩյ\u064fݱࡡ८ਲ਼ଳ");
		a71.Name = a425("bŪɼ\u034bѩյ\u064fݱࡡ८ਲ਼ଳ");
		a72.Caption = a425("@Ūɼ;ѣեٯݥࠨ\u094b੯୶\u0c70൦\u0e71ཨ");
		a72.Name = a425("sŢɟ\u036bѿտ٤ݤ\u086c।\u0a4b୯\u0c76൰\u0e66\u0f71\u1068");
		a73.Caption = a425("AŽɩ\u0379ѫս٧ݵ\u0826࠵\u0b5b୯౧൬");
		a73.Name = a425("mżɂͼѪո٨ݼࡨॴ\u0a4c୷౯൧\u0e6c");
		a74.Caption = a425("JŪɾͼѺզئݑࡥ२੫ୱ");
		a74.Name = a425("ožɍ\u036bѽսٵݧࡑ॥੨୫\u0c71");
		a75.BorderStyle = BorderStyles.NoBorder;
		a75.Dock = DockStyle.Fill;
		a75.Location = new Point(238, 24);
		a75.LookAndFeel.SkinName = a425("GżɻͳѯՖ٭ݨ\u086b९");
		a75.LookAndFeel.UseDefaultLookAndFeel = false;
		a75.Name = a425("wźɿ\u036dџի٫\u074bࡨ२\u0a71୶౬൮ะ");
		a75.SelectedTabPage = a81;
		a75.Size = new Size(937, 469);
		a75.TabIndex = 11;
		a75.TabPages.AddRange(new XtraTabPage[2] { a76, a81 });
		a75.Text = a425("wźɿ\u036dџի٫\u074bࡨ२\u0a71୶౬൮ะ");
		a81.Controls.Add(a82);
		a81.Controls.Add(a91);
		a81.Name = a425("_ūɫ\u0358Ѧա٠ݔࡢ॰\u0a60");
		a81.Size = new Size(928, 439);
		a81.Text = a425("\\Ūɸ\u0368Ш՞ۺݮࡨ०੯\u0b64");
		a82.ContextMenuStrip = a160;
		a82.Dock = DockStyle.Fill;
		a82.EmbeddedNavigator.Name = a425("");
		a82.Font = new Font(a425("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a82.Location = new Point(0, 172);
		a82.LookAndFeel.SkinName = a425("GżɻͳѯՖ٭ݨ\u086b९");
		a82.LookAndFeel.UseDefaultLookAndFeel = false;
		a82.MainView = a83;
		a82.Name = a425("kŹɣ\u036dыը٨ݱࡶ६੮ଳ");
		a82.RepositoryItems.AddRange(new RepositoryItem[8] { a84, a85, a86, a87, a88, a89, a90, a186 });
		a82.Size = new Size(928, 267);
		a82.TabIndex = 8;
		a82.ViewCollection.AddRange(new BaseView[1] { a83 });
		a160.Items.AddRange(new ToolStripItem[2] { a161, a162 });
		a160.Name = a425("rſɡͺѨմٿ\u0747\u086c०ੲ\u0b55\u0c71൶\u0e6a\u0f72\u1030");
		a160.Size = new Size(137, 80);
		a161.Enabled = false;
		a161.Image = (Image)componentResourceManager.GetObject(a425("mŷɸͺцՠ١ݻࡡढ़੪ୠ౸\u0d45\u0e7f\u0f6f\u1064ᄹሷጨᑌᕩᙢᝥᡤ"));
		a161.ImageScaling = ToolStripItemImageScaling.None;
		a161.Name = a425("gŽɾͼќպٿݥࡻ\u0947੬୦\u0c72൏\u0e71ཡၮᄳሱ");
		a161.Size = new Size(136, 38);
		a161.Text = a425("Oǻɨ\u0366ѡկٮݤ");
		a162.Image = (Image)componentResourceManager.GetObject(a425("mŷɸͺцՠ١ݻࡡढ़੪ୠ౸\u0d45\u0e7f\u0f6f\u1064ᄹሶጨᑌᕩᙢᝥᡤ"));
		a162.ImageScaling = ToolStripItemImageScaling.None;
		a162.Name = a425("gŽɾͼќպٿݥࡻ\u0947੬୦\u0c72൏\u0e71ཡၮᄳሰ");
		a162.Size = new Size(136, 38);
		a162.Text = a425("ĸŷɲ\u0364Ѩԣهݵ");
		a162.Click += a368;
		a83.BorderStyle = BorderStyles.NoBorder;
		a83.Columns.AddRange(new GridColumn[9] { a117, a118, a119, a120, a121, a122, a123, a124, a125 });
		a83.FocusRectStyle = DrawFocusRectStyle.RowFocus;
		a83.GridControl = a82;
		a83.Name = a425("nźɮ\u0362ѓխ٦ݵ࠳");
		a83.OptionsBehavior.Editable = false;
		a83.OptionsFilter.AllowFilterEditor = false;
		a83.OptionsView.ColumnAutoWidth = false;
		a83.OptionsView.ShowAutoFilterRow = true;
		a83.OptionsView.ShowGroupPanel = false;
		a117.Caption = a425("KŅ");
		a117.FieldName = a425("KŅ");
		a117.Name = a425("lŸɠ\u036cфթ٩ݱ\u086e६ਰ");
		a118.Caption = a425("HŬ\u0336\u0326іիٺݣࡥ");
		a118.FieldName = a425("Lŏɖ\u034dтՆو");
		a118.Name = a425("lŸɠ\u036cфթ٩ݱ\u086e६ਲ਼");
		a118.Visible = true;
		a118.VisibleIndex = 0;
		a118.Width = 180;
		a119.Caption = a425("LŧɷͰУՌٮ");
		a119.FieldName = a425("Bŉɕ\u0352ыՋ\u064b\u0747\u0859");
		a119.Name = a425("lŸɠ\u036cфթ٩ݱ\u086e६ਲ");
		a119.Visible = true;
		a119.VisibleIndex = 1;
		a119.Width = 135;
		a120.Caption = a425("^Ũɺ\u036eѮԥ\u0657ݢࡣॵ");
		a120.FieldName = a425("]ŉɕ\u034fэ\u0557ق\u0743ࡕ");
		a120.Name = a425("lŸɠ\u036cфթ٩ݱ\u086e६ਵ");
		a120.Visible = true;
		a120.VisibleIndex = 2;
		a120.Width = 112;
		a121.AppearanceHeader.Options.UseTextOptions = true;
		a121.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Far;
		a121.Caption = a425("ÛŢɨ\u036fѢաا\u0744ࡤ९੪\u0b7b\u0c64");
		a121.FieldName = a425("YŐɂ\u035bёՂق\u0748ࡏ\u0942\u0a41\u0b58\u0c44\u0d44๏ཊၛᅄ");
		a121.Name = a425("lŸɠ\u036cфթ٩ݱ\u086e६\u0a34");
		a121.Visible = true;
		a121.VisibleIndex = 5;
		a121.Width = 123;
		a122.Caption = a425("CŲɪ\u0369ѥխ\u0733ݬ");
		a122.FieldName = a425("CŒɊ\u0349хՍ\u064b\u074c");
		a122.Name = a425("lŸɠ\u036cфթ٩ݱ\u086e६\u0a37");
		a122.Visible = true;
		a122.VisibleIndex = 3;
		a122.Width = 91;
		a123.AppearanceHeader.Options.UseTextOptions = true;
		a123.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Far;
		a123.Caption = a425("Qűɷ\u0363ѳ");
		a123.FieldName = a425("Qőɗ\u0343ѓ");
		a123.Name = a425("lŸɠ\u036cфթ٩ݱ\u086e६ਸ਼");
		a123.Visible = true;
		a123.VisibleIndex = 4;
		a123.Width = 71;
		a124.AppearanceHeader.Options.UseTextOptions = true;
		a124.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Far;
		a124.Caption = a425("]Ţɢ\u0379ѫբ١ܧࡄ।੯୪౻\u0d64");
		a124.FieldName = a425("XœɃ\u0344ѐ՝ق\u0742\u0859\u094b\u0a42\u0b41ౘ\u0d44ไཏ၊ᅛቄ");
		a124.Name = a425("lŸɠ\u036cфթ٩ݱ\u086e६ਹ");
		a124.Visible = true;
		a124.VisibleIndex = 6;
		a124.Width = 103;
		a125.Caption = a425("KŠɶ\u0368ѧջ");
		a125.FieldName = a425("Kŀɖ\u0348ч՛");
		a125.Name = a425("lŸɠ\u036cфթ٩ݱ\u086e६ਸ");
		a125.Visible = true;
		a125.VisibleIndex = 7;
		a125.Width = 247;
		a84.AutoHeight = false;
		a84.Buttons.AddRange(new EditorButton[1]
		{
			new EditorButton(ButtonPredefines.Glyph, a425("AŨɮ\u0364"), -1, enabled: true, visible: true, isLeft: false, HorzAlignment.Center, null)
		});
		a84.Name = a425("eŲɫ\u0341Ѩծ٤");
		a84.TextEditStyle = TextEditStyles.HideTextEditor;
		a85.AutoHeight = false;
		a85.Buttons.AddRange(new EditorButton[1]
		{
			new EditorButton(ButtonPredefines.Glyph, a425("CǦ"), -1, enabled: true, visible: true, isLeft: false, HorzAlignment.Center, null)
		});
		a85.Name = a425("gŰɭ\u0343Ѣ");
		a85.TextEditStyle = TextEditStyles.HideTextEditor;
		a86.AutoHeight = false;
		a86.Buttons.AddRange(new EditorButton[1]
		{
			new EditorButton()
		});
		a86.Name = a425("eųɥͻѠջ٥ݿࡽॷ\u0a44\u0b78౮൧\u0e5dཡ\u106aᅣቀ፠ᑪᕶᘰ");
		a87.AutoHeight = false;
		a87.Buttons.AddRange(new EditorButton[1]
		{
			new EditorButton(ButtonPredefines.Combo)
		});
		a87.Name = a425("eųɥͻѠջ٥ݿࡽॷ\u0a44\u0b78౮൧\u0e4dཀྵ\u1073ᅣቀ፠ᑪᕶᘰ");
		a87.VistaTimeProperties.Buttons.AddRange(new EditorButton[1]
		{
			new EditorButton()
		});
		a88.AutoHeight = false;
		a88.Buttons.AddRange(new EditorButton[1]
		{
			new EditorButton()
		});
		a88.Name = a425("kŽɧ\u0379Ѧս٧ݽࡣ३\u0a46\u0b7a౨ൡ\u0e49\u0f7fၽᅼቨ፨ᑀᕠᙪ\u1776ᠰ");
		a89.AutoHeight = false;
		a89.Buttons.AddRange(new EditorButton[1]
		{
			new EditorButton(ButtonPredefines.Glyph, a425("HŬɸ;Ѹըب\u0740ࡣ\u09e2੩୪൝൨"), -1, enabled: true, visible: true, isLeft: false, HorzAlignment.Center, null)
		});
		a89.Name = a425("RŻɠ\u034bѭտٿݻࡩ\u0940\u0a63୦౩൪\u0e71ཨ");
		a89.TextEditStyle = TextEditStyles.HideTextEditor;
		a90.AutoHeight = false;
		a90.Buttons.AddRange(new EditorButton[1]
		{
			new EditorButton(ButtonPredefines.Glyph, a425("AŨɮ\u0364"), -1, enabled: true, visible: true, isLeft: false, HorzAlignment.Center, null)
		});
		a90.Name = a425("oŸɥ\u034cѨռٲݴࡤ\u0941੨୮\u0c64");
		a90.TextEditStyle = TextEditStyles.HideTextEditor;
		a186.AutoHeight = false;
		a186.Name = a425("jŲɦͺѧպ٦ݾࡢॶ\u0a47\u0b79౩൦\u0e49ཡ\u106dᅤቭፀᑠᕪᙶᜰ");
		a186.ValueChecked = a425("D");
		a186.ValueUnchecked = a425("I");
		a91.BackColor = Color.White;
		a91.Controls.Add(a99);
		a91.Controls.Add(a101);
		a91.Controls.Add(a176);
		a91.Controls.Add(a177);
		a91.Controls.Add(a174);
		a91.Controls.Add(a175);
		a91.Controls.Add(a171);
		a91.Controls.Add(a169);
		a91.Controls.Add(a172);
		a91.Controls.Add(a173);
		a91.Controls.Add(a170);
		a91.Controls.Add(a159);
		a91.Controls.Add(a136);
		a91.Controls.Add(a107);
		a91.Controls.Add(a178);
		a91.Controls.Add(a100);
		a91.Controls.Add(a102);
		a91.Controls.Add(a137);
		a91.Controls.Add(a138);
		a91.Controls.Add(a139);
		a91.Controls.Add(a140);
		a91.Controls.Add(a141);
		a91.Controls.Add(a142);
		a91.Controls.Add(a143);
		a91.Controls.Add(a144);
		a91.Controls.Add(a145);
		a91.Controls.Add(a146);
		a91.Controls.Add(a147);
		a91.Controls.Add(a148);
		a91.Controls.Add(a103);
		a91.Controls.Add(a104);
		a91.Controls.Add(a105);
		a91.Controls.Add(a106);
		a91.Controls.Add(a165);
		a91.Controls.Add(a92);
		a91.Controls.Add(a93);
		a91.Controls.Add(a94);
		a91.Dock = DockStyle.Top;
		a91.Location = new Point(0, 0);
		a91.Name = a425("nźɨͳѵՆ٬ݺ࠰");
		a91.Size = new Size(928, 172);
		a91.TabIndex = 7;
		a91.TabStop = false;
		a91.Text = a425("aXɪ\u0360ѩկ٧ݳ");
		a99.Font = new Font(a425("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 14.25f);
		a99.Location = new Point(382, 114);
		a99.Name = a425("jŲɲͱѫխس\u0730");
		a99.Size = new Size(95, 48);
		a99.TabIndex = 113;
		a99.Tag = a425("G");
		a99.Text = a425("0Ĵȣ\u0356э");
		a99.UseVisualStyleBackColor = true;
		a99.Click += a323;
		a101.Font = new Font(a425("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 14.25f);
		a101.Location = new Point(382, 67);
		a101.Name = a425("eųɱͰѬլظ");
		a101.Size = new Size(95, 48);
		a101.TabIndex = 113;
		a101.Tag = a425("G");
		a101.Text = a425("7Ĵȣ\u0356э");
		a101.UseVisualStyleBackColor = true;
		a101.Click += a317;
		a176.Enabled = false;
		a176.Font = new Font(a425("RŤɬ\u036cѯՠ"), 15.75f);
		a176.Location = new Point(707, 120);
		a176.Name = a425("\u007fŲɽ\u0343Ѧմٱ\u0743ࡱॷ\u0a71");
		a176.Size = new Size(351, 33);
		a176.TabIndex = 121;
		a177.Enabled = false;
		a177.Font = new Font(a425("RŤɬ\u036cѯՠ"), 15.75f);
		a177.Location = new Point(707, 86);
		a177.Name = a425("~űɼ\u0346ѢՖ٫ݺࡣ॥");
		a177.Size = new Size(351, 33);
		a177.TabIndex = 121;
		a174.Enabled = false;
		a174.Font = new Font(a425("RŤɬ\u036cѯՠ"), 15.75f);
		a174.Location = new Point(707, 52);
		a174.Name = a425("sžɱ\u0350рՌٮ");
		a174.Size = new Size(161, 33);
		a174.TabIndex = 121;
		a175.Enabled = false;
		a175.Font = new Font(a425("RŤɬ\u036cѯՠ"), 15.75f);
		a175.Location = new Point(707, 18);
		a175.Name = a425("}Űɳ\u034dѤնٷ\u074c\u086e");
		a175.Size = new Size(161, 33);
		a175.TabIndex = 121;
		a171.BackColor = Color.FromArgb(128, 255, 128);
		a171.BorderStyle = BorderStyle.Fixed3D;
		a171.FlatStyle = FlatStyle.Flat;
		a171.ForeColor = Color.FromArgb(128, 255, 128);
		a171.Location = new Point(638, 21);
		a171.Name = a425("jŤɦ\u0366ѮԸ");
		a171.Size = new Size(3, 138);
		a171.TabIndex = 120;
		a169.AutoSize = true;
		a169.Location = new Point(646, 29);
		a169.Name = a425("jŤɦ\u0366ѮԷ");
		a169.Size = new Size(43, 13);
		a169.TabIndex = 119;
		a169.Text = a425("LŧɷͰУՌٮ");
		a172.AutoSize = true;
		a172.Location = new Point(646, 128);
		a172.Name = a425("kŧɧ\u0361ѯԳر");
		a172.Size = new Size(59, 13);
		a172.TabIndex = 118;
		a172.Text = a425("AŨɺͳЦՂٱݱࡷॱ");
		a173.AutoSize = true;
		a173.Location = new Point(646, 61);
		a173.Name = a425("kŧɧ\u0361ѯԳذ");
		a173.Size = new Size(36, 13);
		a173.TabIndex = 118;
		a173.Text = a425("QŇȣ\u034cѮ");
		a170.AutoSize = true;
		a170.Location = new Point(646, 96);
		a170.Name = a425("jŤɦ\u0366ѮԶ");
		a170.Size = new Size(53, 13);
		a170.TabIndex = 118;
		a170.Text = a425("IţȦ\u0356ѫպ٣ݥ");
		a159.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		a159.Image = (Image)componentResourceManager.GetObject(a425("aŹɬͺѸվٮ\u0748ࡦ॰ਸ਼ନ\u0c4c൩\u0e62ཥ\u1064"));
		a159.Location = new Point(876, 14);
		a159.Name = a425("{ţɪͼѲմ٠\u0746\u086cॺਰ");
		a159.Size = new Size(46, 43);
		a159.TabIndex = 116;
		a159.TabStop = false;
		a136.Font = new Font(a425("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 24f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a136.ForeColor = SystemColors.WindowText;
		a136.Location = new Point(165, 21);
		a136.MaxLength = 6;
		a136.Name = a425("|ſɲ\u0351ѱշ٣ݳ");
		a136.Size = new Size(123, 44);
		a136.TabIndex = 114;
		a136.Tag = a425("G");
		a136.Text = a425("4įȲ\u0331");
		a136.TextAlign = HorizontalAlignment.Right;
		a136.KeyPress += a302;
		a107.Enabled = false;
		a107.Font = new Font(a425("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 24f);
		a107.ForeColor = SystemColors.WindowText;
		a107.Location = new Point(165, 68);
		a107.Name = a425("~űɼ\u0353фդٯݪࡻ।");
		a107.Size = new Size(123, 44);
		a107.TabIndex = 114;
		a107.Tag = a425("G");
		a107.Text = a425("4įȲ\u0331");
		a107.TextAlign = HorizontalAlignment.Right;
		a178.Font = new Font(a425("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 14.25f);
		a178.Image = (Image)componentResourceManager.GetObject(a425("lŸɸͿѥէع\u073eࠨ\u094c੩\u0b62\u0c65\u0d64"));
		a178.Location = new Point(164, 114);
		a178.Name = a425("jŲɲͱѫխس\u0738");
		a178.Size = new Size(125, 48);
		a178.TabIndex = 113;
		a178.Tag = a425("G");
		a178.UseVisualStyleBackColor = true;
		a178.Click += a299;
		a100.Font = new Font(a425("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 14.25f);
		a100.Location = new Point(288, 114);
		a100.Name = a425("jŲɲͱѫխس\u0731");
		a100.Size = new Size(95, 48);
		a100.TabIndex = 113;
		a100.Tag = a425("G");
		a100.Text = a425("6Ĵȣ\u0356э");
		a100.UseVisualStyleBackColor = true;
		a100.Click += a320;
		a102.Font = new Font(a425("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 14.25f);
		a102.Location = new Point(288, 67);
		a102.Name = a425("eųɱͰѬլع");
		a102.Size = new Size(95, 48);
		a102.TabIndex = 113;
		a102.Tag = a425("G");
		a102.Text = a425("4ıȣ\u0356э");
		a102.UseVisualStyleBackColor = true;
		a102.Click += a314;
		a137.Enabled = false;
		a137.Font = new Font(a425("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 8.25f);
		a137.Location = new Point(584, 113);
		a137.Name = a425("jŲɲͱѫխس\u0739");
		a137.Size = new Size(50, 49);
		a137.TabIndex = 113;
		a137.Tag = a425("G");
		a137.Text = a425("B");
		a137.UseVisualStyleBackColor = true;
		a137.Click += a311;
		a138.Enabled = false;
		a138.Font = new Font(a425("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 8.25f);
		a138.Location = new Point(535, 113);
		a138.Name = a425("jŲɲͱѫխس\u0735");
		a138.Size = new Size(50, 49);
		a138.TabIndex = 113;
		a138.Tag = a425("G");
		a138.Text = a425("1");
		a138.UseVisualStyleBackColor = true;
		a138.Click += a311;
		a139.Enabled = false;
		a139.Font = new Font(a425("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 8.25f);
		a139.Location = new Point(486, 113);
		a139.Name = a425("eųɱͰѬլص");
		a139.Size = new Size(50, 49);
		a139.TabIndex = 113;
		a139.Tag = a425("G");
		a139.Text = a425("-");
		a139.UseVisualStyleBackColor = true;
		a139.Click += a311;
		a140.Enabled = false;
		a140.Font = new Font(a425("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 8.25f);
		a140.Location = new Point(584, 82);
		a140.Name = a425("jŲɲͱѫխس\u0736");
		a140.Size = new Size(50, 32);
		a140.TabIndex = 113;
		a140.Tag = a425("G");
		a140.Text = a425("8");
		a140.UseVisualStyleBackColor = true;
		a140.Click += a311;
		a141.Enabled = false;
		a141.Font = new Font(a425("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 8.25f);
		a141.Location = new Point(535, 82);
		a141.Name = a425("jŲɲͱѫխس\u0732");
		a141.Size = new Size(50, 32);
		a141.TabIndex = 113;
		a141.Tag = a425("G");
		a141.Text = a425("9");
		a141.UseVisualStyleBackColor = true;
		a141.Click += a311;
		a142.Enabled = false;
		a142.Font = new Font(a425("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 8.25f);
		a142.Location = new Point(486, 82);
		a142.Name = a425("eųɱͰѬլز");
		a142.Size = new Size(50, 32);
		a142.TabIndex = 113;
		a142.Tag = a425("G");
		a142.Text = a425("6");
		a142.UseVisualStyleBackColor = true;
		a142.Click += a311;
		a143.Enabled = false;
		a143.Font = new Font(a425("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 8.25f);
		a143.Location = new Point(584, 51);
		a143.Name = a425("jŲɲͱѫխس\u0737");
		a143.Size = new Size(50, 32);
		a143.TabIndex = 113;
		a143.Tag = a425("G");
		a143.Text = a425("7");
		a143.UseVisualStyleBackColor = true;
		a143.Click += a311;
		a144.Enabled = false;
		a144.Font = new Font(a425("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 8.25f);
		a144.Location = new Point(535, 51);
		a144.Name = a425("jŲɲͱѫխس\u0733");
		a144.Size = new Size(50, 32);
		a144.TabIndex = 113;
		a144.Tag = a425("G");
		a144.Text = a425("4");
		a144.UseVisualStyleBackColor = true;
		a144.Click += a311;
		a145.Enabled = false;
		a145.Font = new Font(a425("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 8.25f);
		a145.Location = new Point(486, 51);
		a145.Name = a425("eųɱͰѬլس");
		a145.Size = new Size(50, 32);
		a145.TabIndex = 113;
		a145.Tag = a425("G");
		a145.Text = a425("5");
		a145.UseVisualStyleBackColor = true;
		a145.Click += a311;
		a146.Enabled = false;
		a146.Font = new Font(a425("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 8.25f);
		a146.Location = new Point(584, 20);
		a146.Name = a425("jŲɲͱѫխس\u0734");
		a146.Size = new Size(50, 32);
		a146.TabIndex = 113;
		a146.Tag = a425("G");
		a146.Text = a425("2");
		a146.UseVisualStyleBackColor = true;
		a146.Click += a311;
		a147.Enabled = false;
		a147.Font = new Font(a425("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 8.25f);
		a147.Location = new Point(535, 20);
		a147.Name = a425("eųɱͰѬլش");
		a147.Size = new Size(50, 32);
		a147.TabIndex = 113;
		a147.Tag = a425("G");
		a147.Text = a425("3");
		a147.UseVisualStyleBackColor = true;
		a147.Click += a311;
		a148.Enabled = false;
		a148.Font = new Font(a425("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 8.25f);
		a148.Location = new Point(486, 20);
		a148.Name = a425("eųɱͰѬլذ");
		a148.Size = new Size(50, 32);
		a148.TabIndex = 113;
		a148.Tag = a425("G");
		a148.Text = a425("0");
		a148.UseVisualStyleBackColor = true;
		a148.Click += a365;
		a103.Font = new Font(a425("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a103.Location = new Point(382, 20);
		a103.Name = a425("eųɱͰѬլض");
		a103.Size = new Size(95, 48);
		a103.TabIndex = 113;
		a103.Tag = a425("G");
		a103.Text = a425("4Ĵȣ\u0356э");
		a103.UseVisualStyleBackColor = true;
		a103.Click += a311;
		a104.BackgroundImageLayout = ImageLayout.Zoom;
		a104.Font = new Font(a425("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a104.Location = new Point(288, 20);
		a104.Name = a425("eųɱͰѬլط");
		a104.Size = new Size(95, 48);
		a104.TabIndex = 113;
		a104.Tag = a425("G");
		a104.Text = a425("1ģɖ\u034d");
		a104.UseVisualStyleBackColor = true;
		a104.Click += a308;
		a105.Font = new Font(a425("RŤɬ\u036cѯՠ"), 10f);
		a105.Location = new Point(6, 90);
		a105.Name = a425("pťɾ\u034dѯզ٥ݲ\u086f\u094e੧୵\u0c73൫\u0e70\u0f76ၮᅤ");
		a105.Size = new Size(103, 71);
		a105.TabIndex = 113;
		a105.Text = a425("RŮɥ\u0364ѵծتݎ\u08feॵ\u0afa୫\u0c70\u0dff\u0e6eཤ");
		a105.UseVisualStyleBackColor = true;
		a105.Click += a305;
		a106.Font = new Font(a425("RŤɬ\u036cѯՠ"), 10f);
		a106.Location = new Point(6, 20);
		a106.Name = a425("nſɤ\u0359ѩյ٧ݜࡱ२੮\u0b64");
		a106.Size = new Size(103, 71);
		a106.TabIndex = 112;
		a106.Text = a425("ZŨɺ\u0366Ц՜۸ݨ\u086e।");
		a106.UseVisualStyleBackColor = true;
		a106.Click += a299;
		a165.BackColor = Color.FromArgb(128, 255, 128);
		a165.BorderStyle = BorderStyle.Fixed3D;
		a165.FlatStyle = FlatStyle.Flat;
		a165.ForeColor = Color.FromArgb(128, 255, 128);
		a165.Location = new Point(480, 21);
		a165.Name = a425("jŤɦ\u0366ѮԴ");
		a165.Size = new Size(3, 138);
		a165.TabIndex = 111;
		a92.BackColor = Color.FromArgb(128, 255, 128);
		a92.BorderStyle = BorderStyle.Fixed3D;
		a92.FlatStyle = FlatStyle.Flat;
		a92.ForeColor = Color.FromArgb(128, 255, 128);
		a92.Location = new Point(117, 23);
		a92.Name = a425("kŧɧ\u0361ѯԳع");
		a92.Size = new Size(3, 138);
		a92.TabIndex = 111;
		a93.AutoSize = true;
		a93.Location = new Point(125, 38);
		a93.Name = a425("jŤɦ\u0366ѮԲ");
		a93.Size = new Size(33, 13);
		a93.TabIndex = 64;
		a93.Text = a425("Qűɷ\u0363ѳ");
		a94.AutoSize = true;
		a94.Location = new Point(125, 79);
		a94.Name = a425("jŤɦ\u0366ѮԳ");
		a94.Size = new Size(38, 13);
		a94.TabIndex = 64;
		a94.Text = a425("DŤɯ\u036aѻդ");
		a76.Controls.Add(a77);
		a76.Controls.Add(a80);
		a76.Name = a425("^Ũɪ\u0357ѧբ١\u0744ࡷ९");
		a76.Size = new Size(928, 439);
		a76.Text = a425("LǶɧ\u0328ў\u05faٮݨࡦ९\u0a64");
		a77.BackgroundImageLayout = ImageLayout.Center;
		a77.ContextMenuStrip = a133;
		a77.Dock = DockStyle.Fill;
		a77.EmbeddedNavigator.Name = a425("");
		a77.Font = new Font(a425("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a77.Location = new Point(0, 210);
		a77.LookAndFeel.SkinName = a425("GżɻͳѯՖ٭ݨ\u086b९");
		a77.LookAndFeel.UseDefaultLookAndFeel = false;
		a77.MainView = a78;
		a77.Name = a425("kŹɣ\u036dыը٨ݱࡶ६੮ର");
		a77.RepositoryItems.AddRange(new RepositoryItem[2] { a79, a189 });
		a77.Size = new Size(928, 229);
		a77.TabIndex = 9;
		a77.ViewCollection.AddRange(new BaseView[1] { a78 });
		a133.Items.AddRange(new ToolStripItem[4] { a134, a135, a187, a192 });
		a133.Name = a425("rſɡͺѨմٿ\u0747\u086c०ੲ\u0b55\u0c71൶\u0e6a\u0f72\u1030");
		a133.Size = new Size(303, 156);
		a134.Enabled = false;
		a134.Image = (Image)componentResourceManager.GetObject(a425("xǢɳͿѾնٵݽࡃॹ\u0a7a\u0b78\u0c40൦\u0e63\u0f79ၿᅃቨ።ᑾᕃᙽ\u176dᡪ\u1928ᩌ᭩ᱢᵥṤ"));
		a134.ImageScaling = ToolStripItemImageScaling.None;
		a134.Name = a425("~Ǥɹ\u0375Ѱոٿݷࡅॿ\u0a60\u0b62\u0c5e൸\u0e79ལၹᅅቢ፨ᑰᕍᙷᝧᡬ");
		a134.Size = new Size(302, 38);
		a134.Text = a425("Oǻɨ\u0366ѡկٮݤ");
		a135.Image = (Image)componentResourceManager.GetObject(a425("iŰɴ\u0343ѹպٸ\u0740ࡦ\u0963\u0a79\u0b7f\u0c43൨\u0e62\u0f7e၃ᅽቭ፪ᐨᕌᙩᝢᡥᥤ"));
		a135.ImageScaling = ToolStripItemImageScaling.None;
		a135.Name = a425("gźɾ\u0345ѿՠ٢ݞࡸॹ\u0a63\u0b79\u0c45\u0d62\u0e68\u0f70၍ᅷቧ፬");
		a135.Size = new Size(302, 38);
		a135.Text = a425("ĸŷɲ\u0364Ѩԣهݵ");
		a135.Click += a287;
		a187.Image = a2268.a2286;
		a187.ImageScaling = ToolStripItemImageScaling.None;
		a187.Name = a425("VŁ\u02c4\u034bэՉ\u0658ߢࡳ॰\u0a7e୨\u0c70న\u0e67ར\u1074ᅸቖ፦ᑅᕿᙠᝢᡞ\u1978\u1a79᭣ᱹᵅṢὨ⁰⅍≷⍧⑬");
		a187.Size = new Size(302, 38);
		a187.Text = a425("Dų\u02f2ͽѿջرݗ\u08f3ॠ\u0a61୩౹\u0d63ษ\u0e38ၷᅲቤ፨ᐣᕇᙵ");
		a187.Click += a420;
		a192.Image = a2268.a2282;
		a192.ImageScaling = ToolStripItemImageScaling.None;
		a192.Name = a425("QŎɟ\u0340чՆ\u073d\u0748\u086dॺ੬୶౹ൡ\u0e73ཝၽဈቿቊᑠᕺᙠᝅ\u187fᥠ\u1a62᭞ᱸᵹṣό⁅Ⅲ≨⍰\u244d╷♧❬");
		a192.Size = new Size(302, 38);
		a192.Text = a425("yŌˏ\u034eъՌ\u0604ݤ\u08de\u094f\u0a4c\u0b7a౬൴\u0e72༻၃ᅰቡ፲ᑵᕰᜋ\u177aᠲᥜ\u1a75᭽ᱥᵨṶὢ\u202a⅍≭∘⑯\u245a♰❪⡰⤡");
		a192.Click += a423;
		a78.BorderStyle = BorderStyles.NoBorder;
		a78.Columns.AddRange(new GridColumn[11]
		{
			a126, a127, a128, a129, a130, a193, a131, a132, a188, a190,
			a191
		});
		a78.FocusRectStyle = DrawFocusRectStyle.RowFocus;
		a78.GridControl = a77;
		a78.Name = a425("nźɮ\u0362ѓխ٦ݵ࠰");
		a78.OptionsFilter.AllowFilterEditor = false;
		a78.OptionsView.ColumnAutoWidth = false;
		a78.OptionsView.ShowAutoFilterRow = true;
		a78.OptionsView.ShowGroupPanel = false;
		a126.Caption = a425("KŅ");
		a126.FieldName = a425("KŅ");
		a126.Name = a425("kŹɣ\u036dыը٪ݰࡩ७ਲ਼\u0b31");
		a126.OptionsColumn.AllowEdit = false;
		a127.Caption = a425("BŦ\u0330");
		a127.FieldName = a425("Fłɖ\u034bњՃم");
		a127.Name = a425("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ର");
		a127.OptionsColumn.AllowEdit = false;
		a127.Visible = true;
		a127.VisibleIndex = 1;
		a127.Width = 134;
		a128.Caption = a425("LŧɷͰУՌٮ");
		a128.FieldName = a425("Bŉɕ\u0352ыՋ\u064b\u0747\u0859");
		a128.Name = a425("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଳ");
		a128.OptionsColumn.AllowEdit = false;
		a128.Visible = true;
		a128.VisibleIndex = 2;
		a128.Width = 139;
		a129.Caption = a425("GŨɬ\u0369Ѥ");
		a129.FieldName = a425("GňɌ\u0349ф");
		a129.Name = a425("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଲ");
		a129.OptionsColumn.AllowEdit = false;
		a130.Caption = a425("Qťɱ\u036bѩ");
		a130.FieldName = a425("QŅɑ\u034bщ");
		a130.Name = a425("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଵ");
		a130.OptionsColumn.AllowEdit = false;
		a130.Visible = true;
		a130.VisibleIndex = 3;
		a130.Width = 104;
		a193.Caption = a425("DǾɯ");
		a193.DisplayFormat.FormatString = a425("`ŧɦ\u0365");
		a193.DisplayFormat.FormatType = FormatType.DateTime;
		a193.FieldName = a425("QŅɑ\u034bщ");
		a193.Name = a425("kŹɣ\u036dыը٪ݰࡩ७ਰ\u0b31");
		a193.OptionsColumn.AllowEdit = false;
		a193.Visible = true;
		a193.VisibleIndex = 4;
		a131.Caption = a425("Ò\u001c\u02fe\u036f");
		a131.FieldName = a425("Kńɗ\u034f");
		a131.Name = a425("kŹɣ\u036dыը٪ݰࡩ७ਲ਼\u0b34");
		a131.OptionsColumn.AllowEdit = false;
		a131.Visible = true;
		a131.VisibleIndex = 5;
		a131.Width = 85;
		a132.Caption = a425("AűɱͷѬ");
		a132.FieldName = a425("UŎɇ\u034cу\u0558قݐࡖ\u0956\u0a4f\u0b54");
		a132.Name = a425("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଷ");
		a132.OptionsColumn.AllowEdit = false;
		a132.Visible = true;
		a132.VisibleIndex = 6;
		a132.Width = 104;
		a188.AppearanceHeader.Options.UseTextOptions = true;
		a188.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
		a188.Caption = a425("Pŧ\u02e6");
		a188.ColumnEdit = a189;
		a188.FieldName = a425("PŇɂ");
		a188.Name = a425("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଶ");
		a188.Visible = true;
		a188.VisibleIndex = 0;
		a188.Width = 33;
		a189.AutoHeight = false;
		a189.Name = a425("jŲɦͺѧպ٦ݾࡢॶ\u0a47\u0b79౩൦\u0e49ཡ\u106dᅤቭፀᑠᕪᙶ\u1733");
		a189.ValueChecked = a425("D");
		a189.ValueUnchecked = a425("I");
		a190.Caption = a425("Vŧɴ\u0369Ѩկܖݡ\u0827\u094b\u0a60୶౨൧\u0e7b");
		a190.FieldName = a425("Kŀɖ\u0348ч՛");
		a190.Name = a425("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ହ");
		a190.OptionsColumn.AllowEdit = false;
		a190.Visible = true;
		a190.VisibleIndex = 7;
		a190.Width = 146;
		a191.Caption = a425("UŎɇ\u034cхՂ\u0654ݎࡁख़\u0a4b\u0b45");
		a191.FieldName = a425("UŎɇ\u034cхՂ\u0654ݎࡁख़\u0a4b\u0b45");
		a191.Name = a425("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ସ");
		a79.AutoHeight = false;
		a79.DisplayFormat.FormatString = a425("&Įȯ\u0328Уԩثܤ\u0825नਧଠడഢ");
		a79.DisplayFormat.FormatType = FormatType.Custom;
		a79.EditFormat.FormatString = a425("&Įȯ\u0328Уԩثܤ\u0825नਧଠడഢ");
		a79.EditFormat.FormatType = FormatType.Custom;
		a79.Name = a425("eųɥͻѠջ٥ݿࡽॷ\u0a44\u0b78౮൧\u0e5d\u0f6dၿᅲቀ፠ᑪᕶᘰ");
		a80.BackColor = Color.White;
		a80.Controls.Add(a185);
		a80.Controls.Add(a116);
		a80.Controls.Add(a113);
		a80.Controls.Add(a98);
		a80.Controls.Add(a95);
		a80.Controls.Add(a96);
		a80.Controls.Add(a97);
		a80.Controls.Add(a115);
		a80.Dock = DockStyle.Top;
		a80.Location = new Point(0, 0);
		a80.Name = a425("nźɨͳѵՆ٬ݺ࠳");
		a80.Size = new Size(928, 210);
		a80.TabIndex = 8;
		a80.TabStop = false;
		a80.Text = a425("aXɪ\u0360ѩկ٧ݳ");
		a185.AutoSize = true;
		a185.Font = new Font(a425("RŤɬ\u036cѯՠ"), 10f);
		a185.Location = new Point(6, 139);
		a185.Name = a425("dťɄ\u0364ѯժٻݤ");
		a185.Size = new Size(84, 17);
		a185.TabIndex = 117;
		a185.Text = a425("NŪɡ\u0360ѱբؼܥ࠴यਲ\u0b31");
		a116.AutoSize = true;
		a116.Font = new Font(a425("RŤɬ\u036cѯՠ"), 10f);
		a116.Location = new Point(6, 23);
		a116.Name = a425("jŤɦ\u0366ѮԵ");
		a116.Size = new Size(42, 17);
		a116.TabIndex = 117;
		a116.Text = a425("Ò\u001c\u02fe\u036f");
		a113.DropDownStyle = ComboBoxStyle.DropDownList;
		a113.Font = new Font(a425("RŤɬ\u036cѯՠ"), 9.75f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a113.FormattingEnabled = true;
		a113.Items.AddRange(new object[3]
		{
			a425("Vťɡ\u0363ѩ"),
			a425("Ò\u001cɮ\u0364"),
			a425("Dů\u035c\u0363Ѭ")
		});
		a113.Location = new Point(8, 44);
		a113.Name = a425("eŧɋ\u0364ѷկ");
		a113.Size = new Size(101, 24);
		a113.TabIndex = 116;
		a98.BorderStyle = BorderStyles.NoBorder;
		a98.DateTime = new DateTime(2015, 4, 24, 0, 0, 0, 0);
		a98.Location = new Point(111, 12);
		a98.LookAndFeel.SkinName = a425("GżɻͳѯՖ٭ݨ\u086b९");
		a98.LookAndFeel.UseDefaultLookAndFeel = false;
		a98.Name = a425("cŧɱ\u0361эգٷ");
		a98.ShowWeekNumbers = false;
		a98.Size = new Size(990, 165);
		a98.TabIndex = 115;
		a98.View = DateEditCalendarViewType.MonthInfo;
		a98.CustomDrawDayNumberCell += a405;
		a95.Font = new Font(a425("RŤɬ\u036cѯՠ"), 10f);
		a95.Location = new Point(7, 102);
		a95.Name = a425("nſɤ\u034eѽթفݪࡷॷ੧୳");
		a95.Size = new Size(103, 34);
		a95.TabIndex = 110;
		a95.Text = a425("Mǵɦ\u0327с׳ٷݷࡧॳ");
		a95.UseVisualStyleBackColor = true;
		a95.Click += a284;
		a96.Font = new Font(a425("RŤɬ\u036cѯՠ"), 10f);
		a96.Location = new Point(7, 69);
		a96.Name = a425("ižɧ\u034fѲը\u065cݱࡨ८\u0a64");
		a96.Size = new Size(103, 33);
		a96.TabIndex = 110;
		a96.Text = a425("NǴɩ\u0326ќ\u05f8٨ݮࡤ");
		a96.UseVisualStyleBackColor = true;
		a96.Click += a272;
		a97.AutoSize = true;
		a97.Location = new Point(10, 174);
		a97.Name = a425("jŤɦ\u0366ѮԹ");
		a97.Size = new Size(954, 26);
		a97.TabIndex = 65;
		a97.Text = componentResourceManager.GetString(a425("gūɫ\u036dѫԾثݐࡦॺ\u0a75"));
		a115.FormattingEnabled = true;
		a115.Items.AddRange(new object[3]
		{
			a425("Vťɡ\u0363ѩ"),
			a425("Ò\u001cɮ\u0364"),
			a425("Dů\u035c\u0363Ѭ")
		});
		a115.Location = new Point(7, 79);
		a115.Name = a425("kťɉ\u0362ѱխ\u064b\u0745");
		a115.Size = new Size(47, 21);
		a115.TabIndex = 116;
		a168.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		a168.AutoSize = true;
		a168.Location = new Point(238, 498);
		a168.Name = a425("eŪɊ\u0363Ѷշ٢ݥࡤ");
		a168.Size = new Size(0, 13);
		a168.TabIndex = 10;
		a167.Tick += a383;
		a181.Location = new Point(0, 493);
		a181.Name = a425("\u007fſɫͽѽմ\u0655ݱࡶ४ੲର");
		a181.Size = new Size(1175, 22);
		a181.TabIndex = 12;
		a181.Text = a425("\u007fſɫͽѽմ\u0655ݱࡶ४ੲର");
		Appearance.BackColor = Color.WhiteSmoke;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1175, 515);
		Controls.Add(a75);
		Controls.Add(a50);
		Controls.Add(a168);
		Controls.Add(a34);
		Controls.Add(a181);
		Icon = (Icon)componentResourceManager.GetObject(a425(".Žɠ\u036eѵԫ\u064dݠ\u086d९"));
		LookAndFeel.SkinName = a425("GżɻͳѯՖ٭ݨ\u086b९");
		Name = a425("AŴɨ\u0349Ѣիٯ");
		StartPosition = FormStartPosition.CenterScreen;
		Text = a425("Jŷɼ\u0375Ѥզ٬ݢ\u086eपਖ਼\u0b7a౨ൡ\u0e77ཥၮ\u1033ሡ");
		WindowState = FormWindowState.Maximized;
		Shown += a387;
		FormClosing += a257;
		a34.ResumeLayout(performLayout: false);
		a34.PerformLayout();
		((ISupportInitialize)a50).EndInit();
		((ISupportInitialize)a75).EndInit();
		a75.ResumeLayout(performLayout: false);
		a81.ResumeLayout(performLayout: false);
		((ISupportInitialize)a82).EndInit();
		a160.ResumeLayout(performLayout: false);
		((ISupportInitialize)a83).EndInit();
		((ISupportInitialize)a84).EndInit();
		((ISupportInitialize)a85).EndInit();
		((ISupportInitialize)a86).EndInit();
		((ISupportInitialize)a87.VistaTimeProperties).EndInit();
		((ISupportInitialize)a87).EndInit();
		((ISupportInitialize)a88).EndInit();
		((ISupportInitialize)a89).EndInit();
		((ISupportInitialize)a90).EndInit();
		((ISupportInitialize)a186).EndInit();
		a91.ResumeLayout(performLayout: false);
		a91.PerformLayout();
		((ISupportInitialize)a159).EndInit();
		a76.ResumeLayout(performLayout: false);
		((ISupportInitialize)a77).EndInit();
		a133.ResumeLayout(performLayout: false);
		((ISupportInitialize)a78).EndInit();
		((ISupportInitialize)a189).EndInit();
		((ISupportInitialize)a79).EndInit();
		a80.ResumeLayout(performLayout: false);
		a80.PerformLayout();
		((ISupportInitialize)a98).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public void a204()
	{
		a1344.a1307();
		a1344.a1271.CommandText = a425(">Ŏə\u0357џ՚\u064c\u0737ࡂ\u0954\u0a46\u0b5aౚറ๖ཝ၁ᅀሬ\u135fᑋᕛᙁᝏᡍ᥌\u1a57ᭊ᱖ᴡ");
		DataTable dataTable = a2147.a2105(a1344.a1271);
		for (int i = 0; i < dataTable.Rows.Count; i++)
		{
			a194.Add(Convert.ToDateTime(dataTable.Rows[i][a425("QŅɑ\u034bщ")]));
		}
	}

	public a426()
	{
		try
		{
			a203();
			a1344.a1337(Controls);
			Version version = Assembly.GetEntryAssembly().GetName().Version;
			Text = Text + a425("+ŜɬͺѴկټݫ\u086dसਡ") + version.ToString();
			a1984.a1891(this);
			a1344.a1334();
			if (a2172.a2157 != a425(""))
			{
				a198 = a2172.a2168();
				if (a198.a2182)
				{
					a227();
				}
			}
			else
			{
				a227();
			}
			new a684().ShowDialog();
			a1984.a1964(a425("uŠɨ\u0366ѡյ\u0600ݖ\u085aऱ\u0a53ଡ଼\u0c4f\u0d57\u0e38ད၄ᅚ\u1259ጳᑝᕖᙅᝁᠮᥚᩄ᭎᱘ᵌḨ\u1f46⁍⅑≍⍅\u243f┰"), a115, a113);
			a216();
			a218(a425(""));
			DateTime dateTime = Convert.ToDateTime(a2147.a2113(a425("CŊɂ\u0348я՟تݎࡍ\u0953\u0a42\u0b44\u0c50\u0d46ส༨"), 0));
			a98.DateTime = DateTime.Now.AddYears(1).Date;
			a98.DateTime = DateTime.Now.Date;
			string text = Text;
			Text = text + a425(".ĭȬ\u032bЪԩمݢࡴ८\u0a61\u0b79సഡ") + a1344.a1281 + a425("0įȮ\u032dЬԫ\u065aݬࡺॴ੩୫ౡ൯\u0e38༡") + a1344.a1284;
			if (!a1344.a1285)
			{
				a62.Visible = false;
				a110.Visible = false;
				a153.Visible = false;
				a46.Visible = false;
			}
			if (a1344.a1286)
			{
				a34.Enabled = false;
				a53.Visible = false;
				a56.Visible = false;
				a62.Visible = false;
				a110.Visible = false;
				a153.Visible = false;
				a46.Visible = false;
				a75.Visible = false;
			}
			a1344.a1335();
			if (a1344.a1277 == 0)
			{
				a76.PageVisible = false;
			}
			if (a1344.a1278 == 0)
			{
				a81.PageVisible = false;
			}
			a197 = a213();
			a168.Text = a197;
			if (!a1344.a1285)
			{
				a180.Visible = false;
			}
			a204();
			a98.TodayButton.Text = a425("Aǳɷͷѧճ");
			a98.TodayButton.Click += a408;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	[DllImport("kernel32.dll", EntryPoint = "CreateFile", SetLastError = true)]
	private static extern IntPtr a212(string a205, uint a206, uint a207, IntPtr a208, uint a209, uint a210, IntPtr a211);

	public string a213()
	{
		string text = a425("");
		string text2 = a425("bŵɣ\u036bѮո؋ݣ\u086dई\u0a61୴౪൩ฃ\u0f76\u1063ᅬቒ\u135bᑎᕏᙚ\u175dᡜᥐ\u1a56\u1b44\u1c35ᵃṛὗ⁃⅕∯⍝\u2459╍♙❞⡍⥉⩓⭃Ⱕⴸ⸾⼢〦") + DateTime.Now.ToString(a425("sŰɱ;ЫՈىܮࡦ॥")) + a425("5ıɑ\u0341ъԭى\u0745ࡎ\u094d\u0a49\u0b53\u0c43ഥ\u0e3a\u0f3eဢᄦ") + DateTime.Now.ToString(a425("sŰɱ;ЫՈىܮࡦ॥")) + a425("(ĮɌ\u0342яԪو\u0743ࡓ\u094f\u0a43ହత\u0d47ฦ");
		if (a2147.a2100(text2))
		{
			DataTable dataTable = a2147.a2105(text2);
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				text = text + a425("&ĥȤ\u0323Тԡ") + a215(Convert.ToInt32(dataTable.Rows[i][a425("KŅ")].ToString()));
			}
		}
		text = text.Replace('\r', ' ');
		text = text.Replace('\n', ' ');
		if (text.Length < 350)
		{
			text = text.PadRight(350, ' ');
		}
		return text;
	}

	public string a215(int a214)
	{
		string result = a425("");
		a1344.a1307();
		a1344.a1271.CommandText = a425("ožɶͼѻգ\u0616ݸࡱॠ\u0a61୰౷൪\u0e66ཨ\u106dᅯቯ፻ᐄᕪᙣ\u1776ᡷᥢ\u1a65᭤ᰀᵙṌὒ⁑℻≎⍛\u2454╚♓❆⡇⥒⩕⭔ⱘⵎ⹜⼭せㅃ㉏㍛㑍㔧㙏㝁㠹㥃㩋㭅");
		a1344.a1271.Parameters.Add(a425("KŅ"), SqlDbType.Int).Value = a214;
		DataTable dataTable = a2147.a2105(a1344.a1271);
		if (dataTable.Rows.Count > 0)
		{
			result = dataTable.Rows[0][a425("@ŉɘ\u0359шՏقݎࡀ\u0945\u0a47\u0b47\u0c53")].ToString();
			result = result + a425("#ĸȡ") + dataTable.Rows[0][a425("JŃɖ\u0357тՅل")].ToString();
		}
		return result;
	}

	public void a216()
	{
		int focusedRowHandle = a83.FocusedRowHandle;
		a1344.a1307();
		a1344.a1271.CommandText = a425("\u00a8ǔ\u02c3ωӁ׀\u06d6ޡ\u08d4रਮଢ଼\u0c49\u0d4b๚༭၉ᅙሿጱᑘᕓᘹ\u1738ᠣ\u1926ᨯᬩ\u1c25ᵖṂἺ\u202dÅ∣⌦\u2430╃☣✥⠳⤐⨇⬜Ⱈ\u2d7b⸜⼋〗ㄚ㉶㌞㐝㔀㘛㜝㠕㤝㩮㬚㰄㴎㸘㼌䁨䄎䈂䍸䐐䕲䙬䜊䠉䥬䩷䭱䱹䵩乥佰偼儞刚匕呠唂嘜坺塱好婺季屣嵣幯影怄慳戗挋摰敢晰杨桨楌機歜汈洷湑潘灊煃牉獚瑚畐癗睚硙祐穌筌籇終繓罌耤脧艍荐葈蕏虃蝏衉覲諃试貿趺躩込郘醠銾鎰钺闓隦韀飞馶骻鮦鲠鶮麧龬ꂷꆬꊳꎩ꒨ꖢꚬꞨꢭꧢ\uaaf9ꮄ곻귻꺎꾑낝놙닶돲뒍떆뚙랝뢕릂몋믪볬뷫뺝뾁삍솉싦쎑쓵역욛잔좋짳쫻쯰쳹췤컱쿬탴퇻틷폻퓽헾횏힖\ud8f9\ud988\uda8e\udbf9\udce4\uddee\udee4\udf89\ue08f\ue1ee\ue2f6\ue3f1\ue4e5\ue5ef\ue685\ue781\ue8e5\ue9d3\ueacd\uebd8\uecbc\uedbc\ueed1\uefcc\uf0d4\uf1db\uf2d7\uf3db\uf4dd\uf5de\uf6b5\uf7b1\uf8d5療響ﮤﲠﶫﻞﾸ¦Ǔ\u02d3ϑӅבڮߕࢱ\u0951ਵ\u0b3cమയล༪\u1037ᄹሤጴᐿᔺᘭ\u1733ᠱ\u1924ᨧ\u1b34\u1c29ᵇṊἤ\u202dℵ∭⌠\u243e╞♊✲⠥⤓⨛⬞Ⰸ\u2d7b⸛⼝】ㅷ㈐㌇㐛㔞㙲㜈㠅㤄㨂㬈㰁㴎㸕㼄䀍䄕䈍䌀䐞䕣䘕䜉䠅䥭䩻䬝䱵䵿万佭倉儙副占呿啿噷坼塵奰婣孨屾嵴幣彭态愇扠捷摫敮昂杭桯楘橁歍汝浉湛漹灌焦父獂瑜畖癀睔砰祖穛筆籀絎繇罌聗腊艃荗葛蕊虆蜼") + a1344.a1272 + a425("\fŪɤ\u036dЈլ٧ݷࡰ७੭୩\u0c65\u0d47\u0e3eདၕᅐ\u125fጹᐿᔲᘳ\u1732ᠴᥜᩀ᭕᱕ᵝḮ\u1f4f⁕Å≞⌸␦╎♂✥⡀⥆⩑⭂");
		DataTable dataSource = a2147.a2105(a1344.a1271);
		a82.DataSource = dataSource;
		a83.BestFitColumns();
		a136.Text = a425("4įȲ\u0331");
		try
		{
			a83.FocusedRowHandle = focusedRowHandle;
		}
		catch
		{
		}
	}

	public void a218(string a217)
	{
		int focusedRowHandle = a78.FocusedRowHandle;
		a185.Text = a425("NŪɡ\u0360ѱբؼܥ࠴यਲ\u0b31");
		a115.SelectedIndex = a113.SelectedIndex;
		a195.Clear();
		a1344.a1307();
		a1344.a1271.CommandText = a425("\u0080ǌ\u02dbϑәטێ\u07b9\u08cc\u09d8\u0ac6வದඣຢ\u0fb1ჃᇊውᎰᒫᗃᚭឥᣜᦶ᪨ᯜ᳁\u1dceệῌ\u20c5ℭ∵⌸␦┲☾❕⠵⤲⨤⬾ⰱ\u2d29⹏⽙〣ㄪ㈢㌨㐯㔿㙊㜨㠬㤮㩆㬣㰶㴬㸯㽁䀹䄊䈕䌑䐙䔖䘟䜆䠕䤒䨄䬞䰑䴉乲伆倘儊刜匈呬唂嘎坴堜奶婨嬜封崎帇弌怅慭扵捸摦敲晾朐栔楣樄欛汵海湡潾灩煮牪猁瑸甙瘄睢硩祵穲筫籫絫繧罹而腋般茳葞蕗處蝒衝褻詂謤谺赇蹓轃遙酇鈢鍙鐽锥陃靍頤饓騷鬫鱋鵄鹗齏ꁉꆻꋒꏝ꒳ꖼꚯꞷ\ua8c5꧟ꪥꮰ겸궶꺱꾥냐놠늩뎸뒢뗋뚬랻뢧릪뫆뮪벣붶뺬뿁삷솗슛쎏쒙엻욓잝죥즃쫧쯻첛추캇쾟킙톋틧폡풘헺훤힐\ud88d\ud98a\uda83\udb8e\udc9b\udd87\ude97\udf93\ue095\ue1f2\ue292\ue39d\ue4e5\ue5fe\ue6f7\ue7fc\ue8f3\ue9e8\ueaf2\uebe0\uece6\uede6\ueeff\uefe4\uf08d\uf187\uf2ed\uf3ec\uf4ff\uf5ee\uf68a\uf7fe\uf8e0梨\ufae8ﮅﳰﶒﺌ\ufff8åǒ\u02dbϖӃןۏߋ\u08cd\u09daફ\u0ba5\u0cb4\u0dc7\u0eda࿔პᆯኩᏔᓉᗅᛇ\u17ccᣅ\u19ce\u1ad5\u1ba2Ფ\u1dd4Ịῄ\u20ce⅟∪⍌\u2452┢☿✴⠽⤼⨩⬱Ⱑⴡ⸧⼼きㅞ㉎㌹㐤㔮㘤㝉㡏㤾㨣㬫㰩㴪㸱㽆䁀䄈䈖䌘䐒䕻䘎䝨䡶䤎䨓䬘䰑䴘不伕倅儝创匀呱啸噪圝堀夂娈孥屣崊帒引态慳戙挝摹敵晾朐栘楱橤歺汹洓湵潤灾煰牷獸瑧畧癯睤硭礇穲笔簈絨繫署聩腓艛荏萼蕏蘨蜹衏襟詓譇豑贳蹆輠逾酖鉛鍆鑀镎陇靌顗饊驃魗鱛鵊鹆鼼") + a1344.a1272 + a425("9řə\u0352еՀآ\u073c\u085a\u0951\u0a5d\u0b5a\u0c43\u0d43ใཏၑᄨቋፏᑎᕁᘣᜥᠤ") + a217 + a425("\u0019ĜȚ\u0378Ѷճ\u0616ݡࠅझ\u0a79\u0b78\u0c63൦\u0e62ཨၾᅴባ፭ᐕᕳᘔᜋᡭᥧᨂ\u1b6eᱲᵛṛ\u1f4f‼⅙≃⌹\u244c┦☸❜⡐⤳⩖⭔ⱃⵌ⸢⽙〽ㄥ㉞㍈㑚㕎㙎㜥㡀㥆㩑㭂");
		DataTable dataSource = a2147.a2105(a1344.a1271);
		a77.DataSource = dataSource;
		a78.BestFitColumns();
		try
		{
			a78.FocusedRowHandle = focusedRowHandle;
		}
		catch
		{
		}
	}

	public void a220(string a219)
	{
		if (!a1344.a1304())
		{
			MessageBox.Show(string.Concat(a425("AũɡͲѤժ\u0732ݬ\u0821"), DateTime.Now.DayOfWeek, a425("nĊʰ\u0325Ҷթ\u0611\u07bb\u082dऩਡମధൡนཞ၎ᅜቑፚᑀᕊᜉ\u1759ᤇ᥏\u1a1aᬓᱫ\u1dcdṛὃ⁋⅀≉⌋\u2453╈♘❆⡄⥌⩈⭎ⱇⵊ⸀⽶ヹㅴ㉲㌻㑗㕼㙪㝼㡳㥯㩸㭶㰲㵸㹢㽻䁧䅯䉭䍿䑫䔩䙯䝢䣡䥬䩪䭪䱸䴯")), a425("SżɥͱԳԻ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		decimal num = 0m;
		decimal num2 = 0m;
		if (a1344.a1285)
		{
			a1344.a1305();
			return;
		}
		if (a219 != a425(""))
		{
			a136.Text = a219;
		}
		if (a136.Text == a425(""))
		{
			return;
		}
		try
		{
			num = Convert.ToDecimal(a136.Text);
		}
		catch
		{
			MessageBox.Show(a425("xǜɴͲѸղپݹࡼॳ\u0a37\u0b42ౠൠ\u0e72འᄠᄰቄ፡ᑣᕸᙹᝥᡥ\u1928ᩂ᭢ᱬᵪṪὸ\u202f"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			a136.Focus();
			return;
		}
		if (num == 0m)
		{
			return;
		}
		if (Convert.ToDecimal(a1344.a1276) > num)
		{
			MessageBox.Show(a425("iǓɅ\u0341щՅ\u064f\u074aࡍ\u094cਆୱ\u0c51\u0d57ใནကᅒቷ፳ᑩᕶᙯ\u1777ᠸ\u1943\u1a63᭡ᱵᵡṶὰ⁾ℯ≊⏱╓◷♡✧⠨⥋⫺⭱Ɫⵦ\u2e6c⼡") + a1344.a1276 + a425("\nŽɤ\u0307тՀي܃ࡦ\u0940\u0a48\u0b7e\u0c3e\u0d44\u0ee0\u0f70\u1069ᅼታጷᑛᕼᙿᝧᡳᥣᨰ᭖ᳲᵦṠὮ\u2067Ⅼ≤⍮⑵╬♪❪⡸⤯"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			a136.Focus();
			return;
		}
		if (Convert.ToDecimal(a1344.a1275) < num)
		{
			MessageBox.Show(a425("kǍɛ\u0343ыՃى\u0748ࡏ\u0942ਈ୳\u0c53\u0d51ๅདဂᅬቁ፴ᑭᕴᙱᝮᡷ\u1939ᩌ᭢ᱢᵴṦί\u2073ⅿ∰⍖⓲╦♿❮⡡⤧⨨⭋⳺\u2d71\u2e62⽦ぬㄡ") + a1344.a1275 + a425("\tżɫ\u0306сՁ\u064d܂ࡥ\u0941\u0a77\u0b7fఽ൘\u0ee7ๅქᅳሷ\u135bᑼᕿᙧ\u1773ᡣ\u1930\u1a56\u1bf2ᱦᵠṮὧ\u206cⅤ≮⍵⑬╪♪❸⠯"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			a136.Focus();
			return;
		}
		a199.KARTNOHEX = a1344.a1303();
		if (a199.KARTNOHEX == a425("8ķȶ\u0335дԳز\u0731") || a199.KARTNOHEX == a425(">Ĵȶ\u0335дԳز\u0731"))
		{
			return;
		}
		a199.Getir();
		if (!a2147.a2100(a425("}Ũɠ\u036eѩս؈܍ࠆ\u0963੶୬౯\u0d01\u0e6bཞ၌ᅉቃ\u135cᑈᕌᙈ\u1737ᡁᥝᩑ\u1b41᱗ᴱṑὄ⁚⅄≊⌶\u243b┩♉❉⡂⤥⩍⭇ⰿ\u2d26") + a199.KARTGRUPID + a425("&")))
		{
			MessageBox.Show(a425("?ĒȀ\u0305Ձԁ\u064e\u0741ࡌठ\u0a0bଛజ\u0d47ม༗ထᄁሗፁᐴᔾᘰᙬᠱ\u1937ᨻ\u1b37\u1c35ᴶḻṤℋⅳ∫⌰\u2434┮♮✆⠭⤹⨾⭩Ⰿⴵ⸳⼧〱ㅣ㈑㌨㐬㕖㙐㝐㡕㡤㨔㬳㱴㷋㹂㽓䁑䅝䈒䍺䑑䕝䙚䜍䡧䥊䩓䨘䱜䴇乣低偖兂剌刐呎啻噿坳堼奐婻孫屬崷幑彧恡慱执捿摥支晉柱桢楨橯步汤浢湿潬灪煪牸猯"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		if (a199.BLOKE == 1)
		{
			MessageBox.Show(a425("vŝɉ\u034eЙպ\u065bݙ࡞\u0951ਓ୷\u0c55൙ใགྷ၄\u1073ህጊᑢᕉᙕ\u1752᠅\u196fᩂ᭛ᴐᵔḿὛ⁶Ⅾ≺⍴┨╶♳❷⡻⤴⩑⭾Ȿ\u2d7b\u2e6a⽷つㄬ㉀㍫㑥㕬㜶㝴㤴㥪㬲㭸㰯"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		if (!a199.KAYITLIMI)
		{
			if (MessageBox.Show(a425("`ŋɛ\u035cЇխلݝऒ\u0956\u0a4d\u0a11\u0c3f൚\u0e78ฃ\u1072ᅶሹፓᑶᕯᙱ\u1771ᡧ\u197f\u1a74᭻\u1c2f᰾Ṿὸ\u206eⅸ≤⍡⑴╯♫❭⡹⤬⨡"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.Cancel)
			{
				a1637 a2269 = new a1637();
				a2006 a2270 = new a2006(a2269, 20);
				a2270.ShowDialog();
			}
			return;
		}
		if (a199.KARTDURUM != a425("Q"))
		{
			MessageBox.Show(a425("\\Ũȼ\u0350ѻի٬ݶ࠶\u0945\u0a75ୡ\u0c73റ\u0e49\u0ff3ၥᅡቩ፲ᑯᕤ᙭\u177dᡵᥬ\u1a6a᭪ᱸᴯ"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (a2147.a2113(a425("~ũɧ\u036fѪռ؇ݠࡤॶ੨୮౨൭๚ཌ\u1056ᅙቁጺᑟᕊᙘ\u175bᠵᥟᩒ\u1b40᱅ᵏṈ\u1f5c⁘⅜∫⍝⑁╍♕❃⠥⥍⩇⬿Ⱖ") + a199.KARTGRUPID + a425("&")) != 1 && a199.MERKEZID != a1344.a1272)
		{
			MessageBox.Show(a425("wŁȓ\u0359ѐՂ\u065b\u070eࡪफ़ਫ਼\u0b48\u0c5c\u0d46ๆ༆\u1063ᅅቑፉᑍᐑᘿ\u1753ᡸ\u196e\u1a70᭿ᱣᵴṲὤⁱⅱ∳⍋⓭╻♣❫⡠⥩⨫⭓ⱨ\u2d78⼶⽪つㅩ㉢㍸㐯"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		a1173 a2271 = new a1173(a425(""));
		a2271.a1135.Text = num.ToString(a425("lĳ"));
		a2006 a2272 = new a2006(a2271, 50);
		a2272.ShowDialog();
		if (!a2271.a1140)
		{
			MessageBox.Show(a425("vśɀ\u0352ԮԤؽ\u0745\u08e7ॱ\u0a75\u0b7d౺൳\u0e35ฤᅌᅾቴ\u137dᑦᔮ\u173d\u177c\u187fᥫ\u1a65ᬨ᱂ᵢṬὨ\u2067Ⅻ∯"), a425("Oťɧ\u036dѠդ٢ݨࡡ७\u0a71୯\u0c64"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		num2 = a199.BAKIYE + num;
		a1344.a1307();
		if (a199.KARTNOHEX != a1344.a1303())
		{
			MessageBox.Show(a425("tǐɀ\u0346ьՅق܆ࡖࠕ\u0a51\u0b43\u0c52\u0c11\u0e71\u0f7aၼᄼቐ፻ᑫᕬᜦ᜶ᡚ\u197f\u1a66\u1b6bᱤᵳṺὪ\u206cⅢ∫⍫⑥╥♦❿⤴⥪⬲⭸Ⱟ"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		a1344.a1271.CommandText = a425("iūɾ\u0378Ѭղ\u0616ݾࡽॠ\u0a7b\u0b7d\u0c75ൽฎ\u0f7e\u1069ᅿሊ፫ᑩᕬᙯ\u177cᡡᤞ\u1a62᭣ᱡᵔṗὄ⁙℻≍⍑\u245d╅♓✵⡟⥒⩀⭅ⱞⵀ⹆⽈ごㄶ㉊㍂㑉㕕㙒㝋㡋㥋㩇㭙");
		a1344.a1271.Parameters.Add(a425("Dńɏ\u034aћՄ"), SqlDbType.Decimal).Value = num2;
		a1344.a1271.Parameters.Add(a425("Bŉɕ\u0352ыՋ\u064b\u0747\u0859"), SqlDbType.VarChar).Value = a199.KARTNOHEX;
		try
		{
			a1344.a1271.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			MessageBox.Show(a425("WǱɧ\u0367ѯդ٭ܧࡎ।\u0a70\u0b62\u0c71ర") + ex.Message, a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		a1344.a1307();
		a1344.a1271.CommandText = a425("\u0006ŬɪͰѧճٴ\u073fࡗ\u0953\u0a48\u0b54\u0c3aൕ๗ཐ၉ᅅቕፁᑓᔱᘸᝄᡇᥞᩅᭇᱏᵛṗ\u1f4e⁂℩≏⍂\u2450╕♎➰⢶⦸⪤⯗ⲱⶸ⺪⾣ォㆲ㊦㎦㒢㗝㚤㞮㢼㦤㪤㮸㲫㶨㺼㿋䂿䆰䊯䎯䒧䖬䚥䞀䢕䦈䪐䮗䲛䶗云侚僺凵功厒咀喅嚏垀墀妎媉宀岃嶖床徆悍憌抝掆擮斕暕柫棿槯檐毰泻淫滬濨烥燺狺珡瓳痺盹矰磬秬竧篢糳緬纈羋胿臰苯華蓧藬蛥蟀裓觘諎评賓距躸辻郃釆鋑鏁铛闕隹鞯飘駌髀鯞鳏鷚麠鿇ꃍꇌꋗꏊ\ua4ceꗄꛒ\ua720꠷ꤹ꩐ꬻ갱괸긪꼣뀸넺눼댶됪땝똰뜤렯뤿머무밭봻븽뼷쁊섢숡쌷쐦씠옴윚졶쥴쩰쬛찃촌츓켛퀓턘툑파퐙프혜휃\ud80f\ud903\uda05\udb06\udc66\udd69\ude08\udf0c\ue007\ue117\ue210\ue31c\ue40d\ue50f\ue603\ue77a\ue875\ue974\uea63\ueb79\uec7b\ued72\uee71\uef6e\uf073\uf119\uf274\uf367\uf467\uf565\uf671\uf77d\uf802省逸ﭪﱸﵽﹷｴiūɶ\u0362ѩըٿݝ\u085f\u0956\u0a55\u0b42\u0c5fവ๘ཎ၃ᅞቘፖᑟᕔᙏᝂᡋᥟᩓ\u1b42ᱎᴥṈὒ⁕⅀≖⍊⑆┨");
		a1344.a1271.Parameters.Add(a425("Aŀɛ\u034eъՀ\u0656ݜࡋ\u0945"), SqlDbType.Int).Value = a199.ID;
		a1344.a1271.Parameters.Add(a425("Bŉɕ\u0352ыՋ\u064b\u0747\u0859"), SqlDbType.VarChar).Value = a199.KARTNOHEX;
		a1344.a1271.Parameters.Add(a425("Bŉɕ\u0352њՃ\u0651ݗࡑ"), SqlDbType.Int).Value = a199.KARTGRUPID;
		a1344.a1271.Parameters.Add(a425("IŚɅ\u0341щՆ\u064fݖࡃ\u0952\u0a4a\u0b49\u0c45\u0d4d\u0e4bཌ"), SqlDbType.VarChar).Value = a425("X");
		a1344.a1271.Parameters.Add(a425("YŐɂ\u035bёՂق\u0748ࡏ\u0942\u0a41\u0b58\u0c44\u0d44๏ཊၛᅄ"), SqlDbType.Decimal).Value = a199.BAKIYE;
		a1344.a1271.Parameters.Add(a425("Qőɗ\u0343ѓ"), SqlDbType.Decimal).Value = num;
		a1344.a1271.Parameters.Add(a425("XœɃ\u0344ѐ՝ق\u0742\u0859\u094b\u0a42\u0b41ౘ\u0d44ไཏ၊ᅛቄ"), SqlDbType.Decimal).Value = num2;
		a1344.a1271.Parameters.Add(a425("WŘɇ\u0347яՄ\u064dݘࡋ\u0940\u0a56ଡ଼\u0c4b\u0d45"), SqlDbType.Int).Value = a1344.a1272;
		a1344.a1271.Parameters.Add(a425("SŖɁ\u0351ыՅ"), SqlDbType.Int).Value = a1344.a1283;
		try
		{
			a1344.a1271.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			MessageBox.Show(a425("\\Šɩ\u032dчժٳظࡼध\u0a4e\u0b64\u0c70\u0d62\u0e71ะ") + ex.Message, a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		a199.Getir();
		a107.Text = a199.BAKIYE.ToString(a425("lĳ"));
	}

	public void a221()
	{
		if (a1344.a1285)
		{
			a1344.a1305();
			return;
		}
		long num = 0L;
		decimal num2 = 0m;
		string text = a1344.a1303();
		if (MessageBox.Show(a425("ĕŔɗ\u0343эԀ\u065aݪࡰॹ\u0a70\u0b3aഩ൫\u0e63\u0f73\u1071ᅽጌ፻ᑿᕹᙵᝫᠭ᥉\u1a66᭣ᱧᵥṮή\u206cⅪ≪⍸\u242f"), a425("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
		{
			return;
		}
		string text2 = a425("");
		try
		{
			num = Convert.ToInt64(a83.GetFocusedRowCellValue(a425("KŅ")).ToString());
			num2 = Convert.ToDecimal(a83.GetFocusedRowCellValue(a425("Qőɗ\u0343ѓ")).ToString());
			text2 = a83.GetFocusedRowCellValue(a425("Bŉɕ\u0352ыՋ\u064b\u0747\u0859")).ToString();
			if (a83.GetFocusedRowCellValue(a425("CŒɊ\u0349хՍ\u064b\u074c")).ToString() == a425("LŔɗ\u0343э"))
			{
				MessageBox.Show(a425("Iųɥ\u0375ѡԮ\u073dݼࡿ५\u0a65ନ\u0c42\u0d62\u0e6cཨၮᅫ\u135e"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
		}
		catch
		{
			return;
		}
		if (text != text2)
		{
			MessageBox.Show(a425("\u001eƭȤ\u0329Ыԣ٬܀\u082b\u093b\u0a3c୧ఉമ\u0e31༺\u1037ᄢስፆᑟᔝᜌᝋᡎᥘᩔᬗᱳᵑṝὟ⁗⅒≕⍄␎╹♙❟⡋⥛⬙⭉Ⰶ\u2d7c⻘⽈ぎㅄ㉎㍲㑷㑂㘼㝴㡶㥽㩭㨈㱣㴵㹟㽲䁠䅥䌡䌯䑗䕨䙾䝧䡯䡖䩼䭮䱴䵬乪佪偸儯"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		a199.KARTNOHEX = text2;
		a199.Getir();
		if (a199.BAKIYE < num2)
		{
			MessageBox.Show(a425("ĈŇɂ\u0354јԓٵݔࡂ\u09c8\u0a4b\u0b46\u0c40ൎ\u0f75ཌ၅ᅂቂፌᐊᔃᙩᝀᡒᥫᨾ᭟ᱽᵰṳὠ⁽Ⅴ≿⌵⑀╦♦❰⡢⥫⩯⭣Ⱜⵏ\u2e6b⽡どㄧ㉂㏹㕛㗿㙩㜯"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		a1344.a1307();
		a1344.a1271.CommandText = a425("iūɾ\u0378Ѭղ\u0616ݾࡽॠ\u0a7b\u0b7d\u0c75ൽฎ\u0f7e\u1069ᅿሊ፫ᑩᕬᙯ\u177cᡡᤞ\u1a62᭣ᱡᵔṗὄ⁙℻≍⍑\u245d╅♓✵⡟⥒⩀⭅ⱞⵀ⹆⽈ごㄶ㉊㍂㑉㕕㙒㝋㡋㥋㩇㭙");
		a1344.a1271.Parameters.Add(a425("Dńɏ\u034aћՄ"), SqlDbType.Decimal).Value = a199.BAKIYE - num2;
		a1344.a1271.Parameters.Add(a425("Bŉɕ\u0352ыՋ\u064b\u0747\u0859"), SqlDbType.VarChar).Value = a199.KARTNOHEX;
		try
		{
			a1344.a1271.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			MessageBox.Show(a425("Eśɞ\u0348фԧ\u064eݤࡰ\u0962\u0a71ਰ") + ex.Message, a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		a1344.a1307();
		a1344.a1271.CommandText = a425("\u0006ŬɪͰѧճٴ\u073fࡗ\u0953\u0a48\u0b54\u0c3aൕ๗ཐ၉ᅅቕፁᑓᔱᘸᝄᡇᥞᩅᭇᱏᵛṗ\u1f4e⁂℩≏⍂\u2450╕♎➰⢶⦸⪤⯗ⲱⶸ⺪⾣ォㆲ㊦㎦㒢㗝㚤㞮㢼㦤㪤㮸㲫㶨㺼㿋䂿䆰䊯䎯䒧䖬䚥䞀䢕䦈䪐䮗䲛䶗云侚僺凵功厒咀喅嚏垀墀妎媉宀岃嶖床徆悍憌抝掆擮斕暕柫棿槯檐毰泻淫滬濨烥燺狺珡瓳痺盹矰磬秬竧篢糳緬纈羋胿臰苯華蓧藬蛥蟀裓觘諎评賓距躸辻郃釆鋑鏁铛闕隹鞯飘駌髀鯞鳏鷚麠鿇ꃍꇌꋗꏊ\ua4ceꗄꛒ\ua720꠷ꤹ꩐ꬻ갱괸긪꼣뀸넺눼댶됪땝똰뜤렯뤿머무밭봻븽뼷쁊섢숡쌷쐦씠옴윚졶쥴쩰쬛찃촌츓켛퀓턘툑파퐙프혜휃\ud80f\ud903\uda05\udb06\udc66\udd69\ude08\udf0c\ue007\ue117\ue210\ue31c\ue40d\ue50f\ue603\ue77a\ue875\ue974\uea63\ueb79\uec7b\ued72\uee71\uef6e\uf073\uf119\uf274\uf367\uf467\uf565\uf671\uf77d\uf802省逸ﭪﱸﵽﹷｴiūɶ\u0362ѩըٿݝ\u085f\u0956\u0a55\u0b42\u0c5fവ๘ཎ၃ᅞቘፖᑟᕔᙏᝂᡋᥟᩓ\u1b42ᱎᴥṈὒ⁕⅀≖⍊⑆┨");
		a1344.a1271.Parameters.Add(a425("Aŀɛ\u034eъՀ\u0656ݜࡋ\u0945"), SqlDbType.Int).Value = a199.ID;
		a1344.a1271.Parameters.Add(a425("Bŉɕ\u0352ыՋ\u064b\u0747\u0859"), SqlDbType.VarChar).Value = a199.KARTNOHEX;
		a1344.a1271.Parameters.Add(a425("Bŉɕ\u0352њՃ\u0651ݗࡑ"), SqlDbType.Int).Value = a199.KARTGRUPID;
		a1344.a1271.Parameters.Add(a425("IŚɅ\u0341щՆ\u064fݖࡃ\u0952\u0a4a\u0b49\u0c45\u0d4d\u0e4bཌ"), SqlDbType.VarChar).Value = a425("H");
		a1344.a1271.Parameters.Add(a425("YŐɂ\u035bёՂق\u0748ࡏ\u0942\u0a41\u0b58\u0c44\u0d44๏ཊၛᅄ"), SqlDbType.Decimal).Value = a199.BAKIYE;
		a1344.a1271.Parameters.Add(a425("Qőɗ\u0343ѓ"), SqlDbType.Decimal).Value = -num2;
		a1344.a1271.Parameters.Add(a425("XœɃ\u0344ѐ՝ق\u0742\u0859\u094b\u0a42\u0b41ౘ\u0d44ไཏ၊ᅛቄ"), SqlDbType.Decimal).Value = a199.BAKIYE - num2;
		a1344.a1271.Parameters.Add(a425("WŘɇ\u0347яՄ\u064dݘࡋ\u0940\u0a56ଡ଼\u0c4b\u0d45"), SqlDbType.Int).Value = a1344.a1272;
		a1344.a1271.Parameters.Add(a425("SŖɁ\u0351ыՅ"), SqlDbType.Int).Value = a1344.a1283;
		try
		{
			a1344.a1271.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			MessageBox.Show(a425("\\Šɩ\u032dчժٳظࡼध\u0a4e\u0b64\u0c70\u0d62\u0e71ะ") + ex.Message, a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		a199.Getir();
		a107.Text = a199.BAKIYE.ToString(a425("lĳ"));
		a216();
	}

	public void a222()
	{
		if (!a1344.a1304())
		{
			MessageBox.Show(string.Concat(a425("AũɡͲѤժ\u0732ݬ\u0821"), DateTime.Now.DayOfWeek, a425("nĊʰ\u0325Ҷթ\u0611\u07bb\u082dऩਡମధൡนཞ၎ᅜቑፚᑀᕊᜉ\u1759ᤇ᥏\u1a1aᬓᱫ\u1dcdṛὃ⁋⅀≉⌋\u2453╈♘❆⡄⥌⩈⭎ⱇⵊ⸀⽶ヹㅴ㉲㌻㑗㕼㙪㝼㡳㥯㩸㭶㰲㵸㹢㽻䁧䅯䉭䍿䑫䔩䙯䝢䣡䥬䩪䭪䱸䴯")), a425("SżɥͱԳԻ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		if (a1344.a1285)
		{
			a1344.a1305();
			return;
		}
		if (a98.SelectionStart.AddDays(1.0) < DateTime.Now)
		{
			MessageBox.Show(a425("ołˁ\u0348эѼ\u0602ݵࡁ७\u0a77୵౹\u0d3b\u0e5e\u0fefၶᇫችጵᑓᗯᙼᜱᡉ᧳\u1a65᭡ᱩᵲṯὤ\u206dⅽ≵⍬⑪╪♸✯"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		if (Convert.ToDecimal(a1344.a1274) > (decimal)a98.Selection.Count)
		{
			MessageBox.Show(a425("\u0019ǃɕ\u0351љՕ\u065fݚ\u085dड़ਖ୲\u0cc8൝ฒརၑᅖጟ\u135eᔝᔋᙧᝀᡆᥒᩋ᭐\u1c4aᴃṥ\u1fdd⁎ℿ≍⍼⑥\u242a♩☨⡶⥳⩷⭻ⰴⵗ\u2e73⽹ぱㄯ㉊㏱㕓㗷㙡㜧㠨㥋㫺㭱㱢㵦㹬㼡") + a1344.a1274 + a425("\bŠ\u02da\u034bЄՇهݏࠀज़\u0a7f୵౽\u0d3bใ\u0fe5\u1073ᅤታ\u137eᐴᕔᛮ\u177fᠰᥖ\u1af2᭦ᱠᵮṧὬ\u2064Ⅾ≵⍬⑪╪♸✯"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			a136.Focus();
			return;
		}
		if (Convert.ToDecimal(a1344.a1273) < (decimal)a98.Selection.Count)
		{
			MessageBox.Show(a425("\u001bƽȫ\u0353ћՓ\u0659ݘ\u085f\u0952ਘ୰\u0cca൛ดའၓᅈጁ\u135cᔟᔍᙡᝊᡁᥚᩁᭊ᱓ᵈḄὤ\u20de⅏∀⍌⑿╤✭❨⤫⥷⩼⭶ⱸⴵ⹐⽲ぺㅰ㈰㍖㓲㕦㙿㝮㡡㤧㨨㭋㳺㵱㹢㽦䁬䄡") + a1344.a1273 + a425("\aš\u02d9\u034aЃՆلݎ\u083fग़\u0a7c୴౺ഺ\u0e5d\u0fe4ᅈᇪቾጴᑔᗮᙿᜰᡖ᧲\u1a66᭠ᱮᵧṬὤ\u206eⅵ≬⍪⑪╸☯"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			a136.Focus();
			return;
		}
		if (a113.Text == a425(""))
		{
			MessageBox.Show(a425("|ǆɗ\u0318Ѯ\u05ca\u065eݘࡖ\u094b\u0a54\u0b52\u0c46\u0d42เཉ၀ᄊቀᏏᑎᕈᘅᝁᡍ\u1943\u1a5b\u1b00ᱽᵷṯἼ⁺ⅾ≼⍬\u2437◀✊⟨⡽⤲⩅⭱ⱡⰿ\u2e60⽠なㅧ㉨㍤㔶㕵㜴㝪㤲㥸㨯"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			a1693 a2269 = new a1693();
			a2006 a2270 = new a2006(a2269, 20);
			a2270.ShowDialog();
			a1984.a1964(a425("tţɩ\u0361Ѡն\u0601ݩ\u085bल\u0a52\u0b5b\u0c4eൔ\u0e39ཞ၅ᅙቘጴᑜᕕᙄ\u175eᠯᥙᩅᭉ᱙ᵏḩὉ⁌⅒≌⍂\u243e┳☡"), a115, a113);
			return;
		}
		a199.KARTNOHEX = a1344.a1303();
		if (a199.KARTNOHEX == a425("8ķȶ\u0335дԳز\u0731") || a199.KARTNOHEX == a425(">Ĵȶ\u0335дԳز\u0731"))
		{
			return;
		}
		a115.SelectedIndex = a113.SelectedIndex;
		int num = Convert.ToInt32(a115.Text);
		a199.Getir();
		if (!a2147.a2100(a425("}Ũɠ\u036eѩս؈܍ࠆ\u0963੶୬౯\u0d01\u0e6bཞ၌ᅉቃ\u135cᑈᕌᙈ\u1737ᡁᥝᩑ\u1b41᱗ᴱṑὄ⁚⅄≊⌶\u243b┩♉❉⡂⤥⩍⭇ⰿ\u2d26") + a199.KARTGRUPID + a425("&")))
		{
			MessageBox.Show(a425("?ĒȀ\u0305Ձԁ\u064e\u0741ࡌठ\u0a0bଛజ\u0d47ม༗ထᄁሗፁᐴᔾᘰᙬᠱ\u1937ᨻ\u1b37\u1c35ᴶḻṤℋⅳ∫⌰\u2434┮♮✆⠭⤹⨾⭩Ⰿⴵ⸳⼧〱ㅣ㈑㌨㐬㕖㙐㝐㡕㡤㨔㬳㱴㷋㹂㽓䁑䅝䈒䍺䑑䕝䙚䜍䡧䥊䩓䨘䱜䴇乣低偖兂剌刐呎啻噿坳堼奐婻孫屬崷幑彧恡慱执捿摥支晉柱桢楨橯步汤浢湿潬灪煪牸猯"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		if (a199.BLOKE == 1)
		{
			MessageBox.Show(a425("vŝɉ\u034eЙպ\u065bݙ࡞\u0951ਓ୷\u0c55൙ใགྷ၄\u1073ህጊᑢᕉᙕ\u1752᠅\u196fᩂ᭛ᴐᵔḿὛ⁶Ⅾ≺⍴┨╶♳❷⡻⤴⩑⭾Ȿ\u2d7b\u2e6a⽷つㄬ㉀㍫㑥㕬㜶㝴㤴㥪㬲㭸㰯"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		if (!a199.KAYITLIMI)
		{
			if (MessageBox.Show(a425("gŊɘ\u035dЈլهݜक\u0957\u0a4eਐ\u0c00൛\u0e7bขၵᅷሺፒᑹᕮᙲᝰᡠ\u197e\u1a77᭺\u1c30ᵦṽό\u2069ⅹ∪⍤②╴♯❫⡭⥹⨬⬡"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.Cancel)
			{
				a1637 a2271 = new a1637();
				a2006 a2272 = new a2006(a2271, 20);
				a2272.ShowDialog();
			}
			return;
		}
		if (a199.KARTDURUM != a425("F"))
		{
			MessageBox.Show(a425("_ũȻ\u0351Ѹժ٣ݷ࠵\u0953૯\u0b7cఱ\u0d49\u0ef3ཥၡᅩቲ፯ᑤᕭᙽ\u1775ᡬᥪ\u1a6a᭸\u1c2f"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (a2147.a2113(a425("~ũɧ\u036fѪռ؇ݠࡤॶ੨୮౨൭๚ཌ\u1056ᅙቁጺᑟᕊᙘ\u175bᠵᥟᩒ\u1b40᱅ᵏṈ\u1f5c⁘⅜∫⍝⑁╍♕❃⠥⥍⩇⬿Ⱖ") + a199.KARTGRUPID + a425("&")) != 1 && a199.MERKEZID != a1344.a1272)
		{
			MessageBox.Show(a425("wŁȓ\u0359ѐՂ\u065b\u070eࡪफ़ਫ਼\u0b48\u0c5c\u0d46ๆ༆\u1063ᅅቑፉᑍᐑᘿ\u1753ᡸ\u196e\u1a70᭿ᱣᵴṲὤⁱⅱ∳⍋⓭╻♣❫⡠⥩⨫⭓ⱨ\u2d78⼶⽪つㅩ㉢㍸㐯"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if ((a1344.a1283 == 3) | (a1344.a1283 == 10))
		{
			a1344.a1272 = a2147.a2113(a425("dųɹͱѰզ\u0611ݩࡺ॥\u0a61୩౦൯\u0e76ཥ\u1062ᅴቮ፡ᑹᕽᙨᝤᠿᥘᩏ᭓᱖ᴺṒὑ⁄⅟≙⍑⑁┲♆❘⡊⥜⩈⬬ⱀⵋ⹛⽜ぉㅉ㉍㍁㑛㔿㘦") + a199.KARTNOHEX + a425("&"));
		}
		if (!((a1344.a1272 == 1) | (a1344.a1272 == 2)))
		{
			MessageBox.Show(a425("nŝɟ\u035fњ՝\u0617ݳपढ़\u0a47\u0b5b\u0c5cഐ๙ཋဍလቇፋᑁᕁᙞᝇᡑᤄ\u1a65\u1b43\u1c4a\u1ddcṳὪ⁸Ⅿ≲⍴⑼┸♮⟪⡾⥸⩶⭿ⱴⴰ\u2e76⽯ぽㅭ㉩㍣㑥㕡㙵㝯㡶㥭㩭㭫㱻"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		decimal num2 = 0m;
		for (int i = 0; i < a98.Selection.Count; i++)
		{
			if (!a2147.a2100(a425("~ũɧ\u036fѪռ؇ݯࡡऄ\u0a65୰౮൭฿ཙ၈ᅒቄፃᑌᕓᙛ\u1753ᡘᥑᨳᭅ᱙ᵕṝὋ\u202dⅇ≂⍙⑀╄♂❔⡚⥍⩇⬿Ⱖ") + a199.ID + a425("6İɎ\u0340щԬـ\u074b\u085bड़\u0a49\u0b49\u0c4d\u0d41๛\u0f3fဦ") + a199.KARTNOHEX + a425("*ĬɊ\u0344эԨو\u0741ࡐ\u094a\u0a4a\u0b46\u0c3c") + num + a425(">Ŝɒ\u035fкՀ\u065dݚࡓफ़\u0a4b\u0b57\u0c47\u0d43ๅག\u1033ᄽሬፊᑄᕍᘨ\u1753ᡇᥗᩍᭋ᰿ᴦ") + a98.Selection[i].Date.ToString(a425("sŰɱ;ЫՈىܮࡦ॥")) + a425("&")))
			{
				num2 += a199.FIYAT;
			}
		}
		bool flag = false;
		if (a199.BAKIYE > 0m)
		{
			flag = true;
			DialogResult dialogResult = MessageBox.Show(a425("[Ůɼ\u0379Ьл\u06edݬࡺ८\u0a75୬౪൧\u0e67༡") + a199.BAKIYE.ToString(a425("lĳ")) + a425("\u0006űɨ\u0303ѠՀ\u064bݶࡧॸ\u0a3c୭౻൫\u0e34\u0f37ၔᅴቿ፺ᑫᕴᙴᝪᡠ\u192dᩈ\u1bf7ᵕ\u1df5Ṥὴ\u20faⅫ∤⍮⓾┾"), a425("TũɷͱУԸء"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
			switch (dialogResult)
			{
			case DialogResult.Cancel:
				MessageBox.Show(a425("Wźɨ\u036dиՎ\u06eaݾࡸॶ\u0a7f୴\u0c63൦ฮ\u0e3dၼᅿቫ፥ᐨᕂᙢᝬᡨᥧ\u1a6bᬯ"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			case DialogResult.No:
				flag = false;
				break;
			}
			if (dialogResult == DialogResult.Yes)
			{
				if (a199.BAKIYE <= num2)
				{
					num2 -= a199.BAKIYE;
					a199.BAKIYE = 0m;
				}
				if (a199.BAKIYE > num2)
				{
					a199.BAKIYE -= num2;
					num2 = 0m;
				}
			}
		}
		a1173 a2273 = new a1173(a113.Text);
		a2273.a1135.Text = num2.ToString(a425("lĳ"));
		a2006 a2274 = new a2006(a2273, 50);
		a2274.ShowDialog();
		if (!a2273.a1140)
		{
			MessageBox.Show(a425("Wźɨ\u036dиՎ\u06eaݾࡸॶ\u0a7f୴\u0c63൦ฮ\u0e3dၼᅿቫ፥ᐨᕂᙢᝬᡨᥧ\u1a6bᬯ"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		if (flag)
		{
			a1344.a1307();
			a1344.a1271.CommandText = a425("iūɾ\u0378Ѭղ\u0616ݾࡽॠ\u0a7b\u0b7d\u0c75ൽฎ\u0f7e\u1069ᅿሊ፫ᑩᕬᙯ\u177cᡡᤞ\u1a62᭣ᱡᵔṗὄ⁙℻≍⍑\u245d╅♓✵⡟⥒⩀⭅ⱞⵀ⹆⽈ごㄶ㉊㍂㑉㕕㙒㝋㡋㥋㩇㭙");
			a1344.a1271.Parameters.Add(a425("Dńɏ\u034aћՄ"), SqlDbType.Decimal).Value = a199.BAKIYE;
			a1344.a1271.Parameters.Add(a425("Bŉɕ\u0352ыՋ\u064b\u0747\u0859"), SqlDbType.VarChar).Value = a199.KARTNOHEX;
			a1344.a1271.ExecuteNonQuery();
		}
		List<string> list = new List<string>();
		for (int i = 0; i < a98.Selection.Count; i++)
		{
			if (!a2147.a2100(a425("\u007fŮɦ\u036cѫճ؆ݬࡠ\u0903\u0a64୳౯\u0d52\u0e3eཚ၉ᅕቅፀᑍᕜᙚᝐᡙᥖᨲᭆ᱘ᵊṜὈ\u202c⅀≃⍚⑁╋♃❗⡛⥊⩆⬼") + a199.ID + a425("0Ŏɀ\u0349ЬՀ\u064bݛ\u085c\u0949\u0a49\u0b4d\u0c41൛฿༦") + a199.KARTNOHEX + a425("*ĬɊ\u0344эԨو\u0741ࡐ\u094a\u0a4a\u0b46\u0c3c") + num + a425(">Ŝɒ\u035fкՀ\u065dݚࡓफ़\u0a4b\u0b57\u0c47\u0d43ๅག\u1033ᄽሬፊᑄᕍᘨ\u1753ᡇᥗᩍᭋ᰿ᴦ") + a98.Selection[i].Date.ToString(a425("sŰɱ;ЫՈىܮࡦ॥")) + a425("&")))
			{
				a1344.a1307();
				a1344.a1271.CommandText = a425("2Řɞ\u035cы՟\u0658ܫࡃ\u0947ੜ\u0b48ద\u0d42๑ཌྷၝᅘቕᎴᒲᖸᚱ\u17beᣚ᧑\u1ab3ᮾᲥᶼẸᾶ₠↮⊹⎫Ⓜ▦⚭➹⢾⦧⪧⮯ⲣⶽ⻈⾨ィㆳ㊴㎘㒌㖈㚌㞒㢞㧵㪑㮄㲚㶐㺙㾌䂆䆐䊂䎆䒆䖄䛠䞟䢋䦛䪁䮏䳪䶊亃侖傌冈劄厓哧嗸囱埾壱姦嫼寢峤巠廹徟惫懤拻揣擫无曩柴棧槬櫺毸泯淡溈濶烱燤狲珀瓗痙皰矚磉秒竑篓糗緛纸翊胗臜苕菂蓋藟蛇蟎裐觀諌议貦趥軒迂郎釔鋅錬鑖锽阷露頩餰騴鬲鰤鴪鸽鼷ꁞꄱꈻꌮꐼꔹ꘢Ꜥꠢ\ua92c\uaa30ꭋ갦괮긥꼱뀶넦눲댊됎디똘띷렚뤐먋묛밓봘븋뼇쀓섃숙쌇쐇액옌윟젋줛쨁쬏챪촅츋켄퀗턏툉퍻퐒핽홥흾\ud877\ud97c\uda73\udb68\udc72\udd60\ude66\udf66\ue07f\ue11d\ue270\ue376\ue47b\ue566\ue660\ue76e\ue867\ue96c\uea77\ueb6a\uec63\ued77\uee7b\uef6a\uf066\uf10d\uf260\uf34a\uf44d\uf558\uf64e\uf744\uf853諾勤ﭗﱗ﵆﹟ｚVŐɞ\u0323юՔى\u0746ࡏ\u0944\u0a4d\u0b55\u0c4d\u0d40\u0e5eཊ၆ᄨ");
				a1344.a1271.Parameters.Add(a425("Aŀɛ\u034eъՀ\u0656ݜࡋ\u0945"), SqlDbType.Int).Value = a199.ID;
				a1344.a1271.Parameters.Add(a425("Bŉɕ\u0352ыՋ\u064b\u0747\u0859"), SqlDbType.VarChar).Value = a199.KARTNOHEX;
				a1344.a1271.Parameters.Add(a425("Aňɚ\u0353с\u0557\u0651ݓࡋ\u0945"), SqlDbType.Int).Value = a199.KARTGRUPID;
				a1344.a1271.Parameters.Add(a425("EŘɆ\u034cх\u0558\u0652\u0744ࡖ\u094a\u0a4a\u0b48"), SqlDbType.DateTime).Value = DateTime.Now;
				a1344.a1271.Parameters.Add(a425("QŅɑ\u034bщ"), SqlDbType.DateTime).Value = a98.Selection[i].Date.ToString(a425("sŰɱ;ЫՈىܮࡦ॥"));
				list.Add(a98.Selection[i].Date.ToString(a425("nŭȧ\u034aыԪٽݺࡻॸ")));
				a1344.a1271.Parameters.Add(a425("Iłɑ\u034dыՅ"), SqlDbType.Int).Value = Convert.ToInt32(a115.Text);
				a1344.a1271.Parameters.Add(a425("RŏɄ\u034dьՙفݑࡑ\u0957\u0a4c"), SqlDbType.Int).Value = 0;
				a1344.a1271.Parameters.Add(a425("WŘɇ\u0347яՄ\u064dݘࡋ\u0940\u0a56ଡ଼\u0c4b\u0d45"), SqlDbType.Int).Value = a1344.a1272;
				a1344.a1271.Parameters.Add(a425("Rŕɀ\u0356ќՋم"), SqlDbType.Int).Value = a1344.a1283;
				a1344.a1271.Parameters.Add(a425("FŕɎ\u034dчՃ\u064f"), SqlDbType.Int).Value = 0;
				a1344.a1271.Parameters.Add(a425("UŎɇ\u034cхՂ\u0654ݎࡁख़\u0a4b\u0b45"), SqlDbType.Int).Value = a1344.a1272;
				try
				{
					a1344.a1271.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
		a1344.a1307();
		a1344.a1271.CommandText = a425("\u0006ŬɪͰѧճٴ\u073fࡗ\u0953\u0a48\u0b54\u0c3aൕ๗ཐ၉ᅅቕፁᑓᔱᘸᝄᡇᥞᩅᭇᱏᵛṗ\u1f4e⁂℩≏⍂\u2450╕♎➰⢶⦸⪤⯗ⲱⶸ⺪⾣ォㆲ㊦㎦㒢㗝㚤㞮㢼㦤㪤㮸㲫㶨㺼㿋䂿䆰䊯䎯䒧䖬䚥䞀䢕䦈䪐䮗䲛䶗云侚僺凵功厒咀喅嚏垀墀妎媉宀岃嶖床徆悍憌抝掆擮斕暕柫棿槯檐毰泻淫滬濨烥燺狺珡瓳痺盹矰磬秬竧篢糳緬纈羋胿臰苯華蓧藬蛥蟀裓觘諎评賓距躸辻郃釆鋑鏁铛闕隹鞯飘駌髀鯞鳏鷚麠鿇ꃍꇌꋗꏊ\ua4ceꗄꛒ\ua720꠷ꤹ꩐ꬻ갱괸긪꼣뀸넺눼댶됪땝똰뜤렯뤿머무밭봻븽뼷쁊섢숡쌷쐦씠옴윚졶쥴쩰쬛찃촌츓켛퀓턘툑파퐙프혜휃\ud80f\ud903\uda05\udb06\udc66\udd69\ude08\udf0c\ue007\ue117\ue210\ue31c\ue40d\ue50f\ue603\ue77a\ue875\ue974\uea63\ueb79\uec7b\ued72\uee71\uef6e\uf073\uf119\uf274\uf367\uf467\uf565\uf671\uf77d\uf802省逸ﭪﱸﵽﹷｴiūɶ\u0362ѩըٿݝ\u085f\u0956\u0a55\u0b42\u0c5fവ๘ཎ၃ᅞቘፖᑟᕔᙏᝂᡋᥟᩓ\u1b42ᱎᴥṈὒ⁕⅀≖⍊⑆┨");
		a1344.a1271.Parameters.Add(a425("Aŀɛ\u034eъՀ\u0656ݜࡋ\u0945"), SqlDbType.Int).Value = a199.ID;
		a1344.a1271.Parameters.Add(a425("Bŉɕ\u0352ыՋ\u064b\u0747\u0859"), SqlDbType.VarChar).Value = a199.KARTNOHEX;
		a1344.a1271.Parameters.Add(a425("Bŉɕ\u0352њՃ\u0651ݗࡑ"), SqlDbType.Int).Value = a199.KARTGRUPID;
		a1344.a1271.Parameters.Add(a425("IŚɅ\u0341щՆ\u064fݖࡃ\u0952\u0a4a\u0b49\u0c45\u0d4d\u0e4bཌ"), SqlDbType.VarChar).Value = a425("X");
		a1344.a1271.Parameters.Add(a425("YŐɂ\u035bёՂق\u0748ࡏ\u0942\u0a41\u0b58\u0c44\u0d44๏ཊၛᅄ"), SqlDbType.Decimal).Value = a199.BAKIYE;
		a1344.a1271.Parameters.Add(a425("Qőɗ\u0343ѓ"), SqlDbType.Decimal).Value = num2;
		a1344.a1271.Parameters.Add(a425("XœɃ\u0344ѐ՝ق\u0742\u0859\u094b\u0a42\u0b41ౘ\u0d44ไཏ၊ᅛቄ"), SqlDbType.Decimal).Value = 0;
		a1344.a1271.Parameters.Add(a425("WŘɇ\u0347яՄ\u064dݘࡋ\u0940\u0a56ଡ଼\u0c4b\u0d45"), SqlDbType.Int).Value = a1344.a1272;
		a1344.a1271.Parameters.Add(a425("SŖɁ\u0351ыՅ"), SqlDbType.Int).Value = a1344.a1283;
		try
		{
			a1344.a1271.ExecuteNonQuery();
			if (a2273.a1141)
			{
				string text = a425("IŚɅ\u0341щՆ\u064fݖࡎ\u094e\u0a55\u0b4c\u0c5b\u0d44๗ཏ");
				a200.Clear();
				DataTable dataTable = new DataTable(a425("IŚɅ\u0341щՆ\u064fݖࡎ\u094e\u0a55\u0b4c\u0c5b\u0d44๗ཏ"));
				dataTable.Columns.Add(a425("Mńɖ\u0357ьՎ"));
				dataTable.Columns.Add(a425("Fłɖ\u034bњՃم"));
				dataTable.Columns.Add(a425("PŀɌ\u034e"));
				dataTable.Columns.Add(a425("PŝɌ\u0359ёՅ\u0651\u074bࡉ"));
				dataTable.Columns.Add(a425("MŇɃ\u0347щՉ\u0659ݑࡑ\u0957\u0a43\u0b53"));
				object[] values = new object[5]
				{
					a199.KARTNOHEX,
					a199.ADSOYAD,
					a199.TCKIMLIK,
					DateTime.Now.ToString(a425("tūȡ\u0340сԤٳݰࡱॾਦ\u0b4d\u0c4cഹ\u0e6fཬ")),
					num2.ToString(a425("lĳ")) + a425("#Ŗɍ")
				};
				dataTable.Rows.Add(values);
				DataTable dataTable2 = new DataTable(a425("Mņə\u035dѕՂ\u064bݒࡊ\u0942ਖ਼\u0b40\u0c57\u0d40๓ཋၛᅋቃፓ"));
				dataTable2.Columns.Add(a425("Kńɗ\u034f"));
				dataTable2.Columns.Add(a425("QŅɑ\u034bщ"));
				for (int i = 0; i < list.Count; i++)
				{
					object[] values2 = new object[2]
					{
						a113.Text,
						list[i]
					};
					dataTable2.Rows.Add(values2);
				}
				a200.RegisterData(dataTable, a425("IŚɅ\u0341щՆ\u064fݖࡎ\u094e\u0a55\u0b4c\u0c5b\u0d44๗ཏ"));
				a200.RegisterData(dataTable2, a425("Mņə\u035dѕՂ\u064bݒࡊ\u0942ਖ਼\u0b40\u0c57\u0d40๓ཋၛᅋቃፓ"));
				string s = a425("");
				if (a2147.a2100(a425("tţɩ\u0361Ѡն\u0601ݩ\u085b\u093eਜ਼\u0b4e\u0c54\u0d57\u0e39ཛྷ\u105eᅌቔፍᑝᔲᙆ\u1758ᡊᥜᩈᬬᱏᵃṓὉ⁞ⅈ≄⍀⑊┿☦") + text + a425("&")))
				{
					s = a2147.a2113(a425("dųɹͱѰզ\u0611ݤࡠॾ\u0a0dଝఋ൹\u0e68\u0f7e\u1062ᅲቪ፷ᑷᕰᙨᝮᡘ\u193e\u1a5b᭎᱔ᵗḹ\u1f5c⁞⅌≔⍍\u245d┲♆❘⡊⥜⩈⬬ⱏⵃ⹓⽉ぞㅈ㉄㍀㑊㔿㘦") + text + a425("&"), 0);
				}
				a200.LoadFromString(s);
				(a200.Pages[0] as ReportPage).PaperHeight += list.Count * 3;
				if (a2273.a1143)
				{
					a200.Print();
				}
				else
				{
					a200.Show(modal: true);
				}
			}
			if (!a2273.a1142)
			{
				return;
			}
			IntPtr handle = a212(a1344.a1270, 1073741824u, 0u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
			if (handle.ToInt32() == -1)
			{
				Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
				return;
			}
			string text2 = a425("");
			text2 = a425("\aĆȅ\u036fѢհ٠ݭ࡞ॐ\u0a52\u0b5b\u0c57൏\u0e39ཕၒᅞቘፑᑇᔲᙓ\u1755ᡖ\u192e\u1a58\u1b42᱂ᵜṌ\u1f5a\u2054⅏≑⍁\u2450╋☋");
			text2 += a425(">Ľȼ\u033bкԹظ\u0737࠶\u094c\u0a51\u0b5e\u0c57൚๘ཎ၀ᅈሬፏᑅᕅᙝᝊᠦ\u1943ᩍ᭐\u1c4bᴋ");
			text2 += a425("\v");
			text2 = text2 + a425("PŴɦ\u032eўգٲݫ\u086dॡਧଦథതร༸အ") + a1344.a1296(a199.ADSOYAD) + a425("\v");
			text2 = text2 + a425("Eœȯ\u0340тԬثܪ\u0829नਧଦథതร༸အ") + a199.TCKIMLIK + a425("\v");
			text2 = text2 + a425("Xţɣ\u036bѠԬ\u065fݫࡻॡ੯୯థതร༸အ") + DateTime.Now.ToString(a425("tūȡ\u0340сԤٳݰࡱॾਦ\u0b4d\u0c4cഹ\u0e6fཬ")) + a425("\v");
			text2 = text2 + a425("ZűɽͺЭՂ٤ܪ\u0829नਧଦథതร༸အ") + a199.KARTNOHEX + a425("\"ċ");
			text2 = text2 + a425("Pżɦ\u0360Ѭբثݟࡪॺ\u0a62୲థതร༸အ") + num2.ToString(a425("lĳ")) + a425("$ŗɎ\u030b");
			text2 += a425("\v");
			text2 += a425("UŞɍ\u0359жԵش\u0733࠲ऱਰଯమഭฬ༫ဪᄩረጧᑒᕄᙖᝊᡊᤋ");
			for (int i = 0; i < list.Count; i++)
			{
				string text3 = text2;
				text2 = text3 + a1344.a1296(a113.Text) + a425(".ĭȬ\u032bЪԩبܧ\u0826थਤଣఢഡ") + list[i] + a425("\v");
			}
			text2 += a425("\v");
			text2 += a425("\v");
			text2 += a425("Yųɷ\u036fѴԸ\u0651ݿࡦॽ\u0a7d\u0b7bఱ\u0d43\u0e6eཥၡᅭቲ፣ᑧᕡᙽᜨᠫ\u192aᨭᬬᰋ");
			text2 += a425("\v");
			text2 += a425("\v");
			text2 += a425("\v");
			text2 += a425("\v");
			text2 += a425("\v");
			text2 += a425("\v");
			if (handle.ToInt32() == -1)
			{
				Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
				return;
			}
			FileStream fileStream = new FileStream(handle, FileAccess.ReadWrite);
			byte[] array = new byte[2048];
			array = Encoding.ASCII.GetBytes(text2);
			fileStream.Write(array, 0, array.Length);
			fileStream.Close();
		}
		catch (Exception ex)
		{
			MessageBox.Show(a425("\\Šɩ\u032dчժٳظࡼध\u0a4e\u0b64\u0c70\u0d62\u0e71ะ") + ex.Message, a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	public void a225(int a223, string a224)
	{
		if (a1344.a1285)
		{
			a1344.a1305();
			return;
		}
		string text = a1344.a1303();
		if (text != a224)
		{
			MessageBox.Show(a425("\rƼɋ\u0358јՒ؛ݱࡘ\u094a\u0a43ଖ౺ൟๆཋ၄ᅓቚፗᑌᔌ\u171b\u175aᡝ᥉ᩋᬆᱠᵀṊ\u1f4e⁄⅃≺⍵\u243d╛⛧❴⣥⥶⨷⭝ⱴⵦ\u2e67⸣み〡㈯㍗㑨㕾㙧㝯㥖㥼㩮㭴㱬㵪㹪㽸䀯"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		a199.KARTNOHEX = a224;
		a199.Getir();
		a1344.a1307();
		a1344.a1271.CommandText = a425("IĬȢ\u0325Щԥرܧࡁठ\u0a0c\u0b11ఓഉธ\u0f7aတᄖሃ፶ᐜᔒᙳ\u177a᠂ᤕᨃᬋᰎᴘṫἓ\u200c℅∂⌍␚─☖✐⠔⤍⨟⭸Ɐ\u2d73\u2e76⼚まㅭ㉹㍩㑬㕡㙸㝾㡴㥽㩪㬎㱺㵤㹮㽸䁬䄈䉳䍧䑷䕭䙫䜜䠜䥣䩐䭐䱋䵙义低倱兼剶卢呰唸噔块塅奔婎孚屈崤帢弣怩慉扉捂搥敍晇朿栦") + a223 + a425("\u001dĐȅ\u0307Жշٱݴࡻॿਐ\u0b7a౾൩\u0e6d\u0f7fၯᄉቯ፲ᑨᕺᙽ\u1776ᡩᥭ\u1a65᭒ᱛᴽṏ\u1f5e⁎ℹ≁⍒\u245b═♟❌⡖⥄⩂⭚ⱃⴰ⸿⼫そㅁ㉍㍕㑃㔥㙍㝇㠿㤦") + a223 + a425("nŨȔ\u0303Бդ\u0603\u0711ࠎऎ੪\u0b7d\u0c00\u0d0dป\u0f7fၷᅼሗ፳ᑹᕧᙶ\u1712᠑ᥲ\u1a6a᭩ᱤᵢḋἊ⁺Ⅽ≳⌆⑥╷♬❬⡴⥣⨢⬮ⰽⴼ\u2e5e⽔そㄸ㈷㍅㑐㕘㙖㝑㡅㤰㩏㭝㱂㵂㹞㽉䀩䅉䉔䌦䑖䕋䙍䝗䡂");
		DataTable dataTable = a2147.a2105(a1344.a1271);
		string text2 = dataTable.Rows[0][a425("Vŋɍ\u0357т")].ToString();
		if (text2 == a425("1"))
		{
			MessageBox.Show(a425("ąńɇ\u0353ѝԐ٨\u074b\u085f\u09cb\u0a4e\u0b41\u0c45\u0d4d\u0f78གྷ၈ᅁቇፋᐏᔀᙘ\u177b\u18faᥱ\u1a72ᩅ\u1c39ᵬṶὤ⁼ⅼ∳⍤⑴╩♮✮⡔⥩⩦⭯Ɫ\u2d28\u2e5e⽣にㅩ㉪㉝㐯"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		if (!(text2 == a425("0")))
		{
			return;
		}
		a1344.a1307();
		a1344.a1271.CommandText = a425("\u0006ŬɪͰѧճٴ\u073fࡗ\u0953\u0a48\u0b54\u0c3aൕ๗ཐ၉ᅅቕፁᑓᔱᘸᝄᡇᥞᩅᭇᱏᵛṗ\u1f4e⁂℩≏⍂\u2450╕♎➰⢶⦸⪤⯗ⲱⶸ⺪⾣ォㆲ㊦㎦㒢㗝㚤㞮㢼㦤㪤㮸㲫㶨㺼㿋䂿䆰䊯䎯䒧䖬䚥䞀䢕䦈䪐䮗䲛䶗云侚僺凵功厒咀喅嚏垀墀妎媉宀岃嶖床徆悍憌抝掆擮斕暕柫棿槯檐毰泻淫滬濨烥燺狺珡瓳痺盹矰磬秬竧篢糳緬纈羋胿臰苯華蓧藬蛥蟀裓觘諎评賓距躸辻郃釆鋑鏁铛闕隹鞯飘駌髀鯞鳏鷚麠鿇ꃍꇌꋗꏊ\ua4ceꗄꛒ\ua720꠷ꤹ꩐ꬻ갱괸긪꼣뀸넺눼댶됪땝똰뜤렯뤿머무밭봻븽뼷쁊섢숡쌷쐦씠옴윚졶쥴쩰쬛찃촌츓켛퀓턘툑파퐙프혜휃\ud80f\ud903\uda05\udb06\udc66\udd69\ude08\udf0c\ue007\ue117\ue210\ue31c\ue40d\ue50f\ue603\ue77a\ue875\ue974\uea63\ueb79\uec7b\ued72\uee71\uef6e\uf073\uf119\uf274\uf367\uf467\uf565\uf671\uf77d\uf802省逸ﭪﱸﵽﹷｴiūɶ\u0362ѩըٿݝ\u085f\u0956\u0a55\u0b42\u0c5fവ๘ཎ၃ᅞቘፖᑟᕔᙏᝂᡋᥟᩓ\u1b42ᱎᴥṈὒ⁕⅀≖⍊⑆┨");
		a1344.a1271.Parameters.Add(a425("Aŀɛ\u034eъՀ\u0656ݜࡋ\u0945"), SqlDbType.Int).Value = a199.ID;
		a1344.a1271.Parameters.Add(a425("Bŉɕ\u0352ыՋ\u064b\u0747\u0859"), SqlDbType.VarChar).Value = a199.KARTNOHEX;
		a1344.a1271.Parameters.Add(a425("Bŉɕ\u0352њՃ\u0651ݗࡑ"), SqlDbType.Int).Value = a199.KARTGRUPID;
		a1344.a1271.Parameters.Add(a425("IŚɅ\u0341щՆ\u064fݖࡃ\u0952\u0a4a\u0b49\u0c45\u0d4d\u0e4bཌ"), SqlDbType.VarChar).Value = a425("H");
		a1344.a1271.Parameters.Add(a425("YŐɂ\u035bёՂق\u0748ࡏ\u0942\u0a41\u0b58\u0c44\u0d44๏ཊၛᅄ"), SqlDbType.Decimal).Value = a199.BAKIYE;
		a1344.a1271.Parameters.Add(a425("Qőɗ\u0343ѓ"), SqlDbType.Decimal).Value = -a199.FIYAT;
		a1344.a1271.Parameters.Add(a425("XœɃ\u0344ѐ՝ق\u0742\u0859\u094b\u0a42\u0b41ౘ\u0d44ไཏ၊ᅛቄ"), SqlDbType.Decimal).Value = 0;
		a1344.a1271.Parameters.Add(a425("WŘɇ\u0347яՄ\u064dݘࡋ\u0940\u0a56ଡ଼\u0c4b\u0d45"), SqlDbType.Int).Value = a1344.a1272;
		a1344.a1271.Parameters.Add(a425("SŖɁ\u0351ыՅ"), SqlDbType.Int).Value = a1344.a1283;
		try
		{
			a1344.a1271.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			MessageBox.Show(a425("\\Šɩ\u032dчժٳظࡼध\u0a4e\u0b64\u0c70\u0d62\u0e71ะ") + ex.Message, a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	public void a226()
	{
		if (a1344.a1285)
		{
			a1344.a1305();
			return;
		}
		long num = 0L;
		string text = a1344.a1303();
		if (MessageBox.Show(a425("ĕŔɗ\u0343эԀ\u065aݪࡰॹ\u0a70\u0b3aഩ൫\u0e63\u0f73\u1071ᅽጌ፻ᑿᕹᙵᝫᠭ᥉\u1a66᭣ᱧᵥṮή\u206cⅪ≪⍸\u242f"), a425("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
		{
			return;
		}
		string text2 = a425("");
		try
		{
			num = Convert.ToInt64(a78.GetFocusedRowCellValue(a425("KŅ")).ToString());
			text2 = a78.GetFocusedRowCellValue(a425("Bŉɕ\u0352ыՋ\u064b\u0747\u0859")).ToString();
		}
		catch
		{
			return;
		}
		if (text != text2)
		{
			MessageBox.Show(a425("\rƼɋ\u0358јՒ؛ݱࡘ\u094a\u0a43ଖ౺ൟๆཋ၄ᅓቚፗᑌᔌ\u171b\u175aᡝ᥉ᩋᬆᱠᵀṊ\u1f4e⁄⅃≺⍵\u243d╛⛧❴⣥⥶⨷⭝ⱴⵦ\u2e67⸣み〡㈯㍗㑨㕾㙧㝯㥖㥼㩮㭴㱬㵪㹪㽸䀯"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		a199.KARTNOHEX = text2;
		a199.Getir();
		a1344.a1307();
		a1344.a1271.CommandText = a425("IĬȢ\u0325Щԥرܧࡁठ\u0a0c\u0b11ఓഉธ\u0f7aတᄖሃ፶ᐜᔒᙳ\u177a᠂ᤕᨃᬋᰎᴘṫἓ\u200c℅∂⌍␚─☖✐⠔⤍⨟⭸Ɐ\u2d73\u2e76⼚まㅭ㉹㍩㑬㕡㙸㝾㡴㥽㩪㬎㱺㵤㹮㽸䁬䄈䉳䍧䑷䕭䙫䜜䠜䥣䩐䭐䱋䵙义低倱兼剶卢呰唸噔块塅奔婎孚屈崤帢弣怩慉扉捂搥敍晇朿栦") + num + a425("\u001dĐȅ\u0307Жշٱݴࡻॿਐ\u0b7a౾൩\u0e6d\u0f7fၯᄉቯ፲ᑨᕺᙽ\u1776ᡩᥭ\u1a65᭒ᱛᴽṏ\u1f5e⁎ℹ≁⍒\u245b═♟❌⡖⥄⩂⭚ⱃⴰ⸿⼫そㅁ㉍㍕㑃㔥㙍㝇㠿㤦") + num + a425("nŨȔ\u0303Бդ\u0603\u0711ࠎऎ੪\u0b7d\u0c00\u0d0dป\u0f7fၷᅼሗ፳ᑹᕧᙶ\u1712᠑ᥲ\u1a6a᭩ᱤᵢḋἊ⁺Ⅽ≳⌆⑥╷♬❬⡴⥣⨢⬮ⰽⴼ\u2e5e⽔そㄸ㈷㍅㑐㕘㙖㝑㡅㤰㩏㭝㱂㵂㹞㽉䀩䅉䉔䌦䑖䕋䙍䝗䡂");
		DataTable dataTable = a2147.a2105(a1344.a1271);
		string text3 = dataTable.Rows[0][a425("Vŋɍ\u0357т")].ToString();
		if (text3 == a425("1"))
		{
			MessageBox.Show(a425("ąńɇ\u0353ѝԐ٨\u074b\u085f\u09cb\u0a4e\u0b41\u0c45\u0d4d\u0f78གྷ၈ᅁቇፋᐏᔀᙘ\u177b\u18faᥱ\u1a72ᩅ\u1c39ᵬṶὤ⁼ⅼ∳⍤⑴╩♮✮⡔⥩⩦⭯Ɫ\u2d28\u2e5e⽣にㅩ㉪㉝㐯"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		if (text3 == a425("0"))
		{
			a1344.a1307();
			a1344.a1271.CommandText = a425("\u0006ŬɪͰѧճٴ\u073fࡗ\u0953\u0a48\u0b54\u0c3aൕ๗ཐ၉ᅅቕፁᑓᔱᘸᝄᡇᥞᩅᭇᱏᵛṗ\u1f4e⁂℩≏⍂\u2450╕♎➰⢶⦸⪤⯗ⲱⶸ⺪⾣ォㆲ㊦㎦㒢㗝㚤㞮㢼㦤㪤㮸㲫㶨㺼㿋䂿䆰䊯䎯䒧䖬䚥䞀䢕䦈䪐䮗䲛䶗云侚僺凵功厒咀喅嚏垀墀妎媉宀岃嶖床徆悍憌抝掆擮斕暕柫棿槯檐毰泻淫滬濨烥燺狺珡瓳痺盹矰磬秬竧篢糳緬纈羋胿臰苯華蓧藬蛥蟀裓觘諎评賓距躸辻郃釆鋑鏁铛闕隹鞯飘駌髀鯞鳏鷚麠鿇ꃍꇌꋗꏊ\ua4ceꗄꛒ\ua720꠷ꤹ꩐ꬻ갱괸긪꼣뀸넺눼댶됪땝똰뜤렯뤿머무밭봻븽뼷쁊섢숡쌷쐦씠옴윚졶쥴쩰쬛찃촌츓켛퀓턘툑파퐙프혜휃\ud80f\ud903\uda05\udb06\udc66\udd69\ude08\udf0c\ue007\ue117\ue210\ue31c\ue40d\ue50f\ue603\ue77a\ue875\ue974\uea63\ueb79\uec7b\ued72\uee71\uef6e\uf073\uf119\uf274\uf367\uf467\uf565\uf671\uf77d\uf802省逸ﭪﱸﵽﹷｴiūɶ\u0362ѩըٿݝ\u085f\u0956\u0a55\u0b42\u0c5fവ๘ཎ၃ᅞቘፖᑟᕔᙏᝂᡋᥟᩓ\u1b42ᱎᴥṈὒ⁕⅀≖⍊⑆┨");
			a1344.a1271.Parameters.Add(a425("Aŀɛ\u034eъՀ\u0656ݜࡋ\u0945"), SqlDbType.Int).Value = a199.ID;
			a1344.a1271.Parameters.Add(a425("Bŉɕ\u0352ыՋ\u064b\u0747\u0859"), SqlDbType.VarChar).Value = a199.KARTNOHEX;
			a1344.a1271.Parameters.Add(a425("Bŉɕ\u0352њՃ\u0651ݗࡑ"), SqlDbType.Int).Value = a199.KARTGRUPID;
			a1344.a1271.Parameters.Add(a425("IŚɅ\u0341щՆ\u064fݖࡃ\u0952\u0a4a\u0b49\u0c45\u0d4d\u0e4bཌ"), SqlDbType.VarChar).Value = a425("H");
			a1344.a1271.Parameters.Add(a425("YŐɂ\u035bёՂق\u0748ࡏ\u0942\u0a41\u0b58\u0c44\u0d44๏ཊၛᅄ"), SqlDbType.Decimal).Value = a199.BAKIYE;
			a1344.a1271.Parameters.Add(a425("Qőɗ\u0343ѓ"), SqlDbType.Decimal).Value = -a199.FIYAT;
			a1344.a1271.Parameters.Add(a425("XœɃ\u0344ѐ՝ق\u0742\u0859\u094b\u0a42\u0b41ౘ\u0d44ไཏ၊ᅛቄ"), SqlDbType.Decimal).Value = 0;
			a1344.a1271.Parameters.Add(a425("WŘɇ\u0347яՄ\u064dݘࡋ\u0940\u0a56ଡ଼\u0c4b\u0d45"), SqlDbType.Int).Value = a1344.a1272;
			a1344.a1271.Parameters.Add(a425("SŖɁ\u0351ыՅ"), SqlDbType.Int).Value = a1344.a1283;
			try
			{
				a1344.a1271.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(a425("\\Šɩ\u032dчժٳظࡼध\u0a4e\u0b64\u0c70\u0d62\u0e71ะ") + ex.Message, a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			MessageBox.Show(a425("XųɨȡѻԮ\u073dݼࡿ५\u0a65ନ\u0c42\u0d62\u0e6cཨ\u1067ᅫሯ"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}

	public void a227()
	{
		MessageBox.Show(a425("JžɨͰиգٷݷࡵॽଣ\u0b7f\u0c71യ\u0e6cཬᄓᅧቫ፧ᔹᕫᙧᝨᡥᥧᬳᬯ") + a198.a2181, a425("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
		new a1740().ShowDialog();
		a1344.a1334();
		a198 = a2172.a2168();
		if (a198.a2182)
		{
			MessageBox.Show(a425("Wŵ\u030c;Ѱվٻؿ\u082dय़੪ਕ\u0c65൩\u0e69ཧ\u1068ᅥቧሳᐯ") + a198.a2181, a425("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Environment.Exit(0);
		}
	}

	public void a228()
	{
		a613 a2269 = new a613();
		a2006 a2270 = new a2006(a2269, 20);
		a2270.ShowDialog();
	}

	public void a229()
	{
		a1126 a2269 = new a1126();
		a2006 a2270 = new a2006(a2269, 20);
		a2270.ShowDialog();
	}

	public void a230()
	{
		if (!a1344.a1285)
		{
			MessageBox.Show(a425("\0īȻ\u033cЫԧطٵࡣअਲ਼ଵ\u0c4fഞ\u0e7fཝ၁ᅖገጘᑵᕚᙚ\u175fᡖᤒ\u1a74᭔\u1c4aᵌṄὀ⁆⅏≂⌈\u244e◁♌❊⠃⥻⫗⭎ⱺ\u2d6a\u2e74⽿ひㄺ㉖㍴㑶㕤㙴㝿㠳㥕㩸㭢㱦㱑㸭㽕䁪䅺䉤䍩䑫䐷䙶䘵䡭䠳䩻"), a425("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		a528 a2269 = new a528();
		a2006 a2270 = new a2006(a2269, 20);
		a2270.ShowDialog();
	}

	public void a231()
	{
		if (!a1344.a1285)
		{
			MessageBox.Show(a425("\bģȳ\u0334Пճ\u0658ݎࡐय़\u0a43\u0b54\u0c52\u0d44\u0e5cཚၚᅜሑ፴ᑊᐱᙄᙳᡂ᥇ᩀᬈᱎ\u1dc1ṌὊ\u2003ⅻ⋗⍎⑺╪♴❿⡲⤺⩖\u2b74ⱶⵤ\u2e74⽿〳ㅕ㉸㍢㑦㑑㘭㝕㡪㥺㩤㭩㱫㰷㹶㸵䁭䀳䉻"), a425("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		a1440 a2269 = new a1440();
		a2006 a2270 = new a2006(a2269, 20);
		a2270.ShowDialog();
	}

	public void a232()
	{
		a1740 a2269 = new a1740();
		a2006 a2270 = new a2006(a2269, 20);
		a2270.ShowDialog();
	}

	public void a233()
	{
		a821 a2269 = new a821();
		a2006 a2270 = new a2006(a2269, 20);
		a2270.ShowDialog();
	}

	public void a234()
	{
		a2086 a2269 = new a2086();
		a2006 a2270 = new a2006(a2269, 20);
		a2270.ShowDialog();
	}

	public void a235()
	{
		a1637 a2269 = new a1637();
		a2006 a2270 = new a2006(a2269, 20);
		a2270.ShowDialog();
	}

	public void a236()
	{
		a1071 a2269 = new a1071();
		a2006 a2270 = new a2006(a2269, 20);
		a2270.ShowDialog();
	}

	public void a237()
	{
		a1508 a2269 = new a1508();
		a2006 a2270 = new a2006(a2269, 20);
		a2270.ShowDialog();
	}

	public void a238()
	{
		a1693 a2269 = new a1693();
		a2006 a2270 = new a2006(a2269, 20);
		a2270.ShowDialog();
		a1984.a1964(a425("tţɩ\u0361Ѡն\u0601ݩ\u085bल\u0a52\u0b5b\u0c4eൔ\u0e39ཞ၅ᅙቘጴᑜᕕᙄ\u175eᠯᥙᩅᭉ᱙ᵏḩὉ⁌⅒≌⍂\u243e┳☡"), a115, a113);
	}

	public void a239()
	{
		a1023 a2269 = new a1023();
		a2006 a2270 = new a2006(a2269, 20);
		a2270.ShowDialog();
	}

	public void a240()
	{
		a1266 a2269 = new a1266();
		a2269.Show();
	}

	public void a241()
	{
		a940 a2269 = new a940();
		a2269.Show();
	}

	public void a242()
	{
		a1832 a2269 = new a1832(0, DateTime.Now, DateTime.Now);
		a2269.Show();
	}

	public void a243()
	{
		a764 a2269 = new a764();
		a2269.Show();
	}

	public void a244()
	{
		a2249 a2269 = new a2249();
		a2006 a2270 = new a2006(a2269, 50);
		a2270.ShowDialog();
	}

	public void a245()
	{
		a175.Text = a425("");
		a174.Text = a425("");
		a177.Text = a425("");
		a176.Text = a425("");
		a107.Text = a425("4įȲ\u0331");
	}

	private void a248(object a246, NavBarLinkEventArgs a247)
	{
		a228();
	}

	private void a251(object a249, NavBarLinkEventArgs a250)
	{
		a233();
	}

	private void a254(object a252, NavBarLinkEventArgs a253)
	{
		Close();
	}

	private void a257(object a255, FormClosingEventArgs a256)
	{
		if (!a201 && MessageBox.Show(a425("{ŘɆ\u034fѕՇو\u0740ࡂ\u094c\u0a01\u0bc7മ൵\u0e70\u0f7dၰᄺተ፫ᑣᕳᙱ\u177dᤌ\u197b\u1a7f᭹ᱵᵫḭὩ\u2066Ⅳ≧⍥⑮╵♬❪⡪⥸⨯"), a425("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
		{
			a256.Cancel = true;
		}
	}

	private void a260(object a258, NavBarLinkEventArgs a259)
	{
		a235();
	}

	private void a263(object a261, NavBarLinkEventArgs a262)
	{
		a237();
	}

	private void a266(object a264, NavBarLinkEventArgs a265)
	{
		a232();
	}

	private void a269(object a267, NavBarLinkEventArgs a268)
	{
		a234();
	}

	private void a272(object a270, EventArgs a271)
	{
		a222();
		a218(a425(""));
	}

	private void a275(object a273, NavBarLinkEventArgs a274)
	{
		a238();
	}

	private void a278(object a276, NavBarLinkEventArgs a277)
	{
		a240();
	}

	private void a281(object a279, NavBarLinkEventArgs a280)
	{
		a242();
	}

	private void a284(object a282, EventArgs a283)
	{
		a185.Text = a425("NŪɡ\u0360ѱբؼܥ࠴यਲ\u0b31");
		string text = a1344.a1303();
		if (text == a425("8ķȶ\u0335дԳز\u0731"))
		{
			text = a425("");
		}
		if (text == a425(">Ĵȶ\u0335дԳز\u0731"))
		{
			text = a425("");
		}
		a218(text);
		a408(new object(), new EventArgs());
		a98.Focus();
	}

	private void a287(object a285, EventArgs a286)
	{
		a226();
		string text = a1344.a1303();
		if (text == a425("8ķȶ\u0335дԳز\u0731"))
		{
			text = a425("");
		}
		if (text == a425(">Ĵȶ\u0335дԳز\u0731"))
		{
			text = a425("");
		}
		a218(text);
	}

	private void a290(object a288, NavBarLinkEventArgs a289)
	{
		a75.SelectedTabPage = a81;
	}

	private void a293(object a291, NavBarLinkEventArgs a292)
	{
		a239();
	}

	private void a296(object a294, NavBarLinkEventArgs a295)
	{
		a75.SelectedTabPage = a76;
	}

	private void a299(object a297, EventArgs a298)
	{
		a220(a425(""));
		a216();
	}

	private void a302(object a300, KeyPressEventArgs a301)
	{
		a301.Handled = !char.IsDigit(a301.KeyChar) && !char.IsControl(a301.KeyChar) && a301.KeyChar != ',';
	}

	private void a305(object a303, EventArgs a304)
	{
		a199.KARTNOHEX = a1344.a1303();
		if (a199.KARTNOHEX == a425("8ķȶ\u0335дԳز\u0731") || a199.KARTNOHEX == a425(">Ĵȶ\u0335дԳز\u0731"))
		{
			a245();
			return;
		}
		a199.Getir();
		if (!a199.KAYITLIMI)
		{
			if (MessageBox.Show(a425("`ŋɛ\u035cЇխلݝऒ\u0956\u0a4d\u0a11\u0c3f൚\u0e78ฃ\u1072ᅶሹፓᑶᕯᙱ\u1771ᡧ\u197f\u1a74᭻\u1c2fᵧṾὸ\u206eⅸ≤⍡⑴╯♫❭⡹⤬⨡"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.Cancel)
			{
				a1637 a2269 = new a1637();
				a2006 a2270 = new a2006(a2269, 20);
				a2270.ShowDialog();
			}
		}
		else if (a199.KARTDURUM != a425("Q"))
		{
			MessageBox.Show(a425("kŝȇ\u036dфՖ\u0657\u0613ࡏ\u0900\u0a5d\u0b7f\u0c76൵\u0e62\u0f7f\u106aᅱቹ\u137fᐵᕓᛥᝠᣭ\u197e\u1a7b\u1bf2ᱡᵩṲὯ\u2064Ⅽ≴⍵⑬╪♪❸⠯"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		else
		{
			a175.Text = a199.KARTNOHEX;
			a174.Text = a199.TCKIMLIK;
			a177.Text = a199.ADSOYAD;
			string text = a2147.a2113(a425("gŶɾʹѳջ؎ݹࡣॻਊଘఈ൬\u0e67\u0f77ၰᅼብ፳ᑵᕏᙁ\u175cᡘᥒᨺ᭟\u1c4aᵘṛἵ\u205f⅒≀⍅\u244f╈♜❘⡜⤫⩝⭁ⱍⵕ⹃⼥きㅇ㈿㌦") + a199.KARTGRUPID + a425("&"), 0);
			a176.Text = text;
			a107.Text = a199.BAKIYE.ToString(a425("lĳ"));
			a216();
		}
	}

	private void a308(object a306, EventArgs a307)
	{
		a220(a425("4"));
		a216();
	}

	private void a311(object a309, EventArgs a310)
	{
		a220(a425("3ı"));
		a216();
	}

	private void a314(object a312, EventArgs a313)
	{
		a220(a425("3Ĵ"));
		a216();
	}

	private void a317(object a315, EventArgs a316)
	{
		a220(a425("0ı"));
		a216();
	}

	private void a320(object a318, EventArgs a319)
	{
		a220(a425("1ı"));
		a216();
	}

	private void a323(object a321, EventArgs a322)
	{
		a220(a425("7ı"));
		a216();
	}

	private void a326(object a324, EventArgs a325)
	{
		a235();
	}

	private void a329(object a327, EventArgs a328)
	{
		Close();
	}

	private void a332(object a330, EventArgs a331)
	{
		a75.SelectedTabPage = a81;
	}

	private void a335(object a333, EventArgs a334)
	{
		a75.SelectedTabPage = a76;
	}

	private void a338(object a336, EventArgs a337)
	{
		a240();
	}

	private void a341(object a339, EventArgs a340)
	{
		a242();
	}

	private void a344(object a342, EventArgs a343)
	{
		a238();
	}

	private void a347(object a345, EventArgs a346)
	{
		a237();
	}

	private void a350(object a348, EventArgs a349)
	{
		a228();
	}

	private void a353(object a351, EventArgs a352)
	{
		a233();
	}

	private void a356(object a354, EventArgs a355)
	{
		a234();
	}

	private void a359(object a357, EventArgs a358)
	{
		a239();
	}

	private void a362(object a360, EventArgs a361)
	{
		a232();
	}

	private void a365(object a363, EventArgs a364)
	{
		a136.Text = (a363 as Button).Text + a136.Text;
	}

	private void a368(object a366, EventArgs a367)
	{
		a221();
	}

	private void a371(object a369, NavBarLinkEventArgs a370)
	{
		a243();
	}

	private void a374(object a372, EventArgs a373)
	{
		a243();
	}

	private void a377(object a375, MouseEventArgs a376)
	{
		if (a376.Button == MouseButtons.Left)
		{
			NavBarControl navBarControl = a375 as NavBarControl;
			NavBarHitInfo navBarHitInfo = navBarControl.CalcHitInfo(new Point(a376.X, a376.Y));
			if (navBarHitInfo.InGroupCaption && !navBarHitInfo.InGroupButton)
			{
				navBarHitInfo.Group.Expanded = !navBarHitInfo.Group.Expanded;
			}
		}
	}

	private void a380(object a378, NavBarLinkEventArgs a379)
	{
		a244();
	}

	private void a383(object a381, EventArgs a382)
	{
		a196++;
		if (a196 > 3000)
		{
			a196 = 0;
			if (a197 != a213())
			{
				a197 = a213();
				a168.Text = a197;
			}
		}
		if (a168.Text.Length > 0)
		{
			a168.Text = a168.Text.Substring(1) + a168.Text.Substring(0, 1);
		}
	}

	public string a384()
	{
		string text = a425("EŖɑ\u031aаԱٻݨ\u086bऴ\u0a78ୱ\u0c65൦\u0e74\u0f7aၶᅾቡ፳ᐡᕭᙢᝡᠤᥓᩌᭅ᱂ᵍṍὅ⁍ⅇ∮");
		string userName = a425("kŠɺͷѧի١ݯࡲ\u0962");
		string password = a425("}ũɳͱѩբض\u0733");
		string text2 = a425("}ůɻͻѮթ٫ܪࡷॺ\u0a75");
		FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(new Uri(text + text2));
		ftpWebRequest.Credentials = new NetworkCredential(userName, password);
		ftpWebRequest.Method = a425("Vņɖ\u0353");
		ftpWebRequest.UseBinary = true;
		FtpWebResponse ftpWebResponse = (FtpWebResponse)ftpWebRequest.GetResponse();
		Stream responseStream = ftpWebResponse.GetResponseStream();
		long contentLength = ftpWebResponse.ContentLength;
		int num = 2048;
		byte[] array = new byte[num];
		int num2 = responseStream.Read(array, 0, num);
		string result = a425("");
		while (num2 > 0)
		{
			result = Encoding.Default.GetString(array, 0, num2);
			num2 = 0;
		}
		responseStream.Close();
		ftpWebResponse.Close();
		return result;
	}

	private void a387(object a385, EventArgs a386)
	{
		a167.Enabled = true;
		try
		{
			Version version = Assembly.GetEntryAssembly().GetName().Version;
			if (version.ToString() != a384() && MessageBox.Show(a425("gŘɑ\u035eёՑ\u0659ݙࡓक\u0a64\u0b41ౝൖโཎ၃လቂሚᑄᔉᙱᝂᡈ᥌ᨄ᭵᱇ᵓṓὶ\u2067ⅲ≲⍮⑴╬☸❎⣪⥾⩸⭶Ɀ\u2d74\u2e7b⼯ㄾㅾ㉸㍮㑸㔩㙥㝮㡵㥬㩪㭪㱸㴾"), a425("Mŭɤ\u036e"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				a201 = true;
				Process.Start(Application.StartupPath + a425("Wşə\u034cцՒـܪࡦॺ\u0a64"));
				Close();
			}
		}
		catch
		{
		}
	}

	private void a390(object a388, NavBarLinkEventArgs a389)
	{
		a229();
	}

	private void a393(object a391, NavBarLinkEventArgs a392)
	{
		a230();
	}

	private void a396(object a394, EventArgs a395)
	{
		a230();
	}

	private void a399(object a397, NavBarLinkEventArgs a398)
	{
		a231();
	}

	private void a402(object a400, NavBarLinkEventArgs a401)
	{
		a236();
	}

	private void a405(object a403, CustomDrawDayNumberCellEventArgs a404)
	{
		RectangleF rect = default;
		for (int i = 0; i < a195.Count; i++)
		{
			if (a404.Date == a195[i].Tarih)
			{
				if (a195[i].Durum == 0)
				{
					a404.Style.Font = new Font(a404.Style.Font, FontStyle.Regular);
					rect = new RectangleF(a404.Bounds.Location, a404.Bounds.Size);
					a404.Graphics.FillRectangle(new SolidBrush(Color.GreenYellow), rect);
				}
				else if (a195[i].Durum == 1)
				{
					a404.Style.Font = new Font(a404.Style.Font, FontStyle.Regular);
					rect = new RectangleF(a404.Bounds.Location, a404.Bounds.Size);
					a404.Graphics.FillRectangle(new SolidBrush(Color.Orange), rect);
				}
				else if (a195[i].Durum == 3)
				{
					a404.Style.Font = new Font(a404.Style.Font, FontStyle.Regular);
					rect = new RectangleF(a404.Bounds.Location, a404.Bounds.Size);
					a404.Graphics.FillRectangle(new SolidBrush(Color.HotPink), rect);
				}
				else
				{
					a404.Style.Font = new Font(a404.Style.Font, FontStyle.Regular);
					rect = new RectangleF(a404.Bounds.Location, a404.Bounds.Size);
					a404.Graphics.FillRectangle(new SolidBrush(Color.White), rect);
				}
			}
		}
		for (int i = 0; i < a194.Count; i++)
		{
			if (a404.Date == a194[i].Date)
			{
				a404.Style.ForeColor = Color.Red;
			}
		}
	}

	private void a408(object a406, EventArgs a407)
	{
		string text = a1344.a1303();
		a199.KARTNOHEX = text;
		a199.Getir();
		a185.Text = a425("Eŧɮ\u036dѺէػ") + a199.BAKIYE.ToString(a425("lĳ"));
		a115.SelectedIndex = a113.SelectedIndex;
		a195.Clear();
		a1344.a1307();
		a1344.a1271.CommandText = a425("gĕȀ\u0308Іԁ\u0615ݠ\u086bॱ੭ଜఉഊฉ\u0f18\u1063ᄄማ፵ᑷᕡᙾᝩᡮᥪᨁ᭸ᰙᴄṢὩ⁵ⅲ≫⍫⑫╧♹✌⡋⤬⨳⭞ⱗⵕ⹒⽝〻ㅂ㈤㌺㑇㕓㙃㝙㡇㤢㩙㬽㰥㵃㹍㼤䁓䄷䈫䍋䑄䕗䙏䝉䢻䧒䫝䮳䲼䶯亷俅僟冥劰厸咶喱嚥埐墠妩媸客峋嶬庻徧悪懆抪掣撶斬曁枷梗榛檏殙泻涓溝濥炃燧狻玛璔疇皟瞙碋秧竡箘糺緤纐羍肊膃芎莛蒇薗蚓螕裲覒誝该賾跷軼迳部釲鋠鏦铦闿雤鞍颇駭髬鯿鳮鶊黾鿠ꃢꇨꊅꏰ꒒ꖌ\ua6f8\ua7e5꣒\ua9db\uaad6ꯃ곟귏껋꿍냚놫능뎴듇뗚뛔럞뢯릩뫔믉볅뷇뻌뿅샎쇕슢쎤쓔엊웄쟎졟줪쩌쭒찢촿츴켽퀼턩툱팡퐡픧혼흍\ud85e\ud94e\uda39\udb24\udc2e\udd24\ude49\udf4f\ue03e\ue123\ue22b\ue329\ue42a\ue531\ue646\ue740\ue808\ue916\uea18\ueb12\uec7b\ued0e\uee68\uef76\uf00e\uf113\uf218\uf311\uf418\uf50d\uf615\uf705\uf81d亂切ﭱﱸﵪ\ufe1d\uff00\u0002Ĉɥ\u0363ЊԒ\u0615܁ࡳङਝ\u0b79\u0c75ൾฐ\u0f18\u1071ᅤቺ፹ᐓᕵᙤ\u177eᡰ\u1977\u1a78᭧ᱧᵯṤὭ\u2007ⅲ∔⌈⑨╫♲❩⡓⥛⩏⬼ⱏ\u2d28⸹⽏たㅓ㉇㍑㐳㕆㘠㜾㡖㥛㩆㭀㱎㵇㹌㽗䁊䅃䉗䍛䑊䕆䘼") + a1344.a1272 + a425("9řə\u0352еՀآ\u073c\u085a\u0951\u0a5d\u0b5a\u0c43\u0d43ใཏၑᄨቋፏᑎᕁᘣᜥᠤ") + text + a425("\u001eĝș\u0379ѹղ\u0615ݠࠂज\u0a7a\u0b79౼൧\u0e61ཀྵၹᅵበ፬ᐚᕲᘗᜊᡪᥦᨁ\u1b6fᱍᵚṘ\u1f4e※⅘≀⌸⑃┧☻❀⡒⥀⩘⭘Ⱟⵊ⹈⽟えㄦ㉝㌹㐩㕏㙁㜤㡂㥑㩂");
		DataTable dataTable = a2147.a2105(a1344.a1271);
		for (int i = 0; i < dataTable.Rows.Count; i++)
		{
			if (dataTable.Rows[i][a425("Iłɑ\u034dыՅ")].ToString() == a115.Text)
			{
				YukluTar yukluTar = new YukluTar();
				yukluTar.Tarih = Convert.ToDateTime(dataTable.Rows[i][a425("QŅɑ\u034bщ")]);
				yukluTar.Durum = Convert.ToInt32(dataTable.Rows[i][a425("RŏɄ\u034dьՙفݑࡑ\u0957\u0a4c")]);
				a195.Add(yukluTar);
			}
		}
	}

	private void a411(object a409, EventArgs a410)
	{
		a2006 a2269 = new a2006(new a1702());
		a2269.ShowDialog();
	}

	private void a414(object a412, EventArgs a413)
	{
		a229();
	}

	private void a417(object a415, NavBarLinkEventArgs a416)
	{
		a241();
	}

	private void a420(object a418, EventArgs a419)
	{
		if (MessageBox.Show(a425("ĕŔɗ\u0343эԀ\u065aݪࡰॹ\u0a70\u0b3aഩ൫\u0e63\u0f73\u1071ᅽጌ፻ᑿᕹᙵᝫᠭ᥉\u1a66᭣ᱧᵥṮή\u206cⅪ≪⍸\u242f"), a425("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
		{
			return;
		}
		int num = 0;
		if (num < a78.RowCount)
		{
			switch ((int)/*Error near IL_013e: Stack underflow*/)
			{
			default:
				/*Error: End of method reached without returning.*/;
			case 0:
				/*Error: Invalid branch target*/;
			case 1:
				/*Error: Invalid branch target*/;
			case 2:
				/*Error: Invalid branch target*/;
			case 3:
				/*Error: Invalid branch target*/;
			case 4:
				/*Error: Invalid branch target*/;
			case 5:
				/*Error: Invalid branch target*/;
			case 6:
				/*Error: Invalid branch target*/;
			case 7:
				/*Error: Invalid branch target*/;
			case 8:
				/*Error: Invalid branch target*/;
			case 9:
				/*Error: Invalid branch target*/;
			case 10:
				/*Error: Invalid branch target*/;
			case 11:
				/*Error: Invalid branch target*/;
			case 12:
				/*Error: Invalid branch target*/;
			case 13:
				/*Error: Invalid branch target*/;
			case 14:
				/*Error: Invalid branch target*/;
			case 15:
				/*Error: Invalid branch target*/;
			case 16:
				/*Error: Invalid branch target*/;
			case 17:
				/*Error: Invalid branch target*/;
			case 18:
				/*Error: Invalid branch target*/;
			case 19:
				/*Error: Invalid branch target*/;
			case 20:
				/*Error: Invalid branch target*/;
			case 21:
				/*Error: Invalid branch target*/;
			case 22:
				/*Error: Invalid branch target*/;
			case 23:
				/*Error: Invalid branch target*/;
			case 24:
				/*Error: Invalid branch target*/;
			case 25:
				/*Error: Invalid branch target*/;
			case 26:
				/*Error: Invalid branch target*/;
			case 27:
				/*Error: Invalid branch target*/;
			case 28:
				/*Error: Invalid branch target*/;
			case 29:
				/*Error: Invalid branch target*/;
			case 30:
				/*Error: Invalid branch target*/;
			case 31:
				/*Error: Invalid branch target*/;
			case 32:
				/*Error: Invalid branch target*/;
			case 33:
				/*Error: Invalid branch target*/;
			case 34:
				/*Error: Invalid branch target*/;
			case 35:
				/*Error: Invalid branch target*/;
			case 36:
				/*Error: Invalid branch target*/;
			case 37:
				/*Error: Invalid branch target*/;
			case 38:
				/*Error: Invalid branch target*/;
			case 39:
				/*Error: Invalid branch target*/;
			case 40:
				/*Error: Invalid branch target*/;
			case 41:
				/*Error: Invalid branch target*/;
			case 42:
				/*Error: Invalid branch target*/;
			case 43:
				/*Error: Invalid branch target*/;
			case 44:
				/*Error: Invalid branch target*/;
			case 45:
				/*Error: Invalid branch target*/;
			case 46:
				/*Error: Invalid branch target*/;
			case 47:
				/*Error: Invalid branch target*/;
			case 48:
				/*Error: Invalid branch target*/;
			case 49:
				/*Error: Invalid branch target*/;
			case 50:
				/*Error: Invalid branch target*/;
			case 51:
				/*Error: Invalid branch target*/;
			case 52:
				/*Error: Invalid branch target*/;
			case 53:
				/*Error: Invalid branch target*/;
			case 54:
				/*Error: Invalid branch target*/;
			case 55:
				/*Error: Invalid branch target*/;
			case 56:
				/*Error: Invalid branch target*/;
			case 57:
				/*Error: Invalid branch target*/;
			case 58:
				/*Error: Invalid branch target*/;
			case 59:
				/*Error: Invalid branch target*/;
			case 60:
				/*Error: Invalid branch target*/;
			case 61:
				/*Error: Invalid branch target*/;
			case 62:
				/*Error: Invalid branch target*/;
			case 63:
				/*Error: Invalid branch target*/;
			}
		}
		string text = a1344.a1303();
		if (text == a425("8ķȶ\u0335дԳز\u0731"))
		{
			text = a425("");
		}
		if (text == a425(">Ĵȶ\u0335дԳز\u0731"))
		{
			text = a425("");
		}
		a218(text);
		MessageBox.Show(a425("]ŴɭȢѦսٱݽ\u082e࠽\u0a7c\u0b7f౫\u0d65ศག\u1062ᅬቨ፧ᑫᔯ"), a425("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	private void a423(object a421, EventArgs a422)
	{
		if (a78.RowCount <= 0)
		{
			return;
		}
		bool flag = false;
		for (int i = 0; i < a78.RowCount; i++)
		{
			if (a78.GetRowCellValue(i, a425("PŇɂ")).ToString() == a425("D"))
			{
				flag = true;
			}
		}
		if (!flag)
		{
			MessageBox.Show(a425("xǏɆ\u0357ѕՁ؎\u07fbࡂ\u0948\u0a4fଉ౬\u0d42\u0f39ཌᅻᅎቇፒᑉᕱᙷ\u173d\u192cᥨ\u1a6e᭼ᱼᵾἉὼ⁺ⅺ≨⌱\u2457◳♠❡⡩⥹⩣⬩ⱛⵢ⻡⽬なㅪ㉸㌯"), a425(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		a2266 a2269 = new a2266();
		a2006 a2270 = new a2006(a2269);
		a2270.ShowDialog();
		if (!a2269.a2257)
		{
			return;
		}
		for (int i = 0; i < a78.RowCount; i++)
		{
			if (a78.GetRowCellValue(i, a425("PŇɂ")).ToString() == a425("D"))
			{
				int num = Convert.ToInt32(a78.GetRowCellValue(i, a425("KŅ")));
				a1344.a1307();
				a1344.a1271.CommandText = a425("pŴɧ\u0363ѵեؿݙࡈ\u0952\u0a44\u0b43\u0c4c\u0d53๛ན\u1058ᅑሳፁᑔᕄᘯ\u1757ᡈ\u1941ᩎᭇ\u1c4cᵚṌὃ\u205f⅍≇⌿␦") + a2269.a2258 + a425("+īɝ\u0341эՕكܥࡍ\u0947\u0a3fଦ") + num + a425("&");
				a1344.a1271.ExecuteNonQuery();
			}
		}
		string text = a1344.a1303();
		if (text == a425("8ķȶ\u0335дԳز\u0731"))
		{
			text = a425("");
		}
		if (text == a425(">Ĵȶ\u0335дԳز\u0731"))
		{
			text = a425("");
		}
		a218(text);
	}

	private static string a425(string a424)
	{
		int length = a424.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a424[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
