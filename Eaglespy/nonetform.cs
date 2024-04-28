using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000099 RID: 153
[DesignerGenerated]
public partial class nonetform : Form
{
	// Token: 0x060006B1 RID: 1713 RVA: 0x00003339 File Offset: 0x00001539
	public nonetform()
	{
		base.Load += this.Nonetform_Load;
		this.InitializeComponent();
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x00003359 File Offset: 0x00001559
	private void DrakeUIAvatar1_Click(object sender, EventArgs e)
	{
		base.Close();
		this.CraxsStyle();
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x000A74E4 File Offset: 0x000A56E4
	public void CraxsStyle()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", false) != 0)
		{
			if (Operators.CompareString(language, "CN", false) != 0)
			{
				this.Label1.Text = "No internet Connection.\r\n\r\nPlease Check your internet and try again.";
			}
			else
			{
				this.Label1.Text = "没有网络连接。\r\n\r\n请检查您的互联网并重试。";
			}
		}
		else
		{
			this.Label1.Text = "لا يوجد اتصال بالإنترنت.\r\n\r\nيرجى التحقق من الإنترنت الخاص بك وحاول مرة أخرى.";
		}
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x000A7550 File Offset: 0x000A5750
	private void Nonetform_Load(object sender, EventArgs e)
	{
		base.StartPosition = FormStartPosition.Manual;
		base.Location = new Point(checked(Screen.PrimaryScreen.WorkingArea.Width - base.Width) / 2, 0);
	}

	// Token: 0x040009C5 RID: 2501
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar1")]
	private DrakeUIAvatar _DrakeUIAvatar1;
}
