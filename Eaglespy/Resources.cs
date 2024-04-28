using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x020000F5 RID: 245
[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
[HideModuleName]
internal sealed class Resources
{
	// Token: 0x1700018C RID: 396
	// (get) Token: 0x06000A68 RID: 2664 RVA: 0x000E1AC0 File Offset: 0x000DFCC0
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (Resources.resourceMan == null)
			{
				ResourceManager resourceManager = new ResourceManager("Craxs_Rat.Resources", typeof(Resources).Assembly);
				Resources.resourceMan = resourceManager;
			}
			return Resources.resourceMan;
		}
	}

	// Token: 0x1700018D RID: 397
	// (get) Token: 0x06000A69 RID: 2665 RVA: 0x000E1B00 File Offset: 0x000DFD00
	// (set) Token: 0x06000A6A RID: 2666 RVA: 0x00004169 File Offset: 0x00002369
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return Resources.resourceCulture;
		}
		set
		{
			Resources.resourceCulture = value;
		}
	}

	// Token: 0x1700018E RID: 398
	// (get) Token: 0x06000A6B RID: 2667 RVA: 0x000E1B14 File Offset: 0x000DFD14
	internal static Bitmap _3g
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("_3g", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x1700018F RID: 399
	// (get) Token: 0x06000A6C RID: 2668 RVA: 0x000E1B44 File Offset: 0x000DFD44
	internal static Bitmap _on
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("_on", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x17000190 RID: 400
	// (get) Token: 0x06000A6D RID: 2669 RVA: 0x000E1B74 File Offset: 0x000DFD74
	internal static Bitmap Abov_mid
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Abov_mid", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x17000191 RID: 401
	// (get) Token: 0x06000A6E RID: 2670 RVA: 0x00004171 File Offset: 0x00002371
	internal static string accessibilityprivatesrcapp
	{
		get
		{
			return Resources.ResourceManager.GetString("accessibilityprivatesrcapp", Resources.resourceCulture);
		}
	}

	// Token: 0x17000192 RID: 402
	// (get) Token: 0x06000A6F RID: 2671 RVA: 0x00004187 File Offset: 0x00002387
	internal static string activity_req_access
	{
		get
		{
			return Resources.ResourceManager.GetString("activity_req_access", Resources.resourceCulture);
		}
	}

	// Token: 0x17000193 RID: 403
	// (get) Token: 0x06000A70 RID: 2672 RVA: 0x0000419D File Offset: 0x0000239D
	internal static string ALLPRIM
	{
		get
		{
			return Resources.ResourceManager.GetString("ALLPRIM", Resources.resourceCulture);
		}
	}

	// Token: 0x17000194 RID: 404
	// (get) Token: 0x06000A71 RID: 2673 RVA: 0x000E1BA4 File Offset: 0x000DFDA4
	internal static byte[] APKEditor
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("APKEditor", Resources.resourceCulture));
			return (byte[])objectValue;
		}
	}

	// Token: 0x17000195 RID: 405
	// (get) Token: 0x06000A72 RID: 2674 RVA: 0x000E1BD4 File Offset: 0x000DFDD4
	internal static byte[] apktool
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("apktool", Resources.resourceCulture));
			return (byte[])objectValue;
		}
	}

	// Token: 0x17000196 RID: 406
	// (get) Token: 0x06000A73 RID: 2675 RVA: 0x000E1C04 File Offset: 0x000DFE04
	internal static byte[] APPS
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("APPS", Resources.resourceCulture));
			return (byte[])objectValue;
		}
	}

	// Token: 0x17000197 RID: 407
	// (get) Token: 0x06000A74 RID: 2676 RVA: 0x000E1C34 File Offset: 0x000DFE34
	internal static Bitmap backcraxs3
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("backcraxs3", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x17000198 RID: 408
	// (get) Token: 0x06000A75 RID: 2677 RVA: 0x000041B3 File Offset: 0x000023B3
	internal static string batteryprim
	{
		get
		{
			return Resources.ResourceManager.GetString("batteryprim", Resources.resourceCulture);
		}
	}

	// Token: 0x17000199 RID: 409
	// (get) Token: 0x06000A76 RID: 2678 RVA: 0x000041C9 File Offset: 0x000023C9
	internal static string BootPrim
	{
		get
		{
			return Resources.ResourceManager.GetString("BootPrim", Resources.resourceCulture);
		}
	}

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x06000A77 RID: 2679 RVA: 0x000E1C64 File Offset: 0x000DFE64
	internal static byte[] c
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("c", Resources.resourceCulture));
			return (byte[])objectValue;
		}
	}

	// Token: 0x1700019B RID: 411
	// (get) Token: 0x06000A78 RID: 2680 RVA: 0x000E1C94 File Offset: 0x000DFE94
	internal static byte[] C2
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("C2", Resources.resourceCulture));
			return (byte[])objectValue;
		}
	}

	// Token: 0x1700019C RID: 412
	// (get) Token: 0x06000A79 RID: 2681 RVA: 0x000E1CC4 File Offset: 0x000DFEC4
	internal static Bitmap chrg
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("chrg", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x1700019D RID: 413
	// (get) Token: 0x06000A7A RID: 2682 RVA: 0x000E1CF4 File Offset: 0x000DFEF4
	internal static Bitmap close48px
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("close48px", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x1700019E RID: 414
	// (get) Token: 0x06000A7B RID: 2683 RVA: 0x000E1D24 File Offset: 0x000DFF24
	internal static Bitmap Compile
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Compile", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x1700019F RID: 415
	// (get) Token: 0x06000A7C RID: 2684 RVA: 0x000E1D54 File Offset: 0x000DFF54
	internal static Bitmap correctsign
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("correctsign", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001A0 RID: 416
	// (get) Token: 0x06000A7D RID: 2685 RVA: 0x000041DF File Offset: 0x000023DF
	internal static string CraxsAsci
	{
		get
		{
			return Resources.ResourceManager.GetString("CraxsAsci", Resources.resourceCulture);
		}
	}

	// Token: 0x170001A1 RID: 417
	// (get) Token: 0x06000A7E RID: 2686 RVA: 0x000041F5 File Offset: 0x000023F5
	internal static string CypherMini
	{
		get
		{
			return Resources.ResourceManager.GetString("CypherMini", Resources.resourceCulture);
		}
	}

	// Token: 0x170001A2 RID: 418
	// (get) Token: 0x06000A7F RID: 2687 RVA: 0x0000420B File Offset: 0x0000240B
	internal static string DataP
	{
		get
		{
			return Resources.ResourceManager.GetString("DataP", Resources.resourceCulture);
		}
	}

	// Token: 0x170001A3 RID: 419
	// (get) Token: 0x06000A80 RID: 2688 RVA: 0x00004221 File Offset: 0x00002421
	internal static string DB
	{
		get
		{
			return Resources.ResourceManager.GetString("DB", Resources.resourceCulture);
		}
	}

	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x06000A81 RID: 2689 RVA: 0x000E1D84 File Offset: 0x000DFF84
	internal static Bitmap Decompile
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Decompile", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x06000A82 RID: 2690 RVA: 0x000E1DB4 File Offset: 0x000DFFB4
	internal static Bitmap disconnected
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("disconnected", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001A6 RID: 422
	// (get) Token: 0x06000A83 RID: 2691 RVA: 0x000E1DE4 File Offset: 0x000DFFE4
	internal static byte[] dropstub
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("dropstub", Resources.resourceCulture));
			return (byte[])objectValue;
		}
	}

	// Token: 0x170001A7 RID: 423
	// (get) Token: 0x06000A84 RID: 2692 RVA: 0x000E1E14 File Offset: 0x000E0014
	internal static Bitmap error48px
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("error48px", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001A8 RID: 424
	// (get) Token: 0x06000A85 RID: 2693 RVA: 0x00004237 File Offset: 0x00002437
	internal static string FORGROUD
	{
		get
		{
			return Resources.ResourceManager.GetString("FORGROUD", Resources.resourceCulture);
		}
	}

	// Token: 0x170001A9 RID: 425
	// (get) Token: 0x06000A86 RID: 2694 RVA: 0x000E1E44 File Offset: 0x000E0044
	internal static Bitmap full
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("full", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001AA RID: 426
	// (get) Token: 0x06000A87 RID: 2695 RVA: 0x0000424D File Offset: 0x0000244D
	internal static string GRESSTR
	{
		get
		{
			return Resources.ResourceManager.GetString("GRESSTR", Resources.resourceCulture);
		}
	}

	// Token: 0x170001AB RID: 427
	// (get) Token: 0x06000A88 RID: 2696 RVA: 0x00004263 File Offset: 0x00002463
	internal static string GSTART
	{
		get
		{
			return Resources.ResourceManager.GetString("GSTART", Resources.resourceCulture);
		}
	}

	// Token: 0x170001AC RID: 428
	// (get) Token: 0x06000A89 RID: 2697 RVA: 0x00004279 File Offset: 0x00002479
	internal static string HIDECODE
	{
		get
		{
			return Resources.ResourceManager.GetString("HIDECODE", Resources.resourceCulture);
		}
	}

	// Token: 0x170001AD RID: 429
	// (get) Token: 0x06000A8A RID: 2698 RVA: 0x000E1E74 File Offset: 0x000E0074
	internal static Bitmap incall_removebg_preview
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("incall_removebg_preview", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001AE RID: 430
	// (get) Token: 0x06000A8B RID: 2699 RVA: 0x000E1EA4 File Offset: 0x000E00A4
	internal static Bitmap information48px
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("information48px", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001AF RID: 431
	// (get) Token: 0x06000A8C RID: 2700 RVA: 0x000E1ED4 File Offset: 0x000E00D4
	internal static Bitmap InstallApk
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("InstallApk", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001B0 RID: 432
	// (get) Token: 0x06000A8D RID: 2701 RVA: 0x000E1F04 File Offset: 0x000E0104
	internal static byte[] junk
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("junk", Resources.resourceCulture));
			return (byte[])objectValue;
		}
	}

	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x06000A8E RID: 2702 RVA: 0x000E1F34 File Offset: 0x000E0134
	internal static byte[] k
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("k", Resources.resourceCulture));
			return (byte[])objectValue;
		}
	}

	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x06000A8F RID: 2703 RVA: 0x000E1F64 File Offset: 0x000E0164
	internal static byte[] K2
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("K2", Resources.resourceCulture));
			return (byte[])objectValue;
		}
	}

	// Token: 0x170001B3 RID: 435
	// (get) Token: 0x06000A90 RID: 2704 RVA: 0x000E1F94 File Offset: 0x000E0194
	internal static Bitmap lie
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("lie", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001B4 RID: 436
	// (get) Token: 0x06000A91 RID: 2705 RVA: 0x000E1FC4 File Offset: 0x000E01C4
	internal static Bitmap loading_please_wait
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("loading_please_wait", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x06000A92 RID: 2706 RVA: 0x000E1FF4 File Offset: 0x000E01F4
	internal static Bitmap log
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("log", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x06000A93 RID: 2707 RVA: 0x000E2024 File Offset: 0x000E0224
	internal static Bitmap LOGO
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("LOGO", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001B7 RID: 439
	// (get) Token: 0x06000A94 RID: 2708 RVA: 0x0000428F File Offset: 0x0000248F
	internal static string LOGS
	{
		get
		{
			return Resources.ResourceManager.GetString("LOGS", Resources.resourceCulture);
		}
	}

	// Token: 0x170001B8 RID: 440
	// (get) Token: 0x06000A95 RID: 2709 RVA: 0x000E2054 File Offset: 0x000E0254
	internal static Bitmap low
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("low", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001B9 RID: 441
	// (get) Token: 0x06000A96 RID: 2710 RVA: 0x000042A5 File Offset: 0x000024A5
	internal static string MainMith
	{
		get
		{
			return Resources.ResourceManager.GetString("MainMith", Resources.resourceCulture);
		}
	}

	// Token: 0x170001BA RID: 442
	// (get) Token: 0x06000A97 RID: 2711 RVA: 0x000042BB File Offset: 0x000024BB
	internal static string map
	{
		get
		{
			return Resources.ResourceManager.GetString("map", Resources.resourceCulture);
		}
	}

	// Token: 0x170001BB RID: 443
	// (get) Token: 0x06000A98 RID: 2712 RVA: 0x000E2084 File Offset: 0x000E0284
	internal static Icon max
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("max", Resources.resourceCulture));
			return (Icon)objectValue;
		}
	}

	// Token: 0x170001BC RID: 444
	// (get) Token: 0x06000A99 RID: 2713 RVA: 0x000042D1 File Offset: 0x000024D1
	internal static string MethRn
	{
		get
		{
			return Resources.ResourceManager.GetString("MethRn", Resources.resourceCulture);
		}
	}

	// Token: 0x170001BD RID: 445
	// (get) Token: 0x06000A9A RID: 2714 RVA: 0x000E20B4 File Offset: 0x000E02B4
	internal static Bitmap min
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("min", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001BE RID: 446
	// (get) Token: 0x06000A9B RID: 2715 RVA: 0x000E20E4 File Offset: 0x000E02E4
	internal static byte[] MYSTUB
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("MYSTUB", Resources.resourceCulture));
			return (byte[])objectValue;
		}
	}

	// Token: 0x170001BF RID: 447
	// (get) Token: 0x06000A9C RID: 2716 RVA: 0x000E2114 File Offset: 0x000E0314
	internal static byte[] MYSTUBTEN
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("MYSTUBTEN", Resources.resourceCulture));
			return (byte[])objectValue;
		}
	}

	// Token: 0x170001C0 RID: 448
	// (get) Token: 0x06000A9D RID: 2717 RVA: 0x000E2144 File Offset: 0x000E0344
	internal static Bitmap new_call
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("new_call", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001C1 RID: 449
	// (get) Token: 0x06000A9E RID: 2718 RVA: 0x000E2174 File Offset: 0x000E0374
	internal static Bitmap new_notifi
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("new_notifi", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001C2 RID: 450
	// (get) Token: 0x06000A9F RID: 2719 RVA: 0x000E21A4 File Offset: 0x000E03A4
	internal static Bitmap noicon
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("noicon", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001C3 RID: 451
	// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x000E21D4 File Offset: 0x000E03D4
	internal static Bitmap not_found
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("not_found", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001C4 RID: 452
	// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x000E2204 File Offset: 0x000E0404
	internal static Bitmap notifi
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("notifi", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001C5 RID: 453
	// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x000E2234 File Offset: 0x000E0434
	internal static Bitmap notok
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("notok", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001C6 RID: 454
	// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x000E2264 File Offset: 0x000E0464
	internal static Bitmap OFF
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("OFF", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001C7 RID: 455
	// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x000E2294 File Offset: 0x000E0494
	internal static Bitmap OFF_LOCK
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("OFF_LOCK", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001C8 RID: 456
	// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x000E22C4 File Offset: 0x000E04C4
	internal static Bitmap ok
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("ok", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001C9 RID: 457
	// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x000E22F4 File Offset: 0x000E04F4
	internal static Bitmap ON_LOCK
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("ON_LOCK", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001CA RID: 458
	// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x000042E7 File Offset: 0x000024E7
	internal static string oncreatecode
	{
		get
		{
			return Resources.ResourceManager.GetString("oncreatecode", Resources.resourceCulture);
		}
	}

	// Token: 0x170001CB RID: 459
	// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x000E2324 File Offset: 0x000E0524
	internal static Bitmap onloading
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("onloading", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001CC RID: 460
	// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x000E2354 File Offset: 0x000E0554
	internal static Bitmap outcall_removebg_preview
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("outcall_removebg_preview", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001CD RID: 461
	// (get) Token: 0x06000AAA RID: 2730 RVA: 0x000042FD File Offset: 0x000024FD
	internal static string PRO
	{
		get
		{
			return Resources.ResourceManager.GetString("PRO", Resources.resourceCulture);
		}
	}

	// Token: 0x170001CE RID: 462
	// (get) Token: 0x06000AAB RID: 2731 RVA: 0x000E2384 File Offset: 0x000E0584
	internal static Bitmap protect
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("protect", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001CF RID: 463
	// (get) Token: 0x06000AAC RID: 2732 RVA: 0x00004313 File Offset: 0x00002513
	internal static string ReadPrim
	{
		get
		{
			return Resources.ResourceManager.GetString("ReadPrim", Resources.resourceCulture);
		}
	}

	// Token: 0x170001D0 RID: 464
	// (get) Token: 0x06000AAD RID: 2733 RVA: 0x000E23B4 File Offset: 0x000E05B4
	internal static Bitmap recoeded
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("recoeded", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001D1 RID: 465
	// (get) Token: 0x06000AAE RID: 2734 RVA: 0x000E23E4 File Offset: 0x000E05E4
	internal static Bitmap screenshoterfram
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("screenshoterfram", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001D2 RID: 466
	// (get) Token: 0x06000AAF RID: 2735 RVA: 0x00004329 File Offset: 0x00002529
	internal static string SDK29
	{
		get
		{
			return Resources.ResourceManager.GetString("SDK29", Resources.resourceCulture);
		}
	}

	// Token: 0x170001D3 RID: 467
	// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x000E2414 File Offset: 0x000E0614
	internal static Bitmap shieldoff
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("shieldoff", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001D4 RID: 468
	// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x000E2444 File Offset: 0x000E0644
	internal static Bitmap shieldon
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("shieldon", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001D5 RID: 469
	// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x000E2474 File Offset: 0x000E0674
	internal static Bitmap sign
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("sign", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001D6 RID: 470
	// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x000E24A4 File Offset: 0x000E06A4
	internal static byte[] signapk
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("signapk", Resources.resourceCulture));
			return (byte[])objectValue;
		}
	}

	// Token: 0x170001D7 RID: 471
	// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x000E24D4 File Offset: 0x000E06D4
	internal static Bitmap sstore
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("sstore", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001D8 RID: 472
	// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0000433F File Offset: 0x0000253F
	internal static string String1
	{
		get
		{
			return Resources.ResourceManager.GetString("String1", Resources.resourceCulture);
		}
	}

	// Token: 0x170001D9 RID: 473
	// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x000E2504 File Offset: 0x000E0704
	internal static Bitmap sucess48px
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("sucess48px", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001DA RID: 474
	// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x000E2534 File Offset: 0x000E0734
	internal static Bitmap swtchoff
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("swtchoff", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001DB RID: 475
	// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x000E2564 File Offset: 0x000E0764
	internal static Bitmap swtchon
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("swtchon", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001DC RID: 476
	// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x00004355 File Offset: 0x00002555
	internal static string SystemwindowPrim
	{
		get
		{
			return Resources.ResourceManager.GetString("SystemwindowPrim", Resources.resourceCulture);
		}
	}

	// Token: 0x170001DD RID: 477
	// (get) Token: 0x06000ABA RID: 2746 RVA: 0x000E2594 File Offset: 0x000E0794
	internal static Bitmap target__1_
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("target__1_", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001DE RID: 478
	// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0000436B File Offset: 0x0000256B
	internal static string TF
	{
		get
		{
			return Resources.ResourceManager.GetString("TF", Resources.resourceCulture);
		}
	}

	// Token: 0x170001DF RID: 479
	// (get) Token: 0x06000ABC RID: 2748 RVA: 0x000E25C4 File Offset: 0x000E07C4
	internal static Bitmap Tip_screenctrol
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Tip_screenctrol", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001E0 RID: 480
	// (get) Token: 0x06000ABD RID: 2749 RVA: 0x00004381 File Offset: 0x00002581
	internal static string Toreplaceprim
	{
		get
		{
			return Resources.ResourceManager.GetString("Toreplaceprim", Resources.resourceCulture);
		}
	}

	// Token: 0x170001E1 RID: 481
	// (get) Token: 0x06000ABE RID: 2750 RVA: 0x000E25F4 File Offset: 0x000E07F4
	internal static byte[] up
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("up", Resources.resourceCulture));
			return (byte[])objectValue;
		}
	}

	// Token: 0x170001E2 RID: 482
	// (get) Token: 0x06000ABF RID: 2751 RVA: 0x00004397 File Offset: 0x00002597
	internal static string wallpaper
	{
		get
		{
			return Resources.ResourceManager.GetString("wallpaper", Resources.resourceCulture);
		}
	}

	// Token: 0x170001E3 RID: 483
	// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x000E2624 File Offset: 0x000E0824
	internal static Bitmap warning48px
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("warning48px", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001E4 RID: 484
	// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x000E2654 File Offset: 0x000E0854
	internal static Bitmap wifi
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("wifi", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001E5 RID: 485
	// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x000043AD File Offset: 0x000025AD
	internal static string WritePrim
	{
		get
		{
			return Resources.ResourceManager.GetString("WritePrim", Resources.resourceCulture);
		}
	}

	// Token: 0x170001E6 RID: 486
	// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x000E2684 File Offset: 0x000E0884
	internal static Bitmap X_sign
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("X_sign", Resources.resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x170001E7 RID: 487
	// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x000E26B4 File Offset: 0x000E08B4
	internal static byte[] zipalign
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("zipalign", Resources.resourceCulture));
			return (byte[])objectValue;
		}
	}

	// Token: 0x0400103C RID: 4156
	private static ResourceManager resourceMan;

	// Token: 0x0400103D RID: 4157
	private static CultureInfo resourceCulture;
}
