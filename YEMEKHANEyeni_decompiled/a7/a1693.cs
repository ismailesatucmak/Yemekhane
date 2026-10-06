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

public class a1693 : XtraForm
{
	private int a1640;

	private IContainer a1641 = null;

	public GridView a1642;

	private GridColumn a1643;

	private GridColumn a1644;

	private GridColumn a1645;

	private GridColumn a1646;

	private GridColumn a1647;

	public GridControl a1648;

	public ContextMenuStrip a1649;

	private ToolStripMenuItem a1650;

	public ToolStripMenuItem a1651;

	public GroupBox a1652;

	public Label a1653;

	public Label a1654;

	public Label a1655;

	public Label a1656;

	public Label a1657;

	public Label a1658;

	public Label a1659;

	public TextBox a1660;

	public Panel a1661;

	public Button a1662;

	public Button a1663;

	private MaskedTextBox a1664;

	private MaskedTextBox a1665;

	public Label a1666;

	private PictureBox a1667;

	public Label a1668;

	public a1693()
	{
		a1690();
		a1984.a1891(this);
		a1640 = -1;
		a1669();
	}

	public void a1669()
	{
		a1344.a1307();
		a1344.a1271.CommandText = a1692("ožɶͼѻգ\u0616ݼࡰट\u0a7d୶\u0c65ൡข\u0f6f\u106dᅸቹ፨ᑩᕳᘊᝧᡭ\u1977\u1a71᭠ᱡᵋḲ\u1f5c⁗⅏≓⍟\u2438║♄❚⡙⤳⩝⭖ⱅⵁ⸮⽚いㅎ㉘㍌㐨㕆㙍㝑㡍㥅㨿㬰");
		DataTable dataSource = a2147.a2105(a1344.a1271);
		a1648.DataSource = dataSource;
	}

	public void a1670()
	{
		try
		{
			a1640 = Convert.ToInt32(a1642.GetFocusedRowCellValue(a1692("KŅ")).ToString());
			a1660.Text = a1642.GetFocusedRowCellValue(a1692("Kńɗ\u034f")).ToString();
			a1665.Text = a1642.GetFocusedRowCellValue(a1692("EŇɖ\u0357тՃ\u0655")).ToString();
			a1664.Text = a1642.GetFocusedRowCellValue(a1692("Eŏɑ\u0357тՃ\u0655")).ToString();
		}
		catch
		{
			a1640 = -1;
		}
	}

	public void a1671()
	{
		if (a1660.Text == a1692(""))
		{
			MessageBox.Show(a1692("Vǥɬͱѳջش߅ऍ৭\u0a7eଯ\u0c4f൩༽ཥᄻᄩ\u124f፮ᑴᕬᙪᝪᡸ\u192f"));
			a1660.Focus();
			return;
		}
		if (a1665.Text == a1692("") || a1664.Text == a1692(""))
		{
			MessageBox.Show(a1692("dǛɒ\u0343сՍ\u0602ݲࡁॾ੪ଽౝ൩\u0e7b\u0f75ᄩᅼቺ፴ᑦᐢᙼᘠᠰ᥄\u1a61᭣ᱸᵹṥὥ\u2028⅂≢⍬⑪╪♸✯"));
			a1665.Focus();
			return;
		}
		a1344.a1307();
		if (a1640 < 0)
		{
			a1344.a1271.CommandText = a1692("tĚȜ\u0302Еԝ\u061aݭࠅअਞଆ౨ഈก༐ညᅫልጆᐕᕱᘒ\u177f\u187dᥨ\u1a69᭸ᱹᵣḚί⁽Ⅷ≡⍰⑱╻☂❬⡧⥿⩣⭯Ⰱⴇ\u2e70⽤とㅶ㉧㍲㐈㕟㙑㝚㡉㥕㨶㭙㱚㵖㹅㽆䁕䅒䉆䌽䑐䕍䙇䝙䡟䥊䩋䭝䰤䵇乇低偐兊剄匨");
		}
		else
		{
			a1344.a1271.CommandText = a1692("wăȅ\u0310ВԆ\u0614ݰࠀउਘ\u0b02౫ങฌ༜\u1067ᄉሂ\u1311ᐍᕿᘁᜏᡸᥫ\u1a73ᬐᱹᵻṪὫ⁶ⅷ≡⌉⑳╰♰❣⡼⥯⩬⭸Ⰷ\u2d68\u2e60⽼ぴㅧ㉤㍰㐞㕢㙣㝩㡋㥍㩜㭝㱏㴶㹘㽓䁃䅟䉓䌩䑓䕓䙚䝄䡆䥈䨭䭛䱃䵏乛位倧兏剁匹呃啋噅");
			a1344.a1271.Parameters.Add(a1692("KŅ"), SqlDbType.Int).Value = a1640;
		}
		a1344.a1271.Parameters.Add(a1692("Kńɗ\u034f"), SqlDbType.VarChar).Value = a1660.Text;
		try
		{
			a1344.a1271.Parameters.Add(a1692("EŇɖ\u0357тՃ\u0655"), SqlDbType.Time).Value = Convert.ToDateTime(a1665.Text).ToString(a1692("MŌȹ\u036fѬ"));
			a1344.a1271.Parameters.Add(a1692("Eŏɑ\u0357тՃ\u0655"), SqlDbType.Time).Value = Convert.ToDateTime(a1664.Text).ToString(a1692("MŌȹ\u036fѬ"));
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			return;
		}
		a1344.a1271.Parameters.Add(a1692("Dŏɗ\u034bч"), SqlDbType.Int).Value = 1;
		try
		{
			a1344.a1271.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
		a1640 = -1;
		a1669();
		a1673();
	}

	public void a1672()
	{
		try
		{
			long num = Convert.ToInt64(a1642.GetFocusedRowCellValue(a1692("KŅ")).ToString());
			if (MessageBox.Show(a1692("eŌɕȚўՅܙ܇\u08f0࠺\u0ad8\u0b4dೞ\u0d01๓\u0f76\u1072ᅰቹ፰ᐺᐩᙫᝣᡳᥱ\u1a7dᨌᱻᵿṹή\u206bℭ≉⍦④╧♥❮⡵⥬⩪⭪ⱸ\u2d2f"), a1692("]žɧͷԵԣظܡ"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.Cancel)
			{
				return;
			}
			a1344.a1307();
			a1344.a1271.CommandText = a1692("\u0005űɳ\u0366Ѡմ\u065a\u073eࡒज़\u0a4e\u0b54హ\u0d4b๒ག\u1035ᅕቘፆᑘᕖᘲ\u173eᠭᥛᩃ᭏ᱛᵍḧ\u1f4f⁁ℹ≃⍋⑅");
			a1344.a1271.Parameters.Add(a1692("KŅ"), SqlDbType.Int).Value = num;
			a1344.a1271.ExecuteNonQuery();
		}
		catch
		{
		}
		a1669();
		a1673();
	}

	public void a1673()
	{
		a1660.Text = a1692("");
		a1665.Text = a1692("");
		a1664.Text = a1692("");
	}

	private void a1676(object a1674, EventArgs a1675)
	{
		Close();
	}

	private void a1679(object a1677, EventArgs a1678)
	{
		a1671();
	}

	private void a1682(object a1680, EventArgs a1681)
	{
		a1672();
	}

	private void a1685(object a1683, EventArgs a1684)
	{
		a1670();
	}

	private void a1688(object a1686, EventArgs a1687)
	{
		a1670();
	}

	protected override void Dispose(bool a1689)
	{
		if (a1689 && a1641 != null)
		{
			a1641.Dispose();
		}
		base.Dispose(a1689);
	}

	private void a1690()
	{
		a1641 = new Container();
		GridLevelNode gridLevelNode = new GridLevelNode();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(a1693));
		a1642 = new GridView();
		a1643 = new GridColumn();
		a1644 = new GridColumn();
		a1645 = new GridColumn();
		a1646 = new GridColumn();
		a1647 = new GridColumn();
		a1648 = new GridControl();
		a1649 = new ContextMenuStrip(a1641);
		a1650 = new ToolStripMenuItem();
		a1651 = new ToolStripMenuItem();
		a1652 = new GroupBox();
		a1667 = new PictureBox();
		a1664 = new MaskedTextBox();
		a1663 = new Button();
		a1665 = new MaskedTextBox();
		a1666 = new Label();
		a1653 = new Label();
		a1654 = new Label();
		a1655 = new Label();
		a1668 = new Label();
		a1656 = new Label();
		a1657 = new Label();
		a1658 = new Label();
		a1659 = new Label();
		a1660 = new TextBox();
		a1661 = new Panel();
		a1662 = new Button();
		((ISupportInitialize)a1642).BeginInit();
		((ISupportInitialize)a1648).BeginInit();
		a1649.SuspendLayout();
		a1652.SuspendLayout();
		((ISupportInitialize)a1667).BeginInit();
		a1661.SuspendLayout();
		SuspendLayout();
		a1642.BorderStyle = BorderStyles.NoBorder;
		a1642.Columns.AddRange(new GridColumn[5] { a1643, a1644, a1645, a1646, a1647 });
		a1642.FocusRectStyle = DrawFocusRectStyle.RowFocus;
		a1642.GridControl = a1648;
		a1642.Name = a1692("nźɮ\u0362ѓխ٦ݵ࠰");
		a1642.OptionsBehavior.Editable = false;
		a1642.OptionsCustomization.AllowFilter = false;
		a1642.OptionsCustomization.AllowGroup = false;
		a1642.OptionsCustomization.AllowRowSizing = true;
		a1642.OptionsCustomization.AllowSort = false;
		a1642.OptionsFilter.AllowFilterEditor = false;
		a1642.OptionsView.ShowGroupPanel = false;
		a1643.Caption = a1692("KŅ");
		a1643.FieldName = a1692("KŅ");
		a1643.Name = a1692("lŸɠ\u036cфթ٩ݱ\u086e६ਰ");
		a1644.Caption = a1692("Ò\u001c\u02fe\u036f");
		a1644.FieldName = a1692("Kńɗ\u034f");
		a1644.Name = a1692("lŸɠ\u036cфթ٩ݱ\u086e६ਲ਼");
		a1644.Visible = true;
		a1644.VisibleIndex = 0;
		a1645.Caption = a1692("Mů\u0352\u0360Ѫդٮع\u08e0द\u0a56\u0b65\u0c62൶\u0e68");
		a1645.FieldName = a1692("EŇɖ\u0357тՃ\u0655");
		a1645.Name = a1692("lŸɠ\u036cфթ٩ݱ\u086e६ਲ");
		a1645.Visible = true;
		a1645.VisibleIndex = 1;
		a1646.Caption = a1692("Iţɽ\u0361\u0558Ԧ\u0656ݥࡢॶ੨");
		a1646.FieldName = a1692("Eŏɑ\u0357тՃ\u0655");
		a1646.Name = a1692("lŸɠ\u036cфթ٩ݱ\u086e६ਵ");
		a1646.Visible = true;
		a1646.VisibleIndex = 2;
		a1647.Caption = a1692("Důɷ\u036bѧ");
		a1647.FieldName = a1692("Dŏɗ\u034bч");
		a1647.Name = a1692("lŸɠ\u036cфթ٩ݱ\u086e६\u0a34");
		a1648.ContextMenuStrip = a1649;
		a1648.EmbeddedNavigator.Name = a1692("");
		a1648.Font = new Font(a1692("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		gridLevelNode.RelationName = a1692("JŠɲ\u0366Ѯ\u0530");
		a1648.LevelTree.Nodes.AddRange(new GridLevelNode[1] { gridLevelNode });
		a1648.Location = new Point(9, 193);
		a1648.LookAndFeel.SkinName = a1692("GżɻͳѯՖ٭ݨ\u086b९");
		a1648.LookAndFeel.UseDefaultLookAndFeel = false;
		a1648.MainView = a1642;
		a1648.Name = a1692("kŹɣ\u036dыը٨ݱࡶ६੮ର");
		a1648.Size = new Size(352, 164);
		a1648.TabIndex = 3;
		a1648.ViewCollection.AddRange(new BaseView[1] { a1642 });
		a1648.DoubleClick += a1688;
		a1649.Items.AddRange(new ToolStripItem[2] { a1650, a1651 });
		a1649.Name = a1692("rſɡͺѨմٿ\u0747\u086c०ੲ\u0b55\u0c71൶\u0e6a\u0f72\u1030");
		a1649.Size = new Size(137, 80);
		a1650.Image = a2268.a2289;
		a1650.ImageScaling = ToolStripItemImageScaling.None;
		a1650.Name = a1692("~Ǥɹ\u0375Ѱոٿݷࡅॿ\u0a60\u0b62\u0c5e൸\u0e79ལၹᅅቢ፨ᑰᕍᙷᝧᡬ");
		a1650.Size = new Size(136, 38);
		a1650.Text = a1692("Oǻɨ\u0366ѡկٮݤ");
		a1650.Click += a1685;
		a1651.Image = a2268.a2341;
		a1651.ImageScaling = ToolStripItemImageScaling.None;
		a1651.Name = a1692("gźɾ\u0345ѿՠ٢ݞࡸॹ\u0a63\u0b79\u0c45\u0d62\u0e68\u0f70၍ᅷቧ፬");
		a1651.Size = new Size(136, 38);
		a1651.Text = a1692("Pūɭ");
		a1651.Click += a1682;
		a1652.Controls.Add(a1667);
		a1652.Controls.Add(a1664);
		a1652.Controls.Add(a1663);
		a1652.Controls.Add(a1665);
		a1652.Controls.Add(a1648);
		a1652.Controls.Add(a1666);
		a1652.Controls.Add(a1653);
		a1652.Controls.Add(a1654);
		a1652.Controls.Add(a1655);
		a1652.Controls.Add(a1668);
		a1652.Controls.Add(a1656);
		a1652.Controls.Add(a1657);
		a1652.Controls.Add(a1658);
		a1652.Controls.Add(a1659);
		a1652.Controls.Add(a1660);
		a1652.Location = new Point(6, 2);
		a1652.Name = a1692("nźɨͳѵՆ٬ݺ࠰");
		a1652.Size = new Size(557, 418);
		a1652.TabIndex = 0;
		a1652.TabStop = false;
		a1667.Image = (Image)componentResourceManager.GetObject(a1692("aŹɬͺѸվٮ\u0748ࡦ॰ਸ਼ନ\u0c4c൩\u0e62ཥ\u1064"));
		a1667.InitialImage = null;
		a1667.Location = new Point(395, 20);
		a1667.Name = a1692("{ţɪͼѲմ٠\u0746\u086cॺਰ");
		a1667.Size = new Size(143, 142);
		a1667.TabIndex = 61;
		a1667.TabStop = false;
		a1664.Font = new Font(a1692("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a1664.Location = new Point(101, 99);
		a1664.Mask = a1692("5Ĵȹ\u0332б");
		a1664.Name = a1692("~űɼ\u0345ѯձ\u0657ݢࡣॵ");
		a1664.Size = new Size(53, 26);
		a1664.TabIndex = 2;
		a1664.ValidatingType = typeof(DateTime);
		a1663.Location = new Point(161, 99);
		a1663.Name = a1692("kżɩ\u034dѤս٧ݧࡵ");
		a1663.Size = new Size(75, 27);
		a1663.TabIndex = 0;
		a1663.Text = a1692("MŤɽ\u0367ѧյ");
		a1663.UseVisualStyleBackColor = true;
		a1663.Click += a1679;
		a1665.Font = new Font(a1692("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a1665.Location = new Point(101, 67);
		a1665.Mask = a1692("5Ĵȹ\u0332б");
		a1665.Name = a1692("~űɼ\u0345ѧն\u0657ݢࡣॵ");
		a1665.Size = new Size(53, 26);
		a1665.TabIndex = 1;
		a1665.ValidatingType = typeof(DateTime);
		a1666.AutoSize = true;
		a1666.Location = new Point(6, 145);
		a1666.Name = a1692("jŤɦ\u0366ѮԶ");
		a1666.Size = new Size(257, 13);
		a1666.TabIndex = 59;
		a1666.Text = a1692("~őɅ\u035fљՑ\u065dܒࣇ\u082f\u0ad3\u0b40\u0c0dൎโཆ၎ᅁቋፃᑗᕍᙍᝋ᠁᥄\u1a7e᭶ᱼᴼṨή⁷Ⅺ≶⌶⑲◨♽❱⡴⥼⩣⭫ⱴ\u2d69\u2e69⽣づㅡ㉵㍵㑬㕪㙪㝸㠯");
		a1653.AutoSize = true;
		a1653.Location = new Point(6, 389);
		a1653.Name = a1692("jŤɦ\u0366ѮԲ");
		a1653.Size = new Size(323, 26);
		a1653.TabIndex = 59;
		a1653.Text = a1692("²|ʞ\u030fрԋؿ\u0733७शਸ਼ସవശ\u0e3a༴ဦ\u1062ሼጵᐱᕯᘬᜬᤓ\u1927ᨫᬧ\u1c2fᱶạὥ′Ω≢⌣␩╋♗♢⠜⥈⩛⭘ⱌⵛ⹓⽇そㅝ㉛㌑㑉㕊㙃㝈㡇㥃㩋㭇㱍㵉㹏㽋䀄䄮䈨䍒䑅䕭䙨䝴䡯䤻䩩䭸䱹䵣乺佰偦兺剼却吰啨囸坿塩夫婫孰屩嵵幪彤恽怲扬振");
		a1654.AutoSize = true;
		a1654.Font = new Font(a1692("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a1654.Location = new Point(6, 176);
		a1654.Name = a1692("jŤɦ\u0366Ѯ\u0530");
		a1654.Size = new Size(75, 13);
		a1654.TabIndex = 55;
		a1654.Text = a1692("Ú\u0014\u02f6\u0367ШՋٯݶࡰ०\u0a71୨");
		a1655.BackColor = Color.FromArgb(128, 255, 128);
		a1655.BorderStyle = BorderStyle.Fixed3D;
		a1655.FlatStyle = FlatStyle.Flat;
		a1655.ForeColor = Color.DarkOrange;
		a1655.Location = new Point(9, 168);
		a1655.Name = a1692("kŧɧ\u0361ѯԳز");
		a1655.Size = new Size(350, 3);
		a1655.TabIndex = 54;
		a1668.AutoSize = true;
		a1668.Font = new Font(a1692("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a1668.Location = new Point(6, 373);
		a1668.Name = a1692("jŤɦ\u0366ѮԸ");
		a1668.Size = new Size(46, 13);
		a1668.TabIndex = 51;
		a1668.Text = a1692("]žɧͷԵԣظܡ");
		a1656.AutoSize = true;
		a1656.Font = new Font(a1692("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a1656.Location = new Point(10, 13);
		a1656.Name = a1692("jŤɦ\u0366ѮԹ");
		a1656.Size = new Size(80, 13);
		a1656.TabIndex = 51;
		a1656.Text = a1692("Ø\u0012\u02f0\u0365ЪՋ١ݫࡡ६੨୦\u0c70൨");
		a1657.AutoSize = true;
		a1657.Location = new Point(18, 107);
		a1657.Name = a1692("jŤɦ\u0366ѮԴ");
		a1657.Size = new Size(53, 13);
		a1657.TabIndex = 49;
		a1657.Text = a1692("Iţɽ\u0361\u0558Ԧ\u0656ݥࡢॶ੨");
		a1658.AutoSize = true;
		a1658.Location = new Point(18, 75);
		a1658.Name = a1692("jŤɦ\u0366ѮԵ");
		a1658.Size = new Size(78, 13);
		a1658.TabIndex = 49;
		a1658.Text = a1692("Mů\u0352\u0360Ѫդٮع\u08e0द\u0a56\u0b65\u0c62൶\u0e68");
		a1659.AutoSize = true;
		a1659.Location = new Point(18, 43);
		a1659.Name = a1692("jŤɦ\u0366ѮԷ");
		a1659.Size = new Size(51, 13);
		a1659.TabIndex = 49;
		a1659.Text = a1692("Þ\u0018\u02fa\u036bФՂ٦ذ");
		a1660.Font = new Font(a1692("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a1660.Location = new Point(101, 35);
		a1660.Name = a1692("~űɼ\u0348ѡհ٪\u0742ࡦ२");
		a1660.Size = new Size(223, 26);
		a1660.TabIndex = 0;
		a1661.BackColor = Color.FromArgb(233, 235, 236);
		a1661.Controls.Add(a1662);
		a1661.Dock = DockStyle.Bottom;
		a1661.Location = new Point(0, 431);
		a1661.Name = a1692("vŤɪ\u0366Ѯ\u0530");
		a1661.Size = new Size(573, 37);
		a1661.TabIndex = 1;
		a1662.Dock = DockStyle.Fill;
		a1662.Location = new Point(0, 0);
		a1662.Name = a1692("jųɨ\u0346ѭը٫ݲ");
		a1662.Size = new Size(573, 37);
		a1662.TabIndex = 1;
		a1662.Text = a1692("Â5ɨȳ՞");
		a1662.UseVisualStyleBackColor = true;
		a1662.Click += a1676;
		Appearance.BackColor = Color.White;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(573, 468);
		Controls.Add(a1652);
		Controls.Add(a1661);
		MaximizeBox = false;
		Name = a1692("VŽɣ\u0342ѫվ٤ݝࡩ३੯୨౨\u0d62\u0e6fའ");
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a1692("Ø\u0012\u02f0\u0365Ъ՝٩ݩष२੨\u0b62౯ൠ");
		((ISupportInitialize)a1642).EndInit();
		((ISupportInitialize)a1648).EndInit();
		a1649.ResumeLayout(performLayout: false);
		a1652.ResumeLayout(performLayout: false);
		a1652.PerformLayout();
		((ISupportInitialize)a1667).EndInit();
		a1661.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	private static string a1692(string a1691)
	{
		int length = a1691.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a1691[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
