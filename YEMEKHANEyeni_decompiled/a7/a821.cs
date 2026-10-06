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

public class a821 : XtraForm
{
	private IContainer a767 = null;

	public Label a768;

	public Label a769;

	public Label a770;

	public Label a771;

	public Panel a772;

	public Button a773;

	public Button a774;

	public TextBox a775;

	public Label a776;

	public ContextMenuStrip a777;

	public ToolStripMenuItem a778;

	public Label a779;

	public GroupBox a780;

	public Label a781;

	public Label a782;

	public TextBox a783;

	public TextBox a784;

	public GridControl a785;

	public GridView a786;

	private GridColumn a787;

	private GridColumn a788;

	private GridColumn a789;

	private GridColumn a790;

	private ToolStripMenuItem a791;

	private PictureBox a792;

	private int a793 = -1;

	protected override void Dispose(bool a794)
	{
		if (a794 && a767 != null)
		{
			a767.Dispose();
		}
		base.Dispose(a794);
	}

	private void a795()
	{
		a767 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(a821));
		a768 = new Label();
		a769 = new Label();
		a770 = new Label();
		a771 = new Label();
		a772 = new Panel();
		a773 = new Button();
		a774 = new Button();
		a775 = new TextBox();
		a776 = new Label();
		a777 = new ContextMenuStrip(a767);
		a791 = new ToolStripMenuItem();
		a778 = new ToolStripMenuItem();
		a779 = new Label();
		a780 = new GroupBox();
		a792 = new PictureBox();
		a785 = new GridControl();
		a786 = new GridView();
		a787 = new GridColumn();
		a788 = new GridColumn();
		a789 = new GridColumn();
		a790 = new GridColumn();
		a781 = new Label();
		a782 = new Label();
		a783 = new TextBox();
		a784 = new TextBox();
		a772.SuspendLayout();
		a777.SuspendLayout();
		a780.SuspendLayout();
		((ISupportInitialize)a792).BeginInit();
		((ISupportInitialize)a785).BeginInit();
		((ISupportInitialize)a786).BeginInit();
		SuspendLayout();
		a768.AutoSize = true;
		a768.Font = new Font(a820("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a768.Location = new Point(16, 160);
		a768.Name = a820("jŤɦ\u0366Ѯ\u0530");
		a768.Size = new Size(88, 13);
		a768.TabIndex = 55;
		a768.Text = a820("CŨɾ\u0360ѯճب\u074b\u086fॶ\u0a70୦\u0c71൨");
		a769.BackColor = Color.FromArgb(128, 255, 128);
		a769.BorderStyle = BorderStyle.Fixed3D;
		a769.FlatStyle = FlatStyle.Flat;
		a769.ForeColor = Color.DarkOrange;
		a769.Location = new Point(16, 153);
		a769.Name = a820("kŧɧ\u0361ѯԳز");
		a769.Size = new Size(587, 3);
		a769.TabIndex = 54;
		a770.AutoSize = true;
		a770.Font = new Font(a820("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a770.Location = new Point(10, 15);
		a770.Name = a820("jŤɦ\u0366ѮԹ");
		a770.Size = new Size(93, 13);
		a770.TabIndex = 51;
		a770.Text = a820("]Ūɼ\u0366ѩձت\u074bࡡ५\u0a61୬౨൦\u0e70ཨ");
		a771.AutoSize = true;
		a771.Location = new Point(17, 43);
		a771.Name = a820("jŤɦ\u0366ѮԷ");
		a771.Size = new Size(59, 13);
		a771.TabIndex = 49;
		a771.Text = a820("GŬɺ\u036cѣտؤ\u0742ࡦ࠰");
		a772.BackColor = Color.FromArgb(233, 235, 236);
		a772.Controls.Add(a773);
		a772.Controls.Add(a774);
		a772.Dock = DockStyle.Bottom;
		a772.Location = new Point(0, 478);
		a772.Name = a820("vŤɪ\u0366Ѯ\u0530");
		a772.Size = new Size(623, 37);
		a772.TabIndex = 1;
		a773.Dock = DockStyle.Fill;
		a773.Location = new Point(304, 0);
		a773.Name = a820("jųɨ\u0346ѭը٫ݲ");
		a773.Size = new Size(319, 37);
		a773.TabIndex = 1;
		a773.Text = a820("Oǻɨ\u0366ѡկٮݤ");
		a773.UseVisualStyleBackColor = true;
		a773.Click += a802;
		a774.Dock = DockStyle.Left;
		a774.Location = new Point(0, 0);
		a774.Name = a820("kżɩ\u034dѤս٧ݧࡵ");
		a774.Size = new Size(304, 37);
		a774.TabIndex = 0;
		a774.Text = a820("MŤɽ\u0367ѧյ");
		a774.UseVisualStyleBackColor = true;
		a774.Click += a805;
		a775.Font = new Font(a820("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a775.Location = new Point(88, 36);
		a775.Name = a820("xųɾ\u0344ѭյ٭ݠࡾ\u0942੦୨");
		a775.Size = new Size(268, 26);
		a775.TabIndex = 0;
		a776.AutoSize = true;
		a776.Location = new Point(17, 453);
		a776.Name = a820("jŤɦ\u0366ѮԳ");
		a776.Size = new Size(237, 13);
		a776.TabIndex = 60;
		a776.Text = a820("~Ŕɀ\u0352ўЀ\u0610\u0748ࡇय़\u0a48\u0b42വ\u0d40ๆཎၜᄅቝᏟᑉᕍᙅ\u1772\u187b\u193d\u1a71᭾ᱨᵲṽὭ⁺ⅰ≦⍺⑼╸☰❼⡧⥡⩩⭩Ᵽⵥ\u2e61⽵ふㅬ㉪㍪㑸㔯");
		a777.Items.AddRange(new ToolStripItem[2] { a791, a778 });
		a777.Name = a820("rſɡͺѨմٿ\u0747\u086c०ੲ\u0b55\u0c71൶\u0e6a\u0f72\u1030");
		a777.Size = new Size(137, 80);
		a791.Image = a2268.a2289;
		a791.ImageScaling = ToolStripItemImageScaling.None;
		a791.Name = a820("~Ǥɹ\u0375Ѱոٿݷࡅॿ\u0a60\u0b62\u0c5e൸\u0e79ལၹᅅቢ፨ᑰᕍᙷᝧᡬ");
		a791.Size = new Size(136, 38);
		a791.Text = a820("Oǻɨ\u0366ѡկٮݤ");
		a791.Click += a812;
		a778.Image = a2268.a2341;
		a778.ImageScaling = ToolStripItemImageScaling.None;
		a778.Name = a820("gźɾ\u0345ѿՠ٢ݞࡸॹ\u0a63\u0b79\u0c45\u0d62\u0e68\u0f70၍ᅷቧ፬");
		a778.Size = new Size(136, 38);
		a778.Text = a820("Pūɭ");
		a778.Click += a808;
		a779.AutoSize = true;
		a779.Location = new Point(17, 129);
		a779.Name = a820("jŤɦ\u0366ѮԲ");
		a779.Size = new Size(419, 13);
		a779.TabIndex = 59;
		a779.Text = a820("\0Ƥȼ\u033aаԹضݲ\u081cव\u0a3dଥనശยཪဦᄤሲሙᐱᔱᘱᜯᠠ\u192b᨟᭗\u1cdaᵕṕἚ\u2054⅝≅⍝\u2450╎☓❓⡕⠁⨏⭝ⱂⵞ\u2e5e⽇ぅㅝ㈇㍐㑀㔄㙗㝇㡍㥅㩹㭱㱳㴼㹹㽳䁵䅿䉾䍥䑼䕺䙺䜲䡶䥹䩽䭣䱨䵢乢佰倩共剢卲呠啶噯坫堯");
		a780.Controls.Add(a792);
		a780.Controls.Add(a785);
		a780.Controls.Add(a776);
		a780.Controls.Add(a779);
		a780.Controls.Add(a768);
		a780.Controls.Add(a769);
		a780.Controls.Add(a770);
		a780.Controls.Add(a781);
		a780.Controls.Add(a782);
		a780.Controls.Add(a771);
		a780.Controls.Add(a783);
		a780.Controls.Add(a784);
		a780.Controls.Add(a775);
		a780.Location = new Point(4, -2);
		a780.Name = a820("nźɨͳѵՆ٬ݺ࠰");
		a780.Size = new Size(611, 475);
		a780.TabIndex = 0;
		a780.TabStop = false;
		a792.Image = (Image)componentResourceManager.GetObject(a820("aŹɬͺѸվٮ\u0748ࡦ॰ਸ਼ନ\u0c4c൩\u0e62ཥ\u1064"));
		a792.Location = new Point(470, 15);
		a792.Name = a820("{ţɪͼѲմ٠\u0746\u086cॺਰ");
		a792.Size = new Size(133, 135);
		a792.TabIndex = 64;
		a792.TabStop = false;
		a785.ContextMenuStrip = a777;
		a785.EmbeddedNavigator.Name = a820("");
		a785.Font = new Font(a820("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a785.Location = new Point(16, 175);
		a785.LookAndFeel.SkinName = a820("GżɻͳѯՖ٭ݨ\u086b९");
		a785.LookAndFeel.UseDefaultLookAndFeel = false;
		a785.MainView = a786;
		a785.Name = a820("kŹɣ\u036dыը٨ݱࡶ६੮ର");
		a785.Size = new Size(589, 275);
		a785.TabIndex = 3;
		a785.ViewCollection.AddRange(new BaseView[1] { a786 });
		a785.DoubleClick += a815;
		a786.BorderStyle = BorderStyles.NoBorder;
		a786.Columns.AddRange(new GridColumn[4] { a787, a788, a789, a790 });
		a786.FocusRectStyle = DrawFocusRectStyle.RowFocus;
		a786.GridControl = a785;
		a786.Name = a820("nźɮ\u0362ѓխ٦ݵ࠰");
		a786.OptionsBehavior.Editable = false;
		a786.OptionsCustomization.AllowFilter = false;
		a786.OptionsCustomization.AllowGroup = false;
		a786.OptionsCustomization.AllowSort = false;
		a786.OptionsFilter.AllowFilterEditor = false;
		a786.OptionsView.ShowGroupPanel = false;
		a787.Caption = a820("KŅ");
		a787.FieldName = a820("KŅ");
		a787.Name = a820("lŸɠ\u036cфթ٩ݱ\u086e६ਰ");
		a788.Caption = a820("GŬɺ\u036cѣտؤ\u0742ࡦ࠰");
		a788.FieldName = a820("BņɈ");
		a788.Name = a820("lŸɠ\u036cфթ٩ݱ\u086e६ਲ਼");
		a788.Visible = true;
		a788.VisibleIndex = 0;
		a788.Width = 168;
		a789.Caption = a820("TũɷͱѮծٴ");
		a789.FieldName = a820("Tŉɗ\u0351юՎ\u0654");
		a789.Name = a820("lŸɠ\u036cфթ٩ݱ\u086e६ਲ");
		a789.Visible = true;
		a789.VisibleIndex = 1;
		a789.Width = 142;
		a790.Caption = a820("Sţɩ\u0361ѥխٯ");
		a790.FieldName = a820("SŃɉ\u0341хՍ\u064f");
		a790.Name = a820("lŸɠ\u036cфթ٩ݱ\u086e६ਵ");
		a790.Visible = true;
		a790.VisibleIndex = 2;
		a790.Width = 98;
		a781.AutoSize = true;
		a781.Location = new Point(17, 97);
		a781.Name = a820("jŤɦ\u0366ѮԴ");
		a781.Size = new Size(43, 13);
		a781.TabIndex = 49;
		a781.Text = a820("Sţɩ\u0361ѥխٯ");
		a782.AutoSize = true;
		a782.Location = new Point(17, 70);
		a782.Name = a820("jŤɦ\u0366ѮԵ");
		a782.Size = new Size(63, 13);
		a782.TabIndex = 49;
		a782.Text = a820("XťɻͽѪժ\u0670ܤࡂ०ର");
		a783.Font = new Font(a820("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a783.Location = new Point(88, 90);
		a783.Name = a820("~űɼ\u0353ѣթ١ݥ\u086d९");
		a783.Size = new Size(268, 26);
		a783.TabIndex = 2;
		a784.Font = new Font(a820("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a784.Location = new Point(88, 63);
		a784.Name = a820("~űɼ\u0354ѩշٱݮ\u086eॴ");
		a784.Size = new Size(268, 26);
		a784.TabIndex = 1;
		Appearance.BackColor = Color.White;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(623, 515);
		Controls.Add(a772);
		Controls.Add(a780);
		MaximizeBox = false;
		Name = a820("Hſɡ\u0346ѯջ٣ݢࡼ\u0951\u0a65୭౫൬");
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a820("Kǭɻ\u0363ѫՠ٩ܫࡇ६\u0a7a୬\u0c63ൿ\u0e68སၰᅨ");
		Load += a818;
		a772.ResumeLayout(performLayout: false);
		a777.ResumeLayout(performLayout: false);
		a780.ResumeLayout(performLayout: false);
		a780.PerformLayout();
		((ISupportInitialize)a792).EndInit();
		((ISupportInitialize)a785).EndInit();
		((ISupportInitialize)a786).EndInit();
		ResumeLayout(performLayout: false);
	}

	public a821()
	{
		a795();
		a1984.a1891(this);
		a796();
	}

	public void a796()
	{
		DataTable dataSource = a2147.a2105(a820("bŵɣ\u036bѮո؋ݣ\u086dऄ੦\u0b62౬ഈ\u0e70\u0f6d\u1073ᅵቒፒᑈᔰᙏ\u175fᡕᥝᩑ᭙ᱛᴴṕὀ⁞⅝∯⍗\u2458╇♇❏⡄⥍⩘⭋ⱀⵖ⹈⽇せ"));
		a785.DataSource = dataSource;
	}

	public void a797()
	{
		if (a775.Text == a820(""))
		{
			MessageBox.Show(a820("SŸɮͰѿգظݖࡲࠤ\u0a7aਢల\u0d53\u0e7f๐\u102eᅊቩᏬᑯᕤ᙭\u177dᡵᥬ\u1a6a᭪ᱸᴯ"), a820("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			a775.Focus();
			return;
		}
		a1344.a1307();
		if (a793 > 0)
		{
			a1344.a1271.CommandText = a820("\u0004Āȋ\u030fЙԉ٫ܓ\u081c\u0903\u0a0b\u0b03ఈ\u0d01ผ༏ငᄒቴ፻ᑧᔜᙨ\u177fᡭᤘ\u1a76\u1b72ᱼᴉṳέ⁵ⅹ∃⍽③╾♾❧⡥⥽⨚⭦ⱶ\u2d6b\u2e71⽷ぬㅬ㉊㌲㑉㕙㙗㝟㡟㥗㩙㬫㱕㵀㹖㽞䁔䅖䉀䍀䐭䕛䙃䝏䡛䥍䨧䭏䱁䴹乃佋偅");
			a1344.a1271.Parameters.Add(a820("KŅ"), SqlDbType.Int).Value = a793;
		}
		else
		{
			a1344.a1271.CommandText = a820("\u0013ėȋ\u0312Єԁٴܚ\u081cअਟ୯గഘง༇ဏᄄልጘᐋᔀᘖᜈ᠇ᤛ\u1a68᭾ᱺᵴḐὨ⁵Ⅻ≭⍺⑺╠☘❧⡷⥽⩵⭩ⱡⵣ⸀⽪ちㅽ㉡㍡㐏㕳㙥㝯㡷㥤㩳㬷㱞㵜㹘㽒䀶䅙䉋䍘䑄䕀䙙䝟䡇䤽䩐䭛䱋䵁义位偅兇判升呇啎噐坊塄夨");
		}
		a1344.a1271.Parameters.Add(a820("BņɈ"), SqlDbType.VarChar).Value = a775.Text;
		a1344.a1271.Parameters.Add(a820("Tŉɗ\u0351юՎ\u0654"), SqlDbType.VarChar).Value = a784.Text;
		a1344.a1271.Parameters.Add(a820("SŃɉ\u0341хՍ\u064f"), SqlDbType.VarChar).Value = a783.Text;
		a1344.a1271.Parameters.Add(a820("Dŏɗ\u034bч"), SqlDbType.Int).Value = 1;
		try
		{
			a1344.a1271.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
		a796();
		a798();
	}

	public void a798()
	{
		a793 = -1;
		a775.Text = a820("");
		a784.Text = a820("");
		a783.Text = a820("");
	}

	public void a799()
	{
		try
		{
			int num = Convert.ToInt32(a786.GetFocusedRowCellValue(a820("KŅ")).ToString());
			if (MessageBox.Show(a820("xŃɅ\u0345тԆܕٻࡏ\u0947\u0a4c\u0b49\u0c71ൻ\u0e3d\u0f78ၾᅬቸ፵ᐷᕳᙡ\u1779ᡶ\u1979ᨱ᭹ᱼᵺṤή\u2064ⅸ≤⍽⑴╳♫❱⡹⤬⨡"), a820("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.Cancel)
			{
				return;
			}
			if (a2147.a2100(a820("`ŷɽ\u0375Ѭպ؍ݥ\u086fऊ੯\u0b7a౨൫ฅ\u0f70ၦᅰቬ፩ᑑᕟᙑᝐᡞ᥈ᨹ᭏ᱟᵓṇὑ″⅋≄⍛⑃╋♀❉⡔⥇⩌⭚ⱌⵃ\u2e5f⽛おㅆ㈼") + num))
			{
				MessageBox.Show(a820("iŐɔ\u035aѓԕ܄٬࡞\u0954\u0a5d\u0b46ఎ\u0d4a\u0e49ཙჍᅌቃፋᑃᑺᙐᝊᡐ᥈ᩌ᭺ᱳᵴṥὴ\u2068ℷ∸⍕④┵♟❲⡫⥵⩱⬯Ɐⵤ\u2e78⼫っざ㉤㍢㑫㔥㙲㝢㡰㤯"), a820("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (a2147.a2100(a820("yŬɤ\u0362ѥձ\u0604ݪࡦ\u0901੦\u0b4d\u0c51\u0d50\u0e3cཎ၉ᅜቊፄᐶᕂᙜ\u1756ᡀᥔᨰ᭖ᱛᵆṀ\u1f4e⁇⅌≗⍊⑃╗♛❊⡆⤼") + num))
			{
				MessageBox.Show(a820("iŐɔ\u035aѓԕ܄٬࡞\u0954\u0a5d\u0b46ఎ\u0d4a\u0e49ཙჍᅌቃፋᑃᑺᙐᝊᡐ᥈ᩌ᭺ᱳᵴṥὴ\u2068ℷ∸⍕④┵♟❲⡫⥵⩱⬯Ɐⵤ\u2e78⼫っざ㉤㍢㑫㔥㙲㝢㡰㤯"), a820("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			a2147.a2128(a820("`Ŧɮ\u0364Ѵ՚ؾݛࡎ\u0954\u0a57ହ\u0c41\u0d42\u0e5dཙၑᅞ\u1257ፎᑝᕊᙜᝆᡉᥑᨪ᭞᱀ᵂṔὀ․⅊≆⌼") + num, a820("BŠɨ\u0366Ѷդ"));
		}
		catch
		{
		}
		a796();
		a798();
	}

	private void a802(object a800, EventArgs a801)
	{
		a797();
	}

	private void a805(object a803, EventArgs a804)
	{
		a793 = -1;
		a797();
	}

	private void a808(object a806, EventArgs a807)
	{
		a799();
	}

	public void a809()
	{
		try
		{
			a793 = Convert.ToInt32(a786.GetFocusedRowCellValue(a820("KŅ")).ToString());
			a775.Text = a786.GetFocusedRowCellValue(a820("BņɈ")).ToString();
			a784.Text = a786.GetFocusedRowCellValue(a820("Tŉɗ\u0351юՎ\u0654")).ToString();
			a783.Text = a786.GetFocusedRowCellValue(a820("SŃɉ\u0341хՍ\u064f")).ToString();
		}
		catch
		{
		}
	}

	private void a812(object a810, EventArgs a811)
	{
		a809();
	}

	private void a815(object a813, EventArgs a814)
	{
		a809();
	}

	private void a818(object a816, EventArgs a817)
	{
	}

	private static string a820(string a819)
	{
		int length = a819.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a819[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
