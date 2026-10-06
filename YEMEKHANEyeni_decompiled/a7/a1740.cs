using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using a7.a2096;

namespace a7;

public class a1740 : XtraForm
{
	private IContainer a1705 = null;

	public PictureBox a1706;

	public GroupBox a1707;

	public Label a1708;

	public Label a1709;

	public Label a1710;

	public Label a1711;

	public Label a1712;

	public Label a1713;

	public TextBox a1714;

	public TextBox a1715;

	public TextBox a1716;

	public TextBox a1717;

	public Label a1718;

	public Panel a1719;

	public Button a1720;

	public Button a1721;

	public Label a1722;

	public Label a1723;

	public Label a1724;

	protected override void Dispose(bool a1725)
	{
		if (a1725 && a1705 != null)
		{
			a1705.Dispose();
		}
		base.Dispose(a1725);
	}

	private void a1726()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(a1740));
		a1707 = new GroupBox();
		a1706 = new PictureBox();
		a1708 = new Label();
		a1709 = new Label();
		a1710 = new Label();
		a1722 = new Label();
		a1723 = new Label();
		a1711 = new Label();
		a1712 = new Label();
		a1713 = new Label();
		a1714 = new TextBox();
		a1715 = new TextBox();
		a1716 = new TextBox();
		a1717 = new TextBox();
		a1718 = new Label();
		a1719 = new Panel();
		a1720 = new Button();
		a1721 = new Button();
		a1724 = new Label();
		a1707.SuspendLayout();
		((ISupportInitialize)a1706).BeginInit();
		a1719.SuspendLayout();
		SuspendLayout();
		a1707.Controls.Add(a1724);
		a1707.Controls.Add(a1706);
		a1707.Controls.Add(a1708);
		a1707.Controls.Add(a1709);
		a1707.Controls.Add(a1710);
		a1707.Controls.Add(a1722);
		a1707.Controls.Add(a1723);
		a1707.Controls.Add(a1711);
		a1707.Controls.Add(a1712);
		a1707.Controls.Add(a1713);
		a1707.Controls.Add(a1714);
		a1707.Controls.Add(a1715);
		a1707.Controls.Add(a1716);
		a1707.Controls.Add(a1717);
		a1707.Controls.Add(a1718);
		a1707.Location = new Point(4, -1);
		a1707.Name = a1739("nźɨͳѵՆ٬ݺ࠰");
		a1707.Size = new Size(505, 388);
		a1707.TabIndex = 2;
		a1707.TabStop = false;
		a1706.Image = a2268.a2321;
		a1706.Location = new Point(8, 46);
		a1706.Name = a1739("{ţɪͼѲմ٠\u0746\u086cॺਰ");
		a1706.Size = new Size(109, 123);
		a1706.TabIndex = 0;
		a1706.TabStop = false;
		a1708.AutoSize = true;
		a1708.Font = new Font(a1739("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a1708.Location = new Point(14, 312);
		a1708.Name = a1739("jŤɦ\u0366Ѯ\u0530");
		a1708.Size = new Size(37, 13);
		a1708.TabIndex = 55;
		a1708.Text = a1739("PŽɢͰ\u0530");
		a1709.BackColor = Color.FromArgb(128, 255, 128);
		a1709.BorderStyle = BorderStyle.Fixed3D;
		a1709.FlatStyle = FlatStyle.Flat;
		a1709.Location = new Point(16, 264);
		a1709.Name = a1739("kŧɧ\u0361ѯԳز");
		a1709.Size = new Size(471, 3);
		a1709.TabIndex = 54;
		a1710.AutoSize = true;
		a1710.Font = new Font(a1739("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a1710.Location = new Point(14, 17);
		a1710.Name = a1739("jŤɦ\u0366ѮԹ");
		a1710.Size = new Size(206, 13);
		a1710.TabIndex = 51;
		a1710.Text = a1739("rņɐ\u0348єվټݼࡲ\u082a\u0a3a\u0b5b౹ఈ\u0e7a\u0f74ၺᅧጣጱᑉᕮᙾᘼᡠᥪ\u1a64\u1b6dᴹᵵἷὩ\u2069Ⅲ≱∰");
		a1722.AutoSize = true;
		a1722.Location = new Point(123, 193);
		a1722.Name = a1739("jŤɦ\u0366ѮԶ");
		a1722.Size = new Size(50, 13);
		a1722.TabIndex = 49;
		a1722.Text = a1739("Cńȥ\u034aѢկ٤");
		a1723.AutoSize = true;
		a1723.Location = new Point(14, 330);
		a1723.Name = a1739("jŤɦ\u0366ѮԵ");
		a1723.Size = new Size(432, 39);
		a1723.TabIndex = 49;
		a1723.Text = componentResourceManager.GetString(a1739("gūɫ\u036dѫԲثݐࡦॺ\u0a75"));
		a1711.AutoSize = true;
		a1711.Location = new Point(123, 151);
		a1711.Name = a1739("jŤɦ\u0366ѮԲ");
		a1711.Size = new Size(54, 13);
		a1711.TabIndex = 49;
		a1711.Text = a1739("\\ŻɢʹХՔ٢ݱࡲ");
		a1712.AutoSize = true;
		a1712.Location = new Point(123, 105);
		a1712.Name = a1739("jŤɦ\u0366ѮԳ");
		a1712.Size = new Size(59, 13);
		a1712.TabIndex = 49;
		a1712.Text = a1739("\\ŻɢʹХՊ٢ݯࡤ");
		a1713.AutoSize = true;
		a1713.Location = new Point(123, 62);
		a1713.Name = a1739("jŤɦ\u0366ѮԷ");
		a1713.Size = new Size(69, 13);
		a1713.TabIndex = 49;
		a1713.Text = a1739("Xůɻ;Ѣմإ\u074aࡢ९\u0a64");
		a1714.Font = new Font(a1739("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 15.75f);
		a1714.Location = new Point(198, 181);
		a1714.Name = a1739("}Űɳ\u0342чՊ٢ݯࡤ");
		a1714.Size = new Size(301, 31);
		a1714.TabIndex = 3;
		a1714.KeyDown += a1737;
		a1715.Font = new Font(a1739("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 15.75f);
		a1715.Location = new Point(198, 139);
		a1715.Name = a1739("\u007fŲɽ\u035dѴգٷݔࡢॱੲ");
		a1715.PasswordChar = '*';
		a1715.Size = new Size(301, 31);
		a1715.TabIndex = 2;
		a1715.KeyDown += a1737;
		a1716.Font = new Font(a1739("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 15.75f);
		a1716.Location = new Point(198, 97);
		a1716.Name = a1739("\u007fŲɽ\u035dѴգٷ\u074aࡢ९\u0a64");
		a1716.Size = new Size(301, 31);
		a1716.TabIndex = 1;
		a1716.KeyDown += a1737;
		a1717.Font = new Font(a1739("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 15.75f);
		a1717.Location = new Point(198, 55);
		a1717.Name = a1739("yŴɿ\u0359Ѭպٱݣࡷ\u094a\u0a62୯\u0c64");
		a1717.Size = new Size(301, 31);
		a1717.TabIndex = 0;
		a1717.KeyDown += a1737;
		a1718.AutoSize = true;
		a1718.Location = new Point(25, 231);
		a1718.Name = a1739("jŤɦ\u0366ѮԴ");
		a1718.Size = new Size(0, 13);
		a1718.TabIndex = 46;
		a1719.BackColor = Color.FromArgb(233, 235, 236);
		a1719.Controls.Add(a1720);
		a1719.Controls.Add(a1721);
		a1719.Dock = DockStyle.Bottom;
		a1719.Location = new Point(0, 396);
		a1719.Name = a1739("vŤɪ\u0366Ѯ\u0530");
		a1719.Size = new Size(518, 37);
		a1719.TabIndex = 3;
		a1720.Dock = DockStyle.Fill;
		a1720.Location = new Point(244, 0);
		a1720.Name = a1739("jųɨ\u0346ѭը٫ݲ");
		a1720.Size = new Size(274, 37);
		a1720.TabIndex = 1;
		a1720.Text = a1739("Â5ɨȳ՞");
		a1720.UseVisualStyleBackColor = true;
		a1720.Click += a1729;
		a1721.Dock = DockStyle.Left;
		a1721.Location = new Point(0, 0);
		a1721.Name = a1739("kżɩ\u034dѤս٧ݧࡵ");
		a1721.Size = new Size(244, 37);
		a1721.TabIndex = 0;
		a1721.Text = a1739("MŤɽ\u0367ѧյ");
		a1721.UseVisualStyleBackColor = true;
		a1721.Click += a1732;
		a1724.AutoSize = true;
		a1724.Location = new Point(14, 244);
		a1724.Name = a1739("jŤɦ\u0366ѮԸ");
		a1724.Size = new Size(296, 13);
		a1724.TabIndex = 56;
		a1724.Text = a1739("\u0017ĥɍ\u0357Нը\u065aݘࡘ\u0956ଆଖ౷ൕ༬ཞၐᅞቛሟᐍᕮᙂᝆᡎ\u1941ᩋ\u1b43᱗ᵍṍὋ\u2001ⅳ≶⍭⑩╹♶✺⡀⧮⩹⭳ⱡ\u2d7d\u2e70⽻みㅹ㉵㍪㑨㕢㘫㘺㡺㥼㩢㭿㱬㵪㹪㽸䀯");
		Appearance.BackColor = Color.White;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(518, 433);
		Controls.Add(a1707);
		Controls.Add(a1719);
		Icon = (Icon)componentResourceManager.GetObject(a1739(".Žɠ\u036eѵԫ\u064dݠ\u086d९"));
		MaximizeBox = false;
		MaximumSize = new Size(534, 472);
		Name = a1739("MŸɤ\u034cхՅ٪ݪࡥ५੦");
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a1739("MŊȧ\u0345Ѫժ٥ݫࡦ");
		a1707.ResumeLayout(performLayout: false);
		a1707.PerformLayout();
		((ISupportInitialize)a1706).EndInit();
		a1719.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public a1740()
	{
		a1726();
		a1984.a1891(this);
		a1733();
	}

	private void a1729(object a1727, EventArgs a1728)
	{
		Close();
	}

	private void a1732(object a1730, EventArgs a1731)
	{
		a1734();
		Close();
	}

	public void a1733()
	{
		a1717.Text = a1344.a1321(a1739("@Žɷ\u0364Ѹկٿݩࡗ\u0944\u0a4c\u0b5e\u0c46൚\u0e5cཁ၎ᅇቊ"), a1739("Uŀɖ\u0355чՓ"));
		a1716.Text = a1344.a1321(a1739("@Žɷ\u0364Ѹկٿݩࡗ\u0944\u0a4c\u0b5e\u0c46൚\u0e5cཁ၎ᅇቊ"), a1739("Oňɂ\u035dыՊل\u074aࡊ\u0941\u0a48"));
		a1715.Text = a1344.a1327(a1344.a1321(a1739("@Žɷ\u0364Ѹկٿݩࡗ\u0944\u0a4c\u0b5e\u0c46൚\u0e5cཁ၎ᅇቊ"), a1739("Cńɖ\u034dхՐل")));
		a1714.Text = a1344.a1321(a1739("@Žɷ\u0364Ѹկٿݩࡗ\u0944\u0a4c\u0b5e\u0c46൚\u0e5cཁ၎ᅇቊ"), a1739("BŇɊ\u0342яՄ"));
	}

	public void a1734()
	{
		a1344.a1325(a1739("@Žɷ\u0364Ѹկٿݩࡗ\u0944\u0a4c\u0b5e\u0c46൚\u0e5cཁ၎ᅇቊ"), a1739("Uŀɖ\u0355чՓ"), a1717.Text);
		a1344.a1325(a1739("@Žɷ\u0364Ѹկٿݩࡗ\u0944\u0a4c\u0b5e\u0c46൚\u0e5cཁ၎ᅇቊ"), a1739("Oňɂ\u035dыՊل\u074aࡊ\u0941\u0a48"), a1716.Text);
		a1344.a1325(a1739("@Žɷ\u0364Ѹկٿݩࡗ\u0944\u0a4c\u0b5e\u0c46൚\u0e5cཁ၎ᅇቊ"), a1739("Cńɖ\u034dхՐل"), a1344.a1329(a1715.Text));
		a1344.a1325(a1739("@Žɷ\u0364Ѹկٿݩࡗ\u0944\u0a4c\u0b5e\u0c46൚\u0e5cཁ၎ᅇቊ"), a1739("BŇɊ\u0342яՄ"), a1714.Text);
		MessageBox.Show(a1739("IŻɯ\u0375ѯջٻݹࡹ\u0827ਵ\u0b50\u0c76\u0c0d\u0e74ར\u1063ᅫቿ፥ᐫᕁᙨ\u1771ᡣᥣ\u1a61\u1b6dᱯᵦṨ"), a1739("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		a1733();
	}

	private void a1737(object a1735, KeyEventArgs a1736)
	{
		if (a1736.KeyCode == Keys.Return)
		{
			a1734();
		}
	}

	private static string a1739(string a1738)
	{
		int length = a1738.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a1738[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
