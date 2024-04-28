using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200006A RID: 106
[DesignerGenerated]
public partial class Dialog2 : Form
{
	// Token: 0x06000501 RID: 1281 RVA: 0x00002C20 File Offset: 0x00000E20
	public Dialog2()
	{
		base.Load += this.Dialog2_Load;
		this.InitializeComponent();
	}

	// Token: 0x06000504 RID: 1284 RVA: 0x00002858 File Offset: 0x00000A58
	private void Button1_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	// Token: 0x06000505 RID: 1285 RVA: 0x0000206C File Offset: 0x0000026C
	private void Dialog2_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x040006A8 RID: 1704
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;
}
