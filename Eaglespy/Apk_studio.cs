using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000026 RID: 38
[DesignerGenerated]
public partial class Apk_studio : Form
{
	// Token: 0x0600018D RID: 397 RVA: 0x00010044 File Offset: 0x0000E244
	public Apk_studio()
	{
		base.Load += this.Apk_studio_Load;
		this.TargetAPKPATH = "";
		this.TargetAPKNAME = "";
		this.TargetWorkPATH = "";
		this.craxsStudioPath = "";
		this.APKINFO = "";
		this.Apkeditorpath = "";
		this.InitializeComponent();
	}

	// Token: 0x0600018E RID: 398 RVA: 0x000100B4 File Offset: 0x0000E2B4
	public void log(string str)
	{
		base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
		{
			this.logtext.AppendText("> " + str + "\r\n-----------------------\r\n");
		}));
	}

	// Token: 0x0600018F RID: 399 RVA: 0x000100E8 File Offset: 0x0000E2E8
	private void Selectapkbtn_Click(object sender, EventArgs e)
	{
		if (this.BackgroundWorker1.IsBusy)
		{
			EagleAlert.Showinformation("Please Wait.");
		}
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Title = "Selecte Android App [Only .apk] (.apk)";
		openFileDialog.Filter = "apk Files|*.apk";
		openFileDialog.RestoreDirectory = true;
		DialogResult dialogResult = openFileDialog.ShowDialog();
		if (dialogResult != DialogResult.OK)
		{
			this.TargetApktext.Text = "";
		}
		else
		{
			this.TargetApktext.Text = openFileDialog.FileName;
			this.TargetAPKPATH = openFileDialog.FileName;
			string directoryName = Path.GetDirectoryName(this.TargetAPKPATH);
			this.TargetAPKNAME = Path.GetFileNameWithoutExtension(this.TargetAPKPATH);
			this.craxsStudioPath = directoryName + "\\Craxs_Studio";
			if (!Directory.Exists(this.craxsStudioPath))
			{
				Directory.CreateDirectory(this.craxsStudioPath);
			}
			this.titlespanel.Enabled = true;
			this.titlespanel.Visible = true;
			if (!this.BackgroundWorker1.IsBusy)
			{
				this.BackgroundWorker1.RunWorkerAsync();
			}
		}
	}

	// Token: 0x06000190 RID: 400 RVA: 0x000101F0 File Offset: 0x0000E3F0
	private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		if (!string.IsNullOrEmpty(this.TargetAPKPATH))
		{
			Apk_studio._Closure_0024__116_002D0 arg = null;
			Apk_studio._Closure_0024__116_002D0 CS_0024_003C_003E8__locals0 = new Apk_studio._Closure_0024__116_002D0(arg);
			CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
			this.APKINFO = Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\aapt.exe"), "dump badging \"" + this.TargetAPKPATH + "\"", 5000);
			if (this.apkicon.Image != null)
			{
				this.apkicon.Image.Dispose();
				this.apkicon.Image = null;
			}
			CS_0024_003C_003E8__locals0._0024VB_0024Local_appname = Codes.ExtractName(this.TargetAPKPATH);
			CS_0024_003C_003E8__locals0._0024VB_0024Local_PackageName = Conversions.ToString(Codes.RegexMatcher("(?<=package: name=\\')(.*?)(?=\\')", this.APKINFO));
			CS_0024_003C_003E8__locals0._0024VB_0024Local_Vercode = Conversions.ToString(Codes.RegexMatcher("(?<=versionCode=\\')(.*?)(?=\\')", this.APKINFO));
			CS_0024_003C_003E8__locals0._0024VB_0024Local_Vername = Conversions.ToString(Codes.RegexMatcher("(?<=versionName=\\')(.*?)(?=\\')", this.APKINFO));
			string sdkNumber = Conversions.ToString(Codes.RegexMatcher("(?<=sdkVersion:\\')(.*?)(?=\\')", this.APKINFO));
			CS_0024_003C_003E8__locals0._0024VB_0024Local_androidfrom = Codes.GetAndroidVersionName(sdkNumber);
			string sdkNumber2 = Conversions.ToString(Codes.RegexMatcher("(?<=targetSdkVersion:\\')(.*?)(?=\\')", this.APKINFO));
			CS_0024_003C_003E8__locals0._0024VB_0024Local_androidto = Codes.GetAndroidVersionName(sdkNumber2);
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
						goto IL_1FE;
					}
				}
				CS_0024_003C_003E8__locals0._0024VB_0024Local_appname = "Not found";
			}
			IL_1FE:
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) != 0)
			{
				if (Operators.CompareString(language, "CN", false) != 0)
				{
					base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
					{
						CS_0024_003C_003E8__locals0._0024VB_0024Me.nametext.Text = "App Name: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_appname;
						CS_0024_003C_003E8__locals0._0024VB_0024Me.pkgtext.Text = "Package Name: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_PackageName;
						CS_0024_003C_003E8__locals0._0024VB_0024Me.vercodtext.Text = "Version Code: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_Vercode;
						CS_0024_003C_003E8__locals0._0024VB_0024Me.vernamtext.Text = "Version Name: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_Vername;
						CS_0024_003C_003E8__locals0._0024VB_0024Me.andfromtext.Text = "Support from: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_androidfrom;
						CS_0024_003C_003E8__locals0._0024VB_0024Me.andtotext.Text = "Support up to: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_androidto;
					}));
				}
				else
				{
					base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
					{
						CS_0024_003C_003E8__locals0._0024VB_0024Me.nametext.Text = "姓名: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_appname;
						CS_0024_003C_003E8__locals0._0024VB_0024Me.pkgtext.Text = "标识符: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_PackageName;
						CS_0024_003C_003E8__locals0._0024VB_0024Me.vercodtext.Text = "版本代码: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_Vercode;
						CS_0024_003C_003E8__locals0._0024VB_0024Me.vernamtext.Text = "版本名称: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_Vername;
						CS_0024_003C_003E8__locals0._0024VB_0024Me.andfromtext.Text = "来自的支持: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_androidfrom;
						CS_0024_003C_003E8__locals0._0024VB_0024Me.andtotext.Text = "支持高达: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_androidto;
					}));
				}
			}
			else
			{
				base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
				{
					CS_0024_003C_003E8__locals0._0024VB_0024Me.nametext.Text = "الأسم: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_appname;
					CS_0024_003C_003E8__locals0._0024VB_0024Me.pkgtext.Text = "المعرف: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_PackageName;
					CS_0024_003C_003E8__locals0._0024VB_0024Me.vercodtext.Text = "رقم الاصدار: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_Vercode;
					CS_0024_003C_003E8__locals0._0024VB_0024Me.vernamtext.Text = "اسم الاصدار: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_Vername;
					CS_0024_003C_003E8__locals0._0024VB_0024Me.andfromtext.Text = "يدعم من: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_androidfrom;
					CS_0024_003C_003E8__locals0._0024VB_0024Me.andtotext.Text = "يدعم حتى: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_androidto;
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
			}
			catch (Exception)
			{
				this.apkicon.Image = Resources.noicon;
			}
		}
	}

	// Token: 0x06000191 RID: 401 RVA: 0x00010664 File Offset: 0x0000E864
	private void Button1_Click(object sender, EventArgs e)
	{
		if (this.apkicon.Image != null)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.FileName = "image.png";
			saveFileDialog.Filter = "PNG Image|*.png";
			saveFileDialog.RestoreDirectory = true;
			DialogResult dialogResult = saveFileDialog.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				string fileName = saveFileDialog.FileName;
				Image image = this.apkicon.Image;
				Bitmap bitmap = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb);
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height));
				}
				bitmap.Save(fileName, ImageFormat.Png);
				EagleAlert.ShowSucess("Image saved successfully.");
			}
		}
		else
		{
			EagleAlert.Showinformation("No image to save.");
		}
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00010750 File Offset: 0x0000E950
	private void Andtotext_Click(object sender, EventArgs e)
	{
		Label label = (Label)sender;
		Clipboard.SetText(label.Text);
		EagleAlert.ShowSucess("copied to clipboard: " + label.Text);
	}

	// Token: 0x06000193 RID: 403 RVA: 0x00010784 File Offset: 0x0000E984
	private void Button2_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.TargetAPKPATH))
		{
			EagleAlert.Showinformation("Select Apk First.");
		}
		else if (!Directory.Exists(this.TargetWorkPATH) || Codes.MyMsgBox("Confirm", "this app is decompiled before \r\nDecompile again ?", true, Resources.information48px))
		{
			if (this.deworker.IsBusy)
			{
				EagleAlert.Showinformation("Decompiling  , Please Wait...");
			}
			else
			{
				this.log("Starting Decompile..");
				this.deworker.RunWorkerAsync();
			}
		}
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00010800 File Offset: 0x0000EA00
	private void Deworker_DoWork(object sender, DoWorkEventArgs e)
	{
		string directoryName = Path.GetDirectoryName(this.TargetAPKPATH);
		this.TargetWorkPATH = directoryName + "\\Craxs_Studio\\" + this.TargetAPKNAME;
		string text = Codes.ExecuteDecompile(this.TargetAPKPATH, this.TargetWorkPATH);
		base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
		{
			if (text.Contains("Copying original files"))
			{
				EagleAlert.ShowSucess("Decompiling finish");
				this.log("Decompiling finish");
				this.workdirtext.Text = this.TargetWorkPATH;
			}
			else
			{
				EagleAlert.ShowError("Decompiling failed");
				this.log("Decompiling failed");
			}
			this.log(text.Replace("\r\n", "\r\n"));
		}));
	}

	// Token: 0x06000195 RID: 405 RVA: 0x00010868 File Offset: 0x0000EA68
	private void Button5_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.TargetAPKPATH))
		{
			EagleAlert.Showinformation("Select Apk First.");
		}
		else if (this.protectworker.IsBusy)
		{
			EagleAlert.Showinformation("Protector is busy , Please Wait...");
		}
		else
		{
			this.protectworker.RunWorkerAsync();
		}
	}

	// Token: 0x06000196 RID: 406 RVA: 0x000108B4 File Offset: 0x0000EAB4
	private void Protectworker_DoWork(object sender, DoWorkEventArgs e)
	{
		string str = Codes.Excuteapkeditor_pro(this.TargetAPKPATH);
		base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
		{
			if (File.Exists(this.TargetAPKPATH.Replace(".apk", "_protected.apk")))
			{
				this.log("APK Protected finish");
				EagleAlert.ShowSucess("APK Protected finish");
			}
			else
			{
				this.log("APK Protected failed");
				EagleAlert.ShowSucess("APK Protected failed");
			}
			this.log(str);
		}));
	}

	// Token: 0x06000197 RID: 407 RVA: 0x000108F4 File Offset: 0x0000EAF4
	private void Button4_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.TargetAPKPATH))
		{
			EagleAlert.Showinformation("Select Apk First.");
		}
		else if (string.IsNullOrEmpty(this.TargetWorkPATH))
		{
			EagleAlert.Showinformation("Decompile Apk First.");
		}
		else if (this.COworker.IsBusy)
		{
			EagleAlert.Showinformation("Compiling  , Please Wait...");
		}
		else
		{
			this.COworker.RunWorkerAsync();
		}
	}

	// Token: 0x06000198 RID: 408 RVA: 0x00010958 File Offset: 0x0000EB58
	private void COworker_DoWork(object sender, DoWorkEventArgs e)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.FileName = this.TargetAPKNAME + "_CRAX.apk";
		saveFileDialog.Filter = "APK file|*.apk";
		saveFileDialog.RestoreDirectory = true;
		DialogResult dialogResult = DialogResult.None;
		base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
		{
			dialogResult = saveFileDialog.ShowDialog();
		}));
		if (dialogResult == DialogResult.OK)
		{
			string fileName = saveFileDialog.FileName;
			string text = Codes.ExecuteCompile(this.TargetWorkPATH, fileName);
			base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
			{
				if (text.Contains("Built apk"))
				{
					EagleAlert.ShowSucess("Compiling finish");
					this.log("Compiling finish");
				}
				this.log(text.Replace("\r\n", "\r\n"));
			}));
		}
	}

	// Token: 0x06000199 RID: 409 RVA: 0x00010A10 File Offset: 0x0000EC10
	private void Button3_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.TargetAPKPATH))
		{
			EagleAlert.Showinformation("Select Apk First.");
		}
		else
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.FileName = this.TargetAPKNAME + "_Signed.apk";
			saveFileDialog.Filter = "APK file|*.apk";
			saveFileDialog.RestoreDirectory = true;
			DialogResult dialogResult = DialogResult.None;
			base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
			{
				dialogResult = saveFileDialog.ShowDialog();
			}));
			if (dialogResult == DialogResult.OK)
			{
				string fileName = saveFileDialog.FileName;
				Codes.ExecuteSign(this.TargetAPKPATH, fileName);
				base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
				{
					this.log("Sing finish");
					if (File.Exists(fileName))
					{
						EagleAlert.ShowSucess("Sing finish");
						this.log("Sing finish");
					}
					else
					{
						EagleAlert.ShowError("Sing failed");
						this.log("Sing failed");
					}
				}));
			}
		}
	}

	// Token: 0x0600019A RID: 410 RVA: 0x0000206C File Offset: 0x0000026C
	private void TargetApktext_TextChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x0600019B RID: 411 RVA: 0x000022E5 File Offset: 0x000004E5
	private void Apk_studio_Load(object sender, EventArgs e)
	{
		this.Translateme();
	}

	// Token: 0x0600019C RID: 412 RVA: 0x00010AE8 File Offset: 0x0000ECE8
	private void Translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", false) != 0)
		{
			if (Operators.CompareString(language, "CN", false) == 0)
			{
				this.savebtn.Text = "保存图片";
				this.debtn.Text = "反编译";
				this.cobtn.Text = "编译";
				this.sinbtn.Text = "签名";
				this.probtn.Text = "保护";
				this.selectapkbtn.Text = "选择一个文件";
				this.Label2.Text = "工作路径";
			}
		}
		else
		{
			this.savebtn.Text = "احفظ الصورة";
			this.debtn.Text = "فك التطبيق";
			this.cobtn.Text = "تجميع";
			this.sinbtn.Text = "إمضاء";
			this.probtn.Text = "حماية";
			this.selectapkbtn.Text = "إختيار تطبيق";
			this.Label2.Text = "مسار العمل";
		}
	}

	// Token: 0x040000D8 RID: 216
	private string TargetAPKPATH;

	// Token: 0x040000D9 RID: 217
	private string TargetAPKNAME;

	// Token: 0x040000DA RID: 218
	private string TargetWorkPATH;

	// Token: 0x040000DB RID: 219
	private string craxsStudioPath;

	// Token: 0x040000DC RID: 220
	private string APKINFO;

	// Token: 0x040000DD RID: 221
	private string Apkeditorpath;

	// Token: 0x02000027 RID: 39
	[CompilerGenerated]
	internal sealed class _Closure_0024__116_002D0
	{
		// Token: 0x0600019D RID: 413 RVA: 0x00010C08 File Offset: 0x0000EE08
		public _Closure_0024__116_002D0(Apk_studio._Closure_0024__116_002D0 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_appname = arg0._0024VB_0024Local_appname;
				this._0024VB_0024Local_PackageName = arg0._0024VB_0024Local_PackageName;
				this._0024VB_0024Local_Vercode = arg0._0024VB_0024Local_Vercode;
				this._0024VB_0024Local_Vername = arg0._0024VB_0024Local_Vername;
				this._0024VB_0024Local_androidfrom = arg0._0024VB_0024Local_androidfrom;
				this._0024VB_0024Local_androidto = arg0._0024VB_0024Local_androidto;
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00010C6C File Offset: 0x0000EE6C
		internal void _Lambda_0024__0()
		{
			this._0024VB_0024Me.nametext.Text = "الأسم: " + this._0024VB_0024Local_appname;
			this._0024VB_0024Me.pkgtext.Text = "المعرف: " + this._0024VB_0024Local_PackageName;
			this._0024VB_0024Me.vercodtext.Text = "رقم الاصدار: " + this._0024VB_0024Local_Vercode;
			this._0024VB_0024Me.vernamtext.Text = "اسم الاصدار: " + this._0024VB_0024Local_Vername;
			this._0024VB_0024Me.andfromtext.Text = "يدعم من: " + this._0024VB_0024Local_androidfrom;
			this._0024VB_0024Me.andtotext.Text = "يدعم حتى: " + this._0024VB_0024Local_androidto;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00010D3C File Offset: 0x0000EF3C
		internal void _Lambda_0024__1()
		{
			this._0024VB_0024Me.nametext.Text = "姓名: " + this._0024VB_0024Local_appname;
			this._0024VB_0024Me.pkgtext.Text = "标识符: " + this._0024VB_0024Local_PackageName;
			this._0024VB_0024Me.vercodtext.Text = "版本代码: " + this._0024VB_0024Local_Vercode;
			this._0024VB_0024Me.vernamtext.Text = "版本名称: " + this._0024VB_0024Local_Vername;
			this._0024VB_0024Me.andfromtext.Text = "来自的支持: " + this._0024VB_0024Local_androidfrom;
			this._0024VB_0024Me.andtotext.Text = "支持高达: " + this._0024VB_0024Local_androidto;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00010E0C File Offset: 0x0000F00C
		internal void _Lambda_0024__2()
		{
			this._0024VB_0024Me.nametext.Text = "App Name: " + this._0024VB_0024Local_appname;
			this._0024VB_0024Me.pkgtext.Text = "Package Name: " + this._0024VB_0024Local_PackageName;
			this._0024VB_0024Me.vercodtext.Text = "Version Code: " + this._0024VB_0024Local_Vercode;
			this._0024VB_0024Me.vernamtext.Text = "Version Name: " + this._0024VB_0024Local_Vername;
			this._0024VB_0024Me.andfromtext.Text = "Support from: " + this._0024VB_0024Local_androidfrom;
			this._0024VB_0024Me.andtotext.Text = "Support up to: " + this._0024VB_0024Local_androidto;
		}

		// Token: 0x040000F8 RID: 248
		public string _0024VB_0024Local_appname;

		// Token: 0x040000F9 RID: 249
		public string _0024VB_0024Local_PackageName;

		// Token: 0x040000FA RID: 250
		public string _0024VB_0024Local_Vercode;

		// Token: 0x040000FB RID: 251
		public string _0024VB_0024Local_Vername;

		// Token: 0x040000FC RID: 252
		public string _0024VB_0024Local_androidfrom;

		// Token: 0x040000FD RID: 253
		public string _0024VB_0024Local_androidto;

		// Token: 0x040000FE RID: 254
		public Apk_studio _0024VB_0024Me;
	}
}
