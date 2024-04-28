using System;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000077 RID: 119
[StandardModule]
public sealed class GetCountryName2
{
	// Token: 0x060005B7 RID: 1463 RVA: 0x00093BB8 File Offset: 0x00091DB8
	public static string GetCountryName(string ipc)
	{
		string text = Data.GeoIP0.LookupCountryName(ipc.Trim());
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		return text;
	}
}
