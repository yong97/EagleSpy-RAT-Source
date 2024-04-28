using System;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000078 RID: 120
[StandardModule]
public sealed class GetFlagThisIp
{
	// Token: 0x060005B9 RID: 1465 RVA: 0x00093C28 File Offset: 0x00091E28
	public static Image ThisIp(string ipc)
	{
		string text = Data.GeoIP0.LookupCountryCode(ipc.Trim()).ToUpper();
		int num = Array.IndexOf<string>(Data.GeoIP0.CountryCode, text);
		int num2 = Data.imageFlags.Images.IndexOfKey(text);
		int num3 = num;
		checked
		{
			if (num3 == -1)
			{
				num2 = -1;
			}
			else if (num3 == Data.GeoIP0.CountryName.Length)
			{
				num--;
				num2 = -1;
			}
			else if (num3 > Data.GeoIP0.CountryName.Length)
			{
				num2 = -1;
			}
			Image result;
			try
			{
				if (num2 == -1)
				{
					num2 = Data.imageFlags.Images.IndexOfKey("-1".ToUpper());
				}
				result = Data.imageFlags.Images[num2];
			}
			catch (Exception)
			{
				result = Data.imageFlags.Images[0];
			}
			return result;
		}
	}
}
