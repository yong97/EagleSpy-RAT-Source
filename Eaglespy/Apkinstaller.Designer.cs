// Token: 0x02000025 RID: 37
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class Apkinstaller : global::System.Windows.Forms.Form
{
	// Token: 0x06000188 RID: 392 RVA: 0x0000E370 File Offset: 0x0000C570
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

	// Token: 0x06000189 RID: 393 RVA: 0x0000E3B4 File Offset: 0x0000C5B4
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.Panel1 = new global::System.Windows.Forms.Panel();
		this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
		this.Panel2 = new global::System.Windows.Forms.Panel();
		this.LinkLabel1 = new global::System.Windows.Forms.LinkLabel();
		this.DrakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.Label1 = new global::System.Windows.Forms.Label();
		this.Panel1.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.Panel2.SuspendLayout();
		base.SuspendLayout();
		this.Panel1.Controls.Add(this.PictureBox1);
		this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.Panel1.Location = new global::System.Drawing.Point(0, 0);
		this.Panel1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new global::System.Drawing.Size(614, 501);
		this.Panel1.TabIndex = 0;
		this.PictureBox1.Location = new global::System.Drawing.Point(86, 33);
		this.PictureBox1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new global::System.Drawing.Size(451, 416);
		this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 0;
		this.PictureBox1.TabStop = false;
		this.Panel2.Controls.Add(this.LinkLabel1);
		this.Panel2.Controls.Add(this.DrakeUIButtonIcon1);
		this.Panel2.Controls.Add(this.Label1);
		this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Location = new global::System.Drawing.Point(0, 466);
		this.Panel2.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new global::System.Drawing.Size(614, 35);
		this.Panel2.TabIndex = 1;
		this.LinkLabel1.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.LinkLabel1.Font = new global::System.Drawing.Font("Calibri", 9f);
		this.LinkLabel1.Location = new global::System.Drawing.Point(211, 0);
		this.LinkLabel1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.LinkLabel1.Name = "LinkLabel1";
		this.LinkLabel1.Size = new global::System.Drawing.Size(55, 35);
		this.LinkLabel1.TabIndex = 3;
		this.LinkLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.LinkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
		this.DrakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.DrakeUIButtonIcon1.FillColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
		this.DrakeUIButtonIcon1.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon1.Location = new global::System.Drawing.Point(525, 0);
		this.DrakeUIButtonIcon1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
		this.DrakeUIButtonIcon1.RectColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
		this.DrakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.Size = new global::System.Drawing.Size(89, 35);
		this.DrakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.Symbol = 61537;
		this.DrakeUIButtonIcon1.TabIndex = 2;
		this.DrakeUIButtonIcon1.Text = "Next";
		this.Label1.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.Label1.Font = new global::System.Drawing.Font("Calibri", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = global::System.Drawing.Color.White;
		this.Label1.Location = new global::System.Drawing.Point(0, 0);
		this.Label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new global::System.Drawing.Size(211, 35);
		this.Label1.TabIndex = 1;
		this.Label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.Black;
		base.ClientSize = new global::System.Drawing.Size(614, 501);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel1);
		base.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		base.Name = "Apkinstaller";
		this.Text = "Apkinstaller";
		this.Panel1.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.Panel2.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	// Token: 0x040000CF RID: 207
	private global::System.ComponentModel.IContainer components;

	// Token: 0x040000D1 RID: 209
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel1")]
	internal global::System.Windows.Forms.Panel Panel1;

	// Token: 0x040000D2 RID: 210
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("PictureBox1")]
	internal global::System.Windows.Forms.PictureBox PictureBox1;

	// Token: 0x040000D3 RID: 211
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel2")]
	internal global::System.Windows.Forms.Panel Panel2;

	// Token: 0x040000D4 RID: 212
	internal global::System.Windows.Forms.LinkLabel LinkLabel1;

	// Token: 0x040000D5 RID: 213
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("DrakeUIButtonIcon1")]
	internal global::DrakeUI.Framework.DrakeUIButtonIcon DrakeUIButtonIcon1;

	// Token: 0x040000D6 RID: 214
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label1")]
	internal global::System.Windows.Forms.Label Label1;
}
