using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000030 RID: 48
[DesignerGenerated]
public partial class AppsProperties : Form
{
	// Token: 0x060001CD RID: 461 RVA: 0x00002353 File Offset: 0x00000553
	public AppsProperties()
	{
		base.Load += this.AppsProperties_Load;
		this.Title = "null";
		this.InitializeComponent();
		this.Font = reso.f;
	}

	// Token: 0x060001CE RID: 462 RVA: 0x000136C4 File Offset: 0x000118C4
	private void AppsProperties_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\2.ico");
		this.SpyStyle();
		this.Text = this.Title;
		this.TOpacity.Interval = SpySettings.T_Interval;
		this.TOpacity.Enabled = true;
	}

	// Token: 0x060001CF RID: 463 RVA: 0x0001371C File Offset: 0x0001191C
	private void SpyStyle()
	{
		foreach (Panel panel in base.Controls.OfType<Panel>())
		{
			panel.BackColor = Color.Black;
		}
		foreach (Label label in this.BOXPNL1.Controls.OfType<Label>())
		{
			label.ForeColor = Color.White;
			label.BackColor = Color.Black;
		}
		foreach (PictureBox pictureBox in this.BOXPNL1.Controls.OfType<PictureBox>())
		{
			pictureBox.BackColor = Color.Black;
		}
		this.LPermissions.ForeColor = Color.White;
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x0001382C File Offset: 0x00011A2C
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

	// Token: 0x060001D1 RID: 465 RVA: 0x00002389 File Offset: 0x00000589
	private void BoxIcons_Click(object sender, EventArgs e)
	{
		Process.Start(string.Format("{0}{1}", "https://play.google.com/store/apps/details?id=", Conversions.ToString(this.BoxIcons.Tag)));
	}

	// Token: 0x0400013B RID: 315
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BoxIcons")]
	private PictureBox _BoxIcons;

	// Token: 0x0400013C RID: 316
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	// Token: 0x0400013D RID: 317
	public string Title;
}
