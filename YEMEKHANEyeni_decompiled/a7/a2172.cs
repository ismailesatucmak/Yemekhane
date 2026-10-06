using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace a7;

public static class a2172
{
	[CompilerGenerated]
	private static string a2150;

	[CompilerGenerated]
	private static string a2151;

	[CompilerGenerated]
	private static string a2152;

	[CompilerGenerated]
	private static string a2153;

	[CompilerGenerated]
	private static SqlConnection a2154;

	[CompilerGenerated]
	private static OleDbConnection a2155;

	public static string a2156
	{
		[CompilerGenerated]
		get
		{
			return a2150;
		}
		[CompilerGenerated]
		set
		{
			a2150 = value;
		}
	}

	public static string a2157
	{
		[CompilerGenerated]
		get
		{
			return a2151;
		}
		[CompilerGenerated]
		set
		{
			a2151 = value;
		}
	}

	public static string a2158
	{
		[CompilerGenerated]
		get
		{
			return a2152;
		}
		[CompilerGenerated]
		set
		{
			a2152 = value;
		}
	}

	public static string a2159
	{
		[CompilerGenerated]
		get
		{
			return a2153;
		}
		[CompilerGenerated]
		set
		{
			a2153 = value;
		}
	}

	public static SqlConnection a2160
	{
		[CompilerGenerated]
		get
		{
			return a2154;
		}
		[CompilerGenerated]
		set
		{
			a2154 = value;
		}
	}

	public static OleDbConnection a2161
	{
		[CompilerGenerated]
		get
		{
			return a2155;
		}
		[CompilerGenerated]
		set
		{
			a2155 = value;
		}
	}

	public static a2189 a2168()
	{
		a2189 result = default;
		if (a2160 == null)
		{
			a2160 = new SqlConnection();
		}
		if (a2160.State == ConnectionState.Open)
		{
			a2160.Close();
		}
		try
		{
			a2160.ConnectionString = a2171("tţɷͲѦհؼ") + a2157 + a2171(">űɪ\u0366м") + a2158 + a2171(">Ŵɴ\u0366м") + a2159 + a2171("1ŭɩͳѧէ٥ݰࡧ\u093c") + a2156;
		}
		catch
		{
			a1740 a2250 = new a1740();
			a2250.ShowDialog();
			a1344.a1334();
			a2160.ConnectionString = a2171("tţɷͲѦհؼ") + a2157 + a2171(">űɪ\u0366м") + a2158 + a2171(">Ŵɴ\u0366м") + a2159 + a2171("1ŭɩͳѧէ٥ݰࡧ\u093c") + a2156;
		}
		try
		{
			a2160.Open();
		}
		catch (Exception ex)
		{
			result.a2182 = true;
			result.a2179 = 0;
			result.a2180 = a2171("\u007fŎɘ\u035fэՕه܅ࡦ\u0942ଽ\u0b4d\u0c41൱༯\u0f6fၷᅾቴጹᑙᑈᙷᘊ\u1925\u1977\u1a73᭺ᱹᴯṆὬ⁸Ⅺ∪⍆⑤╲❙❱⡱⤣⨸⬡");
			result.a2181 = ex.Message;
			return result;
		}
		return result;
	}

	public static SqlTransaction a2169()
	{
		return a2160.BeginTransaction();
	}

	private static string a2171(string a2170)
	{
		int length = a2170.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a2170[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
