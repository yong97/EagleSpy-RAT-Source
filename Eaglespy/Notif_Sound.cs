using System;
using System.Media;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200009C RID: 156
[StandardModule]
internal sealed class Notif_Sound
{
	// Token: 0x060006C0 RID: 1728 RVA: 0x000A90C8 File Offset: 0x000A72C8
	public static string getsoundpath()
	{
		string text = RegistryHandler.GET_SoundID();
		if (text == null)
		{
			text = "5";
		}
		return Notif_Sound.path_File.Replace("[id]", text);
	}

	// Token: 0x040009E9 RID: 2537
	public static bool multi = false;

	// Token: 0x040009EA RID: 2538
	public static SoundPlayer aMedia;

	// Token: 0x040009EB RID: 2539
	public static MultiSounds Snds = new MultiSounds();

	// Token: 0x040009EC RID: 2540
	private static string path_File = reso.res_Path + "\\Audio\\[id].wav";

	// Token: 0x040009ED RID: 2541
	public static int id = 0;
}
