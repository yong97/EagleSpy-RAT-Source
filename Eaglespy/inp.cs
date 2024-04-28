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

// Token: 0x02000081 RID: 129
[DesignerGenerated]
public partial class inp : Form
{
	// Token: 0x060005E9 RID: 1513 RVA: 0x00097A58 File Offset: 0x00095C58
	private void translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", false) != 0)
		{
			if (Operators.CompareString(language, "CN", false) == 0)
			{
				this.CheckHidden.Text = Codes.Translate(this.CheckHidden.Text, "en", "zh");
				this.CheckFolder.Text = Codes.Translate(this.CheckFolder.Text, "en", "zh");
			}
		}
		else
		{
			this.CheckHidden.Text = Codes.Translate(this.CheckHidden.Text, "en", "ar");
			this.CheckFolder.Text = Codes.Translate(this.CheckFolder.Text, "en", "ar");
		}
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x00002EBF File Offset: 0x000010BF
	public inp()
	{
		base.Load += this.inp_Load;
		this.RectInputText0 = new List<Rectangle>();
		this.InitializeComponent();
		this.Font = reso.f;
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x00097B28 File Offset: 0x00095D28
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

	// Token: 0x060005EC RID: 1516 RVA: 0x00002EF5 File Offset: 0x000010F5
	private void inp_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\12.ico");
		this.translateme();
		this.TOpacity.Interval = SpySettings.T_Interval;
		this.TOpacity.Enabled = true;
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x00002226 File Offset: 0x00000426
	private void b_ok_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x00097B70 File Offset: 0x00095D70
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

	// Token: 0x060005EF RID: 1519 RVA: 0x00002226 File Offset: 0x00000426
	private void B_ok_Click_1(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
	}

	// Token: 0x0400085E RID: 2142
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	// Token: 0x0400085F RID: 2143
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	// Token: 0x04000860 RID: 2144
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b_ok")]
	private DrakeUIButtonIcon _b_ok;

	// Token: 0x04000861 RID: 2145
	private List<Rectangle> RectInputText0;
}
