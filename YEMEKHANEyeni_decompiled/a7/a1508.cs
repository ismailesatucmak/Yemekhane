using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using a7.a2096;

namespace a7;

public class a1508 : XtraForm
{
	private long a1443 = 0L;

	private IContainer a1444 = null;

	public GridView a1445;

	public GridControl a1446;

	public ContextMenuStrip a1447;

	private ToolStripMenuItem a1448;

	public ToolStripMenuItem a1449;

	public GroupBox a1450;

	public Label a1451;

	public Label a1452;

	public Label a1453;

	public Label a1454;

	public Label a1455;

	public Label a1456;

	public Label a1457;

	public TextBox a1458;

	public TextBox a1459;

	public Panel a1460;

	public Button a1461;

	public Button a1462;

	private GridColumn a1463;

	private GridColumn a1464;

	private GridColumn a1465;

	private GridColumn a1466;

	public System.Windows.Forms.ComboBox a1467;

	public System.Windows.Forms.ComboBox a1468;

	private GridColumn a1469;

	private PictureBox a1470;

	private CheckBox a1471;

	private GridColumn a1472;

	private CheckBox a1473;

	private GridColumn a1474;

	public Label a1475;

	public TextBox a1476;

	private GridColumn a1477;

	public a1508()
	{
		a1505();
		a1984.a1891(this);
		a1984.a1964(a1507("}Ũɠ\u036eѩս؈ݬࡧॷ\u0a70\u0b7c౭ൻ\u0e65ནၒᅔ\u1257ጷᑑᕘᙊᝃᡉᥑᩁ\u1b41᱇ᵜḰὉ⁜⅂≁⌫⑁╈♚❓⡙⥁⩑⭑ⱗⵌ"), a1467, a1468);
		a1478();
	}

	public void a1478()
	{
		int focusedRowHandle = a1445.FocusedRowHandle;
		DataTable dataSource = a2147.a2105(a1507("\u0015ŧɶ;Ѵճٻ\u070eࡤ२ਇୡ౨ൺ\u0e73\u0f79\u1062ᅶቶ፲ᑾᕡᙛ\u1757ᠱᥗ\u1a5aᭈᱍᵜṂὄ\u2040⅙∮⌺⑂╕♃❋⡎⥘⨫⭁ⱈⵚ⹓⽙おㅞ㉆㍎㑍㕉㚴㟞㢻㦮㪴㮷㳙㶳㺶㾤䂡䆫䊷䎧䒣䖥䚢䟎䢺䦤䪮䮸䲬䷈京侧傷冰劼厦咴喲嚊垓壠妈嫪寴岒嶙庅徂悊憐抆掀撄斝曦柢棭榇檊殘沝涗溃澓炗熑犎珮璇疉盦矿磩禐竲篱糰緶维翿胳臽苪菳蓥薜蚏蟨裬觾諠详賠跥転迴郮釡鋹鎟铢闯雑韈飘駎髏鮲鳛鷑黃龺ꂽꇗꋒꏁꓔꖰꛘꟆ\ua8c8꧂ꪫꯌ곈귚껌꿊냌뇉닆돐듊뗅똥띃롌륜먯묲밼봶빗뽇쁕성숿쌡쐴앐왟읎젨줢쨯쭃챀쵄칇켫퀬턷툢팤퐨픲혘휛\ud81e\ud915\uda08\udb67\udc1a\udd17\ude19\udf00\ue010\ue106\ue207\ue37a\ue413\ue519\ue61b\ue762\ue865\ue90f\uea0a\ueb19\uec0c\ued68\uee10\uef0e\uf000\uf10a\uf263\uf30f\uf408\uf513\uf67e\uf778\uf874葉塚ﭿﱺﵱ﹤＋\u0004ĔɧͺѴվ؏ܟࠍ३੧\u0b79౬ഈท༆\u1060ᅪቧጋᐈᔀᙙᝌᡒᥑᨻ᭑᱘ᵊṃὉ⁒ⅆ≆⍂\u2431╄☾✮⡚⥄⩎⭘ⱌ\u2d28⹆⽍けㅍ㉅㌿㐰"));
		a1446.DataSource = dataSource;
		try
		{
			a1445.FocusedRowHandle = focusedRowHandle;
		}
		catch
		{
		}
	}

	public void a1479()
	{
		a1459.Text = a1507("");
		a1458.Text = a1507("4įȲ\u0331");
		a1476.Text = a1507("4įȲ\u0331");
		a1471.Checked = false;
	}

	public void a1480()
	{
		if (a1459.Text == a1507(""))
		{
			MessageBox.Show(a1507("bŖɖ\u0352Ёաٻد࠽ॽ\u0a77\u0b7b౷\u0c29\u0e79ว\u1035ᅶቼቍᐱᕲ\u173e\u177cᡬᥧ\u1a6a᭧ᱨᵲṴḷ\u206b‵≹⌬\u242f"), a1507("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		a1468.SelectedIndex = a1467.SelectedIndex;
		decimal num = 0m;
		decimal num2 = 0m;
		try
		{
			num = Convert.ToDecimal(a1458.Text);
			num2 = Convert.ToDecimal(a1476.Text);
		}
		catch
		{
			MessageBox.Show(a1507("kǚɑ\u0342цՌ\u0601ݦࡶ१\u0a7c୨\u0c3b൛\u0e75\u0f79ၹᅺቴ፦ᔢᕼᜠᜰᡄᥡ\u1a63᭸ᱹᵥṥἨ⁂Ⅲ≬⍪⑪╸☯"), a1507("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		a1344.a1307();
		if (a1443 > 0)
		{
			a1344.a1271.CommandText = a1507("àǪˮϹӽׯۿޙ\u08f3৶\u0ae4\u0be1೫෴\u0ee0\u0fe4რᆏዽᏨᓸᖋᛡ៨\u18fa᧳\u1af9ᯢᳶ\u1df6Ỳ\u1ffe\u20e1⇛⋗⎠ⓜ◐⛛⟋⣌⧈⫑⯇ⳁⷃ⻍⿐ピ㇆㊢㏆㓍㗙㛞㟖㣌㧒㫔㯐㳉㶾㻂㿊䃁䄭䈪䌢䐸䔮䘨䜬䠵䥛䨰䬼䰭䴲並佌倰儩刧匴吭唿噆坉堡夬娯嬫尧崪帤弨怹愞戊捠搜攒昑朐栖椔樟欓氝洊渓漅灼焉爏猟琇甇瘃眄砍礕稍笀簞絾縂缇老腭艵荱葵蕶虿蝫衳襲詬謙豹赺蹡轰遶酦鉼鍪鑩镨陣靺頕饧驫魬鱷鵢鹤齨ꁲꅘꉛꍞꑕꕈ\ua636Ꝙꡓꥃ꩟ꭓ갩굓깓꽚끄녆뉈댭둛땃뙏띛롍뤧멏뭁밹뵃빋뽅");
			a1344.a1271.Parameters.Add(a1507("KŅ"), SqlDbType.Int).Value = a1443;
		}
		else
		{
			a1344.a1271.CommandText = a1507("\u009cǲ\u02f4Ϫӽץ\u06e2ޕ\u08fd৽૦\u0bfeಐ\u0de4\u0eef\u0fffჸᇴይᏻᓽᗷᚎ\u17eeᣥ᧱\u1af6᯾\u1ce7\u1dcdị\u1fcd\u20c3⇚⋞⏐⒴◜⛗⟇⣀⧌⫖⯄Ⳃⷚ⻃⾡ナ㇂㋓㏈㓜㖫㛏㟎㣍㧍㫁㯈㳆㴶㸧㼼䀨䅗䈼䌸䐪䔼䘺䜼䠹䤶䨠䬺䰵䴵乂传倥儸别匯吡唵嘡圠堧太娱孍尡崔帊弔怚慲扺挏搙攛昃朐标楻樒欚民洝渚漒瀋焙爟猙琗甆瘂県硨礃稉笀簒絫繡罹聩腩良荴萔蕷虰蝼衭襲試謝豰赦蹥轤遢酨鉣鍯鑡镾陧靱須饣驤魠鱲鵔鹒齔ꁑꅞꉈꍒꑝꕍ\ua63aꝕꡙ\ua95aꩁꭐ걖굆깜꽊끉녈뉃덚됤땇뙇띎롐륊멄묨");
		}
		a1344.a1271.Parameters.Add(a1507("Fōə\u035eіՏ\u0655ݓࡕज़\u0a42\u0b46\u0c48"), SqlDbType.VarChar).Value = a1459.Text;
		a1344.a1271.Parameters.Add(a1507("Aňɚ\u0353љՁ\u0651ݑࡗ\u094c"), SqlDbType.VarChar).Value = a1468.Text;
		a1344.a1271.Parameters.Add(a1507("Cōɚ\u0343ѕ"), SqlDbType.Decimal).Value = num;
		a1344.a1271.Parameters.Add(a1507("BŁɀ\u0346фՏكݍ\u085a\u0943\u0a55"), SqlDbType.Decimal).Value = num2;
		if (a1473.Checked)
		{
			a1344.a1271.Parameters.Add(a1507("Ałə\u0348юՎ\u0654\u0742ࡁ\u0940\u0a4b\u0b52"), SqlDbType.Int).Value = 1;
		}
		else
		{
			a1344.a1271.Parameters.Add(a1507("Ałə\u0348юՎ\u0654\u0742ࡁ\u0940\u0a4b\u0b52"), SqlDbType.Int).Value = 0;
		}
		if (a1471.Checked)
		{
			a1344.a1271.Parameters.Add(a1507("JŊɘ\u0342фՎ\u064b\u0740ࡖ\u0948\u0a47\u0b5b"), SqlDbType.Int).Value = 1;
		}
		else
		{
			a1344.a1271.Parameters.Add(a1507("JŊɘ\u0342фՎ\u064b\u0740ࡖ\u0948\u0a47\u0b5b"), SqlDbType.Int).Value = 0;
		}
		a1344.a1271.Parameters.Add(a1507("Dŏɗ\u034bч"), SqlDbType.Int).Value = 1;
		try
		{
			a1344.a1271.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			return;
		}
		a1443 = 0L;
		a1479();
		a1478();
		MessageBox.Show(a1507("ġOɣ\u036bѠԬ\u065fݫࡤ३੪୪\u0c64൪\u0e67ำ\u102f"), a1507("Gŭɯ\u0365Ѩ"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	public void a1481()
	{
		try
		{
			int num = Convert.ToInt32(a1445.GetFocusedRowCellValue(a1507("KŅ")).ToString());
			if (MessageBox.Show(a1507("mńɝ\u0347ԓԁٳݶࡲ॰\u0a79୰\u0c3a൰\u0e6bལ\u1073ᅱችሌᑻᕿᙹ\u1775ᡫ\u192d\u1a69᭦ᱣᵧṥὮ⁵Ⅼ≪⍪⑸┯"), a1507("PťɺͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.Cancel)
			{
				return;
			}
			a2147.a2128(a1507("sŵɠ\u0362Ѷդ\u0600ݔ\u085f\u094f\u0a48\u0b44ౝ\u0d4b\u0e4dཇ\u1036ᅆቑፇᐲᕐᙛ\u175bᡇ᥋ᨱ\u1b3b\u1c2aᵞṀὂ\u2054⅀∤⍊⑆┼") + num, a1507("Sŵɠ\u0362Ѷդ"));
		}
		catch
		{
		}
		a1478();
	}

	public void a1482()
	{
		try
		{
			a1443 = Convert.ToInt64(a1445.GetFocusedRowCellValue(a1507("KŅ")).ToString());
			a1459.Text = a1445.GetFocusedRowCellValue(a1507("Fōə\u035eіՏ\u0655ݓࡕज़\u0a42\u0b46\u0c48")).ToString();
			a1468.SelectedIndex = a1468.Items.IndexOf(a1445.GetFocusedRowCellValue(a1507("Aňɚ\u0353љՁ\u0651ݑࡗ\u094c")).ToString());
			a1467.SelectedIndex = a1468.SelectedIndex;
			a1458.Text = a1445.GetFocusedRowCellValue(a1507("Cōɚ\u0343ѕ")).ToString();
			a1476.Text = a1445.GetFocusedRowCellValue(a1507("BŁɀ\u0346фՏكݍ\u085a\u0943\u0a55")).ToString();
			string text = a1445.GetFocusedRowCellValue(a1507("JŊɘ\u0342фՎ\u064b\u0740ࡖ\u0948\u0a47\u0b5b")).ToString();
			string text2 = a1445.GetFocusedRowCellValue(a1507("Ałə\u0348юՎ\u0654\u0742ࡁ\u0940\u0a4b\u0b52")).ToString();
			if (text == a1507("Pűɷ\u0364"))
			{
				a1471.Checked = true;
			}
			else
			{
				a1471.Checked = false;
			}
			if (text2 == a1507("Pűɷ\u0364"))
			{
				a1473.Checked = true;
			}
			else
			{
				a1473.Checked = false;
			}
		}
		catch
		{
		}
	}

	private void a1485(object a1483, EventArgs a1484)
	{
		a1480();
	}

	private void a1488(object a1486, EventArgs a1487)
	{
		a1443 = 0L;
		a1480();
	}

	private void a1491(object a1489, KeyPressEventArgs a1490)
	{
		if (!char.IsControl(a1490.KeyChar) && !char.IsDigit(a1490.KeyChar) && a1490.KeyChar != ',')
		{
			a1490.Handled = true;
		}
	}

	private void a1494(object a1492, EventArgs a1493)
	{
		a1481();
	}

	private void a1497(object a1495, EventArgs a1496)
	{
		a1482();
	}

	private void a1500(object a1498, EventArgs a1499)
	{
		a1482();
	}

	private void a1503(object a1501, EventArgs a1502)
	{
	}

	protected override void Dispose(bool a1504)
	{
		if (a1504 && a1444 != null)
		{
			a1444.Dispose();
		}
		base.Dispose(a1504);
	}

	private void a1505()
	{
		a1444 = new Container();
		a1445 = new GridView();
		a1463 = new GridColumn();
		a1464 = new GridColumn();
		a1465 = new GridColumn();
		a1469 = new GridColumn();
		a1466 = new GridColumn();
		a1472 = new GridColumn();
		a1474 = new GridColumn();
		a1477 = new GridColumn();
		a1446 = new GridControl();
		a1447 = new ContextMenuStrip(a1444);
		a1448 = new ToolStripMenuItem();
		a1449 = new ToolStripMenuItem();
		a1450 = new GroupBox();
		a1473 = new CheckBox();
		a1471 = new CheckBox();
		a1470 = new PictureBox();
		a1467 = new System.Windows.Forms.ComboBox();
		a1451 = new Label();
		a1452 = new Label();
		a1453 = new Label();
		a1454 = new Label();
		a1475 = new Label();
		a1455 = new Label();
		a1456 = new Label();
		a1457 = new Label();
		a1476 = new TextBox();
		a1458 = new TextBox();
		a1459 = new TextBox();
		a1460 = new Panel();
		a1461 = new Button();
		a1462 = new Button();
		a1468 = new System.Windows.Forms.ComboBox();
		((ISupportInitialize)a1445).BeginInit();
		((ISupportInitialize)a1446).BeginInit();
		a1447.SuspendLayout();
		a1450.SuspendLayout();
		((ISupportInitialize)a1470).BeginInit();
		a1460.SuspendLayout();
		SuspendLayout();
		a1445.BorderStyle = BorderStyles.NoBorder;
		a1445.Columns.AddRange(new GridColumn[8] { a1463, a1464, a1465, a1469, a1466, a1472, a1474, a1477 });
		a1445.FocusRectStyle = DrawFocusRectStyle.RowFocus;
		a1445.GridControl = a1446;
		a1445.Name = a1507("nźɮ\u0362ѓխ٦ݵ࠰");
		a1445.OptionsBehavior.Editable = false;
		a1445.OptionsCustomization.AllowFilter = false;
		a1445.OptionsCustomization.AllowGroup = false;
		a1445.OptionsCustomization.AllowSort = false;
		a1445.OptionsFilter.AllowFilterEditor = false;
		a1445.OptionsView.ShowGroupPanel = false;
		a1463.Caption = a1507("KŅ");
		a1463.Name = a1507("lŸɠ\u036cфթ٩ݱ\u086e६ਰ");
		a1464.Caption = a1507("Oŵɳ\u0375ФՂ٦ذ");
		a1464.FieldName = a1507("Fōə\u035eіՏ\u0655ݓࡕज़\u0a42\u0b46\u0c48");
		a1464.Name = a1507("lŸɠ\u036cфթ٩ݱ\u086e६ਲ਼");
		a1464.Visible = true;
		a1464.VisibleIndex = 0;
		a1464.Width = 226;
		a1465.Caption = a1507("Mźɲ\u036bХՐ٪ݲࡨ");
		a1465.FieldName = a1507("Bŉɕ\u0352сՑ\u0651ݗࡌ");
		a1465.Name = a1507("lŸɠ\u036cфթ٩ݱ\u086e६ਲ");
		a1465.Visible = true;
		a1465.VisibleIndex = 1;
		a1465.Width = 68;
		a1469.Caption = a1507("AŨɺͳЦՁٱݱࡷ६");
		a1469.FieldName = a1507("Aňɚ\u0353љՁ\u0651ݑࡗ\u094c");
		a1469.Name = a1507("lŸɠ\u036cфթ٩ݱ\u086e६\u0a34");
		a1469.Width = 73;
		a1466.AppearanceHeader.Options.UseTextOptions = true;
		a1466.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Far;
		a1466.Caption = a1507("Cŭɺ\u0363ѵ");
		a1466.FieldName = a1507("Cōɚ\u0343ѕ");
		a1466.Name = a1507("lŸɠ\u036cфթ٩ݱ\u086e६ਵ");
		a1466.Visible = true;
		a1466.VisibleIndex = 4;
		a1466.Width = 49;
		a1472.AppearanceHeader.Options.UseTextOptions = true;
		a1472.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
		a1472.Caption = a1507("Kŭɹ\u0361ѥйا\u074bࡠॶ੨୧౻");
		a1472.FieldName = a1507("JŊɘ\u0342фՎ\u064b\u0740ࡖ\u0948\u0a47\u0b5b");
		a1472.Name = a1507("lŸɠ\u036cфթ٩ݱ\u086e६\u0a37");
		a1472.Visible = true;
		a1472.VisibleIndex = 2;
		a1472.Width = 91;
		a1474.AppearanceHeader.Options.UseTextOptions = true;
		a1474.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
		a1474.Caption = a1507("CŤɿ\u036aѬՠٺܧࡁॠ\u0ae3୪൝൨");
		a1474.FieldName = a1507("Ałə\u0348юՎ\u0654\u0742ࡁ\u0940\u0a4b\u0b52");
		a1474.Name = a1507("lŸɠ\u036cфթ٩ݱ\u086e६ਸ਼");
		a1474.Visible = true;
		a1474.VisibleIndex = 3;
		a1474.Width = 81;
		a1477.AppearanceHeader.Options.UseTextOptions = true;
		a1477.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Far;
		a1477.Caption = a1507("CŤɿ\u036aѬՠٺܧ\u08da०੶୦\u0c76൨");
		a1477.FieldName = a1507("BŁɀ\u0346фՏكݍ\u085a\u0943\u0a55");
		a1477.Name = a1507("lŸɠ\u036cфթ٩ݱ\u086e६ਹ");
		a1477.Visible = true;
		a1477.VisibleIndex = 5;
		a1477.Width = 86;
		a1446.ContextMenuStrip = a1447;
		a1446.EmbeddedNavigator.Name = a1507("");
		a1446.Font = new Font(a1507("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1446.Location = new Point(15, 217);
		a1446.LookAndFeel.SkinName = a1507("GżɻͳѯՖ٭ݨ\u086b९");
		a1446.LookAndFeel.UseDefaultLookAndFeel = false;
		a1446.MainView = a1445;
		a1446.Name = a1507("kŹɣ\u036dыը٨ݱࡶ६੮ର");
		a1446.Size = new Size(691, 279);
		a1446.TabIndex = 3;
		a1446.ViewCollection.AddRange(new BaseView[1] { a1445 });
		a1446.DoubleClick += a1500;
		a1447.Items.AddRange(new ToolStripItem[2] { a1448, a1449 });
		a1447.Name = a1507("rſɡͺѨմٿ\u0747\u086c०ੲ\u0b55\u0c71൶\u0e6a\u0f72\u1030");
		a1447.Size = new Size(137, 80);
		a1448.Image = a2268.a2289;
		a1448.ImageScaling = ToolStripItemImageScaling.None;
		a1448.Name = a1507("~Ǥɹ\u0375Ѱոٿݷࡅॿ\u0a60\u0b62\u0c5e൸\u0e79ལၹᅅቢ፨ᑰᕍᙷᝧᡬ");
		a1448.Size = new Size(136, 38);
		a1448.Text = a1507("Oǻɨ\u0366ѡկٮݤ");
		a1448.Click += a1497;
		a1449.Image = a2268.a2341;
		a1449.ImageScaling = ToolStripItemImageScaling.None;
		a1449.Name = a1507("gźɾ\u0345ѿՠ٢ݞࡸॹ\u0a63\u0b79\u0c45\u0d62\u0e68\u0f70၍ᅷቧ፬");
		a1449.Size = new Size(136, 38);
		a1449.Text = a1507("Pūɭ");
		a1449.Click += a1494;
		a1450.Controls.Add(a1473);
		a1450.Controls.Add(a1471);
		a1450.Controls.Add(a1470);
		a1450.Controls.Add(a1467);
		a1450.Controls.Add(a1446);
		a1450.Controls.Add(a1451);
		a1450.Controls.Add(a1452);
		a1450.Controls.Add(a1453);
		a1450.Controls.Add(a1454);
		a1450.Controls.Add(a1475);
		a1450.Controls.Add(a1455);
		a1450.Controls.Add(a1456);
		a1450.Controls.Add(a1457);
		a1450.Controls.Add(a1476);
		a1450.Controls.Add(a1458);
		a1450.Controls.Add(a1459);
		a1450.Location = new Point(10, -2);
		a1450.Name = a1507("nźɨͳѵՆ٬ݺ࠰");
		a1450.Size = new Size(712, 501);
		a1450.TabIndex = 0;
		a1450.TabStop = false;
		a1473.AutoSize = true;
		a1473.Checked = true;
		a1473.CheckState = CheckState.Checked;
		a1473.Location = new Point(200, 130);
		a1473.Name = a1507("jŠɊ\u036fѶե٥ݫࡳ");
		a1473.Size = new Size(200, 17);
		a1473.TabIndex = 5;
		a1473.Text = a1507("ĘŌɏ\u034bчՊ\u0602ݦࡅ৸\u0a77\u0a42\u0c3c\u0d42\u0e7bཀྵၹᅵቿ፹ᑧᕺᙼᜱᠸ\u1942\u1a67᭾ᱭᵭṣύ\u2028⅀≣⏢⑭\u245c♫✨");
		a1473.UseVisualStyleBackColor = true;
		a1471.AutoSize = true;
		a1471.Location = new Point(200, 101);
		a1471.Name = a1507("mťɊ\u036aѸբ٤ݮࡋॠ੶୨౧ൻ");
		a1471.Size = new Size(291, 17);
		a1471.TabIndex = 4;
		a1471.Text = a1507("\u007fřɅ\u035dљЅ\u0613ݿࡔ\u0942\u0a44\u0b4b\u0c57\u0d40\u0e4eམ၍ᅍሇሖᕺᕈᙆᝏ᠁\u1979\u1a7e\u1b6eᴬᵰṺὸ⁰ⅴ≤⍿⑻┺☳✺⡈⧬⩤⭢ⱨⵡ\u2e6e⼪みㅭ㈧㍁㑠㗣㙪㙝㠨");
		a1471.UseVisualStyleBackColor = true;
		a1470.Image = a2268.a2324;
		a1470.Location = new Point(564, 20);
		a1470.Name = a1507("{ţɪͼѲմ٠\u0746\u086cॺਰ");
		a1470.Size = new Size(136, 127);
		a1470.TabIndex = 63;
		a1470.TabStop = false;
		a1467.DropDownStyle = ComboBoxStyle.DropDownList;
		a1467.Font = new Font(a1507("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1467.FormattingEnabled = true;
		a1467.Location = new Point(116, 65);
		a1467.Name = a1507("iūɌ\u0375ѳը\u0650ݪࡲ२");
		a1467.Size = new Size(358, 26);
		a1467.TabIndex = 1;
		a1451.AutoSize = true;
		a1451.Location = new Point(17, 170);
		a1451.Name = a1507("jŤɦ\u0366ѮԲ");
		a1451.Size = new Size(388, 13);
		a1451.TabIndex = 59;
		a1451.Text = a1507("\u001eĵȡ\u0326ѱԗؽ\u073b\u082fह੫ଅథഽ\u0f18༲\u1030ᄶሢጠᐨᔬᙒ\u175bᡖᤜᩒᯝ᱐ᵖḗὑ⁇⅁≃⌒\u2450╔✞❀⤜⤀⩀⭋ⱛⵜ⸇⽂ぐㅖ㉖㍏㐁㕔㙶㝮㡴㥲㩲㬺㱯㵽㸷㽰䁼䅭䉲䍦䔠䕾䜾䜮䡪䥥䩹䭧䱬䵤乮併偬兪剪卸启");
		a1452.AutoSize = true;
		a1452.Font = new Font(a1507("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a1452.Location = new Point(16, 197);
		a1452.Name = a1507("jŤɦ\u0366Ѯ\u0530");
		a1452.Size = new Size(100, 13);
		a1452.TabIndex = 55;
		a1452.Text = a1507("ZűɽͺЭՋٹݿࡹन\u0a4b୯\u0c76൰\u0e66\u0f71\u1068");
		a1453.BackColor = Color.FromArgb(128, 255, 128);
		a1453.BorderStyle = BorderStyle.Fixed3D;
		a1453.FlatStyle = FlatStyle.Flat;
		a1453.ForeColor = Color.DarkOrange;
		a1453.Location = new Point(16, 187);
		a1453.Name = a1507("kŧɧ\u0361ѯԳز");
		a1453.Size = new Size(684, 3);
		a1453.TabIndex = 54;
		a1454.AutoSize = true;
		a1454.Font = new Font(a1507("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a1454.Location = new Point(11, 17);
		a1454.Name = a1507("jŤɦ\u0366ѮԹ");
		a1454.Size = new Size(69, 13);
		a1454.TabIndex = 51;
		a1454.Text = a1507("KŹɿ\u0379ШՅٯݩࡣ४\u0a71୨");
		a1475.AutoSize = true;
		a1475.Location = new Point(17, 132);
		a1475.Name = a1507("jŤɦ\u0366ѮԶ");
		a1475.Size = new Size(88, 13);
		a1475.TabIndex = 49;
		a1475.Text = a1507("ģŹɸ;Ѭէح\u074b\u086e৭\u0a60\u0a57ధ\u0d40\u0e6c\u0f7d\u1062ᅶጰ");
		a1455.AutoSize = true;
		a1455.Location = new Point(17, 103);
		a1455.Name = a1507("jŤɦ\u0366ѮԴ");
		a1455.Size = new Size(31, 13);
		a1455.TabIndex = 49;
		a1455.Text = a1507("Cŭɺ\u0363ѵ");
		a1456.AutoSize = true;
		a1456.Location = new Point(17, 72);
		a1456.Name = a1507("jŤɦ\u0366ѮԵ");
		a1456.Size = new Size(57, 13);
		a1456.TabIndex = 49;
		a1456.Text = a1507("NżɺͲѫԥ\u0650ݪࡲ२");
		a1457.AutoSize = true;
		a1457.Location = new Point(17, 41);
		a1457.Name = a1507("jŤɦ\u0366ѮԷ");
		a1457.Size = new Size(48, 13);
		a1457.TabIndex = 49;
		a1457.Text = a1507("Oŵɳ\u0375ФՂ٦ذ");
		a1476.Font = new Font(a1507("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a1476.Location = new Point(116, 125);
		a1476.MaxLength = 5;
		a1476.Name = a1507("zŵɸ\u0362ѡՠ٦ݤ\u086f\u0943੭\u0b7a\u0c63൵");
		a1476.Size = new Size(73, 26);
		a1476.TabIndex = 3;
		a1476.Text = a1507("4įȲ\u0331");
		a1476.TextAlign = HorizontalAlignment.Right;
		a1476.KeyPress += a1491;
		a1458.Font = new Font(a1507("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a1458.Location = new Point(116, 96);
		a1458.MaxLength = 5;
		a1458.Name = a1507("|ſɲ\u0343ѭպ٣ݵ");
		a1458.Size = new Size(73, 26);
		a1458.TabIndex = 2;
		a1458.Text = a1507("4įȲ\u0331");
		a1458.TextAlign = HorizontalAlignment.Right;
		a1458.KeyPress += a1491;
		a1459.Font = new Font(a1507("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a1459.Location = new Point(116, 34);
		a1459.Name = a1507("~űɼ\u0340Ѵհٴ\u0742ࡦ२");
		a1459.Size = new Size(358, 26);
		a1459.TabIndex = 1;
		a1460.BackColor = Color.FromArgb(233, 235, 236);
		a1460.Controls.Add(a1461);
		a1460.Controls.Add(a1462);
		a1460.Dock = DockStyle.Bottom;
		a1460.Location = new Point(0, 504);
		a1460.Name = a1507("vŤɪ\u0366Ѯ\u0530");
		a1460.Size = new Size(734, 37);
		a1460.TabIndex = 1;
		a1461.Dock = DockStyle.Fill;
		a1461.Location = new Point(342, 0);
		a1461.Name = a1507("jųɨ\u0346ѭը٫ݲ");
		a1461.Size = new Size(392, 37);
		a1461.TabIndex = 1;
		a1461.Text = a1507("Oǻɨ\u0366ѡկٮݤ");
		a1461.UseVisualStyleBackColor = true;
		a1461.Click += a1485;
		a1462.Dock = DockStyle.Left;
		a1462.Location = new Point(0, 0);
		a1462.Name = a1507("kżɩ\u034dѤս٧ݧࡵ");
		a1462.Size = new Size(342, 37);
		a1462.TabIndex = 0;
		a1462.Text = a1507("MŤɽ\u0367ѧյ");
		a1462.UseVisualStyleBackColor = true;
		a1462.Click += a1488;
		a1468.DropDownStyle = ComboBoxStyle.DropDownList;
		a1468.Font = new Font(a1507("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1468.FormattingEnabled = true;
		a1468.Location = new Point(788, 96);
		a1468.Name = a1507("oũɎͻѽժ\u0652ݬࡴ४\u0a4b\u0b45");
		a1468.Size = new Size(41, 26);
		a1468.TabIndex = 61;
		Appearance.BackColor = Color.White;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(734, 541);
		Controls.Add(a1450);
		Controls.Add(a1460);
		Controls.Add(a1468);
		MaximizeBox = false;
		MaximumSize = new Size(750, 580);
		Name = a1507("JŹɧ\u034eѺղٶݑࡥ७੫୬");
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a1507("IſɹͻЪ՝٩ݩष२੨\u0b62౯ൠ");
		((ISupportInitialize)a1445).EndInit();
		((ISupportInitialize)a1446).EndInit();
		a1447.ResumeLayout(performLayout: false);
		a1450.ResumeLayout(performLayout: false);
		a1450.PerformLayout();
		((ISupportInitialize)a1470).EndInit();
		a1460.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	private static string a1507(string a1506)
	{
		int length = a1506.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a1506[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
