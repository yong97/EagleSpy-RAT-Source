using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200008E RID: 142
[DesignerGenerated]
public partial class LanguageSelector : Form
{
	// Token: 0x06000661 RID: 1633 RVA: 0x0000320A File Offset: 0x0000140A
	public LanguageSelector()
	{
		base.Load += this.LanguageSelector_Load;
		this.SelectedLang = "";
		this.InitializeComponent();
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x00003235 File Offset: 0x00001435
	private void Copydev_Click(object sender, EventArgs e)
	{
		this.SelectedLang = "AR";
		base.Close();
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x00003248 File Offset: 0x00001448
	private void DrakeUIButton1_Click(object sender, EventArgs e)
	{
		this.SelectedLang = "EN";
		base.Close();
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x0000325B File Offset: 0x0000145B
	private void DrakeUIButton2_Click(object sender, EventArgs e)
	{
		this.SelectedLang = "CN";
		base.Close();
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x0000206C File Offset: 0x0000026C
	private void LanguageSelector_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x04000949 RID: 2377
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("copydev")]
	private DrakeUIButton _copydev;

	// Token: 0x0400094A RID: 2378
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButton1")]
	private DrakeUIButton _DrakeUIButton1;

	// Token: 0x0400094B RID: 2379
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButton2")]
	private DrakeUIButton _DrakeUIButton2;

	// Token: 0x0400094C RID: 2380
	public string SelectedLang;
}
