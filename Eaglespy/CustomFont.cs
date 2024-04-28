using System;
using System.Drawing;
using System.Drawing.Text;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000067 RID: 103
[StandardModule]
internal sealed class CustomFont
{
	// Token: 0x060004F5 RID: 1269 RVA: 0x0007D130 File Offset: 0x0007B330
	public static Font LoadFont(string name, float size, FontStyle style)
	{
		CustomFont.privateFonts = new PrivateFontCollection();
		CustomFont.privateFonts.AddFontFile(reso.res_Path + "\\Fonts\\" + name);
		return new Font(CustomFont.privateFonts.Families[0], size, style);
	}

	// Token: 0x0400069B RID: 1691
	private static PrivateFontCollection privateFonts;
}
