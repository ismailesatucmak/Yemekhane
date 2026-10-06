using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using a7.a2096;

namespace a7;

public class a764 : XtraForm
{
	private IContainer a687 = null;

	private GroupBox a688;

	private DateTimePicker a689;

	public Label a690;

	private DateTimePicker a691;

	public System.Windows.Forms.ComboBox a692;

	public TextBox a693;

	public System.Windows.Forms.ComboBox a694;

	public Label a695;

	public Label a696;

	public Label a697;

	public Label a698;

	public Label a699;

	public TextBox a700;

	public TextBox a701;

	public Label a702;

	public Label a703;

	public Button a704;

	public Button a705;

	public Button a706;

	private GroupBox a707;

	public GridControl a708;

	public GridView a709;

	public System.Windows.Forms.ComboBox a710;

	public System.Windows.Forms.ComboBox a711;

	public System.Windows.Forms.ComboBox a712;

	public System.Windows.Forms.ComboBox a713;

	public Label a714;

	public Label a715;

	private GridColumn a716;

	private GridColumn a717;

	private GridColumn a718;

	private GridColumn a719;

	private GridColumn a720;

	private GridColumn a721;

	private GridColumn a722;

	private GridColumn a723;

	private GridColumn a724;

	private GridColumn a725;

	private GridColumn a726;

	private GridColumn a727;

	private GridColumn a728;

	private GridColumn a729;

	private GridColumn a730;

	private GridColumn a731;

	private GridColumn a732;

	private CheckedListBox a733;

	private CheckedListBox a734;

	private ContextMenuStrip a735;

	private ToolStripMenuItem a736;

	private ToolStripMenuItem a737;

	private GridColumn a738;

	private GridColumn a739;

	private GridColumn a740;

	public a764()
	{
		a761();
		a1984.a1891(this);
		a1984.a1975(a763("fűɿͷѲդ؏ݧࡩ\u0900\u0a60୫౻ർ\u0e78ཡၷᅱታ\u137dᑠᕤᙖ\u173eᡛ᥎ᩔ᭗\u1c39ᵓṖὄ⁁⅋≔⍀⑄╀☯❙⡅⥉⩙⭏Ⱙⵉ⹌⽒がㅂ㈾㌳㐡"), a733, a734);
		for (int i = 0; i < a734.Items.Count; i++)
		{
			a734.SetItemChecked(i, value: true);
		}
		a1984.a1964(a763("rťɓ\u035bўՈػݓ\u085dऴ\u0a56\u0b52\u0c5cഴ๕ཀ\u105eᅝሯፗᑘᕇᙇᝏᡄ᥍\u1a58ᭋ᱀ᵖṈ\u1f47⁛"), a692, a694);
		a1984.a1964(a763("uŠɨ\u0366ѡյ\u0600ݖ\u085aऱ\u0a53ଡ଼\u0c4f\u0d57\u0e38ད၄ᅚ\u1259ጳᑝᕖᙅᝁᠮᥚᩄ᭎᱘ᵌḨ\u1f46⁍⅑≍⍅\u243f┰"), a711, a713);
		a692.Items.Add(a763("1"));
		a694.Items.Add(a763("MšɳͱѨ"));
		a711.Items.Add(a763("1"));
		a713.Items.Add(a763("MšɳͱѨ"));
		a710.Items.Add(a763("1"));
		a712.Items.Add(a763("Růɧ\u0365Ѣի٬\u065b\u086f१ੳ"));
		a710.Items.Add(a763("0"));
		a712.Items.Add(a763("Pŭɩ\u036bѬћٯݧࡳ"));
		a710.Items.Add(a763("2"));
		a712.Items.Add(a763("ĸŷɲ\u0364Ѩկ٧ݳ"));
		a710.Items.Add(a763("1"));
		a712.Items.Add(a763("MšɳͱѨ"));
		a712.SelectedIndex = 0;
		if (a1344.a1287)
		{
			a692.SelectedIndex = a692.Items.IndexOf(a1344.a1272.ToString());
			if (a692.SelectedIndex != -1)
			{
				a694.SelectedIndex = a692.SelectedIndex;
			}
			a694.Enabled = false;
		}
	}

	public void a741()
	{
		for (int i = 0; i < a734.Items.Count; i++)
		{
			a733.SetItemCheckState(i, a734.GetItemCheckState(i));
		}
		string text = a763("");
		for (int i = 0; i < a733.CheckedItems.Count; i++)
		{
			text = text + a733.CheckedItems[i].ToString() + a763("-");
		}
		a1344.a1307();
		a1344.a1271.CommandText = a763("VĦȱ\u033fзԲؤݏ࠼ढ\u0a3b\u0b34త\u0d3cล༥ဣᄷቌፊᑂᔮᘶ\u171a\u180c\u197d\u1a74ᬔᰈᴝḝἅ⁶℗∍⍳␆╠♾✛⠏⤟⨅⬃Ᵽ\u2d69⸛⼎〔\u3104㉨㌗㑳㕯㘉㝻㠒㥩㨍㬕㱱㵰㹫㽾䁺䅰䉦䍬䑻䕵䘜䜏䡯䥩䩥䬖䰂䵺乭佫偣兦剰匃呣啥噳坐塇奜婘嬻屜嵋幗彚怶慞扝捀摛敝晕杝栮楚橄歎汘浌渨潎灂焸牐猲琬畊癉瞬碷禱窹箩粥綰纼翞胚臕芠莰蒼薾蛍蟇袽覨誠议販趽軈辳邥醮銭鎮钮閨隫響题馏骓鮖鳺鶒麑龄ꂟꆙꊑꎁꓲꖆꚘ\ua78aꢜꦈ\uaaecꮂ겎귴꺜꿶냨놎늍뎐뒋떍뚅럭룡맴뫸뮒벖붙뻺뿸샺쇠싹쎎쒚엢웵쟣죫짮쫸쮋쳨췦커쿲탫톅틢폱퓭헬횀ퟔ\ud8d7\ud9ce\udad5\udbd7\udcdf\uddcb\udeb8\udfc0\ue0de\ue1d0\ue2c6\ue3d6\ue4b2\ue5d8\ue6d4\ue7b2\ue8da\ue9bc\ueaa2\uebc0\uecc3\uedda\ueec1\uefcb\uf0c3\uf1d7\uf2db\uf3ca\uf4c6\uf5a8\uf6ac\uf75f\uf82d老免גּﰼ﵄﹐Ｄ3Ĺȱ\u0330ЦՑأܦ\u0820तਪ\u0b4bబ\u0d3bว༪၆ᄮርጰᐫᔭᘥᜍ\u187eᤊᨔᬞᰈᴜṸ\u1f1e‒Ⅸ∀⍢⑼┚☙✜⠇⤁⨉⬙Ⱅⴀ⸌⽮なㅥ㈐㍲㑬㔊㘁㝭㡪㥳㩳㭳㱿㵡㸔㽣䀇䄛䉠䍲䑠䕸䙸䜃䡺䤜䨂䭠䱫䵻乼你側兰剴卪呦唍嘀坔塟奏婈孜屈嵌幈弪怾慆扑损摗敒晄术桚楂橜欫氻洩湃潆灔煑牛獄瑐畔癐瞠碿禹窵篛粼綫纷羺胖膾芵莡蒦薮蚷螽袻覽諌讼貢趬躺辢郆醬銠鏞钶闐雎鞔颟馏骈鮜鲈鶌麈龞ꂒꇼꋸꏳꒆꗠ\ua6feꞀꢉꦘꪂꮂ겎귥꺇꾀낓놋당돫뒑떄뚌럺룽맩몜믴볽뷬뻶뾗샰쇧싻쏾쒒엾웷쟺죠즍쫻쯣쳯췻컭쾇탯퇡튙폷풓햏훯ퟘ\ud8cb\ud9d3\udad5\udbdf\udcb3\uddb5\udeb8\udfc3\ue0a7\ue1bb\ue2cd\ue3d6\ue4df\ue5d4\ue6db\ue7d0\ue8ca\ue9d8\ueade\uebde\uecc7\ueda5\ueecc\uefd2\uf0d4\uf1d0\uf2c9\uf3be\uf4aa\uf5c2\uf6c1\uf72c\uf83b諾飼דּﰿﴷ﹘ＣGśȭ\u0336пԴػ\u0730\u082aस\u0a3e\u0b3eధൔ๘ཇ\u1032ᄭሡጭᑂᕆᘹ\u171a᠐ᤐ\u1a19ᬖᰓᴊṿί\u2001ℝ∑⌝⑲┅♡❡⠗⤈⨁⬎Ⰱⴖ⸌⼒〔ㄐ㈉㍾㑳㕡㘔㝷㡻㥳㨜㬜㱣㵼㹶㽺䁿䅦䈓䌓䑥䕹䙵䝡䠎䥹䨝䬅䱳䵬乥佢偭兺剠卶呰啴噭圢堭夽婈孓屟嵗常弰恟慅所捒摞收昰杊桀楉樥欧氪浝渹漩灟煐牏獏瑇界癅瞠碳禸窮箤粳綽绔翗肻膰芦莸蒷薫蛍蟇袽覨誠议販趽軈辦邢醬鋄鎥钰閮隭響颇馈骗鮗鲟鶔麝龈ꂛꆐꊆꎘ꒗ꖋ\ua6f0Ꞙꢆꦈꪞꮎ곪궀꺌꿺낒뇴닪뎚뒗떊뚌럺룳맸뫣믶볿뷫뻧뿾샲솜슘쎓쓫열웽쟪죣짨쫾쯠쳯췳컡쾚킎퇶틡폯퓧헢훴ힿ\ud8df\ud9d9\udad5\udbbb\udcdc\uddcb\uded7\udfda\ue0b6\ue1cc\ue2c1\ue3d8\ue4de\ue5d4\ue6dd\ue7ca\ue8d1\ue9c0\ueac9\uebd9\uecc1\uedcc\ueed2\uefa7\uf0d1\uf1cd\uf2c1\uf3d1\uf4c7\uf5a1\uf6c9\uf73b\uf843朗祉ﭕﰣﴼ︵Ｒ;İȦ\u0338зԫعܫࡇ\u0941\u0a4c\u0b3f\u0c5b\u0d47\u0e3d༴ဣᄷሻጪᐦᕍᘵᜌ\u181bᤏᨎ᭦ᱲᴊḝἛ–№∀⍳␓┕☃✀⠗⤌⨈⭫Ⰼⴛ⸇⼊てㄐ㈗㌆㐐㔒㙠㝨㡶㥸㩮㭾㰚㵰㹼㼊䁢䄄䈚䍦䑡䕴䙢䝰䡧䥩䨅䬋䰊䵯乺佨偫儅剣卶呬啾噹坊塕契婙孖屟崹幌弦怶慂扜捖摀敔昰杛桏楟橅歃氪测湍潓灑煀牁獍琢甦") + Convert.ToDateTime(a691.Text).ToString(a763("sŰɱ;ЫՈىܮࡦ॥")) + a763(" ĦɄ\u034aчԢئ") + Convert.ToDateTime(a689.Text).ToString(a763("sŰɱ;ЫՈىܮࡦ॥")) + a763("%ġ");
		if (text != a763(""))
		{
			text = text.Substring(0, text.Length - 1);
			SqlCommand a2269 = a1344.a1271;
			a2269.CommandText = a2269.CommandText + a763("6Ŕɚ\u0357вՅءܡࡅ\u094cਫ਼ୟ\u0c4d൛\u0e5dབྷ၏ᅁሤፊᑌᔩ") + text + a763("+ġ");
			if (a694.Text != a763("MšɳͱѨ"))
			{
				a692.SelectedIndex = a694.SelectedIndex;
				SqlCommand a2270 = a1344.a1271;
				string commandText = a2270.CommandText;
				a2270.CommandText = commandText + a763("=ŝɕ\u035eй\u0530ط\u0736࠽\u0940ਢ\u0b3c\u0c48\u0d45ไག၈ᅁ\u124eፕᑄᕍᙕ\u1759ᡌ᥀ᨿ\u1b3c\u1c26") + a692.Text + a763("0Ķɔ\u035aїԲمܡ\u0821\u0957\u0a48\u0b41\u0c4e\u0d47\u0e4cཚ၌ᅃ\u125fፍᑇᔿᘦ") + a692.Text + a763("<ĳȹ\u0357хԶص\u073cࡇण\u0a3f\u0b49ౚ\u0d45แཉ၆ᅏቖፅᑂᕔᙚᝍᡇ\u193fᨦ") + a692.Text + a763("\u0016Đɮ\u0360ѩԌٿܛࠇॱ\u0a62୫ౠ൩\u0e66\u0f70\u106aᅥቅፗᑙᔡᘫ\u1733ᠹᥗᩅ\u1b36\u1c35ᴼṇἣ\u203fⅉ≚⍅⑁╉♆❏⡖⥅⩂⭔ⱚⵍ⹇⼿〦") + a692.Text + a763("0Ķɔ\u035aїԲمܡ\u0821\u0957\u0a48\u0b41\u0c4e\u0d47\u0e4cཚ၌ᅃ\u125fፍᑇᔿᘦ") + a692.Text + a763("$īȡ");
				a1344.a1271.CommandText += a763("\"Ĩ");
			}
			if (a713.Text != a763("MšɳͱѨ"))
			{
				a711.SelectedIndex = a713.SelectedIndex;
				SqlCommand a2271 = a1344.a1271;
				a2271.CommandText = a2271.CommandText + a763("0Ŏɀ\u0349Ь՟ػܧࡇ\u0940\u0a53\u0b4b\u0c4d\u0d47฿༦") + a711.Text + a763("%ġ");
			}
			if (a712.Text != a763("MšɳͱѨ"))
			{
				a710.SelectedIndex = a712.SelectedIndex;
				SqlCommand a2272 = a1344.a1271;
				a2272.CommandText = a2272.CommandText + a763("5ŕɝ\u0356бՄؾܠࡔ\u0949\u0a46\u0b4f\u0c42\u0d57ใན\u1057ᅑ\u124eጿᐦ") + a710.Text + a763("%ġ");
			}
			if (a700.Text != a763(""))
			{
				SqlCommand a2273 = a1344.a1271;
				a2273.CommandText = a2273.CommandText + a763("6Ŕɚ\u0357в՚\u0651ݝ\u085a\u0943\u0a43\u0b43\u0c4f\u0d51ศཋ၏ᅎቁጣᐥᔤ") + a700.Text + a763("&ĥȡ");
			}
			a1344.a1271.CommandText += a763("3ŝɃ\u0354ъ՜حݎࡒप\u0a5dହ\u0c29\u0d52ไབ၊ᅊሡ");
			DataTable dataSource = a2147.a2105(a1344.a1271);
			a708.DataSource = dataSource;
		}
		else
		{
			a708.DataSource = null;
		}
	}

	private void a744(object a742, EventArgs a743)
	{
		Close();
	}

	private void a747(object a745, EventArgs a746)
	{
		a741();
	}

	private void a750(object a748, EventArgs a749)
	{
		a700.Text = a1344.a1303();
		a1344.CUSTUMERINFO cUSTUMERINFO = new a1344.CUSTUMERINFO();
		cUSTUMERINFO.KARTNOHEX = a700.Text;
		cUSTUMERINFO.Getir();
		a701.Text = cUSTUMERINFO.ADSOYAD;
		a693.Text = cUSTUMERINFO.TCKIMLIK;
	}

	private void a753(object a751, EventArgs a752)
	{
		a708.ShowPreview();
	}

	private void a756(object a754, EventArgs a755)
	{
		for (int i = 0; i < a734.Items.Count; i++)
		{
			a734.SetItemChecked(i, value: true);
		}
	}

	private void a759(object a757, EventArgs a758)
	{
		for (int i = 0; i < a734.Items.Count; i++)
		{
			a734.SetItemChecked(i, value: false);
		}
	}

	protected override void Dispose(bool a760)
	{
		if (a760 && a687 != null)
		{
			a687.Dispose();
		}
		base.Dispose(a760);
	}

	private void a761()
	{
		a687 = new Container();
		a688 = new GroupBox();
		a733 = new CheckedListBox();
		a734 = new CheckedListBox();
		a735 = new ContextMenuStrip(a687);
		a736 = new ToolStripMenuItem();
		a737 = new ToolStripMenuItem();
		a689 = new DateTimePicker();
		a690 = new Label();
		a691 = new DateTimePicker();
		a710 = new System.Windows.Forms.ComboBox();
		a711 = new System.Windows.Forms.ComboBox();
		a692 = new System.Windows.Forms.ComboBox();
		a693 = new TextBox();
		a712 = new System.Windows.Forms.ComboBox();
		a713 = new System.Windows.Forms.ComboBox();
		a694 = new System.Windows.Forms.ComboBox();
		a714 = new Label();
		a715 = new Label();
		a695 = new Label();
		a696 = new Label();
		a697 = new Label();
		a698 = new Label();
		a699 = new Label();
		a700 = new TextBox();
		a701 = new TextBox();
		a702 = new Label();
		a703 = new Label();
		a704 = new Button();
		a705 = new Button();
		a706 = new Button();
		a707 = new GroupBox();
		a708 = new GridControl();
		a709 = new GridView();
		a716 = new GridColumn();
		a717 = new GridColumn();
		a731 = new GridColumn();
		a718 = new GridColumn();
		a719 = new GridColumn();
		a720 = new GridColumn();
		a721 = new GridColumn();
		a722 = new GridColumn();
		a723 = new GridColumn();
		a724 = new GridColumn();
		a725 = new GridColumn();
		a726 = new GridColumn();
		a727 = new GridColumn();
		a728 = new GridColumn();
		a729 = new GridColumn();
		a730 = new GridColumn();
		a732 = new GridColumn();
		a738 = new GridColumn();
		a739 = new GridColumn();
		a740 = new GridColumn();
		a688.SuspendLayout();
		a735.SuspendLayout();
		a707.SuspendLayout();
		((ISupportInitialize)a708).BeginInit();
		((ISupportInitialize)a709).BeginInit();
		SuspendLayout();
		a688.Controls.Add(a733);
		a688.Controls.Add(a734);
		a688.Controls.Add(a689);
		a688.Controls.Add(a690);
		a688.Controls.Add(a691);
		a688.Controls.Add(a710);
		a688.Controls.Add(a711);
		a688.Controls.Add(a692);
		a688.Controls.Add(a693);
		a688.Controls.Add(a712);
		a688.Controls.Add(a713);
		a688.Controls.Add(a694);
		a688.Controls.Add(a714);
		a688.Controls.Add(a715);
		a688.Controls.Add(a695);
		a688.Controls.Add(a696);
		a688.Controls.Add(a697);
		a688.Controls.Add(a698);
		a688.Controls.Add(a699);
		a688.Controls.Add(a700);
		a688.Controls.Add(a701);
		a688.Controls.Add(a702);
		a688.Controls.Add(a703);
		a688.Controls.Add(a704);
		a688.Controls.Add(a705);
		a688.Controls.Add(a706);
		a688.Dock = DockStyle.Left;
		a688.Location = new Point(0, 0);
		a688.Name = a763("nźɨͳѵՆ٬ݺ࠲");
		a688.Size = new Size(267, 611);
		a688.TabIndex = 63;
		a688.TabStop = false;
		a688.Text = a763("Mţɥ\u0361ѳմ٠ݨࡦ९\u0a64");
		a733.BorderStyle = BorderStyle.FixedSingle;
		a733.CheckOnClick = true;
		a733.Font = new Font(a763("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a733.FormattingEnabled = true;
		a733.Location = new Point(393, 114);
		a733.Name = a763("rŸɃ\u0367Ѿոـݫࡻॼ\u0a40୴\u0c70൦\u0e76ཋ၅");
		a733.Size = new Size(98, 66);
		a733.TabIndex = 95;
		a734.BorderStyle = BorderStyle.FixedSingle;
		a734.CheckOnClick = true;
		a734.ContextMenuStrip = a735;
		a734.Font = new Font(a763("RŤɬ\u036cѯՠ"), 8f);
		a734.FormattingEnabled = true;
		a734.Location = new Point(56, 95);
		a734.Name = a763("lŦɁ\u0365Ѹվقݩࡵॲ\u0a42୶\u0c76ൠ\u0e74");
		a734.Size = new Size(208, 212);
		a734.TabIndex = 94;
		a735.Items.AddRange(new ToolStripItem[2] { a736, a737 });
		a735.Name = a763("rſɡͺѨմٿ\u0747\u086c०ੲ\u0b55\u0c71൶\u0e6a\u0f72\u1030");
		a735.Size = new Size(148, 48);
		a736.Name = a763("{ŷɅͿѠբ\u065eݸࡹ\u0963\u0a79\u0b45\u0c62൨\u0e70ཌྷၷᅧቬ");
		a736.Size = new Size(147, 22);
		a736.Text = a763("CůɹͻѮը٬ܤࡐ१૦");
		a736.Click += a756;
		a737.Name = a763("vŸɬ\u0368ѳշٱݜࡷॹ\u0a70ਢౠ\u0d45\u0e7fའ\u1062ᅞቸ፹ᑣᕹᙅᝢᡨᥰᩍ᭷ᱧᵬ");
		a737.Size = new Size(147, 22);
		a737.Text = a763("FŨɼ\u0378ѣէ١ܧࡍ।੨୧ള൳");
		a737.Click += a759;
		a689.Font = new Font(a763("RŤɬ\u036cѯՠ"), 10f);
		a689.Location = new Point(56, 70);
		a689.Name = a763("lųɄ\u036cѰ\u0557٣ݳ");
		a689.Size = new Size(208, 24);
		a689.TabIndex = 68;
		a690.BackColor = Color.FromArgb(128, 255, 128);
		a690.BorderStyle = BorderStyle.Fixed3D;
		a690.FlatStyle = FlatStyle.Flat;
		a690.ForeColor = Color.DarkOrange;
		a690.Location = new Point(6, 414);
		a690.Name = a763("kŧɧ\u0361ѯԳز");
		a690.Size = new Size(258, 3);
		a690.TabIndex = 55;
		a691.Font = new Font(a763("RŤɬ\u036cѯՠ"), 10f);
		a691.ImeMode = ImeMode.NoControl;
		a691.Location = new Point(56, 45);
		a691.Name = a763("lųɄ\u0364ѷ\u0557٣ݳ");
		a691.Size = new Size(208, 24);
		a691.TabIndex = 68;
		a710.DropDownStyle = ComboBoxStyle.DropDownList;
		a710.Font = new Font(a763("RŤɬ\u036cѯՠ"), 14.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a710.FormattingEnabled = true;
		a710.Location = new Point(393, 280);
		a710.Name = a763("jŪɃͳѷձٮ\u074bࡅ");
		a710.Size = new Size(41, 31);
		a710.TabIndex = 67;
		a711.DropDownStyle = ComboBoxStyle.DropDownList;
		a711.Font = new Font(a763("RŤɬ\u036cѯՠ"), 14.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a711.FormattingEnabled = true;
		a711.Location = new Point(393, 243);
		a711.Name = a763("kťɉ\u0362ѱխ\u064b\u0745");
		a711.Size = new Size(41, 31);
		a711.TabIndex = 67;
		a692.DropDownStyle = ComboBoxStyle.DropDownList;
		a692.Font = new Font(a763("RŤɬ\u036cѯՠ"), 14.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a692.FormattingEnabled = true;
		a692.Location = new Point(393, 20);
		a692.Name = a763("iūɅ\u0362Ѵծ١ݹࡋ\u0945");
		a692.Size = new Size(41, 31);
		a692.TabIndex = 67;
		a693.Enabled = false;
		a693.Font = new Font(a763("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 10f);
		a693.Location = new Point(56, 424);
		a693.MaxLength = 11;
		a693.Name = a763("|ſɲ\u0351ѧՍ٭\u0740");
		a693.Size = new Size(208, 23);
		a693.TabIndex = 0;
		a712.DropDownStyle = ComboBoxStyle.DropDownList;
		a712.Font = new Font(a763("RŤɬ\u036cѯՠ"), 10f);
		a712.FormattingEnabled = true;
		a712.Location = new Point(56, 333);
		a712.Name = a763("dŤɁͱѱշ٬");
		a712.Size = new Size(143, 24);
		a712.TabIndex = 65;
		a713.DropDownStyle = ComboBoxStyle.DropDownList;
		a713.Font = new Font(a763("RŤɬ\u036cѯՠ"), 10f);
		a713.FormattingEnabled = true;
		a713.Location = new Point(56, 308);
		a713.Name = a763("eŧɋ\u0364ѷկ");
		a713.Size = new Size(143, 24);
		a713.TabIndex = 65;
		a694.DropDownStyle = ComboBoxStyle.DropDownList;
		a694.Font = new Font(a763("RŤɬ\u036cѯՠ"), 10f);
		a694.FormattingEnabled = true;
		a694.Location = new Point(56, 20);
		a694.Name = a763("kťɋ\u0360Ѷը٧ݻ");
		a694.Size = new Size(208, 24);
		a694.TabIndex = 65;
		a714.AutoSize = true;
		a714.Location = new Point(-2, 338);
		a714.Name = a763("jŤɦ\u0366ѮԷ");
		a714.Size = new Size(38, 13);
		a714.TabIndex = 66;
		a714.Text = a763("AűɱͷѬ");
		a715.AutoSize = true;
		a715.Location = new Point(-2, 313);
		a715.Name = a763("jŤɦ\u0366ѮԴ");
		a715.Size = new Size(33, 13);
		a715.TabIndex = 66;
		a715.Text = a763("Ò\u001c\u02fe\u036f");
		a695.AutoSize = true;
		a695.Location = new Point(-2, 211);
		a695.Name = a763("jŤɦ\u0366ѮԲ");
		a695.Size = new Size(59, 13);
		a695.TabIndex = 66;
		a695.Text = a763("AŨɺͳЦՂٶݶࡠॴ");
		a696.AutoSize = true;
		a696.Location = new Point(-1, 76);
		a696.Name = a763("jŤɦ\u0366ѮԳ");
		a696.Size = new Size(55, 13);
		a696.TabIndex = 66;
		a696.Text = a763("NŢɾ\u0360\u0557ԧ\u0652ݤࡶ४੪୨");
		a697.AutoSize = true;
		a697.Location = new Point(-1, 53);
		a697.Name = a763("jŤɦ\u0366Ѯ\u0530");
		a697.Size = new Size(57, 13);
		a697.TabIndex = 66;
		a697.Text = a763("Iū\u0356\u0326ЧՒ٤ݶࡪ४੨");
		a698.AutoSize = true;
		a698.Location = new Point(-1, 30);
		a698.Name = a763("jŤɦ\u0366ѮԵ");
		a698.Size = new Size(41, 13);
		a698.TabIndex = 66;
		a698.Text = a763("KŠɶ\u0368ѧջ");
		a699.AutoSize = true;
		a699.Location = new Point(-2, 429);
		a699.Name = a763("kŧɧ\u0361ѯԳش");
		a699.Size = new Size(52, 13);
		a699.TabIndex = 49;
		a699.Text = a763("^ħɋ\u0327эլ٩ݯ\u086b४");
		a700.Font = new Font(a763("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 10f);
		a700.Location = new Point(56, 472);
		a700.MaxLength = 100;
		a700.Name = a763("~űɼ\u034cѧշ\u0670ݍ\u086d\u0940");
		a700.Size = new Size(163, 23);
		a700.TabIndex = 2;
		a701.Enabled = false;
		a701.Font = new Font(a763("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 10f);
		a701.Location = new Point(56, 448);
		a701.MaxLength = 100;
		a701.Name = a763("yŴɿ\u034bѭա\u0654ݩࡼ॥੧୫\u0c40");
		a701.Size = new Size(208, 23);
		a701.TabIndex = 1;
		a702.AutoSize = true;
		a702.Location = new Point(-2, 453);
		a702.Name = a763("kŧɧ\u0361ѯԳط");
		a702.Size = new Size(57, 13);
		a702.TabIndex = 49;
		a702.Text = a763("Kŭ\u0339\u0327ѕժٽݢࡦ࠰");
		a703.AutoSize = true;
		a703.Location = new Point(-2, 476);
		a703.Name = a763("kŧɧ\u0361ѯԳض");
		a703.Size = new Size(45, 13);
		a703.TabIndex = 49;
		a703.Text = a763("LŧɷͰУՌ\u064e");
		a704.Image = a2268.a2312;
		a704.ImageAlign = ContentAlignment.MiddleLeft;
		a704.Location = new Point(123, 540);
		a704.Name = a763("jųɨ\u0340Ѽՠ٧ݭ");
		a704.Size = new Size(142, 40);
		a704.TabIndex = 3;
		a704.Text = a763("Yūɹ\u0367ѵԦلݯࡷ\u0963ੳ");
		a704.UseVisualStyleBackColor = true;
		a704.Click += a753;
		a705.Image = a2268.a2280;
		a705.ImageAlign = ContentAlignment.MiddleLeft;
		a705.Location = new Point(123, 501);
		a705.Name = a763("hŽɦ\u0354ѩշ٣ݶ\u086eॠ");
		a705.Size = new Size(142, 40);
		a705.TabIndex = 3;
		a705.Text = a763("_ŭɻ\u0365ѻԨ\u0654ݩࡷ\u0963੶୮ౠ");
		a705.UseVisualStyleBackColor = true;
		a705.Click += a747;
		a706.Image = a2268.a2305;
		a706.ImageAlign = ContentAlignment.MiddleLeft;
		a706.Location = new Point(219, 471);
		a706.Name = a763("dűɪ\u0342Ѱՠ");
		a706.Size = new Size(46, 25);
		a706.TabIndex = 3;
		a706.UseVisualStyleBackColor = true;
		a706.Click += a750;
		a707.Controls.Add(a708);
		a707.Dock = DockStyle.Fill;
		a707.Location = new Point(267, 0);
		a707.Name = a763("nźɨͳѵՆ٬ݺ࠰");
		a707.Size = new Size(934, 611);
		a707.TabIndex = 64;
		a707.TabStop = false;
		a707.Text = a763("0ŝɯͽѣչتݚࡧ३ੳ\u0be2౨\u0d62\u0e70ะ");
		a708.Dock = DockStyle.Fill;
		a708.EmbeddedNavigator.Name = a763("");
		a708.Font = new Font(a763("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a708.Location = new Point(3, 17);
		a708.LookAndFeel.SkinName = a763("GżɻͳѯՖ٭ݨ\u086b९");
		a708.LookAndFeel.UseDefaultLookAndFeel = false;
		a708.MainView = a709;
		a708.Name = a763("kŹɣ\u036dыը٨ݱࡶ६੮ର");
		a708.Size = new Size(928, 591);
		a708.TabIndex = 56;
		a708.ViewCollection.AddRange(new BaseView[1] { a709 });
		a709.BorderStyle = BorderStyles.NoBorder;
		a709.Columns.AddRange(new GridColumn[20]
		{
			a716, a717, a731, a718, a719, a720, a721, a722, a723, a724,
			a725, a726, a727, a728, a729, a730, a732, a738, a739, a740
		});
		a709.FocusRectStyle = DrawFocusRectStyle.RowFocus;
		a709.GridControl = a708;
		a709.Name = a763("nźɮ\u0362ѓխ٦ݵ࠰");
		a709.OptionsBehavior.Editable = false;
		a709.OptionsFilter.AllowFilterEditor = false;
		a709.OptionsView.ColumnAutoWidth = false;
		a709.OptionsView.ShowAutoFilterRow = true;
		a709.OptionsView.ShowFooter = true;
		a709.OptionsView.ShowGroupPanel = false;
		a716.Caption = a763("KŅ");
		a716.FieldName = a763("KŅ");
		a716.Name = a763("lŸɠ\u036cфթ٩ݱ\u086e६ਰ");
		a717.Caption = a763("Bšɴ\u036fѩաٱ\u074bࡅ");
		a717.FieldName = a763("Aŀɛ\u034eъՀ\u0656ݜࡋ\u0945");
		a717.Name = a763("lŸɠ\u036cфթ٩ݱ\u086e६ਲ਼");
		a731.Caption = a763("QŇȣ\u034cѮ");
		a731.FieldName = a763("PŀɌ\u034e");
		a731.Name = a763("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଷ");
		a731.Visible = true;
		a731.VisibleIndex = 2;
		a731.Width = 67;
		a718.Caption = a763("Kŭ\u0339\u0327ѕժٽݢࡦ࠰");
		a718.FieldName = a763("BņɈ");
		a718.Name = a763("lŸɠ\u036cфթ٩ݱ\u086e६ਲ");
		a718.Visible = true;
		a718.VisibleIndex = 3;
		a718.Width = 100;
		a719.Caption = a763("LŧɷͰУՌٮ");
		a719.FieldName = a763("Bŉɕ\u0352ыՋ\u064b\u0747\u0859");
		a719.Name = a763("lŸɠ\u036cфթ٩ݱ\u086e६ਵ");
		a719.SummaryItem.SummaryType = SummaryItemType.Count;
		a719.Visible = true;
		a719.VisibleIndex = 1;
		a719.Width = 63;
		a720.Caption = a763("Qťɱ\u036bѩ");
		a720.FieldName = a763("QŅɑ\u034bщ");
		a720.Name = a763("lŸɠ\u036cфթ٩ݱ\u086e६\u0a34");
		a720.Visible = true;
		a720.VisibleIndex = 7;
		a720.Width = 60;
		a721.Caption = a763("@ūɻͼЧՁٷݱࡳ\u094b\u0a45");
		a721.FieldName = a763("Aňɚ\u0353с\u0557\u0651ݓࡋ\u0945");
		a721.Name = a763("lŸɠ\u036cфթ٩ݱ\u086e६\u0a37");
		a722.Caption = a763("BũɵͲХՃٱݷࡱ");
		a722.FieldName = a763("Cņɔ\u0351уՑ\u0657ݑ");
		a722.Name = a763("lŸɠ\u036cфթ٩ݱ\u086e६ਸ਼");
		a722.Visible = true;
		a722.VisibleIndex = 4;
		a722.Width = 84;
		a723.Caption = a763("Iłɑ\u034dыՅ");
		a723.FieldName = a763("Iłɑ\u034dыՅ");
		a723.Name = a763("lŸɠ\u036cфթ٩ݱ\u086e६ਹ");
		a724.Caption = a763("Ò\u001c\u02fe\u036f");
		a724.FieldName = a763("Kńɗ\u034f");
		a724.Name = a763("lŸɠ\u036cфթ٩ݱ\u086e६ਸ");
		a724.Visible = true;
		a724.VisibleIndex = 8;
		a724.Width = 55;
		a725.Caption = a763("_Łɱͱѷլ");
		a725.FieldName = a763("RŏɄ\u034dьՙفݑࡑ\u0957\u0a4c");
		a725.Name = a763("kŹɣ\u036dыը٪ݰࡩ७ਲ਼\u0b31");
		a726.Caption = a763("AűɱͷѬ");
		a726.FieldName = a763("Aőɑ\u0357ь");
		a726.Name = a763("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ର");
		a726.Visible = true;
		a726.VisibleIndex = 9;
		a727.Caption = a763("EŢɴ\u036eѡչ\u064b\u0745");
		a727.FieldName = a763("WŘɇ\u0347яՄ\u064dݘࡋ\u0940\u0a56ଡ଼\u0c4b\u0d45");
		a727.Name = a763("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଳ");
		a728.Caption = a763("Vǲɦ\u0360Ѯէ٬ܨࡊ\u0963\u0a77୯౦൸\u0e68");
		a728.FieldName = a763("Kŀɖ\u0348ч՛");
		a728.Name = a763("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଲ");
		a728.Visible = true;
		a728.VisibleIndex = 10;
		a728.Width = 91;
		a729.Caption = a763("SŶɡͱыՅ");
		a729.FieldName = a763("Rŕɀ\u0356ќՋم");
		a729.Name = a763("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଵ");
		a730.Caption = a763("XŢɴͶѫխ٧ݭ");
		a730.FieldName = a763("PŗɆ\u0350ѓ");
		a730.Name = a763("kŹɣ\u036dыը٪ݰࡩ७ਲ਼\u0b34");
		a730.Visible = true;
		a730.VisibleIndex = 12;
		a730.Width = 111;
		a732.Caption = a763("W2ɰ\u0360");
		a732.FieldName = a763("WŊɐ\u0340");
		a732.Name = a763("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଶ");
		a732.Visible = true;
		a732.VisibleIndex = 0;
		a732.Width = 70;
		a738.Caption = a763("GǲɯϾѬ");
		a738.FieldName = a763("Gŋɏ\u0357ь");
		a738.Name = a763("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ହ");
		a738.OptionsColumn.AllowEdit = false;
		a738.Visible = true;
		a738.VisibleIndex = 5;
		a739.Caption = a763("V5ɭȳѧ");
		a739.FieldName = a763("Vōɍ\u034bч");
		a739.Name = a763("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ସ");
		a739.OptionsColumn.AllowEdit = false;
		a739.Visible = true;
		a739.VisibleIndex = 6;
		a740.Caption = a763("UŮɧ\u036cШՊ٣ݷ\u086f०\u0a78୨");
		a740.FieldName = a763("RŏɄ\u034dъՃ\u0657ݏࡆक़\u0a48");
		a740.Name = a763("kŹɣ\u036dыը٪ݰࡩ७ਰ\u0b31");
		a740.Visible = true;
		a740.VisibleIndex = 11;
		a740.Width = 90;
		Appearance.BackColor = Color.White;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1201, 611);
		Controls.Add(a707);
		Controls.Add(a688);
		Name = a763("MŸɤ\u034fѲը\u0657ݥࡳ७ੳ");
		ShowIcon = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a763("Jǰɥ\u032aћթٷݩࡷ२\u0a62୰ര");
		WindowState = FormWindowState.Maximized;
		a688.ResumeLayout(performLayout: false);
		a688.PerformLayout();
		a735.ResumeLayout(performLayout: false);
		a707.ResumeLayout(performLayout: false);
		((ISupportInitialize)a708).EndInit();
		((ISupportInitialize)a709).EndInit();
		ResumeLayout(performLayout: false);
	}

	private static string a763(string a762)
	{
		int length = a762.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a762[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
