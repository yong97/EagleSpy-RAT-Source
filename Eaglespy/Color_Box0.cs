using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200004A RID: 74
[DesignerGenerated]
public partial class Color_Box0 : Form
{
	// Token: 0x06000357 RID: 855 RVA: 0x000512F0 File Offset: 0x0004F4F0
	private void SpyStyle()
	{
		this.BoxTitle.BackColor = SpySettings.DefaultColor_Background;
		this.BackColor = SpySettings.DefaultColor_Background;
		foreach (Button button in base.Controls.OfType<Button>())
		{
			button.BackColor = SpySettings.DefaultColor_Foreground;
			button.ForeColor = SpySettings.DefaultColor_Background;
		}
		foreach (CheckBox checkBox in base.Controls.OfType<CheckBox>())
		{
			checkBox.BackColor = SpySettings.DefaultColor_Background;
			checkBox.ForeColor = SpySettings.DefaultColor_Foreground;
		}
	}

	// Token: 0x06000358 RID: 856 RVA: 0x000513C0 File Offset: 0x0004F5C0
	public Color_Box0()
	{
		base.Load += this.Color_Box0_Load;
		base.Activated += this.Color_Box0_Activated;
		base.Deactivate += this.Color_Box0_Deactivate;
		this.BoxTitlePaintEventArgsWait = false;
		this.Programmatically = false;
		this.default_color = Color.Yellow;
		this._new_color = Color.Yellow;
		this.p1 = new Point(0, 0);
		this.s_mouse1 = false;
		this.p0 = default(Point);
		this.s_mouse0 = false;
		this.TEXT_COLOR = "null";
		this.InitializeComponent();
		this.Font = reso.f;
	}

	// Token: 0x06000359 RID: 857 RVA: 0x00051470 File Offset: 0x0004F670
	private void Color_Box0_Load(object sender, EventArgs e)
	{
		this.SpyStyle();
		this.BTN_OK.Font = reso.f;
		base.TopMost = true;
		this.Programmatically = true;
		this.Bmp = new Bitmap(1, 1);
		this.G = Graphics.FromImage(this.Bmp);
		if (clrSAVE.po1 == default(Point))
		{
			this.p0 = new Point(1, 1);
		}
		else
		{
			this.p0 = clrSAVE.po1;
		}
		object[] e2 = new object[]
		{
			this.p0.X,
			this.p0.Y
		};
		this._Update0(e2, this.C_Box2);
		this.C_Box2.Invalidate();
		if (clrSAVE.po2 == default(Point))
		{
			this.p1 = new Point(1, 1);
		}
		else
		{
			this.p1 = clrSAVE.po2;
		}
		object[] e3 = new object[]
		{
			this.p1.X,
			this.p1.Y
		};
		this._Update1(e3, this.C_Box0);
		this.C_Box0.Invalidate();
		this.Programmatically = false;
		this.BoxTitlePaintEventArgsWait = true;
	}

	// Token: 0x0600035A RID: 858
	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetKeyState(long nVirtKey);

	// Token: 0x0600035B RID: 859 RVA: 0x000515BC File Offset: 0x0004F7BC
	private void C_Box0_Paint(object sender, PaintEventArgs e)
	{
		Graphics graphics = e.Graphics;
		Graphics graphics2 = graphics;
		Rectangle rect = new Rectangle(0, 0, this.C_Box0.Width, this.C_Box0.Height);
		using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rect, Color.White, this.default_color, LinearGradientMode.Horizontal))
		{
			graphics2.FillRectangle(linearGradientBrush, rect);
		}
		Rectangle rect2 = new Rectangle(0, 0, this.C_Box0.Width, this.C_Box0.Height);
		checked
		{
			using (LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(rect2, Color.Transparent, Color.Black, LinearGradientMode.Vertical))
			{
				graphics2.FillRectangle(linearGradientBrush2, rect2);
				int num = this.C_Box0.Height - 7;
				graphics2.DrawLine(new Pen(Color.Black, 5f), 0, num, this.C_Box0.Width, num);
			}
			graphics2 = null;
			if (!(this.p1 == default(Point)))
			{
				e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
				Rectangle rect3 = (!this.s_mouse1) ? new Rectangle(this.p1.X - 5, this.p1.Y - 5, 10, 10) : new Rectangle(this.p1.X - 7, this.p1.Y - 7, 14, 14);
				Pen pen = new Pen(Color.Black, 1f);
				if ((int)Math.Round((double)this.C_Box0.Height / 2.0) < this.p1.Y)
				{
					pen = new Pen(Color.White, 1f);
				}
				e.Graphics.DrawEllipse(pen, rect3);
				Bitmap bitmap = new Bitmap(this.C_Box0.ClientSize.Width, this.C_Box0.Height);
				this.C_Box0.DrawToBitmap(bitmap, this.C_Box0.ClientRectangle);
				if (bitmap.Width > this.p1.X & bitmap.Height > this.p1.Y)
				{
					Color pixel = bitmap.GetPixel(this.p1.X, this.p1.Y);
					bitmap.Dispose();
					this._new_color = pixel;
				}
			}
			this.C_Box3.BackColor = this._new_color;
			this.Title(new object[]
			{
				this.C_Box3.BackColor.R,
				this.C_Box3.BackColor.G,
				this.C_Box3.BackColor.B
			});
			this.C_Box3.Refresh();
		}
	}

	// Token: 0x0600035C RID: 860 RVA: 0x000518B0 File Offset: 0x0004FAB0
	private void C_Box0_MouseDown(object sender, MouseEventArgs e)
	{
		this.s_mouse1 = true;
		object[] e2 = new object[]
		{
			e.X,
			e.Y
		};
		this._Update1(e2, this.C_Box0);
	}

	// Token: 0x0600035D RID: 861 RVA: 0x000518F4 File Offset: 0x0004FAF4
	private void _Update1(object[] e, Control c)
	{
		if ((this.s_mouse1 | this.Programmatically) && Conversions.ToBoolean(Operators.AndObject(checked(Operators.AndObject(Operators.AndObject(Operators.NotObject(Operators.CompareObjectGreater(e[0], c.Width - 7, false)), Operators.NotObject(Operators.CompareObjectLess(e[0], 1, false))), Operators.NotObject(Operators.CompareObjectGreater(e[1], c.Height - 7, false)))), Operators.NotObject(Operators.CompareObjectLess(e[1], 1, false)))))
		{
			this.p1.X = Conversions.ToInteger(e[0]);
			this.p1.Y = Conversions.ToInteger(e[1]);
			clrSAVE.po2 = new Point(this.p1.X, this.p1.Y);
			Bitmap bitmap = new Bitmap(c.ClientSize.Width, c.Height);
			c.DrawToBitmap(bitmap, c.ClientRectangle);
			if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(bitmap.Width, e[0], false), Operators.CompareObjectGreater(bitmap.Height, e[1], false))))
			{
				Color pixel = bitmap.GetPixel(Conversions.ToInteger(e[0]), Conversions.ToInteger(e[1]));
				bitmap.Dispose();
				this._new_color = pixel;
				c.Refresh();
			}
			c.Invalidate();
		}
	}

	// Token: 0x0600035E RID: 862 RVA: 0x00051A60 File Offset: 0x0004FC60
	private void C_Box0_MouseMove(object sender, MouseEventArgs e)
	{
		if (this.s_mouse1)
		{
			if (Operators.ConditionalCompareObjectEqual(this.C_Box0.Tag, null, false))
			{
				Cursor.Clip = this.C_Box0.RectangleToScreen(checked(new Rectangle(1, 1, this.C_Box0.Width - 7, this.C_Box0.Height - 7)));
				this.C_Box0.Tag = true;
			}
			object[] e2 = new object[]
			{
				e.X,
				e.Y
			};
			this._Update1(e2, this.C_Box0);
		}
	}

	// Token: 0x0600035F RID: 863 RVA: 0x00051B00 File Offset: 0x0004FD00
	private void C_Box0_MouseUp(object sender, MouseEventArgs e)
	{
		this.s_mouse1 = false;
		Cursor.Clip = default(Rectangle);
		this.C_Box0.Tag = null;
		this.C_Box0.Invalidate();
	}

	// Token: 0x06000360 RID: 864 RVA: 0x00051B3C File Offset: 0x0004FD3C
	private void C_Box2_Paint(object sender, PaintEventArgs e)
	{
		using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Rectangle(new Point(0, 0), this.C_Box2.ClientSize), Color.Red, Color.Blue, 0f))
		{
			linearGradientBrush.InterpolationColors = new ColorBlend
			{
				Positions = new float[]
				{
					0f,
					0.1f,
					0.284f,
					0.5f,
					0.668f,
					0.9f,
					1f
				},
				Colors = new Color[]
				{
					Color.Purple,
					Color.Red,
					Color.Yellow,
					Color.Lime,
					Color.Cyan,
					Color.Blue,
					Color.LightBlue
				}
			};
			e.Graphics.FillRectangle(linearGradientBrush, this.C_Box2.ClientRectangle);
		}
		if (!(this.p0 == default(Point)))
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Rectangle rect = checked(new Rectangle(this.p0.X - 3, -1, 5, this.C_Box2.Height - 3));
			Pen pen = new Pen(Color.Black, 1f);
			e.Graphics.DrawRectangle(pen, rect);
		}
	}

	// Token: 0x06000361 RID: 865 RVA: 0x00051C98 File Offset: 0x0004FE98
	private void C_Box2_MouseDown(object sender, MouseEventArgs e)
	{
		this.s_mouse0 = true;
		object[] e2 = new object[]
		{
			e.X,
			e.Y
		};
		this._Update0(e2, this.C_Box2);
	}

	// Token: 0x06000362 RID: 866 RVA: 0x00051CDC File Offset: 0x0004FEDC
	private void _Update0(object[] e, Control c)
	{
		if ((this.s_mouse0 | this.Programmatically) && Conversions.ToBoolean(Operators.AndObject(checked(Operators.AndObject(Operators.AndObject(Operators.NotObject(Operators.CompareObjectGreater(e[0], c.Width - 7, false)), Operators.NotObject(Operators.CompareObjectLess(e[0], 1, false))), Operators.NotObject(Operators.CompareObjectGreater(e[1], c.Height - 7, false)))), Operators.NotObject(Operators.CompareObjectLess(e[1], 1, false)))))
		{
			this.p0.X = Conversions.ToInteger(e[0]);
			this.p0.Y = Conversions.ToInteger(e[1]);
			clrSAVE.po1 = new Point(this.p0.X, this.p0.Y);
			Bitmap bitmap = new Bitmap(c.ClientSize.Width, c.Height);
			c.DrawToBitmap(bitmap, c.ClientRectangle);
			if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(bitmap.Width, e[0], false), Operators.CompareObjectGreater(bitmap.Height, e[1], false))))
			{
				Color pixel = bitmap.GetPixel(Conversions.ToInteger(e[0]), Conversions.ToInteger(e[1]));
				bitmap.Dispose();
				this.default_color = pixel;
				this.C_Box0.Invalidate();
			}
			c.Invalidate();
		}
	}

	// Token: 0x06000363 RID: 867 RVA: 0x00051E4C File Offset: 0x0005004C
	private void C_Box2_MouseMove(object sender, MouseEventArgs e)
	{
		if (this.s_mouse0)
		{
			if (Operators.ConditionalCompareObjectEqual(this.C_Box2.Tag, null, false))
			{
				Cursor.Clip = this.C_Box2.RectangleToScreen(checked(new Rectangle(1, 1, this.C_Box2.Width - 7, this.C_Box2.Height - 7)));
				this.C_Box2.Tag = true;
			}
			object[] e2 = new object[]
			{
				e.X,
				e.Y
			};
			this._Update0(e2, this.C_Box2);
		}
	}

	// Token: 0x06000364 RID: 868 RVA: 0x00051EEC File Offset: 0x000500EC
	private void C_Box2_MouseUp(object sender, MouseEventArgs e)
	{
		this.s_mouse0 = false;
		Cursor.Clip = default(Rectangle);
		this.C_Box2.Tag = null;
	}

	// Token: 0x06000365 RID: 869 RVA: 0x00051F1C File Offset: 0x0005011C
	private void ti_Tick(object sender, EventArgs e)
	{
		try
		{
			this.G.CopyFromScreen(new Point((Size)Cursor.Position), Point.Empty, this.Bmp.Size);
			this.C_Box3.BackColor = Color.FromArgb((int)this.Bmp.GetPixel(0, 0).R, (int)this.Bmp.GetPixel(0, 0).G, (int)this.Bmp.GetPixel(0, 0).B);
			this.Title(new object[]
			{
				this.C_Box3.BackColor.R,
				this.C_Box3.BackColor.G,
				this.C_Box3.BackColor.B
			});
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000366 RID: 870 RVA: 0x000027AC File Offset: 0x000009AC
	private void Title(object[] obj)
	{
		this.TEXT_COLOR = string.Format("RGB:({0},{1},{2})", RuntimeHelpers.GetObjectValue(obj[0]), RuntimeHelpers.GetObjectValue(obj[1]), RuntimeHelpers.GetObjectValue(obj[2]));
		this.BoxTitle.Refresh();
	}

	// Token: 0x06000367 RID: 871 RVA: 0x000027E1 File Offset: 0x000009E1
	private void CK1_MouseDown(object sender, MouseEventArgs e)
	{
		this.ti.Enabled = true;
		this.CK1.Checked = true;
	}

	// Token: 0x06000368 RID: 872 RVA: 0x000027FB File Offset: 0x000009FB
	private void CK1_MouseUp(object sender, MouseEventArgs e)
	{
		this.ti.Enabled = false;
		this.CK1.Checked = false;
	}

	// Token: 0x06000369 RID: 873 RVA: 0x00002226 File Offset: 0x00000426
	private void BTN_OK_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
	}

	// Token: 0x0600036A RID: 874 RVA: 0x00002815 File Offset: 0x00000A15
	private void Color_Box0_Activated(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x0600036B RID: 875 RVA: 0x00002815 File Offset: 0x00000A15
	private void Color_Box0_Deactivate(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x0600036C RID: 876 RVA: 0x00002815 File Offset: 0x00000A15
	private void BoxTitle_Resize(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x0600036D RID: 877 RVA: 0x0000206C File Offset: 0x0000026C
	private void C_Box0_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600036E RID: 878 RVA: 0x00052020 File Offset: 0x00050220
	private void BoxTitle_Paint(object sender, PaintEventArgs e)
	{
		checked
		{
			if (this.BoxTitlePaintEventArgsWait)
			{
				string text_COLOR = this.TEXT_COLOR;
				Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
				e.Graphics.DrawLine(new Pen(Color.FromArgb(50, (int)defaultColor_Foreground.R, (int)defaultColor_Foreground.G, (int)defaultColor_Foreground.B)), 0, 1, this.BoxTitle.Width, 1);
				Brush brush = new SolidBrush(SpySettings.DefaultColor_Foreground);
				Brush brush2 = new SolidBrush(Color.FromArgb(170, (int)this.BoxTitle.BackColor.R, (int)this.BoxTitle.BackColor.G, (int)this.BoxTitle.BackColor.B));
				Size size = TextRenderer.MeasureText(text_COLOR, reso.f);
				Rectangle rect = new Rectangle(0, 2, this.BoxTitle.Width, size.Height + 5);
				e.Graphics.FillRectangle(new Pen(brush2).Brush, rect);
				e.Graphics.DrawString(text_COLOR, reso.f, brush, 0f, 2f);
				Size size2 = TextRenderer.MeasureText("S", reso.f);
				if (this.BoxTitle.Height != size2.Height + 3)
				{
					this.BoxTitle.Height = size2.Height + 3;
				}
			}
		}
	}

	// Token: 0x0600036F RID: 879 RVA: 0x0000206C File Offset: 0x0000026C
	private void BoxTitle_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000370 RID: 880 RVA: 0x0000206C File Offset: 0x0000026C
	private void C_Box2_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x040003B9 RID: 953
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("C_Box2")]
	private PictureBox _C_Box2;

	// Token: 0x040003BA RID: 954
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BTN_OK")]
	private Button _BTN_OK;

	// Token: 0x040003BB RID: 955
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("C_Box0")]
	private PictureBox _C_Box0;

	// Token: 0x040003BC RID: 956
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ti")]
	private Timer _ti;

	// Token: 0x040003BD RID: 957
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CK1")]
	private CheckBox _CK1;

	// Token: 0x040003BE RID: 958
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BoxTitle")]
	private PictureBox _BoxTitle;

	// Token: 0x040003BF RID: 959
	private bool BoxTitlePaintEventArgsWait;

	// Token: 0x040003C0 RID: 960
	public bool Programmatically;

	// Token: 0x040003C1 RID: 961
	public Color default_color;

	// Token: 0x040003C2 RID: 962
	public Color _new_color;

	// Token: 0x040003C3 RID: 963
	private Bitmap Bmp;

	// Token: 0x040003C4 RID: 964
	private Graphics G;

	// Token: 0x040003C5 RID: 965
	private Point p1;

	// Token: 0x040003C6 RID: 966
	private bool s_mouse1;

	// Token: 0x040003C7 RID: 967
	private Point p0;

	// Token: 0x040003C8 RID: 968
	private bool s_mouse0;

	// Token: 0x040003C9 RID: 969
	private string TEXT_COLOR;
}
