using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200006B RID: 107
[DesignerGenerated]
public partial class DialogPloice : Form
{
	// Token: 0x06000506 RID: 1286 RVA: 0x00002C40 File Offset: 0x00000E40
	public DialogPloice()
	{
		base.Load += this.DialogPloice_Load;
		this.ARTEXT = "انا قرأت ما موجود اعلاه , وموافق على الشروط";
		this.ENTEXT = "I read all text above, And Accepted All";
		this.IsArab = false;
		this.InitializeComponent();
	}

	// Token: 0x06000509 RID: 1289 RVA: 0x0007E87C File Offset: 0x0007CA7C
	private void OK_Button_Click(object sender, EventArgs e)
	{
		if (!this.Acccheck.Checked)
		{
			if (this.IsArab)
			{
				Interaction.MsgBox("قم بالموافقة على الشروط اولا!", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				Interaction.MsgBox("Accepte Privacy Policy First!", MsgBoxStyle.OkOnly, null);
			}
		}
		else
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
		}
	}

	// Token: 0x0600050A RID: 1290 RVA: 0x00002C7D File Offset: 0x00000E7D
	private void Cancel_Button_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		base.Close();
	}

	// Token: 0x0600050B RID: 1291 RVA: 0x0007E8CC File Offset: 0x0007CACC
	private void DialogPloice_Load(object sender, EventArgs e)
	{
		this.StartNow = DateAndTime.Now.AddSeconds(15.0);
		this.Timer1.Start();
		this.OK_Button.Enabled = false;
		this.Cancel_Button.Enabled = false;
	}

	// Token: 0x0600050C RID: 1292 RVA: 0x0007E91C File Offset: 0x0007CB1C
	private void Button2_Click(object sender, EventArgs e)
	{
		this.IsArab = true;
		this.MainText.Text = "";
		this.Acccheck.Text = this.ARTEXT;
		this.OK_Button.Text = "موافق";
		this.Cancel_Button.Text = "كلا";
	}

	// Token: 0x0600050D RID: 1293 RVA: 0x0007E974 File Offset: 0x0007CB74
	private void Button1_Click(object sender, EventArgs e)
	{
		this.IsArab = false;
		this.MainText.Text = "";
		this.Acccheck.Text = this.ENTEXT;
		this.OK_Button.Text = "OK";
		this.Cancel_Button.Text = "Cancel";
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x0007E9CC File Offset: 0x0007CBCC
	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (DateTime.Compare(this.StartNow, DateAndTime.Now) < 0)
		{
			this.OK_Button.Enabled = true;
			this.Cancel_Button.Enabled = true;
			this.Text = " Privacy Policy & Terms of Service";
			this.Timer1.Stop();
		}
		else
		{
			this.Text = " Privacy Policy & Terms of Service - " + (checked(this.StartNow.Second - DateAndTime.Now.Second)).ToString();
		}
	}

	// Token: 0x0600050F RID: 1295 RVA: 0x0000206C File Offset: 0x0000026C
	private void DialogPloice_Load_1(object sender, EventArgs e)
	{
	}

	// Token: 0x040006B0 RID: 1712
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OK_Button")]
	private Button _OK_Button;

	// Token: 0x040006B1 RID: 1713
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Cancel_Button")]
	private Button _Cancel_Button;

	// Token: 0x040006B2 RID: 1714
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	// Token: 0x040006B3 RID: 1715
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	// Token: 0x040006B4 RID: 1716
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	// Token: 0x040006B5 RID: 1717
	private string ARTEXT;

	// Token: 0x040006B6 RID: 1718
	private string ENTEXT;

	// Token: 0x040006B7 RID: 1719
	private bool IsArab;

	// Token: 0x040006B8 RID: 1720
	private DateTime StartNow;
}
