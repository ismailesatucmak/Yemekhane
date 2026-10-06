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
using a7.a2096;

namespace a7;

public class a1832 : XtraForm
{
	private IContainer a1743 = null;

	private GroupBox a1744;

	private DateTimePicker a1745;

	public Label a1746;

	private DateTimePicker a1747;

	public System.Windows.Forms.ComboBox a1748;

	public System.Windows.Forms.ComboBox a1749;

	public Label a1750;

	public Label a1751;

	public Label a1752;

	public Button a1753;

	public Button a1754;

	private GroupBox a1755;

	public GridControl a1756;

	public GridView a1757;

	public TextBox a1758;

	public Label a1759;

	public TextBox a1760;

	public TextBox a1761;

	public Label a1762;

	public Label a1763;

	public Button a1764;

	private GridColumn a1765;

	private GridColumn a1766;

	private GridColumn a1767;

	private GridColumn a1768;

	private GridColumn a1769;

	private GridColumn a1770;

	private GridColumn a1771;

	private GridColumn a1772;

	private GridColumn a1773;

	private GridColumn a1774;

	private GridColumn a1775;

	private GridColumn a1776;

	private GridColumn a1777;

	private GridColumn a1778;

	private GridColumn a1779;

	private GridColumn a1780;

	public Label a1781;

	private GridColumn a1782;

	private CheckedListBox a1783;

	private CheckedListBox a1784;

	private ContextMenuStrip a1785;

	private ToolStripMenuItem a1786;

	private ToolStripMenuItem a1787;

	public System.Windows.Forms.ComboBox a1788;

	public System.Windows.Forms.ComboBox a1789;

	public Label a1790;

	public Button a1791;

	private GridColumn a1792;

	private GridColumn a1793;

	private int a1794 = 0;

	protected override void Dispose(bool a1795)
	{
		if (a1795 && a1743 != null)
		{
			a1743.Dispose();
		}
		base.Dispose(a1795);
	}

	private void a1796()
	{
		a1743 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(a1832));
		a1744 = new GroupBox();
		a1783 = new CheckedListBox();
		a1784 = new CheckedListBox();
		a1785 = new ContextMenuStrip(a1743);
		a1786 = new ToolStripMenuItem();
		a1787 = new ToolStripMenuItem();
		a1781 = new Label();
		a1758 = new TextBox();
		a1759 = new Label();
		a1760 = new TextBox();
		a1761 = new TextBox();
		a1762 = new Label();
		a1763 = new Label();
		a1764 = new Button();
		a1745 = new DateTimePicker();
		a1746 = new Label();
		a1747 = new DateTimePicker();
		a1788 = new System.Windows.Forms.ComboBox();
		a1748 = new System.Windows.Forms.ComboBox();
		a1789 = new System.Windows.Forms.ComboBox();
		a1749 = new System.Windows.Forms.ComboBox();
		a1750 = new Label();
		a1790 = new Label();
		a1751 = new Label();
		a1752 = new Label();
		a1753 = new Button();
		a1791 = new Button();
		a1754 = new Button();
		a1755 = new GroupBox();
		a1756 = new GridControl();
		a1757 = new GridView();
		a1765 = new GridColumn();
		a1766 = new GridColumn();
		a1767 = new GridColumn();
		a1768 = new GridColumn();
		a1769 = new GridColumn();
		a1770 = new GridColumn();
		a1771 = new GridColumn();
		a1772 = new GridColumn();
		a1773 = new GridColumn();
		a1774 = new GridColumn();
		a1775 = new GridColumn();
		a1776 = new GridColumn();
		a1777 = new GridColumn();
		a1778 = new GridColumn();
		a1779 = new GridColumn();
		a1780 = new GridColumn();
		a1782 = new GridColumn();
		a1792 = new GridColumn();
		a1793 = new GridColumn();
		a1744.SuspendLayout();
		a1785.SuspendLayout();
		a1755.SuspendLayout();
		((ISupportInitialize)a1756).BeginInit();
		((ISupportInitialize)a1757).BeginInit();
		SuspendLayout();
		a1744.Controls.Add(a1783);
		a1744.Controls.Add(a1784);
		a1744.Controls.Add(a1781);
		a1744.Controls.Add(a1758);
		a1744.Controls.Add(a1759);
		a1744.Controls.Add(a1760);
		a1744.Controls.Add(a1761);
		a1744.Controls.Add(a1762);
		a1744.Controls.Add(a1763);
		a1744.Controls.Add(a1764);
		a1744.Controls.Add(a1745);
		a1744.Controls.Add(a1746);
		a1744.Controls.Add(a1747);
		a1744.Controls.Add(a1788);
		a1744.Controls.Add(a1748);
		a1744.Controls.Add(a1789);
		a1744.Controls.Add(a1749);
		a1744.Controls.Add(a1750);
		a1744.Controls.Add(a1790);
		a1744.Controls.Add(a1751);
		a1744.Controls.Add(a1752);
		a1744.Controls.Add(a1753);
		a1744.Controls.Add(a1791);
		a1744.Controls.Add(a1754);
		a1744.Dock = DockStyle.Left;
		a1744.Location = new Point(0, 0);
		a1744.Name = a1831("nźɨͳѵՆ٬ݺ࠲");
		a1744.Size = new Size(317, 644);
		a1744.TabIndex = 2;
		a1744.TabStop = false;
		a1744.Text = a1831("Mţɥ\u0361ѳմ٠ݨࡦ९\u0a64");
		a1783.BorderStyle = BorderStyle.FixedSingle;
		a1783.CheckOnClick = true;
		a1783.Font = new Font(a1831("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1783.FormattingEnabled = true;
		a1783.Location = new Point(380, 116);
		a1783.Name = a1831("rŸɃ\u0367Ѿոـݫࡻॼ\u0a40୴\u0c70൦\u0e76ཋ၅");
		a1783.Size = new Size(98, 66);
		a1783.TabIndex = 93;
		a1784.BorderStyle = BorderStyle.FixedSingle;
		a1784.CheckOnClick = true;
		a1784.ContextMenuStrip = a1785;
		a1784.Font = new Font(a1831("RŤɬ\u036cѯՠ"), 8f);
		a1784.FormattingEnabled = true;
		a1784.Location = new Point(84, 122);
		a1784.Name = a1831("lŦɁ\u0365Ѹվقݩࡵॲ\u0a42୶\u0c76ൠ\u0e74");
		a1784.Size = new Size(230, 212);
		a1784.TabIndex = 92;
		a1785.Items.AddRange(new ToolStripItem[2] { a1786, a1787 });
		a1785.Name = a1831("rſɡͺѨմٿ\u0747\u086c०ੲ\u0b55\u0c71൶\u0e6a\u0f72\u1030");
		a1785.Size = new Size(148, 48);
		a1786.Name = a1831("{ŷɅͿѠբ\u065eݸࡹ\u0963\u0a79\u0b45\u0c62൨\u0e70ཌྷၷᅧቬ");
		a1786.Size = new Size(147, 22);
		a1786.Text = a1831("CůɹͻѮը٬ܤࡐ१૦");
		a1786.Click += a1817;
		a1787.Name = a1831("vŸɬ\u0368ѳշٱݜࡷॹ\u0a70ਢౠ\u0d45\u0e7fའ\u1062ᅞቸ፹ᑣᕹᙅᝢᡨᥰᩍ᭷ᱧᵬ");
		a1787.Size = new Size(147, 22);
		a1787.Text = a1831("FŨɼ\u0378ѣէ١ܧࡍ।੨୧ള൳");
		a1787.Click += a1820;
		a1781.AutoSize = true;
		a1781.Location = new Point(3, 198);
		a1781.Name = a1831("jŤɦ\u0366ѮԲ");
		a1781.Size = new Size(59, 13);
		a1781.TabIndex = 78;
		a1781.Text = a1831("AŨɺͳЦՂٶݶࡠॴ");
		a1758.Font = new Font(a1831("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 9.75f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1758.Location = new Point(85, 351);
		a1758.MaxLength = 11;
		a1758.Name = a1831("|ſɲ\u0351ѧՍ٭\u0740");
		a1758.Size = new Size(229, 22);
		a1758.TabIndex = 4;
		a1759.AutoSize = true;
		a1759.Location = new Point(6, 356);
		a1759.Name = a1831("kŧɧ\u0361ѯԳش");
		a1759.Size = new Size(65, 13);
		a1759.TabIndex = 75;
		a1759.Text = a1831("_ĤɊ\u0328щճ٨ݶࡢॱର");
		a1760.Font = new Font(a1831("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 9.75f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1760.Location = new Point(85, 397);
		a1760.MaxLength = 100;
		a1760.Name = a1831("~űɼ\u034cѧշ\u0670ݍ\u086d\u0940");
		a1760.Size = new Size(184, 22);
		a1760.TabIndex = 6;
		a1761.Font = new Font(a1831("Yźɱ\u0363ѿռ١ݫࡸफਖ਼୨౦൴ฦབၡᅱቫ፧"), 9.75f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1761.Location = new Point(85, 374);
		a1761.MaxLength = 100;
		a1761.Name = a1831("yŴɿ\u034bѭա\u0654ݩࡼ॥੧୫\u0c40");
		a1761.Size = new Size(229, 22);
		a1761.TabIndex = 5;
		a1762.AutoSize = true;
		a1762.Location = new Point(6, 380);
		a1762.Name = a1831("kŧɧ\u0361ѯԳط");
		a1762.Size = new Size(57, 13);
		a1762.TabIndex = 73;
		a1762.Text = a1831("Kŭ\u0339\u0327ѕժٽݢࡦ࠰");
		a1763.AutoSize = true;
		a1763.Location = new Point(6, 402);
		a1763.Name = a1831("kŧɧ\u0361ѯԳض");
		a1763.Size = new Size(74, 13);
		a1763.TabIndex = 74;
		a1763.Text = a1831("Fŭɹ;ЩՆٲݫࡤॶ\u0a62ୱര");
		a1764.Image = a2268.a2305;
		a1764.ImageAlign = ContentAlignment.MiddleLeft;
		a1764.Location = new Point(269, 396);
		a1764.Name = a1831("dűɪ\u0342Ѱՠ");
		a1764.Size = new Size(46, 24);
		a1764.TabIndex = 7;
		a1764.UseVisualStyleBackColor = true;
		a1764.Click += a1814;
		a1745.CustomFormat = a1831("vŵȰ\u0342уՀفܫࡳ॰\u0a71\u0b7eద\u0d4d\u0e4c\u0f39ၯᅬ");
		a1745.Font = new Font(a1831("RŤɬ\u036cѯՠ"), 10f);
		a1745.Format = DateTimePickerFormat.Custom;
		a1745.Location = new Point(84, 72);
		a1745.Name = a1831("lųɄ\u036cѰ\u0557٣ݳ");
		a1745.Size = new Size(230, 24);
		a1745.TabIndex = 2;
		a1746.BackColor = Color.FromArgb(128, 255, 128);
		a1746.BorderStyle = BorderStyle.Fixed3D;
		a1746.FlatStyle = FlatStyle.Flat;
		a1746.ForeColor = Color.DarkOrange;
		a1746.Location = new Point(2, 340);
		a1746.Name = a1831("kŧɧ\u0361ѯԳز");
		a1746.Size = new Size(312, 3);
		a1746.TabIndex = 55;
		a1747.CustomFormat = a1831("vŵȰ\u0342уՀفܫࡳ॰\u0a71\u0b7eద\u0d4d\u0e4c\u0f39ၯᅬ");
		a1747.Font = new Font(a1831("RŤɬ\u036cѯՠ"), 10f);
		a1747.Format = DateTimePickerFormat.Custom;
		a1747.ImeMode = ImeMode.NoControl;
		a1747.Location = new Point(84, 47);
		a1747.Name = a1831("lųɄ\u0364ѷ\u0557٣ݳ");
		a1747.Size = new Size(230, 24);
		a1747.TabIndex = 1;
		a1788.DropDownStyle = ComboBoxStyle.DropDownList;
		a1788.Font = new Font(a1831("RŤɬ\u036cѯՠ"), 14.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1788.FormattingEnabled = true;
		a1788.Location = new Point(443, 54);
		a1788.Name = a1831("oũɚ\u036cѺմ٩ݫࡡ९\u0a4b\u0b45");
		a1788.Size = new Size(41, 31);
		a1788.TabIndex = 67;
		a1748.DropDownStyle = ComboBoxStyle.DropDownList;
		a1748.Font = new Font(a1831("RŤɬ\u036cѯՠ"), 14.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1748.FormattingEnabled = true;
		a1748.Location = new Point(443, 20);
		a1748.Name = a1831("iūɅ\u0362Ѵծ١ݹࡋ\u0945");
		a1748.Size = new Size(41, 31);
		a1748.TabIndex = 67;
		a1789.DropDownStyle = ComboBoxStyle.DropDownList;
		a1789.Font = new Font(a1831("RŤɬ\u036cѯՠ"), 10f);
		a1789.FormattingEnabled = true;
		a1789.Location = new Point(84, 97);
		a1789.Name = a1831("iūɘ\u0362Ѵն٫ݭࡧ७");
		a1789.Size = new Size(230, 24);
		a1789.TabIndex = 0;
		a1749.DropDownStyle = ComboBoxStyle.DropDownList;
		a1749.Font = new Font(a1831("RŤɬ\u036cѯՠ"), 10f);
		a1749.FormattingEnabled = true;
		a1749.Location = new Point(84, 22);
		a1749.Name = a1831("kťɋ\u0360Ѷը٧ݻ");
		a1749.Size = new Size(230, 24);
		a1749.TabIndex = 0;
		a1749.SelectedIndexChanged += a1823;
		a1750.AutoSize = true;
		a1750.Location = new Point(4, 81);
		a1750.Name = a1831("jŤɦ\u0366ѮԳ");
		a1750.Size = new Size(55, 13);
		a1750.TabIndex = 66;
		a1750.Text = a1831("NŢɾ\u0360\u0557ԧ\u0652ݤࡶ४੪୨");
		a1790.AutoSize = true;
		a1790.Location = new Point(4, 106);
		a1790.Name = a1831("jŤɦ\u0366ѮԴ");
		a1790.Size = new Size(48, 13);
		a1790.TabIndex = 66;
		a1790.Text = a1831("XŢɴͶѫխ٧ݭ");
		a1751.AutoSize = true;
		a1751.Location = new Point(4, 56);
		a1751.Name = a1831("jŤɦ\u0366Ѯ\u0530");
		a1751.Size = new Size(57, 13);
		a1751.TabIndex = 66;
		a1751.Text = a1831("Iū\u0356\u0326ЧՒ٤ݶࡪ४੨");
		a1752.AutoSize = true;
		a1752.Location = new Point(4, 31);
		a1752.Name = a1831("jŤɦ\u0366ѮԵ");
		a1752.Size = new Size(41, 13);
		a1752.TabIndex = 66;
		a1752.Text = a1831("KŠɶ\u0368ѧջ");
		a1753.Image = a2268.a2312;
		a1753.ImageAlign = ContentAlignment.MiddleLeft;
		a1753.Location = new Point(156, 510);
		a1753.Name = a1831("jųɨ\u0340Ѽՠ٧ݭ");
		a1753.Size = new Size(158, 40);
		a1753.TabIndex = 9;
		a1753.Text = a1831("Yūɹ\u0367ѵԦلݯࡷ\u0963ੳ");
		a1753.UseVisualStyleBackColor = true;
		a1753.Click += a1808;
		a1791.Image = a2268.a2280;
		a1791.ImageAlign = ContentAlignment.MiddleLeft;
		a1791.Location = new Point(156, 432);
		a1791.Name = a1831("oŸɥ\u0341Ѡջٮݍࡤॽ੪ୱ౨");
		a1791.Size = new Size(158, 40);
		a1791.TabIndex = 8;
		a1791.Text = a1831("@ţ\u0356\u0361ЧՕ٤ݽलॱର");
		a1791.UseVisualStyleBackColor = true;
		a1791.Click += a1826;
		a1754.Image = a2268.a2280;
		a1754.ImageAlign = ContentAlignment.MiddleLeft;
		a1754.Location = new Point(156, 471);
		a1754.Name = a1831("hŽɦ\u0354ѩշ٣ݶ\u086eॠ");
		a1754.Size = new Size(158, 40);
		a1754.TabIndex = 8;
		a1754.Text = a1831("_ŭɻ\u0365ѻԨ\u0654ݩࡷ\u0963੶୮ౠ");
		a1754.UseVisualStyleBackColor = true;
		a1754.Click += a1805;
		a1755.Controls.Add(a1756);
		a1755.Dock = DockStyle.Fill;
		a1755.Location = new Point(317, 0);
		a1755.Name = a1831("nźɨͳѵՆ٬ݺ࠰");
		a1755.Size = new Size(1053, 644);
		a1755.TabIndex = 1;
		a1755.TabStop = false;
		a1755.Text = a1831("0ŝɯͽѣչتݚࡧ३ੳ\u0be2౨\u0d62\u0e70ะ");
		a1756.Dock = DockStyle.Fill;
		a1756.EmbeddedNavigator.Name = a1831("");
		a1756.Font = new Font(a1831("RŤɬ\u036cѯՠ"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		a1756.Location = new Point(3, 17);
		a1756.LookAndFeel.SkinName = a1831("GżɻͳѯՖ٭ݨ\u086b९");
		a1756.LookAndFeel.UseDefaultLookAndFeel = false;
		a1756.MainView = a1757;
		a1756.Name = a1831("kŹɣ\u036dыը٨ݱࡶ६੮ର");
		a1756.Size = new Size(1047, 624);
		a1756.TabIndex = 56;
		a1756.ViewCollection.AddRange(new BaseView[1] { a1757 });
		a1757.BorderStyle = BorderStyles.NoBorder;
		a1757.Columns.AddRange(new GridColumn[19]
		{
			a1765, a1766, a1767, a1768, a1769, a1770, a1771, a1772, a1773, a1774,
			a1775, a1776, a1777, a1778, a1779, a1780, a1782, a1792, a1793
		});
		a1757.FocusRectStyle = DrawFocusRectStyle.RowFocus;
		a1757.GridControl = a1756;
		a1757.Name = a1831("nźɮ\u0362ѓխ٦ݵ࠰");
		a1757.OptionsBehavior.Editable = false;
		a1757.OptionsFilter.AllowFilterEditor = false;
		a1757.OptionsView.ColumnAutoWidth = false;
		a1757.OptionsView.ShowAutoFilterRow = true;
		a1757.OptionsView.ShowFooter = true;
		a1757.OptionsView.ShowGroupPanel = false;
		a1765.Caption = a1831("KŅ");
		a1765.FieldName = a1831("KŅ");
		a1765.Name = a1831("lŸɠ\u036cфթ٩ݱ\u086e६ਰ");
		a1766.Caption = a1831("MŬɷ\u036aыՅ");
		a1766.FieldName = a1831("Aŀɛ\u034eъՀ\u0656ݜࡋ\u0945");
		a1766.Name = a1831("lŸɠ\u036cфթ٩ݱ\u086e६ਲ਼");
		a1767.Caption = a1831("PŀɌ\u034e");
		a1767.FieldName = a1831("PŀɌ\u034e");
		a1767.Name = a1831("lŸɠ\u036cфթ٩ݱ\u086e६ਲ");
		a1767.Visible = true;
		a1767.VisibleIndex = 13;
		a1767.Width = 74;
		a1768.Caption = a1831("BŦ\u0330");
		a1768.FieldName = a1831("BņɈ");
		a1768.Name = a1831("lŸɠ\u036cфթ٩ݱ\u086e६ਵ");
		a1768.Visible = true;
		a1768.VisibleIndex = 2;
		a1768.Width = 83;
		a1769.Caption = a1831("LŧɷͰУՌٮ");
		a1769.FieldName = a1831("Bŉɕ\u0352ыՋ\u064b\u0747\u0859");
		a1769.Name = a1831("lŸɠ\u036cфթ٩ݱ\u086e६\u0a34");
		a1769.SummaryItem.SummaryType = SummaryItemType.Count;
		a1769.Visible = true;
		a1769.VisibleIndex = 1;
		a1769.Width = 98;
		a1770.Caption = a1831("AŷɱͳыՅ");
		a1770.FieldName = a1831("Bŉɕ\u0352њՃ\u0651ݗࡑ");
		a1770.Name = a1831("lŸɠ\u036cфթ٩ݱ\u086e६\u0a37");
		a1771.Caption = a1831("Oŵɳ\u0375ФՂ٦ذ");
		a1771.FieldName = a1831("@Ŕɐ\u0354тՆو");
		a1771.Name = a1831("lŸɠ\u036cфթ٩ݱ\u086e६ਸ਼");
		a1771.Visible = true;
		a1771.VisibleIndex = 4;
		a1771.Width = 96;
		a1772.Caption = a1831("Qťɱ\u036bѩ");
		a1772.DisplayFormat.FormatString = a1831("tūȣ\u0340сԦٳݰࡱॾਦ\u0b4d\u0c4cഹ\u0e6fཬ");
		a1772.DisplayFormat.FormatType = FormatType.DateTime;
		a1772.FieldName = a1831("]ŉɕ\u034fэ\u0557ق\u0743ࡕ");
		a1772.Name = a1831("lŸɠ\u036cфթ٩ݱ\u086e६ਹ");
		a1772.Visible = true;
		a1772.VisibleIndex = 7;
		a1772.Width = 86;
		a1773.Caption = a1831("VŻɦ\u0360Ѯէ٬ܨࠨद\u0a4c୴౷\u0d63\u0e6d");
		a1773.FieldName = a1831("IŚɅ\u0341щՆ\u064fݖࡃ\u0952\u0a4a\u0b49\u0c45\u0d4d\u0e4bཌ");
		a1773.Name = a1831("lŸɠ\u036cфթ٩ݱ\u086e६ਸ");
		a1773.Visible = true;
		a1773.VisibleIndex = 12;
		a1773.Width = 119;
		a1774.AppearanceHeader.Options.UseTextOptions = true;
		a1774.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Far;
		a1774.Caption = a1831("ÛŢɨ\u036fѢաا\u0744ࡤ९੪\u0b7b\u0c64");
		a1774.FieldName = a1831("YŐɂ\u035bёՂق\u0748ࡏ\u0942\u0a41\u0b58\u0c44\u0d44๏ཊၛᅄ");
		a1774.Name = a1831("kŹɣ\u036dыը٪ݰࡩ७ਲ਼\u0b31");
		a1774.Visible = true;
		a1774.VisibleIndex = 8;
		a1775.AppearanceHeader.Options.UseTextOptions = true;
		a1775.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Far;
		a1775.Caption = a1831("Qűɷ\u0363ѳ");
		a1775.FieldName = a1831("Qőɗ\u0343ѓ");
		a1775.Name = a1831("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ର");
		a1775.SummaryItem.SummaryType = SummaryItemType.Sum;
		a1775.Visible = true;
		a1775.VisibleIndex = 3;
		a1775.Width = 62;
		a1776.AppearanceHeader.Options.UseTextOptions = true;
		a1776.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Far;
		a1776.Caption = a1831("YŦɦ\u0327фդٯݪࡻ।");
		a1776.FieldName = a1831("XœɃ\u0344ѐ՝ق\u0742\u0859\u094b\u0a42\u0b41ౘ\u0d44ไཏ၊ᅛቄ");
		a1776.Name = a1831("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଳ");
		a1776.Visible = true;
		a1776.VisibleIndex = 9;
		a1776.Width = 80;
		a1777.Caption = a1831("EŢɴ\u036eѡչ\u064b\u0745");
		a1777.FieldName = a1831("WŘɇ\u0347яՄ\u064dݘࡋ\u0940\u0a56ଡ଼\u0c4b\u0d45");
		a1777.Name = a1831("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଲ");
		a1778.Caption = a1831("GŬɺ\u036cѣտؤ\u0742ࡦ࠰");
		a1778.FieldName = a1831("Dōɕ\u034dр՞ق\u0746ࡈ");
		a1778.Name = a1831("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଵ");
		a1778.Visible = true;
		a1778.VisibleIndex = 10;
		a1778.Width = 130;
		a1779.Caption = a1831("SŶɡͱыՅ");
		a1779.FieldName = a1831("SŖɁ\u0351ыՅ");
		a1779.Name = a1831("kŹɣ\u036dыը٪ݰࡩ७ਲ਼\u0b34");
		a1780.Caption = a1831("XŢɴͶѫխ٧ݭ");
		a1780.FieldName = a1831("Rŕɀ\u0356тՆو");
		a1780.Name = a1831("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଷ");
		a1780.Visible = true;
		a1780.VisibleIndex = 11;
		a1780.Width = 113;
		a1782.Caption = a1831("W2ɰ\u0360");
		a1782.FieldName = a1831("WŊɐ\u0340");
		a1782.Name = a1831("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ଶ");
		a1782.Visible = true;
		a1782.VisibleIndex = 0;
		a1782.Width = 71;
		a1792.Caption = a1831("V5ɭȳѧ");
		a1792.FieldName = a1831("Vōɍ\u034bч");
		a1792.Name = a1831("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ହ");
		a1792.OptionsColumn.AllowEdit = false;
		a1792.Visible = true;
		a1792.VisibleIndex = 6;
		a1793.Caption = a1831("GǲɯϾѬ");
		a1793.FieldName = a1831("Gŋɏ\u0357ь");
		a1793.Name = a1831("kŹɣ\u036dыը٪ݰࡩ७ਲ਼ସ");
		a1793.OptionsColumn.AllowEdit = false;
		a1793.Visible = true;
		a1793.VisibleIndex = 5;
		Appearance.BackColor = Color.White;
		Appearance.Options.UseBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1370, 644);
		Controls.Add(a1755);
		Controls.Add(a1744);
		Icon = (Icon)componentResourceManager.GetObject(a1831(".Žɠ\u036eѵԫ\u064dݠ\u086d९"));
		Name = a1831("Kžɦ\u034eѦդٲݫࡗ॥ੳ୭\u0c73");
		ShowIcon = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = a1831("Kšɡ\u0379ѦԪ\u065bݩࡷ३\u0a77୨\u0c62൰༰");
		WindowState = FormWindowState.Maximized;
		Shown += a1829;
		a1744.ResumeLayout(performLayout: false);
		a1744.PerformLayout();
		a1785.ResumeLayout(performLayout: false);
		a1755.ResumeLayout(performLayout: false);
		((ISupportInitialize)a1756).EndInit();
		((ISupportInitialize)a1757).EndInit();
		ResumeLayout(performLayout: false);
	}

	public a1832(int a1797, DateTime a1798, DateTime a1799)
	{
		a1796();
		a1794 = a1797;
		a1984.a1891(this);
		a1984.a1964(a1831("rťɓ\u035bўՈػݓ\u085dऴ\u0a56\u0b52\u0c5cഴ๕ཀ\u105eᅝሯፗᑘᕇᙇᝏᡄ᥍\u1a58ᭋ᱀ᵖṈ\u1f47⁛"), a1748, a1749, a1831("1"), a1831("MšɳͱѨ"));
		a1984.a1975(a1831("fűɿͷѲդ؏ݧࡩ\u0900\u0a60୫౻ർ\u0e78ཡၷᅱታ\u137dᑠᕤᙖ\u173eᡛ᥎ᩔ᭗\u1c39ᵓṖὄ⁁⅋≔⍀⑄╀☯❙⡅⥉⩙⭏Ⱙⵉ⹌⽒がㅂ㈾㌳㐡"), a1783, a1784);
		for (int i = 0; i < a1784.Items.Count; i++)
		{
			a1784.SetItemChecked(i, value: true);
		}
		a1747.Text = DateTime.Now.Date.ToString();
		a1745.Text = DateTime.Now.Date.ToString();
		if (a1344.a1287)
		{
			a1748.SelectedIndex = a1748.Items.IndexOf(a1344.a1272.ToString());
			if (a1748.SelectedIndex != -1)
			{
				a1749.SelectedIndex = a1748.SelectedIndex;
			}
			a1749.Enabled = false;
		}
		if (a1797 > 0)
		{
			a1789.SelectedIndex = a1788.Items.IndexOf(a1797.ToString());
			a1747.Value = a1798;
			a1745.Value = a1799;
		}
	}

	public void a1800()
	{
		if (a1749.Text == a1831("MšɳͱѨ"))
		{
			a1984.a1964(a1831("~ũɧ\u036fѪռ؇ݯࡡई\u0a62୦\u0c72൯ๆཟ\u1059ᄼቝፈᑖᕕᘷᝃᡆᥑᩁ\u1b41\u1c31ᵇṇὋ\u205fⅉ∫⍋⑂╜♎❀⠸⤣⨲⬥Ⱑ"), a1788, a1789, a1831("1"), a1831("MšɳͱѨ"));
			return;
		}
		a1748.SelectedIndex = a1748.SelectedIndex;
		a1984.a1964(a1831("\u0012ąɳͻѾը؛ݳࡽऔ੶୲౦ൻ\u0e6a\u0f73ၵᄐቩ፼ᑢᕡᘋ\u177f\u187aᥭ\u1a75᭵ᰅᵳṫὧ\u2073Ⅵ∿⍟\u2456╈♒❜⠤⤿⨦⬱ⰵⵕ⹝⽖〱ㅉ㉚㍅㑁㕉㙆㝏㡖㥅㩂㭔㱚㵍㹇㼿䀦") + a1748.Text + a1831("%ġ"), a1788, a1789, a1831("1"), a1831("MšɳͱѨ"));
	}

	public void a1801()
	{
		for (int i = 0; i < a1784.Items.Count; i++)
		{
			a1783.SetItemCheckState(i, a1784.GetItemCheckState(i));
		}
		string text = a1831("");
		for (int i = 0; i < a1783.CheckedItems.Count; i++)
		{
			text = text + a1783.CheckedItems[i].ToString() + a1831("-");
		}
		a1344.a1307();
		a1344.a1271.CommandText = a1831("\0Ōɛ\u0351љ\u0558\u064e\u0739ࡊक़\u0a41\u0b4aౚ\u0d46\u0e5fནၕᅝሦጤᐬᕄᙜᝌᡚ\u1927ᨮᭊ᱖ᵇṇὓ†↽⊧⏝⒨◊⛔➭⢹⦥⪿⮽ⲧⶲ⺳⾥ベ㇏㊽㎤㒾㖪㛊㟅㢼㧖㫈㮬㲠㷏㺶㿐䃎䆔䊗䎎䒕䖗䚟䞋䢇䦞䪒䯹䳴䶇云侟傟凲劚叿哢喟嚉垂墁妊媊完岏巯廢往悄懶抃揩撎斕曻柽棫槸櫯毴泰涟溒濥炂熁狽珤瓢痢盬瞅碈秳窔箋糦緬绮翴胭膳芾菉蒭薵蛑蟘裊觃諘诚賜跖車辽郄醾銠鏆铍闙雞韖飏駕髓鯕鲨鶣黅鿓ꃕꄯꈿꌹꐵꕆꙒꜪ\ua83dꤻ\uaa33ꬶ갠굓긹꼰뀢넻눱댪됾딾똺뜶렩뤣먯뭅밢봱븭뼬쁀섔숟쌏쐈씄옝윋젍줇쩶쬂찜촖츀켔큰턆툊퍰퐘핺홤휂\ud809\ud915\uda12\udb1a\udc03\udd11\ude17\udf11\ue069\ue113\ue21e\ue369\ue40d\ue515\ue66e\ue778\ue86a\ue97e\uea7e\ueb66\uec75\ued72\uee66\uef1d\uf064\uf11e\uf200\uf374\uf479\uf560\uf666\uf76c\uf865異啕ﭮﱱﵯ\ufe6e｠nŖɓ\u0331шԪشݒ\u0859\u0945\u0a42\u0b4a\u0c5b൝๑པၛᅆቑፏᑍᕀᙃᝐᡍ\u192bᨦ᭑\u1c35ᴭṖὔ\u2054↾⊬⏑⒨◊⛔➲⢹⦥⪢⮪ⲧⶼ⺼⾣ケㆤ㊧㎲㒮㖪㚡㞠㢱㦢㫊㮱㳕㷍㺻㾴䂫䆓䊛䎐䒙䖄䚗䞜䢊䦈䪟䮑䳸䷳亟侔傂冄劋厗咍喏嚃埴壠妔媃安岁嶀庖忡悁懻拷掝擺早曵柴梘槮櫣毾泸淶滿濴烯燢狫珿瓧痮盰瞉磿积竣篷糡綃绫翥肝臋芯莳蓅藎蛑蟕裝觚諓诊賙跖軀迎郙釋銧鎡钬闟隻鞧飝駔髃鯗鳍鷇麮鿔ꃓꄺꈬꌼꐸꔲꙇꝑ꠫ꤲ\uaa3aꬰ갷괧깒꼰뀴넼눡댴됭딯뙊뜯렺뤨먫뭅백봰븧뼳쀳셿숉쌕쐙씉옟읹접줓쩫쬁챥쵽츇켂퀕턝툇팉푥핫혌휛\ud807\ud90a\uda66\udb09\udc0b\udd04\ude1d\udf11\ue001\ue16d\ue27f\ue31d\ue468\ue50a\ue61a\ue775\ue87d\ue971\uea62\ueb15\uec7e\ued7c\uee7b\uef7f\uf010\uf164\uf267\uf37e\uf465\uf567\uf66f\uf77b\uf808拾﨔ﬅﱫﵭ\ufe0aｵ\u0011ıɕ\u035cюՏ\u0654ݖࡐ\u0952\u0a4eନ\u0c40ഡ\u0e3cཚၑᅝቚፃᑃᕃᙏᝑᠡ\u1927ᩑ\u1b4d᱁ᵑṇἡ");
		if (Convert.ToDateTime(a1747.Text).ToString(a1831("MŌȹ\u036fѬ")).ToString() == a1831("5Ĵȹ\u0332б") && Convert.ToDateTime(a1745.Text).ToString(a1831("MŌȹ\u036fѬ")).ToString() == a1831("5Ĵȹ\u0332б"))
		{
			SqlCommand a2269 = a1344.a1271;
			string commandText = a2269.CommandText;
			a2269.CommandText = commandText + a1831("7łȤ\u033aчՓكݙࡇढ़\u0a4c\u0b4d\u0c5fപ\u0e4bཌྷၓᅑቀፁᑍᔢᘦ") + Convert.ToDateTime(a1747.Text).ToString(a1831("sŰɱ;ЫՈىܮࡦ॥")) + a1831(" ĦɄ\u034aчԢئ") + Convert.ToDateTime(a1745.Text).AddDays(1.0).ToString(a1831("sŰɱ;ЫՈىܮࡦ॥")) + a1831("&");
		}
		else
		{
			SqlCommand a2270 = a1344.a1271;
			string commandText = a2270.CommandText;
			a2270.CommandText = commandText + a1831("7łȤ\u033aчՓكݙࡇढ़\u0a4c\u0b4d\u0c5fപ\u0e4bཌྷၓᅑቀፁᑍᔢᘦ") + Convert.ToDateTime(a1747.Text).ToString(a1831("iŶɷʹСՆهܤ\u086c\u0963ਦ\u0b4d\u0c4cഹ\u0e6fཬ")) + a1831(" ĦɄ\u034aчԢئ") + Convert.ToDateTime(a1745.Text).ToString(a1831("iŶɷʹСՆهܤ\u086c\u0963ਦ\u0b4d\u0c4cഹ\u0e6fཬ")) + a1831("&");
		}
		a1344.a1271.CommandText += a1831(")ŉɉ\u0342ХԵؾ\u0733\u0821");
		if (text != a1831(""))
		{
			text = text.Substring(0, text.Length - 1);
			SqlCommand a2271 = a1344.a1271;
			a2271.CommandText = a2271.CommandText + a1831("5ŕɝ\u0356бՄؾܠࡆ\u094dਖ਼\u0b5e\u0c56൏๕ནၕᄤቊፌᐩ") + text + a1831("+ġ");
			if (a1749.Text != a1831("MšɳͱѨ"))
			{
				a1748.SelectedIndex = a1749.SelectedIndex;
				SqlCommand a2272 = a1344.a1271;
				a2272.CommandText = a2272.CommandText + a1831("8Ŗɘ\u0351дՇأ\u073fࡉग़\u0a45\u0b41\u0c49\u0d46๏བ၅ᅂቔፚᑍᕇᘿᜦ") + a1748.Text + a1831("%ġ");
			}
			if (a1789.Text != a1831("MšɳͱѨ"))
			{
				a1788.SelectedIndex = a1789.SelectedIndex;
				SqlCommand a2273 = a1344.a1271;
				a2273.CommandText = a2273.CommandText + a1831("0Ŏɀ\u0349Ь՟ػܧ\u085d\u0954\u0a43\u0b57\u0c4d\u0d47฿༦") + a1788.Text + a1831("%ġ");
			}
			if (a1760.Text != a1831(""))
			{
				SqlCommand a2274 = a1344.a1271;
				a2274.CommandText = a2274.CommandText + a1831("3œɟ\u0354Я՚ؼܢࡀ\u094bਜ਼ଡ଼\u0c49\u0d49\u0e4dཁၛᄿሦ") + a1760.Text + a1831("%ġ");
			}
			if (a1758.Text != a1831(""))
			{
				SqlCommand a2275 = a1344.a1271;
				a2275.CommandText = a2275.CommandText + a1831("8Ŗɘ\u0351дՇؠ\u073fࡄ\u094c\u0a45\u0b44\u0c41\u0d47ใགဨᅋ\u124fፎᑁᔣᘥᜤ") + a1758.Text + a1831("&ĥȡ");
			}
			if (a1761.Text != a1831(""))
			{
				SqlCommand a2276 = a1344.a1271;
				a2276.CommandText = a2276.CommandText + a1831("7ŗɛ\u0350гՆأ\u073eࡎ\u094aਫ਼\u0b43\u0c52\u0d4b\u0e4d༨။ᅏ\u124eፁᐣᔥᘤ") + a1761.Text + a1831("&ĥȡ");
			}
			a1344.a1271.CommandText += a1831("6ŚɆ\u0357їՃذݍࡗभ\u0a58\u0b3aత൝\u0e49ཕ၏ᅍ\u1257ፂᑃᕕ");
			DataTable dataSource = a2147.a2105(a1344.a1271);
			a1756.DataSource = dataSource;
			a1757.BestFitColumns();
		}
		else
		{
			a1756.DataSource = null;
		}
	}

	public void a1802()
	{
		for (int i = 0; i < a1784.Items.Count; i++)
		{
			a1783.SetItemCheckState(i, a1784.GetItemCheckState(i));
		}
		string text = a1831("");
		for (int i = 0; i < a1783.CheckedItems.Count; i++)
		{
			text = text + a1783.CheckedItems[i].ToString() + a1831("-");
		}
		a1344.a1307();
		a1344.a1271.CommandText = a1831("~Ďș\u0317ПԚ،ݷࠂ१\u0a7a\u0b12ఖ\u0d02ฟ༖ဏᄉቬ፫ᐌᔛᘇᜊᡦᤉᨋ\u1b04ᰝᴑḁὭⁿℝ≨⌊␚╵♽❱⡢⤕⩾⭼ⱻ\u2d7f⸐⽤でㅾ㉥㍧㑯㕻㘈㝳㠔㤅㩫㭭㰊㵵㸑㼱䁕䅜䉎䍏䑔䕖䙐䝒䡎䤨䩀䬡䰼䵚乑佝做元剃千呏啑嘡圧塑奍婁孑屇崡");
		if (Convert.ToDateTime(a1747.Text).ToString(a1831("MŌȹ\u036fѬ")).ToString() == a1831("5Ĵȹ\u0332б") && Convert.ToDateTime(a1745.Text).ToString(a1831("MŌȹ\u036fѬ")).ToString() == a1831("5Ĵȹ\u0332б"))
		{
			SqlCommand a2269 = a1344.a1271;
			string commandText = a2269.CommandText;
			a2269.CommandText = commandText + a1831("7łȤ\u033aчՓكݙࡇढ़\u0a4c\u0b4d\u0c5fപ\u0e4bཌྷၓᅑቀፁᑍᔢᘦ") + Convert.ToDateTime(a1747.Text).ToString(a1831("sŰɱ;ЫՈىܮࡦ॥")) + a1831(" ĦɄ\u034aчԢئ") + Convert.ToDateTime(a1745.Text).AddDays(1.0).ToString(a1831("sŰɱ;ЫՈىܮࡦ॥")) + a1831("&");
		}
		else
		{
			SqlCommand a2270 = a1344.a1271;
			string commandText = a2270.CommandText;
			a2270.CommandText = commandText + a1831("7łȤ\u033aчՓكݙࡇढ़\u0a4c\u0b4d\u0c5fപ\u0e4bཌྷၓᅑቀፁᑍᔢᘦ") + Convert.ToDateTime(a1747.Text).ToString(a1831("iŶɷʹСՆهܤ\u086c\u0963ਦ\u0b4d\u0c4cഹ\u0e6fཬ")) + a1831(" ĦɄ\u034aчԢئ") + Convert.ToDateTime(a1745.Text).ToString(a1831("iŶɷʹСՆهܤ\u086c\u0963ਦ\u0b4d\u0c4cഹ\u0e6fཬ")) + a1831("&");
		}
		a1344.a1271.CommandText += a1831(")ŉɉ\u0342ХԵؾ\u0733\u0821");
		if (text != a1831(""))
		{
			text = text.Substring(0, text.Length - 1);
			SqlCommand a2271 = a1344.a1271;
			a2271.CommandText = a2271.CommandText + a1831("5ŕɝ\u0356бՄؾܠࡆ\u094dਖ਼\u0b5e\u0c56൏๕ནၕᄤቊፌᐩ") + text + a1831("+ġ");
			if (a1749.Text != a1831("MšɳͱѨ"))
			{
				a1748.SelectedIndex = a1749.SelectedIndex;
				SqlCommand a2272 = a1344.a1271;
				a2272.CommandText = a2272.CommandText + a1831("8Ŗɘ\u0351дՇأ\u073fࡉग़\u0a45\u0b41\u0c49\u0d46๏བ၅ᅂቔፚᑍᕇᘿᜦ") + a1748.Text + a1831("%ġ");
			}
			if (a1789.Text != a1831("MšɳͱѨ"))
			{
				a1788.SelectedIndex = a1789.SelectedIndex;
				SqlCommand a2273 = a1344.a1271;
				a2273.CommandText = a2273.CommandText + a1831("0Ŏɀ\u0349Ь՟ػܧ\u085d\u0954\u0a43\u0b57\u0c4d\u0d47฿༦") + a1788.Text + a1831("%ġ");
			}
			if (a1760.Text != a1831(""))
			{
				SqlCommand a2274 = a1344.a1271;
				a2274.CommandText = a2274.CommandText + a1831("3œɟ\u0354Я՚ؼܢࡀ\u094bਜ਼ଡ଼\u0c49\u0d49\u0e4dཁၛᄿሦ") + a1760.Text + a1831("%ġ");
			}
			if (a1758.Text != a1831(""))
			{
				SqlCommand a2275 = a1344.a1271;
				a2275.CommandText = a2275.CommandText + a1831("8Ŗɘ\u0351дՇؠ\u073fࡄ\u094c\u0a45\u0b44\u0c41\u0d47ใགဨᅋ\u124fፎᑁᔣᘥᜤ") + a1758.Text + a1831("&ĥȡ");
			}
			if (a1761.Text != a1831(""))
			{
				SqlCommand a2276 = a1344.a1271;
				a2276.CommandText = a2276.CommandText + a1831("7ŗɛ\u0350гՆأ\u073eࡎ\u094aਫ਼\u0b43\u0c52\u0d4b\u0e4d༨။ᅏ\u124eፁᐣᔥᘤ") + a1761.Text + a1831("&ĥȡ");
			}
			a1344.a1271.CommandText += a1831("5œɁ\u035dфՀد\u074cࡔब\u0a5fସధ\u0d49ใཕ၊ᅝቂፆᐡ");
			DataTable dataTable = a2147.a2105(a1344.a1271);
			a1791.Text = dataTable.Rows.Count.ToString();
		}
		else
		{
			a1756.DataSource = null;
		}
	}

	private void a1805(object a1803, EventArgs a1804)
	{
		a1801();
	}

	private void a1808(object a1806, EventArgs a1807)
	{
		a1756.ShowPreview();
	}

	private void a1811(object a1809, EventArgs a1810)
	{
		Close();
	}

	private void a1814(object a1812, EventArgs a1813)
	{
		a1760.Text = a1344.a1303();
		a1344.CUSTUMERINFO cUSTUMERINFO = new a1344.CUSTUMERINFO();
		cUSTUMERINFO.KARTNOHEX = a1760.Text;
		cUSTUMERINFO.Getir();
		a1761.Text = cUSTUMERINFO.ADSOYAD;
		a1758.Text = cUSTUMERINFO.TCKIMLIK;
	}

	private void a1817(object a1815, EventArgs a1816)
	{
		for (int i = 0; i < a1784.Items.Count; i++)
		{
			a1784.SetItemChecked(i, value: true);
		}
	}

	private void a1820(object a1818, EventArgs a1819)
	{
		for (int i = 0; i < a1784.Items.Count; i++)
		{
			a1784.SetItemChecked(i, value: false);
		}
	}

	private void a1823(object a1821, EventArgs a1822)
	{
		a1800();
	}

	private void a1826(object a1824, EventArgs a1825)
	{
		a1802();
	}

	private void a1829(object a1827, EventArgs a1828)
	{
		if (a1794 > 0)
		{
			a1801();
		}
	}

	private static string a1831(string a1830)
	{
		int length = a1830.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a1830[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
