using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using a7.a2096;

namespace a7.a2267;

public class a2266 : XtraForm
{
	private IContainer a2252 = null;

	public System.Windows.Forms.ComboBox a2253;

	public Label a2254;

	public Button a2255;

	public System.Windows.Forms.ComboBox a2256;

	public bool a2257 = false;

	public int a2258 = 0;

	protected override void Dispose(bool a2259)
	{
		if (a2259 && a2252 != null)
		{
			a2252.Dispose();
		}
		base.Dispose(a2259);
	}

	private void a2260()
	{
		a2253 = new System.Windows.Forms.ComboBox();
		a2254 = new Label();
		a2255 = new Button();
		a2256 = new System.Windows.Forms.ComboBox();
		SuspendLayout();
		a2253.DropDownStyle = ComboBoxStyle.DropDownList;
		a2253.Font = new Font(a2265("RŤɬ\u036cѯՠ"), 15.25f);
		a2253.FormattingEnabled = true;
		a2253.Location = new Point(1, 29);
		a2253.Name = a2265("oũɓͼѣի٣ݨࡡ\u094e੧୳");
		a2253.Size = new Size(347, 32);
		a2253.TabIndex = 5;
		a2254.AutoSize = true;
		a2254.Enabled = false;
		a2254.Location = new Point(0, 9);
		a2254.Name = a2265("jŤɦ\u0366ѮԶ");
		a2254.Size = new Size(85, 13);
		a2254.TabIndex = 50;
		a2254.Text = a2265("IŦɷ\u0368ѯծܕݠࠨ\u094a\u0a63୷౯൦\u0e78ཨ");
		a2255.Dock = DockStyle.Bottom;
		a2255.Font = new Font(a2265("RŤɬ\u036cѯՠ"), 12.25f);
		a2255.Image = a2268.a2294;
		a2255.ImageAlign = ContentAlignment.MiddleLeft;
		a2255.Location = new Point(0, 66);
		a2255.Name = a2265("eųɱͰѬլس");
		a2255.Size = new Size(348, 67);
		a2255.TabIndex = 51;
		a2255.Text = a2265("Qťɮ\u0363Ѭ");
		a2255.UseVisualStyleBackColor = true;
		a2255.Click += a2263;
		a2256.DropDownStyle = ComboBoxStyle.DropDownList;
		a2256.Font = new Font(a2265("RŤɬ\u036cѯՠ"), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a2256.FormattingEnabled = true;
		a2256.Location = new Point(150, 129);
		a2256.Name = a2265("můɕ;ѡե٭ݪࡣ\u0948\u0a61ୱ\u0c4b\u0d45");
		a2256.Size = new Size(34, 26);
		a2256.TabIndex = 63;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(348, 133);
		Controls.Add(a2255);
		Controls.Add(a2254);
		Controls.Add(a2253);
		Controls.Add(a2256);
		MaximumSize = new Size(364, 172);
		MinimumSize = new Size(364, 172);
		Name = a2265("WŢɢ\u0357Ѥյٮݩ\u086c९੮\u0b4bౠ൶\u0e68ཧၻ");
		ShowIcon = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a2265("@űɮͳѶձ܌ݻ࠱ढ़੪\u0b7c౦൩\u0e71ལဩᅌቢሙᑬᑛᙷᝫᡳ");
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public a2266()
	{
		a2260();
		a1984.a1964(a2265("rťɓ\u035bўՈػݓ\u085dऴ\u0a56\u0b52\u0c5cഴ๕ཀ\u105eᅝሯፗᑘᕇᙇᝏᡄ᥍\u1a58ᭋ᱀ᵖṈ\u1f47⁛"), a2256, a2253);
	}

	private void a2263(object a2261, EventArgs a2262)
	{
		a2257 = true;
		a2256.SelectedIndex = a2253.SelectedIndex;
		a2258 = Convert.ToInt32(a2256.Text);
		Close();
	}

	private static string a2265(string a2264)
	{
		int length = a2264.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a2264[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
