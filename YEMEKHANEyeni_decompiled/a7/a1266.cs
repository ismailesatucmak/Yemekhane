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

public class a1266 : XtraForm
{
	private IContainer a1176 = null;

	private GroupBox a1177;

	public TextBox a1178;

	public Label a1179;

	public TextBox a1180;

	public TextBox a1181;

	public Label a1182;

	public Label a1183;

	public Button a1184;

	public Label a1185;

	public System.Windows.Forms.ComboBox a1186;

	public System.Windows.Forms.ComboBox a1187;

	public Label a1188;

	public GridControl a1189;

	public GridView a1190;

	private DateTimePicker a1191;

	private DateTimePicker a1192;

	public Label a1193;

	public Label a1194;

	private GroupBox a1195;

	private GridColumn a1196;

	private GridColumn a1197;

	private GridColumn a1198;

	private GridColumn a1199;

	private GridColumn a1200;

	private GridColumn a1201;

	private GridColumn a1202;

	private GridColumn a1203;

	private GridColumn a1204;

	private GridColumn a1205;

	private GridColumn a1206;

	private GridColumn a1207;

	public Button a1208;

	public Button a1209;

	public Label a1210;

	private GridColumn a1211;

	private GridColumn a1212;

	private GridColumn a1213;

	private CheckBox a1214;

	private CheckBox a1215;

	private CheckBox a1216;

	private CheckedListBox a1217;

	private CheckedListBox a1218;

	public Label a1219;

	public Label a1220;

	private GridColumn a1221;

	private GridColumn a1222;

	private CheckedListBox a1223;

	private CheckedListBox a1224;

	private ContextMenuStrip a1225;

	private ToolStripMenuItem a1226;

	private ToolStripMenuItem a1227;

	private ContextMenuStrip a1228;

	private ToolStripMenuItem a1229;

	private ToolStripMenuItem a1230;

	private GridColumn a1231;

	private GridColumn a1232;

	protected override void Dispose(bool a1233)
	{
		if (a1233 && a1176 != null)
		{
			a1176.Dispose();
		}
		base.Dispose(a1233);
	}

	private void a1234()
	{
		a1176 = new Container();
		a1177 = new GroupBox();
		a1223 = new CheckedListBox();
		a1224 = new CheckedListBox();
		a1225 = new ContextMenuStrip(a1176);
		a1226 = new ToolStripMenuItem();
		a1227 = new ToolStripMenuItem();
		a1214 = new CheckBox();
		a1215 = new CheckBox();
		a1216 = new CheckBox();
		a1217 = new CheckedListBox();
		a1218 = new CheckedListBox();
		a1228 = new ContextMenuStrip(a1176);
		a1229 = new ToolStripMenuItem();
		a1230 = new ToolStripMenuItem();
		a1191 = new DateTimePicker();
		a1185 = new Label();
		a1192 = new DateTimePicker();
		a1186 = new System.Windows.Forms.ComboBox();
		a1178 = new TextBox();
		a1187 = new System.Windows.Forms.ComboBox();
		a1219 = new Label();
		a1220 = new Label();
		a1210 = new Label();
		a1193 = new Label();
		a1194 = new Label();
		a1188 = new Label();
		a1179 = new Label();
		a1180 = new TextBox();
		a1181 = new TextBox();
		a1182 = new Label();
		a1183 = new Label();
		a1208 = new Button();
		a1209 = new Button();
		a1184 = new Button();
		a1189 = new GridControl();
		a1190 = new GridView();
		a1196 = new GridColumn();
		a1197 = new GridColumn();
		a1198 = new GridColumn();
		a1199 = new GridColumn();
		a1200 = new GridColumn();
		a1201 = new GridColumn();
		a1202 = new GridColumn();
		a1203 = new GridColumn();
		a1204 = new GridColumn();
		a1213 = new GridColumn();
		a1205 = new GridColumn();
		a1206 = new GridColumn();
		a1207 = new GridColumn();
		a1211 = new GridColumn();
		a1212 = new GridColumn();
		a1221 = new GridColumn();
		a1222 = new GridColumn();
		a1231 = new GridColumn();
		a1232 = new GridColumn();
		a1195 = new GroupBox();
		a1177.SuspendLayout();
		a1225.SuspendLayout();
		a1228.SuspendLayout();
		((ISupportInitialize)a1189).BeginInit();
		((ISupportInitialize)a1190).BeginInit();
		a1195.SuspendLayout();
		SuspendLayout();
		a1177.Controls.Add(a1223);
		a1177.Controls.Add(a1224);
		a1177.Controls.Add(a1214);
		a1177.Controls.Add(a1215);
		a1177.Controls.Add(a1216);
		a1177.Controls.Add(a1217);
		a1177.Controls.Add(a1218);
		a1177.Controls.Add(a1191);
		a1177.Controls.Add(a1185);
		a1177.Controls.Add(a1192);
		a1177.Controls.Add(a1186);
		a1177.Controls.Add(a1178);
		a1177.Controls.Add(a1187);
		a1177.Controls.Add(a1219);
		a1177.Controls.Add(a1220);
		a1177.Controls.Add(a1210);
		a1177.Controls.Add(a1193);
		a1177.Controls.Add(a1194);
		a1177.Controls.Add(a1188);
		a1177.Controls.Add(a1179);
		a1177.Controls.Add(a1180);
		a1177.Controls.Add(a1181);
		a1177.Controls.Add(a1182);
		a1177.Controls.Add(a1183);
		a1177.Controls.Add(a1208);
		a1177.Controls.Add(a1209);
		a1177.Controls.Add(a1184);
		a1177.Dock = DockStyle.Left;
		a1177.Location = new Point(0, 0);
		a1177.Name = a1265("nźɨͳѵՆ٬ݺ࠲");
		a1177.Size = new Size(328, 570);
		a1177.TabIndex = 4;
		a1177.TabStop = false;
		a1177.Text = a1265("Mţɥ\u0361ѳմ٠ݨࡦ९\u0a64");
		a1223.BorderStyle = BorderStyle.FixedSingle;
		a1223.CheckOnClick = true;
		a1223.Font = new Font(a1265("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1223.FormattingEnabled = true;
		a1223.Location = new Point(414, 129);
		a1223.Name = a1265("rŸɃ\u0367Ѿոـݫࡻॼ\u0a40୴\u0c70൦\u0e76ཋ၅");
		a1223.Size = new Size(98, 66);
		a1223.TabIndex = 91;
		a1224.BorderStyle = BorderStyle.FixedSingle;
		a1224.CheckOnClick = true;
		a1224.ContextMenuStrip = a1225;
		a1224.Font = new Font(a1265("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1224.FormattingEnabled = true;
		a1224.Location = new Point(89, 88);
		a1224.Name = a1265("lŦɁ\u0365Ѹվقݩࡵॲ\u0a42୶\u0c76ൠ\u0e74");
		a1224.Size = new Size(232, 146);
		a1224.TabIndex = 90;
		a1225.Items.AddRange(new ToolStripItem[2] { a1226, a1227 });
		a1225.Name = a1265("rſɡͺѨմٿ\u0747\u086c०ੲ\u0b55\u0c71൶\u0e6a\u0f72\u1030");
		a1225.Size = new Size(148, 48);
		a1226.Name = a1265("{ŷɅͿѠբ\u065eݸࡹ\u0963\u0a79\u0b45\u0c62൨\u0e70ཌྷၷᅧቬ");
		a1226.Size = new Size(147, 22);
		a1226.Text = a1265("CůɹͻѮը٬ܤࡐ१૦");
		a1226.Click += a1254;
		a1227.Name = a1265("vŸɬ\u0368ѳշٱݜࡷॹ\u0a70ਢౠ\u0d45\u0e7fའ\u1062ᅞቸ፹ᑣᕹᙅᝢᡨᥰᩍ᭷ᱧᵬ");
		a1227.Size = new Size(147, 22);
		a1227.Text = a1265("FŨɼ\u0378ѣէ١ܧࡍ।੨୧ള൳");
		a1227.Click += a1257;
		a1214.AutoSize = true;
		a1214.Checked = true;
		a1214.CheckState = CheckState.Checked;
		a1214.Font = new Font(a1265("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1214.Location = new Point(89, 351);
		a1214.Name = a1265("nŤɢ\u0361Ѡզ٤ݯࡂॡ\u0a60୫\u0c72");
		a1214.Size = new Size(90, 17);
		a1214.TabIndex = 69;
		a1214.Text = a1265("Ŀťɤ\u0362Ѩգةݏࡢৡ੬ਜ਼౯൧\u0e73");
		a1214.UseVisualStyleBackColor = true;
		a1215.AutoSize = true;
		a1215.Checked = true;
		a1215.CheckState = CheckState.Checked;
		a1215.Font = new Font(a1265("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1215.Location = new Point(89, 367);
		a1215.Name = a1265("išɡ\u036bѭՂ١ݠ\u086bॲ");
		a1215.Size = new Size(77, 17);
		a1215.TabIndex = 69;
		a1215.Text = a1265("ļŧɡ\u0329яբ\u06e1ݬज़९੧୳");
		a1215.UseVisualStyleBackColor = true;
		a1216.AutoSize = true;
		a1216.Checked = true;
		a1216.CheckState = CheckState.Checked;
		a1216.Font = new Font(a1265("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1216.Location = new Point(89, 335);
		a1216.Name = a1265("oţɍͼѦՓ٧ݫ\u086d८੮୨");
		a1216.Size = new Size(114, 17);
		a1216.TabIndex = 69;
		a1216.Text = a1265("@Ųɠ\u0378Ѹԯ\u064cݬࡶ१\u0b3b\u0b29\u0c4f\u0d62\u0ee1ཬᅛᅯቧ፳");
		a1216.UseVisualStyleBackColor = true;
		a1217.FormattingEnabled = true;
		a1217.Location = new Point(414, 201);
		a1217.Name = a1265("sŧɂ\u0364ѿտ\u065eݬࡺ४੯୫\u0c65൯\u0e4bཅ");
		a1217.Size = new Size(98, 52);
		a1217.TabIndex = 89;
		a1218.BorderStyle = BorderStyle.FixedSingle;
		a1218.CheckOnClick = true;
		a1218.ContextMenuStrip = a1228;
		a1218.Font = new Font(a1265("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1218.FormattingEnabled = true;
		a1218.Location = new Point(89, 235);
		a1218.Name = a1265("rŸɃ\u0367Ѿո\u065fݯࡻ॥੮୨\u0c64൨โས\u1068");
		a1218.Size = new Size(232, 98);
		a1218.TabIndex = 89;
		a1228.Items.AddRange(new ToolStripItem[2] { a1229, a1230 });
		a1228.Name = a1265("rſɡͺѨմٿ\u0747\u086c०ੲ\u0b55\u0c71൶\u0e6a\u0f72\u1030");
		a1228.Size = new Size(148, 48);
		a1229.Name = a1265("fžɿ\u0363ѝչپݢࡺ\u0944੭୩\u0c73\u0d4c\u0e70སၯᄰ");
		a1229.Size = new Size(147, 22);
		a1229.Text = a1265("CůɹͻѮը٬ܤࡐ१૦");
		a1229.Click += a1260;
		a1230.Name = a1265("fžɿ\u0363ѝչپݢࡺ\u0944੭୩\u0c73\u0d4c\u0e70སၯᄳ");
		a1230.Size = new Size(147, 22);
		a1230.Text = a1265("FŨɼ\u0378ѣէ١ܧࡍ।੨୧ള൳");
		a1230.Click += a1263;
		a1191.CustomFormat = a1265("vŵȰ\u0342уՀفܫࡳ॰\u0a71\u0b7eద\u0d4d\u0e4c\u0f39ၯᅬ");
		a1191.Font = new Font(a1265("RŤɬ\u036cѯՠ"), 10f);
		a1191.Format = DateTimePickerFormat.Custom;
		a1191.Location = new Point(89, 63);
		a1191.Name = a1265("lųɄ\u036cѰ\u0557٣ݳ");
		a1191.Size = new Size(232, 24);
		a1191.TabIndex = 68;
		a1185.BackColor = Color.FromArgb(128, 255, 128);
		a1185.BorderStyle = BorderStyle.Fixed3D;
		a1185.FlatStyle = FlatStyle.Flat;
		a1185.ForeColor = Color.DarkOrange;
		a1185.Location = new Point(5, 386);
		a1185.Name = a1265("kŧɧ\u0361ѯԳز");
		a1185.Size = new Size(317, 3);
		a1185.TabIndex = 55;
		a1192.CustomFormat = a1265("vŵȰ\u0342уՀفܫࡳ॰\u0a71\u0b7eద\u0d4d\u0e4c\u0f39ၯᅬ");
		a1192.Font = new Font(a1265("RŤɬ\u036cѯՠ"), 10f);
		a1192.Format = DateTimePickerFormat.Custom;
		a1192.ImeMode = ImeMode.NoControl;
		a1192.Location = new Point(89, 38);
		a1192.Name = a1265("lųɄ\u0364ѷ\u0557٣ݳ");
		a1192.Size = new Size(232, 24);
		a1192.TabIndex = 68;
		a1186.DropDownStyle = ComboBoxStyle.DropDownList;
		a1186.Font = new Font(a1265("RŤɬ\u036cѯՠ"), 14.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1186.FormattingEnabled = true;
		a1186.Location = new Point(413, 20);
		a1186.Name = a1265("iūɅ\u0362Ѵծ١ݹࡋ\u0945");
		a1186.Size = new Size(42, 31);
		a1186.TabIndex = 67;
		a1178.Font = new Font(a1265("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 10f);
		a1178.Location = new Point(89, 390);
		a1178.MaxLength = 11;
		a1178.Name = a1265("|ſɲ\u0351ѧՍ٭\u0740");
		a1178.Size = new Size(231, 23);
		a1178.TabIndex = 0;
		a1187.DropDownStyle = ComboBoxStyle.DropDownList;
		a1187.Font = new Font(a1265("RŤɬ\u036cѯՠ"), 10f);
		a1187.FormattingEnabled = true;
		a1187.Location = new Point(89, 13);
		a1187.Name = a1265("kťɋ\u0360Ѷը٧ݻ");
		a1187.Size = new Size(232, 24);
		a1187.TabIndex = 65;
		a1187.SelectedIndexChanged += a1251;
		a1219.AutoSize = true;
		a1219.Location = new Point(5, 273);
		a1219.Name = a1265("jŤɦ\u0366ѮԴ");
		a1219.Size = new Size(59, 13);
		a1219.TabIndex = 66;
		a1219.Text = a1265("_ůɻ\u0365Ѯը٤ݨ\u086f१ੳ");
		a1220.AutoSize = true;
		a1220.Location = new Point(5, 348);
		a1220.Name = a1265("jŤɦ\u0366ѮԷ");
		a1220.Size = new Size(63, 13);
		a1220.TabIndex = 66;
		a1220.Text = a1265("Jũˬ\u0363ՖԨ\u0653ݯࡵ२੦୰౨");
		a1210.AutoSize = true;
		a1210.Location = new Point(5, 131);
		a1210.Name = a1265("jŤɦ\u0366ѮԲ");
		a1210.Size = new Size(59, 13);
		a1210.TabIndex = 66;
		a1210.Text = a1265("AŨɺͳЦՂٶݶࡠॴ");
		a1193.AutoSize = true;
		a1193.Location = new Point(5, 68);
		a1193.Name = a1265("jŤɦ\u0366ѮԳ");
		a1193.Size = new Size(55, 13);
		a1193.TabIndex = 66;
		a1193.Text = a1265("NŢɾ\u0360\u0557ԧ\u0652ݤࡶ४੪୨");
		a1194.AutoSize = true;
		a1194.Location = new Point(5, 44);
		a1194.Name = a1265("jŤɦ\u0366Ѯ\u0530");
		a1194.Size = new Size(80, 13);
		a1194.TabIndex = 66;
		a1194.Text = a1265("RŮ\u0351\u0361ѭե٭ظ\u08efध\u0a52\u0b64\u0c76൪\u0e6aཨ");
		a1188.AutoSize = true;
		a1188.Location = new Point(5, 24);
		a1188.Name = a1265("jŤɦ\u0366ѮԵ");
		a1188.Size = new Size(41, 13);
		a1188.TabIndex = 66;
		a1188.Text = a1265("KŠɶ\u0368ѧջ");
		a1179.AutoSize = true;
		a1179.Location = new Point(6, 394);
		a1179.Name = a1265("kŧɧ\u0361ѯԳش");
		a1179.Size = new Size(65, 13);
		a1179.TabIndex = 49;
		a1179.Text = a1265("_ĤɊ\u0328щճ٨ݶࡢॱର");
		a1180.Font = new Font(a1265("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 10f);
		a1180.Location = new Point(89, 438);
		a1180.MaxLength = 100;
		a1180.Name = a1265("~űɼ\u034cѧշ\u0670ݍ\u086d\u0940");
		a1180.Size = new Size(188, 23);
		a1180.TabIndex = 2;
		a1181.Font = new Font(a1265("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 10f);
		a1181.Location = new Point(89, 414);
		a1181.MaxLength = 100;
		a1181.Name = a1265("yŴɿ\u034bѭա\u0654ݩࡼ॥੧୫\u0c40");
		a1181.Size = new Size(231, 23);
		a1181.TabIndex = 1;
		a1182.AutoSize = true;
		a1182.Location = new Point(6, 419);
		a1182.Name = a1265("kŧɧ\u0361ѯԳط");
		a1182.Size = new Size(57, 13);
		a1182.TabIndex = 49;
		a1182.Text = a1265("Kŭ\u0339\u0327ѕժٽݢࡦ࠰");
		a1183.AutoSize = true;
		a1183.Location = new Point(6, 441);
		a1183.Name = a1265("kŧɧ\u0361ѯԳض");
		a1183.Size = new Size(74, 13);
		a1183.TabIndex = 49;
		a1183.Text = a1265("Fŭɹ;ЩՆٲݫࡤॶ\u0a62ୱര");
		a1208.Image = a2268.a2312;
		a1208.ImageAlign = ContentAlignment.MiddleLeft;
		a1208.Location = new Point(165, 508);
		a1208.Name = a1265("jųɨ\u0340Ѽՠ٧ݭ");
		a1208.Size = new Size(157, 40);
		a1208.TabIndex = 3;
		a1208.Text = a1265("Yūɹ\u0367ѵԦلݯࡷ\u0963ੳ");
		a1208.UseVisualStyleBackColor = true;
		a1208.Click += a1242;
		a1209.Image = a2268.a2280;
		a1209.ImageAlign = ContentAlignment.MiddleLeft;
		a1209.Location = new Point(165, 468);
		a1209.Name = a1265("hŽɦ\u0354ѩշ٣ݶ\u086eॠ");
		a1209.Size = new Size(157, 40);
		a1209.TabIndex = 3;
		a1209.Text = a1265("_ŭɻ\u0365ѻԨ\u0654ݩࡷ\u0963੶୮ౠ");
		a1209.UseVisualStyleBackColor = true;
		a1209.Click += a1245;
		a1184.Image = a2268.a2305;
		a1184.ImageAlign = ContentAlignment.MiddleLeft;
		a1184.Location = new Point(277, 437);
		a1184.Name = a1265("dűɪ\u0342Ѱՠ");
		a1184.Size = new Size(44, 25);
		a1184.TabIndex = 3;
		a1184.UseVisualStyleBackColor = true;
		a1184.Click += a1239;
		a1189.Dock = DockStyle.Fill;
		a1189.EmbeddedNavigator.Name = a1265("");
		a1189.Font = new Font(a1265("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1189.Location = new Point(3, 17);
		a1189.LookAndFeel.SkinName = a1265("GżɻͳѯՖ٭ݨ\u086b९");
		a1189.LookAndFeel.UseDefaultLookAndFeel = false;
		a1189.MainView = a1190;
		a1189.Name = a1265("kŹɣ\u036dыը٨ݱࡶ६੮ର");
		a1189.Size = new Size(868, 550);
		a1189.TabIndex = 56;
		a1189.ViewCollection.AddRange(new BaseView[1] { a1190 });
		a1190.BorderStyle = BorderStyles.NoBorder;
		a1190.Columns.AddRange(new GridColumn[19]
		{
			a1196, a1197, a1198, a1199, a1200, a1201, a1202, a1203, a1204, a1213,
			a1205, a1206, a1207, a1211, a1212, a1221, a1222, a1231, a1232
		});
		a1190.FocusRectStyle = DrawFocusRectStyle.RowFocus;
		a1190.GridControl = a1189;
		a1190.Name = a1265("nźɮ\u0362ѓխ٦ݵ࠰");
		a1190.OptionsBehavior.Editable = false;
		a1190.OptionsFilter.AllowFilterEditor = false;
		a1190.OptionsView.ColumnAutoWidth = false;
		a1190.OptionsView.ShowAutoFilterRow = true;
		a1190.OptionsView.ShowFooter = true;
		a1190.OptionsView.ShowGroupPanel = false;
		a1196.Caption = a1265("KŅ");
		a1196.FieldName = a1265("KŅ");
		a1196.Name = a1265("lŸɠ\u036cфթ٩ݱ\u086e६ਰ");
		a1197.Caption = a1265("LŧɷͰУՌٮ");
		a1197.FieldName = a1265("Bŉɕ\u0352ыՋ\u064b\u0747\u0859");
		a1197.Name = a1265("lŸɠ\u036cфթ٩ݱ\u086e६ਲ਼");
		a1197.SummaryItem.SummaryType = SummaryItemType.Count;
		a1197.Visible = true;
		a1197.VisibleIndex = 1;
		a1198.Caption = a1265("AűɱͷѬ");
		a1198.FieldName = a1265("Aőɑ\u0357ь");
		a1198.Name = a1265("lŸɠ\u036cфթ٩ݱ\u086e६ਲ");
		a1198.Visible = true;
		a1198.VisibleIndex = 7;
		a1198.Width = 72;
		a1199.Caption = a1265("Qťɱ\u036bѩ");
		a1199.DisplayFormat.FormatString = a1265("tūȣ\u0340сԦٳݰࡱॾਦ\u0b4d\u0c4cഹ\u0e6fཬ");
		a1199.DisplayFormat.FormatType = FormatType.DateTime;
		a1199.FieldName = a1265("]ŉɕ\u034fэ\u0557ق\u0743ࡕ");
		a1199.Name = a1265("lŸɠ\u036cфթ٩ݱ\u086e६ਵ");
		a1199.Visible = true;
		a1199.VisibleIndex = 8;
		a1199.Width = 72;
		a1200.Caption = a1265("_ůɻ\u0365Ѯը٤ݨ\u0823\u094b\u0a45");
		a1200.FieldName = a1265("_ŏɛ\u0345юՈل\u0748\u085c\u094b\u0a45");
		a1200.Name = a1265("lŸɠ\u036cфթ٩ݱ\u086e६\u0a37");
		a1201.Caption = a1265("Hťɤ\u0362Ѩաٮܪࡄ७\u0a75୭ౠൾรཋ၅");
		a1201.FieldName = a1265("HŅɄ\u0342шՁ\u064eݕࡄ\u094d\u0a55\u0b4d\u0c40൞\u0e5cཋ၅");
		a1201.Name = a1265("lŸɠ\u036cфթ٩ݱ\u086e६ਸ਼");
		a1202.AppearanceHeader.Options.UseTextOptions = true;
		a1202.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Far;
		a1202.Caption = a1265("HǷ\u0355\u036cѦԧ\u064bݬ\u086fॷ\u0a63୳");
		a1202.FieldName = a1265("HŞə\u034cц\u0558\u064b\u074cࡏ\u0957\u0a43\u0b53");
		a1202.Name = a1265("lŸɠ\u036cфթ٩ݱ\u086e६ਹ");
		a1202.SummaryItem.SummaryType = SummaryItemType.Sum;
		a1202.Visible = true;
		a1202.VisibleIndex = 10;
		a1202.Width = 72;
		a1203.AppearanceHeader.Options.UseTextOptions = true;
		a1203.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Far;
		a1203.Caption = a1265("GŪɦ\u0368Ѧԧلݤ\u086f४\u0a7b\u0b64");
		a1203.FieldName = a1265("GŊɆ\u0348ц\u0558ل\u0744ࡏ\u094aਜ਼\u0b44");
		a1203.Name = a1265("lŸɠ\u036cфթ٩ݱ\u086e६ਸ");
		a1203.Visible = true;
		a1203.VisibleIndex = 11;
		a1203.Width = 72;
		a1204.Caption = a1265("Gůɿ\u036fѪէ٨ܨࡊ\u0963\u0a77୯౦൸\u0e68");
		a1204.FieldName = a1265("Eōə\u0349шՅن\u074bࡀ\u0956\u0a48\u0b47\u0c5b");
		a1204.Name = a1265("kŹɣ\u036dыը٪ݰࡩ७ਲ਼\u0b31");
		a1204.Visible = true;
		a1204.VisibleIndex = 13;
		a1204.Width = 94;
		a1213.Caption = a1265("GŪɸͽШՊ٣ݷ\u086f०\u0a78୨");
		a1213.FieldName = a1265("Aňɚ\u0353ыՀ\u0656\u0748ࡇज़");
		a1213.Name = a1265("lŸɠ\u036cфթ٩ݱ\u086e६\u0a34");
		a1213.Visible = true;
		a1213.VisibleIndex = 12;
		a1213.Width = 68;
		a1205.Caption = a1265("@ūɻͼЧՋ٠ݶࡨ१\u0a7b");
		a1205.FieldName = a1265("Aňɚ\u0353ыՀ\u0656\u0748ࡇज़");
		a1205.Name = a1265("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ର");
		a1206.Caption = a1265("XňȪ\u0342ѡժ٪ݬ\u086fण\u0a4c୮");
		a1206.FieldName = a1265("\\ńɍ\u034cщՏ\u064b\u074a");
		a1206.Name = a1265("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଳ");
		a1206.Visible = true;
		a1206.VisibleIndex = 2;
		a1207.Caption = a1265("IţȦ\u0356ѫպ٣ݥ");
		a1207.FieldName = a1265("Fłɖ\u034bњՃم");
		a1207.Name = a1265("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଲ");
		a1207.Visible = true;
		a1207.VisibleIndex = 3;
		a1211.Caption = a1265("AŨɺͳЦՂٶݶࡠॴ");
		a1211.FieldName = a1265("Cņɔ\u0351уՑ\u0657ݑ");
		a1211.Name = a1265("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଵ");
		a1211.Visible = true;
		a1211.VisibleIndex = 4;
		a1211.Width = 72;
		a1212.AppearanceHeader.Options.UseTextOptions = true;
		a1212.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Far;
		a1212.Caption = a1265("Cŭɺ\u0363ѵ");
		a1212.FieldName = a1265("Cōɚ\u0343ѕ");
		a1212.Name = a1265("kŹɣ\u036dыը٪ݰࡩ७ਲ਼\u0b34");
		a1212.SummaryItem.SummaryType = SummaryItemType.Sum;
		a1212.Visible = true;
		a1212.VisibleIndex = 9;
		a1212.Width = 72;
		a1221.Caption = a1265("XŮɸ\u0364ѡթ٧ݩࠤ\u0942੦ਰ");
		a1221.FieldName = a1265("_ŏɛ\u0345юՈل\u0748ࡂ\u0946\u0a48");
		a1221.Name = a1265("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଷ");
		a1221.Visible = true;
		a1221.VisibleIndex = 14;
		a1221.Width = 86;
		a1222.Caption = a1265("W2ɰ\u0360");
		a1222.FieldName = a1265("WŊɐ\u0340");
		a1222.Name = a1265("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଶ");
		a1222.Visible = true;
		a1222.VisibleIndex = 0;
		a1222.Width = 36;
		a1231.Caption = a1265("DǳɨϿѯ\u05fd");
		a1231.FieldName = a1265("Gŋɏ\u0357ь");
		a1231.Name = a1265("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ହ");
		a1231.Visible = true;
		a1231.VisibleIndex = 5;
		a1231.Width = 67;
		a1232.Caption = a1265("V5ɭȳѧ");
		a1232.FieldName = a1265("Vōɍ\u034bч");
		a1232.Name = a1265("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ସ");
		a1232.OptionsColumn.AllowEdit = false;
		a1232.Visible = true;
		a1232.VisibleIndex = 6;
		a1195.Controls.Add(a1189);
		a1195.Dock = DockStyle.Fill;
		a1195.Location = new Point(328, 0);
		a1195.Name = a1265("nźɨͳѵՆ٬ݺ࠰");
		a1195.Size = new Size(874, 570);
		a1195.TabIndex = 57;
		a1195.TabStop = false;
		a1195.Text = a1265("0ŝɯͽѣչتݚࡧ३ੳ\u0be2౨\u0d62\u0e70ะ");
		Appearance.BackColor = Color.White;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1202, 570);
		Controls.Add(a1195);
		Controls.Add(a1177);
		Name = a1265("VŽɣ\u0346ѹէ٦ݨࡦ८੫\u0b57\u0c65൳\u0e6d\u0f73");
		ShowIcon = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a1265("YŤɼ\u0363ѯգ\u073dݦ\u082aज़੩୷౩൷\u0e68རၰ\u1030");
		WindowState = FormWindowState.Maximized;
		a1177.ResumeLayout(performLayout: false);
		a1177.PerformLayout();
		a1225.ResumeLayout(performLayout: false);
		a1228.ResumeLayout(performLayout: false);
		((ISupportInitialize)a1189).EndInit();
		((ISupportInitialize)a1190).EndInit();
		a1195.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public a1266()
	{
		a1234();
		a1984.a1891(this);
		a1984.a1964(a1265("rťɓ\u035bўՈػݓ\u085dऴ\u0a56\u0b52\u0c5cഴ๕ཀ\u105eᅝሯፗᑘᕇᙇᝏᡄ᥍\u1a58ᭋ᱀ᵖṈ\u1f47⁛"), a1186, a1187);
		a1186.Items.Add(a1265("1"));
		a1187.Items.Add(a1265("MšɳͱѨ"));
		a1192.Text = DateTime.Now.Date.ToString();
		a1191.Text = DateTime.Now.Date.ToString();
		if (a1344.a1287)
		{
			a1186.SelectedIndex = a1186.Items.IndexOf(a1344.a1272.ToString());
			if (a1186.SelectedIndex != -1)
			{
				a1187.SelectedIndex = a1186.SelectedIndex;
			}
			a1187.Enabled = false;
		}
	}

	public void a1235()
	{
		a1186.SelectedIndex = a1187.SelectedIndex;
		if (a1187.Text != a1265("MšɳͱѨ"))
		{
			a1984.a1975(a1265("nŹɷͿѺլ\u0617ݿࡱघ\u0a70\u0b7b౹൱\u0e75\u0f71\u1064ᅼላ፬ᑻᕧᙪᜆᡱᥡ\u1a71\u1b6fᱨᵮṞὒ⁑⅙≉⌺\u244e═♒❄⡐⤴⩊⭇ⱚⵜ⹊⽃えㅓ㉆㍏㑛㕃㙂㝜㡚㥍㩇㬿㰦") + a1186.Text + a1265("&"), a1217, a1218);
		}
		else
		{
			a1984.a1975(a1265("wŦɮ\u0364ѣՋؾݔࡘषਖ਼\u0b50\u0c50ൖ\u0e4cཊၝᅃሲፗᑂᕀᙃᜭᡘ᥎\u1a58\u1b44᱁ᵉṇὉ⁈ⅆ≐⌡"), a1217, a1218);
		}
		for (int i = 0; i < a1218.Items.Count; i++)
		{
			a1218.SetItemChecked(i, value: true);
		}
		a1984.a1975(a1265("fűɿͷѲդ؏ݧࡩ\u0900\u0a60୫౻ർ\u0e78ཡၷᅱታ\u137dᑠᕤᙖ\u173eᡛ᥎ᩔ᭗\u1c39ᵓṖὄ⁁⅋≔⍀⑄╀☯❙⡅⥉⩙⭏Ⱙⵉ⹌⽒がㅂ㈾㌳㐡"), a1223, a1224);
		for (int i = 0; i < a1224.Items.Count; i++)
		{
			a1224.SetItemChecked(i, value: true);
		}
	}

	public void a1236()
	{
		string text = a1265("");
		if (a1216.Checked)
		{
			text += a1265("#ńȥ\u032d");
		}
		if (a1215.Checked)
		{
			text += a1265("#œȥ\u032d");
		}
		if (a1214.Checked)
		{
			text += a1265("#Ŋȥ\u032d");
		}
		for (int i = 0; i < a1224.Items.Count; i++)
		{
			a1223.SetItemCheckState(i, a1224.GetItemCheckState(i));
		}
		string text2 = a1265("");
		for (int i = 0; i < a1223.CheckedItems.Count; i++)
		{
			text2 = text2 + a1223.CheckedItems[i].ToString() + a1265("-");
		}
		for (int i = 0; i < a1218.Items.Count; i++)
		{
			a1217.SetItemCheckState(i, a1218.GetItemCheckState(i));
		}
		string text3 = a1265("");
		for (int i = 0; i < a1217.CheckedItems.Count; i++)
		{
			text3 = text3 + a1217.CheckedItems[i].ToString() + a1265("-");
		}
		a1344.a1307();
		a1344.a1271.CommandText = a1265("\u009eǮ\u02f9Ϸӿ\u05fa\u06ecޗ\u08e4৺\u0ae3௬\u0cfc\u0de4\u0efd\u0fedძᇿኄᎂᒊᗦ\u16fe២ᣴᦅ\u1a8c\u1becᳰ\u1de5ụ\u1fcd₾⇟⋅⎻Ⓨ▨⚶⟃⣗⧇⫝⯛Ⲿⷅ⺡⾡ポ㇌㋍㏟㒣㖩㛛㟎㣔㧄㪨㮣㳖㶰㺮㼶䀺䅑䈨䍊䑔䔲䘹䜥䠢䤻䨻䬻䰷䴩乜伻偟元刨匾吸唼嘥坋堲夤娶嬪尪崲帡弞怊慠戈捪摴攍昙朅栟椝橿歴汲浶湻漛灿煣爟猊琋甝癤眓硷祫稐笆簐紌縉罱聿腱艣荲葾蔕虬蜆蠘襬詡譸豾赴蹽轪遱酠鉩鍹鑡镬陲靸顯饡騈鬃鱶鴐鸎齛ꁋꅎꉙꍕꑅꕔꙑꝜꡂ\ua954ꩆꬿ걆괠긾꽄끏녁뉍덅둕땋뙉띌롏륜멁묯밢뵕빅뾭삳솴슲쎺쒶언욼잾죋즡쫆쯝첱춸캸쾮킴톲튥펻퓆헉횣\ud7a6\ud8b4\ud9b1\udaa3\udbb1\udcb7\uddb1\udedd\udff7\ue08d\ue198\ue290\ue39e\ue499\ue58d\ue6f8\ue783\ue899\ue985\ueaf4\uebe2\uecf2\ued9a\uee91\uef9d\uf09a\uf192\uf28b\uf399\uf49f\uf599\uf697\uf786\uf882歷\ufae4ﮅﲐﶎﺍﾟõǼˮϯӥ\u05fe\u06eaߢ\u08e6ক\u0ae3\u0bfb\u0cf7\u0de3\u0ef5\u0f8fყᇩኑ\u13ffᒛᖇᛣ៦ᣴ᧱\u1ae3\u1bf1\u1cf7\u1df1ứΊ₷↱⊼⏝ⓓ◀⛙⟃⢫⦽⫇⯖Ⳟⷔ⻓\u2fdbギ㇙㋃㏛㒪㖸㚨㟁㣏㧜㫅㯗㲢㷇㻒㼰䀳䅝䈷䌺䐨䔭䘧䜰䠤䤠䨤䭓䰥䴹丵伽倫免別匯呗唽噙坉堭夤娶嬷尥崳帵式怗愙扵捷摺攑昙朅栕椔標欒氟洔渂漄瀋焗牱獣琙甌瘄眂砅礑穤笗簍紑繠缎耞腼艸荲萚蕿虪蝸衻褕詭警豹赽蹵轢遫酲鉡鍮鑸镢陭靽順饲马魦鱰鵤鸀齖ꁚꄠꉈꌩꐴꕀꙍꝜꡚ\ua950꩙ꭖ걍굜깕꽝끅녈뉖더둃땍똡뜫렦륎멅뭑뱖뵌빅뾭삵솸슦쏆쓒얪욽잻좳즶쪠쯓첦춾캠쿏탟퇍튭펯풣헉횮ힵ\ud8a9\ud9a8\udac4\udbba\udcb7\uddaa\udeac\udf9a\ue093\ue198\ue283\ue396\ue49f\ue58b\ue693\ue792\ue88c\ue9f5\uea83\ueb9b\uec97\ued83\uee95\uefef\uf087\uf189\uf2f1\uf39f\uf4fb\uf5e7\uf691\uf792\uf88d黎嬨ﮎﲇﶞﺍ\ufffaìǶ\u02f9ϡӥװۼޞ\u089aকૠ\u0b80ಜ\u0de5\u0ef3\u0fe4ყᇠዠᏢᓡᖅ\u16fcបᢈ᧧\u1aeb\u1bef\u1cf7\u1decẌΉ₭↳⋏⏒ⓔ◐⛞➻⢶⧁⪧⮽ⳓⷕ⻃⿀プ㇌㋈㎫㒪㗏㛚㟈㣋㦥㫈㯌㳅㷞㻔㼺䀬䄰䈵䌵䐻䔵䙘䜣䡇䥕䨸䬶䰴䴥乐伥倡儤刢卋吾唬嘺圪堯夫娥嬯尮崤帲彿怊慯扼挔搔敹晰會桧楻樀欖氀洜渙漁瀏焁爓猂琎畴瘜睵硨礌稀筪籢納縅罹聪脝艶荴葳蕷蘘蝼衿襦詽譿豷赣踐轻逝鄍鉣鍥鐂镽阙霉顭饤驶魷鱬鵮鹨齚ꁆꄠꉈꌨꐴꕒꙙꝅꡂ\ua95b\uaa5b\uab5b걗굉긹꼯끙녅뉉덙둏딩똹뜺렷뤥멅뭍뱆봡");
		if (Convert.ToDateTime(a1192.Text).ToString(a1265("MŌȹ\u036fѬ")).ToString() == a1265("5Ĵȹ\u0332б") && Convert.ToDateTime(a1191.Text).ToString(a1265("MŌȹ\u036fѬ")).ToString() == a1265("5Ĵȹ\u0332б"))
		{
			SqlCommand a2269 = a1344.a1271;
			string commandText = a2269.CommandText;
			a2269.CommandText = commandText + a1265("3ņȠ\u033eћՏ\u065f\u0745ࡃप\u0a4b\u0b4d\u0c53\u0d51เཁ၍ᄢሦ") + Convert.ToDateTime(a1192.Text).ToString(a1265("sŰɱ;ЫՈىܮࡦ॥")) + a1265(" ĦɄ\u034aчԢئ") + Convert.ToDateTime(a1191.Text).ToString(a1265("sŰɱ;ЫՈىܮࡦ॥")) + a1265("%ġ");
		}
		else
		{
			SqlCommand a2270 = a1344.a1271;
			string commandText = a2270.CommandText;
			a2270.CommandText = commandText + a1265("8Ńȧ\u033bрՒـݘࡘत\u0a5d\u0b4c\u0c4dൟสཋ၍ᅓቑፀᑁᕍᘢᜦ") + Convert.ToDateTime(a1192.Text).ToString(a1265("iŶɷʹСՆهܤ\u086c\u0963ਦ\u0b4d\u0c4cഹ\u0e6fཬ")) + a1265(" ĦɄ\u034aчԢئ") + Convert.ToDateTime(a1191.Text).ToString(a1265("iŶɷʹСՆهܤ\u086c\u0963ਦ\u0b4d\u0c4cഹ\u0e6fཬ")) + a1265("%ġ");
		}
		if (text2 != a1265(""))
		{
			text2 = text2.Substring(0, text2.Length - 1);
			SqlCommand a2271 = a1344.a1271;
			a2271.CommandText = a2271.CommandText + a1265("6Ŕɚ\u0357вՅءܡࡅ\u094cਫ਼ୟ\u0c4d൛\u0e5dབྷ၏ᅁሤፊᑌᔩ") + text2 + a1265("+ġ");
			if (text3 != a1265(""))
			{
				text3 = text3.Substring(0, text3.Length - 1);
				SqlCommand a2272 = a1344.a1271;
				a2272.CommandText = a2272.CommandText + a1265("7ŗɛ\u0350гՆؠ\u073e\u085b\u094b\u0a5f\u0b41\u0c42\u0d44\u0e48ང\u1058ᅏቁጤᑊᕌᘩ") + text3 + a1265("+ġ");
				if (text != a1265(""))
				{
					text = text.Substring(0, text.Length - 1);
					SqlCommand a2273 = a1344.a1271;
					a2273.CommandText = a2273.CommandText + a1265("1őɁ\u034aЭ\u0558غܤࡍढ़\u0a55\u0b53\u0c48ത\u0e4aཌဩ") + text + a1265("+ġ");
					if (a1187.Text != a1265("MšɳͱѨ"))
					{
						a1186.SelectedIndex = a1187.SelectedIndex;
						SqlCommand a2274 = a1344.a1271;
						a2274.CommandText = a2274.CommandText + a1265(";śɗ\u035cзՂا\u073aࡊ\u0947ਗ਼ଡ଼\u0c4a\u0d43\u0e48ན၆ᅏቛፃᑂᕜᙚᝍᡇ\u193fᨦ") + a1186.Text + a1265("%ġ");
					}
					if (a1180.Text != a1265(""))
					{
						SqlCommand a2275 = a1344.a1271;
						a2275.CommandText = a2275.CommandText + a1265("9řə\u0352еՀآ\u073c\u085a\u0951\u0a5d\u0b5a\u0c43\u0d43ใཏၑᄨቋፏᑎᕁᘣᜥᠤ") + a1180.Text + a1265("&ĥȡ");
					}
					if (a1178.Text != a1265(""))
					{
						SqlCommand a2276 = a1344.a1271;
						a2276.CommandText = a2276.CommandText + a1265("8Ŗɘ\u0351дՇء\u073fࡄ\u094c\u0a45\u0b44\u0c41\u0d47ใགဨᅋ\u124fፎᑁᔣᘥᜤ") + a1178.Text + a1265("&ĥȡ");
					}
					if (a1181.Text != a1265(""))
					{
						SqlCommand a2277 = a1344.a1271;
						a2277.CommandText = a2277.CommandText + a1265("7ŗɛ\u0350гՆآ\u073eࡎ\u094aਫ਼\u0b43\u0c52\u0d4b\u0e4d༨။ᅏ\u124eፁᐣᔥᘤ") + a1181.Text + a1265("&ĥȡ");
					}
					a1344.a1271.CommandText += a1265(":ŖɊ\u0353ѓՇشݑࡋऱ\u0a44\u0b3eఠ൙\u0e4dཙ၃ᅁሤፓᐷᔫᙗᝂᡃᥕ");
					DataTable dataSource = a2147.a2105(a1344.a1271);
					a1189.DataSource = dataSource;
					a1190.BestFitColumns();
				}
				else
				{
					a1189.DataSource = null;
				}
			}
			else
			{
				a1189.DataSource = null;
			}
		}
		else
		{
			a1189.DataSource = null;
		}
	}

	private void a1239(object a1237, EventArgs a1238)
	{
		a1180.Text = a1344.a1303();
		a1344.CUSTUMERINFO cUSTUMERINFO = new a1344.CUSTUMERINFO();
		cUSTUMERINFO.KARTNOHEX = a1180.Text;
		cUSTUMERINFO.Getir();
		a1181.Text = cUSTUMERINFO.ADSOYAD;
		a1178.Text = cUSTUMERINFO.TCKIMLIK;
	}

	private void a1242(object a1240, EventArgs a1241)
	{
		a1189.ShowPreview();
	}

	private void a1245(object a1243, EventArgs a1244)
	{
		a1236();
	}

	private void a1248(object a1246, EventArgs a1247)
	{
		Close();
	}

	private void a1251(object a1249, EventArgs a1250)
	{
		a1235();
	}

	private void a1254(object a1252, EventArgs a1253)
	{
		for (int i = 0; i < a1224.Items.Count; i++)
		{
			a1224.SetItemChecked(i, value: true);
		}
	}

	private void a1257(object a1255, EventArgs a1256)
	{
		for (int i = 0; i < a1224.Items.Count; i++)
		{
			a1224.SetItemChecked(i, value: false);
		}
	}

	private void a1260(object a1258, EventArgs a1259)
	{
		for (int i = 0; i < a1218.Items.Count; i++)
		{
			a1218.SetItemChecked(i, value: true);
		}
	}

	private void a1263(object a1261, EventArgs a1262)
	{
		for (int i = 0; i < a1218.Items.Count; i++)
		{
			a1218.SetItemChecked(i, value: false);
		}
	}

	private static string a1265(string a1264)
	{
		int length = a1264.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a1264[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
