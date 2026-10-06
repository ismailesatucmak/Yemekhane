using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using a7.a2096;

namespace a7;

public class a940 : XtraForm
{
	private IContainer a824 = null;

	public Panel a825;

	public Button a826;

	private GroupBox a827;

	private DateTimePicker a828;

	private DateTimePicker a829;

	public System.Windows.Forms.ComboBox a830;

	public Label a831;

	public Label a832;

	public Button a833;

	public Button a834;

	private GroupBox a835;

	public System.Windows.Forms.ComboBox a836;

	public System.Windows.Forms.ComboBox a837;

	public Label a838;

	private XtraTabControl a839;

	private XtraTabPage a840;

	private XtraTabPage a841;

	private GroupControl a842;

	private GroupControl a843;

	public Button a844;

	public Button a845;

	private DateTimePicker a846;

	private DateTimePicker a847;

	public Label a848;

	public Label a849;

	public Label a850;

	public TextBox a851;

	public Label a852;

	public Label a853;

	public GridControl a854;

	public GridView a855;

	private GridColumn a856;

	private GridColumn a857;

	private GridColumn a858;

	private GridColumn a859;

	public GridControl a860;

	public GridView a861;

	private GridColumn a862;

	private GridColumn a863;

	private GridColumn a864;

	private GridColumn a865;

	private GridColumn a866;

	private GridColumn a867;

	private XtraTabPage a868;

	private GroupControl a869;

	private GroupControl a870;

	public Label a871;

	private DateTimePicker a872;

	private DateTimePicker a873;

	public Label a874;

	public Label a875;

	public Button a876;

	public Button a877;

	public GridControl a878;

	public GridView a879;

	private GridColumn a880;

	private GridColumn a881;

	private GridColumn a882;

	private GridColumn a883;

	private GridColumn a884;

	private GridColumn a885;

	private GridColumn a886;

	private GridColumn a887;

	private GridColumn a888;

	private GridColumn a889;

	private GridColumn a890;

	private GridColumn a891;

	private GridColumn a892;

	private GridColumn a893;

	private GridColumn a894;

	private GridColumn a895;

	private GridColumn a896;

	private GridColumn a897;

	private GridColumn a898;

	public Label a899;

	protected override void Dispose(bool a900)
	{
		if (a900 && a824 != null)
		{
			a824.Dispose();
		}
		base.Dispose(a900);
	}

	private void a901()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(a940));
		a825 = new Panel();
		a826 = new Button();
		a827 = new GroupBox();
		a828 = new DateTimePicker();
		a829 = new DateTimePicker();
		a836 = new System.Windows.Forms.ComboBox();
		a830 = new System.Windows.Forms.ComboBox();
		a837 = new System.Windows.Forms.ComboBox();
		a831 = new Label();
		a838 = new Label();
		a832 = new Label();
		a833 = new Button();
		a834 = new Button();
		a835 = new GroupBox();
		a854 = new GridControl();
		a855 = new GridView();
		a856 = new GridColumn();
		a857 = new GridColumn();
		a858 = new GridColumn();
		a859 = new GridColumn();
		a898 = new GridColumn();
		a839 = new XtraTabControl();
		a840 = new XtraTabPage();
		a841 = new XtraTabPage();
		a842 = new GroupControl();
		a860 = new GridControl();
		a861 = new GridView();
		a862 = new GridColumn();
		a863 = new GridColumn();
		a864 = new GridColumn();
		a865 = new GridColumn();
		a866 = new GridColumn();
		a867 = new GridColumn();
		a843 = new GroupControl();
		a851 = new TextBox();
		a850 = new Label();
		a846 = new DateTimePicker();
		a847 = new DateTimePicker();
		a853 = new Label();
		a852 = new Label();
		a848 = new Label();
		a849 = new Label();
		a844 = new Button();
		a845 = new Button();
		a868 = new XtraTabPage();
		a869 = new GroupControl();
		a878 = new GridControl();
		a879 = new GridView();
		a880 = new GridColumn();
		a881 = new GridColumn();
		a882 = new GridColumn();
		a883 = new GridColumn();
		a884 = new GridColumn();
		a885 = new GridColumn();
		a897 = new GridColumn();
		a886 = new GridColumn();
		a887 = new GridColumn();
		a888 = new GridColumn();
		a889 = new GridColumn();
		a890 = new GridColumn();
		a891 = new GridColumn();
		a892 = new GridColumn();
		a893 = new GridColumn();
		a894 = new GridColumn();
		a895 = new GridColumn();
		a896 = new GridColumn();
		a870 = new GroupControl();
		a871 = new Label();
		a872 = new DateTimePicker();
		a873 = new DateTimePicker();
		a874 = new Label();
		a875 = new Label();
		a876 = new Button();
		a877 = new Button();
		a899 = new Label();
		a825.SuspendLayout();
		a827.SuspendLayout();
		a835.SuspendLayout();
		((ISupportInitialize)a854).BeginInit();
		((ISupportInitialize)a855).BeginInit();
		((ISupportInitialize)a839).BeginInit();
		a839.SuspendLayout();
		a840.SuspendLayout();
		a841.SuspendLayout();
		((ISupportInitialize)a842).BeginInit();
		a842.SuspendLayout();
		((ISupportInitialize)a860).BeginInit();
		((ISupportInitialize)a861).BeginInit();
		((ISupportInitialize)a843).BeginInit();
		a843.SuspendLayout();
		a868.SuspendLayout();
		((ISupportInitialize)a869).BeginInit();
		a869.SuspendLayout();
		((ISupportInitialize)a878).BeginInit();
		((ISupportInitialize)a879).BeginInit();
		((ISupportInitialize)a870).BeginInit();
		a870.SuspendLayout();
		SuspendLayout();
		a825.BackColor = Color.FromArgb(233, 235, 236);
		a825.Controls.Add(a826);
		a825.Dock = DockStyle.Bottom;
		a825.Location = new Point(0, 340);
		a825.Name = a939("vŤɪ\u0366Ѯ\u0530");
		a825.Size = new Size(887, 40);
		a825.TabIndex = 58;
		a826.Dock = DockStyle.Fill;
		a826.Location = new Point(0, 0);
		a826.Name = a939("jųɨ\u0346ѭը٫ݲ");
		a826.Size = new Size(887, 40);
		a826.TabIndex = 0;
		a826.Text = a939("Â5ɨȳ՞");
		a826.UseVisualStyleBackColor = true;
		a826.Click += a915;
		a827.Controls.Add(a828);
		a827.Controls.Add(a829);
		a827.Controls.Add(a836);
		a827.Controls.Add(a830);
		a827.Controls.Add(a837);
		a827.Controls.Add(a831);
		a827.Controls.Add(a899);
		a827.Controls.Add(a838);
		a827.Controls.Add(a832);
		a827.Controls.Add(a833);
		a827.Controls.Add(a834);
		a827.Dock = DockStyle.Left;
		a827.Location = new Point(0, 0);
		a827.Name = a939("nźɨͳѵՆ٬ݺ࠲");
		a827.Size = new Size(355, 310);
		a827.TabIndex = 2;
		a827.TabStop = false;
		a827.Text = a939("Mţɥ\u0361ѳմ٠ݨࡦ९\u0a64");
		a828.CustomFormat = a939("vŵȰ\u0342уՀفܫࡳ॰\u0a71\u0b7eద\u0d4d\u0e4c\u0f39ၯᅬ");
		a828.Font = new Font(a939("RŤɬ\u036cѯՠ"), 14.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a828.Format = DateTimePickerFormat.Custom;
		a828.Location = new Point(89, 52);
		a828.Name = a939("lųɄ\u036cѰ\u0557٣ݳ");
		a828.Size = new Size(258, 30);
		a828.TabIndex = 2;
		a829.CustomFormat = a939("vŵȰ\u0342уՀفܫࡳ॰\u0a71\u0b7eద\u0d4d\u0e4c\u0f39ၯᅬ");
		a829.Font = new Font(a939("RŤɬ\u036cѯՠ"), 14.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a829.Format = DateTimePickerFormat.Custom;
		a829.ImeMode = ImeMode.NoControl;
		a829.Location = new Point(89, 21);
		a829.Name = a939("lųɄ\u0364ѷ\u0557٣ݳ");
		a829.Size = new Size(258, 30);
		a829.TabIndex = 1;
		a836.DropDownStyle = ComboBoxStyle.DropDownList;
		a836.Font = new Font(a939("RŤɬ\u036cѯՠ"), 14.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a836.FormattingEnabled = true;
		a836.Location = new Point(443, 54);
		a836.Name = a939("oũɚ\u036cѺմ٩ݫࡡ९\u0a4b\u0b45");
		a836.Size = new Size(41, 31);
		a836.TabIndex = 67;
		a830.DropDownStyle = ComboBoxStyle.DropDownList;
		a830.Font = new Font(a939("RŤɬ\u036cѯՠ"), 14.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a830.FormattingEnabled = true;
		a830.Location = new Point(443, 20);
		a830.Name = a939("iūɅ\u0362Ѵծ١ݹࡋ\u0945");
		a830.Size = new Size(41, 31);
		a830.TabIndex = 67;
		a837.DropDownStyle = ComboBoxStyle.DropDownList;
		a837.Font = new Font(a939("RŤɬ\u036cѯՠ"), 14.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a837.FormattingEnabled = true;
		a837.Location = new Point(89, 83);
		a837.Name = a939("iūɘ\u0362Ѵն٫ݭࡧ७");
		a837.Size = new Size(258, 31);
		a837.TabIndex = 0;
		a831.AutoSize = true;
		a831.Location = new Point(4, 61);
		a831.Name = a939("jŤɦ\u0366ѮԳ");
		a831.Size = new Size(55, 13);
		a831.TabIndex = 66;
		a831.Text = a939("NŢɾ\u0360\u0557ԧ\u0652ݤࡶ४੪୨");
		a838.AutoSize = true;
		a838.Location = new Point(4, 92);
		a838.Name = a939("jŤɦ\u0366ѮԴ");
		a838.Size = new Size(48, 13);
		a838.TabIndex = 66;
		a838.Text = a939("XŢɴͶѫխ٧ݭ");
		a832.AutoSize = true;
		a832.Location = new Point(4, 30);
		a832.Name = a939("jŤɦ\u0366Ѯ\u0530");
		a832.Size = new Size(80, 13);
		a832.TabIndex = 66;
		a832.Text = a939("RŮ\u0351\u0361ѭե٭ظ\u08efध\u0a52\u0b64\u0c76൪\u0e6aཨ");
		a833.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		a833.Image = a2268.a2312;
		a833.ImageAlign = ContentAlignment.MiddleLeft;
		a833.Location = new Point(191, 172);
		a833.Name = a939("jųɨ\u0340Ѽՠ٧ݭ");
		a833.Size = new Size(158, 40);
		a833.TabIndex = 9;
		a833.Text = a939("Yūɹ\u0367ѵԦلݯࡷ\u0963ੳ");
		a833.UseVisualStyleBackColor = true;
		a833.Click += a912;
		a834.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		a834.Image = a2268.a2280;
		a834.ImageAlign = ContentAlignment.MiddleLeft;
		a834.Location = new Point(191, 133);
		a834.Name = a939("hŽɦ\u0354ѩշ٣ݶ\u086eॠ");
		a834.Size = new Size(158, 40);
		a834.TabIndex = 8;
		a834.Text = a939("_ŭɻ\u0365ѻԨ\u0654ݩࡷ\u0963੶୮ౠ");
		a834.UseVisualStyleBackColor = true;
		a834.Click += a909;
		a835.Controls.Add(a854);
		a835.Dock = DockStyle.Fill;
		a835.Location = new Point(355, 0);
		a835.Name = a939("nźɨͳѵՆ٬ݺ࠰");
		a835.Size = new Size(523, 310);
		a835.TabIndex = 1;
		a835.TabStop = false;
		a835.Text = a939("0ŝɯͽѣչتݚࡧ३ੳ\u0be2౨\u0d62\u0e70ะ");
		a854.Dock = DockStyle.Fill;
		a854.EmbeddedNavigator.Name = a939("");
		a854.Font = new Font(a939("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a854.Location = new Point(3, 17);
		a854.LookAndFeel.SkinName = a939("GżɻͳѯՖ٭ݨ\u086b९");
		a854.LookAndFeel.UseDefaultLookAndFeel = false;
		a854.MainView = a855;
		a854.Name = a939("kŹɣ\u036dыը٨ݱࡶ६੮ଳ");
		a854.Size = new Size(517, 290);
		a854.TabIndex = 58;
		a854.ViewCollection.AddRange(new BaseView[1] { a855 });
		a854.DoubleClick += a937;
		a855.BorderStyle = BorderStyles.NoBorder;
		a855.Columns.AddRange(new GridColumn[5] { a856, a857, a858, a859, a898 });
		a855.FocusRectStyle = DrawFocusRectStyle.RowFocus;
		a855.GridControl = a854;
		a855.Name = a939("nźɮ\u0362ѓխ٦ݵ࠳");
		a855.OptionsBehavior.Editable = false;
		a855.OptionsFilter.AllowFilterEditor = false;
		a855.OptionsView.ColumnAutoWidth = false;
		a855.OptionsView.ShowAutoFilterRow = true;
		a855.OptionsView.ShowFooter = true;
		a855.OptionsView.ShowGroupPanel = false;
		a856.Caption = a939("KŅ");
		a856.FieldName = a939("KŅ");
		a856.Name = a939("lŸɠ\u036cфթ٩ݱ\u086e६\u0a34");
		a857.Caption = a939("Qťɱ\u036bѩ");
		a857.DisplayFormat.FormatString = a939("tūȣ\u0340сԦٳݰࡱॾਦ\u0b4d\u0c4cഹ\u0e6fཬ");
		a857.DisplayFormat.FormatType = FormatType.DateTime;
		a857.FieldName = a939("QŅɑ\u034bщ");
		a857.Name = a939("lŸɠ\u036cфթ٩ݱ\u086e६\u0a37");
		a857.Visible = true;
		a857.VisibleIndex = 0;
		a858.Caption = a939("KŬɯͷѣճ");
		a858.FieldName = a939("KŌɏ\u0357уՓ");
		a858.Name = a939("lŸɠ\u036cфթ٩ݱ\u086e६ਸ਼");
		a858.SummaryItem.SummaryType = SummaryItemType.Sum;
		a858.Visible = true;
		a858.VisibleIndex = 1;
		a859.Caption = a939("XŢɴͶѫխ٧ݭ");
		a859.FieldName = a939("Fłɖ\u034bњՃم");
		a859.Name = a939("lŸɠ\u036cфթ٩ݱ\u086e६ਹ");
		a859.Visible = true;
		a859.VisibleIndex = 2;
		a898.Caption = a939("SŖɁ\u0351ыՅ");
		a898.FieldName = a939("SŖɁ\u0351ыՅ");
		a898.Name = a939("kŹɣ\u036dыը٪ݰࡩ७ਰସ");
		a839.Dock = DockStyle.Fill;
		a839.Location = new Point(0, 0);
		a839.LookAndFeel.SkinName = a939("GżɻͳѯՖ٭ݨ\u086b९");
		a839.LookAndFeel.UseDefaultLookAndFeel = false;
		a839.Name = a939("wźɿ\u036dџի٫\u074bࡨ२\u0a71୶౬൮ะ");
		a839.SelectedTabPage = a840;
		a839.Size = new Size(887, 340);
		a839.TabIndex = 60;
		a839.TabPages.AddRange(new XtraTabPage[3] { a840, a841, a868 });
		a839.Text = a939("wźɿ\u036dџի٫\u074bࡨ२\u0a71୶౬൮ะ");
		a840.Controls.Add(a835);
		a840.Controls.Add(a827);
		a840.Name = a939("tſɸ\u0368ќզ٤ݕࡥ।੧ର");
		a840.Size = new Size(878, 310);
		a840.Text = a939("ZŎɔ\u0338ќշ٦ݵ࠳ॐ\u0a7e\u0a4f౮\u0d62\u0e79\u0e3dၦᄪቛ፩ᑷᕩᙷᝨᡢᥰᬰ");
		a841.Controls.Add(a842);
		a841.Controls.Add(a843);
		a841.Name = a939("tſɸ\u0368ќզ٤ݕࡥ।੧ଳ");
		a841.Size = new Size(878, 310);
		a841.Text = a939("Ršɺȡѫկحݕ\u086e१੬\u0b63ధൔ\u0e64\u0f74\u106cᅰቴ");
		a842.Controls.Add(a860);
		a842.Dock = DockStyle.Fill;
		a842.Location = new Point(354, 0);
		a842.LookAndFeel.SkinName = a939("GżɻͳѯՖ٭ݨ\u086b९");
		a842.LookAndFeel.UseDefaultLookAndFeel = false;
		a842.Name = a939("jžɤͿѹՋ٨ݨࡱॶ੬୮ళ");
		a842.Size = new Size(524, 310);
		a842.TabIndex = 1;
		a842.Text = a939("^Ūɺ\u0366Ѻԧ\u0655ݪࡪॶ\u0a61୴");
		a860.Dock = DockStyle.Fill;
		a860.EmbeddedNavigator.Name = a939("");
		a860.Font = new Font(a939("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a860.Location = new Point(2, 20);
		a860.LookAndFeel.SkinName = a939("GżɻͳѯՖ٭ݨ\u086b९");
		a860.LookAndFeel.UseDefaultLookAndFeel = false;
		a860.MainView = a861;
		a860.Name = a939("kŹɣ\u036dыը٨ݱࡶ६੮ର");
		a860.Size = new Size(520, 288);
		a860.TabIndex = 57;
		a860.ViewCollection.AddRange(new BaseView[1] { a861 });
		a861.BorderStyle = BorderStyles.NoBorder;
		a861.Columns.AddRange(new GridColumn[6] { a862, a863, a864, a865, a866, a867 });
		a861.FocusRectStyle = DrawFocusRectStyle.RowFocus;
		a861.GridControl = a860;
		a861.Name = a939("nźɮ\u0362ѓխ٦ݵ࠰");
		a861.OptionsBehavior.Editable = false;
		a861.OptionsFilter.AllowFilterEditor = false;
		a861.OptionsView.ShowFooter = true;
		a861.OptionsView.ShowGroupPanel = false;
		a862.Caption = a939("KŅ");
		a862.FieldName = a939("KŅ");
		a862.Name = a939("lŸɠ\u036cфթ٩ݱ\u086e६ਰ");
		a862.OptionsColumn.AllowEdit = false;
		a863.Caption = a939("Qťɱ\u036bѩ");
		a863.DisplayFormat.FormatString = a939("tūȣ\u0340сԦٳݰࡱॾਦ\u0b4d\u0c4cഹ\u0e6fཬ");
		a863.DisplayFormat.FormatType = FormatType.DateTime;
		a863.FieldName = a939("]ŉɕ\u034fэ\u0557ق\u0743ࡕ");
		a863.Name = a939("lŸɠ\u036cфթ٩ݱ\u086e६ਲ਼");
		a863.OptionsColumn.AllowEdit = false;
		a863.Visible = true;
		a863.VisibleIndex = 0;
		a864.Caption = a939("YŰɣ\u036eЮכ٢ݨ\u086f\u0962\u0a61ଧ\u0c44\u0d64\u0e6fཪၻᅤ");
		a864.FieldName = a939("YŐɂ\u035bёՂق\u0748ࡏ\u0942\u0a41\u0b58\u0c44\u0d44๏ཊၛᅄ");
		a864.Name = a939("lŸɠ\u036cфթ٩ݱ\u086e६ਲ");
		a864.OptionsColumn.AllowEdit = false;
		a864.Visible = true;
		a864.VisibleIndex = 1;
		a865.Caption = a939("Qűɷ\u0363ѳ");
		a865.FieldName = a939("Qőɗ\u0343ѓ");
		a865.Name = a939("lŸɠ\u036cфթ٩ݱ\u086e६ਵ");
		a865.OptionsColumn.AllowEdit = false;
		a865.SummaryItem.SummaryType = SummaryItemType.Sum;
		a865.Visible = true;
		a865.VisibleIndex = 2;
		a866.Caption = a939("Bſɡ\u032eцխٸݫ\u0829\u094a੦୭౬ൽ\u0e66\u0f71\u1068");
		a866.FieldName = a939("XœɃ\u0344ѐ՝ق\u0742\u0859\u094b\u0a42\u0b41ౘ\u0d44ไཏ၊ᅛቄ");
		a866.Name = a939("lŸɠ\u036cфթ٩ݱ\u086e६ਸ");
		a866.OptionsColumn.AllowEdit = false;
		a866.Visible = true;
		a866.VisibleIndex = 3;
		a867.Caption = a939("Vǲɦ\u0360Ѯէ٬ܨࡉ३੮୰\u0c62൱༰");
		a867.FieldName = a939("Bŝɋ\u034aфՊي\u0741ࡈ");
		a867.Name = a939("kŹɣ\u036dыը٪ݰࡩ७ਲ਼\u0b31");
		a867.OptionsColumn.AllowEdit = false;
		a867.Visible = true;
		a867.VisibleIndex = 4;
		a843.Controls.Add(a851);
		a843.Controls.Add(a850);
		a843.Controls.Add(a846);
		a843.Controls.Add(a847);
		a843.Controls.Add(a853);
		a843.Controls.Add(a852);
		a843.Controls.Add(a848);
		a843.Controls.Add(a849);
		a843.Controls.Add(a844);
		a843.Controls.Add(a845);
		a843.Dock = DockStyle.Left;
		a843.Location = new Point(0, 0);
		a843.LookAndFeel.SkinName = a939("GżɻͳѯՖ٭ݨ\u086b९");
		a843.LookAndFeel.UseDefaultLookAndFeel = false;
		a843.Name = a939("jžɤͿѹՋ٨ݨࡱॶ੬୮ర");
		a843.Size = new Size(354, 310);
		a843.TabIndex = 0;
		a843.Text = a939("^Ūɺ\u0366Ѻԧ\u064dشࡷ࠲੶ਰ");
		a851.Enabled = false;
		a851.Font = new Font(a939("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 20f);
		a851.ForeColor = Color.Gray;
		a851.Location = new Point(128, 216);
		a851.MaxLength = 5;
		a851.Name = a939("}Žɍ\u0378ѡՠ٬ݦࡄ।੯୪౻\u0d64");
		a851.Size = new Size(135, 38);
		a851.TabIndex = 72;
		a851.Text = a939("4įȲ\u0331");
		a851.TextAlign = HorizontalAlignment.Right;
		a850.BackColor = Color.FromArgb(128, 255, 128);
		a850.BorderStyle = BorderStyle.Fixed3D;
		a850.FlatStyle = FlatStyle.Flat;
		a850.ForeColor = Color.DarkOrange;
		a850.Location = new Point(7, 209);
		a850.Name = a939("kŧɧ\u0361ѯԳز");
		a850.Size = new Size(340, 3);
		a850.TabIndex = 71;
		a846.CalendarForeColor = Color.Gray;
		a846.CustomFormat = a939("vŵȰ\u0342уՀفܫࡳ॰\u0a71\u0b7eద\u0d4d\u0e4c\u0f39ၯᅬ");
		a846.Font = new Font(a939("RŤɬ\u036cѯՠ"), 14.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a846.Format = DateTimePickerFormat.Custom;
		a846.Location = new Point(90, 54);
		a846.Name = a939("iŸɉ\u0363ѽ՜٦ݴࡁ५੯୷౬");
		a846.Size = new Size(258, 30);
		a846.TabIndex = 68;
		a847.CustomFormat = a939("vŵȰ\u0342уՀفܫࡳ॰\u0a71\u0b7eద\u0d4d\u0e4c\u0f39ၯᅬ");
		a847.Font = new Font(a939("RŤɬ\u036cѯՠ"), 14.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a847.Format = DateTimePickerFormat.Custom;
		a847.ImeMode = ImeMode.NoControl;
		a847.Location = new Point(90, 23);
		a847.Name = a939("iŸɉ\u036bѺ՜٦ݴࡁ५੯୷౬");
		a847.Size = new Size(258, 30);
		a847.TabIndex = 67;
		a853.AutoSize = true;
		a853.Font = new Font(a939("RŤɬ\u036cѯՠ"), 14f);
		a853.ForeColor = Color.Gray;
		a853.Location = new Point(269, 224);
		a853.Name = a939("jŤɦ\u0366ѮԶ");
		a853.Size = new Size(30, 23);
		a853.TabIndex = 70;
		a853.Text = a939("Vō");
		a852.AutoSize = true;
		a852.Font = new Font(a939("RŤɬ\u036cѯՠ"), 14f);
		a852.ForeColor = Color.Gray;
		a852.Location = new Point(9, 224);
		a852.Name = a939("jŤɦ\u0366ѮԷ");
		a852.Size = new Size(113, 23);
		a852.TabIndex = 70;
		a852.Text = a939("LſɠȻЩՊ٦ݭ\u086cॽ੦ୱ౨");
		a848.AutoSize = true;
		a848.Location = new Point(5, 63);
		a848.Name = a939("jŤɦ\u0366ѮԲ");
		a848.Size = new Size(55, 13);
		a848.TabIndex = 70;
		a848.Text = a939("NŢɾ\u0360\u0557ԧ\u0652ݤࡶ४੪୨");
		a849.AutoSize = true;
		a849.Location = new Point(5, 32);
		a849.Name = a939("jŤɦ\u0366ѮԵ");
		a849.Size = new Size(80, 13);
		a849.TabIndex = 69;
		a849.Text = a939("RŮ\u0351\u0361ѭե٭ظ\u08efध\u0a52\u0b64\u0c76൪\u0e6aཨ");
		a844.Image = a2268.a2312;
		a844.ImageAlign = ContentAlignment.MiddleLeft;
		a844.Location = new Point(191, 143);
		a844.Name = a939("eųɱͰѬլس");
		a844.Size = new Size(158, 40);
		a844.TabIndex = 10;
		a844.Text = a939("Yūɹ\u0367ѵԦلݯࡷ\u0963ੳ");
		a844.UseVisualStyleBackColor = true;
		a844.Click += a924;
		a845.Image = a2268.a2280;
		a845.ImageAlign = ContentAlignment.MiddleLeft;
		a845.Location = new Point(191, 104);
		a845.Name = a939("eųɱͰѬլذ");
		a845.Size = new Size(158, 40);
		a845.TabIndex = 9;
		a845.Text = a939("_ŭɻ\u0365ѻԨ\u0654ݩࡷ\u0963੶୮ౠ");
		a845.UseVisualStyleBackColor = true;
		a845.Click += a921;
		a868.Controls.Add(a869);
		a868.Controls.Add(a870);
		a868.Name = a939("tſɸ\u0368ќզ٤ݕࡥ।੧ଲ");
		a868.Size = new Size(878, 310);
		a868.Text = a939("UŠɹȠѴծ٠ܭࡈ।੦\u0b7c\u0c65ധ๔ཤ\u1074ᅬተ፴");
		a869.Controls.Add(a878);
		a869.Dock = DockStyle.Fill;
		a869.Location = new Point(354, 0);
		a869.LookAndFeel.SkinName = a939("GżɻͳѯՖ٭ݨ\u086b९");
		a869.LookAndFeel.UseDefaultLookAndFeel = false;
		a869.Name = a939("jžɤͿѹՋ٨ݨࡱॶ੬୮వ");
		a869.Size = new Size(524, 310);
		a869.TabIndex = 2;
		a869.Text = a939("^Ūɺ\u0366Ѻԧ\u0655ݪࡪॶ\u0a61୴");
		a878.Dock = DockStyle.Fill;
		a878.EmbeddedNavigator.Name = a939("");
		a878.Font = new Font(a939("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a878.Location = new Point(2, 20);
		a878.LookAndFeel.SkinName = a939("GżɻͳѯՖ٭ݨ\u086b९");
		a878.LookAndFeel.UseDefaultLookAndFeel = false;
		a878.MainView = a879;
		a878.Name = a939("kŹɣ\u036dыը٨ݱࡶ६੮ଲ");
		a878.Size = new Size(520, 288);
		a878.TabIndex = 57;
		a878.ViewCollection.AddRange(new BaseView[1] { a879 });
		a879.BorderStyle = BorderStyles.NoBorder;
		a879.Columns.AddRange(new GridColumn[18]
		{
			a880, a881, a882, a883, a884, a885, a897, a886, a887, a888,
			a889, a890, a891, a892, a893, a894, a895, a896
		});
		a879.FocusRectStyle = DrawFocusRectStyle.RowFocus;
		a879.GridControl = a878;
		a879.Name = a939("nźɮ\u0362ѓխ٦ݵ࠲");
		a879.OptionsBehavior.Editable = false;
		a879.OptionsFilter.AllowFilterEditor = false;
		a879.OptionsView.ShowFooter = true;
		a879.OptionsView.ShowGroupPanel = false;
		a880.Caption = a939("KŅ");
		a880.FieldName = a939("KŅ");
		a880.Name = a939("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ର");
		a881.Caption = a939("Bšɴ\u036fѩաٱ\u074bࡅ");
		a881.FieldName = a939("Aŀɛ\u034eъՀ\u0656ݜࡋ\u0945");
		a881.Name = a939("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଳ");
		a882.Caption = a939("QŇȣ\u034cѮ");
		a882.FieldName = a939("PŀɌ\u034e");
		a882.Name = a939("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଷ");
		a882.Visible = true;
		a882.VisibleIndex = 2;
		a882.Width = 99;
		a883.Caption = a939("Kŭ\u0339\u0327ѕժٽݢࡦ࠰");
		a883.FieldName = a939("BņɈ");
		a883.Name = a939("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଲ");
		a883.Visible = true;
		a883.VisibleIndex = 3;
		a883.Width = 99;
		a884.Caption = a939("LŧɷͰУՌٮ");
		a884.FieldName = a939("Bŉɕ\u0352ыՋ\u064b\u0747\u0859");
		a884.Name = a939("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଵ");
		a884.SummaryItem.SummaryType = SummaryItemType.Count;
		a884.Visible = true;
		a884.VisibleIndex = 1;
		a884.Width = 99;
		a885.Caption = a939("Qťɱ\u036bѩ");
		a885.FieldName = a939("QŅɑ\u034bщ");
		a885.Name = a939("kŹɣ\u036dыը٪ݰࡩ७ਲ਼\u0b34");
		a885.Visible = true;
		a885.VisibleIndex = 5;
		a885.Width = 90;
		a897.Caption = a939("ļTɦ\u036cѥԧ\u0652ݤࡶ४੪୨");
		a897.DisplayFormat.FormatString = a939("tūȣ\u0340сԦٳݰࡱॾਦ\u0b4d\u0c4cഹ\u0e6fཬ");
		a897.DisplayFormat.FormatType = FormatType.DateTime;
		a897.FieldName = a939("EŘɆ\u034cх\u0558\u0652\u0744ࡖ\u094a\u0a4a\u0b48");
		a897.Name = a939("kŹɣ\u036dыը٪ݰࡩ७ਰହ");
		a897.OptionsColumn.AllowEdit = false;
		a897.Visible = true;
		a897.VisibleIndex = 4;
		a897.Width = 89;
		a886.Caption = a939("@ūɻͼЧՁٷݱࡳ\u094b\u0a45");
		a886.FieldName = a939("Aňɚ\u0353с\u0557\u0651ݓࡋ\u0945");
		a886.Name = a939("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଶ");
		a887.Caption = a939("BũɵͲХՃٱݷࡱ");
		a887.FieldName = a939("Cņɔ\u0351уՑ\u0657ݑ");
		a887.Name = a939("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ହ");
		a887.Visible = true;
		a887.VisibleIndex = 6;
		a887.Width = 90;
		a888.Caption = a939("Iłɑ\u034dыՅ");
		a888.FieldName = a939("Iłɑ\u034dыՅ");
		a888.Name = a939("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ସ");
		a889.Caption = a939("Ò\u001c\u02fe\u036f");
		a889.FieldName = a939("Kńɗ\u034f");
		a889.Name = a939("kŹɣ\u036dыը٪ݰࡩ७ਰ\u0b31");
		a889.Visible = true;
		a889.VisibleIndex = 7;
		a889.Width = 90;
		a890.Caption = a939("_Łɱͱѷլ");
		a890.FieldName = a939("RŏɄ\u034dьՙفݑࡑ\u0957\u0a4c");
		a890.Name = a939("kŹɣ\u036dыը٪ݰࡩ७ਰର");
		a891.Caption = a939("AűɱͷѬ");
		a891.FieldName = a939("Aőɑ\u0357ь");
		a891.Name = a939("kŹɣ\u036dыը٪ݰࡩ७ਰଳ");
		a891.Visible = true;
		a891.VisibleIndex = 8;
		a891.Width = 90;
		a892.Caption = a939("EŢɴ\u036eѡչ\u064b\u0745");
		a892.FieldName = a939("WŘɇ\u0347яՄ\u064dݘࡋ\u0940\u0a56ଡ଼\u0c4b\u0d45");
		a892.Name = a939("kŹɣ\u036dыը٪ݰࡩ७ਰଲ");
		a893.Caption = a939("KŠɶ\u0368ѧջ");
		a893.FieldName = a939("Kŀɖ\u0348ч՛");
		a893.Name = a939("kŹɣ\u036dыը٪ݰࡩ७ਰଵ");
		a893.Visible = true;
		a893.VisibleIndex = 9;
		a893.Width = 90;
		a894.Caption = a939("SŶɡͱыՅ");
		a894.FieldName = a939("Rŕɀ\u0356ќՋم");
		a894.Name = a939("kŹɣ\u036dыը٪ݰࡩ७ਰ\u0b34");
		a895.Caption = a939("XŢɴͶѫխ٧ݭ");
		a895.FieldName = a939("PŗɆ\u0350ѓ");
		a895.Name = a939("kŹɣ\u036dыը٪ݰࡩ७ਰଷ");
		a895.Visible = true;
		a895.VisibleIndex = 10;
		a895.Width = 102;
		a896.Caption = a939("W2ɰ\u0360");
		a896.FieldName = a939("WŊɐ\u0340");
		a896.Name = a939("kŹɣ\u036dыը٪ݰࡩ७ਰଶ");
		a896.Visible = true;
		a896.VisibleIndex = 0;
		a896.Width = 44;
		a870.Controls.Add(a871);
		a870.Controls.Add(a872);
		a870.Controls.Add(a873);
		a870.Controls.Add(a874);
		a870.Controls.Add(a875);
		a870.Controls.Add(a876);
		a870.Controls.Add(a877);
		a870.Dock = DockStyle.Left;
		a870.Location = new Point(0, 0);
		a870.LookAndFeel.SkinName = a939("GżɻͳѯՖ٭ݨ\u086b९");
		a870.LookAndFeel.UseDefaultLookAndFeel = false;
		a870.Name = a939("jžɤͿѹՋ٨ݨࡱॶ੬୮ల");
		a870.Size = new Size(354, 310);
		a870.TabIndex = 1;
		a870.Text = a939("^Ūɺ\u0366Ѻԧ\u064dشࡷ࠲੶ਰ");
		a871.BackColor = Color.FromArgb(128, 255, 128);
		a871.BorderStyle = BorderStyle.Fixed3D;
		a871.FlatStyle = FlatStyle.Flat;
		a871.ForeColor = Color.DarkOrange;
		a871.Location = new Point(7, 209);
		a871.Name = a939("jŤɦ\u0366ѮԹ");
		a871.Size = new Size(340, 3);
		a871.TabIndex = 71;
		a872.CalendarForeColor = Color.Gray;
		a872.CustomFormat = a939("vŵȰ\u0342уՀفܫࡳ॰\u0a71\u0b7eద\u0d4d\u0e4c\u0f39ၯᅬ");
		a872.Font = new Font(a939("RŤɬ\u036cѯՠ"), 14.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a872.Format = DateTimePickerFormat.Custom;
		a872.Location = new Point(90, 54);
		a872.Name = a939("nŽɊ\u036eѲՑ٥ݱࡃ\u0945");
		a872.Size = new Size(258, 30);
		a872.TabIndex = 68;
		a873.CustomFormat = a939("vŵȰ\u0342уՀفܫࡳ॰\u0a71\u0b7eద\u0d4d\u0e4c\u0f39ၯᅬ");
		a873.Font = new Font(a939("RŤɬ\u036cѯՠ"), 14.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a873.Format = DateTimePickerFormat.Custom;
		a873.ImeMode = ImeMode.NoControl;
		a873.Location = new Point(90, 23);
		a873.Name = a939("nŽɊ\u0366ѵՑ٥ݱࡃ\u0945");
		a873.Size = new Size(258, 30);
		a873.TabIndex = 67;
		a874.AutoSize = true;
		a874.Location = new Point(5, 63);
		a874.Name = a939("kŧɧ\u0361ѯԳذ");
		a874.Size = new Size(55, 13);
		a874.TabIndex = 70;
		a874.Text = a939("NŢɾ\u0360\u0557ԧ\u0652ݤࡶ४੪୨");
		a875.AutoSize = true;
		a875.Location = new Point(5, 32);
		a875.Name = a939("kŧɧ\u0361ѯԳس");
		a875.Size = new Size(80, 13);
		a875.TabIndex = 69;
		a875.Text = a939("RŮ\u0351\u0361ѭե٭ظ\u08efध\u0a52\u0b64\u0c76൪\u0e6aཨ");
		a876.Image = a2268.a2312;
		a876.ImageAlign = ContentAlignment.MiddleLeft;
		a876.Location = new Point(191, 143);
		a876.Name = a939("eųɱͰѬլز");
		a876.Size = new Size(158, 40);
		a876.TabIndex = 10;
		a876.Text = a939("Yūɹ\u0367ѵԦلݯࡷ\u0963ੳ");
		a876.UseVisualStyleBackColor = true;
		a876.Click += a930;
		a877.Image = a2268.a2280;
		a877.ImageAlign = ContentAlignment.MiddleLeft;
		a877.Location = new Point(191, 104);
		a877.Name = a939("eųɱͰѬլص");
		a877.Size = new Size(158, 40);
		a877.TabIndex = 9;
		a877.Text = a939("_ŭɻ\u0365ѻԨ\u0654ݩࡷ\u0963੶୮ౠ");
		a877.UseVisualStyleBackColor = true;
		a877.Click += a927;
		a899.AutoSize = true;
		a899.ForeColor = Color.Red;
		a899.Location = new Point(4, 258);
		a899.Name = a939("jŤɦ\u0366ѮԸ");
		a899.Size = new Size(333, 13);
		a899.TabIndex = 66;
		a899.Text = a939("\u001fƹȯ\u032fЧԬإܟࡺक़\u0a48\u0b5a\u0c43ఈ๖ฆဖᅲዂፁᑟᕔᙛᜏᡇ\u19caᩅᭅᰊᵰỔὌ⁊⅀≉⍆␂╪♁❦⡺⠬⩲⨪ⱴⴹ⻤⽭びㅧ㉽㍽㑷㔱㛷㝦㡨㥹㨬㭿㴻㵢㹤㽦䁿䀴䉪䈲䑸䔯");
		Appearance.BackColor = Color.White;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(887, 380);
		Controls.Add(a839);
		Controls.Add(a825);
		Icon = (Icon)componentResourceManager.GetObject(a939(".Žɠ\u036eѵԫ\u064dݠ\u086d९"));
		Name = a939("Kžɦ\u0341Ѡէٴݭࡗ॥ੳ୭\u0c73");
		ShowIcon = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a939("Sžɹ\u0366ѿԳ\u0650ݾ\u094f८\u0a62\u0b79ഽ൦สཛ\u1069ᅷቩ፷ᑨᕢᙰᘰ");
		WindowState = FormWindowState.Maximized;
		a825.ResumeLayout(performLayout: false);
		a827.ResumeLayout(performLayout: false);
		a827.PerformLayout();
		a835.ResumeLayout(performLayout: false);
		((ISupportInitialize)a854).EndInit();
		((ISupportInitialize)a855).EndInit();
		((ISupportInitialize)a839).EndInit();
		a839.ResumeLayout(performLayout: false);
		a840.ResumeLayout(performLayout: false);
		a841.ResumeLayout(performLayout: false);
		((ISupportInitialize)a842).EndInit();
		a842.ResumeLayout(performLayout: false);
		((ISupportInitialize)a860).EndInit();
		((ISupportInitialize)a861).EndInit();
		((ISupportInitialize)a843).EndInit();
		a843.ResumeLayout(performLayout: false);
		a843.PerformLayout();
		a868.ResumeLayout(performLayout: false);
		((ISupportInitialize)a869).EndInit();
		a869.ResumeLayout(performLayout: false);
		((ISupportInitialize)a878).EndInit();
		((ISupportInitialize)a879).EndInit();
		((ISupportInitialize)a870).EndInit();
		a870.ResumeLayout(performLayout: false);
		a870.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	public a940()
	{
		a901();
		a1984.a1891(this);
		a829.Value = DateTime.Now.Date;
		a847.Value = DateTime.Now.Date;
		a828.Value = DateTime.Now.Date;
		a846.Value = DateTime.Now.Date;
		a872.Value = DateTime.Now.Date;
		a873.Value = DateTime.Now.Date;
		a902();
		a906();
	}

	public void a902()
	{
		a1984.a1964(a939("~ũɧ\u036fѪռ؇ݯࡡई\u0a62୦\u0c72൯ๆཟ\u1059ᄼቝፈᑖᕕᘷᝃᡆᥑᩁ\u1b41\u1c31ᵇṇὋ\u205fⅉ∫⍋⑂╜♎❀⠸⤣⨲⬥Ⱑ"), a836, a837, a939("1"), a939("MšɳͱѨ"));
	}

	public void a903()
	{
		a836.SelectedIndex = a837.SelectedIndex;
		a1344.a1307();
		a1344.a1271.CommandText = a939("Uħȶ\u033eдԳػݎ࠹ढ़\u0a45ଣభ\u0d44ำབྷ။ᄰሢጰᐨᔨᙳᜊᡬᥲᨖᬓᰒᴌḖἄ⁹℀≢⍼␄┃☊✜⠄⤈⩧⬞ⱻⵦ⸆⼂〖ㄋ㈚㌃㐅㕠㙹㝬㡲㥱㨛㭱㱰㵷㹤㽽䁽䅵䉡䌒䑥䔁䘏䝢䡨䥪䩿䬊䱣䵧乮佨倅共剰卧味啳嘿坊堯夼婔孔就嵌带弸恀慇扖捀摘敔昲杚栿椢橂歎氠洨渧潑灍煁牑獇琡");
		if (Convert.ToDateTime(a829.Value).ToString(a939("MŌȹ\u036fѬ")).ToString() == a939("5Ĵȹ\u0332б") && Convert.ToDateTime(a828.Value).ToString(a939("MŌȹ\u036fѬ")).ToString() == a939("5Ĵȹ\u0332б"))
		{
			SqlCommand a2269 = a1344.a1271;
			string commandText = a2269.CommandText;
			a2269.CommandText = commandText + a939("3ņȠ\u033eћՏ\u065f\u0745ࡃप\u0a4b\u0b4d\u0c53\u0d51เཁ၍ᄢሦ") + Convert.ToDateTime(a829.Value).ToString(a939("sŰɱ;ЫՈىܮࡦ॥")) + a939(" ĦɄ\u034aчԢئ") + Convert.ToDateTime(a828.Value).AddDays(1.0).ToString(a939("sŰɱ;ЫՈىܮࡦ॥")) + a939("&");
		}
		else
		{
			SqlCommand a2270 = a1344.a1271;
			string commandText = a2270.CommandText;
			a2270.CommandText = commandText + a939("3ņȠ\u033eћՏ\u065f\u0745ࡃप\u0a4b\u0b4d\u0c53\u0d51เཁ၍ᄢሦ") + Convert.ToDateTime(a829.Value).ToString(a939("iŶɷʹСՆهܤ\u086c\u0963ਦ\u0b4d\u0c4cഹ\u0e6fཬ")) + a939(" ĦɄ\u034aчԢئ") + Convert.ToDateTime(a828.Value).ToString(a939("iŶɷʹСՆهܤ\u086c\u0963ਦ\u0b4d\u0c4cഹ\u0e6fཬ")) + a939("&");
		}
		if (a837.Text != a939("MšɳͱѨ"))
		{
			SqlCommand a2271 = a1344.a1271;
			a2271.CommandText = a2271.CommandText + a939("0Ŏɀ\u0349Ь՟ػܧ\u085d\u0954\u0a43\u0b57\u0c4d\u0d47฿༦") + a836.Text + a939("%ġ");
		}
		a1344.a1271.CommandText += a939("2Şɂ\u034bы՟ج\u0749ࡓऩ\u0a41\u0b43ద\u0d41แཐ၁ᄡ");
		DataTable dataSource = a2147.a2105(a1344.a1271);
		a854.DataSource = dataSource;
		a855.BestFitColumns();
	}

	public void a904()
	{
		a1344.a1307();
		a1344.a1271.CommandText = a939("\u0085Ƿ\u02e6ϮӤףۋ\u07be\u08d4\u09d8ષ\u0bce\u0cd8\u0dcaໞ\u0fde\u10c6ᇕዒᏆᒽᗛᛎៜᣙ᧓\u1ac4ᯄ\u1cca\u1dcdỌ\u1fcf\u20da⇆⋂⏉Ⓢ◙☺❒⠩⤩⨯⬻Ⱛⵔ⸼⼷〧ㄠ㈬㌡㐾㔾㘽㜯㠦㤥㨴㬨㰨㴣㸮㼿䀠䅈䉃䌩䐴䔬䘓䜟䠓䤕䨘䬓䱤䵰丄伓候儑刐匆呱唑嘋圝堂夕娊嬎屩崎帕弉怈慤或挑搄攒晬朞桪楴橾歨汼洘湾潲瀈煠爂猜瑤畣癪睼硤票稂笊簉絮繵罩聨脄良荭葦蕿虏蝟衏襝註譎谨贸蹀轞遐酆鉖録鑚镙陜靇顁饉驙魕鱀鵌鸺鼶ꀥꅅꉍꍆꐡ");
		if (Convert.ToDateTime(a847.Value).ToString(a939("MŌȹ\u036fѬ")).ToString() == a939("5Ĵȹ\u0332б") && Convert.ToDateTime(a846.Value).ToString(a939("MŌȹ\u036fѬ")).ToString() == a939("5Ĵȹ\u0332б"))
		{
			SqlCommand a2269 = a1344.a1271;
			string commandText = a2269.CommandText;
			a2269.CommandText = commandText + a939("7łȤ\u033aчՓكݙࡇढ़\u0a4c\u0b4d\u0c5fപ\u0e4bཌྷၓᅑቀፁᑍᔢᘦ") + Convert.ToDateTime(a847.Value).ToString(a939("sŰɱ;ЫՈىܮࡦ॥")) + a939(" ĦɄ\u034aчԢئ") + Convert.ToDateTime(a846.Value).AddDays(1.0).ToString(a939("sŰɱ;ЫՈىܮࡦ॥")) + a939("&");
		}
		else
		{
			SqlCommand a2270 = a1344.a1271;
			string commandText = a2270.CommandText;
			a2270.CommandText = commandText + a939("7łȤ\u033aчՓكݙࡇढ़\u0a4c\u0b4d\u0c5fപ\u0e4bཌྷၓᅑቀፁᑍᔢᘦ") + Convert.ToDateTime(a847.Value).ToString(a939("iŶɷʹСՆهܤ\u086c\u0963ਦ\u0b4d\u0c4cഹ\u0e6fཬ")) + a939(" ĦɄ\u034aчԢئ") + Convert.ToDateTime(a846.Value).ToString(a939("iŶɷʹСՆهܤ\u086c\u0963ਦ\u0b4d\u0c4cഹ\u0e6fཬ")) + a939("&");
		}
		a1344.a1271.CommandText += a939("2Şɂ\u034bы՟ج\u0749ࡓऩ\u0a41\u0b43ద\u0d41แཐ၁ᄡ");
		DataTable dataSource = a2147.a2105(a1344.a1271);
		a860.DataSource = dataSource;
	}

	public void a905()
	{
		a1344.a1307();
		a1344.a1271.CommandText = a939("ùƋʒΚҐ\u0597ڇ\u07f2ࢃটઘ\u0b91\u0c83\u0d99ຆྈ\u108cᆚዯᏯᓥᖋᚕជᢓ᧠᪗\u1bf1ᳯ\u1df8ỾῨₙ⇺⋮⎖ⓡ▅⚝⟦⣰⧢⫦⯦Ⲅⶌ\u2ef8\u2fe3・\u31e9㊋㏲㒔㖊㛪㟦㢍㧴㪮㮰㳖㷕㻈㿓䃕䇝䋅䏉䓜䗐䚿䞲䣐䧔䫆䮳䲥䷟从俆僌凋勓厦哄嗀囐埍壘姁娻孞尻崮帴強恙愳戾挥搼攸昶朠桑椧樧欫氿洩湋漣瀭煕爳獗瑋甯瘪眱砨礬稚笌簂紕縟罳聵腸舃茕萛蔛虮蝺蠂褕訃謋谎贘蹫輞逊鄃鈎錋鐉锍阈面頇餒驰魳鰝鵷鹲齩ꁰꅴꉲꍤꐕꕣ\ua67bꝷꡣꥵꨏꭧ걩광깿꼛뀇녣뉮덵둬땨뙦띰롾륩멛묷백봼빏뼫쀷셓쉖썄쑁앚왜읚졔쥈쨣쭚찼촢칟콋큛텁퉏팪푑픵혭흉\ud840\ud952\udaab\udbb9\udcaf\udda9\udeab\udfb3\ue0bd\ue1d4\ue2d7\ue3bd\ue4b4\ue5a6\ue6a7\ue7b5\ue8a3\ue9a5\ueabf\uebd3\uecc5\uedbf\ueeae\uefa6\uf0ac\uf1ab\uf2b3\uf3c6\uf4b1\uf5ab\uf6b3\uf7c2\uf8d0燎杖ﮟﲏﶈﺄﾝ\u008bƍʇΉҔ\u0590ښ\u07f2\u0897\u0982\u0a80ஃ೭ඇຊ\u0f98\u109dᆗኀ᎔ᒐᖔᛣផᢉᦅ\u1aed\u1bfbᲝ\u1df5ỿᾇ\u20ed↉⊙⏽⓴◦⛧⟵⣣⧥⫿⯧⳩ⶅ⺇⾊ヽ㆙㊉㏩㓢㗱㛭㟫㣥㦌㫐㯙㳈㷒㺦㾲䃊䇝䋛䏓䓖䗀䚳䟝䣖䧅䫁䮮䳋䷞仄俇傩凇勀叓哋喤囔埊壄姒娺孞尴崸幆弮恈慖戸挱搠攺昺朶桘楜橏欺汜浂渲漯瀤焭爬猹琡由瘱眷砬祌稛笋簏紉縖罧聱脛舖茅萐蕴蘄蜚蠔褞詯謚豼赢踒輏逄鄍鈌錙鐁锑阑霗頌饽騏鬞鱩鵴鹾齴ꀙꄟꉮꍳꑻꕹ\ua676ꝿ\ua878ꥣꨈꬎ걺굤깮꽤뀉논눖댈둼땡뙮띧롪륿멛뭋뱏뵉빖뼧쀨세쉃썞쑐앚옳융졈쥕쩁쭃채쵟츬켪큞텀퉂퍈퐥핐혲휬\ud858\ud945\udab2\udbbb\udcb6\udda3\udebf\udfaf\ue0ab\ue1ad\ue2ba\ue3cb\ue4c6\ue5d4\ue6a7\ue7ba\ue8b4\ue9be\ueacf\uebc9\ueca4\uedbc\ueebf\uefab\uf0a5\uf1cf\uf2c7\uf3a3\uf4ab\uf5a0\uf6ca\uf7ce\uf8c1領\ufaeeﯰﲄﶉﺐﾖ\u009cƕʒΉҘ\u0591ځލ\u0898ঔ\u0ae3ஃಈඞ\u0e80\u0f8f႓ᇵዯ᎕ᒀᖈᚆខᢕ᧠\u1afe\u1bfa\u1cf4ᶜỽῨ\u20f6⇵⊗⏯ⓠ◿⛿⟷⣼⧵⫰⯣⳨\u2dfe⻠\u2fefンㆈ㋰㏮㓠㗶㛦㞂㣨㧤㪢㯊㲬㶲㻂㿏䃒䇔䋒䏛䓐䗋䛞䟗䣃䧏䫆䯊䲤䶠享俞傸冦勒叕哀嗖囜埋壅妬娪嬭尸崮帩彇恑愫戲挺搰攷昧杒栰椴樼次水洭港潊瀯焺爨猫瑅由瘰眧砳礳穿笉簕紙縉缟聹脑舓荫萁蕥虽蜇蠂褕訝謑谄贈蹢车適鄜鉶鍨鐌锗阏震頌餟驫魿鱯鵵鹳齳ꀙꄘꉱꍤꑺꕹꘓꝵꡤ\ua97eꩰꭷ걸굧깧꽯끤녭눇덲됔딄뙴띪롤륲멚묾뱜뵏빐뽓쁝셙쉙쌫쐤씴왒읜졕줰쩛쭏챟쵅칃켪큋텍퉓퍑푀핁홍휢\ud826") + Convert.ToDateTime(a873.Text).ToString(a939("sŰɱ;ЫՈىܮࡦ॥")) + a939(" ĦɄ\u034aчԢئ") + Convert.ToDateTime(a872.Text).ToString(a939("sŰɱ;ЫՈىܮࡦ॥")) + a939("%ġ");
		DataTable dataSource = a2147.a2105(a1344.a1271);
		a878.DataSource = dataSource;
	}

	public void a906()
	{
		a1344.a1307();
		a1344.a1271.CommandText = a939("cŪɢ\u0368ѯտ؊ݫࡩ६੯\u0b7cౡ\u0d03\u0e64\u0f73ၯᅒሾ\u135cᑏᕐᙓ\u175dᡙᥕ\u1a57᭞ᱝᵊṗἱ\u205f⅝≊⍈\u245e┫♈❐⠨⥎⩂⬥ⱀⵆ⹑⽂");
		DataTable dataTable = a2147.a2105(a1344.a1271);
		if (dataTable.Rows.Count > 0)
		{
			a851.Text = Convert.ToDecimal(dataTable.Rows[0][a939("Dńɏ\u034aћՄ")]).ToString(a939("lĳ"));
		}
		else
		{
			a851.Text = a939("4ĭȲ\u0331");
		}
	}

	private void a909(object a907, EventArgs a908)
	{
		a903();
	}

	private void a912(object a910, EventArgs a911)
	{
		a854.ShowPreview();
	}

	private void a915(object a913, EventArgs a914)
	{
		Close();
	}

	private void a918(object a916, EventArgs a917)
	{
		a902();
	}

	private void a921(object a919, EventArgs a920)
	{
		a904();
	}

	private void a924(object a922, EventArgs a923)
	{
		a860.ShowPreview();
	}

	private void a927(object a925, EventArgs a926)
	{
		a905();
	}

	private void a930(object a928, EventArgs a929)
	{
		a878.ShowPreview();
	}

	public void a931()
	{
		if (a855.RowCount > 0)
		{
			int num = Convert.ToInt32(a855.GetFocusedRowCellValue(a939("KŅ")));
			int num2 = Convert.ToInt32(a855.GetFocusedRowCellValue(a939("SŖɁ\u0351ыՅ")));
			DateTime a2269 = Convert.ToDateTime(a855.GetFocusedRowCellValue(a939("QŅɑ\u034bщ")));
			DateTime a2270 = DateTime.Now;
			DataTable dataTable = a2147.a2105(a939("|ūɡ\u0369Ѩվ؉ݼࡨॶਅକ\u0c03൶\u0e60\u0f72\u1056ᅖሽፚᑉᕕᙔ\u1738ᡜᥟ\u1a5aᭇ᱘ᵚṐὂ\u202f⅙≅⍉\u2459╏☩❝⡔⥃⩗⭍ⱇⴿ⸦") + num2 + a939("-ĩɉ\u0349тԥ\u064d\u0747࠾द") + num + a939("5ıɟ\u035dъՈ\u065eܫࡈॐਨ\u0b4e\u0c42ഥเཆၑᅂ"));
			if (dataTable.Rows.Count > 0)
			{
				a2270 = Convert.ToDateTime(dataTable.Rows[0][0]);
			}
			a1832 a2271 = new a1832(num2, a2270, a2269);
			a2271.Show();
		}
	}

	private void a934(object a932, EventArgs a933)
	{
	}

	private void a937(object a935, EventArgs a936)
	{
		a931();
	}

	private static string a939(string a938)
	{
		int length = a938.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a938[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
