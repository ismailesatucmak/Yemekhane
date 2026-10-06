using System.Runtime.CompilerServices;

namespace a7;

public struct a2189
{
	[CompilerGenerated]
	private int a2175;

	[CompilerGenerated]
	private string a2176;

	[CompilerGenerated]
	private string a2177;

	[CompilerGenerated]
	private bool a2178;

	public int a2179
	{
		[CompilerGenerated]
		get
		{
			return a2175;
		}
		[CompilerGenerated]
		set
		{
			a2175 = value;
		}
	}

	public string a2180
	{
		[CompilerGenerated]
		get
		{
			return a2176;
		}
		[CompilerGenerated]
		set
		{
			a2176 = value;
		}
	}

	public string a2181
	{
		[CompilerGenerated]
		get
		{
			return a2177;
		}
		[CompilerGenerated]
		set
		{
			a2177 = value;
		}
	}

	public bool a2182
	{
		[CompilerGenerated]
		get
		{
			return a2178;
		}
		[CompilerGenerated]
		set
		{
			a2178 = value;
		}
	}

	private static string a2188(string a2187)
	{
		int length = a2187.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a2187[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
