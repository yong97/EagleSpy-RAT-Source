using System;
using System.Drawing;
using System.Drawing.Text;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000068 RID: 104
[StandardModule]
internal sealed class CustomFontDrawString
{
	// Token: 0x060004F7 RID: 1271 RVA: 0x0007D178 File Offset: 0x0007B378
	public static Font LoadFont(string name, float size, FontStyle style)
	{
		CustomFontDrawString.privateFonts = new PrivateFontCollection();
		CustomFontDrawString.privateFonts.AddFontFile(reso.res_Path + "\\Fonts\\" + name);
		return new Font(CustomFontDrawString.privateFonts.Families[0], size, style);
	}

	// Token: 0x0400069C RID: 1692
	private static PrivateFontCollection privateFonts;
}
