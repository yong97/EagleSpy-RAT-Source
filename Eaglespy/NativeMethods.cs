using System;
using System.Drawing;
using System.Runtime.InteropServices;

// Token: 0x02000096 RID: 150
public class NativeMethods
{
	// Token: 0x060006A9 RID: 1705
	[DllImport("user32.dll", SetLastError = true)]
	internal static extern bool UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst, ref Point pptDst, ref Size psize, IntPtr hdcSrc, ref Point pptSrc, int crKey, ref NativeMethods.BLENDFUNCTION pblend, int dwFlags);

	// Token: 0x060006AA RID: 1706
	[DllImport("user32.dll", SetLastError = true)]
	internal static extern IntPtr GetDC(IntPtr hWnd);

	// Token: 0x060006AB RID: 1707
	[DllImport("gdi32.dll")]
	internal static extern IntPtr CreateCompatibleDC(IntPtr dc);

	// Token: 0x060006AC RID: 1708
	[DllImport("gdi32.dll")]
	internal static extern IntPtr SelectObject(IntPtr hdc, IntPtr hObj);

	// Token: 0x060006AD RID: 1709
	[DllImport("gdi32.dll")]
	internal static extern IntPtr DeleteDC(IntPtr dc);

	// Token: 0x060006AE RID: 1710
	[DllImport("gdi32.dll")]
	internal static extern IntPtr DeleteObject(IntPtr hObj);

	// Token: 0x040009BA RID: 2490
	internal const int AC_SRC_OVER = 0;

	// Token: 0x040009BB RID: 2491
	internal const int ULW_ALPHA = 2;

	// Token: 0x02000097 RID: 151
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct BLENDFUNCTION
	{
		// Token: 0x060006B0 RID: 1712 RVA: 0x00003314 File Offset: 0x00001514
		public BLENDFUNCTION(byte alpha)
		{
			this = default(NativeMethods.BLENDFUNCTION);
			this.BlendOp = 0;
			this.BlendFlags = 0;
			this.SourceConstantAlpha = alpha;
			this.AlphaFormat = 1;
		}

		// Token: 0x040009BC RID: 2492
		public byte BlendOp;

		// Token: 0x040009BD RID: 2493
		public byte BlendFlags;

		// Token: 0x040009BE RID: 2494
		public byte SourceConstantAlpha;

		// Token: 0x040009BF RID: 2495
		public byte AlphaFormat;
	}

	// Token: 0x02000098 RID: 152
	internal struct RECT
	{
		// Token: 0x040009C0 RID: 2496
		public int Left;

		// Token: 0x040009C1 RID: 2497
		public int Top;

		// Token: 0x040009C2 RID: 2498
		public int Right;

		// Token: 0x040009C3 RID: 2499
		public int Bottom;
	}
}
