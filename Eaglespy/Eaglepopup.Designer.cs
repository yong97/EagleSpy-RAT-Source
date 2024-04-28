// Token: 0x02000056 RID: 86
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class Eaglepopup : global::System.Windows.Forms.Form
{
	// Token: 0x060003B2 RID: 946 RVA: 0x00055A10 File Offset: 0x00053C10
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

	// Token: 0x060003B3 RID: 947 RVA: 0x00055A54 File Offset: 0x00053C54
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new global::System.ComponentModel.Container();
		this.Panel1 = new global::System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon2 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.checkbutton = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel2 = new global::System.Windows.Forms.Panel();
		this.Panel3 = new global::System.Windows.Forms.Panel();
		this.Panel4 = new global::System.Windows.Forms.Panel();
		this.Panel5 = new global::System.Windows.Forms.Panel();
		this.notifitext = new global::System.Windows.Forms.TextBox();
		this.ToolTips = new global::DrakeUI.Framework.DrakeUIToolTip(this.components);
		this.Panel1.SuspendLayout();
		this.Panel5.SuspendLayout();
		base.SuspendLayout();
		this.Panel1.BackColor = global::System.Drawing.Color.Transparent;
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon2);
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon1);
		this.Panel1.Controls.Add(this.checkbutton);
		this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.Panel1.Location = new global::System.Drawing.Point(0, 0);
		this.Panel1.Margin = new global::System.Windows.Forms.Padding(2);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new global::System.Drawing.Size(365, 108);
		this.Panel1.TabIndex = 0;
		this.DrakeUIButtonIcon2.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon2.FillColor = global::System.Drawing.Color.Black;
		this.DrakeUIButtonIcon2.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon2.Location = new global::System.Drawing.Point(240, 78);
		this.DrakeUIButtonIcon2.Margin = new global::System.Windows.Forms.Padding(2);
		this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
		this.DrakeUIButtonIcon2.Radius = 15;
		this.DrakeUIButtonIcon2.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon2.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon2.Size = new global::System.Drawing.Size(54, 24);
		this.DrakeUIButtonIcon2.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon2.Symbol = 61544;
		this.DrakeUIButtonIcon2.TabIndex = 3;
		this.ToolTips.SetToolTip(this.DrakeUIButtonIcon2, "Hide");
		this.DrakeUIButtonIcon2.Click += new global::System.EventHandler(this.DrakeUIButtonIcon2_Click);
		this.DrakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.FillColor = global::System.Drawing.Color.Black;
		this.DrakeUIButtonIcon1.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon1.Location = new global::System.Drawing.Point(182, 78);
		this.DrakeUIButtonIcon1.Margin = new global::System.Windows.Forms.Padding(2);
		this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
		this.DrakeUIButtonIcon1.Radius = 15;
		this.DrakeUIButtonIcon1.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.Size = new global::System.Drawing.Size(54, 24);
		this.DrakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.StyleCustomMode = true;
		this.DrakeUIButtonIcon1.Symbol = 61639;
		this.DrakeUIButtonIcon1.TabIndex = 2;
		this.ToolTips.SetToolTip(this.DrakeUIButtonIcon1, "Save");
		this.DrakeUIButtonIcon1.Click += new global::System.EventHandler(this.DrakeUIButtonIcon1_Click);
		this.checkbutton.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.checkbutton.FillColor = global::System.Drawing.Color.Black;
		this.checkbutton.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.checkbutton.Location = new global::System.Drawing.Point(298, 78);
		this.checkbutton.Margin = new global::System.Windows.Forms.Padding(2);
		this.checkbutton.Name = "checkbutton";
		this.checkbutton.Radius = 15;
		this.checkbutton.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.checkbutton.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.checkbutton.Size = new global::System.Drawing.Size(54, 24);
		this.checkbutton.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.checkbutton.Symbol = 61453;
		this.checkbutton.TabIndex = 1;
		this.ToolTips.SetToolTip(this.checkbutton, "Clear & Close");
		this.checkbutton.Click += new global::System.EventHandler(this.Checkbutton_Click);
		this.Panel2.BackColor = global::System.Drawing.Color.Transparent;
		this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.Panel2.Location = new global::System.Drawing.Point(0, 108);
		this.Panel2.Margin = new global::System.Windows.Forms.Padding(2);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new global::System.Drawing.Size(13, 233);
		this.Panel2.TabIndex = 1;
		this.Panel3.BackColor = global::System.Drawing.Color.Transparent;
		this.Panel3.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.Panel3.Location = new global::System.Drawing.Point(352, 108);
		this.Panel3.Margin = new global::System.Windows.Forms.Padding(2);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new global::System.Drawing.Size(13, 233);
		this.Panel3.TabIndex = 2;
		this.Panel4.BackColor = global::System.Drawing.Color.Transparent;
		this.Panel4.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.Panel4.Location = new global::System.Drawing.Point(13, 324);
		this.Panel4.Margin = new global::System.Windows.Forms.Padding(2);
		this.Panel4.Name = "Panel4";
		this.Panel4.Size = new global::System.Drawing.Size(339, 17);
		this.Panel4.TabIndex = 3;
		this.Panel5.BackColor = global::System.Drawing.Color.Black;
		this.Panel5.Controls.Add(this.notifitext);
		this.Panel5.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.Panel5.Location = new global::System.Drawing.Point(13, 108);
		this.Panel5.Margin = new global::System.Windows.Forms.Padding(2);
		this.Panel5.Name = "Panel5";
		this.Panel5.Size = new global::System.Drawing.Size(339, 216);
		this.Panel5.TabIndex = 4;
		this.notifitext.BackColor = global::System.Drawing.Color.Black;
		this.notifitext.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
		this.notifitext.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.notifitext.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.notifitext.ForeColor = global::System.Drawing.Color.White;
		this.notifitext.Location = new global::System.Drawing.Point(0, 0);
		this.notifitext.Multiline = true;
		this.notifitext.Name = "notifitext";
		this.notifitext.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
		this.notifitext.Size = new global::System.Drawing.Size(339, 216);
		this.notifitext.TabIndex = 2;
		this.notifitext.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
		this.ToolTips.BackColor = global::System.Drawing.Color.Black;
		this.ToolTips.ForeColor = global::System.Drawing.Color.White;
		this.ToolTips.OwnerDraw = true;
		this.ToolTips.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.DarkRed;
		this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
		base.ClientSize = new global::System.Drawing.Size(365, 341);
		base.Controls.Add(this.Panel5);
		base.Controls.Add(this.Panel4);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel1);
		this.DoubleBuffered = true;
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(2);
		base.Name = "Eaglepopup";
		this.Text = "Notification";
		this.Panel1.ResumeLayout(false);
		this.Panel5.ResumeLayout(false);
		this.Panel5.PerformLayout();
		base.ResumeLayout(false);
	}

	// Token: 0x04000429 RID: 1065
	private global::System.ComponentModel.IContainer components;

	// Token: 0x0400042E RID: 1070
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel1")]
	internal global::System.Windows.Forms.Panel Panel1;

	// Token: 0x0400042F RID: 1071
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel2")]
	internal global::System.Windows.Forms.Panel Panel2;

	// Token: 0x04000430 RID: 1072
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel3")]
	internal global::System.Windows.Forms.Panel Panel3;

	// Token: 0x04000431 RID: 1073
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel4")]
	internal global::System.Windows.Forms.Panel Panel4;

	// Token: 0x04000432 RID: 1074
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel5")]
	internal global::System.Windows.Forms.Panel Panel5;

	// Token: 0x04000433 RID: 1075
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("notifitext")]
	internal global::System.Windows.Forms.TextBox notifitext;

	// Token: 0x04000434 RID: 1076
	internal global::DrakeUI.Framework.DrakeUIButtonIcon checkbutton;

	// Token: 0x04000435 RID: 1077
	internal global::DrakeUI.Framework.DrakeUIButtonIcon DrakeUIButtonIcon1;

	// Token: 0x04000436 RID: 1078
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("ToolTips")]
	internal global::DrakeUI.Framework.DrakeUIToolTip ToolTips;

	// Token: 0x04000437 RID: 1079
	internal global::DrakeUI.Framework.DrakeUIButtonIcon DrakeUIButtonIcon2;
}
