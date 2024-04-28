using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000066 RID: 102
[DesignerGenerated]
public partial class EagleSpySettinngs : Form
{
	// Token: 0x060004E1 RID: 1249 RVA: 0x0007C258 File Offset: 0x0007A458
	public EagleSpySettinngs()
	{
		base.Load += this.CypherSettings_Load;
		this.sizearry = new string[]
		{
			"original",
			"1024x768",
			"1024x600",
			"960x640",
			"960x600",
			"960x540",
			"864x480",
			"854x480",
			"800x600",
			"800x480",
			"768x576",
			"640x480",
			"640x360",
			"480x320",
			"432x240",
			"450x300",
			"400x240",
			"320x240",
			"280x280"
		};
		this.progma = false;
		this.first = true;
		this.InitializeComponent();
	}

	// Token: 0x060004E2 RID: 1250 RVA: 0x0007C340 File Offset: 0x0007A540
	private void CypherSettings_Load(object sender, EventArgs e)
	{
		string text = RegistryHandler.Get_EMAIL();
		if (text == null | string.IsNullOrEmpty(text))
		{
			text = " ";
		}
		this.Label17.Text = "EagleSpy v7.0\r\n . \r\n© 2024 All rights reserved.\r\nLicenses Auther: [EM].\r\nAdvanced Android Remote Control Software.".Replace("[EM]", text);
		this.Translateme();
		string[] array = this.sizearry;
		foreach (string item in array)
		{
			this.resolutioncombo.Items.Add(item);
		}
		this.resolutioncombo.Text = MySettingsProperty.Settings.resolution;
		this.GetValues();
		try
		{
			if (File.Exists(Application.StartupPath + "/ChangeLog.html"))
			{
				string input = File.ReadAllText(Application.StartupPath + "/ChangeLog.html");
				this.LogBrowser.DocumentText = Codes.AesDecrypt(input, "nbjguhidoskznsmd");
			}
			else
			{
				this.LogBrowser.Visible = false;
			}
		}
		catch (Exception)
		{
			this.LogBrowser.Visible = false;
		}
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x0007C448 File Offset: 0x0007A648
	private void Translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				this.Label1.Text = Codes.Translate(this.Label1.Text, "en", "ar");
				this.recordfps.Text = "سرعة الإيطار";
				this.savebtn.Text = "حفظ";
				this.resetbtn.Text = "إعادة ضبط";
				this.checkupdatbtn.Text = "تفقد التحديث";
				this.exitbtn.Text = "اغلاق";
				this.Generaltext.Text = Codes.Translate(this.Generaltext.Text, "en", "ar");
				this.Label3.Text = Codes.Translate(this.Label3.Text, "en", "ar");
				this.Label4.Text = Codes.Translate(this.Label4.Text, "en", "ar");
				this.Label5.Text = Codes.Translate(this.Label5.Text, "en", "ar");
				this.Label6.Text = Codes.Translate(this.Label6.Text, "en", "ar");
				this.Label7.Text = Codes.Translate(this.Label7.Text, "en", "ar");
				this.Label8.Text = Codes.Translate(this.Label8.Text, "en", "ar");
				this.Label9.Text = Codes.Translate(this.Label9.Text, "en", "ar");
				this.label10.Text = Codes.Translate(this.label10.Text, "en", "ar");
				this.label11.Text = Codes.Translate(this.label11.Text, "en", "ar");
				this.Label12.Text = Codes.Translate(this.Label12.Text, "en", "ar");
				this.Label13.Text = Codes.Translate(this.Label13.Text, "en", "ar");
				this.Label14.Text = Codes.Translate(this.Label14.Text, "en", "ar");
				this.Label15.Text = Codes.Translate(this.Label15.Text, "en", "ar");
				this.Label16.Text = Codes.Translate(this.Label16.Text, "en", "ar");
			}
		}
		else
		{
			this.Label1.Text = Codes.Translate(this.Label1.Text, "en", "zh");
			this.Generaltext.Text = Codes.Translate(this.Generaltext.Text, "en", "zh");
			this.Label3.Text = Codes.Translate(this.Label3.Text, "en", "zh");
			this.Label4.Text = Codes.Translate(this.Label4.Text, "en", "zh");
			this.Label5.Text = Codes.Translate(this.Label5.Text, "en", "zh");
			this.Label6.Text = Codes.Translate(this.Label6.Text, "en", "zh");
			this.Label7.Text = Codes.Translate(this.Label7.Text, "en", "zh");
			this.Label8.Text = Codes.Translate(this.Label8.Text, "en", "zh");
			this.Label9.Text = Codes.Translate(this.Label9.Text, "en", "zh");
			this.label10.Text = Codes.Translate(this.label10.Text, "en", "zh");
			this.label11.Text = Codes.Translate(this.label11.Text, "en", "zh");
			this.Label12.Text = Codes.Translate(this.Label12.Text, "en", "zh");
			this.Label13.Text = Codes.Translate(this.Label13.Text, "en", "zh");
			this.Label14.Text = Codes.Translate(this.Label14.Text, "en", "zh");
			this.Label15.Text = Codes.Translate(this.Label15.Text, "en", "zh");
			this.Label16.Text = Codes.Translate(this.Label16.Text, "en", "zh");
			this.exitbtn.Text = "关闭";
			this.resetbtn.Text = "重置";
			this.recordfps.Text = "帧速度";
			this.checkupdatbtn.Text = "检查更新";
		}
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x0007C9B8 File Offset: 0x0007ABB8
	public void GetValues()
	{
		try
		{
			if (Operators.CompareString(MySettingsProperty.Settings.hidecoonstart, "Yes", false) == 0)
			{
				this.CheckHidecoonstart.Active = true;
			}
			else
			{
				this.CheckHidecoonstart.Active = false;
			}
			if (Operators.CompareString(MySettingsProperty.Settings.show_alert, "Yes", false) == 0)
			{
				this.CheckNotifi.Active = true;
			}
			else
			{
				this.CheckNotifi.Active = false;
			}
			if (Operators.CompareString(MySettingsProperty.Settings.ShowAlertDis, "Yes", false) == 0)
			{
				this.CheckNotifiDis.Active = true;
			}
			else
			{
				this.CheckNotifiDis.Active = false;
			}
			if (Operators.CompareString(MySettingsProperty.Settings.LOG, "Yes", false) == 0)
			{
				this.Checklogit.Active = true;
			}
			else
			{
				this.Checklogit.Active = false;
			}
			if (Operators.CompareString(MySettingsProperty.Settings.Saving_data, "Yes", false) == 0)
			{
				this.Checksaveit.Active = true;
			}
			else
			{
				this.Checksaveit.Active = false;
			}
			if (Operators.CompareString(MySettingsProperty.Settings.FM_IC_Size, "Small", false) == 0)
			{
				this.CheckFMI.Active = true;
			}
			else
			{
				this.CheckFMI.Active = false;
			}
			this.FMQ.Text = Conversions.ToString(MySettingsProperty.Settings.ImageQualty);
			this.LiveSQ.Text = Conversions.ToString(this.LiveSQ.Items[this.LiveSQ.Items.IndexOf(MySettingsProperty.Settings.live_sc_qulty)]);
			this.LSFPS.Text = Conversions.ToString(this.LSFPS.Items[this.LSFPS.Items.IndexOf(MySettingsProperty.Settings.live_fps_rec)]);
			this.Checkplysound.Active = MySettingsProperty.Settings.NOTI_SOUND;
			string[] files = Directory.GetFiles(reso.res_Path + "\\Audio");
			foreach (string path in files)
			{
				try
				{
					string item = Path.GetFileName(path).Split(new char[]
					{
						'.'
					})[0];
					this.selectedsoundcombo.Items.Add(item);
				}
				catch (Exception)
				{
				}
			}
			if (RegistryHandler.GET_SoundID() == null)
			{
				RegistryHandler.SET_SoundID("5");
			}
			this.progma = true;
			this.selectedsoundcombo.Text = RegistryHandler.GET_SoundID();
			if (Operators.CompareString(MySettingsProperty.Settings.checkupdatestart, "Yes", false) == 0)
			{
				this.Checkupdate.Active = true;
			}
			else
			{
				this.Checkupdate.Active = false;
			}
			string language = RegistryHandler.Get_Language();
			string a = language;
			if (!(a == "CN"))
			{
				if (!(a == "AR"))
				{
					if (a == "EN")
					{
						this.lngtext.Text = "EN-English";
					}
				}
				else
				{
					this.lngtext.Text = "AR-العربية";
				}
			}
			else
			{
				this.lngtext.Text = "CN-中国人";
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x0000206C File Offset: 0x0000026C
	private void Button2_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060004E6 RID: 1254 RVA: 0x0000206C File Offset: 0x0000026C
	private void Button1_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060004E7 RID: 1255 RVA: 0x0007CD08 File Offset: 0x0007AF08
	private void DrakeUIAvatar2_Click(object sender, EventArgs e)
	{
		MySettingsProperty.Settings.performance = "Normal";
		MySettingsProperty.Settings.show_alert = "Yes";
		MySettingsProperty.Settings.ShowAlertDis = "Yes";
		MySettingsProperty.Settings.hidecoonstart = "Yes";
		MySettingsProperty.Settings.LOG = "Yes";
		MySettingsProperty.Settings.Saving_data = "Yes";
		MySettingsProperty.Settings.FM_IC_Size = "Small";
		MySettingsProperty.Settings.ImageQualty = Conversions.ToInteger("20");
		this.GetValues();
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x0007CD98 File Offset: 0x0007AF98
	private void DrakeUIAvatar1_Click(object sender, EventArgs e)
	{
		if (this.CheckNotifi.Active)
		{
			MySettingsProperty.Settings.show_alert = "Yes";
		}
		else
		{
			MySettingsProperty.Settings.show_alert = "No";
		}
		if (this.CheckNotifiDis.Active)
		{
			MySettingsProperty.Settings.ShowAlertDis = "Yes";
		}
		else
		{
			MySettingsProperty.Settings.ShowAlertDis = "No";
		}
		if (this.Checklogit.Active)
		{
			MySettingsProperty.Settings.LOG = "Yes";
		}
		else
		{
			MySettingsProperty.Settings.LOG = "No";
		}
		if (this.Checksaveit.Active)
		{
			MySettingsProperty.Settings.Saving_data = "Yes";
		}
		else
		{
			MySettingsProperty.Settings.Saving_data = "No";
		}
		if (this.CheckFMI.Active)
		{
			MySettingsProperty.Settings.FM_IC_Size = "Small";
		}
		else
		{
			MySettingsProperty.Settings.FM_IC_Size = "Large";
		}
		MySettingsProperty.Settings.ImageQualty = Conversions.ToInteger(this.FMQ.Text);
		if (this.CheckHidecoonstart.Active)
		{
			MySettingsProperty.Settings.hidecoonstart = "Yes";
		}
		else
		{
			MySettingsProperty.Settings.hidecoonstart = "No";
		}
		MySettingsProperty.Settings.live_sc_qulty = this.LiveSQ.Text;
		MySettingsProperty.Settings.live_fps_rec = this.LSFPS.Text;
		if (this.Checkupdate.Active)
		{
			MySettingsProperty.Settings.checkupdatestart = "Yes";
		}
		else
		{
			MySettingsProperty.Settings.checkupdatestart = "No";
		}
		MySettingsProperty.Settings.NOTI_SOUND = this.Checkplysound.Active;
		MySettingsProperty.Settings.resolution = this.resolutioncombo.Text;
		string language = this.lngtext.Text.Split(new char[]
		{
			'-'
		})[0];
		RegistryHandler.Set_Language(language);
		MySettingsProperty.Settings.Save();
		RegistryHandler.SET_SoundID(this.selectedsoundcombo.Text);
		EagleAlert.ShowSucess("Saved Changes will be made after restarting the program");
		base.Close();
	}

	// Token: 0x060004E9 RID: 1257 RVA: 0x0000206C File Offset: 0x0000026C
	private void DrakeUIButton1_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x00002BA6 File Offset: 0x00000DA6
	private void Copydev_Click(object sender, EventArgs e)
	{
		RegistryHandler.Set_Language("AR");
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x00002BB2 File Offset: 0x00000DB2
	private void DrakeUIButton2_Click(object sender, EventArgs e)
	{
		RegistryHandler.Set_Language("CN");
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x0007CF9C File Offset: 0x0007B19C
	private void Selectedsoundcombo_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (this.progma)
			{
				this.progma = false;
			}
			else
			{
				string text = reso.res_Path + "\\Audio\\[id].wav";
				if (File.Exists(text.Replace("[id]", this.selectedsoundcombo.Text)))
				{
					Notif_Sound.aMedia = new SoundPlayer();
					Notif_Sound.aMedia.SoundLocation = Notif_Sound.getsoundpath();
					Notif_Sound.aMedia.Load();
					RegistryHandler.SET_SoundID(this.selectedsoundcombo.Text);
					while (!Notif_Sound.aMedia.IsLoadCompleted)
					{
						Thread.Sleep(100);
					}
					try
					{
						Notif_Sound.aMedia.Play();
					}
					catch (InvalidOperationException)
					{
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060004ED RID: 1261 RVA: 0x0007D06C File Offset: 0x0007B26C
	private void Resolutioncombo_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.first)
		{
			this.first = false;
			Codes.MyMsgBox("Alert", "This option can effect the FPS for screen monitor.\r\nMore Resolution = slow connection", false, Resources.information48px);
		}
	}

	// Token: 0x060004EE RID: 1262 RVA: 0x0007D0A0 File Offset: 0x0007B2A0
	private void PictureBox5_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("facebook.com");
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060004EF RID: 1263 RVA: 0x0007D0D0 File Offset: 0x0007B2D0
	private void PictureBox6_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("twitter.com");
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060004F0 RID: 1264 RVA: 0x0007D100 File Offset: 0x0007B300
	private void PictureBox3_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("telegram.com");
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x00059674 File Offset: 0x00057874
	private void DrakeUISymbolLabel1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x00059674 File Offset: 0x00057874
	private void Panel1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x00059674 File Offset: 0x00057874
	private void Panel2_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x00002858 File Offset: 0x00000A58
	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	// Token: 0x04000654 RID: 1620
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("resetbtn")]
	private DrakeUIButtonIcon _resetbtn;

	// Token: 0x04000655 RID: 1621
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("savebtn")]
	private DrakeUIButtonIcon _savebtn;

	// Token: 0x04000656 RID: 1622
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	// Token: 0x04000657 RID: 1623
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("selectedsoundcombo")]
	private ComboBox _selectedsoundcombo;

	// Token: 0x04000658 RID: 1624
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("resolutioncombo")]
	private ComboBox _resolutioncombo;

	// Token: 0x04000659 RID: 1625
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkupdatbtn")]
	private DrakeUIButtonIcon _checkupdatbtn;

	// Token: 0x0400065A RID: 1626
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	// Token: 0x0400065B RID: 1627
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox6")]
	private PictureBox _PictureBox6;

	// Token: 0x0400065C RID: 1628
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	// Token: 0x0400065D RID: 1629
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	// Token: 0x0400065E RID: 1630
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUISymbolLabel1")]
	private DrakeUISymbolLabel _DrakeUISymbolLabel1;

	// Token: 0x0400065F RID: 1631
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("exitbtn")]
	private DrakeUIButtonIcon _exitbtn;

	// Token: 0x04000660 RID: 1632
	private string[] sizearry;

	// Token: 0x04000661 RID: 1633
	private bool progma;

	// Token: 0x04000662 RID: 1634
	private bool first;
}
