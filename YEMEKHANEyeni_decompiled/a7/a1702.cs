using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace a7;

public class a1702 : XtraForm
{
	private IContainer a1696 = null;

	private LabelControl a1697;

	public a1702()
	{
		a1699();
	}

	protected override void Dispose(bool a1698)
	{
		if (a1698 && a1696 != null)
		{
			a1696.Dispose();
		}
		base.Dispose(a1698);
	}

	private void a1699()
	{
		a1697 = new LabelControl();
		SuspendLayout();
		a1697.Location = new Point(301, 97);
		a1697.Name = a1701("aŭɩ\u036fѥՋ٨ݨࡱॶ੬୮ర");
		a1697.Size = new Size(218, 26);
		a1697.TabIndex = 0;
		a1697.Text = a1701("gŘɑ\u035eёՑ\u0659ݙࡓकਛଓ\u0c75ൔ໗ཆᅱᄍቧፄᑄᕝᙚᝈᡊᤅ\u1a6b᭗ᱍᵌṁὬ\u2067ⅲ≲⍮\u243a┫☨✦⠣⤘⨞⭤ⱥⵦ⸾⽠まㅬ㉧㍲㑫㕳㙡㝫㡯㥨㨪㭠㱭㵬");
		Appearance.BackColor = Color.White;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(531, 135);
		Controls.Add(a1697);
		KeyPreview = true;
		Name = a1701("MŸɤ\u0340Ѧխٮݭ\u086d०\u0a60");
		ShowIcon = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a1701("}ņɏ\u0344ыշٿݳࡹ\u093bਵହ\u0c5f൲\u0ef1\u0f7cᅋᄳ\u1259\u137eᑾᕻᙼᝢᡠ\u192bᩅ᭽ᱧᵪṧὶ⁽Ⅼ≬⍴");
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private static string a1701(string a1700)
	{
		int length = a1700.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a1700[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
