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

public class a1126 : XtraForm
{
	private IContainer a1074 = null;

	public Panel a1075;

	public Button a1076;

	public Button a1077;

	public GroupBox a1078;

	public Button a1079;

	public System.Windows.Forms.ComboBox a1080;

	public GridControl a1081;

	public GridView a1082;

	public Label a1083;

	public Label a1084;

	public Label a1085;

	public Label a1086;

	public Label a1087;

	public Button a1088;

	public TextBox a1089;

	public Label a1090;

	private GridColumn a1091;

	private GridColumn a1092;

	public Label a1093;

	public Label a1094;

	public Label a1095;

	public System.Windows.Forms.ComboBox a1096;

	private ContextMenuStrip a1097;

	private ToolStripMenuItem a1098;

	private GridColumn a1099;

	private PictureBox a1100;

	protected override void Dispose(bool a1101)
	{
		if (a1101 && a1074 != null)
		{
			a1074.Dispose();
		}
		base.Dispose(a1101);
	}

	private void a1102()
	{
		a1074 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(a1126));
		a1075 = new Panel();
		a1076 = new Button();
		a1077 = new Button();
		a1078 = new GroupBox();
		a1096 = new System.Windows.Forms.ComboBox();
		a1095 = new Label();
		a1093 = new Label();
		a1094 = new Label();
		a1088 = new Button();
		a1089 = new TextBox();
		a1090 = new Label();
		a1079 = new Button();
		a1080 = new System.Windows.Forms.ComboBox();
		a1081 = new GridControl();
		a1097 = new ContextMenuStrip(a1074);
		a1098 = new ToolStripMenuItem();
		a1082 = new GridView();
		a1091 = new GridColumn();
		a1092 = new GridColumn();
		a1099 = new GridColumn();
		a1083 = new Label();
		a1084 = new Label();
		a1085 = new Label();
		a1086 = new Label();
		a1087 = new Label();
		a1100 = new PictureBox();
		a1075.SuspendLayout();
		a1078.SuspendLayout();
		((ISupportInitialize)a1081).BeginInit();
		a1097.SuspendLayout();
		((ISupportInitialize)a1082).BeginInit();
		((ISupportInitialize)a1100).BeginInit();
		SuspendLayout();
		a1075.BackColor = Color.FromArgb(233, 235, 236);
		a1075.Controls.Add(a1076);
		a1075.Controls.Add(a1077);
		a1075.Dock = DockStyle.Bottom;
		a1075.Location = new Point(0, 534);
		a1075.Name = a1125("vŤɪ\u0366Ѯ\u0530");
		a1075.Size = new Size(550, 37);
		a1075.TabIndex = 2;
		a1076.Dock = DockStyle.Fill;
		a1076.Location = new Point(274, 0);
		a1076.Name = a1125("jųɨ\u0346ѭը٫ݲ");
		a1076.Size = new Size(276, 37);
		a1076.TabIndex = 1;
		a1076.Text = a1125("Â5ɨȳ՞");
		a1076.UseVisualStyleBackColor = true;
		a1076.Click += a1120;
		a1077.Dock = DockStyle.Left;
		a1077.Location = new Point(0, 0);
		a1077.Name = a1125("kżɩ\u034dѤս٧ݧࡵ");
		a1077.Size = new Size(274, 37);
		a1077.TabIndex = 0;
		a1077.Text = a1125("MŤɽ\u0367ѧյ");
		a1077.UseVisualStyleBackColor = true;
		a1077.Click += a1114;
		a1078.Controls.Add(a1096);
		a1078.Controls.Add(a1095);
		a1078.Controls.Add(a1093);
		a1078.Controls.Add(a1094);
		a1078.Controls.Add(a1088);
		a1078.Controls.Add(a1089);
		a1078.Controls.Add(a1090);
		a1078.Controls.Add(a1079);
		a1078.Controls.Add(a1080);
		a1078.Controls.Add(a1081);
		a1078.Controls.Add(a1083);
		a1078.Controls.Add(a1084);
		a1078.Controls.Add(a1085);
		a1078.Controls.Add(a1086);
		a1078.Controls.Add(a1087);
		a1078.Controls.Add(a1100);
		a1078.Location = new Point(8, 4);
		a1078.Name = a1125("nźɨͳѵՆ٬ݺ࠰");
		a1078.Size = new Size(530, 520);
		a1078.TabIndex = 3;
		a1078.TabStop = false;
		a1078.Enter += a1123;
		a1096.DropDownStyle = ComboBoxStyle.DropDownList;
		a1096.Font = new Font(a1125("RŤɬ\u036cѯՠ"), 15.75f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1096.FormattingEnabled = true;
		a1096.Location = new Point(453, 111);
		a1096.Name = a1125("iūɅ\u0362Ѵծ١ݹࡋ\u0945");
		a1096.Size = new Size(69, 33);
		a1096.TabIndex = 93;
		a1096.Visible = false;
		a1095.AutoSize = true;
		a1095.Location = new Point(8, 494);
		a1095.Name = a1125("jŤɦ\u0366ѮԴ");
		a1095.Size = new Size(434, 13);
		a1095.TabIndex = 92;
		a1095.Text = a1125("\u000eļȫ\u0323ѶԞصܡ\u0826ऽ\u0a31ଽൿണ\u0f7d༥\u106aᄂሩጾᐤᑴᙤᜐᠭ\u192fᨲ᭞ᱍᰌṒὟ⁛ℙ≺⍂␖╹♝❀⡆⥔⩔⭊ⱀⴍ\u2e78⽊い〘㉅㍋㑇㕈㜕㙼㠂㥮㩌㭻㱫㰂㹩㽵䁯䅣䈸䍜䑷䕬䙶䝼䡾䥰䩾䬯䱅䵬乾使儻儩剛卮呪啬噪坪塸夯");
		a1093.AutoSize = true;
		a1093.Font = new Font(a1125("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a1093.Location = new Point(13, 131);
		a1093.Name = a1125("kŧɧ\u0361ѯԳر");
		a1093.Size = new Size(43, 13);
		a1093.TabIndex = 90;
		a1093.Text = a1125("RſɤͶԲԢػ");
		a1094.AutoSize = true;
		a1094.Location = new Point(13, 148);
		a1094.Name = a1125("jŤɦ\u0366ѮԸ");
		a1094.Size = new Size(390, 13);
		a1094.TabIndex = 91;
		a1094.Text = a1125("\u0004ĮȠɼСԧثܤॹ\u0818੦ଊఠശཝ༴\u102eᅊቄጝᑨᕞᙉᝍ᠘\u197c\u1a57ᭇ᱀ᵟṓὃ℁⅁⌟⌍⑵╎♞❂⡁⥋⩏⬅ⱴⵆ⹐⽒くㅱ㉻㍱㐼㕟㜫㙆㤩㥹㩲㭴㰴㵘㹻㽼䁣䅪䉷䍨䐬䕝䙯䝻䡥䥢䩿䭬䱪䵪乸伯");
		a1088.Image = a2268.a2305;
		a1088.ImageAlign = ContentAlignment.MiddleLeft;
		a1088.Location = new Point(224, 36);
		a1088.Name = a1125("kżɩ\u034dѤնٷ\u074c\u086e");
		a1088.Size = new Size(42, 33);
		a1088.TabIndex = 88;
		a1088.UseVisualStyleBackColor = true;
		a1088.Click += a1108;
		a1089.Font = new Font(a1125("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 15.75f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1089.Location = new Point(59, 37);
		a1089.MaxLength = 8;
		a1089.Name = a1125("}Űɳ\u034dѤնٷ\u074c\u086e");
		a1089.Size = new Size(165, 31);
		a1089.TabIndex = 87;
		a1090.AutoSize = true;
		a1090.Location = new Point(9, 44);
		a1090.Name = a1125("jŤɦ\u0366ѮԲ");
		a1090.Size = new Size(43, 13);
		a1090.TabIndex = 89;
		a1090.Text = a1125("LŧɷͰУՌٮ");
		a1079.BackColor = Color.LightGray;
		a1079.Font = new Font(a1125("RŤɬ\u036cѯՠ"), 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a1079.ForeColor = Color.Black;
		a1079.Location = new Point(328, 68);
		a1079.Name = a1125("oŸɥ\u0347Ѭպ٬ݣࡿ\u0941੨୮\u0c64");
		a1079.Size = new Size(36, 35);
		a1079.TabIndex = 86;
		a1079.Text = a1125("*");
		a1079.UseVisualStyleBackColor = false;
		a1079.Click += a1111;
		a1080.DropDownStyle = ComboBoxStyle.DropDownList;
		a1080.Font = new Font(a1125("RŤɬ\u036cѯՠ"), 15.75f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1080.FormattingEnabled = true;
		a1080.Location = new Point(59, 69);
		a1080.Name = a1125("kťɋ\u0360Ѷը٧ݻ");
		a1080.Size = new Size(269, 33);
		a1080.TabIndex = 1;
		a1081.ContextMenuStrip = a1097;
		a1081.EmbeddedNavigator.Name = a1125("");
		a1081.Font = new Font(a1125("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1081.Location = new Point(13, 200);
		a1081.LookAndFeel.SkinName = a1125("GżɻͳѯՖ٭ݨ\u086b९");
		a1081.LookAndFeel.UseDefaultLookAndFeel = false;
		a1081.MainView = a1082;
		a1081.Name = a1125("kŹɣ\u036dыը٨ݱࡶ६੮ର");
		a1081.Size = new Size(509, 284);
		a1081.TabIndex = 6;
		a1081.ViewCollection.AddRange(new BaseView[1] { a1082 });
		a1097.Items.AddRange(new ToolStripItem[1] { a1098 });
		a1097.Name = a1125("rſɡͺѨմٿ\u0747\u086c०ੲ\u0b55\u0c71൶\u0e6a\u0f72\u1030");
		a1097.Size = new Size(103, 42);
		a1098.Image = a2268.a2341;
		a1098.ImageScaling = ToolStripItemImageScaling.None;
		a1098.Name = a1125("gźɾ\u0345ѿՠ٢ݞࡸॹ\u0a63\u0b79\u0c45\u0d62\u0e68\u0f70၍ᅷቧ፬");
		a1098.Size = new Size(102, 38);
		a1098.Text = a1125("Pūɭ");
		a1098.Click += a1117;
		a1082.BorderStyle = BorderStyles.NoBorder;
		a1082.Columns.AddRange(new GridColumn[3] { a1091, a1092, a1099 });
		a1082.FocusRectStyle = DrawFocusRectStyle.RowFocus;
		a1082.GridControl = a1081;
		a1082.Name = a1125("nźɮ\u0362ѓխ٦ݵ࠰");
		a1082.OptionsBehavior.Editable = false;
		a1082.OptionsCustomization.AllowFilter = false;
		a1082.OptionsCustomization.AllowGroup = false;
		a1082.OptionsCustomization.AllowSort = false;
		a1082.OptionsFilter.AllowFilterEditor = false;
		a1082.OptionsView.ShowGroupPanel = false;
		a1091.Caption = a1125("KŅ");
		a1091.FieldName = a1125("KŅ");
		a1091.Name = a1125("lŸɠ\u036cфթ٩ݱ\u086e६ਰ");
		a1092.Caption = a1125("Fŭɹ;ЩՆٲݫࡤॶ\u0a62ୱര");
		a1092.FieldName = a1125("Bŉɕ\u0352ыՋ\u064b\u0747\u0859");
		a1092.Name = a1125("lŸɠ\u036cфթ٩ݱ\u086e६ਲ਼");
		a1092.Visible = true;
		a1092.VisibleIndex = 1;
		a1092.Width = 153;
		a1099.Caption = a1125("KŠɶ\u0368ѧջ");
		a1099.FieldName = a1125("Kŀɖ\u0348ч՛");
		a1099.Name = a1125("lŸɠ\u036cфթ٩ݱ\u086e६ਲ");
		a1099.Visible = true;
		a1099.VisibleIndex = 0;
		a1099.Width = 309;
		a1083.AutoSize = true;
		a1083.Location = new Point(9, 399);
		a1083.Name = a1125("jŤɦ\u0366ѮԳ");
		a1083.Size = new Size(255, 13);
		a1083.TabIndex = 60;
		a1083.Text = a1125("~ŕɓ\u035bуԘٵݟ\u0859\u0953ਗ਼\u0b5e\u0c54\u0d42ๆཀ၄ᄌቬᏖᑇᕋᙂᝊᡉ\u1941ᩎᭇ\u1c4aᴀṶΌ⁴ⅲ∻⍶⑰╫♣❳⡬⥱⨳⯵ⱸ\u2d76\u2e7b⼮べ〽㉠㍦㑨㕱㜶㝨㤴㥾㨭㬏㰋");
		a1084.AutoSize = true;
		a1084.Font = new Font(a1125("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a1084.Location = new Point(12, 180);
		a1084.Name = a1125("jŤɦ\u0366Ѯ\u0530");
		a1084.Size = new Size(98, 13);
		a1084.TabIndex = 55;
		a1084.Text = a1125("EŵɼͺЭՇ٪ݸࡽन\u0a4b୯\u0c76൰\u0e66\u0f71\u1068");
		a1085.BackColor = Color.FromArgb(128, 255, 128);
		a1085.BorderStyle = BorderStyle.Fixed3D;
		a1085.FlatStyle = FlatStyle.Flat;
		a1085.ForeColor = Color.DarkOrange;
		a1085.Location = new Point(14, 171);
		a1085.Name = a1125("kŧɧ\u0361ѯԳز");
		a1085.Size = new Size(501, 3);
		a1085.TabIndex = 54;
		a1086.AutoSize = true;
		a1086.Font = new Font(a1125("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a1086.Location = new Point(7, 11);
		a1086.Name = a1125("jŤɦ\u0366ѮԹ");
		a1086.Size = new Size(66, 13);
		a1086.TabIndex = 0;
		a1086.Text = a1125("GŪɸͽШՅٯݩࡣ४\u0a71୨");
		a1087.AutoSize = true;
		a1087.Location = new Point(9, 78);
		a1087.Name = a1125("jŤɦ\u0366ѮԵ");
		a1087.Size = new Size(41, 13);
		a1087.TabIndex = 49;
		a1087.Text = a1125("KŠɶ\u0368ѧջ");
		a1100.Image = (Image)componentResourceManager.GetObject(a1125("aŹɬͺѸվٮ\u0748ࡦ॰ਸ਼ନ\u0c4c൩\u0e62ཥ\u1064"));
		a1100.Location = new Point(396, 12);
		a1100.Name = a1125("{ţɪͼѲմ٠\u0746\u086cॺਰ");
		a1100.Size = new Size(130, 93);
		a1100.TabIndex = 94;
		a1100.TabStop = false;
		Appearance.BackColor = Color.White;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(550, 571);
		Controls.Add(a1078);
		Controls.Add(a1075);
		Name = a1125("Iżɠ\u0358Ѯչٽ\u0743ࡦॴ\u0a71\u0b48౪൱\u0e75");
		ShowIcon = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a1125("Gŷɢ\u0364ЯՅ٬ݾࡿप\u0a5d୩౩ష\u0e68ཨ\u1062ᅯበ");
		a1075.ResumeLayout(performLayout: false);
		a1078.ResumeLayout(performLayout: false);
		a1078.PerformLayout();
		((ISupportInitialize)a1081).EndInit();
		a1097.ResumeLayout(performLayout: false);
		((ISupportInitialize)a1082).EndInit();
		((ISupportInitialize)a1100).EndInit();
		ResumeLayout(performLayout: false);
	}

	public a1126()
	{
		a1102();
		a1984.a1891(this);
		a1984.a1964(a1125("rťɓ\u035bўՈػݓ\u085dऴ\u0a56\u0b52\u0c5cഴ๕ཀ\u105eᅝሯፗᑘᕇᙇᝏᡄ᥍\u1a58ᭋ᱀ᵖṈ\u1f47⁛"), a1096, a1080);
		a1103();
	}

	public void a1103()
	{
		int focusedRowHandle = a1082.FocusedRowHandle;
		DataTable dataSource = a2147.a2105(a1125("@Čț\u0311ЙԘ؎ݹࠑओ\u0a7aଞక\u0d01ฆ༟ဟᄇላጕᑠᔆᘏ\u171b᠃ᤂ\u1a1c᭸ᱬᴐḇἍ\u2005ⅼ≪⌝⑽╿♳✙⡾⥥⩹⭸Ⱄ\u2d6a\u2e67⽺ぼㅪ㉣㍨㑳㕦㙯㝻㡣㥢㩼㬅㱳㵫㹧㽳䁥䄿䉗䍙䐡䕖䙟䝋䡓䥒䩌䭜䱐䴺串佗偂兀剃匭员啎噙坝塃奆婔孑屈嵊幑录"));
		a1081.DataSource = dataSource;
		if (focusedRowHandle > 0 && a1082.RowCount >= focusedRowHandle)
		{
			a1082.FocusedRowHandle = focusedRowHandle;
		}
	}

	public void a1104()
	{
		if (!(a1089.Text == a1125("")) && !(a1080.Text == a1125("")))
		{
			a1096.SelectedIndex = a1080.SelectedIndex;
			a1344.a1307();
			a1344.a1271.CommandText = a1125("\u000ežɩ\u0367ѯժټ܇\u086fॡ\u0a04\u0b65\u0c70൮\u0e6d\u0f3f၊ᅘ\u124fፏᑑᕘᙊᝃᡚᥜᩇᭇ\u1c32ᵆṘὊ⁜ⅈ∬⍀\u244b╛♜❉⡉⥍⩁⭛ⰿ\u2d26") + a1089.Text + a1125("&");
			DataTable dataTable = a2147.a2105(a1344.a1271);
			if (dataTable.Rows.Count > 0)
			{
				MessageBox.Show(a1125("\\Ũȼ\u0350ѻի٬\u0737ࡒॴ\u0a7c୲ల\u0dc7\u0e7eཬ\u106bᄭቇ፪ᑳᕭ᙭ᝣᡯᥩ\u1a69᭪ᵝᴯ"), a1125("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			a1344.a1307();
			a1344.a1271.CommandText = a1125("kăȇ\u031bЂԔ\u0611ݤࠊऌਕଏట൪\u0e78\u0f6fၯᅱቸ፪ᑣᕺᙼᝧᡧᤒ\u1a19᭻ᱮᵼṹὢ\u2064Ⅲ≬⍰␋╫♠❶⡨⥧⩻⭩ⱛⴷ⸽⽊ずㅖ㉌㍝㑄㔾㙕㝟㡒㥀㩅㭞㱀㵆㹈㽔䀧䅊䉄䍍䑕䕍䙀䝞䡊䥆䨨");
			a1344.a1271.Parameters.Add(a1125("Bŉɕ\u0352ыՋ\u064b\u0747\u0859"), SqlDbType.NVarChar).Value = a1089.Text;
			a1344.a1271.Parameters.Add(a1125("Ełɔ\u034eсՙ\u064b\u0745"), SqlDbType.NVarChar).Value = Convert.ToInt32(a1096.Text);
			a1344.a1271.ExecuteNonQuery();
			a1089.Text = a1125("");
			a1103();
		}
	}

	public void a1105()
	{
		if (a1082.RowCount > 0)
		{
			if (MessageBox.Show(a1125("sŶɲͰѹԻܪنࡴॲ\u0a7b\u0b7c౺ൺาཞၾᅮቷ፡ᔽᕲᙥ\u177bᡥᥲ\u1a75\u1b70ᱪᵶṸἯ"), a1125("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.Cancel)
			{
				return;
			}
			int num = Convert.ToInt32(a1082.GetFocusedRowCellValue(a1125("KŅ")).ToString());
			a1344.a1307();
			a1344.a1271.CommandText = a1125("\u0004ŧɧ\u036dѥՋ\u065b\u073d\u085a\u0949\u0a55\u0b54స\u0d43๓ཆ၀ᅘቓፃᑄᕃᙇ\u175eᡘ\u192b\u1a5d\u1b41ᱍᵕṃἥ⁍ⅇ∿⌦") + num + a1125("&");
			a1344.a1271.ExecuteNonQuery();
		}
		a1103();
	}

	private void a1108(object a1106, EventArgs a1107)
	{
		a1089.Text = a1344.a1303();
	}

	private void a1111(object a1109, EventArgs a1110)
	{
		a821 a2269 = new a821();
		a2006 a2270 = new a2006(a2269, 30);
		a2270.ShowDialog();
		a1984.a1964(a1125("rťɓ\u035bўՈػݓ\u085dऴ\u0a56\u0b52\u0c5cഴ๕ཀ\u105eᅝሯፗᑘᕇᙇᝏᡄ᥍\u1a58ᭋ᱀ᵖṈ\u1f47⁛"), a1096, a1080);
	}

	private void a1114(object a1112, EventArgs a1113)
	{
		a1104();
	}

	private void a1117(object a1115, EventArgs a1116)
	{
		a1105();
	}

	private void a1120(object a1118, EventArgs a1119)
	{
		Close();
	}

	private void a1123(object a1121, EventArgs a1122)
	{
	}

	private static string a1125(string a1124)
	{
		int length = a1124.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a1124[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
