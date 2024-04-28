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

// Token: 0x02000056 RID: 86
[DesignerGenerated]
public partial class Eaglepopup : Form
{
	// Token: 0x060003B4 RID: 948 RVA: 0x0000295D File Offset: 0x00000B5D
	public Eaglepopup()
	{
		base.Load += this.Craxsnotification_Load;
		base.Deactivate += this.Craxsnotification_Deactivate;
		this.InitializeComponent();
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x00056300 File Offset: 0x00054500
	private void Craxsnotification_Load(object sender, EventArgs e)
	{
		base.Location = new Point(checked(Cursor.Position.X - 79), Cursor.Position.Y);
		this.BackColor = Color.DarkRed;
		base.TransparencyKey = Color.DarkRed;
		if (this.ClassClient != null)
		{
			if (this.ClassClient.Notifications.Count<string>() > 0)
			{
				this.notifitext.Text = "Notifications Reader...\r\n";
				string[] notifications = this.ClassClient.Notifications;
				foreach (string text in notifications)
				{
					try
					{
						if (text != null && text.Length > 0)
						{
							TextBox textBox;
							(textBox = this.notifitext).Text = textBox.Text + text + "\r\n--------------------";
						}
					}
					catch (Exception)
					{
					}
				}
			}
			else
			{
				TextBox textBox2 = this.notifitext;
				textBox2.Text += "No Notifications ...";
			}
		}
		this.ClassClient.isnewnotifi = false;
	}

	// Token: 0x060003B6 RID: 950 RVA: 0x0000206C File Offset: 0x0000026C
	private void DrakeUIButton1_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060003B7 RID: 951 RVA: 0x00002858 File Offset: 0x00000A58
	private void Craxsnotification_Deactivate(object sender, EventArgs e)
	{
		base.Close();
	}

	// Token: 0x060003B8 RID: 952 RVA: 0x0000298F File Offset: 0x00000B8F
	private void Checkbutton_Click(object sender, EventArgs e)
	{
		this.notifitext.Text = "";
		this.ClassClient.Notifications = new string[251];
		base.Close();
	}

	// Token: 0x060003B9 RID: 953 RVA: 0x00002858 File Offset: 0x00000A58
	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	// Token: 0x060003BA RID: 954 RVA: 0x0005641C File Offset: 0x0005461C
	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.notifitext.Text))
		{
			EagleAlert.Showinformation("No log found to save");
		}
		else
		{
			try
			{
				if (!Directory.Exists(this.ClassClient.FolderUSER + "\\Notificatios"))
				{
					Directory.CreateDirectory(this.ClassClient.FolderUSER + "\\Notificatios");
				}
				string text = DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".txt";
				if (!File.Exists(this.ClassClient.FolderUSER + "\\Notificatios\\" + text))
				{
					File.Create(this.ClassClient.FolderUSER + "\\Notificatios\\" + text).Dispose();
					File.AppendAllText(this.ClassClient.FolderUSER + "\\Notificatios\\" + text, string.Concat(new string[]
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
				File.AppendAllText(this.ClassClient.FolderUSER + "\\Notificatios\\" + text, text + this.notifitext.Text + "\r\n");
				Process.Start(this.ClassClient.FolderUSER + "\\Notificatios");
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0400042A RID: 1066
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkbutton")]
	private DrakeUIButtonIcon _checkbutton;

	// Token: 0x0400042B RID: 1067
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	// Token: 0x0400042C RID: 1068
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	// Token: 0x0400042D RID: 1069
	public Client ClassClient;
}
