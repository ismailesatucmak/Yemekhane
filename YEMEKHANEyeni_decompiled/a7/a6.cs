using System;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;

namespace a7;

internal static class a6
{
	[STAThread]
	private static void a3()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		SkinManager.Default.RegisterAssembly(typeof(SkinProject2).Assembly);
		Application.Run(new a426());
	}

	private static string a5(string a4)
	{
		int length = a4.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a4[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
