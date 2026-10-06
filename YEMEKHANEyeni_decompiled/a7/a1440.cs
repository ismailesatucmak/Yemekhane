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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using a7.a2096;

namespace a7;

public class a1440 : XtraForm
{
	private IContainer a1347 = null;

	public GroupBox a1348;

	public Label a1349;

	public Label a1350;

	public Label a1351;

	public Label a1352;

	private Panel a1353;

	public Button a1354;

	public System.Windows.Forms.ComboBox a1355;

	public Label a1356;

	public GridControl a1357;

	public GridView a1358;

	private GridColumn a1359;

	private GridColumn a1360;

	private GridColumn a1361;

	private GridColumn a1362;

	private GridColumn a1363;

	private GridColumn a1364;

	private GridColumn a1365;

	private GridColumn a1366;

	private GridColumn a1367;

	private GridColumn a1368;

	private GridColumn a1369;

	private GridColumn a1370;

	public ContextMenuStrip a1371;

	public ToolStripMenuItem a1372;

	private ToolStripMenuItem a1373;

	public System.Windows.Forms.ComboBox a1374;

	public System.Windows.Forms.ComboBox a1375;

	public Label a1376;

	public System.Windows.Forms.ComboBox a1377;

	private ToolStripMenuItem a1378;

	private ToolStripMenuItem a1379;

	private PictureBox a1380;

	private GridColumn a1381;

	private GridColumn a1382;

	public Button a1383;

	public Label a1384;

	public Label a1385;

	public Label a1386;

	public TextBox a1387;

	public TextBox a1388;

	public TextBox a1389;

	public Label a1390;

	public System.Windows.Forms.ComboBox a1391;

	public System.Windows.Forms.ComboBox a1392;

	public Label a1393;

	private GridColumn a1394;

	private ToolStripMenuItem a1395;

	public bool a1396 = false;

	protected override void Dispose(bool a1397)
	{
		if (a1397 && a1347 != null)
		{
			a1347.Dispose();
		}
		base.Dispose(a1397);
	}

	private void a1398()
	{
		a1347 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(a1440));
		a1348 = new GroupBox();
		a1390 = new Label();
		a1391 = new System.Windows.Forms.ComboBox();
		a1392 = new System.Windows.Forms.ComboBox();
		a1393 = new Label();
		a1383 = new Button();
		a1384 = new Label();
		a1385 = new Label();
		a1386 = new Label();
		a1387 = new TextBox();
		a1388 = new TextBox();
		a1389 = new TextBox();
		a1375 = new System.Windows.Forms.ComboBox();
		a1376 = new Label();
		a1357 = new GridControl();
		a1371 = new ContextMenuStrip(a1347);
		a1372 = new ToolStripMenuItem();
		a1373 = new ToolStripMenuItem();
		a1378 = new ToolStripMenuItem();
		a1379 = new ToolStripMenuItem();
		a1395 = new ToolStripMenuItem();
		a1358 = new GridView();
		a1359 = new GridColumn();
		a1360 = new GridColumn();
		a1361 = new GridColumn();
		a1362 = new GridColumn();
		a1363 = new GridColumn();
		a1364 = new GridColumn();
		a1365 = new GridColumn();
		a1366 = new GridColumn();
		a1367 = new GridColumn();
		a1368 = new GridColumn();
		a1369 = new GridColumn();
		a1370 = new GridColumn();
		a1381 = new GridColumn();
		a1382 = new GridColumn();
		a1394 = new GridColumn();
		a1355 = new System.Windows.Forms.ComboBox();
		a1356 = new Label();
		a1349 = new Label();
		a1350 = new Label();
		a1351 = new Label();
		a1352 = new Label();
		a1380 = new PictureBox();
		a1377 = new System.Windows.Forms.ComboBox();
		a1374 = new System.Windows.Forms.ComboBox();
		a1353 = new Panel();
		a1354 = new Button();
		a1348.SuspendLayout();
		((ISupportInitialize)a1357).BeginInit();
		a1371.SuspendLayout();
		((ISupportInitialize)a1358).BeginInit();
		((ISupportInitialize)a1380).BeginInit();
		a1353.SuspendLayout();
		SuspendLayout();
		a1348.Controls.Add(a1390);
		a1348.Controls.Add(a1391);
		a1348.Controls.Add(a1392);
		a1348.Controls.Add(a1393);
		a1348.Controls.Add(a1383);
		a1348.Controls.Add(a1384);
		a1348.Controls.Add(a1385);
		a1348.Controls.Add(a1386);
		a1348.Controls.Add(a1387);
		a1348.Controls.Add(a1388);
		a1348.Controls.Add(a1389);
		a1348.Controls.Add(a1375);
		a1348.Controls.Add(a1376);
		a1348.Controls.Add(a1357);
		a1348.Controls.Add(a1355);
		a1348.Controls.Add(a1356);
		a1348.Controls.Add(a1349);
		a1348.Controls.Add(a1350);
		a1348.Controls.Add(a1351);
		a1348.Controls.Add(a1352);
		a1348.Controls.Add(a1380);
		a1348.Location = new Point(3, 1);
		a1348.Name = a1439("nźɨͳѵՆ٬ݺ࠰");
		a1348.Size = new Size(1009, 722);
		a1348.TabIndex = 1;
		a1348.TabStop = false;
		a1390.AutoSize = true;
		a1390.Location = new Point(345, 71);
		a1390.Name = a1439("kŧɧ\u0361ѯԳظ");
		a1390.Size = new Size(27, 13);
		a1390.TabIndex = 83;
		a1390.Text = a1439("V5ɭȳѧ");
		a1391.DropDownStyle = ComboBoxStyle.DropDownList;
		a1391.Font = new Font(a1439("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1391.FormattingEnabled = true;
		a1391.Items.AddRange(new object[10]
		{
			a1439("MšɳͱѨ"),
			a1439("1"),
			a1439("0"),
			a1439("3"),
			a1439("2"),
			a1439("5"),
			a1439("4"),
			a1439("7"),
			a1439("6"),
			a1439("9")
		});
		a1391.Location = new Point(386, 64);
		a1391.Name = a1439("dŤɖ\u036dѭի٧");
		a1391.Size = new Size(92, 26);
		a1391.TabIndex = 7;
		a1391.SelectedIndexChanged += a1428;
		a1392.DropDownStyle = ComboBoxStyle.DropDownList;
		a1392.Font = new Font(a1439("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1392.FormattingEnabled = true;
		a1392.Location = new Point(386, 36);
		a1392.Name = a1439("dŤɇ\u036bѯշ٬");
		a1392.Size = new Size(239, 26);
		a1392.TabIndex = 6;
		a1392.SelectedIndexChanged += a1428;
		a1393.AutoSize = true;
		a1393.Location = new Point(345, 43);
		a1393.Name = a1439("kŧɧ\u0361ѯԳع");
		a1393.Size = new Size(35, 13);
		a1393.TabIndex = 82;
		a1393.Text = a1439("GǲɯϾѬ");
		a1383.Image = a2268.a2289;
		a1383.ImageAlign = ContentAlignment.MiddleLeft;
		a1383.Location = new Point(287, 147);
		a1383.Name = a1439("kżɩ\u034dѤնٷ\u074c\u086e");
		a1383.Size = new Size(40, 28);
		a1383.TabIndex = 5;
		a1383.UseVisualStyleBackColor = true;
		a1383.Click += a1431;
		a1384.AutoSize = true;
		a1384.Location = new Point(9, 155);
		a1384.Name = a1439("jŤɦ\u0366ѮԴ");
		a1384.Size = new Size(74, 13);
		a1384.TabIndex = 78;
		a1384.Text = a1439("Fŭɹ;ЩՆٲݫࡤॶ\u0a62ୱര");
		a1385.AutoSize = true;
		a1385.Location = new Point(9, 127);
		a1385.Name = a1439("jŤɦ\u0366ѮԷ");
		a1385.Size = new Size(57, 13);
		a1385.TabIndex = 79;
		a1385.Text = a1439("Kŭ\u0339\u0327ѕժٽݢࡦ࠰");
		a1386.AutoSize = true;
		a1386.Location = new Point(9, 99);
		a1386.Name = a1439("kŧɧ\u0361ѯԳر");
		a1386.Size = new Size(93, 13);
		a1386.TabIndex = 77;
		a1386.Text = a1439("FĿɓ\u032fхդ١ݧࡣ\u0962ਨ\u0b49\u0c73൨\u0e76ར\u1071\u1030");
		a1387.Font = new Font(a1439("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a1387.Location = new Point(108, 148);
		a1387.MaxLength = 8;
		a1387.Name = a1439("}Űɳ\u034dѤնٷ\u074c\u086e");
		a1387.Size = new Size(178, 26);
		a1387.TabIndex = 4;
		a1387.TextChanged += a1428;
		a1388.Font = new Font(a1439("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a1388.Location = new Point(108, 120);
		a1388.MaxLength = 40;
		a1388.Name = a1439("xųɾ\u0348Ѭծ\u0655ݪࡽ\u0962੦୨");
		a1388.Size = new Size(218, 26);
		a1388.TabIndex = 3;
		a1388.TextChanged += a1428;
		a1389.Font = new Font(a1439("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a1389.Location = new Point(108, 92);
		a1389.MaxLength = 11;
		a1389.Name = a1439("sžɱ\u0350рՌٮ");
		a1389.Size = new Size(218, 26);
		a1389.TabIndex = 2;
		a1389.TextChanged += a1428;
		a1375.DropDownStyle = ComboBoxStyle.DropDownList;
		a1375.Font = new Font(a1439("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1375.FormattingEnabled = true;
		a1375.Location = new Point(108, 64);
		a1375.Name = a1439("oũɓͼѣի٣ݨࡡ\u094e੧୳");
		a1375.Size = new Size(218, 26);
		a1375.TabIndex = 1;
		a1375.SelectedIndexChanged += a1428;
		a1376.AutoSize = true;
		a1376.Location = new Point(9, 71);
		a1376.Name = a1439("jŤɦ\u0366ѮԶ");
		a1376.Size = new Size(85, 13);
		a1376.TabIndex = 69;
		a1376.Text = a1439("Vǲɦ\u0360Ѯէ٬ܨࡊ\u0963\u0a77୯౦൸\u0e68");
		a1357.ContextMenuStrip = a1371;
		a1357.EmbeddedNavigator.Name = a1439("");
		a1357.Font = new Font(a1439("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1357.Location = new Point(9, 246);
		a1357.LookAndFeel.SkinName = a1439("GżɻͳѯՖ٭ݨ\u086b९");
		a1357.LookAndFeel.UseDefaultLookAndFeel = false;
		a1357.MainView = a1358;
		a1357.Name = a1439("kŹɣ\u036dыը٨ݱࡶ६੮ର");
		a1357.Size = new Size(991, 476);
		a1357.TabIndex = 9;
		a1357.ViewCollection.AddRange(new BaseView[1] { a1358 });
		a1371.Items.AddRange(new ToolStripItem[5] { a1372, a1373, a1378, a1379, a1395 });
		a1371.Name = a1439("rſɡͺѨմٿ\u0747\u086c०ੲ\u0b55\u0c71൶\u0e6a\u0f72\u1030");
		a1371.Size = new Size(214, 274);
		a1372.Image = a2268.a2342;
		a1372.ImageScaling = ToolStripItemImageScaling.None;
		a1372.Name = a1439("gźɾ\u0345ѿՠ٢ݞࡸॹ\u0a63\u0b79\u0c45\u0d62\u0e68\u0f70၍ᅷቧ፬");
		a1372.Size = new Size(213, 54);
		a1372.Text = a1439("AǨɾ\u0332њձٽݺࡡ७\u0a79\u0a3b\u0c29\u0d4a\u0e6bཀྵၮᅡሣፇᑵ");
		a1372.Visible = false;
		a1372.Click += a1413;
		a1373.Image = a2268.a2314;
		a1373.ImageScaling = ToolStripItemImageScaling.None;
		a1373.Name = a1439("vŽɩ\u036eԨՙټݢࡼॲ\u0a56୦\u0c45ൿ\u0e60ར\u105eᅸቹ፣ᑹᕅᙢᝨᡰ᥍\u1a77᭧ᱬ");
		a1373.Size = new Size(213, 54);
		a1373.Text = a1439("AǨɾ\u0332њձٽݺࡡ७\u0a79\u0a3b\u0c29\u0d49\u0e6c\u0f72\u106cᅢሣፇᑵ");
		a1373.Visible = false;
		a1373.Click += a1422;
		a1378.Image = a2268.a2341;
		a1378.ImageScaling = ToolStripItemImageScaling.None;
		a1378.Name = a1439("PŇˆ\u0349ѳշ\u0656ݽࡩ८ନ\u0b5a౻൹\u0e7e\u0f71\u1056ᅦቅ\u137fᑠᕢᙞ\u1778\u1879ᥣ\u1a79ᭅᱢᵨṰὍ⁷Ⅷ≬");
		a1378.Size = new Size(213, 54);
		a1378.Text = a1439("Fű\u02f4ͻѽչد\u0745\u086cॾ\u0a7f\u0a3b\u0c29\u0d4a\u0e6bཀྵၮᅡሣፇᑵ");
		a1378.Visible = false;
		a1378.Click += a1416;
		a1379.Image = a2268.a2319;
		a1379.ImageScaling = ToolStripItemImageScaling.None;
		a1379.Name = a1439("PŇˆ\u0349ѳշ\u0656ݽࡩ८ନ\u0b59౼\u0d62\u0e7c\u0f72\u1056ᅦቅ\u137fᑠᕢᙞ\u1778\u1879ᥣ\u1a79ᭅᱢᵨṰὍ⁷Ⅷ≬");
		a1379.Size = new Size(213, 54);
		a1379.Text = a1439("Fű\u02f4ͻѽչد\u0745\u086cॾ\u0a7f\u0a3b\u0c29\u0d49\u0e6c\u0f72\u106cᅢሣፇᑵ");
		a1379.Visible = false;
		a1379.Click += a1419;
		a1395.Image = a2268.a2313;
		a1395.ImageScaling = ToolStripItemImageScaling.None;
		a1395.Name = a1439("wżɪͼѳկٸݶࡠ\u0945\u0a7fୠ\u0c62൞\u0e78\u0f79\u1063ᅹቅ።ᑨᕰᙍ\u1777ᡧᥬ");
		a1395.Size = new Size(213, 54);
		a1395.Text = a1439("Dŭɵ\u036dѠվٯݧࡳ");
		a1358.BorderStyle = BorderStyles.NoBorder;
		a1358.Columns.AddRange(new GridColumn[15]
		{
			a1359, a1360, a1361, a1362, a1363, a1364, a1365, a1366, a1367, a1368,
			a1369, a1370, a1381, a1382, a1394
		});
		a1358.FocusRectStyle = DrawFocusRectStyle.RowFocus;
		a1358.GridControl = a1357;
		a1358.Name = a1439("nźɮ\u0362ѓխ٦ݵ࠰");
		a1358.OptionsBehavior.Editable = false;
		a1358.OptionsCustomization.AllowFilter = false;
		a1358.OptionsCustomization.AllowGroup = false;
		a1358.OptionsCustomization.AllowRowSizing = true;
		a1358.OptionsCustomization.AllowSort = false;
		a1358.OptionsFilter.AllowFilterEditor = false;
		a1358.OptionsView.ShowFooter = true;
		a1358.OptionsView.ShowGroupPanel = false;
		a1359.Caption = a1439("KŅ");
		a1359.FieldName = a1439("KŅ");
		a1359.Name = a1439("lŸɠ\u036cфթ٩ݱ\u086e६ਰ");
		a1360.Caption = a1439("QŇȣ\u034cѮ");
		a1360.FieldName = a1439("\\ńɍ\u034cщՏ\u064b\u074a");
		a1360.Name = a1439("lŸɠ\u036cфթ٩ݱ\u086e६ਲ਼");
		a1360.Visible = true;
		a1360.VisibleIndex = 1;
		a1360.Width = 113;
		a1361.Caption = a1439("IţȦ\u0356ѫպ٣ݥ");
		a1361.FieldName = a1439("Fłɖ\u034bњՃم");
		a1361.Name = a1439("lŸɠ\u036cфթ٩ݱ\u086e६ਲ");
		a1361.Visible = true;
		a1361.VisibleIndex = 2;
		a1361.Width = 194;
		a1362.Caption = a1439("LŧɷͰУՌٮ");
		a1362.FieldName = a1439("Bŉɕ\u0352ыՋ\u064b\u0747\u0859");
		a1362.Name = a1439("lŸɠ\u036cфթ٩ݱ\u086e६ਵ");
		a1362.Visible = true;
		a1362.VisibleIndex = 3;
		a1362.Width = 87;
		a1363.Caption = a1439("AŨɺͳЦՂٶݶࡠॴ");
		a1363.FieldName = a1439("Cņɔ\u0351уՑ\u0657ݑ");
		a1363.Name = a1439("lŸɠ\u036cфթ٩ݱ\u086e६\u0a34");
		a1363.Visible = true;
		a1363.VisibleIndex = 4;
		a1363.Width = 179;
		a1364.Caption = a1439("AŨɺͳсշٱݳࡋ\u0945");
		a1364.FieldName = a1439("Bŉɕ\u0352њՃ\u0651ݗࡑ");
		a1364.Name = a1439("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଳ");
		a1365.Caption = a1439("Ełɔ\u034eсՙ\u064b\u0745");
		a1365.FieldName = a1439("HŅɄ\u0342шՁ\u064eݕࡄ\u094d\u0a55\u0b4d\u0c40൞\u0e5cཋ၅");
		a1365.Name = a1439("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ର");
		a1366.Caption = a1439("KŠɶ\u0368ѧջ");
		a1366.FieldName = a1439("PŝɌ\u034bрՖو\u0747\u085b");
		a1366.Name = a1439("lŸɠ\u036cфթ٩ݱ\u086e६\u0a37");
		a1366.Visible = true;
		a1366.VisibleIndex = 5;
		a1366.Width = 180;
		a1367.Caption = a1439("DŤɯ\u036aѻդ");
		a1367.FieldName = a1439("Dńɏ\u034aћՄ");
		a1367.Name = a1439("lŸɠ\u036cфթ٩ݱ\u086e६ਸ਼");
		a1367.Width = 71;
		a1368.Caption = a1439("XŪɸ\u0360Ѡԧةܥࡗ\u0962\u0a63୵");
		a1368.FieldName = a1439("]ŉɕ\u034fэ\u0557ق\u0743ࡕ");
		a1368.Name = a1439("lŸɠ\u036cфթ٩ݱ\u086e६ਹ");
		a1368.Width = 87;
		a1369.Caption = a1439("XĤɍ\u0332ЧՋ٬ݯࡷ\u0963ੳ");
		a1369.FieldName = a1439("Cŀɀ\u0352ш՞\u0659\u074cࡆक़\u0a4b\u0b4c\u0c4f\u0d57ใན");
		a1369.Name = a1439("lŸɠ\u036cфթ٩ݱ\u086e६ਸ");
		a1369.Width = 73;
		a1370.AppearanceHeader.Options.UseTextOptions = true;
		a1370.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
		a1370.Caption = a1439("GŨɬ\u0369Ѥ");
		a1370.FieldName = a1439("GňɌ\u0349ф");
		a1370.Name = a1439("kŹɣ\u036dыը٪ݰࡩ७ਲ਼\u0b31");
		a1370.Width = 45;
		a1381.Caption = a1439("GǲɯϾѬ");
		a1381.FieldName = a1439("Gŋɏ\u0357ь");
		a1381.Name = a1439("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଲ");
		a1381.Visible = true;
		a1381.VisibleIndex = 6;
		a1381.Width = 81;
		a1382.Caption = a1439("V5ɭȳѧ");
		a1382.FieldName = a1439("Vōɍ\u034bч");
		a1382.Name = a1439("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଵ");
		a1382.Visible = true;
		a1382.VisibleIndex = 7;
		a1382.Width = 91;
		a1394.Caption = a1439("W2ɰ\u0360");
		a1394.FieldName = a1439("WŊɐ\u0340");
		a1394.Name = a1439("kŹɣ\u036dыը٪ݰࡩ७ਲ਼\u0b34");
		a1394.SummaryItem.SummaryType = SummaryItemType.Count;
		a1394.Visible = true;
		a1394.VisibleIndex = 0;
		a1394.Width = 49;
		a1355.DropDownStyle = ComboBoxStyle.DropDownList;
		a1355.Font = new Font(a1439("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1355.FormattingEnabled = true;
		a1355.Location = new Point(108, 36);
		a1355.Name = a1439("iūɃ\u0366Ѵձكݱࡷॱ");
		a1355.Size = new Size(218, 26);
		a1355.TabIndex = 0;
		a1355.SelectedIndexChanged += a1428;
		a1356.AutoSize = true;
		a1356.Location = new Point(9, 43);
		a1356.Name = a1439("jŤɦ\u0366ѮԸ");
		a1356.Size = new Size(59, 13);
		a1356.TabIndex = 65;
		a1356.Text = a1439("AŨɺͳЦՂٶݶࡠॴ");
		a1349.AutoSize = true;
		a1349.Location = new Point(6, 227);
		a1349.Name = a1439("jŤɦ\u0366ѮԲ");
		a1349.Size = new Size(653, 13);
		a1349.TabIndex = 59;
		a1349.Text = a1439("Äǯ\u02ffϸӧ\u05ebۻڹࢧ\u09d2૪௴೯\u0df7ມ\u0ff9သᄚሜ\u135cᐯᔟᘒ\u1714\u181eᥖ\u1a1aᬘᰒᴀḐἛ⁏ℬ∁⌃␀┏♉✭⠃⤃⨇⬍Ⰿⴋ⸓⼓〶\u3130㈴㌦㑵㕺㘝㜹㠿㤷㩵㬇㰼㴼㸣㼱䁯䄌䈡䌣䐠䔯䘺䜡䠩䤯䩥䬏䰢䴮严乱偍兓剜南君吊噊坌塒奒婜娫屚嵜幘彊怏慥扌捞摟搛昉杣框楔橑欄汨浃湘渑火焾牘獷瑩畻癷瘩硹祲穴筺簳絖续罪聪腢艹荩葩蕣虥蝡衵襵詬譪豪赸踯");
		a1350.AutoSize = true;
		a1350.Font = new Font(a1439("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a1350.Location = new Point(9, 198);
		a1350.Name = a1439("jŤɦ\u0366Ѯ\u0530");
		a1350.Size = new Size(70, 13);
		a1350.TabIndex = 55;
		a1350.Text = a1439("GŪɸͽШՋٯݶࡰ०\u0a71୨");
		a1351.BackColor = Color.FromArgb(128, 255, 128);
		a1351.BorderStyle = BorderStyle.Fixed3D;
		a1351.FlatStyle = FlatStyle.Flat;
		a1351.ForeColor = Color.DarkOrange;
		a1351.Location = new Point(7, 219);
		a1351.Name = a1439("kŧɧ\u0361ѯԳز");
		a1351.Size = new Size(983, 3);
		a1351.TabIndex = 54;
		a1352.AutoSize = true;
		a1352.Font = new Font(a1439("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a1352.Location = new Point(7, 19);
		a1352.Name = a1439("jŤɦ\u0366ѮԹ");
		a1352.Size = new Size(69, 13);
		a1352.TabIndex = 51;
		a1352.Text = a1439("KŹɿ\u0379ШՅٯݩࡣ४\u0a71୨");
		a1380.Image = (Image)componentResourceManager.GetObject(a1439("aŹɬͺѸվٮ\u0748ࡦ॰ਸ਼ନ\u0c4c൩\u0e62ཥ\u1064"));
		a1380.Location = new Point(109, -756);
		a1380.Name = a1439("{ţɪͼѲմ٠\u0746\u086cॺਰ");
		a1380.Size = new Size(1289, 1216);
		a1380.TabIndex = 72;
		a1380.TabStop = false;
		a1377.DropDownStyle = ComboBoxStyle.DropDownList;
		a1377.Font = new Font(a1439("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1377.FormattingEnabled = true;
		a1377.Location = new Point(965, 257);
		a1377.Name = a1439("můɕ;ѡե٭ݪࡣ\u0948\u0a61ୱ\u0c4b\u0d45");
		a1377.Size = new Size(41, 26);
		a1377.TabIndex = 67;
		a1374.DropDownStyle = ComboBoxStyle.DropDownList;
		a1374.Font = new Font(a1439("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1374.FormattingEnabled = true;
		a1374.Location = new Point(965, 225);
		a1374.Name = a1439("oũɁ\u0368Ѻճفݷࡱॳ\u0a4b\u0b45");
		a1374.Size = new Size(41, 26);
		a1374.TabIndex = 67;
		a1353.Controls.Add(a1354);
		a1353.Dock = DockStyle.Bottom;
		a1353.Location = new Point(0, 729);
		a1353.Name = a1439("vŤɪ\u0366Ѯ\u0530");
		a1353.Size = new Size(1016, 46);
		a1353.TabIndex = 2;
		a1354.Dock = DockStyle.Fill;
		a1354.Location = new Point(0, 0);
		a1354.Name = a1439("jųɨ\u0346ѭը٫ݲ");
		a1354.Size = new Size(1016, 46);
		a1354.TabIndex = 3;
		a1354.Text = a1439("Â5ɨȳ՞");
		a1354.UseVisualStyleBackColor = true;
		a1354.Click += a1410;
		Appearance.BackColor = Color.White;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1016, 775);
		Controls.Add(a1353);
		Controls.Add(a1348);
		Controls.Add(a1377);
		Controls.Add(a1374);
		MaximizeBox = false;
		MaximumSize = new Size(1032, 814);
		Name = a1439("Pŧɹ\u0358ѳգ٤\u0742\u086bॿ੧୮\u0c70ൠ\u0e4cརၡᅬቷ፪ᑯᕨ");
		ShowIcon = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a1439("^ŵɡ\u0366б՝٪ݼࡦ३\u0a71\u0b63\u0c29\u0d4c\u0e62น\u106cၛቪ፯ᑨ");
		Shown += a1437;
		a1348.ResumeLayout(performLayout: false);
		a1348.PerformLayout();
		((ISupportInitialize)a1357).EndInit();
		a1371.ResumeLayout(performLayout: false);
		((ISupportInitialize)a1358).EndInit();
		((ISupportInitialize)a1380).EndInit();
		a1353.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public a1440()
	{
		a1398();
		a1984.a1891(this);
		a1391.SelectedIndex = 0;
		a1984.a1964(a1439("rťɓ\u035bўՈػݓ\u085dऴ\u0a56\u0b52\u0c5cഴ๕ཀ\u105eᅝሯፗᑘᕇᙇᝏᡄ᥍\u1a58ᭋ᱀ᵖṈ\u1f47⁛"), a1377, a1375, a1439("1"), a1439("MšɳͱѨ"));
		a1984.a1964(a1439("gŶɾʹѳջ؎ݤࡨइ\u0a61୨౺൳\u0e79རၶᅶቲ\u137eᑡᕛᙗ\u173dᡚ᥉\u1a55᭔\u1c38ᵜṗ\u1f47\u2040⅌≕⍃⑅╟☮❚⡄⥎⩘⭌Ⱘⵆ⹍⽑きㅅ㈿㌰"), a1374, a1355, a1439("1"), a1439("MšɳͱѨ"));
		a1984.a1964(a1439("pŧɭ\u0365ќՊؽݘࡒ\u0949\u0a4d\u0b51ౙൕแ༼ၑᅝቝፅᑂᔧᘭᝊᡙ᥅ᩄᬨ\u1c4cᵏṖὍ⁏ⅇ≓"), a1392);
		a1392.Items.Insert(0, a1439("MšɳͱѨ"));
		a1402();
		a1403();
	}

	private void a1401(object a1399, EventArgs a1400)
	{
		if (!a1344.a1285)
		{
			MessageBox.Show(a1439("\u007fŀɐ\u0348ыԁ٫خ\u086d\u082c੨୷౻൴\u0e79ཤᄧᄻጤቌᑾᕴᙽᜯᡉᥨ\u1a7e\u1becᱯᵢṤὢ⅙Ⅸ≡⍧⑫┯"), a1439("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)a1399;
		if (MessageBox.Show(a1439("|ŕɝ\u0345шՖهݏ\u085b\u0941ਇ\u0b62\u0c40\u0c3b\u0e4a\u0e7dၕᅉቭ፳ᑸᕷᘻᘪᡪᥬ\u1a72\u1b72ᱼᰋṺὼ⁸Ⅺ≪⌮⑈╡♢❤⠩⥥⩮\u2b75ⱬ\u2d6a\u2e6a⽸〾"), a1439("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel || MessageBox.Show(a1439("Bſɡ\u032eцխٹݫࡻ࠹੩\u0a37౿ത\u0e6eำ\u103e"), a1439("PŽɢͰ\u0530"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No || MessageBox.Show(a1439("ZǫɲϧѶմٽݭ࠶\u0954\u0a7f\u0a4c\u0c73ർ༡ཡ\u102eᅘቪ፠ᑿᕧᙬᝦᡵᠴ\u1a6aᨲᱸᴾ"), a1439("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
		{
			return;
		}
		int num = a2147.a2113(a1439("\nźɭ\u036bѣզ\u0670܃\u086b॥\u0a00\u0b59\u0c4c\u0d52๑༻၃ᅌቓ\u135bᑓᕘᙑᝌᡟᥔᩂ\u1b44\u1c4bᵗḬ\u1f5c⁂⅌≚⍂␦╄♀❊⠿⤦") + toolStripMenuItem.Text + a1439("&"));
		if (num > 0)
		{
			for (int i = 0; i < a1358.RowCount; i++)
			{
				a1344.a1307();
				a1344.a1271.CommandText = a1439("eđȓ\u0306ЀԔٺܞࡶॵ੨୳\u0c75ൽ\u0e65༖ၦᅱቧጒᑨᕥᙤᝢᡨᥡ\u1a6e᭵ᱤᵭṵὭ\u2060ⅾ≼⍫⑥┝♟❇⡈⥗⩗⭟ⱔⵝ⹈⽛ぐㅆ㉘㍗㑋㕏㙆㝊㠭㥛㩃㭏㱛㵍㸧㽏䁁䄹䉃䍋䑅");
				a1344.a1271.Parameters.Add(a1439("HŅɄ\u0342шՁ\u064eݕࡄ\u094d\u0a55\u0b4d\u0c40൞\u0e5cཋ၅"), SqlDbType.Int).Value = num;
				a1344.a1271.Parameters.Add(a1439("KŅ"), SqlDbType.Int).Value = Convert.ToInt32(a1358.GetRowCellValue(i, a1439("KŅ")));
				a1344.a1271.ExecuteNonQuery();
			}
		}
		MessageBox.Show(a1439("š\u000fȣ\u032bРլ؟ܫࠤऩਪପతപว\u0e73ၯᅠታፗᑎᕈᙞ\u175eᡜᥓ\u1a5eᬖᱡ\u1dc8Ṟἒ⁺⅑≝⍚␍╧♊❓⤘⥜⩋⭇ⱗⰕ⸃⽠\u3040み㉴㍿㐽㕾㙲㝨㠹㥕㩲㭤㱾㵱㹩㽷䀱䅄䉽䍯䑣䕿䙭䝯䡻䤨䩂䭢䱬䵨乧佫倯"), a1439("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		a1403();
	}

	public void a1402()
	{
		a1344.a1307();
		a1344.a1271.CommandText = a1439("}Ũɠ\u036eѩս؈ݦࡢ६\u0a04\u0b65\u0c70൮\u0e6d\u0f3f၇ᅈ\u1257ፗᑟᕔᙝᝈᡛᥐᩆ᭘᱗ᵋḰ\u1f58⁆ⅈ≞⍎\u242a╈♃❓⡏⥃⨹⬤ⰳ\u2d26");
		DataTable dataTable = a2147.a2105(a1344.a1271);
		ToolStripItem[] array = new ToolStripItem[dataTable.Rows.Count];
		for (int i = 0; i < dataTable.Rows.Count; i++)
		{
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(dataTable.Rows[i][0].ToString());
			toolStripMenuItem.Click += a1401;
			toolStripMenuItem.Image = a2268.a2313;
			array[i] = toolStripMenuItem;
		}
		a1395.DropDownItems.AddRange(array);
	}

	public void a1403()
	{
		if (!a1396)
		{
			return;
		}
		a1377.SelectedIndex = a1375.SelectedIndex;
		a1374.SelectedIndex = a1355.SelectedIndex;
		int focusedRowHandle = a1358.FocusedRowHandle;
		a1344.a1307();
		a1344.a1271.CommandText = a1439("\u0086Ƕˡϯӧע۴\u07bf\u08cc\u09d2\u0acb\u0bc4\u0cd4\u0dcc໕࿕დᇇኼᎺᒲᗞᛆ\u17caᣜ\u19ad᪤ᯄ\u1cd8\u1dcdọ\u1fd5₦⇇⋝⎣ⓖ▰⚮✾⠺⤮⨳⬢ⰻⴽ⹑⽗〥ㄼ㈦㌲㑞㔥㙁㝁㠧㤩㩀㬿㱛㵇㸼㼤䀭䄬䈩䌯䐫䔪䙌䜋䡯䥳䨝䬟䰉䴖丁伖倒兹刀卢呼唚嘑圝堚夃娃嬃小崑幤弓恷慫戏挂搐攕星杸桬楨橬欗氚浲湹潥灢煲牦獦瑢甌癤眝砀祦穭筹籾絶繯罵聳腵艻荢葦蕨蘌蝋蠯褳詞譔豖赌蹕輻遂鄤鈺鍀鑛镟陙靉頢餭驕魞鱁鵄鹍齕ꁍꅀꉞꌾꐪꕒꙅꞳ\ua8bb\ua9beꪨꯛ겻궽꺱꿗낰놧늻뎾듒떨뚥랤뢢릨몡뮮벵붤뺭뾵삭솠슾쏃쒵얩욥잍좛짽쪕쮟쳧춍컩쿹킏톀튟펟풗햜횕힐\ud883\ud988\uda9e\udb80\udc8f\udd93\ude97\udf8e\ue082\ue1ec\ue2e8\ue39a\ue497\ue58a\ue68c\ue7fa\ue8f3\ue9f8\ueae3\uebf6\uecff\uedeb\ueef3\ueff2\uf0ec\uf1ea\uf2fd\uf3f7\uf49e\uf591\uf6f2\uf7ee\uf8e5理\ufaf5ﯮﲆ﷽ﻩ\ufff5ïǭ\u02f7Ϣӣ\u05f5ڌߌ\u08d1\u09d3\u0ac3\u0bdf\u0ccf\u0dcaໝ࿙\u10c9ᇘዝᏘᓆᗐᛂឣᣌᧁ\u1ac3ᯀ\u1ccfᶴịῈ\u20c8⇓⋁⏑ⓖ▩⛂✶⠪⥑⩔⬸ⰻ\u2d2a⸽⽗〡ㄽ㈱㌽㑒㔥㙁㝁㠬㤡㨣㬠㰯㵔㹏㽗䁁䅅䈰䌫䐧䔯䙀䝯䡾䤘䨐䬈䰟䵹乩佷倓儛刐卺呻啱嘖圝堁夀婬嬀尃崚币弋怃愗扤挗摳敡昌杺桸楩樜歱汵浰湶漗災煴牦獧瑭當癢睺硾礍穸笙簊給繦缇耎腱舕茍葩蕠虲蝋衁襚詎譎豊贤蹌輥逸酜鉐錺鐲镆陘靊顜饈騬魟鰻鴧鹉齌ꁒꅌꉂꌾꐳꔡ");
		if (a1392.Text != a1439("MšɳͱѨ"))
		{
			SqlCommand a2269 = a1344.a1271;
			a2269.CommandText = a2269.CommandText + a1439("/ŏɃ\u0348Ы՞ظܦࡅ\u0949\u0a49\u0b51\u0c4e\u0d3fฦ") + a1392.Text + a1439("&");
		}
		if (a1391.Text != a1439("MšɳͱѨ"))
		{
			SqlCommand a2270 = a1344.a1271;
			object commandText = a2270.CommandText;
			a2270.CommandText = string.Concat(commandText, a1439("/ŏɃ\u0348Ы՞ظܦࡔ\u094f\u0a4b\u0b4d\u0c45\u0d3fฦ"), Convert.ToInt32(a1391.Text), a1439("&"));
		}
		if (a1388.Text != a1439(""))
		{
			SqlCommand a2271 = a1344.a1271;
			a2271.CommandText = a2271.CommandText + a1439("7ŗɛ\u0350гՆؠ\u073eࡎ\u094aਫ਼\u0b43\u0c52\u0d4b\u0e4d༨။ᅏ\u124eፁᐣᔥᘤ") + a1388.Text + a1439("'Ħ");
		}
		if (a1389.Text != a1439(""))
		{
			SqlCommand a2272 = a1344.a1271;
			a2272.CommandText = a2272.CommandText + a1439("8Ŗɘ\u0351дՇأ\u073fࡄ\u094c\u0a45\u0b44\u0c41\u0d47ใགဨᅋ\u124fፎᑁᔣᘥᜤ") + a1389.Text + a1439("'Ħ");
		}
		if (a1387.Text != a1439(""))
		{
			SqlCommand a2273 = a1344.a1271;
			a2273.CommandText = a2273.CommandText + a1439("9řə\u0352еՀآ\u073c\u085a\u0951\u0a5d\u0b5a\u0c43\u0d43ใཏၑᄨቋፏᑎᕁᘣᜥᠤ") + a1387.Text + a1439("'Ħ");
		}
		if (a1375.Text != a1439("MšɳͱѨ") && a1375.Text != a1439(""))
		{
			SqlCommand a2274 = a1344.a1271;
			object commandText = a2274.CommandText;
			a2274.CommandText = string.Concat(commandText, a1439(";śɗ\u035cзՂؤ\u073aࡊ\u0947ਗ਼ଡ଼\u0c4a\u0d43\u0e48ན၆ᅏቛፃᑂᕜᙚᝍᡇ\u193fᨦ"), Convert.ToInt32(a1377.Text), a1439("&"));
		}
		if (a1355.Text != a1439("MšɳͱѨ") && a1355.Text != a1439(""))
		{
			SqlCommand a2275 = a1344.a1271;
			object commandText = a2275.CommandText;
			a2275.CommandText = string.Concat(commandText, a1439(",ŊɄ\u034dШՓشܫࡍ\u0947\u0a3fଦ"), Convert.ToInt32(a1374.Text), a1439("&"));
		}
		a1344.a1271.CommandText += a1439("5śɁ\u0356єՂد\u074cࡔब\u0a5f\u0b3bధ\u0d49ใཕ၊ᅝቂፆᐡ");
		DataTable dataSource = a2147.a2105(a1344.a1271);
		a1357.DataSource = dataSource;
		try
		{
			a1358.FocusedRowHandle = focusedRowHandle;
		}
		catch
		{
		}
	}

	public void a1404()
	{
		if (a1358.RowCount <= 0)
		{
			return;
		}
		int num = Convert.ToInt32(a1358.GetFocusedRowCellValue(a1439("KŅ")).ToString());
		if (MessageBox.Show(a1439("\0Ģȹ\u033dЭԫأܫ\u0821भ\u0a62କ\u0cbc\u0d52พ\u0f76ၝᅉ\u124eፕᑙᕅᘖ\u1777ᡘᥜ\u1a59᭔ᰐᵪṊὄ\u2040ⅎ≉⍌⑃┋☆❡⡁⥕⩃⭌Ⰰⵚ\u2e6a⽰べㅰ㈺㈩㑫㕣㙳㝱㡽㠌㩻㭿㱹㵵㹫㼭䁉䅦䉣䍧䑥䕮䙵䝬䡪䥪䩸䬯"), a1439("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.Cancel)
		{
			a1374.SelectedIndex = a1355.SelectedIndex;
			a1377.SelectedIndex = a1375.SelectedIndex;
			string text = a1439("xżɯ\u036bѽխ؇ݭ\u086cॷ੪୮\u0c64൲฿ཌྷ\u1058ᅈሻፘᑕᕗᙜ\u1753ᠨ\u1933ᨢ\u1b35\u1c31ᵇṇὋ\u205fⅉ∫⍁⑈╚♓❙⡂⥖⩖⭒ⰼ") + Convert.ToInt32(a1374.Text) + a1439("!");
			if (a1375.Text != a1439("MšɳͱѨ"))
			{
				object obj = text;
				text = string.Concat(obj, a1439("7ŗɛ\u0350гՋلݛࡃ\u094b\u0a40\u0b49\u0c54\u0d47\u0e4cཚ၌ᅃ\u125f\u135bᑊᕆᘼ"), Convert.ToInt32(a1377.Text), a1439("!"));
			}
			a2147.a2128(text, a1439("Sŵɠ\u0362Ѷդ"));
			a1403();
		}
	}

	public void a1405()
	{
		if (a1358.RowCount <= 0)
		{
			return;
		}
		int num = Convert.ToInt32(a1358.GetFocusedRowCellValue(a1439("KŅ")).ToString());
		if (MessageBox.Show(a1439("\0Ģȹ\u033dЭԫأܫ\u0821भ\u0a62କ\u0cbc\u0d52พ\u0f76ၝᅉ\u124eፕᑙᕅᘖ\u1774ᡟ᥇\u1a5b᭗ᰐᵪṊὄ\u2040ⅎ≉⍌⑃┋☆❡⡁⥕⩃⭌Ⰰⵚ\u2e6a⽰べㅰ㈺㈩㑫㕣㙳㝱㡽㠌㩻㭿㱹㵵㹫㼭䁉䅦䉣䍧䑥䕮䙵䝬䡪䥪䩸䬯"), a1439("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.Cancel)
		{
			a1374.SelectedIndex = a1355.SelectedIndex;
			a1377.SelectedIndex = a1375.SelectedIndex;
			string text = a1439("xżɯ\u036bѽխ؇ݭ\u086cॷ੪୮\u0c64൲฿ཌྷ\u1058ᅈሻፘᑕᕗᙜ\u1753ᠨ\u1933ᨣ\u1b35\u1c31ᵇṇὋ\u205fⅉ∫⍁⑈╚♓❙⡂⥖⩖⭒ⰼ") + Convert.ToInt32(a1374.Text) + a1439("!");
			if (a1375.Text != a1439("MšɳͱѨ"))
			{
				object obj = text;
				text = string.Concat(obj, a1439("7ŗɛ\u0350гՋلݛࡃ\u094b\u0a40\u0b49\u0c54\u0d47\u0e4cཚ၌ᅃ\u125f\u135bᑊᕆᘼ"), Convert.ToInt32(a1377.Text), a1439("!"));
			}
			a2147.a2128(text, a1439("Sŵɠ\u0362Ѷդ"));
			a1403();
		}
	}

	public void a1406()
	{
		if (a1358.RowCount > 0)
		{
			int num = Convert.ToInt32(a1358.GetFocusedRowCellValue(a1439("KŅ")).ToString());
			if (MessageBox.Show(a1439("\u0012ĥ\u02d8\u0357ёՕ؛ݱࡘ\u094a\u0a43ଖ\u0c74ൟ\u0e47ཛ\u1057ᄐቪፊᑄᕀᙎᝉᡌ\u1943ᨋᬆᱡᵁṕὃ⁌℀≚⍪⑰╹♰✺⤩⥫⩣⭳ⱱ\u2d7d⼌⽻みㅹ㉵㍫㐭㕉㙦㝣㡧㥥㩮㭵㱬㵪㹪㽸䀯"), a1439("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.Cancel)
			{
				a2147.a2128(a1439("sŵɠ\u0362Ѷդ\u0600ݔࡗ\u094e\u0a55\u0b57\u0c5f\u0d4b\u0e38ངၓᅁሴፑᑞᕞᙛᝊᠳ\u192aᨽᬬ\u1c2aᵞṀὂ\u2054⅀∤⍊⑆┼") + num, a1439("Sŵɠ\u0362Ѷդ"));
				a1403();
			}
		}
	}

	public void a1407()
	{
		if (a1358.RowCount > 0)
		{
			int num = Convert.ToInt32(a1358.GetFocusedRowCellValue(a1439("KŅ")).ToString());
			if (MessageBox.Show(a1439("\u0012ĥ\u02d8\u0357ёՕ؛ݱࡘ\u094a\u0a43ଖ\u0c74ൟ\u0e47ཛ\u1057ᄐቪፊᑄᕀᙎᝉᡌ\u1943ᨋᬆᱡᵁṕὃ⁌℀≚⍪⑰╹♰✺⤩⥫⩣⭳ⱱ\u2d7d⼌⽻みㅹ㉵㍫㐭㕉㙦㝣㡧㥥㩮㭵㱬㵪㹪㽸䀯"), a1439("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.Cancel)
			{
				a2147.a2128(a1439("sŵɠ\u0362Ѷդ\u0600ݔࡗ\u094e\u0a55\u0b57\u0c5f\u0d4b\u0e38ངၓᅁሴፑᑞᕞᙛᝊᠳ\u192aᨼᬬ\u1c2aᵞṀὂ\u2054⅀∤⍊⑆┼") + num, a1439("Sŵɠ\u0362Ѷդ"));
				a1403();
			}
		}
	}

	private void a1410(object a1408, EventArgs a1409)
	{
		Close();
	}

	private void a1413(object a1411, EventArgs a1412)
	{
		a1404();
	}

	private void a1416(object a1414, EventArgs a1415)
	{
		a1406();
	}

	private void a1419(object a1417, EventArgs a1418)
	{
		a1407();
	}

	private void a1422(object a1420, EventArgs a1421)
	{
		a1405();
	}

	private void a1425(object a1423, EventArgs a1424)
	{
		a1403();
	}

	private void a1428(object a1426, EventArgs a1427)
	{
		a1403();
	}

	private void a1431(object a1429, EventArgs a1430)
	{
		a1387.Text = a1344.a1303();
	}

	private void a1434(object a1432, EventArgs a1433)
	{
	}

	private void a1437(object a1435, EventArgs a1436)
	{
		a1396 = true;
		a1403();
	}

	private static string a1439(string a1438)
	{
		int length = a1438.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a1438[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
