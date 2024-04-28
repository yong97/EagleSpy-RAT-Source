using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x020000A6 RID: 166
[StandardModule]
internal sealed class RefreshExplorer
{
	// Token: 0x06000713 RID: 1811
	[DllImport("shell32.dll")]
	public static extern void SHChangeNotify(RefreshExplorer.HChangeNotifyEventID wEventID, RefreshExplorer.HChangeNotifyFlags uFlags, IntPtr dwItem1, IntPtr dwItem2);

	// Token: 0x06000714 RID: 1812 RVA: 0x0000342E File Offset: 0x0000162E
	public static void EnvRefresh()
	{
		RefreshExplorer.SHChangeNotify(RefreshExplorer.HChangeNotifyEventID.SHCNE_ASSOCCHANGED, RefreshExplorer.HChangeNotifyFlags.SHCNF_IDLIST, IntPtr.Zero, IntPtr.Zero);
	}

	// Token: 0x020000A7 RID: 167
	[Flags]
	public enum HChangeNotifyFlags
	{
		// Token: 0x04000A56 RID: 2646
		SHCNF_DWORD = 3,
		// Token: 0x04000A57 RID: 2647
		SHCNF_IDLIST = 0,
		// Token: 0x04000A58 RID: 2648
		SHCNF_PATHA = 1,
		// Token: 0x04000A59 RID: 2649
		SHCNF_PATHW = 5,
		// Token: 0x04000A5A RID: 2650
		SHCNF_PRINTERA = 2,
		// Token: 0x04000A5B RID: 2651
		SHCNF_PRINTERW = 6,
		// Token: 0x04000A5C RID: 2652
		SHCNF_FLUSH = 4096,
		// Token: 0x04000A5D RID: 2653
		SHCNF_FLUSHNOWAIT = 8192
	}

	// Token: 0x020000A8 RID: 168
	[Flags]
	public enum HChangeNotifyEventID
	{
		// Token: 0x04000A5F RID: 2655
		SHCNE_ALLEVENTS = 2147483647,
		// Token: 0x04000A60 RID: 2656
		SHCNE_ASSOCCHANGED = 134217728,
		// Token: 0x04000A61 RID: 2657
		SHCNE_ATTRIBUTES = 2048,
		// Token: 0x04000A62 RID: 2658
		SHCNE_CREATE = 2,
		// Token: 0x04000A63 RID: 2659
		SHCNE_DELETE = 4,
		// Token: 0x04000A64 RID: 2660
		SHCNE_DRIVEADD = 16,
		// Token: 0x04000A65 RID: 2661
		SHCNE_DRIVEADDGUI = 65536,
		// Token: 0x04000A66 RID: 2662
		SHCNE_DRIVEREMOVED = 128,
		// Token: 0x04000A67 RID: 2663
		SHCNE_EXTENDED_EVENT = 67108864,
		// Token: 0x04000A68 RID: 2664
		SHCNE_FREESPACE = 262144,
		// Token: 0x04000A69 RID: 2665
		SHCNE_MEDIAINSERTED = 32,
		// Token: 0x04000A6A RID: 2666
		SHCNE_MEDIAREMOVED = 64,
		// Token: 0x04000A6B RID: 2667
		SHCNE_MKDIR = 8,
		// Token: 0x04000A6C RID: 2668
		SHCNE_NETSHARE = 512,
		// Token: 0x04000A6D RID: 2669
		SHCNE_NETUNSHARE = 1024,
		// Token: 0x04000A6E RID: 2670
		SHCNE_RENAMEFOLDER = 131072,
		// Token: 0x04000A6F RID: 2671
		SHCNE_RENAMEITEM = 1,
		// Token: 0x04000A70 RID: 2672
		SHCNE_RMDIR = 16,
		// Token: 0x04000A71 RID: 2673
		SHCNE_SERVERDISCONNECT = 16384,
		// Token: 0x04000A72 RID: 2674
		SHCNE_UPDATEDIR = 4096,
		// Token: 0x04000A73 RID: 2675
		SHCNE_UPDATEIMAGE = 32768
	}
}
