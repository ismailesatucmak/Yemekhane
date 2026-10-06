using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using a7.a2096;

namespace a7;

public static class a1984
{
	public static GridControl a1835;

	public static GridView a1836;

	public static void a1839(string a1837, ComboBoxEdit a1838)
	{
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a1837;
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		a1838.Properties.Items.Clear();
		while (sqlDataReader.Read())
		{
			if (sqlDataReader.IsDBNull(0))
			{
				a1838.Properties.Items.Add(a1983(""));
			}
			else
			{
				a1838.Properties.Items.Add(sqlDataReader.GetValue(0).ToString());
			}
		}
		sqlDataReader.Close();
		if (a1838.Properties.Items.Count > 0)
		{
			a1838.SelectedIndex = 0;
		}
	}

	public static void a1839(string a1840, System.Windows.Forms.ComboBox a1841)
	{
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a1840;
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		a1841.Items.Clear();
		while (sqlDataReader.Read())
		{
			if (sqlDataReader.IsDBNull(0))
			{
				a1841.Items.Add(a1983(""));
			}
			else
			{
				a1841.Items.Add(sqlDataReader.GetValue(0).ToString());
			}
		}
		sqlDataReader.Close();
		if (a1841.Items.Count > 0)
		{
			a1841.SelectedIndex = 0;
		}
	}

	public static void a1839(string a1842, RepositoryItemComboBox a1843)
	{
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a1842;
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		a1843.Properties.Items.Clear();
		while (sqlDataReader.Read())
		{
			if (sqlDataReader.IsDBNull(0))
			{
				a1843.Items.Add(a1983(""));
			}
			else
			{
				a1843.Items.Add(sqlDataReader.GetValue(0).ToString());
			}
		}
		sqlDataReader.Close();
	}

	public static void a1846(string a1844, ComboBoxEdit a1845)
	{
		OleDbCommand oleDbCommand = new OleDbCommand();
		oleDbCommand.Connection = a2172.a2161;
		oleDbCommand.CommandText = a1844;
		OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
		a1845.Properties.Items.Clear();
		while (oleDbDataReader.Read())
		{
			if (oleDbDataReader.IsDBNull(0))
			{
				a1845.Properties.Items.Add(a1983(""));
			}
			else
			{
				a1845.Properties.Items.Add(oleDbDataReader.GetValue(0).ToString());
			}
		}
		oleDbDataReader.Close();
		if (a1845.Properties.Items.Count > 0)
		{
			a1845.SelectedIndex = 0;
		}
	}

	public static void a1846(string a1847, System.Windows.Forms.ComboBox a1848)
	{
		OleDbCommand oleDbCommand = new OleDbCommand();
		oleDbCommand.Connection = a2172.a2161;
		oleDbCommand.CommandText = a1847;
		OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
		a1848.Items.Clear();
		while (oleDbDataReader.Read())
		{
			if (oleDbDataReader.IsDBNull(0))
			{
				a1848.Items.Add(a1983(""));
			}
			else
			{
				a1848.Items.Add(oleDbDataReader.GetValue(0).ToString());
			}
		}
		oleDbDataReader.Close();
		if (a1848.Items.Count > 0)
		{
			a1848.SelectedIndex = 0;
		}
	}

	public static void a1839(SqlCommand a1849, ComboBoxEdit a1850)
	{
		SqlDataReader sqlDataReader = a1849.ExecuteReader();
		a1850.Properties.Items.Clear();
		while (sqlDataReader.Read())
		{
			if (sqlDataReader.IsDBNull(0))
			{
				a1850.Properties.Items.Add(a1983(""));
			}
			else
			{
				a1850.Properties.Items.Add(sqlDataReader.GetValue(0).ToString());
			}
		}
		sqlDataReader.Close();
		if (a1850.Properties.Items.Count > 0)
		{
			a1850.SelectedIndex = 0;
		}
	}

	public static void a1839(string a1851, ComboBoxEdit a1852, ComboBoxEdit a1853)
	{
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a1851;
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		a1852.Properties.Items.Clear();
		a1853.Properties.Items.Clear();
		while (sqlDataReader.Read())
		{
			if (sqlDataReader.IsDBNull(0))
			{
				a1852.Properties.Items.Add(a1983(""));
			}
			else
			{
				a1852.Properties.Items.Add(sqlDataReader.GetValue(0).ToString());
			}
			if (sqlDataReader.IsDBNull(1))
			{
				a1853.Properties.Items.Add(a1983(""));
			}
			else
			{
				a1853.Properties.Items.Add(sqlDataReader.GetValue(1).ToString());
			}
		}
		sqlDataReader.Close();
		if (a1852.Properties.Items.Count > 0)
		{
			a1852.SelectedIndex = 0;
		}
		if (a1853.Properties.Items.Count > 0)
		{
			a1853.SelectedIndex = 0;
		}
	}

	public static void a1839(string a1854, System.Windows.Forms.ComboBox a1855, System.Windows.Forms.ComboBox a1856)
	{
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a1854;
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		a1855.Items.Clear();
		a1856.Items.Clear();
		while (sqlDataReader.Read())
		{
			if (sqlDataReader.IsDBNull(0))
			{
				a1855.Items.Add(a1983(""));
			}
			else
			{
				a1855.Items.Add(sqlDataReader.GetValue(0).ToString());
			}
			if (sqlDataReader.IsDBNull(1))
			{
				a1856.Items.Add(a1983(""));
			}
			else
			{
				a1856.Items.Add(sqlDataReader.GetValue(1).ToString());
			}
		}
		sqlDataReader.Close();
		if (a1855.Items.Count > 0)
		{
			a1855.SelectedIndex = 0;
		}
		if (a1856.Items.Count > 0)
		{
			a1856.SelectedIndex = 0;
		}
	}

	public static void a1839(string a1857, ComboBoxEdit a1858, ComboBoxEdit a1859, string a1860, string a1861)
	{
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a1857;
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		a1858.Properties.Items.Clear();
		a1859.Properties.Items.Clear();
		while (sqlDataReader.Read())
		{
			if (sqlDataReader.IsDBNull(0))
			{
				a1858.Properties.Items.Add(a1983(""));
			}
			else
			{
				a1858.Properties.Items.Add(sqlDataReader.GetValue(0).ToString());
			}
			if (sqlDataReader.IsDBNull(1))
			{
				a1859.Properties.Items.Add(a1983(""));
			}
			else
			{
				a1859.Properties.Items.Add(sqlDataReader.GetValue(1).ToString());
			}
		}
		sqlDataReader.Close();
		if (a1858.Properties.Items.Count > 0)
		{
			a1858.Properties.Items.Insert(0, a1860);
			a1859.Properties.Items.Insert(0, a1861);
		}
		else
		{
			a1858.Properties.Items.Add(a1860);
			a1859.Properties.Items.Add(a1861);
		}
		a1858.SelectedIndex = 0;
		a1859.SelectedIndex = 0;
	}

	public static void a1839(SqlCommand a1862, ComboBoxEdit a1863, ComboBoxEdit a1864)
	{
		SqlDataReader sqlDataReader = a1862.ExecuteReader();
		a1863.Properties.Items.Clear();
		a1864.Properties.Items.Clear();
		while (sqlDataReader.Read())
		{
			if (sqlDataReader.IsDBNull(0))
			{
				a1863.Properties.Items.Add(a1983(""));
			}
			else
			{
				a1863.Properties.Items.Add(sqlDataReader.GetValue(0).ToString());
			}
			if (sqlDataReader.IsDBNull(1))
			{
				a1864.Properties.Items.Add(a1983(""));
			}
			else
			{
				a1864.Properties.Items.Add(sqlDataReader.GetValue(1).ToString());
			}
		}
		sqlDataReader.Close();
		if (a1863.Properties.Items.Count > 0)
		{
			a1863.SelectedIndex = 0;
		}
		if (a1864.Properties.Items.Count > 0)
		{
			a1864.SelectedIndex = 0;
		}
	}

	public static void a1839(OleDbCommand a1865, ComboBoxEdit a1866, ComboBoxEdit a1867)
	{
		OleDbDataReader oleDbDataReader = a1865.ExecuteReader();
		a1866.Properties.Items.Clear();
		a1867.Properties.Items.Clear();
		while (oleDbDataReader.Read())
		{
			if (oleDbDataReader.IsDBNull(0))
			{
				a1866.Properties.Items.Add(a1983(""));
			}
			else
			{
				a1866.Properties.Items.Add(oleDbDataReader.GetValue(0).ToString());
			}
			if (oleDbDataReader.IsDBNull(1))
			{
				a1867.Properties.Items.Add(a1983(""));
			}
			else
			{
				a1867.Properties.Items.Add(oleDbDataReader.GetValue(1).ToString());
			}
		}
		oleDbDataReader.Close();
		if (a1866.Properties.Items.Count > 0)
		{
			a1866.SelectedIndex = 0;
		}
		if (a1867.Properties.Items.Count > 0)
		{
			a1867.SelectedIndex = 0;
		}
	}

	public static void a1871(string a1868, CheckedListBoxControl a1869, CheckedListBoxControl a1870)
	{
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a1868;
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		a1869.Items.Clear();
		a1870.Items.Clear();
		while (sqlDataReader.Read())
		{
			a1869.Items.Add(sqlDataReader.GetValue(0).ToString(), isChecked: true);
			a1870.Items.Add(sqlDataReader.GetValue(1).ToString(), isChecked: true);
		}
		sqlDataReader.Close();
	}

	public static void a1871(string a1872, CheckedListBoxControl a1873)
	{
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a1872;
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		a1873.Items.Clear();
		while (sqlDataReader.Read())
		{
			a1873.Items.Add(sqlDataReader.GetValue(0).ToString(), isChecked: true);
		}
		sqlDataReader.Close();
	}

	public static void a1871(string a1874, CheckedListBoxControl a1875, CheckedListBoxControl a1876, bool a1877)
	{
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a1874;
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		a1875.Items.Clear();
		a1876.Items.Clear();
		while (sqlDataReader.Read())
		{
			a1875.Items.Add(sqlDataReader.GetValue(0).ToString(), a1877);
			a1876.Items.Add(sqlDataReader.GetValue(1).ToString(), a1877);
		}
		sqlDataReader.Close();
	}

	public static void a1880(CheckedListBoxControl a1878, bool a1879)
	{
		for (int i = 0; i < a1878.Items.Count; i++)
		{
			a1878.SetItemChecked(i, a1879);
		}
	}

	public static string a1885(string a1881, CheckedListBoxControl a1882, CheckedListBoxControl a1883, bool a1884)
	{
		string text = a1983("");
		string text2 = a1983("");
		if (a1884)
		{
			text2 = a1983("&");
		}
		for (int i = 0; i <= a1882.Items.Count - 1; i++)
		{
			if (a1882.GetItemChecked(i))
			{
				if (text == a1983(""))
				{
					text = text2 + a1883.Items[i].ToString() + text2;
					continue;
				}
				string text3 = text;
				text = text3 + a1881 + text2 + a1883.Items[i].ToString() + text2;
			}
		}
		return text;
	}

	public static void a1887(Control a1886)
	{
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected Obj, but got Unknown
		MemoEdit memoEdit;
		float size;
		if (a1886 is MemoEdit)
		{
			memoEdit = a1886 as MemoEdit;
			memoEdit.Properties.AppearanceFocused.BackColor = Color.MistyRose;
			size = memoEdit.Font.Size;
			memoEdit.Properties.AppearanceFocused.Font = new Font(a1983("RŤɬ\u036cѯՠ"), size + 1f, FontStyle.Bold);
			memoEdit.Properties.AppearanceFocused.ForeColor = Color.Black;
			memoEdit.Properties.LookAndFeel.UseDefaultLookAndFeel = true;
			memoEdit.Properties.LookAndFeel.SkinName = a1983("Fťɧ\u036dѾԦ\u0651ݳࡪ६ੲ");
		}
		if (a1886 is GridControl)
		{
			GridControl gridControl = a1886 as GridControl;
			for (int i = 0; i < gridControl.RepositoryItems.Count; i++)
			{
				if (gridControl.RepositoryItems[i] is RepositoryItemTextEdit)
				{
					RepositoryItemTextEdit repositoryItemTextEdit = gridControl.RepositoryItems[i] as RepositoryItemTextEdit;
					MessageBox.Show(repositoryItemTextEdit.Name);
					repositoryItemTextEdit.Enter += a1934;
					repositoryItemTextEdit.MouseUp += a1931;
				}
			}
			if (gridControl.ContextMenuStrip != null)
			{
				ContextMenuStrip contextMenuStrip = gridControl.ContextMenuStrip;
				for (int i = 0; i < contextMenuStrip.Items.Count; i++)
				{
				}
			}
		}
		if (a1886 is ToolStrip)
		{
			ToolStrip toolStrip = a1886 as ToolStrip;
			for (int i = 0; i < toolStrip.Items.Count; i++)
			{
			}
		}
		if (a1886 is GroupBox)
		{
			foreach (Control control in a1886.Controls)
			{
				a1887(control);
			}
		}
		if (a1886 is Panel)
		{
			foreach (Control control2 in a1886.Controls)
			{
				a1887(control2);
			}
		}
		if (a1886 is GroupControl)
		{
			foreach (Control control3 in a1886.Controls)
			{
				a1887(control3);
			}
		}
		if (a1886 is PanelControl)
		{
			foreach (Control control4 in a1886.Controls)
			{
				a1887(control4);
			}
		}
		if (a1886 is XtraTabPage)
		{
			foreach (Control control5 in a1886.Controls)
			{
				a1887(control5);
			}
		}
		if (a1886 is XtraTabControl)
		{
			foreach (Control control6 in a1886.Controls)
			{
				a1887(control6);
			}
		}
		if (a1886 is TextEdit)
		{
			TextEdit textEdit = a1886 as TextEdit;
			textEdit.Properties.AppearanceFocused.BackColor = Color.MistyRose;
			size = textEdit.Font.Size;
			textEdit.Properties.AppearanceFocused.Font = new Font(a1983("RŤɬ\u036cѯՠ"), size + 1f, FontStyle.Bold);
			textEdit.Properties.LookAndFeel.UseDefaultLookAndFeel = true;
			textEdit.Properties.LookAndFeel.SkinName = a1983("Fťɧ\u036dѾԦ\u0651ݳࡪ६ੲ");
			textEdit.MouseUp += a1931;
			textEdit.Enter += a1934;
			if (textEdit is ButtonEdit)
			{
				ButtonEdit buttonEdit = textEdit as ButtonEdit;
				if (buttonEdit.Properties.Buttons.Count > 0)
				{
					buttonEdit.Properties.Buttons[0].Shortcut = new KeyShortcut(Keys.F3);
				}
			}
		}
		if (a1886 is ComboBoxEdit)
		{
			ComboBoxEdit comboBoxEdit = a1886 as ComboBoxEdit;
			comboBoxEdit.Properties.AppearanceFocused.BackColor = Color.MistyRose;
			size = comboBoxEdit.Font.Size;
			comboBoxEdit.Properties.AppearanceFocused.Font = new Font(a1983("RŤɬ\u036cѯՠ"), size + 1f, FontStyle.Bold);
			comboBoxEdit.Properties.LookAndFeel.UseDefaultLookAndFeel = true;
			comboBoxEdit.Properties.LookAndFeel.SkinName = a1983("Fťɧ\u036dѾԦ\u0651ݳࡪ६ੲ");
		}
		if (a1886 is DateEdit)
		{
			DateEdit dateEdit = a1886 as DateEdit;
			dateEdit.Properties.AppearanceFocused.BackColor = Color.MistyRose;
			size = dateEdit.Font.Size;
			dateEdit.Properties.AppearanceFocused.Font = new Font(a1983("RŤɬ\u036cѯՠ"), size + 1f, FontStyle.Bold);
			dateEdit.Properties.LookAndFeel.UseDefaultLookAndFeel = true;
			dateEdit.Properties.LookAndFeel.SkinName = a1983("Fťɧ\u036dѾԦ\u0651ݳࡪ६ੲ");
			if (a1886 is CheckEdit)
			{
				goto IL_06a5;
			}
		}
		else
		{
			memoEdit = (MemoEdit)/*Error near IL_068e: Stack underflow*/;
			if (a1886 is CheckEdit)
			{
				goto IL_06a5;
			}
		}
		memoEdit = (MemoEdit)(/*Error near IL_0726: Stack underflow*/ & /*Error near IL_0726: Stack underflow*/);
		return;
		IL_06a5:
		CheckEdit checkEdit = a1886 as CheckEdit;
		checkEdit.Properties.AppearanceFocused.BackColor = Color.MistyRose;
		size = checkEdit.Font.Size;
		checkEdit.Properties.AppearanceFocused.Font = new Font(a1983("RŤɬ\u036cѯՠ"), size + 1f, FontStyle.Bold);
		checkEdit.Properties.LookAndFeel.UseDefaultLookAndFeel = true;
		checkEdit.Properties.LookAndFeel.SkinName = a1983("Fťɧ\u036dѾԦ\u0651ݳࡪ६ੲ");
	}

	public static void a1889(Control a1888)
	{
		if (a1888 is MemoEdit)
		{
			MemoEdit memoEdit = a1888 as MemoEdit;
		}
		if (a1888 is GridControl)
		{
			GridControl gridControl = a1888 as GridControl;
			GridView gridView = gridControl.Views[0] as GridView;
			gridView.OptionsView.EnableAppearanceEvenRow = true;
			gridView.OptionsView.EnableAppearanceOddRow = true;
			gridView.Appearance.Empty.BackColor = Color.White;
			gridView.Appearance.EvenRow.BackColor = Color.White;
			gridView.Appearance.HorzLine.BackColor = Color.LightGray;
			gridView.Appearance.VertLine.BackColor = Color.LightGray;
			gridView.Appearance.OddRow.BackColor = Color.LightGoldenrodYellow;
			gridView.BorderStyle = BorderStyles.Default;
			gridView.PaintStyleName = a1983("Cţɣ\u0365Ѷծٵ");
			for (int i = 0; i < gridControl.RepositoryItems.Count; i++)
			{
				if (gridControl.RepositoryItems[i] is RepositoryItemTextEdit)
				{
					RepositoryItemTextEdit repositoryItemTextEdit = gridControl.RepositoryItems[i] as RepositoryItemTextEdit;
					repositoryItemTextEdit.Enter += a1934;
					repositoryItemTextEdit.MouseUp += a1931;
				}
			}
			if (gridControl.ContextMenuStrip != null)
			{
				ContextMenuStrip contextMenuStrip = gridControl.ContextMenuStrip;
				for (int i = 0; i < contextMenuStrip.Items.Count; i++)
				{
				}
			}
		}
		if (a1888 is ToolStrip)
		{
			ToolStrip toolStrip = a1888 as ToolStrip;
			for (int i = 0; i < toolStrip.Items.Count; i++)
			{
			}
		}
		if (a1888 is GroupBox)
		{
			foreach (Control control in a1888.Controls)
			{
				a1889(control);
			}
		}
		if (a1888 is Panel)
		{
			foreach (Control control2 in a1888.Controls)
			{
				a1889(control2);
			}
		}
		if (a1888 is GroupControl)
		{
			foreach (Control control3 in a1888.Controls)
			{
				a1887(control3);
			}
		}
		if (a1888 is PanelControl)
		{
			foreach (Control control4 in a1888.Controls)
			{
				a1889(control4);
			}
		}
		if (a1888 is XtraTabPage)
		{
			foreach (Control control5 in a1888.Controls)
			{
				a1889(control5);
			}
		}
		if (a1888 is TabControl)
		{
			foreach (Control control6 in a1888.Controls)
			{
				a1889(control6);
			}
		}
		if (a1888 is TextEdit)
		{
			TextEdit textEdit = a1888 as TextEdit;
			textEdit.MouseUp += a1931;
			if (textEdit.Properties.Mask.MaskType == MaskType.Numeric)
			{
				textEdit.Enter += a1934;
			}
			if (textEdit is ButtonEdit)
			{
				ButtonEdit buttonEdit = textEdit as ButtonEdit;
				if (buttonEdit.Properties.Buttons.Count > 0)
				{
					buttonEdit.Properties.Buttons[0].Shortcut = new KeyShortcut(Keys.F3);
				}
			}
		}
		if (a1888 is ComboBoxEdit)
		{
			ComboBoxEdit comboBoxEdit = a1888 as ComboBoxEdit;
		}
		if (a1888 is CheckedListBoxControl)
		{
			CheckedListBoxControl checkedListBoxControl = a1888 as CheckedListBoxControl;
		}
		if (a1888 is DateEdit)
		{
			DateEdit dateEdit = a1888 as DateEdit;
		}
		if (a1888 is CheckEdit)
		{
			CheckEdit checkEdit = a1888 as CheckEdit;
			checkEdit.Properties.AppearanceFocused.ForeColor = Color.Navy;
			checkEdit.Properties.CheckStyle = CheckStyles.Standard;
			checkEdit.BorderStyle = BorderStyles.NoBorder;
			checkEdit.LookAndFeel.UseDefaultLookAndFeel = true;
			checkEdit.LookAndFeel.UseWindowsXPTheme = false;
		}
	}

	public static void a1891(XtraForm a1890)
	{
		a1890.FormClosing += a1912;
		a1890.KeyDown += a1918;
		a1890.Load += a1928;
		a1890.KeyPreview = true;
		a1891(a1890.Controls);
	}

	public static void a1891(Form a1892)
	{
		a1892.KeyDown += a1925;
		a1892.KeyPreview = true;
		foreach (Control control in a1892.Controls)
		{
			a1889(control);
		}
	}

	private static void a1895(object a1893, EventArgs a1894)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.ShowDialog();
		if (saveFileDialog.FileName != a1983(""))
		{
			a1836.ExportToXls(saveFileDialog.FileName + a1983("*ŻɮͲ"));
		}
	}

	private static void a1898(object a1896, EventArgs a1897)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.ShowDialog();
		if (saveFileDialog.FileName != a1983(""))
		{
			a1836.ExportToPdf(saveFileDialog.FileName + a1983("*ųɦ\u0367"));
		}
	}

	private static void a1901(object a1899, EventArgs a1900)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.ShowDialog();
		if (saveFileDialog.FileName != a1983(""))
		{
			a1836.ExportToHtml(saveFileDialog.FileName + a1983("+Ŭɷ\u036fѭ"));
		}
	}

	private static void a1904(object a1902, EventArgs a1903)
	{
		a1835.ShowPrintPreview();
	}

	private static void a1907(object a1905, EventArgs a1906)
	{
		a1835.ShowPreview();
	}

	public static void a1909(GridView a1908)
	{
		a1908.Appearance.ColumnFilterButton.BackColor = Color.DarkGray;
		a1908.Appearance.ColumnFilterButton.BorderColor = Color.DarkGray;
		a1908.Appearance.ColumnFilterButton.ForeColor = Color.DimGray;
		a1908.Appearance.ColumnFilterButton.Options.UseBackColor = true;
		a1908.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
		a1908.Appearance.ColumnFilterButton.Options.UseForeColor = true;
		a1908.Appearance.ColumnFilterButtonActive.BackColor = Color.DarkGray;
		a1908.Appearance.ColumnFilterButtonActive.BorderColor = Color.DarkGray;
		a1908.Appearance.ColumnFilterButtonActive.ForeColor = Color.Gainsboro;
		a1908.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
		a1908.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
		a1908.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
		a1908.Appearance.Empty.BackColor = Color.DimGray;
		a1908.Appearance.Empty.GradientMode = LinearGradientMode.BackwardDiagonal;
		a1908.Appearance.Empty.Options.UseBackColor = true;
		a1908.Appearance.EvenRow.BackColor = Color.White;
		a1908.Appearance.EvenRow.Options.UseBackColor = true;
		a1908.Appearance.FilterCloseButton.BackColor = Color.Gray;
		a1908.Appearance.FilterCloseButton.BorderColor = Color.Gray;
		a1908.Appearance.FilterCloseButton.Options.UseBackColor = true;
		a1908.Appearance.FilterCloseButton.Options.UseBorderColor = true;
		a1908.Appearance.FilterPanel.BackColor = Color.Gray;
		a1908.Appearance.FilterPanel.ForeColor = Color.Black;
		a1908.Appearance.FilterPanel.Options.UseBackColor = true;
		a1908.Appearance.FilterPanel.Options.UseForeColor = true;
		a1908.Appearance.FocusedRow.BackColor = Color.Black;
		a1908.Appearance.FocusedRow.ForeColor = Color.White;
		a1908.Appearance.FocusedRow.Options.UseBackColor = true;
		a1908.Appearance.FocusedRow.Options.UseForeColor = true;
		a1908.Appearance.FooterPanel.BackColor = Color.DarkGray;
		a1908.Appearance.FooterPanel.BorderColor = Color.DarkGray;
		a1908.Appearance.FooterPanel.Options.UseBackColor = true;
		a1908.Appearance.FooterPanel.Options.UseBorderColor = true;
		a1908.Appearance.GroupButton.BackColor = Color.Silver;
		a1908.Appearance.GroupButton.BorderColor = Color.Silver;
		a1908.Appearance.GroupButton.Options.UseBackColor = true;
		a1908.Appearance.GroupButton.Options.UseBorderColor = true;
		a1908.Appearance.GroupFooter.BackColor = Color.Silver;
		a1908.Appearance.GroupFooter.BorderColor = Color.Silver;
		a1908.Appearance.GroupFooter.Options.UseBackColor = true;
		a1908.Appearance.GroupFooter.Options.UseBorderColor = true;
		a1908.Appearance.GroupPanel.BackColor = Color.DimGray;
		a1908.Appearance.GroupPanel.ForeColor = Color.White;
		a1908.Appearance.GroupPanel.Options.UseBackColor = true;
		a1908.Appearance.GroupPanel.Options.UseForeColor = true;
		a1908.Appearance.GroupRow.BackColor = Color.Silver;
		a1908.Appearance.GroupRow.Font = new Font(a1983("RŤɬ\u036cѯՠ"), 8f, FontStyle.Bold);
		a1908.Appearance.GroupRow.Options.UseBackColor = true;
		a1908.Appearance.GroupRow.Options.UseFont = true;
		a1908.Appearance.HeaderPanel.BackColor = Color.DarkGray;
		a1908.Appearance.HeaderPanel.BorderColor = Color.DarkGray;
		a1908.Appearance.HeaderPanel.Options.UseBackColor = true;
		a1908.Appearance.HeaderPanel.Options.UseBorderColor = true;
		a1908.Appearance.HideSelectionRow.BackColor = Color.LightSlateGray;
		a1908.Appearance.HideSelectionRow.Options.UseBackColor = true;
		a1908.Appearance.HorzLine.BackColor = Color.LightGray;
		a1908.Appearance.HorzLine.Options.UseBackColor = true;
		a1908.Appearance.OddRow.BackColor = Color.WhiteSmoke;
		a1908.Appearance.OddRow.Options.UseBackColor = true;
		a1908.Appearance.Preview.BackColor = Color.Gainsboro;
		a1908.Appearance.Preview.ForeColor = Color.DimGray;
		a1908.Appearance.Preview.Options.UseBackColor = true;
		a1908.Appearance.Preview.Options.UseForeColor = true;
		a1908.Appearance.Row.BackColor = Color.White;
		a1908.Appearance.Row.Options.UseBackColor = true;
		a1908.Appearance.RowSeparator.BackColor = Color.DimGray;
		a1908.Appearance.RowSeparator.Options.UseBackColor = true;
		a1908.Appearance.SelectedRow.BackColor = Color.DimGray;
		a1908.Appearance.SelectedRow.Options.UseBackColor = true;
		a1908.Appearance.VertLine.BackColor = Color.LightGray;
		a1908.Appearance.VertLine.Options.UseBackColor = true;
		a1908.OptionsBehavior.Editable = false;
		a1908.OptionsView.EnableAppearanceEvenRow = true;
		a1908.OptionsView.EnableAppearanceOddRow = true;
		a1908.OptionsView.ShowGroupPanel = false;
	}

	public static void a1912(object a1910, FormClosingEventArgs a1911)
	{
	}

	public static void a1915(object a1913, FormClosingEventArgs a1914)
	{
	}

	public static void a1918(object a1916, KeyEventArgs a1917)
	{
		if (a1917.KeyCode == Keys.F5)
		{
			List<Control> list = a1921(a1916 as XtraForm);
			foreach (Control item in list)
			{
				if (item.Name == a1983("kżɩ\u036dѤս٧ݧࡵ"))
				{
					if ((item as SimpleButton).Visible && (item as SimpleButton).Enabled)
					{
						(item as SimpleButton).PerformClick();
					}
					break;
				}
			}
		}
		if (a1917.KeyCode == Keys.F6)
		{
			List<Control> list = a1921(a1916 as XtraForm);
			foreach (Control item2 in list)
			{
				if (item2.Name == a1983("lŹɢ\u0360ѫհ٬ݢࡲॳ\u0a61ୠ౫൪"))
				{
					if ((item2 as SimpleButton).Visible && (item2 as SimpleButton).Enabled)
					{
						(item2 as SimpleButton).PerformClick();
					}
					break;
				}
			}
		}
		if (a1917.KeyCode == Keys.F7)
		{
			List<Control> list = a1921(a1916 as XtraForm);
			foreach (Control item3 in list)
			{
				if (item3.Name == a1983("ižɧ\u036cѢա٬ݷࡷ५ੳ"))
				{
					if ((item3 as SimpleButton).Visible && (item3 as SimpleButton).Enabled)
					{
						(item3 as SimpleButton).PerformClick();
					}
					break;
				}
			}
		}
		if (a1917.KeyCode == Keys.F8)
		{
			List<Control> list = a1921(a1916 as XtraForm);
			foreach (Control item4 in list)
			{
				if (item4.Name == a1983("dűɪͰѫխ"))
				{
					if ((item4 as SimpleButton).Visible && (item4 as SimpleButton).Enabled)
					{
						(item4 as SimpleButton).PerformClick();
					}
					break;
				}
			}
		}
		if (a1917.KeyCode == Keys.Insert)
		{
			List<Control> list = a1921(a1916 as XtraForm);
			foreach (Control item5 in list)
			{
				if (item5.Name == a1983("nſɤͺѩճٯݷࡡ२੮\u0b64"))
				{
					if ((item5 as SimpleButton).Visible && (item5 as SimpleButton).Enabled)
					{
						(item5 as SimpleButton).PerformClick();
					}
					break;
				}
			}
		}
		if (a1917.Control && a1917.KeyCode == Keys.Delete)
		{
			List<Control> list = a1921(a1916 as XtraForm);
			foreach (Control item6 in list)
			{
				if (item6.Name == a1983("ižɧͻѦղ٬ݶࡰ५੭"))
				{
					if ((item6 as SimpleButton).Visible && (item6 as SimpleButton).Enabled)
					{
						(item6 as SimpleButton).PerformClick();
					}
					break;
				}
			}
		}
		if (a1917.Control && a1917.KeyCode == Keys.F2)
		{
			List<Control> list = a1921(a1916 as XtraForm);
			foreach (Control item7 in list)
			{
				if (item7.Name == a1983("mźɣͿѢպ٨ݺ\u086eॵ\u0a64୯౷\u0d63\u0e73"))
				{
					if ((item7 as SimpleButton).Visible && (item7 as SimpleButton).Enabled)
					{
						(item7 as SimpleButton).PerformClick();
					}
					break;
				}
			}
		}
		if (a1917.KeyCode == Keys.Escape)
		{
			(a1916 as XtraForm).Close();
		}
	}

	public static List<Control> a1921(Control a1919, List<Control> a1920)
	{
		foreach (Control control in a1919.Controls)
		{
			if (control is SimpleButton)
			{
				a1920.Add(control);
			}
			if (control.Controls.Count > 0)
			{
				a1920 = a1921(control, a1920);
			}
		}
		return a1920;
	}

	public static List<Control> a1921(Control a1922)
	{
		return a1921(a1922, new List<Control>());
	}

	public static void a1925(object a1923, KeyEventArgs a1924)
	{
		if (a1924.KeyCode == Keys.F2 && (a1923 as Form).AcceptButton != null)
		{
			(a1923 as Form).AcceptButton.PerformClick();
		}
		if (a1924.KeyCode == Keys.Escape)
		{
			(a1923 as Form).Close();
		}
	}

	public static void a1928(object a1926, EventArgs a1927)
	{
		if ((a1926 as XtraForm).StartPosition == FormStartPosition.Manual || (a1926 as XtraForm).StartPosition == FormStartPosition.WindowsDefaultBounds || (a1926 as XtraForm).StartPosition == FormStartPosition.WindowsDefaultLocation)
		{
			(a1926 as XtraForm).Left = 0;
			(a1926 as XtraForm).Top = 0;
		}
		(a1926 as XtraForm).WindowState = (a1926 as XtraForm).WindowState;
	}

	public static void a1931(object a1929, MouseEventArgs a1930)
	{
		(a1929 as TextEdit).SelectAll();
	}

	public static void a1934(object a1932, EventArgs a1933)
	{
		(a1932 as TextEdit).SelectAll();
	}

	public static void a1938(RichTextBox a1935, int a1936, Color a1937)
	{
		int num = 0;
		int num2 = 0;
		if (a1936 == 0)
		{
			num = 0;
			num2 = a1935.Lines[a1936].Length + 1;
		}
		else
		{
			num = a1935.Lines[a1936 - 1].Length + 1;
			num2 = a1935.Lines[a1936].Length + 1;
		}
		a1935.Select(num, num2 - num);
		a1935.SelectionColor = a1937;
	}

	public static void a1942(RichTextBox a1939, string a1940, Color a1941)
	{
		a1939.SelectionStart = a1939.TextLength;
		a1939.SelectionLength = 0;
		a1939.SelectionColor = a1941;
		a1939.AppendText(a1940);
		a1939.SelectionColor = a1939.ForeColor;
	}

	public static bool a1944(CheckedListBoxControl a1943)
	{
		bool result = false;
		for (int i = 0; i < a1943.Items.Count; i++)
		{
			if (a1943.GetItemChecked(i))
			{
				result = true;
			}
		}
		return result;
	}

	public static void a1948(SqlCommand a1945, Image a1946, string a1947)
	{
		byte[] value;
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			a1946.Save(memoryStream, ImageFormat.Bmp);
			value = memoryStream.ToArray();
		}
		catch
		{
			value = null;
		}
		IDataParameter dataParameter = a1945.CreateParameter();
		dataParameter.ParameterName = a1947;
		dataParameter.DbType = DbType.Binary;
		dataParameter.Value = value;
		a1945.Parameters.Add(dataParameter);
	}

	public static void a1891(Control.ControlCollection a1949)
	{
		foreach (object item in a1949)
		{
			if (item is GroupControl)
			{
				(item as GroupControl).AppearanceCaption.ForeColor = Color.Black;
				a1891((item as GroupControl).Controls);
			}
			if (item is MdiClient)
			{
				(item as MdiClient).BackColor = Color.FromArgb(227, 241, 254);
			}
			if (item is XtraTabControl)
			{
				a1891((item as XtraTabControl).Controls);
			}
			if (item is XtraTabPage)
			{
				a1891((item as XtraTabPage).Controls);
			}
			if (item is GroupBox)
			{
				(item as GroupBox).ForeColor = Color.Black;
				a1891((item as GroupBox).Controls);
			}
			if (item is Panel)
			{
				(item as Panel).ForeColor = Color.Black;
				a1891((item as Panel).Controls);
			}
			if (item is GridControl && (item as GridControl).ContextMenuStrip == null)
			{
				ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(a1983("HŴɨ\u036fѥխا\u0741\u08f3४੧୧\u0c73"), a2268.a2277);
				contextMenuStrip.Items.Add(toolStripMenuItem);
				toolStripMenuItem.Click += a1952;
				ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem(a1983("ZōɎ\u0327с׳٪ݧࡧॳ"), a2268.a2279);
				contextMenuStrip.Items.Add(toolStripMenuItem2);
				toolStripMenuItem2.Click += a1955;
				ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem(a1983("CŞɄ\u0344ЧՁ۳ݪࡧ१ੳ"), a2268.a2281);
				contextMenuStrip.Items.Add(toolStripMenuItem3);
				toolStripMenuItem3.Click += a1958;
				ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem(a1983("Þũ\u0336ͿѨզٯݤ"), a2268.a2283);
				contextMenuStrip.Items.Add(toolStripMenuItem4);
				toolStripMenuItem4.Click += a1961;
				(item as GridControl).ContextMenuStrip = contextMenuStrip;
			}
		}
	}

	private static void a1952(object a1950, EventArgs a1951)
	{
		ToolStripMenuItem toolStripMenuItem = a1950 as ToolStripMenuItem;
		ContextMenuStrip contextMenuStrip = toolStripMenuItem.Owner as ContextMenuStrip;
		GridControl gridControl = contextMenuStrip.SourceControl as GridControl;
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.ShowDialog();
		if (saveFileDialog.FileName != a1983(""))
		{
			gridControl.ExportToXls(saveFileDialog.FileName + a1983("*ŻɮͲ"));
		}
	}

	private static void a1955(object a1953, EventArgs a1954)
	{
		ToolStripMenuItem toolStripMenuItem = a1953 as ToolStripMenuItem;
		ContextMenuStrip contextMenuStrip = toolStripMenuItem.Owner as ContextMenuStrip;
		GridControl gridControl = contextMenuStrip.SourceControl as GridControl;
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.ShowDialog();
		if (saveFileDialog.FileName != a1983(""))
		{
			gridControl.ExportToPdf(saveFileDialog.FileName + a1983("*ųɦ\u0367"));
		}
	}

	private static void a1958(object a1956, EventArgs a1957)
	{
		ToolStripMenuItem toolStripMenuItem = a1956 as ToolStripMenuItem;
		ContextMenuStrip contextMenuStrip = toolStripMenuItem.Owner as ContextMenuStrip;
		GridControl gridControl = contextMenuStrip.SourceControl as GridControl;
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.ShowDialog();
		if (saveFileDialog.FileName != a1983(""))
		{
			gridControl.ExportToHtml(saveFileDialog.FileName + a1983("+Ŭɷ\u036fѭ"));
		}
	}

	private static void a1961(object a1959, EventArgs a1960)
	{
		ToolStripMenuItem toolStripMenuItem = a1959 as ToolStripMenuItem;
		ContextMenuStrip contextMenuStrip = toolStripMenuItem.Owner as ContextMenuStrip;
		GridControl gridControl = contextMenuStrip.SourceControl as GridControl;
		gridControl.ShowPreview();
	}

	public static void a1964(string a1962, System.Windows.Forms.ComboBox a1963)
	{
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a1962;
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		a1963.Items.Clear();
		while (sqlDataReader.Read())
		{
			a1963.Items.Add(sqlDataReader.GetValue(0).ToString());
		}
		sqlDataReader.Close();
		if (a1963.Items.Count > 0)
		{
			a1963.SelectedIndex = 0;
		}
	}

	public static void a1964(string a1965, System.Windows.Forms.ComboBox a1966, System.Windows.Forms.ComboBox a1967)
	{
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a1965;
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		a1966.Items.Clear();
		a1967.Items.Clear();
		while (sqlDataReader.Read())
		{
			a1966.Items.Add(sqlDataReader.GetValue(0).ToString());
			a1967.Items.Add(sqlDataReader.GetValue(1).ToString());
		}
		sqlDataReader.Close();
		if (a1966.Items.Count > 0)
		{
			a1966.SelectedIndex = 0;
			a1967.SelectedIndex = 0;
		}
	}

	public static void a1964(string a1968, System.Windows.Forms.ComboBox a1969, System.Windows.Forms.ComboBox a1970, string a1971, string a1972)
	{
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a1968;
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		a1969.Items.Clear();
		a1970.Items.Clear();
		a1969.Items.Add(a1971);
		a1970.Items.Add(a1972);
		while (sqlDataReader.Read())
		{
			a1969.Items.Add(sqlDataReader.GetValue(0).ToString());
			a1970.Items.Add(sqlDataReader.GetValue(1).ToString());
		}
		sqlDataReader.Close();
		if (a1969.Items.Count > 0)
		{
			a1969.SelectedIndex = 0;
			a1970.SelectedIndex = 0;
		}
	}

	public static void a1975(string a1973, CheckedListBox a1974)
	{
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a1973;
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		a1974.Items.Clear();
		while (sqlDataReader.Read())
		{
			a1974.Items.Add(sqlDataReader.GetValue(0).ToString());
		}
		sqlDataReader.Close();
	}

	public static void a1975(string a1976, CheckedListBox a1977, CheckedListBox a1978)
	{
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = a2172.a2160;
		sqlCommand.CommandText = a1976;
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		a1977.Items.Clear();
		a1978.Items.Clear();
		while (sqlDataReader.Read())
		{
			a1977.Items.Add(sqlDataReader.GetValue(0).ToString());
			a1978.Items.Add(sqlDataReader.GetValue(1).ToString());
		}
		sqlDataReader.Close();
	}

	private static void a1981(object a1979, KeyEventArgs a1980)
	{
		if (a1980.KeyCode == Keys.Return)
		{
			SendKeys.Send(a1983("~Őɂ\u0340Ѽ"));
		}
	}

	private static string a1983(string a1982)
	{
		int length = a1982.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = a1982[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
