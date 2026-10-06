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

namespace a7;

public class a1071 : XtraForm
{
	private IContainer a1026 = null;

	public GroupBox a1027;

	public PictureBox a1028;

	public Label a1029;

	public Label a1030;

	public Label a1031;

	public Label a1032;

	public Panel a1033;

	public Button a1034;

	public GridControl a1035;

	public GridView a1036;

	public Label a1037;

	private DateTimePicker a1038;

	private TextBox a1039;

	private GridColumn a1040;

	private GridColumn a1041;

	private GridColumn a1042;

	public Label a1043;

	public Label a1044;

	private Button a1045;

	public Label a1046;

	public Label a1047;

	private ContextMenuStrip a1048;

	private ToolStripMenuItem a1049;

	private ToolStripMenuItem a1050;

	protected override void Dispose(bool a1051)
	{
		if (a1051 && a1026 != null)
		{
			a1026.Dispose();
		}
		base.Dispose(a1051);
	}

	private void a1052()
	{
		a1026 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(a1071));
		a1027 = new GroupBox();
		a1045 = new Button();
		a1039 = new TextBox();
		a1038 = new DateTimePicker();
		a1035 = new GridControl();
		a1048 = new ContextMenuStrip(a1026);
		a1049 = new ToolStripMenuItem();
		a1050 = new ToolStripMenuItem();
		a1036 = new GridView();
		a1040 = new GridColumn();
		a1041 = new GridColumn();
		a1042 = new GridColumn();
		a1037 = new Label();
		a1028 = new PictureBox();
		a1043 = new Label();
		a1044 = new Label();
		a1029 = new Label();
		a1046 = new Label();
		a1030 = new Label();
		a1031 = new Label();
		a1047 = new Label();
		a1032 = new Label();
		a1033 = new Panel();
		a1034 = new Button();
		a1027.SuspendLayout();
		((ISupportInitialize)a1035).BeginInit();
		a1048.SuspendLayout();
		((ISupportInitialize)a1036).BeginInit();
		((ISupportInitialize)a1028).BeginInit();
		a1033.SuspendLayout();
		SuspendLayout();
		a1027.Controls.Add(a1045);
		a1027.Controls.Add(a1039);
		a1027.Controls.Add(a1038);
		a1027.Controls.Add(a1035);
		a1027.Controls.Add(a1037);
		a1027.Controls.Add(a1028);
		a1027.Controls.Add(a1043);
		a1027.Controls.Add(a1044);
		a1027.Controls.Add(a1029);
		a1027.Controls.Add(a1046);
		a1027.Controls.Add(a1030);
		a1027.Controls.Add(a1031);
		a1027.Controls.Add(a1047);
		a1027.Controls.Add(a1032);
		a1027.Location = new Point(10, 0);
		a1027.Name = a1070("nźɨͳѵՆ٬ݺ࠰");
		a1027.Size = new Size(642, 633);
		a1027.TabIndex = 6;
		a1027.TabStop = false;
		a1045.Location = new Point(357, 44);
		a1045.Name = a1070("eųɱͰѬլذ");
		a1045.Size = new Size(110, 55);
		a1045.TabIndex = 60;
		a1045.Text = a1070("AŨɮ\u0364");
		a1045.UseVisualStyleBackColor = true;
		a1045.Click += a1065;
		a1039.Font = new Font(a1070("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1039.Location = new Point(75, 73);
		a1039.Name = a1070("\u007fŲɽ\u0349Ѥկٮݨࡢ९\u0a60");
		a1039.Size = new Size(276, 26);
		a1039.TabIndex = 59;
		a1038.Font = new Font(a1070("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1038.ImeMode = ImeMode.NoControl;
		a1038.Location = new Point(75, 44);
		a1038.Name = a1070("lųɄ\u0364ѷ\u0557٣ݳ");
		a1038.Size = new Size(276, 26);
		a1038.TabIndex = 58;
		a1035.ContextMenuStrip = a1048;
		a1035.EmbeddedNavigator.Name = a1070("");
		a1035.Font = new Font(a1070("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1035.Location = new Point(16, 169);
		a1035.LookAndFeel.SkinName = a1070("GżɻͳѯՖ٭ݨ\u086b९");
		a1035.LookAndFeel.UseDefaultLookAndFeel = false;
		a1035.MainView = a1036;
		a1035.Name = a1070("kŹɣ\u036dыը٨ݱࡶ६੮ର");
		a1035.Size = new Size(567, 383);
		a1035.TabIndex = 56;
		a1035.ViewCollection.AddRange(new BaseView[1] { a1036 });
		a1048.Items.AddRange(new ToolStripItem[2] { a1049, a1050 });
		a1048.Name = a1070("rſɡͺѨմٿ\u0747\u086c०ੲ\u0b55\u0c71൶\u0e6a\u0f72\u1030");
		a1048.Size = new Size(161, 48);
		a1049.Name = a1070("gźɾ\u0345ѿՠ٢ݞࡸॹ\u0a63\u0b79\u0c45\u0d62\u0e68\u0f70၍ᅷቧ፬");
		a1049.Size = new Size(160, 22);
		a1049.Text = a1070("Pūɭ");
		a1049.Click += a1059;
		a1050.Name = a1070("Tǣɳ\u0349ѽթٳݱࡴॲ\u0a64\u0b7c\u0c47ൺ\u0e7eཅၿᅠቢ\u135eᑸᕹᙣ\u1779ᡅᥢ\u1a68\u1b70ᱍᵷṧὬ");
		a1050.Size = new Size(160, 22);
		a1050.Text = a1070("EǬɢ\u032eљխٹݣࡡ।\u0a62୴౬ത๐ཫ\u106d");
		a1050.Click += a1062;
		a1036.BorderStyle = BorderStyles.NoBorder;
		a1036.Columns.AddRange(new GridColumn[3] { a1040, a1041, a1042 });
		a1036.FocusRectStyle = DrawFocusRectStyle.RowFocus;
		a1036.GridControl = a1035;
		a1036.Name = a1070("nźɮ\u0362ѓխ٦ݵ࠰");
		a1036.OptionsBehavior.Editable = false;
		a1036.OptionsCustomization.AllowFilter = false;
		a1036.OptionsCustomization.AllowGroup = false;
		a1036.OptionsCustomization.AllowSort = false;
		a1036.OptionsFilter.AllowFilterEditor = false;
		a1036.OptionsView.ShowGroupPanel = false;
		a1040.Caption = a1070("KŅ");
		a1040.FieldName = a1070("KŅ");
		a1040.Name = a1070("lŸɠ\u036cфթ٩ݱ\u086e६ਰ");
		a1040.OptionsColumn.AllowEdit = false;
		a1041.Caption = a1070("Qťɱ\u036bѩ");
		a1041.FieldName = a1070("QŅɑ\u034bщ");
		a1041.Name = a1070("lŸɠ\u036cфթ٩ݱ\u086e६ਲ਼");
		a1041.OptionsColumn.AllowEdit = false;
		a1041.Visible = true;
		a1041.VisibleIndex = 0;
		a1041.Width = 114;
		a1042.Caption = a1070("IǠ\u0337\u036eѨբٯݠ");
		a1042.FieldName = a1070("Ińɏ\u034eшՂ\u064f\u0740");
		a1042.Name = a1070("lŸɠ\u036cфթ٩ݱ\u086e६ਲ");
		a1042.OptionsColumn.AllowEdit = false;
		a1042.Visible = true;
		a1042.VisibleIndex = 1;
		a1042.Width = 390;
		a1037.AutoSize = true;
		a1037.Font = new Font(a1070("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a1037.Location = new Point(18, 153);
		a1037.Name = a1070("jŤɦ\u0366ѮԳ");
		a1037.Size = new Size(114, 13);
		a1037.TabIndex = 57;
		a1037.Text = a1070("Aŵɧͻѽ\u0530و\u07f2ࡣॠ੮\u0b78ౠന\u0e4b\u0f6fၶᅰቦ፱ᑨ");
		a1028.Image = (Image)componentResourceManager.GetObject(a1070("aŹɬͺѸվٮ\u0748ࡦ॰ਸ਼ନ\u0c4c൩\u0e62ཥ\u1064"));
		a1028.InitialImage = null;
		a1028.Location = new Point(501, 15);
		a1028.Name = a1070("{ţɪͼѲմ٠\u0746\u086cॺਰ");
		a1028.Size = new Size(128, 128);
		a1028.SizeMode = PictureBoxSizeMode.AutoSize;
		a1028.TabIndex = 0;
		a1028.TabStop = false;
		a1043.AutoSize = true;
		a1043.BackColor = Color.Transparent;
		a1043.Font = new Font(a1070("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1043.Location = new Point(19, 80);
		a1043.Name = a1070("jŤɦ\u0366ѮԴ");
		a1043.Size = new Size(48, 13);
		a1043.TabIndex = 55;
		a1043.Text = a1070("IǠ\u0337\u036eѨբٯݠ");
		a1044.AutoSize = true;
		a1044.BackColor = Color.Transparent;
		a1044.Font = new Font(a1070("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1044.Location = new Point(19, 51);
		a1044.Name = a1070("jŤɦ\u0366ѮԲ");
		a1044.Size = new Size(31, 13);
		a1044.TabIndex = 55;
		a1044.Text = a1070("Qťɱ\u036bѩ");
		a1029.AutoSize = true;
		a1029.BackColor = Color.Transparent;
		a1029.Font = new Font(a1070("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a1029.Location = new Point(13, 564);
		a1029.Name = a1070("jŤɦ\u0366Ѯ\u0530");
		a1029.Size = new Size(37, 13);
		a1029.TabIndex = 55;
		a1029.Text = a1070("PŽɢͰ\u0530");
		a1046.BackColor = Color.FromArgb(128, 255, 128);
		a1046.BorderStyle = BorderStyle.Fixed3D;
		a1046.FlatStyle = FlatStyle.Flat;
		a1046.Location = new Point(22, 109);
		a1046.Name = a1070("jŤɦ\u0366ѮԷ");
		a1046.Size = new Size(328, 3);
		a1046.TabIndex = 54;
		a1030.BackColor = Color.FromArgb(128, 255, 128);
		a1030.BorderStyle = BorderStyle.Fixed3D;
		a1030.FlatStyle = FlatStyle.Flat;
		a1030.Location = new Point(16, 554);
		a1030.Name = a1070("kŧɧ\u0361ѯԳز");
		a1030.Size = new Size(507, 3);
		a1030.TabIndex = 54;
		a1031.AutoSize = true;
		a1031.Font = new Font(a1070("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a1031.Location = new Point(18, 15);
		a1031.Name = a1070("jŤɦ\u0366ѮԹ");
		a1031.Size = new Size(177, 13);
		a1031.TabIndex = 51;
		a1031.Text = a1070("BǦɲʹѲջ\u0670\u0734ࡊॳ\u0a61ਡ\u0c63൯\u0e60\u0f6d\u1072ᅫቪ፩ᑬᔦᙑᝥᡱᥫ\u1a69");
		a1047.AutoSize = true;
		a1047.Location = new Point(19, 117);
		a1047.Name = a1070("jŤɦ\u0366ѮԶ");
		a1047.Size = new Size(374, 26);
		a1047.TabIndex = 49;
		a1047.Text = a1070("Õǣ\u02f6ϩӪ\u05a2ەߡࠋग\u0a11ଐఞഈฐམ\u1036ဩሔቫᕂᔖᘐ\u171b᠆᥎ᨡᬅᰘᴞḌἑ\u2002ⅆ∑⌅␍\u2453☌✌⠾⤺⭬⩃\u2d6aⴴ⽨⼢ぷ\u3102㈴㌿㐷㔻㘣㜴㠪㥮㩀㭆㰒㶶㸢㼤䀢䄫䈠䍤䐎䔧䘳䜫䡚䥄䩑䭙䱉䵓乗作偒儖剃卑吓啅噔坒堏姒婗孉屙嵃幇彌恂愆扊挄摗敃晓杉桷楲橸歮汿浿渹潡烫煽特獱瑾畷瘱睷硪祼竪筩籠給繬繗聢腫艠荾萭蔏蘋");
		a1032.AutoSize = true;
		a1032.Location = new Point(13, 581);
		a1032.Name = a1070("jŤɦ\u0366ѮԵ");
		a1032.Size = new Size(382, 39);
		a1032.TabIndex = 49;
		a1032.Text = componentResourceManager.GetString(a1070("gūɫ\u036dѫԲثݐࡦॺ\u0a75"));
		a1033.BackColor = Color.FromArgb(233, 235, 236);
		a1033.Controls.Add(a1034);
		a1033.Dock = DockStyle.Bottom;
		a1033.Location = new Point(0, 639);
		a1033.Name = a1070("vŤɪ\u0366Ѯ\u0530");
		a1033.Size = new Size(662, 37);
		a1033.TabIndex = 7;
		a1034.Dock = DockStyle.Fill;
		a1034.Location = new Point(0, 0);
		a1034.Name = a1070("jųɨ\u0346ѭը٫ݲ");
		a1034.Size = new Size(662, 37);
		a1034.TabIndex = 1;
		a1034.Text = a1070("Â5ɨȳ՞");
		a1034.UseVisualStyleBackColor = true;
		Appearance.BackColor = Color.White;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(662, 676);
		Controls.Add(a1027);
		Controls.Add(a1033);
		KeyPreview = true;
		Name = a1070("Iżɠ\u0355Ѿա٥ݭࡪ\u0963\u0a4b୫\u0c47\u0d63\u0e78");
		ShowIcon = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a1070("mǏə\u035dѕՂ\u064b܍ࡵ\u094aਗ਼ਘ\u0c44\u0d46\u0e4bངၝᅂቁፀᑋᔿᙊ\u177cᡮᥲ\u1a72᭵ᱽᵥḶἽ⁆ⅶ≡⍼⑹┯♚❬⡸⥢⩦⬩ⱏ\u2dfb\u2e68⽩ちㅱ㉫㌨");
		KeyDown += a1068;
		a1027.ResumeLayout(performLayout: false);
		a1027.PerformLayout();
		((ISupportInitialize)a1035).EndInit();
		a1048.ResumeLayout(performLayout: false);
		((ISupportInitialize)a1036).EndInit();
		((ISupportInitialize)a1028).EndInit();
		a1033.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public a1071()
	{
		a1052();
		a1053();
	}

	public void a1053()
	{
		int focusedRowHandle = a1036.FocusedRowHandle;
		a1344.a1307();
		a1344.a1271.CommandText = a1070("\u001důɾͶѼջ٣ܖࡼ॰ਟ୦\u0c70\u0d62\u0e66སခᅭቨ፣ᑢᕤᙦᝫᡤᤄ\u1a65\u1b70ᱮᵭḿὊ⁜ⅎ≒⍒\u2452║♄❟⡁⤴⩜⭀ⱕⵕ⹝⼮くㅕ㈫㍞㑈㕚㙎㝎㠥㥀㩆㭑㱂");
		a1035.DataSource = a2147.a2105(a1344.a1271);
		a1036.FocusedRowHandle = focusedRowHandle;
	}

	public void a1054()
	{
		a1344.a1307();
		a1344.a1271.CommandText = a1070("\vŮɬ\u0364Ѣղ٠܄ࡥ॰੮୭\u0c3f\u0d4a\u0e5cཎၒᅒቒፑᑄᕟᙁ\u1734ᡄᥚᩔ\u1b42\u1c4aᴮṙὍ⁙⅃≁⌵⑇╒♄❖⡊⥊⨡");
		a1344.a1271.Parameters.Add(a1070("QŅɑ\u034bщ"), SqlDbType.DateTime).Value = a1038.Value.ToString(a1070("sŰɱ;ЫՈىܮࡦ॥"));
		a1344.a1271.ExecuteNonQuery();
		a1344.a1307();
		a1344.a1271.CommandText = a1070("cċȏ\u0313Ѻլ٩ܜࡲॴ੭୷గ\u0d62\u0e74སၺᅺቺ፹ᑼᕧᙹᜌ᠃\u197e\u1a68᭺ᱮᵮḉὥ\u2060Ⅻ≪⍬\u245e╓♜✵⠻⥌⩘⭔ⱂⵓ⹆⼴〻ㅒ㉅㍑㑝㕇㙅㜠㡋㥋㩊㭁㱌㵊㹄㽉䁂䄫䈡");
		a1344.a1271.Parameters.Add(a1070("QŅɑ\u034bщ"), SqlDbType.DateTime).Value = a1038.Value.ToString(a1070("sŰɱ;ЫՈىܮࡦ॥"));
		a1344.a1271.Parameters.Add(a1070("Ińɏ\u034eшՂ\u064f\u0740"), SqlDbType.VarChar).Value = a1039.Text;
		a1344.a1271.ExecuteNonQuery();
		a1039.Text = a1070("");
		a1053();
	}

	public void a1055()
	{
		if (a1036.RowCount > 0 && MessageBox.Show(a1070("ĝsɇ\u034fфՍ؇ݢࡀ\u0952\u0a42\u0b4f\u0c01\u0d45\u0e6b\u0f73ၸᅷሻ፳ᑪᕬᙲ\u1772\u187c\u180b\u1a7a᭼ᱸᵪṪἮ\u2068Ⅱ≢⍤␩╥♮❵⡬⥪⩪⭸Ⱟ"), a1070("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.Cancel)
		{
			int num = Convert.ToInt32(a1036.GetFocusedRowCellValue(a1070("KŅ")));
			a1344.a1307();
			a1344.a1271.CommandText = a1070("\u0004ŧɧ\u036dѥՋ\u065b\u073d\u085a\u0949\u0a55\u0b54స\u0d43๗ཇၝᅛ\u1259ፘᑃᕆᙚᜭᡛ\u1943ᩏ᭛ᱍᴧṏὁ‹⅃≋⍅");
			a1344.a1271.Parameters.Add(a1070("KŅ"), SqlDbType.Int).Value = num;
			a1344.a1271.ExecuteNonQuery();
			a1053();
		}
	}

	public void a1056()
	{
		if (MessageBox.Show(a1070("ĝsɇ\u034fфՍ؇ݢࡀ\u0952\u0a42\u0b4f\u0c01\u0d45\u0e6b\u0f73ၸᅷሻ፳ᑪᕬᙲ\u1772\u187c\u180b\u1a7a᭼ᱸᵪṪἮ\u2068Ⅱ≢⍤␩╥♮❵⡬⥪⩪⭸Ⱟ"), a1070("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
		{
			a1344.a1307();
			a1344.a1271.CommandText = a1070("8œɓ\u0359ёՇ\u0657\u0731ࡖढ़\u0a41\u0b40బൟ\u0e4bཛ၁ᅏቍፌᑗᕊᙖᜡ");
			a1344.a1271.ExecuteNonQuery();
		}
		a1053();
	}

	private void a1059(object a1057, EventArgs a1058)
	{
		a1055();
	}

	private void a1062(object a1060, EventArgs a1061)
	{
		a1056();
	}

	private void a1065(object a1063, EventArgs a1064)
	{
		a1054();
	}

	private void a1068(object a1066, KeyEventArgs a1067)
	{
		if (a1067.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private static string a1070(string a1069)
	{
		int length = a1069.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a1069[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
