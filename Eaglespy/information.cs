using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200007E RID: 126
[DesignerGenerated]
public partial class information : Form
{
	// Token: 0x060005CC RID: 1484 RVA: 0x000967E8 File Offset: 0x000949E8
	public information()
	{
		base.Load += this.info_Load;
		this.Title = "null";
		this.tmpTable = null;
		this.DS = null;
		this.InitializeComponent();
		this.Font = reso.f;
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x00096838 File Offset: 0x00094A38
	private void translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", false) != 0)
		{
			if (Operators.CompareString(language, "CN", false) == 0)
			{
				this.LB1.Text = Codes.Translate(this.LB1.Text, "en", "zh");
				this.LB2.Text = Codes.Translate(this.LB2.Text, "en", "zh");
				this.LB3.Text = Codes.Translate(this.LB3.Text, "en", "zh");
				this.LB4.Text = Codes.Translate(this.LB4.Text, "en", "zh");
				this.LB5.Text = Codes.Translate(this.LB5.Text, "en", "zh");
				this.LB7.Text = Codes.Translate(this.LB7.Text, "en", "zh");
				this.LB6.Text = Codes.Translate(this.LB6.Text, "en", "zh");
			}
		}
		else
		{
			this.LB1.Text = Codes.Translate(this.LB1.Text, "en", "ar");
			this.LB2.Text = Codes.Translate(this.LB2.Text, "en", "ar");
			this.LB3.Text = Codes.Translate(this.LB3.Text, "en", "ar");
			this.LB4.Text = Codes.Translate(this.LB4.Text, "en", "ar");
			this.LB5.Text = Codes.Translate(this.LB5.Text, "en", "ar");
			this.LB6.Text = Codes.Translate(this.LB6.Text, "en", "ar");
			this.LB7.Text = Codes.Translate(this.LB7.Text, "en", "ar");
		}
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x00096A80 File Offset: 0x00094C80
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

	// Token: 0x060005CF RID: 1487 RVA: 0x00096AC8 File Offset: 0x00094CC8
	public void grreSize()
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

	// Token: 0x060005D0 RID: 1488 RVA: 0x00096B40 File Offset: 0x00094D40
	private void info_Load(object sender, EventArgs e)
	{
		this.SaveToolStripMenuItem.Visible = true;
		this.SaveAsToolStripMenuItem.Visible = true;
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\11.ico");
		this.translateme();
		this.grreSize();
		this.Text = this.Title;
		this.TOpacity.Interval = SpySettings.T_Interval;
		this.TOpacity.Enabled = true;
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x00096BB4 File Offset: 0x00094DB4
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

	// Token: 0x060005D2 RID: 1490 RVA: 0x00002E07 File Offset: 0x00001007
	private void DGV0_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		this.ClearSEL(this.DGV0);
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x00002E15 File Offset: 0x00001015
	private void DGV1_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		this.ClearSEL(this.DGV1);
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x00002E23 File Offset: 0x00001023
	private void DGV2_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		this.ClearSEL(this.DGV2);
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x00002E31 File Offset: 0x00001031
	private void DGV3_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		this.ClearSEL(this.DGV3);
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x00002E3F File Offset: 0x0000103F
	private void DGV4_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		this.ClearSEL(this.DGV4);
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x00002E4D File Offset: 0x0000104D
	private void DGV5_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		this.ClearSEL(this.DGV5);
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x00002E5B File Offset: 0x0000105B
	private void DGV6_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		this.ClearSEL(this.DGV6);
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x00002E69 File Offset: 0x00001069
	private void DGV5_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
	{
		this.EventName = "DGV5";
		this.EventArgs = e;
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x00002E7D File Offset: 0x0000107D
	private void DGV6_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
	{
		this.EventName = "DGV6";
		this.EventArgs = e;
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x00096C50 File Offset: 0x00094E50
	private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.tmpTable != null)
		{
			reso.Directory_Exist(this.classClient);
			if (this.DS == null)
			{
				this.DS = new DataSet("info");
				this.DS.Tables.Add(this.tmpTable);
			}
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				reso.SAVEit((Array)a0);
			}, new object[]
			{
				this.DS,
				this.tmpFolderUSER,
				"informations",
				this.tmpClientName,
				this.tmpCountry + " - " + this.tmpAddressIP,
				"informations",
				"info",
				DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
			});
		}
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x00096D40 File Offset: 0x00094F40
	private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
		saveFileDialog.Filter = "html (*.html)|*.html";
		if (saveFileDialog.ShowDialog() == DialogResult.OK)
		{
			if (this.DS == null)
			{
				this.DS = new DataSet("info");
				this.DS.Tables.Add(this.tmpTable);
			}
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				reso.SAVEit((Array)a0);
			}, new object[]
			{
				this.DS,
				"null",
				saveFileDialog.FileName,
				this.tmpClientName,
				this.tmpCountry + " - " + this.tmpAddressIP,
				"informations",
				"info",
				"null"
			});
		}
		saveFileDialog.Dispose();
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x00096E48 File Offset: 0x00095048
	private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
	{
		ComboBox comboBox = (ComboBox)sender;
		if (comboBox != null && comboBox.Text.Length > 0 && this.EventArgs != null && (this.EventArgs.ColumnIndex != -1 & this.EventArgs.RowIndex != -1 & Operators.CompareString(this.EventName, null, false) != 0))
		{
			string eventName = this.EventName;
			if (Operators.CompareString(eventName, "DGV5", false) != 0)
			{
				if (Operators.CompareString(eventName, "DGV6", false) == 0)
				{
					if (this.EventArgs.ColumnIndex == 1 & this.EventArgs.RowIndex == 0)
					{
						this.change("ringer_mode", Conversions.ToString(comboBox.SelectedIndex));
					}
					else if (this.EventArgs.ColumnIndex == 1 & this.EventArgs.RowIndex == 1)
					{
						this.change("wifi_mode", Conversions.ToString(comboBox.SelectedIndex));
					}
				}
			}
			else if (this.EventArgs.ColumnIndex == 1 & this.EventArgs.RowIndex == 0)
			{
				this.change("ring", Conversions.ToString(comboBox.SelectedIndex));
			}
			else if (this.EventArgs.ColumnIndex == 1 & this.EventArgs.RowIndex == 1)
			{
				this.change("music", Conversions.ToString(comboBox.SelectedIndex));
			}
			else if (this.EventArgs.ColumnIndex == 1 & this.EventArgs.RowIndex == 2)
			{
				this.change("notification", Conversions.ToString(comboBox.SelectedIndex));
			}
			else if (this.EventArgs.ColumnIndex == 1 & this.EventArgs.RowIndex == 3)
			{
				this.change("system", Conversions.ToString(comboBox.SelectedIndex));
			}
		}
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x00097038 File Offset: 0x00095238
	private void change(string num, string vul)
	{
		if (this.classClient != null)
		{
			object[] parametersObjects = new object[]
			{
				this.Client,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient1,
					Data.SPL_SOCKET,
					reso.domen,
					".info",
					Data.SPL_SOCKET,
					"method",
					Data.SPL_SOCKET,
					SecurityKey.resultClient,
					Data.SPL_SOCKET,
					num,
					Data.SPL_DATA,
					vul
				}),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x000970F4 File Offset: 0x000952F4
	private void DGV5_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
	{
		ComboBox comboBox = (ComboBox)e.Control;
		if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(comboBox.SelectedItem)))
		{
			if (!Information.IsNothing(this.LastComboDGV5))
			{
				this.LastComboDGV5.SelectionChangeCommitted -= this.ComboBox_SelectedIndexChanged;
			}
			this.LastComboDGV5 = comboBox;
			this.LastComboDGV5.SelectionChangeCommitted += this.ComboBox_SelectedIndexChanged;
		}
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x00097168 File Offset: 0x00095368
	private void DGV6_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
	{
		ComboBox comboBox = (ComboBox)e.Control;
		if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(comboBox.SelectedItem)))
		{
			if (!Information.IsNothing(this.LastComboDGV6))
			{
				this.LastComboDGV6.SelectionChangeCommitted -= this.ComboBox_SelectedIndexChanged;
			}
			this.LastComboDGV6 = comboBox;
			this.LastComboDGV6.SelectionChangeCommitted += this.ComboBox_SelectedIndexChanged;
		}
	}

	// Token: 0x0400081E RID: 2078
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV3")]
	private DataGridView _DGV3;

	// Token: 0x0400081F RID: 2079
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV2")]
	private DataGridView _DGV2;

	// Token: 0x04000820 RID: 2080
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV1")]
	private DataGridView _DGV1;

	// Token: 0x04000821 RID: 2081
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV0")]
	private DataGridView _DGV0;

	// Token: 0x04000822 RID: 2082
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV4")]
	private DataGridView _DGV4;

	// Token: 0x04000823 RID: 2083
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV5")]
	private DataGridView _DGV5;

	// Token: 0x04000824 RID: 2084
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV6")]
	private DataGridView _DGV6;

	// Token: 0x04000825 RID: 2085
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private System.Windows.Forms.Timer _TOpacity;

	// Token: 0x04000826 RID: 2086
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SaveToolStripMenuItem")]
	private ToolStripMenuItem _SaveToolStripMenuItem;

	// Token: 0x04000827 RID: 2087
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SaveAsToolStripMenuItem")]
	private ToolStripMenuItem _SaveAsToolStripMenuItem;

	// Token: 0x04000828 RID: 2088
	public TcpClient Client;

	// Token: 0x04000829 RID: 2089
	public Client classClient;

	// Token: 0x0400082A RID: 2090
	public string Title;

	// Token: 0x0400082B RID: 2091
	private ComboBox LastComboDGV5;

	// Token: 0x0400082C RID: 2092
	private ComboBox LastComboDGV6;

	// Token: 0x0400082D RID: 2093
	private DataGridViewCellCancelEventArgs EventArgs;

	// Token: 0x0400082E RID: 2094
	private string EventName;

	// Token: 0x0400082F RID: 2095
	public DataTable tmpTable;

	// Token: 0x04000830 RID: 2096
	public string tmpFolderUSER;

	// Token: 0x04000831 RID: 2097
	public string tmpClientName;

	// Token: 0x04000832 RID: 2098
	public string tmpCountry;

	// Token: 0x04000833 RID: 2099
	public string tmpAddressIP;

	// Token: 0x04000834 RID: 2100
	public DataSet DS;
}
