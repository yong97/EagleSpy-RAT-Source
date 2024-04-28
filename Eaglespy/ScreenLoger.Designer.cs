// Token: 0x020000B4 RID: 180
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class ScreenLoger : global::System.Windows.Forms.Form
{
	// Token: 0x06000785 RID: 1925 RVA: 0x000B263C File Offset: 0x000B083C
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

	// Token: 0x06000786 RID: 1926 RVA: 0x000B2680 File Offset: 0x000B0880
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.Logs = new global::System.Windows.Forms.TextBox();
		base.SuspendLayout();
		this.Logs.BackColor = global::System.Drawing.Color.Black;
		this.Logs.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
		this.Logs.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.Logs.Font = new global::System.Drawing.Font("Microsoft PhagsPa", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.Logs.ForeColor = global::System.Drawing.Color.White;
		this.Logs.Location = new global::System.Drawing.Point(0, 0);
		this.Logs.Multiline = true;
		this.Logs.Name = "Logs";
		this.Logs.ReadOnly = true;
		this.Logs.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
		this.Logs.Size = new global::System.Drawing.Size(524, 601);
		this.Logs.TabIndex = 0;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(524, 601);
		base.ControlBox = false;
		base.Controls.Add(this.Logs);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "ScreenLoger";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		this.Text = "ScreenLoger";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000AB9 RID: 2745
	private global::System.ComponentModel.IContainer components;

	// Token: 0x04000ABA RID: 2746
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Logs")]
	internal global::System.Windows.Forms.TextBox Logs;
}
