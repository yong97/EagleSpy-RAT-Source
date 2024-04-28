// Token: 0x02000026 RID: 38
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class Apk_studio : global::System.Windows.Forms.Form
{
	// Token: 0x0600018B RID: 395 RVA: 0x0000E8CC File Offset: 0x0000CACC
	[global::System.Diagnostics.DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	// Token: 0x0600018C RID: 396 RVA: 0x0000E910 File Offset: 0x0000CB10
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.toppanel = new global::System.Windows.Forms.Panel();
		this.Label2 = new global::System.Windows.Forms.Label();
		this.workdirtext = new global::DrakeUI.Framework.DrakeUITextBox();
		this.selectapkbtn = new global::System.Windows.Forms.Button();
		this.TargetApktext = new global::DrakeUI.Framework.DrakeUITextBox();
		this.workpanel = new global::System.Windows.Forms.Panel();
		this.Panel1 = new global::System.Windows.Forms.Panel();
		this.logtext = new global::System.Windows.Forms.RichTextBox();
		this.probtn = new global::System.Windows.Forms.Button();
		this.cobtn = new global::System.Windows.Forms.Button();
		this.sinbtn = new global::System.Windows.Forms.Button();
		this.titlespanel = new global::System.Windows.Forms.Panel();
		this.andtotext = new global::System.Windows.Forms.Label();
		this.andfromtext = new global::System.Windows.Forms.Label();
		this.vernamtext = new global::System.Windows.Forms.Label();
		this.vercodtext = new global::System.Windows.Forms.Label();
		this.pkgtext = new global::System.Windows.Forms.Label();
		this.nametext = new global::System.Windows.Forms.Label();
		this.debtn = new global::System.Windows.Forms.Button();
		this.savebtn = new global::System.Windows.Forms.Button();
		this.apkicon = new global::System.Windows.Forms.PictureBox();
		this.BackgroundWorker1 = new global::System.ComponentModel.BackgroundWorker();
		this.Label1 = new global::System.Windows.Forms.Label();
		this.protectworker = new global::System.ComponentModel.BackgroundWorker();
		this.deworker = new global::System.ComponentModel.BackgroundWorker();
		this.COworker = new global::System.ComponentModel.BackgroundWorker();
		this.toppanel.SuspendLayout();
		this.workpanel.SuspendLayout();
		this.Panel1.SuspendLayout();
		this.titlespanel.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.apkicon).BeginInit();
		base.SuspendLayout();
		this.toppanel.Controls.Add(this.Label2);
		this.toppanel.Controls.Add(this.workdirtext);
		this.toppanel.Controls.Add(this.selectapkbtn);
		this.toppanel.Controls.Add(this.TargetApktext);
		this.toppanel.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.toppanel.Location = new global::System.Drawing.Point(0, 16);
		this.toppanel.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.toppanel.Name = "toppanel";
		this.toppanel.Size = new global::System.Drawing.Size(572, 95);
		this.toppanel.TabIndex = 0;
		this.Label2.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.Label2.Location = new global::System.Drawing.Point(452, 54);
		this.Label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.Label2.Name = "Label2";
		this.Label2.Size = new global::System.Drawing.Size(107, 26);
		this.Label2.TabIndex = 47;
		this.Label2.Text = "Work DIR";
		this.Label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.workdirtext.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.workdirtext.Enabled = false;
		this.workdirtext.FillColor = global::System.Drawing.Color.Black;
		this.workdirtext.FillDisableColor = global::System.Drawing.Color.Black;
		this.workdirtext.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.workdirtext.ForeColor = global::System.Drawing.Color.White;
		this.workdirtext.ForeDisableColor = global::System.Drawing.Color.White;
		this.workdirtext.Location = new global::System.Drawing.Point(4, 54);
		this.workdirtext.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
		this.workdirtext.Maximum = 2147483647.0;
		this.workdirtext.Minimum = -2147483648.0;
		this.workdirtext.Name = "workdirtext";
		this.workdirtext.Padding = new global::System.Windows.Forms.Padding(5, 5, 5, 5);
		this.workdirtext.Radius = 10;
		this.workdirtext.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.workdirtext.RectDisableColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.workdirtext.Size = new global::System.Drawing.Size(442, 27);
		this.workdirtext.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.workdirtext.StyleCustomMode = true;
		this.workdirtext.TabIndex = 46;
		this.workdirtext.TextAlignment = global::System.Drawing.ContentAlignment.TopLeft;
		this.workdirtext.Watermark = "Target Apk";
		this.selectapkbtn.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
		this.selectapkbtn.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
		this.selectapkbtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.selectapkbtn.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.selectapkbtn.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.selectapkbtn.Location = new global::System.Drawing.Point(452, 18);
		this.selectapkbtn.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.selectapkbtn.Name = "selectapkbtn";
		this.selectapkbtn.Size = new global::System.Drawing.Size(110, 26);
		this.selectapkbtn.TabIndex = 45;
		this.selectapkbtn.Text = "Select APK";
		this.selectapkbtn.UseVisualStyleBackColor = true;
		this.selectapkbtn.Click += new global::System.EventHandler(this.Selectapkbtn_Click);
		this.TargetApktext.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.TargetApktext.Enabled = false;
		this.TargetApktext.FillColor = global::System.Drawing.Color.Black;
		this.TargetApktext.FillDisableColor = global::System.Drawing.Color.Black;
		this.TargetApktext.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.TargetApktext.ForeColor = global::System.Drawing.Color.White;
		this.TargetApktext.ForeDisableColor = global::System.Drawing.Color.White;
		this.TargetApktext.Location = new global::System.Drawing.Point(4, 18);
		this.TargetApktext.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
		this.TargetApktext.Maximum = 2147483647.0;
		this.TargetApktext.Minimum = -2147483648.0;
		this.TargetApktext.Name = "TargetApktext";
		this.TargetApktext.Padding = new global::System.Windows.Forms.Padding(5, 5, 5, 5);
		this.TargetApktext.Radius = 10;
		this.TargetApktext.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.TargetApktext.RectDisableColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.TargetApktext.Size = new global::System.Drawing.Size(442, 27);
		this.TargetApktext.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.TargetApktext.StyleCustomMode = true;
		this.TargetApktext.TabIndex = 44;
		this.TargetApktext.TextAlignment = global::System.Drawing.ContentAlignment.TopLeft;
		this.TargetApktext.Watermark = "Target Apk";
		this.TargetApktext.TextChanged += new global::System.EventHandler(this.TargetApktext_TextChanged);
		this.workpanel.Controls.Add(this.Panel1);
		this.workpanel.Controls.Add(this.probtn);
		this.workpanel.Controls.Add(this.cobtn);
		this.workpanel.Controls.Add(this.sinbtn);
		this.workpanel.Controls.Add(this.titlespanel);
		this.workpanel.Controls.Add(this.debtn);
		this.workpanel.Controls.Add(this.savebtn);
		this.workpanel.Controls.Add(this.apkicon);
		this.workpanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.workpanel.Location = new global::System.Drawing.Point(0, 111);
		this.workpanel.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.workpanel.Name = "workpanel";
		this.workpanel.Size = new global::System.Drawing.Size(572, 400);
		this.workpanel.TabIndex = 1;
		this.Panel1.Controls.Add(this.logtext);
		this.Panel1.Location = new global::System.Drawing.Point(12, 285);
		this.Panel1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new global::System.Drawing.Size(548, 105);
		this.Panel1.TabIndex = 54;
		this.logtext.BackColor = global::System.Drawing.Color.Black;
		this.logtext.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
		this.logtext.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.logtext.Font = new global::System.Drawing.Font("Calibri", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.logtext.ForeColor = global::System.Drawing.Color.Lime;
		this.logtext.Location = new global::System.Drawing.Point(0, 0);
		this.logtext.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.logtext.Name = "logtext";
		this.logtext.ReadOnly = true;
		this.logtext.Size = new global::System.Drawing.Size(548, 105);
		this.logtext.TabIndex = 0;
		this.logtext.Text = "";
		this.probtn.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
		this.probtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.probtn.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
		this.probtn.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
		this.probtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.probtn.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.probtn.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.probtn.Location = new global::System.Drawing.Point(465, 12);
		this.probtn.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.probtn.Name = "probtn";
		this.probtn.Size = new global::System.Drawing.Size(94, 109);
		this.probtn.TabIndex = 53;
		this.probtn.Text = "Protect APK";
		this.probtn.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
		this.probtn.UseVisualStyleBackColor = true;
		this.probtn.Click += new global::System.EventHandler(this.Button5_Click);
		this.cobtn.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
		this.cobtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.cobtn.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
		this.cobtn.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
		this.cobtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.cobtn.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.cobtn.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.cobtn.Location = new global::System.Drawing.Point(238, 12);
		this.cobtn.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.cobtn.Name = "cobtn";
		this.cobtn.Size = new global::System.Drawing.Size(94, 109);
		this.cobtn.TabIndex = 52;
		this.cobtn.Text = "Compile";
		this.cobtn.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
		this.cobtn.UseVisualStyleBackColor = true;
		this.cobtn.Click += new global::System.EventHandler(this.Button4_Click);
		this.sinbtn.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
		this.sinbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.sinbtn.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
		this.sinbtn.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
		this.sinbtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.sinbtn.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.sinbtn.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.sinbtn.Location = new global::System.Drawing.Point(352, 12);
		this.sinbtn.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.sinbtn.Name = "sinbtn";
		this.sinbtn.Size = new global::System.Drawing.Size(94, 109);
		this.sinbtn.TabIndex = 51;
		this.sinbtn.Text = "Sign APK";
		this.sinbtn.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
		this.sinbtn.UseVisualStyleBackColor = true;
		this.sinbtn.Click += new global::System.EventHandler(this.Button3_Click);
		this.titlespanel.Controls.Add(this.andtotext);
		this.titlespanel.Controls.Add(this.andfromtext);
		this.titlespanel.Controls.Add(this.vernamtext);
		this.titlespanel.Controls.Add(this.vercodtext);
		this.titlespanel.Controls.Add(this.pkgtext);
		this.titlespanel.Controls.Add(this.nametext);
		this.titlespanel.Enabled = false;
		this.titlespanel.Location = new global::System.Drawing.Point(112, 143);
		this.titlespanel.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.titlespanel.Name = "titlespanel";
		this.titlespanel.Size = new global::System.Drawing.Size(450, 125);
		this.titlespanel.TabIndex = 50;
		this.andtotext.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.andtotext.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.andtotext.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.andtotext.Font = new global::System.Drawing.Font("Calibri", 9f);
		this.andtotext.Location = new global::System.Drawing.Point(0, 95);
		this.andtotext.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.andtotext.Name = "andtotext";
		this.andtotext.Size = new global::System.Drawing.Size(450, 19);
		this.andtotext.TabIndex = 53;
		this.andtotext.Text = "Support to:";
		this.andtotext.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.andtotext.Click += new global::System.EventHandler(this.Andtotext_Click);
		this.andfromtext.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.andfromtext.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.andfromtext.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.andfromtext.Font = new global::System.Drawing.Font("Calibri", 9f);
		this.andfromtext.Location = new global::System.Drawing.Point(0, 76);
		this.andfromtext.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.andfromtext.Name = "andfromtext";
		this.andfromtext.Size = new global::System.Drawing.Size(450, 19);
		this.andfromtext.TabIndex = 52;
		this.andfromtext.Text = "Support From:";
		this.andfromtext.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.andfromtext.Click += new global::System.EventHandler(this.Andtotext_Click);
		this.vernamtext.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.vernamtext.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.vernamtext.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.vernamtext.Font = new global::System.Drawing.Font("Calibri", 9f);
		this.vernamtext.Location = new global::System.Drawing.Point(0, 57);
		this.vernamtext.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.vernamtext.Name = "vernamtext";
		this.vernamtext.Size = new global::System.Drawing.Size(450, 19);
		this.vernamtext.TabIndex = 51;
		this.vernamtext.Text = "Version Name:";
		this.vernamtext.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.vernamtext.Click += new global::System.EventHandler(this.Andtotext_Click);
		this.vercodtext.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.vercodtext.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.vercodtext.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.vercodtext.Font = new global::System.Drawing.Font("Calibri", 9f);
		this.vercodtext.Location = new global::System.Drawing.Point(0, 38);
		this.vercodtext.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.vercodtext.Name = "vercodtext";
		this.vercodtext.Size = new global::System.Drawing.Size(450, 19);
		this.vercodtext.TabIndex = 50;
		this.vercodtext.Text = "Version Code:";
		this.vercodtext.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.vercodtext.Click += new global::System.EventHandler(this.Andtotext_Click);
		this.pkgtext.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.pkgtext.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.pkgtext.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.pkgtext.Font = new global::System.Drawing.Font("Calibri", 9f);
		this.pkgtext.Location = new global::System.Drawing.Point(0, 19);
		this.pkgtext.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.pkgtext.Name = "pkgtext";
		this.pkgtext.Size = new global::System.Drawing.Size(450, 19);
		this.pkgtext.TabIndex = 49;
		this.pkgtext.Text = "Package Name:";
		this.pkgtext.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.pkgtext.Click += new global::System.EventHandler(this.Andtotext_Click);
		this.nametext.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.nametext.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.nametext.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.nametext.Font = new global::System.Drawing.Font("Calibri", 9f);
		this.nametext.Location = new global::System.Drawing.Point(0, 0);
		this.nametext.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.nametext.Name = "nametext";
		this.nametext.Size = new global::System.Drawing.Size(450, 19);
		this.nametext.TabIndex = 48;
		this.nametext.Text = "App Name:";
		this.nametext.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.nametext.Click += new global::System.EventHandler(this.Andtotext_Click);
		this.debtn.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
		this.debtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.debtn.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
		this.debtn.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
		this.debtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.debtn.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.debtn.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.debtn.Location = new global::System.Drawing.Point(125, 12);
		this.debtn.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.debtn.Name = "debtn";
		this.debtn.Size = new global::System.Drawing.Size(94, 109);
		this.debtn.TabIndex = 49;
		this.debtn.Text = "Decompile";
		this.debtn.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
		this.debtn.UseVisualStyleBackColor = true;
		this.debtn.Click += new global::System.EventHandler(this.Button2_Click);
		this.savebtn.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
		this.savebtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.savebtn.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
		this.savebtn.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
		this.savebtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.savebtn.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.savebtn.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.savebtn.Location = new global::System.Drawing.Point(12, 12);
		this.savebtn.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.savebtn.Name = "savebtn";
		this.savebtn.Size = new global::System.Drawing.Size(94, 109);
		this.savebtn.TabIndex = 46;
		this.savebtn.Text = "Save icon";
		this.savebtn.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
		this.savebtn.UseVisualStyleBackColor = true;
		this.savebtn.Click += new global::System.EventHandler(this.Button1_Click);
		this.apkicon.Location = new global::System.Drawing.Point(8, 155);
		this.apkicon.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.apkicon.Name = "apkicon";
		this.apkicon.Size = new global::System.Drawing.Size(94, 84);
		this.apkicon.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.apkicon.TabIndex = 0;
		this.apkicon.TabStop = false;
		this.BackgroundWorker1.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
		this.Label1.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.Label1.Font = new global::System.Drawing.Font("Calibri", 7.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new global::System.Drawing.Point(0, 0);
		this.Label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new global::System.Drawing.Size(572, 16);
		this.Label1.TabIndex = 46;
		this.Label1.Text = "Craxs Rat Apk Studio";
		this.protectworker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.Protectworker_DoWork);
		this.deworker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.Deworker_DoWork);
		this.COworker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.COworker_DoWork);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.Black;
		base.ClientSize = new global::System.Drawing.Size(572, 511);
		base.Controls.Add(this.workpanel);
		base.Controls.Add(this.toppanel);
		base.Controls.Add(this.Label1);
		this.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		base.Name = "Apk_studio";
		this.Text = "Apk Studio";
		this.toppanel.ResumeLayout(false);
		this.workpanel.ResumeLayout(false);
		this.Panel1.ResumeLayout(false);
		this.titlespanel.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.apkicon).EndInit();
		base.ResumeLayout(false);
	}

	// Token: 0x040000D7 RID: 215
	private global::System.ComponentModel.IContainer components;

	// Token: 0x040000DE RID: 222
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("toppanel")]
	internal global::System.Windows.Forms.Panel toppanel;

	// Token: 0x040000DF RID: 223
	internal global::DrakeUI.Framework.DrakeUITextBox TargetApktext;

	// Token: 0x040000E0 RID: 224
	internal global::System.Windows.Forms.Button selectapkbtn;

	// Token: 0x040000E1 RID: 225
	internal global::System.Windows.Forms.Panel workpanel;

	// Token: 0x040000E2 RID: 226
	internal global::System.Windows.Forms.Button savebtn;

	// Token: 0x040000E3 RID: 227
	internal global::System.Windows.Forms.PictureBox apkicon;

	// Token: 0x040000E4 RID: 228
	internal global::System.ComponentModel.BackgroundWorker BackgroundWorker1;

	// Token: 0x040000E5 RID: 229
	internal global::System.Windows.Forms.Label Label1;

	// Token: 0x040000E6 RID: 230
	internal global::System.Windows.Forms.Button debtn;

	// Token: 0x040000E7 RID: 231
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("workdirtext")]
	internal global::DrakeUI.Framework.DrakeUITextBox workdirtext;

	// Token: 0x040000E8 RID: 232
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label2")]
	internal global::System.Windows.Forms.Label Label2;

	// Token: 0x040000E9 RID: 233
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("titlespanel")]
	internal global::System.Windows.Forms.Panel titlespanel;

	// Token: 0x040000EA RID: 234
	internal global::System.Windows.Forms.Label pkgtext;

	// Token: 0x040000EB RID: 235
	internal global::System.Windows.Forms.Label nametext;

	// Token: 0x040000EC RID: 236
	internal global::System.Windows.Forms.Label andfromtext;

	// Token: 0x040000ED RID: 237
	internal global::System.Windows.Forms.Label vernamtext;

	// Token: 0x040000EE RID: 238
	internal global::System.Windows.Forms.Label vercodtext;

	// Token: 0x040000EF RID: 239
	internal global::System.Windows.Forms.Label andtotext;

	// Token: 0x040000F0 RID: 240
	internal global::System.Windows.Forms.Button sinbtn;

	// Token: 0x040000F1 RID: 241
	internal global::System.Windows.Forms.Button cobtn;

	// Token: 0x040000F2 RID: 242
	internal global::System.Windows.Forms.Button probtn;

	// Token: 0x040000F3 RID: 243
	internal global::System.ComponentModel.BackgroundWorker protectworker;

	// Token: 0x040000F4 RID: 244
	internal global::System.ComponentModel.BackgroundWorker deworker;

	// Token: 0x040000F5 RID: 245
	internal global::System.ComponentModel.BackgroundWorker COworker;

	// Token: 0x040000F6 RID: 246
	internal global::System.Windows.Forms.Panel Panel1;

	// Token: 0x040000F7 RID: 247
	internal global::System.Windows.Forms.RichTextBox logtext;
}
