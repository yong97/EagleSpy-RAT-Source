using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x020000CB RID: 203
[DesignerGenerated]
[ToolboxBitmap("ZoomPictureBox.bmp")]
public class ZoomPictureBox : UserControl
{
	// Token: 0x1700010A RID: 266
	// (get) Token: 0x060008B1 RID: 2225 RVA: 0x000CF34C File Offset: 0x000CD54C
	// (set) Token: 0x060008B2 RID: 2226 RVA: 0x0000383D File Offset: 0x00001A3D
	[Category("_ZoomPictureBox")]
	public Image Image
	{
		get
		{
			return this._Image;
		}
		set
		{
			this._Image = value;
			this.InitializeImage();
		}
	}

	// Token: 0x1700010B RID: 267
	// (get) Token: 0x060008B3 RID: 2227 RVA: 0x000CF364 File Offset: 0x000CD564
	// (set) Token: 0x060008B4 RID: 2228 RVA: 0x0000384C File Offset: 0x00001A4C
	[Category("_ZoomPictureBox")]
	[DefaultValue(0)]
	public ZoomPictureBox.ZoomType ZoomMode
	{
		get
		{
			return this._ZoomMode;
		}
		set
		{
			this._ZoomMode = value;
		}
	}

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x060008B5 RID: 2229 RVA: 0x000CF37C File Offset: 0x000CD57C
	// (set) Token: 0x060008B6 RID: 2230 RVA: 0x00003855 File Offset: 0x00001A55
	[Browsable(false)]
	public double ZoomFactor
	{
		get
		{
			return this._ZoomFactor;
		}
		set
		{
			this._ZoomFactor = this.ValidateZoomFactor(value);
			base.Invalidate(this._ImageBounds);
			this._ImageBounds = this.GetZoomedBounds();
			base.Invalidate(this._ImageBounds);
		}
	}

	// Token: 0x1700010D RID: 269
	// (get) Token: 0x060008B7 RID: 2231 RVA: 0x000CF394 File Offset: 0x000CD594
	// (set) Token: 0x060008B8 RID: 2232 RVA: 0x00003888 File Offset: 0x00001A88
	[Browsable(false)]
	public Point ImagePosition
	{
		get
		{
			return this._ImageBounds.Location;
		}
		set
		{
			this._ImageBounds.Location = value;
		}
	}

	// Token: 0x060008B9 RID: 2233 RVA: 0x000CF3B0 File Offset: 0x000CD5B0
	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	// Token: 0x060008BA RID: 2234 RVA: 0x00003896 File Offset: 0x00001A96
	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new Container();
		base.AutoScaleMode = AutoScaleMode.Font;
	}

	// Token: 0x060008BB RID: 2235 RVA: 0x000CF3F4 File Offset: 0x000CD5F4
	public ZoomPictureBox()
	{
		this.MouseWheelDivisor = 4000;
		this.MinimumImageWidth = 100;
		this.MinimumImageHeight = 100;
		this.MaximumZoomFactor = 16.0;
		this.EnableMouseWheelZooming = true;
		this.EnableMouseDragging = true;
		this._ZoomMode = ZoomPictureBox.ZoomType.MousePosition;
		this.InitializeComponent();
		this.DoubleBuffered = true;
		this.BackColor = Color.FromKnownColor(KnownColor.AppWorkspace);
		base.Size = new Size(200, 200);
	}

	// Token: 0x060008BC RID: 2236 RVA: 0x000CF474 File Offset: 0x000CD674
	protected override void OnMouseDown(MouseEventArgs e)
	{
		if (this.EnableMouseDragging && e.Button == MouseButtons.Left)
		{
			this._startDrag = e.Location;
			this._dragging = true;
		}
		base.OnMouseDown(e);
	}

	// Token: 0x060008BD RID: 2237 RVA: 0x000CF4B8 File Offset: 0x000CD6B8
	protected override void OnMouseMove(MouseEventArgs e)
	{
		checked
		{
			if (this._dragging)
			{
				base.Invalidate(this._ImageBounds);
				this._ImageBounds.X = this._ImageBounds.X + (e.X - this._startDrag.X);
				this._ImageBounds.Y = this._ImageBounds.Y + (e.Y - this._startDrag.Y);
				this._startDrag = e.Location;
				base.Invalidate(this._ImageBounds);
			}
			base.OnMouseMove(e);
		}
	}

	// Token: 0x060008BE RID: 2238 RVA: 0x000CF540 File Offset: 0x000CD740
	protected override void OnMouseUp(MouseEventArgs e)
	{
		if (this._dragging)
		{
			this._dragging = false;
			base.Invalidate();
		}
		base.OnMouseUp(e);
	}

	// Token: 0x060008BF RID: 2239 RVA: 0x000038AA File Offset: 0x00001AAA
	protected override void OnMouseEnter(EventArgs e)
	{
		base.Select();
		base.OnMouseEnter(e);
	}

	// Token: 0x060008C0 RID: 2240 RVA: 0x000CF56C File Offset: 0x000CD76C
	protected override void OnMouseWheel(MouseEventArgs e)
	{
		if (this.EnableMouseWheelZooming && base.Bounds.Contains(base.PointToClient(Control.MousePosition)))
		{
			double num = this._ZoomFactor;
			num *= 1.0 + (double)e.Delta / (double)this.MouseWheelDivisor;
			this.ZoomFactor = num;
		}
		base.OnMouseWheel(e);
	}

	// Token: 0x060008C1 RID: 2241 RVA: 0x000CF5D4 File Offset: 0x000CD7D4
	protected override void OnPaint(PaintEventArgs pe)
	{
		if (this._ZoomFactor > 4.0)
		{
			pe.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
			pe.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
		}
		else
		{
			pe.Graphics.InterpolationMode = InterpolationMode.Default;
		}
		if (this._Image != null)
		{
			pe.Graphics.DrawImage(this._Image, this._ImageBounds);
		}
		base.OnPaint(pe);
	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x000038B9 File Offset: 0x00001AB9
	protected override void OnParentChanged(EventArgs e)
	{
		this.InitializeImage();
		base.OnParentChanged(e);
	}

	// Token: 0x060008C3 RID: 2243 RVA: 0x000CF644 File Offset: 0x000CD844
	private void InitializeImage()
	{
		if (this._Image != null)
		{
			this.ZoomFactor = this.FitImageToControl();
			this._ImageBounds = this.CenterImageBounds();
		}
		base.Invalidate();
	}

	// Token: 0x060008C4 RID: 2244 RVA: 0x000CF67C File Offset: 0x000CD87C
	private double ValidateZoomFactor(double zoom)
	{
		zoom = Math.Min(zoom, this.MaximumZoomFactor);
		checked
		{
			if (this._Image != null)
			{
				if ((int)Math.Round(unchecked((double)this._Image.Width * zoom)) < this.MinimumImageWidth)
				{
					zoom = (double)this.MinimumImageWidth / (double)this._Image.Width;
				}
				if ((int)Math.Round(unchecked((double)this._Image.Height * zoom)) < this.MinimumImageHeight)
				{
					zoom = (double)this.MinimumImageHeight / (double)this._Image.Height;
				}
			}
			return zoom;
		}
	}

	// Token: 0x060008C5 RID: 2245 RVA: 0x000038C8 File Offset: 0x00001AC8
	public void RefreshLocation()
	{
		this.InitializeImage();
	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x000CF710 File Offset: 0x000CD910
	private double FitImageToControl()
	{
		double result;
		if (base.ClientSize == Size.Empty)
		{
			result = 1.0;
		}
		else
		{
			double num = (double)this._Image.Width / (double)this._Image.Height;
			double num2 = (double)base.ClientSize.Width / (double)base.ClientSize.Height;
			if (num > num2)
			{
				result = (double)base.ClientSize.Width / (double)this._Image.Width;
			}
			else
			{
				result = (double)base.ClientSize.Height / (double)this._Image.Height;
			}
		}
		return result;
	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x000CF7C8 File Offset: 0x000CD9C8
	private Rectangle CenterImageBounds()
	{
		checked
		{
			int num = (int)Math.Round(unchecked((double)this._Image.Width * this._ZoomFactor));
			int num2 = (int)Math.Round(unchecked((double)this._Image.Height * this._ZoomFactor));
			int x = (base.ClientSize.Width - num) / 2;
			int y = (base.ClientSize.Height - num2) / 2;
			return new Rectangle(x, y, num, num2);
		}
	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x000CF844 File Offset: 0x000CDA44
	private Rectangle GetZoomedBounds()
	{
		Rectangle result = default(Rectangle);
		checked
		{
			try
			{
				if (this._Image == null)
				{
					result = Rectangle.Empty;
					return result;
				}
				if (this._ImageBounds == Rectangle.Empty)
				{
					this._ImageBounds = this.CenterImageBounds();
				}
				Point point = this.FindZoomCenter(this._ZoomMode);
				double num = (double)this._ImageBounds.Width / (double)this._Image.Width;
				double num2 = this._ZoomFactor / num;
				this._ImageBounds.Width = (int)Math.Round(unchecked((double)this._ImageBounds.Width * num2));
				this._ImageBounds.Height = (int)Math.Round(unchecked((double)this._ImageBounds.Height * num2));
				Point point2 = default(Point);
				point2.X = (int)Math.Round(unchecked((double)point.X * num2));
				point2.Y = (int)Math.Round(unchecked((double)point.Y * num2));
				this._ImageBounds.X = this._ImageBounds.X + (point.X - point2.X);
				this._ImageBounds.Y = this._ImageBounds.Y + (point.Y - point2.Y);
				result = this._ImageBounds;
				return result;
			}
			catch (Exception)
			{
			}
			return result;
		}
	}

	// Token: 0x060008C9 RID: 2249 RVA: 0x000CF9BC File Offset: 0x000CDBBC
	private Point FindZoomCenter(ZoomPictureBox.ZoomType type)
	{
		Point result = default(Point);
		checked
		{
			switch (type)
			{
			case ZoomPictureBox.ZoomType.MousePosition:
			{
				Point point = base.PointToClient(Control.MousePosition);
				result.X = point.X - this._ImageBounds.X;
				result.Y = point.Y - this._ImageBounds.Y;
				break;
			}
			case ZoomPictureBox.ZoomType.ControlCenter:
				result.X = base.Width / 2 - this._ImageBounds.X;
				result.Y = base.Height / 2 - this._ImageBounds.Y;
				break;
			case ZoomPictureBox.ZoomType.ImageCenter:
				result.X = this._ImageBounds.Width / 2;
				result.Y = this._ImageBounds.Height / 2;
				break;
			default:
				return Point.Empty;
			}
			return result;
		}
	}

	// Token: 0x04000D21 RID: 3361
	private IContainer components;

	// Token: 0x04000D22 RID: 3362
	public int MouseWheelDivisor;

	// Token: 0x04000D23 RID: 3363
	public int MinimumImageWidth;

	// Token: 0x04000D24 RID: 3364
	public int MinimumImageHeight;

	// Token: 0x04000D25 RID: 3365
	public double MaximumZoomFactor;

	// Token: 0x04000D26 RID: 3366
	public bool EnableMouseWheelZooming;

	// Token: 0x04000D27 RID: 3367
	public bool EnableMouseDragging;

	// Token: 0x04000D28 RID: 3368
	private Rectangle _ImageBounds;

	// Token: 0x04000D29 RID: 3369
	private double _ZoomFactor;

	// Token: 0x04000D2A RID: 3370
	private Image _Image;

	// Token: 0x04000D2B RID: 3371
	private Point _startDrag;

	// Token: 0x04000D2C RID: 3372
	private bool _dragging;

	// Token: 0x04000D2D RID: 3373
	private ZoomPictureBox.ZoomType _ZoomMode;

	// Token: 0x020000CC RID: 204
	public enum ZoomType
	{
		// Token: 0x04000D2F RID: 3375
		MousePosition,
		// Token: 0x04000D30 RID: 3376
		ControlCenter,
		// Token: 0x04000D31 RID: 3377
		ImageCenter
	}
}
