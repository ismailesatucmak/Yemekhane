using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using a7.a2096;

namespace a7;

public class a1173 : XtraForm
{
	private IContainer a1129 = null;

	private Label a1130;

	private Button a1131;

	private Button a1132;

	private PictureBox a1133;

	private PictureBox a1134;

	public TextBox a1135;

	private Label a1136;

	private CheckBox a1137;

	private CheckBox a1138;

	private CheckBox a1139;

	public bool a1140 = false;

	public bool a1141 = false;

	public bool a1142 = false;

	public bool a1143 = false;

	protected override void Dispose(bool a1144)
	{
		if (a1144 && a1129 != null)
		{
			a1129.Dispose();
		}
		base.Dispose(a1144);
	}

	private void a1145()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(a1173));
		a1135 = new TextBox();
		a1130 = new Label();
		a1131 = new Button();
		a1132 = new Button();
		a1133 = new PictureBox();
		a1134 = new PictureBox();
		a1136 = new Label();
		a1137 = new CheckBox();
		a1138 = new CheckBox();
		a1139 = new CheckBox();
		((ISupportInitialize)a1133).BeginInit();
		((ISupportInitialize)a1134).BeginInit();
		SuspendLayout();
		a1135.Enabled = false;
		a1135.Font = new Font(a1172("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 24f);
		a1135.Location = new Point(92, 71);
		a1135.Name = a1172("|ſɲ\u0351ѱշ٣ݳ");
		a1135.RightToLeft = RightToLeft.Yes;
		a1135.Size = new Size(268, 44);
		a1135.TabIndex = 1;
		a1135.Tag = a1172("G");
		a1135.Text = a1172("4įȲ\u0331");
		a1130.AutoSize = true;
		a1130.Font = new Font(a1172("RŤɬ\u036cѯՠ"), 24f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1130.Location = new Point(105, 29);
		a1130.Name = a1172("jŤɦ\u0366Ѯ\u0530");
		a1130.Size = new Size(245, 39);
		a1130.TabIndex = 0;
		a1130.Text = a1172("Xńɚ\u0345щՊئݑࡑ\u0957\u0a43\u0b53");
		a1131.Location = new Point(168, 115);
		a1131.Name = a1172("jųɨ\u0351ѥծ٣ݬ");
		a1131.Size = new Size(193, 45);
		a1131.TabIndex = 3;
		a1131.Text = a1172("Rģɥ\u036eѣլ");
		a1131.UseVisualStyleBackColor = true;
		a1131.Click += a1149;
		a1132.Location = new Point(91, 115);
		a1132.Name = a1172("jųɨ\u034cѴշ٣ݭ");
		a1132.Size = new Size(78, 45);
		a1132.TabIndex = 4;
		a1132.Text = a1172("ĵŴɷ\u0363ѭ");
		a1132.UseVisualStyleBackColor = true;
		a1132.Click += a1152;
		a1133.Image = a2268.a2327;
		a1133.Location = new Point(366, 82);
		a1133.Name = a1172("{ţɪͼѲմ٠\u0746\u086cॺਰ");
		a1133.Size = new Size(23, 24);
		a1133.TabIndex = 3;
		a1133.TabStop = false;
		a1134.Image = (Image)componentResourceManager.GetObject(a1172("aŹɬͺѸվٮ\u0748ࡦ॰ਵନ\u0c4c൩\u0e62ཥ\u1064"));
		a1134.Location = new Point(-17, 50);
		a1134.Name = a1172("{ţɪͼѲմ٠\u0746\u086cॺਲ਼");
		a1134.Size = new Size(1356, 760);
		a1134.TabIndex = 4;
		a1134.TabStop = false;
		a1136.AutoSize = true;
		a1136.Font = new Font(a1172("RŤɬ\u036cѯՠ"), 24f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1136.ForeColor = Color.DeepPink;
		a1136.Location = new Point(1, -1);
		a1136.Name = a1172("jŧɋ\u0364ѷկ");
		a1136.Size = new Size(0, 39);
		a1136.TabIndex = 1;
		a1137.AutoSize = true;
		a1137.BackColor = Color.Transparent;
		a1137.Font = new Font(a1172("RŤɬ\u036cѯՠ"), 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a1137.Location = new Point(169, 179);
		a1137.Name = a1172("hŢɏ\u0361Ѵ՟٤ݾࡧ५ੳ");
		a1137.Size = new Size(148, 20);
		a1137.TabIndex = 6;
		a1137.Text = a1172("UŻ\u034e\u0330іկٷݨ\u093aॸ\u0a29ଠ\u0c49൩\u0e77ཀྵ\u1062ᅮረ");
		a1137.UseVisualStyleBackColor = false;
		a1137.Visible = false;
		a1137.CheckedChanged += a1158;
		a1138.AutoSize = true;
		a1138.BackColor = Color.Transparent;
		a1138.Font = new Font(a1172("RŤɬ\u036cѯՠ"), 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a1138.Location = new Point(169, 160);
		a1138.Name = a1172("wŻɔ\u0378ѣՖٯݷࡨ\u0962\u0a78\u0b4d౧൳\u0e4bཤၰᅱቫ፹");
		a1138.Size = new Size(172, 20);
		a1138.TabIndex = 5;
		a1138.Text = a1172("Qſ\u034a\u0334ъճ٫ݴ\u093eॼਭତ\u0c4f\u0d65\u0e7d༨၊ᅧቱ፶ᑪᕺᘨ");
		a1138.UseVisualStyleBackColor = false;
		a1138.Visible = false;
		a1138.CheckedChanged += a1161;
		a1139.AutoSize = true;
		a1139.BackColor = Color.Transparent;
		a1139.Font = new Font(a1172("RŤɬ\u036cѯՠ"), 7f, FontStyle.Bold);
		a1139.Location = new Point(184, 198);
		a1139.Name = a1172("dŮɁ\u036dѱէ٪");
		a1139.Size = new Size(88, 16);
		a1139.TabIndex = 7;
		a1139.Text = a1172("HŢɸ\u036cѣԧ\u065fݤࡾ१ଳ୳");
		a1139.UseVisualStyleBackColor = false;
		a1139.Visible = false;
		a1139.CheckedChanged += a1164;
		Appearance.BackColor = Color.White;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(475, 209);
		Controls.Add(a1138);
		Controls.Add(a1139);
		Controls.Add(a1137);
		Controls.Add(a1133);
		Controls.Add(a1132);
		Controls.Add(a1131);
		Controls.Add(a1136);
		Controls.Add(a1130);
		Controls.Add(a1135);
		Controls.Add(a1134);
		MaximizeBox = false;
		MinimizeBox = false;
		Name = a1172("Kžɦ\u035eѼռ٦ݴࡕ॥੭୧౭");
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a1172("Oš\u033d\u0365ѫժ٩ݬ\u0826\u0951\u0a71୷\u0c63൳");
		Load += a1167;
		Shown += a1170;
		KeyDown += a1155;
		((ISupportInitialize)a1133).EndInit();
		((ISupportInitialize)a1134).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public a1173(string a1146)
	{
		a1145();
		if (a1344.a1321(a1172("IŶɾ\u0363ѡմ٦ݶࡎय़\u0a55\u0b59\u0c4f\u0d51๕ཎ၇ᅌቃ\u135bᑀᕌᙗ\u175aᡃᥛ"), a1172("@Ōɗ\u035aу՛")) == a1172("0"))
		{
			a1137.Checked = true;
		}
		else
		{
			a1137.Checked = false;
		}
		if (a1344.a1321(a1172("Nųɽ\u036eѮչ٥ݳࡉग़\u0a56\u0b44\u0c50\u0d4c๖ཋ၀ᅉቀፖᑏᕁᙔ\u175fᡄᥞᩇ\u1b4d᱕"), a1172("OŁɔ\u035fф՞هݍࡕ")) == a1172("0"))
		{
			a1138.Checked = true;
		}
		else
		{
			a1138.Checked = false;
		}
		if (a1344.a1321(a1172("OŴɼ\u036dѯն٤ݰࡈढ़\u0a57\u0b47\u0c51\u0d53๗\u0f48၁ᅎቁፕᑌᕎᙔᝀᡏᥚᩃ᭛"), a1172("LŎɔ\u0340я՚كݛ")) == a1172("0"))
		{
			a1139.Checked = true;
		}
		else
		{
			a1139.Checked = false;
		}
		a1344.a1337(Controls);
		a1984.a1891(this);
		a1136.Text = a1146;
	}

	private void a1149(object a1147, EventArgs a1148)
	{
		a1140 = true;
		if (a1137.Checked)
		{
			a1141 = true;
		}
		if (a1138.Checked)
		{
			a1142 = true;
		}
		if (a1139.Checked)
		{
			a1143 = true;
		}
		Close();
	}

	private void a1152(object a1150, EventArgs a1151)
	{
		a1140 = false;
		Close();
	}

	private void a1155(object a1153, KeyEventArgs a1154)
	{
		if (a1154.KeyCode == Keys.Return)
		{
			a1140 = true;
			if (a1137.Checked)
			{
				a1141 = true;
			}
			if (a1138.Checked)
			{
				a1142 = true;
			}
			Close();
		}
	}

	private void a1158(object a1156, EventArgs a1157)
	{
		if (a1137.Checked)
		{
			a1344.a1325(a1172("IŶɾ\u0363ѡմ٦ݶࡎय़\u0a55\u0b59\u0c4f\u0d51๕ཎ၇ᅌቃ\u135bᑀᕌᙗ\u175aᡃᥛ"), a1172("@Ōɗ\u035aу՛"), a1172("0"));
			a1138.Checked = false;
		}
		else
		{
			a1344.a1325(a1172("IŶɾ\u0363ѡմ٦ݶࡎय़\u0a55\u0b59\u0c4f\u0d51๕ཎ၇ᅌቃ\u135bᑀᕌᙗ\u175aᡃᥛ"), a1172("@Ōɗ\u035aу՛"), a1172("1"));
		}
	}

	private void a1161(object a1159, EventArgs a1160)
	{
		if (a1138.Checked)
		{
			a1344.a1325(a1172("Nųɽ\u036eѮչ٥ݳࡉग़\u0a56\u0b44\u0c50\u0d4c๖ཋ၀ᅉቀፖᑏᕁᙔ\u175fᡄᥞᩇ\u1b4d᱕"), a1172("OŁɔ\u035fф՞هݍࡕ"), a1172("0"));
			a1137.Checked = false;
		}
		else
		{
			a1344.a1325(a1172("Nųɽ\u036eѮչ٥ݳࡉग़\u0a56\u0b44\u0c50\u0d4c๖ཋ၀ᅉቀፖᑏᕁᙔ\u175fᡄᥞᩇ\u1b4d᱕"), a1172("OŁɔ\u035fф՞هݍࡕ"), a1172("1"));
		}
	}

	private void a1164(object a1162, EventArgs a1163)
	{
		if (a1139.Checked)
		{
			a1344.a1325(a1172("OŴɼ\u036dѯն٤ݰࡈढ़\u0a57\u0b47\u0c51\u0d53๗\u0f48၁ᅎቁፕᑌᕎᙔᝀᡏᥚᩃ᭛"), a1172("LŎɔ\u0340я՚كݛ"), a1172("0"));
		}
		else
		{
			a1344.a1325(a1172("OŴɼ\u036dѯն٤ݰࡈढ़\u0a57\u0b47\u0c51\u0d53๗\u0f48၁ᅎቁፕᑌᕎᙔᝀᡏᥚᩃ᭛"), a1172("LŎɔ\u0340я՚كݛ"), a1172("1"));
		}
	}

	private void a1167(object a1165, EventArgs a1166)
	{
	}

	private void a1170(object a1168, EventArgs a1169)
	{
		a1131.Focus();
	}

	private static string a1172(string a1171)
	{
		int length = a1171.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a1171[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
