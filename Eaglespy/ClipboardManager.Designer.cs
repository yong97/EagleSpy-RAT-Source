// Token: 0x02000042 RID: 66
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class ClipboardManager : global::System.Windows.Forms.Form
{
	// Token: 0x060002F0 RID: 752 RVA: 0x0004D8B8 File Offset: 0x0004BAB8
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

	// Token: 0x060002F1 RID: 753 RVA: 0x0004D8FC File Offset: 0x0004BAFC
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new global::System.ComponentModel.Container();
		this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
		this.Panel1 = new global::System.Windows.Forms.Panel();
		this.label1 = new global::System.Windows.Forms.Label();
		this.BoxClipboard = new global::System.Windows.Forms.TextBox();
		this.BTN_SET = new global::System.Windows.Forms.Button();
		this.BTN_GET = new global::System.Windows.Forms.Button();
		this.Panel1.SuspendLayout();
		base.SuspendLayout();
		this.TOpacity.Interval = 1;
		this.TOpacity.Tick += new global::System.EventHandler(this.TOpacity_Tick);
		this.Panel1.BackColor = global::System.Drawing.Color.Black;
		this.Panel1.Controls.Add(this.label1);
		this.Panel1.Controls.Add(this.BoxClipboard);
		this.Panel1.Controls.Add(this.BTN_SET);
		this.Panel1.Controls.Add(this.BTN_GET);
		this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.Panel1.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		this.Panel1.Location = new global::System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new global::System.Drawing.Size(451, 281);
		this.Panel1.TabIndex = 3;
		this.Panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
		this.label1.AutoSize = true;
		this.label1.Font = new global::System.Drawing.Font("Bahnschrift SemiBold", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label1.ForeColor = global::System.Drawing.Color.Red;
		this.label1.Location = new global::System.Drawing.Point(99, 14);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(185, 25);
		this.label1.TabIndex = 4;
		this.label1.Text = "Clipboard Changer";
		this.BoxClipboard.BackColor = global::System.Drawing.Color.Black;
		this.BoxClipboard.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.BoxClipboard.ForeColor = global::System.Drawing.Color.White;
		this.BoxClipboard.Location = new global::System.Drawing.Point(19, 51);
		this.BoxClipboard.Multiline = true;
		this.BoxClipboard.Name = "BoxClipboard";
		this.BoxClipboard.Size = new global::System.Drawing.Size(412, 163);
		this.BoxClipboard.TabIndex = 0;
		this.BTN_SET.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.BTN_SET.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.BTN_SET.ForeColor = global::System.Drawing.Color.Red;
		this.BTN_SET.Location = new global::System.Drawing.Point(271, 225);
		this.BTN_SET.Name = "BTN_SET";
		this.BTN_SET.Size = new global::System.Drawing.Size(153, 48);
		this.BTN_SET.TabIndex = 3;
		this.BTN_SET.Text = "SET";
		this.BTN_SET.UseVisualStyleBackColor = true;
		this.BTN_SET.Click += new global::System.EventHandler(this.BTN_SET_Click);
		this.BTN_GET.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.BTN_GET.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.BTN_GET.ForeColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
		this.BTN_GET.Location = new global::System.Drawing.Point(34, 225);
		this.BTN_GET.Name = "BTN_GET";
		this.BTN_GET.Size = new global::System.Drawing.Size(145, 48);
		this.BTN_GET.TabIndex = 1;
		this.BTN_GET.Text = "GET";
		this.BTN_GET.UseVisualStyleBackColor = true;
		this.BTN_GET.Click += new global::System.EventHandler(this.BTN_GET_Click);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(451, 281);
		base.Controls.Add(this.Panel1);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		this.MaximumSize = new global::System.Drawing.Size(467, 320);
		this.MinimumSize = new global::System.Drawing.Size(467, 320);
		base.Name = "ClipboardManager";
		base.Opacity = 0.0;
		this.Text = "ClipboardManager";
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		base.ResumeLayout(false);
	}

	// Token: 0x04000393 RID: 915
	private global::System.ComponentModel.IContainer components;

	// Token: 0x0400039C RID: 924
	internal global::System.Windows.Forms.Timer TOpacity;

	// Token: 0x0400039D RID: 925
	internal global::System.Windows.Forms.Panel Panel1;

	// Token: 0x0400039E RID: 926
	internal global::System.Windows.Forms.Button BTN_GET;

	// Token: 0x0400039F RID: 927
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("BoxClipboard")]
	internal global::System.Windows.Forms.TextBox BoxClipboard;

	// Token: 0x040003A0 RID: 928
	private global::System.Windows.Forms.Label label1;

	// Token: 0x040003A1 RID: 929
	internal global::System.Windows.Forms.Button BTN_SET;
}
