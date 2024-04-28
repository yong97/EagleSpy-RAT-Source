using System;
using System.Net.Sockets;
using System.Threading;

// Token: 0x0200008F RID: 143
public sealed class ListData
{
	// Token: 0x06000668 RID: 1640 RVA: 0x0000326E File Offset: 0x0000146E
	public ListData(Client ParametersClient, byte[] ParametersByte, object[] ParametersObject, TcpClient ParametersTcpClient)
	{
		this.WaitDataHandler = new ManualResetEvent(false);
		this.wait = false;
		this.ClassClient = ParametersClient;
		this.bByte = ParametersByte;
		this.SizeData = ParametersObject;
		this.TcpClient = ParametersTcpClient;
	}

	// Token: 0x04000955 RID: 2389
	public bool wait;

	// Token: 0x04000956 RID: 2390
	public ManualResetEvent WaitDataHandler;

	// Token: 0x04000957 RID: 2391
	public byte[] bByte;

	// Token: 0x04000958 RID: 2392
	public Client ClassClient;

	// Token: 0x04000959 RID: 2393
	public object[] SizeData;

	// Token: 0x0400095A RID: 2394
	public TcpClient TcpClient;
}
