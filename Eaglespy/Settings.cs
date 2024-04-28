using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x020000BE RID: 190
[DesignerGenerated]
public partial class Settings : Form
{
	// Token: 0x06000818 RID: 2072 RVA: 0x000035F0 File Offset: 0x000017F0
	public Settings()
	{
		base.Load += this.Settings_Load;
		this.InitializeComponent();
		this.Font = reso.f;
	}

	// Token: 0x06000819 RID: 2073 RVA: 0x000C29C0 File Offset: 0x000C0BC0
	private void TOpacity_Tick(object sender, EventArgs e)
	{
		if (base.Opacity != 1.0)
		{
			base.Opacity += 0.1;
		}
		else
		{
			this.TOpacity.Enabled = false;
		}
	}

	// Token: 0x0600081A RID: 2074 RVA: 0x000C2A08 File Offset: 0x000C0C08
	private void SpyStyle()
	{
		foreach (DataGridView dataGridView in this.Panel1.Controls.OfType<DataGridView>())
		{
			dataGridView.BackgroundColor = SpySettings.DefaultColor_Background;
			dataGridView.BackColor = SpySettings.DefaultColor_Background;
			dataGridView.ColumnHeadersDefaultCellStyle.BackColor = SpySettings.DefaultColor_Background;
			dataGridView.DefaultCellStyle.BackColor = SpySettings.DefaultColor_Background;
			dataGridView.DefaultCellStyle.SelectionForeColor = SpySettings.DefaultColor_Background;
			dataGridView.DefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground;
			dataGridView.DefaultCellStyle.SelectionBackColor = SpySettings.DefaultColor_Foreground;
			dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground;
			dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
			dataGridView.GridColor = SpySettings.DefaultColor_Foreground;
			dataGridView.BorderStyle = BorderStyle.None;
			dataGridView.ColumnHeadersVisible = false;
			dataGridView.EnableHeadersVisualStyles = false;
			dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridView.RowHeadersVisible = false;
			dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
			dataGridView.MultiSelect = false;
		}
		foreach (Label label in this.Panel1.Controls.OfType<Label>())
		{
			label.BackColor = SpySettings.DefaultColor_Background;
			label.ForeColor = SpySettings.DefaultColor_ColorTitles;
		}
		foreach (Button button in this.Panel2.Controls.OfType<Button>())
		{
			button.BackColor = SpySettings.DefaultColor_Foreground;
			button.ForeColor = SpySettings.DefaultColor_Background;
		}
		foreach (Panel panel in base.Controls.OfType<Panel>())
		{
			panel.BackColor = SpySettings.DefaultColor_Background;
			panel.ForeColor = SpySettings.DefaultColor_Foreground;
		}
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x000C2C28 File Offset: 0x000C0E28
	private void grreSize()
	{
		checked
		{
			foreach (DataGridView dataGridView in this.Panel1.Controls.OfType<DataGridView>())
			{
				int num = dataGridView.Rows.Count * dataGridView.Rows[0].Height;
				dataGridView.Height = num + 5;
			}
		}
	}

	// Token: 0x0600081C RID: 2076 RVA: 0x000C2CA0 File Offset: 0x000C0EA0
	private void Settings_Load(object sender, EventArgs e)
	{
		base.Icon = Resources.max;
		this.SpyStyle();
		this.R();
		this.grreSize();
		this.DGV5.ContextMenuStrip = this.ctxPacket;
		this.TOpacity.Interval = SpySettings.T_Interval;
		this.TOpacity.Enabled = true;
	}

	// Token: 0x0600081D RID: 2077 RVA: 0x000C2CF8 File Offset: 0x000C0EF8
	private void R()
	{
		List<string> list = new List<string>();
		DataGridViewRowCollection rows = this.DGV0.Rows;
		object[] array = new object[2];
		array[0] = "Performance";
		int index = rows.Add(array);
		DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.DGV0.Rows[index].Cells[1];
		list.Add("High");
		list.Add("Normal");
		list.Add("Low");
		dataGridViewComboBoxCell.DataSource = list;
		dataGridViewComboBoxCell.Value = list[list.IndexOf(MySettingsProperty.Settings.performance)];
		list = new List<string>();
		DataGridViewRowCollection rows2 = this.DGV0.Rows;
		object[] array2 = new object[2];
		array2[0] = "Encoding";
		index = rows2.Add(array2);
		DataGridViewComboBoxCell dataGridViewComboBoxCell2 = (DataGridViewComboBoxCell)this.DGV0.Rows[index].Cells[1];
		list.Add("Default");
		list.Add("UTF8");
		list.Add("UTF32");
		list.Add("ASCII");
		dataGridViewComboBoxCell2.DataSource = list;
		dataGridViewComboBoxCell2.Value = list[list.IndexOf(MySettingsProperty.Settings.encoding8)];
		list = new List<string>();
		DataGridViewRowCollection rows3 = this.DGV0.Rows;
		object[] array3 = new object[2];
		array3[0] = "Disconnected";
		index = rows3.Add(array3);
		DataGridViewComboBoxCell dataGridViewComboBoxCell3 = (DataGridViewComboBoxCell)this.DGV0.Rows[index].Cells[1];
		list.Add("Close windows");
		list.Add("Just tell me");
		dataGridViewComboBoxCell3.DataSource = list;
		dataGridViewComboBoxCell3.Value = list[list.IndexOf(MySettingsProperty.Settings.disconnected)];
		list = new List<string>();
		DataGridViewRowCollection rows4 = this.DGV0.Rows;
		object[] array4 = new object[2];
		array4[0] = "Removing Duplicates";
		index = rows4.Add(array4);
		DataGridViewComboBoxCell dataGridViewComboBoxCell4 = (DataGridViewComboBoxCell)this.DGV0.Rows[index].Cells[1];
		list.Add("Yes");
		list.Add("No");
		dataGridViewComboBoxCell4.DataSource = list;
		dataGridViewComboBoxCell4.Value = list[list.IndexOf(MySettingsProperty.Settings.Removing_Duplicates)];
		list = new List<string>();
		DataGridViewRowCollection rows5 = this.DGV1.Rows;
		object[] array5 = new object[2];
		array5[0] = "Show Alert";
		index = rows5.Add(array5);
		DataGridViewComboBoxCell dataGridViewComboBoxCell5 = (DataGridViewComboBoxCell)this.DGV1.Rows[index].Cells[1];
		list.Add("Yes");
		list.Add("No");
		dataGridViewComboBoxCell5.DataSource = list;
		dataGridViewComboBoxCell5.Value = list[list.IndexOf(MySettingsProperty.Settings.show_alert)];
		list = new List<string>();
		DataGridViewRowCollection rows6 = this.DGV1.Rows;
		object[] array6 = new object[2];
		array6[0] = "Location";
		index = rows6.Add(array6);
		DataGridViewComboBoxCell dataGridViewComboBoxCell6 = (DataGridViewComboBoxCell)this.DGV1.Rows[index].Cells[1];
		list.Add("Right");
		list.Add("Left");
		dataGridViewComboBoxCell6.DataSource = list;
		dataGridViewComboBoxCell6.Value = list[list.IndexOf(MySettingsProperty.Settings.location)];
		list = new List<string>();
		DataGridViewRowCollection rows7 = this.DGV1.Rows;
		object[] array7 = new object[2];
		array7[0] = "Play Sound";
		index = rows7.Add(array7);
		DataGridViewComboBoxCell dataGridViewComboBoxCell7 = (DataGridViewComboBoxCell)this.DGV1.Rows[index].Cells[1];
		list.Add("Yes");
		list.Add("No");
		dataGridViewComboBoxCell7.DataSource = list;
		dataGridViewComboBoxCell7.Value = list[list.IndexOf(MySettingsProperty.Settings.NOTI_SOUND ? "Yes" : "No")];
		list = new List<string>();
		DataGridViewRowCollection rows8 = this.DGV1.Rows;
		object[] array8 = new object[2];
		array8[0] = "Multi-Sounds";
		index = rows8.Add(array8);
		DataGridViewComboBoxCell dataGridViewComboBoxCell8 = (DataGridViewComboBoxCell)this.DGV1.Rows[index].Cells[1];
		list.Add("Yes");
		list.Add("No");
		dataGridViewComboBoxCell8.DataSource = list;
		dataGridViewComboBoxCell8.Value = list[list.IndexOf(MySettingsProperty.Settings._multi_sounds)];
		list = new List<string>();
		DataGridViewRowCollection rows9 = this.DGV1.Rows;
		object[] array9 = new object[2];
		array9[0] = "Round";
		index = rows9.Add(array9);
		DataGridViewComboBoxCell dataGridViewComboBoxCell9 = (DataGridViewComboBoxCell)this.DGV1.Rows[index].Cells[1];
		list.Add("Yes");
		list.Add("No");
		dataGridViewComboBoxCell9.DataSource = list;
		dataGridViewComboBoxCell9.Value = list[list.IndexOf(MySettingsProperty.Settings.Round)];
		list = new List<string>();
		DataGridViewRowCollection rows10 = this.DGV2.Rows;
		object[] array10 = new object[2];
		array10[0] = "Auto focus";
		index = rows10.Add(array10);
		DataGridViewComboBoxCell dataGridViewComboBoxCell10 = (DataGridViewComboBoxCell)this.DGV2.Rows[index].Cells[1];
		list.Add("Yes");
		list.Add("No");
		dataGridViewComboBoxCell10.DataSource = list;
		dataGridViewComboBoxCell10.Value = list[list.IndexOf(MySettingsProperty.Settings.Auto_focus)];
		list = new List<string>();
		DataGridViewRowCollection rows11 = this.DGV2.Rows;
		object[] array11 = new object[2];
		array11[0] = "Effects";
		index = rows11.Add(array11);
		DataGridViewComboBoxCell dataGridViewComboBoxCell11 = (DataGridViewComboBoxCell)this.DGV2.Rows[index].Cells[1];
		list.Add("Normal");
		list.Add("Gray");
		list.Add("Raw-01");
		list.Add("Raw-02");
		dataGridViewComboBoxCell11.DataSource = list;
		dataGridViewComboBoxCell11.Value = list[list.IndexOf(MySettingsProperty.Settings.Effects_CAM)];
		list = new List<string>();
		DataGridViewRowCollection rows12 = this.DGV2.Rows;
		object[] array12 = new object[2];
		array12[0] = "Quality";
		index = rows12.Add(array12);
		DataGridViewComboBoxCell dataGridViewComboBoxCell12 = (DataGridViewComboBoxCell)this.DGV2.Rows[index].Cells[1];
		list.Add("Auto");
		list.Add("high quality");
		dataGridViewComboBoxCell12.DataSource = list;
		dataGridViewComboBoxCell12.Value = list[list.IndexOf(MySettingsProperty.Settings.CAMQuality)];
		list = new List<string>();
		DataGridViewRowCollection rows13 = this.DGV3.Rows;
		object[] array13 = new object[2];
		array13[0] = "Style";
		index = rows13.Add(array13);
		DataGridViewComboBoxCell dataGridViewComboBoxCell13 = (DataGridViewComboBoxCell)this.DGV3.Rows[index].Cells[1];
		list.Add("Navigation_Preview_Day");
		list.Add("Dark");
		list.Add("Basic_Template");
		list.Add("Streets");
		list.Add("Le_Shine");
		list.Add("Ice_Cream");
		list.Add("Navigation_Preview_Night");
		list.Add("Moonlight");
		list.Add("Decimal");
		dataGridViewComboBoxCell13.DataSource = list;
		dataGridViewComboBoxCell13.Value = list[list.IndexOf(MySettingsProperty.Settings.Style_Maps)];
		list = new List<string>();
		DataGridViewRowCollection rows14 = this.DGV4.Rows;
		object[] array14 = new object[2];
		array14[0] = "Auto save";
		index = rows14.Add(array14);
		DataGridViewComboBoxCell dataGridViewComboBoxCell14 = (DataGridViewComboBoxCell)this.DGV4.Rows[index].Cells[1];
		list.Add("Yes");
		list.Add("No");
		dataGridViewComboBoxCell14.DataSource = list;
		dataGridViewComboBoxCell14.Value = list[list.IndexOf(MySettingsProperty.Settings.Saving_data)];
		Bitmap bitmap = new Bitmap(21, 17);
		Graphics graphics = Graphics.FromImage(bitmap);
		Color color = MySettingsProperty.Settings.DefaultColorForeground;
		graphics.Clear(color);
		Pen pen = new Pen(ControlPaint.Light(MySettingsProperty.Settings.DefaultColorForeground), 1f);
		checked
		{
			graphics.DrawRectangle(pen, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
			index = this.DGV5.Rows.Add(new object[]
			{
				"Foreground",
				bitmap
			});
			this.DGV5.Rows[index].Tag = color;
			graphics.Dispose();
			bitmap = new Bitmap(21, 17);
			graphics = Graphics.FromImage(bitmap);
			color = MySettingsProperty.Settings.DefaultColorBackground;
			graphics.Clear(color);
			pen = new Pen(ControlPaint.Light(MySettingsProperty.Settings.DefaultColorBackground), 1f);
			graphics.DrawRectangle(pen, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
			index = this.DGV5.Rows.Add(new object[]
			{
				"Background",
				bitmap
			});
			this.DGV5.Rows[index].Tag = color;
			graphics.Dispose();
			bitmap = new Bitmap(21, 17);
			graphics = Graphics.FromImage(bitmap);
			color = MySettingsProperty.Settings.DefaultColor_ColorTitles;
			graphics.Clear(color);
			pen = new Pen(ControlPaint.Light(MySettingsProperty.Settings.DefaultColor_ColorTitles), 1f);
			graphics.DrawRectangle(pen, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
			index = this.DGV5.Rows.Add(new object[]
			{
				"Titles",
				bitmap
			});
			this.DGV5.Rows[index].Tag = color;
			graphics.Dispose();
			bitmap = new Bitmap(21, 17);
			graphics = Graphics.FromImage(bitmap);
			color = MySettingsProperty.Settings.DefaultColor_NewColorFiles;
			graphics.Clear(color);
			pen = new Pen(ControlPaint.Light(MySettingsProperty.Settings.DefaultColor_NewColorFiles), 1f);
			graphics.DrawRectangle(pen, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
			index = this.DGV5.Rows.Add(new object[]
			{
				"New Files",
				bitmap
			});
			this.DGV5.Rows[index].Tag = color;
			graphics.Dispose();
			list = new List<string>();
			DataGridViewRowCollection rows15 = this.DGV6.Rows;
			object[] array15 = new object[2];
			array15[0] = "Size";
			index = rows15.Add(array15);
			DataGridViewComboBoxCell dataGridViewComboBoxCell15 = (DataGridViewComboBoxCell)this.DGV6.Rows[index].Cells[1];
			list.Add("8");
			list.Add("9");
			list.Add("10");
			list.Add("11");
			list.Add("12");
			dataGridViewComboBoxCell15.DataSource = list;
			dataGridViewComboBoxCell15.Value = list[list.IndexOf(Conversions.ToString(MySettingsProperty.Settings.FontSize))];
			list = new List<string>();
			DataGridViewRowCollection rows16 = this.DGV6.Rows;
			object[] array16 = new object[2];
			array16[0] = "Style";
			index = rows16.Add(array16);
			DataGridViewComboBoxCell dataGridViewComboBoxCell16 = (DataGridViewComboBoxCell)this.DGV6.Rows[index].Cells[1];
			list.Add("Bold");
			list.Add("Regular");
			dataGridViewComboBoxCell16.DataSource = list;
			dataGridViewComboBoxCell16.Value = list[list.IndexOf(MySettingsProperty.Settings.FontStyle)];
			list = new List<string>();
			DataGridViewRowCollection rows17 = this.DGV7.Rows;
			object[] array17 = new object[2];
			array17[0] = "Visible";
			index = rows17.Add(array17);
			DataGridViewComboBoxCell dataGridViewComboBoxCell17 = (DataGridViewComboBoxCell)this.DGV7.Rows[index].Cells[1];
			list.Add("Yes");
			list.Add("No");
			dataGridViewComboBoxCell17.DataSource = list;
			dataGridViewComboBoxCell17.Value = list[list.IndexOf(MySettingsProperty.Settings.Flags_Visible)];
			list = new List<string>();
			DataGridViewRowCollection rows18 = this.DGV7.Rows;
			object[] array18 = new object[2];
			array18[0] = "Size";
			index = rows18.Add(array18);
			DataGridViewComboBoxCell dataGridViewComboBoxCell18 = (DataGridViewComboBoxCell)this.DGV7.Rows[index].Cells[1];
			list.Add("16px");
			list.Add("24px");
			list.Add("32px");
			dataGridViewComboBoxCell18.DataSource = list;
			dataGridViewComboBoxCell18.Value = list[list.IndexOf(MySettingsProperty.Settings.Flags_Size)];
			list = new List<string>();
			DataGridViewRowCollection rows19 = this.DGV8.Rows;
			object[] array19 = new object[2];
			array19[0] = "Visible";
			index = rows19.Add(array19);
			DataGridViewComboBoxCell dataGridViewComboBoxCell19 = (DataGridViewComboBoxCell)this.DGV8.Rows[index].Cells[1];
			list.Add("Yes");
			list.Add("No");
			dataGridViewComboBoxCell19.DataSource = list;
			dataGridViewComboBoxCell19.Value = list[list.IndexOf(MySettingsProperty.Settings.SStatus_Visible)];
			list = new List<string>();
			DataGridViewRowCollection rows20 = this.DGV9.Rows;
			object[] array20 = new object[2];
			array20[0] = "Icon files size";
			index = rows20.Add(array20);
			DataGridViewComboBoxCell dataGridViewComboBoxCell20 = (DataGridViewComboBoxCell)this.DGV9.Rows[index].Cells[1];
			list.Add("Small");
			list.Add("Large");
			dataGridViewComboBoxCell20.DataSource = list;
			dataGridViewComboBoxCell20.Value = list[list.IndexOf(MySettingsProperty.Settings.FM_IC_Size)];
			this.DGV0.ClearSelection();
			this.DGV1.ClearSelection();
			this.DGV2.ClearSelection();
			this.DGV3.ClearSelection();
			this.DGV4.ClearSelection();
			this.DGV5.ClearSelection();
			this.DGV6.ClearSelection();
			this.DGV7.ClearSelection();
			this.DGV8.ClearSelection();
			this.DGV9.ClearSelection();
		}
	}

	// Token: 0x0600081E RID: 2078 RVA: 0x000C3B10 File Offset: 0x000C1D10
	private void SV_Click(object sender, EventArgs e)
	{
		int num = 0;
		checked
		{
			foreach (object obj in ((IEnumerable)this.DGV0.Rows))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(obj);
				switch (num)
				{
				case 0:
					MySettingsProperty.Settings.performance = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
					{
						1
					}, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				case 1:
					MySettingsProperty.Settings.encoding8 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
					{
						1
					}, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				case 2:
					MySettingsProperty.Settings.disconnected = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
					{
						1
					}, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				case 3:
					MySettingsProperty.Settings.Removing_Duplicates = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
					{
						1
					}, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				}
				num++;
			}
			num = 0;
			foreach (object obj2 in ((IEnumerable)this.DGV1.Rows))
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
				switch (num)
				{
				case 0:
					MySettingsProperty.Settings.show_alert = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, null, "Cells", new object[]
					{
						1
					}, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				case 1:
					MySettingsProperty.Settings.location = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, null, "Cells", new object[]
					{
						1
					}, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				case 2:
					MySettingsProperty.Settings.NOTI_SOUND = Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, null, "Cells", new object[]
					{
						1
					}, null, null, null), null, "Value", new object[0], null, null, null), "Yes", false);
					break;
				case 3:
					MySettingsProperty.Settings._multi_sounds = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, null, "Cells", new object[]
					{
						1
					}, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				case 4:
					MySettingsProperty.Settings.Round = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, null, "Cells", new object[]
					{
						1
					}, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				}
				num++;
			}
			num = 0;
			foreach (object obj3 in ((IEnumerable)this.DGV2.Rows))
			{
				object objectValue3 = RuntimeHelpers.GetObjectValue(obj3);
				switch (num)
				{
				case 0:
					MySettingsProperty.Settings.Auto_focus = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[]
					{
						1
					}, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				case 1:
					MySettingsProperty.Settings.Effects_CAM = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[]
					{
						1
					}, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				case 2:
					MySettingsProperty.Settings.CAMQuality = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[]
					{
						1
					}, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				}
				num++;
			}
			num = 0;
			foreach (object obj4 in ((IEnumerable)this.DGV3.Rows))
			{
				object objectValue4 = RuntimeHelpers.GetObjectValue(obj4);
				if (num == 0)
				{
					MySettingsProperty.Settings.Style_Maps = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue4, null, "Cells", new object[]
					{
						1
					}, null, null, null), null, "Value", new object[0], null, null, null));
				}
				num++;
			}
			num = 0;
			foreach (object obj5 in ((IEnumerable)this.DGV4.Rows))
			{
				object objectValue5 = RuntimeHelpers.GetObjectValue(obj5);
				if (num == 0)
				{
					MySettingsProperty.Settings.Saving_data = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue5, null, "Cells", new object[]
					{
						1
					}, null, null, null), null, "Value", new object[0], null, null, null));
				}
				num++;
			}
			num = 0;
			foreach (object obj6 in ((IEnumerable)this.DGV5.Rows))
			{
				object objectValue6 = RuntimeHelpers.GetObjectValue(obj6);
				switch (num)
				{
				case 0:
					MySettingsProperty.Settings.DefaultColorForeground = (Color)NewLateBinding.LateGet(objectValue6, null, "Tag", new object[0], null, null, null);
					break;
				case 1:
					MySettingsProperty.Settings.DefaultColorBackground = (Color)NewLateBinding.LateGet(objectValue6, null, "Tag", new object[0], null, null, null);
					break;
				case 2:
					MySettingsProperty.Settings.DefaultColor_ColorTitles = (Color)NewLateBinding.LateGet(objectValue6, null, "Tag", new object[0], null, null, null);
					break;
				case 3:
					MySettingsProperty.Settings.DefaultColor_NewColorFiles = (Color)NewLateBinding.LateGet(objectValue6, null, "Tag", new object[0], null, null, null);
					break;
				}
				num++;
			}
			num = 0;
			foreach (object obj7 in ((IEnumerable)this.DGV6.Rows))
			{
				object objectValue7 = RuntimeHelpers.GetObjectValue(obj7);
				int num2 = num;
				int num3 = num2;
				if (num3 != 0)
				{
					if (num3 == 1)
					{
						MySettingsProperty.Settings.FontStyle = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue7, null, "Cells", new object[]
						{
							1
						}, null, null, null), null, "Value", new object[0], null, null, null));
					}
				}
				else
				{
					MySettingsProperty.Settings.FontSize = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue7, null, "Cells", new object[]
					{
						1
					}, null, null, null), null, "Value", new object[0], null, null, null));
				}
				num++;
			}
			num = 0;
			foreach (object obj8 in ((IEnumerable)this.DGV7.Rows))
			{
				object objectValue8 = RuntimeHelpers.GetObjectValue(obj8);
				int num4 = num;
				int num5 = num4;
				if (num5 != 0)
				{
					if (num5 == 1)
					{
						MySettingsProperty.Settings.Flags_Size = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue8, null, "Cells", new object[]
						{
							1
						}, null, null, null), null, "Value", new object[0], null, null, null));
					}
				}
				else
				{
					MySettingsProperty.Settings.Flags_Visible = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue8, null, "Cells", new object[]
					{
						1
					}, null, null, null), null, "Value", new object[0], null, null, null));
				}
				num++;
			}
			num = 0;
			foreach (object obj9 in ((IEnumerable)this.DGV8.Rows))
			{
				object objectValue9 = RuntimeHelpers.GetObjectValue(obj9);
				if (num == 0)
				{
					MySettingsProperty.Settings.SStatus_Visible = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue9, null, "Cells", new object[]
					{
						1
					}, null, null, null), null, "Value", new object[0], null, null, null));
				}
				num++;
			}
			num = 0;
			foreach (object obj10 in ((IEnumerable)this.DGV9.Rows))
			{
				object objectValue10 = RuntimeHelpers.GetObjectValue(obj10);
				if (num == 0)
				{
					MySettingsProperty.Settings.FM_IC_Size = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue10, null, "Cells", new object[]
					{
						1
					}, null, null, null), null, "Value", new object[0], null, null, null));
				}
				num++;
			}
			MySettingsProperty.Settings.Save();
			Interaction.MsgBox("Saved Changes will be made after restarting the program", MsgBoxStyle.Information, reso.nameRAT);
			base.Close();
		}
	}

	// Token: 0x0600081F RID: 2079 RVA: 0x000C4614 File Offset: 0x000C2814
	private void DL_Click(object sender, EventArgs e)
	{
		MySettingsProperty.Settings.Reset();
		this.DGV0.Rows.Clear();
		this.DGV1.Rows.Clear();
		this.DGV2.Rows.Clear();
		this.DGV3.Rows.Clear();
		this.DGV4.Rows.Clear();
		this.DGV5.Rows.Clear();
		this.DGV6.Rows.Clear();
		this.DGV7.Rows.Clear();
		this.DGV8.Rows.Clear();
		this.DGV9.Rows.Clear();
		this.R();
	}

	// Token: 0x06000820 RID: 2080 RVA: 0x000C46D4 File Offset: 0x000C28D4
	private void ClearSEL(DataGridView DG0)
	{
		foreach (DataGridView dataGridView in this.Panel1.Controls.OfType<DataGridView>())
		{
			if (Operators.CompareString(dataGridView.Name, DG0.Name, false) != 0 && dataGridView.Rows.Count > 0)
			{
				dataGridView.CurrentCell = dataGridView.Rows[0].Cells[0];
				dataGridView.ClearSelection();
			}
		}
	}

	// Token: 0x06000821 RID: 2081 RVA: 0x0000361B File Offset: 0x0000181B
	private void DGV0_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		this.ClearSEL(this.DGV0);
	}

	// Token: 0x06000822 RID: 2082 RVA: 0x00003629 File Offset: 0x00001829
	private void DGV1_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		this.ClearSEL(this.DGV1);
	}

	// Token: 0x06000823 RID: 2083 RVA: 0x00003637 File Offset: 0x00001837
	private void DGV2_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		this.ClearSEL(this.DGV2);
	}

	// Token: 0x06000824 RID: 2084 RVA: 0x00003645 File Offset: 0x00001845
	private void DGV3_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		this.ClearSEL(this.DGV3);
	}

	// Token: 0x06000825 RID: 2085 RVA: 0x00003653 File Offset: 0x00001853
	private void DGV4_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		this.ClearSEL(this.DGV4);
	}

	// Token: 0x06000826 RID: 2086 RVA: 0x00003661 File Offset: 0x00001861
	private void DGV5_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		this.ClearSEL(this.DGV5);
	}

	// Token: 0x06000827 RID: 2087 RVA: 0x0000366F File Offset: 0x0000186F
	private void DGV6_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		this.ClearSEL(this.DGV6);
	}

	// Token: 0x06000828 RID: 2088 RVA: 0x0000367D File Offset: 0x0000187D
	private void DGV7_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		this.ClearSEL(this.DGV7);
	}

	// Token: 0x06000829 RID: 2089 RVA: 0x0000368B File Offset: 0x0000188B
	private void DGV8_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		this.ClearSEL(this.DGV8);
	}

	// Token: 0x0600082A RID: 2090 RVA: 0x00003699 File Offset: 0x00001899
	private void DGV9_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		this.ClearSEL(this.DGV9);
	}

	// Token: 0x0600082B RID: 2091 RVA: 0x000C4770 File Offset: 0x000C2970
	private void DGV5_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		checked
		{
			if ((e.RowIndex == 0 | e.RowIndex == 1 | e.RowIndex == 2 | e.RowIndex == 3) && e.ColumnIndex == 1)
			{
				Color_Box0 color_Box = new Color_Box0();
				if (color_Box.ShowDialog() == DialogResult.OK)
				{
					Bitmap bitmap = new Bitmap(21, 17);
					Graphics graphics = Graphics.FromImage(bitmap);
					Color backColor = color_Box.C_Box3.BackColor;
					graphics.Clear(backColor);
					Pen pen = new Pen(ControlPaint.Light(backColor), 1f);
					graphics.DrawRectangle(pen, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
					this.DGV5.Rows[e.RowIndex].Tag = backColor;
					this.DGV5.Rows[e.RowIndex].Cells[1].Value = bitmap;
					graphics.Dispose();
				}
				color_Box.Close();
			}
		}
	}

	// Token: 0x0600082C RID: 2092 RVA: 0x000C4878 File Offset: 0x000C2A78
	private void CrateColor(Color[] packet)
	{
		int num = 0;
		checked
		{
			foreach (object obj in ((IEnumerable)this.DGV5.Rows))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(obj);
				DataGridViewRow dataGridViewRow = (DataGridViewRow)objectValue;
				Bitmap bitmap = new Bitmap(21, 17);
				Graphics graphics = Graphics.FromImage(bitmap);
				Color color = packet[num];
				graphics.Clear(color);
				Pen pen = new Pen(ControlPaint.Light(color), 1f);
				graphics.DrawRectangle(pen, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
				dataGridViewRow.Tag = color;
				dataGridViewRow.Cells[1].Value = bitmap;
				graphics.Dispose();
				num++;
			}
		}
	}

	// Token: 0x0600082D RID: 2093 RVA: 0x0000206C File Offset: 0x0000026C
	private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	// Token: 0x0600082E RID: 2094 RVA: 0x000C4968 File Offset: 0x000C2B68
	private void DefaultToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Color[] packet = new Color[]
		{
			Color.FromArgb(106, 106, 106),
			Color.FromArgb(206, 206, 206),
			Color.FromArgb(70, 130, 180),
			Color.FromArgb(95, 158, 160)
		};
		this.CrateColor(packet);
	}

	// Token: 0x0600082F RID: 2095 RVA: 0x000C49E0 File Offset: 0x000C2BE0
	private void clr_1ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Color[] packet = new Color[]
		{
			Color.FromArgb(45, 156, 202),
			Color.FromArgb(37, 39, 77),
			Color.FromArgb(169, 171, 184),
			Color.FromArgb(159, 64, 103)
		};
		this.CrateColor(packet);
	}

	// Token: 0x06000830 RID: 2096 RVA: 0x000C4A58 File Offset: 0x000C2C58
	private void clr_2ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Color[] packet = new Color[]
		{
			Color.FromArgb(55, 176, 169),
			Color.FromArgb(222, 242, 241),
			Color.FromArgb(43, 122, 119),
			Color.FromArgb(23, 36, 42)
		};
		this.CrateColor(packet);
	}

	// Token: 0x06000831 RID: 2097 RVA: 0x000C4ACC File Offset: 0x000C2CCC
	private void Clr3ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Color[] packet = new Color[]
		{
			Color.FromArgb(47, 68, 85),
			Color.FromArgb(220, 220, 220),
			Color.FromArgb(84, 102, 116),
			Color.FromArgb(218, 123, 147)
		};
		this.CrateColor(packet);
	}

	// Token: 0x06000832 RID: 2098 RVA: 0x000C4B40 File Offset: 0x000C2D40
	private void Clr4ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Color[] packet = new Color[]
		{
			Color.FromArgb(217, 63, 135),
			Color.FromArgb(42, 27, 60),
			Color.FromArgb(130, 101, 167),
			Color.FromArgb(68, 49, 141)
		};
		this.CrateColor(packet);
	}

	// Token: 0x06000833 RID: 2099 RVA: 0x000C4BB4 File Offset: 0x000C2DB4
	private void Clr5ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Color[] packet = new Color[]
		{
			Color.FromArgb(61, 61, 61),
			Color.FromArgb(222, 222, 222),
			Color.FromArgb(4, 94, 175),
			Color.FromArgb(30, 175, 4)
		};
		this.CrateColor(packet);
	}

	// Token: 0x06000834 RID: 2100 RVA: 0x000C4C24 File Offset: 0x000C2E24
	private void Clr6ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Color[] packet = new Color[]
		{
			Color.FromArgb(0, 122, 204),
			Color.FromArgb(37, 37, 38),
			Color.FromArgb(241, 241, 241),
			Color.FromArgb(87, 116, 48)
		};
		this.CrateColor(packet);
	}

	// Token: 0x06000835 RID: 2101 RVA: 0x000C4C94 File Offset: 0x000C2E94
	private void Clr7ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Color[] packet = new Color[]
		{
			Color.FromArgb(45, 40, 62),
			Color.FromArgb(208, 215, 225),
			Color.FromArgb(129, 43, 178),
			Color.FromArgb(158, 165, 172)
		};
		this.CrateColor(packet);
	}

	// Token: 0x06000836 RID: 2102 RVA: 0x000C4D10 File Offset: 0x000C2F10
	private void Clr8ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Color[] packet = new Color[]
		{
			Color.FromArgb(94, 94, 94),
			Color.FromArgb(40, 40, 40),
			Color.FromArgb(198, 198, 198),
			Color.FromArgb(12, 159, 26)
		};
		this.CrateColor(packet);
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x000C4D80 File Offset: 0x000C2F80
	private void Clr9ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Color[] packet = new Color[]
		{
			Color.FromArgb(232, 191, 106),
			Color.FromArgb(43, 43, 43),
			Color.FromArgb(169, 183, 198),
			Color.FromArgb(75, 119, 81)
		};
		this.CrateColor(packet);
	}

	// Token: 0x04000BCE RID: 3022
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV0")]
	private DataGridView _DGV0;

	// Token: 0x04000BCF RID: 3023
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV1")]
	private DataGridView _DGV1;

	// Token: 0x04000BD0 RID: 3024
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SV")]
	private Button _SV;

	// Token: 0x04000BD1 RID: 3025
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DL")]
	private Button _DL;

	// Token: 0x04000BD2 RID: 3026
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV2")]
	private DataGridView _DGV2;

	// Token: 0x04000BD3 RID: 3027
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV3")]
	private DataGridView _DGV3;

	// Token: 0x04000BD4 RID: 3028
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV4")]
	private DataGridView _DGV4;

	// Token: 0x04000BD5 RID: 3029
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV5")]
	private DataGridView _DGV5;

	// Token: 0x04000BD6 RID: 3030
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	// Token: 0x04000BD7 RID: 3031
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV6")]
	private DataGridView _DGV6;

	// Token: 0x04000BD8 RID: 3032
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV7")]
	private DataGridView _DGV7;

	// Token: 0x04000BD9 RID: 3033
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV8")]
	private DataGridView _DGV8;

	// Token: 0x04000BDA RID: 3034
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV9")]
	private DataGridView _DGV9;

	// Token: 0x04000BDB RID: 3035
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DefaultToolStripMenuItem")]
	private ToolStripMenuItem _DefaultToolStripMenuItem;

	// Token: 0x04000BDC RID: 3036
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clr_1")]
	private ToolStripMenuItem _clr_1;

	// Token: 0x04000BDD RID: 3037
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clr_2")]
	private ToolStripMenuItem _clr_2;

	// Token: 0x04000BDE RID: 3038
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Clr3ToolStripMenuItem")]
	private ToolStripMenuItem _Clr3ToolStripMenuItem;

	// Token: 0x04000BDF RID: 3039
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Clr4ToolStripMenuItem")]
	private ToolStripMenuItem _Clr4ToolStripMenuItem;

	// Token: 0x04000BE0 RID: 3040
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Clr5ToolStripMenuItem")]
	private ToolStripMenuItem _Clr5ToolStripMenuItem;

	// Token: 0x04000BE1 RID: 3041
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Clr6ToolStripMenuItem")]
	private ToolStripMenuItem _Clr6ToolStripMenuItem;

	// Token: 0x04000BE2 RID: 3042
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Clr7ToolStripMenuItem")]
	private ToolStripMenuItem _Clr7ToolStripMenuItem;

	// Token: 0x04000BE3 RID: 3043
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Clr8ToolStripMenuItem")]
	private ToolStripMenuItem _Clr8ToolStripMenuItem;

	// Token: 0x04000BE4 RID: 3044
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Clr9ToolStripMenuItem")]
	private ToolStripMenuItem _Clr9ToolStripMenuItem;
}
