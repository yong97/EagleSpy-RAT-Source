using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

// Token: 0x02000015 RID: 21
public partial class ApkBuilder : Form
{
	// Token: 0x06000129 RID: 297 RVA: 0x0000210D File Offset: 0x0000030D
	public ApkBuilder()
	{
		this.InitializeComponent();
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00006F0C File Offset: 0x0000510C
	public bool IsJavaInstalled()
	{
		bool result;
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo("java", "-version");
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			using (Process process = new Process())
			{
				process.StartInfo = processStartInfo;
				process.Start();
				string text = process.StandardOutput.ReadToEnd();
				string text2 = process.StandardError.ReadToEnd();
				result = (text.Contains("java version") || text2.Contains("java version"));
			}
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00006FC0 File Offset: 0x000051C0
	public object Trytodeletfiles()
	{
		string path = Path.Combine(Application.StartupPath, "Tools");
		string path2 = Path.Combine(path, "Android");
		string path3 = Path.Combine(path, "Build_unsigned.apk");
		string path4 = Path.Combine(path, "Aligned.apk");
		if (Directory.Exists(path2))
		{
			Directory.Delete(path2, true);
		}
		if (File.Exists(path3))
		{
			File.Delete(path3);
		}
		if (File.Exists(path4))
		{
			File.Delete(path4);
		}
		return null;
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00007034 File Offset: 0x00005234
	[DebuggerStepThrough]
	public Task DecompileApk()
	{
		ApkBuilder.<DecompileApk>d__3 <DecompileApk>d__ = new ApkBuilder.<DecompileApk>d__3();
		<DecompileApk>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
		<DecompileApk>d__.<>4__this = this;
		<DecompileApk>d__.<>1__state = -1;
		<DecompileApk>d__.<>t__builder.Start<ApkBuilder.<DecompileApk>d__3>(ref <DecompileApk>d__);
		return <DecompileApk>d__.<>t__builder.Task;
	}

	// Token: 0x0600012D RID: 301 RVA: 0x0000707C File Offset: 0x0000527C
	[DebuggerStepThrough]
	public Task CompiledApk()
	{
		ApkBuilder.<CompiledApk>d__4 <CompiledApk>d__ = new ApkBuilder.<CompiledApk>d__4();
		<CompiledApk>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
		<CompiledApk>d__.<>4__this = this;
		<CompiledApk>d__.<>1__state = -1;
		<CompiledApk>d__.<>t__builder.Start<ApkBuilder.<CompiledApk>d__4>(ref <CompiledApk>d__);
		return <CompiledApk>d__.<>t__builder.Task;
	}

	// Token: 0x0600012E RID: 302 RVA: 0x000070C4 File Offset: 0x000052C4
	[DebuggerStepThrough]
	private Task ExecuteCommandAsync(string command)
	{
		ApkBuilder.<ExecuteCommandAsync>d__5 <ExecuteCommandAsync>d__ = new ApkBuilder.<ExecuteCommandAsync>d__5();
		<ExecuteCommandAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
		<ExecuteCommandAsync>d__.<>4__this = this;
		<ExecuteCommandAsync>d__.command = command;
		<ExecuteCommandAsync>d__.<>1__state = -1;
		<ExecuteCommandAsync>d__.<>t__builder.Start<ApkBuilder.<ExecuteCommandAsync>d__5>(ref <ExecuteCommandAsync>d__);
		return <ExecuteCommandAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00007114 File Offset: 0x00005314
	private void OutputHandler(object sender, DataReceivedEventArgs e)
	{
		if (e.Data != null)
		{
			this.AppendTextToRichTextBox(e.Data);
		}
	}

	// Token: 0x06000130 RID: 304 RVA: 0x0000713C File Offset: 0x0000533C
	private void AppendTextToRichTextBox(string text)
	{
		if (base.InvokeRequired)
		{
			base.Invoke(new Action<string>(this.AppendTextToRichTextBox), new object[]
			{
				text
			});
		}
		else
		{
			this.RichTextBox1.AppendText(text + "\r\n");
			this.RichTextBox1.ScrollToCaret();
		}
	}

	// Token: 0x06000131 RID: 305 RVA: 0x00007194 File Offset: 0x00005394
	private void SButton1_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Title = "Select PNG Image File";
		openFileDialog.Filter = "PNG Files (*.png)|*.png";
		openFileDialog.FilterIndex = 1;
		openFileDialog.RestoreDirectory = true;
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			string fileName = openFileDialog.FileName;
			try
			{
				if (Path.GetExtension(fileName).ToLower() != ".png")
				{
					MessageBox.Show("Please select a PNG image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					this.PictureBox1.Image = Image.FromFile(fileName);
				}
			}
			catch (Exception)
			{
				this.AppendTextToRichTextBox("Error loading icon");
			}
		}
	}

	// Token: 0x06000132 RID: 306 RVA: 0x0000723C File Offset: 0x0000543C
	private void Guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
	{
		List<Tuple<string, string, string>> list = new List<Tuple<string, string, string>>();
		if (this.Guna2ToggleSwitch1.Checked)
		{
			list.Add(Tuple.Create<string, string, string>("LAUNCHER", "INFO", "Tools\\Android\\AndroidManifest.xml"));
		}
		else
		{
			list.Add(Tuple.Create<string, string, string>("INFO", "LAUNCHER", "Tools\\Android\\AndroidManifest.xml"));
		}
	}

	// Token: 0x06000133 RID: 307 RVA: 0x00007294 File Offset: 0x00005494
	private void BuildApkButton_Click(object sender, EventArgs e)
	{
		ApkBuilder.<BuildApkButton_Click>d__0 <BuildApkButton_Click>d__;
		<BuildApkButton_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		<BuildApkButton_Click>d__.<>4__this = this;
		<BuildApkButton_Click>d__.<>1__state = -1;
		<BuildApkButton_Click>d__.<>t__builder.Start<ApkBuilder.<BuildApkButton_Click>d__0>(ref <BuildApkButton_Click>d__);
	}

	// Token: 0x06000134 RID: 308 RVA: 0x000072CC File Offset: 0x000054CC
	private void SButton2_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Title = "Select PNG Image File";
		openFileDialog.Filter = "PNG Files (*.png)|*.png";
		openFileDialog.FilterIndex = 1;
		openFileDialog.RestoreDirectory = true;
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			string fileName = openFileDialog.FileName;
			try
			{
				if (Path.GetExtension(fileName).ToLower() != ".png")
				{
					MessageBox.Show("Please select a PNG image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					this.PictureBox2.Image = Image.FromFile(fileName);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
	}

	// Token: 0x06000135 RID: 309 RVA: 0x00007388 File Offset: 0x00005588
	private void FindAndReplaceInFile(string filePath, string oldText, string newText)
	{
		try
		{
			string text = File.ReadAllText(filePath);
			text = text.Replace(oldText, newText);
			File.WriteAllText(filePath, text);
		}
		catch (Exception ex)
		{
			MessageBox.Show("Error processing file: " + filePath + Environment.NewLine + ex.Message);
		}
	}

	// Token: 0x06000136 RID: 310 RVA: 0x000073E0 File Offset: 0x000055E0
	private void UpdateIPAddressLabels()
	{
		IPAddress[] ipv4Addresses = this.GetIPv4Addresses();
		if (ipv4Addresses != null && ipv4Addresses.Length != 0)
		{
			this.TextBox2.Text = string.Join(", ", from ip in ipv4Addresses
			select ip.ToString());
		}
		else
		{
			this.TextBox2.Text = "127.0.0.1";
		}
	}

	// Token: 0x06000137 RID: 311 RVA: 0x00007450 File Offset: 0x00005650
	private IPAddress[] GetIPv4Addresses()
	{
		List<IPAddress> list = new List<IPAddress>();
		try
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			foreach (NetworkInterface networkInterface in allNetworkInterfaces)
			{
				if (networkInterface.OperationalStatus == OperationalStatus.Up && networkInterface.NetworkInterfaceType != NetworkInterfaceType.Loopback)
				{
					IPInterfaceProperties ipproperties = networkInterface.GetIPProperties();
					foreach (UnicastIPAddressInformation unicastIPAddressInformation in ipproperties.UnicastAddresses)
					{
						if (unicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
						{
							list.Add(unicastIPAddressInformation.Address);
						}
					}
				}
			}
		}
		catch (Exception)
		{
		}
		return list.ToArray();
	}

	// Token: 0x06000138 RID: 312 RVA: 0x00002122 File Offset: 0x00000322
	private void ApkBuilder_Load(object sender, EventArgs e)
	{
		this.UpdateIPAddressLabels();
	}

	// Token: 0x06000139 RID: 313 RVA: 0x0000212A File Offset: 0x0000032A
	private void Guna2GradientButton2_Click(object sender, EventArgs e)
	{
		MessageBox.Show("Currently in maintenance");
	}
}
