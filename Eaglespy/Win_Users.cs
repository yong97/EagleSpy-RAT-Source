using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x020000CA RID: 202
[DesignerGenerated]
public partial class Win_Users : Form
{
	// Token: 0x060008A5 RID: 2213 RVA: 0x000037CD File Offset: 0x000019CD
	public Win_Users()
	{
		base.Load += this.Win_Users_Load;
		base.Closing += this.Win_Users_Closing;
		this.InitializeComponent();
	}

	// Token: 0x060008A8 RID: 2216 RVA: 0x000CF008 File Offset: 0x000CD208
	private void Win_Users_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\1.ico");
		this.DGV0.ContextMenuStrip = this.ctxz;
		this.DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
		this.DGV0.DefaultCellStyle.Font = reso.f;
		this.SpyStyle();
		this.MYTEXT();
		this.TOpacity.Interval = SpySettings.T_Interval;
		this.TOpacity.Enabled = true;
	}

	// Token: 0x060008A9 RID: 2217 RVA: 0x0007EF60 File Offset: 0x0007D160
	private void SpyStyle()
	{
		foreach (DataGridView dataGridView in base.Controls.OfType<DataGridView>())
		{
			dataGridView.BackgroundColor = SpySettings.DefaultColor_Background;
			dataGridView.BackColor = SpySettings.DefaultColor_Background;
			dataGridView.ColumnHeadersDefaultCellStyle.BackColor = SpySettings.DefaultColor_Background;
			dataGridView.DefaultCellStyle.BackColor = SpySettings.DefaultColor_Background;
			dataGridView.DefaultCellStyle.SelectionForeColor = SpySettings.DefaultColor_Background;
			dataGridView.DefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground;
			dataGridView.DefaultCellStyle.SelectionBackColor = SpySettings.DefaultColor_Foreground;
			dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground;
		}
	}

	// Token: 0x060008AA RID: 2218 RVA: 0x000CF094 File Offset: 0x000CD294
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

	// Token: 0x060008AB RID: 2219 RVA: 0x000037FF File Offset: 0x000019FF
	private void Win_Users_Closing(object sender, CancelEventArgs e)
	{
		MyProject.Forms.CraxsRatMain.WU = null;
	}

	// Token: 0x060008AC RID: 2220 RVA: 0x0000206C File Offset: 0x0000026C
	private void DGV0_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	// Token: 0x060008AD RID: 2221 RVA: 0x00003811 File Offset: 0x00001A11
	public void MYTEXT()
	{
		this.Text = "Users (" + Conversions.ToString(this.DGV0.Rows.Count) + ")";
	}

	// Token: 0x060008AE RID: 2222 RVA: 0x000CF0DC File Offset: 0x000CD2DC
	private void DGV0_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		if (this.DGV0.Rows.Count > 0 && e.RowIndex != -1)
		{
			string str = Conversions.ToString(this.DGV0.Rows[e.RowIndex].Cells[2].Value);
			string text = reso.res_Path + "\\Users\\" + str;
			if (Directory.Exists(text))
			{
				Process.Start(text);
			}
			else
			{
				this.DGV0.Rows.RemoveAt(e.RowIndex);
				this.MYTEXT();
			}
		}
	}

	// Token: 0x060008AF RID: 2223 RVA: 0x000CF178 File Offset: 0x000CD378
	private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DGV0.SelectedRows.Count > 0)
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string str = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[2].Value);
					string text = reso.res_Path + "\\Users\\" + str;
					if (Directory.Exists(text))
					{
						Process.Start(text);
					}
					else
					{
						this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index);
						this.MYTEXT();
					}
				}
			}
		}
	}

	// Token: 0x060008B0 RID: 2224 RVA: 0x000CF258 File Offset: 0x000CD458
	private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DGV0.SelectedRows.Count > 0)
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int num2 = num; num2 >= 0; num2 += -1)
				{
					string str = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[num2].Index].Cells[2].Value);
					string path = reso.res_Path + "\\Users\\" + str;
					this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[num2].Index);
					this.MYTEXT();
					if (Directory.Exists(path))
					{
						try
						{
							Directory.Delete(path, true);
						}
						catch (Exception)
						{
						}
					}
				}
			}
		}
	}

	// Token: 0x04000D14 RID: 3348
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV0")]
	private DataGridView _DGV0;

	// Token: 0x04000D15 RID: 3349
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	// Token: 0x04000D16 RID: 3350
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OpenToolStripMenuItem")]
	private ToolStripMenuItem _OpenToolStripMenuItem;

	// Token: 0x04000D17 RID: 3351
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DeleteToolStripMenuItem")]
	private ToolStripMenuItem _DeleteToolStripMenuItem;
}
