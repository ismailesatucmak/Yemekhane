using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace a7;

public class a2006 : XtraForm
{
	public Color a1987;

	public XtraForm a1988;

	public int a1989;

	private IContainer a1990 = null;

	public a2006(XtraForm a1991)
	{
		a2003();
		a1989 = 70;
		a1987 = Color.Black;
		a1988 = a1991;
	}

	public a2006(XtraForm a1992, Color a1993)
	{
		a2003();
		a1989 = 70;
		a1987 = Color.Black;
		a1988 = a1992;
		a1987 = a1993;
	}

	public a2006(XtraForm a1994, int a1995)
	{
		a2003();
		a1989 = 70;
		a1987 = Color.Black;
		a1989 = a1995;
		a1988 = a1994;
	}

	public a2006(XtraForm a1996, int a1997, Color a1998)
	{
		a2003();
		a1989 = 70;
		a1987 = Color.Black;
		a1989 = a1997;
		a1987 = a1998;
		a1988 = a1996;
	}

	private void a2001(object a1999, EventArgs a2000)
	{
		double opacity = (double)a1989 / 100.0;
		BackColor = a1987;
		Opacity = opacity;
		TopMost = false;
		a1988.StartPosition = FormStartPosition.CenterScreen;
		MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
		WindowState = FormWindowState.Maximized;
		a1988.ShowDialog();
		Close();
	}

	protected override void Dispose(bool a2002)
	{
		if (a2002 && a1990 != null)
		{
			a1990.Dispose();
		}
		base.Dispose(a2002);
	}

	private void a2003()
	{
		SuspendLayout();
		Appearance.BackColor = Color.Black;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(394, 210);
		FormBorderStyle = FormBorderStyle.None;
		Name = a2005("JŹɧ\u034bѤզ٥ݮࡆ\u0962\u0a61୪");
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a2005("JŹɧ\u034bѤզ٥ݮࡆ\u0962\u0a61୪");
		Shown += a2001;
		ResumeLayout(performLayout: false);
	}

	private static string a2005(string a2004)
	{
		int length = a2004.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a2004[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
