using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000022 RID: 34
[DesignerGenerated]
public partial class AddNumber : Form
{
	// Token: 0x0600016D RID: 365 RVA: 0x0000206C File Offset: 0x0000026C
	private void b_ok_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600016E RID: 366 RVA: 0x000021B8 File Offset: 0x000003B8
	public AddNumber()
	{
		base.Load += this.AddNumber_Load;
		this.RectInputText0 = new List<Rectangle>();
		this.InitializeComponent();
		this.Font = reso.f;
	}

	// Token: 0x0600016F RID: 367 RVA: 0x0000D90C File Offset: 0x0000BB0C
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

	// Token: 0x06000170 RID: 368 RVA: 0x000021EE File Offset: 0x000003EE
	private void AddNumber_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\12.ico");
		this.TOpacity.Interval = SpySettings.T_Interval;
		this.TOpacity.Enabled = true;
	}

	// Token: 0x06000171 RID: 369 RVA: 0x0000D954 File Offset: 0x0000BB54
	private void Panel1_Paint(object sender, PaintEventArgs e)
	{
		e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
		if (this.RectInputText0.Count > 0)
		{
			foreach (Rectangle rect in this.RectInputText0)
			{
				if (rect.Width > 0)
				{
					e.Graphics.FillRectangle(new SolidBrush(defaultColor_Foreground), rect);
				}
			}
		}
	}

	// Token: 0x06000172 RID: 370 RVA: 0x00002226 File Offset: 0x00000426
	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
	}

	// Token: 0x040000AE RID: 174
	private DrakeUIButtonIcon _DrakeUIButtonIcon3;

	// Token: 0x040000AF RID: 175
	private List<Rectangle> RectInputText0;
}
