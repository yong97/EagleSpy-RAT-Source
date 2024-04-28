using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000050 RID: 80
[DesignerGenerated]
public partial class EagleSpyMsgbox : Form
{
	// Token: 0x17000104 RID: 260
	// (get) Token: 0x0600039B RID: 923 RVA: 0x00054AAC File Offset: 0x00052CAC
	protected override CreateParams CreateParams
	{
		get
		{
			this.CheckAeroEnabled();
			CreateParams createParams = base.CreateParams;
			CreateParams result;
			if (!this.aeroEnabled)
			{
				createParams.ClassStyle |= 131072;
				result = createParams;
			}
			else
			{
				result = createParams;
			}
			return result;
		}
	}

	// Token: 0x0600039E RID: 926 RVA: 0x000552C0 File Offset: 0x000534C0
	protected override void WndProc(ref Message m)
	{
		int msg = m.Msg;
		if (msg == 133)
		{
			int num = 2;
			if (this.aeroEnabled)
			{
				EagleSpyMsgbox.NativeMethods.DwmSetWindowAttribute(base.Handle, 2, ref num, 4);
				EagleSpyMsgbox.NativeStructs.MARGINS margins = default(EagleSpyMsgbox.NativeStructs.MARGINS);
				margins.bottomHeight = 1;
				margins.leftWidth = 1;
				margins.rightWidth = 1;
				margins.topHeight = 1;
				EagleSpyMsgbox.NativeMethods.DwmExtendFrameIntoClientArea(base.Handle, ref margins);
			}
		}
		base.WndProc(ref m);
	}

	// Token: 0x0600039F RID: 927 RVA: 0x00055344 File Offset: 0x00053544
	private void CheckAeroEnabled()
	{
		if (Environment.OSVersion.Version.Major >= 6)
		{
			int num = 0;
			EagleSpyMsgbox.NativeMethods.DwmIsCompositionEnabled(ref num);
			this.aeroEnabled = (num == 1);
		}
		else
		{
			this.aeroEnabled = false;
		}
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x00055388 File Offset: 0x00053588
	public EagleSpyMsgbox(string t, string m, bool no, Bitmap ico)
	{
		base.Load += this.CraxsMsgbox_Load;
		base.Paint += this.CraxsMsgbox_Paint;
		this.aeroEnabled = true;
		this.borderRadius = 30;
		this.borderSize = 3;
		this.borderColor = Color.Transparent;
		this.InitializeComponent();
		this.titletext.Text = t;
		this.msgtext.Text = m;
		if (!no)
		{
			this.nobtn.Visible = false;
		}
		this.picbox.Image = ico;
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x000028D8 File Offset: 0x00000AD8
	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Yes;
		this.Timer1.Stop();
		base.Close();
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x000028F2 File Offset: 0x00000AF2
	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		this.Timer1.Stop();
		base.Close();
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x0000290C File Offset: 0x00000B0C
	private void CraxsMsgbox_Load(object sender, EventArgs e)
	{
		base.CenterToScreen();
		this.Timer1.Start();
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00055420 File Offset: 0x00053620
	private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
	{
		if (base.WindowState != FormWindowState.Minimized)
		{
			using (GraphicsPath roundedPath = this.GetRoundedPath(form.ClientRectangle, radius))
			{
				using (Pen pen = new Pen(borderColor, borderSize))
				{
					using (Matrix matrix = new Matrix())
					{
						graph.SmoothingMode = SmoothingMode.AntiAlias;
						form.Region = new System.Drawing.Region(roundedPath);
						if (borderSize >= 1f)
						{
							Rectangle clientRectangle = form.ClientRectangle;
							float scaleX = 1f - (borderSize + 1f) / (float)clientRectangle.Width;
							float scaleY = 1f - (borderSize + 1f) / (float)clientRectangle.Height;
							matrix.Scale(scaleX, scaleY);
							matrix.Translate(borderSize / 1.6f, borderSize / 1.6f);
							graph.Transform = matrix;
							graph.DrawPath(pen, roundedPath);
						}
					}
				}
			}
		}
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x00055530 File Offset: 0x00053730
	private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
	{
		GraphicsPath graphicsPath = new GraphicsPath();
		float num = radius * 2f;
		graphicsPath.StartFigure();
		graphicsPath.AddArc((float)rect.X, (float)rect.Y, num, num, 180f, 90f);
		graphicsPath.AddArc((float)rect.Right - num, (float)rect.Y, num, num, 270f, 90f);
		graphicsPath.AddArc((float)rect.Right - num, (float)rect.Bottom - num, num, num, 0f, 90f);
		graphicsPath.AddArc((float)rect.X, (float)rect.Bottom - num, num, num, 90f, 90f);
		graphicsPath.CloseFigure();
		return graphicsPath;
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x000555FC File Offset: 0x000537FC
	private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
	{
		using (GraphicsPath roundedPath = this.GetRoundedPath(control.ClientRectangle, radius))
		{
			using (Pen pen = new Pen(borderColor, 1f))
			{
				graph.SmoothingMode = SmoothingMode.AntiAlias;
				control.Region = new System.Drawing.Region(roundedPath);
				graph.DrawPath(pen, roundedPath);
			}
		}
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x00055674 File Offset: 0x00053874
	private void DrawPath(Rectangle rectForm, Graphics graphics, Color color)
	{
		using (GraphicsPath roundedPath = this.GetRoundedPath(rectForm, (float)this.borderRadius))
		{
			using (Pen pen = new Pen(color, 3f))
			{
				graphics.DrawPath(pen, roundedPath);
			}
		}
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x000556D8 File Offset: 0x000538D8
	private EagleSpyMsgbox.FormBoundsColors GetFormBoundsColors()
	{
		EagleSpyMsgbox.FormBoundsColors result = default(EagleSpyMsgbox.FormBoundsColors);
		using (Bitmap bitmap = new Bitmap(1, 1))
		{
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				Rectangle rectangle = new Rectangle(0, 0, 1, 1);
				rectangle.X = checked(base.Bounds.X - 1);
				rectangle.Y = base.Bounds.Y;
				graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
				result.TopLeftColor = bitmap.GetPixel(0, 0);
				rectangle.X = base.Bounds.Right;
				rectangle.Y = base.Bounds.Y;
				graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
				result.TopRightColor = bitmap.GetPixel(0, 0);
				rectangle.X = base.Bounds.X;
				rectangle.Y = base.Bounds.Bottom;
				graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
				result.BottomLeftColor = bitmap.GetPixel(0, 0);
				rectangle.X = base.Bounds.Right;
				rectangle.Y = base.Bounds.Bottom;
				graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
				result.BottomRightColor = bitmap.GetPixel(0, 0);
			}
		}
		return result;
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x000558E4 File Offset: 0x00053AE4
	private void CraxsMsgbox_Paint(object sender, PaintEventArgs e)
	{
		e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		Rectangle clientRectangle = base.ClientRectangle;
		checked
		{
			int num = (int)Math.Round((double)clientRectangle.Width / 2.0);
			int num2 = (int)Math.Round((double)clientRectangle.Height / 2.0);
			EagleSpyMsgbox.FormBoundsColors formBoundsColors = this.GetFormBoundsColors();
			this.DrawPath(clientRectangle, e.Graphics, formBoundsColors.TopLeftColor);
			Rectangle rectForm = new Rectangle(clientRectangle.Right - num, clientRectangle.Y, num, num2);
			this.DrawPath(rectForm, e.Graphics, formBoundsColors.TopRightColor);
			Rectangle rectForm2 = new Rectangle(clientRectangle.X, clientRectangle.Bottom - num2, num, num2);
			this.DrawPath(rectForm2, e.Graphics, formBoundsColors.BottomLeftColor);
			Rectangle rectForm3 = new Rectangle(clientRectangle.Right - num, clientRectangle.Bottom - num2, num, num2);
			this.DrawPath(rectForm3, e.Graphics, formBoundsColors.BottomRightColor);
			this.FormRegionAndBorder(this, (float)this.borderRadius, e.Graphics, this.borderColor, (float)this.borderSize);
		}
	}

	// Token: 0x060003AA RID: 938 RVA: 0x0000291F File Offset: 0x00000B1F
	private void Panel2_Paint(object sender, PaintEventArgs e)
	{
		this.ControlRegionAndBorder(this.Panel2, (float)this.borderRadius - (float)this.borderSize / 2f, e.Graphics, this.borderColor);
	}

	// Token: 0x060003AB RID: 939 RVA: 0x0000294E File Offset: 0x00000B4E
	private void Timer1_Tick(object sender, EventArgs e)
	{
		base.TopMost = true;
		base.BringToFront();
	}

	// Token: 0x0400040F RID: 1039
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("nobtn")]
	private DrakeUIButtonIcon _nobtn;

	// Token: 0x04000410 RID: 1040
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("okbtn")]
	private DrakeUIButtonIcon _okbtn;

	// Token: 0x04000411 RID: 1041
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	// Token: 0x04000412 RID: 1042
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	// Token: 0x04000413 RID: 1043
	private bool aeroEnabled;

	// Token: 0x04000414 RID: 1044
	private int borderRadius;

	// Token: 0x04000415 RID: 1045
	private int borderSize;

	// Token: 0x04000416 RID: 1046
	private Color borderColor;

	// Token: 0x02000051 RID: 81
	public class NativeStructs
	{
		// Token: 0x02000052 RID: 82
		public struct MARGINS
		{
			// Token: 0x0400041F RID: 1055
			public int leftWidth;

			// Token: 0x04000420 RID: 1056
			public int rightWidth;

			// Token: 0x04000421 RID: 1057
			public int topHeight;

			// Token: 0x04000422 RID: 1058
			public int bottomHeight;
		}
	}

	// Token: 0x02000053 RID: 83
	public class NativeMethods
	{
		// Token: 0x060003AD RID: 941
		[DllImport("dwmapi")]
		public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref EagleSpyMsgbox.NativeStructs.MARGINS pMarInset);

		// Token: 0x060003AE RID: 942
		[DllImport("dwmapi")]
		internal static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

		// Token: 0x060003AF RID: 943
		[DllImport("dwmapi.dll")]
		public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
	}

	// Token: 0x02000054 RID: 84
	public class NativeConstants
	{
		// Token: 0x04000423 RID: 1059
		public const int CS_DROPSHADOW = 131072;

		// Token: 0x04000424 RID: 1060
		public const int WM_NCPAINT = 133;
	}

	// Token: 0x02000055 RID: 85
	private struct FormBoundsColors
	{
		// Token: 0x04000425 RID: 1061
		public Color TopLeftColor;

		// Token: 0x04000426 RID: 1062
		public Color TopRightColor;

		// Token: 0x04000427 RID: 1063
		public Color BottomLeftColor;

		// Token: 0x04000428 RID: 1064
		public Color BottomRightColor;
	}
}
