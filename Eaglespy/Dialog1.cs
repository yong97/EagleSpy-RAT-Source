using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000069 RID: 105
[DesignerGenerated]
public partial class Dialog1 : Form
{
	// Token: 0x060004F9 RID: 1273 RVA: 0x00002BBE File Offset: 0x00000DBE
	public Dialog1()
	{
		base.Load += this.Dialog1_Load;
		this.InitializeComponent();
	}

	// Token: 0x060004FC RID: 1276 RVA: 0x0000206C File Offset: 0x0000026C
	private void translateme()
	{
	}

	// Token: 0x060004FD RID: 1277 RVA: 0x0000206C File Offset: 0x0000026C
	private void Cancel_Button_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060004FE RID: 1278 RVA: 0x00002BDE File Offset: 0x00000DDE
	private void Dialog1_Load(object sender, EventArgs e)
	{
		this.Mytitle.Text = this.Title;
	}

	// Token: 0x060004FF RID: 1279 RVA: 0x00002BF1 File Offset: 0x00000DF1
	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		this.TheText = this.Mytext.Text;
		base.DialogResult = DialogResult.OK;
		base.Close();
	}

	// Token: 0x06000500 RID: 1280 RVA: 0x00002C11 File Offset: 0x00000E11
	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.No;
		base.Close();
	}

	// Token: 0x0400069E RID: 1694
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	// Token: 0x0400069F RID: 1695
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	// Token: 0x040006A0 RID: 1696
	public string Title;

	// Token: 0x040006A1 RID: 1697
	public string TheText;
}
