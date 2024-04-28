using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000080 RID: 128
[StandardModule]
internal sealed class infoServer
{
	// Token: 0x04000859 RID: 2137
	public static string PORTS = string.Empty;

	// Token: 0x0400085A RID: 2138
	public static int KeySize = 8;

	// Token: 0x0400085B RID: 2139
	public static int Microseconds = -1;

	// Token: 0x0400085C RID: 2140
	public static List<Client> WorkerRemove = new List<Client>();
}
