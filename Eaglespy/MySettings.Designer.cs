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
	// Token: 0x1700014B RID: 331
	// (get) Token: 0x060009E1 RID: 2529 RVA: 0x000E11DC File Offset: 0x000DF3DC
	public static MySettings Default
	{
		get
		{
			if (!MySettings.addedHandler)
			{
				object obj = MySettings.addedHandlerLockObject;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				lock (obj)
				{
					if (!MySettings.addedHandler)
					{
						MyProject.Application.Shutdown += delegate(object sender, EventArgs e)
						{
							if (MyProject.Application.SaveMySettingsOnExit)
							{
								MySettingsProperty.Settings.Save();
							}
						};
						MySettings.addedHandler = true;
					}
				}
			}
			return MySettings.defaultInstance;
		}
	}

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x060009E2 RID: 2530 RVA: 0x000E126C File Offset: 0x000DF46C
	// (set) Token: 0x060009E3 RID: 2531 RVA: 0x00003D6C File Offset: 0x00001F6C
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("7771>7772")]
	public string ports
	{
		get
		{
			return Conversions.ToString(this["ports"]);
		}
		set
		{
			this["ports"] = value;
		}
	}

	// Token: 0x1700014D RID: 333
	// (get) Token: 0x060009E4 RID: 2532 RVA: 0x000E128C File Offset: 0x000DF48C
	// (set) Token: 0x060009E5 RID: 2533 RVA: 0x00003D7A File Offset: 0x00001F7A
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Normal")]
	public string performance
	{
		get
		{
			return Conversions.ToString(this["performance"]);
		}
		set
		{
			this["performance"] = value;
		}
	}

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x060009E6 RID: 2534 RVA: 0x000E12AC File Offset: 0x000DF4AC
	// (set) Token: 0x060009E7 RID: 2535 RVA: 0x00003D88 File Offset: 0x00001F88
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("UTF8")]
	public string encoding8
	{
		get
		{
			return Conversions.ToString(this["encoding8"]);
		}
		set
		{
			this["encoding8"] = value;
		}
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x060009E8 RID: 2536 RVA: 0x000E12CC File Offset: 0x000DF4CC
	// (set) Token: 0x060009E9 RID: 2537 RVA: 0x00003D96 File Offset: 0x00001F96
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yes")]
	public string show_alert
	{
		get
		{
			return Conversions.ToString(this["show_alert"]);
		}
		set
		{
			this["show_alert"] = value;
		}
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x060009EA RID: 2538 RVA: 0x000E12EC File Offset: 0x000DF4EC
	// (set) Token: 0x060009EB RID: 2539 RVA: 0x00003DA4 File Offset: 0x00001FA4
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Right")]
	public string location
	{
		get
		{
			return Conversions.ToString(this["location"]);
		}
		set
		{
			this["location"] = value;
		}
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x060009EC RID: 2540 RVA: 0x000E130C File Offset: 0x000DF50C
	// (set) Token: 0x060009ED RID: 2541 RVA: 0x00003DB2 File Offset: 0x00001FB2
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Just tell me")]
	public string disconnected
	{
		get
		{
			return Conversions.ToString(this["disconnected"]);
		}
		set
		{
			this["disconnected"] = value;
		}
	}

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x060009EE RID: 2542 RVA: 0x000E132C File Offset: 0x000DF52C
	// (set) Token: 0x060009EF RID: 2543 RVA: 0x00003DC0 File Offset: 0x00001FC0
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("No")]
	public string Auto_focus
	{
		get
		{
			return Conversions.ToString(this["Auto_focus"]);
		}
		set
		{
			this["Auto_focus"] = value;
		}
	}

	// Token: 0x17000153 RID: 339
	// (get) Token: 0x060009F0 RID: 2544 RVA: 0x000E134C File Offset: 0x000DF54C
	// (set) Token: 0x060009F1 RID: 2545 RVA: 0x00003DCE File Offset: 0x00001FCE
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Normal")]
	public string Effects_CAM
	{
		get
		{
			return Conversions.ToString(this["Effects_CAM"]);
		}
		set
		{
			this["Effects_CAM"] = value;
		}
	}

	// Token: 0x17000154 RID: 340
	// (get) Token: 0x060009F2 RID: 2546 RVA: 0x000E136C File Offset: 0x000DF56C
	// (set) Token: 0x060009F3 RID: 2547 RVA: 0x00003DDC File Offset: 0x00001FDC
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Streets")]
	public string Style_Maps
	{
		get
		{
			return Conversions.ToString(this["Style_Maps"]);
		}
		set
		{
			this["Style_Maps"] = value;
		}
	}

	// Token: 0x17000155 RID: 341
	// (get) Token: 0x060009F4 RID: 2548 RVA: 0x000E138C File Offset: 0x000DF58C
	// (set) Token: 0x060009F5 RID: 2549 RVA: 0x00003DEA File Offset: 0x00001FEA
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yes")]
	public string Saving_data
	{
		get
		{
			return Conversions.ToString(this["Saving_data"]);
		}
		set
		{
			this["Saving_data"] = value;
		}
	}

	// Token: 0x17000156 RID: 342
	// (get) Token: 0x060009F6 RID: 2550 RVA: 0x000E13AC File Offset: 0x000DF5AC
	// (set) Token: 0x060009F7 RID: 2551 RVA: 0x00003DF8 File Offset: 0x00001FF8
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Auto")]
	public string CAMQuality
	{
		get
		{
			return Conversions.ToString(this["CAMQuality"]);
		}
		set
		{
			this["CAMQuality"] = value;
		}
	}

	// Token: 0x17000157 RID: 343
	// (get) Token: 0x060009F8 RID: 2552 RVA: 0x000E13CC File Offset: 0x000DF5CC
	// (set) Token: 0x060009F9 RID: 2553 RVA: 0x00003E06 File Offset: 0x00002006
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Client")]
	public string build_text_name_victim
	{
		get
		{
			return Conversions.ToString(this["build_text_name_victim"]);
		}
		set
		{
			this["build_text_name_victim"] = value;
		}
	}

	// Token: 0x17000158 RID: 344
	// (get) Token: 0x060009FA RID: 2554 RVA: 0x000E13EC File Offset: 0x000DF5EC
	// (set) Token: 0x060009FB RID: 2555 RVA: 0x00003E14 File Offset: 0x00002014
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("CraxsApp")]
	public string build_text_name_patch
	{
		get
		{
			return Conversions.ToString(this["build_text_name_patch"]);
		}
		set
		{
			this["build_text_name_patch"] = value;
		}
	}

	// Token: 0x17000159 RID: 345
	// (get) Token: 0x060009FC RID: 2556 RVA: 0x000E140C File Offset: 0x000DF60C
	// (set) Token: 0x060009FD RID: 2557 RVA: 0x00003E22 File Offset: 0x00002022
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.0.0.0")]
	public string build_text_version
	{
		get
		{
			return Conversions.ToString(this["build_text_version"]);
		}
		set
		{
			this["build_text_version"] = value;
		}
	}

	// Token: 0x1700015A RID: 346
	// (get) Token: 0x060009FE RID: 2558 RVA: 0x000E142C File Offset: 0x000DF62C
	// (set) Token: 0x060009FF RID: 2559 RVA: 0x00003E30 File Offset: 0x00002030
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int build_text_sleep
	{
		get
		{
			return Conversions.ToInteger(this["build_text_sleep"]);
		}
		set
		{
			this["build_text_sleep"] = value;
		}
	}

	// Token: 0x1700015B RID: 347
	// (get) Token: 0x06000A00 RID: 2560 RVA: 0x000E144C File Offset: 0x000DF64C
	// (set) Token: 0x06000A01 RID: 2561 RVA: 0x00003E43 File Offset: 0x00002043
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("7771")]
	public int build_text_port
	{
		get
		{
			return Conversions.ToInteger(this["build_text_port"]);
		}
		set
		{
			this["build_text_port"] = value;
		}
	}

	// Token: 0x1700015C RID: 348
	// (get) Token: 0x06000A02 RID: 2562 RVA: 0x000E146C File Offset: 0x000DF66C
	// (set) Token: 0x06000A03 RID: 2563 RVA: 0x00003E56 File Offset: 0x00002056
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool build_Checked_hide
	{
		get
		{
			return Conversions.ToBoolean(this["build_Checked_hide"]);
		}
		set
		{
			this["build_Checked_hide"] = value;
		}
	}

	// Token: 0x1700015D RID: 349
	// (get) Token: 0x06000A04 RID: 2564 RVA: 0x000E148C File Offset: 0x000DF68C
	// (set) Token: 0x06000A05 RID: 2565 RVA: 0x00003E69 File Offset: 0x00002069
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool build_Checked_icon
	{
		get
		{
			return Conversions.ToBoolean(this["build_Checked_icon"]);
		}
		set
		{
			this["build_Checked_icon"] = value;
		}
	}

	// Token: 0x1700015E RID: 350
	// (get) Token: 0x06000A06 RID: 2566 RVA: 0x000E14AC File Offset: 0x000DF6AC
	// (set) Token: 0x06000A07 RID: 2567 RVA: 0x00003E7C File Offset: 0x0000207C
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool build_Checked_doze
	{
		get
		{
			return Conversions.ToBoolean(this["build_Checked_doze"]);
		}
		set
		{
			this["build_Checked_doze"] = value;
		}
	}

	// Token: 0x1700015F RID: 351
	// (get) Token: 0x06000A08 RID: 2568 RVA: 0x000E14CC File Offset: 0x000DF6CC
	// (set) Token: 0x06000A09 RID: 2569 RVA: 0x00003E8F File Offset: 0x0000208F
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("null")]
	public string build_path_icon
	{
		get
		{
			return Conversions.ToString(this["build_path_icon"]);
		}
		set
		{
			this["build_path_icon"] = value;
		}
	}

	// Token: 0x17000160 RID: 352
	// (get) Token: 0x06000A0A RID: 2570 RVA: 0x000E14EC File Offset: 0x000DF6EC
	// (set) Token: 0x06000A0B RID: 2571 RVA: 0x00003E9D File Offset: 0x0000209D
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("null")]
	public string build_DGV_list
	{
		get
		{
			return Conversions.ToString(this["build_DGV_list"]);
		}
		set
		{
			this["build_DGV_list"] = value;
		}
	}

	// Token: 0x17000161 RID: 353
	// (get) Token: 0x06000A0C RID: 2572 RVA: 0x000E150C File Offset: 0x000DF70C
	// (set) Token: 0x06000A0D RID: 2573 RVA: 0x00003EAB File Offset: 0x000020AB
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("95, 95, 250")]
	public Color DefaultColorForeground
	{
		get
		{
			object obj = this["DefaultColorForeground"];
			return (obj != null) ? ((Color)obj) : default(Color);
		}
		set
		{
			this["DefaultColorForeground"] = value;
		}
	}

	// Token: 0x17000162 RID: 354
	// (get) Token: 0x06000A0E RID: 2574 RVA: 0x000E1540 File Offset: 0x000DF740
	// (set) Token: 0x06000A0F RID: 2575 RVA: 0x00003EBE File Offset: 0x000020BE
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50, 50, 50")]
	public Color DefaultColorBackground
	{
		get
		{
			object obj = this["DefaultColorBackground"];
			return (obj != null) ? ((Color)obj) : default(Color);
		}
		set
		{
			this["DefaultColorBackground"] = value;
		}
	}

	// Token: 0x17000163 RID: 355
	// (get) Token: 0x06000A10 RID: 2576 RVA: 0x000E1574 File Offset: 0x000DF774
	// (set) Token: 0x06000A11 RID: 2577 RVA: 0x00003ED1 File Offset: 0x000020D1
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("9")]
	public int FontSize
	{
		get
		{
			return Conversions.ToInteger(this["FontSize"]);
		}
		set
		{
			this["FontSize"] = value;
		}
	}

	// Token: 0x17000164 RID: 356
	// (get) Token: 0x06000A12 RID: 2578 RVA: 0x000E1594 File Offset: 0x000DF794
	// (set) Token: 0x06000A13 RID: 2579 RVA: 0x00003EE4 File Offset: 0x000020E4
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Regular")]
	public string FontStyle
	{
		get
		{
			return Conversions.ToString(this["FontStyle"]);
		}
		set
		{
			this["FontStyle"] = value;
		}
	}

	// Token: 0x17000165 RID: 357
	// (get) Token: 0x06000A14 RID: 2580 RVA: 0x000E15B4 File Offset: 0x000DF7B4
	// (set) Token: 0x06000A15 RID: 2581 RVA: 0x00003EF2 File Offset: 0x000020F2
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00110000")]
	public string EncryptionKey
	{
		get
		{
			return Conversions.ToString(this["EncryptionKey"]);
		}
		set
		{
			this["EncryptionKey"] = value;
		}
	}

	// Token: 0x17000166 RID: 358
	// (get) Token: 0x06000A16 RID: 2582 RVA: 0x000E15D4 File Offset: 0x000DF7D4
	// (set) Token: 0x06000A17 RID: 2583 RVA: 0x00003F00 File Offset: 0x00002100
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Red")]
	public Color DefaultColor_NewColorFiles
	{
		get
		{
			object obj = this["DefaultColor_NewColorFiles"];
			return (obj != null) ? ((Color)obj) : default(Color);
		}
		set
		{
			this["DefaultColor_NewColorFiles"] = value;
		}
	}

	// Token: 0x17000167 RID: 359
	// (get) Token: 0x06000A18 RID: 2584 RVA: 0x000E1608 File Offset: 0x000DF808
	// (set) Token: 0x06000A19 RID: 2585 RVA: 0x00003F13 File Offset: 0x00002113
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Blue")]
	public Color DefaultColor_ColorTitles
	{
		get
		{
			object obj = this["DefaultColor_ColorTitles"];
			return (obj != null) ? ((Color)obj) : default(Color);
		}
		set
		{
			this["DefaultColor_ColorTitles"] = value;
		}
	}

	// Token: 0x17000168 RID: 360
	// (get) Token: 0x06000A1A RID: 2586 RVA: 0x000E163C File Offset: 0x000DF83C
	// (set) Token: 0x06000A1B RID: 2587 RVA: 0x00003F26 File Offset: 0x00002126
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("null")]
	public string BIND_Path
	{
		get
		{
			return Conversions.ToString(this["BIND_Path"]);
		}
		set
		{
			this["BIND_Path"] = value;
		}
	}

	// Token: 0x17000169 RID: 361
	// (get) Token: 0x06000A1C RID: 2588 RVA: 0x000E165C File Offset: 0x000DF85C
	// (set) Token: 0x06000A1D RID: 2589 RVA: 0x00003F34 File Offset: 0x00002134
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("null")]
	public string BIND_EX
	{
		get
		{
			return Conversions.ToString(this["BIND_EX"]);
		}
		set
		{
			this["BIND_EX"] = value;
		}
	}

	// Token: 0x1700016A RID: 362
	// (get) Token: 0x06000A1E RID: 2590 RVA: 0x000E167C File Offset: 0x000DF87C
	// (set) Token: 0x06000A1F RID: 2591 RVA: 0x00003F42 File Offset: 0x00002142
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("null")]
	public string intent
	{
		get
		{
			return Conversions.ToString(this["intent"]);
		}
		set
		{
			this["intent"] = value;
		}
	}

	// Token: 0x1700016B RID: 363
	// (get) Token: 0x06000A20 RID: 2592 RVA: 0x000E169C File Offset: 0x000DF89C
	// (set) Token: 0x06000A21 RID: 2593 RVA: 0x00003F50 File Offset: 0x00002150
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool NOTI_SOUND
	{
		get
		{
			return Conversions.ToBoolean(this["NOTI_SOUND"]);
		}
		set
		{
			this["NOTI_SOUND"] = value;
		}
	}

	// Token: 0x1700016C RID: 364
	// (get) Token: 0x06000A22 RID: 2594 RVA: 0x000E16BC File Offset: 0x000DF8BC
	// (set) Token: 0x06000A23 RID: 2595 RVA: 0x00003F63 File Offset: 0x00002163
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yes")]
	public string Flags_Visible
	{
		get
		{
			return Conversions.ToString(this["Flags_Visible"]);
		}
		set
		{
			this["Flags_Visible"] = value;
		}
	}

	// Token: 0x1700016D RID: 365
	// (get) Token: 0x06000A24 RID: 2596 RVA: 0x000E16DC File Offset: 0x000DF8DC
	// (set) Token: 0x06000A25 RID: 2597 RVA: 0x00003F71 File Offset: 0x00002171
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("32px")]
	public string Flags_Size
	{
		get
		{
			return Conversions.ToString(this["Flags_Size"]);
		}
		set
		{
			this["Flags_Size"] = value;
		}
	}

	// Token: 0x1700016E RID: 366
	// (get) Token: 0x06000A26 RID: 2598 RVA: 0x000E16FC File Offset: 0x000DF8FC
	// (set) Token: 0x06000A27 RID: 2599 RVA: 0x00003F7F File Offset: 0x0000217F
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yes")]
	public string Round
	{
		get
		{
			return Conversions.ToString(this["Round"]);
		}
		set
		{
			this["Round"] = value;
		}
	}

	// Token: 0x1700016F RID: 367
	// (get) Token: 0x06000A28 RID: 2600 RVA: 0x000E171C File Offset: 0x000DF91C
	// (set) Token: 0x06000A29 RID: 2601 RVA: 0x00003F8D File Offset: 0x0000218D
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yes")]
	public string SStatus_Visible
	{
		get
		{
			return Conversions.ToString(this["SStatus_Visible"]);
		}
		set
		{
			this["SStatus_Visible"] = value;
		}
	}

	// Token: 0x17000170 RID: 368
	// (get) Token: 0x06000A2A RID: 2602 RVA: 0x000E173C File Offset: 0x000DF93C
	// (set) Token: 0x06000A2B RID: 2603 RVA: 0x00003F9B File Offset: 0x0000219B
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0123456789")]
	public string _Columns
	{
		get
		{
			return Conversions.ToString(this["_Columns"]);
		}
		set
		{
			this["_Columns"] = value;
		}
	}

	// Token: 0x17000171 RID: 369
	// (get) Token: 0x06000A2C RID: 2604 RVA: 0x000E175C File Offset: 0x000DF95C
	// (set) Token: 0x06000A2D RID: 2605 RVA: 0x00003FA9 File Offset: 0x000021A9
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Small")]
	public string FM_IC_Size
	{
		get
		{
			return Conversions.ToString(this["FM_IC_Size"]);
		}
		set
		{
			this["FM_IC_Size"] = value;
		}
	}

	// Token: 0x17000172 RID: 370
	// (get) Token: 0x06000A2E RID: 2606 RVA: 0x000E177C File Offset: 0x000DF97C
	// (set) Token: 0x06000A2F RID: 2607 RVA: 0x00003FB7 File Offset: 0x000021B7
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yes")]
	public string Removing_Duplicates
	{
		get
		{
			return Conversions.ToString(this["Removing_Duplicates"]);
		}
		set
		{
			this["Removing_Duplicates"] = value;
		}
	}

	// Token: 0x17000173 RID: 371
	// (get) Token: 0x06000A30 RID: 2608 RVA: 0x000E179C File Offset: 0x000DF99C
	// (set) Token: 0x06000A31 RID: 2609 RVA: 0x00003FC5 File Offset: 0x000021C5
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("No")]
	public string _multi_sounds
	{
		get
		{
			return Conversions.ToString(this["_multi_sounds"]);
		}
		set
		{
			this["_multi_sounds"] = value;
		}
	}

	// Token: 0x17000174 RID: 372
	// (get) Token: 0x06000A32 RID: 2610 RVA: 0x000E17BC File Offset: 0x000DF9BC
	// (set) Token: 0x06000A33 RID: 2611 RVA: 0x00003FD3 File Offset: 0x000021D3
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	public int ImageQualty
	{
		get
		{
			return Conversions.ToInteger(this["ImageQualty"]);
		}
		set
		{
			this["ImageQualty"] = value;
		}
	}

	// Token: 0x17000175 RID: 373
	// (get) Token: 0x06000A34 RID: 2612 RVA: 0x000E17DC File Offset: 0x000DF9DC
	// (set) Token: 0x06000A35 RID: 2613 RVA: 0x00003FE6 File Offset: 0x000021E6
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yes")]
	public string Cashpic
	{
		get
		{
			return Conversions.ToString(this["Cashpic"]);
		}
		set
		{
			this["Cashpic"] = value;
		}
	}

	// Token: 0x17000176 RID: 374
	// (get) Token: 0x06000A36 RID: 2614 RVA: 0x000E17FC File Offset: 0x000DF9FC
	// (set) Token: 0x06000A37 RID: 2615 RVA: 0x00003FF4 File Offset: 0x000021F4
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yes")]
	public string LOG
	{
		get
		{
			return Conversions.ToString(this["LOG"]);
		}
		set
		{
			this["LOG"] = value;
		}
	}

	// Token: 0x17000177 RID: 375
	// (get) Token: 0x06000A38 RID: 2616 RVA: 0x000E181C File Offset: 0x000DFA1C
	// (set) Token: 0x06000A39 RID: 2617 RVA: 0x00004002 File Offset: 0x00002202
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("PT1BQUFic2RGQURhY0FTQ1ZERVNEVnNkU0RSVlNEVkFFR1NTRkJSRUE=")]
	public string DKEY
	{
		get
		{
			return Conversions.ToString(this["DKEY"]);
		}
		set
		{
			this["DKEY"] = value;
		}
	}

	// Token: 0x17000178 RID: 376
	// (get) Token: 0x06000A3A RID: 2618 RVA: 0x000E183C File Offset: 0x000DFA3C
	// (set) Token: 0x06000A3B RID: 2619 RVA: 0x00004010 File Offset: 0x00002210
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yes")]
	public string ShowAlertDis
	{
		get
		{
			return Conversions.ToString(this["ShowAlertDis"]);
		}
		set
		{
			this["ShowAlertDis"] = value;
		}
	}

	// Token: 0x17000179 RID: 377
	// (get) Token: 0x06000A3C RID: 2620 RVA: 0x000E185C File Offset: 0x000DFA5C
	// (set) Token: 0x06000A3D RID: 2621 RVA: 0x0000401E File Offset: 0x0000221E
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yes")]
	public string hidecoonstart
	{
		get
		{
			return Conversions.ToString(this["hidecoonstart"]);
		}
		set
		{
			this["hidecoonstart"] = value;
		}
	}

	// Token: 0x1700017A RID: 378
	// (get) Token: 0x06000A3E RID: 2622 RVA: 0x000E187C File Offset: 0x000DFA7C
	// (set) Token: 0x06000A3F RID: 2623 RVA: 0x0000402C File Offset: 0x0000222C
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("...")]
	public string inj_thost
	{
		get
		{
			return Conversions.ToString(this["inj_thost"]);
		}
		set
		{
			this["inj_thost"] = value;
		}
	}

	// Token: 0x1700017B RID: 379
	// (get) Token: 0x06000A40 RID: 2624 RVA: 0x000E189C File Offset: 0x000DFA9C
	// (set) Token: 0x06000A41 RID: 2625 RVA: 0x0000403A File Offset: 0x0000223A
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("4444")]
	public string inj_tport
	{
		get
		{
			return Conversions.ToString(this["inj_tport"]);
		}
		set
		{
			this["inj_tport"] = value;
		}
	}

	// Token: 0x1700017C RID: 380
	// (get) Token: 0x06000A42 RID: 2626 RVA: 0x000E18BC File Offset: 0x000DFABC
	// (set) Token: 0x06000A43 RID: 2627 RVA: 0x00004048 File Offset: 0x00002248
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1234")]
	public string inj_tkey
	{
		get
		{
			return Conversions.ToString(this["inj_tkey"]);
		}
		set
		{
			this["inj_tkey"] = value;
		}
	}

	// Token: 0x1700017D RID: 381
	// (get) Token: 0x06000A44 RID: 2628 RVA: 0x000E18DC File Offset: 0x000DFADC
	// (set) Token: 0x06000A45 RID: 2629 RVA: 0x00004056 File Offset: 0x00002256
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Client")]
	public string inj_tnam
	{
		get
		{
			return Conversions.ToString(this["inj_tnam"]);
		}
		set
		{
			this["inj_tnam"] = value;
		}
	}

	// Token: 0x1700017E RID: 382
	// (get) Token: 0x06000A46 RID: 2630 RVA: 0x000E18FC File Offset: 0x000DFAFC
	// (set) Token: 0x06000A47 RID: 2631 RVA: 0x00004064 File Offset: 0x00002264
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool requestmade
	{
		get
		{
			return Conversions.ToBoolean(this["requestmade"]);
		}
		set
		{
			this["requestmade"] = value;
		}
	}

	// Token: 0x1700017F RID: 383
	// (get) Token: 0x06000A48 RID: 2632 RVA: 0x000E191C File Offset: 0x000DFB1C
	// (set) Token: 0x06000A49 RID: 2633 RVA: 0x00004077 File Offset: 0x00002277
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool reportmade
	{
		get
		{
			return Conversions.ToBoolean(this["reportmade"]);
		}
		set
		{
			this["reportmade"] = value;
		}
	}

	// Token: 0x17000180 RID: 384
	// (get) Token: 0x06000A4A RID: 2634 RVA: 0x000E193C File Offset: 0x000DFB3C
	// (set) Token: 0x06000A4B RID: 2635 RVA: 0x0000408A File Offset: 0x0000228A
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("System update")]
	public string NotifiTitle
	{
		get
		{
			return Conversions.ToString(this["NotifiTitle"]);
		}
		set
		{
			this["NotifiTitle"] = value;
		}
	}

	// Token: 0x17000181 RID: 385
	// (get) Token: 0x06000A4C RID: 2636 RVA: 0x000E195C File Offset: 0x000DFB5C
	// (set) Token: 0x06000A4D RID: 2637 RVA: 0x00004098 File Offset: 0x00002298
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("New system software is available, Tap to learn more.")]
	public string NotifiText
	{
		get
		{
			return Conversions.ToString(this["NotifiText"]);
		}
		set
		{
			this["NotifiText"] = value;
		}
	}

	// Token: 0x17000182 RID: 386
	// (get) Token: 0x06000A4E RID: 2638 RVA: 0x000E197C File Offset: 0x000DFB7C
	// (set) Token: 0x06000A4F RID: 2639 RVA: 0x000040A6 File Offset: 0x000022A6
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("This App Request Accessibility Service:\r\n• Click on Enable\r\n• Go to Downloaded Service\r\n• Enable [MY-NAME]")]
	public string bodytext
	{
		get
		{
			return Conversions.ToString(this["bodytext"]);
		}
		set
		{
			this["bodytext"] = value;
		}
	}

	// Token: 0x17000183 RID: 387
	// (get) Token: 0x06000A50 RID: 2640 RVA: 0x000E199C File Offset: 0x000DFB9C
	// (set) Token: 0x06000A51 RID: 2641 RVA: 0x000040B4 File Offset: 0x000022B4
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("...")]
	public string accessdiscribe
	{
		get
		{
			return Conversions.ToString(this["accessdiscribe"]);
		}
		set
		{
			this["accessdiscribe"] = value;
		}
	}

	// Token: 0x17000184 RID: 388
	// (get) Token: 0x06000A52 RID: 2642 RVA: 0x000E19BC File Offset: 0x000DFBBC
	// (set) Token: 0x06000A53 RID: 2643 RVA: 0x000040C2 File Offset: 0x000022C2
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public string live_sc_qulty
	{
		get
		{
			return Conversions.ToString(this["live_sc_qulty"]);
		}
		set
		{
			this["live_sc_qulty"] = value;
		}
	}

	// Token: 0x17000185 RID: 389
	// (get) Token: 0x06000A54 RID: 2644 RVA: 0x000E19DC File Offset: 0x000DFBDC
	// (set) Token: 0x06000A55 RID: 2645 RVA: 0x000040D0 File Offset: 0x000022D0
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public string live_fps_rec
	{
		get
		{
			return Conversions.ToString(this["live_fps_rec"]);
		}
		set
		{
			this["live_fps_rec"] = value;
		}
	}

	// Token: 0x17000186 RID: 390
	// (get) Token: 0x06000A56 RID: 2646 RVA: 0x000E19FC File Offset: 0x000DFBFC
	// (set) Token: 0x06000A57 RID: 2647 RVA: 0x000040DE File Offset: 0x000022DE
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yes")]
	public string checkupdatestart
	{
		get
		{
			return Conversions.ToString(this["checkupdatestart"]);
		}
		set
		{
			this["checkupdatestart"] = value;
		}
	}

	// Token: 0x17000188 RID: 392
	// (get) Token: 0x06000A5A RID: 2650 RVA: 0x000E1A3C File Offset: 0x000DFC3C
	// (set) Token: 0x06000A5B RID: 2651 RVA: 0x000040FA File Offset: 0x000022FA
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool savepass
	{
		get
		{
			return Conversions.ToBoolean(this["savepass"]);
		}
		set
		{
			this["savepass"] = value;
		}
	}

	// Token: 0x17000189 RID: 393
	// (get) Token: 0x06000A5C RID: 2652 RVA: 0x000E1A5C File Offset: 0x000DFC5C
	// (set) Token: 0x06000A5D RID: 2653 RVA: 0x0000410D File Offset: 0x0000230D
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("450x300")]
	public string resolution
	{
		get
		{
			return Conversions.ToString(this["resolution"]);
		}
		set
		{
			this["resolution"] = value;
		}
	}

	// Token: 0x04001037 RID: 4151
	private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

	// Token: 0x04001038 RID: 4152
	private static bool addedHandler;

	// Token: 0x04001039 RID: 4153
	private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
}
