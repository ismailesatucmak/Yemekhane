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

public class a2249 : XtraForm
{
	private IContainer a2192 = null;

	public GridView a2193;

	private GridColumn a2194;

	public GridControl a2195;

	public ContextMenuStrip a2196;

	private ToolStripMenuItem a2197;

	public ToolStripMenuItem a2198;

	public GroupBox a2199;

	private PictureBox a2200;

	public Label a2201;

	public Label a2202;

	public Label a2203;

	public Label a2204;

	public Label a2205;

	public Label a2206;

	public TextBox a2207;

	public Button a2208;

	public Panel a2209;

	public Button a2210;

	public TextBox a2211;

	public Label a2212;

	private DateTimePicker a2213;

	private DateTimePicker a2214;

	public Label a2215;

	public Label a2216;

	private GridColumn a2217;

	private GridColumn a2218;

	private GridColumn a2219;

	private GridColumn a2220;

	private GridColumn a2221;

	private ToolStripMenuItem a2222;

	private ToolStripMenuItem a2223;

	protected override void Dispose(bool a2224)
	{
		if (a2224 && a2192 != null)
		{
			a2192.Dispose();
		}
		base.Dispose(a2224);
	}

	private void a2225()
	{
		a2192 = new Container();
		a2193 = new GridView();
		a2194 = new GridColumn();
		a2217 = new GridColumn();
		a2218 = new GridColumn();
		a2219 = new GridColumn();
		a2220 = new GridColumn();
		a2221 = new GridColumn();
		a2195 = new GridControl();
		a2196 = new ContextMenuStrip(a2192);
		a2197 = new ToolStripMenuItem();
		a2198 = new ToolStripMenuItem();
		a2222 = new ToolStripMenuItem();
		a2223 = new ToolStripMenuItem();
		a2199 = new GroupBox();
		a2213 = new DateTimePicker();
		a2210 = new Button();
		a2214 = new DateTimePicker();
		a2215 = new Label();
		a2216 = new Label();
		a2211 = new TextBox();
		a2200 = new PictureBox();
		a2201 = new Label();
		a2202 = new Label();
		a2203 = new Label();
		a2204 = new Label();
		a2205 = new Label();
		a2212 = new Label();
		a2206 = new Label();
		a2207 = new TextBox();
		a2208 = new Button();
		a2209 = new Panel();
		((ISupportInitialize)a2193).BeginInit();
		((ISupportInitialize)a2195).BeginInit();
		a2196.SuspendLayout();
		a2199.SuspendLayout();
		((ISupportInitialize)a2200).BeginInit();
		a2209.SuspendLayout();
		SuspendLayout();
		a2193.BorderStyle = BorderStyles.NoBorder;
		a2193.Columns.AddRange(new GridColumn[6] { a2194, a2217, a2218, a2219, a2220, a2221 });
		a2193.FocusRectStyle = DrawFocusRectStyle.RowFocus;
		a2193.GridControl = a2195;
		a2193.Name = a2248("nźɮ\u0362ѓխ٦ݵ࠰");
		a2193.OptionsBehavior.Editable = false;
		a2193.OptionsCustomization.AllowFilter = false;
		a2193.OptionsCustomization.AllowGroup = false;
		a2193.OptionsCustomization.AllowSort = false;
		a2193.OptionsFilter.AllowFilterEditor = false;
		a2193.OptionsView.ColumnAutoWidth = false;
		a2193.OptionsView.ShowGroupPanel = false;
		a2194.Caption = a2248("KŅ");
		a2194.Name = a2248("lŸɠ\u036cфթ٩ݱ\u086e६ਰ");
		a2217.Caption = a2248("@ũɸ\u036bѣԨمݧग़२ଲਝര");
		a2217.FieldName = a2248("@ŉɘ\u0359шՏقݎࡀ\u0945\u0a47\u0b47\u0c53");
		a2217.Name = a2248("lŸɠ\u036cфթ٩ݱ\u086e६ਲ਼");
		a2217.Visible = true;
		a2217.VisibleIndex = 0;
		a2217.Width = 201;
		a2218.Caption = a2248("Hšɰ\u0363ѫ");
		a2218.FieldName = a2248("JŃɖ\u0357тՅل");
		a2218.Name = a2248("lŸɠ\u036cфթ٩ݱ\u086e६ਲ");
		a2218.Visible = true;
		a2218.VisibleIndex = 1;
		a2218.Width = 479;
		a2219.Caption = a2248("RŮ\u0351\u0361ѭե٭ظ\u08efध\u0a52\u0b64\u0c76൪\u0e6aཨ");
		a2219.FieldName = a2248("ZŜɆ\u0354ёՀقݖࡄ");
		a2219.Name = a2248("lŸɠ\u036cфթ٩ݱ\u086e६ਵ");
		a2219.Visible = true;
		a2219.VisibleIndex = 2;
		a2219.Width = 103;
		a2220.Caption = a2248("NŢɾ\u0360\u0557ԧ\u0652ݤࡶ४੪୨");
		a2220.FieldName = a2248("BňɁ\u0340тՖل");
		a2220.Name = a2248("lŸɠ\u036cфթ٩ݱ\u086e६\u0a34");
		a2220.Visible = true;
		a2220.VisibleIndex = 3;
		a2220.Width = 116;
		a2221.AppearanceCell.Options.UseTextOptions = true;
		a2221.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
		a2221.AppearanceHeader.Options.UseTextOptions = true;
		a2221.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
		a2221.Caption = a2248("Důɷ\u036bѧ");
		a2221.FieldName = a2248("Dŏɗ\u034bч");
		a2221.Name = a2248("lŸɠ\u036cфթ٩ݱ\u086e६\u0a37");
		a2221.Visible = true;
		a2221.VisibleIndex = 4;
		a2221.Width = 56;
		a2195.ContextMenuStrip = a2196;
		a2195.EmbeddedNavigator.Name = a2248("");
		a2195.Font = new Font(a2248("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a2195.Location = new Point(6, 274);
		a2195.LookAndFeel.SkinName = a2248("GżɻͳѯՖ٭ݨ\u086b९");
		a2195.LookAndFeel.UseDefaultLookAndFeel = false;
		a2195.MainView = a2193;
		a2195.Name = a2248("kŹɣ\u036dыը٨ݱࡶ६੮ର");
		a2195.Size = new Size(994, 230);
		a2195.TabIndex = 3;
		a2195.ViewCollection.AddRange(new BaseView[1] { a2193 });
		a2196.Items.AddRange(new ToolStripItem[4] { a2197, a2198, a2222, a2223 });
		a2196.Name = a2248("rſɡͺѨմٿ\u0747\u086c०ੲ\u0b55\u0c71൶\u0e6a\u0f72\u1030");
		a2196.Size = new Size(166, 156);
		a2197.Enabled = false;
		a2197.Image = a2268.a2289;
		a2197.ImageScaling = ToolStripItemImageScaling.None;
		a2197.Name = a2248("~Ǥɹ\u0375Ѱոٿݷࡅॿ\u0a60\u0b62\u0c5e൸\u0e79ལၹᅅቢ፨ᑰᕍᙷᝧᡬ");
		a2197.Size = new Size(165, 38);
		a2197.Text = a2248("Oǻɨ\u0366ѡկٮݤ");
		a2198.Image = a2268.a2341;
		a2198.ImageScaling = ToolStripItemImageScaling.None;
		a2198.Name = a2248("gźɾ\u0345ѿՠ٢ݞࡸॹ\u0a63\u0b79\u0c45\u0d62\u0e68\u0f70၍ᅷቧ፬");
		a2198.Size = new Size(165, 38);
		a2198.Text = a2248("Pūɭ");
		a2198.Click += a2237;
		a2222.Image = a2268.a2330;
		a2222.ImageScaling = ToolStripItemImageScaling.None;
		a2222.Name = a2248("sŸɯͺѰШ\u0659ݼࡢॼੲ\u0b56౦\u0d45\u0e7fའ\u1062ᅞቸ፹ᑣᕹᙅᝢᡨᥰᩍ᭷ᱧᵬ");
		a2222.Size = new Size(165, 38);
		a2222.Text = a2248("Būɾ\u036dѡлة\u0749\u086cॲ੬\u0b62ణ\u0d47\u0e75");
		a2222.Click += a2240;
		a2223.Image = a2268.a2342;
		a2223.ImageScaling = ToolStripItemImageScaling.None;
		a2223.Name = a2248("sŸɯͺѰШوݶࡥॼੲ\u0b56౦\u0d45\u0e7fའ\u1062ᅞቸ፹ᑣᕹᙅᝢᡨᥰᩍ᭷ᱧᵬ");
		a2223.Size = new Size(165, 38);
		a2223.Text = a2248("Būɾ\u036dѡлةݘࡦॵ੬\u0b62ణ\u0d47\u0e75");
		a2223.Click += a2243;
		a2199.Controls.Add(a2213);
		a2199.Controls.Add(a2210);
		a2199.Controls.Add(a2214);
		a2199.Controls.Add(a2215);
		a2199.Controls.Add(a2216);
		a2199.Controls.Add(a2211);
		a2199.Controls.Add(a2200);
		a2199.Controls.Add(a2195);
		a2199.Controls.Add(a2201);
		a2199.Controls.Add(a2202);
		a2199.Controls.Add(a2203);
		a2199.Controls.Add(a2204);
		a2199.Controls.Add(a2205);
		a2199.Controls.Add(a2212);
		a2199.Controls.Add(a2206);
		a2199.Controls.Add(a2207);
		a2199.Dock = DockStyle.Fill;
		a2199.Location = new Point(0, 0);
		a2199.Name = a2248("nźɨͳѵՆ٬ݺ࠰");
		a2199.Size = new Size(1018, 535);
		a2199.TabIndex = 0;
		a2199.TabStop = false;
		a2213.Font = new Font(a2248("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a2213.Location = new Point(116, 211);
		a2213.Name = a2248("lųɄ\u036cѰ\u0557٣ݳ");
		a2213.Size = new Size(276, 26);
		a2213.TabIndex = 3;
		a2210.BackColor = Color.FromArgb(255, 128, 0);
		a2210.FlatStyle = FlatStyle.Flat;
		a2210.Font = new Font(a2248("RŤɬ\u036cѯՠ"), 10f);
		a2210.ForeColor = Color.White;
		a2210.Location = new Point(394, 183);
		a2210.Name = a2248("kżɩ\u034dѤս٧ݧࡵ");
		a2210.Size = new Size(216, 55);
		a2210.TabIndex = 0;
		a2210.Text = a2248("Fůɺ\u0369ѭзإ\u0741ࡨ८\u0a64");
		a2210.UseVisualStyleBackColor = false;
		a2210.Click += a2234;
		a2214.Font = new Font(a2248("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a2214.ImeMode = ImeMode.NoControl;
		a2214.Location = new Point(116, 184);
		a2214.Name = a2248("lųɄ\u0364ѷ\u0557٣ݳ");
		a2214.Size = new Size(276, 26);
		a2214.TabIndex = 2;
		a2215.AutoSize = true;
		a2215.ForeColor = Color.Gray;
		a2215.Location = new Point(17, 219);
		a2215.Name = a2248("jŤɦ\u0366ѮԸ");
		a2215.Size = new Size(55, 13);
		a2215.TabIndex = 69;
		a2215.Text = a2248("NŢɾ\u0360\u0557ԧ\u0652ݤࡶ४੪୨");
		a2216.AutoSize = true;
		a2216.ForeColor = Color.Gray;
		a2216.Location = new Point(17, 191);
		a2216.Name = a2248("kŧɧ\u0361ѯԳر");
		a2216.Size = new Size(90, 13);
		a2216.TabIndex = 70;
		a2216.Text = a2248("Hűɶȿѣՠ٪ݤࡤ३ਧ\u0b52\u0c64൶\u0e6aཪ\u1068");
		a2211.Font = new Font(a2248("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a2211.Location = new Point(116, 72);
		a2211.Multiline = true;
		a2211.Name = a2248("|ſɲ\u0348ѡհ٣ݫ");
		a2211.Size = new Size(494, 110);
		a2211.TabIndex = 1;
		a2200.Image = a2268.a2306;
		a2200.Location = new Point(864, 12);
		a2200.Name = a2248("{ţɪͼѲմ٠\u0746\u086cॺਰ");
		a2200.Size = new Size(136, 130);
		a2200.TabIndex = 63;
		a2200.TabStop = false;
		a2201.AutoSize = true;
		a2201.Location = new Point(3, 513);
		a2201.Name = a2248("jŤɦ\u0366ѮԳ");
		a2201.Size = new Size(568, 13);
		a2201.TabIndex = 60;
		a2201.Text = a2248("0ęȈ\u031bГԔ\u0616܄\u0859\u0954ਸଇఝജฎༀᅜᄏፚጆᐈᔚᙇ᜶᠗ᤋᨄᬐᰀᴍḳἿ\u202f\u206d≻⌛Ⓘ┬❦✽⠹⤵⨡⩣ⱱⴊ⸮⼣\u302cㄢ㉫㌋㐥㔼㙧㜟㠤㤾㭲㭢㰮㴬㹞㽌䁜䅗䈛䍌䑜䔘䙕䝓䡙䥘䩚䬒䱐䵂乎佂儜兇則卋呛啄噆圆塂姘婍孁屄嵌平彻恳慹扩捿摲攸晒杽桧極橽歾汰浢漾潠灬焬牌獯瑥畭癤督确祰穪筰簯");
		a2202.AutoSize = true;
		a2202.ForeColor = Color.Gray;
		a2202.Location = new Point(17, 29);
		a2202.Name = a2248("jŤɦ\u0366ѮԲ");
		a2202.Size = new Size(507, 13);
		a2202.TabIndex = 59;
		a2202.Text = a2248(">āȟ\u031eАԞݞ܍ड़\u094c\u0a29\u0b03అഏฎ༊ကᄊሇጋᐓᔍᘺ\u177e᠐\u1939ᨨ\u1b3b\u1c33ᱩṹὶ–℻∡⌿␤┾♯✯⠡⤸⭺⬤Ⱝ\u2d29\u2e67⼭\u302cㅤ㈯㌫㐲㔴㙚㝚㡘㥒㨛㭷㱜㵋㹖㽜䁙䅕䉁䈃䐑䕃䙆䝂䡈䥎䩂䭆䱀䵚万佖偄兗削卄吁啖噺圾塼奷婯孳屿崸广彷恹慱戳捵摴敤晦杼桨楮橢武池浺湴潯火煭特猬琡");
		a2203.AutoSize = true;
		a2203.Font = new Font(a2248("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a2203.Location = new Point(7, 254);
		a2203.Name = a2248("jŤɦ\u0366Ѯ\u0530");
		a2203.Size = new Size(124, 13);
		a2203.TabIndex = 55;
		a2203.Text = a2248("SŶ\u02f5ͼѹѐخ\u0740ࡩॸ੫\u0b63న\u0d4b\u0e6f\u0f76ၰᅦቱ፨");
		a2204.BackColor = Color.FromArgb(128, 255, 128);
		a2204.BorderStyle = BorderStyle.Fixed3D;
		a2204.FlatStyle = FlatStyle.Flat;
		a2204.ForeColor = Color.DarkOrange;
		a2204.Location = new Point(7, 245);
		a2204.Name = a2248("kŧɧ\u0361ѯԳز");
		a2204.Size = new Size(985, 3);
		a2204.TabIndex = 54;
		a2205.AutoSize = true;
		a2205.Font = new Font(a2248("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a2205.ForeColor = Color.Gray;
		a2205.Location = new Point(7, 12);
		a2205.Name = a2248("jŤɦ\u0366ѮԹ");
		a2205.Size = new Size(76, 13);
		a2205.TabIndex = 51;
		a2205.Text = a2248("@ũɸ\u036bѣԨمݯࡩ\u0963੪ୱ౨");
		a2212.AutoSize = true;
		a2212.ForeColor = Color.Gray;
		a2212.Location = new Point(17, 141);
		a2212.Name = a2248("jŤɦ\u0366ѮԵ");
		a2212.Size = new Size(35, 13);
		a2212.TabIndex = 49;
		a2212.Text = a2248("Hšɰ\u0363ѫ");
		a2206.AutoSize = true;
		a2206.ForeColor = Color.Gray;
		a2206.Location = new Point(17, 54);
		a2206.Name = a2248("jŤɦ\u0366ѮԷ");
		a2206.Size = new Size(67, 13);
		a2206.TabIndex = 49;
		a2206.Text = a2248("@ũɸ\u036bѣԨمݧग़२ଲਝര");
		a2207.Font = new Font(a2248("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a2207.Location = new Point(116, 47);
		a2207.Name = a2248("{Ŷɹ\u0341Ѯչ٨ݢࡅ१੶୨౪\u0d65\u0e68");
		a2207.Size = new Size(494, 24);
		a2207.TabIndex = 0;
		a2208.Dock = DockStyle.Fill;
		a2208.Location = new Point(0, 0);
		a2208.Name = a2248("jųɨ\u0346ѭը٫ݲ");
		a2208.Size = new Size(1018, 37);
		a2208.TabIndex = 1;
		a2208.Text = a2248("Â5ɨȳ՞");
		a2208.UseVisualStyleBackColor = true;
		a2208.Click += a2246;
		a2209.BackColor = Color.FromArgb(233, 235, 236);
		a2209.Controls.Add(a2208);
		a2209.Dock = DockStyle.Bottom;
		a2209.Location = new Point(0, 535);
		a2209.Name = a2248("vŤɪ\u0366Ѯ\u0530");
		a2209.Size = new Size(1018, 37);
		a2209.TabIndex = 63;
		Appearance.BackColor = Color.White;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1018, 572);
		Controls.Add(a2199);
		Controls.Add(a2209);
		MaximizeBox = false;
		Name = a2248("Hſɡ\u0346ѯպ٩ݭࡃ८੨୦౯\u0d64");
		ShowIcon = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a2248("_Ŵɣ\u036eѤԭىݠࡦ६\u0a65\u0b62ద\u0d43\u0e6b\u0f71ၯᅴ");
		((ISupportInitialize)a2193).EndInit();
		((ISupportInitialize)a2195).EndInit();
		a2196.ResumeLayout(performLayout: false);
		a2199.ResumeLayout(performLayout: false);
		a2199.PerformLayout();
		((ISupportInitialize)a2200).EndInit();
		a2209.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public a2249()
	{
		a2225();
		a1984.a1891(this);
		a2226();
	}

	public void a2226()
	{
		int focusedRowHandle = a2193.FocusedRowHandle;
		a1344.a1271.CommandText = a2248("²ǂ\u02d5σӋ\u05ce\u06d8\u07abࣃ\u09cdત\u0bca\u0cc3\u0dd6໗࿂Ⴥᇄወጺᐿᔹᘹᜩᡖ\u1934ᨽᬤ\u1c25ᴴḳἶ⁞™∤⌮\u243c┹☨✪⠾⤬⩄⬢Ⱘⴡ⸠⼢〶ㄤ㉌㌞㐕㔉㘕㜝㡧㤚㨗㬙㰀㴐㸆㼇䁺䄓䈙䌛䑢䕥䘏䜊䠙䤌䩨䬐䰎䴀上佣倃儊刔卶呸唀嘛坾堝夙婬孿屳嵻帔异怒慴扼捼摫攍昜朋桯楧橬欎氏洅湢潱灭煬爀獋瑜畑癑睞硉祊穙筐籓絝繕罁耲腞艂荋葋蕟蘬蝉術褩詁譃谦赁蹁轐遁鄡");
		DataTable dataSource = a2147.a2105(a1344.a1271);
		a2195.DataSource = dataSource;
		a2193.FocusedRowHandle = focusedRowHandle;
		a2193.BestFitColumns();
	}

	public void a2227()
	{
		a2211.Text = a2248("");
		a2207.Text = a2248("");
	}

	public void a2228()
	{
		a1344.a1307();
		a1344.a1271.CommandText = a2248("¦ǌˊϐӇד۔ݟ࠷ळਨ\u0b34ౚഭ\u0e3a༻\u103bᄰሧጠᐳᔶᘵᜧᠯ\u193fᩌ\u1b43\u1c27ᴬḻἴ‧™∡⌫␧┠☤✚⠌⥱⨑⬞Ⰹⴊ⸙⼐〓ㅹ㈇㌇㐓㔃㘄㜋㠏㤙㨉㭧㰏㴇㸌㼃䀇䄑䈁䍯䐃䔊䘔䝶䡸䤔䨜䭭䱻䵵乭佲健儝剴卾呷啢噣坮塩奨婤孮屫嵭幭彵怊慥扩捦摱敲晡杘桛椱橜歈汎浘湊潃灒煔牀獖琾畑癕睁硊祉積筟籏紥繈罆聍腑艍荅萫蔡");
		a1344.a1271.Parameters.Add(a2248("@ŉɘ\u0359шՏقݎࡀ\u0945\u0a47\u0b47\u0c53"), SqlDbType.NVarChar).Value = a2207.Text;
		a1344.a1271.Parameters.Add(a2248("JŃɖ\u0357тՅل"), SqlDbType.NVarChar).Value = a2211.Text;
		a1344.a1271.Parameters.Add(a2248("ZŜɆ\u0354ёՀقݖࡄ"), SqlDbType.DateTime).Value = Convert.ToDateTime(a2214.Text).ToString(a2248("sŰɱ;ЫՈىܮࡦ॥"));
		a1344.a1271.Parameters.Add(a2248("BňɁ\u0340тՖل"), SqlDbType.DateTime).Value = Convert.ToDateTime(a2213.Text).ToString(a2248("sŰɱ;ЫՈىܮࡦ॥"));
		a1344.a1271.Parameters.Add(a2248("Dŏɗ\u034bч"), SqlDbType.NVarChar).Value = a2248("D");
		a1344.a1271.ExecuteNonQuery();
		a2227();
		a2226();
	}

	public void a2229()
	{
		if (a2193.RowCount > 0)
		{
			int num = Convert.ToInt32(a2193.GetFocusedRowCellValue(a2248("KŅ")).ToString());
			if (MessageBox.Show(a2248("jŃɖ\u0345щГ\u0601ݳࡶॲ\u0a70\u0b79\u0c70ഺ༩ཫ\u1063ᅳቱ\u137dᔌᕻᙿ\u1779ᡵᥫᨭᭉᱦᵣṧὥ\u206eⅵ≬⍪⑪╸☯"), a2248("PŽɢͰ\u0530"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.Cancel)
			{
				a1344.a1307();
				a1344.a1271.CommandText = a2248("\bţɣ\u0369ѡշ٧܁ࡦ\u094d\u0a51\u0b50\u0c3c൏๘ཕၕᅒቅፆᑕᕔᙗ\u1759ᡑᥝᨮ᭚᱄ᵎṘὌ\u2028ⅎ≂⌸⑄╊♆✡");
				a1344.a1271.Parameters.Add(a2248("KŅ"), SqlDbType.Int).Value = num;
				a1344.a1271.ExecuteNonQuery();
				a2227();
				a2226();
			}
		}
	}

	public void a2231(string a2230)
	{
		if (a2193.RowCount > 0)
		{
			int num = Convert.ToInt32(a2193.GetFocusedRowCellValue(a2248("KŅ")).ToString());
			a1344.a1307();
			a1344.a1271.CommandText = a2248("\u0014Ŧɢ\u0375ѱջ٫܍ࡸ३੦\u0b64౭൴\u0e75ཤ\u1063ᅦቪ፠ᑲᔿᙍ\u1758ᡈ\u193b\u1a5b᭒\u1c4cᵞṐἨ\u2054⅒≙⍅\u2459╉☮❚⡄⥎⩘⭌Ⱘⵎ⹂⼸いㅊ㉆㌡");
			a1344.a1271.Parameters.Add(a2248("KŅ"), SqlDbType.Int).Value = num;
			if (a2230 == a2248("Důɷ\u036bѧ"))
			{
				a1344.a1271.Parameters.Add(a2248("Dŏɗ\u034bч"), SqlDbType.NVarChar).Value = a2248("D");
			}
			else
			{
				a1344.a1271.Parameters.Add(a2248("Dŏɗ\u034bч"), SqlDbType.NVarChar).Value = a2248("I");
			}
			a1344.a1271.ExecuteNonQuery();
			a2227();
			a2226();
		}
	}

	private void a2234(object a2232, EventArgs a2233)
	{
		a2228();
	}

	private void a2237(object a2235, EventArgs a2236)
	{
		a2229();
	}

	private void a2240(object a2238, EventArgs a2239)
	{
		a2231(a2248("Důɷ\u036bѧ"));
	}

	private void a2243(object a2241, EventArgs a2242)
	{
		a2231(a2248("Uťɰ\u036bѧ"));
	}

	private void a2246(object a2244, EventArgs a2245)
	{
		Close();
	}

	private static string a2248(string a2247)
	{
		int length = a2247.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a2247[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
