using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000073 RID: 115
[DesignerGenerated]
public partial class EditSocket : Form
{
	// Token: 0x06000550 RID: 1360 RVA: 0x00002D22 File Offset: 0x00000F22
	public EditSocket()
	{
		base.Load += this.EditSocket_Load;
		this.RectInputText0 = new List<Rectangle>();
		this.InitializeComponent();
		this.Font = reso.f;
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x0008448C File Offset: 0x0008268C
	private void SpyStyle()
	{
		this.po.BackColor = SpySettings.DefaultColor_Background;
		this.po.ForeColor = SpySettings.DefaultColor_Foreground;
		checked
		{
			this.RectInputText0.Add(new Rectangle(this.po.Location.X - 1, this.po.Location.Y - 1, this.po.Width + 1, this.po.Height + 1));
			foreach (DataGridView dataGridView in this.PanelBOX.Controls.OfType<DataGridView>())
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
			foreach (Label label in this.PanelBOX.Controls.OfType<Label>())
			{
				label.ForeColor = SpySettings.DefaultColor_Foreground;
			}
			foreach (Button button in this.PanelBOX.Controls.OfType<Button>())
			{
				button.BackColor = SpySettings.DefaultColor_Foreground;
				button.ForeColor = SpySettings.DefaultColor_Background;
			}
			foreach (TextBox textBox in this.PanelBOX.Controls.OfType<TextBox>())
			{
				textBox.BackColor = SpySettings.DefaultColor_Background;
				textBox.ForeColor = SpySettings.DefaultColor_Foreground;
				this.RectInputText0.Add(new Rectangle(textBox.Location.X - 1, textBox.Location.Y - 1, textBox.Width + 1, textBox.Height + 1));
			}
			foreach (Panel panel in base.Controls.OfType<Panel>())
			{
				panel.BackColor = SpySettings.DefaultColor_Background;
			}
			this.Refresh();
		}
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x00084774 File Offset: 0x00082974
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

	// Token: 0x06000553 RID: 1363 RVA: 0x000847BC File Offset: 0x000829BC
	private void EditSocket_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\12.ico");
		this.SpyStyle();
		this.TextIP.Text = Codes.GetIPAddress();
		this.TOpacity.Interval = SpySettings.T_Interval;
		this.TOpacity.Enabled = true;
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x00084818 File Offset: 0x00082A18
	private void b_Add_Click(object sender, EventArgs e)
	{
		this.DGV0.Rows.Add(new object[]
		{
			this.TextIP.Text + ":" + Conversions.ToString(this.po.Value)
		});
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x00084864 File Offset: 0x00082A64
	private void b_del_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DGV0.SelectedRows.Count > 0)
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index);
				}
			}
		}
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x00002D58 File Offset: 0x00000F58
	private void btnUp_Click(object sender, EventArgs e)
	{
		this.Rowinsert(false);
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x00002D61 File Offset: 0x00000F61
	private void btnDown_Click(object sender, EventArgs e)
	{
		this.Rowinsert(true);
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x000848D0 File Offset: 0x00082AD0
	private void Rowinsert(bool isDown)
	{
		checked
		{
			if (this.DGV0.SelectedRows.Count == 1 & this.DGV0.Rows.Count != 1)
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Value);
					if (isDown)
					{
						this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index);
						this.DGV0.Rows.Insert(this.DGV0.SelectedRows[i].Index + 1, new object[]
						{
							text
						});
						this.DGV0.CurrentCell = this.DGV0.Rows[this.DGV0.SelectedRows[i].Index + 1].Cells[0];
					}
					else if (this.DGV0.SelectedRows[i].Index != 0)
					{
						this.DGV0.Rows.Insert(this.DGV0.SelectedRows[i].Index - 1, new object[]
						{
							text
						});
						this.DGV0.CurrentCell = this.DGV0.Rows[this.DGV0.SelectedRows[i].Index - 1].Cells[0];
						this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index + 1);
						this.DGV0.CurrentCell = this.DGV0.Rows[this.DGV0.SelectedRows[i].Index - 1].Cells[0];
					}
				}
			}
		}
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x00002226 File Offset: 0x00000426
	private void OKY_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x00084B0C File Offset: 0x00082D0C
	private void PanelBOX_Paint(object sender, PaintEventArgs e)
	{
		e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
		if (this.RectInputText0.Count > 0)
		{
			foreach (Rectangle rect in this.RectInputText0)
			{
				if (rect.Width > 0)
				{
					e.Graphics.FillRectangle(new SolidBrush(defaultColor_Foreground), rect);
				}
			}
		}
	}

	// Token: 0x04000748 RID: 1864
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PanelBOX")]
	private Panel _PanelBOX;

	// Token: 0x04000749 RID: 1865
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnUp")]
	private Button _btnUp;

	// Token: 0x0400074A RID: 1866
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnDown")]
	private Button _btnDown;

	// Token: 0x0400074B RID: 1867
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b_Add")]
	private Button _b_Add;

	// Token: 0x0400074C RID: 1868
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b_del")]
	private Button _b_del;

	// Token: 0x0400074D RID: 1869
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OKY")]
	private Button _OKY;

	// Token: 0x0400074E RID: 1870
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	// Token: 0x0400074F RID: 1871
	private List<Rectangle> RectInputText0;
}
