using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

public class a1637 : XtraForm
{
	private IContainer a1511 = null;

	public GroupBox a1512;

	public Label a1513;

	public Label a1514;

	public Label a1515;

	public Label a1516;

	public Label a1517;

	public Label a1518;

	public Label a1519;

	public Label a1520;

	public TextBox a1521;

	public TextBox a1522;

	private GroupBox a1523;

	public Label a1524;

	public Button a1525;

	public Label a1526;

	public Label a1527;

	public Label a1528;

	public Label a1529;

	public TextBox a1530;

	public TextBox a1531;

	public TextBox a1532;

	public TextBox a1533;

	public Label a1534;

	public GridControl a1535;

	public GridView a1536;

	private GridColumn a1537;

	private GridColumn a1538;

	private GridColumn a1539;

	private GridColumn a1540;

	private GridColumn a1541;

	private GridColumn a1542;

	private GridColumn a1543;

	private GridColumn a1544;

	private GridColumn a1545;

	private GridColumn a1546;

	public System.Windows.Forms.ComboBox a1547;

	public System.Windows.Forms.ComboBox a1548;

	public System.Windows.Forms.ComboBox a1549;

	public System.Windows.Forms.ComboBox a1550;

	public ContextMenuStrip a1551;

	public ToolStripMenuItem a1552;

	private ToolStripMenuItem a1553;

	private GroupBox a1554;

	public TextBox a1555;

	public Label a1556;

	public TextBox a1557;

	public TextBox a1558;

	public Label a1559;

	public Label a1560;

	public Button a1561;

	private GridColumn a1562;

	private ToolStripMenuItem a1563;

	public Button a1564;

	public TextBox a1565;

	private ToolStripMenuItem a1566;

	private GridColumn a1567;

	public Button a1568;

	public System.Windows.Forms.ComboBox a1569;

	public Label a1570;

	public Label a1571;

	private GridColumn a1572;

	private GridColumn a1573;

	public TextBox a1574;

	private ToolStripMenuItem a1575;

	private ToolStripMenuItem a1576;

	private ToolStripMenuItem a1577;

	private GridColumn a1578;

	private RepositoryItemCheckEdit a1579;

	private long a1580 = 0L;

	protected override void Dispose(bool a1581)
	{
		if (a1581 && a1511 != null)
		{
			a1511.Dispose();
		}
		base.Dispose(a1581);
	}

	private void a1582()
	{
		a1511 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(a1637));
		a1512 = new GroupBox();
		a1571 = new Label();
		a1547 = new System.Windows.Forms.ComboBox();
		a1549 = new System.Windows.Forms.ComboBox();
		a1550 = new System.Windows.Forms.ComboBox();
		a1569 = new System.Windows.Forms.ComboBox();
		a1548 = new System.Windows.Forms.ComboBox();
		a1534 = new Label();
		a1568 = new Button();
		a1525 = new Button();
		a1564 = new Button();
		a1513 = new Label();
		a1514 = new Label();
		a1515 = new Label();
		a1526 = new Label();
		a1570 = new Label();
		a1524 = new Label();
		a1527 = new Label();
		a1516 = new Label();
		a1517 = new Label();
		a1528 = new Label();
		a1518 = new Label();
		a1529 = new Label();
		a1519 = new Label();
		a1530 = new TextBox();
		a1520 = new Label();
		a1531 = new TextBox();
		a1532 = new TextBox();
		a1533 = new TextBox();
		a1565 = new TextBox();
		a1521 = new TextBox();
		a1574 = new TextBox();
		a1522 = new TextBox();
		a1523 = new GroupBox();
		a1535 = new GridControl();
		a1551 = new ContextMenuStrip(a1511);
		a1552 = new ToolStripMenuItem();
		a1553 = new ToolStripMenuItem();
		a1566 = new ToolStripMenuItem();
		a1563 = new ToolStripMenuItem();
		a1575 = new ToolStripMenuItem();
		a1576 = new ToolStripMenuItem();
		a1577 = new ToolStripMenuItem();
		a1536 = new GridView();
		a1537 = new GridColumn();
		a1538 = new GridColumn();
		a1539 = new GridColumn();
		a1540 = new GridColumn();
		a1541 = new GridColumn();
		a1567 = new GridColumn();
		a1562 = new GridColumn();
		a1542 = new GridColumn();
		a1543 = new GridColumn();
		a1544 = new GridColumn();
		a1545 = new GridColumn();
		a1546 = new GridColumn();
		a1572 = new GridColumn();
		a1573 = new GridColumn();
		a1578 = new GridColumn();
		a1579 = new RepositoryItemCheckEdit();
		a1554 = new GroupBox();
		a1555 = new TextBox();
		a1556 = new Label();
		a1557 = new TextBox();
		a1558 = new TextBox();
		a1559 = new Label();
		a1560 = new Label();
		a1561 = new Button();
		a1512.SuspendLayout();
		a1523.SuspendLayout();
		((ISupportInitialize)a1535).BeginInit();
		a1551.SuspendLayout();
		((ISupportInitialize)a1536).BeginInit();
		((ISupportInitialize)a1579).BeginInit();
		a1554.SuspendLayout();
		SuspendLayout();
		a1512.Controls.Add(a1571);
		a1512.Controls.Add(a1547);
		a1512.Controls.Add(a1549);
		a1512.Controls.Add(a1550);
		a1512.Controls.Add(a1569);
		a1512.Controls.Add(a1548);
		a1512.Controls.Add(a1534);
		a1512.Controls.Add(a1568);
		a1512.Controls.Add(a1525);
		a1512.Controls.Add(a1564);
		a1512.Controls.Add(a1513);
		a1512.Controls.Add(a1514);
		a1512.Controls.Add(a1515);
		a1512.Controls.Add(a1526);
		a1512.Controls.Add(a1570);
		a1512.Controls.Add(a1524);
		a1512.Controls.Add(a1527);
		a1512.Controls.Add(a1516);
		a1512.Controls.Add(a1517);
		a1512.Controls.Add(a1528);
		a1512.Controls.Add(a1518);
		a1512.Controls.Add(a1529);
		a1512.Controls.Add(a1519);
		a1512.Controls.Add(a1530);
		a1512.Controls.Add(a1520);
		a1512.Controls.Add(a1531);
		a1512.Controls.Add(a1532);
		a1512.Controls.Add(a1533);
		a1512.Controls.Add(a1565);
		a1512.Controls.Add(a1521);
		a1512.Controls.Add(a1574);
		a1512.Controls.Add(a1522);
		a1512.Dock = DockStyle.Left;
		a1512.Location = new Point(0, 0);
		a1512.Name = a1636("nźɨͳѵՆ٬ݺ࠰");
		a1512.Size = new Size(368, 635);
		a1512.TabIndex = 0;
		a1512.TabStop = false;
		a1512.Text = a1636("EŬɾͿЪՋ١ݫࡡ६੨୦\u0c70൨");
		a1571.AutoSize = true;
		a1571.Location = new Point(12, 239);
		a1571.Name = a1636("kŧɧ\u0361ѯԳظ");
		a1571.Size = new Size(72, 13);
		a1571.TabIndex = 63;
		a1571.Text = a1636("A ɾȾѨԭأܫࡍॠ\u0a7a୮൙ഥ\u0e5dาၮ\u1030");
		a1547.DropDownStyle = ComboBoxStyle.DropDownList;
		a1547.Font = new Font(a1636("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1547.FormattingEnabled = true;
		a1547.Location = new Point(427, 142);
		a1547.Name = a1636("oũɁ\u0368Ѻճفݷࡱॳ\u0a4b\u0b45");
		a1547.Size = new Size(34, 26);
		a1547.TabIndex = 62;
		a1549.DropDownStyle = ComboBoxStyle.DropDownList;
		a1549.Font = new Font(a1636("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1549.FormattingEnabled = true;
		a1549.Location = new Point(427, 110);
		a1549.Name = a1636("můɕ;ѡե٭ݪࡣ\u0948\u0a61ୱ\u0c4b\u0d45");
		a1549.Size = new Size(34, 26);
		a1549.TabIndex = 62;
		a1550.DropDownStyle = ComboBoxStyle.DropDownList;
		a1550.Font = new Font(a1636("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1550.FormattingEnabled = true;
		a1550.Location = new Point(118, 139);
		a1550.Name = a1636("oũɓͼѣի٣ݨࡡ\u094e੧୳");
		a1550.Size = new Size(244, 26);
		a1550.TabIndex = 4;
		a1569.Font = new Font(a1636("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1569.FormattingEnabled = true;
		a1569.Location = new Point(118, 201);
		a1569.Name = a1636("dŤɇ\u036bѯշ٬");
		a1569.Size = new Size(244, 26);
		a1569.TabIndex = 6;
		a1548.DropDownStyle = ComboBoxStyle.DropDownList;
		a1548.Font = new Font(a1636("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1548.FormattingEnabled = true;
		a1548.Location = new Point(118, 170);
		a1548.Name = a1636("iūɃ\u0366Ѵձكݱࡷॱ");
		a1548.Size = new Size(244, 26);
		a1548.TabIndex = 5;
		a1534.BackColor = Color.FromArgb(128, 255, 128);
		a1534.BorderStyle = BorderStyle.Fixed3D;
		a1534.FlatStyle = FlatStyle.Flat;
		a1534.Location = new Point(8, 416);
		a1534.Name = a1636("kŧɧ\u0361ѯԳص");
		a1534.Size = new Size(360, 3);
		a1534.TabIndex = 57;
		a1568.Image = a2268.a2294;
		a1568.ImageAlign = ContentAlignment.MiddleLeft;
		a1568.Location = new Point(144, 462);
		a1568.Name = a1636("eųɱͰѬլس");
		a1568.Size = new Size(219, 37);
		a1568.TabIndex = 13;
		a1568.Text = a1636("Oǻɨ\u0366ѡկٮݤ");
		a1568.UseVisualStyleBackColor = true;
		a1568.Click += a1628;
		a1525.Image = a2268.a2286;
		a1525.ImageAlign = ContentAlignment.MiddleLeft;
		a1525.Location = new Point(144, 424);
		a1525.Name = a1636("eųɱͰѬլذ");
		a1525.Size = new Size(219, 37);
		a1525.TabIndex = 12;
		a1525.Text = a1636("SŬɦ\u036eЦՎ٥ݺळॵ");
		a1525.UseVisualStyleBackColor = true;
		a1525.Click += a1595;
		a1564.Image = a2268.a2289;
		a1564.ImageAlign = ContentAlignment.MiddleLeft;
		a1564.Location = new Point(326, 107);
		a1564.Name = a1636("kżɩ\u034dѤնٷ\u074c\u086e");
		a1564.Size = new Size(37, 28);
		a1564.TabIndex = 3;
		a1564.UseVisualStyleBackColor = true;
		a1564.Click += a1619;
		a1513.AutoSize = true;
		a1513.Font = new Font(a1636("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a1513.Location = new Point(7, 501);
		a1513.Name = a1636("jŤɦ\u0366Ѯ\u0530");
		a1513.Size = new Size(43, 13);
		a1513.TabIndex = 55;
		a1513.Text = a1636("RſɤͶԲԢػ");
		a1514.BackColor = Color.FromArgb(128, 255, 128);
		a1514.BorderStyle = BorderStyle.Fixed3D;
		a1514.FlatStyle = FlatStyle.Flat;
		a1514.Location = new Point(8, 272);
		a1514.Name = a1636("kŧɧ\u0361ѯԳز");
		a1514.Size = new Size(360, 3);
		a1514.TabIndex = 54;
		a1515.AutoSize = true;
		a1515.Font = new Font(a1636("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a1515.Location = new Point(6, 22);
		a1515.Name = a1636("jŤɦ\u0366ѮԹ");
		a1515.Size = new Size(211, 13);
		a1515.TabIndex = 51;
		a1515.Text = a1636("mńɖ\u0357Ђժفݦय३\u0a3c\u0bcdഅ൫\u0e7d\u0f79ၵᅼሻፃᑷᕣᙣᝠᡠᥨ\u1a60ᬫ\u1c2aᵋṡὫ\u2061Ⅼ≨⍦⑰╨");
		a1526.AutoSize = true;
		a1526.Location = new Point(12, 381);
		a1526.Name = a1636("kŧɧ\u0361ѯԳس");
		a1526.Size = new Size(55, 13);
		a1526.TabIndex = 49;
		a1526.Text = a1636("AŨɺͳЦՇ٨ݬࡩ।");
		a1570.AutoSize = true;
		a1570.Location = new Point(12, 208);
		a1570.Name = a1636("kŧɧ\u0361ѯԳع");
		a1570.Size = new Size(35, 13);
		a1570.TabIndex = 49;
		a1570.Text = a1636("GǲɯϾѬ");
		a1524.AutoSize = true;
		a1524.Location = new Point(12, 177);
		a1524.Name = a1636("jŤɦ\u0366ѮԸ");
		a1524.Size = new Size(59, 13);
		a1524.TabIndex = 49;
		a1524.Text = a1636("AŨɺͳЦՂٶݶࡠॴ");
		a1527.AutoSize = true;
		a1527.Location = new Point(12, 351);
		a1527.Name = a1636("kŧɧ\u0361ѯԳذ");
		a1527.Size = new Size(90, 13);
		a1527.TabIndex = 49;
		a1527.Text = a1636("CŠɠ\u032dш\u05f7ݕݬࡦध\u0a4b୬౯൷\u0e63\u0f73");
		a1516.AutoSize = true;
		a1516.Enabled = false;
		a1516.Location = new Point(12, 146);
		a1516.Name = a1636("jŤɦ\u0366ѮԶ");
		a1516.Size = new Size(85, 13);
		a1516.TabIndex = 49;
		a1516.Text = a1636("Vǲɦ\u0360Ѯէ٬ܨࡊ\u0963\u0a77୯౦൸\u0e68");
		a1517.AutoSize = true;
		a1517.Location = new Point(4, 517);
		a1517.Name = a1636("jŤɦ\u0366ѮԵ");
		a1517.Size = new Size(347, 52);
		a1517.TabIndex = 49;
		a1517.Text = componentResourceManager.GetString(a1636("gūɫ\u036dѫԲثݐࡦॺ\u0a75"));
		a1528.AutoSize = true;
		a1528.Location = new Point(12, 321);
		a1528.Name = a1636("kŧɧ\u0361ѯԳر");
		a1528.Size = new Size(84, 13);
		a1528.TabIndex = 49;
		a1528.Text = a1636("CŠɠ\u032dјժٸݠࡠध\u0a29ଥ\u0c57\u0d62\u0e63\u0f75");
		a1518.AutoSize = true;
		a1518.Location = new Point(12, 115);
		a1518.Name = a1636("jŤɦ\u0366ѮԲ");
		a1518.Size = new Size(74, 13);
		a1518.TabIndex = 49;
		a1518.Text = a1636("Fŭɹ;ЩՆٲݫࡤॶ\u0a62ୱര");
		a1529.AutoSize = true;
		a1529.Location = new Point(12, 291);
		a1529.Name = a1636("jŤɦ\u0366ѮԴ");
		a1529.Size = new Size(38, 13);
		a1529.TabIndex = 49;
		a1529.Text = a1636("DŤɯ\u036aѻդ");
		a1519.AutoSize = true;
		a1519.Location = new Point(12, 84);
		a1519.Name = a1636("jŤɦ\u0366ѮԳ");
		a1519.Size = new Size(57, 13);
		a1519.TabIndex = 49;
		a1519.Text = a1636("Kŭ\u0339\u0327ѕժٽݢࡦ࠰");
		a1530.Enabled = false;
		a1530.Font = new Font(a1636("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a1530.Location = new Point(118, 376);
		a1530.Name = a1636("|Ţɾͱцլٺ\u0734");
		a1530.Size = new Size(244, 26);
		a1530.TabIndex = 11;
		a1520.AutoSize = true;
		a1520.Location = new Point(12, 53);
		a1520.Name = a1636("jŤɦ\u0366ѮԷ");
		a1520.Size = new Size(93, 13);
		a1520.TabIndex = 49;
		a1520.Text = a1636("FĿɓ\u032fхդ١ݧࡣ\u0962ਨ\u0b49\u0c73൨\u0e76ར\u1071\u1030");
		a1531.Enabled = false;
		a1531.Font = new Font(a1636("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a1531.Location = new Point(118, 345);
		a1531.Name = a1636("|Ţɾͱцլٺ\u0735");
		a1531.Size = new Size(244, 26);
		a1531.TabIndex = 10;
		a1532.Enabled = false;
		a1532.Font = new Font(a1636("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a1532.Location = new Point(118, 314);
		a1532.Name = a1636("|Ţɾͱцլٺ\u0732");
		a1532.Size = new Size(244, 26);
		a1532.TabIndex = 9;
		a1533.Enabled = false;
		a1533.Font = new Font(a1636("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a1533.Location = new Point(118, 283);
		a1533.Name = a1636("|Ţɾͱцլٺ\u0733");
		a1533.Size = new Size(244, 26);
		a1533.TabIndex = 8;
		a1565.Enabled = false;
		a1565.Font = new Font(a1636("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a1565.Location = new Point(118, 108);
		a1565.MaxLength = 8;
		a1565.Name = a1636("}Űɳ\u034dѤնٷ\u074c\u086e");
		a1565.Size = new Size(207, 26);
		a1565.TabIndex = 2;
		a1521.Font = new Font(a1636("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a1521.Location = new Point(118, 77);
		a1521.MaxLength = 40;
		a1521.Name = a1636("xųɾ\u0348Ѭծ\u0655ݪࡽ\u0962੦୨");
		a1521.Size = new Size(244, 26);
		a1521.TabIndex = 1;
		a1574.Font = new Font(a1636("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a1574.Location = new Point(118, 232);
		a1574.MaxLength = 4;
		a1574.Name = a1636("xųɾ\u034eѡյٯݶ\u085d४੮୨");
		a1574.Size = new Size(57, 26);
		a1574.TabIndex = 7;
		a1574.Text = a1636("6ĳȳ\u0334");
		a1574.KeyPress += a1622;
		a1522.Font = new Font(a1636("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a1522.Location = new Point(118, 46);
		a1522.MaxLength = 11;
		a1522.Name = a1636("sžɱ\u0350рՌٮ");
		a1522.Size = new Size(244, 26);
		a1522.TabIndex = 0;
		a1522.KeyPress += a1622;
		a1523.BackColor = Color.Transparent;
		a1523.Controls.Add(a1535);
		a1523.Dock = DockStyle.Fill;
		a1523.Location = new Point(368, 45);
		a1523.Name = a1636("nźɨͳѵՆ٬ݺ࠳");
		a1523.Size = new Size(892, 590);
		a1523.TabIndex = 3;
		a1523.TabStop = false;
		a1523.Text = a1636("GŪɸͽШՋٯݶࡰ०\u0a71୨");
		a1535.ContextMenuStrip = a1551;
		a1535.Dock = DockStyle.Fill;
		a1535.EmbeddedNavigator.Name = a1636("");
		a1535.Font = new Font(a1636("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1535.Location = new Point(3, 17);
		a1535.LookAndFeel.SkinName = a1636("GżɻͳѯՖ٭ݨ\u086b९");
		a1535.LookAndFeel.UseDefaultLookAndFeel = false;
		a1535.MainView = a1536;
		a1535.Name = a1636("kŹɣ\u036dыը٨ݱࡶ६੮ର");
		a1535.RepositoryItems.AddRange(new RepositoryItem[1] { a1579 });
		a1535.Size = new Size(886, 570);
		a1535.TabIndex = 0;
		a1535.ViewCollection.AddRange(new BaseView[1] { a1536 });
		a1535.DoubleClick += a1613;
		a1551.Items.AddRange(new ToolStripItem[5] { a1552, a1553, a1566, a1563, a1575 });
		a1551.Name = a1636("rſɡͺѨմٿ\u0747\u086c०ੲ\u0b55\u0c71൶\u0e6a\u0f72\u1030");
		a1551.Size = new Size(230, 194);
		a1552.Image = a2268.a2342;
		a1552.ImageScaling = ToolStripItemImageScaling.None;
		a1552.Name = a1636("gźɾ\u0345ѿՠ٢ݞࡸॹ\u0a63\u0b79\u0c45\u0d62\u0e68\u0f70၍ᅷቧ፬");
		a1552.Size = new Size(229, 38);
		a1552.Text = a1636("EŬɾͿԻԩيݫࡩ८\u0a61ଣ\u0c47൵");
		a1552.Click += a1601;
		a1553.Image = a2268.a2314;
		a1553.ImageScaling = ToolStripItemImageScaling.None;
		a1553.Name = a1636("vŽɩ\u036eԨՙټݢࡼॲ\u0a56୦\u0c45ൿ\u0e60ར\u105eᅸቹ፣ᑹᕅᙢᝨᡰ᥍\u1a77᭧ᱬ");
		a1553.Size = new Size(229, 38);
		a1553.Text = a1636("EŬɾͿԻԩىݬࡲ६\u0a62ଣ\u0c47൵");
		a1553.Click += a1604;
		a1566.Image = a2268.a2289;
		a1566.ImageScaling = ToolStripItemImageScaling.None;
		a1566.Name = a1636("użɥ\u036fԫ՞\u06e4ݹࡵ॰\u0a78\u0b7f౷\u0d45\u0e7fའ\u1062ᅞቸ፹ᑣᕹᙅᝢᡨᥰᩍ᭷ᱧᵬ");
		a1566.Size = new Size(229, 38);
		a1566.Text = a1636("EŬɵ\u036fԻԩ\u064f\u07fbࡨ०\u0a61୯౮\u0d64");
		a1566.Click += a1625;
		a1563.Image = a2268.a2341;
		a1563.ImageScaling = ToolStripItemImageScaling.None;
		a1563.Name = a1636("rŹɮͲԤՇٺݾࡅॿ\u0a60\u0b62\u0c5e൸\u0e79ལၹᅅቢ፨ᑰᕍᙷᝧᡬ");
		a1563.Size = new Size(229, 38);
		a1563.Text = a1636("Bũɾ\u0362ԴԤ\u0650ݫ\u086d");
		a1563.Click += a1616;
		a1575.DropDownItems.AddRange(new ToolStripItem[2] { a1576, a1577 });
		a1575.Image = a2268.a2279;
		a1575.ImageScaling = ToolStripItemImageScaling.None;
		a1575.Name = a1636("GŖɏȒцՀٹݺࡳॸ\u0a77\u0b4e\u0c63ൾ\u0e6d\u0f7bၷᅸት፠ᔣᕅᙿᝠᡢᥞ\u1a78᭹ᱣᵹṅὢ\u2068ⅰ≍⍷⑧╬");
		a1575.Size = new Size(229, 38);
		a1575.Text = a1636("Vťɾȥѷճر\u0749ࡪ\u0963੨୧ఫൟ\u0e70\u0f6f\u1072ᅪቤ፩ᑢᕱᜰ");
		a1576.Image = a2268.a2296;
		a1576.ImageScaling = ToolStripItemImageScaling.None;
		a1576.Name = a1636("eźɨ\u0378Ѫջٷݻࡧ\u0822\u0a7c\u0b45౿ൠ\u0e62ཞၸᅹባ፹ᑅᕢᙨᝰᡍ\u1977\u1a67\u1b6c");
		a1576.Size = new Size(165, 38);
		a1576.Text = a1636("Rūɻ\u0369ѵժ٤ݪࡰ࠳੯");
		a1576.Click += a1634;
		a1577.Image = a2268.a2297;
		a1577.ImageScaling = ToolStripItemImageScaling.None;
		a1577.Name = a1636("gżɮͺѨյٹݹࡻॴ੧ਢ౼\u0d45\u0e7fའ\u1062ᅞቸ፹ᑣᕹᙅᝢᡨᥰᩍ᭷ᱧᵬ");
		a1577.Size = new Size(165, 38);
		a1577.Text = a1636("Tŭɹ\u036bѻդ٦ݨࡨ॥\u0a70ਲ਼౯");
		a1577.Click += a1631;
		a1536.BorderStyle = BorderStyles.NoBorder;
		a1536.Columns.AddRange(new GridColumn[15]
		{
			a1537, a1538, a1539, a1540, a1541, a1567, a1562, a1542, a1543, a1544,
			a1545, a1546, a1572, a1573, a1578
		});
		a1536.FocusRectStyle = DrawFocusRectStyle.RowFocus;
		a1536.GridControl = a1535;
		a1536.Name = a1636("nźɮ\u0362ѓխ٦ݵ࠰");
		a1536.OptionsBehavior.Editable = false;
		a1536.OptionsFilter.AllowFilterEditor = false;
		a1536.OptionsView.ShowGroupPanel = false;
		a1537.Caption = a1636("KŅ");
		a1537.FieldName = a1636("KŅ");
		a1537.Name = a1636("lŸɠ\u036cфթ٩ݱ\u086e६ਰ");
		a1538.Caption = a1636("QŇȣ\u034cѮ");
		a1538.FieldName = a1636("\\ńɍ\u034cщՏ\u064b\u074a");
		a1538.Name = a1636("lŸɠ\u036cфթ٩ݱ\u086e६ਲ਼");
		a1538.Visible = true;
		a1538.VisibleIndex = 0;
		a1538.Width = 108;
		a1539.Caption = a1636("IţȦ\u0356ѫպ٣ݥ");
		a1539.FieldName = a1636("Fłɖ\u034bњՃم");
		a1539.Name = a1636("lŸɠ\u036cфթ٩ݱ\u086e६ਲ");
		a1539.Visible = true;
		a1539.VisibleIndex = 1;
		a1539.Width = 185;
		a1540.Caption = a1636("LŧɷͰУՌٮ");
		a1540.FieldName = a1636("Bŉɕ\u0352ыՋ\u064b\u0747\u0859");
		a1540.Name = a1636("lŸɠ\u036cфթ٩ݱ\u086e६ਵ");
		a1540.Visible = true;
		a1540.VisibleIndex = 2;
		a1540.Width = 83;
		a1541.Caption = a1636("AŨɺͳЦՂٶݶࡠॴ");
		a1541.FieldName = a1636("Cņɔ\u0351уՑ\u0657ݑ");
		a1541.Name = a1636("lŸɠ\u036cфթ٩ݱ\u086e६\u0a34");
		a1541.Visible = true;
		a1541.VisibleIndex = 3;
		a1541.Width = 171;
		a1567.Caption = a1636("AŨɺͳсշٱݳࡋ\u0945");
		a1567.FieldName = a1636("Bŉɕ\u0352њՃ\u0651ݗࡑ");
		a1567.Name = a1636("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଳ");
		a1562.Caption = a1636("Ełɔ\u034eсՙ\u064b\u0745");
		a1562.FieldName = a1636("HŅɄ\u0342шՁ\u064eݕࡄ\u094d\u0a55\u0b4d\u0c40൞\u0e5cཋ၅");
		a1562.Name = a1636("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ର");
		a1542.Caption = a1636("KŠɶ\u0368ѧջ");
		a1542.FieldName = a1636("PŝɌ\u034bрՖو\u0747\u085b");
		a1542.Name = a1636("lŸɠ\u036cфթ٩ݱ\u086e६\u0a37");
		a1542.Visible = true;
		a1542.VisibleIndex = 4;
		a1542.Width = 126;
		a1543.Caption = a1636("DŤɯ\u036aѻդ");
		a1543.FieldName = a1636("Dńɏ\u034aћՄ");
		a1543.Name = a1636("lŸɠ\u036cфթ٩ݱ\u086e६ਸ਼");
		a1543.Width = 71;
		a1544.Caption = a1636("XŪɸ\u0360Ѡԧةܥࡗ\u0962\u0a63୵");
		a1544.FieldName = a1636("]ŉɕ\u034fэ\u0557ق\u0743ࡕ");
		a1544.Name = a1636("lŸɠ\u036cфթ٩ݱ\u086e६ਹ");
		a1544.Width = 87;
		a1545.Caption = a1636("XĤɍ\u0332ЧՋ٬ݯࡷ\u0963ੳ");
		a1545.FieldName = a1636("Cŀɀ\u0352ш՞\u0659\u074cࡆक़\u0a4b\u0b4c\u0c4f\u0d57ใན");
		a1545.Name = a1636("lŸɠ\u036cфթ٩ݱ\u086e६ਸ");
		a1545.Width = 73;
		a1546.AppearanceHeader.Options.UseTextOptions = true;
		a1546.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
		a1546.Caption = a1636("GŨɬ\u0369Ѥ");
		a1546.FieldName = a1636("GňɌ\u0349ф");
		a1546.Name = a1636("kŹɣ\u036dыը٪ݰࡩ७ਲ਼\u0b31");
		a1546.Visible = true;
		a1546.VisibleIndex = 6;
		a1546.Width = 56;
		a1572.Caption = a1636("GǲɯϾѬ");
		a1572.FieldName = a1636("Gŋɏ\u0357ь");
		a1572.Name = a1636("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଲ");
		a1572.Visible = true;
		a1572.VisibleIndex = 5;
		a1572.Width = 118;
		a1573.Caption = a1636("V5ɭȳѧ");
		a1573.FieldName = a1636("Vōɍ\u034bч");
		a1573.Name = a1636("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଵ");
		a1578.Caption = a1636("JŹɢ\u0361ѣէإݝ\u082d\u0957ਯ");
		a1578.ColumnEdit = a1579;
		a1578.FieldName = a1636("MŘɁ\u0340ьՆ\u0659ݜࡁ\u094e\u0a47\u0b4a");
		a1578.Name = a1636("kŹɣ\u036dыը٪ݰࡩ७ਲ਼\u0b34");
		a1578.OptionsColumn.AllowEdit = false;
		a1578.Visible = true;
		a1578.VisibleIndex = 7;
		a1579.AutoHeight = false;
		a1579.Name = a1636("jŲɦͺѧպ٦ݾࡢॶ\u0a47\u0b79౩൦\u0e49ཡ\u106dᅤቭፀᑠᕪᙶᜰ");
		a1579.ValueChecked = 1;
		a1579.ValueUnchecked = 0;
		a1554.Controls.Add(a1555);
		a1554.Controls.Add(a1556);
		a1554.Controls.Add(a1557);
		a1554.Controls.Add(a1558);
		a1554.Controls.Add(a1559);
		a1554.Controls.Add(a1560);
		a1554.Controls.Add(a1561);
		a1554.Dock = DockStyle.Top;
		a1554.Location = new Point(368, 0);
		a1554.Name = a1636("nźɨͳѵՆ٬ݺ࠲");
		a1554.Size = new Size(892, 45);
		a1554.TabIndex = 2;
		a1554.TabStop = false;
		a1554.Text = a1636("Mţɥ\u0361ѳմ٠ݨࡦ९\u0a64");
		a1555.Font = new Font(a1636("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 15.75f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1555.Location = new Point(115, 11);
		a1555.MaxLength = 11;
		a1555.Name = a1636("|ſɲ\u0351ѧՍ٭\u0740");
		a1555.Size = new Size(164, 31);
		a1555.TabIndex = 0;
		a1555.TextChanged += a1607;
		a1555.KeyPress += a1622;
		a1556.AutoSize = true;
		a1556.Location = new Point(11, 20);
		a1556.Name = a1636("kŧɧ\u0361ѯԳش");
		a1556.Size = new Size(93, 13);
		a1556.TabIndex = 49;
		a1556.Text = a1636("FĿɓ\u032fхդ١ݧࡣ\u0962ਨ\u0b49\u0c73൨\u0e76ར\u1071\u1030");
		a1557.Font = new Font(a1636("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 15.75f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1557.Location = new Point(627, 11);
		a1557.MaxLength = 100;
		a1557.Name = a1636("~űɼ\u034cѧշ\u0670ݍ\u086d\u0940");
		a1557.Size = new Size(162, 31);
		a1557.TabIndex = 2;
		a1557.TextChanged += a1607;
		a1558.Font = new Font(a1636("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 15.75f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1558.Location = new Point(358, 11);
		a1558.MaxLength = 100;
		a1558.Name = a1636("yŴɿ\u034bѭա\u0654ݩࡼ॥੧୫\u0c40");
		a1558.Size = new Size(173, 31);
		a1558.TabIndex = 1;
		a1558.TextChanged += a1607;
		a1559.AutoSize = true;
		a1559.Location = new Point(290, 20);
		a1559.Name = a1636("kŧɧ\u0361ѯԳط");
		a1559.Size = new Size(57, 13);
		a1559.TabIndex = 49;
		a1559.Text = a1636("Kŭ\u0339\u0327ѕժٽݢࡦ࠰");
		a1560.AutoSize = true;
		a1560.Location = new Point(542, 20);
		a1560.Name = a1636("kŧɧ\u0361ѯԳض");
		a1560.Size = new Size(74, 13);
		a1560.TabIndex = 49;
		a1560.Text = a1636("Fŭɹ;ЩՆٲݫࡤॶ\u0a62ୱര");
		a1561.Image = a2268.a2305;
		a1561.ImageAlign = ContentAlignment.MiddleLeft;
		a1561.Location = new Point(789, 10);
		a1561.Name = a1636("dűɪ\u0342Ѱՠ");
		a1561.Size = new Size(43, 33);
		a1561.TabIndex = 3;
		a1561.UseVisualStyleBackColor = true;
		a1561.Click += a1610;
		Appearance.BackColor = Color.White;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1260, 635);
		Controls.Add(a1523);
		Controls.Add(a1554);
		Controls.Add(a1512);
		MaximizeBox = false;
		MaximumSize = new Size(1276, 674);
		Name = a1636("JŹɧ\u0342ѩյٲݎࡥॺ੫୵");
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a1636("AŨɺͳЦՎ٥ݺळॵ");
		a1512.ResumeLayout(performLayout: false);
		a1512.PerformLayout();
		a1523.ResumeLayout(performLayout: false);
		((ISupportInitialize)a1535).EndInit();
		a1551.ResumeLayout(performLayout: false);
		((ISupportInitialize)a1536).EndInit();
		((ISupportInitialize)a1579).EndInit();
		a1554.ResumeLayout(performLayout: false);
		a1554.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	public a1637()
	{
		a1582();
		a1984.a1891(this);
		a1574.Text = DateTime.Now.Year.ToString();
		a1984.a1964(a1636("pŧɭ\u0365ќՊؽݘࡒ\u0949\u0a4d\u0b51ౙൕแ༼ၑᅝቝፅᑂᔧᘭᝊᡙ᥅ᩄᬨ\u1c4cᵏṖὍ⁏ⅇ≓"), a1569);
		a1569.Items.Remove(a1636(""));
		a1984.a1964(a1636("rťɓ\u035bўՈػݓ\u085dऴ\u0a56\u0b52\u0c5cഴ๕ཀ\u105eᅝሯፗᑘᕇᙇᝏᡄ᥍\u1a58ᭋ᱀ᵖṈ\u1f47⁛"), a1549, a1550);
		a1984.a1964(a1636("gŶɾʹѳջ؎ݤࡨइ\u0a61୨౺൳\u0e79རၶᅶቲ\u137eᑡᕛᙗ\u173dᡚ᥉\u1a55᭔\u1c38ᵜṗ\u1f47\u2040⅌≕⍃⑅╟☮❚⡄⥎⩘⭌Ⱘⵆ⹍⽑きㅅ㈿㌰"), a1547, a1548);
		a1549.SelectedIndex = a1549.Items.IndexOf(a1344.a1272.ToString());
		if (a1549.SelectedIndex != -1)
		{
			a1550.SelectedIndex = a1549.SelectedIndex;
		}
		a1583();
		if (a1344.a1285)
		{
			a1550.Enabled = true;
			a1565.Enabled = true;
		}
		else
		{
			a1550.Enabled = false;
			a1565.Enabled = false;
		}
	}

	public void a1583()
	{
		int focusedRowHandle = a1536.FocusedRowHandle;
		a1344.a1307();
		a1344.a1271.CommandText = a1636("\u00a0ĬȻ\u0331йԸخݙ\u082cसਦ\u0b55\u0c46\u0d43โད\u1039ᄫቂጹᐯᔠᘣᜤᠤ\u192eᨭᭉ\u1c25ᴧḱἮ‹℞√⍱␗┚☈✍⠖⤘⨞⬐Ⰼ\u2d7f⸙⼐。ㄛ㈑㌊㐞㔞㘚㝥㡨㤌㨇㬗㰐㴄㸐㼔䀐䄂䈖䍮䑹䕷䙿䝺䡬䤗䩽䭴䱦䵧乭佶偢兺剾卲呭啯噣圉塮奵婩孨射嵨幣彳恴慀扙捏摉敋昺李桐楒橄歐水浘湓潃灄煐牉獟瑙畛瘤着硌示穒笴簪絈繃罓联膠芹莯蒩薫蛓蟕裘覮誣设貹趶躠辺邵醵鋓鏅钿閮隦鞬颫馳髆鮤鲠鶪黂龧ꂲꆐꊓꏽꒅꖎꚑꞕꢝꦚꪓꮊ겙궖꺀꾚낕놕닮뎚뒄떎뚘람루릎몂미벐뷲뻬뾘삕쇴싲쏸쓱엾웥쟴죽짥쫽쯰쳮췬컻쿵킙톃틷폸퓧헧훯ퟤ\ud8ed\ud9f8\udaeb\udbe0\udcf6\udde8\udee7\udffb\ue0ff\ue1d6\ue2da\ue3b1\ue4bc\ue5d9\ue6db\ue7d2\ue8d1\ue9ce\uead3\uebb9\uecc0\uedd2\ueec0\uefd8\uf0d8\uf1dc\uf2cf\uf3cc\uf4d8\uf5a7\uf6d9\uf7c6\uf8c6律輸\ufbd0ﳗﷆﻌ\uffdeÍĶȵ\u0329нԩ\u0656\u073b࠴स\u0a3dର\u0c49ര\u0e3d\u0f3fဦᄪሼጹᑄᔩᘣ\u173dᡄ᥏ᨥᬤ\u1c37ᴦṂἶ\u2028ℚ∐⍽␈╪♴✛⠔⤘⨝⬐Ⱪ\u2d74\u2e62⽶ばㄛ㈆㌈㐂㕫㙺㝩㠍㤋㨕㬀㱤㵲㹢㼄䀎䅻䈗䌔䐐䔛䙸䝶䡴䥢䩻䬙䱧䵺乼佸偶儃副卾呧啢噮坨塷奾婣孨屡嵨市彧恲慐打挽摗敒晉材桔楒橄欵汀洢渲潆灘煊牜獈琬畟瘻眧硉祌穒筌籂紾縳缡");
		if (a1344.a1272 != 0)
		{
			SqlCommand a2269 = a1344.a1271;
			object commandText = a2269.CommandText;
			a2269.CommandText = string.Concat(commandText, a1636(";śɗ\u035cзՂؤ\u073aࡊ\u0947ਗ਼ଡ଼\u0c4a\u0d43\u0e48ན၆ᅏቛፃᑂᕜᙚᝍᡇ\u193fᨦ"), a1344.a1272, a1636("&"));
		}
		if (a1555.Text != a1636(""))
		{
			SqlCommand a2270 = a1344.a1271;
			a2270.CommandText = a2270.CommandText + a1636("8Ŗɘ\u0351дՇأ\u073fࡄ\u094c\u0a45\u0b44\u0c41\u0d47ใགဨᅋ\u124fፎᑁᔣᘥᜤ") + a1555.Text + a1636("&ĥȡ");
		}
		if (a1558.Text != a1636(""))
		{
			SqlCommand a2271 = a1344.a1271;
			a2271.CommandText = a2271.CommandText + a1636("7ŗɛ\u0350гՆؠ\u073eࡎ\u094aਫ਼\u0b43\u0c52\u0d4b\u0e4d༨။ᅏ\u124eፁᐣᔥᘤ") + a1558.Text + a1636("&ĥȡ");
		}
		if (a1557.Text != a1636(""))
		{
			SqlCommand a2272 = a1344.a1271;
			a2272.CommandText = a2272.CommandText + a1636("9řə\u0352еՀآ\u073c\u085a\u0951\u0a5d\u0b5a\u0c43\u0d43ใཏၑᄨቋፏᑎᕁᘣᜥᠤ") + a1557.Text + a1636("&ĥȡ");
		}
		a1344.a1271.CommandText += a1636("2Şɂ\u034bы՟ج\u0749ࡓऩ\u0a41\u0b43ద\u0d41แཐ၁ᄡ");
		DataTable dataSource = a2147.a2105(a1344.a1271);
		a1535.DataSource = dataSource;
		try
		{
			a1536.FocusedRowHandle = focusedRowHandle;
		}
		catch
		{
		}
	}

	public void a1584()
	{
		a1984.a1964(a1636("pŧɭ\u0365ќՊؽݘࡒ\u0949\u0a4d\u0b51ౙൕแ༼ၑᅝቝፅᑂᔧᘭᝊᡙ᥅ᩄᬨ\u1c4cᵏṖὍ⁏ⅇ≓"), a1569);
		a1569.Items.Remove(a1636(""));
		a1522.Text = a1636("");
		a1521.Text = a1636("");
		a1565.Text = a1636("");
		a1555.Text = a1636("");
		a1557.Text = a1636("");
		a1558.Text = a1636("");
		a1580 = 0L;
	}

	public void a1585()
	{
		if (a1580 < 1)
		{
			return;
		}
		if (a1344.a1285)
		{
		}
		a1549.SelectedIndex = a1550.SelectedIndex;
		a1547.SelectedIndex = a1548.SelectedIndex;
		if (a1344.a1285)
		{
			string text = a1344.a1303();
			if (text != a1636("8ķȶ\u0335дԳز\u0731"))
			{
				a1565.Text = text;
			}
		}
		else
		{
			a1565.Text = a1344.a1303();
		}
		if (a1565.Text.Length != 8 || a1565.Text == a1636("8ķȶ\u0335дԳز\u0731"))
		{
			MessageBox.Show(a1636("fǕɜ\u0341уՋ\u0604ݨࡃ\u0953\u0a54\u0b3f\u0c51൶\u0e69རၯᅺቭ፮ᑷᔵᙟ\u1772ᡠᥥᬡᬯ᱗ᵨṾὧ\u206f⁖≼⍮⑴╬♪❪⡸⤯"), a1636("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		if (a1521.Text == a1636("") || a1547.Text == a1636("") || a1549.Text == a1636(""))
		{
			MessageBox.Show(a1636("WǦɭ;Ѳոصݕࡿॳ\u0a7f\u0b7c౮ർ༼༬၏ᅥብ፬ᑲᕴᙰᝪᡶ\u1978ᨯ"), a1636("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		if (a2147.a2100(a1636("{Ţɪ\u0360ѧշ\u0602ݨࡤ\u093f\u0a58\u0b4f\u0c53ൖ\u0e3aདྷၑᅄ\u125fፙᑑᕁᘲᝆᡘ᥊\u1a5cᭈ\u1c2cᵀṋὛ⁜ⅉ≉⍍⑁╛☿✦") + a1565.Text + a1636(",ĪɈ\u0346уԦ\u064c\u0740\u083f\u093cਦ") + a1580 + a1636("%ġ")))
		{
			MessageBox.Show(a1636("\\Ũȼ\u0350ѻի٬\u0737ࡒॴ\u0a7c୲ల\u0dc7\u0e7eཬ\u106bᄭቇ፪ᑳᕭ᙭ᝣᡯᥩ\u1a69᭪ᵝᴡ"), a1636("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (a1344.a1279 == 1 && a2147.a2100(a1636("tţɩ\u0361Ѡն\u0601ݩ\u085b\u093eਜ਼\u0b4e\u0c54\u0d57\u0e39ན\u105eᅅቜፘᑖᕀᘱᝇᡇ᥋\u1a5fᭉ\u1c2bᵞṊὃ⁎⅋≉⍍⑈┿☦") + a1565.Text + a1636(",ĪɈ\u0346уԦ\u064c\u0740\u083f\u093cਦ") + a1580 + a1636("%ġ")))
		{
			MessageBox.Show(a1636("nŞȊͽѫԇ٭\u074cࡉ\u094f\u0a4b\u0b4a\u0c00\u0d51\u0e6b\u0f70ၽᅩቻ፪ᔩᔷᙒ\u1774\u187cᥲᨲᯇ᱾ᵬṫἭ⁇Ⅺ≳⍭⑭╣♯❩⡩⥪⭝⬯"), a1636("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		a1344.a1307();
		string text2 = a2147.a2113(a1636("{Ţɪ\u0360ѧշ\u0602ݪࡡ\u094d\u0a4a\u0b53\u0c53\u0d53\u0e5fཁ\u1038ᅑቄፚᑙᔳᙙ\u1758ᡃ᥆ᩂᭈᱞᴫṝὁ⁍⅕≃⌥\u244d╇☿✦") + a1580 + a1636("&"), 0);
		if (text2 != a1565.Text)
		{
			a2147.a2128(a1636("Kōɘ\u035aю՜ظݜ\u085f\u0946\u0a5dୟ\u0c57\u0d43ะཛྷ။ᅙሬፀᑋᕛᙜᝉᡉ᥍ᩁ᭛᰿ᴦ") + a1565.Text + a1636("4ĲɆ\u0358ъ՜وܬࡀ\u094bਜ਼ଡ଼\u0c49\u0d49\u0e4dཁၛᄿሦ") + text2 + a1636("&"), a1636("Sŵɠ\u0362Ѷդ"));
			a2147.a2128(a1636("vŲɥ\u0361ы՛ؽݐࡔढ़\u0a46\u0b4c\u0c52\u0d44๘ཝၝᅓቝጰᑜᕋᙙᜬᡀ᥋\u1a5b᭜᱉ᵉṍὁ⁛ℿ∦") + a1565.Text + a1636("4ĲɆ\u0358ъ՜وܬࡀ\u094bਜ਼ଡ଼\u0c49\u0d49\u0e4dཁၛᄿሦ") + text2 + a1636("&"), a1636("Sŵɠ\u0362Ѷդ"));
			a2147.a2128(a1636("JŎə\u035dя՟عݔࡘ\u0951\u0a4a\u0b44\u0c52\u0d40๐༰ၜᅋ\u1259ጬᑀᕋᙛ\u175cᡉ᥉ᩍ\u1b41ᱛᴿḦ") + a1565.Text + a1636("4ĲɆ\u0358ъ՜وܬࡀ\u094bਜ਼ଡ଼\u0c49\u0d49\u0e4dཁၛᄿሦ") + text2 + a1636("&"), a1636("Sŵɠ\u0362Ѷդ"));
			a2147.a2128(a1636("wűɤ\u035eъ\u0558ؼݜࡏ\u0957\u0a47\u0b4e\u0c43൞๘བ\u105fᅔሰ\u135cᑋᕙᘬᝀᡋᥛ\u1a5cᭉ᱉ᵍṁὛ\u203fΩ") + a1565.Text + a1636("4ĲɆ\u0358ъ՜وܬࡀ\u094bਜ਼ଡ଼\u0c49\u0d49\u0e4dཁၛᄿሦ") + text2 + a1636("&"), a1636("Sŵɠ\u0362Ѷդ"));
		}
		a1344.a1271.CommandText = a1636("èƒʖ\u0381\u0485\u0597ڇߡࢋ৶૭௴\u0cf0\u0dfe\u0ee8\u0f99ძᇲዢ᎕ᓠᗰ\u16f9៸\u18fd᧣\u1ae7\u1be6Ბ\u1debỾῪ\u20e3⇮⋫⏩⓭◨⚎⟠⣤⧌⫑⯄ⳝ\u2ddf⺧\u2fd9ベ㇓㋅㏚㓍㗒㛖㞽㣛㧎㫜㯙㳂㷄㻂㿌䃐䆺䋆䏎䓅䗑䛖䟏䣏䤷䨻䬥䱐䵛丱伸倪儣利匲否唦嘢坌堰夤娯嬿尸崴席弻怽愷扊挼搱攨昮朤栭椚樁欐氙洉渑漜瀂焈爟猑瑩甓瘋眄砛礃程笀簉純縇缌耚脌舃茟萛蔊蘆蝭蠂襳話譶豹贆蹺轻遴酸鉽鍰鐘镲陹靥项饩験魭鱭鵠鹾齠ꁮꄋꉤꍪꑨꕶ\ua66fꜜꡠ\ua95d꩑ꭑ걉굖긶꽊끑녙뉟덓됩땓뙁띘롞륆멈묭뱛뵃빏뽛쁍섧쉏썁쐹앃왋읅");
		a1344.a1271.Parameters.Add(a1636("KŅ"), SqlDbType.Int).Value = a1580;
		a1344.a1271.Parameters.Add(a1636("Bŉɕ\u0352ыՋ\u064b\u0747\u0859"), SqlDbType.VarChar).Value = a1565.Text;
		a1344.a1271.Parameters.Add(a1636("\\ńɍ\u034cщՏ\u064b\u074a"), SqlDbType.VarChar).Value = a1522.Text;
		a1344.a1271.Parameters.Add(a1636("Fłɖ\u034bњՃم"), SqlDbType.VarChar).Value = a1521.Text;
		a1344.a1271.Parameters.Add(a1636("Bŉɕ\u0352њՃ\u0651ݗࡑ"), SqlDbType.Int).Value = Convert.ToInt32(a1547.Text);
		if (a1344.a1285)
		{
			a1344.a1271.Parameters.Add(a1636("HŅɄ\u0342шՁ\u064eݕࡄ\u094d\u0a55\u0b4d\u0c40൞\u0e5cཋ၅"), SqlDbType.Int).Value = Convert.ToInt32(a1549.Text);
		}
		else
		{
			a1344.a1271.Parameters.Add(a1636("HŅɄ\u0342шՁ\u064eݕࡄ\u094d\u0a55\u0b4d\u0c40൞\u0e5cཋ၅"), SqlDbType.Int).Value = a1344.a1272;
		}
		a1344.a1271.Parameters.Add(a1636("GňɌ\u0349ф"), SqlDbType.VarChar).Value = a1636("1");
		a1344.a1271.Parameters.Add(a1636("Dŏɗ\u034bч"), SqlDbType.VarChar).Value = a1636("0");
		a1344.a1271.Parameters.Add(a1636("Gŋɏ\u0357ь"), SqlDbType.VarChar).Value = a1569.Text;
		a1344.a1271.Parameters.Add(a1636("Vōɍ\u034bч"), SqlDbType.Int).Value = Convert.ToInt32(a1574.Text);
		try
		{
			a1344.a1271.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
		a1584();
	}

	public void a1586()
	{
		if (a1344.a1285)
		{
		}
		if (a1344.a1279 == 1 && a2147.a2100(a1636("tţɩ\u0361Ѡն\u0601ݩ\u085b\u093eਜ਼\u0b4e\u0c54\u0d57\u0e39ན\u105eᅅቜፘᑖᕀᘱᝇᡇ᥋\u1a5fᭉ\u1c2bᵞṊὃ⁎⅋≉⍍⑈┿☦") + a1565.Text + a1636("&")))
		{
			MessageBox.Show(a1636("nŞȊͽѫԇ٭\u074cࡉ\u094f\u0a4b\u0b4a\u0c00\u0d51\u0e6b\u0f70ၽᅩቻ፪ᔩᔷᙒ\u1774\u187cᥲᨲᯇ᱾ᵬṫἭ⁇Ⅺ≳⍭⑭╣♯❩⡩⥪⭝⬯"), a1636("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		a1549.SelectedIndex = a1550.SelectedIndex;
		a1547.SelectedIndex = a1548.SelectedIndex;
		if (!a1565.Enabled)
		{
			a1565.Text = a1344.a1303();
		}
		if (a1565.Text.Length != 8 || a1565.Text == a1636("8ķȶ\u0335дԳز\u0731"))
		{
			MessageBox.Show(a1636("fǕɜ\u0341уՋ\u0604ݨࡃ\u0953\u0a54\u0b3f\u0c51൶\u0e69རၯᅺቭ፮ᑷᔵᙟ\u1772ᡠᥥᬡᬯ᱗ᵨṾὧ\u206f⁖≼⍮⑴╬♪❪⡸⤯"), a1636("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		if (a1521.Text == a1636("") || a1547.Text == a1636("") || a1549.Text == a1636(""))
		{
			MessageBox.Show(a1636("WǦɭ;Ѳոصݕࡿॳ\u0a7f\u0b7c౮ർ༼༬၏ᅥብ፬ᑲᕴᙰᝪᡶ\u1978ᨯ"), a1636("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		a1344.a1307();
		if (a2147.a2100(a1636("{Ţɪ\u0360ѧշ\u0602ݨࡤ\u093f\u0a58\u0b4f\u0c53ൖ\u0e3aདྷၑᅄ\u125fፙᑑᕁᘲᝆᡘ᥊\u1a5cᭈ\u1c2cᵀṋὛ⁜ⅉ≉⍍⑁╛☿✦") + a1565.Text + a1636("&")))
		{
			MessageBox.Show(a1636("\\Ũȼ\u0350ѻի٬\u0737ࡒॴ\u0a7c୲ల\u0dc7\u0e7eཬ\u106bᄭቇ፪ᑳᕭ᙭ᝣᡯᥩ\u1a69᭪ᵝᴡ"), a1636("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		a1344.a1271.CommandText = a1636("\bŮɨͶѡձٶ܁ࡩ\u0951\u0a4a\u0b52\u0c3c\u0d50๓ཊၑᅛቓፇᐴᔻᙆ\u1752ᡛ᥆ᩃ\u1b41᱅ᵀḦὈ⁌⅔≉⍜⑅╇☮❊⡁⦭⪪⮳ⲳⶳ⺿⾡ピㆼ㊷㎧㒠㖬㚵㞣㢥㦿㫂㮴㲹㶠㺦㾬䂥䆢䊹䎨䒡䖱䚩䞤䢺䦀䪗䮙䳰䶙些侒傑冎劓叹咀喒嚀垘墘妜媏完岘巧庙徆悆憘抂掐撗斆暌枞梍槶櫵毩泽淩準濻烴燸狽珰璘痲盹知磹秩窂篯糣緧绿翤肄致苯菫蓭藥蚎蟠裳觔諗诙賝跄軃远郕釒鋝鎼钴闅雓韝飅駊髝鮭鲤鷋點鿊ꃃꇎꋋꏉ\ua4cdꗈꚮꟁ\ua8c1ꤻ\uaa2dꬲ갥괺긾꽕뀸넼눷댧될딽똽뜹렵뤷멂묭밧봪븸뼽쀷선숴쌰쐴앏옢윸젵줔쨒쬘찑촞츅켔퀝턅툝판퐎플혛휕\ud87c\ud90f\uda0c\udb0c\udc07\udd02\ude13\udf0c\ue064\ue107\ue212\ue304\ue416\ue50a\ue60a\ue712\ue801\ue97e\uea6a\ueb11\uec7c\ued68\uee75\uef77\uf067\uf173\uf263\uf366\uf471\uf57d\uf66d\uf77c\uf879磻喙ﭬﱾﴇ﹪ｫdŨɭ\u0360Јգ٣ݪࡴ\u0956\u0a58\u0b31\u0c5c൙๕ཕ၍ᅚሺፕᑇᕚᙜ\u1758ᡖ\u1923ᩎᭌᱟᵀṃὍ⁉⅘≟⍀⑉╆♉✨");
		a1344.a1271.Parameters.Add(a1636("Dńɏ\u034aћՄ"), SqlDbType.Decimal).Value = Convert.ToDecimal(a1636("4įȲ\u0331"));
		a1344.a1271.Parameters.Add(a1636("Cŀɀ\u0352ш՞\u0659\u074cࡆक़\u0a4b\u0b4c\u0c4f\u0d57ใན"), SqlDbType.Decimal).Value = Convert.ToDecimal(a1636("4įȲ\u0331"));
		a1344.a1271.Parameters.Add(a1636("]ŉɕ\u034fэ\u0557ق\u0743ࡕ"), SqlDbType.DateTime).Value = DateTime.Now.AddDays(-1.0);
		a1344.a1271.Parameters.Add(a1636("Bŉɕ\u0352ыՋ\u064b\u0747\u0859"), SqlDbType.VarChar).Value = a1565.Text;
		a1344.a1271.Parameters.Add(a1636("\\ńɍ\u034cщՏ\u064b\u074a"), SqlDbType.VarChar).Value = a1522.Text;
		a1344.a1271.Parameters.Add(a1636("Fłɖ\u034bњՃم"), SqlDbType.VarChar).Value = a1521.Text;
		a1344.a1271.Parameters.Add(a1636("Bŉɕ\u0352њՃ\u0651ݗࡑ"), SqlDbType.Int).Value = Convert.ToInt32(a1547.Text);
		if (a1344.a1285)
		{
			a1344.a1271.Parameters.Add(a1636("HŅɄ\u0342шՁ\u064eݕࡄ\u094d\u0a55\u0b4d\u0c40൞\u0e5cཋ၅"), SqlDbType.Int).Value = Convert.ToInt32(a1549.Text);
		}
		else
		{
			a1344.a1271.Parameters.Add(a1636("HŅɄ\u0342шՁ\u064eݕࡄ\u094d\u0a55\u0b4d\u0c40൞\u0e5cཋ၅"), SqlDbType.Int).Value = a1344.a1272;
		}
		a1344.a1271.Parameters.Add(a1636("GňɌ\u0349ф"), SqlDbType.VarChar).Value = a1636("1");
		a1344.a1271.Parameters.Add(a1636("Dŏɗ\u034bч"), SqlDbType.VarChar).Value = a1636("0");
		a1344.a1271.Parameters.Add(a1636("Gŋɏ\u0357ь"), SqlDbType.VarChar).Value = a1569.Text;
		a1344.a1271.Parameters.Add(a1636("Vōɍ\u034bч"), SqlDbType.Int).Value = Convert.ToInt32(a1574.Text);
		a1344.a1271.Parameters.Add(a1636("MŘɁ\u0340ьՆ\u0659ݜࡁ\u094e\u0a47\u0b4a"), SqlDbType.Int).Value = 1;
		try
		{
			a1344.a1271.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
		a1584();
	}

	public void a1587()
	{
		if (a1536.RowCount > 0)
		{
			int num = Convert.ToInt32(a1536.GetFocusedRowCellValue(a1636("KŅ")).ToString());
			if (MessageBox.Show(a1636("`ŋɛ\u035cԖԆ٧\u0748ࡌ\u0949\u0a44\u0b00ౚ൪\u0e70\u0f79ၰᄺጩ፫ᑣᕳᙱ\u177dᤌ\u197b\u1a7f᭹ᱵᵫḭὉ\u2066Ⅳ≧⍥⑮╵♬❪⡪⥸⨯"), a1636("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.Cancel)
			{
				a2147.a2128(a1636("sŵɠ\u0362Ѷդ\u0600ݔࡗ\u094e\u0a55\u0b57\u0c5f\u0d4b\u0e38ངၓᅁሴፑᑞᕞᙛᝊᠳ\u192aᨽᬬ\u1c2aᵞṀὂ\u2054⅀∤⍊⑆┼") + num, a1636("Sŵɠ\u0362Ѷդ"));
				a1583();
			}
		}
	}

	public void a1588()
	{
		if (a1536.RowCount > 0)
		{
			int num = Convert.ToInt32(a1536.GetFocusedRowCellValue(a1636("KŅ")).ToString());
			if (MessageBox.Show(a1636("`ŋɛ\u035cԖԆ٤ݏࡗ\u094b\u0a47\u0b00ౚ൪\u0e70\u0f79ၰᄺጩ፫ᑣᕳᙱ\u177dᤌ\u197b\u1a7f᭹ᱵᵫḭὉ\u2066Ⅳ≧⍥⑮╵♬❪⡪⥸⨯"), a1636("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.Cancel)
			{
				a2147.a2128(a1636("sŵɠ\u0362Ѷդ\u0600ݔࡗ\u094e\u0a55\u0b57\u0c5f\u0d4b\u0e38ངၓᅁሴፑᑞᕞᙛᝊᠳ\u192aᨼᬬ\u1c2aᵞṀὂ\u2054⅀∤⍊⑆┼") + num, a1636("Sŵɠ\u0362Ѷդ"));
				a1583();
			}
		}
	}

	public void a1589()
	{
		if (!a1344.a1285)
		{
			MessageBox.Show(a1636("{ǗɎͺѪմٿݲ࠺\u0956ੴ୶\u0c64൴\u0e7f༳ၕᅸቢ፦ᕑᔭᙕᝪ\u187aᥤ\u1a69\u1b6bᴷᵶἵὭℳⅻ"), a1636("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else if (a1536.RowCount > 0)
		{
			int num = Convert.ToInt32(a1536.GetFocusedRowCellValue(a1636("KŅ")).ToString());
			if (MessageBox.Show(a1636("mńɖ\u0357ԓԁٳݶࡲ॰\u0a79୰\u0c3a\u0c29\u0e6bལ\u1073ᅱችሌᑻᕿᙹ\u1775ᡫ\u192dᩉ᭦ᱣᵧṥὮ⁵Ⅼ≪⍪⑸┯"), a1636("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.Cancel)
			{
				a2147.a2128(a1636("Yřɗ\u035fэ՝طݐࡇज़ਫ਼ଲౚ൙\u0e5cཇ၁ᅉ\u1259ጪᑞᕀᙂ\u1754ᡀ\u1924ᩊᭆ᰼") + num, a1636("BŠɨ\u0366Ѷդ"));
				a1583();
			}
		}
	}

	public void a1591(bool a1590)
	{
		if (a1536.RowCount > 0)
		{
			int num = Convert.ToInt32(a1536.GetFocusedRowCellValue(a1636("KŅ")).ToString());
			if (MessageBox.Show(a1636("ĝsɇ\u034fфՍ؇ݢࡀ\u0952\u0a42\u0b4f\u0c01\u0d65\u0e6b\u0f73ၸᅷሻሪᑪᕬᙲ\u1772\u187c\u180b\u1a7a᭼ᱸᵪṪἮ⁈Ⅱ≢⍤␩╥♮❵⡬⥪⩪⭸ⰾ"), a1636("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.Cancel)
			{
				int num2 = 0;
				num2 = (a1590 ? 1 : 0);
				a2147.a2128(a1636("tŰɛ\u035fщՙػݑࡐ\u094bਫ਼\u0b5a\u0c50\u0d46ำཁၔᅄሯፏᑞᕇᙂᝎᡈᥗ\u1a5e\u1b43᱈ᵁṈἿ…") + num2 + a1636(",Īɞ\u0340тՔـܤࡊ\u0946\u0a3c") + num, a1636("Sŵɠ\u0362Ѷդ"));
				a1583();
			}
		}
	}

	public void a1592()
	{
		if (a1536.RowCount > 0)
		{
			a1580 = Convert.ToInt32(a1536.GetFocusedRowCellValue(a1636("KŅ")).ToString());
			a1522.Text = a1536.GetFocusedRowCellValue(a1636("\\ńɍ\u034cщՏ\u064b\u074a")).ToString();
			a1521.Text = a1536.GetFocusedRowCellValue(a1636("Fłɖ\u034bњՃم")).ToString();
			a1565.Text = a1536.GetFocusedRowCellValue(a1636("Bŉɕ\u0352ыՋ\u064b\u0747\u0859")).ToString();
			if (a1344.a1285)
			{
				a1550.SelectedIndex = a1549.Items.IndexOf(a1536.GetFocusedRowCellValue(a1636("HŅɄ\u0342шՁ\u064eݕࡄ\u094d\u0a55\u0b4d\u0c40൞\u0e5cཋ၅")).ToString());
			}
			a1548.SelectedIndex = a1547.Items.IndexOf(a1536.GetFocusedRowCellValue(a1636("Bŉɕ\u0352њՃ\u0651ݗࡑ")).ToString());
			a1569.Text = a1536.GetFocusedRowCellValue(a1636("Gŋɏ\u0357ь")).ToString();
			a1574.Text = a1536.GetFocusedRowCellValue(a1636("Vōɍ\u034bч")).ToString();
		}
	}

	private void a1595(object a1593, EventArgs a1594)
	{
		a1586();
		a1583();
	}

	private void a1598(object a1596, EventArgs a1597)
	{
		Close();
	}

	private void a1601(object a1599, EventArgs a1600)
	{
		a1587();
	}

	private void a1604(object a1602, EventArgs a1603)
	{
		a1588();
	}

	private void a1607(object a1605, EventArgs a1606)
	{
		a1583();
	}

	private void a1610(object a1608, EventArgs a1609)
	{
		a1557.Text = a1344.a1303();
	}

	private void a1613(object a1611, EventArgs a1612)
	{
		a1592();
	}

	private void a1616(object a1614, EventArgs a1615)
	{
		a1589();
	}

	private void a1619(object a1617, EventArgs a1618)
	{
		a1565.Text = a1344.a1303();
	}

	private void a1622(object a1620, KeyPressEventArgs a1621)
	{
		if (!char.IsControl(a1621.KeyChar) && !char.IsDigit(a1621.KeyChar))
		{
			a1621.Handled = true;
		}
	}

	private void a1625(object a1623, EventArgs a1624)
	{
		a1592();
	}

	private void a1628(object a1626, EventArgs a1627)
	{
		a1585();
		a1583();
	}

	private void a1631(object a1629, EventArgs a1630)
	{
		a1591(a1590: false);
	}

	private void a1634(object a1632, EventArgs a1633)
	{
		a1591(a1590: true);
	}

	private static string a1636(string a1635)
	{
		int length = a1635.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a1635[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
