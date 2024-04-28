using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200007D RID: 125
[DesignerGenerated]
public partial class Icons : Form
{
	// Token: 0x060005C1 RID: 1473 RVA: 0x00002DE7 File Offset: 0x00000FE7
	public Icons()
	{
		base.Load += this.Icons_Load;
		this.InitializeComponent();
	}

	// Token: 0x060005C4 RID: 1476 RVA: 0x000942CC File Offset: 0x000924CC
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
			dataGridView.Columns[0].DefaultCellStyle.SelectionBackColor = SpySettings.DefaultColor_Background;
		}
	}

	// Token: 0x060005C5 RID: 1477 RVA: 0x000943B0 File Offset: 0x000925B0
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

	// Token: 0x060005C6 RID: 1478 RVA: 0x000943F8 File Offset: 0x000925F8
	private void Icons_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\4.ico");
		this.SpyStyle();
		this.DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
		this.DGV0.DefaultCellStyle.Font = reso.f;
		this.TOpacity.Interval = SpySettings.T_Interval;
		this.TOpacity.Enabled = true;
	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x0008A99C File Offset: 0x00088B9C
	private void DGV0_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
	{
		if (e.RowIndex1 == 0)
		{
			e.Handled = true;
		}
	}

	// Token: 0x060005C8 RID: 1480 RVA: 0x0009446C File Offset: 0x0009266C
	private void DGV0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
		{
			this.id = e.RowIndex;
			base.DialogResult = DialogResult.OK;
		}
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x0000206C File Offset: 0x0000026C
	private void DGV0_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	// Token: 0x04000814 RID: 2068
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV0")]
	private DataGridView _DGV0;

	// Token: 0x04000815 RID: 2069
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	// Token: 0x04000816 RID: 2070
	public int id;
}
