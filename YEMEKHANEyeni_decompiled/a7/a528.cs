using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Data;
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

public class a528 : XtraForm
{
	private IContainer a429 = null;

	public GroupBox a430;

	public Label a431;

	public Label a432;

	public Label a433;

	public Label a434;

	private Panel a435;

	public Button a436;

	public System.Windows.Forms.ComboBox a437;

	public Label a438;

	public GridControl a439;

	public GridView a440;

	private GridColumn a441;

	private GridColumn a442;

	private GridColumn a443;

	private GridColumn a444;

	private GridColumn a445;

	private GridColumn a446;

	private GridColumn a447;

	private GridColumn a448;

	private GridColumn a449;

	private GridColumn a450;

	private GridColumn a451;

	private GridColumn a452;

	public ContextMenuStrip a453;

	public ToolStripMenuItem a454;

	private ToolStripMenuItem a455;

	public System.Windows.Forms.ComboBox a456;

	public System.Windows.Forms.ComboBox a457;

	public Label a458;

	public System.Windows.Forms.ComboBox a459;

	private ToolStripMenuItem a460;

	private ToolStripMenuItem a461;

	private PictureBox a462;

	private GridColumn a463;

	private ToolStripMenuItem a464;

	private GridColumn a465;

	private RepositoryItemCheckEdit a466;

	private ToolStripMenuItem a467;

	private ToolStripMenuItem a468;

	private ToolStripMenuItem a469;

	private ToolStripMenuItem a470;

	private ToolStripMenuItem a471;

	private ToolStripMenuItem a472;

	private ToolStripMenuItem a473;

	private bool a474 = false;

	protected override void Dispose(bool a475)
	{
		if (a475 && a429 != null)
		{
			a429.Dispose();
		}
		base.Dispose(a475);
	}

	private void a476()
	{
		a429 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(a528));
		a430 = new GroupBox();
		a457 = new System.Windows.Forms.ComboBox();
		a458 = new Label();
		a439 = new GridControl();
		a453 = new ContextMenuStrip(a429);
		a454 = new ToolStripMenuItem();
		a455 = new ToolStripMenuItem();
		a460 = new ToolStripMenuItem();
		a461 = new ToolStripMenuItem();
		a464 = new ToolStripMenuItem();
		a467 = new ToolStripMenuItem();
		a468 = new ToolStripMenuItem();
		a469 = new ToolStripMenuItem();
		a470 = new ToolStripMenuItem();
		a471 = new ToolStripMenuItem();
		a472 = new ToolStripMenuItem();
		a473 = new ToolStripMenuItem();
		a440 = new GridView();
		a441 = new GridColumn();
		a442 = new GridColumn();
		a443 = new GridColumn();
		a444 = new GridColumn();
		a445 = new GridColumn();
		a446 = new GridColumn();
		a447 = new GridColumn();
		a448 = new GridColumn();
		a449 = new GridColumn();
		a450 = new GridColumn();
		a451 = new GridColumn();
		a452 = new GridColumn();
		a463 = new GridColumn();
		a465 = new GridColumn();
		a466 = new RepositoryItemCheckEdit();
		a437 = new System.Windows.Forms.ComboBox();
		a438 = new Label();
		a431 = new Label();
		a432 = new Label();
		a433 = new Label();
		a434 = new Label();
		a462 = new PictureBox();
		a459 = new System.Windows.Forms.ComboBox();
		a456 = new System.Windows.Forms.ComboBox();
		a435 = new Panel();
		a436 = new Button();
		a430.SuspendLayout();
		((ISupportInitialize)a439).BeginInit();
		a453.SuspendLayout();
		((ISupportInitialize)a440).BeginInit();
		((ISupportInitialize)a466).BeginInit();
		((ISupportInitialize)a462).BeginInit();
		a435.SuspendLayout();
		SuspendLayout();
		a430.Controls.Add(a457);
		a430.Controls.Add(a458);
		a430.Controls.Add(a439);
		a430.Controls.Add(a437);
		a430.Controls.Add(a438);
		a430.Controls.Add(a431);
		a430.Controls.Add(a432);
		a430.Controls.Add(a433);
		a430.Controls.Add(a434);
		a430.Controls.Add(a462);
		a430.Location = new Point(3, 1);
		a430.Name = a527("nźɨͳѵՆ٬ݺ࠰");
		a430.Size = new Size(1009, 722);
		a430.TabIndex = 0;
		a430.TabStop = false;
		a457.DropDownStyle = ComboBoxStyle.DropDownList;
		a457.Font = new Font(a527("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a457.FormattingEnabled = true;
		a457.Location = new Point(108, 68);
		a457.Name = a527("oũɓͼѣի٣ݨࡡ\u094e੧୳");
		a457.Size = new Size(218, 26);
		a457.TabIndex = 1;
		a457.SelectedIndexChanged += a510;
		a458.AutoSize = true;
		a458.Location = new Point(15, 75);
		a458.Name = a527("jŤɦ\u0366ѮԶ");
		a458.Size = new Size(85, 13);
		a458.TabIndex = 69;
		a458.Text = a527("Vǲɦ\u0360Ѯէ٬ܨࡊ\u0963\u0a77୯౦൸\u0e68");
		a439.ContextMenuStrip = a453;
		a439.EmbeddedNavigator.Name = a527("");
		a439.Font = new Font(a527("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a439.Location = new Point(9, 151);
		a439.LookAndFeel.SkinName = a527("GżɻͳѯՖ٭ݨ\u086b९");
		a439.LookAndFeel.UseDefaultLookAndFeel = false;
		a439.MainView = a440;
		a439.Name = a527("kŹɣ\u036dыը٨ݱࡶ६੮ର");
		a439.RepositoryItems.AddRange(new RepositoryItem[1] { a466 });
		a439.Size = new Size(991, 440);
		a439.TabIndex = 2;
		a439.ViewCollection.AddRange(new BaseView[1] { a440 });
		a453.Items.AddRange(new ToolStripItem[6] { a454, a455, a460, a461, a464, a467 });
		a453.Name = a527("rſɡͺѨմٿ\u0747\u086c०ੲ\u0b55\u0c71൶\u0e6a\u0f72\u1030");
		a453.Size = new Size(269, 350);
		a454.Image = a2268.a2342;
		a454.ImageScaling = ToolStripItemImageScaling.None;
		a454.Name = a527("gźɾ\u0345ѿՠ٢ݞࡸॹ\u0a63\u0b79\u0c45\u0d62\u0e68\u0f70၍ᅷቧ፬");
		a454.Size = new Size(268, 54);
		a454.Text = a527("AǨɾ\u0332њձٽݺࡡ७\u0a79\u0a3b\u0c29\u0d4a\u0e6bཀྵၮᅡሣፇᑵ");
		a454.Click += a495;
		a455.Image = a2268.a2314;
		a455.ImageScaling = ToolStripItemImageScaling.None;
		a455.Name = a527("vŽɩ\u036eԨՙټݢࡼॲ\u0a56୦\u0c45ൿ\u0e60ར\u105eᅸቹ፣ᑹᕅᙢᝨᡰ᥍\u1a77᭧ᱬ");
		a455.Size = new Size(268, 54);
		a455.Text = a527("AǨɾ\u0332њձٽݺࡡ७\u0a79\u0a3b\u0c29\u0d49\u0e6c\u0f72\u106cᅢሣፇᑵ");
		a455.Click += a504;
		a460.Image = a2268.a2341;
		a460.ImageScaling = ToolStripItemImageScaling.None;
		a460.Name = a527("PŇˆ\u0349ѳշ\u0656ݽࡩ८ନ\u0b5a౻൹\u0e7e\u0f71\u1056ᅦቅ\u137fᑠᕢᙞ\u1778\u1879ᥣ\u1a79ᭅᱢᵨṰὍ⁷Ⅷ≬");
		a460.Size = new Size(268, 54);
		a460.Text = a527("Fű\u02f4ͻѽչد\u0745\u086cॾ\u0a7f\u0a3b\u0c29\u0d4a\u0e6bཀྵၮᅡሣፇᑵ");
		a460.Click += a498;
		a461.Image = a2268.a2319;
		a461.ImageScaling = ToolStripItemImageScaling.None;
		a461.Name = a527("PŇˆ\u0349ѳշ\u0656ݽࡩ८ନ\u0b59౼\u0d62\u0e7c\u0f72\u1056ᅦቅ\u137fᑠᕢᙞ\u1778\u1879ᥣ\u1a79ᭅᱢᵨṰὍ⁷Ⅷ≬");
		a461.Size = new Size(268, 54);
		a461.Text = a527("Fű\u02f4ͻѽչد\u0745\u086cॾ\u0a7f\u0a3b\u0c29\u0d49\u0e6c\u0f72\u106cᅢሣፇᑵ");
		a461.Click += a501;
		a464.Image = a2268.a2279;
		a464.ImageScaling = ToolStripItemImageScaling.None;
		a464.Name = a527("użɮ\u036fѝի٭ݵࡣ\u0951\u0a71୴౻\u0d62\u0e64སၼᅞቸ፹ᑣᕹᙅᝢᡨᥰᩍ᭷ᱧᵬ");
		a464.Size = new Size(268, 54);
		a464.Text = a527("Tſɯ\u0368л՝٫ݭࡵ\u0963\u0a7bୡళൖ\u0e74ฏၦၑቹ፥ᑹᔪᘡᝀᡢ\u1976\u1a76\u1b6dᱭᵫḨ");
		a467.DropDownItems.AddRange(new ToolStripItem[2] { a468, a471 });
		a467.Image = (Image)componentResourceManager.GetObject(a527("MŘɁȘьՆٿ\u0740ࡉ\u0946\u0a49୴ౙ൸\u0e6b\u0f71ၽᅶቻ፪ᔩᕃᙹ\u177aᡸ᥀\u1a66᭣ᱹᵿṃὨ\u2062ⅾ≃⍽⑭╪☨❌⡩⥢⩥⭤"));
		a467.ImageScaling = ToolStripItemImageScaling.None;
		a467.Name = a527("GŖɏȒцՀٹݺࡳॸ\u0a77\u0b4e\u0c63ൾ\u0e6d\u0f7bၷᅸት፠ᔣᕅᙿᝠᡢᥞ\u1a78᭹ᱣᵹṅὢ\u2068ⅰ≍⍷⑧╬");
		a467.Size = new Size(268, 54);
		a467.Text = a527("Vťɾȥѷճر\u0749ࡪ\u0963੨୧ఫൟ\u0e70\u0f6f\u1072ᅪቤ፩ᑢᕱᜰ");
		a468.DropDownItems.AddRange(new ToolStripItem[2] { a469, a470 });
		a468.Image = (Image)componentResourceManager.GetObject(a527("GŃɚ\u035cтՂـݏࡊॶ\u0add\u0b4d\u0c54ൿ\u0e64อၯᅶቸ፪ᑃᕹᙺ\u1778ᡀᥦ\u1a63᭹᱿ᵃṨὢ⁾⅃≽⍭⑪┨♌❩⡢⥥⩤"));
		a468.ImageScaling = ToolStripItemImageScaling.None;
		a468.Name = a527("Iōɐ\u0356фՄٺݵࡴ\u0948૧୷\u0c52൹\u0e6eวၡᅸቲ፠ᑅᕿᙠᝢᡞ\u1978\u1a79᭣ᱹᵅṢὨ⁰⅍≷⍧⑬");
		a468.Size = new Size(206, 38);
		a468.Text = a527("Zżɧ\u0367ѷյٵݤࡧभ\u0a58௷౧ഩใསၿ\u1034ተ፯ᑣᕳ");
		a469.Image = (Image)componentResourceManager.GetObject(a527("FŕɎȕчՃ\u064fݹࡶ१\u0a78ୱ౾൩\u0e70\u0f76၃ᅹቺ፸ᑀᕦᙣ\u1779\u187f\u1943\u1a68᭢᱾ᵃṽὭ\u206aℨ≌⍩③╥♤"));
		a469.ImageScaling = ToolStripItemImageScaling.None;
		a469.Name = a527("@œɴȯѹսٵ\u0743ࡰॡੲ\u0b7b\u0c70൧\u0e7a\u0f7c၅ᅿበ።ᑞᕸᙹᝣ\u1879᥅\u1a62᭨ᱰᵍṷὧ\u206c");
		a469.Size = new Size(189, 38);
		a469.Text = a527("SŢɻȾѪլ٢ܫࡓॠ\u0a71\u0b62\u0c64൬\u0e68\u0f70\u106bᅯ");
		a469.Click += a516;
		a470.Image = (Image)componentResourceManager.GetObject(a527("IŔɍȔрՂ\u064cݸࡉ०\u0a7b\u0b7f\u0c75൷\u0e69\u0f70ၶᅃቹ፺ᑸᕀᙦᝣ\u1879\u197fᩃ᭨ᱢᵾṃώ\u206dⅪ∨⍌⑩╢♥❤"));
		a470.ImageScaling = ToolStripItemImageScaling.None;
		a470.Name = a527("CŒɋȮѺռٲ\u0742ࡳॠ\u0a7d୵౿൹\u0e67\u0f7aၼᅅቿ፠ᑢᕞᙸ\u1779ᡣ\u1979ᩅ᭢ᱨᵰṍί\u2067Ⅼ");
		a470.Size = new Size(189, 38);
		a470.Text = a527("Pţɤȿѩխ٥ܪࡐॡ\u0a7e\u0b63౨ൡ\u0e70ཫၯ");
		a470.Click += a519;
		a471.DropDownItems.AddRange(new ToolStripItem[2] { a472, a473 });
		a471.Image = (Image)componentResourceManager.GetObject(a527("Uŀ\u02c3\u034aюՈٯݳࡿॳ\u0a57\u0b7a\u0c63న\u0e6cགྷၹᅺቸፀᑦᕣᙹ\u177fᡃᥨ\u1a62᭾᱃ᵽṭὪ\u2028⅌≩⍢⑥╤"));
		a471.ImageScaling = ToolStripItemImageScaling.None;
		a471.Name = a527("Sź\u02f9ʹѰղ\u0655ݵࡹॹ\u0a5d୴౭ఢ\u0e66ཅၿᅠቢ\u135eᑸᕹᙣ\u1779ᡅᥢ\u1a68\u1b70ᱍᵷṧὬ");
		a471.Size = new Size(206, 38);
		a471.Text = a527("Bŵ\u02e8\u0367ѡեث\u0745ࡥ३੩ଦ\u0c4e\u0d65\u0e7aำၵ");
		a472.Image = (Image)componentResourceManager.GetObject(a527("HśɌȗсՅ\u064dݻࡈख़\u0a7a\u0b7c\u0c74൰\u0e68\u0f73ၷᅌቸ፹ᑹᕇᙧᝠᡸᥠᩂ\u1b6bᱣᵹṂ\u1f7e\u206cⅥ∶⌨\u244c╩♢❥⡤"));
		a472.ImageScaling = ToolStripItemImageScaling.None;
		a472.Name = a527("BőɊȑѻտٳ\u0745ࡲ\u0963\u0a7c\u0b7a౾ൺ\u0e66\u0f7dၽᅆቾ\u137fᑣᕝᙹ\u177eᡢ\u197aᩄ\u1b6dᱩᵳṌὰ\u2066Ⅿ∰");
		a472.Size = new Size(189, 38);
		a472.Text = a527("SŢɻȾѪլ٢ܫࡓॠ\u0a71\u0b62\u0c64൬\u0e68\u0f70\u106bᅯ");
		a472.Click += a522;
		a473.Image = (Image)componentResourceManager.GetObject(a527("IŔɍȔрՂ\u064cݸࡉ०\u0a7b୰౹൨\u0e73\u0f77၌ᅸቹ፹ᑇᕧᙠ\u1778ᡠ\u1942\u1a6b᭣ᱹᵂṾὬ\u2065ℶ∨⍌⑩╢♥❤"));
		a473.ImageScaling = ToolStripItemImageScaling.None;
		a473.Name = a527("CŒɋȮѺռٲ\u0742ࡳॠ\u0a7d\u0b7a\u0c73൦\u0e7d\u0f7d၆ᅾቿ፣ᑝᕹᙾᝢ\u187a᥄\u1a6d᭩ᱳᵌṰὦ\u206fℰ");
		a473.Size = new Size(189, 38);
		a473.Text = a527("Pţɤȿѩխ٥ܪࡐॡ\u0a7e\u0b63౨ൡ\u0e70ཫၯ");
		a473.Click += a525;
		a440.BorderStyle = BorderStyles.NoBorder;
		a440.Columns.AddRange(new GridColumn[14]
		{
			a441, a442, a443, a444, a445, a446, a447, a448, a449, a450,
			a451, a452, a463, a465
		});
		a440.FocusRectStyle = DrawFocusRectStyle.RowFocus;
		a440.GridControl = a439;
		a440.Name = a527("nźɮ\u0362ѓխ٦ݵ࠰");
		a440.OptionsBehavior.Editable = false;
		a440.OptionsCustomization.AllowFilter = false;
		a440.OptionsCustomization.AllowGroup = false;
		a440.OptionsCustomization.AllowRowSizing = true;
		a440.OptionsCustomization.AllowSort = false;
		a440.OptionsFilter.AllowFilterEditor = false;
		a440.OptionsView.ShowAutoFilterRow = true;
		a440.OptionsView.ShowFooter = true;
		a440.OptionsView.ShowGroupPanel = false;
		a441.Caption = a527("KŅ");
		a441.FieldName = a527("KŅ");
		a441.Name = a527("lŸɠ\u036cфթ٩ݱ\u086e६ਰ");
		a442.Caption = a527("QŇȣ\u034cѮ");
		a442.FieldName = a527("\\ńɍ\u034cщՏ\u064b\u074a");
		a442.Name = a527("lŸɠ\u036cфթ٩ݱ\u086e६ਲ਼");
		a442.Visible = true;
		a442.VisibleIndex = 1;
		a442.Width = 130;
		a443.Caption = a527("IţȦ\u0356ѫպ٣ݥ");
		a443.FieldName = a527("Fłɖ\u034bњՃم");
		a443.Name = a527("lŸɠ\u036cфթ٩ݱ\u086e६ਲ");
		a443.Visible = true;
		a443.VisibleIndex = 2;
		a443.Width = 222;
		a444.Caption = a527("LŧɷͰУՌٮ");
		a444.FieldName = a527("Bŉɕ\u0352ыՋ\u064b\u0747\u0859");
		a444.Name = a527("lŸɠ\u036cфթ٩ݱ\u086e६ਵ");
		a444.Visible = true;
		a444.VisibleIndex = 3;
		a444.Width = 100;
		a445.Caption = a527("AŨɺͳЦՂٶݶࡠॴ");
		a445.FieldName = a527("Cņɔ\u0351уՑ\u0657ݑ");
		a445.Name = a527("lŸɠ\u036cфթ٩ݱ\u086e६\u0a34");
		a445.Visible = true;
		a445.VisibleIndex = 4;
		a445.Width = 206;
		a446.Caption = a527("AŨɺͳсշٱݳࡋ\u0945");
		a446.FieldName = a527("Bŉɕ\u0352њՃ\u0651ݗࡑ");
		a446.Name = a527("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଳ");
		a447.Caption = a527("Ełɔ\u034eсՙ\u064b\u0745");
		a447.FieldName = a527("HŅɄ\u0342шՁ\u064eݕࡄ\u094d\u0a55\u0b4d\u0c40൞\u0e5cཋ၅");
		a447.Name = a527("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ର");
		a448.Caption = a527("KŠɶ\u0368ѧջ");
		a448.FieldName = a527("PŝɌ\u034bрՖو\u0747\u085b");
		a448.Name = a527("lŸɠ\u036cфթ٩ݱ\u086e६\u0a37");
		a448.Visible = true;
		a448.VisibleIndex = 5;
		a448.Width = 207;
		a449.Caption = a527("DŤɯ\u036aѻդ");
		a449.FieldName = a527("Dńɏ\u034aћՄ");
		a449.Name = a527("lŸɠ\u036cфթ٩ݱ\u086e६ਸ਼");
		a449.Width = 71;
		a450.Caption = a527("XŪɸ\u0360Ѡԧةܥࡗ\u0962\u0a63୵");
		a450.FieldName = a527("]ŉɕ\u034fэ\u0557ق\u0743ࡕ");
		a450.Name = a527("lŸɠ\u036cфթ٩ݱ\u086e६ਹ");
		a450.Width = 87;
		a451.Caption = a527("XĤɍ\u0332ЧՋ٬ݯࡷ\u0963ੳ");
		a451.FieldName = a527("Cŀɀ\u0352ш՞\u0659\u074cࡆक़\u0a4b\u0b4c\u0c4f\u0d57ใན");
		a451.Name = a527("lŸɠ\u036cфթ٩ݱ\u086e६ਸ");
		a451.Width = 73;
		a452.AppearanceHeader.Options.UseTextOptions = true;
		a452.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
		a452.Caption = a527("GŨɬ\u0369Ѥ");
		a452.FieldName = a527("GňɌ\u0349ф");
		a452.Name = a527("kŹɣ\u036dыը٪ݰࡩ७ਲ਼\u0b31");
		a452.Visible = true;
		a452.VisibleIndex = 6;
		a452.Width = 64;
		a463.Caption = a527("W2ɰ\u0360");
		a463.FieldName = a527("WŊɐ\u0340");
		a463.Name = a527("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଲ");
		a463.SummaryItem.SummaryType = SummaryItemType.Count;
		a463.Visible = true;
		a463.VisibleIndex = 0;
		a463.Width = 45;
		a465.Caption = a527("Kźɣ\u036eѢդؤݚ\u082c\u0954");
		a465.ColumnEdit = a466;
		a465.FieldName = a527("MŘɁ\u0340ьՆ\u0659ݜࡁ\u094e\u0a47\u0b4a");
		a465.Name = a527("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଵ");
		a465.OptionsColumn.AllowEdit = false;
		a465.Visible = true;
		a465.VisibleIndex = 7;
		a466.AutoHeight = false;
		a466.Name = a527("jŲɦͺѧպ٦ݾࡢॶ\u0a47\u0b79౩൦\u0e49ཡ\u106dᅤቭፀᑠᕪᙶᜰ");
		a466.ValueChecked = 1;
		a466.ValueUnchecked = 0;
		a437.DropDownStyle = ComboBoxStyle.DropDownList;
		a437.Font = new Font(a527("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a437.FormattingEnabled = true;
		a437.Location = new Point(108, 36);
		a437.Name = a527("iūɃ\u0366Ѵձكݱࡷॱ");
		a437.Size = new Size(218, 26);
		a437.TabIndex = 0;
		a437.SelectedIndexChanged += a510;
		a438.AutoSize = true;
		a438.Location = new Point(15, 44);
		a438.Name = a527("jŤɦ\u0366ѮԸ");
		a438.Size = new Size(59, 13);
		a438.TabIndex = 65;
		a438.Text = a527("AŨɺͳЦՂٶݶࡠॴ");
		a431.AutoSize = true;
		a431.Location = new Point(11, 107);
		a431.Name = a527("jŤɦ\u0366ѮԲ");
		a431.Size = new Size(653, 13);
		a431.TabIndex = 59;
		a431.Text = a527("Äǯ\u02ffϸӧ\u05ebۻڹࢧ\u09d2૪௴೯\u0df7ມ\u0ff9သᄚሜ\u135cᐯᔟᘒ\u1714\u181eᥖ\u1a1aᬘᰒᴀḐἛ⁏ℬ∁⌃␀┏♉✭⠃⤃⨇⬍Ⰿⴋ⸓⼓〶\u3130㈴㌦㑵㕺㘝㜹㠿㤷㩵㬇㰼㴼㸣㼱䁯䄌䈡䌣䐠䔯䘺䜡䠩䤯䩥䬏䰢䴮严乱偍兓剜南君吊噊坌塒奒婜娫屚嵜幘彊怏慥扌捞摟搛昉杣框楔橑欄汨浃湘渑火焾牘獷瑩畻癷瘩硹祲穴筺簳絖续罪聪腢艹荩葩蕣虥蝡衵襵詬譪豪赸踯");
		a432.AutoSize = true;
		a432.Font = new Font(a527("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a432.Location = new Point(12, 133);
		a432.Name = a527("jŤɦ\u0366Ѯ\u0530");
		a432.Size = new Size(100, 13);
		a432.TabIndex = 55;
		a432.Text = a527("ZűɽͺЭՋٹݿࡹन\u0a4b୯\u0c76൰\u0e66\u0f71\u1068");
		a433.BackColor = Color.FromArgb(128, 255, 128);
		a433.BorderStyle = BorderStyle.Fixed3D;
		a433.FlatStyle = FlatStyle.Flat;
		a433.ForeColor = Color.DarkOrange;
		a433.Location = new Point(12, 126);
		a433.Name = a527("kŧɧ\u0361ѯԳز");
		a433.Size = new Size(983, 3);
		a433.TabIndex = 54;
		a434.AutoSize = true;
		a434.Font = new Font(a527("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a434.Location = new Point(12, 19);
		a434.Name = a527("jŤɦ\u0366ѮԹ");
		a434.Size = new Size(69, 13);
		a434.TabIndex = 51;
		a434.Text = a527("KŹɿ\u0379ШՅٯݩࡣ४\u0a71୨");
		a462.Image = (Image)componentResourceManager.GetObject(a527("aŹɬͺѸվٮ\u0748ࡦ॰ਸ਼ନ\u0c4c൩\u0e62ཥ\u1064"));
		a462.Location = new Point(595, 11);
		a462.Name = a527("{ţɪͼѲմ٠\u0746\u086cॺਰ");
		a462.Size = new Size(492, 845);
		a462.TabIndex = 71;
		a462.TabStop = false;
		a459.DropDownStyle = ComboBoxStyle.DropDownList;
		a459.Font = new Font(a527("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a459.FormattingEnabled = true;
		a459.Location = new Point(965, 257);
		a459.Name = a527("můɕ;ѡե٭ݪࡣ\u0948\u0a61ୱ\u0c4b\u0d45");
		a459.Size = new Size(41, 26);
		a459.TabIndex = 67;
		a456.DropDownStyle = ComboBoxStyle.DropDownList;
		a456.Font = new Font(a527("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a456.FormattingEnabled = true;
		a456.Location = new Point(965, 225);
		a456.Name = a527("oũɁ\u0368Ѻճفݷࡱॳ\u0a4b\u0b45");
		a456.Size = new Size(41, 26);
		a456.TabIndex = 67;
		a435.Controls.Add(a436);
		a435.Dock = DockStyle.Bottom;
		a435.Location = new Point(0, 596);
		a435.Name = a527("vŤɪ\u0366Ѯ\u0530");
		a435.Size = new Size(1016, 46);
		a435.TabIndex = 2;
		a436.Dock = DockStyle.Fill;
		a436.Location = new Point(0, 0);
		a436.Name = a527("jųɨ\u0346ѭը٫ݲ");
		a436.Size = new Size(1016, 46);
		a436.TabIndex = 3;
		a436.Text = a527("Â5ɨȳ՞");
		a436.UseVisualStyleBackColor = true;
		a436.Click += a492;
		Appearance.BackColor = Color.White;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1016, 642);
		Controls.Add(a435);
		Controls.Add(a430);
		Controls.Add(a459);
		Controls.Add(a456);
		MaximizeBox = false;
		MaximumSize = new Size(1032, 814);
		Name = a527("WŢɢ\u035aѢռ٧ݿࡂ३\u0a75୲\u0c4c൷\u0e6fཧ\u106c");
		ShowIcon = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a527("@żɢͽѥԯمݬࡾॿਪਹ\u0d57൫\u0e63ཨ\u1068ᅦተ፨");
		Shown += a513;
		a430.ResumeLayout(performLayout: false);
		a430.PerformLayout();
		((ISupportInitialize)a439).EndInit();
		a453.ResumeLayout(performLayout: false);
		((ISupportInitialize)a440).EndInit();
		((ISupportInitialize)a466).EndInit();
		((ISupportInitialize)a462).EndInit();
		a435.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public a528()
	{
		a476();
		a1984.a1891(this);
		a1984.a1964(a527("rťɓ\u035bўՈػݓ\u085dऴ\u0a56\u0b52\u0c5cഴ๕ཀ\u105eᅝሯፗᑘᕇᙇᝏᡄ᥍\u1a58ᭋ᱀ᵖṈ\u1f47⁛"), a459, a457, a527("1"), a527("MšɳͱѨ"));
		a1984.a1964(a527("gŶɾʹѳջ؎ݤࡨइ\u0a61୨౺൳\u0e79རၶᅶቲ\u137eᑡᕛᙗ\u173dᡚ᥉\u1a55᭔\u1c38ᵜṗ\u1f47\u2040⅌≕⍃⑅╟☮❚⡄⥎⩘⭌Ⱘⵆ⹍⽑きㅅ㈿㌰"), a456, a437, a527("1"), a527("MšɳͱѨ"));
		a481();
		a477();
	}

	public void a477()
	{
		a1344.a1307();
		a1344.a1271.CommandText = a527("\u0013šɴͼѪխٹ܌ࡠ५\u0a7b\u0b7c౸ൡ\u0e77\u0f71\u1073ᅽበ፤ᑖᔾᙛᝎᡔᥗᨹ᭓᱖ᵄṁὋ\u2054⅀≄⍀\u242f╙♅❉⡙⥏⨩⭉ⱌⵒ⹌⽂〾ㄳ㈡");
		DataTable dataTable = a2147.a2105(a1344.a1271);
		ToolStripItem[] array = new ToolStripItem[dataTable.Rows.Count];
		for (int i = 0; i < dataTable.Rows.Count; i++)
		{
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(dataTable.Rows[i][0].ToString());
			toolStripMenuItem.Click += a480;
			toolStripMenuItem.Image = a2268.a2292;
			toolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			array[i] = toolStripMenuItem;
		}
		a464.DropDownItems.AddRange(array);
	}

	private void a480(object a478, EventArgs a479)
	{
		if (a440.RowCount > 0 && MessageBox.Show(a527("\u009eƧʵΩҢ\u05a9\u06e1\u07a9\u08cc\u09ca\u0ad8\u0bd8\u0cd2ಥ໐࿖პᇌንᏝᗬᗞᛔ\u17ddᣆᧃ\u1a8dᯋ\u1cce\u1dd8Ềᾈ\u20c3⅐⋋⍘◼╞⚁⟏⣳⧳⫼⯥⳺\u2df8⻰⿴ヾ㇤㊻㏘㑯㗦㛷㟵㣡㦮㫉㯥㳠㷡㻨㿼䃫䇯䊥䏫䓯䗷䛯䟵䠅䥐䩷䬥䰚䴞丘佘倎儗刅匙吒唙噑圙堜多娈嬈専屵帀弆怎愜扅挍攼攎昄服桿椷檺欵氵浺渀漹瀭灧爹牥琾畲皍眢砪示稤笯簢紹縠缱耫脣艥茭萱蔶蘨蜢衞襊詜謜豜赟軞轑遙酟鉏錚鐹镺陔靂饰饋驔魉鰋鵘鹈鸷ꁊꅃꉋꌄꑊꑽꙍꝅꡲꥻ\uaa3dꭸ걾구깸꽵뀷녳뉡덹둶땹똱띹롼륺멤뭵뱤뵸븩뽥쁲셵쉰썪쑶앸옾"), a527("PŽɢͰ\u0530"), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
		{
			ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)a478;
			int num = 0;
			a1344.a1307();
			a1344.a1271.CommandText = a527("\u001eĉȇ\u030fЊԜ٧ܒࠊऔ\u0a63୳ౡഉ\u0e7b༞ၻᅮቴ፷ᐙᕳᙶᝤᡡᥫ\u1a74᭠ᱤᵠḏό\u2065Ⅹ≹⍯␉╩♬❲⡬⥢⨞⬓Ⰱⵡ⹑⽚〽ㅗ㉚㍈㑍㕇㙐㝄㡀㥄㩌㭓㱕㵙㸲㽎䁆䅍䉙䍞䑖䕏䙕䝓䡕䥛䩂䭆䱈");
			a1344.a1271.Parameters.Add(a527("Fōə\u035eіՏ\u0655ݓࡕज़\u0a42\u0b46\u0c48"), SqlDbType.NVarChar).Value = toolStripMenuItem.Text;
			DataTable dataTable = a2147.a2105(a1344.a1271);
			if (dataTable.Rows.Count > 0)
			{
				num = Convert.ToInt32(dataTable.Rows[0][0]);
			}
			string text = a527("");
			for (int i = 0; i < a440.RowCount; i++)
			{
				text = text + a440.GetRowCellValue(i, a527("KŅ")).ToString() + a527("-");
			}
			text = text.Substring(0, text.Length - 1);
			a1344.a1307();
			a1344.a1271.CommandText = a527("aţɶͰѤժ؎ݦࡥॸ\u0a63\u0b65౭൵ฆ\u0f76ၡᅷሂ፪ᑡᕍᙊᝂᡛ᥉ᩏᭉ\u1c25ᵗṝὔ⁆ⅇ≍⍖⑂╚♞✭⡛⥃⩏⭛ⱍⴧ⹏⽁〤ㅊ㉌㌩") + text + a527("(");
			a1344.a1271.Parameters.Add(a527("Bŉɕ\u0352њՃ\u0651ݗࡑ"), SqlDbType.Int).Value = num;
			a1344.a1271.ExecuteNonQuery();
			a481();
		}
	}

	public void a481()
	{
		if (!a474)
		{
			return;
		}
		a459.SelectedIndex = a457.SelectedIndex;
		a456.SelectedIndex = a437.SelectedIndex;
		int focusedRowHandle = a440.FocusedRowHandle;
		a1344.a1307();
		a1344.a1271.CommandText = a527("\u0082ǲ\u02e5ϓӛמۈ\u07bbࣈ\u09d6\u0acf\u0bc8\u0cd8ව໙࿑თᇃኸᎦᒮᗂᛚ\u17ceᣘᦩ᪠ᯈ\u1cd4\u1dc1ềῑ₢⇃⋙⍟\u242a╌♒✺⠾⤪⨷⬮ⰷⴱ⹝⽓〡ㄸ㈢㌮㑂㔹㙝㝅㠣㤭㩄㬳㱗㵋㸰㼠䀩䄨䈭䌓䐗䔖䙰䜏䡫䥷䨙䬓䰅䴚不伒倖兽刄卾呠唆嘍圙堞备娇嬏尃崝幨弗恳慯戋捾摬敩晣杼桨楬橨欛氖浾湵潡灦煶牢獺瑾甐癸眙砄祢穩筵籲絺繣罱職腱艿荞葚蕔蘰蜻衃襌詓譚豓赇蹟轖遈鄬鈸鍜鑋镁陉靈類餩驉魃鱏鴥鹂齑ꁍꅌꈠꎦ꒫ꖶꚰꞾ\ua8b7\ua9bcꪧꮺ겳궧꺿꾶남뇑늧뎧뒫떿뚩럋뢣릭뫕뮳볗뷋뺽뾶삩솭슥쎒쒛얂욑잞좈즒쪝쮍첉출캐쿺탾톈튅펄풂했횁힎\ud895\ud984\uda8d\udb95\udc8d\udd80\ude9e\udf9c\ue08b\ue185\ue2ec\ue39f\ue4fc\ue5fc\ue6f7\ue7f2\ue8e3\ue9fc\uea94\uebe3\uecf7\uede7\ueefd\ueffb\uf0e1\uf1f0\uf2f1\uf3fb\uf482\uf5fe\uf6e3\uf7e5\uf8f5吝\ufafdﯴﳣ\ufdebﻻ￮ëǪ\u02f4Ϟӌ\u05b1۞ߗ\u08d5\u09d2\u0addப\u0cd5\u0dda\u0eda࿅თᇃዄᎧᓌᗄᛘឧᢢ\u19ca\u1ac9ᯔ᳃ᶥồΉ\u20c7⇏⊠⌫\u244f╓☾✷⠵⤲⨽⭊ⱑⵅ⹓⽓〦ㄹ㈵㌡㑎㕝㙌㜮㠦㤺㨭㭇㱗㵅㸡㼭䀦䅈䉉䍳䐟䔎䘗䜒䠞䤘䨇䬎䰓䴘丑优偲共刖匝吁唀噬圀堃多威嬋尃崗幤弗恳慡戌捺摸敩昜東桵楰橶欗汽浴湦潧灭煶牢獺瑾甍癸眙砊祦穦笇簎統縕缍聩腠色荋葁蕚虎蝎衊褤詌謥谸赜蹐輺進酆鉘鍊鑜镈阬靟頻餧驉魌鱒鵌鹂鼾ꀳꄡ");
		if (a457.Text != a527("MšɳͱѨ"))
		{
			SqlCommand a2269 = a1344.a1271;
			object commandText = a2269.CommandText;
			a2269.CommandText = string.Concat(commandText, a527(";śɗ\u035cзՂؤ\u073aࡊ\u0947ਗ਼ଡ଼\u0c4a\u0d43\u0e48ན၆ᅏቛፃᑂᕜᙚᝍᡇ\u193fᨦ"), Convert.ToInt32(a459.Text), a527("&"));
		}
		if (a437.Text != a527("MšɳͱѨ"))
		{
			SqlCommand a2270 = a1344.a1271;
			object commandText = a2270.CommandText;
			a2270.CommandText = string.Concat(commandText, a527(",ŊɄ\u034dШՓشܫࡍ\u0947\u0a3fଦ"), Convert.ToInt32(a456.Text), a527("&"));
		}
		a1344.a1271.CommandText += a527("5śɁ\u0356єՂد\u074cࡔब\u0a5f\u0b3bధ\u0d49ใཕ၊ᅝቂፆᐡ");
		DataTable dataSource = a2147.a2105(a1344.a1271);
		a439.DataSource = dataSource;
		try
		{
			a440.FocusedRowHandle = focusedRowHandle;
		}
		catch
		{
		}
	}

	public void a482()
	{
		if (a440.RowCount > 0 && MessageBox.Show(a527("\0Ģȹ\u033dЭԫأܫ\u0821भ\u0a62କ\u0cbc\u0d52พ\u0f76ၝᅉ\u124eፕᑙᕅᘖ\u1777ᡘᥜ\u1a59᭔ᰐᵪṊὄ\u2040ⅎ≉⍌⑃┋☆❡⡁⥕⩃⭌Ⰰⵚ\u2e6a⽰べㅰ㈺㈩㑫㕣㙳㝱㡽㠌㩻㭿㱹㵵㹫㼭䁉䅦䉣䍧䑥䕮䙵䝬䡪䥪䩸䬯"), a527("PŽɢͰ\u0530"), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
		{
			for (int i = 0; i < a440.RowCount; i++)
			{
				int num = Convert.ToInt32(a440.GetRowCellValue(i, a527("KŅ")));
				string text = a527("rŶɡ\u0365ѷէ\u0601ݫࡖ\u094d\u0a54\u0b50\u0c5e\u0d48\u0e39ཋၒᅂስፖᑟᕝᙚ\u1755ᠲ\u1929ᨼᬫ\u1c2bᵝṁὍ⁕⅃∥⍍⑇┿☦") + num + a527("&");
				a2147.a2128(a527(""), a527("Sŵɠ\u0362Ѷդ"));
			}
			a481();
		}
	}

	public void a483()
	{
		if (a440.RowCount > 0 && MessageBox.Show(a527("\0Ģȹ\u033dЭԫأܫ\u0821भ\u0a62କ\u0cbc\u0d52พ\u0f76ၝᅉ\u124eፕᑙᕅᘖ\u1774ᡟ᥇\u1a5b᭗ᰐᵪṊὄ\u2040ⅎ≉⍌⑃┋☆❡⡁⥕⩃⭌Ⰰⵚ\u2e6a⽰べㅰ㈺㈩㑫㕣㙳㝱㡽㠌㩻㭿㱹㵵㹫㼭䁉䅦䉣䍧䑥䕮䙵䝬䡪䥪䩸䬯"), a527("PŽɢͰ\u0530"), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
		{
			for (int i = 0; i < a440.RowCount; i++)
			{
				int num = Convert.ToInt32(a440.GetRowCellValue(i, a527("KŅ")));
				string text = a527("rŶɡ\u0365ѷէ\u0601ݫࡖ\u094d\u0a54\u0b50\u0c5e\u0d48\u0e39ཋၒᅂስፖᑟᕝᙚ\u1755ᠲ\u1929ᨽᬫ\u1c2bᵝṁὍ⁕⅃∥⍍⑇┿☦") + num + a527("&");
				a2147.a2128(a527(""), a527("Sŵɠ\u0362Ѷդ"));
			}
			a481();
		}
	}

	public void a485(bool a484)
	{
		if (a440.RowCount > 0 && MessageBox.Show(a527("ĜtɆ\u034cхՂ؆ݡࡁ\u0955\u0a43\u0b4c\u0c00൚\u0e6a\u0f70ၹᅰሺሩᑫᕣᙳ\u1771\u187d\u180c\u1a7b᭿ᱹᵵṫἭ⁉Ⅶ≣⍧⑥╮♵❬⡪⥪⩸⬯"), a527("PŽɢͰ\u0530"), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
		{
			a456.SelectedIndex = a437.SelectedIndex;
			a459.SelectedIndex = a457.SelectedIndex;
			int num = 0;
			num = (a484 ? 1 : 0);
			for (int i = 0; i < a440.RowCount; i++)
			{
				int num2 = Convert.ToInt32(a440.GetRowCellValue(i, a527("KŅ")));
				a2147.a2128(a527("tŰɛ\u035fщՙػݑࡐ\u094bਫ਼\u0b5a\u0c50\u0d46ำཁၔᅄሯፏᑞᕇᙂᝎᡈᥗ\u1a5e\u1b43᱈ᵁṈἿ…") + num + a527(",Īɞ\u0340тՔـܤࡊ\u0946\u0a3c") + num2 + a527("!"), a527("Sŵɠ\u0362Ѷդ"));
			}
			a481();
		}
	}

	public void a487(bool a486)
	{
		if (a440.RowCount > 0)
		{
			int num = Convert.ToInt32(a440.GetFocusedRowCellValue(a527("KŅ")).ToString());
			if (MessageBox.Show(a527("ĝsɇ\u034fфՍ؇ݢࡀ\u0952\u0a42\u0b4f\u0c01\u0d65\u0e6b\u0f73ၸᅷሻሪᑪᕬᙲ\u1772\u187c\u180b\u1a7a᭼ᱸᵪṪἮ⁈Ⅱ≢⍤␩╥♮❵⡬⥪⩪⭸ⰾ"), a527("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.Cancel)
			{
				int num2 = 0;
				num2 = (a486 ? 1 : 0);
				a2147.a2128(a527("tŰɛ\u035fщՙػݑࡐ\u094bਫ਼\u0b5a\u0c50\u0d46ำཁၔᅄሯፏᑞᕇᙂᝎᡈᥗ\u1a5e\u1b43᱈ᵁṈἿ…") + num2 + a527(",Īɞ\u0340тՔـܤࡊ\u0946\u0a3c") + num, a527("Sŵɠ\u0362Ѷդ"));
				a481();
			}
		}
	}

	public void a488()
	{
		if (a440.RowCount > 0)
		{
			int num = Convert.ToInt32(a440.GetFocusedRowCellValue(a527("KŅ")).ToString());
			if (MessageBox.Show(a527("\u0012ĥ\u02d8\u0357ёՕ؛ݱࡘ\u094a\u0a43ଖ\u0c74ൟ\u0e47ཛ\u1057ᄐቪፊᑄᕀᙎᝉᡌ\u1943ᨋᬆᱡᵁṕὃ⁌℀≚⍪⑰╹♰✺⤩⥫⩣⭳ⱱ\u2d7d⼌⽻みㅹ㉵㍫㐭㕉㙦㝣㡧㥥㩮㭵㱬㵪㹪㽸䀯"), a527("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.Cancel)
			{
				a2147.a2128(a527("sŵɠ\u0362Ѷդ\u0600ݔࡗ\u094e\u0a55\u0b57\u0c5f\u0d4b\u0e38ངၓᅁሴፑᑞᕞᙛᝊᠳ\u192aᨽᬬ\u1c2aᵞṀὂ\u2054⅀∤⍊⑆┼") + num, a527("Sŵɠ\u0362Ѷդ"));
				a481();
			}
		}
	}

	public void a489()
	{
		if (a440.RowCount > 0)
		{
			int num = Convert.ToInt32(a440.GetFocusedRowCellValue(a527("KŅ")).ToString());
			if (MessageBox.Show(a527("\u0012ĥ\u02d8\u0357ёՕ؛ݱࡘ\u094a\u0a43ଖ\u0c74ൟ\u0e47ཛ\u1057ᄐቪፊᑄᕀᙎᝉᡌ\u1943ᨋᬆᱡᵁṕὃ⁌℀≚⍪⑰╹♰✺⤩⥫⩣⭳ⱱ\u2d7d⼌⽻みㅹ㉵㍫㐭㕉㙦㝣㡧㥥㩮㭵㱬㵪㹪㽸䀯"), a527("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.Cancel)
			{
				a2147.a2128(a527("sŵɠ\u0362Ѷդ\u0600ݔࡗ\u094e\u0a55\u0b57\u0c5f\u0d4b\u0e38ངၓᅁሴፑᑞᕞᙛᝊᠳ\u192aᨼᬬ\u1c2aᵞṀὂ\u2054⅀∤⍊⑆┼") + num, a527("Sŵɠ\u0362Ѷդ"));
				a481();
			}
		}
	}

	private void a492(object a490, EventArgs a491)
	{
		Close();
	}

	private void a495(object a493, EventArgs a494)
	{
		a482();
	}

	private void a498(object a496, EventArgs a497)
	{
		a488();
	}

	private void a501(object a499, EventArgs a500)
	{
		a489();
	}

	private void a504(object a502, EventArgs a503)
	{
		a483();
	}

	private void a507(object a505, EventArgs a506)
	{
		a481();
	}

	private void a510(object a508, EventArgs a509)
	{
		a481();
	}

	private void a513(object a511, EventArgs a512)
	{
		a474 = true;
		a481();
	}

	private void a516(object a514, EventArgs a515)
	{
		a485(a484: true);
	}

	private void a519(object a517, EventArgs a518)
	{
		a485(a484: false);
	}

	private void a522(object a520, EventArgs a521)
	{
		a487(a486: true);
	}

	private void a525(object a523, EventArgs a524)
	{
		a487(a486: false);
	}

	private static string a527(string a526)
	{
		int length = a526.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a526[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
