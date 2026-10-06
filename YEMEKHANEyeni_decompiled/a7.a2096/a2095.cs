using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace a7.a2096;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
internal sealed class a2095 : ApplicationSettingsBase
{
	private static a2095 a2089 = (a2095)SettingsBase.Synchronized(new a2095());

	public static a2095 a2090 => a2089;

	[DebuggerNonUserCode]
	[DefaultSettingValue("0, 0")]
	[UserScopedSetting]
	public Point a2091
	{
		get
		{
			return (Point)this[a2094("TţɱͰѪլ٦")];
		}
		set
		{
			this[a2094("TţɱͰѪլ٦")] = value;
		}
	}

	private static string a2094(string a2093)
	{
		int length = a2093.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a2093[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
