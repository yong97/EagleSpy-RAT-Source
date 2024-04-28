using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000023 RID: 35
[DesignerGenerated]
public partial class alertform : Form
{
	// Token: 0x17000102 RID: 258
	// (get) Token: 0x06000173 RID: 371 RVA: 0x0000222F File Offset: 0x0000042F
	protected override bool ShowWithoutActivation
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06000174 RID: 372
	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

	// Token: 0x06000175 RID: 373 RVA: 0x00002232 File Offset: 0x00000432
	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);
		alertform.SetWindowPos(base.Handle, new IntPtr(-1), base.Left, base.Top, base.Width, base.Height, 80U);
	}

	// Token: 0x06000178 RID: 376
	[DllImport("user32.dll")]
	private static extern bool SetWindowPos(int hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

	// Token: 0x06000179 RID: 377
	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	// Token: 0x0600017A RID: 378 RVA: 0x0000DE30 File Offset: 0x0000C030
	public static void ShowInactiveTopmost(Form frm)
	{
		alertform.ShowWindow(frm.Handle, 4);
		alertform.SetWindowPos(frm.Handle.ToInt32(), -1, frm.Left, frm.Top, frm.Width, frm.Height, 16U);
	}

	// Token: 0x0600017B RID: 379 RVA: 0x0000DE7C File Offset: 0x0000C07C
	[DebuggerStepThrough]
	private void FadeIn(Form o, int interval = 45)
	{
		alertform.VB_0024StateMachine_39_FadeIn vb_0024StateMachine_39_FadeIn = new alertform.VB_0024StateMachine_39_FadeIn();
		vb_0024StateMachine_39_FadeIn._0024VB_0024Me = this;
		vb_0024StateMachine_39_FadeIn._0024VB_0024Local_o = o;
		vb_0024StateMachine_39_FadeIn._0024VB_0024Local_interval = interval;
		vb_0024StateMachine_39_FadeIn._0024State = -1;
		vb_0024StateMachine_39_FadeIn._0024Builder = AsyncVoidMethodBuilder.Create();
		vb_0024StateMachine_39_FadeIn._0024Builder.Start<alertform.VB_0024StateMachine_39_FadeIn>(ref vb_0024StateMachine_39_FadeIn);
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00002267 File Offset: 0x00000467
	public alertform(string msg)
	{
		base.Load += this.AlertForm_Load;
		this.components = null;
		this.counter = 1;
		this.hold = 50;
		this.InitializeComponent();
		this.TheMessage = msg;
	}

	// Token: 0x0600017D RID: 381 RVA: 0x0000DEC8 File Offset: 0x0000C0C8
	private void AlertForm_Load(object sender, EventArgs e)
	{
		this.guna2GradientTileButton1.Text = this.msglabel.Text;
		this.soundPlayer = new SoundPlayer();
		string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "res/Audio");
		string soundLocation = Path.Combine(path, "alert.wav");
		this.soundPlayer.SoundLocation = soundLocation;
		this.soundPlayer.Play();
		base.Opacity = 0.0;
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				this.TheMessage = Codes.Translate(this.TheMessage, "en", "ar");
			}
		}
		else
		{
			this.TheMessage = Codes.Translate(this.TheMessage, "en", "zh");
		}
		this.msglabel.Text = this.TheMessage;
		this.workingArea = Screen.GetWorkingArea(this);
		checked
		{
			this.oldY = this.workingArea.Bottom - base.Size.Height - 10;
			int num = 1;
			do
			{
				try
				{
					string name = "Craxs_Alert_" + Conversions.ToString(num);
					alertform alertform = (alertform)Application.OpenForms[name];
					if (alertform == null)
					{
						base.Name = name;
						break;
					}
					this.oldY = this.workingArea.Bottom - base.Size.Height - 10 - base.Height * num;
				}
				catch (Exception)
				{
				}
				num++;
			}
			while (num <= 99);
			base.Location = new Point(this.workingArea.Right - base.Size.Width, this.oldY);
			alertform.ShowInactiveTopmost(this);
			this.FadeIn(this, 45);
		}
	}

	// Token: 0x0600017E RID: 382 RVA: 0x0000E0B0 File Offset: 0x0000C2B0
	private void Closetimer_Tick(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (DateTime.Compare(this.Showtime, DateTime.Now) < 0)
				{
					base.Opacity = 0.0;
					this.closetimer.Stop();
					this.closetimer.Dispose();
					base.Close();
				}
				else if (this.hold == 0)
				{
					base.Name = "ended";
					this.workingArea = Screen.GetWorkingArea(this);
					base.Location = new Point(this.workingArea.Right - base.Size.Width, this.oldY - this.counter);
					this.counter++;
					unchecked
					{
						base.Opacity -= 0.05;
					}
				}
				else
				{
					this.hold--;
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600017F RID: 383 RVA: 0x000022A4 File Offset: 0x000004A4
	private void PictureBox2_Click(object sender, EventArgs e)
	{
		this.closetimer.Stop();
		this.closetimer.Dispose();
		base.Close();
	}

	// Token: 0x06000180 RID: 384 RVA: 0x000022A4 File Offset: 0x000004A4
	private void Lidlamb_MouseDown(object sender, MouseEventArgs e)
	{
		this.closetimer.Stop();
		this.closetimer.Dispose();
		base.Close();
	}

	// Token: 0x06000181 RID: 385 RVA: 0x000022C2 File Offset: 0x000004C2
	private void Lidlamb_MouseUp(object sender, MouseEventArgs e)
	{
		this.closetimer.Start();
	}

	// Token: 0x06000182 RID: 386 RVA: 0x0000206C File Offset: 0x0000026C
	private void alertform_Shown(object sender, EventArgs e)
	{
	}

	// Token: 0x040000B8 RID: 184
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("pictureBox2")]
	private PictureBox _pictureBox2;

	// Token: 0x040000BA RID: 186
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("closetimer")]
	private Timer _closetimer;

	// Token: 0x040000BB RID: 187
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lidlamb")]
	private DrakeUIButtonIcon _lidlamb;

	// Token: 0x040000BC RID: 188
	public string TheMessage;

	// Token: 0x040000BD RID: 189
	public int oldY;

	// Token: 0x040000BE RID: 190
	public Rectangle workingArea;

	// Token: 0x040000BF RID: 191
	public DateTime Showtime;

	// Token: 0x040000C0 RID: 192
	public const int HWND_TOPMOST = -1;

	// Token: 0x040000C1 RID: 193
	private int counter;

	// Token: 0x040000C2 RID: 194
	private SoundPlayer soundPlayer;

	// Token: 0x040000C3 RID: 195
	private int hold;
}
