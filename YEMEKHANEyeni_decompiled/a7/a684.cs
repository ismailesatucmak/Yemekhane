using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using a7.a2096;

namespace a7;

public class a684 : XtraForm
{
	private IContainer a616 = null;

	public TextBox a617;

	public TextBox a618;

	private Label a619;

	private Label a620;

	public PictureBox a621;

	public System.Windows.Forms.ComboBox a622;

	public System.Windows.Forms.ComboBox a623;

	public System.Windows.Forms.ComboBox a624;

	public System.Windows.Forms.ComboBox a625;

	private ContextMenuStrip a626;

	private ToolStripMenuItem a627;

	private Panel a628;

	private Label a629;

	private Button a630;

	private Label a631;

	private Label a632;

	private LabelControl a633;

	private ToolStripMenuItem a634;

	private Panel a635;

	private ToolStripMenuItem a636;

	private Label a637;

	private Button a638;

	private Label a639;

	public a684()
	{
		a681();
		a1984.a1891(this);
		a1344.a1269 = false;
		if (!a2147.a2100(a683("Nřɗ\u035fњՌطݟࡑऴ\u0a55\u0b40\u0c5e൝ฯབྷ\u1058ᅇቇፏᑄᕍᙘᝋᡀᥖᩈᭇᱛ")))
		{
			MessageBox.Show(a683("uŌɗ\u0357чՌم\u073fࡕॼ\u0a65ਪ౮൵༩\u0f37\u1074ᅼቦጳᑟᕴᙢᝤᡫ\u1977ᨬᭉ᱿ᵥṽὩ\u2067Ⅸ≥⍧┳┯"), a683("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			new a821().ShowDialog();
			if (!a2147.a2100(a683("Nřɗ\u035fњՌطݟࡑऴ\u0a55\u0b40\u0c5e൝ฯབྷ\u1058ᅇቇፏᑄᕍᙘᝋᡀᥖᩈᭇᱛ")))
			{
				Environment.Exit(0);
			}
		}
		if (!a2147.a2100(a683("Jŝɛ\u0353іՀس\u0738࠱\u0956\u0a5d\u0b41\u0c40ബเཋၛᅜቘፂᑐᕖᙖᝏᠡ")))
		{
			a1344.a1307();
			a1344.a1271.CommandText = a683("\u001aĜȂ\u0315НԚ٭܅ࠅञਆ୨ఌഇท༐လᄆሔጒᑪᕳᘝ\u1714ᡰ\u197b\u1a6b\u1b6cᱨᵲṠὦ\u2066ⅿ∝⍻⑮╼♹❳⡤⥰⩬⭤Ⱬⵯ\u2e6e⼍〃ㅴ㉠㍬㑊㕛㙎㜼㠳㥚㩒㭙㱅㵂㹊㽐䁆䅀䉄䍝䐣䕎䙆䝍䡙䥞䩖䭇䱝䵃义佈偊光刨");
			a1344.a1271.Parameters.Add(a683("Aňɚ\u0353љՁ\u0651ݑࡗ\u094c"), SqlDbType.NVarChar).Value = a683("F");
			a1344.a1271.Parameters.Add(a683("GŊɘ\u035dїՈ\u065c\u0740ࡈ\u094f\u0a4b\u0b4a"), SqlDbType.NVarChar).Value = a683("DǾɯ");
			a1344.a1271.ExecuteNonQuery();
			a1344.a1307();
			a1344.a1271.CommandText = a683("\u001aĜȂ\u0315НԚ٭܅ࠅञਆ୨ఌഇท༐လᄆሔጒᑪᕳᘝ\u1714ᡰ\u197b\u1a6b\u1b6cᱨᵲṠὦ\u2066ⅿ∝⍻⑮╼♹❳⡤⥰⩬⭤Ⱬⵯ\u2e6e⼍〃ㅴ㉠㍬㑊㕛㙎㜼㠳㥚㩒㭙㱅㵂㹊㽐䁆䅀䉄䍝䐣䕎䙆䝍䡙䥞䩖䭇䱝䵃义佈偊光刨");
			a1344.a1271.Parameters.Add(a683("Aňɚ\u0353љՁ\u0651ݑࡗ\u094c"), SqlDbType.NVarChar).Value = a683("Q");
			a1344.a1271.Parameters.Add(a683("GŊɘ\u035dїՈ\u065c\u0740ࡈ\u094f\u0a4b\u0b4a"), SqlDbType.NVarChar).Value = a683("TŢɰ\u0360");
			a1344.a1271.ExecuteNonQuery();
		}
		if (!a2147.a2100(a683("pŧɭ\u0365ќՊؽݕ\u085f\u093a\u0a5f\u0b4aౘ൛\u0e35ཁ၀ᅗቃፃᐯᕙᙅᝉᡙ᥏ᨩᭉ\u1c4cᵒṌὂ‾ℳ∡")))
		{
			MessageBox.Show(a683("zŁɔ\u0352рՉن܂ࡪ\u0941੦ਯ౩൰༪༺ၻᅱብጶᑞᕡᙿ\u177eᡰ\u197e\u1b3e\u1b6dᴼᴬṉ\u1f7f\u2065ⅽ≩⍧⑨╥♧☳⠯"), a683("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			new a613().ShowDialog();
			if (!a2147.a2100(a683("qŤɬ\u035aѝՉؼݒ࡞हਫ਼\u0b45ౙ൘\u0e34ཆ၁ᅔቂ\u135cᐮᕚᙄᝎᡘ᥌ᨨᭆᱍᵑṍὅ\u203fℰ")))
			{
				Environment.Exit(0);
			}
		}
		a1984.a1964(a683("rťɓ\u035bўՈػݓ\u085dऴ\u0a56\u0b52\u0c5cഴ๕ཀ\u105eᅝሯፗᑘᕇᙇᝏᡄ᥍\u1a58ᭋ᱀ᵖṈ\u1f47⁛"), a623, a622);
		a617.Text = a1344.a1321(a683("IŶɾ\u0363ѡմ٦ݶࡎय़\u0a55\u0b59\u0c4f\u0d51๕ཎ၇ᅌቃ\u135bᑍᕐᙈᝂᡆ᥈"), a683("Lœɉ\u0348тՆو"));
		a623.SelectedIndex = a623.Items.IndexOf(a1344.a1321(a683("OŴɼ\u036dѯն٤ݰࡈढ़\u0a57\u0b47\u0c51\u0d53๗\u0f48၁ᅎቁፕᑅᕂᙔᝎᡁᥙᩋᭅ"), a683("Ełɔ\u034eсՙ\u064b\u0745")));
		a625.SelectedIndex = a625.Items.IndexOf(a1344.a1321(a683("Nųɽ\u036eѮչ٥ݳࡉग़\u0a56\u0b44\u0c50\u0d4c๖ཋ၀ᅉቀፖᑎᕁᙕᝏᡖᥐᩊ᭒᱈"), a683("NŁɕ\u034fіՐيݒࡈ")));
		if (a625.SelectedIndex != -1)
		{
			a624.SelectedIndex = a625.SelectedIndex;
		}
		if (a623.SelectedIndex != -1)
		{
			a622.SelectedIndex = a623.SelectedIndex;
		}
	}

	private void a642(object a640, EventArgs a641)
	{
		Close();
	}

	private void a645(object a643, EventArgs a644)
	{
	}

	private void a648(object a646, FormClosedEventArgs a647)
	{
		if (!a1344.a1269)
		{
			Environment.Exit(-1);
		}
	}

	private void a651(object a649, EventArgs a650)
	{
		if (a617.Text != a683(""))
		{
			a618.Focus();
		}
		else
		{
			a617.Focus();
		}
	}

	public void a652()
	{
		a623.SelectedIndex = a622.SelectedIndex;
		a625.SelectedIndex = a624.SelectedIndex;
		a1344.a1325(a683("IŶɾ\u0363ѡմ٦ݶࡎय़\u0a55\u0b59\u0c4f\u0d51๕ཎ၇ᅌቃ\u135bᑍᕐᙈᝂᡆ᥈"), a683("Lœɉ\u0348тՆو"), a617.Text);
		a1344.a1325(a683("Nųɽ\u036eѮչ٥ݳࡉग़\u0a56\u0b44\u0c50\u0d4c๖ཋ၀ᅉቀፖᑎᕁᙕᝏᡖᥐᩊ᭒᱈"), a683("NŁɕ\u034fіՐيݒࡈ"), a625.Text);
		a1344.a1325(a683("OŴɼ\u036dѯն٤ݰࡈढ़\u0a57\u0b47\u0c51\u0d53๗\u0f48၁ᅎቁፕᑅᕂᙔᝎᡁᥙᩋᭅ"), a683("Ełɔ\u034eсՙ\u064b\u0745"), a623.Text);
		if (a625.Text == a683("3"))
		{
			if (a1344.a1315(a617.Text, a618.Text))
			{
				a1344.a1269 = true;
				Close();
			}
			else
			{
				MessageBox.Show(a683("xǖɱͻѩյٸݳ࠹ख़ੳਧవ\u0d62\u0e76ཫၰᄰፑ፧ᑫᕾ᙮\u1779ᡠ\u1928ᩏ᭧ᱱᵥṯḳ\u202f"), a683("SżɥͱԳԡ"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}
		else if (a625.Text == a683("0"))
		{
			if (a1344.a1318(a617.Text, a618.Text))
			{
				a1344.a1269 = true;
				Close();
			}
			else
			{
				MessageBox.Show(a683("sŁɯͱѯը\u06edݨ࠹ख़ੳਧవ\u0d62\u0e76ཫၰᄰፑ፧ᑫᕾ᙮\u1779ᡠ\u1928ᩏ᭧ᱱᵥṯḳ\u202f"), a683("SżɥͱԳԡ"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}
		else if (a625.Text == a683("1"))
		{
			string text = a1344.a1303();
			if (text == a683("8ķȶ\u0335дԳز\u0731"))
			{
				MessageBox.Show(a683("eǔɓ\u0340рՊ\u0603ݩࡀ\u0952੫\u0b3e\u0c52൷\u0e6eལ\u106cᅻቢ፯ᑴᔴᙘ\u1773ᡣᥤᨯ᭗ᱨᵾṧὯ⅖ⅼ≮⍴⑬╪♪❸⠯"), a683("Eŭɿ\u036bѥաا\u0741\u086cॶ੪ୱ\u0c3b"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (!a1344.a1312(a617.Text, a618.Text, a623.Text, text))
			{
				MessageBox.Show(a683("\u001aƾȪ\u032cњՓ\u0658ܜࡶय़\u0a4b\u0b53\u0c52\u0d4c\u0e5cཚၚᄞሑ፻ᑚᕂᙁᝍᡅ\u181bᩊ\u1a19ᰇᵧṁḕ⁍–≛∑\u243f╨♸❥⡺⤺⭇⭱ⱱⵤ\u2e70⽺ぺㅨ㉸㌰㑄㕡㙣㝸㡹㥥㩥㬨㱂㵢㹬㽪䁪䅸䈯"), a683("Eŭɿ\u036bѥաا\u0741\u086cॶ੪ୱ\u0c3b"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			a1344.a1269 = true;
			Close();
		}
	}

	private void a655(object a653, KeyEventArgs a654)
	{
		if (a654.KeyCode == Keys.Return)
		{
			a652();
		}
	}

	private void a658(object a656, MouseEventArgs a657)
	{
		MessageBox.Show(a683("AŨɺͳЦՋ٫ܣ࠸ड") + a1344.a1303(), a683("oŴɫ\u0364ѩոٯ\u0739ࣄ७ੳ୧౽ൽ\u0e76\u0f74ၻᅦሮፆᑭᕹᙾᜩᡆᥲ\u1a6b᭤ᱶᵢṱḰ"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	private void a661(object a659, ToolStripItemClickedEventArgs a660)
	{
	}

	private void a664(object a662, EventArgs a663)
	{
	}

	private void a667(object a665, EventArgs a666)
	{
		a1740 a2269 = new a1740();
		a2269.ShowDialog();
	}

	private void a670(object a668, EventArgs a669)
	{
		a652();
	}

	private void a673(object a671, EventArgs a672)
	{
		Close();
	}

	private void a676(object a674, EventArgs a675)
	{
		MessageBox.Show(a1344.a1303(), a683("Oťɧ\u036dѠդ٢ݨࡡ७\u0a71୯\u0c64"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	private void a679(object a677, EventArgs a678)
	{
		Close();
	}

	protected override void Dispose(bool a680)
	{
		if (a680 && a616 != null)
		{
			a616.Dispose();
		}
		base.Dispose(a680);
	}

	private void a681()
	{
		a616 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(a684));
		a617 = new TextBox();
		a618 = new TextBox();
		a619 = new Label();
		a620 = new Label();
		a622 = new System.Windows.Forms.ComboBox();
		a623 = new System.Windows.Forms.ComboBox();
		a624 = new System.Windows.Forms.ComboBox();
		a625 = new System.Windows.Forms.ComboBox();
		a626 = new ContextMenuStrip(a616);
		a627 = new ToolStripMenuItem();
		a636 = new ToolStripMenuItem();
		a634 = new ToolStripMenuItem();
		a628 = new Panel();
		a638 = new Button();
		a629 = new Label();
		a630 = new Button();
		a637 = new Label();
		a631 = new Label();
		a632 = new Label();
		a633 = new LabelControl();
		a635 = new Panel();
		a621 = new PictureBox();
		a639 = new Label();
		a626.SuspendLayout();
		a628.SuspendLayout();
		a635.SuspendLayout();
		((ISupportInitialize)a621).BeginInit();
		SuspendLayout();
		a617.BackColor = Color.FromArgb(224, 224, 224);
		a617.Font = new Font(a683("QŽɧ\u036cѠԫ\u065fݧࡡ।੩ୡౡണ๏དྷ"), 12f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a617.ForeColor = SystemColors.WindowText;
		a617.Location = new Point(19, 270);
		a617.Name = a683("rŽɰ\u0342Ѧը");
		a617.Size = new Size(230, 29);
		a617.TabIndex = 2;
		a617.KeyDown += a655;
		a618.BackColor = Color.FromArgb(224, 224, 224);
		a618.Font = new Font(a683("QŽɧ\u036cѠԫ\u065fݧࡡ।੩ୡౡണ๏དྷ"), 12f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a618.Location = new Point(19, 300);
		a618.Name = a683("|ſɲ\u0356ѭե\u0670ݤ");
		a618.PasswordChar = '*';
		a618.Size = new Size(230, 29);
		a618.TabIndex = 3;
		a618.KeyDown += a655;
		a619.AutoSize = true;
		a619.Location = new Point(40, 569);
		a619.Name = a683("jŤɦ\u0366ѮԳ");
		a619.Size = new Size(62, 13);
		a619.TabIndex = 8;
		a619.Text = a683("FŹɧ\u0366Ѩզ\u0736ݥऴत\u0a42୦ര");
		a619.Visible = false;
		a620.AutoSize = true;
		a620.Location = new Point(40, 593);
		a620.Name = a683("jŤɦ\u0366ѮԲ");
		a620.Size = new Size(29, 13);
		a620.TabIndex = 8;
		a620.Text = a683("śŭɥͰѤ");
		a620.Visible = false;
		a622.BackColor = Color.FromArgb(224, 224, 224);
		a622.DropDownStyle = ComboBoxStyle.DropDownList;
		a622.Font = new Font(a683("QŽɧ\u036cѠԫ\u065fݧࡡ।੩ୡౡണ๏དྷ"), 12f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a622.FormattingEnabled = true;
		a622.Location = new Point(19, 240);
		a622.Name = a683("kťɋ\u0360Ѷը٧ݻ");
		a622.Size = new Size(230, 29);
		a622.TabIndex = 1;
		a623.DropDownStyle = ComboBoxStyle.DropDownList;
		a623.Font = new Font(a683("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a623.FormattingEnabled = true;
		a623.Location = new Point(1002, 307);
		a623.Name = a683("iūɅ\u0362Ѵծ١ݹࡋ\u0945");
		a623.Size = new Size(35, 26);
		a623.TabIndex = 12;
		a624.BackColor = Color.FromArgb(224, 224, 224);
		a624.DropDownStyle = ComboBoxStyle.DropDownList;
		a624.Font = new Font(a683("QŽɧ\u036cѠԫ\u065fݧࡡ।੩ୡౡണ๏དྷ"), 12f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a624.FormattingEnabled = true;
		a624.Items.AddRange(new object[3]
		{
			a683("[źɢ\u0361ѭե\u073bݪहध\u0a41୬\u0c76൪ཝཨ"),
			a683("AųɡͿѽԮيߺࡹ৶੧\u0b7c\u0cfb൪\u0e60\u0f7d\u106aᅡቨ"),
			a683("VǸɣ\u0369ѿգ٪ݡ\u0827\u0941੬୶౪ౝ\u0e68")
		});
		a624.Location = new Point(19, 210);
		a624.Name = a683("hŨɎ\u0361ѵկٶݐࡪॲ੨");
		a624.Size = new Size(230, 29);
		a624.TabIndex = 0;
		a625.DropDownStyle = ComboBoxStyle.DropDownList;
		a625.Font = new Font(a683("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a625.FormattingEnabled = true;
		a625.Items.AddRange(new object[3]
		{
			a683("1"),
			a683("0"),
			a683("3")
		});
		a625.Location = new Point(1002, 279);
		a625.Name = a683("nŮɌ\u0363ѻաٴݒ\u086cॴ੪\u0b4b\u0c45");
		a625.Size = new Size(35, 26);
		a625.TabIndex = 12;
		a626.Items.AddRange(new ToolStripItem[3] { a627, a636, a634 });
		a626.Name = a683("rſɡͺѨմٿ\u0747\u086c०ੲ\u0b55\u0c71൶\u0e6a\u0f72\u1030");
		a626.Size = new Size(152, 118);
		a627.Image = a2268.a2313;
		a627.ImageScaling = ToolStripItemImageScaling.None;
		a627.Name = a683("}Śɔ\u0379ѻճٺݴࡅॿ\u0a60\u0b62\u0c5e൸\u0e79ལၹᅅቢ፨ᑰᕍᙷᝧᡬ");
		a627.Size = new Size(151, 38);
		a627.Text = a683("MŊȧ\u0345ъՊم\u074bࡆ");
		a627.Click += a667;
		a636.Image = a2268.a2294;
		a636.ImageScaling = ToolStripItemImageScaling.None;
		a636.Name = a683("tŗɇ\u0350ѝ՝مݿࡠ\u0962ਫ਼\u0b78౹\u0d63\u0e79ཅ\u1062ᅨተፍᑷᕧᙬ");
		a636.Size = new Size(151, 38);
		a636.Text = a683("DŇɗ\u0340УՌ\u064e");
		a636.Click += a676;
		a634.Image = a2268.a2282;
		a634.ImageScaling = ToolStripItemImageScaling.None;
		a634.Name = a683("ñ$ɿȢՍՅٿݠࡢफ़\u0a78\u0b79\u0c63൹ๅར\u1068ᅰቍ፷ᑧᕬ");
		a634.Size = new Size(151, 38);
		a634.Text = a683("Aśɋ\u0355");
		a634.Click += a673;
		a628.BackColor = Color.FromArgb(34, 76, 100);
		a628.Controls.Add(a639);
		a628.Controls.Add(a638);
		a628.Controls.Add(a629);
		a628.Controls.Add(a630);
		a628.Controls.Add(a637);
		a628.Controls.Add(a631);
		a628.Controls.Add(a632);
		a628.Controls.Add(a624);
		a628.Controls.Add(a620);
		a628.Controls.Add(a622);
		a628.Controls.Add(a619);
		a628.Controls.Add(a633);
		a628.Controls.Add(a617);
		a628.Controls.Add(a618);
		a628.Dock = DockStyle.Right;
		a628.Location = new Point(740, 0);
		a628.Name = a683("vŤɪ\u0366Ѯ\u0530");
		a628.Size = new Size(267, 572);
		a628.TabIndex = 15;
		a638.BackColor = Color.FromArgb(34, 76, 100);
		a638.FlatStyle = FlatStyle.Flat;
		a638.ForeColor = Color.FromArgb(192, 192, 255);
		a638.Location = new Point(19, 331);
		a638.Name = a683("eųɱͰѬլذ");
		a638.Size = new Size(95, 30);
		a638.TabIndex = 11;
		a638.Text = a683("ĵŴɷ\u0363ѭ");
		a638.UseVisualStyleBackColor = false;
		a638.Click += a679;
		a629.AutoSize = true;
		a629.Font = new Font(a683("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a629.ForeColor = Color.LightSlateGray;
		a629.Location = new Point(17, 407);
		a629.Name = a683("jŤɦ\u0366ѮԴ");
		a629.Size = new Size(165, 39);
		a629.TabIndex = 10;
		a629.Text = a683("\u0005ČȊ\u0368Шԭذ\u073d࠶ड\u0a34ମ\u0c4a\u0d50ฝ࿀၁ᅟቋፑᑙᕓᘕ\u175fᡒ᥀ᩅᨁ᱁ᰟṗḝ…℠≐⍍\u2455╊♀♻⡗⥋⩓⭄ⱶ\u2d75\u2e69⽹ふㄺ㉪㍷㑹㕤㙴㜴㠞㤘㩶㭹㱽㵧㽒㼬䁲䅫䉹䈹䑩䐷䙿䜪䠭䤬䨯");
		a630.BackColor = Color.FromArgb(255, 128, 0);
		a630.FlatStyle = FlatStyle.Flat;
		a630.ForeColor = Color.White;
		a630.Location = new Point(115, 331);
		a630.Name = a683("eųɱͰѬլز");
		a630.Size = new Size(134, 30);
		a630.TabIndex = 9;
		a630.Text = a683("Bŭɱ\u036b՞");
		a630.UseVisualStyleBackColor = false;
		a630.Click += a670;
		a637.AutoSize = true;
		a637.Font = new Font(a683("[ūɠͼѾչةݛࡦ२੶ତ\u0c4aൖโ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a637.ForeColor = Color.Silver;
		a637.Location = new Point(133, 553);
		a637.Name = a683("jŤɦ\u0366Ѯ\u0530");
		a637.Size = new Size(133, 15);
		a637.TabIndex = 8;
		a637.Text = a683("zŮȶ\u035bѱեٳ\u0731\u085d৳੦୨\u0c62൯\u0e63\u0f7a\u1064ᅮቭጥᐶᔳᘳ\u1738");
		a631.AutoSize = true;
		a631.Font = new Font(a683("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a631.ForeColor = Color.Gainsboro;
		a631.Location = new Point(17, 97);
		a631.Name = a683("jŤɦ\u0366ѮԷ");
		a631.Size = new Size(204, 39);
		a631.TabIndex = 8;
		a631.Text = a683("9ƈȇ\u0314ДԞ\u064fܗ\u0891इਇଏ\u0c04\u0d0d\u0e47་ကᄖለጇᐛᔉᘱ\u1737\u187d\u192fᨾᮽ\u1c30ᴶḾἬ⁹ⅴ∸⌧\u243d┼☮✠⥼⤯⭺⭇ⱃ\u2d29⸣\u2e77どㅤ㌜㌫㐧㔲㙚㜞㡟㥕㩗㭝㱐㵔㹒㽄䁜䅚䉚䌒䑖䕙䙝䝇䡃䥅䩑䬊䱟䵍万佂偄兌剂匂呒問噱坬塼夑娑孽屰嵪幾幉怵慶扦捦摾敾智杠桸椬橿樻汢浤湦潿焴煪猲獸琯");
		a632.AutoSize = true;
		a632.Font = new Font(a683("RŤɬ\u036cѯՠ"), 18f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a632.ForeColor = Color.Gainsboro;
		a632.Location = new Point(15, 46);
		a632.Name = a683("jŤɦ\u0366ѮԶ");
		a632.Size = new Size(69, 29);
		a632.TabIndex = 7;
		a632.Text = a683("Iūɤ\u036bѯ");
		a633.Appearance.ForeColor = Color.White;
		a633.Appearance.Options.UseForeColor = true;
		a633.Location = new Point(20, 186);
		a633.Name = a683("aŭɩ\u036fѥՋ٨ݨࡱॶ੬୮ర");
		a633.Size = new Size(34, 13);
		a633.TabIndex = 6;
		a633.Text = a683("KŠɶ\u0368ѧջ");
		a635.Controls.Add(a621);
		a635.Dock = DockStyle.Fill;
		a635.Location = new Point(0, 0);
		a635.Name = a683("vŤɪ\u0366ѮԳ");
		a635.Size = new Size(740, 572);
		a635.TabIndex = 16;
		a621.Dock = DockStyle.Fill;
		a621.Image = (Image)componentResourceManager.GetObject(a683("aŹɬͺѸվٮ\u0748ࡦ॰ਸ਼ନ\u0c4c൩\u0e62ཥ\u1064"));
		a621.Location = new Point(0, 0);
		a621.Name = a683("{ţɪͼѲմ٠\u0746\u086cॺਰ");
		a621.Size = new Size(740, 572);
		a621.SizeMode = PictureBoxSizeMode.StretchImage;
		a621.TabIndex = 9;
		a621.TabStop = false;
		a621.MouseDoubleClick += a658;
		a639.AutoSize = true;
		a639.Font = new Font(a683("RŤɬ\u036cѯՠ"), 18f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a639.ForeColor = Color.Gainsboro;
		a639.Location = new Point(15, 9);
		a639.Name = a683("jŤɦ\u0366ѮԵ");
		a639.Size = new Size(205, 29);
		a639.TabIndex = 12;
		Appearance.BackColor = Color.White;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1007, 572);
		ContextMenuStrip = a626;
		Controls.Add(a635);
		Controls.Add(a628);
		Controls.Add(a625);
		Controls.Add(a623);
		FormBorderStyle = FormBorderStyle.None;
		Icon = (Icon)componentResourceManager.GetObject(a683(".Žɠ\u036eѵԫ\u064dݠ\u086d९"));
		MaximizeBox = false;
		MinimumSize = new Size(478, 222);
		Name = a683("Nŵɫ\u0342ѭձ٫ݲ");
		ShowIcon = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a683("^ťɸ;Ѭեا\u0741\u086cॶ੪\u0a5d౨");
		Load += a664;
		Shown += a651;
		FormClosed += a648;
		a626.ResumeLayout(performLayout: false);
		a628.ResumeLayout(performLayout: false);
		a628.PerformLayout();
		a635.ResumeLayout(performLayout: false);
		((ISupportInitialize)a621).EndInit();
		ResumeLayout(performLayout: false);
	}

	private static string a683(string a682)
	{
		int length = a682.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a682[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
