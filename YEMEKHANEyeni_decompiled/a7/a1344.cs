using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.Win32;

namespace a7;

public static class a1344
{
	public struct SystemTime
	{
		public short Year;

		public short Month;

		public short DayOfWeek;

		public short Day;

		public short Hour;

		public short Minute;

		public short Second;

		public short Millisecond;
	}

	public class CUSTUMERINFO
	{
		public int ID;

		public string TCKIMLIK;

		public string ADSOYAD;

		public string KARTNOHEX;

		public int MERKEZID;

		public decimal BAKIYE;

		public decimal SONDUSENMIKTAR;

		public DateTime TARIHSAAT;

		public int BLOKE;

		public int AKTIF;

		public long KARTGRUPID;

		public string KARTDURUM;

		public decimal FIYAT;

		public bool KAYITLIMI;

		public int SINIF;

		public string BOLUM;

		public CUSTUMERINFO()
		{
			ID = -1;
			TCKIMLIK = "";
			ADSOYAD = "";
			KARTNOHEX = "";
			MERKEZID = -1;
			BAKIYE = 0m;
			SONDUSENMIKTAR = 0m;
			TARIHSAAT = DateTime.Now;
			BLOKE = 0;
			AKTIF = 0;
			KARTGRUPID = 0L;
			KARTDURUM = "";
			FIYAT = 0m;
			KAYITLIMI = false;
			BOLUM = "";
			SINIF = 0;
		}

		public void Getir()
		{
			if (a2147.a2100("SELECT ID FROM KISILER WHERE KARTNOHEX='" + KARTNOHEX + "'"))
			{
				KAYITLIMI = true;
			}
			else
			{
				KAYITLIMI = false;
			}
			a1307();
			a1271.CommandText = " SELECT TOP 1 T1.ID,T1.TCKIMLIK,T1.ADSOYAD,T1.KARTNOHEX,T1.YUKLEME_MERKEZ_ID, T1.BAKIYE,T1.TARIHSAAT,T1.SON_DUSEN_MIKTAR,T1.BLOKE,T1.AKTIF,T1.KART_GRUP, KARTDURUM=(SELECT KART_DURUM FROM KART_GRUP WHERE ID=T1.KART_GRUP), FIYAT=(SELECT FIYAT FROM KART_GRUP WHERE ID=T1.KART_GRUP), T1.BOLUM,T1.SINIF  FROM KISILER T1 WHERE T1.KARTNOHEX=@KARTNOHEX ";
			a1271.Parameters.Add("KARTNOHEX", SqlDbType.VarChar).Value = KARTNOHEX;
			DataTable dataTable = a2147.a2105(a1271);
			if (dataTable.Rows.Count > 0)
			{
				ID = Convert.ToInt32(dataTable.Rows[0]["ID"]);
				TCKIMLIK = dataTable.Rows[0]["TCKIMLIK"].ToString();
				ADSOYAD = dataTable.Rows[0]["ADSOYAD"].ToString();
				KARTNOHEX = dataTable.Rows[0]["KARTNOHEX"].ToString();
				BOLUM = dataTable.Rows[0]["BOLUM"].ToString();
				SINIF = Convert.ToInt32(dataTable.Rows[0]["SINIF"]);
				MERKEZID = Convert.ToInt32(dataTable.Rows[0]["YUKLEME_MERKEZ_ID"]);
				BAKIYE = Convert.ToDecimal(dataTable.Rows[0]["BAKIYE"]);
				SONDUSENMIKTAR = Convert.ToDecimal(dataTable.Rows[0]["SON_DUSEN_MIKTAR"]);
				BLOKE = Convert.ToInt32(dataTable.Rows[0]["BLOKE"]);
				AKTIF = Convert.ToInt32(dataTable.Rows[0]["AKTIF"]);
				KARTGRUPID = Convert.ToInt32(dataTable.Rows[0]["KART_GRUP"]);
				KARTDURUM = dataTable.Rows[0]["KARTDURUM"].ToString();
				FIYAT = Convert.ToDecimal(dataTable.Rows[0]["FIYAT"]);
			}
		}
	}

	public static bool a1269 = false;

	public static string a1270 = a1343("Hœɖ\u0330");

	public static SqlCommand a1271;

	public static long a1272;

	public static int a1273 = 100;

	public static int a1274 = 1;

	public static int a1275 = 500;

	public static int a1276 = 0;

	public static int a1277 = 1;

	public static int a1278 = 1;

	public static int a1279 = 1;

	public static PrivateFontCollection a1280 = new PrivateFontCollection();

	public static string a1281;

	public static string a1282;

	public static int a1283;

	public static string a1284;

	public static bool a1285;

	public static bool a1286;

	public static bool a1287;

	private static FontFamily a1288 = a1338();

	[DllImport("ACRKart.dll", EntryPoint = "GetirKartNo")]
	public static extern long a1289();

	[DllImport("ACRKart.dll", EntryPoint = "GetirKartNo2")]
	public static extern long a1290();

	[DllImport("ACRKart.dll", EntryPoint = "GetirKartNo3")]
	public static extern long a1291();

	[DllImport("ACRKart.dll", EntryPoint = "GetirKartNo4")]
	public static extern long a1292();

	[DllImport("kernel32.dll", EntryPoint = "SetSystemTime", SetLastError = true)]
	public static extern bool a1294(ref SystemTime a1293);

	public static string a1296(string a1295)
	{
		a1295 = a1295.Replace(a1343("ğ"), a1343("F"));
		a1295 = a1295.Replace(a1343("ş"), a1343("R"));
		a1295 = a1295.Replace(a1343("ı"), a1343("H"));
		a1295 = a1295.Replace(a1343("Æ"), a1343("B"));
		a1295 = a1295.Replace(a1343("Ý"), a1343("T"));
		a1295 = a1295.Replace(a1343("×"), a1343("N"));
		a1295 = a1295.Replace(a1343("Ğ"), a1343("f"));
		a1295 = a1295.Replace(a1343("Ş"), a1343("r"));
		a1295 = a1295.Replace(a1343("İ"), a1343("h"));
		a1295 = a1295.Replace(a1343("æ"), a1343("b"));
		a1295 = a1295.Replace(a1343("ý"), a1343("t"));
		a1295 = a1295.Replace(a1343("÷"), a1343("n"));
		return a1295;
	}

	public static void a1302(int a1297, int a1298, int a1299, int a1300, int a1301)
	{
		SystemTime a2250 = new SystemTime
		{
			Year = (short)a1297,
			Month = (short)a1298,
			Day = (short)a1299,
			Minute = (short)a1301
		};
		a1294(ref a2250);
	}

	public static string a1303()
	{
		string text = a1343("");
		string text2 = a1343("");
		text = a1289().ToString(a1343("ZĹ"));
		if (text == a1343("8ķȶ\u0335дԳز\u0731"))
		{
			text = a1290().ToString(a1343("ZĹ"));
		}
		if (text == a1343("8ķȶ\u0335дԳز\u0731"))
		{
			text = a1291().ToString(a1343("ZĹ"));
		}
		if (text == a1343("8ķȶ\u0335дԳز\u0731"))
		{
			text = a1292().ToString(a1343("ZĹ"));
		}
		int num;
		for (num = text.Length - 1; num > 0; num--)
		{
			text2 = text2 + text[num - 1] + text[num];
			num--;
		}
		if (text2 == a1343(">Ĵȶ\u0335дԳز\u0731"))
		{
			text2 = a1343("8ķȶ\u0335дԳز\u0731");
		}
		return text2;
	}

	public static bool a1304()
	{
		a1307();
		a1271.CommandText = a1343("sāȔ\u031cЊԍ\u0619ݬ\u081fअਙ୨\u0c76൦ต༅မᄃሓ፬ᑯᕿᙧ\u177dᡩ\u196e\u1a7c\u1b6b᱾ᴚṦήⁿⅻ∝⍳⑮╼♾❭⡦⥨⩨⬄ⱷⵣ\u2e77⽷てㅯ㉣㍥㐳㕝㙈㝑㡚㤶㩚㭍㱚㵗㹇㽀䁖䅁䉘䌰䑉䕜䙂䝁䠫䥚䩈䭚䱆䵋乀佐偑兇刡");
		DataTable dataTable = a2147.a2105(a1271);
		if (dataTable.Rows.Count > 0)
		{
			int dayOfWeek = (int)DateTime.Now.DayOfWeek;
			if (dataTable.Rows[0][dayOfWeek].ToString() == a1343("0"))
			{
				return true;
			}
			return false;
		}
		return false;
	}

	public static void a1305()
	{
		MessageBox.Show(a1343("\0Ľȡ\u032aоԪاݩࠉणਫବప\u0d63ป༤\u1034ᅔ\u1257ፎᑕᔛᙓ\u1755ᡝᤗ\u1a77ᯒᴅᵟṟḀⅯℏ≷⏑⑇╇♏❄⡍⤇⩵⭌ⱈⵎ⹇⼁ざㅺ㈾㈭㑬㕯㙻㝵㠸㠧㭉㭹㱱㵾㹾㽴䁢䅦䈮䍔䑭䕻䙫䝤䡩䥽䩵䨴䱪䰲乸伯"), a1343("]žɧͷԵԣظܡ"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	public static string a1306()
	{
		string text = a1343("");
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		foreach (NetworkInterface networkInterface in allNetworkInterfaces)
		{
			if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet && networkInterface.OperationalStatus == OperationalStatus.Up)
			{
				return text + networkInterface.GetPhysicalAddress().ToString();
			}
		}
		return text;
	}

	public static void a1307()
	{
		a1271 = new SqlCommand();
		a1271.Connection = a2172.a2160;
		a1271.Parameters.Clear();
		a1271.CommandText = a1343("");
	}

	public static bool a1312(string a1308, string a1309, string a1310, string a1311)
	{
		DataTable dataTable = a2147.a2105(a1343("\u0016āȏ\u0307ЂԔ؟ݪࡲ६ਛଋఙ൱\u0e73༚\u1074ᅰበ\u137dᑨᕱᙫᜎᡫ\u197e\u1a64᭧ᰉᵽṴὣ⁷ⅷ∃⍵⑩╥♍❛⠽⥝⩐⭎ⱐⵞ⸪⼧〵ㅕ㉝㍖㐱㕉㙚㝅㡁㥉㩆㭏㱖㵅㹂㽔䁚䅍䉇䌿䐦") + a1310 + a1343("3ĳɓ\u035fєԯمݘࡀ\u0947\u0a4b\u0b47\u0c41\u0d44๏ང၀ᅊሿጦ") + a1308 + a1343("*ĬɊ\u0344эԨ\u0654ݏࡃ\u0956\u0a46\u0b3fద") + a1309 + a1343("6İɎ\u0340щԬـ\u074b\u085bड़\u0a49\u0b49\u0c4d\u0d41๛\u0f3fဦ") + a1311 + a1343("&"));
		if (dataTable.Rows.Count <= 0)
		{
			return false;
		}
		a1283 = Convert.ToInt32(dataTable.Rows[0][a1343("KŅ")].ToString());
		a1284 = dataTable.Rows[0][a1343("Fłɖ\u034bњՃم")].ToString();
		a1272 = Convert.ToInt64(a1310);
		a1281 = a2147.a2113(a1343("|ūɡ\u0369Ѩվ؉ݼࡨॶਅକ\u0c03\u0d63\u0e65ཀྵဿᅘ\u124fፓᑖᔺᙀᝍᡜᥚᩐ᭙᱖ᵍṜὕ⁝ⅅ≈⍖\u242b╝♁❍⡕⥃⨥⭍ⱇⴿ⸦") + a1272 + a1343("&"), 0);
		a1285 = false;
		a1286 = false;
		a1287 = true;
		return true;
	}

	public static bool a1315(string a1313, string a1314)
	{
		DataTable dataTable = a2147.a2105(a1343("\u001cċȁ\u0309ЈԞ٩ܜࠈख\u0a65୵\u0c63ഋฅཬၾᅺቮ፳ᑢᕻᙽ\u1718ᡱᥤ\u1a7a᭹ᰓᵧṢή⁽ⅽ∍⍻④╯♻❭⠇⥧⩮⭰ⱪⵤ⸜⼑〿ㅟ㉓㍘㐻㕛㙝㝕㡞㥘㨨㬦㰳㵓㹟㽔䀯䅅䉘䍀䑇䕋䙇䝁䡄䥏䩄䭀䱊䴿並") + a1313 + a1343("*ĬɊ\u0344эԨ\u0654ݏࡃ\u0956\u0a46\u0b3fద") + a1314 + a1343("%ġ"));
		if (dataTable.Rows.Count <= 0)
		{
			return false;
		}
		a1283 = Convert.ToInt32(dataTable.Rows[0][a1343("KŅ")].ToString());
		a1284 = dataTable.Rows[0][a1343("Fłɖ\u034bњՃم")].ToString();
		a1272 = 0L;
		a1281 = a1343("VǸɣ\u0369ѿգ٪ݡ\u0827\u0941੬୶౪൱\u0e68");
		a1285 = true;
		a1286 = false;
		a1287 = false;
		return true;
	}

	public static bool a1318(string a1316, string a1317)
	{
		DataTable dataTable = a2147.a2105(a1343("\u001cċȁ\u0309ЈԞ٩ܜࠈख\u0a65୵\u0c63ഋฅཬၾᅺቮ፳ᑢᕻᙽ\u1718ᡱᥤ\u1a7a᭹ᰓᵧṢή⁽ⅽ∍⍻④╯♻❭⠇⥧⩮⭰ⱪⵤ⸜⼑〿ㅟ㉓㍘㐻㕛㙝㝕㡞㥘㨨㬥㰳㵓㹟㽔䀯䅅䉘䍀䑇䕋䙇䝁䡄䥏䩄䭀䱊䴿並") + a1316 + a1343("*ĬɊ\u0344эԨ\u0654ݏࡃ\u0956\u0a46\u0b3fద") + a1317 + a1343("%ġ"));
		if (dataTable.Rows.Count <= 0)
		{
			return false;
		}
		a1283 = Convert.ToInt32(dataTable.Rows[0][a1343("KŅ")].ToString());
		a1284 = dataTable.Rows[0][a1343("Fłɖ\u034bњՃم")].ToString();
		a1272 = 0L;
		a1281 = a1343("]ůɽ\u0363ѹվۿݺ\u0827\u0941੬୶౪൱\u0e68");
		a1285 = false;
		a1286 = true;
		a1287 = false;
		return true;
	}

	public static string a1321(string a1319, string a1320)
	{
		try
		{
			return Registry.CurrentUser.OpenSubKey(a1319).GetValue(a1320).ToString();
		}
		catch
		{
			return a1343("");
		}
	}

	public static bool a1325(string a1322, string a1323, string a1324)
	{
		try
		{
			Registry.CurrentUser.CreateSubKey(a1322, RegistryKeyPermissionCheck.Default).SetValue(a1323, a1324.ToString());
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static string a1327(string a1326)
	{
		try
		{
			byte[] bytes = Convert.FromBase64String(a1326);
			return Encoding.ASCII.GetString(bytes);
		}
		catch
		{
			return a1343("JŖɎ\u034d");
		}
	}

	public static string a1329(string a1328)
	{
		return Convert.ToBase64String(Encoding.ASCII.GetBytes(a1328));
	}

	public static bool a1331(string a1330)
	{
		try
		{
			Convert.ToDateTime(a1330);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool a1333(string a1332)
	{
		try
		{
			Convert.ToDecimal(a1332);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static void a1334()
	{
		a2172.a2157 = a1321(a1343("@Žɷ\u0364Ѹկٿݩࡗ\u0944\u0a4c\u0b5e\u0c46൚\u0e5cཁ၎ᅇቊ"), a1343("Uŀɖ\u0355чՓ"));
		a2172.a2158 = a1321(a1343("@Žɷ\u0364Ѹկٿݩࡗ\u0944\u0a4c\u0b5e\u0c46൚\u0e5cཁ၎ᅇቊ"), a1343("Oňɂ\u035dыՊل\u074aࡊ\u0941\u0a48"));
		a2172.a2159 = a1327(a1321(a1343("@Žɷ\u0364Ѹկٿݩࡗ\u0944\u0a4c\u0b5e\u0c46൚\u0e5cཁ၎ᅇቊ"), a1343("Cńɖ\u034dхՐل")));
		a2172.a2156 = a1321(a1343("@Žɷ\u0364Ѹկٿݩࡗ\u0944\u0a4c\u0b5e\u0c46൚\u0e5cཁ၎ᅇቊ"), a1343("BŇɊ\u0342яՄ"));
	}

	public static void a1335()
	{
		try
		{
			object[] array = a2147.a2131(a1343("\tĜȔ\u0312Еԁٴܞࠓउਗଚ\u0c00ൡก༂ငᄎምጉᑪᔈᘅ\u171b᠒ᤀᨒ᭾ᰒᵰṵή\u206aⅸ≪⍶␚╸♱❽⡧⥶⩥⭡Ɐⵦ\u2e78⽢ぬㄅ㉥㍢㑨㕰㙴㝢㡰㥠㩡㭔㱊㵔㹚㼷䁎䅚䉖䍘䑕䕚䙚䝇䡀䥞䩜䬯䱈䵟乃但倪兙剉单呇啈噁块塐奄"));
			a1273 = Convert.ToInt32(array[0].ToString());
			a1274 = Convert.ToInt32(array[1].ToString());
			a1275 = Convert.ToInt32(array[2].ToString());
			a1276 = Convert.ToInt32(array[3].ToString());
			a1277 = Convert.ToInt32(array[4].ToString());
			a1278 = Convert.ToInt32(array[5].ToString());
			a1279 = Convert.ToInt32(array[6].ToString());
		}
		catch
		{
			a1273 = 100;
			a1274 = 1;
			a1275 = 500;
			a1276 = 0;
			a1277 = 1;
			a1278 = 1;
		}
	}

	public static void a1337(Control.ControlCollection a1336)
	{
		foreach (Control item in a1336)
		{
			if (a1288 == null)
			{
				continue;
			}
			if (item.Controls.Count > 0)
			{
				a1337(item.Controls);
			}
			if (item.GetType() == typeof(TextBox))
			{
				TextBox textBox = (TextBox)item;
				if (textBox.Tag == a1343("G"))
				{
					textBox.Font = new Font(a1288, textBox.Font.Size);
				}
			}
			if (item.GetType() == typeof(Button))
			{
				Button button = (Button)item;
				if (button.Tag == a1343("G"))
				{
					button.Font = new Font(a1288, button.Font.Size);
				}
			}
			if (item.GetType() == typeof(SpinEdit))
			{
				SpinEdit spinEdit = (SpinEdit)item;
				spinEdit.Font = new Font(a1288, spinEdit.Font.Size);
			}
		}
	}

	private static FontFamily a1338()
	{
		PrivateFontCollection privateFontCollection = new PrivateFontCollection();
		if (File.Exists(a1343("]žɫͻѼս\u064bݖ\u082a\u0957\u0a56\u0b47")))
		{
			privateFontCollection.AddFontFile(a1343("]žɫͻѼս\u064bݖ\u082a\u0957\u0a56\u0b47"));
			return privateFontCollection.Families[0];
		}
		return null;
	}

	public static bool a1341(string a1339, string a1340)
	{
		a1307();
		a1271.CommandText = a1343("vŲɥ\u0361ы՛ؽݐࡔढ़\u0a46\u0b4c\u0c52\u0d44๘ཝၝᅓቝጰᑜᕋᙙᜬᡀ᥋\u1a5b᭜᱉ᵉṍὁ⁛ℿ∦") + a1340 + a1343("4ĲɆ\u0358ъ՜وܬࡀ\u094bਜ਼ଡ଼\u0c49\u0d49\u0e4dཁၛᄿሦ") + a1339 + a1343("&");
		return true;
	}

	private static string a1343(string a1342)
	{
		int length = a1342.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a1342[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
