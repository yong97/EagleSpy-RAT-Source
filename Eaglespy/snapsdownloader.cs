using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x020000C3 RID: 195
[DesignerGenerated]
public partial class snapsdownloader : Form
{
	// Token: 0x06000877 RID: 2167 RVA: 0x00003753 File Offset: 0x00001953
	public snapsdownloader()
	{
		base.Load += this.Snapsdownloader_Load;
		this.imageCounter = 0;
		this.totalImages = 0;
		this.Downloadfolder = "";
		this.InitializeComponent();
	}

	// Token: 0x06000878 RID: 2168 RVA: 0x000C92E4 File Offset: 0x000C74E4
	private void Snapsdownloader_Load(object sender, EventArgs e)
	{
		base.Visible = true;
		base.Location = checked(new Point(Screen.PrimaryScreen.WorkingArea.Width - base.Width, Screen.PrimaryScreen.WorkingArea.Height - base.Height));
	}

	// Token: 0x06000879 RID: 2169 RVA: 0x000C933C File Offset: 0x000C753C
	public void UpdateProgressBar()
	{
		checked
		{
			if (base.InvokeRequired)
			{
				base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
				{
					this.UpdateProgressBar();
				}));
			}
			else
			{
				int value = (int)Math.Round(unchecked((double)this.imageCounter / (double)this.totalImages * 100.0));
				this.Bbar.Value = value;
				this.finishedtext.Text = "-> Finished: " + this.imageCounter.ToString();
				this.lefttext.Text = "-> Left: " + (this.totalImages - this.imageCounter).ToString();
				if (this.Bbar.Value == this.Bbar.Maximum)
				{
					this.statustext.Text = "-> Status : Done.";
				}
				else
				{
					this.statustext.Text = "-> Status : Downloading...";
				}
			}
		}
	}

	// Token: 0x0600087A RID: 2170 RVA: 0x000C9420 File Offset: 0x000C7620
	private void DrakeUIButtonIcon12_Click(object sender, EventArgs e)
	{
		if (this.Bbar.Value == this.Bbar.Maximum || Codes.MyMsgBox("Alert", "Exit without finish download ?", true, Resources.information48px))
		{
			base.Close();
		}
	}

	// Token: 0x0600087B RID: 2171 RVA: 0x000C9468 File Offset: 0x000C7668
	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (Directory.Exists(this.Downloadfolder))
		{
			Process.Start(this.Downloadfolder);
		}
	}

	// Token: 0x04000C80 RID: 3200
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon12")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon12;

	// Token: 0x04000C81 RID: 3201
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	// Token: 0x04000C82 RID: 3202
	public int imageCounter;

	// Token: 0x04000C83 RID: 3203
	public int totalImages;

	// Token: 0x04000C84 RID: 3204
	public string Downloadfolder;
}
