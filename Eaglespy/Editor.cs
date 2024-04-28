using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000072 RID: 114
[DesignerGenerated]
public partial class Editor : Form
{
	// Token: 0x06000544 RID: 1348 RVA: 0x00083478 File Offset: 0x00081678
	public Editor()
	{
		base.Load += this.Editor_Load;
		base.Activated += this.Editor_Activated;
		this.path = null;
		this.Title = "null";
		this.InitializeComponent();
		this.Font = reso.f;
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x000834D4 File Offset: 0x000816D4
	private void SpyStyle()
	{
		foreach (Button button in this.Panel1.Controls.OfType<Button>())
		{
			button.BackColor = SpySettings.DefaultColor_Foreground;
			button.ForeColor = SpySettings.DefaultColor_Background;
		}
		foreach (RichTextBox richTextBox in base.Controls.OfType<RichTextBox>())
		{
			richTextBox.ForeColor = SpySettings.DefaultColor_Foreground;
			richTextBox.BackColor = SpySettings.DefaultColor_Background;
		}
		foreach (Panel panel in base.Controls.OfType<Panel>())
		{
			panel.BackColor = SpySettings.DefaultColor_Background;
		}
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x000835DC File Offset: 0x000817DC
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

	// Token: 0x06000547 RID: 1351 RVA: 0x00083624 File Offset: 0x00081824
	private void Editor_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\8.ico");
		this.SpyStyle();
		this.EditText.ContextMenuStrip = this.CMenu;
		this.Text = this.Title;
		this.TOpacity.Interval = SpySettings.T_Interval;
		this.TOpacity.Enabled = true;
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x0008368C File Offset: 0x0008188C
	private void EditText_TextChanged(object sender, EventArgs e)
	{
		if (!this.b_ok.Visible & this.status)
		{
			this.b_ok.Visible = true;
		}
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x00002CF2 File Offset: 0x00000EF2
	private void Editor_Activated(object sender, EventArgs e)
	{
		this.status = true;
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x000836BC File Offset: 0x000818BC
	private void b_ok_Click(object sender, EventArgs e)
	{
		if (this.classClient != null & Operators.CompareString(this.path, null, false) != 0)
		{
			object[] array2;
			if (this.EditText.Text.Length > 0)
			{
				object[] array = new object[4];
				array[0] = this.Client;
				array[1] = string.Concat(new string[]
				{
					SecurityKey.KeysClient1,
					Data.SPL_SOCKET,
					reso.domen,
					".files",
					Data.SPL_SOCKET,
					"method",
					Data.SPL_SOCKET,
					SecurityKey.resultClient,
					Data.SPL_SOCKET,
					"save",
					Data.SPL_DATA,
					this.path,
					Data.SPL_DATA,
					this.EditText.Text
				});
				array[2] = Codes.Encoding().GetBytes("null");
				array2 = array;
				array[3] = this.classClient;
			}
			else
			{
				object[] array3 = new object[4];
				array3[0] = this.Client;
				array3[1] = string.Concat(new string[]
				{
					SecurityKey.KeysClient1,
					Data.SPL_SOCKET,
					reso.domen,
					".files",
					Data.SPL_SOCKET,
					"method",
					Data.SPL_SOCKET,
					SecurityKey.resultClient,
					Data.SPL_SOCKET,
					"empty",
					Data.SPL_DATA,
					this.path
				});
				array3[2] = Codes.Encoding().GetBytes("null");
				array2 = array3;
				array3[3] = this.classClient;
			}
			object[] parametersObjects = array2;
			this.classClient.SendMessage(parametersObjects);
			base.Close();
		}
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x00002CFB File Offset: 0x00000EFB
	private void CutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.EditText.Cut();
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x00002D08 File Offset: 0x00000F08
	private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.EditText.Copy();
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x00002D15 File Offset: 0x00000F15
	private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.EditText.Paste();
	}

	// Token: 0x04000734 RID: 1844
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EditText")]
	private RichTextBox _EditText;

	// Token: 0x04000735 RID: 1845
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b_ok")]
	private Button _b_ok;

	// Token: 0x04000736 RID: 1846
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	// Token: 0x04000737 RID: 1847
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CutToolStripMenuItem")]
	private ToolStripMenuItem _CutToolStripMenuItem;

	// Token: 0x04000738 RID: 1848
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CopyToolStripMenuItem")]
	private ToolStripMenuItem _CopyToolStripMenuItem;

	// Token: 0x04000739 RID: 1849
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PasteToolStripMenuItem")]
	private ToolStripMenuItem _PasteToolStripMenuItem;

	// Token: 0x0400073A RID: 1850
	public TcpClient Client;

	// Token: 0x0400073B RID: 1851
	public Client classClient;

	// Token: 0x0400073C RID: 1852
	public bool status;

	// Token: 0x0400073D RID: 1853
	public string path;

	// Token: 0x0400073E RID: 1854
	public string Title;
}
