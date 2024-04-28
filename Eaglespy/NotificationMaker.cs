using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200009A RID: 154
[DesignerGenerated]
public partial class NotificationMaker : Form
{
	// Token: 0x060006B9 RID: 1721 RVA: 0x000A8AC4 File Offset: 0x000A6CC4
	public NotificationMaker(List<Client> L)
	{
		base.Load += this.NotificationMaker_Load;
		this.listclients = new List<Client>();
		this.SelectedList = new List<Client>();
		this.type = "0";
		this.Openthis = "null";
		this.InitializeComponent();
		this.listclients = L;
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x000A8B24 File Offset: 0x000A6D24
	private void translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", false) != 0)
		{
			if (Operators.CompareString(language, "CN", false) == 0)
			{
				this.Label1.Text = Codes.Translate(this.Label1.Text, "en", "zh");
				this.Label2.Text = Codes.Translate(this.Label2.Text, "en", "zh");
				this.Label3.Text = Codes.Translate(this.Label3.Text, "en", "zh");
				this.Label4.Text = Codes.Translate(this.Label4.Text, "en", "zh");
				this.checkusrcraxs.Text = "使用craxs浏览器";
			}
		}
		else
		{
			this.Label1.Text = Codes.Translate(this.Label1.Text, "en", "ar");
			this.Label2.Text = Codes.Translate(this.Label2.Text, "en", "ar");
			this.Label3.Text = Codes.Translate(this.Label3.Text, "en", "ar");
			this.Label4.Text = Codes.Translate(this.Label4.Text, "en", "ar");
			this.checkusrcraxs.Text = "استخدم متصفح craxs";
		}
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x000A8CAC File Offset: 0x000A6EAC
	private void NotificationMaker_Load(object sender, EventArgs e)
	{
		if (this.listclients.Count > 0)
		{
			foreach (Client client in this.listclients)
			{
				int index = this.DGVC.Rows.Add(new object[]
				{
					true,
					client.Wallpaper,
					client.ClientName
				});
				this.DGVC.Rows[index].Tag = client;
			}
		}
		this.typecomp.Text = "Nothing";
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x00003367 File Offset: 0x00001567
	private void Label35_Click(object sender, EventArgs e)
	{
		Interaction.MsgBox("what happen after user click the notification ?", MsgBoxStyle.OkOnly, null);
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x000A8D68 File Offset: 0x000A6F68
	private void Actonscompo_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(this.typecomp.Text, "Nothing", false) == 0)
		{
			this.TAlabel.Enabled = false;
			this.TAlabel.Visible = false;
			this.toopentext.Enabled = false;
			this.toopentext.Visible = false;
			this.toopentext.Text = "";
			this.TAlabel.Text = "";
			this.checkusrcraxs.Checked = false;
			this.checkusrcraxs.Enabled = false;
			this.checkusrcraxs.Visible = false;
		}
		else if (Operators.CompareString(this.typecomp.Text, "Open Apk", false) == 0)
		{
			this.TAlabel.Enabled = true;
			this.TAlabel.Visible = true;
			this.toopentext.Enabled = true;
			this.toopentext.Visible = true;
			this.toopentext.Text = "";
			this.toopentext.Watermark = "com.whatsapp";
			this.TAlabel.Text = "App ID";
			this.checkusrcraxs.Checked = false;
			this.checkusrcraxs.Enabled = false;
			this.checkusrcraxs.Visible = false;
		}
		else if (Operators.CompareString(this.typecomp.Text, "Open Link", false) == 0)
		{
			this.TAlabel.Enabled = true;
			this.TAlabel.Visible = true;
			this.toopentext.Enabled = true;
			this.toopentext.Visible = true;
			this.toopentext.Text = "";
			this.toopentext.Watermark = "www.whatsapp.com";
			this.TAlabel.Text = "Website Link";
			this.checkusrcraxs.Checked = true;
			this.checkusrcraxs.Enabled = true;
			this.checkusrcraxs.Visible = true;
		}
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x000A8F54 File Offset: 0x000A7154
	private void DrakeUIAvatar1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(this.typecomp.Text, "Nothing", false) == 0)
		{
			this.type = "0";
			this.Openthis = "null";
		}
		else if (Operators.CompareString(this.typecomp.Text, "Open Apk", false) == 0)
		{
			if (!Codes.IsValidPackageName(this.toopentext.Text))
			{
				EagleAlert.ShowWarning("Invalid APK package name");
				return;
			}
			this.type = "1";
			this.Openthis = this.toopentext.Text;
		}
		else if (Operators.CompareString(this.typecomp.Text, "Open Link", false) == 0)
		{
			this.type = "2";
			this.Openthis = this.toopentext.Text;
		}
		if (this.DGVC.Rows.Count > 0)
		{
			foreach (object obj in ((IEnumerable)this.DGVC.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				try
				{
					this.SelectedList.Add((Client)dataGridViewRow.Tag);
				}
				catch (Exception)
				{
				}
			}
		}
		base.DialogResult = DialogResult.OK;
		base.Close();
	}

	// Token: 0x040009CA RID: 2506
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar1")]
	private DrakeUIAvatar _DrakeUIAvatar1;

	// Token: 0x040009CB RID: 2507
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label35")]
	private Label _Label35;

	// Token: 0x040009CC RID: 2508
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("typecomp")]
	private DrakeUIComboBox _typecomp;

	// Token: 0x040009CD RID: 2509
	public List<Client> listclients;

	// Token: 0x040009CE RID: 2510
	public List<Client> SelectedList;

	// Token: 0x040009CF RID: 2511
	public string type;

	// Token: 0x040009D0 RID: 2512
	public string Openthis;
}
