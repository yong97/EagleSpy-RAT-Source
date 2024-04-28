using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x020000F4 RID: 244
[StandardModule]
[HideModuleName]
[DebuggerNonUserCode]
[CompilerGenerated]
internal sealed class MySettingsProperty
{
	// Token: 0x1700018B RID: 395
	// (get) Token: 0x06000A66 RID: 2662 RVA: 0x00004162 File Offset: 0x00002362
	[HelpKeyword("My.Settings")]
	internal static MySettings Settings
	{
		get
		{
			return MySettings.Default;
		}
	}
}
