using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000094 RID: 148
public class MultiSounds
{
	// Token: 0x060006A3 RID: 1699 RVA: 0x000032F2 File Offset: 0x000014F2
	public MultiSounds()
	{
		this.Snds = new Dictionary<string, string>();
		this.sndcnt = 0;
	}

	// Token: 0x060006A4 RID: 1700
	[DllImport("winmm.dll")]
	private static extern int mciSendStringW([MarshalAs(UnmanagedType.LPTStr)] string lpszCommand, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpszReturnString, uint cchReturn, IntPtr hwndCallback);

	// Token: 0x060006A5 RID: 1701 RVA: 0x000A6F94 File Offset: 0x000A5194
	public bool AddSound(string SoundName, string SndFilePath)
	{
		checked
		{
			bool result;
			if (Operators.CompareString(SoundName.Trim(), "", false) == 0 | !File.Exists(SndFilePath))
			{
				result = false;
			}
			else if (MultiSounds.mciSendStringW("open \"" + SndFilePath + "\" alias Snd_" + this.sndcnt.ToString(), null, 0U, IntPtr.Zero) != 0)
			{
				result = false;
			}
			else
			{
				this.Snds.Add(SoundName, "Snd_" + this.sndcnt.ToString());
				this.sndcnt++;
				result = true;
			}
			return result;
		}
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x000A7028 File Offset: 0x000A5228
	public bool Play(string SoundName)
	{
		bool result;
		if (!this.Snds.ContainsKey(SoundName))
		{
			result = false;
		}
		else
		{
			MultiSounds.mciSendStringW("seek " + this.Snds[SoundName] + " to start", null, 0U, IntPtr.Zero);
			result = (MultiSounds.mciSendStringW("play " + this.Snds[SoundName], null, 0U, IntPtr.Zero) == 0);
		}
		return result;
	}

	// Token: 0x040009B8 RID: 2488
	private Dictionary<string, string> Snds;

	// Token: 0x040009B9 RID: 2489
	private int sndcnt;
}
