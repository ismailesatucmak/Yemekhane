using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace a7;

public static class a2147
{
	public static bool a2100(SqlCommand a2099)
	{
		bool flag = false;
		SqlDataReader sqlDataReader = a2099.ExecuteReader();
		flag = (sqlDataReader.HasRows ? true : false);
		sqlDataReader.Close();
		sqlDataReader = null;
		return flag;
	}

	public static bool a2100(string a2101)
	{
		bool flag = false;
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.Parameters.Clear();
		sqlCommand.CommandText = a2101;
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow);
		flag = (sqlDataReader.Read() ? true : false);
		sqlDataReader.Close();
		sqlDataReader = null;
		return flag;
	}

	public static bool a2103(string a2102)
	{
		bool flag = false;
		OleDbCommand oleDbCommand = new OleDbCommand();
		oleDbCommand.Connection = a2172.a2161;
		oleDbCommand.Parameters.Clear();
		oleDbCommand.CommandText = a2102;
		OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader(CommandBehavior.SingleRow);
		flag = (oleDbDataReader.Read() ? true : false);
		oleDbDataReader.Close();
		oleDbDataReader = null;
		return flag;
	}

	public static DataTable a2105(string a2104)
	{
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a2104;
		SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
		DataSet dataSet = new DataSet();
		sqlDataAdapter.Fill(dataSet);
		return dataSet.Tables[0];
	}

	public static DataTable a2107(string a2106)
	{
		OleDbCommand oleDbCommand = new OleDbCommand();
		oleDbCommand.Connection = a2172.a2161;
		oleDbCommand.CommandText = a2106;
		OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
		DataSet dataSet = new DataSet();
		oleDbDataAdapter.Fill(dataSet);
		return dataSet.Tables[0];
	}

	public static SqlDataReader a2109(string a2108)
	{
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a2108;
		return sqlCommand.ExecuteReader();
	}

	public static DataTable a2105(SqlCommand a2110)
	{
		SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(a2110);
		DataSet dataSet = new DataSet();
		sqlDataAdapter.Fill(dataSet);
		return dataSet.Tables[0];
	}

	public static SqlDataReader a2109(SqlCommand a2111)
	{
		return a2111.ExecuteReader();
	}

	public static int a2113(SqlCommand a2112)
	{
		int result = 0;
		SqlDataReader sqlDataReader = a2112.ExecuteReader();
		while (sqlDataReader.Read())
		{
			if (!sqlDataReader.IsDBNull(0))
			{
				result = Convert.ToInt32(sqlDataReader.GetValue(0));
			}
		}
		sqlDataReader.Close();
		sqlDataReader = null;
		return result;
	}

	public static int a2113(string a2114)
	{
		int result = 0;
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a2114;
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		while (sqlDataReader.Read())
		{
			if (!sqlDataReader.IsDBNull(0))
			{
				result = Convert.ToInt32(sqlDataReader.GetValue(0));
			}
		}
		sqlDataReader.Close();
		sqlDataReader = null;
		return result;
	}

	public static DateTime a2116(string a2115)
	{
		DateTime result = DateTime.MinValue.Date;
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a2115;
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		while (sqlDataReader.Read())
		{
			if (!sqlDataReader.IsDBNull(0))
			{
				result = Convert.ToDateTime(sqlDataReader.GetValue(0));
			}
		}
		sqlDataReader.Close();
		sqlDataReader = null;
		return result;
	}

	public static string a2113(SqlCommand a2117, int a2118)
	{
		string result = a2146("");
		SqlDataReader sqlDataReader = a2117.ExecuteReader();
		while (sqlDataReader.Read())
		{
			if (!sqlDataReader.IsDBNull(0))
			{
				result = sqlDataReader.GetValue(0).ToString();
			}
		}
		sqlDataReader.Close();
		sqlDataReader = null;
		return result;
	}

	public static string a2113(string a2119, int a2120)
	{
		string result = a2146("");
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a2119;
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		while (sqlDataReader.Read())
		{
			if (!sqlDataReader.IsDBNull(0))
			{
				result = sqlDataReader.GetValue(0).ToString();
			}
		}
		sqlDataReader.Close();
		sqlDataReader = null;
		return result;
	}

	public static decimal a2122(SqlCommand a2121)
	{
		decimal result = 0m;
		SqlDataReader sqlDataReader = a2121.ExecuteReader();
		if (sqlDataReader.Read())
		{
			try
			{
				result = Convert.ToDecimal(sqlDataReader.GetValue(0));
			}
			catch
			{
			}
		}
		sqlDataReader.Close();
		sqlDataReader = null;
		return result;
	}

	public static decimal a2122(string a2123)
	{
		decimal result = 0m;
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.CommandText = a2123;
		sqlCommand.Connection = a2172.a2160;
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		if (sqlDataReader.Read())
		{
			try
			{
				result = Convert.ToDecimal(sqlDataReader.GetValue(0));
			}
			catch
			{
			}
		}
		sqlDataReader.Close();
		sqlDataReader = null;
		return result;
	}

	public static DateTime a2125(string a2124)
	{
		DateTime result = DateTime.Now.Date;
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.CommandText = a2124;
		sqlCommand.Connection = a2172.a2160;
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		if (sqlDataReader.Read())
		{
			try
			{
				result = Convert.ToDateTime(sqlDataReader.GetValue(0));
			}
			catch
			{
			}
		}
		sqlDataReader.Close();
		sqlDataReader = null;
		return result;
	}

	public static bool a2128(string a2126, string a2127)
	{
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a2126;
		try
		{
			sqlCommand.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			MessageBox.Show(a2146("OŪɶ\u0339ћ\u05ebٻݹࡱॠ\u0a7b\u0b7f\u0c74൪ฮཅ\u106dᅿቫጩᑇᕫᙳᙚᡰ\u1976ᨸᬋ") + ex.Message, a2146("PŽɢͰ\u0530"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return false;
		}
		return true;
	}

	public static a2189 a2128(SqlCommand a2129)
	{
		a2189 result = default;
		try
		{
			a2129.ExecuteNonQuery();
			result.a2182 = false;
		}
		catch (Exception ex)
		{
			result.a2182 = true;
			result.a2180 = a2146("IŨɴ\u0337Ԧճٵݷࡷ\u0962\u0a79ୡ౪൨ฬགྷ\u106bᅽቩጧᑉᕩᙱᙜᡶᥴ");
			result.a2181 = a2146("Aũɳ\u0367ХԾأ܈ࠌ") + ex.Message;
		}
		return result;
	}

	public static object[] a2131(string a2130)
	{
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a2130;
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		object[] array = new object[sqlDataReader.FieldCount];
		while (sqlDataReader.Read())
		{
			for (int i = 0; i < sqlDataReader.FieldCount; i++)
			{
				array[i] = sqlDataReader.GetValue(i);
			}
		}
		sqlDataReader.Close();
		sqlDataReader = null;
		return array;
	}

	public static object[] a2133(string a2132)
	{
		OleDbCommand oleDbCommand = new OleDbCommand();
		oleDbCommand.Connection = a2172.a2161;
		oleDbCommand.CommandText = a2132;
		OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
		object[] array = new object[oleDbDataReader.FieldCount];
		while (oleDbDataReader.Read())
		{
			for (int i = 0; i < oleDbDataReader.FieldCount; i++)
			{
				array[i] = oleDbDataReader.GetValue(i);
			}
		}
		oleDbDataReader.Close();
		oleDbDataReader = null;
		return array;
	}

	public static object[] a2131(SqlCommand a2134)
	{
		SqlDataReader sqlDataReader = a2134.ExecuteReader();
		object[] array = new object[sqlDataReader.FieldCount];
		while (sqlDataReader.Read())
		{
			for (int i = 0; i < sqlDataReader.FieldCount; i++)
			{
				array[i] = sqlDataReader.GetValue(i);
			}
		}
		sqlDataReader.Close();
		sqlDataReader = null;
		return array;
	}

	public static void a2137(string a2135, ref object[] a2136)
	{
		for (int i = 0; i < a2136.Length; i++)
		{
			if (a2136[i].GetType() == typeof(DateTime))
			{
				a2136[i] = DateTime.Now;
			}
			if (a2136[i].GetType() == typeof(decimal))
			{
				a2136[i] = 0;
			}
			if (a2136[i].GetType() == typeof(int))
			{
				a2136[i] = 0;
			}
			if (a2136[i].GetType() == typeof(string))
			{
				a2136[i] = a2146("");
			}
		}
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a2135;
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		while (sqlDataReader.Read())
		{
			for (int i = 0; i < sqlDataReader.FieldCount; i++)
			{
				a2136[i] = sqlDataReader.GetValue(i);
			}
		}
		sqlDataReader.Close();
		sqlDataReader = null;
	}

	public static bool a2139(string a2138)
	{
		bool flag = false;
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.Parameters.Clear();
		sqlCommand.CommandText = a2146("pŧɭ\u0365ќՊؽ\u0736࠻ड़\u0a4b\u0b57ౚശแབ\u105fᅁቅ\u135fᑄᕝᙏᜬᡜ\u1942ᩌ᭚᱂ᴦṎὋ⁇ℿ∦") + a2138 + a2146("&");
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		flag = (sqlDataReader.Read() ? true : false);
		sqlDataReader.Close();
		sqlDataReader = null;
		return flag;
	}

	public static void a2141(string a2140)
	{
	}

	public static a2189 a2144(object[,] a2142, string a2143)
	{
		a2189 result = new a2189
		{
			a2182 = true,
			a2181 = a2146("Mŧɡ\u0365ѥէ٬ݱࡢ२ਥ\u0b4c\u0c62൶\u0e60")
		};
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a2143;
		sqlCommand.Parameters.Clear();
		for (int i = 0; i < a2142.Length / 2; i++)
		{
			if (a2142[i, 1].GetType() == typeof(int))
			{
				sqlCommand.Parameters.Add(a2142[i, 0].ToString(), SqlDbType.Int).Value = a2142[i, 1];
			}
			if (a2142[i, 1].GetType() == typeof(decimal))
			{
				sqlCommand.Parameters.Add(a2142[i, 0].ToString(), SqlDbType.Decimal).Value = a2142[i, 1];
			}
			if (a2142[i, 1].GetType() == typeof(string))
			{
				sqlCommand.Parameters.Add(a2142[i, 0].ToString(), SqlDbType.VarChar).Value = a2142[i, 1];
			}
			if (a2142[i, 1].GetType() == typeof(DateTime))
			{
				sqlCommand.Parameters.Add(a2142[i, 0].ToString(), SqlDbType.DateTime).Value = a2142[i, 1];
			}
		}
		try
		{
			sqlCommand.ExecuteNonQuery();
			result.a2182 = false;
		}
		catch (Exception ex)
		{
			result.a2182 = true;
			result.a2181 = a2146("OŪɶ\u0339Ԩձٷݱࡱॠ\u0a7b\u0b7f\u0c74൪ฮཅ\u106dᅿቫጩᑇᕫᙳᙚᡰ\u1976ᨈᬌ") + ex.Message;
		}
		return result;
	}

	private static string a2146(string a2145)
	{
		int length = a2145.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a2145[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
