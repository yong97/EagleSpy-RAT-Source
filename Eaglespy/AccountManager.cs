using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000020 RID: 32
[DesignerGenerated]
public partial class AccountManager : Form
{
	// Token: 0x06000158 RID: 344 RVA: 0x0000C554 File Offset: 0x0000A754
	public AccountManager()
	{
		base.Load += this.AccountManager_Load;
		base.Activated += this.AngelAndroidForm_Activated;
		base.Deactivate += this.AngelAndroidForm_Deactivate;
		this.Title = "null";
		this.BoxTitlePaintEventArgsWait = false;
		this.InitializeComponent();
	}

	// Token: 0x0600015B RID: 347 RVA: 0x0000CD40 File Offset: 0x0000AF40
	private void SpyStyle()
	{
		this.BoxTitle.BackColor = SpySettings.DefaultColor_Background;
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

	// Token: 0x0600015C RID: 348 RVA: 0x0000CE18 File Offset: 0x0000B018
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

	// Token: 0x0600015D RID: 349 RVA: 0x0000CE60 File Offset: 0x0000B060
	private void AccountManager_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\1.ico");
		this.DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
		this.DGV0.DefaultCellStyle.Font = reso.f;
		if (Operators.CompareString(SpySettings.SAVING_DATA, "No", false) == 0)
		{
			this.SaveToolStripMenuItem.Visible = true;
			this.SaveAsToolStripMenuItem.Visible = true;
		}
		this.Text = this.Title;
		this.TOpacity.Interval = SpySettings.T_Interval;
		this.TOpacity.Enabled = true;
		this.BoxTitlePaintEventArgsWait = true;
	}

	// Token: 0x0600015E RID: 350 RVA: 0x0000CF10 File Offset: 0x0000B110
	private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
		saveFileDialog.Filter = "html (*.html)|*.html";
		if (saveFileDialog.ShowDialog() == DialogResult.OK)
		{
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				reso.SAVEit((Array)a0);
			}, new object[]
			{
				this.DGV0,
				"null",
				saveFileDialog.FileName,
				this.tmpClientName,
				this.tmpCountry + " - " + this.tmpAddressIP,
				"Accounts",
				"log",
				"null"
			});
		}
		saveFileDialog.Dispose();
	}

	// Token: 0x0600015F RID: 351 RVA: 0x0000CFE4 File Offset: 0x0000B1E4
	private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
	{
		reso.Directory_Exist(this.classClient);
		ThreadPool.QueueUserWorkItem(delegate(object a0)
		{
			reso.SAVEit((Array)a0);
		}, new object[]
		{
			this.DGV0,
			this.tmpFolderUSER,
			"Account Manager",
			this.tmpClientName,
			this.tmpCountry + " - " + this.tmpAddressIP,
			"Accounts",
			"log",
			DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
		});
	}

	// Token: 0x06000160 RID: 352 RVA: 0x0000D094 File Offset: 0x0000B294
	private void BoxTitle_Paint(object sender, PaintEventArgs e)
	{
		checked
		{
			if (this.BoxTitlePaintEventArgsWait)
			{
				int count = this.DGV0.Rows.Count;
				string str = "All " + Conversions.ToString(count);
				string str2 = "Selected " + Conversions.ToString(this.DGV0.SelectedRows.Count);
				Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
				e.Graphics.DrawLine(new Pen(Color.FromArgb(50, (int)defaultColor_Foreground.R, (int)defaultColor_Foreground.G, (int)defaultColor_Foreground.B)), 0, 1, this.BoxTitle.Width, 1);
				Brush brush = new SolidBrush(SpySettings.DefaultColor_Foreground);
				Brush brush2 = new SolidBrush(Color.FromArgb(170, (int)this.BoxTitle.BackColor.R, (int)this.BoxTitle.BackColor.G, (int)this.BoxTitle.BackColor.B));
				Size size = TextRenderer.MeasureText(str + Strings.Space(10) + str2, reso.f);
				Rectangle rect = new Rectangle(0, 2, this.BoxTitle.Width, size.Height + 5);
				e.Graphics.FillRectangle(new Pen(brush2).Brush, rect);
				e.Graphics.DrawString(str + Strings.Space(10) + str2 + Strings.Space(10), reso.f, brush, 0f, 2f);
				Size size2 = TextRenderer.MeasureText("S", reso.f);
				if (this.BoxTitle.Height != size2.Height + 3)
				{
					this.BoxTitle.Height = size2.Height + 3;
				}
			}
		}
	}

	// Token: 0x06000161 RID: 353 RVA: 0x00002192 File Offset: 0x00000392
	private void AngelAndroidForm_Activated(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x06000162 RID: 354 RVA: 0x00002192 File Offset: 0x00000392
	private void AngelAndroidForm_Deactivate(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x06000163 RID: 355 RVA: 0x00002192 File Offset: 0x00000392
	private void BoxTitle_Resize(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x06000164 RID: 356 RVA: 0x00002192 File Offset: 0x00000392
	private void DGV0_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x06000165 RID: 357 RVA: 0x00002192 File Offset: 0x00000392
	private void DGV0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x06000166 RID: 358 RVA: 0x00002192 File Offset: 0x00000392
	private void DGV0_SelectionChanged(object sender, EventArgs e)
	{
		this.BoxTitle.Invalidate();
	}

	// Token: 0x04000098 RID: 152
	public TcpClient Client;

	// Token: 0x04000099 RID: 153
	public Client classClient;

	// Token: 0x0400009A RID: 154
	public string Title;

	// Token: 0x0400009B RID: 155
	public string tmpFolderUSER;

	// Token: 0x0400009C RID: 156
	public string tmpClientName;

	// Token: 0x0400009D RID: 157
	public string tmpCountry;

	// Token: 0x0400009E RID: 158
	public string tmpAddressIP;

	// Token: 0x0400009F RID: 159
	private bool BoxTitlePaintEventArgsWait;
}
