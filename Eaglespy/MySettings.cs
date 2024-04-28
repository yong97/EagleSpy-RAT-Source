using System;
using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x020000F2 RID: 242
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.7.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed partial class MySettings : ApplicationSettingsBase
{
	// Token: 0x17000187 RID: 391
	// (get) Token: 0x06000A58 RID: 2648 RVA: 0x000E1A1C File Offset: 0x000DFC1C
	// (set) Token: 0x06000A59 RID: 2649 RVA: 0x000040EC File Offset: 0x000022EC
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public StringCollection ListBoxItems
	{
		get
		{
			return (StringCollection)this["ListBoxItems"];
		}
		set
		{
			this["ListBoxItems"] = value;
		}
	}

	// Token: 0x1700018A RID: 394
	// (get) Token: 0x06000A5E RID: 2654 RVA: 0x000E1A7C File Offset: 0x000DFC7C
	// (set) Token: 0x06000A5F RID: 2655 RVA: 0x0000411B File Offset: 0x0000231B
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public StringCollection ListBoxTracker
	{
		get
		{
			return (StringCollection)this["ListBoxTracker"];
		}
		set
		{
			this["ListBoxTracker"] = value;
		}
	}

	// Token: 0x06000A60 RID: 2656 RVA: 0x000E1A9C File Offset: 0x000DFC9C
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (MyProject.Application.SaveMySettingsOnExit)
		{
			MySettingsProperty.Settings.Save();
		}
	}
}
