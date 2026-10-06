using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using a7.a2096;

namespace a7;

public class a959 : XtraForm
{
	private IContainer a943 = null;

	public TextBox a944;

	private PictureBox a945;

	public Label a946;

	public Label a947;

	public Label a948;

	public TextBox a949;

	public Label a950;

	public Label a951;

	public a959(int a952)
	{
		a956();
		a1984.a1891(this);
		a954(a952);
	}

	public void a954(int a953)
	{
		a1344.a1307();
		a1344.a1271.CommandText = a958("ožɶͼѻգ\u0616ݸࡱॠ\u0a61୰౷൪\u0e66ཨ\u106dᅯቯ፻ᐄᕪᙣ\u1776ᡷᥢ\u1a65᭤ᰀᵙṌὒ⁑℻≎⍛\u2454╚♓❆⡇⥒⩕⭔ⱘⵎ⹜⼭せㅃ㉏㍛㑍㔧㙏㝁㠹㥃㩋㭅");
		a1344.a1271.Parameters.Add(a958("KŅ"), SqlDbType.Int).Value = a953;
		DataTable dataTable = a2147.a2105(a1344.a1271);
		if (dataTable.Rows.Count > 0)
		{
			a949.Text = dataTable.Rows[0][a958("@ŉɘ\u0359шՏقݎࡀ\u0945\u0a47\u0b47\u0c53")].ToString();
			a944.Text = dataTable.Rows[0][a958("JŃɖ\u0357тՅل")].ToString();
		}
	}

	protected override void Dispose(bool a955)
	{
		if (a955 && a943 != null)
		{
			a943.Dispose();
		}
		base.Dispose(a955);
	}

	private void a956()
	{
		a944 = new TextBox();
		a946 = new Label();
		a950 = new Label();
		a947 = new Label();
		a948 = new Label();
		a949 = new TextBox();
		a945 = new PictureBox();
		a951 = new Label();
		((ISupportInitialize)a945).BeginInit();
		SuspendLayout();
		a944.BackColor = Color.White;
		a944.Enabled = false;
		a944.Font = new Font(a958("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a944.Location = new Point(92, 57);
		a944.Multiline = true;
		a944.Name = a958("|ſɲ\u0348ѡհ٣ݫ");
		a944.Size = new Size(498, 146);
		a944.TabIndex = 1;
		a946.AutoSize = true;
		a946.Font = new Font(a958("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
		a946.Location = new Point(15, 11);
		a946.Name = a958("jŤɦ\u0366ѮԹ");
		a946.Size = new Size(76, 13);
		a946.TabIndex = 51;
		a946.Text = a958("@ũɸ\u036bѣԨمݯࡩ\u0963੪ୱ౨");
		a950.AutoSize = true;
		a950.Location = new Point(15, 268);
		a950.Name = a958("jŤɦ\u0366Ѯ\u0530");
		a950.Size = new Size(376, 13);
		a950.TabIndex = 49;
		a950.Text = a958("\u0003ĨȾ\u0320ЯԳ٨ܓ\u0827षਥଥ൳യฤཞၐᄝቻᏍᑔᕝᙝᝅᡟᥙᩑ᭝ᰒᵼṕ\u1f5c⁏ⅇ≀⍊\u2458␘☈❣⡏⥎⩏⭂ⱖⵄ⸀⽞ひㅹ㌭㈄㔫㕷㜩㝭㠶㠥㫳㭺㱼㴱㹄㽪䅑䅨䉧䍠䓶䕻䘨䝂䡢䥠䩶䭪䱸䴯");
		a947.AutoSize = true;
		a947.Location = new Point(15, 124);
		a947.Name = a958("jŤɦ\u0366ѮԵ");
		a947.Size = new Size(35, 13);
		a947.TabIndex = 49;
		a947.Text = a958("Hšɰ\u0363ѫ");
		a948.AutoSize = true;
		a948.Location = new Point(15, 37);
		a948.Name = a958("jŤɦ\u0366ѮԷ");
		a948.Size = new Size(67, 13);
		a948.TabIndex = 49;
		a948.Text = a958("@ũɸ\u036bѣԨمݧग़२ଲਝര");
		a949.BackColor = Color.White;
		a949.Enabled = false;
		a949.Font = new Font(a958("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f);
		a949.Location = new Point(92, 30);
		a949.Name = a958("{Ŷɹ\u0341Ѯչ٨ݢࡅ१੶୨౪\u0d65\u0e68");
		a949.Size = new Size(498, 26);
		a949.TabIndex = 0;
		a945.Image = a2268.a2311;
		a945.Location = new Point(333, -32);
		a945.Name = a958("{ţɪͼѲմ٠\u0746\u086cॺਰ");
		a945.Size = new Size(741, 563);
		a945.TabIndex = 63;
		a945.TabStop = false;
		a951.BackColor = Color.FromArgb(128, 255, 128);
		a951.BorderStyle = BorderStyle.Fixed3D;
		a951.FlatStyle = FlatStyle.Flat;
		a951.ForeColor = Color.DarkOrange;
		a951.Location = new Point(15, 263);
		a951.Name = a958("kŧɧ\u0361ѯԳز");
		a951.Size = new Size(366, 3);
		a951.TabIndex = 64;
		Appearance.BackColor = Color.White;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(651, 291);
		Controls.Add(a951);
		Controls.Add(a944);
		Controls.Add(a946);
		Controls.Add(a947);
		Controls.Add(a950);
		Controls.Add(a949);
		Controls.Add(a948);
		Controls.Add(a945);
		MaximizeBox = false;
		MaximumSize = new Size(667, 330);
		Name = a958("Hſɡ\u0346ѯպ٩ݭࡁ४\u0a77୷౧൳");
		ShowIcon = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a958("jŕɳͲѼղܪݹनस\u0a55\u0b7f౹൳\u0e7a\u0f7e\u1074ᅾቫ፧ᑿᕡ᙮ᜪᡄᥭ\u1a74᭧ᱯᵨṢὰℰ");
		((ISupportInitialize)a945).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private static string a958(string a957)
	{
		int length = a957.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a957[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
