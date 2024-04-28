using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200006C RID: 108
[DesignerGenerated]
public partial class Download : Form
{
	// Token: 0x06000510 RID: 1296 RVA: 0x0007EA54 File Offset: 0x0007CC54
	public Download()
	{
		base.Load += this.Download_Load;
		base.Closing += this.Download_Closing;
		this.FileStream = null;
		this._stream = 0L;
		this.xName = "null";
		this.Title = "null";
		this.InitializeComponent();
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x0007EF60 File Offset: 0x0007D160
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

	// Token: 0x06000514 RID: 1300 RVA: 0x0007F028 File Offset: 0x0007D228
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

	// Token: 0x06000515 RID: 1301 RVA: 0x0007F070 File Offset: 0x0007D270
	private void Download_Load(object sender, EventArgs e)
	{
		base.Location = checked(new Point(Screen.PrimaryScreen.WorkingArea.Width - base.Width, Screen.PrimaryScreen.WorkingArea.Height - base.Height));
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\7.ico");
		this.SpyStyle();
		this.DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
		this.DGV0.DefaultCellStyle.Font = reso.f;
		this.TimeFinish.Interval = 1000;
		this.TimeFinish.Enabled = true;
		this.Text = this.Title;
		this.TOpacity.Interval = SpySettings.T_Interval;
		this.TOpacity.Enabled = true;
	}

	// Token: 0x06000516 RID: 1302 RVA: 0x0007F14C File Offset: 0x0007D34C
	private void Download_Closing(object sender, CancelEventArgs e)
	{
		this.TimeFinish.Enabled = false;
		if (this.classClient != null)
		{
			this.classClient.qit = true;
			this.classClient.Close(this.Client);
		}
		if (this.FileStream != null)
		{
			this.FileStream.Dispose();
			this.FileStream.Close();
		}
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x0007F1B0 File Offset: 0x0007D3B0
	private void TimeFinish_Tick(object sender, EventArgs e)
	{
		if (this.DGV0.Rows.Count > 0 && this._stream <= this.TotalSize && this._stream > 0L)
		{
			this.stop_time = DateAndTime.Now;
			this.elapsed_time = this.stop_time.Subtract(this.start_time);
			long value = checked((long)Math.Round(unchecked((double)(checked(this.TotalSize - this._stream)) * this.elapsed_time.TotalSeconds) / (double)this._stream));
			string text = Codes.ToTime(value);
			if (!text.Equals("0:0:0"))
			{
				DateTime dateTime = DateTime.Now;
				DateTime dateTime2 = Convert.ToDateTime(text);
				dateTime = dateTime.AddHours((double)dateTime2.Hour).AddMinutes((double)dateTime2.Minute).AddSeconds((double)dateTime2.Second);
				this.DGV0.Rows[3].Cells[1].Value = "[" + text + "]";
			}
		}
	}

	// Token: 0x040006C8 RID: 1736
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TimeFinish")]
	private Timer _TimeFinish;

	// Token: 0x040006C9 RID: 1737
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	// Token: 0x040006CA RID: 1738
	public TcpClient Client;

	// Token: 0x040006CB RID: 1739
	public Client classClient;

	// Token: 0x040006CC RID: 1740
	public FileStream FileStream;

	// Token: 0x040006CD RID: 1741
	public long _stream;

	// Token: 0x040006CE RID: 1742
	public string xName;

	// Token: 0x040006CF RID: 1743
	public long TotalSize;

	// Token: 0x040006D0 RID: 1744
	public TimeSpan elapsed_time;

	// Token: 0x040006D1 RID: 1745
	public DateTime start_time;

	// Token: 0x040006D2 RID: 1746
	public DateTime stop_time;

	// Token: 0x040006D3 RID: 1747
	public string DownFolder;

	// Token: 0x040006D4 RID: 1748
	public string Title;
}
