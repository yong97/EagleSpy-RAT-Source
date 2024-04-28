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

// Token: 0x0200003B RID: 59
[DesignerGenerated]
public partial class CallPhone : Form
{
	// Token: 0x0600028F RID: 655 RVA: 0x00048734 File Offset: 0x00046934
	public CallPhone()
	{
		base.Load += this.CallPhone_Load;
		this._keyback = false;
		this._Call = "call";
		this.Title = "null";
		this.RectInputText0 = new List<Rectangle>();
		this.InitializeComponent();
		this.Font = reso.f;
	}

	// Token: 0x06000290 RID: 656 RVA: 0x00048794 File Offset: 0x00046994
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

	// Token: 0x06000291 RID: 657 RVA: 0x000487DC File Offset: 0x000469DC
	private void CallPhone_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\18.ico");
		this.TextBox1.ContextMenuStrip = this.CMenu;
		int fontSize = MySettingsProperty.Settings.FontSize;
		if (CallPhone.IsFontInstalled("Wingdings 3"))
		{
			this.b_DEL.Font = new Font("Wingdings 3", (float)fontSize, FontStyle.Regular);
			this.b_DEL.Text = "…";
		}
		else
		{
			this.b_DEL.Text = "<";
		}
		this.TOpacity.Interval = SpySettings.T_Interval;
		this.TOpacity.Enabled = true;
	}

	// Token: 0x06000292 RID: 658 RVA: 0x00048884 File Offset: 0x00046A84
	public static bool IsFontInstalled(string FontName)
	{
		bool result;
		using (Font font = new Font(FontName, 10f))
		{
			result = (string.Compare(FontName, font.Name, StringComparison.InvariantCultureIgnoreCase) == 0);
		}
		return result;
	}

	// Token: 0x06000293 RID: 659 RVA: 0x000488CC File Offset: 0x00046ACC
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

	// Token: 0x06000294 RID: 660 RVA: 0x00002585 File Offset: 0x00000785
	private void b1_Click(object sender, EventArgs e)
	{
		TextBox textBox = this.TextBox1;
		textBox.Text += "1";
	}

	// Token: 0x06000295 RID: 661 RVA: 0x000025A2 File Offset: 0x000007A2
	private void b2_Click(object sender, EventArgs e)
	{
		TextBox textBox = this.TextBox1;
		textBox.Text += "2";
	}

	// Token: 0x06000296 RID: 662 RVA: 0x000025BF File Offset: 0x000007BF
	private void b3_Click(object sender, EventArgs e)
	{
		TextBox textBox = this.TextBox1;
		textBox.Text += "3";
	}

	// Token: 0x06000297 RID: 663 RVA: 0x000025DC File Offset: 0x000007DC
	private void b4_Click(object sender, EventArgs e)
	{
		TextBox textBox = this.TextBox1;
		textBox.Text += "4";
	}

	// Token: 0x06000298 RID: 664 RVA: 0x000025F9 File Offset: 0x000007F9
	private void b5_Click(object sender, EventArgs e)
	{
		TextBox textBox = this.TextBox1;
		textBox.Text += "5";
	}

	// Token: 0x06000299 RID: 665 RVA: 0x00002616 File Offset: 0x00000816
	private void b6_Click(object sender, EventArgs e)
	{
		TextBox textBox = this.TextBox1;
		textBox.Text += "6";
	}

	// Token: 0x0600029A RID: 666 RVA: 0x00002633 File Offset: 0x00000833
	private void b7_Click(object sender, EventArgs e)
	{
		TextBox textBox = this.TextBox1;
		textBox.Text += "7";
	}

	// Token: 0x0600029B RID: 667 RVA: 0x00002650 File Offset: 0x00000850
	private void b8_Click(object sender, EventArgs e)
	{
		TextBox textBox = this.TextBox1;
		textBox.Text += "8";
	}

	// Token: 0x0600029C RID: 668 RVA: 0x0000266D File Offset: 0x0000086D
	private void b9_Click(object sender, EventArgs e)
	{
		TextBox textBox = this.TextBox1;
		textBox.Text += "9";
	}

	// Token: 0x0600029D RID: 669 RVA: 0x0000268A File Offset: 0x0000088A
	private void b0_Click(object sender, EventArgs e)
	{
		TextBox textBox = this.TextBox1;
		textBox.Text += "0";
	}

	// Token: 0x0600029E RID: 670 RVA: 0x00048964 File Offset: 0x00046B64
	private void b_DEL_Click(object sender, EventArgs e)
	{
		if (this.TextBox1.Text.Length > 0)
		{
			this.TextBox1.Text = this.TextBox1.Text.Remove(checked(this.TextBox1.Text.Length - 1));
		}
	}

	// Token: 0x0600029F RID: 671 RVA: 0x000026A7 File Offset: 0x000008A7
	private void B_star_Click(object sender, EventArgs e)
	{
		TextBox textBox = this.TextBox1;
		textBox.Text += "*";
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x000026C4 File Offset: 0x000008C4
	private void B_hash_Click(object sender, EventArgs e)
	{
		TextBox textBox = this.TextBox1;
		textBox.Text += "#";
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x0000206C File Offset: 0x0000026C
	private void Button1_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x0000206C File Offset: 0x0000026C
	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x000489B4 File Offset: 0x00046BB4
	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (this._keyback)
		{
			e.Handled = false;
		}
		else
		{
			string text = "0123456789,*#+";
			if (!text.Contains(e.KeyChar.ToString()))
			{
				e.Handled = true;
			}
		}
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x000489FC File Offset: 0x00046BFC
	private void TextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Back)
		{
			this._keyback = true;
		}
		else
		{
			this._keyback = false;
		}
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x000026E1 File Offset: 0x000008E1
	private void CutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.TextBox1.Cut();
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x000026EE File Offset: 0x000008EE
	private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.TextBox1.Copy();
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x00048A24 File Offset: 0x00046C24
	private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string text = "0123456789,*#+";
		if (MyProject.Computer.Clipboard.ContainsText())
		{
			string text2 = MyProject.Computer.Clipboard.GetText();
			if (text2.Length <= 1500)
			{
				string text3 = text2;
				foreach (char value in text3)
				{
					if (!text.ToString().Contains(Conversions.ToString(value)))
					{
						return;
					}
				}
			}
		}
		this.TextBox1.Paste();
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x000026FB File Offset: 0x000008FB
	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		this._Call = "call";
		base.DialogResult = DialogResult.OK;
	}

	// Token: 0x040002F2 RID: 754
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	// Token: 0x040002F3 RID: 755
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	// Token: 0x040002F4 RID: 756
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	// Token: 0x040002F5 RID: 757
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("B_hash")]
	private Button _B_hash;

	// Token: 0x040002F6 RID: 758
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b0")]
	private Button _b0;

	// Token: 0x040002F7 RID: 759
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("B_star")]
	private Button _B_star;

	// Token: 0x040002F8 RID: 760
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b9")]
	private Button _b9;

	// Token: 0x040002F9 RID: 761
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b8")]
	private Button _b8;

	// Token: 0x040002FA RID: 762
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b7")]
	private Button _b7;

	// Token: 0x040002FB RID: 763
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b6")]
	private Button _b6;

	// Token: 0x040002FC RID: 764
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b5")]
	private Button _b5;

	// Token: 0x040002FD RID: 765
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b4")]
	private Button _b4;

	// Token: 0x040002FE RID: 766
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b3")]
	private Button _b3;

	// Token: 0x040002FF RID: 767
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b2")]
	private Button _b2;

	// Token: 0x04000300 RID: 768
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b1")]
	private Button _b1;

	// Token: 0x04000301 RID: 769
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b_DEL")]
	private Button _b_DEL;

	// Token: 0x04000302 RID: 770
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CutToolStripMenuItem")]
	private ToolStripMenuItem _CutToolStripMenuItem;

	// Token: 0x04000303 RID: 771
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CopyToolStripMenuItem")]
	private ToolStripMenuItem _CopyToolStripMenuItem;

	// Token: 0x04000304 RID: 772
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PasteToolStripMenuItem")]
	private ToolStripMenuItem _PasteToolStripMenuItem;

	// Token: 0x04000305 RID: 773
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	// Token: 0x04000306 RID: 774
	private bool _keyback;

	// Token: 0x04000307 RID: 775
	public string _Call;

	// Token: 0x04000308 RID: 776
	public string Title;

	// Token: 0x04000309 RID: 777
	private List<Rectangle> RectInputText0;
}
