using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DrakeUI.Framework;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using Sipaa.Framework;

// Token: 0x020000A1 RID: 161
[DesignerGenerated]
public partial class Ports : Form
{
	// Token: 0x060006DE RID: 1758 RVA: 0x0000206C File Offset: 0x0000026C
	private void ShowResponse(string type)
	{
	}

	// Token: 0x060006E1 RID: 1761 RVA: 0x000ADD10 File Offset: 0x000ABF10
	public Ports()
	{
		base.FormClosing += this.Ports_FormClosing;
		this.r = null;
		this.Ping_Json = "Ping";
		this.Check_Json = "Check";
		this.Checkv2_Json = "Checkv2";
		this.Session = "Session";
		this.IDC_Json = "IDC";
		this.Secritkey = "YS5pW5qXMuYnTPNbpkhLx5mYY4vwQn9x";
		this.holder = "...";
		this.index = 0;
		this.Finish = false;
		this.S = false;
		this.InitializeComponent();
		this.Font = reso.f;
	}

	// Token: 0x060006E2 RID: 1762 RVA: 0x000ADDB0 File Offset: 0x000ABFB0
	[DebuggerStepThrough]
	private void FadeIn(Form o, int interval = 80)
	{
		Ports.VB_0024StateMachine_114_FadeIn vb_0024StateMachine_114_FadeIn = new Ports.VB_0024StateMachine_114_FadeIn();
		vb_0024StateMachine_114_FadeIn._0024VB_0024Me = this;
		vb_0024StateMachine_114_FadeIn._0024VB_0024Local_o = o;
		vb_0024StateMachine_114_FadeIn._0024VB_0024Local_interval = interval;
		vb_0024StateMachine_114_FadeIn._0024State = -1;
		vb_0024StateMachine_114_FadeIn._0024Builder = AsyncVoidMethodBuilder.Create();
		vb_0024StateMachine_114_FadeIn._0024Builder.Start<Ports.VB_0024StateMachine_114_FadeIn>(ref vb_0024StateMachine_114_FadeIn);
	}

	// Token: 0x060006E3 RID: 1763
	[DllImport("Kernel32.dll")]
	public static extern IntPtr GetCurrentThread();

	// Token: 0x060006E4 RID: 1764 RVA: 0x000ADDFC File Offset: 0x000ABFFC
	public void opebbtn(object[] objs)
	{
		if (this.Login.InvokeRequired)
		{
			Ports.opebbtndele method = new Ports.opebbtndele(this.opebbtn);
			this.Login.Invoke(method, new object[]
			{
				objs
			});
		}
		else
		{
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) != 0)
			{
				if (Operators.CompareString(language, "CN", false) != 0)
				{
					this.Login.Text = Codes.AES_Decrypt("Jyew2tI1udg4ZJM+uI+ywA==", "Accept");
				}
				else
				{
					this.Login.Text = "登录";
				}
			}
			else
			{
				this.Login.Text = "دخول";
			}
		}
	}

	// Token: 0x060006E5 RID: 1765 RVA: 0x000ADEA4 File Offset: 0x000AC0A4
	public object RandomString()
	{
		if (this.r == null)
		{
			this.r = new Random();
		}
		string text = "abcdefghijklmnopqrstuvwxyz";
		StringBuilder stringBuilder = new StringBuilder();
		int num = 32;
		checked
		{
			for (int i = 1; i <= num; i++)
			{
				int startIndex = this.r.Next(0, text.Length);
				stringBuilder.Append(text.Substring(startIndex, 1));
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x060006E6 RID: 1766 RVA: 0x000ADF1C File Offset: 0x000AC11C
	public string DecryptRJ256(string prm_key, string prm_iv, string prm_text_to_decrypt)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(prm_key);
		byte[] bytes2 = Encoding.ASCII.GetBytes(prm_iv);
		byte[] array2;
		using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
		{
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			ICryptoTransform transform = rijndaelManaged.CreateDecryptor(bytes, bytes2);
			byte[] array = Convert.FromBase64String(prm_text_to_decrypt);
			array2 = new byte[checked(array.Length - 1 + 1)];
			MemoryStream stream = new MemoryStream(array);
			CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
			cryptoStream.Read(array2, 0, array2.Length);
		}
		return Encoding.ASCII.GetString(array2);
	}

	// Token: 0x060006E7 RID: 1767 RVA: 0x000ADFD8 File Offset: 0x000AC1D8
	public string EncryptRJ256(string prm_key, string prm_iv, string prm_text_to_encrypt)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(prm_key);
		byte[] bytes2 = Encoding.ASCII.GetBytes(prm_iv);
		byte[] inArray;
		using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
		{
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			ICryptoTransform transform = rijndaelManaged.CreateEncryptor(bytes, bytes2);
			byte[] bytes3 = Encoding.ASCII.GetBytes(prm_text_to_encrypt);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(bytes3, 0, bytes3.Length);
			cryptoStream.FlushFinalBlock();
			inArray = memoryStream.ToArray();
		}
		return Convert.ToBase64String(inArray);
	}

	// Token: 0x060006E8 RID: 1768 RVA: 0x000AE094 File Offset: 0x000AC294
	public string KeepOnlyEnglishLetters(string input)
	{
		string pattern = "[^a-zA-Z]";
		return Regex.Replace(input, pattern, "");
	}

	// Token: 0x060006E9 RID: 1769 RVA: 0x0000206C File Offset: 0x0000026C
	private void pnl1_Paint(object sender, PaintEventArgs e)
	{
	}

	// Token: 0x060006EA RID: 1770 RVA: 0x00002C11 File Offset: 0x00000E11
	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.No;
		base.Close();
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x0000206C File Offset: 0x0000026C
	private void Addpo_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x0000206C File Offset: 0x0000026C
	private void Rempo_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060006ED RID: 1773 RVA: 0x00003403 File Offset: 0x00001603
	private void DrakeUILinkLabel1_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Dialog2.ShowDialog();
	}

	// Token: 0x060006EE RID: 1774 RVA: 0x0000206C File Offset: 0x0000026C
	private void Button1_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x00059674 File Offset: 0x00057874
	private void Pnl1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x0000206C File Offset: 0x0000026C
	private void PictureBox3_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x000AE0B8 File Offset: 0x000AC2B8
	private void PictureBox3_Click_1(object sender, EventArgs e)
	{
		try
		{
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x0000206C File Offset: 0x0000026C
	private void Ports_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x0000206C File Offset: 0x0000026C
	private void Statuslabel_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x00059674 File Offset: 0x00057874
	private void Label1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x00059674 File Offset: 0x00057874
	private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x00059674 File Offset: 0x00057874
	private void Panel3_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x0000206C File Offset: 0x0000026C
	private void Porttext_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x0000206C File Offset: 0x0000026C
	private void Porttext_TextChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x00059674 File Offset: 0x00057874
	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x00002C11 File Offset: 0x00000E11
	private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.No;
		base.Close();
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00059674 File Offset: 0x00057874
	private void PictureBox1_MouseDown_1(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x00003415 File Offset: 0x00001615
	private void Loginworker_DoWork(object sender, DoWorkEventArgs e)
	{
		this.Finish = true;
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x0000341E File Offset: 0x0000161E
	private void PictureBox2_Click(object sender, EventArgs e)
	{
		Environment.Exit(0);
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x000AE0DC File Offset: 0x000AC2DC
	public static bool SubExist(string name)
	{
		return true;
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x0000206C File Offset: 0x0000026C
	private void Ports_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x000AE0EC File Offset: 0x000AC2EC
	private static string random_string()
	{
		string text = null;
		Random random = new Random();
		for (int i = 0; i < 5; i++)
		{
			text += Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0))).ToString();
		}
		return text;
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x00002226 File Offset: 0x00000426
	private void Login_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x000AE150 File Offset: 0x000AC350
	private void KeyAuthRegister_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x0000206C File Offset: 0x0000026C
	private void Ports_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x06000704 RID: 1796 RVA: 0x00059674 File Offset: 0x00057874
	private void Guna2PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	// Token: 0x04000A24 RID: 2596
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("pnl1")]
	private Panel _pnl1;

	// Token: 0x04000A25 RID: 2597
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("loginbtn")]
	private DrakeUIButtonIcon _loginbtn;

	// Token: 0x04000A26 RID: 2598
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	// Token: 0x04000A27 RID: 2599
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("policylink")]
	private DrakeUILinkLabel _policylink;

	// Token: 0x04000A28 RID: 2600
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("usrkeytext")]
	private DrakeUITextBox _usrkeytext;

	// Token: 0x04000A29 RID: 2601
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	// Token: 0x04000A2A RID: 2602
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("statuslabel")]
	private Label _statuslabel;

	// Token: 0x04000A2B RID: 2603
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("changeidlabel")]
	private DrakeUILinkLabel _changeidlabel;

	// Token: 0x04000A2C RID: 2604
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("qutelabel")]
	private Label _qutelabel;

	// Token: 0x04000A2D RID: 2605
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("exitbtn")]
	private DrakeUIButtonIcon _exitbtn;

	// Token: 0x04000A2E RID: 2606
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUILinkLabel1")]
	private DrakeUILinkLabel _DrakeUILinkLabel1;

	// Token: 0x04000A2F RID: 2607
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	// Token: 0x04000A30 RID: 2608
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("loginworker")]
	private BackgroundWorker _loginworker;

	// Token: 0x04000A31 RID: 2609
	private Random r;

	// Token: 0x04000A32 RID: 2610
	public string Ping_Json;

	// Token: 0x04000A33 RID: 2611
	public string Check_Json;

	// Token: 0x04000A34 RID: 2612
	public string Checkv2_Json;

	// Token: 0x04000A35 RID: 2613
	public string Session;

	// Token: 0x04000A36 RID: 2614
	public string IDC_Json;

	// Token: 0x04000A37 RID: 2615
	public string Secritkey;

	// Token: 0x04000A38 RID: 2616
	private string holder;

	// Token: 0x04000A39 RID: 2617
	private int index;

	// Token: 0x04000A3A RID: 2618
	public bool Finish;

	// Token: 0x04000A3B RID: 2619
	public bool S;

	// Token: 0x020000A2 RID: 162
	// (Invoke) Token: 0x06000707 RID: 1799
	public delegate void addLogback(object[] objs);

	// Token: 0x020000A3 RID: 163
	// (Invoke) Token: 0x0600070B RID: 1803
	public delegate void opebbtndele(object[] objs);
}
