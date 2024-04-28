using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000079 RID: 121
[StandardModule]
internal sealed class getIconFrmReg
{
	// Token: 0x060005BB RID: 1467
	[DllImport("shell32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SHGetFileInfo(string pszPath, int dwFileAttributes, ref getIconFrmReg.SHFILEINFO psfi, int cbFileInfo, int uFlags);

	// Token: 0x060005BC RID: 1468
	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool DestroyIcon(IntPtr hIcon);

	// Token: 0x060005BD RID: 1469 RVA: 0x00093D0C File Offset: 0x00091F0C
	public static Bitmap GetFileIcon(string fileExt)
	{
		int num = (Operators.CompareString(SpySettings.FM_IC_Size, "Large", false) != 0) ? 1 : 0;
		getIconFrmReg.SHFILEINFO shfileinfo = default(getIconFrmReg.SHFILEINFO);
		shfileinfo.szDisplayName = new string('\0', 260);
		shfileinfo.szTypeName = new string('\0', 80);
		getIconFrmReg.SHGetFileInfo(fileExt, 128, ref shfileinfo, Marshal.SizeOf<getIconFrmReg.SHFILEINFO>(shfileinfo), 256 | num | 16);
		Bitmap result = Icon.FromHandle(shfileinfo.hIcon).ToBitmap();
		getIconFrmReg.DestroyIcon(shfileinfo.hIcon);
		return result;
	}

	// Token: 0x060005BE RID: 1470
	[DllImport("shell32.dll")]
	private static extern int SHGetFileInfoW([MarshalAs(UnmanagedType.LPTStr)] [In] string pszPath, int dwFileAttributes, ref getIconFrmReg.SHFILEINFOW psfi, int cbFileInfo, int uFlags);

	// Token: 0x060005BF RID: 1471 RVA: 0x00093DA4 File Offset: 0x00091FA4
	public static Bitmap GetIcon(string PathName, bool LargeIco)
	{
		getIconFrmReg.SHFILEINFOW shfileinfow = default(getIconFrmReg.SHFILEINFOW);
		if (LargeIco)
		{
			getIconFrmReg.SHGetFileInfoW(PathName, 0, ref shfileinfow, Marshal.SizeOf<getIconFrmReg.SHFILEINFOW>(shfileinfow), 256);
		}
		else
		{
			getIconFrmReg.SHGetFileInfoW(PathName, 0, ref shfileinfow, Marshal.SizeOf<getIconFrmReg.SHFILEINFOW>(shfileinfow), 257);
		}
		Bitmap result = Icon.FromHandle(shfileinfow.hIcon).ToBitmap();
		getIconFrmReg.DestroyIcon(shfileinfow.hIcon);
		return result;
	}

	// Token: 0x04000803 RID: 2051
	private const int SHGFI_ICON = 256;

	// Token: 0x04000804 RID: 2052
	private const int FILE_ATTRIBUTE_NORMAL = 128;

	// Token: 0x04000805 RID: 2053
	private const int SHGFI_SMALLICON = 1;

	// Token: 0x0200007A RID: 122
	private struct SHFILEINFO
	{
		// Token: 0x04000806 RID: 2054
		public IntPtr hIcon;

		// Token: 0x04000807 RID: 2055
		public int iIcon;

		// Token: 0x04000808 RID: 2056
		public int dwAttributes;

		// Token: 0x04000809 RID: 2057
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string szDisplayName;

		// Token: 0x0400080A RID: 2058
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
		public string szTypeName;
	}

	// Token: 0x0200007B RID: 123
	public enum IconSize
	{
		// Token: 0x0400080C RID: 2060
		SHGFI_LARGEICON,
		// Token: 0x0400080D RID: 2061
		SHGFI_SMALLICON
	}

	// Token: 0x0200007C RID: 124
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct SHFILEINFOW
	{
		// Token: 0x0400080E RID: 2062
		public IntPtr hIcon;

		// Token: 0x0400080F RID: 2063
		public int iIcon;

		// Token: 0x04000810 RID: 2064
		public int dwAttributes;

		// Token: 0x04000811 RID: 2065
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string szDisplayName;

		// Token: 0x04000812 RID: 2066
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
		public string szTypeName;
	}
}
